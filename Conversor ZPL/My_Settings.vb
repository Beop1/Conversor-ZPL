Imports System.Collections.Specialized
Imports System.IO
Imports System.Xml.Serialization

Module Funções_Gerais
    Public Sub Exportar_predefinicoes(ByRef p As StringCollection, Optional nome_do_arquivo As String = "")

        Dim arquivo As String
        Dim serializer As XmlSerializer = Nothing
        Dim writer As StreamWriter = Nothing

        If nome_do_arquivo = "" Then nome_do_arquivo = "MySettings"
        arquivo = Salvar_Como(nome_do_arquivo & ".config", "Arquivo de configurações|*.config")
        If arquivo = "" Then Exit Sub

        Try
            ' Create an XmlSerializer for the ApplicationSettings type.
            serializer = New XmlSerializer(GetType(StringCollection))
            writer = New StreamWriter(arquivo)

            ' Serialize this instance of the preset to the config file. 
            serializer.Serialize(writer, p)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            ' If the FileStream is open, close it.
            If Not (writer Is Nothing) Then
                writer.Close()
            End If

        End Try

    End Sub

    Public Function Carregar_Predefinicoes(Optional nome_do_arquivo As String = "") As StringCollection

        Dim arquivo As String = ""
        Dim p As StringCollection = Nothing
        Dim serializer As XmlSerializer = Nothing
        Dim reader As StreamReader = Nothing

        If nome_do_arquivo = "" Then nome_do_arquivo = "MySettings"

        Dim openFileDialog1 As New OpenFileDialog() With
        {
           .FileName = nome_do_arquivo & ".config",
           .Filter = "Arquivo de configurações|*.config",
           .Title = "Abrir arquivo"
        }

        If openFileDialog1.ShowDialog() = DialogResult.Cancel Then Return Nothing

        arquivo = openFileDialog1.FileName
        Try
            ' Create an XmlSerializer for the ApplicationSettings type.
            serializer = New XmlSerializer(GetType(StringCollection))

            'Deserializar o arquivo para o objeto StringCollection
            reader = New StreamReader(arquivo)
            p = serializer.Deserialize(reader)

            Return p
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            ' If the FileStream is open, close it.
            If Not (reader Is Nothing) Then
                reader.Close()
            End If

        End Try
        Return Nothing
    End Function

    Public Function Salvar_Como(padrao As String, filtro As String) As String

        Dim saveFileDialog1 As New SaveFileDialog() With
            {
               .FileName = padrao,
               .Filter = filtro,
               .Title = "Salvar como..."
            }
        If saveFileDialog1.ShowDialog() = DialogResult.Cancel Then Return ""

        'se o arquivo ja existe, o proprio savefiledialog pergunta se quer sobregravar
        Return saveFileDialog1.FileName
    End Function

End Module
