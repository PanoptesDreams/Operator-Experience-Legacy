Imports Argus.ArgusCommon

Public Class FormSettings
    Dim BGs As Windows.Forms.TabPage() = {TabArgusBehavior, TabArgusPersonalization, TabArgusMisc}
    Dim PersistCollections As Boolean = My.Settings.PersistCollections
    Dim PersistSearch As Boolean = My.Settings.PersistSearch
    Dim PersistHome As Boolean = My.Settings.PersistHome
    Dim PersistWallet As Boolean = My.Settings.PersistWallet

    'Start/Load
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Theme()

        'Applet
        If PersistCollections = True Then
            PicAppletCollections.BackColor = Color.Green
        ElseIf PersistCollections = False Then
            PicAppletCollections.BackColor = Color.DarkRed
        End If

        If PersistSearch = True Then
            PicAppletSearch.BackColor = Color.Green
        ElseIf PersistSearch = False Then
            PicAppletSearch.BackColor = Color.DarkRed
        End If

        If PersistHome = True Then
            PicAppletHome.BackColor = Color.Green
        ElseIf PersistHome = False Then
            PicAppletHome.BackColor = Color.DarkRed
        End If

        If PersistWallet = True Then
            PicAppletWallet.BackColor = Color.Green
        ElseIf PersistWallet = False Then
            PicAppletWallet.BackColor = Color.DarkRed
        End If

        'Behavior
        ComboBoxAutohideUsermenu.Text = My.Settings.AutohideUsermenu
        ComboBoxLauncherAlwaysonTop.Text = My.Settings.LauncherAoT
        ComboBoxBlur.Text = My.Settings.Blur

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

        UniThemer(Me)
        UniThemer(ToolTipAlpha)

    End Sub


    'Activation
    Private Sub FormSettings_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        HideUsermenu()
        HideSearch()

    End Sub


#Region "Buttons"
    'Apply Behaviors
    Private Sub ButtonApplyBehaviors_Click(sender As Object, e As EventArgs) Handles ButtonApplyBehaviors.Click

        'Autohide usermenu when an argus applet is invoked
        My.Settings.AutohideUsermenu = ComboBoxAutohideUsermenu.Text
        My.Settings.LauncherAoT = ComboBoxLauncherAlwaysonTop.Text
        My.Settings.Blur = ComboBoxBlur.Text

        ASave()

        FormHeader.AlwaysOnTop()

        Blur()

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

        'Position
        My.Settings.LauncherPos = ComboBoxLauncherPOS.Text
        My.Settings.CollectionsPos = ComboBoxCollectionsPOS.Text

        'Theme
        My.Settings.ThemeUniversal = ComboBoxTheme.Text

        ASave()

        'Apply theme
        UniThemer(Me)
        UniThemer(FormUserMenu)
        UniThemer(FormHeader)
        UniThemer(FormCollections)
        UniThemer(FormSearch)
        UniThemer(ToolTipAlpha)

        'Apply positions
        Positioner(FormCollections, My.Settings.CollectionsPos, My.Settings.CollectionsLastPos)
        Positioner(FormHeader, My.Settings.LauncherPos, My.Settings.LauncherLastPos)

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

    'Applets
    'Collections
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

    'Search
    Private Sub PicAppletSearch_Click(sender As Object, e As EventArgs) Handles PicAppletSearch.Click

        If PersistSearch = True Then
            My.Settings.PersistSearch = False
            PersistSearch = False
            PicAppletSearch.BackColor = Color.DarkRed
        ElseIf PersistSearch = False Then
            My.Settings.PersistSearch = True
            PersistSearch = True
            PicAppletSearch.BackColor = Color.Green
        End If

    End Sub

    Private Sub PicAppletWallet_Click(sender As Object, e As EventArgs) Handles PicAppletWallet.Click

        If PersistWallet = True Then
            My.Settings.PersistWallet = False
            PersistWallet = False
            PicAppletWallet.BackColor = Color.DarkRed
        ElseIf PersistWallet = False Then
            My.Settings.PersistWallet = True
            PersistWallet = True
            PicAppletWallet.BackColor = Color.Green
        End If

    End Sub

    Private Sub PicAppletHome_Click(sender As Object, e As EventArgs) Handles PicAppletHome.Click

        If PersistHome = True Then
            My.Settings.PersistHome = False
            PersistHome = False
            PicAppletHome.BackColor = Color.DarkRed
        ElseIf PersistHome = False Then
            My.Settings.PersistHome = True
            PersistHome = True
            PicAppletHome.BackColor = Color.Green
        End If

    End Sub

    Private Sub LabelSettingsUser_MouseEnter(sender As Object, e As EventArgs) Handles LabelSettingsUser.MouseEnter

        ButtonGlow(LabelSettingsUser)

    End Sub

    Private Sub LabelSettingsUser_MouseLeave(sender As Object, e As EventArgs) Handles LabelSettingsUser.MouseLeave

        ButtonUnGlow(LabelSettingsUser)

    End Sub

    Private Sub LabelSettingsWindows_MouseEnter(sender As Object, e As EventArgs) Handles LabelSettingsWindows.MouseEnter

        ButtonGlow(LabelSettingsWindows)

    End Sub

    Private Sub LabelSettingsWindows_MouseLeave(sender As Object, e As EventArgs) Handles LabelSettingsWindows.MouseLeave

        ButtonUnGlow(LabelSettingsWindows)

    End Sub

    Private Sub LabelSettingsUser_Click(sender As Object, e As EventArgs) Handles LabelSettingsUser.Click

        TabControlSettings.SelectedTab = SettingsTab1Argus

        TabControlArgus.SelectedTab = TabArgusPersonalization

    End Sub

    Private Sub LabelSettingsWindows_Click(sender As Object, e As EventArgs) Handles LabelSettingsWindows.Click

        TabControlSettings.SelectedTab = SettingsTab2Win

    End Sub

    Private Sub lblAutohideUserMenu_MouseHover(sender As Object, e As EventArgs) Handles lblAutohideUserMenu.MouseHover
        ToolTipAlpha.Show("True - Hides user menu when another applet is clicked" + vbCrLf + "False - Doesn't . . .", lblAutohideUserMenu)
    End Sub


End Class