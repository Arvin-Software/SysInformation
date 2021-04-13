<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Processor))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblL3CachSz = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblL2CachSz = New System.Windows.Forms.Label()
        Me.lblL1CachSz = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblProMaxClSpd = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProIden = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblProManu = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblProNm = New System.Windows.Forms.Label()
        Me.lblSockTyp = New System.Windows.Forms.Label()
        Me.perCPU = New System.Diagnostics.PerformanceCounter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tmrCPU = New System.Windows.Forms.Timer(Me.components)
        Me.lblThreads = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblProArc = New System.Windows.Forms.Label()
        Me.tmrProCurClckSpd = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblProCurClSpd = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblProVolt = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblProExtClSpd = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProNoOfCrs = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prCPU = New System.Windows.Forms.ProgressBar()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.perCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoEllipsis = True
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(4, 136)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 14)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "L3 Cache Size:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblL3CachSz
        '
        Me.lblL3CachSz.AutoEllipsis = True
        Me.lblL3CachSz.AutoSize = True
        Me.lblL3CachSz.BackColor = System.Drawing.Color.Transparent
        Me.lblL3CachSz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblL3CachSz.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL3CachSz.ForeColor = System.Drawing.Color.Black
        Me.lblL3CachSz.Location = New System.Drawing.Point(104, 136)
        Me.lblL3CachSz.Margin = New System.Windows.Forms.Padding(4)
        Me.lblL3CachSz.Name = "lblL3CachSz"
        Me.lblL3CachSz.Size = New System.Drawing.Size(23, 14)
        Me.lblL3CachSz.TabIndex = 44
        Me.lblL3CachSz.Text = "    "
        Me.lblL3CachSz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoEllipsis = True
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(4, 114)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 14)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "L2 Cache Size:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(270, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Clock Speeds"
        '
        'lblL2CachSz
        '
        Me.lblL2CachSz.AutoEllipsis = True
        Me.lblL2CachSz.AutoSize = True
        Me.lblL2CachSz.BackColor = System.Drawing.Color.Transparent
        Me.lblL2CachSz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblL2CachSz.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL2CachSz.ForeColor = System.Drawing.Color.Black
        Me.lblL2CachSz.Location = New System.Drawing.Point(104, 114)
        Me.lblL2CachSz.Margin = New System.Windows.Forms.Padding(4)
        Me.lblL2CachSz.Name = "lblL2CachSz"
        Me.lblL2CachSz.Size = New System.Drawing.Size(23, 14)
        Me.lblL2CachSz.TabIndex = 42
        Me.lblL2CachSz.Text = "    "
        Me.lblL2CachSz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblL1CachSz
        '
        Me.lblL1CachSz.AutoEllipsis = True
        Me.lblL1CachSz.AutoSize = True
        Me.lblL1CachSz.BackColor = System.Drawing.Color.Transparent
        Me.lblL1CachSz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblL1CachSz.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL1CachSz.ForeColor = System.Drawing.Color.Black
        Me.lblL1CachSz.Location = New System.Drawing.Point(104, 92)
        Me.lblL1CachSz.Margin = New System.Windows.Forms.Padding(4)
        Me.lblL1CachSz.Name = "lblL1CachSz"
        Me.lblL1CachSz.Size = New System.Drawing.Size(23, 14)
        Me.lblL1CachSz.TabIndex = 40
        Me.lblL1CachSz.Text = "    "
        Me.lblL1CachSz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(60, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 15)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "No of Cores, Threads, Caches, Usage,"
        '
        'Label16
        '
        Me.Label16.AutoEllipsis = True
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(4, 92)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 14)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "L1 Cache Size:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProMaxClSpd
        '
        Me.lblProMaxClSpd.AutoEllipsis = True
        Me.lblProMaxClSpd.AutoSize = True
        Me.lblProMaxClSpd.BackColor = System.Drawing.Color.Transparent
        Me.lblProMaxClSpd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProMaxClSpd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProMaxClSpd.ForeColor = System.Drawing.Color.Black
        Me.lblProMaxClSpd.Location = New System.Drawing.Point(105, 26)
        Me.lblProMaxClSpd.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProMaxClSpd.Name = "lblProMaxClSpd"
        Me.lblProMaxClSpd.Size = New System.Drawing.Size(23, 14)
        Me.lblProMaxClSpd.TabIndex = 35
        Me.lblProMaxClSpd.Text = "    "
        Me.lblProMaxClSpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(60, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Processor"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblProIden, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblProManu, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblProNm, 1, 1)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(89, 85)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(115, 66)
        Me.TableLayoutPanel2.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Identifier:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProIden
        '
        Me.lblProIden.AutoEllipsis = True
        Me.lblProIden.AutoSize = True
        Me.lblProIden.BackColor = System.Drawing.Color.Transparent
        Me.lblProIden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProIden.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProIden.ForeColor = System.Drawing.Color.Black
        Me.lblProIden.Location = New System.Drawing.Point(88, 48)
        Me.lblProIden.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProIden.Name = "lblProIden"
        Me.lblProIden.Size = New System.Drawing.Size(23, 14)
        Me.lblProIden.TabIndex = 36
        Me.lblProIden.Text = "    "
        Me.lblProIden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 14)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Manufacturer:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProManu
        '
        Me.lblProManu.AutoEllipsis = True
        Me.lblProManu.AutoSize = True
        Me.lblProManu.BackColor = System.Drawing.Color.Transparent
        Me.lblProManu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProManu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProManu.ForeColor = System.Drawing.Color.Black
        Me.lblProManu.Location = New System.Drawing.Point(88, 4)
        Me.lblProManu.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProManu.Name = "lblProManu"
        Me.lblProManu.Size = New System.Drawing.Size(23, 14)
        Me.lblProManu.TabIndex = 29
        Me.lblProManu.Text = "    "
        Me.lblProManu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(4, 26)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 14)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Processor:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProNm
        '
        Me.lblProNm.AutoEllipsis = True
        Me.lblProNm.AutoSize = True
        Me.lblProNm.BackColor = System.Drawing.Color.Transparent
        Me.lblProNm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProNm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProNm.ForeColor = System.Drawing.Color.Black
        Me.lblProNm.Location = New System.Drawing.Point(88, 26)
        Me.lblProNm.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProNm.Name = "lblProNm"
        Me.lblProNm.Size = New System.Drawing.Size(23, 14)
        Me.lblProNm.TabIndex = 35
        Me.lblProNm.Text = "    "
        Me.lblProNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSockTyp
        '
        Me.lblSockTyp.AutoEllipsis = True
        Me.lblSockTyp.AutoSize = True
        Me.lblSockTyp.BackColor = System.Drawing.Color.Transparent
        Me.lblSockTyp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSockTyp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSockTyp.ForeColor = System.Drawing.Color.Black
        Me.lblSockTyp.Location = New System.Drawing.Point(104, 70)
        Me.lblSockTyp.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSockTyp.Name = "lblSockTyp"
        Me.lblSockTyp.Size = New System.Drawing.Size(23, 14)
        Me.lblSockTyp.TabIndex = 39
        Me.lblSockTyp.Text = "    "
        Me.lblSockTyp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'perCPU
        '
        Me.perCPU.CategoryName = "Processor"
        Me.perCPU.CounterName = "% Processor Time"
        Me.perCPU.InstanceName = "_Total"
        '
        'Label13
        '
        Me.Label13.AutoEllipsis = True
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(4, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 14)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Socket Type:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 48)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 14)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Threads:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrCPU
        '
        Me.tmrCPU.Interval = 1000
        '
        'lblThreads
        '
        Me.lblThreads.AutoEllipsis = True
        Me.lblThreads.AutoSize = True
        Me.lblThreads.BackColor = System.Drawing.Color.Transparent
        Me.lblThreads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblThreads.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreads.ForeColor = System.Drawing.Color.Black
        Me.lblThreads.Location = New System.Drawing.Point(104, 48)
        Me.lblThreads.Margin = New System.Windows.Forms.Padding(4)
        Me.lblThreads.Name = "lblThreads"
        Me.lblThreads.Size = New System.Drawing.Size(23, 14)
        Me.lblThreads.TabIndex = 36
        Me.lblThreads.Text = "    "
        Me.lblThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 4)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 14)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Architecture:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProArc
        '
        Me.lblProArc.AutoEllipsis = True
        Me.lblProArc.AutoSize = True
        Me.lblProArc.BackColor = System.Drawing.Color.Transparent
        Me.lblProArc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProArc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProArc.ForeColor = System.Drawing.Color.Black
        Me.lblProArc.Location = New System.Drawing.Point(104, 4)
        Me.lblProArc.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProArc.Name = "lblProArc"
        Me.lblProArc.Size = New System.Drawing.Size(23, 14)
        Me.lblProArc.TabIndex = 29
        Me.lblProArc.Text = "    "
        Me.lblProArc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(4, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "No. Of Cores:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(4, 26)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 14)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Max Clock Speed:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProCurClSpd
        '
        Me.lblProCurClSpd.AutoEllipsis = True
        Me.lblProCurClSpd.AutoSize = True
        Me.lblProCurClSpd.BackColor = System.Drawing.Color.Transparent
        Me.lblProCurClSpd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProCurClSpd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProCurClSpd.ForeColor = System.Drawing.Color.Black
        Me.lblProCurClSpd.Location = New System.Drawing.Point(105, 4)
        Me.lblProCurClSpd.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProCurClSpd.Name = "lblProCurClSpd"
        Me.lblProCurClSpd.Size = New System.Drawing.Size(23, 14)
        Me.lblProCurClSpd.TabIndex = 29
        Me.lblProCurClSpd.Text = "    "
        Me.lblProCurClSpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.lblProVolt, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.lblProExtClSpd, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblProCurClSpd, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblProMaxClSpd, 1, 1)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(89, 356)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(132, 88)
        Me.TableLayoutPanel3.TabIndex = 98
        '
        'Label15
        '
        Me.Label15.AutoEllipsis = True
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(4, 70)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 14)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Voltage:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProVolt
        '
        Me.lblProVolt.AutoEllipsis = True
        Me.lblProVolt.AutoSize = True
        Me.lblProVolt.BackColor = System.Drawing.Color.Transparent
        Me.lblProVolt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProVolt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProVolt.ForeColor = System.Drawing.Color.Black
        Me.lblProVolt.Location = New System.Drawing.Point(105, 70)
        Me.lblProVolt.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProVolt.Name = "lblProVolt"
        Me.lblProVolt.Size = New System.Drawing.Size(23, 14)
        Me.lblProVolt.TabIndex = 38
        Me.lblProVolt.Text = "    "
        Me.lblProVolt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 48)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 14)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Ext Clock Speed:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProExtClSpd
        '
        Me.lblProExtClSpd.AutoEllipsis = True
        Me.lblProExtClSpd.AutoSize = True
        Me.lblProExtClSpd.BackColor = System.Drawing.Color.Transparent
        Me.lblProExtClSpd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProExtClSpd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProExtClSpd.ForeColor = System.Drawing.Color.Black
        Me.lblProExtClSpd.Location = New System.Drawing.Point(105, 48)
        Me.lblProExtClSpd.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProExtClSpd.Name = "lblProExtClSpd"
        Me.lblProExtClSpd.Size = New System.Drawing.Size(23, 14)
        Me.lblProExtClSpd.TabIndex = 36
        Me.lblProExtClSpd.Text = "    "
        Me.lblProExtClSpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(4, 4)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 14)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Curr Clock Speed:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.lblL3CachSz, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lblL2CachSz, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblL1CachSz, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSockTyp, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblThreads, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblProArc, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblProNoOfCrs, 1, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(89, 202)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(131, 154)
        Me.TableLayoutPanel1.TabIndex = 97
        '
        'lblProNoOfCrs
        '
        Me.lblProNoOfCrs.AutoEllipsis = True
        Me.lblProNoOfCrs.AutoSize = True
        Me.lblProNoOfCrs.BackColor = System.Drawing.Color.Transparent
        Me.lblProNoOfCrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProNoOfCrs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProNoOfCrs.ForeColor = System.Drawing.Color.Black
        Me.lblProNoOfCrs.Location = New System.Drawing.Point(104, 26)
        Me.lblProNoOfCrs.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProNoOfCrs.Name = "lblProNoOfCrs"
        Me.lblProNoOfCrs.Size = New System.Drawing.Size(23, 14)
        Me.lblProNoOfCrs.TabIndex = 35
        Me.lblProNoOfCrs.Text = "    "
        Me.lblProNoOfCrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(36, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 109
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.prCPU)
        Me.Panel1.Controls.Add(Me.lblCPU)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 25)
        Me.Panel1.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Processor"
        '
        'prCPU
        '
        Me.prCPU.Location = New System.Drawing.Point(450, 5)
        Me.prCPU.Name = "prCPU"
        Me.prCPU.Size = New System.Drawing.Size(91, 12)
        Me.prCPU.TabIndex = 106
        '
        'lblCPU
        '
        Me.lblCPU.AutoSize = True
        Me.lblCPU.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCPU.Location = New System.Drawing.Point(381, 5)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(63, 13)
        Me.lblCPU.TabIndex = 107
        Me.lblCPU.Text = "Load : 99 %"
        '
        'Processor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Processor"
        Me.Size = New System.Drawing.Size(545, 485)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.perCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblL3CachSz As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblL2CachSz As System.Windows.Forms.Label
    Friend WithEvents lblL1CachSz As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblProMaxClSpd As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblProIden As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblProManu As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblProNm As System.Windows.Forms.Label
    Friend WithEvents lblSockTyp As System.Windows.Forms.Label
    Friend WithEvents perCPU As System.Diagnostics.PerformanceCounter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tmrCPU As System.Windows.Forms.Timer
    Friend WithEvents lblThreads As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblProArc As System.Windows.Forms.Label
    Friend WithEvents prCPU As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrProCurClckSpd As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblProCurClSpd As System.Windows.Forms.Label
    Friend WithEvents lblCPU As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblProVolt As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblProExtClSpd As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblProNoOfCrs As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
