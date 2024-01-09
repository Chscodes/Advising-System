<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlyear = New System.Windows.Forms.Panel()
        Me.pnl_drop1 = New System.Windows.Forms.Panel()
        Me.btnregADD = New System.Windows.Forms.Button()
        Me.btnregEval = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnl_drop2 = New System.Windows.Forms.Panel()
        Me.btnTransNA = New System.Windows.Forms.Button()
        Me.btnTransEval = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.btnregA = New System.Windows.Forms.Button()
        Me.btnadvise = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAddSub = New System.Windows.Forms.Button()
        Me.btnProspectus = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTransf = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlyear.SuspendLayout()
        Me.pnl_drop1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnl_drop2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.pnlyear)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnAddSub)
        Me.Panel1.Controls.Add(Me.btnProspectus)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 606)
        Me.Panel1.TabIndex = 0
        '
        'pnlyear
        '
        Me.pnlyear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlyear.Controls.Add(Me.pnl_drop1)
        Me.pnlyear.Controls.Add(Me.btnadvise)
        Me.pnlyear.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlyear.Location = New System.Drawing.Point(0, 230)
        Me.pnlyear.MaximumSize = New System.Drawing.Size(223, 122)
        Me.pnlyear.MinimumSize = New System.Drawing.Size(223, 47)
        Me.pnlyear.Name = "pnlyear"
        Me.pnlyear.Size = New System.Drawing.Size(223, 122)
        Me.pnlyear.TabIndex = 12
        '
        'pnl_drop1
        '
        Me.pnl_drop1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl_drop1.Controls.Add(Me.btnregADD)
        Me.pnl_drop1.Controls.Add(Me.btnregEval)
        Me.pnl_drop1.Controls.Add(Me.btnregA)
        Me.pnl_drop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_drop1.Location = New System.Drawing.Point(0, 47)
        Me.pnl_drop1.MaximumSize = New System.Drawing.Size(223, 74)
        Me.pnl_drop1.MinimumSize = New System.Drawing.Size(223, 30)
        Me.pnl_drop1.Name = "pnl_drop1"
        Me.pnl_drop1.Size = New System.Drawing.Size(223, 74)
        Me.pnl_drop1.TabIndex = 5
        '
        'btnregADD
        '
        Me.btnregADD.BackColor = System.Drawing.Color.Transparent
        Me.btnregADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregADD.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnregADD.FlatAppearance.BorderSize = 0
        Me.btnregADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnregADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregADD.ForeColor = System.Drawing.SystemColors.Window
        Me.btnregADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregADD.Location = New System.Drawing.Point(0, 51)
        Me.btnregADD.Name = "btnregADD"
        Me.btnregADD.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnregADD.Size = New System.Drawing.Size(223, 21)
        Me.btnregADD.TabIndex = 7
        Me.btnregADD.Text = "Add Student"
        Me.btnregADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnregADD.UseVisualStyleBackColor = False
        '
        'btnregEval
        '
        Me.btnregEval.BackColor = System.Drawing.Color.Transparent
        Me.btnregEval.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregEval.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnregEval.FlatAppearance.BorderSize = 0
        Me.btnregEval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnregEval.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregEval.ForeColor = System.Drawing.SystemColors.Window
        Me.btnregEval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregEval.Location = New System.Drawing.Point(0, 31)
        Me.btnregEval.Name = "btnregEval"
        Me.btnregEval.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnregEval.Size = New System.Drawing.Size(223, 20)
        Me.btnregEval.TabIndex = 6
        Me.btnregEval.Text = "Evaluation"
        Me.btnregEval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnregEval.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 35)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(223, 107)
        Me.Panel4.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 35)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnl_drop2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(78, 20)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'pnl_drop2
        '
        Me.pnl_drop2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl_drop2.Controls.Add(Me.btnTransNA)
        Me.pnl_drop2.Controls.Add(Me.btnTransEval)
        Me.pnl_drop2.Controls.Add(Me.btnTransf)
        Me.pnl_drop2.Location = New System.Drawing.Point(6, 19)
        Me.pnl_drop2.MaximumSize = New System.Drawing.Size(223, 74)
        Me.pnl_drop2.MinimumSize = New System.Drawing.Size(223, 30)
        Me.pnl_drop2.Name = "pnl_drop2"
        Me.pnl_drop2.Size = New System.Drawing.Size(223, 69)
        Me.pnl_drop2.TabIndex = 8
        '
        'btnTransNA
        '
        Me.btnTransNA.BackColor = System.Drawing.Color.Transparent
        Me.btnTransNA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransNA.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransNA.FlatAppearance.BorderSize = 0
        Me.btnTransNA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnTransNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransNA.ForeColor = System.Drawing.SystemColors.Window
        Me.btnTransNA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransNA.Location = New System.Drawing.Point(0, 52)
        Me.btnTransNA.Name = "btnTransNA"
        Me.btnTransNA.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTransNA.Size = New System.Drawing.Size(223, 21)
        Me.btnTransNA.TabIndex = 7
        Me.btnTransNA.Text = "Add Student"
        Me.btnTransNA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransNA.UseVisualStyleBackColor = False
        '
        'btnTransEval
        '
        Me.btnTransEval.BackColor = System.Drawing.Color.Transparent
        Me.btnTransEval.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransEval.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransEval.FlatAppearance.BorderSize = 0
        Me.btnTransEval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnTransEval.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransEval.ForeColor = System.Drawing.SystemColors.Window
        Me.btnTransEval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransEval.Location = New System.Drawing.Point(0, 31)
        Me.btnTransEval.Name = "btnTransEval"
        Me.btnTransEval.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTransEval.Size = New System.Drawing.Size(223, 21)
        Me.btnTransEval.TabIndex = 6
        Me.btnTransEval.Text = "Evaluate"
        Me.btnTransEval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransEval.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(223, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1088, 35)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(223, 35)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1088, 571)
        Me.Panel5.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        Me.Timer2.Interval = 15
        '
        'Timer5
        '
        Me.Timer5.Interval = 10
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.SystemColors.Window
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(33, 10)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 21)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Home"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(1049, 10)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 18)
        Me.Button6.TabIndex = 0
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.ForeColor = System.Drawing.SystemColors.Window
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.Location = New System.Drawing.Point(0, 352)
        Me.Button15.Name = "Button15"
        Me.Button15.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button15.Size = New System.Drawing.Size(223, 44)
        Me.Button15.TabIndex = 10
        Me.Button15.Text = "Activity Log"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button15.UseVisualStyleBackColor = True
        '
        'btnregA
        '
        Me.btnregA.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnregA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregA.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnregA.FlatAppearance.BorderSize = 0
        Me.btnregA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnregA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregA.ForeColor = System.Drawing.SystemColors.Window
        Me.btnregA.Image = Global.Sysarch2finals.My.Resources.Resources.right_arrow
        Me.btnregA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregA.Location = New System.Drawing.Point(0, 0)
        Me.btnregA.Name = "btnregA"
        Me.btnregA.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnregA.Size = New System.Drawing.Size(223, 31)
        Me.btnregA.TabIndex = 5
        Me.btnregA.Text = "STUDENT EVALUATION"
        Me.btnregA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnregA.UseVisualStyleBackColor = False
        '
        'btnadvise
        '
        Me.btnadvise.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnadvise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadvise.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnadvise.FlatAppearance.BorderSize = 0
        Me.btnadvise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnadvise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadvise.ForeColor = System.Drawing.SystemColors.Window
        Me.btnadvise.Image = CType(resources.GetObject("btnadvise.Image"), System.Drawing.Image)
        Me.btnadvise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadvise.Location = New System.Drawing.Point(0, 0)
        Me.btnadvise.Name = "btnadvise"
        Me.btnadvise.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnadvise.Size = New System.Drawing.Size(223, 47)
        Me.btnadvise.TabIndex = 6
        Me.btnadvise.Text = "Advise"
        Me.btnadvise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadvise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnadvise.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gray
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.Window
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 558)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(223, 48)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Log Out"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnAddSub
        '
        Me.btnAddSub.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddSub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddSub.FlatAppearance.BorderSize = 0
        Me.btnAddSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnAddSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSub.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddSub.Image = CType(resources.GetObject("btnAddSub.Image"), System.Drawing.Image)
        Me.btnAddSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSub.Location = New System.Drawing.Point(0, 186)
        Me.btnAddSub.Name = "btnAddSub"
        Me.btnAddSub.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAddSub.Size = New System.Drawing.Size(223, 44)
        Me.btnAddSub.TabIndex = 3
        Me.btnAddSub.Text = "Add Subject"
        Me.btnAddSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddSub.UseVisualStyleBackColor = False
        '
        'btnProspectus
        '
        Me.btnProspectus.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnProspectus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProspectus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProspectus.FlatAppearance.BorderSize = 0
        Me.btnProspectus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnProspectus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProspectus.ForeColor = System.Drawing.SystemColors.Window
        Me.btnProspectus.Image = CType(resources.GetObject("btnProspectus.Image"), System.Drawing.Image)
        Me.btnProspectus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProspectus.Location = New System.Drawing.Point(0, 142)
        Me.btnProspectus.Name = "btnProspectus"
        Me.btnProspectus.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnProspectus.Size = New System.Drawing.Size(223, 44)
        Me.btnProspectus.TabIndex = 2
        Me.btnProspectus.Text = "Prospectus"
        Me.btnProspectus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProspectus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProspectus.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnTransf
        '
        Me.btnTransf.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnTransf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransf.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransf.FlatAppearance.BorderSize = 0
        Me.btnTransf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnTransf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransf.ForeColor = System.Drawing.SystemColors.Window
        Me.btnTransf.Image = Global.Sysarch2finals.My.Resources.Resources.right_arrow
        Me.btnTransf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransf.Location = New System.Drawing.Point(0, 0)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTransf.Size = New System.Drawing.Size(223, 31)
        Me.btnTransf.TabIndex = 5
        Me.btnTransf.Text = "Transferee"
        Me.btnTransf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransf.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.pnlyear.ResumeLayout(False)
        Me.pnl_drop1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.pnl_drop2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAddSub As Button
    Friend WithEvents btnProspectus As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Button15 As Button
    Friend WithEvents pnlyear As Panel
    Friend WithEvents pnl_drop2 As Panel
    Friend WithEvents btnTransNA As Button
    Friend WithEvents btnTransEval As Button
    Friend WithEvents btnTransf As Button
    Friend WithEvents pnl_drop1 As Panel
    Friend WithEvents btnregADD As Button
    Friend WithEvents btnregEval As Button
    Friend WithEvents btnregA As Button
    Friend WithEvents btnadvise As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
