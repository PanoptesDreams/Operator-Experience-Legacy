<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControlSettings = New System.Windows.Forms.TabControl()
        Me.SettingsTab1Argus = New System.Windows.Forms.TabPage()
        Me.TabControlArgus = New System.Windows.Forms.TabControl()
        Me.TabArgusPersonalization = New System.Windows.Forms.TabPage()
        Me.picUserImage = New System.Windows.Forms.PictureBox()
        Me.ComboBoxLauncherPOS = New System.Windows.Forms.ComboBox()
        Me.lblLauncherPOS = New System.Windows.Forms.Label()
        Me.tstUsernameSet = New System.Windows.Forms.TextBox()
        Me.lblUsernameSet = New System.Windows.Forms.Label()
        Me.btnApplyPersonalization = New System.Windows.Forms.Button()
        Me.ComboBoxTheme = New System.Windows.Forms.ComboBox()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.picFavColor = New System.Windows.Forms.PictureBox()
        Me.lblFaveColor = New System.Windows.Forms.Label()
        Me.TabArgusMisc = New System.Windows.Forms.TabPage()
        Me.ComboBoxWebSearchProvider = New System.Windows.Forms.ComboBox()
        Me.lblWebsearchProvider = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SettingsTab2Win = New System.Windows.Forms.TabPage()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TabControlSettings.SuspendLayout()
        Me.SettingsTab1Argus.SuspendLayout()
        Me.TabControlArgus.SuspendLayout()
        Me.TabArgusPersonalization.SuspendLayout()
        CType(Me.picUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFavColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabArgusMisc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlSettings
        '
        Me.TabControlSettings.Controls.Add(Me.SettingsTab1Argus)
        Me.TabControlSettings.Controls.Add(Me.SettingsTab2Win)
        Me.TabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlSettings.Location = New System.Drawing.Point(0, 0)
        Me.TabControlSettings.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControlSettings.Name = "TabControlSettings"
        Me.TabControlSettings.SelectedIndex = 0
        Me.TabControlSettings.Size = New System.Drawing.Size(882, 556)
        Me.TabControlSettings.TabIndex = 0
        '
        'SettingsTab1Argus
        '
        Me.SettingsTab1Argus.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SettingsTab1Argus.Controls.Add(Me.TabControlArgus)
        Me.SettingsTab1Argus.Location = New System.Drawing.Point(4, 31)
        Me.SettingsTab1Argus.Margin = New System.Windows.Forms.Padding(5)
        Me.SettingsTab1Argus.Name = "SettingsTab1Argus"
        Me.SettingsTab1Argus.Padding = New System.Windows.Forms.Padding(5)
        Me.SettingsTab1Argus.Size = New System.Drawing.Size(874, 521)
        Me.SettingsTab1Argus.TabIndex = 0
        Me.SettingsTab1Argus.Text = "Argus"
        '
        'TabControlArgus
        '
        Me.TabControlArgus.Controls.Add(Me.TabArgusPersonalization)
        Me.TabControlArgus.Controls.Add(Me.TabArgusMisc)
        Me.TabControlArgus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlArgus.Location = New System.Drawing.Point(5, 5)
        Me.TabControlArgus.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControlArgus.Name = "TabControlArgus"
        Me.TabControlArgus.SelectedIndex = 0
        Me.TabControlArgus.Size = New System.Drawing.Size(864, 511)
        Me.TabControlArgus.TabIndex = 1
        '
        'TabArgusPersonalization
        '
        Me.TabArgusPersonalization.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabArgusPersonalization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabArgusPersonalization.Controls.Add(Me.picUserImage)
        Me.TabArgusPersonalization.Controls.Add(Me.ComboBoxLauncherPOS)
        Me.TabArgusPersonalization.Controls.Add(Me.lblLauncherPOS)
        Me.TabArgusPersonalization.Controls.Add(Me.tstUsernameSet)
        Me.TabArgusPersonalization.Controls.Add(Me.lblUsernameSet)
        Me.TabArgusPersonalization.Controls.Add(Me.btnApplyPersonalization)
        Me.TabArgusPersonalization.Controls.Add(Me.ComboBoxTheme)
        Me.TabArgusPersonalization.Controls.Add(Me.lblTheme)
        Me.TabArgusPersonalization.Controls.Add(Me.picFavColor)
        Me.TabArgusPersonalization.Controls.Add(Me.lblFaveColor)
        Me.TabArgusPersonalization.Location = New System.Drawing.Point(4, 31)
        Me.TabArgusPersonalization.Margin = New System.Windows.Forms.Padding(5)
        Me.TabArgusPersonalization.Name = "TabArgusPersonalization"
        Me.TabArgusPersonalization.Padding = New System.Windows.Forms.Padding(5)
        Me.TabArgusPersonalization.Size = New System.Drawing.Size(856, 476)
        Me.TabArgusPersonalization.TabIndex = 0
        Me.TabArgusPersonalization.Text = "Personalization"
        '
        'picUserImage
        '
        Me.picUserImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picUserImage.BackColor = System.Drawing.Color.Transparent
        Me.picUserImage.BackgroundImage = Global.Argus.My.Resources.Resources.user
        Me.picUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUserImage.Location = New System.Drawing.Point(588, 31)
        Me.picUserImage.Margin = New System.Windows.Forms.Padding(5)
        Me.picUserImage.Name = "picUserImage"
        Me.picUserImage.Size = New System.Drawing.Size(241, 221)
        Me.picUserImage.TabIndex = 9
        Me.picUserImage.TabStop = False
        '
        'ComboBoxLauncherPOS
        '
        Me.ComboBoxLauncherPOS.FormattingEnabled = True
        Me.ComboBoxLauncherPOS.Items.AddRange(New Object() {"Top", "Bottom", "User"})
        Me.ComboBoxLauncherPOS.Location = New System.Drawing.Point(224, 45)
        Me.ComboBoxLauncherPOS.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBoxLauncherPOS.Name = "ComboBoxLauncherPOS"
        Me.ComboBoxLauncherPOS.Size = New System.Drawing.Size(133, 30)
        Me.ComboBoxLauncherPOS.TabIndex = 8
        '
        'lblLauncherPOS
        '
        Me.lblLauncherPOS.AutoSize = True
        Me.lblLauncherPOS.Location = New System.Drawing.Point(44, 48)
        Me.lblLauncherPOS.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLauncherPOS.Name = "lblLauncherPOS"
        Me.lblLauncherPOS.Size = New System.Drawing.Size(170, 22)
        Me.lblLauncherPOS.TabIndex = 7
        Me.lblLauncherPOS.Text = "Launcher Position -"
        '
        'tstUsernameSet
        '
        Me.tstUsernameSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tstUsernameSet.Location = New System.Drawing.Point(588, 262)
        Me.tstUsernameSet.Margin = New System.Windows.Forms.Padding(5)
        Me.tstUsernameSet.Name = "tstUsernameSet"
        Me.tstUsernameSet.Size = New System.Drawing.Size(241, 29)
        Me.tstUsernameSet.TabIndex = 6
        Me.tstUsernameSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUsernameSet
        '
        Me.lblUsernameSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsernameSet.AutoSize = True
        Me.lblUsernameSet.Font = New System.Drawing.Font("Fira Sans Medium", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameSet.Location = New System.Drawing.Point(672, 296)
        Me.lblUsernameSet.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblUsernameSet.Name = "lblUsernameSet"
        Me.lblUsernameSet.Size = New System.Drawing.Size(72, 14)
        Me.lblUsernameSet.TabIndex = 5
        Me.lblUsernameSet.Text = "Username"
        '
        'btnApplyPersonalization
        '
        Me.btnApplyPersonalization.AutoSize = True
        Me.btnApplyPersonalization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnApplyPersonalization.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnApplyPersonalization.Location = New System.Drawing.Point(5, 437)
        Me.btnApplyPersonalization.Margin = New System.Windows.Forms.Padding(5)
        Me.btnApplyPersonalization.Name = "btnApplyPersonalization"
        Me.btnApplyPersonalization.Size = New System.Drawing.Size(844, 32)
        Me.btnApplyPersonalization.TabIndex = 4
        Me.btnApplyPersonalization.Text = "Apply All"
        Me.btnApplyPersonalization.UseVisualStyleBackColor = True
        '
        'ComboBoxTheme
        '
        Me.ComboBoxTheme.FormattingEnabled = True
        Me.ComboBoxTheme.Items.AddRange(New Object() {"Light", "Dark"})
        Me.ComboBoxTheme.Location = New System.Drawing.Point(224, 85)
        Me.ComboBoxTheme.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBoxTheme.Name = "ComboBoxTheme"
        Me.ComboBoxTheme.Size = New System.Drawing.Size(133, 30)
        Me.ComboBoxTheme.TabIndex = 3
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(137, 88)
        Me.lblTheme.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(77, 22)
        Me.lblTheme.TabIndex = 2
        Me.lblTheme.Text = "Theme -"
        Me.lblTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picFavColor
        '
        Me.picFavColor.Location = New System.Drawing.Point(763, 353)
        Me.picFavColor.Margin = New System.Windows.Forms.Padding(5)
        Me.picFavColor.Name = "picFavColor"
        Me.picFavColor.Size = New System.Drawing.Size(41, 43)
        Me.picFavColor.TabIndex = 1
        Me.picFavColor.TabStop = False
        '
        'lblFaveColor
        '
        Me.lblFaveColor.AutoSize = True
        Me.lblFaveColor.Location = New System.Drawing.Point(616, 363)
        Me.lblFaveColor.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFaveColor.Name = "lblFaveColor"
        Me.lblFaveColor.Size = New System.Drawing.Size(137, 22)
        Me.lblFaveColor.TabIndex = 0
        Me.lblFaveColor.Text = "Favorite Color -"
        '
        'TabArgusMisc
        '
        Me.TabArgusMisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabArgusMisc.Controls.Add(Me.ComboBoxWebSearchProvider)
        Me.TabArgusMisc.Controls.Add(Me.lblWebsearchProvider)
        Me.TabArgusMisc.Controls.Add(Me.Button1)
        Me.TabArgusMisc.Location = New System.Drawing.Point(4, 31)
        Me.TabArgusMisc.Margin = New System.Windows.Forms.Padding(5)
        Me.TabArgusMisc.Name = "TabArgusMisc"
        Me.TabArgusMisc.Padding = New System.Windows.Forms.Padding(5)
        Me.TabArgusMisc.Size = New System.Drawing.Size(856, 476)
        Me.TabArgusMisc.TabIndex = 1
        Me.TabArgusMisc.Text = "Misc"
        Me.TabArgusMisc.UseVisualStyleBackColor = True
        '
        'ComboBoxWebSearchProvider
        '
        Me.ComboBoxWebSearchProvider.FormattingEnabled = True
        Me.ComboBoxWebSearchProvider.Items.AddRange(New Object() {"Bing", "Duck", "Frontpage", "Google", "Yahoo"})
        Me.ComboBoxWebSearchProvider.Location = New System.Drawing.Point(239, 31)
        Me.ComboBoxWebSearchProvider.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBoxWebSearchProvider.Name = "ComboBoxWebSearchProvider"
        Me.ComboBoxWebSearchProvider.Size = New System.Drawing.Size(285, 30)
        Me.ComboBoxWebSearchProvider.TabIndex = 7
        '
        'lblWebsearchProvider
        '
        Me.lblWebsearchProvider.AutoSize = True
        Me.lblWebsearchProvider.Location = New System.Drawing.Point(35, 34)
        Me.lblWebsearchProvider.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblWebsearchProvider.Name = "lblWebsearchProvider"
        Me.lblWebsearchProvider.Size = New System.Drawing.Size(193, 22)
        Me.lblWebsearchProvider.TabIndex = 6
        Me.lblWebsearchProvider.Text = "Web Search Provider -"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(5, 430)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(844, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Apply All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SettingsTab2Win
        '
        Me.SettingsTab2Win.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SettingsTab2Win.Location = New System.Drawing.Point(4, 31)
        Me.SettingsTab2Win.Margin = New System.Windows.Forms.Padding(5)
        Me.SettingsTab2Win.Name = "SettingsTab2Win"
        Me.SettingsTab2Win.Padding = New System.Windows.Forms.Padding(5)
        Me.SettingsTab2Win.Size = New System.Drawing.Size(874, 521)
        Me.SettingsTab2Win.TabIndex = 1
        Me.SettingsTab2Win.Text = "Windows"
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.SolidColorOnly = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(882, 556)
        Me.Controls.Add(Me.TabControlSettings)
        Me.Font = New System.Drawing.Font("Fira Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabControlSettings.ResumeLayout(False)
        Me.SettingsTab1Argus.ResumeLayout(False)
        Me.TabControlArgus.ResumeLayout(False)
        Me.TabArgusPersonalization.ResumeLayout(False)
        Me.TabArgusPersonalization.PerformLayout()
        CType(Me.picUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFavColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabArgusMisc.ResumeLayout(False)
        Me.TabArgusMisc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlSettings As TabControl
    Friend WithEvents SettingsTab1Argus As TabPage
    Friend WithEvents SettingsTab2Win As TabPage
    Friend WithEvents TabControlArgus As TabControl
    Friend WithEvents TabArgusPersonalization As TabPage
    Friend WithEvents TabArgusMisc As TabPage
    Friend WithEvents lblFaveColor As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents picFavColor As PictureBox
    Friend WithEvents ComboBoxTheme As ComboBox
    Friend WithEvents lblTheme As Label
    Friend WithEvents btnApplyPersonalization As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tstUsernameSet As TextBox
    Friend WithEvents lblUsernameSet As Label
    Friend WithEvents ComboBoxWebSearchProvider As ComboBox
    Friend WithEvents lblWebsearchProvider As Label
    Friend WithEvents ComboBoxLauncherPOS As ComboBox
    Friend WithEvents lblLauncherPOS As Label
    Friend WithEvents picUserImage As PictureBox
End Class
