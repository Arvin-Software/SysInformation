<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Memory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Memory))
        Me.lstMemoryModules = New System.Windows.Forms.ListView()
        Me.colBank = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOccMemSlots = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotMemSlots = New System.Windows.Forms.Label()
        Me.lblUsedMem = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblInstMem = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRemMem = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.lblMaxInsMem = New System.Windows.Forms.Label()
        Me.tmrMem = New System.Windows.Forms.Timer(Me.components)
        Me.tltp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.prRM = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMemoryModules
        '
        Me.lstMemoryModules.AutoArrange = False
        Me.lstMemoryModules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMemoryModules.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBank, Me.colSize, Me.colType})
        Me.lstMemoryModules.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMemoryModules.FullRowSelect = True
        Me.lstMemoryModules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstMemoryModules.LabelWrap = False
        Me.lstMemoryModules.Location = New System.Drawing.Point(90, 301)
        Me.lstMemoryModules.MultiSelect = False
        Me.lstMemoryModules.Name = "lstMemoryModules"
        Me.lstMemoryModules.ShowGroups = False
        Me.lstMemoryModules.ShowItemToolTips = True
        Me.lstMemoryModules.Size = New System.Drawing.Size(407, 114)
        Me.lstMemoryModules.TabIndex = 98
        Me.lstMemoryModules.UseCompatibleStateImageBehavior = False
        Me.lstMemoryModules.View = System.Windows.Forms.View.Details
        '
        'colBank
        '
        Me.colBank.Text = "Bank Label"
        Me.colBank.Width = 178
        '
        'colSize
        '
        Me.colSize.Text = "Size (MB)"
        Me.colSize.Width = 100
        '
        'colType
        '
        Me.colType.Text = "RAM Type"
        Me.colType.Width = 95
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(67, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 15)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Installed Memory Modules"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(62, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Physical Memory"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOccMemSlots, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTotMemSlots, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblUsedMem, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblInstMem, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblRemMem, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label88, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMaxInsMem, 1, 3)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(90, 97)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(167, 132)
        Me.TableLayoutPanel2.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 14)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Occupied Memory Slots : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOccMemSlots
        '
        Me.lblOccMemSlots.AutoSize = True
        Me.lblOccMemSlots.BackColor = System.Drawing.Color.Transparent
        Me.lblOccMemSlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOccMemSlots.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccMemSlots.ForeColor = System.Drawing.Color.Black
        Me.lblOccMemSlots.Location = New System.Drawing.Point(140, 114)
        Me.lblOccMemSlots.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOccMemSlots.Name = "lblOccMemSlots"
        Me.lblOccMemSlots.Size = New System.Drawing.Size(23, 14)
        Me.lblOccMemSlots.TabIndex = 78
        Me.lblOccMemSlots.Text = "    "
        Me.lblOccMemSlots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 14)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Total Memory Slots : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotMemSlots
        '
        Me.lblTotMemSlots.AutoSize = True
        Me.lblTotMemSlots.BackColor = System.Drawing.Color.Transparent
        Me.lblTotMemSlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotMemSlots.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotMemSlots.ForeColor = System.Drawing.Color.Black
        Me.lblTotMemSlots.Location = New System.Drawing.Point(140, 92)
        Me.lblTotMemSlots.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTotMemSlots.Name = "lblTotMemSlots"
        Me.lblTotMemSlots.Size = New System.Drawing.Size(23, 14)
        Me.lblTotMemSlots.TabIndex = 76
        Me.lblTotMemSlots.Text = "    "
        Me.lblTotMemSlots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsedMem
        '
        Me.lblUsedMem.AutoSize = True
        Me.lblUsedMem.BackColor = System.Drawing.Color.Transparent
        Me.lblUsedMem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsedMem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsedMem.ForeColor = System.Drawing.Color.Black
        Me.lblUsedMem.Location = New System.Drawing.Point(140, 48)
        Me.lblUsedMem.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUsedMem.Name = "lblUsedMem"
        Me.lblUsedMem.Size = New System.Drawing.Size(23, 14)
        Me.lblUsedMem.TabIndex = 75
        Me.lblUsedMem.Text = "    "
        Me.lblUsedMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 14)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Used Memory:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 4)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 14)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Installed Memory:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInstMem
        '
        Me.lblInstMem.AutoSize = True
        Me.lblInstMem.BackColor = System.Drawing.Color.Transparent
        Me.lblInstMem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInstMem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstMem.ForeColor = System.Drawing.Color.Black
        Me.lblInstMem.Location = New System.Drawing.Point(140, 4)
        Me.lblInstMem.Margin = New System.Windows.Forms.Padding(4)
        Me.lblInstMem.Name = "lblInstMem"
        Me.lblInstMem.Size = New System.Drawing.Size(23, 14)
        Me.lblInstMem.TabIndex = 64
        Me.lblInstMem.Text = "    "
        Me.lblInstMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 26)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 14)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Remaning Memory:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRemMem
        '
        Me.lblRemMem.AutoSize = True
        Me.lblRemMem.BackColor = System.Drawing.Color.Transparent
        Me.lblRemMem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRemMem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemMem.ForeColor = System.Drawing.Color.Black
        Me.lblRemMem.Location = New System.Drawing.Point(140, 26)
        Me.lblRemMem.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRemMem.Name = "lblRemMem"
        Me.lblRemMem.Size = New System.Drawing.Size(23, 14)
        Me.lblRemMem.TabIndex = 65
        Me.lblRemMem.Text = "    "
        Me.lblRemMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label88.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(4, 70)
        Me.Label88.Margin = New System.Windows.Forms.Padding(4)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(128, 14)
        Me.Label88.TabIndex = 66
        Me.Label88.Text = "Maximum Installable:"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaxInsMem
        '
        Me.lblMaxInsMem.AutoSize = True
        Me.lblMaxInsMem.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxInsMem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMaxInsMem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxInsMem.ForeColor = System.Drawing.Color.Black
        Me.lblMaxInsMem.Location = New System.Drawing.Point(140, 70)
        Me.lblMaxInsMem.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMaxInsMem.Name = "lblMaxInsMem"
        Me.lblMaxInsMem.Size = New System.Drawing.Size(23, 14)
        Me.lblMaxInsMem.TabIndex = 66
        Me.lblMaxInsMem.Text = "    "
        Me.lblMaxInsMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrMem
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(346, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 23)
        Me.Button1.TabIndex = 112
        Me.tltp.SetToolTip(Me.Button1, "Advanced view of your installed memory")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(37, 261)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 111
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblCPU)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.prRM)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 25)
        Me.Panel1.TabIndex = 100
        '
        'lblCPU
        '
        Me.lblCPU.AutoSize = True
        Me.lblCPU.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCPU.Location = New System.Drawing.Point(381, 5)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(63, 13)
        Me.lblCPU.TabIndex = 108
        Me.lblCPU.Text = "Load : 99 %"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Memory"
        '
        'prRM
        '
        Me.prRM.Location = New System.Drawing.Point(450, 5)
        Me.prRM.Name = "prRM"
        Me.prRM.Size = New System.Drawing.Size(91, 12)
        Me.prRM.TabIndex = 99
        '
        'Memory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstMemoryModules)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "Memory"
        Me.Size = New System.Drawing.Size(545, 485)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prRM As System.Windows.Forms.ProgressBar
    Friend WithEvents lstMemoryModules As System.Windows.Forms.ListView
    Friend WithEvents colBank As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblOccMemSlots As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotMemSlots As System.Windows.Forms.Label
    Friend WithEvents lblUsedMem As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblInstMem As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblRemMem As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents lblMaxInsMem As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCPU As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMem As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tltp As System.Windows.Forms.ToolTip
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader

End Class
