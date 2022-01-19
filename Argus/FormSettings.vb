Imports Argus.ArgusCommon

Public Class FormSettings
    Dim BGs As Windows.Forms.TabPage() = {TabArgusBehavior, TabArgusPersonalization, TabArgusMisc}

    'Start/Load
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Theme()

        'Behavior
        ComboBoxAutohideUsermenu.Text = My.Settings.AutohideUsermenu

        'Personalization
        picFavColor.BackColor = My.Settings.FavColor

        ComboBoxTheme.Text = My.Settings.ThemeUniversal

        tstUsernameSet.Text = My.Settings.UserName

        ComboBoxLauncherPOS.Text = My.Settings.LauncherPos

        'Misc
        ComboBoxWebSearchProvider.Text = My.Settings.WebSearchProvider



    End Sub


    'Themer
    Public Sub Theme()

        Dim BgColor As Color = BgColorPicker()

        Me.BackColor = BgColor

        SettingsTab1Argus.BackColor = BgColor
        SettingsTab2Win.BackColor = BgColor

        TabArgusBehavior.BackColor = BgColor
        TabArgusMisc.BackColor = BgColor
        TabArgusPersonalization.BackColor = BgColor


    End Sub


    'Activation
    Private Sub FormSettings_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        HideUsermenu()

    End Sub


    'Apply Behaviors
    Private Sub ButtonApplyBehaviors_Click(sender As Object, e As EventArgs) Handles ButtonApplyBehaviors.Click

        'Autohide usermenu when an argus applet is invoked
        My.Settings.AutohideUsermenu = ComboBoxAutohideUsermenu.Text

        'Save Settings
        My.Settings.Save()

    End Sub


    'Apply Personalization
    Private Sub btnApplyPersonalization_Click(sender As Object, e As EventArgs) Handles btnApplyPersonalization.Click

        'Favorite Color
        'My.Settings.FavColor = picFavColor.BackColor

        'Username
        FormHeader.lblUser.Text = tstUsernameSet.Text
        My.Settings.UserName = tstUsernameSet.Text

        'Apply theme and position
        My.Settings.LauncherPos = ComboBoxLauncherPOS.Text
        My.Settings.ThemeUniversal = ComboBoxTheme.Text
        FormHeader.Theme()
        Theme()

        My.Settings.WebSearchProvider = ComboBoxWebSearchProvider.Text

        'Save Settings
        My.Settings.Save()

    End Sub


    'Argus
    'Personalization
    'Favorite Color Picker
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