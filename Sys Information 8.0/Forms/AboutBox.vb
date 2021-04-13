Imports System.Runtime.InteropServices
Imports System.IO

Public NotInheritable Class AboutBox
    Public Shared Function IsConnectionAvailable()
        Dim objURL As New System.Uri("http://www.google.com")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objURL)
        Dim objResp As System.Net.WebResponse
        Try
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return "Connected"

        Catch ex As Exception
            objResp = Nothing
            objWebReq = Nothing
            Return "Not Connected"
        End Try
    End Function
    Public Function setAD()
        'Label1.Visible = True
        'Try
        '    Dim fileecx
        '    PicAd.BackgroundImage = Nothing
        '    fileecx = File.Exists("C://Windows//Temp//ad.png")
        '    If fileecx = True Then
        '        File.Delete("C://Windows//Temp//ad.png")
        '    End If
        'Catch ex As Exception

        'End Try
        'Try
        '    'Check the internet connection is available
        '    Dim status = IsConnectionAvailable()
        '    'If Internet Connection is available then execute the following args
        '    If status = "Connected" Then
        '        'Download the File from internet to check the update
        '        My.Computer.Network.DownloadFile("http://mmarun.webs.com/adsSysInfo.png", "C://Windows//Temp//ad.png")
        '        PicAd.BackgroundImage = Image.FromFile("C://Windows//Temp//ad.png")
        '        PicAd.BackgroundImageLayout = ImageLayout.Stretch
        '        'Check the version number is above the version in updatefile
        '        'If Internet is not connected then show the error message that "error connecting to internet"
        '    ElseIf status = "Not Connected" Then
        '        ' MsgBox("Error connecting to internet. Please check your internet connection", MsgBoxStyle.OkOnly + vbCritical, "Error")
        '        Return "Error connecting server"
        '        TabControl1.TabPages.Remove(panOth)
        '    End If
        'Catch ex As Exception
        '    'MsgBox("Sorry update information cannot be downloaded", MsgBoxStyle.Critical)
        'End Try
        Return Nothing
    End Function
    Public Class SpecialFoldersandDrives
        'Public Shared crashbox As Boolean
        'Public Shared crashmessage As String
        Public Shared Function OsInstalledDrive()
            Dim dlsWMI As New ClsWMI
            With dlsWMI
                Try
                    Return .WindowsFolder
                Catch ex As Exception
                    Motherboard.ereror = ex.ToString
                    crashbox.ShowDialog()
                    Return Nothing
                End Try
            End With
        End Function
    End Class
    Public Shared Function CheckForUpdates()
        Dim loc As String
        loc = SpecialFoldersandDrives.OsInstalledDrive
        Try
            Dim fileecx
            fileecx = File.Exists(loc & "\Windows\Temp\update6_0.txt")
            If fileecx = True Then
                File.Delete(loc & "\Windows\Temp\update6_0.txt")
            End If
        Catch ex As Exception

        End Try
        Try
            'Check the internet connection is available
            Dim status = IsConnectionAvailable()
            'If Internet Connection is available then execute the following args
            If status = "Connected" Then
                'Download the File from internet to check the update
                My.Computer.Network.DownloadFile("http://www.weebly.com/uploads/4/6/0/9/4609554/update6_0.txt", "C:\Windows\Temp\update6_0.txt")
                Dim updt = My.Computer.FileSystem.ReadAllText(loc & "\Windows\Temp\update6_0.txt")
                'Check the version number is above the version in updatefile
                If updt > "8.0" Then
                    'If the version number is above the version in the update ask the user that he/she want to go to the website and download the latest version
                    If MsgBox("Update available " & vbNewLine & "Do you want to go to download page now ?", MsgBoxStyle.YesNo + vbQuestion, "Please Confirm") = MsgBoxResult.Yes Then
                        Process.Start("http://arvinsoft.weebly.com/sys-information.html")
                        'After the user select yes in the message box then delete the update file in the temp folder
                        My.Computer.FileSystem.DeleteFile(loc & "\Windows\Temp\update6_0.txt")
                        Return "Update available"
                    Else
                        Return "Update available"
                        'After the user select no in the message box then delete the update file in the temp folder
                        My.Computer.FileSystem.DeleteFile(loc & "\Windows\Temp\update6_0.txt")
                    End If
                Else
                    'If the Version in the update file is same or lower then the version mentioned the display the message that he/she using the latest version
                    'MsgBox("You are using the latest version of the software")
                    My.Computer.FileSystem.DeleteFile(loc & "\Windows\Temp\update6_0.txt")
                    'Return "This Version is Up to date"
                    'MsgBox("Version Up to date", MsgBoxStyle.Information + vbOKOnly, "Information")
                    'Delete the update file in the temp folder after showing the message
                    Return "Version up to date"
                End If
                'If Internet is not connected then show the error message that "error connecting to internet"
            ElseIf status = "Not Connected" Then
                ' MsgBox("Error connecting to internet. Please check your internet connection", MsgBoxStyle.OkOnly + vbCritical, "Error")
                Return "Error connecting server"
            End If
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
            'MsgBox("Sorry update information cannot be downloaded" & vbNewLine & "Some error occurred", MsgBoxStyle.Critical)
        End Try
        Return Nothing
    End Function
    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).

    End Sub
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub AboutBox_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub AboutBox_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        'setAD()
        If lblupdatestat.Text <> "" Then
            lblupdatestat.Text = ""
        End If
        Button1.Enabled = False
        picerror.Visible = False
        PicUptodate.Visible = False
        Button1.Text = "Checking For Updates"
        If BgWrkChkFrUpdates.IsBusy = False Then
            BgWrkChkFrUpdates.RunWorkerAsync()
        End If
    End Sub
    Dim texd
    Private Sub BgWrkChkFrUpdates_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWrkChkFrUpdates.DoWork
        texd = CheckForUpdates()
    End Sub

    Private Sub BgWrkChkFrUpdates_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgWrkChkFrUpdates.RunWorkerCompleted
        Button1.Enabled = True
        Button1.Text = "Check For Updates"
        lblupdatestat.Text = texd
        If texd = "Version up to date" Then
            picerror.Visible = False
            PicUptodate.Visible = True
        Else
            picerror.Visible = True
            PicUptodate.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If BgWrkChkFrUpdates.IsBusy = False Then
            BgWrkChkFrUpdates.RunWorkerAsync()
            Button1.Enabled = False
            picerror.Visible = False
            lblupdatestat.Text = ""
            Button1.Text = "Checking For Updates"
        Else
            MsgBox("Update Check is already in Progress")
        End If
    End Sub

    
    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click
        Process.Start("http://www.arvinsoft.weebly.com")
    End Sub

    Private Sub picSoft_Click(sender As System.Object, e As System.EventArgs) Handles picSoft.Click
        Process.Start("http://www.arvinsoft.weebly.com/sys-information.html")
    End Sub

    Private Sub picSoft_MouseEnter(sender As Object, e As System.EventArgs) Handles picSoft.MouseEnter
        picSoft.Width = picSoft.Width + 1
        picSoft.Height = picSoft.Height + 1
    End Sub

   
    Private Sub picSoft_MouseLeave(sender As Object, e As System.EventArgs) Handles picSoft.MouseLeave
        picSoft.Width = picSoft.Width - 1
        picSoft.Height = picSoft.Height - 1
    End Sub
End Class
