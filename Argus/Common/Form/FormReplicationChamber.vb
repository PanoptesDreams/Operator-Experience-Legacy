Public Class FormReplicationChamber

    Private Sub FormReplicationChamber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        ButtonBuild.Text = "Build"
        ButtonFetch.Text = "Fetch"

    End Sub

End Class