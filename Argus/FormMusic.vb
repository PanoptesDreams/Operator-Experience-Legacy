Imports System.IO

Public Class FormMusic

    Dim MusicDir As String = "C:\Users\argus\Music"
    Dim SongSelected As String

    Private Sub frmMusic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateMusic()

        ListBoxMusic.SelectedIndex = 0

    End Sub

    Sub PopulateMusic()

        For Each item In Directory.EnumerateFiles(MusicDir)

            If item = MusicDir & "\desktop.ini" Then
                GoTo jump
            End If

            ListBoxMusic.Items.Add(item.Remove(0, MusicDir.Length + 1))

jump:

        Next

    End Sub

    Private Sub ListBoxMusic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMusic.SelectedIndexChanged

        SongSelected = MusicDir & "\" & ListBoxMusic.SelectedItem.ToString

        MediaPlayer1.URL = SongSelected


    End Sub

    Private Sub FormMusic_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        FormMoverGrab(Me)
    End Sub

    Private Sub FormMusic_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        FormMoverRelease()
    End Sub

    Private Sub FormMusic_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        FormMover(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = MusicDir
        OFD.ShowDialog()

        MediaPlayer1.URL = OFD.FileName

    End Sub
End Class