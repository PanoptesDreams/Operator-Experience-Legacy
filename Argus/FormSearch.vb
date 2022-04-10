Public Class FormSearch

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        If SearchBox.Text = "" Then
            SearchBox.Text = "how to use a search engine"
        End If

        Dim SearchEngine As String = My.Settings.WebSearchProvider
        Dim URL As String

        Select Case SearchEngine

            Case = "Bing"
                URL = "https://www.bing.com/search?q="
            Case = "Duck"
                URL = "https://duckduckgo.com/?q="
            Case = "Startpage"
                URL = "https://startpage.com/do/search?q="
            Case = "Google"
                URL = "https://www.google.com/search?q="
            Case = "Yahoo"
                URL = "http://search.yahoo.com/search?p="

        End Select


        Try

            Cursor.Current = Cursors.AppStarting
            Process.Start(URL + SearchBox.Text)
            SearchBox.Text = ""

        Catch

        Finally

            Cursor.Current = Cursors.Arrow

        End Try

        Banish(Me)

    End Sub

    Private Sub ButtonOpenSettings_Click(sender As Object, e As EventArgs) Handles ButtonOpenSettings.Click

        Summon(FormSettings)

        FormSettings.TabControlSettings.SelectedIndex = 0
        FormSettings.TabControlArgus.SelectedIndex = 2

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        SearchBox.Text = ""
    End Sub

    Private Sub FormSearch_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        SearchBox.Select()

    End Sub

    Private Sub SearchBox_Enter(sender As Object, e As EventArgs) Handles SearchBox.Enter
        SearchBox.Text = ""
    End Sub

    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UniThemer(Me)
    End Sub
End Class