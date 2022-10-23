Module HealthAsses

    Dim HostType As String ' Spinning rust or flash - to be flesh out with different levels of disk speed and types of flash, and host adapter


    Private Declare Function AvailableVolume Lib "kernel32" Alias "GetDiskFreeSpaceExA" (ByVal lpDirectoryName As String, ByRef lpTotalNumberOfBytes As Long, ByRef lpTotalNumberOfFreeBytes As Long) As Integer


    Sub DiskFullness()

        Dim DiskFull As Integer ' from 0 to 100

        Dim FreeBytes As Long 'the total number of free bytes on a disk
        Dim TotalBytes As Long 'the total available bytes to the user whose process this is 

        Dim Volume As String = "C:" ' Volume of choice - must be a drive letter with colon


        Dim FetchResult As Integer

        'the function returns non zero if successful and 0 if failed
        FetchResult = AvailableVolume(Volume, TotalBytes, FreeBytes)

        If FetchResult <> 0 Then

            Dim bytes As String = Format(FreeBytes, "###,###,##") & " bytes )"


            'convert to Megabytes
            Dim megabytes As String
            Dim MBytes As Double
            MBytes = (FreeBytes \ 1024) \ 1024
            megabytes = Format(MBytes, "###,###,##") & " MB free"

            MessageBox.Show(megabytes & " (" & bytes)

        Else

            MessageBox.Show("Drive not available or folder not accessible")

        End If


    End Sub

End Module
