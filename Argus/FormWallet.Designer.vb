<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWallet
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
        Me.LabelBalanceCash = New System.Windows.Forms.Label()
        Me.LabelBalanceCredit = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelBalanceCash
        '
        Me.LabelBalanceCash.AutoSize = True
        Me.LabelBalanceCash.Location = New System.Drawing.Point(10, 42)
        Me.LabelBalanceCash.Margin = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.LabelBalanceCash.Name = "LabelBalanceCash"
        Me.LabelBalanceCash.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelBalanceCash.Size = New System.Drawing.Size(62, 32)
        Me.LabelBalanceCash.TabIndex = 2
        Me.LabelBalanceCash.Text = "Cash"
        '
        'LabelBalanceCredit
        '
        Me.LabelBalanceCredit.AutoSize = True
        Me.LabelBalanceCredit.Location = New System.Drawing.Point(10, 10)
        Me.LabelBalanceCredit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.LabelBalanceCredit.Name = "LabelBalanceCredit"
        Me.LabelBalanceCredit.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelBalanceCredit.Size = New System.Drawing.Size(68, 32)
        Me.LabelBalanceCredit.TabIndex = 1
        Me.LabelBalanceCredit.Text = "Credit"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.Font = New System.Drawing.Font("Fira Sans", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(127, 51)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(25, 25)
        Me.ButtonAdd.TabIndex = 0
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'FormWallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(160, 84)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.LabelBalanceCredit)
        Me.Controls.Add(Me.LabelBalanceCash)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(9, 9)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormWallet"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormWallet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelBalanceCash As Label
    Friend WithEvents LabelBalanceCredit As Label
    Friend WithEvents ButtonAdd As Button
End Class
