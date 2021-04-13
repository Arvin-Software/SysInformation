Imports System.Management
Imports System.Runtime.InteropServices

Public Class HrdDiskAdv
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Public Sub lod()
        Dim count As Integer = 0
        Try
            treHrdDskAdvan.Nodes.Clear()
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
            For Each queryObj As ManagementObject In searcher.Get

                'If queryObj("interfacetype") = "IDE" Then

                treHrdDskAdvan.Nodes.Add("Harddisk Name : " & queryObj("Caption"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Size : " & Math.Round(queryObj("size") / 1024 / 1024 / 1024, 0) & " GBytes")
                treHrdDskAdvan.Nodes(count).Nodes.Add("Bytes Per Sector : " & queryObj("bytespersector"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Interface type : " & queryObj("interfacetype"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Serial Number : " & queryObj("serialnumber"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Total Cylinders: " & queryObj("totalcylinders"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Total Heads : " & queryObj("totalheads"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Total Sectors : " & queryObj("totalsectors"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Total Tracks : " & queryObj("totaltracks"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Tracks Per Cylinder : " & queryObj("trackspercylinder"))
                treHrdDskAdvan.Nodes(count).Nodes.Add("Firmware Revision : " & queryObj("firmwarerevision"))
                treHrdDskAdvan.ExpandAll()
                'End If
                count += 1

            Next
        Catch ex As Exception
        End Try
        Dim dount As Integer = 0
        Try
            treParti.Nodes.Clear()
            Dim sear As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_LogicalDisk")
            For Each query As ManagementObject In sear.Get
                If query("Description") = "Local Fixed Disk" Then
                    treParti.Nodes.Add("Partition " & dount & " : " & query("caption"))
                    treParti.Nodes(dount).Nodes.Add("Description : " & query("Description"))
                    treParti.Nodes(dount).Nodes.Add("File System : " & query("FileSystem"))
                    treParti.Nodes(dount).Nodes.Add("Size : " & Math.Round(query("size") / 1024 / 1024 / 1024, 0) & " GB")
                    treParti.Nodes(dount).Nodes.Add("Volume Serial Number : " & query("VolumeSerialNumber"))
                    dount += 1
                End If
            Next
            treParti.ExpandAll()
        Catch ex As Exception
        End Try
        Dim ount As Integer = 0
        Try
            treCDDVD.Nodes.Clear()
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_CDROMDrive")
            For Each queryObj As ManagementObject In searcher.Get()

                treCDDVD.Nodes.Add(queryObj("Caption"))
                treCDDVD.Nodes(ount).Nodes.Add("Drive Type : " & queryObj("MediaType"))
                Dim ret
                Select Case queryObj("Availability")
                    Case 1
                        ret = "Other"
                    Case 2
                        ret = "Unknown"
                    Case 3
                        ret = "Running or Full Power"
                    Case 4
                        ret = "Warning"
                    Case 5
                        ret = "In test"
                    Case 6
                        ret = "Not Applicable"
                    Case 7
                        ret = "Power Off"
                    Case 8
                        ret = "Off Line"
                    Case 9
                        ret = "Off Duty"
                    Case 10
                        ret = "Degraded"
                    Case 11
                        ret = "Not Installed"
                    Case 12
                        ret = "Install Error"
                    Case 13
                        ret = "Power Save-Unknown"
                    Case 14
                        ret = "Power Save-Low Power Mode"
                    Case 15
                        ret = "Power Save-Standby"
                    Case 16
                        ret = "Power Cycle"
                    Case 17
                        ret = "Power Save-Warning"
                    Case Else
                        ret = "Not Found"
                End Select
                treCDDVD.Nodes(ount).Nodes.Add("Availability : " & ret)
                treCDDVD.Nodes(ount).Nodes.Add("Drive : " & queryObj("drive"))
                treCDDVD.Nodes(ount).Nodes.Add("Media Loaded : " & queryObj("medialoaded"))
                treCDDVD.Nodes(ount).Nodes.Add("SCSI Bus : " & queryObj("SCSIBus"))
                treCDDVD.Nodes(ount).Nodes.Add("SCSI Logical Unit : " & queryObj("SCSILogicalUnit"))
                treCDDVD.Nodes(ount).Nodes.Add("SCSI Port : " & queryObj("SCSIPort"))
                treCDDVD.Nodes(ount).Nodes.Add("SCSI Target Id : " & queryObj("SCSITargetID"))
                treCDDVD.Nodes(ount).Nodes.Add("Status : " & queryObj("Status"))
                treCDDVD.ExpandAll()
                ount += 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HrdDiskAdv_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub HrdDiskAdv_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        lod()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class