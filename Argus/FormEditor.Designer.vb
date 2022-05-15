<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditor
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
        Me.TextEditBox = New System.Windows.Forms.RichTextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextEditBox
        '
        Me.TextEditBox.Location = New System.Drawing.Point(12, 12)
        Me.TextEditBox.Name = "TextEditBox"
        Me.TextEditBox.Size = New System.Drawing.Size(329, 199)
        Me.TextEditBox.TabIndex = 0
        Me.TextEditBox.Text = """ Pwease put your notes in me Sir "" Said the supplicated Notepad" & Global.Microsoft.VisualBasic.ChrW(10) & "😫😫" & Global.Microsoft.VisualBasic.ChrW(10) & """ Fill me w" &
    "ith your knowledge and experience! """ & Global.Microsoft.VisualBasic.ChrW(10) & "😫😫"
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonSave.Location = New System.Drawing.Point(94, 217)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.ButtonSave.Size = New System.Drawing.Size(75, 50)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.ButtonCancel.Location = New System.Drawing.Point(175, 217)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 50)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "&Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FormEditor
        '
        Me.AcceptButton = Me.ButtonSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(353, 279)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextEditBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditor"
        Me.Text = "Editor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextEditBox As RichTextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
End Class
