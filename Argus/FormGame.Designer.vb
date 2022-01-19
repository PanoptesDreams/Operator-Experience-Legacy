<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGame))
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.panelTMP = New System.Windows.Forms.Panel()
        Me.picInstalled = New System.Windows.Forms.PictureBox()
        Me.picPlatform = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.picGameIcon = New System.Windows.Forms.PictureBox()
        Me.picPoster = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblGenre = New System.Windows.Forms.Label()
        Me.LblGameDir = New System.Windows.Forms.Label()
        Me.panelTMP.SuspendLayout()
        CType(Me.picInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGameIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstGames
        '
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.ItemHeight = 17
        Me.lstGames.Location = New System.Drawing.Point(1001, 22)
        Me.lstGames.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(293, 582)
        Me.lstGames.TabIndex = 0
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoSize = True
        Me.lblGameTitle.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.Location = New System.Drawing.Point(63, 29)
        Me.lblGameTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(132, 26)
        Me.lblGameTitle.TabIndex = 1
        Me.lblGameTitle.Text = "Game Title"
        '
        'panelTMP
        '
        Me.panelTMP.Controls.Add(Me.picInstalled)
        Me.panelTMP.Location = New System.Drawing.Point(16, 613)
        Me.panelTMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelTMP.Name = "panelTMP"
        Me.panelTMP.Size = New System.Drawing.Size(1280, 170)
        Me.panelTMP.TabIndex = 5
        '
        'picInstalled
        '
        Me.picInstalled.Location = New System.Drawing.Point(21, 18)
        Me.picInstalled.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picInstalled.Name = "picInstalled"
        Me.picInstalled.Size = New System.Drawing.Size(43, 42)
        Me.picInstalled.TabIndex = 3
        Me.picInstalled.TabStop = False
        '
        'picPlatform
        '
        Me.picPlatform.Location = New System.Drawing.Point(925, 540)
        Me.picPlatform.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlatform.Name = "picPlatform"
        Me.picPlatform.Size = New System.Drawing.Size(68, 65)
        Me.picPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlatform.TabIndex = 3
        Me.picPlatform.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(16, 143)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(43, 42)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'picGameIcon
        '
        Me.picGameIcon.Location = New System.Drawing.Point(16, 22)
        Me.picGameIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picGameIcon.Name = "picGameIcon"
        Me.picGameIcon.Size = New System.Drawing.Size(43, 42)
        Me.picGameIcon.TabIndex = 2
        Me.picGameIcon.TabStop = False
        '
        'picPoster
        '
        Me.picPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPoster.InitialImage = Nothing
        Me.picPoster.Location = New System.Drawing.Point(667, 22)
        Me.picPoster.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPoster.Name = "picPoster"
        Me.picPoster.Size = New System.Drawing.Size(327, 392)
        Me.picPoster.TabIndex = 2
        Me.picPoster.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 564)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblGenre
        '
        Me.LblGenre.AutoSize = True
        Me.LblGenre.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGenre.Location = New System.Drawing.Point(16, 68)
        Me.LblGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGenre.Name = "LblGenre"
        Me.LblGenre.Size = New System.Drawing.Size(48, 18)
        Me.LblGenre.TabIndex = 7
        Me.LblGenre.Text = "Genre"
        '
        'LblGameDir
        '
        Me.LblGameDir.AutoSize = True
        Me.LblGameDir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameDir.Location = New System.Drawing.Point(344, 320)
        Me.LblGameDir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGameDir.Name = "LblGameDir"
        Me.LblGameDir.Size = New System.Drawing.Size(120, 18)
        Me.LblGameDir.TabIndex = 8
        Me.LblGameDir.Text = "LABEL GaME DIR"
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumBlue
        Me.ClientSize = New System.Drawing.Size(1312, 799)
        Me.Controls.Add(Me.LblGameDir)
        Me.Controls.Add(Me.LblGenre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picPlatform)
        Me.Controls.Add(Me.panelTMP)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.picGameIcon)
        Me.Controls.Add(Me.picPoster)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Controls.Add(Me.lstGames)
        Me.Font = New System.Drawing.Font("Fira Sans", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Argus • Games"
        Me.TopMost = True
        Me.panelTMP.ResumeLayout(False)
        CType(Me.picInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGameIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGames As ListBox
    Friend WithEvents lblGameTitle As Label
    Friend WithEvents picPoster As PictureBox
    Friend WithEvents picGameIcon As PictureBox
    Friend WithEvents picInstalled As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents picPlatform As PictureBox
    Friend WithEvents panelTMP As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents LblGenre As Label
    Friend WithEvents LblGameDir As Label
End Class
