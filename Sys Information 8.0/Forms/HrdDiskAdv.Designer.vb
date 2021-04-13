<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HrdDiskAdv
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.treHrdDskAdvan = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.treCDDVD = New System.Windows.Forms.TreeView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.treParti = New System.Windows.Forms.TreeView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(172, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Storage Devices"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(402, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 27)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'treHrdDskAdvan
        '
        Me.treHrdDskAdvan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treHrdDskAdvan.Location = New System.Drawing.Point(3, 3)
        Me.treHrdDskAdvan.Name = "treHrdDskAdvan"
        Me.treHrdDskAdvan.Size = New System.Drawing.Size(423, 302)
        Me.treHrdDskAdvan.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(437, 334)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.treHrdDskAdvan)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(429, 308)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Storage Devices"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.treCDDVD)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(429, 308)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CD/DVD Drives"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'treCDDVD
        '
        Me.treCDDVD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treCDDVD.Location = New System.Drawing.Point(3, 3)
        Me.treCDDVD.Name = "treCDDVD"
        Me.treCDDVD.Size = New System.Drawing.Size(423, 302)
        Me.treCDDVD.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.treParti)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(429, 308)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Partitions"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'treParti
        '
        Me.treParti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treParti.Location = New System.Drawing.Point(3, 3)
        Me.treParti.Name = "treParti"
        Me.treParti.Size = New System.Drawing.Size(423, 302)
        Me.treParti.TabIndex = 14
        '
        'HrdDiskAdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(438, 367)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HrdDiskAdv"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HrdDiskAdv"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents treHrdDskAdvan As System.Windows.Forms.TreeView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents treCDDVD As System.Windows.Forms.TreeView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents treParti As System.Windows.Forms.TreeView
End Class
