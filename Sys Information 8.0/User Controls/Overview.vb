Imports System.Management

Public Class Overview
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Inin()
    End Sub
    Public Sub GraphicCardd()
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Availability") = 3 Then
                    '    CmboGraphicCrd.Items.Add(queryObj("Caption"))
                    '    CmboGraphicCrd.Text = queryObj("Caption")
                    'Else
                    '    CmboGraphicCrd.Items.Add(queryObj("Caption"))
                    lblGraphicCrd.Text = "Graphic Card : " & queryObj("Caption")
                    'CmboGraphicCrd.Text = queryObj("Caption")
                End If
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Public Sub Inin()
        Try
            Dim objWMI As New clsWMI
            With objWMI
                If .OperServicePack <> "" Then
                    lblOsName.Text = My.Computer.Info.OSFullName & "- " & .OperServicePack
                Else
                    lblOsName.Text = My.Computer.Info.OSFullName
                End If
            End With
            lblOsVers.Text = "Version : " & My.Computer.Info.OSVersion
            Dim dlsWMI As New clsWMI
            With dlsWMI
                lblOsManu.Text = "Manufacturer : " & .OperManufac
                lblMotherbrd.Text = "Motherboard : " & .MoProduct
                lblProce.Text = "Processor : " & .ProcessorName
                'lblGraphicCrd.Text = "Graphic Card : " & .VideoNm
                GraphicCardd()
            End With
            Dim installedCapacity As Long
            Dim slotCount As Integer
            Dim memorySize As Long
            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory WHERE Capacity > 0")
            Dim queryCollection As ManagementObjectCollection = query.Get()
            For Each mo As ManagementObject In queryCollection
                slotCount += 1
                memorySize = CLng(mo("Capacity"))

                installedCapacity += memorySize
                'MsgBox(installedCapacity)
                Dim totalMem As Long = installedCapacity
                totalMem = Math.Round(totalMem / 1024 / 1024 / 1024, 0)
                Dim avlMem = Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024, 2)
                lblRAM.Text = "RAM : " & totalMem.ToString & " GB" & " ( " & avlMem & " GB Usable ) "
            Next
            tmrCPU.Enabled = True
            tmrRM.Enabled = True
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub

    Private Sub tmrCPU_Tick(sender As System.Object, e As System.EventArgs) Handles tmrCPU.Tick
        ProgrProc.Value = perCPU.NextValue()
        If ProgrProc.Value < 10 Then
            lblProPer.Text = "Processor : 0" & ProgrProc.Value.ToString & " %"
        Else
            lblProPer.Text = "Processor : " & ProgrProc.Value.ToString & " %"
        End If
    End Sub

    Private Sub tmrRM_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRM.Tick
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
        lblRmUsg.Text = "RAM : " & sperus & " %"
        ProgrRAM.Value = sperus
    End Sub
    Dim dsount As Integer = 0
    Dim dount As Integer = 0
    Dim nount As Integer = 0
    Dim indta(100) As Single
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If BackgroundWorker1.IsBusy = False Then
            BackgroundWorker1.RunWorkerAsync()
        End If
        If dsount >= 100 Then
            'Graph1.Clear()
            'MsgBox("Cleared")
            'System.Threading.Thread.Sleep(100)
            Array.Clear(indta, 1, 100)
            dsount = 1
            indta(dount) = 0

        End If
        Dim i

        'ProgrProc.Value = PerfCntrProc.NextValue
        'lblProcPer.Text = "Processor : " e & " %"
        Dim vals = ProgrRAM.Value
        dount += 1
        'If count > 0 Then
        '    'indt(count - 1) += 0
        '    ' MsgBox(indt.GetValue(count - 1) & " count " & count - 1)
        'End If
        'For i = 0 To 10
        'Dim i = 0 + 1
        'MsgBox(i)

        'MsgBox(ProgrRAM.Value)
        indta(dsount) = ProgrRAM.Value
        'Array.Clear(indt, bount + 1, bount + 1)
        'Array.Clear(indt, count, count + 1)
        'Label1.Text += ProgressBar1.Value.ToString
        'Label1.Text += indt.GetValue(count).ToString & " "

        i = ProgrRAM.Value
        'System.Threading.Thread.Sleep(100)
        'MsgBox(i)
        dsount += 1
        nount += 1
        If dount = 1 Then
            Graph2.Values = indta
            dount = 0
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
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
    End Sub
    Dim scount = 0
    Dim sount = 0
    Dim bount = 0
    Dim indt(100) As Single
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If scount >= 100 Then
            'Graph1.Clear()
            'MsgBox("Cleared")
            'System.Threading.Thread.Sleep(100)
            Array.Clear(indt, 1, 100)
            scount = 1
            indt(sount) = 0

        End If
        Dim i

        'ProgrProc.Value = PerfCntrProc.NextValue
        ' lblProcPer.Text = "Processor : " & ProgrProc.Value & " %"
        Dim vals = ProgrProc.Value()
        sount += 1
        'If count > 0 Then
        '    'indt(count - 1) += 0
        '    ' MsgBox(indt.GetValue(count - 1) & " count " & count - 1)
        'End If
        'For i = 0 To 10
        'Dim i = 0 + 1
        'MsgBox(i)


        indt(scount) = ProgrProc.Value
        'Array.Clear(indt, bount + 1, bount + 1)
        'Array.Clear(indt, count, count + 1)
        'Label1.Text += ProgressBar1.Value.ToString
        'Label1.Text += indt.GetValue(count).ToString & " "

        i = ProgrProc.Value
        'System.Threading.Thread.Sleep(100)
        'MsgBox(i)
        scount += 1
        bount += 1
        If sount = 1 Then
            Graph1.Values = indt
            sount = 0
        End If
    End Sub
End Class
