Public Class FormEditor

    Dim Target As String

    Private Sub FormEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        FormGame.LabelOperatorNotes.Text = TextEditBox.Text

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        Ding()

        Dim diagres As DialogResult = MsgBox("Are You Sure? You will lose all changes!", vbYesNo)

        If diagres = vbYes Then

            Banish(Me)

        ElseIf diagres = vbNo Then



        End If



    End Sub
End Class