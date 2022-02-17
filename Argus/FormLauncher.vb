Imports System.Text
Imports Argus.ArgusCommon


'Header a.k.a Launcher
Public Class FormHeader

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim lastPOS As Point = My.Settings.LauncherLastPos

    Dim OSKParam As String = Command() 'REMOVE ME


    'Start/Load
    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Are we in debug mode?
        DebugFeatures()

        'Checks environment variable
        Portable()

        'Set theme
        UniThemer(Me)

        'Set position
        Positioner(Me, My.Settings.LauncherPos, My.Settings.LauncherLastPos)

        'Set greeting
        labelGreeter.Text = Greeter()

        'Set Username
        labelUsername.Text = My.Settings.UserName

        'Call set: day of week, time, date/month, year
        SetTime()



        'Set Form width from monitor width
        Me.Width = Math.Round(Screen.PrimaryScreen.Bounds.Width * 0.33)



        PersitingApp()

    End Sub


    'Activation
    Private Sub FormHeader_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


    End Sub

    'AlwaysOnTop
    Public Sub AlwaysOnTop()

        Me.TopMost = My.Settings.LauncherAoT

    End Sub



    'Debug Features
    Public Sub DebugFeatures()

        Dim DebugOn As Boolean = My.Settings.DebugFeatures

        If DebugOn = True Then
            ButtonDebug.Enabled = True
            ButtonDebug2.Enabled = True
            ButtonDebug.Visible = True
            ButtonDebug2.Visible = True
        End If

        If DebugOn = False Then
            ButtonDebug.Enabled = False
            ButtonDebug2.Enabled = False
            ButtonDebug.Visible = False
            ButtonDebug2.Visible = False
        End If

    End Sub

    'Portable Mode
    Public Sub Portable()

        'Add check for portable
        If System.IO.File.Exists("portable.ini") Then
            GoTo 1
        End If

        'Checks for ARGUS environment variable, needed for app to function
        If Environment.GetEnvironmentVariable("argus") = "" Then

            MsgBox("Argus has not been initialized on this system would you like to?", vbYesNo)


            If MsgBox("Please restart Argus", vbYesNo) = vbYes Then
                'Sets Envirnment Variable %ARGUS% to "A:"
                Environment.SetEnvironmentVariable("argus", "A:", EnvironmentVariableTarget.User)
            ElseIf vbNo Then
                'Assuming portable mode
                GoTo 1
            End If

        ElseIf Environment.GetEnvironmentVariable("argus") = "A:" Then

            GoTo 1

        End If

