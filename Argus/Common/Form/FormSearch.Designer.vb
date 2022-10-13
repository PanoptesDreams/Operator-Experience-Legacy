<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearch
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
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.RichTextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonOpenSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(13, 41)
        Me.ButtonSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(100, 39)
        Me.ButtonSearch.TabIndex = 0
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(13, 13)
        Me.SearchBox.Multiline = False
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(390, 26)
        Me.SearchBox.TabIndex = 1
        Me.SearchBox.Text = ""
        '
        'ButtonClear
        '
        Me.ButtonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClear.Location = New System.Drawing.Point(303, 41)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(100, 39)
        Me.ButtonClear.TabIndex = 2
        Me.ButtonClear.Text = "&Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonOpenSettings
        '
        Me.ButtonOpenSettings.Location = New System.Drawing.Point(158, 41)
        Me.ButtonOpenSettings.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonOpenSettings.Name = "ButtonOpenSettings"
        Me.ButtonOpenSettings.Size = New System.Drawing.Size(100, 39)
        Me.ButtonOpenSettings.TabIndex = 3
        Me.ButtonOpenSettings.Text = "Sett&ings"
        Me.ButtonOpenSettings.UseVisualStyleBackColor = True
        '
        'FormSearch
        '
        Me.AcceptButton = Me.ButtonSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonClear
        Me.ClientSize = New System.Drawing.Size(427, 94)
        Me.Controls.Add(Me.ButtonOpenSettings)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Font = New System.Drawing.Font("Fira Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonSearch As Button
    Friend WithEvents SearchBox As RichTextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonOpenSettings As Button
End Class
