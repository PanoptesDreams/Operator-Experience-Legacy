Module ArgusCommon

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
    Public Function UniThemer(UserForm As Form, ThemePen As Color)

        Dim UserTheme As String = My.Settings.ThemeUniversal
        Dim BgColor As New Color

        'Choose background coloring for common forms
        Select Case UserTheme

            Case = "Light"
                BgColor = Color.White 'replace with smoky white

            Case = "Dark"
                BgColor = ControlPaint.ContrastControlDark

            Case = "User"
                BgColor = Color.Blue

        End Select


        'Set background images and font pen
        Select Case UserTheme

            Case = "Light"
                ThemePen = Color.Black
                UserForm.BackgroundImage = My.Resources.strip_light

            Case = "Dark"
                ThemePen = Color.Silver
                UserForm.BackgroundImage = My.Resources.strip

            Case = "User"
                'Please add user customizations
                ThemePen = Color.Silver
                UserForm.BackgroundImage = My.Resources.strip
                '^^ these are placeholders!
        End Select


        Return BgColor

    End Function


    'Settings Saver
    Public Function ASave() ' Hi


        My.Settings.Save()

        My.Settings.Reload()

    End Function


    'Button GLow
    Public Function ButtonGlow(TButton As PictureBox)

        TButton.BackgroundImage = My.Resources.frame

    End Function


    'Button GLow
    Public Function ButtonUnGlow(TButton As PictureBox)

        TButton.BackgroundImage = My.Resources.frame_empty


    End Function

End Module
