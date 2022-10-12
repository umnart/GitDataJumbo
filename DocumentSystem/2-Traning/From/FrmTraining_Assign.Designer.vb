<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTraining_Assign
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraining_Assign))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bntClose = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDetail = New MetroFramework.Controls.MetroGrid()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainerCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetrainFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMD = New MetroFramework.Controls.MetroComboBox()
        Me.TxtEmployeeNo = New MetroFramework.Controls.MetroComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.bntPrinting = New MetroFramework.Controls.MetroButton()
        Me.bntFind = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntAddNew = New System.Windows.Forms.ToolStripButton()
        Me.bntSaveData = New System.Windows.Forms.ToolStripButton()
        Me.bntDeleteData = New System.Windows.Forms.ToolStripButton()
        Me.bntDeleteCancel = New System.Windows.Forms.ToolStripButton()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.bntClose)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.MetroButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 43)
        Me.Panel2.TabIndex = 1352
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.DocumentSystem.My.Resources.Resources._13014619901547782854minimizebutton_hi__Custom_
        Me.PictureBox1.Location = New System.Drawing.Point(1008, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 795
        Me.PictureBox1.TabStop = False
        '
        'bntClose
        '
        Me.bntClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntClose.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg_hi
        Me.bntClose.Location = New System.Drawing.Point(1048, 7)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(34, 29)
        Me.bntClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntClose.TabIndex = 385
        Me.bntClose.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(40, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 794
        Me.Label5.Text = "Training Assign"
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.Report__Custom_1
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(8, 6)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(27, 30)
        Me.MetroButton1.TabIndex = 793
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(242, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(95, 28)
        Me.Panel5.TabIndex = 1353
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อพนักงาน"
        '
        'BackgroundWorker1
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(8, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 28)
        Me.Panel3.TabIndex = 1357
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รายเดือน / รายวัน"
        '
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.DOCNO, Me.Status, Me.DOCNAME, Me.AssignName, Me.TrainerName, Me.MthdNam, Me.Approve, Me.DOCDEPT, Me.AssignCode, Me.TrainerCode, Me.MthdCode, Me.StartDate, Me.Remark, Me.RetrainFreq})
        Me.dgvDetail.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetail.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetail.EnableHeadersVisualStyles = False
        Me.dgvDetail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.Location = New System.Drawing.Point(0, 0)
        Me.dgvDetail.MultiSelect = False
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetail.RowHeadersVisible = False
        Me.dgvDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetail.Size = New System.Drawing.Size(1091, 507)
        Me.dgvDetail.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvDetail.TabIndex = 1359
        Me.dgvDetail.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'No
        '
        Me.No.Frozen = True
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 30
        '
        'DOCNO
        '
        Me.DOCNO.Frozen = True
        Me.DOCNO.HeaderText = "DOC NO"
        Me.DOCNO.Name = "DOCNO"
        Me.DOCNO.ReadOnly = True
        '
        'Status
        '
        Me.Status.Frozen = True
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 80
        '
        'DOCNAME
        '
        Me.DOCNAME.Frozen = True
        Me.DOCNAME.HeaderText = "DOCNAME"
        Me.DOCNAME.Name = "DOCNAME"
        Me.DOCNAME.ReadOnly = True
        Me.DOCNAME.Width = 250
        '
        'AssignName
        '
        Me.AssignName.HeaderText = "Assign"
        Me.AssignName.Name = "AssignName"
        Me.AssignName.ReadOnly = True
        Me.AssignName.Width = 120
        '
        'TrainerName
        '
        Me.TrainerName.HeaderText = "Trainer"
        Me.TrainerName.Name = "TrainerName"
        Me.TrainerName.ReadOnly = True
        Me.TrainerName.Width = 150
        '
        'MthdNam
        '
        Me.MthdNam.HeaderText = "Method Training"
        Me.MthdNam.Name = "MthdNam"
        Me.MthdNam.ReadOnly = True
        Me.MthdNam.Width = 150
        '
        'Approve
        '
        Me.Approve.HeaderText = "Approve By"
        Me.Approve.Name = "Approve"
        Me.Approve.ReadOnly = True
        '
        'DOCDEPT
        '
        Me.DOCDEPT.HeaderText = "DOCDEPT"
        Me.DOCDEPT.Name = "DOCDEPT"
        Me.DOCDEPT.ReadOnly = True
        Me.DOCDEPT.Visible = False
        '
        'AssignCode
        '
        Me.AssignCode.HeaderText = "AssignCode"
        Me.AssignCode.Name = "AssignCode"
        Me.AssignCode.ReadOnly = True
        Me.AssignCode.Visible = False
        '
        'TrainerCode
        '
        Me.TrainerCode.HeaderText = "TrainerCode"
        Me.TrainerCode.Name = "TrainerCode"
        Me.TrainerCode.ReadOnly = True
        Me.TrainerCode.Visible = False
        '
        'MthdCode
        '
        Me.MthdCode.HeaderText = "MthdCode"
        Me.MthdCode.Name = "MthdCode"
        Me.MthdCode.ReadOnly = True
        Me.MthdCode.Visible = False
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "StartDate"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ReadOnly = True
        Me.StartDate.Width = 70
        '
        'Remark
        '
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        Me.Remark.Width = 120
        '
        'RetrainFreq
        '
        Me.RetrainFreq.HeaderText = "Retraing Frequency"
        Me.RetrainFreq.Name = "RetrainFreq"
        Me.RetrainFreq.ReadOnly = True
        '
        'TxtMD
        '
        Me.TxtMD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtMD.FormattingEnabled = True
        Me.TxtMD.ItemHeight = 23
        Me.TxtMD.Items.AddRange(New Object() {"รายเดือน", "รายวัน"})
        Me.TxtMD.Location = New System.Drawing.Point(110, 11)
        Me.TxtMD.Name = "TxtMD"
        Me.TxtMD.Size = New System.Drawing.Size(130, 29)
        Me.TxtMD.TabIndex = 1360
        Me.TxtMD.UseSelectable = True
        '
        'TxtEmployeeNo
        '
        Me.TxtEmployeeNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtEmployeeNo.FormattingEnabled = True
        Me.TxtEmployeeNo.ItemHeight = 23
        Me.TxtEmployeeNo.Location = New System.Drawing.Point(338, 12)
        Me.TxtEmployeeNo.Name = "TxtEmployeeNo"
        Me.TxtEmployeeNo.Size = New System.Drawing.Size(425, 29)
        Me.TxtEmployeeNo.TabIndex = 1361
        Me.TxtEmployeeNo.UseSelectable = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(806, 11)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(67, 29)
        Me.Panel4.TabIndex = 1382
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Start Date"
        '
        'TxtStartDate
        '
        Me.TxtStartDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtStartDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtStartDate.Location = New System.Drawing.Point(875, 11)
        Me.TxtStartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(106, 29)
        Me.TxtStartDate.TabIndex = 1383
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Controls.Add(Me.bntPrinting)
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.TxtMD)
        Me.Panel6.Controls.Add(Me.TxtEmployeeNo)
        Me.Panel6.Controls.Add(Me.TxtStartDate)
        Me.Panel6.Controls.Add(Me.bntFind)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 43)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1091, 47)
        Me.Panel6.TabIndex = 1401
        '
        'bntPrinting
        '
        Me.bntPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntPrinting.BackgroundImage = CType(resources.GetObject("bntPrinting.BackgroundImage"), System.Drawing.Image)
        Me.bntPrinting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntPrinting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntPrinting.Location = New System.Drawing.Point(1042, 3)
        Me.bntPrinting.Name = "bntPrinting"
        Me.bntPrinting.Size = New System.Drawing.Size(37, 38)
        Me.bntPrinting.TabIndex = 9
        Me.bntPrinting.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntPrinting.UseSelectable = True
        '
        'bntFind
        '
        Me.bntFind.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntFind.Location = New System.Drawing.Point(770, 12)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(33, 29)
        Me.bntFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntFind.TabIndex = 1370
        Me.bntFind.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvDetail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1091, 507)
        Me.Panel1.TabIndex = 1402
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ToolStrip3)
        Me.Panel7.Location = New System.Drawing.Point(0, 600)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1091, 50)
        Me.Panel7.TabIndex = 1403
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntAddNew, Me.bntSaveData, Me.bntDeleteData, Me.bntDeleteCancel})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1091, 47)
        Me.ToolStrip3.TabIndex = 14
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'bntAddNew
        '
        Me.bntAddNew.ForeColor = System.Drawing.Color.White
        Me.bntAddNew.Image = CType(resources.GetObject("bntAddNew.Image"), System.Drawing.Image)
        Me.bntAddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntAddNew.Name = "bntAddNew"
        Me.bntAddNew.Size = New System.Drawing.Size(111, 44)
        Me.bntAddNew.Text = "Add course"
        Me.bntAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bntSaveData
        '
        Me.bntSaveData.ForeColor = System.Drawing.Color.White
        Me.bntSaveData.Image = Global.DocumentSystem.My.Resources.Resources.new_database_5123
        Me.bntSaveData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntSaveData.Name = "bntSaveData"
        Me.bntSaveData.Size = New System.Drawing.Size(132, 44)
        Me.bntSaveData.Text = " Copy assign to"
        '
        'bntDeleteData
        '
        Me.bntDeleteData.ForeColor = System.Drawing.Color.White
        Me.bntDeleteData.Image = Global.DocumentSystem.My.Resources.Resources.delete_icon_image_15_jpg
        Me.bntDeleteData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntDeleteData.Name = "bntDeleteData"
        Me.bntDeleteData.Size = New System.Drawing.Size(173, 44)
        Me.bntDeleteData.Text = "Delete ( ลบข้อมูลทั้งหมด )"
        Me.bntDeleteData.ToolTipText = "Delete ( ลบข้อมูลทั้งหมด )"
        '
        'bntDeleteCancel
        '
        Me.bntDeleteCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bntDeleteCancel.ForeColor = System.Drawing.Color.White
        Me.bntDeleteCancel.Image = Global.DocumentSystem.My.Resources.Resources.delete_button_pngrepo_com1
        Me.bntDeleteCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntDeleteCancel.Name = "bntDeleteCancel"
        Me.bntDeleteCancel.Size = New System.Drawing.Size(180, 44)
        Me.bntDeleteCancel.Text = "Delete Course ที่ยกเลิกเเล้ว"
        Me.bntDeleteCancel.ToolTipText = "Delete ( ลบข้อมูลทั้งหมด )"
        '
        'BackgroundWorker2
        '
        '
        'FrmTraining_Assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 650)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_Assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training Assign"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents bntClose As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDetail As MetroFramework.Controls.MetroGrid
    Friend WithEvents TxtMD As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TxtEmployeeNo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents bntFind As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents bntPrinting As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntAddNew As ToolStripButton
    Friend WithEvents bntDeleteData As ToolStripButton
    Friend WithEvents bntSaveData As ToolStripButton
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents DOCNAME As DataGridViewTextBoxColumn
    Friend WithEvents AssignName As DataGridViewTextBoxColumn
    Friend WithEvents TrainerName As DataGridViewTextBoxColumn
    Friend WithEvents MthdNam As DataGridViewTextBoxColumn
    Friend WithEvents Approve As DataGridViewTextBoxColumn
    Friend WithEvents DOCDEPT As DataGridViewTextBoxColumn
    Friend WithEvents AssignCode As DataGridViewTextBoxColumn
    Friend WithEvents TrainerCode As DataGridViewTextBoxColumn
    Friend WithEvents MthdCode As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents RetrainFreq As DataGridViewTextBoxColumn
    Friend WithEvents bntDeleteCancel As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
