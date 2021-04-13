Imports System.Runtime.InteropServices
Imports System.Net
Imports System.IO
Imports System.Text

Public Class Main
    Dim overvw As Overview
    Dim os As Operating_System
    Dim mther As Motherboard
    Dim inssoft As InstalledSoftwares
    Dim pro As Processor
    Dim mem As Memory
    Dim networkd As Networke
    Dim Graphccrd As GraphicCard
    Dim peri As peripherals
    Dim str As StorageDevices
    Dim bat As Battery
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Splash.Status("Loading Overview section...")
        overvw = New Overview
        Splash.Status("Loading OS section...")
        os = New Operating_System
        Splash.Status("Loading Motherboard section...")
        mther = New Motherboard
        Splash.Status("Enumerating installed softwares...")
        inssoft = New InstalledSoftwares
        Splash.Status("Loading Processor section...")
        pro = New Processor
        Splash.Status("Loading Memory section...")
        mem = New Memory
        Splash.Status("Loading Network section...")
        networkd = New Networke
        Splash.Status("Loading Graphic card section...")
        Graphccrd = New GraphicCard
        Splash.Status("Loading Peripherals section...")
        str = New StorageDevices
        Splash.Status("Loading Storage Devices section...")
        peri = New peripherals
        Dim obdWMI As New clsWMI
        With obdWMI
            If .BatAvl <> "" Then
                Splash.Status("Loading Battery section...")
                bat = New Battery
            End If
        End With
    End Sub
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    'Private Sub GetIPAddress()
    

    'End Sub
    'Public Shared Function GetIPAddress()
    '    Dim wc As New WebClient
    '    Return wc.DownloadString("http://automation.whatismyip.com/n09230945.asp")
    'End Function

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Controls.Clear()
        Panel1.Controls.Add(overvw)
        tmrDtTm.Enabled = True

        Dim objEDI As New clsWMI
        With objEDI
            If .BatAvl = "" Then
                bttnBat.Visible = False
                lblBatPer.Visible = False
            Else
                tmrBat.Enabled = True
                lblBatPer.Text = "Bat : " & .BatLvl & " %"
            End If
        End With
        'panHrd.Visible = False
        'panSoft.Visible = False
        'panlblSoft.Location = New Point(0, 95)
        'panSoft.Location = New Point(0, 120)
        'If InstalledSoftwares.CheckUsingVersionNumber() = "7" Or InstalledSoftwares.CheckUsingVersionNumber() = "vista" Then
        '    'FormSplash.Status("Listing System Drivers...")
        '    'dri = New Drivers
        'Else
        '    bttnInsSoft.Text = "Softwares"
        'End If
        If My.Settings.Skin = 1 Then
            Me.BackColor = Color.Gray
            'panControl.BackColor = Color.DimGray
            'panStatusbar.BackColor = Color.Gray
            lblTit1.ForeColor = Color.White
            lblTit2.ForeColor = Color.White
            bttnMin.ForeColor = Color.White
            bttnClose.ForeColor = Color.White
            Panel2.BackColor = Color.DimGray
            bttnOverview.ForeColor = Color.White
            bttnGraphics.ForeColor = Color.White
            bttnInsSoft.ForeColor = Color.White
            bttnMem.ForeColor = Color.White
            bttnMther.ForeColor = Color.White
            bttnOs.ForeColor = Color.White
            bttnPeriph.ForeColor = Color.White
            bttnProAndServ.ForeColor = Color.White
            bttnproc.ForeColor = Color.White
            bttnBat.ForeColor = Color.White
            bttnHrddsk.ForeColor = Color.White
            lblCopyright.ForeColor = Color.White
            lblIP.ForeColor = Color.White
            lblDttm.ForeColor = Color.White
            lblBatPer.ForeColor = Color.White
        ElseIf My.Settings.Skin = 2 Then
            Me.BackColor = Color.Silver
            panControl.BackColor = Color.DarkGray
            panStatusbar.BackColor = Color.Silver
            lblTit1.ForeColor = Color.Black
            lblTit2.ForeColor = Color.Black
            bttnMin.ForeColor = Color.Black
            bttnClose.ForeColor = Color.Black
            bttnOverview.ForeColor = Color.Black
            bttnGraphics.ForeColor = Color.Black
            bttnInsSoft.ForeColor = Color.Black
            bttnMem.ForeColor = Color.Black
            bttnMther.ForeColor = Color.Black
            bttnOs.ForeColor = Color.Black
            bttnPeriph.ForeColor = Color.Black
            bttnProAndServ.ForeColor = Color.Black
            bttnproc.ForeColor = Color.Black
            bttnBat.ForeColor = Color.Black
            bttnHrddsk.ForeColor = Color.Black
            lblCopyright.ForeColor = Color.Black
            lblIP.ForeColor = Color.Black
            lblDttm.ForeColor = Color.Black
            lblBatPer.ForeColor = Color.Black
        ElseIf My.Settings.Skin = 3 Then
            Me.BackColor = Color.FromArgb(122, 179, 254)
            panControl.BackColor = Color.FromArgb(1, 128, 188)
            panStatusbar.BackColor = Color.FromArgb(122, 179, 254)
            lblTit1.ForeColor = Color.Black
            lblTit2.ForeColor = Color.Black
            bttnMin.ForeColor = Color.Black
            bttnClose.ForeColor = Color.Black
            bttnOverview.ForeColor = Color.Black
            bttnGraphics.ForeColor = Color.Black
            bttnInsSoft.ForeColor = Color.Black
            bttnMem.ForeColor = Color.Black
            bttnMther.ForeColor = Color.Black
            bttnOs.ForeColor = Color.Black
            bttnPeriph.ForeColor = Color.Black
            bttnProAndServ.ForeColor = Color.Black
            bttnproc.ForeColor = Color.Black
            bttnBat.ForeColor = Color.Black
            bttnHrddsk.ForeColor = Color.Black
            lblCopyright.ForeColor = Color.Black
            lblIP.ForeColor = Color.Black
            lblDttm.ForeColor = Color.Black
            lblBatPer.ForeColor = Color.Black
        ElseIf My.Settings.Skin = 4 Then
            Me.BackColor = Color.IndianRed
            panControl.BackColor = Color.Firebrick
            panStatusbar.BackColor = Color.IndianRed
            lblTit1.ForeColor = Color.White
            lblTit2.ForeColor = Color.White
            bttnMin.ForeColor = Color.White
            bttnClose.ForeColor = Color.White
            bttnOverview.ForeColor = Color.White
            bttnGraphics.ForeColor = Color.White
            bttnInsSoft.ForeColor = Color.White
            bttnMem.ForeColor = Color.White
            bttnMther.ForeColor = Color.White
            bttnOs.ForeColor = Color.White
            bttnPeriph.ForeColor = Color.White
            bttnProAndServ.ForeColor = Color.White
            bttnproc.ForeColor = Color.White
            bttnBat.ForeColor = Color.White
            bttnHrddsk.ForeColor = Color.White
            lblCopyright.ForeColor = Color.White
            lblIP.ForeColor = Color.White
            lblDttm.ForeColor = Color.White
            lblBatPer.ForeColor = Color.White
        ElseIf My.Settings.Skin = 5 Then
            Me.BackColor = Color.OliveDrab
            panControl.BackColor = Color.DarkOliveGreen
            panStatusbar.BackColor = Color.OliveDrab
            lblTit1.ForeColor = Color.White
            lblTit2.ForeColor = Color.White
            bttnMin.ForeColor = Color.White
            bttnClose.ForeColor = Color.White
            bttnOverview.ForeColor = Color.White
            bttnGraphics.ForeColor = Color.White
            bttnInsSoft.ForeColor = Color.White
            bttnMem.ForeColor = Color.White
            bttnMther.ForeColor = Color.White
            bttnOs.ForeColor = Color.White
            bttnPeriph.ForeColor = Color.White
            bttnProAndServ.ForeColor = Color.White
            bttnproc.ForeColor = Color.White
            bttnBat.ForeColor = Color.White
            bttnHrddsk.ForeColor = Color.White
            lblCopyright.ForeColor = Color.White
            lblIP.ForeColor = Color.White
            lblDttm.ForeColor = Color.White
            lblBatPer.ForeColor = Color.White
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox.ShowDialog()
    End Sub

    Private Sub bttnOs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOs.Click
        If Not Panel1.Contains(os) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(os)
            'bttnOverview.FlatAppearance.MouseDownBackColor = Color.White
            'bttnOverview.FlatAppearance.MouseOverBackColor = Color.White
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.Black
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.Gray
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.Gray
            bttnOs.BackColor = Color.Gray
            'bttnOs.ForeColor = Color.White
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent

        End If
    End Sub

    Private Sub bttnOverview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOverview.Click
        If Not Panel1.Contains(overvw) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(overvw)
            'bttnOverview.FlatAppearance.MouseDownBackColor = Color.Gray
            'bttnOverview.FlatAppearance.MouseOverBackColor = Color.Gray
            bttnOverview.BackColor = Color.Gray
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            'bttnOs.ForeColor = Color.Black
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnInsSoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnInsSoft.Click
        If Not Panel1.Contains(inssoft) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(inssoft)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Gray
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnMther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMther.Click
        If Not Panel1.Contains(mther) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(mther)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Gray
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnproc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnproc.Click
        If Not Panel1.Contains(pro) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(pro)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Gray
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnMem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMem.Click
        If Not Panel1.Contains(mem) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(mem)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Gray
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnProAndServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnProAndServ.Click
        If Not Panel1.Contains(networkd) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(networkd)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Gray
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnGraphics_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bttnGraphics.Click
        If Not Panel1.Contains(Graphccrd) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Graphccrd)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Gray
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnPeriph_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bttnPeriph.Click
        If Not Panel1.Contains(peri) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(peri)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Gray
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnHrddsk_Click(sender As System.Object, e As System.EventArgs) Handles bttnHrddsk.Click
        If Not Panel1.Contains(str) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(str)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Gray
            bttnBat.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub bttnBat_Click(sender As System.Object, e As System.EventArgs) Handles bttnBat.Click
        If Not Panel1.Contains(bat) Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(bat)
            bttnOverview.BackColor = Color.Transparent
            'bttnOverview.ForeColor = Color.White
            'bttnOs.FlatAppearance.MouseOverBackColor = Color.White
            'bttnOs.FlatAppearance.MouseDownBackColor = Color.White
            bttnOs.BackColor = Color.Transparent
            bttnMther.BackColor = Color.Transparent
            bttnInsSoft.BackColor = Color.Transparent
            bttnproc.BackColor = Color.Transparent
            bttnMem.BackColor = Color.Transparent
            bttnProAndServ.BackColor = Color.Transparent
            bttnGraphics.BackColor = Color.Transparent
            bttnPeriph.BackColor = Color.Transparent
            bttnHrddsk.BackColor = Color.Transparent
            bttnBat.BackColor = Color.Gray
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click, bttnClose.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMin.Click, bttnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Main_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub bttnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAbout.Click
        AboutBox.ShowDialog()
    End Sub
    Delegate Sub setip(ByVal [text] As String)
    Private Sub stip(ByVal [text] As String)
        If lblIP.InvokeRequired = True Then
            Dim d As New setip(AddressOf stip)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblIP.Text = [text]
        End If
    End Sub
    Delegate Sub settim(ByVal [text] As String)
    Private Sub sttim(ByVal [text] As String)
        If lblDttm.InvokeRequired = True Then
            Dim d As New settim(AddressOf sttim)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblDttm.Text = [text]
        End If
    End Sub
    Delegate Sub setvis(ByVal [bo] As Boolean)
    Private Sub stvs(ByVal [bo] As Boolean)
        If PicInt.InvokeRequired = True Then
            Dim d As New setvis(AddressOf stvs)
            Me.Invoke(d, New Object() {[bo]})
        Else
            PicInt.Visible = [bo]
        End If
    End Sub
    Delegate Sub setvisRe(ByVal [bo] As Boolean)
    Private Sub setVisRef(ByVal [bo] As Boolean)
        If PicRefInt.InvokeRequired = True Then
            Dim d As New setvisRe(AddressOf setVisRef)
            Me.Invoke(d, New Object() {[bo]})
        Else
            PicRefInt.Visible = [bo]
        End If
    End Sub
    Delegate Sub setTxe(ByVal [text] As String)
    Private Sub settex(ByVal [text] As String)
        If lblBatPer.InvokeRequired = True Then
            Dim d As New setTxe(AddressOf settex)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblBatPer.Text = [text]
        End If
    End Sub
    
    Private Sub BGwrkrIP_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGwrkrIP.DoWork
        'Try
        '    If IsConnectionAvailable() = "Connected" Then
        '        lblIPAddress.Text = GetIPAddress()
        '    Else
        '        lblIPAddress.Text = "Not Connected to the internet"
        '    End If
        'Catch ex As Exception
        '    lblIPAddress.Text = "Cannot reach the server"
        'End Try
        Try
            If Misc.IsConnectionAvailable() = "Connected" Then
                stip("Connected to Internet")
                stvs(True)
                setVisRef(False)
                'Misc.GetIPAddress()
                ''PicInt.Visible = True
                'Dim ip = Misc.GetIPAddress()
                'If ip <> "" Then
                '    stip("IP :   " & ip)
                '    'lblIP.Text = "IP :   " & ip
                'Else
                '    stip("IP :No data click to refresh")
                '    setVisRef(True)
                '    'lblIP.Text = "IP :No data click to refresh"
                'End If
            Else
                stip("No Internet Connection")
                stvs(False)
                setVisRef(True)
                ''PicInt.Visible = False
                'stip("IP:No data click to refresh")
                'lblIP.Text = "IP :No data click to refresh"
            End If
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub

    Private Sub lblIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIP.Click
        Try
            lblIP.Text = "Refreshing Status"
            If BGwrkrIP.IsBusy = False Then
                BGwrkrIP.RunWorkerAsync()
            End If
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub

    Private Sub tmrDtTm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDtTm.Tick
        If BGwrkrDtTm.IsBusy = False Then
            BGwrkrDtTm.RunWorkerAsync()
        End If
    End Sub

    Private Sub BGwrkrDtTm_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGwrkrDtTm.DoWork
        Dim min = My.Computer.Clock.LocalTime.Minute
        Dim retmin
        If min < 10 Then
            retmin = "0" & min
        Else
            retmin = min
        End If
        Dim hr = My.Computer.Clock.LocalTime.Hour
        Dim rethr
        Dim retampm
        If hr = 0 Then
            rethr = 12
            retampm = "AM"
        ElseIf hr = 1 Then
            rethr = 1
            retampm = "AM"
        ElseIf hr = 2 Then
            rethr = 2
            retampm = "AM"
        ElseIf hr = 3 Then
            rethr = 3
            retampm = "AM"
        ElseIf hr = 4 Then
            rethr = 4
            retampm = "AM"
        ElseIf hr = 5 Then
            rethr = 5
            retampm = "AM"
        ElseIf hr = 6 Then
            rethr = 6
            retampm = "AM"
        ElseIf hr = 7 Then
            rethr = 7
            retampm = "AM"
        ElseIf hr = 8 Then
            rethr = 8
            retampm = "AM"
        ElseIf hr = 9 Then
            rethr = 9
            retampm = "AM"
        ElseIf hr = 10 Then
            rethr = 10
            retampm = "AM"
        ElseIf hr = 11 Then
            rethr = 11
            retampm = "AM"
        ElseIf hr = 12 Then
            rethr = 12
            retampm = "PM"
        ElseIf hr = 13 Then
            rethr = 1
            retampm = "PM"
        ElseIf hr = 14 Then
            rethr = 2
            retampm = "PM"
        ElseIf hr = 15 Then
            rethr = 3
            retampm = "PM"
        ElseIf hr = 16 Then
            rethr = 4
            retampm = "PM"
        ElseIf hr = 17 Then
            rethr = 5
            retampm = "PM"
        ElseIf hr = 18 Then
            rethr = 6
            retampm = "PM"
        ElseIf hr = 19 Then
            rethr = 7
            retampm = "PM"
        ElseIf hr = 20 Then
            rethr = 8
            retampm = "PM"
        ElseIf hr = 21 Then
            rethr = 9
            retampm = "PM"
        ElseIf hr = 22 Then
            rethr = 10
            retampm = "PM"
        ElseIf hr = 23 Then
            rethr = 11
            retampm = "PM"
        Else
            rethr = hr
            retampm = ""
        End If
        sttim(rethr & ":" & retmin & " " & retampm)
        'lblDttm.Text = "Time : " & My.Computer.Clock.LocalTime
    End Sub

    Private Sub tmrSt_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSt.Tick
        If panlblSoft.Location.Y <> 95 And panSoft.Location.Y <> 120 Then
            panlblSoft.Location = New Point(0, panlblSoft.Location.Y - 10)
            panSoft.Location = New Point(0, panSoft.Location.Y - 10)
        Else
            tmrSt.Enabled = False
            panlblHrd.Enabled = True
        End If
    End Sub

    Private Sub tmrRev_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRev.Tick
        '350 370
        If panlblSoft.Location.Y <> 375 And panSoft.Location.Y <> 400 Then
            panlblSoft.Location = New Point(0, panlblSoft.Location.Y + 10)
            panSoft.Location = New Point(0, panSoft.Location.Y + 10)
        Else
            tmrRev.Enabled = False
            panlblHrd.Enabled = True
            panHrd.Visible = True
            lblCEhrd.Text = "^"
        End If
    End Sub
    Private Sub panlblHrd_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panlblHrd.MouseDown
        If panHrd.Visible = False And panlblSoft.Location.Y = 95 Then
            tmrRev.Enabled = True
            panlblHrd.Enabled = False
        Else
            panHrd.Visible = False
            tmrSt.Enabled = True
            panlblHrd.Enabled = False
            lblCEhrd.Text = "v"
        End If
    End Sub

    Private Sub panlblSoft_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panlblSoft.MouseDown
        If panSoft.Visible = True Then
            panSoft.Visible = False
            lblCESoft.Text = "v"
        Else
            panSoft.Visible = True
            lblCESoft.Text = "^"
        End If
    End Sub

    Private Sub PicAd_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Process.Start("http://arvinsoft.weebly.com/sys-optimizer.html")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Settings.ShowDialog()
    End Sub

    Private Sub lblCEhrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCEhrd.Click
        If panHrd.Visible = False And panlblSoft.Location.Y = 95 Then
            tmrRev.Enabled = True
            panlblHrd.Enabled = False
        Else
            panHrd.Visible = False
            tmrSt.Enabled = True
            panlblHrd.Enabled = False
            lblCEhrd.Text = "v"
        End If
    End Sub

    Private Sub lblCESoft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCESoft.Click
        If panSoft.Visible = True Then
            panSoft.Visible = False
            lblCESoft.Text = "v"
        Else
            panSoft.Visible = True
            lblCESoft.Text = "^"
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If panSoft.Visible = True Then
            panSoft.Visible = False
            lblCESoft.Text = "v"
        Else
            panSoft.Visible = True
            lblCESoft.Text = "^"
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If panHrd.Visible = False And panlblSoft.Location.Y = 95 Then
            tmrRev.Enabled = True
            panlblHrd.Enabled = False
        Else
            panHrd.Visible = False
            tmrSt.Enabled = True
            panlblHrd.Enabled = False
            lblCEhrd.Text = "v"
        End If
    End Sub
    Public Shared Function ShowError()
        Motherboard.ereror = "Error occured at testing" & vbNewLine & "This is only for testing purpose not a realtime error"
        CrashBox.ShowDialog()
        Return Nothing
    End Function


    Private Sub Main_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        Try
            If My.Settings.IntStartup = 1 Then
                Try
                    lblIP.Text = "IP :   Refreshing"
                    If BGwrkrIP.IsBusy = False Then
                        BGwrkrIP.RunWorkerAsync()
                    End If
                Catch ex As Exception
                    Motherboard.ereror = ex.ToString
                    CrashBox.ShowDialog()
                End Try
            End If
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
        'ShowError()
        'MsgBox("This is a beta version of the final software it is somewhat stable but it is not fully stable so it is intended only for testers", MsgBoxStyle.Information + vbOKOnly, "Information")
    End Sub
    Private Sub lblTit1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTit1.MouseDoubleClick
        If lblDebug.Visible = True Then
            lblDebug.Visible = False
        Else
            lblDebug.Visible = True
        End If
    End Sub

    Private Sub BGwrkrBat_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGwrkrBat.DoWork
        Dim dlsWMI As New clsWMI
        With dlsWMI
            If .BatAvl <> "" And .BatStatus = 1 Then
                settex("Bat : " & .BatLvl & " %")
            Else
                settex("Bat : Charging")
            End If
        End With
    End Sub

    Private Sub tmrBat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBat.Tick
        If BGwrkrBat.IsBusy = False Then
            BGwrkrBat.RunWorkerAsync()
        End If
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseClick
        Process.Start("http://www.arvinsoft.weebly.com/sys-information.html")
    End Sub

    
    Private Sub PicRefInt_Click(sender As System.Object, e As System.EventArgs) Handles PicRefInt.Click
        Try
            lblIP.Text = "IP :   Refreshing"
            If BGwrkrIP.IsBusy = False Then
                BGwrkrIP.RunWorkerAsync()
            End If
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
End Class
