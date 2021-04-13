<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GraphicCard))
        Me.CmboMntr = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblVideoPixelsY = New System.Windows.Forms.Label()
        Me.lblVideoPixelsX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.lblMonitorManufacturer = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.lblVideoHorizontalRes = New System.Windows.Forms.Label()
        Me.lblVideoVerticalRes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmboGraphicCrd = New System.Windows.Forms.ComboBox()
        Me.TableLayoutVideo = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVideoRefreshRate = New System.Windows.Forms.Label()
        Me.lblVideoScanMode = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.lblVideoManufacturer = New System.Windows.Forms.Label()
        Me.lblVideoCard = New System.Windows.Forms.Label()
        Me.lblVideoMem = New System.Windows.Forms.Label()
        Me.lblVideoDriverVersion = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblVideoColourDepth = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIsDef = New System.Windows.Forms.Label()
        Me.lblIsDefGr = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutVideo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmboMntr
        '
        Me.CmboMntr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboMntr.FormattingEnabled = True
        Me.CmboMntr.Location = New System.Drawing.Point(56, 87)
        Me.CmboMntr.Name = "CmboMntr"
        Me.CmboMntr.Size = New System.Drawing.Size(316, 21)
        Me.CmboMntr.TabIndex = 118
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblVideoPixelsY, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVideoPixelsX, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label86, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label64, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMonitorManufacturer, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label59, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label61, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVideoHorizontalRes, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVideoVerticalRes, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(56, 117)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 118)
        Me.TableLayoutPanel1.TabIndex = 119
        '
        'lblVideoPixelsY
        '
        Me.lblVideoPixelsY.AutoSize = True
        Me.lblVideoPixelsY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoPixelsY.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoPixelsY.ForeColor = System.Drawing.Color.Black
        Me.lblVideoPixelsY.Location = New System.Drawing.Point(183, 97)
        Me.lblVideoPixelsY.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoPixelsY.Name = "lblVideoPixelsY"
        Me.lblVideoPixelsY.Size = New System.Drawing.Size(23, 12)
        Me.lblVideoPixelsY.TabIndex = 118
        Me.lblVideoPixelsY.Text = "    "
        Me.lblVideoPixelsY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoPixelsX
        '
        Me.lblVideoPixelsX.AutoSize = True
        Me.lblVideoPixelsX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoPixelsX.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoPixelsX.ForeColor = System.Drawing.Color.Black
        Me.lblVideoPixelsX.Location = New System.Drawing.Point(183, 75)
        Me.lblVideoPixelsX.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoPixelsX.Name = "lblVideoPixelsX"
        Me.lblVideoPixelsX.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoPixelsX.TabIndex = 117
        Me.lblVideoPixelsX.Text = "    "
        Me.lblVideoPixelsX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 12)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Pixels/Inch Y:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label86.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label86.Location = New System.Drawing.Point(9, 75)
        Me.Label86.Margin = New System.Windows.Forms.Padding(4)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(166, 14)
        Me.Label86.TabIndex = 109
        Me.Label86.Text = "Pixels/Inch X:"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(9, 9)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(166, 14)
        Me.Label64.TabIndex = 97
        Me.Label64.Text = "Manufacturer:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMonitorManufacturer
        '
        Me.lblMonitorManufacturer.AutoSize = True
        Me.lblMonitorManufacturer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMonitorManufacturer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorManufacturer.ForeColor = System.Drawing.Color.Black
        Me.lblMonitorManufacturer.Location = New System.Drawing.Point(183, 9)
        Me.lblMonitorManufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMonitorManufacturer.Name = "lblMonitorManufacturer"
        Me.lblMonitorManufacturer.Size = New System.Drawing.Size(23, 14)
        Me.lblMonitorManufacturer.TabIndex = 98
        Me.lblMonitorManufacturer.Text = "    "
        Me.lblMonitorManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label59.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Location = New System.Drawing.Point(9, 53)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(166, 14)
        Me.Label59.TabIndex = 93
        Me.Label59.Text = "Vertical Screen Resolution:"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(9, 31)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(166, 14)
        Me.Label61.TabIndex = 91
        Me.Label61.Text = "Horizontal Screen Resolution:"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoHorizontalRes
        '
        Me.lblVideoHorizontalRes.AutoSize = True
        Me.lblVideoHorizontalRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoHorizontalRes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoHorizontalRes.ForeColor = System.Drawing.Color.Black
        Me.lblVideoHorizontalRes.Location = New System.Drawing.Point(183, 31)
        Me.lblVideoHorizontalRes.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoHorizontalRes.Name = "lblVideoHorizontalRes"
        Me.lblVideoHorizontalRes.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoHorizontalRes.TabIndex = 92
        Me.lblVideoHorizontalRes.Text = "    "
        Me.lblVideoHorizontalRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoVerticalRes
        '
        Me.lblVideoVerticalRes.AutoSize = True
        Me.lblVideoVerticalRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoVerticalRes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoVerticalRes.ForeColor = System.Drawing.Color.Black
        Me.lblVideoVerticalRes.Location = New System.Drawing.Point(183, 53)
        Me.lblVideoVerticalRes.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoVerticalRes.Name = "lblVideoVerticalRes"
        Me.lblVideoVerticalRes.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoVerticalRes.TabIndex = 94
        Me.lblVideoVerticalRes.Text = "    "
        Me.lblVideoVerticalRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(62, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Monitor"
        '
        'CmboGraphicCrd
        '
        Me.CmboGraphicCrd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboGraphicCrd.FormattingEnabled = True
        Me.CmboGraphicCrd.Location = New System.Drawing.Point(56, 268)
        Me.CmboGraphicCrd.Name = "CmboGraphicCrd"
        Me.CmboGraphicCrd.Size = New System.Drawing.Size(316, 21)
        Me.CmboGraphicCrd.TabIndex = 123
        '
        'TableLayoutVideo
        '
        Me.TableLayoutVideo.AutoSize = True
        Me.TableLayoutVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutVideo.ColumnCount = 2
        Me.TableLayoutVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutVideo.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoRefreshRate, 1, 5)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoScanMode, 1, 6)
        Me.TableLayoutVideo.Controls.Add(Me.Label65, 0, 0)
        Me.TableLayoutVideo.Controls.Add(Me.Label67, 0, 1)
        Me.TableLayoutVideo.Controls.Add(Me.Label63, 0, 2)
        Me.TableLayoutVideo.Controls.Add(Me.Label60, 0, 3)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoManufacturer, 1, 0)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoCard, 1, 1)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoMem, 1, 2)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoDriverVersion, 1, 3)
        Me.TableLayoutVideo.Controls.Add(Me.Label14, 0, 4)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoColourDepth, 1, 4)
        Me.TableLayoutVideo.Controls.Add(Me.Label58, 0, 5)
        Me.TableLayoutVideo.Location = New System.Drawing.Point(56, 297)
        Me.TableLayoutVideo.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutVideo.Name = "TableLayoutVideo"
        Me.TableLayoutVideo.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutVideo.RowCount = 7
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutVideo.Size = New System.Drawing.Size(138, 162)
        Me.TableLayoutVideo.TabIndex = 124
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(9, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Scan Mode:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoRefreshRate
        '
        Me.lblVideoRefreshRate.AutoSize = True
        Me.lblVideoRefreshRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoRefreshRate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoRefreshRate.ForeColor = System.Drawing.Color.Black
        Me.lblVideoRefreshRate.Location = New System.Drawing.Point(106, 119)
        Me.lblVideoRefreshRate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoRefreshRate.Name = "lblVideoRefreshRate"
        Me.lblVideoRefreshRate.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoRefreshRate.TabIndex = 108
        Me.lblVideoRefreshRate.Text = "    "
        Me.lblVideoRefreshRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoScanMode
        '
        Me.lblVideoScanMode.AutoSize = True
        Me.lblVideoScanMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoScanMode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoScanMode.ForeColor = System.Drawing.Color.Black
        Me.lblVideoScanMode.Location = New System.Drawing.Point(106, 141)
        Me.lblVideoScanMode.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoScanMode.Name = "lblVideoScanMode"
        Me.lblVideoScanMode.Size = New System.Drawing.Size(23, 12)
        Me.lblVideoScanMode.TabIndex = 109
        Me.lblVideoScanMode.Text = "    "
        Me.lblVideoScanMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(9, 9)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(89, 14)
        Me.Label65.TabIndex = 87
        Me.Label65.Text = "Manufacturer:"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label67.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(9, 31)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(89, 14)
        Me.Label67.TabIndex = 85
        Me.Label67.Text = "DAC Type:"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label63.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(9, 53)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(89, 14)
        Me.Label63.TabIndex = 89
        Me.Label63.Text = "Video Memory:"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(9, 75)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(89, 14)
        Me.Label60.TabIndex = 102
        Me.Label60.Text = "Driver Version:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoManufacturer
        '
        Me.lblVideoManufacturer.AutoSize = True
        Me.lblVideoManufacturer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoManufacturer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoManufacturer.ForeColor = System.Drawing.Color.Black
        Me.lblVideoManufacturer.Location = New System.Drawing.Point(106, 9)
        Me.lblVideoManufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoManufacturer.Name = "lblVideoManufacturer"
        Me.lblVideoManufacturer.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoManufacturer.TabIndex = 88
        Me.lblVideoManufacturer.Text = "    "
        Me.lblVideoManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoCard
        '
        Me.lblVideoCard.AutoSize = True
        Me.lblVideoCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoCard.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoCard.ForeColor = System.Drawing.Color.Black
        Me.lblVideoCard.Location = New System.Drawing.Point(106, 31)
        Me.lblVideoCard.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoCard.Name = "lblVideoCard"
        Me.lblVideoCard.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoCard.TabIndex = 86
        Me.lblVideoCard.Text = "    "
        Me.lblVideoCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoMem
        '
        Me.lblVideoMem.AutoSize = True
        Me.lblVideoMem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoMem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoMem.ForeColor = System.Drawing.Color.Black
        Me.lblVideoMem.Location = New System.Drawing.Point(106, 53)
        Me.lblVideoMem.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoMem.Name = "lblVideoMem"
        Me.lblVideoMem.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoMem.TabIndex = 90
        Me.lblVideoMem.Text = "    "
        Me.lblVideoMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoDriverVersion
        '
        Me.lblVideoDriverVersion.AutoSize = True
        Me.lblVideoDriverVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoDriverVersion.ForeColor = System.Drawing.Color.Black
        Me.lblVideoDriverVersion.Location = New System.Drawing.Point(106, 75)
        Me.lblVideoDriverVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoDriverVersion.Name = "lblVideoDriverVersion"
        Me.lblVideoDriverVersion.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoDriverVersion.TabIndex = 101
        Me.lblVideoDriverVersion.Text = "     "
        Me.lblVideoDriverVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(9, 97)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 14)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Colour Depth:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoColourDepth
        '
        Me.lblVideoColourDepth.AutoSize = True
        Me.lblVideoColourDepth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoColourDepth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoColourDepth.ForeColor = System.Drawing.Color.Black
        Me.lblVideoColourDepth.Location = New System.Drawing.Point(106, 97)
        Me.lblVideoColourDepth.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoColourDepth.Name = "lblVideoColourDepth"
        Me.lblVideoColourDepth.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoColourDepth.TabIndex = 96
        Me.lblVideoColourDepth.Text = "    "
        Me.lblVideoColourDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(9, 119)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(89, 14)
        Me.Label58.TabIndex = 103
        Me.Label58.Text = "Refresh Rate:"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(62, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Graphic Card"
        '
        'lblIsDef
        '
        Me.lblIsDef.AutoSize = True
        Me.lblIsDef.Location = New System.Drawing.Point(378, 91)
        Me.lblIsDef.Name = "lblIsDef"
        Me.lblIsDef.Size = New System.Drawing.Size(54, 13)
        Me.lblIsDef.TabIndex = 127
        Me.lblIsDef.Text = "Loading..."
        '
        'lblIsDefGr
        '
        Me.lblIsDefGr.AutoSize = True
        Me.lblIsDefGr.Location = New System.Drawing.Point(378, 273)
        Me.lblIsDefGr.Name = "lblIsDefGr"
        Me.lblIsDefGr.Size = New System.Drawing.Size(54, 13)
        Me.lblIsDefGr.TabIndex = 128
        Me.lblIsDefGr.Text = "Loading..."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(36, 239)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 126
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 25)
        Me.Panel1.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Monitor and Graphic Card"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        '
        'GraphicCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblIsDefGr)
        Me.Controls.Add(Me.lblIsDef)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutVideo)
        Me.Controls.Add(Me.CmboGraphicCrd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CmboMntr)
        Me.Name = "GraphicCard"
        Me.Size = New System.Drawing.Size(545, 485)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutVideo.ResumeLayout(False)
        Me.TableLayoutVideo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmboMntr As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblVideoPixelsY As System.Windows.Forms.Label
    Friend WithEvents lblVideoPixelsX As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents lblMonitorManufacturer As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents lblVideoHorizontalRes As System.Windows.Forms.Label
    Friend WithEvents lblVideoVerticalRes As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmboGraphicCrd As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutVideo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblVideoRefreshRate As System.Windows.Forms.Label
    Friend WithEvents lblVideoScanMode As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents lblVideoManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblVideoCard As System.Windows.Forms.Label
    Friend WithEvents lblVideoMem As System.Windows.Forms.Label
    Friend WithEvents lblVideoDriverVersion As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblVideoColourDepth As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblIsDef As System.Windows.Forms.Label
    Friend WithEvents lblIsDefGr As System.Windows.Forms.Label

End Class
