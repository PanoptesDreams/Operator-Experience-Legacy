Imports Argus.ArgusCommon

Public Class FormSettings
    Dim BGs As Windows.Forms.TabPage() = {TabArgusBehavior, TabArgusPersonalization, TabArgusMisc}
    Dim PersistCollections As Boolean = My.Settings.PersistCollections

    'Start/Load
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Theme()

        'Applet
        If PersistCollections = True Then
            PicAppletCollections.BackColor = Color.Green
        ElseIf PersistCollections = False Then
            PicAppletCollections.BackColor = Color.DarkRed
        End If

        'Behavior
        ComboBoxAutohideUsermenu.Text = My.Settings.AutohideUsermenu
        ComboBoxLauncherAlwaysonTop.Text = My.Settings.LauncherAoT

        'Personalization
        picFavColor.BackColor = My.Settings.FavColor

        ComboBoxTheme.Text = My.Settings.ThemeUniversal

        tstUsernameSet.Text = My.Settings.UserName

        ComboBoxLauncherPOS.Text = My.Settings.LauncherPos

        ComboBoxCollectionsPOS.Text = My.Settings.CollectionsPos


        'Misc
        ComboBoxWebSearchProvider.Text = My.Settings.WebSearchProvider

        ComboBoxDebugFeatures.Text = My.Settings.DebugFeatures


    End Sub


    'Themer
    Public Sub Theme()

        Dim ThemeColor As Color

        Dim BgColor As Color = UniThemer(Me, ThemeColor)

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


#Region "Buttons"

    'Apply Behaviors
    Private Sub ButtonApplyBehaviors_Click(sender As Object, e As EventArgs) Handles ButtonApplyBehaviors.Click

        'Autohide usermenu when an argus applet is invoked
        My.Settings.AutohideUsermenu = ComboBoxAutohideUsermenu.Text

        My.Settings.LauncherAoT = ComboBoxLauncherAlwaysonTop.Text

        ASave()

        FormHeader.AlwaysOnTop()


    End Sub


    'Apply Miscellaneous
    Private Sub ButtonApplyMisc_Click(sender As Object, e As EventArgs) Handles ButtonApplyMisc.Click

        'Web Search Provider
        My.Settings.WebSearchProvider = ComboBoxWebSearchProvider.Text

        'Enable or disable User Debugger features
        My.Settings.DebugFeatures = ComboBoxDebugFeatures.Text

        ASave()

        FormHeader.DebugFeatures()

    End Sub


    'Apply Personalization
    Private Sub btnApplyPersonalization_Click(sender As Object, e As EventArgs) Handles ButtonApplyPersonalization.Click

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

        My.Settings.CollectionsPos = ComboBoxCollectionsPOS.Text
        FormCollections.Themer()

        ASave()

    End Sub

#End Region

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

    Private Sub PicAppletCollections_Click(sender As Object, e As EventArgs) Handles PicAppletCollections.Click

        If PersistCollections = True Then
            My.Settings.PersistCollections = False
            PersistCollections = False
            PicAppletCollections.BackColor = Color.DarkRed
        ElseIf PersistCollections = False Then
            My.Settings.PersistCollections = True
            PersistCollections = True
            PicAppletCollections.BackColor = Color.Green
        End If


    End Sub

    Private Sub PicOption1_MouseHover(sender As Object, e As EventArgs) Handles PicOption1.MouseEnter

        ButtonGlow(PicOption1)

    End Sub

    Private Sub PicOption1_MouseLeave(sender As Object, e As EventArgs) Handles PicOption1.MouseLeave

        ButtonUnGlow(PicOption1)

    End Sub

    Private Sub PicOption2_MouseHover(sender As Object, e As EventArgs) Handles PicOption2.MouseEnter

        ButtonGlow(PicOption2)

    End Sub

    Private Sub PicOption2_MouseLeave(sender As Object, e As EventArgs) Handles PicOption2.MouseLeave

        ButtonUnGlow(PicOption2)
    End Sub

    Private Sub PicOption3_MouseHover(sender As Object, e As EventArgs) Handles PicOption3.MouseEnter
        ButtonGlow(PicOption3)
    End Sub

    Private Sub PicOption3_MouseLeave(sender As Object, e As EventArgs) Handles PicOption3.MouseLeave

        ButtonUnGlow(PicOption3)
    End Sub

    Private Sub PicOption0_MouseHover(sender As Object, e As EventArgs) Handles PicOption0.MouseEnter
        ButtonGlow(PicOption0)
    End Sub

    Private Sub PicOption0_MouseLeave(sender As Object, e As EventArgs) Handles PicOption0.MouseLeave

        ButtonUnGlow(PicOption0)
    End Sub

End Class