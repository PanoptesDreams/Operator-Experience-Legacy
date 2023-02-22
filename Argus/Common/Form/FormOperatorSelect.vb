Public Class FormOperatorSelect

    ' Public Variables
    Dim OperatorJunction As String = "A:\"
    Dim AutoSignIn As Boolean = My.Settings.AutoSignIn
    Dim SelectedOperator As String = My.Settings.ActiveOperator


    ' Start
    Private Sub FormOperatorSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If AutoSignIn = True Then

            ActivateOperator()

        End If

        UniThemer(Me)

        PopulateList()

    End Sub

    ' Activate Operator and Start Launcher
    Public Sub ActivateOperator()

        My.Settings.ActiveOperator = SelectedOperator
        My.Settings.OperatorName = SelectedOperator
        My.Settings.OperatorDirectory = Path.Combine(OperatorJunction, SelectedOperator)

        ASave()

        Summon(FormHeader)

        If My.Settings.OperatorChange = True Then

            FormHeader.OperatorLoader()
            My.Settings.OperatorChange = False

            ASave()

        End If


    End Sub

    ' Populate Checkbox List with Operators
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

            Close()

        End If

    End Sub

    ' CheckBox's act like a radio button
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

        SelectedOperator = CheckedListBoxOperators.SelectedItem.ToString

    End Sub

    ' Add Operator
    Private Sub ButtonAddOperator_Click(sender As Object, e As EventArgs) Handles ButtonAddOperator.Click

        If CreateOperator(InputBox("Enter a username", "Create User")) = 1 Then

            PopulateList()

        End If

    End Sub

    ' Select Operator
    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click

        ActivateOperator()

        Me.Close()

    End Sub

End Class