<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StorageDevices
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StorageDevices))
        Me.lstHrdDev = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstRemoDev = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstDVDDrives = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BgWrkTemp = New System.ComponentModel.BackgroundWorker()
        Me.tmrTemp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRemDrive = New System.Windows.Forms.Timer(Me.components)
        Me.BgWrkPart = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRem = New System.Windows.Forms.Label()
        Me.lblCD = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.picCD = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmrPart = New System.Windows.Forms.Timer(Me.components)
        Me.tltpshow = New System.Windows.Forms.ToolTip(Me.components)
        Me.bttnHrdAdv = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstHrdDev
        '
        Me.lstHrdDev.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstHrdDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHrdDev.FullRowSelect = True
        Me.lstHrdDev.Location = New System.Drawing.Point(47, 41)
        Me.lstHrdDev.Name = "lstHrdDev"
        Me.lstHrdDev.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstHrdDev.Size = New System.Drawing.Size(442, 99)
        Me.lstHrdDev.TabIndex = 1
        Me.lstHrdDev.UseCompatibleStateImageBehavior = False
        Me.lstHrdDev.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Harddisk name"
        Me.ColumnHeader1.Width = 198
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size (actual/usable)"
        Me.ColumnHeader2.Width = 123
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Temperature"
        Me.ColumnHeader3.Width = 103
        '
        'lstRemoDev
        '
        Me.lstRemoDev.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstRemoDev.FullRowSelect = True
        Me.lstRemoDev.Location = New System.Drawing.Point(49, 295)
        Me.lstRemoDev.Name = "lstRemoDev"
        Me.lstRemoDev.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstRemoDev.Size = New System.Drawing.Size(442, 97)
        Me.lstRemoDev.TabIndex = 72
        Me.lstRemoDev.UseCompatibleStateImageBehavior = False
        Me.lstRemoDev.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Device Name"
        Me.ColumnHeader4.Width = 303
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Size (actual/usable)"
        Me.ColumnHeader5.Width = 115
        '
        'lstDVDDrives
        '
        Me.lstDVDDrives.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader13})
        Me.lstDVDDrives.FullRowSelect = True
        Me.lstDVDDrives.Location = New System.Drawing.Point(47, 177)
        Me.lstDVDDrives.Name = "lstDVDDrives"
        Me.lstDVDDrives.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstDVDDrives.Size = New System.Drawing.Size(443, 83)
        Me.lstDVDDrives.TabIndex = 73
        Me.lstDVDDrives.UseCompatibleStateImageBehavior = False
        Me.lstDVDDrives.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Device Name"
        Me.ColumnHeader6.Width = 229
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Device Letter"
        Me.ColumnHeader7.Width = 77
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Device Type"
        Me.ColumnHeader13.Width = 116
        '
        'BgWrkTemp
        '
        '
        'tmrTemp
        '
        Me.tmrTemp.Interval = 20000
        '
        'tmrRemDrive
        '
        Me.tmrRemDrive.Interval = 10000
        '
        'BgWrkPart
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(32, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Harddisk"
        '
        'lblRem
        '
        Me.lblRem.AutoSize = True
        Me.lblRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRem.ForeColor = System.Drawing.Color.Maroon
        Me.lblRem.Location = New System.Drawing.Point(32, 272)
        Me.lblRem.Name = "lblRem"
        Me.lblRem.Size = New System.Drawing.Size(114, 15)
        Me.lblRem.TabIndex = 107
        Me.lblRem.Text = "Removable devices"
        '
        'lblCD
        '
        Me.lblCD.AutoSize = True
        Me.lblCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCD.ForeColor = System.Drawing.Color.Maroon
        Me.lblCD.Location = New System.Drawing.Point(32, 146)
        Me.lblCD.Name = "lblCD"
        Me.lblCD.Size = New System.Drawing.Size(83, 15)
        Me.lblCD.TabIndex = 109
        Me.lblCD.Text = "CD/DVD Drive"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(542, 451)
        Me.TabControl1.TabIndex = 111
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.picCD)
        Me.TabPage1.Controls.Add(Me.lstHrdDev)
        Me.TabPage1.Controls.Add(Me.lblCD)
        Me.TabPage1.Controls.Add(Me.lstDVDDrives)
        Me.TabPage1.Controls.Add(Me.lblRem)
        Me.TabPage1.Controls.Add(Me.lstRemoDev)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(534, 425)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Devices"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'picCD
        '
        Me.picCD.Image = CType(resources.GetObject("picCD.Image"), System.Drawing.Image)
        Me.picCD.Location = New System.Drawing.Point(5, 143)
        Me.picCD.Name = "picCD"
        Me.picCD.Size = New System.Drawing.Size(24, 24)
        Me.picCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCD.TabIndex = 110
        Me.picCD.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(534, 425)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Partitions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(39, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Partition"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 108
        Me.PictureBox2.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 56)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListView1.Size = New System.Drawing.Size(505, 351)
        Me.ListView1.TabIndex = 83
        Me.ListView1.TileSize = New System.Drawing.Size(1, 1)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Partition"
        Me.ColumnHeader8.Width = 61
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total Size"
        Me.ColumnHeader9.Width = 99
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Free Space"
        Me.ColumnHeader10.Width = 91
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Volume Serial"
        Me.ColumnHeader11.Width = 106
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "File System"
        Me.ColumnHeader12.Width = 104
        '
        'tmrPart
        '
        Me.tmrPart.Interval = 10000
        '
        'bttnHrdAdv
        '
        Me.bttnHrdAdv.BackColor = System.Drawing.Color.Transparent
        Me.bttnHrdAdv.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.bttnHrdAdv.FlatAppearance.BorderSize = 0
        Me.bttnHrdAdv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnHrdAdv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnHrdAdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnHrdAdv.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnHrdAdv.Image = CType(resources.GetObject("bttnHrdAdv.Image"), System.Drawing.Image)
        Me.bttnHrdAdv.Location = New System.Drawing.Point(511, 0)
        Me.bttnHrdAdv.Name = "bttnHrdAdv"
        Me.bttnHrdAdv.Size = New System.Drawing.Size(29, 25)
        Me.bttnHrdAdv.TabIndex = 115
        Me.tltpshow.SetToolTip(Me.bttnHrdAdv, "More Information")
        Me.bttnHrdAdv.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.bttnHrdAdv)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 25)
        Me.Panel1.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Storage Devices"
        '
        'StorageDevices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StorageDevices"
        Me.Size = New System.Drawing.Size(545, 485)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstHrdDev As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstRemoDev As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstDVDDrives As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BgWrkTemp As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrTemp As System.Windows.Forms.Timer
    Friend WithEvents tmrRemDrive As System.Windows.Forms.Timer
    Friend WithEvents BgWrkPart As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRem As System.Windows.Forms.Label
    Friend WithEvents picCD As System.Windows.Forms.PictureBox
    Friend WithEvents lblCD As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPart As System.Windows.Forms.Timer
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bttnHrdAdv As System.Windows.Forms.Button
    Friend WithEvents tltpshow As System.Windows.Forms.ToolTip

End Class
