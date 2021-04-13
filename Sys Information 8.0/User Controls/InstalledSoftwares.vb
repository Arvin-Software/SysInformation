Imports Microsoft.Win32
Imports System.Management
Imports enumSoftware

Public Class InstalledSoftwares
    Public Function RemoveDuplicates(ByVal lstView As ListView) As Boolean
        Dim itemI As ListViewItem
        Dim itemJ As ListViewItem
        Dim progress As Integer
        Dim count As Integer
        Dim ProgressDupCounter As Integer = lstView.Items.Count
        For i As Integer = lstView.Items.Count - 1 To 0 Step -1
            itemI = lstView.Items(i)
            progress = progress + 1
            ' start one after hence +1
            For z As Integer = i + 1 To lstView.Items.Count - 1 Step 1
                itemJ = lstView.Items(z)
                If itemI.Text = itemJ.Text Then
                    'duplicate found, now delete duplicate
                    lstView.Items.Remove(itemJ)
                    count = count + 1
                    Exit For
                End If
            Next z
        Next (i)
        Return Nothing
    End Function
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler ProgramsLvw.ColumnClick, AddressOf Me.ProgramsLvw_ColumnClick
        'EnumerateStartupPro(lststartup)
        If os.getOsBitness = "32" Then
            'Softwares.GetInstalledPrograms(ProgramsLvw)
            InstalledSoftwaresd.GetInstalledProgramsonline(ProgramsLvw, ImageList1)
            'HiddenSoftwares.GetHiddenInstalledPrograms(ProgramsLvw)
            RemoveDuplicates(ProgramsLvw)
            lblNoOfSoft.Text = ProgramsLvw.Items.Count.ToString
        ElseIf os.getOsBitness = "64" Then
            'Softwares.GetInstalledProgramson64bit(ProgramsLvw)
            InstalledSoftwaresd.GetInstalledProgramson64bit(ProgramsLvw, ImageList1)
            'HiddenSoftwares.GetHiddenInstalledPrograms64(ProgramsLvw)
            RemoveDuplicates(ProgramsLvw)
            lblNoOfSoft.Text = ProgramsLvw.Items.Count.ToString
        Else
            Softwares.GetInstalledPrograms(ProgramsLvw)
            lblNoOfSoft.Text = ProgramsLvw.Items.Count
            RemoveDuplicates(ProgramsLvw)
        End If
        Proc()
        lblNoOfPro.Text = lstproc.Items.Count().ToString
        sortd()
        ' Button1.Visible = False
        Sort()
    End Sub
    Public Shared Function EnumerateStartupPro(ByVal lstStrPro As ListView)
        lstStrPro.Items.Clear()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_StartupCommand")

            For Each queryObj As ManagementObject In searcher.Get()
                lstStrPro.Items.Add(queryObj("Caption"))
                lstStrPro.Items(sist).SubItems.Add(queryObj("command"))
                lstStrPro.Items(sist).SubItems.Add(queryObj("user"))
                sist += 1
            Next
        Catch err As ManagementException
            'MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Motherboard.ereror = err.ToString
            CrashBox.ShowDialog()
        End Try
        Return Nothing
    End Function
    Private Sub Software_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If os.getOsBitness = "32" Then
            Softwares.UninstallSoftwares(ProgramsLvw)
        ElseIf os.getOsBitness = "64" Then
            Softwares.UninstallSoftwares64bit(ProgramsLvw)
            'HiddenSoftwares.UninstallHiddenSoftwares64(ProgramsLvw)
            'Softwares.UninstallSoftwares(ProgramsLvw)
            'HiddenSoftwares.UninstallHiddenSoftwares(ProgramsLvw)
        Else
            Softwares.UninstallSoftwares(ProgramsLvw)
        End If
    End Sub
    Class listviewitemcomparer
        Implements IComparer
        Private col As Integer
        Public Sub New()
            col = 0
        End Sub
        Public Sub New(ByVal column As Integer)
            col = column
        End Sub
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim returnval As Integer = -1
            returnval = [String].Compare(CType(x,  _
                        ListViewItem).SubItems(col).Text, _
                        CType(y, ListViewItem).SubItems(col).Text)
            Return returnval
        End Function
    End Class
    Dim sortColumn As Integer = -1
    Private Sub ProgramsLvw_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ProgramsLvw.ColumnClick
        Me.ProgramsLvw.ListViewItemSorter = New listviewitemcomparer(e.Column)
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            ProgramsLvw.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If ProgramsLvw.Sorting = SortOrder.Ascending Then
                ProgramsLvw.Sorting = SortOrder.Descending
            Else
                ProgramsLvw.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        ProgramsLvw.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        'ProgramsLvw.ListViewItemSorter = New listviewitemcomparer(e.Column, ProgramsLvw.Sorting)
        'MsgBox(e.ToString)
    End Sub
    Public Sub Sort()
        'sortColumn = -1
        'ProgramsLvw.Sorting = SortOrder.Ascending
        Dim args = New ColumnClickEventArgs(0)
        ProgramsLvw_ColumnClick(Nothing, args)

    End Sub

    'Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
    '    ProgramsLvw.Sorting = SortOrder.None
    '    ProgramsLvw.Items.Clear()
    '    If os.getOsBitness = "32" Then
    '        Softwares.GetInstalledPrograms(ProgramsLvw)
    '        RemoveDuplicates(ProgramsLvw)
    '        lblNoOfSoft.Text = ProgramsLvw.Items.Count.ToString

    '    ElseIf os.getOsBitness = "64" Then
    '        Softwares.GetInstalledProgramson64bit(ProgramsLvw)
    '        RemoveDuplicates(ProgramsLvw)
    '        lblNoOfSoft.Text = ProgramsLvw.Items.Count.ToString
    '    Else
    '        Softwares.GetInstalledPrograms(ProgramsLvw)
    '        lblNoOfSoft.Text = ProgramsLvw.Items.Count
    '    End If
    '    Sort()
    'End Sub

    Private Sub bttnRefreshSoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRefreshSoft.Click
        InstalledSoftwaresd.countsx = 0
        ProgramsLvw.Sorting = SortOrder.None
        ProgramsLvw.Items.Clear()
        ImageList1.Images.Clear()
        ProgramsLvw.Visible = False
        If os.getOsBitness = "32" Then
            'Softwares.GetInstalledPrograms(ProgramsLvw)
            InstalledSoftwaresd.GetInstalledProgramsonline(ProgramsLvw, ImageList1)
            RemoveDuplicates(ProgramsLvw)
            lblNoOfSoft.Text = ProgramsLvw.Items.Count.ToString

        ElseIf os.getOsBitness = "64" Then

            'Softwares.GetInstalledProgramson64bit(ProgramsLvw)
            InstalledSoftwaresd.GetInstalledProgramson64bit(ProgramsLvw, ImageList1)
            RemoveDuplicates(ProgramsLvw)
            lblNoOfSoft.Text = ProgramsLvw.Items.Count.ToString
        Else
            Softwares.GetInstalledPrograms(ProgramsLvw)
            lblNoOfSoft.Text = ProgramsLvw.Items.Count
        End If
        Sort()
        ProgramsLvw.Visible = True
    End Sub
    Public Shared Function EnumerateProcess(ByVal lstProName As ListView)
        lstProName.Items.Clear()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")

            For Each queryObj As ManagementObject In searcher.Get()
                Dim name = queryObj("Caption")
                If name <> "wininit.exe" And name <> "System Idle Process" Then
                    lstProName.Items.Add(queryObj("Caption"))
                    lstProName.Items(sist).SubItems.Add(queryObj("ProcessId"))
                    lstProName.Items(sist).SubItems.Add(queryObj("PageFileUsage"))
                    sist += 1
                End If
            Next
        Catch err As ManagementException
            ' MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Motherboard.ereror = err.ToString
            CrashBox.ShowDialog()
        End Try
        Return Nothing
    End Function
    Public Shared Function EnumerateServices(ByVal lstservices As ListView)
        Dim sst As Integer = 0
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Service")
            For Each queryObj As ManagementObject In searcher.Get()
                lstservices.Items.Add(queryObj("name"))
                lstservices.Items(sst).SubItems.Add(queryObj("processid"))
                lstservices.Items(sst).SubItems.Add(queryObj("DisplayName"))
                lstservices.Items(sst).SubItems.Add(queryObj("state"))
                sst += 1
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
        Return Nothing
    End Function
   
    Public Sub Proc()
        EnumerateProcess(lstproc)
        EnumerateServices(lstServ)
    End Sub
    Dim sortcolumnd As Integer = -1
    
    Public Sub sortd()
        Dim args = New ColumnClickEventArgs(0)
        lstproc_ColumnClick(Nothing, args)
    End Sub
    Class listviewitemdcomparer
        Implements IComparer
        Private col As Integer
        Public Sub New()
            col = 0
        End Sub
        Public Sub New(ByVal column As Integer)
            col = column
        End Sub
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim returnval As Integer = -1
            returnval = [String].Compare(CType(x,  _
                        ListViewItem).SubItems(col).Text, _
                        CType(y, ListViewItem).SubItems(col).Text)
            Return returnval
        End Function
    End Class

    Private Sub lstproc_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lstproc.ColumnClick
        Me.lstproc.ListViewItemSorter = New listviewitemdcomparer(e.Column)
        If e.Column <> sortcolumnd Then
            ' Set the sort column to the new column.
            sortcolumnd = e.Column
            ' Set the sort order to ascending by default.
            lstproc.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If lstproc.Sorting = SortOrder.Ascending Then
                lstproc.Sorting = SortOrder.Descending
            Else
                lstproc.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        lstproc.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        'ProgramsLvw.ListViewItemSorter = New listviewitemcomparer(e.Column, ProgramsLvw.Sorting)
        ' MsgBox(e.ToString)
    End Sub

    Private Sub lstproc_DoubleClick(sender As Object, e As System.EventArgs) Handles lstproc.DoubleClick
        lstproc.Sorting = SortOrder.None
        lstproc.Visible = False
        'DoubleClickEndProcess(lstproc)
        EnumerateProcess(lstproc)
        sortd()
        lstproc.Visible = True
        lblNoOfPro.Text = lstproc.Items.Count().ToString
    End Sub
    Public Shared Function EndProcess(ByVal lstprocesse As ListView)
        Dim i As Integer
        For i = 0 To lstprocesse.SelectedItems.Count = i
            Dim retrun
            retrun = lstprocesse.SelectedItems(i).Text
            Try
                Dim sist As Integer = 0
                Dim searcher As New ManagementObjectSearcher( _
                    "root\CIMV2", _
                    "SELECT * FROM Win32_Process")
                For Each queryObj As ManagementObject In searcher.Get()
                    Try
                        Dim lstprocess = queryObj("Caption")
                        Dim lstid = queryObj("ProcessId")
                        If lstprocess = retrun Then
                            Dim p As Process = Process.GetProcessById(lstid)
                            Try
                                p.Kill()
                            Catch ex As Exception
                                MsgBox("Sorry Process Cannot be ended", MsgBoxStyle.OkOnly + vbCritical)
                            End Try
                        End If
                    Catch ex As Exception
                    End Try
                Next
            Catch err As ManagementException
                'MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
                Motherboard.ereror = err.ToString
                CrashBox.ShowDialog()
            End Try
        Next
        Return Nothing
    End Function
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        EndProcess(lstproc)
    End Sub
End Class
