Imports MadMilkman.Ini ' https://github.com/MarioZ/MadMilkman.Ini

' Legacy code in Chronological order
' Modern code in Alphabetical order

' List of Available Functions
'
' AvailableForms() - Returns Array of forms
' Greeter() - Returns a time of day appropriate greeting
' ResizeImage(InputImage, ImageWidth, ImageHeight)
' 
'
' List of Available Subroutines
'
' Banish(Form) - Closes specified form
' Blur() - Invokes a blur for drawing focus
' Summon(Form) - Shows and activates a specified form

Module ArgusCommon

    ' Available Forms - Returns Array of Forms
    Public Function AvailableForms()

        Dim AvailForms As Form() = {FormBlur, FormCollections, FormDocuments, FormEditor, FormGame, FormHeader, FormHomepage, FormLoadingSplash, FormLogin, FormMusic, FormOOBEPrivacy, FormOOBESystem, FormReplicationChamber, FormSearch, FormSettings, FormSocial, FormSoftware, FormSteamLinkGenerater, FormOpMenu, FormWallet}

        Return AvailForms

    End Function

    ' Greeting - Greet the operator based on the time of day
    Public Function Greeting()

        Dim Greet As String = ""
        Dim Mood As String = My.Settings.ArgusMood

        Select Case Mood
            Case "Happy"
                Greet = "Good "
            Case "Neutral"
                Greet = ""
            Case "Bad"
                Greet = "Hi, "
                Return Greet
        End Select

        'Sets time of day greeting, formated to 24 hour
        Select Case Now.ToString("HH")

            'Morning case, from 00 (midnight) to 11am
            Case "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11"
                Greet += "Morning, "

            'Afternoon case, from 12pm (mid day) to 5pm
            Case "12", "13", "14", "15", "16", "17"
                Greet += "Afternoon, "

            'Evening case, from 6pm to 11pm
            Case "18", "19", "20", "21", "22", "23"
                Greet += "Evening, "
        End Select

        Return Greet

    End Function

    ' Season
    Public Function Season()

        ' Determine Hemisphere - countries along the middle latitudes have 4 standard seasons, countries on the lower latitudes have ~6 non-standard seasons
        ' Determine time of year - time of year + hemisphere = season

        Return Nothing

    End Function


    ' Image Resizer
    Public Function ResizeImage(ByVal InputImage As Image, ByVal ImageWidth As Integer, ByVal ImageHeight As Integer) As Image

        Return New Bitmap(InputImage, New Size(ImageWidth, ImageHeight))

    End Function

    ' 
    ' Subroutines
    ' 

    ' Banisher of Forms
    Public Sub Banish(Sender As Form)

        Sender.Close()

    End Sub


    ' Blur
    Public Sub Blur()

        If My.Settings.Blur = True Then

            Summon(FormBlur)

        End If

    End Sub

    ' Drawer of Borders
    Public Sub BorderDrawerer(Sender As Form, e As PaintEventArgs)

        Dim ThemePen As New Pen(Brushes.Silver) 'Set a default pen

        ' Choose Pen
        Select Case My.Settings.ThemeUniversal

            Case = "Light"
                ThemePen = Pens.Silver

            Case = "Dark"
                ThemePen = Pens.Black

            Case = "User"
                ThemePen = Pens.White

        End Select

        ' Draw Borders - Height is reduced by 1 to keep render inside of form
        e.Graphics.DrawLine(ThemePen, 0, 0, Sender.Width - 1, 0) ' Top
        e.Graphics.DrawLine(ThemePen, 0, 1, 0, Sender.Height - 1) ' Left
        e.Graphics.DrawLine(ThemePen, Sender.Width - 1, 1, Sender.Width - 1, Sender.Height - 1) ' Right
        e.Graphics.DrawLine(ThemePen, 0, Sender.Height - 1, Sender.Width - 1, Sender.Height - 1) ' Bottom

    End Sub

    ' Summoner of Forms
    Public Sub Summon(Sender As Object)

        If Sender.Visible = True Then ' If the form is already visible

            Sender.Activate() ' Simply trigger activate on form

        Else ' Otherwise ...

            Sender.Show() ' Properly open form ...

            Sender.Activate() ' And trigger activation.

        End If

        If Sender IsNot FormOpMenu Then

            If My.Settings.AutohideOpMenu = True Then ' If OpMenu autohide is 'True' Banish OpMenu

                Banish(FormOpMenu)

            End If

        End If

        If Sender IsNot FormSearch Then

            If My.Settings.AutohideSearch = True Then ' If Search autohide is 'True' Banish Search

                Banish(FormSearch)

            End If

        End If



    End Sub

    ' Universal Themer
    Public Sub UniThemer(Sender As Object)

        Dim UniversalTheme As String = My.Settings.ThemeUniversal
        Dim FontyPen As Color
        Dim ThemerColor As Color

        'Colorer
        Select Case UniversalTheme

            Case = "Light"
                ThemerColor = Color.FromArgb(245, 245, 245)
                FontyPen = Color.FromArgb(33, 33, 33)

            Case = "Dark"
                ThemerColor = Color.FromArgb(63, 63, 63)
                FontyPen = Color.FromArgb(225, 36, 0)

            Case = "User"
                ThemerColor = Color.FromArgb(255, 195, 203)
                FontyPen = My.Settings.FavColor

        End Select

        Sender.BackColor = ThemerColor
        Sender.ForeColor = FontyPen

        'If you're a tooltip, ride is over for you.
        If Sender.ToString = FormSettings.ToolTipAlpha.ToString Then
            GoTo 1
        End If

        'BGImager
        Select Case UniversalTheme

            Case = "Light"
                Sender.BackgroundImage = My.Resources.bg_light

            Case = "Dark"
                Sender.BackgroundImage = My.Resources.bg

            Case = "User"
                Sender.BackgroundImage = My.Resources.game_poster_mask

        End Select


