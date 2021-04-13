<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Networke
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Networke))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDHCPAdd = New System.Windows.Forms.Label()
        Me.lblNetDHCPEn = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNetNam = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNetMacAdd = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstDNSServers = New System.Windows.Forms.ListBox()
        Me.BGwrkrIP = New System.ComponentModel.BackgroundWorker()
        Me.tlTp = New System.Windows.Forms.ToolTip(Me.components)
        Me.PicRefInt = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.picCon = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picdisCon = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNoInfo = New System.Windows.Forms.Label()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.lblIPV6Add = New System.Windows.Forms.Label()
        Me.lblIPV6AddLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PicRefInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picdisCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDHCPAdd, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNetDHCPEn, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNetNam, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNetMacAdd, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label89, 0, 3)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(56, 170)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(157, 88)
        Me.TableLayoutPanel1.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 14)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "DHCP Address :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDHCPAdd
        '
        Me.lblDHCPAdd.AutoSize = True
        Me.lblDHCPAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDHCPAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDHCPAdd.ForeColor = System.Drawing.Color.Black
        Me.lblDHCPAdd.Location = New System.Drawing.Point(153, 70)
        Me.lblDHCPAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDHCPAdd.Name = "lblDHCPAdd"
        Me.lblDHCPAdd.Size = New System.Drawing.Size(1, 14)
        Me.lblDHCPAdd.TabIndex = 70
        Me.lblDHCPAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNetDHCPEn
        '
        Me.lblNetDHCPEn.AutoSize = True
        Me.lblNetDHCPEn.BackColor = System.Drawing.Color.Transparent
        Me.lblNetDHCPEn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNetDHCPEn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetDHCPEn.ForeColor = System.Drawing.Color.Black
        Me.lblNetDHCPEn.Location = New System.Drawing.Point(153, 48)
        Me.lblNetDHCPEn.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNetDHCPEn.Name = "lblNetDHCPEn"
        Me.lblNetDHCPEn.Size = New System.Drawing.Size(1, 14)
        Me.lblNetDHCPEn.TabIndex = 66
        Me.lblNetDHCPEn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 14)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Adapter name :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNetNam
        '
        Me.lblNetNam.AutoSize = True
        Me.lblNetNam.BackColor = System.Drawing.Color.Transparent
        Me.lblNetNam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNetNam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetNam.ForeColor = System.Drawing.Color.Black
        Me.lblNetNam.Location = New System.Drawing.Point(153, 4)
        Me.lblNetNam.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNetNam.Name = "lblNetNam"
        Me.lblNetNam.Size = New System.Drawing.Size(1, 14)
        Me.lblNetNam.TabIndex = 64
        Me.lblNetNam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 14)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Physical (MAC) Address :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNetMacAdd
        '
        Me.lblNetMacAdd.AutoSize = True
        Me.lblNetMacAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblNetMacAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNetMacAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetMacAdd.ForeColor = System.Drawing.Color.Black
        Me.lblNetMacAdd.Location = New System.Drawing.Point(153, 26)
        Me.lblNetMacAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNetMacAdd.Name = "lblNetMacAdd"
        Me.lblNetMacAdd.Size = New System.Drawing.Size(1, 14)
        Me.lblNetMacAdd.TabIndex = 65
        Me.lblNetMacAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label89.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(4, 48)
        Me.Label89.Margin = New System.Windows.Forms.Padding(4)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(141, 14)
        Me.Label89.TabIndex = 67
        Me.Label89.Text = "DHCP Enabled :"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(60, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 14)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "DNS Servers :"
        '
        'lstDNSServers
        '
        Me.lstDNSServers.BackColor = System.Drawing.Color.White
        Me.lstDNSServers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstDNSServers.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lstDNSServers.FormattingEnabled = True
        Me.lstDNSServers.ItemHeight = 14
        Me.lstDNSServers.Location = New System.Drawing.Point(210, 262)
        Me.lstDNSServers.Name = "lstDNSServers"
        Me.lstDNSServers.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstDNSServers.Size = New System.Drawing.Size(205, 56)
        Me.lstDNSServers.TabIndex = 128
        '
        'BGwrkrIP
        '
        '
        'PicRefInt
        '
        Me.PicRefInt.BackColor = System.Drawing.Color.Transparent
        Me.PicRefInt.Image = CType(resources.GetObject("PicRefInt.Image"), System.Drawing.Image)
        Me.PicRefInt.Location = New System.Drawing.Point(357, 44)
        Me.PicRefInt.Name = "PicRefInt"
        Me.PicRefInt.Size = New System.Drawing.Size(16, 16)
        Me.PicRefInt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRefInt.TabIndex = 129
        Me.PicRefInt.TabStop = False
        Me.tlTp.SetToolTip(Me.PicRefInt, "Click to refresh the internet status. To let the software check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for internet sta" & _
                "tus on software startup see settings.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(18, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Adapter Information"
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.BackColor = System.Drawing.Color.Transparent
        Me.lblInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInt.Location = New System.Drawing.Point(119, 34)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(232, 26)
        Me.lblInt.TabIndex = 133
        Me.lblInt.Text = "Internet : Not Available"
        '
        'picCon
        '
        Me.picCon.BackColor = System.Drawing.Color.Transparent
        Me.picCon.Image = Global.Sys_Information_8._0.My.Resources.Resources._1358976246_netscape
        Me.picCon.Location = New System.Drawing.Point(47, 23)
        Me.picCon.Name = "picCon"
        Me.picCon.Size = New System.Drawing.Size(48, 48)
        Me.picCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCon.TabIndex = 134
        Me.picCon.TabStop = False
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
        Me.Panel1.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Network"
        '
        'picdisCon
        '
        Me.picdisCon.BackColor = System.Drawing.Color.Transparent
        Me.picdisCon.Image = Global.Sys_Information_8._0.My.Resources.Resources._1358976484_browser
        Me.picdisCon.Location = New System.Drawing.Point(47, 23)
        Me.picdisCon.Name = "picdisCon"
        Me.picdisCon.Size = New System.Drawing.Size(48, 48)
        Me.picdisCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picdisCon.TabIndex = 135
        Me.picdisCon.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblInt)
        Me.Panel2.Controls.Add(Me.PicRefInt)
        Me.Panel2.Controls.Add(Me.picCon)
        Me.Panel2.Controls.Add(Me.picdisCon)
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 100)
        Me.Panel2.TabIndex = 136
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Sys_Information_8._0.My.Resources.Resources.Sys_Information_splash1
        Me.PictureBox1.Location = New System.Drawing.Point(20, 437)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 5)
        Me.PictureBox1.TabIndex = 137
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 452)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(459, 15)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "If there is no adapter information you are probably connected to a dialup connect" & _
            "ion"
        '
        'lblNoInfo
        '
        Me.lblNoInfo.AutoSize = True
        Me.lblNoInfo.Location = New System.Drawing.Point(89, 167)
        Me.lblNoInfo.Name = "lblNoInfo"
        Me.lblNoInfo.Size = New System.Drawing.Size(120, 13)
        Me.lblNoInfo.TabIndex = 139
        Me.lblNoInfo.Text = "No information available"
        Me.lblNoInfo.Visible = False
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblAddr.Location = New System.Drawing.Point(60, 331)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(86, 14)
        Me.lblAddr.TabIndex = 140
        Me.lblAddr.Text = "IPv4 Address :"
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPAddress.Location = New System.Drawing.Point(207, 331)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(42, 14)
        Me.lblIPAddress.TabIndex = 141
        Me.lblIPAddress.Text = "Label8"
        '
        'lblIPV6Add
        '
        Me.lblIPV6Add.AutoSize = True
        Me.lblIPV6Add.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPV6Add.Location = New System.Drawing.Point(207, 355)
        Me.lblIPV6Add.Name = "lblIPV6Add"
        Me.lblIPV6Add.Size = New System.Drawing.Size(42, 14)
        Me.lblIPV6Add.TabIndex = 143
        Me.lblIPV6Add.Text = "Label8"
        '
        'lblIPV6AddLabel
        '
        Me.lblIPV6AddLabel.AutoSize = True
        Me.lblIPV6AddLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblIPV6AddLabel.Location = New System.Drawing.Point(60, 355)
        Me.lblIPV6AddLabel.Name = "lblIPV6AddLabel"
        Me.lblIPV6AddLabel.Size = New System.Drawing.Size(86, 14)
        Me.lblIPV6AddLabel.TabIndex = 142
        Me.lblIPV6AddLabel.Text = "IPv6 Address :"
        '
        'Networke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblIPV6Add)
        Me.Controls.Add(Me.lblIPV6AddLabel)
        Me.Controls.Add(Me.lblIPAddress)
        Me.Controls.Add(Me.lblAddr)
        Me.Controls.Add(Me.lblNoInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstDNSServers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Networke"
        Me.Size = New System.Drawing.Size(545, 485)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PicRefInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picdisCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDHCPAdd As System.Windows.Forms.Label
    Friend WithEvents lblNetDHCPEn As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblNetNam As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblNetMacAdd As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstDNSServers As System.Windows.Forms.ListBox
    Friend WithEvents PicRefInt As System.Windows.Forms.PictureBox
    Friend WithEvents BGwrkrIP As System.ComponentModel.BackgroundWorker
    Friend WithEvents tlTp As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblInt As System.Windows.Forms.Label
    Friend WithEvents picCon As System.Windows.Forms.PictureBox
    Friend WithEvents picdisCon As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNoInfo As System.Windows.Forms.Label
    Friend WithEvents lblAddr As System.Windows.Forms.Label
    Friend WithEvents lblIPAddress As System.Windows.Forms.Label
    Friend WithEvents lblIPV6Add As System.Windows.Forms.Label
    Friend WithEvents lblIPV6AddLabel As System.Windows.Forms.Label

End Class
