<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormToolBox
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
        Me.ButtonTool0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonTool0
        '
        Me.ButtonTool0.Location = New System.Drawing.Point(13, 14)
        Me.ButtonTool0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonTool0.Name = "ButtonTool0"
        Me.ButtonTool0.Size = New System.Drawing.Size(220, 35)
        Me.ButtonTool0.TabIndex = 0
        Me.ButtonTool0.Text = "Driver Labeler"
        Me.ButtonTool0.UseVisualStyleBackColor = True
        '
        'FormToolBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 540)
        Me.Controls.Add(Me.ButtonTool0)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormToolBox"
        Me.Text = "FormToolBox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonTool0 As Button
End Class
