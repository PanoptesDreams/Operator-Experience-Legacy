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
        Me.lblClock = New System.Windows.Forms.Label()
        Me.TimerClockTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblLongDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.BtnDebug = New System.Windows.Forms.Button()
        Me.PicUser = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblGreet = New System.Windows.Forms.Label()
        Me.btnDebug2 = New System.Windows.Forms.Button()
        CType(Me.PicUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClock
        '
        Me.lblClock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.Silver
        Me.lblClock.Location = New System.Drawing.Point(327, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(72, 18)
        Me.lblClock.TabIndex = 2
        Me.lblClock.Text = "00:00 XX"
        Me.lblClock.UseMnemonic = False
        '
        'TimerClockTick
        '
        Me.TimerClockTick.Enabled = True
        Me.TimerClockTick.Interval = 200
        '
        'lblDay
        '
        Me.lblDay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.Silver
        Me.lblDay.Location = New System.Drawing.Point(184, 9)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(94, 19)
        Me.lblDay.TabIndex = 3
        Me.lblDay.Text = "TODAY"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblDay.UseMnemonic = False
        '
        'lblLongDate
        '
        Me.lblLongDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLongDate.BackColor = System.Drawing.Color.Transparent
        Me.lblLongDate.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongDate.ForeColor = System.Drawing.Color.Silver
        Me.lblLongDate.Location = New System.Drawing.Point(161, 26)
        Me.lblLongDate.Name = "lblLongDate"
        Me.lblLongDate.Size = New System.Drawing.Size(117, 19)
        Me.lblLongDate.TabIndex = 3
        Me.lblLongDate.Text = "XX MONTH"
        Me.lblLongDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblLongDate.UseMnemonic = False
        '
        'lblYear
        '
        Me.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Silver
        Me.lblYear.Location = New System.Drawing.Point(327, 26)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(40, 18)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "XXXX"
        Me.lblYear.UseMnemonic = False
        '
        'BtnDebug
        '
        Me.BtnDebug.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnDebug.BackColor = System.Drawing.Color.LightCoral
        Me.BtnDebug.Enabled = False
        Me.BtnDebug.Location = New System.Drawing.Point(497, 3)
        Me.BtnDebug.Name = "BtnDebug"
        Me.BtnDebug.Size = New System.Drawing.Size(75, 23)
        Me.BtnDebug.TabIndex = 5
        Me.BtnDebug.Text = "DEBUG"
        Me.BtnDebug.UseVisualStyleBackColor = False
        Me.BtnDebug.Visible = False
        '
        'PicUser
        '
        Me.PicUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicUser.BackColor = System.Drawing.Color.Transparent
        Me.PicUser.BackgroundImage = Global.Argus.My.Resources.Resources.user
        Me.PicUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicUser.Location = New System.Drawing.Point(275, 0)
        Me.PicUser.Name = "PicUser"
        Me.PicUser.Size = New System.Drawing.Size(50, 50)
        Me.PicUser.TabIndex = 0
        Me.PicUser.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Silver
        Me.lblUser.Location = New System.Drawing.Point(10, 26)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(80, 18)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "USERNAME!"
        Me.lblUser.UseMnemonic = False
        '
        'lblGreet
        '
        Me.lblGreet.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGreet.AutoSize = True
        Me.lblGreet.BackColor = System.Drawing.Color.Transparent
        Me.lblGreet.Font = New System.Drawing.Font("Consolas", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreet.ForeColor = System.Drawing.Color.Silver
        Me.lblGreet.Location = New System.Drawing.Point(10, 9)
        Me.lblGreet.Name = "lblGreet"
        Me.lblGreet.Size = New System.Drawing.Size(88, 18)
        Me.lblGreet.TabIndex = 6
        Me.lblGreet.Text = "Greetings,"
        Me.lblGreet.UseMnemonic = False
        '
        'btnDebug2
        '
        Me.btnDebug2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDebug2.BackColor = System.Drawing.Color.LightCoral
        Me.btnDebug2.Enabled = False
        Me.btnDebug2.Location = New System.Drawing.Point(497, 26)
        Me.btnDebug2.Name = "btnDebug2"
        Me.btnDebug2.Size = New System.Drawing.Size(75, 23)
        Me.btnDebug2.TabIndex = 8
        Me.btnDebug2.Text = "DEBUG 2"
        Me.btnDebug2.UseVisualStyleBackColor = False
        Me.btnDebug2.Visible = False
        '
        'FormHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = Global.Argus.My.Resources.Resources.strip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 50)
        Me.Controls.Add(Me.btnDebug2)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblGreet)
        Me.Controls.Add(Me.BtnDebug)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblLongDate)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.PicUser)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormHeader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Here Be Dragons"
        Me.TopMost = True
        CType(Me.PicUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicUser As PictureBox
    Friend WithEvents lblClock As Label
    Friend WithEvents TimerClockTick As Timer
    Friend WithEvents lblDay As Label
    Friend WithEvents lblLongDate As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents BtnDebug As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblGreet As Label
    Friend WithEvents btnDebug2 As Button
End Class
