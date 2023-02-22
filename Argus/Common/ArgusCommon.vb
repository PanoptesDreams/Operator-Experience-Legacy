Imports System.Collections.ObjectModel
Imports System.Windows
Imports Newtonsoft.Json

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


    Dim settings As New Dictionary(Of String, Object) ' Create a dictionary for our settings.


    ' Available Forms - Returns Array of Forms
    Public Function AvailableForms()

        Dim AvailForms As Form() = {FormBlur, FormCollections, FormDocuments, FormEditor, FormGame, FormHeader, FormHomepage, FormLoadingSplash, FormLogin, FormMusic, FormOOBEPrivacy, FormOOBESystem, FormOperatorSelect, FormReplicationChamber, FormSearch, FormSettings, FormSocial, FormSoftware, FormSteamLinkGenerater, FormOpMenu, FormWallet}

        Return AvailForms

    End Function

    Public Function CreateOperator(Optional ByVal OperatorName As String = "NewOperator")

        Dim folderPath As String = Path.Combine("R:\", OperatorName)
        Dim junctionPath As String = Path.Combine("A:\", OperatorName)

        If Directory.Exists(folderPath) Then ' Check if the folder already exists in R:

            If Directory.Exists(junctionPath) Then ' Folder exists check if Junction already exists

                MessageBox.Show("Operator already exists.", "Big Sad")

            Else ' Junction does not exist, prompt to create one

                Dim result As DialogResult = MessageBox.Show("Operator found in Root. Do you want to create a junction?", "Attention Duelist's!", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes AndAlso CreateJunction(junctionPath, folderPath) Then ' Junction created successfully

                    MessageBox.Show("Operator created successfully.", "Success")


                Else ' Junction creation failed or user canceled, show error message

                    MessageBox.Show("Failed to create Operator.", "Error")

                    Return 0

                End If

            End If

        Else ' Folder does not exist, create it and the junction

            Directory.CreateDirectory(folderPath)

            If CreateJunction(junctionPath, folderPath) Then ' Folder and junction created successfully

                MessageBox.Show("Folder and junction created successfully.", "Success")


            Else ' Junction creation failed, show error message and delete the folder

                MessageBox.Show("Failed to create junction.", "Error")

                Directory.Delete(folderPath)

                Return 0

            End If

        End If

        Return 1

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

        ' Draw Borders
        Dim g As Graphics = e.Graphics
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

        ' Draw Border - Height is reduced by 1 to keep render inside of form
        g.DrawRectangle(ThemePen, 0, 0, Sender.Width - 1, Sender.Height - 1)

    End Sub

    ' Summoner of Forms
    ''' <summary>
    ''' Opens Forms and Focus' them, also respects autohide rules
    ''' </summary>
    ''' <param name="Sender">Form to Summon</param>
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

    ' Save Settings To My.Settings
    Public Sub ASave() ' Hi

        My.Settings.Save()

        My.Settings.Reload()

    End Sub

    ' Save Settings To File
    Public Sub ESave()

        settings.Add("AppLocalRunPref", My.Settings.AppLocalRunPref)
        settings.Add("ArgusDir", My.Settings.ArgusDir)
        settings.Add("ArgusMood", My.Settings.ArgusMood)
        settings.Add("AutohideOpMenu", My.Settings.AutohideOpMenu)
        settings.Add("AutohideSearch", My.Settings.AutohideSearch)
        settings.Add("Blur", My.Settings.Blur)
        settings.Add("BrowserDir", My.Settings.BrowserDir)
        settings.Add("Collection1", My.Settings.Collection1)
        settings.Add("Collection2", My.Settings.Collection2)
        settings.Add("Collection3", My.Settings.Collection3)
        settings.Add("Collection4", My.Settings.Collection4)
        settings.Add("Collection5", My.Settings.Collection5)
        settings.Add("Collection6", My.Settings.Collection6)
        settings.Add("Collection7", My.Settings.Collection7)
        settings.Add("Collection8", My.Settings.Collection8)
        settings.Add("Collection9", My.Settings.Collection9)
        settings.Add("CollectionsLastPos", My.Settings.CollectionsLastPos)
        settings.Add("CollectionsPos", My.Settings.CollectionsPos)
        settings.Add("DebugFeatures", My.Settings.DebugFeatures)
        settings.Add("Ding", My.Settings.Ding)
        settings.Add("DirOperatorImage", My.Settings.DirOperatorImage)
        settings.Add("FavColor", My.Settings.FavColor)
        settings.Add("FirstRun", My.Settings.FirstRun)
        settings.Add("Focus", My.Settings.Focus)
        settings.Add("FocusSearch", My.Settings.FocusSearch)
        settings.Add("GameLib", My.Settings.GameLib)
        settings.Add("Homepage", My.Settings.Homepage)
        settings.Add("LauncherAoT", My.Settings.LauncherAoT)
        settings.Add("LauncherLastPos", My.Settings.LauncherLastPos)
        settings.Add("LauncherPos", My.Settings.LauncherPos)
        settings.Add("OperatorName", My.Settings.OperatorName)
        settings.Add("PersistCollections", My.Settings.PersistCollections)
        settings.Add("PersistHome", My.Settings.PersistHome)
        settings.Add("PersistMusic", My.Settings.PersistMusic)
        settings.Add("PersistSearch", My.Settings.PersistSearch)
        settings.Add("PersistSocial", My.Settings.PersistSocial)
        settings.Add("PersistToolbox", My.Settings.PersistToolbox)
        settings.Add("PersistWallet", My.Settings.PersistWallet)
        settings.Add("StartupFocus", My.Settings.StartupFocus)
        settings.Add("ThemeUniversal", My.Settings.ThemeUniversal)
        settings.Add("WebSearchProvider", My.Settings.WebSearchProvider)
        settings.Add("WindowsTheme", My.Settings.WindowsTheme)

        Dim json As String = JsonConvert.SerializeObject(settings) ' Serialize the dictionary to a JSON string.

        Dim ourdir As String = Path.Combine(My.Settings.OperatorDirectory & "\Operator")

        File.WriteAllText(ourdir & "\settings.json", json) ' Write JSON string to the .json file.

        ASave()



    End Sub

    ' Load Settings from File
    Public Sub ERead()

        Dim readJson As String = File.ReadAllText(My.Settings.OperatorDirectory & "\Operator\settings.json")

        Dim readValues As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(readJson)

        Dim PosCollections() As String = readValues("CollectionsLastPos").Split(",")
        Dim PosCollectionsx As Integer = Integer.Parse(PosCollections(0))
        Dim PosCollectionsy As Integer = Integer.Parse(PosCollections(1))

        Dim PosLauncher() As String = readValues("LauncherLastPos").Split(",")
        Dim PosLauncherx As Integer = Integer.Parse(PosLauncher(0))
        Dim PosLaunchery As Integer = Integer.Parse(PosLauncher(1))


        My.Settings.AppLocalRunPref = readValues("AppLocalRunPref")
        My.Settings.ArgusDir = readValues("ArgusDir")
        My.Settings.ArgusMood = readValues("ArgusMood")
        My.Settings.AutohideOpMenu = readValues("AutohideOpMenu")
        My.Settings.AutohideSearch = readValues("AutohideSearch")
        My.Settings.Blur = readValues("Blur")
        My.Settings.BrowserDir = readValues("BrowserDir")
        My.Settings.Collection1 = readValues("Collection1")
        My.Settings.Collection2 = readValues("Collection2")
        My.Settings.Collection3 = readValues("Collection3")
        My.Settings.Collection4 = readValues("Collection4")
        My.Settings.Collection5 = readValues("Collection5")
        My.Settings.Collection6 = readValues("Collection6")
        My.Settings.Collection7 = readValues("Collection7")
        My.Settings.Collection8 = readValues("Collection8")
        My.Settings.Collection9 = readValues("Collection9")
        My.Settings.CollectionsLastPos = New Point(PosCollectionsx, PosCollectionsy)
        My.Settings.CollectionsPos = readValues("CollectionsPos")
        My.Settings.DebugFeatures = readValues("DebugFeatures")
        My.Settings.Ding = readValues("Ding")
        My.Settings.DirOperatorImage = readValues("DirOperatorImage")
        My.Settings.FavColor = Color.FromName(readValues("FavColor"))
        My.Settings.FirstRun = readValues("FirstRun")
        My.Settings.Focus = readValues("Focus")
        My.Settings.FocusSearch = readValues("FocusSearch")
        My.Settings.GameLib = readValues("GameLib")
        My.Settings.Homepage = readValues("Homepage")
        My.Settings.LauncherAoT = readValues("LauncherAoT")
        My.Settings.LauncherLastPos = New Point(PosLauncherx, PosLaunchery)
        My.Settings.LauncherPos = readValues("LauncherPos")
        My.Settings.OperatorName = readValues("OperatorName")
        My.Settings.PersistCollections = readValues("PersistCollections")
        My.Settings.PersistHome = readValues("PersistHome")
        My.Settings.PersistMusic = readValues("PersistMusic")
        My.Settings.PersistSearch = readValues("PersistSearch")
        My.Settings.PersistSocial = readValues("PersistSocial")
        My.Settings.PersistToolbox = readValues("PersistToolbox")
        My.Settings.PersistWallet = readValues("PersistWallet")
        My.Settings.StartupFocus = readValues("StartupFocus")
        My.Settings.ThemeUniversal = readValues("ThemeUniversal")
        My.Settings.WebSearchProvider = readValues("WebSearchProvider")
        My.Settings.WindowsTheme = readValues("WindowsTheme")

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

        If My.Settings.PersistMusic = True Then
            Summon(FormMusic)
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

        MsgBox("I don't do anything anymore")
        MsgBox("See the ESave() Function")
        MsgBox("Maybe these functions will be merged?")
        MsgBox("Why are these messages in message boxes?")
        MsgBox("I dunno")

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

    ' Create Tree Structure
    Public Sub BuildOperatorTree()

        Dim BasePaths() As String = {".tmp", ".cloud", "Media", "Operator", "Software"}
        Dim MediaPaths() As String = {"Book", "Font", "Image", "Model", "Theme", "Video"}
        Dim OperatorPaths() As String = {"Document", "Keyring", "Media", "Note", "Shortcut", "Template", "Wallet"}
        Dim SoftwarePaths() As String = {".template", ".unsorted", "Crypto", "Development", "Driver", "Education", "Emulation", "File Distribution", "Game", "Media", "Operating System", "Productivity", "Repository", "Remote Control", "Security", "Script", "Shell", "System", "Utility", "Web"}

        For Each item In BasePaths
            Directory.CreateDirectory(Path.Combine(My.Settings.OperatorDirectory & "\" & item))
        Next

        For Each item In MediaPaths
            Directory.CreateDirectory(Path.Combine(My.Settings.OperatorDirectory & "\Media\" & item))
        Next

        For Each item In OperatorPaths
            Directory.CreateDirectory(Path.Combine(My.Settings.OperatorDirectory & "\Operator\" & item))
        Next

        For Each item In SoftwarePaths
            Directory.CreateDirectory(Path.Combine(My.Settings.OperatorDirectory & "\Software\" & item))
        Next
    End Sub



End Module

Module WindowsCommon

    Public Function CreateJunction(ByVal junctionPath As String, ByVal targetPath As String) As Boolean

        Try

            Dim process As New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = $"/c mklink /j ""{junctionPath}"" ""{targetPath}"""
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.Start()
            process.WaitForExit()
            Return (process.ExitCode = 0)

        Catch ex As Exception

            Return False

        End Try

    End Function

End Module