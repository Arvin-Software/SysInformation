<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panControl = New System.Windows.Forms.Panel()
        Me.panSoft = New System.Windows.Forms.Panel()
        Me.bttnOs = New System.Windows.Forms.Button()
        Me.bttnInsSoft = New System.Windows.Forms.Button()
        Me.panlblSoft = New System.Windows.Forms.Panel()
        Me.lblCESoft = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panHrd = New System.Windows.Forms.Panel()
        Me.bttnProAndServ = New System.Windows.Forms.Button()
        Me.bttnBat = New System.Windows.Forms.Button()
        Me.bttnMther = New System.Windows.Forms.Button()
        Me.bttnproc = New System.Windows.Forms.Button()
        Me.bttnHrddsk = New System.Windows.Forms.Button()
        Me.bttnMem = New System.Windows.Forms.Button()
        Me.bttnPeriph = New System.Windows.Forms.Button()
        Me.bttnGraphics = New System.Windows.Forms.Button()
        Me.panlblHrd = New System.Windows.Forms.Panel()
        Me.lblCEhrd = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnOverview = New System.Windows.Forms.Button()
        Me.bttnMin = New System.Windows.Forms.Button()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.lblTit1 = New System.Windows.Forms.Label()
        Me.lblTit2 = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.BGwrkrIP = New System.ComponentModel.BackgroundWorker()
        Me.TLTPMn = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bttnAbout = New System.Windows.Forms.Button()
        Me.PicInt = New System.Windows.Forms.PictureBox()
        Me.lblDttm = New System.Windows.Forms.Label()
        Me.BGwrkrDtTm = New System.ComponentModel.BackgroundWorker()
        Me.tmrDtTm = New System.Windows.Forms.Timer(Me.components)
        Me.panStatusbar = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PicRefInt = New System.Windows.Forms.PictureBox()
        Me.lblBatPer = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.tmrSt = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRev = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.BGwrkrBat = New System.ComponentModel.BackgroundWorker()
        Me.tmrBat = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panControl.SuspendLayout()
        Me.panSoft.SuspendLayout()
        Me.panlblSoft.SuspendLayout()
        Me.panHrd.SuspendLayout()
        Me.panlblHrd.SuspendLayout()
        CType(Me.PicInt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panStatusbar.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRefInt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(157, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 494)
        Me.Panel1.TabIndex = 2
        '
        'panControl
        '
        Me.panControl.BackColor = System.Drawing.Color.DimGray
        Me.panControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panControl.Controls.Add(Me.panSoft)
        Me.panControl.Controls.Add(Me.panlblSoft)
        Me.panControl.Controls.Add(Me.panHrd)
        Me.panControl.Controls.Add(Me.panlblHrd)
        Me.panControl.Controls.Add(Me.bttnOverview)
        Me.panControl.Location = New System.Drawing.Point(3, 56)
        Me.panControl.Name = "panControl"
        Me.panControl.Size = New System.Drawing.Size(156, 494)
        Me.panControl.TabIndex = 6
        '
        'panSoft
        '
        Me.panSoft.Controls.Add(Me.bttnOs)
        Me.panSoft.Controls.Add(Me.bttnInsSoft)
        Me.panSoft.Location = New System.Drawing.Point(0, 400)
        Me.panSoft.Name = "panSoft"
        Me.panSoft.Size = New System.Drawing.Size(154, 82)
        Me.panSoft.TabIndex = 29
        '
        'bttnOs
        '
        Me.bttnOs.BackColor = System.Drawing.Color.Transparent
        Me.bttnOs.FlatAppearance.BorderSize = 0
        Me.bttnOs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnOs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnOs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnOs.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnOs.Image = CType(resources.GetObject("bttnOs.Image"), System.Drawing.Image)
        Me.bttnOs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnOs.Location = New System.Drawing.Point(7, 3)
        Me.bttnOs.Name = "bttnOs"
        Me.bttnOs.Size = New System.Drawing.Size(150, 37)
        Me.bttnOs.TabIndex = 7
        Me.bttnOs.Text = "       Operating system"
        Me.bttnOs.UseVisualStyleBackColor = False
        '
        'bttnInsSoft
        '
        Me.bttnInsSoft.BackColor = System.Drawing.Color.Transparent
        Me.bttnInsSoft.FlatAppearance.BorderSize = 0
        Me.bttnInsSoft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnInsSoft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnInsSoft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnInsSoft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnInsSoft.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnInsSoft.Image = CType(resources.GetObject("bttnInsSoft.Image"), System.Drawing.Image)
        Me.bttnInsSoft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnInsSoft.Location = New System.Drawing.Point(7, 44)
        Me.bttnInsSoft.Name = "bttnInsSoft"
        Me.bttnInsSoft.Size = New System.Drawing.Size(150, 37)
        Me.bttnInsSoft.TabIndex = 21
        Me.bttnInsSoft.Text = "      Software && Other"
        Me.bttnInsSoft.UseVisualStyleBackColor = False
        '
        'panlblSoft
        '
        Me.panlblSoft.BackColor = System.Drawing.Color.Gray
        Me.panlblSoft.BackgroundImage = CType(resources.GetObject("panlblSoft.BackgroundImage"), System.Drawing.Image)
        Me.panlblSoft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panlblSoft.Controls.Add(Me.lblCESoft)
        Me.panlblSoft.Controls.Add(Me.Label5)
        Me.panlblSoft.Location = New System.Drawing.Point(0, 375)
        Me.panlblSoft.Name = "panlblSoft"
        Me.panlblSoft.Size = New System.Drawing.Size(153, 25)
        Me.panlblSoft.TabIndex = 20
        Me.TLTPMn.SetToolTip(Me.panlblSoft, "Click to collapse or expand")
        '
        'lblCESoft
        '
        Me.lblCESoft.AutoSize = True
        Me.lblCESoft.BackColor = System.Drawing.Color.Transparent
        Me.lblCESoft.ForeColor = System.Drawing.Color.White
        Me.lblCESoft.Location = New System.Drawing.Point(132, 5)
        Me.lblCESoft.Name = "lblCESoft"
        Me.lblCESoft.Size = New System.Drawing.Size(12, 13)
        Me.lblCESoft.TabIndex = 22
        Me.lblCESoft.Text = "^"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Software"
        '
        'panHrd
        '
        Me.panHrd.Controls.Add(Me.bttnProAndServ)
        Me.panHrd.Controls.Add(Me.bttnBat)
        Me.panHrd.Controls.Add(Me.bttnMther)
        Me.panHrd.Controls.Add(Me.bttnproc)
        Me.panHrd.Controls.Add(Me.bttnHrddsk)
        Me.panHrd.Controls.Add(Me.bttnMem)
        Me.panHrd.Controls.Add(Me.bttnPeriph)
        Me.panHrd.Controls.Add(Me.bttnGraphics)
        Me.panHrd.Location = New System.Drawing.Point(0, 90)
        Me.panHrd.Name = "panHrd"
        Me.panHrd.Size = New System.Drawing.Size(157, 279)
        Me.panHrd.TabIndex = 21
        '
        'bttnProAndServ
        '
        Me.bttnProAndServ.BackColor = System.Drawing.Color.Transparent
        Me.bttnProAndServ.FlatAppearance.BorderSize = 0
        Me.bttnProAndServ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnProAndServ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnProAndServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnProAndServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnProAndServ.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnProAndServ.Image = CType(resources.GetObject("bttnProAndServ.Image"), System.Drawing.Image)
        Me.bttnProAndServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnProAndServ.Location = New System.Drawing.Point(7, 209)
        Me.bttnProAndServ.Name = "bttnProAndServ"
        Me.bttnProAndServ.Size = New System.Drawing.Size(150, 23)
        Me.bttnProAndServ.TabIndex = 27
        Me.bttnProAndServ.Text = "Network       "
        Me.bttnProAndServ.UseVisualStyleBackColor = False
        '
        'bttnBat
        '
        Me.bttnBat.BackColor = System.Drawing.Color.Transparent
        Me.bttnBat.FlatAppearance.BorderSize = 0
        Me.bttnBat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnBat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnBat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnBat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBat.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnBat.Image = CType(resources.GetObject("bttnBat.Image"), System.Drawing.Image)
        Me.bttnBat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnBat.Location = New System.Drawing.Point(7, 242)
        Me.bttnBat.Name = "bttnBat"
        Me.bttnBat.Size = New System.Drawing.Size(150, 23)
        Me.bttnBat.TabIndex = 28
        Me.bttnBat.Text = "Battery         "
        Me.bttnBat.UseVisualStyleBackColor = False
        '
        'bttnMther
        '
        Me.bttnMther.BackColor = System.Drawing.Color.Transparent
        Me.bttnMther.FlatAppearance.BorderSize = 0
        Me.bttnMther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnMther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnMther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnMther.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMther.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnMther.Image = CType(resources.GetObject("bttnMther.Image"), System.Drawing.Image)
        Me.bttnMther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnMther.Location = New System.Drawing.Point(7, 11)
        Me.bttnMther.Name = "bttnMther"
        Me.bttnMther.Size = New System.Drawing.Size(150, 23)
        Me.bttnMther.TabIndex = 9
        Me.bttnMther.Text = "Motherboard"
        Me.bttnMther.UseVisualStyleBackColor = False
        '
        'bttnproc
        '
        Me.bttnproc.BackColor = System.Drawing.Color.Transparent
        Me.bttnproc.FlatAppearance.BorderSize = 0
        Me.bttnproc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnproc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnproc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnproc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnproc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnproc.Image = CType(resources.GetObject("bttnproc.Image"), System.Drawing.Image)
        Me.bttnproc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnproc.Location = New System.Drawing.Point(7, 44)
        Me.bttnproc.Name = "bttnproc"
        Me.bttnproc.Size = New System.Drawing.Size(150, 23)
        Me.bttnproc.TabIndex = 22
        Me.bttnproc.Text = "Processor    "
        Me.bttnproc.UseVisualStyleBackColor = False
        '
        'bttnHrddsk
        '
        Me.bttnHrddsk.BackColor = System.Drawing.Color.Transparent
        Me.bttnHrddsk.FlatAppearance.BorderSize = 0
        Me.bttnHrddsk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnHrddsk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnHrddsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnHrddsk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnHrddsk.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnHrddsk.Image = CType(resources.GetObject("bttnHrddsk.Image"), System.Drawing.Image)
        Me.bttnHrddsk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnHrddsk.Location = New System.Drawing.Point(7, 176)
        Me.bttnHrddsk.Name = "bttnHrddsk"
        Me.bttnHrddsk.Size = New System.Drawing.Size(150, 23)
        Me.bttnHrddsk.TabIndex = 26
        Me.bttnHrddsk.Text = "       Storage devices"
        Me.bttnHrddsk.UseVisualStyleBackColor = False
        '
        'bttnMem
        '
        Me.bttnMem.BackColor = System.Drawing.Color.Transparent
        Me.bttnMem.FlatAppearance.BorderSize = 0
        Me.bttnMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnMem.Image = CType(resources.GetObject("bttnMem.Image"), System.Drawing.Image)
        Me.bttnMem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnMem.Location = New System.Drawing.Point(7, 77)
        Me.bttnMem.Name = "bttnMem"
        Me.bttnMem.Size = New System.Drawing.Size(150, 23)
        Me.bttnMem.TabIndex = 23
        Me.bttnMem.Text = "Memory       "
        Me.bttnMem.UseVisualStyleBackColor = False
        '
        'bttnPeriph
        '
        Me.bttnPeriph.BackColor = System.Drawing.Color.Transparent
        Me.bttnPeriph.FlatAppearance.BorderSize = 0
        Me.bttnPeriph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnPeriph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnPeriph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnPeriph.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPeriph.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnPeriph.Image = CType(resources.GetObject("bttnPeriph.Image"), System.Drawing.Image)
        Me.bttnPeriph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnPeriph.Location = New System.Drawing.Point(7, 143)
        Me.bttnPeriph.Name = "bttnPeriph"
        Me.bttnPeriph.Size = New System.Drawing.Size(150, 23)
        Me.bttnPeriph.TabIndex = 25
        Me.bttnPeriph.Text = "Peripherals"
        Me.bttnPeriph.UseVisualStyleBackColor = False
        '
        'bttnGraphics
        '
        Me.bttnGraphics.BackColor = System.Drawing.Color.Transparent
        Me.bttnGraphics.FlatAppearance.BorderSize = 0
        Me.bttnGraphics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnGraphics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnGraphics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGraphics.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnGraphics.Image = CType(resources.GetObject("bttnGraphics.Image"), System.Drawing.Image)
        Me.bttnGraphics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnGraphics.Location = New System.Drawing.Point(7, 110)
        Me.bttnGraphics.Name = "bttnGraphics"
        Me.bttnGraphics.Size = New System.Drawing.Size(150, 23)
        Me.bttnGraphics.TabIndex = 24
        Me.bttnGraphics.Text = "   Graphic Card"
        Me.bttnGraphics.UseVisualStyleBackColor = False
        '
        'panlblHrd
        '
        Me.panlblHrd.BackColor = System.Drawing.Color.Gray
        Me.panlblHrd.BackgroundImage = CType(resources.GetObject("panlblHrd.BackgroundImage"), System.Drawing.Image)
        Me.panlblHrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panlblHrd.Controls.Add(Me.lblCEhrd)
        Me.panlblHrd.Controls.Add(Me.Label2)
        Me.panlblHrd.Location = New System.Drawing.Point(0, 66)
        Me.panlblHrd.Name = "panlblHrd"
        Me.panlblHrd.Size = New System.Drawing.Size(153, 25)
        Me.panlblHrd.TabIndex = 21
        Me.TLTPMn.SetToolTip(Me.panlblHrd, "Click to collapse or expand")
        '
        'lblCEhrd
        '
        Me.lblCEhrd.AutoSize = True
        Me.lblCEhrd.BackColor = System.Drawing.Color.Transparent
        Me.lblCEhrd.ForeColor = System.Drawing.Color.White
        Me.lblCEhrd.Location = New System.Drawing.Point(132, 5)
        Me.lblCEhrd.Name = "lblCEhrd"
        Me.lblCEhrd.Size = New System.Drawing.Size(12, 13)
        Me.lblCEhrd.TabIndex = 21
        Me.lblCEhrd.Text = "^"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hardware"
        '
        'bttnOverview
        '
        Me.bttnOverview.BackColor = System.Drawing.Color.Gray
        Me.bttnOverview.FlatAppearance.BorderSize = 0
        Me.bttnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.bttnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.bttnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnOverview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnOverview.ForeColor = System.Drawing.Color.White
        Me.bttnOverview.Image = CType(resources.GetObject("bttnOverview.Image"), System.Drawing.Image)
        Me.bttnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnOverview.Location = New System.Drawing.Point(7, 33)
        Me.bttnOverview.Name = "bttnOverview"
        Me.bttnOverview.Size = New System.Drawing.Size(150, 23)
        Me.bttnOverview.TabIndex = 6
        Me.bttnOverview.Text = "Overview   "
        Me.bttnOverview.UseVisualStyleBackColor = False
        '
        'bttnMin
        '
        Me.bttnMin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.bttnMin.FlatAppearance.BorderSize = 0
        Me.bttnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMin.ForeColor = System.Drawing.Color.Black
        Me.bttnMin.Location = New System.Drawing.Point(83, -1)
        Me.bttnMin.Name = "bttnMin"
        Me.bttnMin.Size = New System.Drawing.Size(35, 27)
        Me.bttnMin.TabIndex = 8
        Me.bttnMin.Text = "-"
        Me.bttnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TLTPMn.SetToolTip(Me.bttnMin, "Minimize")
        Me.bttnMin.UseVisualStyleBackColor = True
        '
        'bttnClose
        '
        Me.bttnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.bttnClose.FlatAppearance.BorderSize = 0
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClose.ForeColor = System.Drawing.Color.Black
        Me.bttnClose.Location = New System.Drawing.Point(123, -1)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(35, 27)
        Me.bttnClose.TabIndex = 7
        Me.bttnClose.Text = "X"
        Me.TLTPMn.SetToolTip(Me.bttnClose, "Close")
        Me.bttnClose.UseVisualStyleBackColor = True
        '
        'lblTit1
        '
        Me.lblTit1.AutoSize = True
        Me.lblTit1.BackColor = System.Drawing.Color.Transparent
        Me.lblTit1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTit1.Location = New System.Drawing.Point(62, 0)
        Me.lblTit1.Name = "lblTit1"
        Me.lblTit1.Size = New System.Drawing.Size(197, 36)
        Me.lblTit1.TabIndex = 23
        Me.lblTit1.Text = "Sys Information"
        '
        'lblTit2
        '
        Me.lblTit2.AutoSize = True
        Me.lblTit2.BackColor = System.Drawing.Color.Transparent
        Me.lblTit2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit2.ForeColor = System.Drawing.Color.White
        Me.lblTit2.Location = New System.Drawing.Point(63, 36)
        Me.lblTit2.Name = "lblTit2"
        Me.lblTit2.Size = New System.Drawing.Size(300, 14)
        Me.lblTit2.TabIndex = 24
        Me.lblTit2.Text = "the tool you need to view all your system information."
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.White
        Me.lblIP.Location = New System.Drawing.Point(484, 4)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(125, 13)
        Me.lblIP.TabIndex = 26
        Me.lblIP.Text = "IP :No info click to refresh"
        '
        'BGwrkrIP
        '
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(43, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 27)
        Me.Button1.TabIndex = 26
        Me.TLTPMn.SetToolTip(Me.Button1, "Settings")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bttnAbout
        '
        Me.bttnAbout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.bttnAbout.FlatAppearance.BorderSize = 0
        Me.bttnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAbout.ForeColor = System.Drawing.Color.White
        Me.bttnAbout.Image = CType(resources.GetObject("bttnAbout.Image"), System.Drawing.Image)
        Me.bttnAbout.Location = New System.Drawing.Point(3, -1)
        Me.bttnAbout.Name = "bttnAbout"
        Me.bttnAbout.Size = New System.Drawing.Size(35, 27)
        Me.bttnAbout.TabIndex = 25
        Me.TLTPMn.SetToolTip(Me.bttnAbout, "About Sys Information")
        Me.bttnAbout.UseVisualStyleBackColor = True
        '
        'PicInt
        '
        Me.PicInt.Image = CType(resources.GetObject("PicInt.Image"), System.Drawing.Image)
        Me.PicInt.Location = New System.Drawing.Point(468, 2)
        Me.PicInt.Name = "PicInt"
        Me.PicInt.Size = New System.Drawing.Size(16, 16)
        Me.PicInt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicInt.TabIndex = 27
        Me.PicInt.TabStop = False
        Me.TLTPMn.SetToolTip(Me.PicInt, "Connected to internet")
        Me.PicInt.Visible = False
        '
        'lblDttm
        '
        Me.lblDttm.AutoSize = True
        Me.lblDttm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDttm.ForeColor = System.Drawing.Color.White
        Me.lblDttm.Location = New System.Drawing.Point(643, 5)
        Me.lblDttm.Name = "lblDttm"
        Me.lblDttm.Size = New System.Drawing.Size(53, 13)
        Me.lblDttm.TabIndex = 28
        Me.lblDttm.Text = "00:00 AM"
        '
        'BGwrkrDtTm
        '
        '
        'tmrDtTm
        '
        '
        'panStatusbar
        '
        Me.panStatusbar.BackColor = System.Drawing.Color.Transparent
        Me.panStatusbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panStatusbar.Controls.Add(Me.PictureBox7)
        Me.panStatusbar.Controls.Add(Me.PicRefInt)
        Me.panStatusbar.Controls.Add(Me.lblBatPer)
        Me.panStatusbar.Controls.Add(Me.lblCopyright)
        Me.panStatusbar.Controls.Add(Me.lblIP)
        Me.panStatusbar.Controls.Add(Me.lblDttm)
        Me.panStatusbar.Controls.Add(Me.PicInt)
        Me.panStatusbar.Location = New System.Drawing.Point(3, 556)
        Me.panStatusbar.Name = "panStatusbar"
        Me.panStatusbar.Size = New System.Drawing.Size(699, 21)
        Me.panStatusbar.TabIndex = 29
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(626, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(14, 15)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 32
        Me.PictureBox7.TabStop = False
        '
        'PicRefInt
        '
        Me.PicRefInt.Image = CType(resources.GetObject("PicRefInt.Image"), System.Drawing.Image)
        Me.PicRefInt.Location = New System.Drawing.Point(468, 2)
        Me.PicRefInt.Name = "PicRefInt"
        Me.PicRefInt.Size = New System.Drawing.Size(16, 16)
        Me.PicRefInt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRefInt.TabIndex = 77
        Me.PicRefInt.TabStop = False
        '
        'lblBatPer
        '
        Me.lblBatPer.AutoSize = True
        Me.lblBatPer.ForeColor = System.Drawing.Color.White
        Me.lblBatPer.Location = New System.Drawing.Point(403, 4)
        Me.lblBatPer.Name = "lblBatPer"
        Me.lblBatPer.Size = New System.Drawing.Size(58, 13)
        Me.lblBatPer.TabIndex = 32
        Me.lblBatPer.Text = "Bat : 100 %"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.White
        Me.lblCopyright.Location = New System.Drawing.Point(3, 4)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(93, 13)
        Me.lblCopyright.TabIndex = 29
        Me.lblCopyright.Text = "© 2015 Arvin Soft."
        '
        'tmrSt
        '
        Me.tmrSt.Interval = 1
        '
        'tmrRev
        '
        Me.tmrRev.Interval = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.bttnAbout)
        Me.Panel2.Controls.Add(Me.bttnClose)
        Me.Panel2.Controls.Add(Me.bttnMin)
        Me.Panel2.Location = New System.Drawing.Point(545, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 26)
        Me.Panel2.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(62, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Sys Information v8.0 a1 b93"
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.ForeColor = System.Drawing.Color.White
        Me.lblDebug.Location = New System.Drawing.Point(597, 38)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(65, 13)
        Me.lblDebug.TabIndex = 31
        Me.lblDebug.Text = "Debugging..."
        Me.lblDebug.Visible = False
        '
        'BGwrkrBat
        '
        '
        'tmrBat
        '
        Me.tmrBat.Interval = 10000
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(7, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(52, 52)
        Me.Panel3.TabIndex = 22
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 579)
        Me.Controls.Add(Me.lblDebug)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panStatusbar)
        Me.Controls.Add(Me.lblTit2)
        Me.Controls.Add(Me.lblTit1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panControl)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sys Information 9.0"
        Me.panControl.ResumeLayout(False)
        Me.panSoft.ResumeLayout(False)
        Me.panlblSoft.ResumeLayout(False)
        Me.panlblSoft.PerformLayout()
        Me.panHrd.ResumeLayout(False)
        Me.panlblHrd.ResumeLayout(False)
        Me.panlblHrd.PerformLayout()
        CType(Me.PicInt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panStatusbar.ResumeLayout(False)
        Me.panStatusbar.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRefInt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panControl As System.Windows.Forms.Panel
    Friend WithEvents bttnOs As System.Windows.Forms.Button
    Friend WithEvents bttnOverview As System.Windows.Forms.Button
    Friend WithEvents bttnMther As System.Windows.Forms.Button
    Friend WithEvents bttnMin As System.Windows.Forms.Button
    Friend WithEvents bttnClose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTit1 As System.Windows.Forms.Label
    Friend WithEvents lblTit2 As System.Windows.Forms.Label
    Friend WithEvents bttnAbout As System.Windows.Forms.Button
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents BGwrkrIP As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicInt As System.Windows.Forms.PictureBox
    Friend WithEvents TLTPMn As System.Windows.Forms.ToolTip
    Friend WithEvents bttnInsSoft As System.Windows.Forms.Button
    Friend WithEvents panlblSoft As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panlblHrd As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bttnProAndServ As System.Windows.Forms.Button
    Friend WithEvents bttnHrddsk As System.Windows.Forms.Button
    Friend WithEvents bttnPeriph As System.Windows.Forms.Button
    Friend WithEvents bttnGraphics As System.Windows.Forms.Button
    Friend WithEvents bttnMem As System.Windows.Forms.Button
    Friend WithEvents bttnproc As System.Windows.Forms.Button
    Friend WithEvents lblDttm As System.Windows.Forms.Label
    Friend WithEvents BGwrkrDtTm As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrDtTm As System.Windows.Forms.Timer
    Friend WithEvents bttnBat As System.Windows.Forms.Button
    Friend WithEvents panStatusbar As System.Windows.Forms.Panel
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents tmrSt As System.Windows.Forms.Timer
    Friend WithEvents tmrRev As System.Windows.Forms.Timer
    Friend WithEvents panSoft As System.Windows.Forms.Panel
    Friend WithEvents panHrd As System.Windows.Forms.Panel
    Friend WithEvents lblCESoft As System.Windows.Forms.Label
    Friend WithEvents lblCEhrd As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDebug As System.Windows.Forms.Label
    Friend WithEvents lblBatPer As System.Windows.Forms.Label
    Friend WithEvents BGwrkrBat As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrBat As System.Windows.Forms.Timer
    Friend WithEvents PicRefInt As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox

End Class
