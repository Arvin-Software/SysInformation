<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.chkInt = New System.Windows.Forms.CheckBox()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panColorSelect5 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.panColorSelect4 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panColorSelect1 = New System.Windows.Forms.Panel()
        Me.panColorSelect3 = New System.Windows.Forms.Panel()
        Me.panColorSelect2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panOtherSet = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panThem = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDebugCode = New System.Windows.Forms.TextBox()
        Me.panDebug = New System.Windows.Forms.Panel()
        Me.bttnNameOfApp = New System.Windows.Forms.Button()
        Me.txtNameOfApp = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblThemDebug = New System.Windows.Forms.Label()
        Me.panColorSelect5.SuspendLayout()
        Me.panColorSelect4.SuspendLayout()
        Me.panColorSelect1.SuspendLayout()
        Me.panColorSelect3.SuspendLayout()
        Me.panColorSelect2.SuspendLayout()
        Me.panOtherSet.SuspendLayout()
        Me.panThem.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panDebug.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkInt
        '
        Me.chkInt.AutoSize = True
        Me.chkInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkInt.Location = New System.Drawing.Point(18, 28)
        Me.chkInt.Name = "chkInt"
        Me.chkInt.Size = New System.Drawing.Size(231, 17)
        Me.chkInt.TabIndex = 0
        Me.chkInt.Text = "Check for internet status on software startup"
        Me.chkInt.UseVisualStyleBackColor = True
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSet.ForeColor = System.Drawing.Color.White
        Me.lblSet.Location = New System.Drawing.Point(234, 14)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(59, 17)
        Me.lblSet.TabIndex = 14
        Me.lblSet.Text = "Settings"
        '
        'bttnClose
        '
        Me.bttnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bttnClose.Location = New System.Drawing.Point(491, 0)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(35, 27)
        Me.bttnClose.TabIndex = 13
        Me.bttnClose.Text = "X"
        Me.tlTip.SetToolTip(Me.bttnClose, "Close")
        Me.bttnClose.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Black
        Me.Panel11.Enabled = False
        Me.Panel11.Location = New System.Drawing.Point(27, 20)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(27, 27)
        Me.Panel11.TabIndex = 3
        Me.tlTip.SetToolTip(Me.Panel11, "Text color")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Enabled = False
        Me.Panel5.Location = New System.Drawing.Point(9, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(39, 39)
        Me.Panel5.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel5, "Titlebar color")
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Enabled = False
        Me.Panel6.Location = New System.Drawing.Point(33, 22)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(42, 37)
        Me.Panel6.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel6, "Control and statusbar color")
        '
        'panColorSelect5
        '
        Me.panColorSelect5.Controls.Add(Me.Panel16)
        Me.panColorSelect5.Controls.Add(Me.Panel12)
        Me.panColorSelect5.Controls.Add(Me.Panel13)
        Me.panColorSelect5.Location = New System.Drawing.Point(412, 20)
        Me.panColorSelect5.Name = "panColorSelect5"
        Me.panColorSelect5.Size = New System.Drawing.Size(81, 71)
        Me.panColorSelect5.TabIndex = 6
        Me.tlTip.SetToolTip(Me.panColorSelect5, "Eco Friendly Green")
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Enabled = False
        Me.Panel16.Location = New System.Drawing.Point(27, 20)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(27, 27)
        Me.Panel16.TabIndex = 4
        Me.tlTip.SetToolTip(Me.Panel16, "Text color")
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel12.Enabled = False
        Me.Panel12.Location = New System.Drawing.Point(9, 6)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(39, 39)
        Me.Panel12.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel12, "Titlebar color")
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel13.Enabled = False
        Me.Panel13.Location = New System.Drawing.Point(33, 22)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(42, 37)
        Me.Panel13.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel13, "Control and statusbar color")
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Black
        Me.Panel14.Enabled = False
        Me.Panel14.Location = New System.Drawing.Point(27, 20)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(27, 27)
        Me.Panel14.TabIndex = 4
        Me.tlTip.SetToolTip(Me.Panel14, "Text color")
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel8.Enabled = False
        Me.Panel8.Location = New System.Drawing.Point(9, 6)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(39, 39)
        Me.Panel8.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel8, "Titlebar color")
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel9.Enabled = False
        Me.Panel9.Location = New System.Drawing.Point(33, 22)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(42, 37)
        Me.Panel9.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel9, "Control and statusbar color")
        '
        'panColorSelect4
        '
        Me.panColorSelect4.Controls.Add(Me.Panel15)
        Me.panColorSelect4.Controls.Add(Me.Panel7)
        Me.panColorSelect4.Controls.Add(Me.Panel10)
        Me.panColorSelect4.Location = New System.Drawing.Point(316, 20)
        Me.panColorSelect4.Name = "panColorSelect4"
        Me.panColorSelect4.Size = New System.Drawing.Size(81, 71)
        Me.panColorSelect4.TabIndex = 5
        Me.tlTip.SetToolTip(Me.panColorSelect4, "Spicy Red")
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.White
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Enabled = False
        Me.Panel15.Location = New System.Drawing.Point(27, 20)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(27, 27)
        Me.Panel15.TabIndex = 4
        Me.tlTip.SetToolTip(Me.Panel15, "Text color")
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.IndianRed
        Me.Panel7.Enabled = False
        Me.Panel7.Location = New System.Drawing.Point(9, 6)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(39, 39)
        Me.Panel7.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel7, "Titlebar color")
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Firebrick
        Me.Panel10.Enabled = False
        Me.Panel10.Location = New System.Drawing.Point(33, 22)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(42, 37)
        Me.Panel10.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel10, "Control and statusbar color")
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Transparent
        Me.Panel17.BackgroundImage = CType(resources.GetObject("Panel17.BackgroundImage"), System.Drawing.Image)
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Enabled = False
        Me.Panel17.Location = New System.Drawing.Point(27, 20)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(27, 27)
        Me.Panel17.TabIndex = 4
        Me.tlTip.SetToolTip(Me.Panel17, "Text color")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(9, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(39, 39)
        Me.Panel2.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel2, "Titlebar color")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(33, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(42, 37)
        Me.Panel3.TabIndex = 2
        Me.tlTip.SetToolTip(Me.Panel3, "Control and statusbar color")
        '
        'panColorSelect1
        '
        Me.panColorSelect1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panColorSelect1.Controls.Add(Me.Panel17)
        Me.panColorSelect1.Controls.Add(Me.Panel2)
        Me.panColorSelect1.Controls.Add(Me.Panel3)
        Me.panColorSelect1.Location = New System.Drawing.Point(17, 20)
        Me.panColorSelect1.Name = "panColorSelect1"
        Me.panColorSelect1.Size = New System.Drawing.Size(81, 71)
        Me.panColorSelect1.TabIndex = 1
        Me.tlTip.SetToolTip(Me.panColorSelect1, "Gray Bliss")
        '
        'panColorSelect3
        '
        Me.panColorSelect3.Controls.Add(Me.Panel14)
        Me.panColorSelect3.Controls.Add(Me.Panel8)
        Me.panColorSelect3.Controls.Add(Me.Panel9)
        Me.panColorSelect3.Location = New System.Drawing.Point(214, 20)
        Me.panColorSelect3.Name = "panColorSelect3"
        Me.panColorSelect3.Size = New System.Drawing.Size(81, 71)
        Me.panColorSelect3.TabIndex = 4
        Me.tlTip.SetToolTip(Me.panColorSelect3, "Gorgeous Blue")
        '
        'panColorSelect2
        '
        Me.panColorSelect2.Controls.Add(Me.Panel11)
        Me.panColorSelect2.Controls.Add(Me.Panel5)
        Me.panColorSelect2.Controls.Add(Me.Panel6)
        Me.panColorSelect2.Location = New System.Drawing.Point(115, 20)
        Me.panColorSelect2.Name = "panColorSelect2"
        Me.panColorSelect2.Size = New System.Drawing.Size(81, 71)
        Me.panColorSelect2.TabIndex = 3
        Me.tlTip.SetToolTip(Me.panColorSelect2, "Silver Mist")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(21, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Other Settings"
        '
        'panOtherSet
        '
        Me.panOtherSet.Controls.Add(Me.Button3)
        Me.panOtherSet.Controls.Add(Me.CheckBox1)
        Me.panOtherSet.Controls.Add(Me.Button1)
        Me.panOtherSet.Controls.Add(Me.chkInt)
        Me.panOtherSet.Location = New System.Drawing.Point(7, 151)
        Me.panOtherSet.Name = "panOtherSet"
        Me.panOtherSet.Size = New System.Drawing.Size(508, 199)
        Me.panOtherSet.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(292, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Create Report"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(292, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Traditional windows style"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(412, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(21, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Software Themes"
        '
        'panThem
        '
        Me.panThem.Controls.Add(Me.panColorSelect5)
        Me.panThem.Controls.Add(Me.panColorSelect4)
        Me.panThem.Controls.Add(Me.panColorSelect1)
        Me.panThem.Controls.Add(Me.panColorSelect3)
        Me.panThem.Controls.Add(Me.panColorSelect2)
        Me.panThem.Location = New System.Drawing.Point(7, 18)
        Me.panThem.Name = "panThem"
        Me.panThem.Size = New System.Drawing.Size(508, 116)
        Me.panThem.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.panOtherSet)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.panThem)
        Me.Panel1.Location = New System.Drawing.Point(2, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 361)
        Me.Panel1.TabIndex = 12
        '
        'txtDebugCode
        '
        Me.txtDebugCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDebugCode.Location = New System.Drawing.Point(3, 4)
        Me.txtDebugCode.Name = "txtDebugCode"
        Me.txtDebugCode.Size = New System.Drawing.Size(392, 20)
        Me.txtDebugCode.TabIndex = 16
        '
        'panDebug
        '
        Me.panDebug.BackColor = System.Drawing.Color.White
        Me.panDebug.Controls.Add(Me.bttnNameOfApp)
        Me.panDebug.Controls.Add(Me.txtNameOfApp)
        Me.panDebug.Controls.Add(Me.Button2)
        Me.panDebug.Controls.Add(Me.txtDebugCode)
        Me.panDebug.Location = New System.Drawing.Point(70, 12)
        Me.panDebug.Name = "panDebug"
        Me.panDebug.Size = New System.Drawing.Size(415, 54)
        Me.panDebug.TabIndex = 17
        Me.panDebug.Visible = False
        '
        'bttnNameOfApp
        '
        Me.bttnNameOfApp.Location = New System.Drawing.Point(361, 26)
        Me.bttnNameOfApp.Name = "bttnNameOfApp"
        Me.bttnNameOfApp.Size = New System.Drawing.Size(21, 23)
        Me.bttnNameOfApp.TabIndex = 19
        Me.bttnNameOfApp.Text = "E"
        Me.bttnNameOfApp.UseVisualStyleBackColor = True
        Me.bttnNameOfApp.Visible = False
        '
        'txtNameOfApp
        '
        Me.txtNameOfApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameOfApp.Location = New System.Drawing.Point(35, 27)
        Me.txtNameOfApp.Name = "txtNameOfApp"
        Me.txtNameOfApp.Size = New System.Drawing.Size(323, 20)
        Me.txtNameOfApp.TabIndex = 18
        Me.txtNameOfApp.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(394, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "E"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblThemDebug
        '
        Me.lblThemDebug.AutoSize = True
        Me.lblThemDebug.Location = New System.Drawing.Point(481, 41)
        Me.lblThemDebug.Name = "lblThemDebug"
        Me.lblThemDebug.Size = New System.Drawing.Size(0, 13)
        Me.lblThemDebug.TabIndex = 18
        Me.lblThemDebug.Visible = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(526, 418)
        Me.Controls.Add(Me.lblThemDebug)
        Me.Controls.Add(Me.panDebug)
        Me.Controls.Add(Me.lblSet)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.panColorSelect5.ResumeLayout(False)
        Me.panColorSelect4.ResumeLayout(False)
        Me.panColorSelect1.ResumeLayout(False)
        Me.panColorSelect3.ResumeLayout(False)
        Me.panColorSelect2.ResumeLayout(False)
        Me.panOtherSet.ResumeLayout(False)
        Me.panOtherSet.PerformLayout()
        Me.panThem.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panDebug.ResumeLayout(False)
        Me.panDebug.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkInt As System.Windows.Forms.CheckBox
    Friend WithEvents lblSet As System.Windows.Forms.Label
    Friend WithEvents bttnClose As System.Windows.Forms.Button
    Friend WithEvents tlTip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents panColorSelect5 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents panColorSelect4 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panColorSelect1 As System.Windows.Forms.Panel
    Friend WithEvents panColorSelect3 As System.Windows.Forms.Panel
    Friend WithEvents panColorSelect2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panOtherSet As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panThem As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDebugCode As System.Windows.Forms.TextBox
    Friend WithEvents panDebug As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblThemDebug As System.Windows.Forms.Label
    Friend WithEvents bttnNameOfApp As System.Windows.Forms.Button
    Friend WithEvents txtNameOfApp As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
