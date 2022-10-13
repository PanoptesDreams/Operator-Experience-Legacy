Imports MadMilkman.Ini

' Code in chronological order

' List of Available Functions
'
' Blur() - Invokes a blur for drawing focus
' 
'
' List of Available Subroutines
'
' Banish(Form) - Closes specified form
' Greeter() - Returns a time of day appropriate greeting
' Summon(Form) - Shows and activates a specified form

Module ArgusCommon

    'Blur
    Public Sub Blur()

        If My.Settings.Blur = True Then

            Summon(FormBlur)

        End If

    End Sub

    'Greeter
    Public Function Greeter()

        Dim Greeting As String = ""

        'Sets time of day greeting, formated to 24 hour
        Select Case Now.ToString("HH")

            'Morning case, from 00 (midnight) to 11am
            Case "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11"
                Greeting = "Good Morning, "

            'Afternoon case, from 12pm (mid day) to 5pm
            Case "12", "13", "14", "15", "16", "17"
                Greeting = "Good Afternoon, "

            'Evening case, from 6pm to 11pm
            Case "18", "19", "20", "21", "22", "23"
                Greeting = "Good Evening, "
        End Select

        Return Greeting

    End Function

    'Summoner of Forms
    Public Sub Summon(Sender As Object)

        If Sender.Visible = True Then

            Sender.Activate()

        Else
            Sender.Show()

            Sender.Activate()
        End If


    End Sub

    'Banisher of Forms
    Public Sub Banish(Sender As Form)

        Sender.Close()

    End Sub

    'Operator Menu Auto-Hide
    Public Function HideOpMenu()

        'Check if user has autohide set to 'True' and disposes of it when an argus applet is invoked
        If My.Settings.AutohideOpMenu = True Then

            FormUserMenu.Dispose()

            Return 1

        End If

        Return 0

    End Function

    'Search Box Auto-Hide
    Public Function HideSearch()



        'Check if user has autohide set to 'True' and disposes of it when an argus applet is invoked
        If My.Settings.AutohideSearch = True Then

            FormSearch.Dispose()

            Return 1

        End If

        Return 0

    End Function

    'Image Resizer
    Public Function ResizeImage(ByVal InputImage As Image, ByVal IcoWidth As Integer, ByVal IcoHeight As Integer) As Image

        Return New Bitmap(InputImage, New Size(IcoWidth, IcoHeight))

    End Function


    'Themer
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
                FontyPen = Color.FromArgb(245, 245, 245)

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
    Public Sub Positioner(Sender As Form, Owner As String, LastPos As Point)

        Select Case Owner
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

        Process.Start("A:\argus\applet\Ding.exe")

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
