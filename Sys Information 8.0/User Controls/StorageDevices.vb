Imports System.Management

Public Class StorageDevices
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        storagedeices()
        listPartitionwithsize()
    End Sub
    Public Sub listPartitionwithsize()
        Try
            Dim count As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_LogicalDisk")
            For Each queryObj As ManagementObject In searcher.Get
                ListView1.Items.Add(queryObj("Caption"))
                ListView1.Items(count).SubItems.Add(Math.Round(queryObj("Size") / 1024 / 1024 / 1024, 2) & " GB")
                ListView1.Items(count).SubItems.Add(Math.Round(queryObj("FreeSpace") / 1024 / 1024 / 1024, 2) & " GB")

                If queryObj("VolumeSerialNumber") <> "" Then
                    ListView1.Items(count).SubItems.Add(queryObj("VolumeSerialNumber"))
                Else
                    ListView1.Items(count).SubItems.Add("No Info")
                End If
                If queryObj("FileSystem") <> "" Then
                    ListView1.Items(count).SubItems.Add(queryObj("FileSystem"))
                Else
                    ListView1.Items(count).SubItems.Add("No Info")
                End If
                count += 1
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Public Shared storagenm As String
    Public Shared storagesp As String
    Public Shared storagetemp As String
    Public Sub storagedeices()
        'tmrRemv.Enabled = True
        tmrTemp.Enabled = True
        tmrRemDrive.Enabled = True
        tmrPart.Enabled = True
        Dim count As Integer = 0
        Dim sount As Integer = -1
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
            For Each queryObj As ManagementObject In searcher.Get

                If queryObj("interfacetype") = "IDE" Then
                    lstHrdDev.Items.Add(queryObj("Caption"))
                    Dim actsize = Math.Round(queryObj("size") / 1024 / 1024 / 1024 * 1024 * 1024 * 1024 / 1000 / 1000 / 1000, 0) & " GB"
                    'MsgBox(queryObj("size"))
                    Dim usasize = Math.Round(queryObj("size") / 1024 / 1024 / 1024, 0) & " GB"
                    lstHrdDev.Items(count).SubItems.Add(actsize & " (" & usasize & ")")
                    storagenm = queryObj("caption")
                    storagesp = Math.Round(queryObj("size") / 1024 / 1024 / 1024, 0) & " GB"
                    count += 1
                End If

                If queryObj("interfacetype") = "USB" Then
                    lstRemoDev.Items.Add(queryObj("Caption"))
                    Dim actremsize = Math.Round(queryObj("size") / 1024 / 1024 / 1024 * 1024 * 1024 * 1024 / 1000 / 1000 / 1000, 0) & " GB"
                    Dim usaremsize = Math.Round(queryObj("size") / 1024 / 1024 / 1024, 2) & " GB"
                    lstRemoDev.Items(sount).SubItems.Add(actremsize & " (" & usaremsize & ")")
                End If
                sount += 1
            Next
            Dim fint As Integer = 0
            Dim fearcher As New ManagementObjectSearcher("root\CIMV2", " SELECT * FROM Win32_CDROMDrive")
            For Each queryobj As ManagementObject In fearcher.Get
                lstDVDDrives.Items.Add(queryobj("Caption"))
                lstDVDDrives.Items(fint).SubItems.Add(queryobj("drive"))
                lstDVDDrives.Items(fint).SubItems.Add(queryobj("MediaType"))
                fint += 1
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
        Const TEMPERATURE_ATTRIBUTE As Byte = 194
        Dim ount As Integer = 0
        Dim dount As Integer = 0
        Try
            Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData")
            'loop through all the hard disks
            For Each queryObj As ManagementObject In searcher.[Get]()
                Dim arrVendorSpecific As Byte() = DirectCast(queryObj.GetPropertyValue("VendorSpecific"), Byte())
                'Find the temperature attribute
                Dim tempIndex As Integer = Array.IndexOf(arrVendorSpecific, TEMPERATURE_ATTRIBUTE)
                ' MsgBox(arrVendorSpecific(tempIndex + 5) & "ºC")
                lstHrdDev.Items(dount).SubItems.Add(arrVendorSpecific(tempIndex + 5) & ".0 º C")
                storagetemp = arrVendorSpecific(tempIndex + 5) & ".0 º C"

                ount += 1
                dount += 1
            Next
        Catch err As ManagementException
            'Motherboard.ereror = err.ToString
            'CrashBox.ShowDialog()
            'MsgBox("An error occurred while querying for WMI data: " + err.Message)
        End Try
    End Sub

    Public Sub AddHrd()
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
            'lstHrdDev.Items.Clear()
            'For i = 0 To 0
            Dim count = 0
            For Each queryObj As ManagementObject In searcher.Get
                Dim ids As New ListViewItem
                If queryObj("interfacetype") = "IDE" Then
                    ids.Text = queryObj("Caption").ToString
                    Dim actsize = (Math.Round(queryObj("size") / 1024 / 1024 / 1024 * 1024 * 1024 * 1024 / 1000 / 1000 / 1000, 0) & " GB")
                    Dim usasize = (Math.Round(queryObj("size") / 1024 / 1024 / 1024, 0) & " GB")
                    ids.SubItems.Add(actsize & " (" & usasize & ")")
                    storagenm = queryObj("caption")
                    storagesp = Math.Round(queryObj("size") / 1024 / 1024 / 1024, 0) & " Gb"
                    count += 1
                End If

                Dim fint As Integer = 0
                Const TEMPERATURE_ATTRIBUTE As Byte = 194
                Dim searcherd As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData")
                'loop through all the hard disks
                For Each queryObjd As ManagementObject In searcherd.[Get]()
                    Dim arrVendorSpecific As Byte() = DirectCast(queryObjd.GetPropertyValue("VendorSpecific"), Byte())
                    'Find the temperature attribute
                    Dim tempIndex As Integer = Array.IndexOf(arrVendorSpecific, TEMPERATURE_ATTRIBUTE)
                    ' MsgBox(arrVendorSpecific(tempIndex + 5) & "ºC")
                    If arrVendorSpecific(tempIndex + 5) <> 0 Then
                        ids.SubItems.Add(arrVendorSpecific(tempIndex + 5) & ".0 º C")
                    Else
                        ids.SubItems.Add("No data")
                    End If
                    ids.SubItems.Add(arrVendorSpecific(tempIndex + 5) & ".0 º C")
                    storagetemp = arrVendorSpecific(tempIndex + 5) & ".0 º C"

                    'ount += 1
                    'dount += 1
                Next
                AddListViewItem(ids)
                Exit For
            Next
        Catch ex As Exception
            'Motherboard.ereror = ex.ToString
            'CrashBox.ShowDialog()
        End Try
    End Sub
    Public Sub AddPart()
        Try
            Dim count As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_LogicalDisk")
            For Each queryObj As ManagementObject In searcher.Get
                Dim isd As New ListViewItem
                isd.Text = (queryObj("Caption"))
                isd.SubItems.Add(Math.Round(queryObj("Size") / 1024 / 1024 / 1024, 2) & " GB")
                isd.SubItems.Add(Math.Round(queryObj("FreeSpace") / 1024 / 1024 / 1024, 2) & " GB")

                If queryObj("VolumeSerialNumber") <> "" Then
                    isd.SubItems.Add(queryObj("VolumeSerialNumber"))
                Else
                    isd.SubItems.Add("No Info")
                End If
                If queryObj("FileSystem") <> "" Then
                    isd.SubItems.Add(queryObj("FileSystem"))
                Else
                    isd.SubItems.Add("No Info")
                End If
                AddListView(isd)
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub
    Private Delegate Sub AddListViewItemDelegate(adg As ListViewItem)
    Private Sub AddListViewItem(adg As ListViewItem)
        If Me.InvokeRequired Then
            Dim del As New AddListViewItemDelegate(AddressOf AddListViewItem)
            Me.Invoke(del, New Object() {adg})
        Else
            lstHrdDev.Items.Add(adg)
        End If
    End Sub
    Private Delegate Sub AddListViewDelegate(ad As ListViewItem)
    Private Sub AddListView(ad As ListViewItem)
        If Me.InvokeRequired Then
            Dim dle As New AddListViewDelegate(AddressOf AddListView)
            Me.Invoke(dle, New Object() {ad})
        Else
            ListView1.Items.Add(ad)
        End If
    End Sub
    Private Sub BgWrkTemp_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWrkTemp.DoWork
        'AddHrd()
    End Sub

    Private Sub tmrTemp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTemp.Tick
        If BgWrkTemp.IsBusy = False Then
            lstHrdDev.Items.Clear()
            BgWrkTemp.RunWorkerAsync()
        End If
    End Sub
    Public Sub AddRemDev()
        Try
            lstRemoDev.Items.Clear()
            Dim sount As Integer = -1
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
            For Each queryObj As ManagementObject In searcher.Get
                If queryObj("interfacetype") = "USB" Then
                    lstRemoDev.Items.Add(queryObj("caption"))
                    Dim actremsize = Math.Round(queryObj("size") / 1024 / 1024 / 1024 * 1024 * 1024 * 1024 / 1000 / 1000 / 1000, 0) & " GB"
                    Dim usaremsize = Math.Round(queryObj("size") / 1024 / 1024 / 1024, 2) & " GB"
                    lstRemoDev.Items(sount).SubItems.Add(actremsize & " (" & usaremsize & ")")
                End If
                sount += 1
            Next
        Catch ex As Exception
            Motherboard.ereror = ex.ToString
            CrashBox.ShowDialog()
        End Try
    End Sub

    
    Private Sub tmrRemDrive_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRemDrive.Tick
        AddRemDev()
    End Sub

    Private Sub BgWrkPart_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWrkPart.DoWork
        AddPart()
    End Sub

    Private Sub tmrPart_Tick(sender As System.Object, e As System.EventArgs) Handles tmrPart.Tick
        If BgWrkPart.IsBusy = False Then
            ListView1.Items.Clear()
            BgWrkPart.RunWorkerAsync()
        End If
    End Sub

    Private Sub bttnHrdAdv_Click(sender As System.Object, e As System.EventArgs) Handles bttnHrdAdv.Click
        HrdDiskAdv.ShowDialog()
    End Sub
End Class
