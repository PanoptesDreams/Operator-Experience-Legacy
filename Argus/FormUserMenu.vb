Imports Argus.ArgusCommon

Public Class FormUserMenu

    'Start/Load
    Private Sub FormUserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        'Set Location
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2 - (Me.Width / 2)), (Screen.PrimaryScreen.Bounds.Height / 2 - (Me.Height / 2)))

        'Set Collections Button
        LabelOption0.Text = "Collections"
        PicOption0.Image = My.Resources.collections

        'Set Settings Button
        LabelOption3.Text = "Settings"
        PicOption3.Image = New Bitmap(ResizeImage(My.Resources.settings, PicOption3.Height))

        'Set Exit Button
        LabelOption4.Text = "Exit"
        PicOption4.Image = New Bitmap(ResizeImage(My.Resources.logout, PicOption4.Height))

    End Sub


    'Collections Button
    Private Sub LabelOption0_Click(sender As Object, e As EventArgs) Handles LabelOption0.Click
        Summon(FormCollections)
    End Sub

    Private Sub PicOption0_Click(sender As Object, e As EventArgs) Handles PicOption0.Click
        Summon(FormCollections)
    End Sub

    'Settings Button
    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles LabelOption3.Click

        FormSettings.Show()
        FormSettings.Activate()

    End Sub

    Private Sub picSettings_Click(sender As Object, e As EventArgs) Handles PicOption3.Click

        FormSettings.Show()
        FormSettings.Activate()

    End Sub


    'Exit Button
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles LabelOption4.Click

        FormHeader.Close()

    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles PicOption4.Click

        FormHeader.Close()

    End Sub


End Class