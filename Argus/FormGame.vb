Imports System.Xml
Imports System.IO

Public Class FormGame

    'Variable Start

    'Directories
    Dim ArgusDir As String = "A:\Argus"
    Dim IconDir As String = "icons\"
    Dim GameDir As String = "A:\Gaming\"


    Dim GameName As String
    Dim GamePlatform As String
    Dim GameRelease As String

    'XML Dims
    Dim m_xmld As XmlDocument
    Dim m_nodelist As XmlNodeList
    Dim m_node As XmlNode


    'Form Load
    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        m_xmld = New XmlDocument

        'Chose document to load
        m_xmld.Load("A:\Gaming\Windows\Argus Library\library.xml")

        'Fetch nodes
        m_nodelist = m_xmld.GetElementsByTagName("Game")



        For Each m_node In m_nodelist

            lstGames.Items.Add(m_node.Item("Name").InnerText)

        Next



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click





    End Sub

    Private Sub lstGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGames.SelectedIndexChanged

        Dim Initilized As Boolean
        Dim Dir As String
        Dim GameXML As String
        m_xmld = New XmlDocument


        lblGameTitle.Text = lstGames.SelectedItem



        'Chose document to load
        m_xmld.Load("A:\Gaming\Windows\Argus Library\library.xml")

        'Fetch nodes
        For Each m_node In m_nodelist

            If m_node.Item("Name").InnerText = lstGames.SelectedItem Then
                Dir = m_node.Item("Dir").InnerText
                LblGameDir.Text = Dir
                GameXML = GameDir + "Windows\Argus Library\" + Dir + "\game.xml"
            ElseIf m_node.Item("Name").InnerText <> lstGames.SelectedItem Then
                MsgBox(m_node.Item("Name").InnerText)
            End If

        Next



        If My.Computer.FileSystem.FileExists(GameXML) Then
            GoTo 2
        ElseIf My.Computer.FileSystem.FileExists(GameXML) = False Then
            MsgBox("failed to find game decription file")
            LblGameDir.Text = GameXML
            GoTo 0
        End If
2:
        m_xmld.Load(GameXML)

        m_nodelist = m_xmld.GetElementsByTagName("Game")

        For Each m_node In m_nodelist

            LblGenre.Text = m_node.Item("Genre").InnerText


        Next

0:

    End Sub


End Class