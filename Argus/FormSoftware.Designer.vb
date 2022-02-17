<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSoftware
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
        Me.ButtonOpenFOlder = New System.Windows.Forms.Button()
        Me.TabControlSoftware = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SettingsPanel = New System.Windows.Forms.Panel()
        Me.LabelSettings0 = New System.Windows.Forms.Label()
        Me.LabelSettingsWindows = New System.Windows.Forms.Label()
        Me.LabelSoftwareCustomization = New System.Windows.Forms.Label()
        Me.TabControlSoftware.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SettingsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonOpenFOlder
        '
        Me.ButtonOpenFOlder.Location = New System.Drawing.Point(8, 474)
        Me.ButtonOpenFOlder.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtonOpenFOlder.Name = "ButtonOpenFOlder"
        Me.ButtonOpenFOlder.Size = New System.Drawing.Size(134, 39)
        Me.ButtonOpenFOlder.TabIndex = 0
        Me.ButtonOpenFOlder.Text = "Open Folder"
        Me.ButtonOpenFOlder.UseVisualStyleBackColor = True
        '
        'TabControlSoftware
        '
        Me.TabControlSoftware.Controls.Add(Me.TabPage1)
        Me.TabControlSoftware.Controls.Add(Me.TabPage2)
        Me.TabControlSoftware.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControlSoftware.Location = New System.Drawing.Point(198, 0)
        Me.TabControlSoftware.Name = "TabControlSoftware"
        Me.TabControlSoftware.SelectedIndex = 0
        Me.TabControlSoftware.Size = New System.Drawing.Size(684, 556)
        Me.TabControlSoftware.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonOpenFOlder)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(676, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SettingsPanel
        '
        Me.SettingsPanel.BackColor = System.Drawing.Color.Transparent
        Me.SettingsPanel.Controls.Add(Me.LabelSettings0)
        Me.SettingsPanel.Controls.Add(Me.LabelSettingsWindows)
        Me.SettingsPanel.Controls.Add(Me.LabelSoftwareCustomization)
        Me.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SettingsPanel.Location = New System.Drawing.Point(0, 0)
        Me.SettingsPanel.Margin = New System.Windows.Forms.Padding(5)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.SettingsPanel.Size = New System.Drawing.Size(190, 556)
        Me.SettingsPanel.TabIndex = 2
        '
        'LabelSettings0
        '
        Me.LabelSettings0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSettings0.BackColor = System.Drawing.Color.Transparent
        Me.LabelSettings0.Image = Global.Argus.My.Resources.Resources.frame_empty
        Me.LabelSettings0.Location = New System.Drawing.Point(80, 492)
        Me.LabelSettings0.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelSettings0.Name = "LabelSettings0"
        Me.LabelSettings0.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelSettings0.Size = New System.Drawing.Size(100, 50)
        Me.LabelSettings0.TabIndex = 15
        Me.LabelSettings0.Text = "Ɛ>"
        Me.LabelSettings0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSettingsWindows
        '
        Me.LabelSettingsWindows.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSettingsWindows.BackColor = System.Drawing.Color.Transparent
        Me.LabelSettingsWindows.Image = Global.Argus.My.Resources.Resources.frame_empty
        Me.LabelSettingsWindows.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelSettingsWindows.Location = New System.Drawing.Point(30, 74)
        Me.LabelSettingsWindows.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelSettingsWindows.Name = "LabelSettingsWindows"
        Me.LabelSettingsWindows.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelSettingsWindows.Size = New System.Drawing.Size(150, 50)
        Me.LabelSettingsWindows.TabIndex = 14
        Me.LabelSettingsWindows.Text = "Windows "
        Me.LabelSettingsWindows.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSoftwareCustomization
        '
        Me.LabelSoftwareCustomization.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSoftwareCustomization.BackColor = System.Drawing.Color.Transparent
        Me.LabelSoftwareCustomization.Image = Global.Argus.My.Resources.Resources.frame_empty
        Me.LabelSoftwareCustomization.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelSoftwareCustomization.Location = New System.Drawing.Point(30, 14)
        Me.LabelSoftwareCustomization.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelSoftwareCustomization.Name = "LabelSoftwareCustomization"
        Me.LabelSoftwareCustomization.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelSoftwareCustomization.Size = New System.Drawing.Size(150, 50)
        Me.LabelSoftwareCustomization.TabIndex = 1
        Me.LabelSoftwareCustomization.Text = "Customization "
        Me.LabelSoftwareCustomization.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 556)
        Me.Controls.Add(Me.SettingsPanel)
        Me.Controls.Add(Me.TabControlSoftware)
        Me.Font = New System.Drawing.Font("Fira Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "FormSoftware"
        Me.Text = "FormSoftware"
        Me.TabControlSoftware.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SettingsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonOpenFOlder As Button
    Friend WithEvents TabControlSoftware As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SettingsPanel As Panel
    Friend WithEvents LabelSettings0 As Label
    Friend WithEvents LabelSettingsWindows As Label
    Friend WithEvents LabelSoftwareCustomization As Label
End Class
