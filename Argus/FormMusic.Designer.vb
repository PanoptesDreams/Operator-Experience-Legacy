<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMusic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMusic))
        Me.MediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ListBoxMusic = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MediaPlayer1
        '
        Me.MediaPlayer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MediaPlayer1.Enabled = True
        Me.MediaPlayer1.Location = New System.Drawing.Point(71, 12)
        Me.MediaPlayer1.Name = "MediaPlayer1"
        Me.MediaPlayer1.OcxState = CType(resources.GetObject("MediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer1.Size = New System.Drawing.Size(382, 117)
        Me.MediaPlayer1.TabIndex = 0
        '
        'ListBoxMusic
        '
        Me.ListBoxMusic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxMusic.FormattingEnabled = True
        Me.ListBoxMusic.Location = New System.Drawing.Point(12, 157)
        Me.ListBoxMusic.Name = "ListBoxMusic"
        Me.ListBoxMusic.Size = New System.Drawing.Size(513, 95)
        Me.ListBoxMusic.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(459, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormMusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(537, 286)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBoxMusic)
        Me.Controls.Add(Me.MediaPlayer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMusic"
        Me.Text = "Argus - Music"
        Me.TopMost = True
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ListBoxMusic As ListBox
    Friend WithEvents Button1 As Button
End Class
