Imports System.Management

Public Class Processor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tmrCPU.Enabled = True
        GetProcessorInformation()
    End Sub
    Public Shared l1cache As String
    Public Shared l2cache As String
    Public Shared l3cache As String
    Public Shared proname As String
    Public Shared promanu As String
    Public Shared proiden As String
    Public Shared pronoofcrs As String
    Public Shared pronoofthr As String
    Private Sub GetProcessorInformation()

        Try
            tmrProCurClckSpd.Enabled = True
            tmrCPU.Enabled = True
            lblL1CachSz.Text = RetrieveProcessorCacheInfo("L1")
            l1cache = RetrieveProcessorCacheInfo("L1")
            lblL2CachSz.Text = RetrieveProcessorCacheInfo("L2")
            l2cache = RetrieveProcessorCacheInfo("L2")
            lblL3CachSz.Text = RetrieveProcessorCacheInfo("L3")
            l3cache = RetrieveProcessorCacheInfo("L3")
            Dim objWMI As New clsWMI
            With objWMI
                lblProManu.Text = .ProManu
                promanu = .ProManu
                Dim s As String = .ProNm
                For i = 0 To s.Length - 2
                    If s(i) = " " Then
                        lblProNm.Text = s.Replace("   ", " ")
                    End If
                Next
                'lblProNm.Text = .ProNm
                proname = .ProNm
                proiden = .ProIden
                lblProIden.Text = .ProIden

                Dim proArchite
                Dim proArchiRet
                proArchite = .proArchi
                If proArchite = "0" Then
                    proArchiRet = "x86"
                ElseIf proArchite = "1" Then
                    proArchiRet = "MIPS"
                ElseIf proArchite = "2" Then
                    proArchiRet = "Alpha"
                ElseIf proArchite = "3" Then
                    proArchiRet = "Power Pc"
                ElseIf proArchite = "6" Then
                    proArchiRet = "Itanium-based systems"
                ElseIf proArchite = "9" Then
                    proArchiRet = "x64"
                Else
                    proArchiRet = notAvailable
                End If
                lblProArc.Text = proArchiRet
                lblSockTyp.Text = .proSockDes
                lblProNoOfCrs.Text = .proNoOfCores
                pronoofcrs = .proNoOfCores

                lblThreads.Text = .proNoOfLogPro
                pronoofthr = .proNoOfLogPro

                If .PClockSpeed <> "" Then
                    lblProCurClSpd.Text = .PClockSpeed & " Mhz"
                End If
                If .MaxClockSpeed <> "" Then
                    lblProMaxClSpd.Text = .MaxClockSpeed & " Mhz"
                End If
                If .ExtClock <> "" Then
                    lblProExtClSpd.Text = .ExtClock & " Mhz"
                End If
                If .PVolt = 1 Then
                    lblProVolt.Text = "5 Volts"
                ElseIf .PVolt = 2 Then
                    lblProVolt.Text = "3.3 Volts"
                ElseIf .PVolt = 4 Then
                    lblProVolt.Text = "2.9 Volts"
                Else
                    lblProVolt.Text = notAvailable
                End If
            End With
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Public Const notAvailable As String = "No information available"
    Private Shared Function RetrieveProcessorCacheInfo(ByVal cache As String) As String

        ' Gets the processor cache information for the specified cache level.

        Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_CacheMemory Where InstalledSize > 0")
        Dim queryCollection As ManagementObjectCollection = query.Get()

        Dim cacheSize As String = notAvailable
        Dim purpose As String

        Try
            For Each mo As ManagementObject In queryCollection
                If mo("Purpose") IsNot Nothing Then
                    purpose = mo("Purpose").ToString

                    If purpose.Contains(cache) Then
                        cacheSize = mo("InstalledSize").ToString & " KB"
                        Exit For
                    End If

                End If
            Next
        Catch ex As ManagementException
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
            'ErrorList.AddErrorToList(ex.Message, "Win32_CacheMemory", "Getting Processor Cache Info for: " & cache)
        End Try

        Return cacheSize

    End Function
    Private Sub tmrCPU_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCPU.Tick
        prCPU.Value = perCPU.NextValue()
        If prCPU.Value < 10 Then
            lblCPU.Text = "Load : 0" & prCPU.Value.ToString & " %"
        Else
            lblCPU.Text = "Load : " & prCPU.Value.ToString & " %"
        End If
    End Sub
End Class
