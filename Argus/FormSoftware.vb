Public Class FormSoftware

    'Start
    Private Sub FormSoftware_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)


    End Sub

    Private Sub ButtonOpenFOlder_Click(sender As Object, e As EventArgs) Handles ButtonOpenFOlder.Click

        Process.Start("explorer.exe", Environment.GetEnvironmentVariable("argus") + "\Software")

    End Sub


End Class