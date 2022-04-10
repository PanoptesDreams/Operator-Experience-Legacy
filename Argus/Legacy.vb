Public Class Legacy
    'Deprecated Code - Argus.vb

    'Variables Start

    'Setting Visibility - Always False
    Dim SettingVis As Boolean = False

    'Directories
    Dim ArgusDir As String = "A:\Argus\"
    Dim IconDir As String = "icon\"
    Dim ThemeDir As String = "theme\"


    'User Variables
    Dim UserIcons(7) As String

    'Favorite color
    Dim favColor As System.Drawing.Color = My.Settings.FavColor

    Dim Checked As Boolean = My.Settings.UserIcons
    'Variables End


    'App Load
    Public Sub Argus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Reload Settings
        My.Settings.Reload()

        CBUserIcons.Checked = My.Settings.UserIcons

        PicFavColor.BackColor = My.Settings.FavColor

        'Set Label Color
        LblTitle.ForeColor = favColor

        'Run Icon Changer
        Icon_Change()

        'Invoke Blur
        FormBlur.Show()




    End Sub



    'Settings

    'Toggle Visibility
    Public Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click

        If SettingVis = False Then
            CBUserIcons.Visible = True
            LblFavColor.Visible = True
            PicFavColor.Visible = True
            SettingVis = True
            GoTo 0
        ElseIf SettingVis = True Then
            CBUserIcons.Visible = False
            LblFavColor.Visible = False
            PicFavColor.Visible = False
            SettingVis = False
        End If
0:
    End Sub

    'Toggle custom user icons
    Private Sub CBUserIcons_CheckedChanged(sender As Object, e As EventArgs) Handles CBUserIcons.CheckedChanged

        If CBUserIcons.Checked = True Then

            My.Settings.UserIcons = True

            Icon_Change()

        ElseIf CBUserIcons.Checked = False Then

            My.Settings.UserIcons = False

            'Restart Argus Form to refresh buttons
            FormBlur.Argus_Refresh()

        End If

    End Sub

    'Set Favorite Color
    'Invoke Color Dialog
    Public Sub ColorPick()
        colorDiagFav.ShowDialog()



        My.Settings.FavColor = colorDiagFav.Color

        LblTitle.ForeColor = My.Settings.FavColor

        PicFavColor.BackColor = My.Settings.FavColor
    End Sub

    Private Sub LblFavColor_Click(sender As Object, e As EventArgs) Handles LblFavColor.Click
        ColorPick()
    End Sub

    Private Sub PicFavColor_Click(sender As Object, e As EventArgs) Handles PicFavColor.Click
        ColorPick()
    End Sub

    'Custom Icon Changer
    Public Sub Icon_Change()

        'Set icons
        UserIcons(0) = "app.png"
        UserIcons(1) = "game.png"
        UserIcons(2) = "music.png"
        UserIcons(3) = "movie.png"
        UserIcons(4) = "tv.png"
        UserIcons(5) = "video.png"
        UserIcons(6) = "image.png"
        UserIcons(7) = "document.png"


        If My.Settings.UserIcons = True Then

            'Button list
            Dim bttns As New List(Of Object) From {
                BtnApp,
                BtnGame,
                BtnMusic,
                BtnMovie,
                BtnTV,
                BtnVid,
                BtnImg,
                BtnDoc
            }

            'Set Custom Icons
            For i = 0 To 7

                If My.Computer.FileSystem.FileExists(ArgusDir + IconDir + UserIcons(i)) Then
                    bttns(i).BackgroundImage = System.Drawing.Image.FromFile(ArgusDir + IconDir + UserIcons(i))
                End If

            Next

        End If
    End Sub



    'Button Hover, label changer
    Public Sub BtnApp_MouseHover(sender As Object, e As EventArgs) Handles BtnApp.MouseHover
        LblTitle.Text = "Apps"
    End Sub

    Public Sub BtnGame_MouseHover(sender As Object, e As EventArgs) Handles BtnGame.MouseHover
        LblTitle.Text = "Games"
    End Sub

    Public Sub BtnMusic_MouseHover(sender As Object, e As EventArgs) Handles BtnMusic.MouseHover
        LblTitle.Text = "Music"
    End Sub

    Public Sub BtnMovie_MouseHover(sender As Object, e As EventArgs) Handles BtnMovie.MouseHover
        LblTitle.Text = "Movies"
    End Sub

    Public Sub BtnTV_MouseHover(sender As Object, e As EventArgs) Handles BtnTV.MouseHover
        LblTitle.Text = "T.V / Shows"
    End Sub

    Public Sub BtnVid_MouseHover(sender As Object, e As EventArgs) Handles BtnVid.MouseHover
        LblTitle.Text = "Videos"
    End Sub

    Public Sub BtnImg_MouseHover(sender As Object, e As EventArgs) Handles BtnImg.MouseHover
        LblTitle.Text = "Images"
    End Sub

    Public Sub BtnDoc_MouseHover(sender As Object, e As EventArgs) Handles BtnDoc.MouseHover
        LblTitle.Text = "Documents"
    End Sub

    Private Sub BtnSettings_MouseHover(sender As Object, e As EventArgs) Handles BtnSettings.MouseHover
        LblTitle.Text = "Settings"
    End Sub

    'Primary Buttons, Click
    Public Sub BtnApp_Click(sender As Object, e As EventArgs) Handles BtnApp.Click


    End Sub

    Public Sub BtnGame_Click(sender As Object, e As EventArgs) Handles BtnGame.Click
        FormGame.Show()
    End Sub

    Public Sub BtnMusic_Click(sender As Object, e As EventArgs) Handles BtnMusic.Click
        FormMusic.Show()
    End Sub




    'Form Closing
    Private Sub FormArgus_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'Save, just to be sure
        My.Settings.Save()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormSettings.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class