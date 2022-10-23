Public Class FormDocuments

    ' Start
    Private Sub FormDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        Positioner(Me, My.Settings.CollectionsPos, My.Settings.CollectionsLastPos)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Banish(Me)
    End Sub
End Class