Public Class FormCollections

    Dim lastPOS As Point = My.Settings.CollectionsLastPos

    Private Sub FormCollections_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Themer()

    End Sub


    Public Sub Themer()

        Dim MyPos As String = My.Settings.CollectionsPos

        Select Case MyPos
            Case = "Right"
                Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Width + 5), (Screen.PrimaryScreen.Bounds.Height / 2) - (Me.Height / 2))
            Case = "Left"
                Me.Location = New Point(5, (Screen.PrimaryScreen.Bounds.Height / 2) - (Me.Height / 2))
            Case = "User"
                Me.Location = My.Settings.CollectionsLastPos
        End Select

    End Sub


    Private Sub FormCollections_Move(sender As Object, e As EventArgs) Handles MyBase.Move

        My.Settings.CollectionsLastPos = lastPOS
        ASave()

        Themer()

    End Sub
End Class
