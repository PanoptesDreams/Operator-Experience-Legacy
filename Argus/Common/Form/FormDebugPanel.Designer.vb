<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDebugPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDebugPanel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelDebugName = New System.Windows.Forms.Label()
        Me.PanelHider = New System.Windows.Forms.Panel()
        Me.LabelRewritable = New System.Windows.Forms.Label()
        Me.ButtonOpenStartMenu = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ButtonMakeINI = New System.Windows.Forms.Button()
        Me.ButtonRND = New System.Windows.Forms.Button()
        Me.ListBoxArguments = New System.Windows.Forms.ListBox()
        Me.ButtonWriteKey = New System.Windows.Forms.Button()
        Me.ComboBoxForms = New System.Windows.Forms.ComboBox()
        Me.ButtonOpenForm = New System.Windows.Forms.Button()
        Me.ComboBoxArgusMood = New System.Windows.Forms.ComboBox()
        Me.ButtonDiskSpace = New System.Windows.Forms.Button()
        Me.PanelHider.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(569, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(66, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(569, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(66, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(569, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(66, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(569, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(66, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(569, 211)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(66, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        '
        'LabelDebugName
        '
        Me.LabelDebugName.AutoSize = True
        Me.LabelDebugName.Location = New System.Drawing.Point(777, 178)
        Me.LabelDebugName.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelDebugName.Name = "LabelDebugName"
        Me.LabelDebugName.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelDebugName.Size = New System.Drawing.Size(90, 27)
        Me.LabelDebugName.TabIndex = 3
        Me.LabelDebugName.Text = "DebugNAME"
        '
        'PanelHider
        '
        Me.PanelHider.Controls.Add(Me.LabelRewritable)
        Me.PanelHider.Location = New System.Drawing.Point(10, 324)
        Me.PanelHider.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelHider.Name = "PanelHider"
        Me.PanelHider.Size = New System.Drawing.Size(267, 44)
        Me.PanelHider.TabIndex = 7
        '
        'LabelRewritable
        '
        Me.LabelRewritable.AutoSize = True
        Me.LabelRewritable.Location = New System.Drawing.Point(31, 15)
        Me.LabelRewritable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRewritable.Name = "LabelRewritable"
        Me.LabelRewritable.Size = New System.Drawing.Size(208, 17)
        Me.LabelRewritable.TabIndex = 0
        Me.LabelRewritable.Text = "Rewritable Label Click Me"
        '
        'ButtonOpenStartMenu
        '
        Me.ButtonOpenStartMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpenStartMenu.Location = New System.Drawing.Point(723, 10)
        Me.ButtonOpenStartMenu.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonOpenStartMenu.Name = "ButtonOpenStartMenu"
        Me.ButtonOpenStartMenu.Size = New System.Drawing.Size(144, 32)
        Me.ButtonOpenStartMenu.TabIndex = 9
        Me.ButtonOpenStartMenu.Text = "Open Start Menu"
        Me.ButtonOpenStartMenu.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 335)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(267, 26)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'ButtonMakeINI
        '
        Me.ButtonMakeINI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMakeINI.Location = New System.Drawing.Point(723, 70)
        Me.ButtonMakeINI.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonMakeINI.Name = "ButtonMakeINI"
        Me.ButtonMakeINI.Size = New System.Drawing.Size(144, 32)
        Me.ButtonMakeINI.TabIndex = 11
        Me.ButtonMakeINI.Text = "Make INI File"
        Me.ButtonMakeINI.UseVisualStyleBackColor = True
        '
        'ButtonRND
        '
        Me.ButtonRND.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRND.Location = New System.Drawing.Point(723, 136)
        Me.ButtonRND.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonRND.Name = "ButtonRND"
        Me.ButtonRND.Size = New System.Drawing.Size(144, 32)
        Me.ButtonRND.TabIndex = 12
        Me.ButtonRND.Text = "RND"
        Me.ButtonRND.UseVisualStyleBackColor = True
        '
        'ListBoxArguments
        '
        Me.ListBoxArguments.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ListBoxArguments.FormattingEnabled = True
        Me.ListBoxArguments.ItemHeight = 15
        Me.ListBoxArguments.Location = New System.Drawing.Point(10, 10)
        Me.ListBoxArguments.Margin = New System.Windows.Forms.Padding(5)
        Me.ListBoxArguments.Name = "ListBoxArguments"
        Me.ListBoxArguments.Size = New System.Drawing.Size(363, 199)
        Me.ListBoxArguments.TabIndex = 15
        '
        'ButtonWriteKey
        '
        Me.ButtonWriteKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonWriteKey.Location = New System.Drawing.Point(707, 427)
        Me.ButtonWriteKey.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonWriteKey.Name = "ButtonWriteKey"
        Me.ButtonWriteKey.Size = New System.Drawing.Size(160, 32)
        Me.ButtonWriteKey.TabIndex = 17
        Me.ButtonWriteKey.Text = "Write Key"
        Me.ButtonWriteKey.UseVisualStyleBackColor = True
        '
        'ComboBoxForms
        '
        Me.ComboBoxForms.FormattingEnabled = True
        Me.ComboBoxForms.Location = New System.Drawing.Point(10, 539)
        Me.ComboBoxForms.Name = "ComboBoxForms"
        Me.ComboBoxForms.Size = New System.Drawing.Size(363, 23)
        Me.ComboBoxForms.TabIndex = 18
        '
        'ButtonOpenForm
        '
        Me.ButtonOpenForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpenForm.Location = New System.Drawing.Point(10, 499)
        Me.ButtonOpenForm.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonOpenForm.Name = "ButtonOpenForm"
        Me.ButtonOpenForm.Size = New System.Drawing.Size(160, 32)
        Me.ButtonOpenForm.TabIndex = 19
        Me.ButtonOpenForm.Text = "Open"
        Me.ButtonOpenForm.UseVisualStyleBackColor = True
        '
        'ComboBoxArgusMood
        '
        Me.ComboBoxArgusMood.FormattingEnabled = True
        Me.ComboBoxArgusMood.Items.AddRange(New Object() {"Happy", "Neutral", "Bad"})
        Me.ComboBoxArgusMood.Location = New System.Drawing.Point(10, 217)
        Me.ComboBoxArgusMood.Name = "ComboBoxArgusMood"
        Me.ComboBoxArgusMood.Size = New System.Drawing.Size(363, 23)
        Me.ComboBoxArgusMood.TabIndex = 20
        '
        'ButtonDiskSpace
        '
        Me.ButtonDiskSpace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDiskSpace.Location = New System.Drawing.Point(707, 358)
        Me.ButtonDiskSpace.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonDiskSpace.Name = "ButtonDiskSpace"
        Me.ButtonDiskSpace.Size = New System.Drawing.Size(160, 32)
        Me.ButtonDiskSpace.TabIndex = 21
        Me.ButtonDiskSpace.Text = "DiskSpace"
        Me.ButtonDiskSpace.UseVisualStyleBackColor = True
        '
        'FormDebugPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 570)
        Me.Controls.Add(Me.ButtonDiskSpace)
        Me.Controls.Add(Me.ComboBoxArgusMood)
        Me.Controls.Add(Me.ButtonOpenForm)
        Me.Controls.Add(Me.ComboBoxForms)
        Me.Controls.Add(Me.ButtonWriteKey)
        Me.Controls.Add(Me.ListBoxArguments)
        Me.Controls.Add(Me.ButtonRND)
        Me.Controls.Add(Me.ButtonMakeINI)
        Me.Controls.Add(Me.PanelHider)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ButtonOpenStartMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelDebugName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormDebugPanel"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Argus Debug Panel"
        Me.PanelHider.ResumeLayout(False)
        Me.PanelHider.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelDebugName As Label
    Friend WithEvents PanelHider As Panel
    Friend WithEvents LabelRewritable As Label
    Friend WithEvents ButtonOpenStartMenu As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ButtonMakeINI As Button
    Friend WithEvents ButtonRND As Button
    Friend WithEvents ListBoxArguments As ListBox
    Friend WithEvents ButtonWriteKey As Button
    Friend WithEvents ComboBoxForms As ComboBox
    Friend WithEvents ButtonOpenForm As Button
    Friend WithEvents ComboBoxArgusMood As ComboBox
    Friend WithEvents ButtonDiskSpace As Button
End Class
