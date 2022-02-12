Module ArgusCommon


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

    'Summoner
    Public Function Summon(Sender As Form)

        If Sender.Visible = True Then

            Sender.Hide()

        Else
            Sender.Show()

            Sender.Activate()
        End If


    End Function

    'User Menu Auto-Hide
    Public Function HideUsermenu()

        'Check if user has autohide set to 'True' and disposes of it when an argus applet is invoked
        If My.Settings.AutohideUsermenu = True Then

            FormUserMenu.Dispose()

            Return 1

        End If

        Return 0

    End Function


    'Image Resizer
    Public Function ResizeImage(ByVal InputImage As Image, ByVal IcoSize As Integer) As Image

        Return New Bitmap(InputImage, New Size(IcoSize, IcoSize))

    End Function


    'Themer
    Public Function UniThemer(Sender As Object)

        Dim UniversalTheme As String = My.Settings.ThemeUniversal
        Dim FontyPen As Color
        Dim ThemerColor As Color


        Select Case UniversalTheme

            Case = "Light"
                ThemerColor = Color.FromArgb(245, 245, 245)
                Sender.BackgroundImage = My.Resources.bg_light
                FontyPen = Color.FromArgb(33, 33, 33)

            Case = "Dark"
                ThemerColor = Color.FromArgb(63, 63, 63)
                Sender.BackgroundImage = My.Resources.bg
                FontyPen = Color.FromArgb(245, 245, 245)

            Case = "User"
                ThemerColor = Color.FromArgb(255, 195, 203)
                Sender.BackgroundImage = My.Resources.game_poster_mask
                FontyPen = My.Settings.FavColor

        End Select

        Sender.BackColor = ThemerColor

        Sender.ForeColor = FontyPen

        Return 1


    End Function

    'Fonty
    Public Function Fonty(Sender As Form)

    End Function

    'Positioner
    Public Function Positioner(Sender As Form, Owner As String, LastPos As Point)

        Select Case Owner
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

    End Function

    'Settings Saver
    Public Function ASave() ' Hi


        My.Settings.Save()

        My.Settings.Reload()

    End Function

    Public Function ESave()



    End Function

    'Button Glow
    Public Function ButtonGlow(TLabel As Label)

        TLabel.Image = My.Resources.frame

    End Function


    'Button Glow
    Public Function ButtonUnGlow(TLabel As Label)

        TLabel.Image = My.Resources.frame_empty


    End Function

    'persistence checker
    Public Function PersitingApp()

        If My.Settings.PersistCollections = True Then
            Summon(FormCollections)
        End If

        If My.Settings.PersistSocial = True Then

        End If

        If My.Settings.PersistToolbox = True Then

        End If
    End Function

    Public Function TheThemerer(Sender As Form)



    End Function

End Module
