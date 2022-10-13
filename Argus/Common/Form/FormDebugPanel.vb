Imports System.IO

Public Class FormDebugPanel

    Dim Args As String() = Arguments()

    Dim Froms As Form() = {FormBlur, FormCollections, FormDocuments, FormEditor, FormGame, FormHeader, FormHomepage, FormLoadingSplash, FormLogin, FormMusic, FormOOBEPrivacy, FormOOBESystem, FormReplicationChamber, FormSearch, FormSettings, FormSocial, FormSoftware, FormSteamLinkGenerater, FormUserMenu, FormWallet}

    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    Const VK_STARTKEY = &H5B
    Const KEYEVENTF_KEYUP = &H2

    Private Sub FormDebugPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me) ' Skin form

        ' Add arguments to Argument Listbox
        Try
            For i = 0 To Args.Length - 1

                ListBoxArguments.Items.Add(Args(i))

            Next
        Catch

        End Try

        FormsList()

        ComboBoxForms.SelectedIndex = 0

    End Sub

    Sub FormsList()

        For i = 0 To Froms.Length - 1

            ComboBoxForms.Items.Add(Froms(i).Name)

        Next

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LabelRewritable.Click

        RichTextBox1.Select()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

        LabelRewritable.Text = RichTextBox1.Text

        If LabelRewritable.Text = "" Then

            LabelRewritable.Text = "Click Me! 👆"

        End If

    End Sub




    Public Sub ButtonOpenStartMenu_Click(sender As Object, e As EventArgs) Handles ButtonOpenStartMenu.Click

        WinStart()

        'keybd_event(VK_STARTKEY, 0, 0, 0)
        'keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)

    End Sub



    Private Sub ButtonMakeINI_Click(sender As Object, e As EventArgs) Handles ButtonMakeINI.Click

        GenerateSettings()

    End Sub

    Private Sub ButtonRND_Click(sender As Object, e As EventArgs) Handles ButtonRND.Click

        Dim FirstName() As String
        ReDim FirstName(100)

        ListBoxArguments.Items.Clear()

        For i = 1 To 100
            For Each line As String In File.ReadLines("A:\Argus\firstname.txt") 'Loop over lines in file.

                FirstName(i) = line



                ListBoxArguments.Items.Add(FirstName(i))

            Next
        Next

        LabelDebugName.Text = FirstName(1)



    End Sub



    Private Sub ButtonReadArgs_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub ButtonWriteKey_Click(sender As Object, e As EventArgs) Handles ButtonWriteKey.Click

        My.Computer.Registry.ClassesRoot.CreateSubKey("argus")


    End Sub

    Private Sub ButtonOpenForm_Click(sender As Object, e As EventArgs) Handles ButtonOpenForm.Click

        Summon(Froms(ComboBoxForms.SelectedIndex))

    End Sub


End Class