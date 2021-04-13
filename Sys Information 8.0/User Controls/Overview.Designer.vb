<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Overview))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOsName = New System.Windows.Forms.Label()
        Me.lblOsVers = New System.Windows.Forms.Label()
        Me.lblOsManu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProce = New System.Windows.Forms.Label()
        Me.lblMotherbrd = New System.Windows.Forms.Label()
        Me.perCPU = New System.Diagnostics.PerformanceCounter()
        Me.tmrCPU = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRM = New System.Windows.Forms.Timer(Me.components)
        Me.BGWRInternet = New System.ComponentModel.BackgroundWorker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGraphicCrd = New System.Windows.Forms.Label()
        Me.lblRAM = New System.Windows.Forms.Label()
        Me.ProgrProc = New System.Windows.Forms.ProgressBar()
        Me.lblProPer = New System.Windows.Forms.Label()
        Me.lblRmUsg = New System.Windows.Forms.Label()
        Me.ProgrRAM = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Graph2 = New Sys_Information_8._0.Graph()
        Me.Graph1 = New Sys_Information_8._0.Graph()
        CType(Me.perCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(60, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operating System"
        '
        'lblOsName
        '
        Me.lblOsName.AutoSize = True
        Me.lblOsName.Location = New System.Drawing.Point(75, 86)
        Me.lblOsName.Name = "lblOsName"
        Me.lblOsName.Size = New System.Drawing.Size(110, 15)
        Me.lblOsName.TabIndex = 2
        Me.lblOsName.Text = "Microsoft Windows"
        '
        'lblOsVers
        '
        Me.lblOsVers.AutoSize = True
        Me.lblOsVers.Location = New System.Drawing.Point(75, 110)
        Me.lblOsVers.Name = "lblOsVers"
        Me.lblOsVers.Size = New System.Drawing.Size(111, 15)
        Me.lblOsVers.TabIndex = 3
        Me.lblOsVers.Text = "Version : Loading..."
        '
        'lblOsManu
        '
        Me.lblOsManu.AutoSize = True
        Me.lblOsManu.Location = New System.Drawing.Point(75, 134)
        Me.lblOsManu.Name = "lblOsManu"
        Me.lblOsManu.Size = New System.Drawing.Size(143, 15)
        Me.lblOsManu.TabIndex = 4
        Me.lblOsManu.Text = "Manufacturer : Loading..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(60, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Motherboard and processor"
        '
        'lblProce
        '
        Me.lblProce.AutoSize = True
        Me.lblProce.Location = New System.Drawing.Point(75, 232)
        Me.lblProce.Name = "lblProce"
        Me.lblProce.Size = New System.Drawing.Size(125, 15)
        Me.lblProce.TabIndex = 8
        Me.lblProce.Text = "Processor : Loading..."
        '
        'lblMotherbrd
        '
        Me.lblMotherbrd.AutoSize = True
        Me.lblMotherbrd.Location = New System.Drawing.Point(75, 207)
        Me.lblMotherbrd.Name = "lblMotherbrd"
        Me.lblMotherbrd.Size = New System.Drawing.Size(84, 15)
        Me.lblMotherbrd.TabIndex = 7
        Me.lblMotherbrd.Text = "Motherboard :"
        '
        'perCPU
        '
        Me.perCPU.CategoryName = "Processor"
        Me.perCPU.CounterName = "% Processor Time"
        Me.perCPU.InstanceName = "_Total"
        '
        'tmrCPU
        '
        Me.tmrCPU.Interval = 1000
        '
        'tmrRM
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(60, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Graphic Card and RAM"
        '
        'lblGraphicCrd
        '
        Me.lblGraphicCrd.AutoSize = True
        Me.lblGraphicCrd.Location = New System.Drawing.Point(75, 301)
        Me.lblGraphicCrd.Name = "lblGraphicCrd"
        Me.lblGraphicCrd.Size = New System.Drawing.Size(142, 15)
        Me.lblGraphicCrd.TabIndex = 13
        Me.lblGraphicCrd.Text = "Graphic Card : Loading..."
        '
        'lblRAM
        '
        Me.lblRAM.AutoSize = True
        Me.lblRAM.Location = New System.Drawing.Point(75, 326)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(97, 15)
        Me.lblRAM.TabIndex = 14
        Me.lblRAM.Text = "RAM : Loading..."
        '
        'ProgrProc
        '
        Me.ProgrProc.Location = New System.Drawing.Point(182, 403)
        Me.ProgrProc.Name = "ProgrProc"
        Me.ProgrProc.Size = New System.Drawing.Size(37, 10)
        Me.ProgrProc.TabIndex = 15
        '
        'lblProPer
        '
        Me.lblProPer.ForeColor = System.Drawing.Color.Maroon
        Me.lblProPer.Location = New System.Drawing.Point(68, 363)
        Me.lblProPer.Name = "lblProPer"
        Me.lblProPer.Size = New System.Drawing.Size(104, 15)
        Me.lblProPer.TabIndex = 16
        Me.lblProPer.Text = "Processor : 99 %"
        '
        'lblRmUsg
        '
        Me.lblRmUsg.ForeColor = System.Drawing.Color.Maroon
        Me.lblRmUsg.Location = New System.Drawing.Point(296, 363)
        Me.lblRmUsg.Name = "lblRmUsg"
        Me.lblRmUsg.Size = New System.Drawing.Size(82, 15)
        Me.lblRmUsg.TabIndex = 18
        Me.lblRmUsg.Text = "RAM : 99 %"
        '
        'ProgrRAM
        '
        Me.ProgrRAM.Location = New System.Drawing.Point(193, 414)
        Me.ProgrRAM.Name = "ProgrRAM"
        Me.ProgrRAM.Size = New System.Drawing.Size(47, 10)
        Me.ProgrRAM.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 25)
        Me.Panel1.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Overview"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(30, 268)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(30, 358)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 113
        Me.PictureBox5.TabStop = False
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'Graph2
        '
        Me.Graph2.BorderColor = System.Drawing.Color.Gray
        Me.Graph2.DataColumnForeColor = System.Drawing.Color.Gray
        Me.Graph2.DataSmoothing = False
        Me.Graph2.DataSmoothingLevel = CType(2, Byte)
        Me.Graph2.DrawDataColumn = True
        Me.Graph2.DrawHorizontalLines = True
        Me.Graph2.DrawHoverData = True
        Me.Graph2.DrawHoverLine = True
        Me.Graph2.DrawLineGraph = False
        Me.Graph2.DrawVerticalLines = False
        Me.Graph2.FillColor = System.Drawing.Color.White
        Me.Graph2.GraphBorderColor = System.Drawing.Color.ForestGreen
        Me.Graph2.GraphFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Graph2.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Graph2.HoverBorderColor = System.Drawing.Color.ForestGreen
        Me.Graph2.HoverFillColor = System.Drawing.Color.White
        Me.Graph2.HoverLabelBorderColor = System.Drawing.Color.DarkGray
        Me.Graph2.HoverLabelFillColor = System.Drawing.Color.White
        Me.Graph2.HoverLabelForeColor = System.Drawing.Color.Gray
        Me.Graph2.HoverLabelShadowColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Graph2.HoverLineColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Graph2.LineGraphColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Graph2.Location = New System.Drawing.Point(299, 381)
        Me.Graph2.Name = "Graph2"
        Me.Graph2.OverrideMax = True
        Me.Graph2.OverrideMaxValue = 100.0!
        Me.Graph2.OverrideMin = True
        Me.Graph2.OverrideMinValue = 0.0!
        Me.Graph2.SidePadding = True
        Me.Graph2.Size = New System.Drawing.Size(213, 94)
        Me.Graph2.TabIndex = 115
        Me.Graph2.Text = "Graph2"
        Me.Graph2.Values = New Single(-1) {}
        Me.Graph2.VerticalLineColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        'Graph1
        '
        Me.Graph1.BorderColor = System.Drawing.Color.Gray
        Me.Graph1.DataColumnForeColor = System.Drawing.Color.Gray
        Me.Graph1.DataSmoothing = False
        Me.Graph1.DataSmoothingLevel = CType(2, Byte)
        Me.Graph1.DrawDataColumn = True
        Me.Graph1.DrawHorizontalLines = True
        Me.Graph1.DrawHoverData = True
        Me.Graph1.DrawHoverLine = True
        Me.Graph1.DrawLineGraph = False
        Me.Graph1.DrawVerticalLines = False
        Me.Graph1.FillColor = System.Drawing.Color.White
        Me.Graph1.GraphBorderColor = System.Drawing.Color.ForestGreen
        Me.Graph1.GraphFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Graph1.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Graph1.HoverBorderColor = System.Drawing.Color.ForestGreen
        Me.Graph1.HoverFillColor = System.Drawing.Color.White
        Me.Graph1.HoverLabelBorderColor = System.Drawing.Color.DarkGray
        Me.Graph1.HoverLabelFillColor = System.Drawing.Color.White
        Me.Graph1.HoverLabelForeColor = System.Drawing.Color.Gray
        Me.Graph1.HoverLabelShadowColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Graph1.HoverLineColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Graph1.LineGraphColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Graph1.Location = New System.Drawing.Point(71, 380)
        Me.Graph1.Name = "Graph1"
        Me.Graph1.OverrideMax = True
        Me.Graph1.OverrideMaxValue = 100.0!
        Me.Graph1.OverrideMin = True
        Me.Graph1.OverrideMinValue = 0.0!
        Me.Graph1.SidePadding = True
        Me.Graph1.Size = New System.Drawing.Size(213, 95)
        Me.Graph1.TabIndex = 114
        Me.Graph1.Text = "Graph1"
        Me.Graph1.Values = New Single(-1) {}
        Me.Graph1.VerticalLineColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        'Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Graph2)
        Me.Controls.Add(Me.Graph1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblRmUsg)
        Me.Controls.Add(Me.ProgrRAM)
        Me.Controls.Add(Me.lblProPer)
        Me.Controls.Add(Me.ProgrProc)
        Me.Controls.Add(Me.lblRAM)
        Me.Controls.Add(Me.lblGraphicCrd)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblProce)
        Me.Controls.Add(Me.lblMotherbrd)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOsManu)
        Me.Controls.Add(Me.lblOsVers)
        Me.Controls.Add(Me.lblOsName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Overview"
        Me.Size = New System.Drawing.Size(545, 485)
        CType(Me.perCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblOsName As System.Windows.Forms.Label
    Friend WithEvents lblOsVers As System.Windows.Forms.Label
    Friend WithEvents lblOsManu As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblProce As System.Windows.Forms.Label
    Friend WithEvents lblMotherbrd As System.Windows.Forms.Label
    Friend WithEvents perCPU As System.Diagnostics.PerformanceCounter
    Friend WithEvents tmrCPU As System.Windows.Forms.Timer
    Friend WithEvents tmrRM As System.Windows.Forms.Timer
    Friend WithEvents BGWRInternet As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblGraphicCrd As System.Windows.Forms.Label
    Friend WithEvents lblRAM As System.Windows.Forms.Label
    Friend WithEvents ProgrProc As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProPer As System.Windows.Forms.Label
    Friend WithEvents lblRmUsg As System.Windows.Forms.Label
    Friend WithEvents ProgrRAM As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Graph1 As Sys_Information_8._0.Graph
    Friend WithEvents Graph2 As Sys_Information_8._0.Graph
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

End Class
