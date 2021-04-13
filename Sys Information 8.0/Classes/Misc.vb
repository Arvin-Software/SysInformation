Imports System.Net
Imports System.Text
Imports System.IO
Imports Microsoft.Win32

Public Class Misc
    Public Class HTTPGet
        Private request As HttpWebRequest
        Private response As HttpWebResponse

        Private m_responseBody As String
        Private m_escapedBody As String
        Private m_statusCode As Integer
        Private m_responseTime As Double

        Public ReadOnly Property ResponseBody() As String
            Get
                Return m_responseBody
            End Get
        End Property
        Public ReadOnly Property EscapedBody() As String
            Get
                Return GetEscapedBody()
            End Get
        End Property
        Public ReadOnly Property StatusCode() As Integer
            Get
                Return m_statusCode
            End Get
        End Property
        Public ReadOnly Property ResponseTime() As Double
            Get
                Return m_responseTime
            End Get
        End Property
        Public ReadOnly Property Headers() As String
            Get
                Return GetHeaders()
            End Get
        End Property
        Public ReadOnly Property StatusLine() As String
            Get
                Return GetStatusLine()
            End Get
        End Property



        Public Sub Requests(ByVal url As String)
            Dim timer As New Stopwatch()
            Dim respBody As New StringBuilder()

            Me.request = DirectCast(WebRequest.Create(url), HttpWebRequest)

            Try
                timer.Start()
                Me.response = DirectCast(Me.request.GetResponse(), HttpWebResponse)
                Dim buf As Byte() = New Byte(8191) {}
                Dim respStream As Stream = Me.response.GetResponseStream()
                Dim count As Integer = 0
                Do
                    count = respStream.Read(buf, 0, buf.Length)
                    If count <> 0 Then
                        respBody.Append(Encoding.ASCII.GetString(buf, 0, count))
                    End If
                Loop While count > 0
                timer.[Stop]()

                Me.m_responseBody = respBody.ToString()
                Me.m_statusCode = CInt(DirectCast(Me.response.StatusCode, HttpStatusCode))
                Me.m_responseTime = timer.ElapsedMilliseconds / 1000.0
            Catch ex As WebException
                Me.response = DirectCast(ex.Response, HttpWebResponse)
                Me.m_responseBody = "No Server Response"
                Me.m_escapedBody = "No Server Response"
                Me.m_responseTime = 0.0
            End Try
        End Sub



        Private Function GetEscapedBody() As String
            ' HTML escaped chars
            Dim escapedBody As String = m_responseBody
            escapedBody = escapedBody.Replace("&", "&amp;")
            escapedBody = escapedBody.Replace("<", "&lt;")
            escapedBody = escapedBody.Replace(">", "&gt;")
            escapedBody = escapedBody.Replace("'", "&apos;")
            escapedBody = escapedBody.Replace("""", "&quot;")
            Me.m_escapedBody = escapedBody

            Return escapedBody
        End Function



        Private Function GetHeaders() As String
            If response Is Nothing Then
                Return "No Server Response"
            Else
                Dim headers As New StringBuilder()
                For i As Integer = 0 To Me.response.Headers.Count - 1
                    headers.Append([String].Format("{0}: {1}" & vbLf, response.Headers.Keys(i), response.Headers(i)))
                Next

                Return headers.ToString()
            End If
        End Function



        Private Function GetStatusLine() As String
            If response Is Nothing Then
                Return "No Server Response"
            Else
                Return [String].Format("HTTP/{0} {1} {2}", response.ProtocolVersion, CInt(response.StatusCode), response.StatusDescription)
            End If
        End Function
    End Class
    Public Shared Function GetIPAddress()
        Dim req As New HTTPGet()
        req.Requests("http://checkip.dyndns.org")
        Dim a As String() = req.ResponseBody.Split(":"c)
        Dim a2 As String = a(1).Substring(1)
        Dim a3 As String() = a2.Split("<"c)
        Dim a4 As String = a3(0)
        'Console.WriteLine(a4)
        'MsgBox(a4)
        Return a4
        'Console.ReadLine()
    End Function
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
End Class

Public Class InstalledSoftwaresd
    Public Shared countsx As Integer = 0
    Public Shared Function GetInstalledProgramsonline(ByVal slst As ListView, ByVal imgLst As ImageList)
        'Dim countsx As Integer = 0
        countsx = 0
        imgLst.Images.Clear()
        Try
            Using uninstalled As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
                For Each sbKeyName As String In uninstalled.GetSubKeyNames()
                    Using key As RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                        Dim dunstr As String = Convert.ToString(key.GetValue("UninstallString"))
                        If dunstr <> "" Then
                            Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                            If inssiz <> "" Then
                                Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                                Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                                Dim dmanu As String = Convert.ToString(key.GetValue("Publisher"))
                                Dim dIcon As String = Convert.ToString(key.GetValue("DisplayIcon"))
                                'Dim dinst As String = Convert.ToString(key.GetValue("InstallDate"))
                                If Not String.IsNullOrEmpty(dname) Then
                                    If dIcon <> "" Then
                                        'MsgBox(dname & " " & dIcon)
                                        Dim nm
                                        If dIcon.EndsWith(0) = True Then
                                            Dim nmln = dIcon.Length()
                                            nm = dIcon.Remove(nmln - 2, 2)
                                        Else
                                            nm = dIcon
                                        End If
                                        If File.Exists(nm) = True Then
                                            'MsgBox(dname & " " & nm)
                                            imgLst.Images.Add(Icon.ExtractAssociatedIcon(nm))
                                        Else
                                            imgLst.Images.Add(My.Resources._1419209182_system_installer_32)
                                        End If
                                    Else
                                        imgLst.Images.Add(My.Resources._1419209182_system_installer_32)
                                    End If
                                    slst.Items.Add(dname, countsx)
                                    If dvers <> "" Then
                                        slst.Items(countsx).SubItems.Add(dvers)
                                    Else
                                        slst.Items(countsx).SubItems.Add("(No Information)")
                                    End If
                                    'slst.Items(countsx).SubItems.Add(dinst)
                                    If dmanu <> "" Then
                                        slst.Items(countsx).SubItems.Add(dmanu)
                                    Else
                                        slst.Items(countsx).SubItems.Add("(No Information)")
                                    End If
                                    countsx += 1
                                End If
                            End If
                        End If
                    End Using
                Next
            End Using
            'MsgBox(countsx)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing

    End Function
    Public Shared Function GetInstalledProgramson64bit(ByVal slst As ListView, ByVal imgLst As ImageList)
        Try
            Using uninstalled64 As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall", False)
                For Each sbKeyName As String In uninstalled64.GetSubKeyNames()
                    Using key As RegistryKey = uninstalled64.OpenSubKey(sbKeyName)
                        Dim dunstr As String = Convert.ToString(key.GetValue("UninstallString"))
                        If dunstr <> "" Then
                            Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                            If inssiz <> "" Then
                                Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                                Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                                Dim dmanu As String = Convert.ToString(key.GetValue("Publisher"))
                                Dim dIcon As String = Convert.ToString(key.GetValue("DisplayIcon"))
                                If Not String.IsNullOrEmpty(dname) Then
                                    If dIcon <> "" Then
                                        If File.Exists(dIcon) = True Then
                                            imgLst.Images.Add(Icon.ExtractAssociatedIcon(dIcon))
                                        Else
                                            imgLst.Images.Add(My.Resources._1419209182_system_installer_32)
                                        End If
                                    Else
                                        imgLst.Images.Add(My.Resources._1419209182_system_installer_32)
                                    End If
                                    slst.Items.Add(dname, countsx)
                                    slst.Items(countsx).SubItems.Add(dvers)
                                    slst.Items(countsx).SubItems.Add(dmanu)
                                    countsx += 1
                                End If
                            End If
                        End If
                    End Using
                Next
            End Using
            ' MsgBox(countsx)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing

    End Function
End Class