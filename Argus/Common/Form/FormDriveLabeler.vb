Imports System.IO
Imports System.Security.Principal
Imports System.Diagnostics

Public Class FormDriveLabeler

    ' Admin Variables
    Dim identity = WindowsIdentity.GetCurrent()
    Dim principal = New WindowsPrincipal(identity)
    Dim isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator)

    ' Applet Variables
    Dim IconLocation As String = ""


    Private Sub FormDriveLabeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not isAdmin Then
            Dim startInfo = New ProcessStartInfo()
            startInfo.UseShellExecute = True
            startInfo.WorkingDirectory = Environment.CurrentDirectory
            startInfo.FileName = Application.ExecutablePath
            startInfo.Verb = "runas"

            Try
                Dim process = Diagnostics.Process.Start(startInfo)
            Catch ex As Exception
                MsgBox("This application requires administrative privileges to function properly. " & ex.Message)
                Me.Close()
            End Try
        End If

        PopulateDrives()

    End Sub

    Private Sub PopulateDrives()

        Dim drives = From item In My.Computer.FileSystem.Drives
                     Select item.Name.Substring(0, 2) & " (" & item.VolumeLabel & ")"

        For Each drive In drives

            ComboBoxDrive.Items.Add(drive)

        Next

    End Sub

    Private Sub ButtonExecute_Click(sender As Object, e As EventArgs) Handles ButtonExecute.Click

        If TextBoxIconPath.Text <> "Icon Path" Then
            IconLocation = TextBoxIconPath.Text
        End If

        Dim SelectedDrive As String = ComboBoxDrive.SelectedItem.ToString.Substring(0, 1)

        ChangeDriveLabel(SelectedDrive, TextboxLabel.Text, IconLocation)

    End Sub


    Private Sub ChangeDriveLabel(driveLetter As Char, label As String, icon As String)
        Dim drive As DriveInfo = New DriveInfo(driveLetter)

        ' Check if the drive exists and is ready
        If Not drive.IsReady Then
            MessageBox.Show("Drive " & driveLetter & " is not ready.")
            Return
        End If

        ' Set the drive label to nothing
        Try
            drive.VolumeLabel = label
        Catch ex As Exception
            MessageBox.Show("Failed to set the drive label: " & ex.Message)
            MessageBox.Show("Don't worry, that's what the autorun file is for :)")
        End Try

        ' Create autorun.ini file with the label
        Dim autorunFilePath As String = Path.Combine(drive.RootDirectory.FullName, "autorun.inf")
        Try
            Using writer As StreamWriter = New StreamWriter(autorunFilePath)
                writer.WriteLine("[AUTORUN]")
                writer.WriteLine("LABEL=" & label)
                writer.WriteLine("ICON=" & icon)
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to create autorun file: " & ex.Message)
        End Try
    End Sub


    Private Sub PicIcon_Click(sender As Object, e As EventArgs) Handles PicIcon.Click

        Dim IconOFD As New OpenFileDialog
        IconOFD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        IconOFD.Title = "Select Icon"
        IconOFD.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"

        ' Show the OpenFileDialog
        If IconOFD.ShowDialog() = DialogResult.OK Then

            TextBoxIconPath.Text = IconOFD.FileName

            Dim image As Image = Image.FromFile(IconOFD.FileName) ' Load the image from the selected file

            PicIcon.Image = image ' Display the image in the PictureBox control

        End If

out:
    End Sub
End Class