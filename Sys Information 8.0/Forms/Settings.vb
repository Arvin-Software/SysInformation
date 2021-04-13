Imports System.Runtime.InteropServices

Public Class Settings
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        
    End Sub
    Private Sub panColorSelect1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panColorSelect1.MouseDown
        panColorSelect1.BorderStyle = BorderStyle.FixedSingle
        panColorSelect2.BorderStyle = BorderStyle.None
        panColorSelect3.BorderStyle = BorderStyle.None
        panColorSelect4.BorderStyle = BorderStyle.None
        panColorSelect5.BorderStyle = BorderStyle.None
        My.Settings.Skin = 1
        My.Settings.Save()
        Main.BackColor = Color.Gray
        Main.panControl.BackColor = Color.DimGray
        Main.panStatusbar.BackColor = Color.Transparent
        Main.Panel2.BackColor = Color.DimGray
       
        Main.lblTit1.ForeColor = Color.White
        Main.lblTit2.ForeColor = Color.White
        Main.bttnMin.ForeColor = Color.White
        Main.bttnClose.ForeColor = Color.White
        Main.bttnOverview.ForeColor = Color.White
        Main.bttnGraphics.ForeColor = Color.White
        Main.bttnInsSoft.ForeColor = Color.White
        Main.bttnMem.ForeColor = Color.White
        Main.bttnMther.ForeColor = Color.White
        Main.bttnOs.ForeColor = Color.White
        Main.bttnPeriph.ForeColor = Color.White
        Main.bttnProAndServ.ForeColor = Color.White
        Main.bttnproc.ForeColor = Color.White
        Main.bttnBat.ForeColor = Color.White
        Main.bttnHrddsk.ForeColor = Color.White
        Main.lblCopyright.ForeColor = Color.White
        Main.lblIP.ForeColor = Color.White
        Main.lblDttm.ForeColor = Color.White
        Main.lblBatPer.ForeColor = Color.White
    End Sub
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub panColorSelect2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panColorSelect2.MouseDown
        panColorSelect2.BorderStyle = BorderStyle.FixedSingle
        panColorSelect1.BorderStyle = BorderStyle.None
        panColorSelect3.BorderStyle = BorderStyle.None
        panColorSelect4.BorderStyle = BorderStyle.None
        panColorSelect5.BorderStyle = BorderStyle.None
        My.Settings.Skin = 2
        My.Settings.Save()
        Main.BackColor = Color.Silver
        Main.panControl.BackColor = Color.DarkGray
        Main.panStatusbar.BackColor = Color.Silver
        Main.lblTit1.ForeColor = Color.Black
        Main.lblTit2.ForeColor = Color.Black
        Main.bttnMin.ForeColor = Color.Black
        Main.bttnClose.ForeColor = Color.Black
        Main.bttnOverview.ForeColor = Color.Black
        Main.bttnGraphics.ForeColor = Color.Black
        Main.bttnInsSoft.ForeColor = Color.Black
        Main.bttnMem.ForeColor = Color.Black
        Main.bttnMther.ForeColor = Color.Black
        Main.bttnOs.ForeColor = Color.Black
        Main.bttnPeriph.ForeColor = Color.Black
        Main.bttnProAndServ.ForeColor = Color.Black
        Main.bttnproc.ForeColor = Color.Black
        Main.bttnBat.ForeColor = Color.Black
        Main.bttnHrddsk.ForeColor = Color.Black
        Main.lblCopyright.ForeColor = Color.Black
        Main.lblIP.ForeColor = Color.Black
        Main.lblDttm.ForeColor = Color.Black
        Main.lblBatPer.ForeColor = Color.Black
    End Sub


    Private Sub panColorSelect3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panColorSelect3.MouseDown
        panColorSelect3.BorderStyle = BorderStyle.FixedSingle
        panColorSelect2.BorderStyle = BorderStyle.None
        panColorSelect1.BorderStyle = BorderStyle.None
        panColorSelect4.BorderStyle = BorderStyle.None
        panColorSelect5.BorderStyle = BorderStyle.None
        My.Settings.Skin = 3
        My.Settings.Save()
        Main.BackColor = Color.FromArgb(122, 179, 254)
        Main.panControl.BackColor = Color.FromArgb(1, 128, 188)
        Main.panStatusbar.BackColor = Color.FromArgb(122, 179, 254)
        Main.lblTit1.ForeColor = Color.Black
        Main.lblTit2.ForeColor = Color.Black
        Main.bttnMin.ForeColor = Color.Black
        Main.bttnClose.ForeColor = Color.Black
        Main.bttnOverview.ForeColor = Color.Black
        Main.bttnGraphics.ForeColor = Color.Black
        Main.bttnInsSoft.ForeColor = Color.Black
        Main.bttnMem.ForeColor = Color.Black
        Main.bttnMther.ForeColor = Color.Black
        Main.bttnOs.ForeColor = Color.Black
        Main.bttnPeriph.ForeColor = Color.Black
        Main.bttnProAndServ.ForeColor = Color.Black
        Main.bttnproc.ForeColor = Color.Black
        Main.bttnBat.ForeColor = Color.Black
        Main.bttnHrddsk.ForeColor = Color.Black
        Main.lblCopyright.ForeColor = Color.Black
        Main.lblIP.ForeColor = Color.Black
        Main.lblDttm.ForeColor = Color.Black
        Main.lblBatPer.ForeColor = Color.Black
    End Sub

    Private Sub Settings_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        panDebug.Visible = False
        'DebugToolStripMenuItem.Text = "Show Debug"
        Me.Close()
    End Sub

    Private Sub panColorSelect4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panColorSelect4.MouseDown
        panColorSelect2.BorderStyle = BorderStyle.None
        panColorSelect1.BorderStyle = BorderStyle.None
        panColorSelect3.BorderStyle = BorderStyle.None
        panColorSelect4.BorderStyle = BorderStyle.FixedSingle
        panColorSelect5.BorderStyle = BorderStyle.None
        My.Settings.Skin = 4 '
        My.Settings.Save()
        Main.BackColor = Color.IndianRed
        Main.panControl.BackColor = Color.Firebrick
        Main.panStatusbar.BackColor = Color.IndianRed
        Main.lblTit1.ForeColor = Color.White
        Main.lblTit2.ForeColor = Color.White
        Main.bttnMin.ForeColor = Color.White
        Main.bttnClose.ForeColor = Color.White
        Main.bttnOverview.ForeColor = Color.White
        Main.bttnGraphics.ForeColor = Color.White
        Main.bttnInsSoft.ForeColor = Color.White
        Main.bttnMem.ForeColor = Color.White
        Main.bttnMther.ForeColor = Color.White
        Main.bttnOs.ForeColor = Color.White
        Main.bttnPeriph.ForeColor = Color.White
        Main.bttnProAndServ.ForeColor = Color.White
        Main.bttnproc.ForeColor = Color.White
        Main.bttnBat.ForeColor = Color.White
        Main.bttnHrddsk.ForeColor = Color.White
        Main.lblCopyright.ForeColor = Color.White
        Main.lblIP.ForeColor = Color.White
        Main.lblDttm.ForeColor = Color.White
        Main.lblBatPer.ForeColor = Color.White
    End Sub
    Private Sub panColorSelect5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panColorSelect5.MouseDown
        panColorSelect2.BorderStyle = BorderStyle.None
        panColorSelect1.BorderStyle = BorderStyle.None
        panColorSelect3.BorderStyle = BorderStyle.None
        panColorSelect4.BorderStyle = BorderStyle.None
        panColorSelect5.BorderStyle = BorderStyle.FixedSingle
        My.Settings.Skin = 5
        My.Settings.Save()
        Main.BackColor = Color.OliveDrab
        Main.panControl.BackColor = Color.DarkOliveGreen
        Main.panStatusbar.BackColor = Color.OliveDrab
        Main.lblTit1.ForeColor = Color.White
        Main.lblTit2.ForeColor = Color.White
        Main.bttnMin.ForeColor = Color.White
        Main.bttnClose.ForeColor = Color.White
        Main.bttnOverview.ForeColor = Color.White
        Main.bttnGraphics.ForeColor = Color.White
        Main.bttnInsSoft.ForeColor = Color.White
        Main.bttnMem.ForeColor = Color.White
        Main.bttnMther.ForeColor = Color.White
        Main.bttnOs.ForeColor = Color.White
        Main.bttnPeriph.ForeColor = Color.White
        Main.bttnProAndServ.ForeColor = Color.White
        Main.bttnproc.ForeColor = Color.White
        Main.bttnBat.ForeColor = Color.White
        Main.bttnHrddsk.ForeColor = Color.White
        Main.lblCopyright.ForeColor = Color.White
        Main.lblIP.ForeColor = Color.White
        Main.lblDttm.ForeColor = Color.White
        Main.lblBatPer.ForeColor = Color.White
    End Sub
    Private Sub Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If My.Settings.Skin = 1 Then
            panColorSelect1.BorderStyle = BorderStyle.FixedSingle
            panColorSelect2.BorderStyle = BorderStyle.None
            panColorSelect3.BorderStyle = BorderStyle.None
            panColorSelect4.BorderStyle = BorderStyle.None
            panColorSelect5.BorderStyle = BorderStyle.None
        ElseIf My.Settings.Skin = 2 Then
            panColorSelect1.BorderStyle = BorderStyle.None
            panColorSelect2.BorderStyle = BorderStyle.FixedSingle
            panColorSelect3.BorderStyle = BorderStyle.None
            panColorSelect4.BorderStyle = BorderStyle.None
            panColorSelect5.BorderStyle = BorderStyle.None
        ElseIf My.Settings.Skin = 3 Then
            panColorSelect1.BorderStyle = BorderStyle.None
            panColorSelect2.BorderStyle = BorderStyle.None
            panColorSelect3.BorderStyle = BorderStyle.FixedSingle
            panColorSelect4.BorderStyle = BorderStyle.None
            panColorSelect5.BorderStyle = BorderStyle.None
        ElseIf My.Settings.Skin = 4 Then
            panColorSelect1.BorderStyle = BorderStyle.None
            panColorSelect2.BorderStyle = BorderStyle.None
            panColorSelect3.BorderStyle = BorderStyle.None
            panColorSelect4.BorderStyle = BorderStyle.FixedSingle
            panColorSelect5.BorderStyle = BorderStyle.None
        ElseIf My.Settings.Skin = 5 Then
            panColorSelect1.BorderStyle = BorderStyle.None
            panColorSelect2.BorderStyle = BorderStyle.None
            panColorSelect3.BorderStyle = BorderStyle.None
            panColorSelect4.BorderStyle = BorderStyle.None
            panColorSelect5.BorderStyle = BorderStyle.FixedSingle
        End If
        If My.Settings.IntStartup = 1 Then
            chkInt.Checked = True
        ElseIf My.Settings.IntStartup = 0 Then
            chkInt.Checked = False
        Else
            chkInt.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If chkInt.Checked = True Then
            My.Settings.IntStartup = 1
        ElseIf chkInt.Checked = False Then
            My.Settings.IntStartup = 0
        Else
            My.Settings.IntStartup = 0
        End If
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Main.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Main.bttnClose.Visible = False
            Main.bttnMin.Visible = False
        ElseIf CheckBox1.Checked = False Then
            Main.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Main.bttnClose.Visible = True
            Main.bttnMin.Visible = True
        Else
            Main.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Main.bttnClose.Visible = True
            Main.bttnMin.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtDebugCode.Text = "Debug.ShowCrashBox()" Then
            'CrashBox.ShowDialog()
            Motherboard.ereror = "Error occured at testing" & vbNewLine & "This is only for testing purpose not a realtime error"
            CrashBox.Show()
        ElseIf txtDebugCode.Text = "Debug.HideCrashBox()" Then
            CrashBox.Close()
        ElseIf txtDebugCode.Text = "Debug.ShowTradition()" Then
            Main.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        ElseIf txtDebugCode.Text = "Debug.HideTradition()" Then
            Main.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        ElseIf txtDebugCode.Text = "Debug.SizableMain()" Then
            Main.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        ElseIf txtDebugCode.Text = "Debug.ViewSettings()" Then
            MsgBox("Skin : " & My.Settings.Skin.ToString & vbNewLine & "IntOnStrtUp : " & My.Settings.IntStartup.ToString)
        ElseIf txtDebugCode.Text = "Debug.StopTimers()" Then
            'MsgBox("You are about to stop the timers that are used to check the processor and ram usage stop it will stop the live update of the usages", MsgBoxStyle.Information + vbOKOnly, "Information")
            Main.tmrDtTm.Enabled = False
            ' pro.tmrProCurClckSpd.Enabled = False
            'MsgBox("Timers are stopped to enable them please insert the correct code or restart the program if you don't know how to do so", MsgBoxStyle.Information + vbOKOnly, "Information")
        ElseIf txtDebugCode.Text = "Debug.StartTimers()" Then
            Main.tmrDtTm.Enabled = True
            'MsgBox("Timers are back on their business", MsgBoxStyle.Information + vbOKOnly, "Information")
        ElseIf txtDebugCode.Text = "Debug.StopThemeing()" Then
            'lblThemDebug.Visible = True
            panThem.Enabled = False
        ElseIf txtDebugCode.Text = "Debug.StartThemeing()" Then
            'lblThemDebug.Visible = False
            panThem.Enabled = True
        ElseIf txtDebugCode.Text = "Debug.StopOtherSettings()" Then
            panOtherSet.Enabled = False
        ElseIf txtDebugCode.Text = "Debug.StartOtherSettings()" Then
            panOtherSet.Enabled = True
        ElseIf txtDebugCode.Text = "Debug.DisableCloseSettings()" Then
            bttnClose.Enabled = False
        ElseIf txtDebugCode.Text = "Debug.EnableCloseSettings()" Then
            bttnClose.Enabled = True
        ElseIf txtDebugCode.Text = "Debug.DisableCloseMain()" Then
            Main.bttnClose.Enabled = False
        ElseIf txtDebugCode.Text = "Debug.EnableClosemain()" Then
            Main.bttnClose.Enabled = True
        ElseIf txtDebugCode.Text = "Debug.DisableMiniMain()" Then
            Main.bttnMin.Enabled = False
        ElseIf txtDebugCode.Text = "Debug.EnableMiniMain()" Then
            Main.bttnMin.Enabled = True
        ElseIf txtDebugCode.Text = "Debug.NameTheApp()" Then
            'MsgBox("This will permanent change until the software restart")
            txtNameOfApp.Visible = True
            bttnNameOfApp.Visible = True
        Else
            MsgBox("Please enter the correct code to execute")
        End If
    End Sub

    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub
    Private Sub Label2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblSet.MouseDoubleClick
        If panDebug.Visible = True Then
            panDebug.Visible = False
            'DebugToolStripMenuItem.Text = "Show Debug"

        Else
            If Main.lblDebug.Visible = True Then
                Dim res = MsgBox("Debug codes are just for fun only and by using these codes you can modify the functionality of the software temperorily but the software will function normally after restarting" &
                                 vbNewLine & "When you enter this mode the software will malfunction and this is not bug but is is a builtin feature to entertain the users" &
                                 vbNewLine & "Do you want to continue ? ", MsgBoxStyle.Exclamation + vbYesNo, "Do you want to continue")
                If res = vbYes Then
                    panDebug.Visible = True
                    ' DebugToolStripMenuItem.Text = "Hide Debug"
                End If
            End If
        End If
    End Sub

    Private Sub bttnNameOfApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNameOfApp.Click
        If txtNameOfApp.Text <> "" Then
            Main.lblTit1.Text = txtNameOfApp.Text
            txtNameOfApp.Visible = False
            bttnNameOfApp.Visible = False
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ReportCreation.lblwait.Visible = True
        ReportCreation.ShowDialog()
    End Sub
End Class