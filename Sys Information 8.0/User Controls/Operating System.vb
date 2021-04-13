Imports System.Environment
Public Class Operating_System
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OperatingSystem()
        GetSpecialFolders()
        'russian()
    End Sub
    Public Shared operatingversion As String
    Public Shared operatingbuildtyp As String
    Public Shared operatingbit As String
    Public Shared operatingsysdir As String
    Public Shared windir As String
    Public Shared bootdevice As String
    Public Shared installdate As String
    Public Shared serialnum As String
    Public Shared reguser As String
    Public Shared regorg As String
    Public Shared ServicePack As String
    Public Shared uptime As String
    'Public Sub russian()
    '    Dim russion As Boolean
    '    russion = False
    '    If russion = True Then
    '        lolvers.Text = "версия:"
    '        lolplat.Text = "платформа:"
    '        lolinst.Text = "платформа:"
    '        lolsysdir.Text = "Система каталогов:"
    '        lolserial.Text = "Серийный номер:"
    '        lollogged.Text = "Вы вошли как:"
    '        '    lolinfo.Text = "Просмотр информации о вашей операционной системы"
    '        '    leloperatingsystem.Text = "операционная система"
    '        'End If
    'End Sub
    Public Sub OperatingSystem()
        Try
            Dim objWMI As New clsWMI
            With objWMI
                If .OperServicePack <> "" Then
                    lblOSEdition.Text = My.Computer.Info.OSFullName & "- " & .OperServicePack
                    ServicePack = CStr(.OperServicePack)
                Else
                    lblOSEdition.Text = My.Computer.Info.OSFullName
                    ServicePack = ""
                End If
                lblOSVers.Text = .OperVersion & "(Build " & .OperBuildNum & ")"
                operatingversion = .OperVersion

                lblOperBuildTyp.Text = .OperBuildType
                operatingbuildtyp = .OperBuildType

                lblOsPlatform.Text = os.getOsBitness & "-bit"
                operatingbit = os.getOsBitness

                lblOSSystemDir.Text = .OperSysDirec
                operatingsysdir = .OperSysDirec

                lblOSWindowsDir.Text = .OperWinDirec
                windir = .OperWinDirec

                lblOSBootDevice.Text = .OperBootDevice
                bootdevice = .OperBootDevice

                lblOSInstallationDate.Text = os.InstallationDate
                installdate = os.InstallationDate

                lblOSSerialNumber.Text = .OperSerialNum
                serialnum = .OperSerialNum

                lblOSRegUser.Text = .OperRegUser
                reguser = .OperRegUser

                lblOSOrganisation.Text = .OperRegOrg
                regorg = .OperRegOrg

                lblOsCurrentUser.Text = Environment.UserName
                'lblOsCurrentUser.Text = GetProductKey("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\", "DigitalProductId")
                tmrSysUpt.Enabled = True
                lblSysLstBotDt.Text = Systemd.LastBootUpTime
            End With
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Private Sub tmrSysUpt_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSysUpt.Tick
        If BgwrkrSysUpt.IsBusy = False Then
            BgwrkrSysUpt.RunWorkerAsync()
        End If
    End Sub

    Private Sub BgwrkrSysUpt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgwrkrSysUpt.DoWork
        sttxt(Systemd.Uptime)
        'lblSysUP.Text = Systemd.Uptime
        uptime = Systemd.Uptime
    End Sub
    Delegate Sub settext(ByVal [text] As String)
    Private Sub sttxt(ByVal [text] As String)
        If lblSysUP.InvokeRequired = True Then
            Dim d As New settext(AddressOf sttxt)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblSysUP.Text = [text]
        End If
    End Sub
    Dim folderList As New Dictionary(Of String, String)
    Private Sub GetSpecialFolders()

        Dim folderNames As String() = System.Enum.GetNames(GetType(Environment.SpecialFolder))

        For Each folder As String In folderNames
            Dim lvi As New ListViewItem

            ' Alternate each items' background colour.
            If lstSpecialFolders.Items.Count Mod 2 <> 0 Then
                lvi.BackColor = Color.White
            Else
                lvi.BackColor = Color.WhiteSmoke
            End If

            folderList.Add(folder, GetFolderPath(CType(System.Enum.Parse(GetType(SpecialFolder), CType(folder, String)), SpecialFolder)))

            lvi.Text = folder
            lvi.SubItems.Add(folderList.Item(folder))
            lstSpecialFolders.Items.Add(lvi)
        Next
    End Sub
End Class
