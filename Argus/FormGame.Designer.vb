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
        Me.lstGames.Location = New System.Drawing.Point(751, 17)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(221, 446)
        Me.lstGames.TabIndex = 0
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoSize = True
        Me.lblGameTitle.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.Location = New System.Drawing.Point(47, 22)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(110, 22)
        Me.lblGameTitle.TabIndex = 1
        Me.lblGameTitle.Text = "Game Title"
        '
        'panelTMP
        '
        Me.panelTMP.Controls.Add(Me.picInstalled)
        Me.panelTMP.Location = New System.Drawing.Point(12, 469)
        Me.panelTMP.Name = "panelTMP"
        Me.panelTMP.Size = New System.Drawing.Size(960, 130)
        Me.panelTMP.TabIndex = 5
        '
        'picInstalled
        '
        Me.picInstalled.Location = New System.Drawing.Point(16, 14)
        Me.picInstalled.Name = "picInstalled"
        Me.picInstalled.Size = New System.Drawing.Size(32, 32)
        Me.picInstalled.TabIndex = 3
        Me.picInstalled.TabStop = False
        '
        'picPlatform
        '
        Me.picPlatform.Location = New System.Drawing.Point(694, 413)
        Me.picPlatform.Name = "picPlatform"
        Me.picPlatform.Size = New System.Drawing.Size(51, 50)
        Me.picPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlatform.TabIndex = 3
        Me.picPlatform.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(12, 109)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'picGameIcon
        '
        Me.picGameIcon.Location = New System.Drawing.Point(12, 17)
        Me.picGameIcon.Name = "picGameIcon"
        Me.picGameIcon.Size = New System.Drawing.Size(32, 32)
        Me.picGameIcon.TabIndex = 2
        Me.picGameIcon.TabStop = False
        '
        'picPoster
        '
        Me.picPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPoster.InitialImage = Nothing
        Me.picPoster.Location = New System.Drawing.Point(500, 17)
        Me.picPoster.Name = "picPoster"
        Me.picPoster.Size = New System.Drawing.Size(245, 300)
        Me.picPoster.TabIndex = 2
        Me.picPoster.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblGenre
        '
        Me.LblGenre.AutoSize = True
        Me.LblGenre.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGenre.Location = New System.Drawing.Point(12, 52)
        Me.LblGenre.Name = "LblGenre"
        Me.LblGenre.Size = New System.Drawing.Size(42, 15)
        Me.LblGenre.TabIndex = 7
        Me.LblGenre.Text = "Genre"
        '
        'LblGameDir
        '
        Me.LblGameDir.AutoSize = True
        Me.LblGameDir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameDir.Location = New System.Drawing.Point(258, 245)
        Me.LblGameDir.Name = "LblGameDir"
        Me.LblGameDir.Size = New System.Drawing.Size(105, 15)
        Me.LblGameDir.TabIndex = 8
        Me.LblGameDir.Text = "LABEL GaME DIR"
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 611)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
