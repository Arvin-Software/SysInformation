Imports System.Management

Public Class peripherals
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Peripherals_Keyboard()
        Peripherals_Mouse()
        Peripherals_PrinterRet()
    End Sub
    Public Sub Peripherals_PrinterRet()
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Printer")
            For Each queryobj As ManagementObject In searcher.Get()
                If queryobj("default") = "true" And queryobj("caption") <> "" Then
                    Peripherals_Printer()
                ElseIf queryobj("caption") = "" Then
                    TabControl1.TabPages.Remove(TabPage2)
                End If
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Public Sub Peripherals_Printer()
        Try
            Dim cnt As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Printer")
            For Each queryobj As ManagementObject In searcher.Get()
                If queryobj("default") = "true" Then
                    trePrinter.Nodes.Add("Printer : " & queryobj("caption"))
                    For Each value In queryobj("CapabilityDescriptions")
                        trePrinter.Nodes(cnt).Nodes.Add("Capability : " & value)
                    Next
                    trePrinter.Nodes(cnt).Nodes.Add("Horizontal Resolution : " & queryobj("horizontalresolution"))
                    trePrinter.Nodes(cnt).Nodes.Add("Vertical resolution : " & queryobj("verticalresolution"))
                    trePrinter.Nodes(cnt).Nodes.Add("Print Processor : " & queryobj("printprocessor"))
                    trePrinter.Nodes(cnt).Nodes.Add("Printer Port : " & queryobj("portname"))
                    trePrinter.ExpandAll()
                    cnt += 1
                End If
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Public Sub Peripherals_Mouse()
        Try
            Dim ount As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                   "root\CIMV2", _
                   "SELECT * FROM Win32_PointingDevice")
            For Each queryObj As ManagementObject In searcher.Get()
                treMou.Nodes.Add(("Mouse : " & queryObj("Caption")))
                treMou.Nodes(ount).Nodes.Add("Manufacturer : " & queryObj("Manufacturer"))
                treMou.Nodes(ount).Nodes.Add("PNP Device ID : " & queryObj("pnpdeviceid"))
                Dim dad = queryObj("DeviceInterface")
                Dim ret
                Select Case dad
                    Case 1
                        ret = "Other"
                    Case 2
                        ret = "Unknown"
                    Case 3
                        ret = "Serial"
                    Case 4
                        ret = "PS/2"
                    Case 5
                        ret = "Infrared"
                    Case 6
                        ret = "HP-HIL"
                    Case 7
                        ret = "Bus Mouse"
                    Case 8
                        ret = "ADB (Apple Desktop Bus)"
                    Case 160
                        ret = "Bus Mouse DB-9"
                    Case 161
                        ret = "Bus Mouse Micro-DIN"
                    Case 162
                        ret = "USB"
                    Case Else
                        ret = "No Data"
                End Select
                treMou.Nodes(ount).Nodes.Add("Connected to : " & ret)
                treMou.ExpandAll()
                treMou.Select()
                ount += 1
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Public Sub Peripherals_Keyboard()
        Try
            Dim ount As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                   "root\CIMV2", _
                   "SELECT * FROM Win32_Keyboard")
            For Each queryObj As ManagementObject In searcher.Get()
                treKeybrd.Nodes.Add(("Keyboard : " & queryObj("Caption")))
                treKeybrd.Nodes(ount).Nodes.Add("Description : " & queryObj("Description"))
                treKeybrd.Nodes(ount).Nodes.Add("PNP Device ID : " & queryObj("pnpdeviceid"))
                treKeybrd.ExpandAll()
                ount += 1
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
End Class
