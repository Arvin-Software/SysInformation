Imports System.Management
Imports Microsoft.Win32
Imports System.Runtime.InteropServices

Public Class ReportCreation
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Public Shared Function OperatingSystemInformation()
        Dim OperInfo As String
        OperInfo = vbNewLine & "Name : " & My.Computer.Info.OSFullName & vbNewLine & "Reg User : " & Operating_System.reguser & vbNewLine & "Reg Organization : " & Operating_System.regorg & vbNewLine & "Version : " &
            Operating_System.operatingversion & vbNewLine & "Os Architecture : " & Operating_System.operatingbit & " -Bit" & vbNewLine & "Serial Number : " & Operating_System.serialnum &
            vbNewLine & "Windows Directory : " & Operating_System.windir & vbNewLine & "Install Date : " & Operating_System.installdate & vbNewLine & "Service Pack : " & Operating_System.ServicePack & vbNewLine &
            "Uptime : " & Operating_System.uptime & vbNewLine
        Return OperInfo
    End Function
    Public Shared Function pherids(ByVal texc As RichTextBox)
        Dim searcher As New ManagementObjectSearcher( _
               "root\CIMV2", _
               "SELECT * FROM Win32_PointingDevice")
        For Each queryObj As ManagementObject In searcher.Get()
            texc.Text = texc.Text & vbNewLine & "Mouse : " & queryObj("Caption") & vbNewLine
            texc.Text = texc.Text & "Manufacturer : " & queryObj("Manufacturer") & vbNewLine
            texc.Text = texc.Text & "PNP Device ID : " & queryObj("pnpdeviceid") & vbNewLine
        Next
        Return Nothing
    End Function
    Public Shared Function pherikey(ByVal texc As RichTextBox)
        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Keyboard")
        For Each queryObj As ManagementObject In searcher.Get()
            texc.Text = texc.Text & vbNewLine & "Keyboard : " & queryObj("caption") & vbNewLine
            texc.Text = texc.Text & "PNP Device ID : " & queryObj("pnpdeviceid") & vbNewLine
        Next
        Return Nothing
    End Function
    Public Shared Function pheriPrint(ByVal texc As RichTextBox)
        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Printer")
        For Each queryObj As ManagementObject In searcher.Get()
            If queryObj("default") = "true" Then
                texc.Text = texc.Text & vbNewLine & "Printer : " & queryObj("caption") & vbNewLine
                texc.Text = texc.Text & "Horizontal Resolution : " & queryObj("horizontalresolution") & vbNewLine
                texc.Text = texc.Text & "Vertical Resolution : " & queryObj("VerticalResolution") & vbNewLine
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function EnumPro(ByVal texoc As RichTextBox)
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")

            For Each queryObj As ManagementObject In searcher.Get()
                texoc.Text = texoc.Text & queryObj("Caption") & "     " & queryObj("ProcessId") &
                        "     " & queryObj("PageFileUsage") & vbNewLine
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
        Return Nothing
    End Function
    Public Shared Function GetInstalledPrograms(ByVal slst As RichTextBox)
        Dim count As Integer = 0
        Using uninstalled As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
            For Each sbKeyName As String In uninstalled.GetSubKeyNames()
                Using key As RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                    Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                    Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                    Dim dmanu As String = Convert.ToString(key.GetValue("Publisher"))
                    If Not String.IsNullOrEmpty(dname) Then
                        slst.Text = slst.Text & (dname) & "  " & dmanu & vbNewLine
                        count += 1
                    End If
                End Using
            Next
        End Using
        Return Nothing
    End Function
    Public Shared Function GetInstalledProgramson64bit(ByVal slst As RichTextBox)

        Dim count As Integer = 0
        Using uninstalled64 As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall", False)
            For Each sbKeyName As String In uninstalled64.GetSubKeyNames()
                Using key As RegistryKey = uninstalled64.OpenSubKey(sbKeyName)
                    Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                    Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                    Dim dmanu As String = Convert.ToString(key.GetValue("Publisher"))
                    If Not String.IsNullOrEmpty(dname) Then
                        slst.Text = slst.Text & (dname) & "  " & dmanu & vbNewLine
                        count += 1
                    End If
                End Using
            Next
        End Using
        Return Nothing
    End Function
    Public Shared Function GetGraphicCard(ByVal slist As RichTextBox)
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
            For Each queryObj As ManagementObject In searcher.Get()
                slist.Text = slist.Text & vbNewLine & "Printer : " & queryObj("caption") & vbNewLine
                slist.Text = slist.Text & "DAC Type : " & queryObj("AdapterDACType") & vbNewLine
                slist.Text = slist.Text & "Manufacturer : " & queryObj("AdapterCompatibility") & vbNewLine
                slist.Text = slist.Text & "Adapter RAM : " & Math.Round(queryObj("AdapterRAM") / 1024 / 1024, 0) & " Mb" & vbNewLine
                slist.Text = slist.Text & "Driver Version : " & queryObj("driverversion") & vbNewLine
                slist.Text = slist.Text & "Bits Per Pixel : " & queryObj("CurrentBitsPerPixel") & " Bits" & vbNewLine
                slist.Text = slist.Text & "Refresh Rate : " & queryObj("currentrefreshrate") & " Hz" & vbNewLine
                'lblVideoScanMode.Text = queryObj("CurrentScanMode")
                Dim dat = queryObj("CurrentScanMode")
                If dat = "1" Then
                    slist.Text = slist.Text & "Scan Mode : Other" & vbNewLine
                ElseIf dat = "2" Then
                    slist.Text = slist.Text & "Scan Mode : Unknown" & vbNewLine
                ElseIf dat = "3" Then
                    slist.Text = slist.Text & "Scan Mode : Interlaced" & vbNewLine
                ElseIf dat = "4" Then
                    slist.Text = slist.Text & "Scan Mode : Non Interlaced" & vbNewLine
                Else
                    slist.Text = slist.Text & "Scan Mode : Not Found" & vbNewLine
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function
    Public Shared Function enumprograms(ByVal repsoft As RichTextBox)

        If os.getOsBitness = "32" Then
            GetInstalledPrograms(repsoft)

        ElseIf os.getOsBitness = "64" Then
            GetInstalledProgramson64bit(repsoft)

        Else
            GetInstalledPrograms(repsoft)
        End If
        Return Nothing
    End Function
    Public Shared Function RAM()
        Dim srm As String
        Dim sAvlrm As String
        Dim sperus As String
        Dim sused As String
        Dim retrm As String
        srm = My.Computer.Info.TotalPhysicalMemory()
        sAvlrm = My.Computer.Info.AvailablePhysicalMemory()
        srm = Math.Round(srm / 1024 / 1024 / 1024, 2)
        sAvlrm = Math.Round(sAvlrm / 1024 / 1024 / 1024, 2)
        sused = srm - sAvlrm
        sperus = CInt(Math.Round(CDbl(sused) / CDbl(srm) * 100, 0))
        retrm = "Ram Capacity : " & srm & " GB" & vbNewLine & "Ram Available : " & sAvlrm & " GB" & vbNewLine & "RAM Used : " & sused & " GB" & vbNewLine
        Return retrm
    End Function
    Public Shared Function stoargedeviceen()
        Dim stor
        stor = "Harddisk Name : " & StorageDevices.storagenm & vbNewLine & "Harddisk Size : " & StorageDevices.storagesp & vbNewLine &
            "harddisk temp : " & StorageDevices.storagetemp & vbNewLine
        Return stor
    End Function
    Public Shared Function processorret()
        Dim pro
        pro = "Processor Name : " & Processor.proname & vbNewLine & "Processor Manufacturer : " & Processor.promanu &
            vbNewLine & "No.Of.Cores : " & Processor.pronoofcrs & vbNewLine & "Threads : " & Processor.pronoofthr &
            vbNewLine & "L1 Cache : " & Processor.l1cache & vbNewLine & "L2 Cache : " & Processor.l2cache &
            vbNewLine & "L3 Cache : " & Processor.l3cache & vbNewLine & "Identifier : " & Processor.proiden & vbNewLine
        Return pro
    End Function
    Public Shared Function Motherbrdinfo()
        Dim moth
        moth = "Motherboard Model : " & Motherboard.mothermod & vbNewLine & "Manufacturer : " & Motherboard.mothermanu & vbNewLine & "Version : " &
            Motherboard.motherrevision & vbNewLine & "Serial : " & Motherboard.motherserials & vbNewLine & "Primary Bus Type : " & Motherboard.primarybustyp &
            vbNewLine & "Secondary Bus Type : " & Motherboard.secondarybustyp & vbNewLine & "Bios Manufacturer : " & Motherboard.biosmanu & vbNewLine &
            "Bios Version : " & Motherboard.biosversion & vbNewLine & "SMBIOS Version : " & Motherboard.biossmbsvers & vbNewLine & "Release Date : " & Motherboard.biosreleasedt & vbNewLine
        Return moth
    End Function
    Public Shared Function Partitions(ByVal rtebx As RichTextBox)
        Dim count As Integer = 0
        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_LogicalDisk")
        For Each queryObj As ManagementObject In searcher.Get
            rtebx.Text = rtebx.Text & (queryObj("Caption")) & "  " & (Math.Round(queryObj("Size") / 1024 / 1024 / 1024, 2) & " GB") & "  " & (Math.Round(queryObj("FreeSpace") / 1024 / 1024 / 1024, 2) & " GB") & "  " & Math.Round(queryObj("Size") / 1024 / 1024 / 1024, 2) & " GB" & vbNewLine
        Next
        Return Nothing
    End Function

    Private Sub ReportCreation_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub ReportCreation_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            textox.Visible = False
            textox.Text = ""
            textox.Text = "Report Created on " & My.Computer.Clock.LocalTime & " of " & My.Computer.Name.ToString & vbNewLine & vbNewLine
            'If Settings.chedos = "1" Then
            textox.Text = textox.Text & "----OPERATING SYSTEM----"
            textox.Text = textox.Text & OperatingSystemInformation()
            'End If
            'If Settings.chedgra = "1" Then
            textox.Text = textox.Text & vbNewLine & "----GRAPHIC CARD INFORMATION----"
            GetGraphicCard(textox)
            'End If
            'If Settings.chedperi = "1" Then
            textox.Text = textox.Text & vbNewLine & "----PERIPHERALS INFORMATION----"
            pherids(textox)
            pherikey(textox)
            pheriPrint(textox)
            'End If
            'If Settings.chedrm = "1" Then
            textox.Text = textox.Text & vbNewLine & vbNewLine & "----RAM INFORMATION----"
            textox.Text = textox.Text & vbNewLine & RAM()
            'End If
            'If Settings.chedmother = "1" Then
            textox.Text = textox.Text & vbNewLine & "MOTHERBOARD INFORMATION"
            textox.Text = textox.Text & vbNewLine & Motherbrdinfo()
            'End If
            'If Settings.chedproce = "1" Then
            textox.Text = textox.Text & vbNewLine & "----PROCESSOR INFORMATION----"
            textox.Text = textox.Text & vbNewLine & processorret()
            'End If
            'If Settings.chedpart = "1" Then
            textox.Text = textox.Text & vbNewLine & "----PARTITION INFORMATION----" & vbNewLine
            Partitions(textox)
            'End If
            'If Settings.chedstor = "1" Then
            textox.Text = textox.Text & vbNewLine & "----STORAGE DEVICES----"
            textox.Text = textox.Text & vbNewLine & stoargedeviceen()
            'End If
            'If Settings.chedpro = "1" Then
            textox.Text = textox.Text & vbNewLine & "----PROCESSES INFORMATION----" & vbNewLine
            EnumPro(textox)
            'End If
            'If Settings.chedsoft = "1" Then
            textox.Text = textox.Text & vbNewLine & "----INSTALLED SOFTWARES----" & vbNewLine
            enumprograms(textox)
            'End If
            textox.Text = textox.Text & vbNewLine & vbNewLine & "Copyright (C) 2015 Arvin Soft. All Rights Reserved."
            lblwait.Visible = False
            textox.Visible = True
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub SaveReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveReportToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save Report"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf| Report File (*.rept)|*.rept | ReportEx File(*.reptx)|*.reptx"
            dlg.FileName = "Report of " & My.Computer.Name.ToString
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                textox.SaveFile(dlg.FileName, RichTextBoxStreamType.PlainText)
            End If
        Catch ex As Exception : End Try
    End Sub
End Class