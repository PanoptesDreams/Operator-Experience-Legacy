Imports Argus.ArgusCommon

Public Class FormOpMenu

    'Form Mover Variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    'Start/Load
    Private Sub FormUserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        'Set Location
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2 - (Me.Width / 2)), (Screen.PrimaryScreen.Bounds.Height / 2 - (Me.Height / 2)))

        InitButtons()

    End Sub

    'User Buttons
#Region "Buttons"

    Public Sub InitButtons()
        'Set Collections Button
        LabelOption0.Text = "Collections"
        PicOption0.Image = My.Resources.collections

        'Set Web Home Button
        LabelOption1.Text = "Operator Homepage"
        PicOption1.Image = My.Resources.core

        'Set Debug Menu Button
        LabelOption2.Text = "Debug Menu"
        PicOption2.Image = My.Resources.core

        'Set Settings Button
        LabelOption3.Text = "Settings"
        PicOption3.Image = New Bitmap(ResizeImage(My.Resources.settings, PicOption3.Width, PicOption3.Height))

        'Set Exit Button
        LabelOption4.Text = "Exit"
        PicOption4.Image = New Bitmap(ResizeImage(My.Resources.logout, PicOption3.Width, PicOption4.Height))
    End Sub

    'Collections - Option Button (0)
    Private Sub LabelOption0_Click(sender As Object, e As EventArgs) Handles LabelOption0.Click
        Summon(FormCollections)
    End Sub

    Private Sub PicOption0_Click(sender As Object, e As EventArgs) Handles PicOption0.Click
        Summon(FormCollections)
    End Sub

    'Operator Homepage - Option Button (1)
    Private Sub PicOption1_Click(sender As Object, e As EventArgs) Handles PicOption1.Click

        Summon(FormHomepage)

    End Sub

    Private Sub LabelOption1_Click(sender As Object, e As EventArgs) Handles LabelOption1.Click

        Summon(FormHomepage)

    End Sub

    'Debug Menu - Option Button (2)
    Private Sub PicOption2_Click(sender As Object, e As EventArgs) Handles PicOption2.Click

        FormDebugPanel.ButtonOpenStartMenu_Click(sender, e)

    End Sub

    Private Sub LabelOption2_Click(sender As Object, e As EventArgs) Handles LabelOption2.Click

        Summon(FormDebugPanel)

    End Sub

    'Settings - Option Button (3)
    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles LabelOption3.Click

        FormSettings.Show()
        FormSettings.Activate()

    End Sub

    Private Sub picSettings_Click(sender As Object, e As EventArgs) Handles PicOption3.Click

        FormSettings.Show()
        FormSettings.Activate()

    End Sub

    'Exit - Option Button (4)
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles LabelOption4.Click

        Application.Exit()

    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles PicOption4.Click

        Application.Exit()

    End Sub
#End Region

    'Move form with click drag
#Region "Move" 'Mouse down, Mouse Move, Mouse Release
    'Main Form
    Private Sub FormUserMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        FormMoverGrab(Me)

    End Sub

    Private Sub FormUserMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        FormMover(Me)

    End Sub

    Private Sub FormUserMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        My.Settings.LauncherLastPos = Location
        ASave()

        FormMoverRelease()

    End Sub

    'UserPanel
    Private Sub PanelUserMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelUserMenu.MouseDown

        FormMoverGrab(Me)

    End Sub

    Private Sub PanelUserMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelUserMenu.MouseMove

        FormMover(Me)

    End Sub

    Private Sub PanelUserMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelUserMenu.MouseUp

        My.Settings.LauncherLastPos = Location
        ASave()

        FormMoverRelease()

    End Sub
#End Region

    'Close
    Private Sub ButtonCloseUserMenu_Click(sender As Object, e As EventArgs) Handles ButtonCloseUserMenu.Click

        Application.Exit()

    End Sub


End Class