<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGame))
        Me.ListGamesWin = New System.Windows.Forms.ListBox()
        Me.LabelGameTitle = New System.Windows.Forms.Label()
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.LabelAppNote = New System.Windows.Forms.Label()
        Me.LabelOperatorNotes = New System.Windows.Forms.Label()
        Me.LblGameDir = New System.Windows.Forms.Label()
        Me.ButtonPlayGame = New System.Windows.Forms.Button()
        Me.LblGenre = New System.Windows.Forms.Label()
        Me.ButtonOpenGameFolder = New System.Windows.Forms.Button()
        Me.ButtonDebug0 = New System.Windows.Forms.Button()
        Me.ButtonDebug2 = New System.Windows.Forms.Button()
        Me.TabControlGameLists = New System.Windows.Forms.TabControl()
        Me.TabPageGameWinList = New System.Windows.Forms.TabPage()
        Me.TabPageGameXboxList = New System.Windows.Forms.TabPage()
        Me.ListGamesXbox = New System.Windows.Forms.ListBox()
        Me.TabPageGamePlaystationList = New System.Windows.Forms.TabPage()
        Me.ListGamesPlaystation = New System.Windows.Forms.ListBox()
        Me.TabPageGameNintendoList = New System.Windows.Forms.TabPage()
        Me.ListGamesNintendo = New System.Windows.Forms.ListBox()
        Me.ButtonEditOperatorNotes = New System.Windows.Forms.Button()
        Me.picGameIcon = New System.Windows.Forms.PictureBox()
        Me.picPoster = New System.Windows.Forms.PictureBox()
        Me.picPlatform = New System.Windows.Forms.PictureBox()
        Me.PanelInfo.SuspendLayout()
        Me.TabControlGameLists.SuspendLayout()
        Me.TabPageGameWinList.SuspendLayout()
        Me.TabPageGameXboxList.SuspendLayout()
        Me.TabPageGamePlaystationList.SuspendLayout()
        Me.TabPageGameNintendoList.SuspendLayout()
        CType(Me.picGameIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListGamesWin
        '
        Me.ListGamesWin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGamesWin.FormattingEnabled = True
        Me.ListGamesWin.ItemHeight = 22
        Me.ListGamesWin.Location = New System.Drawing.Point(3, 3)
        Me.ListGamesWin.Margin = New System.Windows.Forms.Padding(0)
        Me.ListGamesWin.Name = "ListGamesWin"
        Me.ListGamesWin.Size = New System.Drawing.Size(386, 515)
        Me.ListGamesWin.TabIndex = 0
        '
        'LabelGameTitle
        '
        Me.LabelGameTitle.AutoSize = True
        Me.LabelGameTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelGameTitle.Location = New System.Drawing.Point(80, 34)
        Me.LabelGameTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelGameTitle.Name = "LabelGameTitle"
        Me.LabelGameTitle.Size = New System.Drawing.Size(96, 22)
        Me.LabelGameTitle.TabIndex = 1
        Me.LabelGameTitle.Text = "Game Title"
        '
        'PanelInfo
        '
        Me.PanelInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelInfo.Controls.Add(Me.LabelAppNote)
        Me.PanelInfo.Controls.Add(Me.LabelOperatorNotes)
        Me.PanelInfo.Location = New System.Drawing.Point(14, 373)
        Me.PanelInfo.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New System.Drawing.Size(582, 169)
        Me.PanelInfo.TabIndex = 5
        '
        'LabelAppNote
        '
        Me.LabelAppNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAppNote.Font = New System.Drawing.Font("Fira Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppNote.Location = New System.Drawing.Point(3, 3)
        Me.LabelAppNote.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelAppNote.Name = "LabelAppNote"
        Me.LabelAppNote.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.LabelAppNote.Size = New System.Drawing.Size(285, 163)
        Me.LabelAppNote.TabIndex = 10
        Me.LabelAppNote.Text = "Long description of video game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Video game is a revolutionary genre game. Desc" &
    "ribed by critics as 'pretty good' and players and 'alright'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sample Text. SAM" &
    "PLE TEXT! ... SaMpLE TexT ⁉"
        '
        'LabelOperatorNotes
        '
        Me.LabelOperatorNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelOperatorNotes.Font = New System.Drawing.Font("Fira Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOperatorNotes.Location = New System.Drawing.Point(294, 3)
        Me.LabelOperatorNotes.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelOperatorNotes.Name = "LabelOperatorNotes"
        Me.LabelOperatorNotes.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.LabelOperatorNotes.Size = New System.Drawing.Size(285, 163)
        Me.LabelOperatorNotes.TabIndex = 9
        Me.LabelOperatorNotes.Text = "Notes written by the Operator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This particular game has issues with Discipline." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A good bug squashing 😩 from Papa Code Protector 🥺 should help"
        '
        'LblGameDir
        '
        Me.LblGameDir.AutoSize = True
        Me.LblGameDir.BackColor = System.Drawing.Color.Transparent
        Me.LblGameDir.Font = New System.Drawing.Font("Fira Sans", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameDir.Location = New System.Drawing.Point(81, 9)
        Me.LblGameDir.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblGameDir.Name = "LblGameDir"
        Me.LblGameDir.Size = New System.Drawing.Size(87, 13)
        Me.LblGameDir.TabIndex = 8
        Me.LblGameDir.Text = "LABEL GaME DIR"
        '
        'ButtonPlayGame
        '
        Me.ButtonPlayGame.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonPlayGame.Location = New System.Drawing.Point(14, 324)
        Me.ButtonPlayGame.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonPlayGame.Name = "ButtonPlayGame"
        Me.ButtonPlayGame.Size = New System.Drawing.Size(60, 39)
        Me.ButtonPlayGame.TabIndex = 6
        Me.ButtonPlayGame.Text = "Play"
        Me.ButtonPlayGame.UseVisualStyleBackColor = True
        '
        'LblGenre
        '
        Me.LblGenre.AutoSize = True
        Me.LblGenre.BackColor = System.Drawing.Color.Transparent
        Me.LblGenre.Font = New System.Drawing.Font("Fira Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGenre.Location = New System.Drawing.Point(81, 64)
        Me.LblGenre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblGenre.Name = "LblGenre"
        Me.LblGenre.Size = New System.Drawing.Size(48, 18)
        Me.LblGenre.TabIndex = 7
        Me.LblGenre.Text = "Genre"
        '
        'ButtonOpenGameFolder
        '
        Me.ButtonOpenGameFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpenGameFolder.Location = New System.Drawing.Point(84, 324)
        Me.ButtonOpenGameFolder.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonOpenGameFolder.Name = "ButtonOpenGameFolder"
        Me.ButtonOpenGameFolder.Size = New System.Drawing.Size(120, 39)
        Me.ButtonOpenGameFolder.TabIndex = 9
        Me.ButtonOpenGameFolder.Text = "Open Folder"
        Me.ButtonOpenGameFolder.UseVisualStyleBackColor = True
        '
        'ButtonDebug0
        '
        Me.ButtonDebug0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDebug0.Location = New System.Drawing.Point(14, 275)
        Me.ButtonDebug0.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonDebug0.Name = "ButtonDebug0"
        Me.ButtonDebug0.Size = New System.Drawing.Size(78, 39)
        Me.ButtonDebug0.TabIndex = 11
        Me.ButtonDebug0.Text = "Debug"
        Me.ButtonDebug0.UseVisualStyleBackColor = True
        '
        'ButtonDebug2
        '
        Me.ButtonDebug2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDebug2.Location = New System.Drawing.Point(102, 275)
        Me.ButtonDebug2.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonDebug2.Name = "ButtonDebug2"
        Me.ButtonDebug2.Size = New System.Drawing.Size(78, 39)
        Me.ButtonDebug2.TabIndex = 12
        Me.ButtonDebug2.Text = "Debug"
        Me.ButtonDebug2.UseVisualStyleBackColor = True
        '
        'TabControlGameLists
        '
        Me.TabControlGameLists.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlGameLists.Controls.Add(Me.TabPageGameWinList)
        Me.TabControlGameLists.Controls.Add(Me.TabPageGameXboxList)
        Me.TabControlGameLists.Controls.Add(Me.TabPageGamePlaystationList)
        Me.TabControlGameLists.Controls.Add(Me.TabPageGameNintendoList)
        Me.TabControlGameLists.Location = New System.Drawing.Point(606, 0)
        Me.TabControlGameLists.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.TabControlGameLists.Multiline = True
        Me.TabControlGameLists.Name = "TabControlGameLists"
        Me.TabControlGameLists.SelectedIndex = 0
        Me.TabControlGameLists.Size = New System.Drawing.Size(400, 556)
        Me.TabControlGameLists.TabIndex = 13
        '
        'TabPageGameWinList
        '
        Me.TabPageGameWinList.Controls.Add(Me.ListGamesWin)
        Me.TabPageGameWinList.Location = New System.Drawing.Point(4, 31)
        Me.TabPageGameWinList.Name = "TabPageGameWinList"
        Me.TabPageGameWinList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGameWinList.Size = New System.Drawing.Size(392, 521)
        Me.TabPageGameWinList.TabIndex = 0
        Me.TabPageGameWinList.Text = "Win"
        Me.TabPageGameWinList.UseVisualStyleBackColor = True
        '
        'TabPageGameXboxList
        '
        Me.TabPageGameXboxList.Controls.Add(Me.ListGamesXbox)
        Me.TabPageGameXboxList.Location = New System.Drawing.Point(4, 31)
        Me.TabPageGameXboxList.Name = "TabPageGameXboxList"
        Me.TabPageGameXboxList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGameXboxList.Size = New System.Drawing.Size(392, 521)
        Me.TabPageGameXboxList.TabIndex = 1
        Me.TabPageGameXboxList.Text = "Xbox"
        Me.TabPageGameXboxList.UseVisualStyleBackColor = True
        '
        'ListGamesXbox
        '
        Me.ListGamesXbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGamesXbox.FormattingEnabled = True
        Me.ListGamesXbox.ItemHeight = 22
        Me.ListGamesXbox.Location = New System.Drawing.Point(3, 3)
        Me.ListGamesXbox.Margin = New System.Windows.Forms.Padding(0)
        Me.ListGamesXbox.Name = "ListGamesXbox"
        Me.ListGamesXbox.Size = New System.Drawing.Size(386, 515)
        Me.ListGamesXbox.TabIndex = 1
        '
        'TabPageGamePlaystationList
        '
        Me.TabPageGamePlaystationList.Controls.Add(Me.ListGamesPlaystation)
        Me.TabPageGamePlaystationList.Location = New System.Drawing.Point(4, 31)
        Me.TabPageGamePlaystationList.Name = "TabPageGamePlaystationList"
        Me.TabPageGamePlaystationList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGamePlaystationList.Size = New System.Drawing.Size(392, 521)
        Me.TabPageGamePlaystationList.TabIndex = 2
        Me.TabPageGamePlaystationList.Text = "Playstation"
        Me.TabPageGamePlaystationList.UseVisualStyleBackColor = True
        '
        'ListGamesPlaystation
        '
        Me.ListGamesPlaystation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGamesPlaystation.FormattingEnabled = True
        Me.ListGamesPlaystation.ItemHeight = 22
        Me.ListGamesPlaystation.Location = New System.Drawing.Point(3, 3)
        Me.ListGamesPlaystation.Margin = New System.Windows.Forms.Padding(0)
        Me.ListGamesPlaystation.Name = "ListGamesPlaystation"
        Me.ListGamesPlaystation.Size = New System.Drawing.Size(386, 515)
        Me.ListGamesPlaystation.TabIndex = 2
        '
        'TabPageGameNintendoList
        '
        Me.TabPageGameNintendoList.Controls.Add(Me.ListGamesNintendo)
        Me.TabPageGameNintendoList.Location = New System.Drawing.Point(4, 31)
        Me.TabPageGameNintendoList.Name = "TabPageGameNintendoList"
        Me.TabPageGameNintendoList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGameNintendoList.Size = New System.Drawing.Size(392, 521)
        Me.TabPageGameNintendoList.TabIndex = 3
        Me.TabPageGameNintendoList.Text = "Nintendo"
        Me.TabPageGameNintendoList.UseVisualStyleBackColor = True
        '
        'ListGamesNintendo
        '
        Me.ListGamesNintendo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGamesNintendo.FormattingEnabled = True
        Me.ListGamesNintendo.ItemHeight = 22
        Me.ListGamesNintendo.Location = New System.Drawing.Point(3, 3)
        Me.ListGamesNintendo.Margin = New System.Windows.Forms.Padding(0)
        Me.ListGamesNintendo.Name = "ListGamesNintendo"
        Me.ListGamesNintendo.Size = New System.Drawing.Size(386, 515)
        Me.ListGamesNintendo.TabIndex = 2
        '
        'ButtonEditOperatorNotes
        '
        Me.ButtonEditOperatorNotes.AccessibleDescription = "Opens dialogue box to edit operators notes"
        Me.ButtonEditOperatorNotes.AccessibleName = "Edit Operator Notes"
        Me.ButtonEditOperatorNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonEditOperatorNotes.Font = New System.Drawing.Font("Fira Sans", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditOperatorNotes.Location = New System.Drawing.Point(571, 344)
        Me.ButtonEditOperatorNotes.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonEditOperatorNotes.Name = "ButtonEditOperatorNotes"
        Me.ButtonEditOperatorNotes.Size = New System.Drawing.Size(25, 25)
        Me.ButtonEditOperatorNotes.TabIndex = 14
        Me.ButtonEditOperatorNotes.Text = "✏"
        Me.ButtonEditOperatorNotes.UseVisualStyleBackColor = True
        '
        'picGameIcon
        '
        Me.picGameIcon.BackColor = System.Drawing.Color.Transparent
        Me.picGameIcon.Location = New System.Drawing.Point(14, 34)
        Me.picGameIcon.Margin = New System.Windows.Forms.Padding(5)
        Me.picGameIcon.Name = "picGameIcon"
        Me.picGameIcon.Size = New System.Drawing.Size(54, 54)
        Me.picGameIcon.TabIndex = 2
        Me.picGameIcon.TabStop = False
        '
        'picPoster
        '
        Me.picPoster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPoster.BackgroundImage = Global.Argus.My.Resources.Resources.game_poster_mask
        Me.picPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPoster.InitialImage = Nothing
        Me.picPoster.Location = New System.Drawing.Point(393, 34)
        Me.picPoster.Margin = New System.Windows.Forms.Padding(5)
        Me.picPoster.Name = "picPoster"
        Me.picPoster.Size = New System.Drawing.Size(200, 300)
        Me.picPoster.TabIndex = 2
        Me.picPoster.TabStop = False
        '
        'picPlatform
        '
        Me.picPlatform.BackColor = System.Drawing.Color.Transparent
        Me.picPlatform.Location = New System.Drawing.Point(0, 0)
        Me.picPlatform.Margin = New System.Windows.Forms.Padding(5)
        Me.picPlatform.Name = "picPlatform"
        Me.picPlatform.Size = New System.Drawing.Size(85, 84)
        Me.picPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlatform.TabIndex = 3
        Me.picPlatform.TabStop = False
        '
        'FormGame
        '
        Me.AcceptButton = Me.ButtonPlayGame
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 556)
        Me.Controls.Add(Me.ButtonEditOperatorNotes)
        Me.Controls.Add(Me.TabControlGameLists)
        Me.Controls.Add(Me.LblGameDir)
        Me.Controls.Add(Me.ButtonDebug2)
        Me.Controls.Add(Me.ButtonDebug0)
        Me.Controls.Add(Me.ButtonOpenGameFolder)
        Me.Controls.Add(Me.LabelGameTitle)
        Me.Controls.Add(Me.LblGenre)
        Me.Controls.Add(Me.ButtonPlayGame)
        Me.Controls.Add(Me.PanelInfo)
        Me.Controls.Add(Me.picGameIcon)
        Me.Controls.Add(Me.picPoster)
        Me.Controls.Add(Me.picPlatform)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Fira Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "FormGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Argus • Games"
        Me.PanelInfo.ResumeLayout(False)
        Me.TabControlGameLists.ResumeLayout(False)
        Me.TabPageGameWinList.ResumeLayout(False)
        Me.TabPageGameXboxList.ResumeLayout(False)
        Me.TabPageGamePlaystationList.ResumeLayout(False)
        Me.TabPageGameNintendoList.ResumeLayout(False)
        CType(Me.picGameIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListGamesWin As ListBox
    Friend WithEvents LabelGameTitle As Label
    Friend WithEvents picPoster As PictureBox
    Friend WithEvents picGameIcon As PictureBox
    Friend WithEvents picPlatform As PictureBox
    Friend WithEvents PanelInfo As Panel
    Friend WithEvents ButtonPlayGame As Button
    Friend WithEvents LblGenre As Label
    Friend WithEvents LblGameDir As Label
    Friend WithEvents ButtonOpenGameFolder As Button
    Friend WithEvents ButtonDebug0 As Button
    Friend WithEvents ButtonDebug2 As Button
    Friend WithEvents TabControlGameLists As TabControl
    Friend WithEvents TabPageGameWinList As TabPage
    Friend WithEvents TabPageGameXboxList As TabPage
    Friend WithEvents TabPageGamePlaystationList As TabPage
    Friend WithEvents TabPageGameNintendoList As TabPage
    Friend WithEvents ListGamesXbox As ListBox
    Friend WithEvents ListGamesPlaystation As ListBox
    Friend WithEvents ListGamesNintendo As ListBox
    Friend WithEvents LabelAppNote As Label
    Friend WithEvents LabelOperatorNotes As Label
    Friend WithEvents ButtonEditOperatorNotes As Button
End Class
