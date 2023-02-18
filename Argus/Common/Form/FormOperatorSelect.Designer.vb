<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOperatorSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOperatorSelect))
        Me.ButtonAddOperator = New System.Windows.Forms.Button()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.CheckedListBoxOperators = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'ButtonAddOperator
        '
        Me.ButtonAddOperator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddOperator.Location = New System.Drawing.Point(13, 148)
        Me.ButtonAddOperator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonAddOperator.Name = "ButtonAddOperator"
        Me.ButtonAddOperator.Size = New System.Drawing.Size(112, 35)
        Me.ButtonAddOperator.TabIndex = 0
        Me.ButtonAddOperator.Text = "Add"
        Me.ButtonAddOperator.UseVisualStyleBackColor = True
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSelect.Location = New System.Drawing.Point(192, 148)
        Me.ButtonSelect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(112, 35)
        Me.ButtonSelect.TabIndex = 1
        Me.ButtonSelect.Text = "Select"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'CheckedListBoxOperators
        '
        Me.CheckedListBoxOperators.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBoxOperators.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBoxOperators.FormattingEnabled = True
        Me.CheckedListBoxOperators.Location = New System.Drawing.Point(13, 12)
        Me.CheckedListBoxOperators.Name = "CheckedListBoxOperators"
        Me.CheckedListBoxOperators.Size = New System.Drawing.Size(292, 121)
        Me.CheckedListBoxOperators.TabIndex = 2
        '
        'FormOperatorSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 197)
        Me.Controls.Add(Me.CheckedListBoxOperators)
        Me.Controls.Add(Me.ButtonSelect)
        Me.Controls.Add(Me.ButtonAddOperator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormOperatorSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operator Select"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonAddOperator As Button
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents CheckedListBoxOperators As CheckedListBox
End Class
