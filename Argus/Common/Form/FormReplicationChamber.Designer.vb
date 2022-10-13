<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReplicationChamber
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
        Me.ButtonBuild = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonFetch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonBuild
        '
        Me.ButtonBuild.Location = New System.Drawing.Point(683, 401)
        Me.ButtonBuild.Name = "ButtonBuild"
        Me.ButtonBuild.Size = New System.Drawing.Size(105, 37)
        Me.ButtonBuild.TabIndex = 0
        Me.ButtonBuild.Text = "ButtonBuild.Text"
        Me.ButtonBuild.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 450)
        Me.Panel1.TabIndex = 1
        '
        'ButtonFetch
        '
        Me.ButtonFetch.Location = New System.Drawing.Point(207, 401)
        Me.ButtonFetch.Name = "ButtonFetch"
        Me.ButtonFetch.Size = New System.Drawing.Size(105, 37)
        Me.ButtonFetch.TabIndex = 2
        Me.ButtonFetch.Text = "ButtonFetch.Text"
        Me.ButtonFetch.UseVisualStyleBackColor = True
        '
        'FormReplicationChamber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonFetch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonBuild)
        Me.Name = "FormReplicationChamber"
        Me.Text = "Replication Chamber"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonBuild As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonFetch As Button
End Class
