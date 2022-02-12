Imports Argus.ArgusCommon

Public Class FormUserMenu

    'Start/Load
    Private Sub FormUserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        'Set Location
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2 - (Me.Width / 2)), (Screen.PrimaryScreen.Bounds.Height / 2 - (Me.Height / 2)))

        'Set Button 4
        lblOption4.Text = "Settings"
        picOption4.Image = New Bitmap(ResizeImage(My.Resources.settings, picOption4.Height))

        'Set Exit Button
        picExit.Image = New Bitmap(ResizeImage(My.Resources.logout, picExit.Height))

    End Sub




    'Settings Button
    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblOption4.Click

        FormSettings.Show()
        FormSettings.Activate()

    End Sub

    Private Sub picSettings_Click(sender As Object, e As EventArgs) Handles picOption4.Click

        FormSettings.Show()
        FormSettings.Activate()

    End Sub


    'Exit Button
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click

        FormHeader.Close()

    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click

        FormHeader.Close()

    End Sub

End Class