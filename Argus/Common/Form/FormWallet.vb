Imports Excel = Microsoft.Office.Interop

Public Class FormWallet

    Public Declare Function GetForegroundWindow Lib "user32" () As Integer

    Private Sub FormWallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

    End Sub



    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        ' The code that actually did something is not here.
        ' Don't know where don't ask me

    End Sub
End Class