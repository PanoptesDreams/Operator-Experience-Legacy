<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHeader
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHeader))
        Me.labelClock = New System.Windows.Forms.Label()
        Me.TimerClockTick = New System.Windows.Forms.Timer(Me.components)
        Me.labelToday = New System.Windows.Forms.Label()
        Me.labelLongDate = New System.Windows.Forms.Label()
        Me.labelYear = New System.Windows.Forms.Label()
        Me.ButtonDebug = New System.Windows.Forms.Button()
        Me.picUserImage = New System.Windows.Forms.PictureBox()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.labelGreeter = New System.Windows.Forms.Label()
        Me.ButtonDebug2 = New System.Windows.Forms.Button()
        Me.PicCollections = New System.Windows.Forms.PictureBox()
        Me.NotifyIconLauncher = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuTrayIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrayMenuItemToggleVisibility = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrayMenuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.picUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCollections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuTrayIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelClock
        '
        Me.labelClock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelClock.AutoSize = True
        Me.labelClock.BackColor = System.Drawing.Color.Transparent
        Me.labelClock.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelClock.Location = New System.Drawing.Point(327, 9)
        Me.labelClock.Name = "labelClock"
        Me.labelClock.Size = New System.Drawing.Size(72, 18)
        Me.labelClock.TabIndex = 2
        Me.labelClock.Text = "00:00 XX"
        Me.labelClock.UseMnemonic = False
        '
        'TimerClockTick
        '
        Me.TimerClockTick.Enabled = True
        Me.TimerClockTick.Interval = 200
        '
        'labelToday
        '
        Me.labelToday.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelToday.BackColor = System.Drawing.Color.Transparent
        Me.labelToday.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelToday.Location = New System.Drawing.Point(184, 9)
        Me.labelToday.Name = "labelToday"
        Me.labelToday.Size = New System.Drawing.Size(94, 19)
        Me.labelToday.TabIndex = 3
        Me.labelToday.Text = "TODAY"
        Me.labelToday.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.labelToday.UseMnemonic = False
        '
        'labelLongDate
        '
        Me.labelLongDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelLongDate.BackColor = System.Drawing.Color.Transparent
        Me.labelLongDate.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLongDate.Location = New System.Drawing.Point(161, 26)
        Me.labelLongDate.Name = "labelLongDate"
        Me.labelLongDate.Size = New System.Drawing.Size(117, 19)
        Me.labelLongDate.TabIndex = 3
        Me.labelLongDate.Text = "XX MONTH"
        Me.labelLongDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.labelLongDate.UseMnemonic = False
        '
        'labelYear
        '
        Me.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelYear.AutoSize = True
        Me.labelYear.BackColor = System.Drawing.Color.Transparent
        Me.labelYear.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelYear.Location = New System.Drawing.Point(327, 26)
        Me.labelYear.Name = "labelYear"
        Me.labelYear.Size = New System.Drawing.Size(40, 18)
        Me.labelYear.TabIndex = 4
        Me.labelYear.Text = "XXXX"
        Me.labelYear.UseMnemonic = False
        '
        'ButtonDebug
        '
        Me.ButtonDebug.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonDebug.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonDebug.Cursor = System.Windows.Forms.Cursors.Help
        Me.ButtonDebug.Location = New System.Drawing.Point(423, 4)
        Me.ButtonDebug.Name = "ButtonDebug"
        Me.ButtonDebug.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDebug.TabIndex = 5
        Me.ButtonDebug.Text = "DEBUG"
        Me.ButtonDebug.UseVisualStyleBackColor = False
        '
        'picUserImage
        '
        Me.picUserImage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picUserImage.BackColor = System.Drawing.Color.Transparent
        Me.picUserImage.BackgroundImage = Global.Argus.My.Resources.Resources.user
        Me.picUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUserImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picUserImage.Location = New System.Drawing.Point(275, 0)
        Me.picUserImage.Name = "picUserImage"
        Me.picUserImage.Size = New System.Drawing.Size(50, 50)
        Me.picUserImage.TabIndex = 0
        Me.picUserImage.TabStop = False
        '
        'labelUsername
        '
        Me.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelUsername.AutoSize = True
        Me.labelUsername.BackColor = System.Drawing.Color.Transparent
        Me.labelUsername.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsername.Location = New System.Drawing.Point(10, 26)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(80, 18)
        Me.labelUsername.TabIndex = 7
        Me.labelUsername.Text = "USERNAME!"
        Me.labelUsername.UseMnemonic = False
        '
        'labelGreeter
        '
        Me.labelGreeter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelGreeter.AutoSize = True
        Me.labelGreeter.BackColor = System.Drawing.Color.Transparent
        Me.labelGreeter.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGreeter.Location = New System.Drawing.Point(10, 9)
        Me.labelGreeter.Name = "labelGreeter"
        Me.labelGreeter.Size = New System.Drawing.Size(88, 18)
        Me.labelGreeter.TabIndex = 6
        Me.labelGreeter.Text = "Greetings,"
        Me.labelGreeter.UseMnemonic = False
        '
        'ButtonDebug2
        '
        Me.ButtonDebug2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonDebug2.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonDebug2.Cursor = System.Windows.Forms.Cursors.Help
        Me.ButtonDebug2.Location = New System.Drawing.Point(423, 27)
        Me.ButtonDebug2.Name = "ButtonDebug2"
        Me.ButtonDebug2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDebug2.TabIndex = 8
        Me.ButtonDebug2.Text = "DEBUG 2"
        Me.ButtonDebug2.UseVisualStyleBackColor = False
        '
        'PicCollections
        '
        Me.PicCollections.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCollections.BackColor = System.Drawing.Color.Transparent
        Me.PicCollections.BackgroundImage = Global.Argus.My.Resources.Resources.collections
        Me.PicCollections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicCollections.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicCollections.Location = New System.Drawing.Point(540, 0)
        Me.PicCollections.Name = "PicCollections"
        Me.PicCollections.Size = New System.Drawing.Size(50, 50)
        Me.PicCollections.TabIndex = 9
        Me.PicCollections.TabStop = False
        '
        'NotifyIconLauncher
        '
        Me.NotifyIconLauncher.ContextMenuStrip = Me.ContextMenuTrayIcon
        Me.NotifyIconLauncher.Icon = CType(resources.GetObject("NotifyIconLauncher.Icon"), System.Drawing.Icon)
        Me.NotifyIconLauncher.Text = "Argus"
        Me.NotifyIconLauncher.Visible = True
        '
        'ContextMenuTrayIcon
        '
        Me.ContextMenuTrayIcon.DropShadowEnabled = False
        Me.ContextMenuTrayIcon.Font = New System.Drawing.Font("Fira Sans", 11.33333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuTrayIcon.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.ContextMenuTrayIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrayMenuItemToggleVisibility, Me.ToolStripSeparator2, Me.TrayMenuSettings, Me.ToolStripSeparator1, Me.TrayMenuItemExit})
        Me.ContextMenuTrayIcon.Name = "ContextMenuTrayIcon"
        Me.ContextMenuTrayIcon.Size = New System.Drawing.Size(197, 119)
        '
        'TrayMenuItemToggleVisibility
        '
        Me.TrayMenuItemToggleVisibility.Name = "TrayMenuItemToggleVisibility"
        Me.TrayMenuItemToggleVisibility.Size = New System.Drawing.Size(196, 26)
        Me.TrayMenuItemToggleVisibility.Text = "Toggle Visiblity"
        '
        'TrayMenuItemExit
        '
        Me.TrayMenuItemExit.Name = "TrayMenuItemExit"
        Me.TrayMenuItemExit.Size = New System.Drawing.Size(196, 26)
        Me.TrayMenuItemExit.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'TrayMenuSettings
        '
        Me.TrayMenuSettings.Name = "TrayMenuSettings"
        Me.TrayMenuSettings.Size = New System.Drawing.Size(196, 26)
        Me.TrayMenuSettings.Text = "Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
        '
        'FormHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 50)
        Me.Controls.Add(Me.PicCollections)
        Me.Controls.Add(Me.ButtonDebug2)
        Me.Controls.Add(Me.labelUsername)
        Me.Controls.Add(Me.labelGreeter)
        Me.Controls.Add(Me.ButtonDebug)
        Me.Controls.Add(Me.labelYear)
        Me.Controls.Add(Me.labelLongDate)
        Me.Controls.Add(Me.labelToday)
        Me.Controls.Add(Me.labelClock)
        Me.Controls.Add(Me.picUserImage)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormHeader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Here Be Dragons"
        Me.TopMost = True
        CType(Me.picUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCollections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuTrayIcon.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picUserImage As PictureBox
    Friend WithEvents labelClock As Label
    Friend WithEvents TimerClockTick As Timer
    Friend WithEvents labelToday As Label
    Friend WithEvents labelLongDate As Label
    Friend WithEvents labelYear As Label
    Friend WithEvents ButtonDebug As Button
    Friend WithEvents labelUsername As Label
    Friend WithEvents labelGreeter As Label
    Friend WithEvents ButtonDebug2 As Button
    Friend WithEvents PicCollections As PictureBox
    Friend WithEvents NotifyIconLauncher As NotifyIcon
    Friend WithEvents ContextMenuTrayIcon As ContextMenuStrip
    Friend WithEvents TrayMenuItemExit As ToolStripMenuItem
    Friend WithEvents TrayMenuItemToggleVisibility As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TrayMenuSettings As ToolStripMenuItem
End Class
