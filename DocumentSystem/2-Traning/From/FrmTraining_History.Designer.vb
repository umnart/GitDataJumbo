<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTraining_History
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle105 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle106 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle111 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle112 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle107 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle108 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle109 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle110 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraining_History))
        Me.TxtMD = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtEmployeeNo = New MetroFramework.Controls.MetroComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtShowData = New MetroFramework.Controls.MetroComboBox()
        Me.TxtStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.dgvDetail = New MetroFramework.Controls.MetroGrid()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REVNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetrainFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrnnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bntPrinting = New MetroFramework.Controls.MetroButton()
        Me.bntFind = New System.Windows.Forms.PictureBox()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dtpCheck = New MetroFramework.Controls.MetroDateTime()
        Me.dtpToday = New MetroFramework.Controls.MetroDateTime()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntSaveData = New System.Windows.Forms.ToolStripButton()
        Me.bntDeleteData = New System.Windows.Forms.ToolStripButton()
        Me.bntReport = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TxtMD
        '
        Me.TxtMD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtMD.FormattingEnabled = True
        Me.TxtMD.ItemHeight = 23
        Me.TxtMD.Items.AddRange(New Object() {"รายเดือน", "รายวัน"})
        Me.TxtMD.Location = New System.Drawing.Point(114, 8)
        Me.TxtMD.Name = "TxtMD"
        Me.TxtMD.Size = New System.Drawing.Size(114, 29)
        Me.TxtMD.TabIndex = 1376
        Me.TxtMD.UseSelectable = True
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
        Me.Panel3.Location = New System.Drawing.Point(12, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 28)
        Me.Panel3.TabIndex = 1374
        '
        'BackgroundWorker1
        '
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(231, 9)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(95, 28)
        Me.Panel5.TabIndex = 1373
        '
        'TxtEmployeeNo
        '
        Me.TxtEmployeeNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtEmployeeNo.FormattingEnabled = True
        Me.TxtEmployeeNo.ItemHeight = 23
        Me.TxtEmployeeNo.Location = New System.Drawing.Point(327, 9)
        Me.TxtEmployeeNo.Name = "TxtEmployeeNo"
        Me.TxtEmployeeNo.Size = New System.Drawing.Size(338, 29)
        Me.TxtEmployeeNo.TabIndex = 1377
        Me.TxtEmployeeNo.UseSelectable = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(716, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(67, 29)
        Me.Panel4.TabIndex = 1381
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
        'TxtShowData
        '
        Me.TxtShowData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtShowData.FormattingEnabled = True
        Me.TxtShowData.ItemHeight = 23
        Me.TxtShowData.Items.AddRange(New Object() {"Show All RevNo.", "Last RevNo."})
        Me.TxtShowData.Location = New System.Drawing.Point(166, 6)
        Me.TxtShowData.Name = "TxtShowData"
        Me.TxtShowData.Size = New System.Drawing.Size(19, 29)
        Me.TxtShowData.TabIndex = 1383
        Me.TxtShowData.UseSelectable = True
        Me.TxtShowData.Visible = False
        '
        'TxtStartDate
        '
        Me.TxtStartDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtStartDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtStartDate.Location = New System.Drawing.Point(785, 9)
        Me.TxtStartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(109, 29)
        Me.TxtStartDate.TabIndex = 1381
        '
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.AllowUserToResizeRows = False
        DataGridViewCellStyle105.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle105
        Me.dgvDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle106.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle106.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle106.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle106.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle106.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle106.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle106
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.DOCNO, Me.REVNO, Me.EFFDATE, Me.RetrainFreq, Me.DOCNAME, Me.MthdNam, Me.DOCDEPT, Me.TrnnDate, Me.Result, Me.Approve, Me.Remark, Me.MthdCode})
        Me.dgvDetail.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle111.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle111.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle111.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle111.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle111.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle111.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle111.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetail.DefaultCellStyle = DataGridViewCellStyle111
        Me.dgvDetail.EnableHeadersVisualStyles = False
        Me.dgvDetail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.Location = New System.Drawing.Point(0, 90)
        Me.dgvDetail.MultiSelect = False
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle112.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle112.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle112.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle112.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle112.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle112.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle112.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle112
        Me.dgvDetail.RowHeadersVisible = False
        Me.dgvDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetail.Size = New System.Drawing.Size(1091, 510)
        Me.dgvDetail.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvDetail.TabIndex = 1384
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
        DataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.REVNO.DefaultCellStyle = DataGridViewCellStyle107
        Me.REVNO.HeaderText = "REV."
        Me.REVNO.Name = "REVNO"
        Me.REVNO.ReadOnly = True
        Me.REVNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REVNO.Width = 30
        '
        'EFFDATE
        '
        Me.EFFDATE.DataPropertyName = "EFFDATE"
        DataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.EFFDATE.DefaultCellStyle = DataGridViewCellStyle108
        Me.EFFDATE.HeaderText = "Rev. Date"
        Me.EFFDATE.Name = "EFFDATE"
        Me.EFFDATE.ReadOnly = True
        Me.EFFDATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EFFDATE.Width = 80
        '
        'RetrainFreq
        '
        Me.RetrainFreq.DataPropertyName = "RetrainFreq"
        DataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.RetrainFreq.DefaultCellStyle = DataGridViewCellStyle109
        Me.RetrainFreq.HeaderText = "Retraining ครั้งที่"
        Me.RetrainFreq.Name = "RetrainFreq"
        Me.RetrainFreq.ReadOnly = True
        Me.RetrainFreq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'TrnnDate
        '
        Me.TrnnDate.DataPropertyName = "TrnnDate"
        DataGridViewCellStyle110.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TrnnDate.DefaultCellStyle = DataGridViewCellStyle110
        Me.TrnnDate.HeaderText = "TrainingDate"
        Me.TrnnDate.Name = "TrnnDate"
        Me.TrnnDate.ReadOnly = True
        Me.TrnnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TrnnDate.Width = 95
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
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.bntPrinting)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxtEmployeeNo)
        Me.Panel2.Controls.Add(Me.TxtStartDate)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.TxtMD)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.bntFind)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 47)
        Me.Panel2.TabIndex = 1400
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
        Me.bntPrinting.Visible = False
        '
        'bntFind
        '
        Me.bntFind.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntFind.Location = New System.Drawing.Point(669, 8)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(33, 29)
        Me.bntFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntFind.TabIndex = 1378
        Me.bntFind.TabStop = False
        '
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(Me.TextBox1)
        Me.Panel_Head.Controls.Add(Me.PictureBox1)
        Me.Panel_Head.Controls.Add(Me.PictureBox3)
        Me.Panel_Head.Controls.Add(Me.dtpCheck)
        Me.Panel_Head.Controls.Add(Me.dtpToday)
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(Me.Label5)
        Me.Panel_Head.Controls.Add(Me.TxtShowData)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(1091, 43)
        Me.Panel_Head.TabIndex = 1399
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.DocumentSystem.My.Resources.Resources._13014619901547782854minimizebutton_hi1
        Me.PictureBox1.Location = New System.Drawing.Point(1009, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1386
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg2
        Me.PictureBox3.Location = New System.Drawing.Point(1053, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1385
        Me.PictureBox3.TabStop = False
        '
        'dtpCheck
        '
        Me.dtpCheck.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpCheck.CustomFormat = "yyyy-MM-dd"
        Me.dtpCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheck.Location = New System.Drawing.Point(1061, 7)
        Me.dtpCheck.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpCheck.Name = "dtpCheck"
        Me.dtpCheck.Size = New System.Drawing.Size(10, 29)
        Me.dtpCheck.TabIndex = 1384
        '
        'dtpToday
        '
        Me.dtpToday.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpToday.CustomFormat = "yyyy-MM-dd"
        Me.dtpToday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToday.Location = New System.Drawing.Point(1069, 7)
        Me.dtpToday.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpToday.Name = "dtpToday"
        Me.dtpToday.Size = New System.Drawing.Size(10, 29)
        Me.dtpToday.TabIndex = 1382
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(52, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Training History"
        '
        'BackgroundWorker2
        '
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntSaveData, Me.bntDeleteData, Me.bntReport})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 603)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1091, 47)
        Me.ToolStrip3.TabIndex = 1401
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'bntSaveData
        '
        Me.bntSaveData.ForeColor = System.Drawing.Color.White
        Me.bntSaveData.Image = Global.DocumentSystem.My.Resources.Resources.new_database_5123
        Me.bntSaveData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntSaveData.Name = "bntSaveData"
        Me.bntSaveData.Size = New System.Drawing.Size(137, 44)
        Me.bntSaveData.Text = " Copy History to"
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
        'bntReport
        '
        Me.bntReport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bntReport.ForeColor = System.Drawing.Color.White
        Me.bntReport.Image = Global.DocumentSystem.My.Resources.Resources.Icon_Printer
        Me.bntReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntReport.Name = "bntReport"
        Me.bntReport.Size = New System.Drawing.Size(149, 44)
        Me.bntReport.Text = " พิมพ์รายการฝึกอบรม"
        Me.bntReport.ToolTipText = "Delete ( ลบข้อมูลทั้งหมด )"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(209, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(789, 25)
        Me.TextBox1.TabIndex = 1388
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.Visible = False
        '
        'FrmTraining_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 650)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.Controls.Add(Me.dgvDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training History"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bntFind As PictureBox
    Friend WithEvents TxtMD As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtEmployeeNo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtShowData As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TxtStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dgvDetail As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bntPrinting As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtpCheck As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpToday As MetroFramework.Controls.MetroDateTime
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents REVNO As DataGridViewTextBoxColumn
    Friend WithEvents EFFDATE As DataGridViewTextBoxColumn
    Friend WithEvents RetrainFreq As DataGridViewTextBoxColumn
    Friend WithEvents DOCNAME As DataGridViewTextBoxColumn
    Friend WithEvents MthdNam As DataGridViewTextBoxColumn
    Friend WithEvents DOCDEPT As DataGridViewTextBoxColumn
    Friend WithEvents TrnnDate As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewCheckBoxColumn
    Friend WithEvents Approve As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents MthdCode As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntSaveData As ToolStripButton
    Friend WithEvents bntDeleteData As ToolStripButton
    Friend WithEvents bntReport As ToolStripButton
    Friend WithEvents TextBox1 As TextBox
End Class
