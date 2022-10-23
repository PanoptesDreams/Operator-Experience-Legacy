Public Class FormBlur

    Private Sub FormBlur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Width = My.Computer.Screen.Bounds.Width

        Height = My.Computer.Screen.WorkingArea.Height


    End Sub

    Public Sub Argus_Refresh()
        Threading.Thread.Sleep(1)
    End Sub

    Private Sub pickBlurImg_Click(sender As Object, e As EventArgs) Handles pickBlurImg.Click

        FormHeader.Hide() ' Must be hidden - closing will end argus

        Banish(FormCollections)

        Banish(FormOpMenu)

        Banish(FormWallet)

        Banish(Me) ' Must be last

    End Sub


End Class