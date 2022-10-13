<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSteamLinkGenerater
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
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.TextBoxGameIDinput = New System.Windows.Forms.TextBox()
        Me.LabelGameID = New System.Windows.Forms.Label()
        Me.ButtonStartCoreKeeper = New System.Windows.Forms.Button()
        Me.LabelGameName = New System.Windows.Forms.Label()
        Me.TextBoxGameNameInput = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ComboBoxGameList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(338, 297)
        Me.ButtonGenerate.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(125, 39)
        Me.ButtonGenerate.TabIndex = 0
        Me.ButtonGenerate.Text = "GO!"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'TextBoxGameIDinput
        '
        Me.TextBoxGameIDinput.Location = New System.Drawing.Point(12, 69)
        Me.TextBoxGameIDinput.Name = "TextBoxGameIDinput"
        Me.TextBoxGameIDinput.Size = New System.Drawing.Size(155, 29)
        Me.TextBoxGameIDinput.TabIndex = 1
        Me.TextBoxGameIDinput.Text = "Game ID...."
        '
        'LabelGameID
        '
        Me.LabelGameID.AutoSize = True
        Me.LabelGameID.Location = New System.Drawing.Point(51, 35)
        Me.LabelGameID.Name = "LabelGameID"
        Me.LabelGameID.Size = New System.Drawing.Size(78, 22)
        Me.LabelGameID.TabIndex = 2
        Me.LabelGameID.Text = "Game ID"
        '
        'ButtonStartCoreKeeper
        '
        Me.ButtonStartCoreKeeper.Location = New System.Drawing.Point(14, 297)
        Me.ButtonStartCoreKeeper.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonStartCoreKeeper.Name = "ButtonStartCoreKeeper"
        Me.ButtonStartCoreKeeper.Size = New System.Drawing.Size(125, 39)
        Me.ButtonStartCoreKeeper.TabIndex = 3
        Me.ButtonStartCoreKeeper.Text = "Core Keeper"
        Me.ButtonStartCoreKeeper.UseVisualStyleBackColor = True
        '
        'LabelGameName
        '
        Me.LabelGameName.AutoSize = True
        Me.LabelGameName.Location = New System.Drawing.Point(212, 35)
        Me.LabelGameName.Name = "LabelGameName"
        Me.LabelGameName.Size = New System.Drawing.Size(108, 22)
        Me.LabelGameName.TabIndex = 5
        Me.LabelGameName.Text = "Game Name"
        '
        'TextBoxGameNameInput
        '
        Me.TextBoxGameNameInput.Location = New System.Drawing.Point(173, 69)
        Me.TextBoxGameNameInput.Name = "TextBoxGameNameInput"
        Me.TextBoxGameNameInput.Size = New System.Drawing.Size(292, 29)
        Me.TextBoxGameNameInput.TabIndex = 4
        Me.TextBoxGameNameInput.Text = "Game Name...."
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(25, 106)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(125, 39)
        Me.ButtonAdd.TabIndex = 6
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ComboBoxGameList
        '
        Me.ComboBoxGameList.FormattingEnabled = True
        Me.ComboBoxGameList.Location = New System.Drawing.Point(173, 259)
        Me.ComboBoxGameList.Name = "ComboBoxGameList"
        Me.ComboBoxGameList.Size = New System.Drawing.Size(290, 30)
        Me.ComboBoxGameList.TabIndex = 7
        '
        'FormSteamLinkGenerater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 350)
        Me.Controls.Add(Me.ComboBoxGameList)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.LabelGameName)
        Me.Controls.Add(Me.TextBoxGameNameInput)
        Me.Controls.Add(Me.ButtonStartCoreKeeper)
        Me.Controls.Add(Me.LabelGameID)
        Me.Controls.Add(Me.TextBoxGameIDinput)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Font = New System.Drawing.Font("Fira Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormSteamLinkGenerater"
        Me.Text = "FormSteamLinkGenerater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGenerate As Button
    Friend WithEvents TextBoxGameIDinput As TextBox
    Friend WithEvents LabelGameID As Label
    Friend WithEvents ButtonStartCoreKeeper As Button
    Friend WithEvents LabelGameName As Label
    Friend WithEvents TextBoxGameNameInput As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ComboBoxGameList As ComboBox
End Class
