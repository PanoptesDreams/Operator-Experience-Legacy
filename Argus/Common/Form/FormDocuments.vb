Public Class FormDocuments

    ' Start
    Private Sub FormDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        Positioner(Me, My.Settings.CollectionsPos, My.Settings.CollectionsLastPos)

    End Sub


End Class