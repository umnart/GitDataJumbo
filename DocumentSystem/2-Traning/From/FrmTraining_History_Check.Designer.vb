<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTraining_History_Check
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraining_History_Check))
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
        Me.RetrainFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrnnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEFFDate = New MetroFramework.Controls.MetroDateTime()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TxtMD = New MetroFramework.Controls.MetroComboBox()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TxtChkStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dtpToday = New MetroFramework.Controls.MetroDateTime()
        Me.dtpCheck = New MetroFramework.Controls.MetroDateTime()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnApprove = New System.Windows.Forms.Panel()
        Me.bntSave = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtResult = New System.Windows.Forms.CheckBox()
        Me.bntSDFind = New System.Windows.Forms.PictureBox()
        Me.TxtSection = New MetroFramework.Controls.MetroComboBox()
        Me.TxtDOCNO = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.bntFind = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnApprove.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bntSDFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.DOCNO, Me.REVNO, Me.EFFDATE, Me.DOCNAME, Me.EmployeeNo, Me.EmployeeName, Me.MthdNam, Me.DOCDEPT, Me.RetrainFreq, Me.TrnnDate, Me.Result, Me.Approve, Me.Remark, Me.MthdCode})
        Me.dgvDetail.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetail.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDetail.EnableHeadersVisualStyles = False
        Me.dgvDetail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.Location = New System.Drawing.Point(7, 96)
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
        Me.dgvDetail.Size = New System.Drawing.Size(1078, 542)
        Me.dgvDetail.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvDetail.TabIndex = 1395
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
        Me.EFFDATE.Width = 75
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
        Me.EmployeeName.Width = 120
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
        'RetrainFreq
        '
        Me.RetrainFreq.DataPropertyName = "RetrainFreq"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RetrainFreq.DefaultCellStyle = DataGridViewCellStyle5
        Me.RetrainFreq.HeaderText = "Retraining ครั้งที่"
        Me.RetrainFreq.Name = "RetrainFreq"
        Me.RetrainFreq.ReadOnly = True
        Me.RetrainFreq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RetrainFreq.Width = 65
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
        Me.TrnnDate.Width = 80
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
        'TxtEFFDate
        '
        Me.TxtEFFDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtEFFDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtEFFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtEFFDate.Location = New System.Drawing.Point(265, 8)
        Me.TxtEFFDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtEFFDate.Name = "TxtEFFDate"
        Me.TxtEFFDate.Size = New System.Drawing.Size(10, 29)
        Me.TxtEFFDate.TabIndex = 1392
        Me.TxtEFFDate.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'TxtMD
        '
        Me.TxtMD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtMD.FormattingEnabled = True
        Me.TxtMD.ItemHeight = 23
        Me.TxtMD.Items.AddRange(New Object() {"รายเดือน", "รายวัน"})
        Me.TxtMD.Location = New System.Drawing.Point(157, 9)
        Me.TxtMD.Name = "TxtMD"
        Me.TxtMD.Size = New System.Drawing.Size(95, 29)
        Me.TxtMD.TabIndex = 1
        Me.TxtMD.UseSelectable = True
        '
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(Me.TextBox1)
        Me.Panel_Head.Controls.Add(Me.ProgressBar1)
        Me.Panel_Head.Controls.Add(Me.PictureBox3)
        Me.Panel_Head.Controls.Add(Me.lblResult)
        Me.Panel_Head.Controls.Add(Me.TxtChkStartDate)
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.Panel4)
        Me.Panel_Head.Controls.Add(Me.PictureBox1)
        Me.Panel_Head.Controls.Add(Me.Label1)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(Me.TxtEFFDate)
        Me.Panel_Head.Controls.Add(Me.dtpToday)
        Me.Panel_Head.Controls.Add(Me.dtpCheck)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(1091, 43)
        Me.Panel_Head.TabIndex = 1397
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Desktop
        Me.ProgressBar1.Location = New System.Drawing.Point(239, 9)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Minimum = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(22, 23)
        Me.ProgressBar1.Step = 50
        Me.ProgressBar1.TabIndex = 1399
        Me.ProgressBar1.Value = 10
        Me.ProgressBar1.Visible = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.Location = New System.Drawing.Point(55, 3)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(10, 13)
        Me.lblResult.TabIndex = 1403
        Me.lblResult.Text = "."
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.DocumentSystem.My.Resources.Resources._13014619901547782854minimizebutton_hi1
        Me.PictureBox3.Location = New System.Drawing.Point(1002, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1403
        Me.PictureBox3.TabStop = False
        '
        'TxtChkStartDate
        '
        Me.TxtChkStartDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtChkStartDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtChkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtChkStartDate.Location = New System.Drawing.Point(316, 6)
        Me.TxtChkStartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtChkStartDate.Name = "TxtChkStartDate"
        Me.TxtChkStartDate.Size = New System.Drawing.Size(21, 29)
        Me.TxtChkStartDate.TabIndex = 1400
        Me.TxtChkStartDate.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(277, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(33, 29)
        Me.Panel4.TabIndex = 1399
        Me.Panel4.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(308, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "From Rev. Date  ( **  กำหนด Rev. Date ที่ต้องการตรวจเช็ค )"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(51, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Check Revision Not Update"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.DocumentSystem.My.Resources.Resources.Close1
        Me.PictureBox2.Location = New System.Drawing.Point(1048, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
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
        Me.dtpToday.TabIndex = 1402
        '
        'dtpCheck
        '
        Me.dtpCheck.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpCheck.CustomFormat = "yyyy-MM-dd"
        Me.dtpCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheck.Location = New System.Drawing.Point(1060, 7)
        Me.dtpCheck.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpCheck.Name = "dtpCheck"
        Me.dtpCheck.Size = New System.Drawing.Size(10, 29)
        Me.dtpCheck.TabIndex = 1401
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.pnApprove)
        Me.Panel2.Controls.Add(Me.bntSDFind)
        Me.Panel2.Controls.Add(Me.TxtSection)
        Me.Panel2.Controls.Add(Me.TxtDOCNO)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxtStartDate)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.bntFind)
        Me.Panel2.Controls.Add(Me.TxtMD)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 47)
        Me.Panel2.TabIndex = 1398
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(497, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(116, 29)
        Me.Panel5.TabIndex = 1406
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เอกสารเลขที่ Doc.No"
        '
        'pnApprove
        '
        Me.pnApprove.Controls.Add(Me.bntSave)
        Me.pnApprove.Controls.Add(Me.Panel1)
        Me.pnApprove.Controls.Add(Me.TxtResult)
        Me.pnApprove.Location = New System.Drawing.Point(883, 3)
        Me.pnApprove.Name = "pnApprove"
        Me.pnApprove.Size = New System.Drawing.Size(204, 42)
        Me.pnApprove.TabIndex = 1404
        '
        'bntSave
        '
        Me.bntSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntSave.BackgroundImage = CType(resources.GetObject("bntSave.BackgroundImage"), System.Drawing.Image)
        Me.bntSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSave.Location = New System.Drawing.Point(165, 1)
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(37, 38)
        Me.bntSave.TabIndex = 1406
        Me.bntSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntSave.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(53, 24)
        Me.Panel1.TabIndex = 1405
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Result"
        '
        'TxtResult
        '
        Me.TxtResult.AutoSize = True
        Me.TxtResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtResult.ForeColor = System.Drawing.Color.White
        Me.TxtResult.Location = New System.Drawing.Point(65, 14)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(103, 17)
        Me.TxtResult.TabIndex = 1404
        Me.TxtResult.Text = "Pass / Not Pass"
        Me.TxtResult.UseVisualStyleBackColor = True
        '
        'bntSDFind
        '
        Me.bntSDFind.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntSDFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSDFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntSDFind.Location = New System.Drawing.Point(840, 8)
        Me.bntSDFind.Name = "bntSDFind"
        Me.bntSDFind.Size = New System.Drawing.Size(33, 29)
        Me.bntSDFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntSDFind.TabIndex = 1402
        Me.bntSDFind.TabStop = False
        '
        'TxtSection
        '
        Me.TxtSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtSection.FormattingEnabled = True
        Me.TxtSection.ItemHeight = 23
        Me.TxtSection.Location = New System.Drawing.Point(317, 8)
        Me.TxtSection.Name = "TxtSection"
        Me.TxtSection.Size = New System.Drawing.Size(175, 29)
        Me.TxtSection.TabIndex = 3
        Me.TxtSection.UseSelectable = True
        '
        'TxtDOCNO
        '
        Me.TxtDOCNO.BackColor = System.Drawing.Color.White
        Me.TxtDOCNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDOCNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDOCNO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOCNO.Location = New System.Drawing.Point(614, 8)
        Me.TxtDOCNO.Name = "TxtDOCNO"
        Me.TxtDOCNO.Size = New System.Drawing.Size(220, 29)
        Me.TxtDOCNO.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Location = New System.Drawing.Point(259, 9)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(57, 28)
        Me.Panel8.TabIndex = 1400
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Section"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(56, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 29)
        Me.Panel3.TabIndex = 1399
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
        'TxtStartDate
        '
        Me.TxtStartDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtStartDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtStartDate.Location = New System.Drawing.Point(125, 9)
        Me.TxtStartDate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(26, 29)
        Me.TxtStartDate.TabIndex = 1399
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(14, 9)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 66
        Me.PictureBox6.TabStop = False
        '
        'bntFind
        '
        Me.bntFind.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntFind.Location = New System.Drawing.Point(270, 8)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(33, 29)
        Me.bntFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntFind.TabIndex = 1396
        Me.bntFind.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(239, 11)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(757, 25)
        Me.TextBox1.TabIndex = 1404
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.Visible = False
        '
        'FrmTraining_History_Check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 650)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.Controls.Add(Me.dgvDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_History_Check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Revision Not Update"
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnApprove.ResumeLayout(False)
        Me.pnApprove.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bntSDFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDetail As MetroFramework.Controls.MetroGrid
    Friend WithEvents TxtEFFDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtMD As MetroFramework.Controls.MetroComboBox
    Friend WithEvents bntFind As PictureBox
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TxtChkStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCheck As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpToday As MetroFramework.Controls.MetroDateTime
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents REVNO As DataGridViewTextBoxColumn
    Friend WithEvents EFFDATE As DataGridViewTextBoxColumn
    Friend WithEvents DOCNAME As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNo As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents MthdNam As DataGridViewTextBoxColumn
    Friend WithEvents DOCDEPT As DataGridViewTextBoxColumn
    Friend WithEvents RetrainFreq As DataGridViewTextBoxColumn
    Friend WithEvents TrnnDate As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewCheckBoxColumn
    Friend WithEvents Approve As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents MthdCode As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSection As MetroFramework.Controls.MetroComboBox
    Friend WithEvents bntSDFind As PictureBox
    Friend WithEvents lblResult As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtResult As CheckBox
    Friend WithEvents pnApprove As Panel
    Friend WithEvents bntSave As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDOCNO As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
