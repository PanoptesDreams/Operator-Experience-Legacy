Imports Argus.ArgusCommon

Public Class FormCollections
    'Varialbes
    Dim lastPOS As Point = My.Settings.CollectionsLastPos

    'Start
    Private Sub FormCollections_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        Positioner(Me, My.Settings.CollectionsPos, My.Settings.CollectionsLastPos)

    End Sub


#Region "Glows"

    Private Sub LabelCollection0_MouseEnter(sender As Object, e As EventArgs) Handles LabelCollection0.MouseEnter

        ButtonGlow(LabelCollection0)

    End Sub

    Private Sub LabelCollection1_MouseEnter(sender As Object, e As EventArgs) Handles LabelCollection1.MouseEnter

        ButtonGlow(LabelCollection1)

    End Sub

    Private Sub LabelCollection2_MouseEnter(sender As Object, e As EventArgs) Handles LabelCollection2.MouseEnter

        ButtonGlow(LabelCollection2)

    End Sub

    Private Sub LabelCollection3_MouseEnter(sender As Object, e As EventArgs) Handles LabelCollection3.MouseEnter

        ButtonGlow(LabelCollection3)

    End Sub

    Private Sub LabelCollection0_MouseLeave(sender As Object, e As EventArgs) Handles LabelCollection0.MouseLeave

        ButtonUnGlow(LabelCollection0)

    End Sub

    Private Sub LabelCollection1_MouseLeave(sender As Object, e As EventArgs) Handles LabelCollection1.MouseLeave

        ButtonUnGlow(LabelCollection1)

    End Sub

    Private Sub LabelCollection2_MouseLeave(sender As Object, e As EventArgs) Handles LabelCollection2.MouseLeave

        ButtonUnGlow(LabelCollection2)

    End Sub

    Private Sub LabelCollection3_MouseLeave(sender As Object, e As EventArgs) Handles LabelCollection3.MouseLeave

        ButtonUnGlow(LabelCollection3)

    End Sub


#End Region


#Region "Link"


    Private Sub LabelCollection0_Click(sender As Object, e As EventArgs) Handles LabelCollection0.Click

        OpenUserDocs()

    End Sub

    Private Sub LabelCollection1_Click(sender As Object, e As EventArgs) Handles LabelCollection1.Click

        Summon(FormGame)

    End Sub

    Private Sub LabelCollection2_Click(sender As Object, e As EventArgs) Handles LabelCollection2.Click

        Summon(FormSoftware)

    End Sub

    Private Sub LabelCollection3_Click(sender As Object, e As EventArgs) Handles LabelCollection3.Click

        Process.Start("explorer.exe", Environment.GetEnvironmentVariable("argus") + "\User")

    End Sub



#End Region

#Region "Mover"
    'Main Form
    Private Sub FormCollections_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        FormMoverGrab(Me)

    End Sub

    Private Sub FormCollections_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        FormMover(Me)

    End Sub

    Private Sub FormCollections_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        FormMoverRelease()

    End Sub
#End Region




    Private Sub FormCollections_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        My.Settings.CollectionsLastPos = Me.Location
        ASave()

    End Sub

    Private Sub LabelCollectionCalendar_Click(sender As Object, e As EventArgs) Handles LabelCollectionCalendar.Click

        Ding()


    End Sub


End Class
