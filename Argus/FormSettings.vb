Public Class FormSettings


    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormUserMenu.Dispose()

        'Personalization
        picFavColor.BackColor = My.Settings.FavColor

        ComboBoxTheme.Text = My.Settings.ThemeUniversal

        tstUsernameSet.Text = My.Settings.UserName

        ComboBoxLauncherPOS.Text = My.Settings.LauncherPos

        'Misc
        ComboBoxWebSearchProvider.Text = My.Settings.WebSearchProvider


    End Sub



    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApplyPersonalization.Click

        'Favorite Color
        'My.Settings.FavColor = picFavColor.BackColor

        'Username
        FormHeader.lblUser.Text = tstUsernameSet.Text
        My.Settings.UserName = tstUsernameSet.Text

        'Apply theme and position
        My.Settings.LauncherPos = ComboBoxLauncherPOS.Text
        My.Settings.ThemeUniversal = ComboBoxTheme.Text
        FormHeader.Theme()

        My.Settings.WebSearchProvider = ComboBoxWebSearchProvider.Text

        'Save Settings
        My.Settings.Save()

    End Sub



    Private Sub ComboBoxDarkTheme_TextUpdate(sender As Object, e As EventArgs) Handles ComboBoxTheme.TextUpdate

        ComboBoxTheme.Text = ComboBoxTheme.Text.ToLower

        If ComboBoxTheme.Text IsNot "true" Or "false" Then
            ComboBoxTheme.Text = My.Settings.ThemeUniversal
        End If

    End Sub



    Private Sub picFavColor_Click(sender As Object, e As EventArgs) Handles picFavColor.Click


        'DONT USE THIS IT DOESN'T WORK
        'It's to help you figure out how to fix it..


        Dim UserColor As Color = My.Settings.FavColor

        ColorDialog1.ShowDialog()

        MsgBox(ColorDialog1.Color.ToString)

        UserColor = ColorDialog1.Color

        picFavColor.BackColor = BackColor


    End Sub



End Class