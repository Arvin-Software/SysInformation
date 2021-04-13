Imports System.Management
Imports System.Globalization.CultureInfo
Public Class Memory
    Public Class CLSDIOD
        Private objPhyMem As ManagementObjectSearcher
        Private objPhyMemAr As ManagementObjectSearcher
        Private objMgmt As ManagementObject
        Private m_PhyCap As String
        Private m_PhyMaxInstallable As String
        Private m_PhyMemDev As String
        Public Sub New()
            objPhyMem = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory")
            objPhyMemAr = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemoryArray")
            For Each Me.objMgmt In objPhyMem.Get
                m_PhyCap = objMgmt("capacity")
            Next
            For Each Me.objMgmt In objPhyMemAr.Get
                m_PhyMaxInstallable = objMgmt("MaxCapacity")
                m_PhyMemDev = objMgmt("memoryDevices")
            Next
        End Sub
        Public ReadOnly Property PhyMemDev()
            Get
                PhyMemDev = m_PhyMemDev
            End Get
        End Property
        Public ReadOnly Property PhyMaxMemInstall()
            Get
                PhyMaxMemInstall = m_PhyMaxInstallable
            End Get
        End Property
        Public ReadOnly Property PhyCap()
            Get
                PhyCap = m_PhyCap
            End Get
        End Property
    End Class
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tmrMem.Enabled = True
        GetMemoryInformation()
    End Sub
    Private Sub tmrMem_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMem.Tick
        Try
            Dim remmem
            remmem = Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024, 0)
            lblRemMem.Text = remmem & " MB"
            Dim totrm = Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, 0)
            Dim usedrm = totrm - remmem
            lblUsedMem.Text = Math.Round(usedrm) & " MB"
            Dim srm As String
            Dim sAvlrm As String
            Dim sperus As String
            Dim sused As String
            srm = My.Computer.Info.TotalPhysicalMemory()
            sAvlrm = My.Computer.Info.AvailablePhysicalMemory()
            srm = Math.Round(srm / 1024 / 1024 / 1024, 2)
            sAvlrm = Math.Round(sAvlrm / 1024 / 1024 / 1024, 2)
            sused = srm - sAvlrm
            sperus = CInt(Math.Round(CDbl(sused) / CDbl(srm) * 100, 0))
            prRM.Maximum = 100
            prRM.Value = sperus
            lblCPU.Text = "Load : " & sperus & " %"
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Private Sub GetMemoryInformation()
        tmrMem.Enabled = True
        ' Get memory module information.

        Dim installedCapacity As Long
        Dim slotCount As Integer
        Dim memorySize As Long

        Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory WHERE Capacity > 0")
        Dim queryCollection As ManagementObjectCollection = query.Get()


        Try
            For Each mo As ManagementObject In queryCollection
                slotCount += 1
                memorySize = CLng(mo("Capacity"))

                installedCapacity += memorySize
                'MsgBox(installedCapacity)
                Dim totalMem As Long = installedCapacity
                totalMem = Math.Round(totalMem / 1024 / 1024 / 1024, 0)
                'MsgBox(totalMem.ToString(InvariantCulture) & " MBytes")
                Dim avlmem = Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024, 2)
                lblInstMem.Text = totalMem.ToString(InvariantCulture) & " GB (" & avlmem & " GB Usable)"
                lblRemMem.Text = Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024, 0) & " MB"
                Dim objWMi As New CLSDIOD
                With objWMi
                    lblMaxInsMem.Text = Math.Round(.PhyMaxMemInstall / 1024 / 1024, 0) & " GB"
                    lblTotMemSlots.Text = .PhyMemDev
                End With
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
        lstMemoryModules.Items.Clear()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_PhysicalMemory")

            For Each queryObj As ManagementObject In searcher.Get()
                lstMemoryModules.Items.Add(queryObj("BankLabel"))
                lstMemoryModules.Items(sist).SubItems.Add(Math.Round(queryObj("capacity") / 1024 / 1024, 0))
                Dim typ = queryObj("MemoryType")
                Select Case typ
                    Case 20
                        lstMemoryModules.Items(sist).SubItems.Add("DDR")
                    Case 21
                        lstMemoryModules.Items(sist).SubItems.Add("DDR 2")
                    Case Else
                        If (typ = 0 Or typ > 22) Then
                            lstMemoryModules.Items(sist).SubItems.Add("DDR 3")
                        Else
                            lstMemoryModules.Items(sist).SubItems.Add("Other")
                        End If
                End Select
                '        public string GetMemoryType(int MemoryType)
                '{
                '        Switch(MemoryType)
                '    {
                '        case 20:
                '            return "DDR";
                '            break;
                '        case 21:
                '            return "DDR-2";
                '            break;
                '        default:
                '            if (MemoryType == 0 || MemoryType > 22)
                '                return "DDR-3";
                '        Else
                '                return "Other";
                '            break;

                '    }
                sist += 1
            Next
            lblOccMemSlots.Text = sist
            'MsgBox(sist)
        Catch err As ManagementException
            Motherboard.ereror = err.ToString
            CrashBox.ShowDialog()
            'MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
        'Processes.EnumerateProcess(lstMemoryModules)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MemAdv.ShowDialog()
    End Sub
End Class
