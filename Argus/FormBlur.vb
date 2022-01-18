Public Class FormBlur

    Public Sub Argus_Refresh()
        Threading.Thread.Sleep(1)
    End Sub

    Private Sub pickBlurImg_Click(sender As Object, e As EventArgs) Handles pickBlurImg.Click
        Close()
    End Sub
End Class