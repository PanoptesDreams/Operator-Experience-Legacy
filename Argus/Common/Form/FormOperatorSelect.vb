Public Class FormOperatorSelect

    Dim OperatorJunction As String = "A:"


    Private Sub FormOperatorSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateList()

    End Sub


    Private Sub CheckedListBoxOperators_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxOperators.SelectedIndexChanged

        Dim listBox As CheckedListBox = DirectCast(sender, CheckedListBox)
        Dim selectedIndex As Integer = listBox.SelectedIndex

        ' Uncheck all other items
        For i As Integer = 0 To listBox.Items.Count - 1
            If i <> selectedIndex Then
                listBox.SetItemChecked(i, False)
            End If
        Next

        ' Check the selected item
        If selectedIndex >= 0 AndAlso Not listBox.GetItemChecked(selectedIndex) Then
            listBox.SetItemChecked(selectedIndex, True)
        End If

    End Sub

    Private Sub ButtonAddOperator_Click(sender As Object, e As EventArgs) Handles ButtonAddOperator.Click

        If CreateOperator(InputBox("Enter a username", "Create User")) = 1 Then

            PopulateList()

        End If

    End Sub

    Public Sub PopulateList()

        CheckedListBoxOperators.Items.Clear()


        If Directory.Exists(OperatorJunction) Then ' Directory exists

            For Each dir As String In Directory.EnumerateDirectories(OperatorJunction)

                Dim attributes As FileAttributes = File.GetAttributes(dir)

                If ((attributes And FileAttributes.Hidden) <> FileAttributes.Hidden) And ((attributes And FileAttributes.System) <> FileAttributes.System) Then

                    Dim folderName As String = Path.GetFileName(dir)

                    folderName = StrConv(folderName, VbStrConv.ProperCase)

                    CheckedListBoxOperators.Items.Add(folderName)

                End If

            Next

        Else ' Directory does not exist

            CheckedListBoxOperators.Items.Clear()

            MessageBox.Show("The junction " & OperatorJunction & " does not exist. You will need to create one manually.")

        End If

    End Sub

End Class