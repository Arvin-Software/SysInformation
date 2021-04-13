<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Motherboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Motherboard))
        Me.LstOnBrd = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBiosVersion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblBiosMake = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSMBiosVersion = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.lblBiosDate = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSecBsTyp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPriBsTyp = New System.Windows.Forms.Label()
        Me.lblMoBoSerialNumber = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMoBoMake = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMoBoModel = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.lblMoBoRevision = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstOnBrd
        '
        Me.LstOnBrd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LstOnBrd.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOnBrd.Location = New System.Drawing.Point(80, 375)
        Me.LstOnBrd.Name = "LstOnBrd"
        Me.LstOnBrd.Size = New System.Drawing.Size(410, 94)
        Me.LstOnBrd.TabIndex = 95
        Me.LstOnBrd.UseCompatibleStateImageBehavior = False
        Me.LstOnBrd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Device Name"
        Me.ColumnHeader1.Width = 193
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 182
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(62, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "On board device"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(62, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "BIOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(62, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Motherboard"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lblBiosVersion, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblBiosMake, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSMBiosVersion, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label88, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblBiosDate, 1, 3)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(80, 249)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(161, 88)
        Me.TableLayoutPanel2.TabIndex = 88
        '
        'lblBiosVersion
        '
        Me.lblBiosVersion.AutoSize = True
        Me.lblBiosVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblBiosVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBiosVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiosVersion.ForeColor = System.Drawing.Color.Black
        Me.lblBiosVersion.Location = New System.Drawing.Point(134, 48)
        Me.lblBiosVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBiosVersion.Name = "lblBiosVersion"
        Me.lblBiosVersion.Size = New System.Drawing.Size(23, 14)
        Me.lblBiosVersion.TabIndex = 75
        Me.lblBiosVersion.Text = "    "
        Me.lblBiosVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 14)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "BIOS Version:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 4)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 14)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Manufacturer:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBiosMake
        '
        Me.lblBiosMake.AutoSize = True
        Me.lblBiosMake.BackColor = System.Drawing.Color.Transparent
        Me.lblBiosMake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBiosMake.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiosMake.ForeColor = System.Drawing.Color.Black
        Me.lblBiosMake.Location = New System.Drawing.Point(134, 4)
        Me.lblBiosMake.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBiosMake.Name = "lblBiosMake"
        Me.lblBiosMake.Size = New System.Drawing.Size(23, 14)
        Me.lblBiosMake.TabIndex = 64
        Me.lblBiosMake.Text = "    "
        Me.lblBiosMake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 26)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 14)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "SMBIOS Version:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSMBiosVersion
        '
        Me.lblSMBiosVersion.AutoSize = True
        Me.lblSMBiosVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblSMBiosVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSMBiosVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMBiosVersion.ForeColor = System.Drawing.Color.Black
        Me.lblSMBiosVersion.Location = New System.Drawing.Point(134, 26)
        Me.lblSMBiosVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSMBiosVersion.Name = "lblSMBiosVersion"
        Me.lblSMBiosVersion.Size = New System.Drawing.Size(23, 14)
        Me.lblSMBiosVersion.TabIndex = 65
        Me.lblSMBiosVersion.Text = "    "
        Me.lblSMBiosVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label88.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(4, 70)
        Me.Label88.Margin = New System.Windows.Forms.Padding(4)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(122, 14)
        Me.Label88.TabIndex = 66
        Me.Label88.Text = "Release Date:"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBiosDate
        '
        Me.lblBiosDate.AutoSize = True
        Me.lblBiosDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBiosDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBiosDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiosDate.ForeColor = System.Drawing.Color.Black
        Me.lblBiosDate.Location = New System.Drawing.Point(134, 70)
        Me.lblBiosDate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBiosDate.Name = "lblBiosDate"
        Me.lblBiosDate.Size = New System.Drawing.Size(23, 14)
        Me.lblBiosDate.TabIndex = 66
        Me.lblBiosDate.Text = "    "
        Me.lblBiosDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSecBsTyp, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPriBsTyp, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoBoSerialNumber, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoBoMake, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoBoModel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label94, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoBoRevision, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label89, 0, 3)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(80, 88)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(162, 132)
        Me.TableLayoutPanel1.TabIndex = 87
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 114)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 14)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Secondary Bus Type:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSecBsTyp
        '
        Me.lblSecBsTyp.AutoSize = True
        Me.lblSecBsTyp.BackColor = System.Drawing.Color.Transparent
        Me.lblSecBsTyp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSecBsTyp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecBsTyp.ForeColor = System.Drawing.Color.Black
        Me.lblSecBsTyp.Location = New System.Drawing.Point(135, 114)
        Me.lblSecBsTyp.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSecBsTyp.Name = "lblSecBsTyp"
        Me.lblSecBsTyp.Size = New System.Drawing.Size(23, 14)
        Me.lblSecBsTyp.TabIndex = 72
        Me.lblSecBsTyp.Text = "    "
        Me.lblSecBsTyp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 14)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Primary Bus Type:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPriBsTyp
        '
        Me.lblPriBsTyp.AutoSize = True
        Me.lblPriBsTyp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPriBsTyp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriBsTyp.ForeColor = System.Drawing.Color.Black
        Me.lblPriBsTyp.Location = New System.Drawing.Point(135, 92)
        Me.lblPriBsTyp.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPriBsTyp.Name = "lblPriBsTyp"
        Me.lblPriBsTyp.Size = New System.Drawing.Size(23, 14)
        Me.lblPriBsTyp.TabIndex = 70
        Me.lblPriBsTyp.Text = "    "
        Me.lblPriBsTyp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoBoSerialNumber
        '
        Me.lblMoBoSerialNumber.AutoSize = True
        Me.lblMoBoSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblMoBoSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoBoSerialNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoBoSerialNumber.ForeColor = System.Drawing.Color.Black
        Me.lblMoBoSerialNumber.Location = New System.Drawing.Point(135, 70)
        Me.lblMoBoSerialNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoBoSerialNumber.Name = "lblMoBoSerialNumber"
        Me.lblMoBoSerialNumber.Size = New System.Drawing.Size(23, 14)
        Me.lblMoBoSerialNumber.TabIndex = 66
        Me.lblMoBoSerialNumber.Text = "    "
        Me.lblMoBoSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 14)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Manufacturer:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoBoMake
        '
        Me.lblMoBoMake.AutoSize = True
        Me.lblMoBoMake.BackColor = System.Drawing.Color.Transparent
        Me.lblMoBoMake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoBoMake.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoBoMake.ForeColor = System.Drawing.Color.Black
        Me.lblMoBoMake.Location = New System.Drawing.Point(135, 4)
        Me.lblMoBoMake.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoBoMake.Name = "lblMoBoMake"
        Me.lblMoBoMake.Size = New System.Drawing.Size(23, 14)
        Me.lblMoBoMake.TabIndex = 64
        Me.lblMoBoMake.Text = "    "
        Me.lblMoBoMake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 14)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Model:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoBoModel
        '
        Me.lblMoBoModel.AutoSize = True
        Me.lblMoBoModel.BackColor = System.Drawing.Color.Transparent
        Me.lblMoBoModel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoBoModel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoBoModel.ForeColor = System.Drawing.Color.Black
        Me.lblMoBoModel.Location = New System.Drawing.Point(135, 26)
        Me.lblMoBoModel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoBoModel.Name = "lblMoBoModel"
        Me.lblMoBoModel.Size = New System.Drawing.Size(23, 14)
        Me.lblMoBoModel.TabIndex = 65
        Me.lblMoBoModel.Text = "    "
        Me.lblMoBoModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label94.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(4, 48)
        Me.Label94.Margin = New System.Windows.Forms.Padding(4)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(123, 14)
        Me.Label94.TabIndex = 68
        Me.Label94.Text = "Version:"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoBoRevision
        '
        Me.lblMoBoRevision.AutoSize = True
        Me.lblMoBoRevision.BackColor = System.Drawing.Color.Transparent
        Me.lblMoBoRevision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoBoRevision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoBoRevision.ForeColor = System.Drawing.Color.Black
        Me.lblMoBoRevision.Location = New System.Drawing.Point(135, 48)
        Me.lblMoBoRevision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoBoRevision.Name = "lblMoBoRevision"
        Me.lblMoBoRevision.Size = New System.Drawing.Size(23, 14)
        Me.lblMoBoRevision.TabIndex = 67
        Me.lblMoBoRevision.Text = "    "
        Me.lblMoBoRevision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label89.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(4, 70)
        Me.Label89.Margin = New System.Windows.Forms.Padding(4)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(123, 14)
        Me.Label89.TabIndex = 67
        Me.Label89.Text = "Serial Number:"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(32, 222)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 99
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
        Me.Panel1.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Motherboard"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 96
        Me.PictureBox1.TabStop = False
        '
        'Motherboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LstOnBrd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Motherboard"
        Me.Size = New System.Drawing.Size(545, 485)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstOnBrd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblBiosVersion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblBiosMake As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblSMBiosVersion As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents lblBiosDate As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSecBsTyp As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPriBsTyp As System.Windows.Forms.Label
    Friend WithEvents lblMoBoSerialNumber As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMoBoMake As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMoBoModel As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents lblMoBoRevision As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
