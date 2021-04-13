Imports System.Management
Imports System.Runtime.InteropServices

Public Class MemAdv
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub MemAdv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RunAdvacedRAM()
    End Sub
    Public Sub RunAdvacedRAM()
        Try
            TreeView1.Nodes.Clear()
            Dim rmcount As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_PhysicalMemory")
            For Each queryObj As ManagementObject In searcher.Get
                TreeView1.Nodes.Add(queryObj("Caption"))
                TreeView1.Nodes(rmcount).Nodes.Add("Capacity : " & Math.Round(queryObj("Capacity") / 1024 / 1024 / 1024, 0) & " GB")
                TreeView1.Nodes(rmcount).Nodes.Add("Bank Label : " & queryObj("banklabel"))
                TreeView1.Nodes(rmcount).Nodes.Add("Datawidth : " & queryObj("datawidth"))
                'TreeView1.Nodes(rmcount).Nodes.Add()
                Dim formfactret = queryObj("FormFactor")
                Dim formfactvalret
                Select Case formfactret
                    Case "0"
                        formfactvalret = "Unknown"
                    Case "1"
                        formfactvalret = "Other"
                    Case "2"
                        formfactvalret = "SIP"
                    Case "3"
                        formfactvalret = "DIP"
                    Case "4"
                        formfactvalret = "ZIP"
                    Case "5"
                        formfactvalret = "SOJ"
                    Case "6"
                        formfactvalret = "Proprietary"
                    Case "7"
                        formfactvalret = "SIMM"
                    Case "8"
                        formfactvalret = "DIMM"
                    Case "9"
                        formfactvalret = "TSOP"
                    Case "10"
                        formfactvalret = "PGA"
                    Case "11"
                        formfactvalret = "RIMM"
                    Case "12"
                        formfactvalret = "SODIMM"
                    Case "13"
                        formfactvalret = "SRIMM"
                    Case "14"
                        formfactvalret = "SMD"
                    Case "15"
                        formfactvalret = "SSMP"
                    Case "16"
                        formfactvalret = "QFP"
                    Case "17"
                        formfactvalret = "TQFP"
                    Case "18"
                        formfactvalret = "SOIC"
                    Case "19"
                        formfactvalret = "LLC"
                    Case "20"
                        formfactvalret = "PLCC"
                    Case "21"
                        formfactvalret = "BGA"
                    Case "22"
                        formfactvalret = "FPBGA"
                    Case "23"
                        formfactvalret = "LGA"
                    Case Else
                        formfactvalret = "No Information"
                End Select
                TreeView1.Nodes(rmcount).Nodes.Add("Form Factor : " & formfactvalret)
                Dim memtype = queryObj("memorytype")
                Dim memret
                Select Case memtype
                    Case "1"
                        memret = "Other"
                    Case "2"
                        memret = "DRAM"
                    Case "3"
                        memret = "Synchronous DRAM"
                    Case "4"
                        memret = "Cache DRAM"
                    Case "5"
                        memret = "EDO"
                    Case "6"
                        memret = "EDRAM"
                    Case "7"
                        memret = "VRAM"
                    Case "8"
                        memret = "SRAM"
                    Case "9"
                        memret = "RAM"
                    Case "10"
                        memret = "ROM"
                    Case "11"
                        memret = "Flash"
                    Case "12"
                        memret = "EEPROM"
                    Case "13"
                        memret = "FEPROM"
                    Case "14"
                        memret = "EPROM"
                    Case "15"
                        memret = "CDRAM"
                    Case "16"
                        memret = "3DRAM"
                    Case "17"
                        memret = "SDRAM"
                    Case "18"
                        memret = "SGRAM"
                    Case "19"
                        memret = "RDRAM"
                    Case "20"
                        memret = "DDR"
                    Case "21"
                        memret = "DDR2"
                    Case Else
                        If memtype = 22 Or memtype = 0 Then
                            memret = "DDR3"
                        Else
                            memret = "No Information"
                        End If
                End Select
                TreeView1.Nodes(rmcount).Nodes.Add("Memory Type : " & memret)
                TreeView1.Nodes(rmcount).Nodes.Add("Interleave Data Depth : " & queryObj("InterleaveDataDepth"))
                Dim interpos = queryObj("interleaveposition")
                Dim interporet
                Select Case interpos
                    Case "0"
                        interporet = "Not Interleaved"
                    Case "1"
                        interporet = "First Position"
                    Case "2"
                        interporet = "Second Position"
                    Case Else
                        interporet = "Not Found"
                End Select
                TreeView1.Nodes(rmcount).Nodes.Add("Interleave Position : " & interporet)
                TreeView1.Nodes(rmcount).Nodes.Add("Part Number : " & queryObj("PartNumber"))
                TreeView1.Nodes(rmcount).Nodes.Add("Serial Number : " & queryObj("SerialNumber"))
                TreeView1.Nodes(rmcount).Nodes.Add("Speed : " & queryObj("Speed") & " Mhz")
                TreeView1.Nodes(rmcount).Nodes.Add("Total Width : " & queryObj("TotalWidth"))
                Dim typdetail = queryObj("typedetail")
                Dim typderet
                Select Case typdetail
                    Case "1"
                        typderet = "Reserved"
                    Case "2"
                        typderet = "Other"
                    Case "4"
                        typderet = "Unknown"
                    Case "8"
                        typderet = "First-Paged"
                    Case "16"
                        typderet = "Static Column"
                    Case "32"
                        typderet = "Pseudo-Static"
                    Case "64"
                        typderet = "RAMBUS"
                    Case "128"
                        typderet = "Synchronous"
                    Case "256"
                        typderet = "CMOS"
                    Case "512"
                        typderet = "EDO"
                    Case "1024"
                        typderet = "Window DRAM"
                    Case "2048"
                        typderet = "Cache DRAM"
                    Case "4096"
                        typderet = "Nonvolatile"
                    Case Else
                        typderet = "No Information"
                End Select
                TreeView1.Nodes(rmcount).Nodes.Add("Type Detail : " & typderet)
                TreeView1.ExpandAll()
                rmcount += 1
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub

    Private Sub MemAdv_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class