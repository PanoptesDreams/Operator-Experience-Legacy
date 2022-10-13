Imports System.Xml
Imports System.IO
Imports Argus.ArgusCommon

Public Class FormGame

    'Variable Start
    Dim ShowTemplate As Boolean = My.Settings.DebugFeatures

    'Directories
    Dim ArgusDir As String = Environment.GetEnvironmentVariable("argus")
    Dim GameLibDir As String = ArgusDir + My.Settings.GameLib 'A:\Software\Gaming\Library
    Dim GameWinDir As String = GameLibDir + "\Windows" 'A:\Software\Gaming\Library\Argus
    Dim GameXboxDir As String = GameLibDir + "\Xbox" 'A:\Software\Gaming\Library\Xbox (Please fix)
    Dim GamePlaystationDir As String = GameLibDir + "\PlayStation 2" 'A:\Software\Gaming\Library\PlayStation 2 (Please fix)
    Dim GameNintendoDir As String = GameLibDir + "\Gameboy Advanced" 'A:\Software\Gaming\Library\Gameboy Advanced (Please fix)
    Dim CurrentDir As String = GameLibDir

    'Buttons
    Dim PlayDr As String


    Dim GameName As String
    Dim GamePlatform As String
    Dim GameRelease As String

    'XML Dims
    Dim m_xmld As XmlDocument
    Dim m_nodelist As XmlNodeList
    Dim m_node As XmlNode


    'Form Load
    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        'LoadGame()

        GameListBuilder("Windows")
        GameListBuilder("Playstation")
        GameListBuilder("Xbox")
        GameListBuilder("Nintendo")

        ListGamesWin.SelectedIndex = 0
        ListGamesXbox.SelectedIndex = 0
        ListGamesPlaystation.SelectedIndex = 0
        ListGamesNintendo.SelectedIndex = 0


        'Debug Features
        If My.Settings.DebugFeatures = False Then
            ButtonDebug0.Hide()
            ButtonDebug2.Hide()
        End If
    End Sub

    'Game list builder
    Public Sub GameListBuilder(Platform As String)

        Dim TargetList As ListBox = ListGamesWin

        'Supported Platforms:
        '3DS, Gameboy, Gameboy Color, Gameboy Advanced, Gamecube, GOG, N64, Playstation 1
        'Playstation 2, Playstation 3, Playstation Portable, Steam, Switch, Wii, Xbox, Xbox 360
        Select Case Platform

            Case = "Windows"
                CurrentDir = GameWinDir
                TargetList = ListGamesWin

            Case = "Playstation"
                CurrentDir = GamePlaystationDir + "\roms"
                TargetList = ListGamesPlaystation

            Case = "Xbox"
                CurrentDir = GameXboxDir + "\roms"
                TargetList = ListGamesXbox

            Case = "Nintendo"
                CurrentDir = GameNintendoDir + "\roms"
                TargetList = ListGamesNintendo

        End Select


        For Each item In Directory.EnumerateDirectories(CurrentDir)

            TargetList.Items.Add(item.Remove(0, CurrentDir.Length + 1))

        Next

        If ShowTemplate = False Then

            Select Case Platform

                Case = "Windows"
                    TargetList.Items.RemoveAt(0)
                    TargetList.Items.RemoveAt(0)

                Case = "Playstation"

                Case = "Xbox"
                    TargetList.Items.RemoveAt(0)

                Case = "Nintendo"

            End Select

        End If

    End Sub

    'Empty
    Public Sub GameListClearer(Platform As String)

        Dim TargetList As ListBox = ListGamesWin
        Dim ItemsToScrub As Integer = 1

        Select Case Platform

            Case = "Windows"
                TargetList = ListGamesWin

            Case = "Playstation"
                TargetList = ListGamesPlaystation

            Case = "Xbox"
                TargetList = ListGamesXbox

            Case = "Nintendo"
                TargetList = ListGamesNintendo

        End Select

        ItemsToScrub = TargetList.Items.Count

        For i = 1 To ItemsToScrub
            TargetList.Items.RemoveAt(0)
        Next

    End Sub

    'Empty
    Public Sub GameThings()


    End Sub

    'Ignore for now
    Public Sub LoadGame()

        m_xmld = New XmlDocument

        'Chose document to load
        m_xmld.Load(GameLibDir + "\Windows\Argus Library\library.xml")

        'Fetch nodes
        m_nodelist = m_xmld.GetElementsByTagName("Game")


        For Each m_node In m_nodelist

            ListGamesWin.Items.Add(m_node.Item("Name").InnerText)

        Next


    End Sub


    Private Sub TabControlGameLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlGameLists.SelectedIndexChanged

        Dim CurrentTab As String = TabControlGameLists.SelectedTab.Text
        Dim GameList As ListBox

        Select Case CurrentTab
            Case = "Win"
                GameList = ListGamesWin
            Case = "Xbox"
                GameList = ListGamesXbox
            Case = "Playstation"
                GameList = ListGamesPlaystation
            Case = "Nintendo"
                GameList = ListGamesNintendo
        End Select

        GameNamer()

    End Sub

    Private Sub lstGamesWin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListGamesWin.SelectedIndexChanged
        GameNamer()
    End Sub

    Private Sub ListGamesXbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListGamesXbox.SelectedIndexChanged
        GameNamer()
    End Sub

    Private Sub ListGamesPlaystation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListGamesPlaystation.SelectedIndexChanged
        GameNamer()
    End Sub

    Private Sub ListGamesNintendo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListGamesNintendo.SelectedIndexChanged
        GameNamer()
    End Sub


    Public Sub GameNamer()

        Dim CurrentTab As String = TabControlGameLists.SelectedTab.Text
        Dim GameList As ListBox = ListGamesWin


        Select Case CurrentTab

            Case = "Win"
                GameList = ListGamesWin
                CurrentDir = GameWinDir

            Case = "Xbox"
                GameList = ListGamesXbox
                CurrentDir = GameXboxDir + "\roms"

            Case = "Playstation"
                GameList = ListGamesPlaystation
                CurrentDir = GamePlaystationDir + "\roms"

            Case = "Nintendo"
                GameList = ListGamesNintendo
                CurrentDir = GameNintendoDir + "\roms"

        End Select


        CurrentDir = CurrentDir + "\" + GameList.SelectedItem
        LblGameDir.Text = CurrentDir


        If System.IO.File.Exists(CurrentDir + "\app") Then



            Using FileReader As StreamReader = File.OpenText(CurrentDir + "\app")

                Dim s As String

                s = FileReader.ReadLine()

                LabelGameTitle.Text = s

            End Using

        Else

            LabelGameTitle.Text = GameList.SelectedItem

        End If


    End Sub

    'Launch Game
    Private Sub ButtonPlayGame_Click(sender As Object, e As EventArgs) Handles ButtonPlayGame.Click

        Dim Arguments As String = ""
        Dim App As String = "play"
        Dim CurrentTab As String = TabControlGameLists.SelectedTab.Text
        Dim GameLauncher As New ProcessStartInfo
        Dim Game As String
        Dim WorkingDir As String = ArgusDir + CurrentDir

        Select Case CurrentTab

            Case = "Win" 'Check for 'play' file

                If System.IO.File.Exists(ArgusDir + CurrentDir + "\" + App) = False Then

                    MsgBox("This game is not configured correctly")
                    GoTo endsub

                ElseIf System.IO.File.Exists(ArgusDir + CurrentDir + "\steam") = True Then

                    Dim SteamLaunch As Integer

                    SteamLaunch = MsgBox("Launch Steam Version?", vbYesNo)

                    If SteamLaunch = 1 Then

                        Using FileReader As StreamReader = File.OpenText(ArgusDir + CurrentDir + "\Steam")

                            Dim s As String

                            s = FileReader.ReadLine()

                            SteamLauncher(Convert.ToInt64(s))

                        End Using

                    End If

                End If


            Case = "Xbox"
            Case = "Playstation"

                WorkingDir = ArgusDir + GamePlaystationDir + "\emulator\PCSX2"
                GameLauncher.FileName = ArgusDir + GamePlaystationDir + "\emulator\PCSX2\pcsx2.exe"
                GameLauncher.WorkingDirectory = WorkingDir
                Game = ArgusDir + GamePlaystationDir + "\roms\" + ListGamesPlaystation.SelectedItem.ToString + "\" + ListGamesPlaystation.SelectedItem.ToString + ".iso"

                GameLauncher.Arguments = """" + Game + """" + " --portable --nogui --fullscreen"


                If File.Exists(Game) = False Then

                    MsgBox("You seem to be missing a few relics")

                    GoTo endsub

                End If

                Process.Start(GameLauncher)

                GoTo endsub

            Case = "Nintendo"

                MsgBox("Fuck")
                GoTo endsub

        End Select


        Using FileReader As StreamReader = File.OpenText(ArgusDir + CurrentDir + "\" + App)

            Dim s As String

            s = FileReader.ReadLine()

            GameLauncher.FileName = ArgusDir + CurrentDir + "\" + s

            GameLauncher.WorkingDirectory = WorkingDir

            If Arguments = "" Then

                'MsgBox(Game.FileName.ToString)'Debug Feature
                Process.Start(GameLauncher)
                GoTo endsub

            End If

            GameLauncher.Arguments = Arguments

            Process.Start(GameLauncher)

        End Using


endsub:
    End Sub

    'Open Current Folder
    Private Sub ButtonOpenGameFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenGameFolder.Click

        Process.Start("explorer.exe", ArgusDir + CurrentDir)

    End Sub

    Private Sub ButtonDebug0_Click(sender As Object, e As EventArgs) Handles ButtonDebug0.Click
        MsgBox(ArgusDir + CurrentDir)


    End Sub

    Private Sub ButtonDebug2_Click(sender As Object, e As EventArgs) Handles ButtonDebug2.Click

        GameListClearer("Windows")

    End Sub

    Private Sub ButtonEditOperatorNotes_Click(sender As Object, e As EventArgs) Handles ButtonEditOperatorNotes.Click

        Summon(FormEditor)

        FormEditor.TextEditBox.Text = LabelOperatorNotes.Text

    End Sub


End Class