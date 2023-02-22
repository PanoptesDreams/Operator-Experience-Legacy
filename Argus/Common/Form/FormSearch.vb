Public Class FormSearch

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = Me.ClientRectangle
        path.StartFigure()
        path.AddArc(rectangle.X, rectangle.Y, 50, 50, 180, 90)
        path.AddLine(rectangle.X + 50, rectangle.Y, rectangle.Width - 50, rectangle.Y)
        path.AddArc(rectangle.X + rectangle.Width - 50, rectangle.Y, 50, 50, 270, 90)
        path.AddLine(rectangle.Width, rectangle.Y + 50, rectangle.Width, rectangle.Height - 50)
        path.AddArc(rectangle.X + rectangle.Width - 50, rectangle.Y + rectangle.Height - 50, 50, 50, 0, 90)
        path.AddLine(rectangle.Width - 50, rectangle.Height, rectangle.X + 50, rectangle.Height)
        path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - 50, 50, 50, 90, 90)
        path.CloseFigure()
        Me.Region = New System.Drawing.Region(path)


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