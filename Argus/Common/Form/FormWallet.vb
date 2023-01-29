' Imports Excel = Microsoft.Office.Interop

Public Class FormWallet

    Public Declare Function GetForegroundWindow Lib "user32" () As Integer

    Private Sub FormWallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' We are disabled until we are upgraded, if you wish to re-enable, remove the line below
        Banish(Me)


        ' UniThemer(Me)

    End Sub



    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        Dim appXL
        Dim wbXl
        Dim shXL
        Dim raXL

        ' Start Excel and get Application object.
        appXL = Process.GetProcessById(GetForegroundWindow)
        appXL.Visible = True

        ' Add a new workbook.
        wbXl = appXL.Workbooks.Add
        shXL = wbXl.ActiveSheet

        ' Add table headers going cell by cell.
        shXL.Cells(1, 1).Value = "First Name"
        shXL.Cells(1, 2).Value = "Last Name"
        shXL.Cells(1, 3).Value = "Full Name"
        shXL.Cells(1, 4).Value = "Specialization"

        ' Format A1:D1 as bold, vertical alignment = center.
        With shXL.Range("A1", "D1")
            .Font.Bold = True
            ' .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With



        ' Fill A2:B6 with an array of values (First and Last Names).
        shXL.Range("A2", "B6").Value = students

        ' Fill C2:C6 with a relative formula (=A2 & " " & B2).
        raXL = shXL.Range("C2", "C6")
        raXL.Formula = "=A2 & "" "" & B2"

        ' Fill D2:D6 values.
        With shXL
            .Cells(2, 4).Value = "Biology"
            .Cells(3, 4).Value = "Mathmematics"
            .Cells(4, 4).Value = "Physics"
            .Cells(5, 4).Value = "Mathmematics"
            .Cells(6, 4).Value = "Arabic"
        End With

        ' AutoFit columns A:D.
        raXL = shXL.Range("A1", "D1")
        raXL.EntireColumn.AutoFit()

        ' Make sure Excel is visible and give the user control
        ' of Excel's lifetime.
        appXL.Visible = True
        appXL.UserControl = True

        ' Release object references.
        raXL = Nothing
        shXL = Nothing
        wbXl = Nothing
        appXL.Quit()
        appXL = Nothing
        Exit Sub
Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)

    End Sub
End Class