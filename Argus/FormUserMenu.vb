Public Class FormUserMenu


    Private Sub FormUserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2 - (Me.Width / 2)), (Screen.PrimaryScreen.Bounds.Height / 2 - (Me.Height / 2)))

        picSettings.Image = New Bitmap(FormHeader.ResizeImage(My.Resources.settings, picSettings.Height))
        picExit.Image = New Bitmap(FormHeader.ResizeImage(My.Resources.logout, picExit.Height))

    End Sub


    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click

        FormHeader.Close()

    End Sub



    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        FormSettings.Show()
    End Sub

    Private Sub picSettings_Click(sender As Object, e As EventArgs) Handles picSettings.Click
        FormSettings.Show()
    End Sub


End Class