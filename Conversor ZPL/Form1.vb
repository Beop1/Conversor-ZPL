Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.ComponentModel
Imports System.Web.Script.Serialization
Imports System.Collections.Specialized
Imports System.IO.Compression
Imports System.IO.Path
Imports System.Windows.Forms


'A FAZER:
'
' Corrigir preview
'   O PREVIEW NAO FUNCIONA SE AS PAGINAS TIVEREM ^PQ, POIS ELE NAO ESTÁ CONTANDO AS PAGINAS REPETIDAS
'
' Pré-definições
'   Salvá-las em um arquivo TXT na pasta do aplicativo
'   Poder criar novas e salvar
' 
' Salvar configurações na pasta do aplicativo ao sair
'
' Opções avançadas do labelary:
'   Múltiplas etiquetas por página (por exemplo para 2 colunas)
'   Alinhamento H e V das etiquetas
'   

Public Class Form1

    Const Max_pages_per_request = 50

    Structure struct_preset

        Dim nome As String
        Dim ordenar_por As String
        Dim ordenar_ordem As String
        Dim DPI As String
        Dim largura As Decimal
        Dim altura As Decimal
        Dim unidade As String

    End Structure

    Dim arquivos_adicionados As New List(Of String)
    Dim contagem_total As Integer = 0
    Dim lista_paginas_completa As New List(Of String), lista_Ordenada As New List(Of String)
    Dim lista_imagens As New Dictionary(Of String, Image)
    Private appSettingsChanged As Boolean
    Private connectionString As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbDPI.SelectedIndex = 1
        cbUnidade.SelectedIndex = 1
        cbOrdenar_por.SelectedIndex = 0

        Atualizar_Lista_Presets()

    End Sub

    Private Sub Atualizar_Lista_Presets()

        cbPresets.Items.Clear()

        Adicionar_Presets(My.Settings.presets_app)
        Adicionar_Presets((My.Settings.presets_user))
    End Sub

    Private Sub Adicionar_Presets(presets As StringCollection)


        For Each p In presets

            With New JavaScriptSerializer().Deserialize(Of struct_preset)(p)
                cbPresets.Items.Add(New DictionaryEntry(.nome, p))
            End With

        Next

        With cbPresets
            .DisplayMember = "Key"
            .ValueMember = "Value"
        End With

    End Sub

    Private Sub Carregar_Presets(preset As String)

        With New JavaScriptSerializer().Deserialize(Of struct_preset)(preset)
            cbOrdenar_por.SelectedItem = .ordenar_por
            cbOrdenar_ordem.SelectedItem = .ordenar_ordem
            cbDPI.SelectedItem = .DPI
            txtLargura.Text = .largura
            txtAltura.Text = .altura
            cbUnidade.SelectedItem = .unidade
        End With

    End Sub

    Private Sub Excluir_Preset(preset As String)
        Dim p As String
        For Each p In My.Settings.presets_user
            If p = preset Then
                My.Settings.presets_user.Remove(preset)
                Exit For
            End If
        Next

    End Sub

    Private Sub btnAddArquivo_Click(sender As Object, e As EventArgs) Handles btnAddArquivo.Click

        Dim arquivo As String
        Dim openFileDialog1 As New OpenFileDialog() With
        {
           .FileName = "Selecione o arquivo",
           .Filter = "Arquivos ZPL|*.txt;*.zpl;*.zip",
           .Title = "Abrir arquivo"
        }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            arquivo = openFileDialog1.FileName
            arquivos_adicionados.Add(arquivo)

            If Path.GetExtension(arquivo) = ".zip" Then

                Using arquivo_zip = ZipFile.Open(arquivo, ZipArchiveMode.Read)
                    Dim arquivo_do_zip As ZipArchiveEntry

                    For Each arquivo_do_zip In arquivo_zip.Entries.Where(Function(x) x.Name.Contains(".txt"))
                        Dim sr As New StreamReader(arquivo_do_zip.Open())
                        Adicionar_arquivo(sr.ReadToEnd())
                        sr.Close()
                    Next

                End Using

            Else
                Adicionar_arquivo(System.IO.File.ReadAllText(arquivo))
            End If

        End If

    End Sub

    Public Sub Adicionar_arquivo(conteudo As String)
        Dim tmp As String
        Dim paginas As List(Of String)

        tmp = conteudo
        tmp = Replace(tmp, "^XA^MCY^XZ", "")
        tmp = Replace(tmp, "^XA", "<####NOVA_PAGINA####>^XA")
        paginas = Split(tmp, "<####NOVA_PAGINA####>",, CompareMethod.Text).ToList

        'Remover páginas vazias
        paginas.RemoveAll(Function(p) p = "")

        lista_paginas_completa.AddRange(paginas)
        gerar_lista_ordenada()

        txtStatus.Text = "Arquivos: " & arquivos_adicionados.Count & vbNewLine &
                             "Total de páginas: " & contagem_total.ToString() & vbNewLine &
                             "Arquivos abertos: " & vbNewLine &
                             Join(arquivos_adicionados.ToArray(), vbNewLine)
        '"Quantidade de arquivos (PDF): " & grupos.Count() & vbNewLine & vbNewLine &

    End Sub

    Private Sub btnSalvarPDF_Click(sender As Object, e As EventArgs) Handles btnSalvarPDF.Click
        Dim arquivo As String

        'Perguntar ao usuário o nome do arquivo
        arquivo = Salvar_Como("Etiquetas.pdf", "Adobe Acrobat PDF|*.pdf")
        If arquivo = "" Then Exit Sub 'Cancelado

        arquivo = Gerar_PDF_Mesclado(arquivo)
        If arquivo = "" Then
            MsgBox("Falha ao criar o arquivo PDF", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        'Abrir pasta do arquivo
        'Process.Start(Path.GetDirectoryName(arquivo))

    End Sub

    Private Sub btnAbrirPDF_Click(sender As Object, e As EventArgs) Handles btnAbrirPDF.Click
        Dim arquivo As String

        arquivo = Gerar_PDF_Mesclado()
        If arquivo = "" Then
            MsgBox("Falha ao criar o arquivo PDF", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        'Abrir arquivo criado
        Try
            Process.Start("acrobat", arquivo)
        Catch ex As Exception
            Try
                Process.Start("AcroRd32", arquivo)
            Catch ex2 As Exception
                Try
                    Process.Start(arquivo)
                Catch ex3 As Exception
                    MsgBox("É necessário instalar o Acrobat Reader", vbOKOnly + vbInformation)
                End Try
            End Try
        End Try
    End Sub

    Public Function Gerar_PDF_Mesclado(Optional arquivo_destino As String = "") As String
        Dim proximo_arquivo As String
        Dim pagina As String
        Dim PDFs_grupos As New List(Of String)

        For Each grupo In gerar_grupos()

            'Gerar uma string com todo o conteúdo do grupo
            pagina = String.Join("", grupo.ToArray())

            'proximo_arquivo = Criar um nome de arquivo único temporário
            proximo_arquivo = GetTempFileName() & ".pdf"
            If Not Converter_ZPL_para_PDF(pagina, proximo_arquivo, Dimensoes_Etiqueta) Then proximo_arquivo = ""

            'Adicionar à lista de PDFs dos grupos
            PDFs_grupos.Add(proximo_arquivo)
        Next

        'se nao for especificado o arquivo de destino, criar um temporário
        If arquivo_destino = "" Then arquivo_destino = GetTempFileName() & ".pdf"
        File.Delete(arquivo_destino)

        If PDFs_grupos.Count = 1 Then
            'Se só tiver 1 grupo, é só copiar o PDF criado
            File.Copy(PDFs_grupos(0), arquivo_destino, True)
        Else
            'Mais de 1 grupo, mesclar PDFs em 1 arquivo só
            Merge_PDF_Files(PDFs_grupos, arquivo_destino)

            'Merge_PDF_Files(PDFs_grupos, arquivo_destino)
            'Excluir arquivos temporários
            For Each proximo_arquivo In PDFs_grupos
                File.Delete(proximo_arquivo)
            Next

        End If

        If File.Exists(arquivo_destino) Then Return arquivo_destino Else Return ""

    End Function

    Private Function Dimensoes_Etiqueta() As struct_dimensoes_etiqueta
        With Dimensoes_Etiqueta
            .DPI = cbDPI.SelectedIndex
            .largura = txtLargura.Text
            .altura = txtAltura.Text
            .unidade = cbUnidade.Text
        End With
    End Function

    Public Sub Gerar_preview(Optional indice As Integer = -1, Optional exibir_no_preview As Boolean = True)

        Dim pagina As String

        If lista_Ordenada.Count = 0 Then
            limpar_preview()
            Exit Sub
        End If

        If indice = -1 Then indice = NumericUpDown1.Value - 1

        pagina = lista_Ordenada(indice)

        'substituir o PQ por 1 para contar apenas como 1 pagina no list view
        pagina = Replace(pagina, "^PQ" & lvPreview_lista.Items(indice).SubItems(1).Text, "^PQ1",,, CompareMethod.Text)
        Try
            If Not lista_imagens.ContainsKey(pagina) Then

                lista_imagens.Add(pagina, Image.FromStream(Converter_ZPL_para_Stream(pagina, 0, Dimensoes_Etiqueta)))
            End If

            If exibir_no_preview Then pictureboxPreview.Image = lista_imagens(pagina)
        Catch ex As Exception
            If exibir_no_preview Then pictureboxPreview.Image = Nothing
        End Try

        lblTotal_Paginas.Text = contagem_total

    End Sub

    Public Sub limpar_preview()
        pictureboxPreview.Image = Nothing

        hsbPreview.Maximum = 1
        hsbPreview.Value = 1

        NumericUpDown1.Maximum = 1
        NumericUpDown1.Value = 1
        NumericUpDown1.Text = 1

        lblPreviewPaginas.Text = "0"
    End Sub

    Public Sub Limpar_Dados()
        arquivos_adicionados.Clear()
        lista_paginas_completa.Clear()
        lista_Ordenada.Clear()
        lista_imagens.Clear()

        lblTotal_Paginas.text = "0"
        txtStatus.Text = ""
        limpar_preview()
    End Sub

    Private Function numero_da_venda(pagina As String) As String
        Dim tmp As String
        Dim numVenda As String = ""

        'Pegar o numero da venda
        If pagina.Contains("Venda: ") Then
            tmp = Split(pagina, "Venda: ", 2, CompareMethod.Text)(1)
            numVenda = Split(tmp, "^", 2, CompareMethod.Text)(0)
            tmp = Split(tmp, "FD", 2, CompareMethod.Text)(1)
            numVenda += Split(tmp, "^", 2, CompareMethod.Text)(0)
        ElseIf pagina.Contains("Pack ID: ") Then
            tmp = Split(pagina, "Pack ID: ", 2, CompareMethod.Text)(1)
            numVenda = Split(tmp, "^", 2, CompareMethod.Text)(0)
            tmp = Split(tmp, "FD", 2, CompareMethod.Text)(1)
            numVenda += Split(tmp, "^", 2, CompareMethod.Text)(0)
        End If

        Return numVenda
    End Function

    Private Function id_do_frete(pagina As String) As String
        Dim numID As String

        'Pegar a 1a metade do numero da venda
        Try
            numID = Split(pagina, "{""id"":""", 2, CompareMethod.Text)(1)
            numID = Split(numID, """", 2)(0)
        Catch ex As System.IndexOutOfRangeException
            numID = ""
        End Try

        Return numID
    End Function

    Private Function gerar_chave_de_ordenamento(pagina As String) As String

        Dim chave As String = 0

        Select Case cbOrdenar_por.SelectedIndex
            Case 0  ' sem ordenamento
                chave = pagina
            Case 1  ' ID do frete
                chave = id_do_frete(pagina)
            Case 2  ' Número da venda
                chave = numero_da_venda(pagina)
        End Select

        If cbOrdenar_ordem.SelectedIndex = 2 Then
            'Ordenar por lista
            Dim tmp As String

            If txtOrdenar_lista.Text.Contains(chave) Then
                tmp = Split(txtOrdenar_lista.Text, chave,, CompareMethod.Text)(0)

                chave = UBound(tmp.Split(vbNewLine)) + 1
            Else
                chave = Integer.MaxValue
            End If
        End If
        Return chave

    End Function

    Private Sub gerar_lista_ordenada()

        Dim numero_de_copias As Integer, slots_Vagos As Integer
        Dim pagina As String
        Dim arr As String() = New String(4) {}
        Dim itm As ListViewItem

        slots_Vagos = Max_pages_per_request

        Select Case cbOrdenar_ordem.SelectedIndex
            Case -1 'Sem ordenamento
                'lista_Ordenada = From p In lista_paginas_completa
                lista_Ordenada = lista_paginas_completa
            Case 0  ' Crescente
                lista_Ordenada = lista_paginas_completa.OrderBy(Function(p) gerar_chave_de_ordenamento(p)).ToList
            Case 1  ' Decrescente
                lista_Ordenada = lista_paginas_completa.OrderByDescending(Function(p) gerar_chave_de_ordenamento(p)).ToList
            Case 2  ' Por lista
                lista_Ordenada = lista_paginas_completa

                If Not chkOrdenar_Incluir.Checked Then lista_Ordenada = lista_Ordenada.Where(Function(p) gerar_chave_de_ordenamento(p) <> Integer.MaxValue).ToList
                lista_Ordenada = lista_Ordenada.OrderBy(Function(p) gerar_chave_de_ordenamento(p)).ToList

        End Select

        'gerar lista de paginas do painel de preview

        'Adicionar cabeçalhos baseado no tipo de pre-definição / tipo de arquivo
        With lvPreview_lista.Columns
            .Clear()
            .Add("Etiqueta", 45, HorizontalAlignment.Center)
            .Add("Cópias", 45, HorizontalAlignment.Left)
            .Add("Nº Venda", 77, HorizontalAlignment.Right)
            .Add("ID Frete", 77, HorizontalAlignment.Right)
        End With

        lvPreview_lista.Items.Clear()
        contagem_total = 0

        For Each pagina In lista_Ordenada

            numero_de_copias = Copias_por_pagina(pagina)

            'Iterar todos os itens da lista_ordenada e adicionar no painel
            'add items to ListView

            arr(0) = (lista_Ordenada.IndexOf(pagina) + 1)
            arr(1) = numero_de_copias
            arr(2) = numero_da_venda(pagina)
            arr(3) = id_do_frete(pagina)
            itm = New ListViewItem(arr)

            lvPreview_lista.Items.Add(itm)
            contagem_total += numero_de_copias
        Next

        If lista_Ordenada.Count > 0 Then
            hsbPreview.Maximum = lista_Ordenada.Count()
            NumericUpDown1.Maximum = lista_Ordenada.Count()
            lblPreviewPaginas.Text = lista_Ordenada.Count()
        End If

        Gerar_preview()

        'If BackgroundWorker1.IsBusy Then

        '    BackgroundWorker1.CancelAsync()
        '    Do
        '        Application.DoEvents()
        '    Loop Until BackgroundWorker1.CancellationPending = False
        'End If

        'BackgroundWorker1.RunWorkerAsync(Me)

    End Sub

    Private Function gerar_grupos() As List(Of List(Of String))

        Dim numero_de_copias As Integer, intTmp As Integer, slots_Vagos As Integer
        Dim pagina As String
        Dim arr As String() = New String(4) {}
        Dim grupo As New List(Of String)
        Dim grupos As New List(Of List(Of String))

        grupos.Clear()

        slots_Vagos = Max_pages_per_request

        For Each pagina In lista_Ordenada

            numero_de_copias = Copias_por_pagina(pagina)

            If numero_de_copias > 0 Then

                Dim numero_de_copias_Sobrando As Integer
                numero_de_copias_Sobrando = numero_de_copias

                Do
                    If slots_Vagos > 0 Then

                        Do
                            intTmp = Math.Min(slots_Vagos, numero_de_copias_Sobrando)
                            grupo.Add(Replace(pagina, "^PQ" & numero_de_copias, "^PQ" & intTmp.ToString(),,, CompareMethod.Text))

                            slots_Vagos -= intTmp
                            numero_de_copias_Sobrando = numero_de_copias_Sobrando - intTmp

                        Loop Until slots_Vagos = 0 Or numero_de_copias_Sobrando = 0

                    Else

                        grupos.Add(grupo)
                        grupo = New List(Of String)
                        slots_Vagos = Max_pages_per_request

                    End If

                Loop Until numero_de_copias_Sobrando = 0

                If slots_Vagos = 0 Then

                    grupos.Add(grupo)
                    grupo = New List(Of String)
                    slots_Vagos = Max_pages_per_request

                End If

            End If

        Next

        If grupo.Count > 0 Then grupos.Add(grupo)
        Return grupos
    End Function

    Private Function Copias_por_pagina(pagina As String) As Integer
        Dim strTmp As String
        Try
            'As próximas 2 linhas servem para extrair o número de cópias (PQ) do comando (Ex: ^PQ20^0,1,Y^XZ resulta em 20)
            strTmp = Split(pagina, "^PQ",, CompareMethod.Text)(1)
            Copias_por_pagina = Split(Replace(strTmp, ",", "^"), "^")(0)

        Catch ex As Exception
            Copias_por_pagina = 1
        End Try
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Dim i As Integer

        'For i = 0 To lista_Ordenada.Count - 1

        '    If BackgroundWorker1.CancellationPending Then
        '        e.Cancel = True
        '        Exit Sub
        '    End If

        '    Try
        '        If Not lista_imagens.ContainsKey(i) Then
        '            lista_imagens.Add(i, Image.FromStream(Converter_ZPL_para_Stream(lista_Ordenada(i), 0)))
        '        End If

        '        pictureboxPreview.Image = lista_imagens(i)
        '    Catch ex As Exception
        '        pictureboxPreview.Image = Nothing
        '    End Try
        'Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.txtStatus.Text = Me.txtStatus.Text & vbNewLine & "Gerado Preview de " & e.UserState()
    End Sub

    Private Sub cbDPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDPI.SelectedIndexChanged
        Gerar_preview()
    End Sub

    Private Sub txtLargura_TextChanged(sender As Object, e As EventArgs) Handles txtLargura.TextChanged
        Gerar_preview()
    End Sub

    Private Sub txtAltura_TextChanged(sender As Object, e As EventArgs) Handles txtAltura.TextChanged
        Gerar_preview()
    End Sub

    Private Sub cbUnidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUnidade.SelectedIndexChanged
        Gerar_preview()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar_Dados()
        lvPreview_lista.Items.Clear()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start(sender.Text)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start(sender.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        hsbPreview.Value = NumericUpDown1.Value
        Gerar_preview()
    End Sub

    Private Sub cbOrdenar_por_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOrdenar_por.SelectedIndexChanged
        If cbOrdenar_por.SelectedIndex = 0 Then
            cbOrdenar_ordem.SelectedIndex = -1
            cbOrdenar_ordem.Enabled = False
        Else
            cbOrdenar_ordem.Enabled = True
        End If

        gerar_lista_ordenada()
    End Sub

    Private Sub cbOrdenar_ordem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOrdenar_ordem.SelectedIndexChanged
        gerar_lista_ordenada()
    End Sub

    Private Sub chkOrdenar_Incluir_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrdenar_Incluir.CheckedChanged
        gerar_lista_ordenada()
    End Sub

    Private Sub txtOrdenar_lista_TextChanged(sender As Object, e As EventArgs) Handles txtOrdenar_lista.TextChanged
        gerar_lista_ordenada()
    End Sub

    Private Sub lvPreview_lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPreview_lista.SelectedIndexChanged

        If lvPreview_lista.SelectedItems.Count > 0 Then
            NumericUpDown1.Value = lvPreview_lista.SelectedItems(0).Index + 1
        End If
    End Sub

    Private Sub btnPresets_Salvar_Click(sender As Object, e As EventArgs) Handles btnPresets_Salvar.Click
        Dim strPreset As String
        Dim objPreset As struct_preset
        Dim indice As Integer

        With objPreset
            'se nao tiver nenhum item selecionado, salvar em um novo preset

            .nome = InputBox("Insira o nome para o preset: ", "Salvar pré-definição", cbPresets.Text)
            If .nome = "" Then Exit Sub
            'verificar se ja existe 
            indice = cbPresets.FindStringExact(.nome)
            'se existir perguntar se quer sobregravar
            If indice <> -1 Then
                If MsgBox("Um item com este nome já existe, deseja sobregravar?", vbYesNo + vbQuestion) = vbNo Then Exit Sub
                Excluir_Preset(cbPresets.Items(indice).value)
            End If


            .ordenar_por = cbOrdenar_por.Text
            .ordenar_ordem = cbOrdenar_ordem.Text
            .DPI = cbDPI.Text
            .largura = txtLargura.Text
            .altura = txtAltura.Text
            .unidade = cbUnidade.Text

            strPreset = New JavaScriptSerializer().Serialize(objPreset)
            My.Settings.presets_user.Add(strPreset)
            My.Settings.Save()

            Atualizar_Lista_Presets()
            cbPresets.SelectedIndex = cbPresets.FindStringExact(.nome)
        End With
    End Sub

    Private Sub btnPresets_Excluir_Click(sender As Object, e As EventArgs) Handles btnPresets_Excluir.Click
        If cbPresets.SelectedItem Is Nothing Then
            MsgBox("Nenhum item selecionado. Favor selecionar um item para ser excluído", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If MsgBox("Tem certeza que deseja excluir o item?", vbYesNo + vbQuestion) = vbNo Then Exit Sub
        Excluir_Preset(cbPresets.SelectedItem.value)
        Atualizar_Lista_Presets()

    End Sub

    Private Sub cbPresets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPresets.SelectedIndexChanged
        Carregar_Presets(cbPresets.SelectedItem.value)
        lista_imagens.Clear()
        Gerar_preview()
    End Sub

    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EToolStripMenuItem.Click
        Exportar_predefinicoes(My.Settings.presets_user, "ConversorZPL")
    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click

        Dim lista_excluir As New List(Of String)
        Dim lista_adicionar As New List(Of String)
        Dim dic_MySettings As New Dictionary(Of String, String)
        Dim p As StringCollection
        Dim serializer As JavaScriptSerializer = Nothing

        p = Importar_Predefinicoes("ConversorZPL")

        If p Is Nothing Then Exit Sub

        Dim noForAll As Boolean = False, yesForAll As Boolean = False
        Dim box As New CustomBox()

        serializer = New JavaScriptSerializer()

        For Each preset As String In p

            Dim addPreset As Boolean 'boolean para verificar se o preset em questão deve ser adicionado
            Dim indice As New Integer
            Dim struct_do_preset As struct_preset

            struct_do_preset = serializer.Deserialize(Of struct_preset)(preset)

            For Each user_preset As String In My.Settings.presets_user

                Dim struct_do_User_preset As struct_preset
                struct_do_User_preset = serializer.Deserialize(Of struct_preset)(user_preset)

                'se o nome dos presets comparados for igual, perguntar ao usuário oq deseja fazer
                If struct_do_preset.nome = struct_do_User_preset.nome Then

                    addPreset = False 'preset ja existe e nao será adicionado, a menos que o usuario deseje sobregravar
                    If noForAll Then Exit For

                    If Not yesForAll Then
                        box.lblText.Text = "Um item com o nome """ & struct_do_preset.nome & """ já existe." & vbCrLf & "Deseja sobregravar?"
                        box.ShowDialog()

                        'checagem de qual botão foi pressionado e se o "ForAll" foi marcado
                        If box.DialogResult.Equals(DialogResult.No) Then

                            If box.chkBox_ForAll.Checked Then noForAll = True
                            Exit For

                        ElseIf box.DialogResult.Equals(DialogResult.Yes) Then

                            If box.chkBox_ForAll.Checked Then yesForAll = True

                        ElseIf box.DialogResult.Equals(DialogResult.Cancel) Then

                            Exit Sub

                        End If
                    End If

                    'processo de sobregravar
                    indice = cbPresets.FindStringExact(struct_do_User_preset.nome)

                    If indice <> -1 Then
                        lista_excluir.Add(My.Settings.presets_user(indice)) 'lista de presets a serem excluídos para serem substituidos
                        addPreset = True 'preset ja existe mas o usuario deseja sobregravar, entao será adicionado
                        Exit For
                    End If
                Else
                    addPreset = True
                End If
            Next
            If addPreset Then
                lista_adicionar.Add(New JavaScriptSerializer().Serialize(struct_do_preset)) 'lista de presets do .config a serem adicionados
            End If
        Next

        For Each i In lista_excluir
            My.Settings.presets_user.Remove(i) 'remover os presets q serão sobregravados
        Next

        For Each s In lista_adicionar
            My.Settings.presets_user.Add(s) 'sobregravar
        Next

        Atualizar_Lista_Presets()
        My.Settings.Save()
    End Sub

    Private Sub hsbPreview_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbPreview.Scroll
        NumericUpDown1.Value = hsbPreview.Value
        Gerar_preview()
    End Sub

End Class