1:
    End Sub





    'Border Drawerer
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Call the base class
        MyBase.OnPaint(e)

        Dim UserTheme As String = My.Settings.ThemeUniversal
        Dim ThemePen As New Pen(Brushes.Silver)


        Select Case UserTheme

            Case = "Light"
                ThemePen = Pens.Silver

            Case = "Dark"
                ThemePen = Pens.Black

            Case = "User"
                ThemePen = Pens.White

        End Select


        'Top
        e.Graphics.DrawLine(ThemePen, 0, 0, Me.Width - 1, 0)
        'Left
        e.Graphics.DrawLine(ThemePen, 0, 1, 0, 48)
        'Right
        e.Graphics.DrawLine(ThemePen, Me.Width - 1, 1, Me.Width - 1, 48)
        'Bottom
        e.Graphics.DrawLine(ThemePen, 0, 49, Me.Width - 1, 49)



    End Sub



    'Clock and Date
    Public Sub SetTime()

        'Set days array
        Dim day() As String = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
        'today Day
        '0=sun 1=mon 2=tue 3=wed 4=thu 5=fri 7=sat

        'Set Month array
        Dim month() As String = {"¯\_(ツ)_/¯", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        'today Month
        '0=null 1=jan 2=feb 3=mar 4=april 5=may 6=jun 7=jul 8=aug 9=sep 10=oct 11=nov 12=dec'Sets the date

        'Set clock
        labelClock.Text = Now.ToShortTimeString

        'Set day of week
        labelToday.Text = day(Now.DayOfWeek)

        'Set Long date, XX MONTH
        labelLongDate.Text = Now.Day.ToString + " " + month(Now.Month)

        'Set Year
        labelYear.Text = Now.Year.ToString


    End Sub

    'Clock tick
    Private Sub TimerClockTick_Tick(sender As Object, e As EventArgs) Handles TimerClockTick.Tick

        'Static midnight As Boolean

        labelClock.Text = Now.ToShortTimeString

        If Now.ToShortTimeString = "12:00 AM" Then
            SetTime()
        End If

    End Sub


    'User Menu
    Private Sub PicUser_Click(sender As Object, e As EventArgs) Handles picUserImage.Click

        Summon(FormUserMenu)

    End Sub


    'Collections
    Private Sub PicCollections_Click(sender As Object, e As EventArgs) Handles PicCollections.Click

        Summon(FormCollections)

    End Sub


    'Debug Button 1
    Private Sub DebugButton_Click(sender As Object, e As EventArgs) Handles ButtonDebug.Click

        'Test button for testing things

        'returns current time as 00:00 AM format
        'MsgBox(Now.ToShortTimeString)

        'Check for environment variable
        'MsgBox(Environment.GetEnvironmentVariable("argus"))

    End Sub

    'Debug Button 2
    Private Sub btnDebug2_Click(sender As Object, e As EventArgs) Handles ButtonDebug2.Click

    End Sub


    'Move form with click drag
    Private Sub FormHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        drag = True

        mousex = Windows.Forms.Cursor.Position.X - sender.Left 'Sets variable mousex

        mousey = Windows.Forms.Cursor.Position.Y - sender.Top 'Sets variable mousey


    End Sub

    Private Sub FormHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        My.Settings.LauncherLastPos = sender.Location
        ASave()

        drag = False

    End Sub

    Private Sub FormHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If drag Then

            sender.Top = Windows.Forms.Cursor.Position.Y - mousey

            sender.Left = Windows.Forms.Cursor.Position.X - mousex

        End If

    End Sub

    Private Sub TrayMenuItemExit_Click(sender As Object, e As EventArgs) Handles TrayMenuItemExit.Click

        Me.Close()

    End Sub

    Private Sub TrayMenuItemToggleVisibility_Click(sender As Object, e As EventArgs) Handles TrayMenuItemToggleVisibility.Click

        If Me.Visible = True Then

            Me.Hide()

        Else

            Summon(Me)

        End If


    End Sub

    Private Sub TrayMenuSettings_Click(sender As Object, e As EventArgs) Handles TrayMenuSettings.Click

        Summon(FormSettings)

    End Sub










    'End Move form click drag







    'Deprecated Code - Argus.vb
    '
    '    'Variables Start

    '    'Setting Visibility - Always False
    '    Dim SettingVis As Boolean = False

    '    'Directories
    '    Dim ArgusDir As String = "A:\Argus\"
    '    Dim IconDir As String = "icon\"
    '    Dim ThemeDir As String = "theme\"


    '    'User Variables
    '    Dim UserIcons(7) As String

    '    'Favorite color
    '    Dim favColor As System.Drawing.Color = My.Settings.FavColor

    '    Dim Checked As Boolean = My.Settings.UserIcons
    '    'Variables End


    '    'App Load
    '    Public Sub Argus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '        'Reload Settings
    '        My.Settings.Reload()

    '        CBUserIcons.Checked = My.Settings.UserIcons

    '        PicFavColor.BackColor = My.Settings.FavColor

    '        'Set Label Color
    '        LblTitle.ForeColor = favColor

    '        'Run Icon Changer
    '        Icon_Change()

    '        'Invoke Blur
    '        FormBlur.Show()




    '    End Sub



    '    'Settings

    '    'Toggle Visibility
    '    Public Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click

    '        If SettingVis = False Then
    '            CBUserIcons.Visible = True
    '            LblFavColor.Visible = True
    '            PicFavColor.Visible = True
    '            SettingVis = True
    '            GoTo 0
    '        ElseIf SettingVis = True Then
    '            CBUserIcons.Visible = False
    '            LblFavColor.Visible = False
    '            PicFavColor.Visible = False
    '            SettingVis = False
    '        End If
    '0:
    '    End Sub

    '    'Toggle custom user icons
    '    Private Sub CBUserIcons_CheckedChanged(sender As Object, e As EventArgs) Handles CBUserIcons.CheckedChanged

    '        If CBUserIcons.Checked = True Then

    '            My.Settings.UserIcons = True

    '            Icon_Change()

    '        ElseIf CBUserIcons.Checked = False Then

    '            My.Settings.UserIcons = False

    '            'Restart Argus Form to refresh buttons
    '            FormBlur.Argus_Refresh()

    '        End If

    '    End Sub

    '    'Set Favorite Color
    '    'Invoke Color Dialog
    '    Public Sub ColorPick()
    '        colorDiagFav.ShowDialog()



    '        My.Settings.FavColor = colorDiagFav.Color

    '        LblTitle.ForeColor = My.Settings.FavColor

    '        PicFavColor.BackColor = My.Settings.FavColor
    '    End Sub

    '    Private Sub LblFavColor_Click(sender As Object, e As EventArgs) Handles LblFavColor.Click
    '        ColorPick()
    '    End Sub

    '    Private Sub PicFavColor_Click(sender As Object, e As EventArgs) Handles PicFavColor.Click
    '        ColorPick()
    '    End Sub

    '    'Custom Icon Changer
    '    Public Sub Icon_Change()

    '        'Set icons
    '        UserIcons(0) = "app.png"
    '        UserIcons(1) = "game.png"
    '        UserIcons(2) = "music.png"
    '        UserIcons(3) = "movie.png"
    '        UserIcons(4) = "tv.png"
    '        UserIcons(5) = "video.png"
    '        UserIcons(6) = "image.png"
    '        UserIcons(7) = "document.png"


    '        If My.Settings.UserIcons = True Then

    '            'Button list
    '            Dim bttns As New List(Of Object) From {
    '                BtnApp,
    '                BtnGame,
    '                BtnMusic,
    '                BtnMovie,
    '                BtnTV,
    '                BtnVid,
    '                BtnImg,
    '                BtnDoc
    '            }

    '            'Set Custom Icons
    '            For i = 0 To 7

    '                If My.Computer.FileSystem.FileExists(ArgusDir + IconDir + UserIcons(i)) Then
    '                    bttns(i).BackgroundImage = System.Drawing.Image.FromFile(ArgusDir + IconDir + UserIcons(i))
    '                End If

    '            Next

    '        End If
    '    End Sub



    '    'Button Hover, label changer
    '    Public Sub BtnApp_MouseHover(sender As Object, e As EventArgs) Handles BtnApp.MouseHover
    '        LblTitle.Text = "Apps"
    '    End Sub

    '    Public Sub BtnGame_MouseHover(sender As Object, e As EventArgs) Handles BtnGame.MouseHover
    '        LblTitle.Text = "Games"
    '    End Sub

    '    Public Sub BtnMusic_MouseHover(sender As Object, e As EventArgs) Handles BtnMusic.MouseHover
    '        LblTitle.Text = "Music"
    '    End Sub

    '    Public Sub BtnMovie_MouseHover(sender As Object, e As EventArgs) Handles BtnMovie.MouseHover
    '        LblTitle.Text = "Movies"
    '    End Sub

    '    Public Sub BtnTV_MouseHover(sender As Object, e As EventArgs) Handles BtnTV.MouseHover
    '        LblTitle.Text = "T.V / Shows"
    '    End Sub

    '    Public Sub BtnVid_MouseHover(sender As Object, e As EventArgs) Handles BtnVid.MouseHover
    '        LblTitle.Text = "Videos"
    '    End Sub

    '    Public Sub BtnImg_MouseHover(sender As Object, e As EventArgs) Handles BtnImg.MouseHover
    '        LblTitle.Text = "Images"
    '    End Sub

    '    Public Sub BtnDoc_MouseHover(sender As Object, e As EventArgs) Handles BtnDoc.MouseHover
    '        LblTitle.Text = "Documents"
    '    End Sub

    '    Private Sub BtnSettings_MouseHover(sender As Object, e As EventArgs) Handles BtnSettings.MouseHover
    '        LblTitle.Text = "Settings"
    '    End Sub

    '    'Primary Buttons, Click
    '    Public Sub BtnApp_Click(sender As Object, e As EventArgs) Handles BtnApp.Click


    '    End Sub

    '    Public Sub BtnGame_Click(sender As Object, e As EventArgs) Handles BtnGame.Click
    '        FormGame.Show()
    '    End Sub

    '    Public Sub BtnMusic_Click(sender As Object, e As EventArgs) Handles BtnMusic.Click
    '        FormMusic.Show()
    '    End Sub




    '    'Form Closing
    '    Private Sub FormArgus_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    '        'Save, just to be sure
    '        My.Settings.Save()

    '    End Sub

    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '        FormSettings.Show()
    '    End Sub

    '    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    '    End Sub
End Class