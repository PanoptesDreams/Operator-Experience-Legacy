Public Class FormHomepage

    Dim timer As Integer = 3

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        timer = 3

    End Sub

    Private Sub ButtonLaunch_Click(sender As Object, e As EventArgs) Handles ButtonLaunch.Click

        Timer1.Enabled = True

        ButtonLaunch.Text = "3 . . ."

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        timer -= 1

        If timer = 0 Then
            Timer1.Enabled = False
            Banish(Me)
        End If

        ButtonLaunch.Text = timer.ToString + " . . ."

        If timer = 1 Then
            SummonArgusHome()
        End If

    End Sub
End Class