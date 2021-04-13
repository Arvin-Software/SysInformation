Imports System.Management

Public Class Networke
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Net()
    End Sub
    Public Sub Net()
        Try
            lstDNSServers.Items.Clear()
            Dim searcher As New ManagementObjectSearcher( _
                     "root\CIMV2", _
                     "SELECT * FROM Win32_NetworkAdapterConfiguration")

            For Each queryObj As ManagementObject In searcher.Get()
                If Convert.ToString(queryObj("IPConnectionMetric")) <> "" Then
                    lblNetNam.Text = queryObj("Description")
                    lblNetMacAdd.Text = queryObj("MACAddress")
                    lblNetDHCPEn.Text = queryObj("DHCPEnabled")
                    lblDHCPAdd.Text = queryObj("DHCPServer")
                    Dim add = queryObj("IPAddress")
                    For Each arrval As String In add
                        '  MsgBox(add(0))
                        lblIPAddress.Text = add(0)
                        lblIPV6Add.Text = add(1)
                        Exit For
                    Next
                    Dim arrDNSServerSearchOrder As String()
                    arrDNSServerSearchOrder = queryObj("DNSServerSearchOrder")
                    If queryObj("DNSServerSearchOrder") Is Nothing Then
                        'Console.WriteLine("DNSServerSearchOrder: {0}", queryObj("DNSServerSearchOrder"))
                    Else
                        For Each arrValue As String In arrDNSServerSearchOrder
                            lstDNSServers.Items.Add(arrValue)
                        Next
                    End If
                End If
            Next
            If lblNetNam.Text = "" Then
                'MsgBox("exe")
                TableLayoutPanel1.Visible = False
                Label1.Visible = False
                lstDNSServers.Visible = False
                lblNoInfo.Visible = True
                lblIPAddress.Visible = False
                lblAddr.Visible = False
                lblIPV6Add.Visible = False
                lblIPV6AddLabel.Visible = False
            Else
                TableLayoutPanel1.Visible = True
                Label1.Visible = True
                lstDNSServers.Visible = True
                lblNoInfo.Visible = False
                lblIPAddress.Visible = True
                lblAddr.Visible = True
                lblIPV6Add.Visible = True
                lblIPV6AddLabel.Visible = True
            End If
            If BGwrkrIP.IsBusy = False Then
                lblInt.Text = "Internet : Loading..."
                BGwrkrIP.RunWorkerAsync()
            End If
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
        


    Private Sub PicRefInt_Click(sender As System.Object, e As System.EventArgs) Handles PicRefInt.Click
        Net()
    End Sub

    Private Sub PicRefInt_MouseEnter(sender As Object, e As System.EventArgs) Handles PicRefInt.MouseEnter
        PicRefInt.Width = PicRefInt.Width + 2
        PicRefInt.Height = PicRefInt.Height + 2
    End Sub

    Private Sub PicRefInt_MouseLeave(sender As Object, e As System.EventArgs) Handles PicRefInt.MouseLeave
        PicRefInt.Width = PicRefInt.Width - 2
        PicRefInt.Height = PicRefInt.Height - 2
    End Sub
    Delegate Sub setcon(ByVal [text] As String)
    Private Sub stcon(ByVal [text] As String)
        If lblInt.InvokeRequired = True Then
            Dim d As New setcon(AddressOf stcon)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblInt.Text = [text]
        End If
    End Sub
    Delegate Sub setvis(ByVal [bo] As Boolean)
    Private Sub stvs(ByVal [bo] As Boolean)
        If picCon.InvokeRequired = True Then
            Dim d As New setvis(AddressOf stvs)
            Me.Invoke(d, New Object() {[bo]})
        Else
            picCon.Visible = [bo]
        End If
    End Sub
    Private Sub BGwrkrIP_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGwrkrIP.DoWork
        Try
            If Misc.IsConnectionAvailable() = "Connected" Then
                'stvs(True)
                'setVisRef(False)

                'PicInt.Visible = True
                stcon("Internet : Connected")
                stvs(True)
            Else

                'PicInt.Visible = False
                stcon("Internet : Disconnected")
                stvs(False)
                'lblIP.Text = "IP :No data click to refresh"
            End If
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
End Class
