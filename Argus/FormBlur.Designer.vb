<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBlur
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
        Me.pickBlurImg = New System.Windows.Forms.PictureBox()
        CType(Me.pickBlurImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pickBlurImg
        '
        Me.pickBlurImg.BackColor = System.Drawing.Color.Transparent
        Me.pickBlurImg.BackgroundImage = Global.Argus.My.Resources.Resources.bg
        Me.pickBlurImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pickBlurImg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pickBlurImg.Location = New System.Drawing.Point(0, 0)
        Me.pickBlurImg.Name = "pickBlurImg"
        Me.pickBlurImg.Size = New System.Drawing.Size(1280, 720)
        Me.pickBlurImg.TabIndex = 0
        Me.pickBlurImg.TabStop = False
        '
        'FormBlur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.pickBlurImg)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "FormBlur"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "blur"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pickBlurImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pickBlurImg As PictureBox
End Class
