Imports System.IO

Public Class FormDebugPanel

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LabelRewritable.Click

        RichTextBox1.Select()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

        LabelRewritable.Text = RichTextBox1.Text

        If LabelRewritable.Text = "" Then

            LabelRewritable.Text = "Click Me! 👆"

        End If

    End Sub


    Private Sub ButtonOpenSearch_Click(sender As Object, e As EventArgs) Handles ButtonOpenSearch.Click

        Summon(FormSearch)

    End Sub

    Public Sub ButtonOpenStartMenu_Click(sender As Object, e As EventArgs) Handles ButtonOpenStartMenu.Click

        'keybd_event(VK_STARTKEY, 0, 0, 0)
        'keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)

    End Sub

    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    Const VK_STARTKEY = &H5B

    Const KEYEVENTF_KEYUP = &H2

    Private Sub ButtonMakeINI_Click(sender As Object, e As EventArgs) Handles ButtonMakeINI.Click

        GenerateSettings()

    End Sub

    Private Sub ButtonRND_Click(sender As Object, e As EventArgs) Handles ButtonRND.Click

        Dim FirstName() As String
        ReDim FirstName(100)

        For i = 1 To 100
            For Each line As String In File.ReadLines("A:\Argus\firstname.txt") 'Loop over lines in file.

                FirstName(i) = line

            Next
        Next

        LabelDebugName.Text = FirstName(1)



    End Sub

    Private Sub ButtonSteamLinkGen_Click(sender As Object, e As EventArgs) Handles ButtonSteamLinkGen.Click
        Summon(FormSteamLinkGenerater)
    End Sub



    Private Sub ButtonReadArgs_Click(sender As Object, e As EventArgs) Handles ButtonReadArgs.Click

        Dim Args As String() = Arguments()

        Try
            For i = 0 To Args.Length - 1

                ListBoxArguments.Items.Add(Args(i))

            Next
        Catch

        End Try


    End Sub
End Class