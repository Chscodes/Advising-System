<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnforward = New System.Windows.Forms.Button()
        Me.btndec = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnre = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbsem = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbyrlvl = New System.Windows.Forms.ComboBox()
        Me.txtmn = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtStdntID = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpreRequisite = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsem_units = New System.Windows.Forms.TextBox()
        Me.txtAdvised_units = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.linklbl_save = New System.Windows.Forms.LinkLabel()
        Me.linklbl_Bridge = New System.Windows.Forms.LinkLabel()
        Me.btnALlFrwrd = New System.Windows.Forms.Button()
        Me.lblunits = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtsb = New System.Windows.Forms.TextBox()
        Me.txtStudTake = New System.Windows.Forms.TextBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Semester Subjects:"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 236)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(498, 270)
        Me.dgv1.TabIndex = 33
        '
        'dgv2
        '
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column1, Me.Column2})
        Me.dgv2.Location = New System.Drawing.Point(559, 236)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv2.Size = New System.Drawing.Size(498, 270)
        Me.dgv2.TabIndex = 34
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Subject Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 96
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subject Title"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 91
        '
        'Column1
        '
        Me.Column1.HeaderText = "Units"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 56
        '
        'Column2
        '
        Me.Column2.HeaderText = "Pre-Requisite"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 95
        '
        'btnforward
        '
        Me.btnforward.Location = New System.Drawing.Point(516, 324)
        Me.btnforward.Name = "btnforward"
        Me.btnforward.Size = New System.Drawing.Size(37, 22)
        Me.btnforward.TabIndex = 38
        Me.btnforward.Text = "-->"
        Me.btnforward.UseVisualStyleBackColor = True
        '
        'btndec
        '
        Me.btndec.Location = New System.Drawing.Point(516, 380)
        Me.btndec.Name = "btndec"
        Me.btndec.Size = New System.Drawing.Size(37, 22)
        Me.btndec.TabIndex = 39
        Me.btndec.Text = "<--"
        Me.btndec.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnre)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbsem)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cmbyrlvl)
        Me.Panel1.Controls.Add(Me.txtmn)
        Me.Panel1.Controls.Add(Me.txtfname)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbtype)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtStdntID)
        Me.Panel1.Controls.Add(Me.txtLname)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(-2, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 120)
        Me.Panel1.TabIndex = 50
        '
        'btnre
        '
        Me.btnre.FlatAppearance.BorderSize = 0
        Me.btnre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btnre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnre.Image = CType(resources.GetObject("btnre.Image"), System.Drawing.Image)
        Me.btnre.Location = New System.Drawing.Point(678, 22)
        Me.btnre.Name = "btnre"
        Me.btnre.Size = New System.Drawing.Size(24, 22)
        Me.btnre.TabIndex = 90
        Me.btnre.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(481, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Semester"
        '
        'cmbsem
        '
        Me.cmbsem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsem.FormattingEnabled = True
        Me.cmbsem.Items.AddRange(New Object() {"First Semester", "Second Semester"})
        Me.cmbsem.Location = New System.Drawing.Point(538, 36)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Size = New System.Drawing.Size(141, 21)
        Me.cmbsem.TabIndex = 80
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(471, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Year Level:"
        '
        'cmbyrlvl
        '
        Me.cmbyrlvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbyrlvl.FormattingEnabled = True
        Me.cmbyrlvl.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year"})
        Me.cmbyrlvl.Location = New System.Drawing.Point(538, 10)
        Me.cmbyrlvl.Name = "cmbyrlvl"
        Me.cmbyrlvl.Size = New System.Drawing.Size(141, 21)
        Me.cmbyrlvl.TabIndex = 79
        '
        'txtmn
        '
        Me.txtmn.Location = New System.Drawing.Point(382, 33)
        Me.txtmn.Name = "txtmn"
        Me.txtmn.ReadOnly = True
        Me.txtmn.Size = New System.Drawing.Size(75, 20)
        Me.txtmn.TabIndex = 74
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(230, 33)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.ReadOnly = True
        Me.txtfname.Size = New System.Drawing.Size(138, 20)
        Me.txtfname.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(217, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 24)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = ","
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(236, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Student Type:"
        '
        'cmbtype
        '
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Regular", "Irregular", "Transferee"})
        Me.cmbtype.Location = New System.Drawing.Point(316, 59)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(141, 21)
        Me.cmbtype.TabIndex = 70
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(917, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 83)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advance Filter"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"First Semester", "Second Semester"})
        Me.ComboBox2.Location = New System.Drawing.Point(10, 51)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox2.TabIndex = 43
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year"})
        Me.ComboBox1.Location = New System.Drawing.Point(10, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox1.TabIndex = 42
        '
        'txtStdntID
        '
        Me.txtStdntID.Location = New System.Drawing.Point(101, 7)
        Me.txtStdntID.Name = "txtStdntID"
        Me.txtStdntID.Size = New System.Drawing.Size(356, 20)
        Me.txtStdntID.TabIndex = 61
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(101, 33)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.ReadOnly = True
        Me.txtLname.Size = New System.Drawing.Size(131, 20)
        Me.txtLname.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Student ID:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(131, 20)
        Me.DateTimePicker1.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Student Name:"
        '
        'txtpreRequisite
        '
        Me.txtpreRequisite.Location = New System.Drawing.Point(915, 43)
        Me.txtpreRequisite.Name = "txtpreRequisite"
        Me.txtpreRequisite.ReadOnly = True
        Me.txtpreRequisite.Size = New System.Drawing.Size(146, 20)
        Me.txtpreRequisite.TabIndex = 75
        Me.txtpreRequisite.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(555, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Subject to Enroll:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(511, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 26)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Advising"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 512)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Total Units:"
        '
        'txtsem_units
        '
        Me.txtsem_units.Location = New System.Drawing.Point(79, 509)
        Me.txtsem_units.Name = "txtsem_units"
        Me.txtsem_units.ReadOnly = True
        Me.txtsem_units.Size = New System.Drawing.Size(83, 20)
        Me.txtsem_units.TabIndex = 63
        '
        'txtAdvised_units
        '
        Me.txtAdvised_units.Location = New System.Drawing.Point(974, 509)
        Me.txtAdvised_units.Name = "txtAdvised_units"
        Me.txtAdvised_units.ReadOnly = True
        Me.txtAdvised_units.Size = New System.Drawing.Size(83, 20)
        Me.txtAdvised_units.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(907, 512)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Total Units:"
        '
        'linklbl_save
        '
        Me.linklbl_save.AutoSize = True
        Me.linklbl_save.LinkColor = System.Drawing.Color.DarkRed
        Me.linklbl_save.Location = New System.Drawing.Point(954, 220)
        Me.linklbl_save.Name = "linklbl_save"
        Me.linklbl_save.Size = New System.Drawing.Size(44, 13)
        Me.linklbl_save.TabIndex = 67
        Me.linklbl_save.TabStop = True
        Me.linklbl_save.Text = "[ Save ]"
        '
        'linklbl_Bridge
        '
        Me.linklbl_Bridge.AutoSize = True
        Me.linklbl_Bridge.LinkColor = System.Drawing.Color.DarkRed
        Me.linklbl_Bridge.Location = New System.Drawing.Point(1004, 220)
        Me.linklbl_Bridge.Name = "linklbl_Bridge"
        Me.linklbl_Bridge.Size = New System.Drawing.Size(57, 13)
        Me.linklbl_Bridge.TabIndex = 68
        Me.linklbl_Bridge.TabStop = True
        Me.linklbl_Bridge.Text = "[ Bridging ]"
        '
        'btnALlFrwrd
        '
        Me.btnALlFrwrd.Location = New System.Drawing.Point(516, 352)
        Me.btnALlFrwrd.Name = "btnALlFrwrd"
        Me.btnALlFrwrd.Size = New System.Drawing.Size(37, 22)
        Me.btnALlFrwrd.TabIndex = 70
        Me.btnALlFrwrd.Text = ">>"
        Me.btnALlFrwrd.UseVisualStyleBackColor = True
        '
        'lblunits
        '
        Me.lblunits.AutoSize = True
        Me.lblunits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunits.Location = New System.Drawing.Point(639, 519)
        Me.lblunits.Name = "lblunits"
        Me.lblunits.Size = New System.Drawing.Size(21, 24)
        Me.lblunits.TabIndex = 87
        Me.lblunits.Text = "0"
        Me.lblunits.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(398, 518)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(235, 26)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Total of Units to Enroll:"
        Me.Label16.Visible = False
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(763, 43)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(146, 20)
        Me.txtCount.TabIndex = 88
        Me.txtCount.Visible = False
        '
        'txtsb
        '
        Me.txtsb.Location = New System.Drawing.Point(611, 43)
        Me.txtsb.Name = "txtsb"
        Me.txtsb.ReadOnly = True
        Me.txtsb.Size = New System.Drawing.Size(146, 20)
        Me.txtsb.TabIndex = 89
        Me.txtsb.Visible = False
        '
        'txtStudTake
        '
        Me.txtStudTake.Location = New System.Drawing.Point(459, 43)
        Me.txtStudTake.Name = "txtStudTake"
        Me.txtStudTake.ReadOnly = True
        Me.txtStudTake.Size = New System.Drawing.Size(146, 20)
        Me.txtStudTake.TabIndex = 90
        Me.txtStudTake.Visible = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 571)
        Me.Controls.Add(Me.txtStudTake)
        Me.Controls.Add(Me.txtsb)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.lblunits)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnALlFrwrd)
        Me.Controls.Add(Me.linklbl_Bridge)
        Me.Controls.Add(Me.linklbl_save)
        Me.Controls.Add(Me.txtAdvised_units)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtsem_units)
        Me.Controls.Add(Me.txtpreRequisite)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btndec)
        Me.Controls.Add(Me.btnforward)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1st Year/ 1st Sem(Advising)"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents btnforward As Button
    Friend WithEvents btndec As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtStdntID As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbtype As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtsem_units As TextBox
    Friend WithEvents txtAdvised_units As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtmn As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents txtpreRequisite As TextBox
    Friend WithEvents linklbl_save As LinkLabel
    Friend WithEvents linklbl_Bridge As LinkLabel
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbsem As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbyrlvl As ComboBox
    Friend WithEvents btnALlFrwrd As Button
    Friend WithEvents lblunits As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCount As TextBox
    Friend WithEvents btnre As Button
    Friend WithEvents txtsb As TextBox
    Friend WithEvents txtStudTake As TextBox
End Class
