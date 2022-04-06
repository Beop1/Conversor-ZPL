<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.chkBox_ForAll = New System.Windows.Forms.CheckBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnYes.Location = New System.Drawing.Point(31, 135)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(71, 30)
        Me.btnYes.TabIndex = 0
        Me.btnYes.Text = "Sim"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnNo.Location = New System.Drawing.Point(108, 135)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(71, 30)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Text = "Não"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'chkBox_ForAll
        '
        Me.chkBox_ForAll.AutoSize = True
        Me.chkBox_ForAll.Location = New System.Drawing.Point(31, 112)
        Me.chkBox_ForAll.Name = "chkBox_ForAll"
        Me.chkBox_ForAll.Size = New System.Drawing.Size(144, 17)
        Me.chkBox_ForAll.TabIndex = 2
        Me.chkBox_ForAll.Text = "Fazer para todos os itens"
        Me.chkBox_ForAll.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(41, 33)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(0, 13)
        Me.lblText.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(185, 135)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 30)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CustomBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 177)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.chkBox_ForAll)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Name = "CustomBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Conversor ZPL"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents chkBox_ForAll As CheckBox
    Friend WithEvents lblText As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
