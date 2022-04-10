Public Class FormSteamLinkGenerater

    Dim publicURI As String = ""


    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click

        'MsgBox("steam://run/" + TextBoxGameIDinput.Text)

        Process.Start("steam://run/" + TextBoxGameIDinput.Text)

    End Sub


    Public Sub URIverify()

        If publicURI = "" Then

            GoTo 1

        End If



1:

    End Sub

    Private Sub ButtonStartCoreKeeper_Click(sender As Object, e As EventArgs) Handles ButtonStartCoreKeeper.Click
        Process.Start("steam://run/1621690")
    End Sub
End Class