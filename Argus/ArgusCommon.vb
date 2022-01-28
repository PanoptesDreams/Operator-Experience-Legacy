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
    Public Function BgColorPicker()

        Dim UserTheme As String = My.Settings.ThemeUniversal
        Dim BgColor As New Color

        Select Case UserTheme

            Case = "Light"
                BgColor = Color.White

            Case = "Dark"
                BgColor = ControlPaint.ContrastControlDark

            Case = "User"
                BgColor = Color.Blue

        End Select

        Return BgColor

    End Function

    'Settings Saver
    Public Function ASave() ' Hi


        My.Settings.Save()

        My.Settings.Reload()

    End Function


End Module
