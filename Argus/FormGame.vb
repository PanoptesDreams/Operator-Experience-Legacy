Imports System.Xml
Imports System.IO

Public Class FormGame

    'Variable Start

    'Directories
    Dim ArgusDir As String = Environment.GetEnvironmentVariable("argus") + "\Argus"
    Dim IconDir As String = "icons\"
    Dim GameDir As String = Environment.GetEnvironmentVariable("argus") + "\Media\Gaming"


    Dim GameName As String
    Dim GamePlatform As String
    Dim GameRelease As String

    'XML Dims
    Dim m_xmld As XmlDocument
    Dim m_nodelist As XmlNodeList
    Dim m_node As XmlNode


    'Form Load
    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        LoadGame()


    End Sub


    Public Sub LoadGame()

        m_xmld = New XmlDocument

        'Chose document to load
        m_xmld.Load(GameDir + "\Windows\Argus Library\library.xml")

        'Fetch nodes
        m_nodelist = m_xmld.GetElementsByTagName("Game")


        For Each m_node In m_nodelist

            lstGames.Items.Add(m_node.Item("Name").InnerText)

        Next


    End Sub


    Private Sub lstGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGames.SelectedIndexChanged

        lblGameTitle.Text = lstGames.SelectedItem

    End Sub


End Class