<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOOBEPrivacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOOBEPrivacy))
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.ButtonDefaultsReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(472, 496)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Padding = New System.Windows.Forms.Padding(5)
        Me.ButtonApply.Size = New System.Drawing.Size(100, 50)
        Me.ButtonApply.TabIndex = 9
        Me.ButtonApply.Text = "&Apply"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'ButtonDefaultsReset
        '
        Me.ButtonDefaultsReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonDefaultsReset.Enabled = False
        Me.ButtonDefaultsReset.Location = New System.Drawing.Point(10, 496)
        Me.ButtonDefaultsReset.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonDefaultsReset.Name = "ButtonDefaultsReset"
        Me.ButtonDefaultsReset.Padding = New System.Windows.Forms.Padding(5)
        Me.ButtonDefaultsReset.Size = New System.Drawing.Size(100, 50)
        Me.ButtonDefaultsReset.TabIndex = 8
        Me.ButtonDefaultsReset.Text = "&Reset"
        Me.ButtonDefaultsReset.UseVisualStyleBackColor = True
        '
        'FormOOBEPrivacy
        '
        Me.AcceptButton = Me.ButtonApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonDefaultsReset
        Me.ClientSize = New System.Drawing.Size(582, 556)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.ButtonDefaultsReset)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Fira Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MaximizeBox = False
        Me.Name = "FormOOBEPrivacy"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Argus Privacy"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonApply As Button
    Friend WithEvents ButtonDefaultsReset As Button
End Class
