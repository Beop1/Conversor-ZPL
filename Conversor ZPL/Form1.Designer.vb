<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAddArquivo = New System.Windows.Forms.Button()
        Me.btnSalvarPDF = New System.Windows.Forms.Button()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPresets = New System.Windows.Forms.Label()
        Me.cbPresets = New System.Windows.Forms.ComboBox()
        Me.btnPresets_Salvar = New System.Windows.Forms.Button()
        Me.btnPresets_Excluir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbOrdenar_ordem = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbOrdenar_por = New System.Windows.Forms.ComboBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtLargura = New System.Windows.Forms.TextBox()
        Me.cbUnidade = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDPI = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lvPreview_lista = New System.Windows.Forms.ListView()
        Me.chkOrdenar_Incluir = New System.Windows.Forms.CheckBox()
        Me.txtOrdenar_lista = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPreviewPaginas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.hsbPreview = New System.Windows.Forms.HScrollBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.pictureboxPreview = New System.Windows.Forms.PictureBox()
        Me.btnAbrirPDF = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddArquivo
        '
        Me.btnAddArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddArquivo.Location = New System.Drawing.Point(33, 455)
        Me.btnAddArquivo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddArquivo.Name = "btnAddArquivo"
        Me.btnAddArquivo.Size = New System.Drawing.Size(142, 29)
        Me.btnAddArquivo.TabIndex = 0
        Me.btnAddArquivo.Text = "Incluir arquivo ZPL"
        Me.btnAddArquivo.UseVisualStyleBackColor = True
        '
        'btnSalvarPDF
        '
        Me.btnSalvarPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarPDF.Location = New System.Drawing.Point(33, 501)
        Me.btnSalvarPDF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalvarPDF.Name = "btnSalvarPDF"
        Me.btnSalvarPDF.Size = New System.Drawing.Size(142, 28)
        Me.btnSalvarPDF.TabIndex = 12
        Me.btnSalvarPDF.Text = "Salvar PDF"
        Me.btnSalvarPDF.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtStatus.Location = New System.Drawing.Point(10, 116)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(338, 132)
        Me.txtStatus.TabIndex = 15
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLimpar.Location = New System.Drawing.Point(204, 455)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(142, 29)
        Me.btnLimpar.TabIndex = 16
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Conversor_ZPL.My.Resources.Resources.Verde___Transparente___completo
        Me.PictureBox1.Location = New System.Drawing.Point(10, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lblPresets
        '
        Me.lblPresets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPresets.AutoSize = True
        Me.lblPresets.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresets.Location = New System.Drawing.Point(11, 264)
        Me.lblPresets.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPresets.Name = "lblPresets"
        Me.lblPresets.Size = New System.Drawing.Size(103, 17)
        Me.lblPresets.TabIndex = 27
        Me.lblPresets.Text = "Pré-definições:"
        Me.lblPresets.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPresets
        '
        Me.cbPresets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbPresets.BackColor = System.Drawing.SystemColors.Window
        Me.cbPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPresets.FormattingEnabled = True
        Me.cbPresets.Items.AddRange(New Object() {"Mercadolivre FULL Produtos (4 x 2,5 cm)", "Padrão Transportadoras (10 x 15 cm)"})
        Me.cbPresets.Location = New System.Drawing.Point(123, 264)
        Me.cbPresets.Margin = New System.Windows.Forms.Padding(2)
        Me.cbPresets.Name = "cbPresets"
        Me.cbPresets.Size = New System.Drawing.Size(223, 21)
        Me.cbPresets.Sorted = True
        Me.cbPresets.TabIndex = 28
        '
        'btnPresets_Salvar
        '
        Me.btnPresets_Salvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPresets_Salvar.Location = New System.Drawing.Point(192, 290)
        Me.btnPresets_Salvar.Name = "btnPresets_Salvar"
        Me.btnPresets_Salvar.Size = New System.Drawing.Size(75, 23)
        Me.btnPresets_Salvar.TabIndex = 34
        Me.btnPresets_Salvar.Text = "Salvar"
        Me.btnPresets_Salvar.UseVisualStyleBackColor = True
        '
        'btnPresets_Excluir
        '
        Me.btnPresets_Excluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPresets_Excluir.Location = New System.Drawing.Point(273, 290)
        Me.btnPresets_Excluir.Name = "btnPresets_Excluir"
        Me.btnPresets_Excluir.Size = New System.Drawing.Size(73, 23)
        Me.btnPresets_Excluir.TabIndex = 44
        Me.btnPresets_Excluir.Text = "Excluir"
        Me.btnPresets_Excluir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbOrdenar_ordem)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbOrdenar_por)
        Me.GroupBox2.Controls.Add(Me.txtAltura)
        Me.GroupBox2.Controls.Add(Me.txtLargura)
        Me.GroupBox2.Controls.Add(Me.cbUnidade)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbDPI)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 113)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opções"
        '
        'cbOrdenar_ordem
        '
        Me.cbOrdenar_ordem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrdenar_ordem.FormattingEnabled = True
        Me.cbOrdenar_ordem.Items.AddRange(New Object() {"Crescente", "Decrescente", "por Lista"})
        Me.cbOrdenar_ordem.Location = New System.Drawing.Point(231, 15)
        Me.cbOrdenar_ordem.Name = "cbOrdenar_ordem"
        Me.cbOrdenar_ordem.Size = New System.Drawing.Size(107, 21)
        Me.cbOrdenar_ordem.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Ordenar por:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbOrdenar_por
        '
        Me.cbOrdenar_por.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrdenar_por.FormattingEnabled = True
        Me.cbOrdenar_por.Items.AddRange(New Object() {"Sem ordenamento", "ID do Frete", "Número da venda"})
        Me.cbOrdenar_por.Location = New System.Drawing.Point(100, 15)
        Me.cbOrdenar_por.Name = "cbOrdenar_por"
        Me.cbOrdenar_por.Size = New System.Drawing.Size(125, 21)
        Me.cbOrdenar_por.TabIndex = 54
        '
        'txtAltura
        '
        Me.txtAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltura.Location = New System.Drawing.Point(251, 83)
        Me.txtAltura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(32, 23)
        Me.txtAltura.TabIndex = 52
        Me.txtAltura.Text = "16"
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLargura
        '
        Me.txtLargura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLargura.Location = New System.Drawing.Point(198, 83)
        Me.txtLargura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(32, 23)
        Me.txtLargura.TabIndex = 51
        Me.txtLargura.Text = "10"
        Me.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbUnidade
        '
        Me.cbUnidade.BackColor = System.Drawing.SystemColors.Window
        Me.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidade.FormattingEnabled = True
        Me.cbUnidade.Items.AddRange(New Object() {"mm", "cm", "pol"})
        Me.cbUnidade.Location = New System.Drawing.Point(296, 83)
        Me.cbUnidade.Margin = New System.Windows.Forms.Padding(2)
        Me.cbUnidade.Name = "cbUnidade"
        Me.cbUnidade.Size = New System.Drawing.Size(44, 21)
        Me.cbUnidade.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Tamanho da etiqueta (L x A):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Densidade da impressão:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDPI
        '
        Me.cbDPI.BackColor = System.Drawing.SystemColors.Window
        Me.cbDPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDPI.FormattingEnabled = True
        Me.cbDPI.Items.AddRange(New Object() {"6 dpmm (152 dpi)", "8 dpmm (203 dpi)", "12 dpmm (300 dpi)", "24 dpmm (600 dpi)"})
        Me.cbDPI.Location = New System.Drawing.Point(178, 51)
        Me.cbDPI.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDPI.Name = "cbDPI"
        Me.cbDPI.Size = New System.Drawing.Size(162, 21)
        Me.cbDPI.TabIndex = 46
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(352, 47)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvPreview_lista)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkOrdenar_Incluir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtOrdenar_lista)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(737, 495)
        Me.SplitContainer1.SplitterDistance = 362
        Me.SplitContainer1.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(199, 462)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Conversor alternativo:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(198, 478)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(158, 13)
        Me.LinkLabel1.TabIndex = 64
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://labelary.com/service.html"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lvPreview_lista
        '
        Me.lvPreview_lista.AllowColumnReorder = True
        Me.lvPreview_lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvPreview_lista.FullRowSelect = True
        Me.lvPreview_lista.GridLines = True
        Me.lvPreview_lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPreview_lista.HideSelection = False
        Me.lvPreview_lista.Location = New System.Drawing.Point(109, 34)
        Me.lvPreview_lista.Name = "lvPreview_lista"
        Me.lvPreview_lista.Size = New System.Drawing.Size(248, 391)
        Me.lvPreview_lista.TabIndex = 63
        Me.lvPreview_lista.UseCompatibleStateImageBehavior = False
        Me.lvPreview_lista.View = System.Windows.Forms.View.Details
        '
        'chkOrdenar_Incluir
        '
        Me.chkOrdenar_Incluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkOrdenar_Incluir.AutoSize = True
        Me.chkOrdenar_Incluir.Location = New System.Drawing.Point(3, 431)
        Me.chkOrdenar_Incluir.Name = "chkOrdenar_Incluir"
        Me.chkOrdenar_Incluir.Size = New System.Drawing.Size(100, 30)
        Me.chkOrdenar_Incluir.TabIndex = 62
        Me.chkOrdenar_Incluir.Text = "Incluir demais" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "páginas ao final"
        Me.chkOrdenar_Incluir.UseVisualStyleBackColor = True
        '
        'txtOrdenar_lista
        '
        Me.txtOrdenar_lista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOrdenar_lista.Location = New System.Drawing.Point(3, 34)
        Me.txtOrdenar_lista.Multiline = True
        Me.txtOrdenar_lista.Name = "txtOrdenar_lista"
        Me.txtOrdenar_lista.Size = New System.Drawing.Size(100, 391)
        Me.txtOrdenar_lista.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblPreviewPaginas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.hsbPreview)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.pictureboxPreview)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 495)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'lblPreviewPaginas
        '
        Me.lblPreviewPaginas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPreviewPaginas.AutoSize = True
        Me.lblPreviewPaginas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviewPaginas.Location = New System.Drawing.Point(139, 466)
        Me.lblPreviewPaginas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPreviewPaginas.Name = "lblPreviewPaginas"
        Me.lblPreviewPaginas.Size = New System.Drawing.Size(16, 17)
        Me.lblPreviewPaginas.TabIndex = 48
        Me.lblPreviewPaginas.Text = "0"
        Me.lblPreviewPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(121, 466)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "de"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'hsbPreview
        '
        Me.hsbPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hsbPreview.LargeChange = 1
        Me.hsbPreview.Location = New System.Drawing.Point(157, 462)
        Me.hsbPreview.Maximum = 1
        Me.hsbPreview.Minimum = 1
        Me.hsbPreview.Name = "hsbPreview"
        Me.hsbPreview.Size = New System.Drawing.Size(208, 24)
        Me.hsbPreview.TabIndex = 46
        Me.hsbPreview.Value = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 466)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Página:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.Location = New System.Drawing.Point(61, 466)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown1.TabIndex = 44
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pictureboxPreview
        '
        Me.pictureboxPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureboxPreview.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pictureboxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxPreview.Location = New System.Drawing.Point(5, 18)
        Me.pictureboxPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureboxPreview.Name = "pictureboxPreview"
        Me.pictureboxPreview.Size = New System.Drawing.Size(360, 442)
        Me.pictureboxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxPreview.TabIndex = 42
        Me.pictureboxPreview.TabStop = False
        '
        'btnAbrirPDF
        '
        Me.btnAbrirPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirPDF.Location = New System.Drawing.Point(204, 501)
        Me.btnAbrirPDF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbrirPDF.Name = "btnAbrirPDF"
        Me.btnAbrirPDF.Size = New System.Drawing.Size(142, 28)
        Me.btnAbrirPDF.TabIndex = 47
        Me.btnAbrirPDF.Text = "Abrir PDF"
        Me.btnAbrirPDF.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1101, 24)
        Me.MenuStrip1.TabIndex = 48
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarToolStripMenuItem, Me.EToolStripMenuItem, Me.ToolStripSeparator1, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ImportarToolStripMenuItem.Text = "Importar Pré-definições"
        '
        'EToolStripMenuItem
        '
        Me.EToolStripMenuItem.Name = "EToolStripMenuItem"
        Me.EToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EToolStripMenuItem.Text = "Exportar Pré-definições"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 554)
        Me.Controls.Add(Me.btnAbrirPDF)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnPresets_Excluir)
        Me.Controls.Add(Me.btnPresets_Salvar)
        Me.Controls.Add(Me.cbPresets)
        Me.Controls.Add(Me.lblPresets)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.btnSalvarPDF)
        Me.Controls.Add(Me.btnAddArquivo)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Salvar PDF"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddArquivo As Button
    Friend WithEvents btnSalvarPDF As Button
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents btnLimpar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPresets As Label
    Friend WithEvents cbPresets As ComboBox
    Friend WithEvents btnPresets_Salvar As Button
    Friend WithEvents btnPresets_Excluir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbOrdenar_ordem As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbOrdenar_por As ComboBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtLargura As TextBox
    Friend WithEvents cbUnidade As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDPI As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lvPreview_lista As ListView
    Friend WithEvents chkOrdenar_Incluir As CheckBox
    Friend WithEvents txtOrdenar_lista As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPreviewPaginas As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents hsbPreview As HScrollBar
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents pictureboxPreview As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnAbrirPDF As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
