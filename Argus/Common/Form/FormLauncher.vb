Option Explicit On

'Header a.k.a Launcher
Public Class FormHeader

    Dim WebToggle As Int16 = 0
    Dim lastPOS As Point = My.Settings.LauncherLastPos

    Dim FirstRun As Boolean = True
    Dim HideMode As Boolean = False

    Dim OperatorPicture As Image = Image.FromFile(My.Settings.DirOperatorImage) ' Set image from file



    'Start/Load
    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ERead()
        Catch ex As Exception

        End Try



        DebugFeatures() ' Are we in debug mode?

        Portable() ' Check if we are in portable mode

        UniThemer(Me) ' Set theme

        Positioner(Me, My.Settings.LauncherPos, My.Settings.LauncherLastPos) ' Position Form

        labelGreeter.Text = Greeting() ' Greet the user

        labelOperatorName.Text = My.Settings.OperatorName ' Retrieve name

        PictureBoxOperator.Image = ResizeImage(OperatorPicture, PictureBoxOperator.Width, PictureBoxOperator.Height) ' Resize imported image and apply


        SetTime() ' Sets all timedate labels to their respective nows

        Me.Width = Math.Round(Screen.PrimaryScreen.Bounds.Width * 0.33) ' Set Form width from monitor width

        Blur() 'Apply Blur

        PersitingApp() ' Launch persiting apps

        Opacity = 100 ' Finished Loading and Setting, show form

        ArgFocus()

    End Sub


    'Activation
    Private Sub FormHeader_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If FirstRun = True Then

            FirstRun = False

        End If

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

        BorderDrawerer(Me, e)

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


#Region "User Menu"

    Private Sub PicUserImage_Click(sender As Object, e As EventArgs) Handles PictureBoxOperator.Click

        Summon(FormOpMenu)

    End Sub

    Private Sub PicUserImage_DoubleClick(sender As Object, e As EventArgs) Handles PictureBoxOperator.DoubleClick

        Banish(FormOpMenu)

    End Sub

#End Region


#Region "Collections"
    Private Sub PicCollections_Click(sender As Object, e As EventArgs) Handles PicCollections.Click

        Summon(FormCollections)

    End Sub

    Private Sub PicCollections_DoubleClick(sender As Object, e As EventArgs) Handles PicCollections.DoubleClick

        Banish(FormCollections)

    End Sub
#End Region


    'Debug Button 1
    Private Sub DebugButton_Click(sender As Object, e As EventArgs) Handles ButtonDebug.Click

        Summon(FormDebugPanel)

        'Test button for testing things

        'returns current time as 00:00 AM format
        'MsgBox(Now.ToShortTimeString)

        'Check for environment variable
        'MsgBox(Environment.GetEnvironmentVariable("argus"))

    End Sub

    'Debug Button 2
    Private Sub btnDebug2_Click(sender As Object, e As EventArgs) Handles ButtonDebug2.Click



1:

    End Sub









    'Move form with click drag
#Region "Move"  'Mouse down, Mouse Move, Mouse Release

    'Main Form
    Private Sub FormHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        FormMoverGrab(Me)

    End Sub

    Private Sub FormHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        FormMover(Me)

    End Sub

    Private Sub FormHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        My.Settings.LauncherLastPos = Location
        ASave()

        FormMoverRelease()

    End Sub

    'Greeting Panel
    Private Sub PanelGreeting_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelGreeting.MouseDown

        FormMoverGrab(Me)

    End Sub

    Private Sub PanelGreeting_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelGreeting.MouseMove

        FormMover(Me)

    End Sub

    Private Sub PanelGreeting_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelGreeting.MouseUp

        My.Settings.LauncherLastPos = Location
        ASave()

        FormMoverRelease()

    End Sub
#End Region

    'Tray icon
#Region "Tray"
    Private Sub TrayMenuItemExit_Click(sender As Object, e As EventArgs) Handles TrayMenuItemExit.Click

        Me.Close()

    End Sub

    Public Sub TrayMenuItemToggleVisibility_Click(sender As Object, e As EventArgs) Handles TrayMenuItemToggleVisibility.Click



    End Sub

    Private Sub TrayMenuSettings_Click(sender As Object, e As EventArgs) Handles TrayMenuSettings.Click

        Summon(FormSettings)

    End Sub

    Private Sub ButtonCloseLauncher_Click(sender As Object, e As EventArgs)

        Banish(Me)

    End Sub

    Public Sub FormHeader_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Dim shorty As String = e.KeyValue.ToString

        ' These change depending on keyboard layout, please update to check layout and assign response
        Select Case shorty

            Case = "9" Or "17" 'Tab or Control, happens on startup sometimes
                GoTo 1

            Case = "83" 's
                Summon(FormSearch)

            Case = "67" 'c
                Summon(FormCollections)

            Case = "39" 'left arrow
                GoTo 1

            Case = "37" 'right arrow
                GoTo 1

        End Select

1:

    End Sub

    Private Sub ContextMenuTrayIcon_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuTrayIcon.Opening

    End Sub

    Private Sub CoreKeeperToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SteamLauncher(1621690)
    End Sub

    Private Sub Destiny2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SteamLauncher(1085660)
    End Sub

    Private Sub CollectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionsToolStripMenuItem.Click
        Summon(FormCollections)
    End Sub

    Private Sub DocumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentsToolStripMenuItem.Click
        OpenUserDocs()
    End Sub

    Private Sub GamesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GamesToolStripMenuItem1.Click
        Summon(FormGame)
    End Sub

    Private Sub SoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareToolStripMenuItem.Click
        Summon(FormSoftware)
    End Sub

    Private Sub FormHeader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ESave()

    End Sub

    Private Sub labelOperatorName_Click(sender As Object, e As EventArgs) Handles labelOperatorName.Click
        Summon(FormOperatorSelect)
    End Sub




    'Quick Shortcuts



#End Region






End Class