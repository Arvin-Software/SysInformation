Imports System.Management

Public Class GraphicCard
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GraphicCard_Monitor()
        GraphicCardd()
    End Sub
    Public Sub GraphicCard_Monitor()
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_DesktopMonitor")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Availability") = 3 Then
                    CmboMntr.Items.Add(queryObj("Caption"))
                    CmboMntr.Text = queryObj("Caption")
                Else
                    CmboMntr.Items.Add(queryObj("Caption"))
                    'CmboMntr.Text = queryObj("Caption")
                End If
                'CmboMntr.Items.Add("text")
                'CmboMntr.Text = queryObj("Caption")
            Next
        Catch err As ManagementException
            'MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Motherboard.ereror = err.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Public Sub GraphicCardd()
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Availability") = 3 Then
                    CmboGraphicCrd.Items.Add(queryObj("Caption"))
                    CmboGraphicCrd.Text = queryObj("Caption")
                Else
                    CmboGraphicCrd.Items.Add(queryObj("Caption"))
                    'CmboGraphicCrd.Text = queryObj("Caption")
                End If
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Private Sub CmboMntr_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CmboMntr.SelectedIndexChanged
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_DesktopMonitor")

            For Each queryObj As ManagementObject In searcher.Get()
                'ComboBox1.Items.Add(queryObj("Caption"))
                If CmboMntr.GetItemText(CmboMntr.SelectedItem) = queryObj("Caption") Then
                    Dim nes = queryObj("availability")
                    Select Case nes
                        Case 1
                            lblIsDef.Text = "Other"
                        Case 2
                            lblIsDef.Text = "Unknown"
                        Case 3
                            lblIsDef.Text = "Running"
                        Case 4
                            lblIsDef.Text = "Warning"
                        Case 5
                            lblIsDef.Text = "In Test"
                        Case 6
                            lblIsDef.Text = "Not Applicable"
                        Case 7
                            lblIsDef.Text = "Power Off"
                        Case 8
                            lblIsDef.Text = "Offline"
                        Case 9
                            lblIsDef.Text = "Off Duty"
                        Case 10
                            lblIsDef.Text = "Degraded"
                        Case 11
                            lblIsDef.Text = "Not Installed"
                        Case 12
                            lblIsDef.Text = "Install Error"
                        Case 13
                            lblIsDef.Text = "Power Save - Unknown"
                        Case 14
                            lblIsDef.Text = "Power Save - Low"
                        Case 15
                            lblIsDef.Text = "Power Save - Standby"
                        Case 16
                            lblIsDef.Text = "Power Cycle"
                        Case 17
                            lblIsDef.Text = "Power Save - Warning"
                        Case Else
                            lblIsDef.Text = "Running"
                    End Select
                    lblMonitorManufacturer.Text = queryObj("monitormanufacturer")
                    lblVideoHorizontalRes.Text = queryObj("screenwidth")
                    lblVideoVerticalRes.Text = queryObj("screenheight")
                    lblVideoPixelsX.Text = queryObj("pixelsperxlogicalinch")
                    lblVideoPixelsY.Text = queryObj("pixelsperylogicalinch")
                End If
            Next
        Catch err As ManagementException
            'MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Motherboard.ereror = err.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub

    Private Sub CmboGraphicCrd_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CmboGraphicCrd.SelectedIndexChanged
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", " SELECT * FROM Win32_VideoController")
            For Each queryObj As ManagementObject In searcher.Get()
                If CmboGraphicCrd.GetItemText(CmboGraphicCrd.SelectedItem) = queryObj("Caption") Then
                    lblVideoCard.Text = queryObj("AdapterDACType")
                    lblVideoManufacturer.Text = queryObj("AdapterCompatibility")
                    lblVideoMem.Text = Math.Round(queryObj("AdapterRAM") / 1024 / 1024, 0) & " Mb"
                    lblVideoDriverVersion.Text = queryObj("driverversion")
                    lblVideoColourDepth.Text = queryObj("CurrentBitsPerPixel") & " Bits"
                    lblVideoRefreshRate.Text = queryObj("currentrefreshrate") & " Hz"
                    'lblVideoScanMode.Text = queryObj("CurrentScanMode")
                    Dim dat = queryObj("CurrentScanMode")
                    If dat = "1" Then
                        lblVideoScanMode.Text = "Other"
                    ElseIf dat = "2" Then
                        lblVideoScanMode.Text = "Unknown"
                    ElseIf dat = "3" Then
                        lblVideoScanMode.Text = "Interlaced"
                    ElseIf dat = "4" Then
                        lblVideoScanMode.Text = "Non Interlaced"
                    Else
                        lblVideoScanMode.Text = "Not Found"
                    End If
                    Dim nes = queryObj("availability")
                    Select Case nes
                        Case 1
                            lblIsDefGr.Text = "Other"
                        Case 2
                            lblIsDefGr.Text = "Unknown"
                        Case 3
                            lblIsDefGr.Text = "Running"
                        Case 4
                            lblIsDefGr.Text = "Warning"
                        Case 5
                            lblIsDefGr.Text = "In Test"
                        Case 6
                            lblIsDefGr.Text = "Not Applicable"
                        Case 7
                            lblIsDefGr.Text = "Power Off"
                        Case 8
                            lblIsDefGr.Text = "Offline"
                        Case 9
                            lblIsDefGr.Text = "Off Duty"
                        Case 10
                            lblIsDefGr.Text = "Degraded"
                        Case 11
                            lblIsDefGr.Text = "Not Installed"
                        Case 12
                            lblIsDefGr.Text = "Install Error"
                        Case 13
                            lblIsDefGr.Text = "Power Save - Unknown"
                        Case 14
                            lblIsDefGr.Text = "Power Save - Low"
                        Case 15
                            lblIsDefGr.Text = "Power Save - Standby"
                        Case 16
                            lblIsDefGr.Text = "Power Cycle"
                        Case 17
                            lblIsDefGr.Text = "Power Save - Warning"
                        Case Else
                            lblIsDef.Text = "Running"
                    End Select
                End If
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
            'MsgBox(ex.ToString)
        End Try
    End Sub
End Class
