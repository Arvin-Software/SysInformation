Imports System.Runtime.InteropServices

Public Class CrashBox

    Private Sub CrashBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Motherboard.ereror <> "" Then
            RichTextBox1.Text = RichTextBox1.Text & Motherboard.ereror
        End If
    End Sub
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        End
    End Sub

    Private Sub CrashBox_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Process.Start("http://arvinsoft.weebly.com/contact-us.html")
    End Sub
End Class