<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Battery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Battery))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblbattimrem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblbatlevel = New System.Windows.Forms.Label()
        Me.lblbattech = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblbatMake = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblbattyp = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.lblbatstatus = New System.Windows.Forms.Label()
        Me.batTech = New System.Windows.Forms.Label()
        Me.BGWRbatref = New System.ComponentModel.BackgroundWorker()
        Me.tmrBatStatus = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBatRef = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblbattimrem, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblbatlevel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblbattech, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblbatMake, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblbattyp, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label94, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblbatstatus, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.batTech, 0, 3)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(39, 80)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(161, 132)
        Me.TableLayoutPanel1.TabIndex = 124
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
        Me.Label6.Size = New System.Drawing.Size(122, 14)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Time Remaining:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbattimrem
        '
        Me.lblbattimrem.AutoSize = True
        Me.lblbattimrem.BackColor = System.Drawing.Color.Transparent
        Me.lblbattimrem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblbattimrem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbattimrem.ForeColor = System.Drawing.Color.Black
        Me.lblbattimrem.Location = New System.Drawing.Point(134, 114)
        Me.lblbattimrem.Margin = New System.Windows.Forms.Padding(4)
        Me.lblbattimrem.Name = "lblbattimrem"
        Me.lblbattimrem.Size = New System.Drawing.Size(23, 14)
        Me.lblbattimrem.TabIndex = 72
        Me.lblbattimrem.Text = "    "
        Me.lblbattimrem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label4.Size = New System.Drawing.Size(122, 14)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Battery Level:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbatlevel
        '
        Me.lblbatlevel.AutoSize = True
        Me.lblbatlevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblbatlevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbatlevel.ForeColor = System.Drawing.Color.Black
        Me.lblbatlevel.Location = New System.Drawing.Point(134, 92)
        Me.lblbatlevel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblbatlevel.Name = "lblbatlevel"
        Me.lblbatlevel.Size = New System.Drawing.Size(23, 14)
        Me.lblbatlevel.TabIndex = 70
        Me.lblbatlevel.Text = "    "
        Me.lblbatlevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbattech
        '
        Me.lblbattech.AutoSize = True
        Me.lblbattech.BackColor = System.Drawing.Color.Transparent
        Me.lblbattech.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblbattech.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbattech.ForeColor = System.Drawing.Color.Black
        Me.lblbattech.Location = New System.Drawing.Point(134, 70)
        Me.lblbattech.Margin = New System.Windows.Forms.Padding(4)
        Me.lblbattech.Name = "lblbattech"
        Me.lblbattech.Size = New System.Drawing.Size(23, 14)
        Me.lblbattech.TabIndex = 66
        Me.lblbattech.Text = "    "
        Me.lblbattech.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 14)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Manufacturer:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbatMake
        '
        Me.lblbatMake.AutoSize = True
        Me.lblbatMake.BackColor = System.Drawing.Color.Transparent
        Me.lblbatMake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblbatMake.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbatMake.ForeColor = System.Drawing.Color.Black
        Me.lblbatMake.Location = New System.Drawing.Point(134, 4)
        Me.lblbatMake.Margin = New System.Windows.Forms.Padding(4)
        Me.lblbatMake.Name = "lblbatMake"
        Me.lblbatMake.Size = New System.Drawing.Size(23, 14)
        Me.lblbatMake.TabIndex = 64
        Me.lblbatMake.Text = "    "
        Me.lblbatMake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 14)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Battery Type:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbattyp
        '
        Me.lblbattyp.AutoSize = True
        Me.lblbattyp.BackColor = System.Drawing.Color.Transparent
        Me.lblbattyp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblbattyp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbattyp.ForeColor = System.Drawing.Color.Black
        Me.lblbattyp.Location = New System.Drawing.Point(134, 26)
        Me.lblbattyp.Margin = New System.Windows.Forms.Padding(4)
        Me.lblbattyp.Name = "lblbattyp"
        Me.lblbattyp.Size = New System.Drawing.Size(23, 14)
        Me.lblbattyp.TabIndex = 65
        Me.lblbattyp.Text = "    "
        Me.lblbattyp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label94.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(4, 48)
        Me.Label94.Margin = New System.Windows.Forms.Padding(4)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(122, 14)
        Me.Label94.TabIndex = 68
        Me.Label94.Text = "Battery Status:"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbatstatus
        '
        Me.lblbatstatus.AutoSize = True
        Me.lblbatstatus.BackColor = System.Drawing.Color.Transparent
        Me.lblbatstatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblbatstatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbatstatus.ForeColor = System.Drawing.Color.Black
        Me.lblbatstatus.Location = New System.Drawing.Point(134, 48)
        Me.lblbatstatus.Margin = New System.Windows.Forms.Padding(4)
        Me.lblbatstatus.Name = "lblbatstatus"
        Me.lblbatstatus.Size = New System.Drawing.Size(23, 14)
        Me.lblbatstatus.TabIndex = 67
        Me.lblbatstatus.Text = "    "
        Me.lblbatstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'batTech
        '
        Me.batTech.AutoSize = True
        Me.batTech.Dock = System.Windows.Forms.DockStyle.Fill
        Me.batTech.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batTech.Location = New System.Drawing.Point(4, 70)
        Me.batTech.Margin = New System.Windows.Forms.Padding(4)
        Me.batTech.Name = "batTech"
        Me.batTech.Size = New System.Drawing.Size(122, 14)
        Me.batTech.TabIndex = 67
        Me.batTech.Text = "Battery Technology:"
        Me.batTech.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrBatStatus
        '
        Me.tmrBatStatus.Interval = 1000
        '
        'tmrBatRef
        '
        Me.tmrBatRef.Interval = 10000
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 25)
        Me.Panel1.TabIndex = 123
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Battery"
        '
        'Battery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Battery"
        Me.Size = New System.Drawing.Size(545, 485)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblbattimrem As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblbatlevel As System.Windows.Forms.Label
    Friend WithEvents lblbattech As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblbatMake As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblbattyp As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents lblbatstatus As System.Windows.Forms.Label
    Friend WithEvents batTech As System.Windows.Forms.Label
    Friend WithEvents BGWRbatref As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrBatStatus As System.Windows.Forms.Timer
    Friend WithEvents tmrBatRef As System.Windows.Forms.Timer

End Class
