Public Class FormHomepage


    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.Homepage = "" Then

            ' if homepage is Operator custom then launch their browser

        End If

        WebBrowser1.Navigate(My.Settings.Homepage)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted



    End Sub


End Class