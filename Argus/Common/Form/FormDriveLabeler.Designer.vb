<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDriveLabeler
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
        Me.ComboBoxDrive = New System.Windows.Forms.ComboBox()
        Me.ButtonExecute = New System.Windows.Forms.Button()
        Me.TextBoxIconPath = New System.Windows.Forms.TextBox()
        Me.TextBoxLabel = New System.Windows.Forms.TextBox()
        Me.PicIcon = New System.Windows.Forms.PictureBox()
        CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxDrive
        '
        Me.ComboBoxDrive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxDrive.FormattingEnabled = True
        Me.ComboBoxDrive.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxDrive.Name = "ComboBoxDrive"
        Me.ComboBoxDrive.Size = New System.Drawing.Size(540, 28)
        Me.ComboBoxDrive.TabIndex = 0
        '
        'ButtonExecute
        '
        Me.ButtonExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonExecute.Location = New System.Drawing.Point(406, 568)
        Me.ButtonExecute.Name = "ButtonExecute"
        Me.ButtonExecute.Size = New System.Drawing.Size(146, 74)
        Me.ButtonExecute.TabIndex = 1
        Me.ButtonExecute.Text = "Execute"
        Me.ButtonExecute.UseVisualStyleBackColor = True
        '
        'TextBoxIconPath
        '
        Me.TextBoxIconPath.Location = New System.Drawing.Point(12, 475)
        Me.TextBoxIconPath.Name = "TextBoxIconPath"
        Me.TextBoxIconPath.Size = New System.Drawing.Size(540, 26)
        Me.TextBoxIconPath.TabIndex = 2
        Me.TextBoxIconPath.Text = "Icon Path"
        Me.TextBoxIconPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxLabel
        '
        Me.TextBoxLabel.Location = New System.Drawing.Point(12, 73)
        Me.TextBoxLabel.Name = "TextBoxLabel"
        Me.TextBoxLabel.Size = New System.Drawing.Size(540, 26)
        Me.TextBoxLabel.TabIndex = 3
        Me.TextBoxLabel.Text = "Drive Label"
        Me.TextBoxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PicIcon
        '
        Me.PicIcon.Location = New System.Drawing.Point(12, 281)
        Me.PicIcon.Name = "PicIcon"
        Me.PicIcon.Size = New System.Drawing.Size(202, 188)
        Me.PicIcon.TabIndex = 4
        Me.PicIcon.TabStop = False
        '
        'FormDriveLabeler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 654)
        Me.Controls.Add(Me.PicIcon)
        Me.Controls.Add(Me.TextBoxLabel)
        Me.Controls.Add(Me.TextBoxIconPath)
        Me.Controls.Add(Me.ButtonExecute)
        Me.Controls.Add(Me.ComboBoxDrive)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormDriveLabeler"
        Me.Text = "FormDriveLabeler"
        CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxDrive As ComboBox
    Friend WithEvents ButtonExecute As Button
    Friend WithEvents TextBoxIconPath As TextBox
    Friend WithEvents TextBoxLabel As TextBox
    Friend WithEvents PicIcon As PictureBox
End Class
