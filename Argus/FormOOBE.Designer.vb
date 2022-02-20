<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOOBE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOOBE))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelSystemName = New System.Windows.Forms.Label()
        Me.TextBoxSystemName = New System.Windows.Forms.TextBox()
        Me.LabelArgusTitle = New System.Windows.Forms.Label()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDefaultsReset = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.TextBoxWorkgroup = New System.Windows.Forms.TextBox()
        Me.LabelWorkgroup = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 254)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 159)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Language" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Region/Location" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Privacy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Profile (Gaming, Education, Creativity, Enter" &
    "tainment, Family, Business)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Applications" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Storage Location"
        '
        'LabelSystemName
        '
        Me.LabelSystemName.AutoSize = True
        Me.LabelSystemName.BackColor = System.Drawing.Color.Transparent
        Me.LabelSystemName.Location = New System.Drawing.Point(60, 122)
        Me.LabelSystemName.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelSystemName.Name = "LabelSystemName"
        Me.LabelSystemName.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelSystemName.Size = New System.Drawing.Size(130, 32)
        Me.LabelSystemName.TabIndex = 3
        Me.LabelSystemName.Text = "System Name"
        '
        'TextBoxSystemName
        '
        Me.TextBoxSystemName.Location = New System.Drawing.Point(200, 125)
        Me.TextBoxSystemName.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxSystemName.Name = "TextBoxSystemName"
        Me.TextBoxSystemName.Size = New System.Drawing.Size(226, 29)
        Me.TextBoxSystemName.TabIndex = 1
        '
        'LabelArgusTitle
        '
        Me.LabelArgusTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelArgusTitle.AutoSize = True
        Me.LabelArgusTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelArgusTitle.Font = New System.Drawing.Font("Fira Sans", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArgusTitle.Location = New System.Drawing.Point(125, 20)
        Me.LabelArgusTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelArgusTitle.Name = "LabelArgusTitle"
        Me.LabelArgusTitle.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelArgusTitle.Size = New System.Drawing.Size(326, 74)
        Me.LabelArgusTitle.TabIndex = 0
        Me.LabelArgusTitle.Text = "Argus Setup"
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(200, 167)
        Me.TextBoxUserName.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(226, 29)
        Me.TextBoxUserName.TabIndex = 2
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsername.Location = New System.Drawing.Point(81, 164)
        Me.LabelUsername.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelUsername.Size = New System.Drawing.Size(109, 32)
        Me.LabelUsername.TabIndex = 4
        Me.LabelUsername.Text = "User Name"
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
        Me.ButtonDefaultsReset.TabIndex = 6
        Me.ButtonDefaultsReset.Text = "&Reset"
        Me.ButtonDefaultsReset.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(472, 496)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Padding = New System.Windows.Forms.Padding(5)
        Me.ButtonApply.Size = New System.Drawing.Size(100, 50)
        Me.ButtonApply.TabIndex = 7
        Me.ButtonApply.Text = "&Apply"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'TextBoxWorkgroup
        '
        Me.TextBoxWorkgroup.Location = New System.Drawing.Point(200, 446)
        Me.TextBoxWorkgroup.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxWorkgroup.Name = "TextBoxWorkgroup"
        Me.TextBoxWorkgroup.Size = New System.Drawing.Size(226, 29)
        Me.TextBoxWorkgroup.TabIndex = 8
        '
        'LabelWorkgroup
        '
        Me.LabelWorkgroup.AutoSize = True
        Me.LabelWorkgroup.BackColor = System.Drawing.Color.Transparent
        Me.LabelWorkgroup.Location = New System.Drawing.Point(81, 443)
        Me.LabelWorkgroup.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelWorkgroup.Name = "LabelWorkgroup"
        Me.LabelWorkgroup.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelWorkgroup.Size = New System.Drawing.Size(109, 32)
        Me.LabelWorkgroup.TabIndex = 9
        Me.LabelWorkgroup.Text = "Workgroup"
        '
        'FormOOBE
        '
        Me.AcceptButton = Me.ButtonApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonDefaultsReset
        Me.ClientSize = New System.Drawing.Size(582, 556)
        Me.Controls.Add(Me.TextBoxWorkgroup)
        Me.Controls.Add(Me.LabelWorkgroup)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.ButtonDefaultsReset)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelArgusTitle)
        Me.Controls.Add(Me.TextBoxSystemName)
        Me.Controls.Add(Me.LabelSystemName)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Fira Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "FormOOBE"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Argus Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelSystemName As Label
    Friend WithEvents TextBoxSystemName As TextBox
    Friend WithEvents LabelArgusTitle As Label
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDefaultsReset As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents TextBoxWorkgroup As TextBox
    Friend WithEvents LabelWorkgroup As Label
End Class
