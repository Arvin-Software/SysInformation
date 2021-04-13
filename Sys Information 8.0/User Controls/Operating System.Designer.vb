<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operating_System
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operating_System))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSysLstBotDt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSysUP = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lollogged = New System.Windows.Forms.Label()
        Me.lblOsCurrentUser = New System.Windows.Forms.Label()
        Me.lblOSOrganisation = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblOSRegUser = New System.Windows.Forms.Label()
        Me.lolserial = New System.Windows.Forms.Label()
        Me.lblOSSerialNumber = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TableLayoutOS = New System.Windows.Forms.TableLayoutPanel()
        Me.lolsysdir = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.lblOSSystemDir = New System.Windows.Forms.Label()
        Me.lblOSWindowsDir = New System.Windows.Forms.Label()
        Me.lblOSBootDevice = New System.Windows.Forms.Label()
        Me.lolinst = New System.Windows.Forms.Label()
        Me.lblOSInstallationDate = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lolbuildtyp = New System.Windows.Forms.Label()
        Me.lblOperBuildTyp = New System.Windows.Forms.Label()
        Me.lolplat = New System.Windows.Forms.Label()
        Me.lblOsPlatform = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOSEdition = New System.Windows.Forms.Label()
        Me.lolvers = New System.Windows.Forms.Label()
        Me.lblOSVers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmrSysUpt = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BgwrkrSysUpt = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstSpecialFolders = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutOS.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblSysLstBotDt, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSysUP, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lollogged, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOsCurrentUser, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSOrganisation, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label32, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSRegUser, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lolserial, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSSerialNumber, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label30, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(59, 277)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(177, 132)
        Me.TableLayoutPanel1.TabIndex = 84
        '
        'lblSysLstBotDt
        '
        Me.lblSysLstBotDt.AutoSize = True
        Me.lblSysLstBotDt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysLstBotDt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysLstBotDt.ForeColor = System.Drawing.Color.Black
        Me.lblSysLstBotDt.Location = New System.Drawing.Point(150, 114)
        Me.lblSysLstBotDt.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysLstBotDt.Name = "lblSysLstBotDt"
        Me.lblSysLstBotDt.Size = New System.Drawing.Size(23, 14)
        Me.lblSysLstBotDt.TabIndex = 51
        Me.lblSysLstBotDt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 92)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 14)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "System uptime:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysUP
        '
        Me.lblSysUP.AutoSize = True
        Me.lblSysUP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysUP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysUP.ForeColor = System.Drawing.Color.Black
        Me.lblSysUP.Location = New System.Drawing.Point(150, 92)
        Me.lblSysUP.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysUP.Name = "lblSysUP"
        Me.lblSysUP.Size = New System.Drawing.Size(23, 14)
        Me.lblSysUP.TabIndex = 49
        Me.lblSysUP.Text = "    "
        Me.lblSysUP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 14)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "System is running since:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lollogged
        '
        Me.lollogged.AutoSize = True
        Me.lollogged.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lollogged.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lollogged.ForeColor = System.Drawing.Color.Black
        Me.lollogged.Location = New System.Drawing.Point(4, 70)
        Me.lollogged.Margin = New System.Windows.Forms.Padding(4)
        Me.lollogged.Name = "lollogged"
        Me.lollogged.Size = New System.Drawing.Size(138, 14)
        Me.lollogged.TabIndex = 47
        Me.lollogged.Text = "Logged in as:"
        Me.lollogged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOsCurrentUser
        '
        Me.lblOsCurrentUser.AutoSize = True
        Me.lblOsCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOsCurrentUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOsCurrentUser.ForeColor = System.Drawing.Color.Black
        Me.lblOsCurrentUser.Location = New System.Drawing.Point(150, 70)
        Me.lblOsCurrentUser.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOsCurrentUser.Name = "lblOsCurrentUser"
        Me.lblOsCurrentUser.Size = New System.Drawing.Size(23, 14)
        Me.lblOsCurrentUser.TabIndex = 46
        Me.lblOsCurrentUser.Text = "    "
        Me.lblOsCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSOrganisation
        '
        Me.lblOSOrganisation.AutoSize = True
        Me.lblOSOrganisation.BackColor = System.Drawing.Color.Transparent
        Me.lblOSOrganisation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSOrganisation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSOrganisation.ForeColor = System.Drawing.Color.Black
        Me.lblOSOrganisation.Location = New System.Drawing.Point(150, 26)
        Me.lblOSOrganisation.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSOrganisation.Name = "lblOSOrganisation"
        Me.lblOSOrganisation.Size = New System.Drawing.Size(23, 14)
        Me.lblOSOrganisation.TabIndex = 44
        Me.lblOSOrganisation.Text = "    "
        Me.lblOSOrganisation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(4, 26)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(138, 14)
        Me.Label32.TabIndex = 45
        Me.Label32.Text = "Organisation:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSRegUser
        '
        Me.lblOSRegUser.AutoSize = True
        Me.lblOSRegUser.BackColor = System.Drawing.Color.Transparent
        Me.lblOSRegUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSRegUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSRegUser.ForeColor = System.Drawing.Color.Black
        Me.lblOSRegUser.Location = New System.Drawing.Point(150, 4)
        Me.lblOSRegUser.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSRegUser.Name = "lblOSRegUser"
        Me.lblOSRegUser.Size = New System.Drawing.Size(23, 14)
        Me.lblOSRegUser.TabIndex = 43
        Me.lblOSRegUser.Text = "    "
        Me.lblOSRegUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lolserial
        '
        Me.lolserial.AutoSize = True
        Me.lolserial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lolserial.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lolserial.ForeColor = System.Drawing.Color.Black
        Me.lolserial.Location = New System.Drawing.Point(4, 48)
        Me.lolserial.Margin = New System.Windows.Forms.Padding(4)
        Me.lolserial.Name = "lolserial"
        Me.lolserial.Size = New System.Drawing.Size(138, 14)
        Me.lolserial.TabIndex = 33
        Me.lolserial.Text = "Serial Number:"
        Me.lolserial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSSerialNumber
        '
        Me.lblOSSerialNumber.AutoSize = True
        Me.lblOSSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblOSSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSSerialNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSSerialNumber.ForeColor = System.Drawing.Color.Black
        Me.lblOSSerialNumber.Location = New System.Drawing.Point(150, 48)
        Me.lblOSSerialNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSSerialNumber.Name = "lblOSSerialNumber"
        Me.lblOSSerialNumber.Size = New System.Drawing.Size(23, 14)
        Me.lblOSSerialNumber.TabIndex = 32
        Me.lblOSSerialNumber.Text = "    "
        Me.lblOSSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(4, 4)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(138, 14)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "Registered User:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutOS
        '
        Me.TableLayoutOS.AutoSize = True
        Me.TableLayoutOS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutOS.ColumnCount = 2
        Me.TableLayoutOS.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutOS.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutOS.Controls.Add(Me.lolsysdir, 0, 0)
        Me.TableLayoutOS.Controls.Add(Me.Label55, 0, 1)
        Me.TableLayoutOS.Controls.Add(Me.Label54, 0, 2)
        Me.TableLayoutOS.Controls.Add(Me.lblOSSystemDir, 1, 0)
        Me.TableLayoutOS.Controls.Add(Me.lblOSWindowsDir, 1, 1)
        Me.TableLayoutOS.Controls.Add(Me.lblOSBootDevice, 1, 2)
        Me.TableLayoutOS.Controls.Add(Me.lolinst, 0, 3)
        Me.TableLayoutOS.Controls.Add(Me.lblOSInstallationDate, 1, 3)
        Me.TableLayoutOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutOS.Location = New System.Drawing.Point(59, 138)
        Me.TableLayoutOS.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutOS.Name = "TableLayoutOS"
        Me.TableLayoutOS.RowCount = 4
        Me.TableLayoutOS.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutOS.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutOS.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutOS.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutOS.Size = New System.Drawing.Size(161, 88)
        Me.TableLayoutOS.TabIndex = 83
        '
        'lolsysdir
        '
        Me.lolsysdir.AutoSize = True
        Me.lolsysdir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lolsysdir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lolsysdir.ForeColor = System.Drawing.Color.Black
        Me.lolsysdir.Location = New System.Drawing.Point(4, 4)
        Me.lolsysdir.Margin = New System.Windows.Forms.Padding(4)
        Me.lolsysdir.Name = "lolsysdir"
        Me.lolsysdir.Size = New System.Drawing.Size(122, 14)
        Me.lolsysdir.TabIndex = 48
        Me.lolsysdir.Text = "System Directory:"
        Me.lolsysdir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(4, 26)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(122, 14)
        Me.Label55.TabIndex = 50
        Me.Label55.Text = "Windows Directory:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(4, 48)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(122, 14)
        Me.Label54.TabIndex = 52
        Me.Label54.Text = "Boot Device:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSSystemDir
        '
        Me.lblOSSystemDir.AutoEllipsis = True
        Me.lblOSSystemDir.AutoSize = True
        Me.lblOSSystemDir.BackColor = System.Drawing.Color.Transparent
        Me.lblOSSystemDir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSSystemDir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSSystemDir.ForeColor = System.Drawing.Color.Black
        Me.lblOSSystemDir.Location = New System.Drawing.Point(134, 4)
        Me.lblOSSystemDir.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSSystemDir.Name = "lblOSSystemDir"
        Me.lblOSSystemDir.Size = New System.Drawing.Size(23, 14)
        Me.lblOSSystemDir.TabIndex = 49
        Me.lblOSSystemDir.Text = "    "
        Me.lblOSSystemDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSWindowsDir
        '
        Me.lblOSWindowsDir.AutoEllipsis = True
        Me.lblOSWindowsDir.AutoSize = True
        Me.lblOSWindowsDir.BackColor = System.Drawing.Color.Transparent
        Me.lblOSWindowsDir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSWindowsDir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSWindowsDir.ForeColor = System.Drawing.Color.Black
        Me.lblOSWindowsDir.Location = New System.Drawing.Point(134, 26)
        Me.lblOSWindowsDir.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSWindowsDir.Name = "lblOSWindowsDir"
        Me.lblOSWindowsDir.Size = New System.Drawing.Size(23, 14)
        Me.lblOSWindowsDir.TabIndex = 51
        Me.lblOSWindowsDir.Text = "    "
        Me.lblOSWindowsDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSBootDevice
        '
        Me.lblOSBootDevice.AutoEllipsis = True
        Me.lblOSBootDevice.AutoSize = True
        Me.lblOSBootDevice.BackColor = System.Drawing.Color.Transparent
        Me.lblOSBootDevice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSBootDevice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSBootDevice.ForeColor = System.Drawing.Color.Black
        Me.lblOSBootDevice.Location = New System.Drawing.Point(134, 48)
        Me.lblOSBootDevice.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSBootDevice.Name = "lblOSBootDevice"
        Me.lblOSBootDevice.Size = New System.Drawing.Size(23, 14)
        Me.lblOSBootDevice.TabIndex = 53
        Me.lblOSBootDevice.Text = "    "
        Me.lblOSBootDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lolinst
        '
        Me.lolinst.AutoSize = True
        Me.lolinst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lolinst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lolinst.ForeColor = System.Drawing.Color.Black
        Me.lolinst.Location = New System.Drawing.Point(4, 70)
        Me.lolinst.Margin = New System.Windows.Forms.Padding(4)
        Me.lolinst.Name = "lolinst"
        Me.lolinst.Size = New System.Drawing.Size(122, 14)
        Me.lolinst.TabIndex = 39
        Me.lolinst.Text = "Installed:"
        Me.lolinst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSInstallationDate
        '
        Me.lblOSInstallationDate.AutoEllipsis = True
        Me.lblOSInstallationDate.AutoSize = True
        Me.lblOSInstallationDate.BackColor = System.Drawing.Color.Transparent
        Me.lblOSInstallationDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSInstallationDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSInstallationDate.ForeColor = System.Drawing.Color.Black
        Me.lblOSInstallationDate.Location = New System.Drawing.Point(134, 70)
        Me.lblOSInstallationDate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSInstallationDate.Name = "lblOSInstallationDate"
        Me.lblOSInstallationDate.Size = New System.Drawing.Size(23, 14)
        Me.lblOSInstallationDate.TabIndex = 38
        Me.lblOSInstallationDate.Text = "    "
        Me.lblOSInstallationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lolbuildtyp, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOperBuildTyp, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.lolplat, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOsPlatform, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOSEdition, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lolvers, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOSVers, 1, 1)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(59, 45)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(160, 92)
        Me.TableLayoutPanel2.TabIndex = 82
        '
        'lolbuildtyp
        '
        Me.lolbuildtyp.AutoEllipsis = True
        Me.lolbuildtyp.AutoSize = True
        Me.lolbuildtyp.BackColor = System.Drawing.Color.Transparent
        Me.lolbuildtyp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lolbuildtyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lolbuildtyp.ForeColor = System.Drawing.Color.Black
        Me.lolbuildtyp.Location = New System.Drawing.Point(4, 73)
        Me.lolbuildtyp.Margin = New System.Windows.Forms.Padding(4)
        Me.lolbuildtyp.Name = "lolbuildtyp"
        Me.lolbuildtyp.Size = New System.Drawing.Size(122, 15)
        Me.lolbuildtyp.TabIndex = 39
        Me.lolbuildtyp.Text = "Build Type:"
        Me.lolbuildtyp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOperBuildTyp
        '
        Me.lblOperBuildTyp.AutoEllipsis = True
        Me.lblOperBuildTyp.AutoSize = True
        Me.lblOperBuildTyp.BackColor = System.Drawing.Color.Transparent
        Me.lblOperBuildTyp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOperBuildTyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperBuildTyp.ForeColor = System.Drawing.Color.Black
        Me.lblOperBuildTyp.Location = New System.Drawing.Point(134, 73)
        Me.lblOperBuildTyp.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOperBuildTyp.Name = "lblOperBuildTyp"
        Me.lblOperBuildTyp.Size = New System.Drawing.Size(22, 15)
        Me.lblOperBuildTyp.TabIndex = 38
        Me.lblOperBuildTyp.Text = "     "
        Me.lblOperBuildTyp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lolplat
        '
        Me.lolplat.AutoEllipsis = True
        Me.lolplat.AutoSize = True
        Me.lolplat.BackColor = System.Drawing.Color.Transparent
        Me.lolplat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lolplat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lolplat.ForeColor = System.Drawing.Color.Black
        Me.lolplat.Location = New System.Drawing.Point(4, 50)
        Me.lolplat.Margin = New System.Windows.Forms.Padding(4)
        Me.lolplat.Name = "lolplat"
        Me.lolplat.Size = New System.Drawing.Size(122, 15)
        Me.lolplat.TabIndex = 37
        Me.lolplat.Text = "Platform"
        Me.lolplat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOsPlatform
        '
        Me.lblOsPlatform.AutoEllipsis = True
        Me.lblOsPlatform.AutoSize = True
        Me.lblOsPlatform.BackColor = System.Drawing.Color.Transparent
        Me.lblOsPlatform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOsPlatform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOsPlatform.ForeColor = System.Drawing.Color.Black
        Me.lblOsPlatform.Location = New System.Drawing.Point(134, 50)
        Me.lblOsPlatform.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOsPlatform.Name = "lblOsPlatform"
        Me.lblOsPlatform.Size = New System.Drawing.Size(22, 15)
        Me.lblOsPlatform.TabIndex = 36
        Me.lblOsPlatform.Text = "     "
        Me.lblOsPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Windows Edition:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSEdition
        '
        Me.lblOSEdition.AutoEllipsis = True
        Me.lblOSEdition.AutoSize = True
        Me.lblOSEdition.BackColor = System.Drawing.Color.Transparent
        Me.lblOSEdition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSEdition.ForeColor = System.Drawing.Color.Black
        Me.lblOSEdition.Location = New System.Drawing.Point(134, 4)
        Me.lblOSEdition.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSEdition.Name = "lblOSEdition"
        Me.lblOSEdition.Size = New System.Drawing.Size(22, 15)
        Me.lblOSEdition.TabIndex = 29
        Me.lblOSEdition.Text = "    "
        Me.lblOSEdition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lolvers
        '
        Me.lolvers.AutoSize = True
        Me.lolvers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lolvers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lolvers.ForeColor = System.Drawing.Color.Black
        Me.lolvers.Location = New System.Drawing.Point(4, 27)
        Me.lolvers.Margin = New System.Windows.Forms.Padding(4)
        Me.lolvers.Name = "lolvers"
        Me.lolvers.Size = New System.Drawing.Size(122, 15)
        Me.lolvers.TabIndex = 34
        Me.lolvers.Text = "Version:"
        Me.lolvers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSVers
        '
        Me.lblOSVers.AutoEllipsis = True
        Me.lblOSVers.AutoSize = True
        Me.lblOSVers.BackColor = System.Drawing.Color.Transparent
        Me.lblOSVers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSVers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSVers.ForeColor = System.Drawing.Color.Black
        Me.lblOSVers.Location = New System.Drawing.Point(134, 27)
        Me.lblOSVers.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSVers.Name = "lblOSVers"
        Me.lblOSVers.Size = New System.Drawing.Size(22, 15)
        Me.lblOSVers.TabIndex = 35
        Me.lblOSVers.Text = "    "
        Me.lblOSVers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(51, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Operating System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(51, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Other Information"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 0
        '
        'tmrSysUpt
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 25)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Operating System"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, 243)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 88
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'BgwrkrSysUpt
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(539, 444)
        Me.TabControl1.TabIndex = 89
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.TableLayoutOS)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(531, 418)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Os Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstSpecialFolders)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(531, 418)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Special Folders"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstSpecialFolders
        '
        Me.lstSpecialFolders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstSpecialFolders.Location = New System.Drawing.Point(3, 6)
        Me.lstSpecialFolders.Name = "lstSpecialFolders"
        Me.lstSpecialFolders.Size = New System.Drawing.Size(525, 409)
        Me.lstSpecialFolders.TabIndex = 0
        Me.lstSpecialFolders.UseCompatibleStateImageBehavior = False
        Me.lstSpecialFolders.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Folder"
        Me.ColumnHeader1.Width = 185
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Folder Path"
        Me.ColumnHeader2.Width = 314
        '
        'Operating_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Operating_System"
        Me.Size = New System.Drawing.Size(545, 485)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutOS.ResumeLayout(False)
        Me.TableLayoutOS.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lollogged As System.Windows.Forms.Label
    Friend WithEvents lblOsCurrentUser As System.Windows.Forms.Label
    Friend WithEvents lblOSOrganisation As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblOSRegUser As System.Windows.Forms.Label
    Friend WithEvents lolserial As System.Windows.Forms.Label
    Friend WithEvents lblOSSerialNumber As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutOS As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lolsysdir As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents lblOSSystemDir As System.Windows.Forms.Label
    Friend WithEvents lblOSWindowsDir As System.Windows.Forms.Label
    Friend WithEvents lblOSBootDevice As System.Windows.Forms.Label
    Friend WithEvents lolinst As System.Windows.Forms.Label
    Friend WithEvents lblOSInstallationDate As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lolbuildtyp As System.Windows.Forms.Label
    Friend WithEvents lblOperBuildTyp As System.Windows.Forms.Label
    Friend WithEvents lolplat As System.Windows.Forms.Label
    Friend WithEvents lblOsPlatform As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblOSEdition As System.Windows.Forms.Label
    Friend WithEvents lolvers As System.Windows.Forms.Label
    Friend WithEvents lblOSVers As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSysUP As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSysLstBotDt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tmrSysUpt As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BgwrkrSysUpt As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lstSpecialFolders As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader

End Class
