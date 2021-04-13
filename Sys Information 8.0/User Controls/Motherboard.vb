Imports System.Management

Public Class Motherboard
    Public Shared ereror As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Motherboard()
    End Sub
    Dim objWMI As New clsWMI
    Public Shared mothermanu As String
    Public Shared mothermod As String
    Public Shared motherrevision As String
    Public Shared motherserials As String
    Public Shared primarybustyp As String
    Public Shared secondarybustyp As String
    Public Shared biosmanu As String
    Public Shared biosversion As String
    Public Shared biosreleasedt As String
    Public Shared biossmbsvers As String
    Public Sub Motherboard()
        Try
            With objWMI
                lblMoBoMake.Text = .MoManufact
                mothermanu = .MoManufact

                lblMoBoModel.Text = .MoProduct
                mothermod = .MoProduct

                lblMoBoRevision.Text = .MoVersion
                motherrevision = .MoVersion

                lblMoBoSerialNumber.Text = .MoSerial
                motherserials = .MoSerial

                lblPriBsTyp.Text = .MoPriBsTyp
                primarybustyp = .MoPriBsTyp

                lblSecBsTyp.Text = .MoSecBsTyp
                secondarybustyp = .MoSecBsTyp

                lblBiosMake.Text = .BIOSManu
                biosmanu = .BIOSManu

                lblBiosVersion.Text = .BIOSVers
                biosversion = .BIOSVers

                lblSMBiosVersion.Text = .SMBIOSVers
                biossmbsvers = .SMBIOSVers

                lblBiosDate.Text = Bios.ReleaseDate
                biosreleasedt = Bios.ReleaseDate
            End With

            LstOnBrd.Items.Clear()
            Dim count As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_OnBoardDevice")
            'lstHrdDev.Items.Clear()
            For Each queryObj As ManagementObject In searcher.Get
                LstOnBrd.Items.Add(queryObj("Description"))
                Dim devtyp, devtypret
                devtyp = queryObj("devicetype")
                If devtyp = 1 Then
                    devtypret = "Other"
                ElseIf devtyp = 2 Then
                    devtypret = "Unknown"
                ElseIf devtyp = 3 Then
                    devtypret = "Video"
                ElseIf devtyp = 4 Then
                    devtypret = "SCSI Controller"
                ElseIf devtyp = 5 Then
                    devtypret = "Ethernet"
                ElseIf devtyp = 6 Then
                    devtypret = "Token Ring"
                ElseIf devtyp = 7 Then
                    devtypret = "Sound"
                Else
                    devtypret = "Not Found"
                End If
                LstOnBrd.Items(count).SubItems.Add(devtypret)
                count += 1
            Next
            'Dim fint As Integer = 0
            'For i = 0 To 10
            '    LstOnBrd.Items.Add(i)
            '    LstOnBrd.Items(i).SubItems.Add(i)
            'Next
            'ereror = "Test Crash"
            'CrashBox.ShowDialog()
        Catch ex As Exception
            ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
End Class
