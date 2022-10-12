<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraining_History_Retraining
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraining_History_Retraining))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtYearData = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSelectData = New MetroFramework.Controls.MetroComboBox()
        Me.bntPrinting = New MetroFramework.Controls.MetroButton()
        Me.TxtEmployeeNo = New MetroFramework.Controls.MetroComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.bntFind = New System.Windows.Forms.PictureBox()
        Me.TxtMD = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtTrnnDate = New MetroFramework.Controls.MetroDateTime()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgvDetail = New MetroFramework.Controls.MetroGrid()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REVNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoReTraining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrnnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.menuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.bntDeleteAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntSaveData = New System.Windows.Forms.ToolStripButton()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(1021, 9)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 66
        IDLabel.Text = "ID:"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(203, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 29)
        Me.Panel3.TabIndex = 1399
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.TxtYearData)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.TxtSelectData)
        Me.Panel2.Controls.Add(Me.bntPrinting)
        Me.Panel2.Controls.Add(Me.TxtEmployeeNo)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxtStartDate)
        Me.Panel2.Controls.Add(Me.bntFind)
        Me.Panel2.Controls.Add(Me.TxtMD)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 47)
        Me.Panel2.TabIndex = 1401
        '
        'TxtYearData
        '
        Me.TxtYearData.BackColor = System.Drawing.Color.White
        Me.TxtYearData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtYearData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtYearData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtYearData.Location = New System.Drawing.Point(137, 7)
        Me.TxtYearData.Name = "TxtYearData"
        Me.TxtYearData.Size = New System.Drawing.Size(63, 29)
        Me.TxtYearData.TabIndex = 1403
        Me.TxtYearData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(400, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(63, 29)
        Me.Panel7.TabIndex = 1408
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เลือกข้อมูล"
        '
        'TxtSelectData
        '
        Me.TxtSelectData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtSelectData.FormattingEnabled = True
        Me.TxtSelectData.ItemHeight = 23
        Me.TxtSelectData.Items.AddRange(New Object() {"ดูข้อมูลทั้งหมด", "ดูข้อมูลเฉพาะพนักงาน"})
        Me.TxtSelectData.Location = New System.Drawing.Point(464, 8)
        Me.TxtSelectData.Name = "TxtSelectData"
        Me.TxtSelectData.Size = New System.Drawing.Size(154, 29)
        Me.TxtSelectData.TabIndex = 1406
        Me.TxtSelectData.UseSelectable = True
        '
        'bntPrinting
        '
        Me.bntPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntPrinting.BackgroundImage = CType(resources.GetObject("bntPrinting.BackgroundImage"), System.Drawing.Image)
        Me.bntPrinting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntPrinting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntPrinting.Location = New System.Drawing.Point(1051, 4)
        Me.bntPrinting.Name = "bntPrinting"
        Me.bntPrinting.Size = New System.Drawing.Size(37, 38)
        Me.bntPrinting.TabIndex = 1405
        Me.bntPrinting.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntPrinting.UseSelectable = True
        '
        'TxtEmployeeNo
        '
        Me.TxtEmployeeNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtEmployeeNo.FormattingEnabled = True
        Me.TxtEmployeeNo.ItemHeight = 23
        Me.TxtEmployeeNo.Location = New System.Drawing.Point(717, 8)
        Me.TxtEmployeeNo.Name = "TxtEmployeeNo"
        Me.TxtEmployeeNo.Size = New System.Drawing.Size(286, 29)
        Me.TxtEmployeeNo.TabIndex = 1404
        Me.TxtEmployeeNo.UseSelectable = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(621, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(95, 28)
        Me.Panel5.TabIndex = 1403
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ชื่อพนักงาน"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(7, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(130, 29)
        Me.Panel4.TabIndex = 1402
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Re-Training Year(YYYY)"
        '
        'TxtStartDate
        '
        Me.TxtStartDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtStartDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtStartDate.Location = New System.Drawing.Point(251, 7)
        Me.TxtStartDate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(26, 29)
        Me.TxtStartDate.TabIndex = 1399
        '
        'bntFind
        '
        Me.bntFind.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntFind.Location = New System.Drawing.Point(1012, 8)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(33, 29)
        Me.bntFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntFind.TabIndex = 1396
        Me.bntFind.TabStop = False
        '
        'TxtMD
        '
        Me.TxtMD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtMD.FormattingEnabled = True
        Me.TxtMD.ItemHeight = 23
        Me.TxtMD.Items.AddRange(New Object() {"รายเดือน", "รายวัน"})
        Me.TxtMD.Location = New System.Drawing.Point(304, 7)
        Me.TxtMD.Name = "TxtMD"
        Me.TxtMD.Size = New System.Drawing.Size(93, 29)
        Me.TxtMD.TabIndex = 1388
        Me.TxtMD.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(52, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Re-Training Document"
        '
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(Me.TxtTrnnDate)
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox1)
        Me.Panel_Head.Controls.Add(Me.Label1)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(1091, 43)
        Me.Panel_Head.TabIndex = 1400
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg4
        Me.PictureBox2.Location = New System.Drawing.Point(1053, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1402
        Me.PictureBox2.TabStop = False
        '
        'TxtTrnnDate
        '
        Me.TxtTrnnDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtTrnnDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtTrnnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtTrnnDate.Location = New System.Drawing.Point(1063, 8)
        Me.TxtTrnnDate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.TxtTrnnDate.Name = "TxtTrnnDate"
        Me.TxtTrnnDate.Size = New System.Drawing.Size(16, 29)
        Me.TxtTrnnDate.TabIndex = 1401
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToAddRows = False
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
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.DOCNO, Me.REVNO, Me.EFFDATE, Me.DOCNAME, Me.EmployeeNo, Me.EmployeeName, Me.MthdNam, Me.DOCDEPT, Me.NoReTraining, Me.TrnnDate, Me.Result, Me.Approve, Me.Remark, Me.MthdCode, Me.Dept, Me.MD})
        Me.dgvDetail.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetail.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvDetail.EnableHeadersVisualStyles = False
        Me.dgvDetail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.Location = New System.Drawing.Point(0, 0)
        Me.dgvDetail.MultiSelect = False
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDetail.RowHeadersVisible = False
        Me.dgvDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetail.Size = New System.Drawing.Size(1091, 508)
        Me.dgvDetail.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvDetail.TabIndex = 1399
        Me.dgvDetail.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'No
        '
        Me.No.DataPropertyName = "No"
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.No.Width = 30
        '
        'DOCNO
        '
        Me.DOCNO.DataPropertyName = "DOCNO"
        Me.DOCNO.HeaderText = "DOC NO"
        Me.DOCNO.Name = "DOCNO"
        Me.DOCNO.ReadOnly = True
        Me.DOCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'REVNO
        '
        Me.REVNO.DataPropertyName = "REVNO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.REVNO.DefaultCellStyle = DataGridViewCellStyle3
        Me.REVNO.HeaderText = "REV"
        Me.REVNO.Name = "REVNO"
        Me.REVNO.ReadOnly = True
        Me.REVNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REVNO.Width = 30
        '
        'EFFDATE
        '
        Me.EFFDATE.DataPropertyName = "EFFDATE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.EFFDATE.DefaultCellStyle = DataGridViewCellStyle4
        Me.EFFDATE.HeaderText = "Rev Date"
        Me.EFFDATE.Name = "EFFDATE"
        Me.EFFDATE.ReadOnly = True
        Me.EFFDATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EFFDATE.Width = 80
        '
        'DOCNAME
        '
        Me.DOCNAME.DataPropertyName = "DOCNAME"
        Me.DOCNAME.HeaderText = "DOCNAME"
        Me.DOCNAME.Name = "DOCNAME"
        Me.DOCNAME.ReadOnly = True
        Me.DOCNAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DOCNAME.Width = 290
        '
        'EmployeeNo
        '
        Me.EmployeeNo.DataPropertyName = "EmployeeNo"
        Me.EmployeeNo.HeaderText = "EmployeeNo"
        Me.EmployeeNo.Name = "EmployeeNo"
        Me.EmployeeNo.ReadOnly = True
        Me.EmployeeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EmployeeNo.Visible = False
        '
        'EmployeeName
        '
        Me.EmployeeName.DataPropertyName = "EmployeeName"
        Me.EmployeeName.HeaderText = "EmployeeName"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EmployeeName.Width = 130
        '
        'MthdNam
        '
        Me.MthdNam.DataPropertyName = "MthdNam"
        Me.MthdNam.HeaderText = "Method Training"
        Me.MthdNam.Name = "MthdNam"
        Me.MthdNam.ReadOnly = True
        Me.MthdNam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MthdNam.Width = 140
        '
        'DOCDEPT
        '
        Me.DOCDEPT.DataPropertyName = "DOCDEPT"
        Me.DOCDEPT.HeaderText = "DOCDEPT"
        Me.DOCDEPT.Name = "DOCDEPT"
        Me.DOCDEPT.ReadOnly = True
        Me.DOCDEPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DOCDEPT.Visible = False
        '
        'NoReTraining
        '
        Me.NoReTraining.DataPropertyName = "NoReTraining"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NoReTraining.DefaultCellStyle = DataGridViewCellStyle5
        Me.NoReTraining.HeaderText = "No.Re-Train"
        Me.NoReTraining.Name = "NoReTraining"
        Me.NoReTraining.ReadOnly = True
        Me.NoReTraining.Width = 50
        '
        'TrnnDate
        '
        Me.TrnnDate.DataPropertyName = "TrnnDate"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TrnnDate.DefaultCellStyle = DataGridViewCellStyle6
        Me.TrnnDate.HeaderText = "TrainingDate"
        Me.TrnnDate.Name = "TrnnDate"
        Me.TrnnDate.ReadOnly = True
        Me.TrnnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TrnnDate.Width = 90
        '
        'Result
        '
        Me.Result.DataPropertyName = "Result"
        Me.Result.HeaderText = "Pass"
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        Me.Result.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Result.TrueValue = "1"
        Me.Result.Width = 50
        '
        'Approve
        '
        Me.Approve.DataPropertyName = "Approve"
        Me.Approve.HeaderText = "Approve By"
        Me.Approve.Name = "Approve"
        Me.Approve.ReadOnly = True
        Me.Approve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Remark
        '
        Me.Remark.DataPropertyName = "Remark"
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        Me.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MthdCode
        '
        Me.MthdCode.DataPropertyName = "MthdCode"
        Me.MthdCode.HeaderText = "MthdCode"
        Me.MthdCode.Name = "MthdCode"
        Me.MthdCode.ReadOnly = True
        Me.MthdCode.Visible = False
        '
        'Dept
        '
        Me.Dept.HeaderText = "Dept"
        Me.Dept.Name = "Dept"
        Me.Dept.ReadOnly = True
        Me.Dept.Visible = False
        '
        'MD
        '
        Me.MD.HeaderText = "MD"
        Me.MD.Name = "MD"
        Me.MD.ReadOnly = True
        Me.MD.Visible = False
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDelete, Me.bntDeleteAll})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(187, 76)
        '
        'menuDelete
        '
        Me.menuDelete.Image = CType(resources.GetObject("menuDelete.Image"), System.Drawing.Image)
        Me.menuDelete.Name = "menuDelete"
        Me.menuDelete.Size = New System.Drawing.Size(186, 36)
        Me.menuDelete.Text = "ลบเฉพาะรายชื่อที่เลือก"
        '
        'bntDeleteAll
        '
        Me.bntDeleteAll.Image = Global.DocumentSystem.My.Resources.Resources.delete_icon_image_151
        Me.bntDeleteAll.Name = "bntDeleteAll"
        Me.bntDeleteAll.Size = New System.Drawing.Size(186, 36)
        Me.bntDeleteAll.Text = "ทุกคนที่อมรมในครั้งนี้"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvDetail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1091, 560)
        Me.Panel1.TabIndex = 1402
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.ToolStrip3)
        Me.Panel6.Location = New System.Drawing.Point(3, 601)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1088, 48)
        Me.Panel6.TabIndex = 1403
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntSaveData})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1088, 47)
        Me.ToolStrip3.TabIndex = 15
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'bntSaveData
        '
        Me.bntSaveData.ForeColor = System.Drawing.Color.White
        Me.bntSaveData.Image = Global.DocumentSystem.My.Resources.Resources.new_database_5123
        Me.bntSaveData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntSaveData.Name = "bntSaveData"
        Me.bntSaveData.Size = New System.Drawing.Size(111, 44)
        Me.bntSaveData.Text = "Re-Training"
        '
        'FrmTraining_History_Retraining
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 650)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_History_Retraining"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTraining_History_Retraining"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents bntFind As PictureBox
    Friend WithEvents TxtMD As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvDetail As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents menuDelete As ToolStripMenuItem
    Friend WithEvents bntDeleteAll As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TxtTrnnDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEmployeeNo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntSaveData As ToolStripButton
    Friend WithEvents bntPrinting As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSelectData As MetroFramework.Controls.MetroComboBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents REVNO As DataGridViewTextBoxColumn
    Friend WithEvents EFFDATE As DataGridViewTextBoxColumn
    Friend WithEvents DOCNAME As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNo As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents MthdNam As DataGridViewTextBoxColumn
    Friend WithEvents DOCDEPT As DataGridViewTextBoxColumn
    Friend WithEvents NoReTraining As DataGridViewTextBoxColumn
    Friend WithEvents TrnnDate As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewCheckBoxColumn
    Friend WithEvents Approve As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents MthdCode As DataGridViewTextBoxColumn
    Friend WithEvents Dept As DataGridViewTextBoxColumn
    Friend WithEvents MD As DataGridViewTextBoxColumn
    Friend WithEvents TxtYearData As TextBox
End Class
