Public Class FormOOBESystem

    'Variables
    Dim SystemName As String = My.Computer.Name
    Dim UserName As String = My.User.Name


    Private Sub FormOOBE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        ResetForm()

    End Sub

    Public Sub ResetForm()

        SystemName = My.Computer.Name
        TextBoxSystemName.Text = SystemName

        UserName = My.User.Name
        TextBoxUserName.Text = UserName

    End Sub

#Region "Buttons"

    Private Sub ButtonDefaultsReset_Click(sender As Object, e As EventArgs) Handles ButtonDefaultsReset.Click

        ResetForm()

    End Sub

#End Region

End Class