1:

    End Sub

    'Fonty
    Public Sub Fonty(Sender As Form)

    End Sub

    'Positioner
    Public Sub Positioner(Sender As Form, Place As String, LastPos As Point)

        Select Case Place
            Case = "Topdock"
                Sender.Location = New Point(0, 0)
            Case = "Top"
                Sender.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2 - (Sender.Width / 2)), 20)
            Case = "Bottom"
                Sender.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2 - (Sender.Width / 2)), (Screen.PrimaryScreen.Bounds.Height - 70))
            Case = "Left"
                Sender.Location = New Point(20, Screen.PrimaryScreen.Bounds.Height / 2 - Sender.Height / 2)
            Case = "Right"
                Sender.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Sender.Width, Screen.PrimaryScreen.Bounds.Height / 2 - Sender.Height / 2)
            Case = "User"
                Sender.Location = LastPos
        End Select

    End Sub

    'Settings Saver
    Public Sub ASave() ' Hi


        My.Settings.Save()

        My.Settings.Reload()

    End Sub

    Public Sub ESave()



    End Sub

    'Button Glow
    Public Sub ButtonGlow(TLabel As Label)

        TLabel.Image = My.Resources.frame


    End Sub


    'Button unGlow
    Public Sub ButtonUnGlow(TLabel As Label)

        TLabel.Image = My.Resources.frame_empty


    End Sub

    'persistence checker
    Public Sub PersitingApp()

        If My.Settings.PersistCollections = True Then
            Summon(FormCollections)
        End If

        If My.Settings.PersistHome = True Then
            Summon(FormHomepage)
        End If

        If My.Settings.PersistSearch = True Then
            Summon(FormSearch)
        End If

        If My.Settings.PersistSocial = True Then
            Summon(FormSocial)
        End If

        If My.Settings.PersistToolbox = True Then

        End If

        If My.Settings.PersistWallet = True Then
            Summon(FormWallet)
        End If
    End Sub



#Region "Form Mover"
    Dim CursorX As Integer
    Dim CursorY As Integer

    Dim Grab As Boolean = False

    'Grab Form
    Public Sub FormMoverGrab(Sender As Form)

        Grab = True

        CursorX = Cursor.Position.X - Sender.Left
        CursorY = Cursor.Position.Y - Sender.Top


    End Sub

    'Move Form
    Public Sub FormMover(Sender As Form)

        If Grab Then
            Sender.Left = Cursor.Position.X - CursorX
            Sender.Top = Cursor.Position.Y - CursorY
        End If

    End Sub

    'Release Form
    Public Sub FormMoverRelease()

        Grab = False

    End Sub
#End Region


    Public Sub GenerateSettings()

        Dim FileINI As New IniFile() 'Create new file with a default formatting.

        Dim SectionArgus As IniSection = FileINI.Sections.Add("Argus Data") 'Add Argus section.
        Dim KeyA As IniKey 'Add new key

        KeyA = SectionArgus.Keys.Add("First Run", "yes")
        KeyA.LeadingComment.Text = "Have we run before?"

        Dim SectionUser As IniSection = FileINI.Sections.Add("User Data") 'Add user section.
        Dim KeyU As IniKey 'Add new key

        KeyU = SectionUser.Keys.Add("Favorite Color", "R20 G80 B90")
        KeyU.LeadingComment.Text = "RGB Value formatted as R20 G80 B90"

        KeyU = SectionUser.Keys.Add("Username", "Operator") '

        KeyU = SectionUser.Keys.Add("USEFULDATA", "Important Value") 'and its value.



        SectionUser.TrailingComment.Text = "I don't want to be here" 'Add trailing comment.


        FileINI.Save("Settings.ini") 'Save file.

    End Sub


    Public Sub NameGen()



    End Sub

    'Steam Launcher
    Public Sub SteamLauncher(GameID As Integer)

        Process.Start("steam://run/" + GameID.ToString)

    End Sub

    'Open User Docs
    Public Sub OpenUserDocs()

        Process.Start("explorer.exe", Environment.GetEnvironmentVariable("argus") + "\User\Document")

    End Sub

    'Open Classic Volume Mixer
    Public Sub OpenVolumeMixer()

        Process.Start("SndVol.exe")

    End Sub

    ' Summon ArgusHome
    Public Sub SummonArgusHome()

        Process.Start("A:\Software\Repository\Argus Repos\argushome\release-builds\home-win32-ia32\home.exe")

    End Sub


    'Arguments - Returns an array of strings containing application arguments
    Public Function Arguments() As String()

        Arguments = Environment.GetCommandLineArgs()
        ' element 0 = executable file name
        ' elements 1+ = additional arguments

    End Function

    Public Sub Ding()
        Try
            Process.Start(".\applet\Ding.exe")

        Catch ex As Exception

            MsgBox("Ding Missing")
        End Try

    End Sub

    Public Sub ArgFocus()

        Dim Args As String() = Arguments()
        Dim ArgsB As String = "argus://"

        Try

            If Args(1) IsNot "" Then

                Select Case Args(1)

                    Case = ArgsB + "help/"
                        Summon(FormDebugPanel)
                    Case = ArgsB + "game/"
                        Summon(FormGame)

                End Select

            End If

        Catch ex As Exception

        End Try



    End Sub

    Public Sub WinStart()




    End Sub

End Module
