<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCourseMaster
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCourseMaster))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntClose = New System.Windows.Forms.PictureBox()
        Me.grdData = New MetroFramework.Controls.MetroGrid()
        Me.DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REVNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCTYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REASON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELECTSYSTEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtEFFDATE = New MetroFramework.Controls.MetroDateTime()
        Me.Panel53 = New System.Windows.Forms.Panel()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Panel51 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDOCNAME = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDOCNO = New System.Windows.Forms.TextBox()
        Me.Panel52 = New System.Windows.Forms.Panel()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDOCTYPE = New MetroFramework.Controls.MetroComboBox()
        Me.TxtREVNO = New System.Windows.Forms.TextBox()
        Me.TxtDOCDEPT = New MetroFramework.Controls.MetroComboBox()
        Me.TxtLinkPdf = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntAddItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TxtFind = New MetroFramework.Controls.MetroTextBox()
        Me.TxtDOCTYPEFind = New MetroFramework.Controls.MetroComboBox()
        Me.TxtFindData = New System.Windows.Forms.TextBox()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSELECTSYSTEM = New MetroFramework.Controls.MetroComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkSelectALL = New System.Windows.Forms.CheckBox()
        Me.dgvDataDept = New MetroFramework.Controls.MetroGrid()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeptCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTDOCSHARE = New MetroFramework.Controls.MetroComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDateNow = New MetroFramework.Controls.MetroDateTime()
        Me.TxtREASON = New System.Windows.Forms.TextBox()
        Me.bntLinkPdf = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel53.SuspendLayout()
        Me.Panel51.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel52.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvDataDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.bntLinkPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 877
        Me.Button1.Text = "Button1"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bntClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1119, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(44, 681)
        Me.Panel1.TabIndex = 860
        '
        'bntClose
        '
        Me.bntClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntClose.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg_hi
        Me.bntClose.Location = New System.Drawing.Point(5, 5)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(34, 29)
        Me.bntClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntClose.TabIndex = 385
        Me.bntClose.TabStop = False
        '
        'grdData
        '
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.grdData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DOCNO, Me.DOCNAME, Me.STATUS, Me.DOCDEPT, Me.REVNO, Me.EFFDATE, Me.DOCTYPE, Me.AttachFile, Me.REASON, Me.SELECTSYSTEM})
        Me.grdData.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle11
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdData.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdData.Location = New System.Drawing.Point(8, 353)
        Me.grdData.MultiSelect = False
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grdData.RowHeadersVisible = False
        Me.grdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(1103, 321)
        Me.grdData.Style = MetroFramework.MetroColorStyle.Teal
        Me.grdData.TabIndex = 873
        Me.grdData.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'DOCNO
        '
        Me.DOCNO.Frozen = True
        Me.DOCNO.HeaderText = "DOCNO"
        Me.DOCNO.Name = "DOCNO"
        Me.DOCNO.ReadOnly = True
        Me.DOCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DOCNAME
        '
        Me.DOCNAME.Frozen = True
        Me.DOCNAME.HeaderText = "DOCNAME"
        Me.DOCNAME.Name = "DOCNAME"
        Me.DOCNAME.ReadOnly = True
        Me.DOCNAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DOCNAME.Width = 300
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        Me.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.STATUS.Width = 50
        '
        'DOCDEPT
        '
        Me.DOCDEPT.HeaderText = "DOCDEPT"
        Me.DOCDEPT.Name = "DOCDEPT"
        Me.DOCDEPT.ReadOnly = True
        Me.DOCDEPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'REVNO
        '
        Me.REVNO.HeaderText = "REVNO"
        Me.REVNO.Name = "REVNO"
        Me.REVNO.ReadOnly = True
        Me.REVNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REVNO.Width = 50
        '
        'EFFDATE
        '
        Me.EFFDATE.HeaderText = "EFFDATE"
        Me.EFFDATE.Name = "EFFDATE"
        Me.EFFDATE.ReadOnly = True
        Me.EFFDATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EFFDATE.Width = 80
        '
        'DOCTYPE
        '
        Me.DOCTYPE.HeaderText = "DOCTYPE"
        Me.DOCTYPE.Name = "DOCTYPE"
        Me.DOCTYPE.ReadOnly = True
        Me.DOCTYPE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DOCTYPE.Width = 70
        '
        'AttachFile
        '
        Me.AttachFile.HeaderText = "AttachFile"
        Me.AttachFile.Name = "AttachFile"
        Me.AttachFile.ReadOnly = True
        Me.AttachFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'REASON
        '
        Me.REASON.HeaderText = "REASON"
        Me.REASON.Name = "REASON"
        Me.REASON.ReadOnly = True
        Me.REASON.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REASON.Width = 250
        '
        'SELECTSYSTEM
        '
        Me.SELECTSYSTEM.HeaderText = "SELECTSYSTEM"
        Me.SELECTSYSTEM.Name = "SELECTSYSTEM"
        Me.SELECTSYSTEM.ReadOnly = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Controls.Add(Me.Button1)
        Me.Panel10.Location = New System.Drawing.Point(8, 148)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(116, 164)
        Me.Panel10.TabIndex = 1152
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "รายละเอียดการแก้ไข"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtEFFDATE
        '
        Me.TxtEFFDATE.CustomFormat = "dd/MM/yyyy"
        Me.TxtEFFDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtEFFDATE.Location = New System.Drawing.Point(586, 116)
        Me.TxtEFFDATE.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtEFFDATE.Name = "TxtEFFDATE"
        Me.TxtEFFDATE.Size = New System.Drawing.Size(125, 29)
        Me.TxtEFFDATE.TabIndex = 6
        '
        'Panel53
        '
        Me.Panel53.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel53.Controls.Add(Me.Label60)
        Me.Panel53.Location = New System.Drawing.Point(469, 116)
        Me.Panel53.Name = "Panel53"
        Me.Panel53.Size = New System.Drawing.Size(116, 29)
        Me.Panel53.TabIndex = 1148
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label60.Location = New System.Drawing.Point(3, 7)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(111, 15)
        Me.Label60.TabIndex = 0
        Me.Label60.Text = "วันที่บังคับใช้ Eff.date"
        '
        'Panel51
        '
        Me.Panel51.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel51.Controls.Add(Me.Label14)
        Me.Panel51.Location = New System.Drawing.Point(8, 116)
        Me.Panel51.Name = "Panel51"
        Me.Panel51.Size = New System.Drawing.Size(116, 29)
        Me.Panel51.TabIndex = 1147
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "เอกสารของฝ่าย Dept"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Location = New System.Drawing.Point(294, 85)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(116, 29)
        Me.Panel8.TabIndex = 1145
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ชื่อเรื่อง ( TH )"
        '
        'TxtDOCNAME
        '
        Me.TxtDOCNAME.BackColor = System.Drawing.Color.White
        Me.TxtDOCNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDOCNAME.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOCNAME.Location = New System.Drawing.Point(411, 85)
        Me.TxtDOCNAME.Multiline = True
        Me.TxtDOCNAME.Name = "TxtDOCNAME"
        Me.TxtDOCNAME.Size = New System.Drawing.Size(577, 29)
        Me.TxtDOCNAME.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(8, 84)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(116, 29)
        Me.Panel4.TabIndex = 1143
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "เอกสารเลขที่ Doc.No"
        '
        'TxtDOCNO
        '
        Me.TxtDOCNO.BackColor = System.Drawing.Color.White
        Me.TxtDOCNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDOCNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDOCNO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOCNO.Location = New System.Drawing.Point(125, 84)
        Me.TxtDOCNO.Name = "TxtDOCNO"
        Me.TxtDOCNO.Size = New System.Drawing.Size(167, 29)
        Me.TxtDOCNO.TabIndex = 2
        '
        'Panel52
        '
        Me.Panel52.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel52.Controls.Add(Me.Label55)
        Me.Panel52.Location = New System.Drawing.Point(294, 116)
        Me.Panel52.Name = "Panel52"
        Me.Panel52.Size = New System.Drawing.Size(116, 29)
        Me.Panel52.TabIndex = 1153
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label55.Location = New System.Drawing.Point(3, 7)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(87, 15)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "แก้ไขครั้งที่ Rev."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(8, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(116, 29)
        Me.Panel3.TabIndex = 1155
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ประเภทเอกสาร"
        '
        'TxtDOCTYPE
        '
        Me.TxtDOCTYPE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCTYPE.FormattingEnabled = True
        Me.TxtDOCTYPE.ItemHeight = 23
        Me.TxtDOCTYPE.Location = New System.Drawing.Point(125, 52)
        Me.TxtDOCTYPE.Name = "TxtDOCTYPE"
        Me.TxtDOCTYPE.Size = New System.Drawing.Size(248, 29)
        Me.TxtDOCTYPE.TabIndex = 1
        Me.TxtDOCTYPE.UseSelectable = True
        '
        'TxtREVNO
        '
        Me.TxtREVNO.BackColor = System.Drawing.Color.White
        Me.TxtREVNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtREVNO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtREVNO.Location = New System.Drawing.Point(411, 116)
        Me.TxtREVNO.Multiline = True
        Me.TxtREVNO.Name = "TxtREVNO"
        Me.TxtREVNO.Size = New System.Drawing.Size(56, 29)
        Me.TxtREVNO.TabIndex = 5
        Me.TxtREVNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDOCDEPT
        '
        Me.TxtDOCDEPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCDEPT.FormattingEnabled = True
        Me.TxtDOCDEPT.ItemHeight = 23
        Me.TxtDOCDEPT.Items.AddRange(New Object() {"AC", "BU", "DC", "EN", "GA", "HR", "IT", "IV", "LB", "MK", "MR", "PD", "PR", "QA", "QE", "RD", "SD", "SF", "WS"})
        Me.TxtDOCDEPT.Location = New System.Drawing.Point(125, 116)
        Me.TxtDOCDEPT.Name = "TxtDOCDEPT"
        Me.TxtDOCDEPT.Size = New System.Drawing.Size(167, 29)
        Me.TxtDOCDEPT.TabIndex = 4
        Me.TxtDOCDEPT.UseSelectable = True
        '
        'TxtLinkPdf
        '
        Me.TxtLinkPdf.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtLinkPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLinkPdf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLinkPdf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLinkPdf.Location = New System.Drawing.Point(125, 320)
        Me.TxtLinkPdf.Multiline = True
        Me.TxtLinkPdf.Name = "TxtLinkPdf"
        Me.TxtLinkPdf.ReadOnly = True
        Me.TxtLinkPdf.Size = New System.Drawing.Size(945, 29)
        Me.TxtLinkPdf.TabIndex = 8
        Me.TxtLinkPdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(8, 320)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(116, 29)
        Me.Panel5.TabIndex = 1338
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เอกสารของฝ่าย Dept"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntAddItem, Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton2})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1119, 47)
        Me.ToolStrip3.TabIndex = 1339
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'bntAddItem
        '
        Me.bntAddItem.ForeColor = System.Drawing.Color.White
        Me.bntAddItem.Image = CType(resources.GetObject("bntAddItem.Image"), System.Drawing.Image)
        Me.bntAddItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntAddItem.Name = "bntAddItem"
        Me.bntAddItem.Size = New System.Drawing.Size(100, 44)
        Me.bntAddItem.Text = "Add Item"
        Me.bntAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.DocumentSystem.My.Resources.Resources.Save_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(99, 44)
        Me.ToolStripButton1.Text = "SaveData"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = Global.DocumentSystem.My.Resources.Resources.delete_button_pngrepo_com2
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(101, 44)
        Me.ToolStripButton3.Text = "Delete All"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.DocumentSystem.My.Resources.Resources.delete_icon_image_15_jpg
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(127, 44)
        Me.ToolStripButton2.Text = "Change Status"
        '
        'TxtFind
        '
        '
        '
        '
        Me.TxtFind.CustomButton.Image = Nothing
        Me.TxtFind.CustomButton.Location = New System.Drawing.Point(-20, 2)
        Me.TxtFind.CustomButton.Name = ""
        Me.TxtFind.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtFind.CustomButton.TabIndex = 1
        Me.TxtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtFind.CustomButton.UseSelectable = True
        Me.TxtFind.CustomButton.Visible = False
        Me.TxtFind.Lines = New String(-1) {}
        Me.TxtFind.Location = New System.Drawing.Point(0, 0)
        Me.TxtFind.MaxLength = 32767
        Me.TxtFind.Name = "TxtFind"
        Me.TxtFind.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFind.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtFind.SelectedText = ""
        Me.TxtFind.SelectionLength = 0
        Me.TxtFind.SelectionStart = 0
        Me.TxtFind.ShortcutsEnabled = True
        Me.TxtFind.Size = New System.Drawing.Size(0, 22)
        Me.TxtFind.TabIndex = 1352
        Me.TxtFind.UseSelectable = True
        Me.TxtFind.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtFind.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtDOCTYPEFind
        '
        Me.TxtDOCTYPEFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCTYPEFind.FormattingEnabled = True
        Me.TxtDOCTYPEFind.ItemHeight = 23
        Me.TxtDOCTYPEFind.Location = New System.Drawing.Point(632, 9)
        Me.TxtDOCTYPEFind.Name = "TxtDOCTYPEFind"
        Me.TxtDOCTYPEFind.Size = New System.Drawing.Size(232, 29)
        Me.TxtDOCTYPEFind.TabIndex = 1340
        Me.TxtDOCTYPEFind.UseSelectable = True
        '
        'TxtFindData
        '
        Me.TxtFindData.BackColor = System.Drawing.Color.White
        Me.TxtFindData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFindData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFindData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindData.Location = New System.Drawing.Point(865, 9)
        Me.TxtFindData.Name = "TxtFindData"
        Me.TxtFindData.Size = New System.Drawing.Size(205, 29)
        Me.TxtFindData.TabIndex = 1351
        Me.TxtFindData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtStatus
        '
        Me.TxtStatus.BackColor = System.Drawing.SystemColors.Control
        Me.TxtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtStatus.Font = New System.Drawing.Font("BrowalliaUPC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStatus.ForeColor = System.Drawing.Color.Red
        Me.TxtStatus.Location = New System.Drawing.Point(672, 52)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(148, 25)
        Me.TxtStatus.TabIndex = 1353
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(515, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(116, 29)
        Me.Panel2.TabIndex = 1354
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ค้นหาเอกสารที่ต้องการ"
        '
        'txtSELECTSYSTEM
        '
        Me.txtSELECTSYSTEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSELECTSYSTEM.FormattingEnabled = True
        Me.txtSELECTSYSTEM.ItemHeight = 23
        Me.txtSELECTSYSTEM.Items.AddRange(New Object() {"", "Document System", "Department"})
        Me.txtSELECTSYSTEM.Location = New System.Drawing.Point(459, 51)
        Me.txtSELECTSYSTEM.Name = "txtSELECTSYSTEM"
        Me.txtSELECTSYSTEM.Size = New System.Drawing.Size(207, 29)
        Me.txtSELECTSYSTEM.TabIndex = 1356
        Me.txtSELECTSYSTEM.UseSelectable = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(375, 52)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(84, 28)
        Me.Panel6.TabIndex = 1355
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เลือกระบบ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkSelectALL
        '
        Me.chkSelectALL.AutoSize = True
        Me.chkSelectALL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSelectALL.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.chkSelectALL.Location = New System.Drawing.Point(999, 83)
        Me.chkSelectALL.Name = "chkSelectALL"
        Me.chkSelectALL.Size = New System.Drawing.Size(78, 17)
        Me.chkSelectALL.TabIndex = 1360
        Me.chkSelectALL.Text = "Select ALL"
        Me.chkSelectALL.UseVisualStyleBackColor = True
        Me.chkSelectALL.Visible = False
        '
        'dgvDataDept
        '
        Me.dgvDataDept.AllowUserToDeleteRows = False
        Me.dgvDataDept.AllowUserToResizeRows = False
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDataDept.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvDataDept.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDataDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDataDept.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDataDept.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataDept.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvDataDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataDept.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.DeptCod})
        Me.dgvDataDept.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataDept.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvDataDept.EnableHeadersVisualStyles = False
        Me.dgvDataDept.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDataDept.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDataDept.Location = New System.Drawing.Point(994, 102)
        Me.dgvDataDept.MultiSelect = False
        Me.dgvDataDept.Name = "dgvDataDept"
        Me.dgvDataDept.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataDept.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvDataDept.RowHeadersVisible = False
        Me.dgvDataDept.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDataDept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDataDept.Size = New System.Drawing.Size(117, 210)
        Me.dgvDataDept.Style = MetroFramework.MetroColorStyle.Blue
        Me.dgvDataDept.TabIndex = 1359
        Me.dgvDataDept.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgvDataDept.Visible = False
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel"
        Me.Sel.Name = "Sel"
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sel.Width = 25
        '
        'DeptCod
        '
        Me.DeptCod.HeaderText = "Dept"
        Me.DeptCod.Name = "DeptCod"
        Me.DeptCod.ReadOnly = True
        Me.DeptCod.Width = 60
        '
        'TXTDOCSHARE
        '
        Me.TXTDOCSHARE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TXTDOCSHARE.FormattingEnabled = True
        Me.TXTDOCSHARE.ItemHeight = 23
        Me.TXTDOCSHARE.Items.AddRange(New Object() {"TP", "KB", "TP-KB"})
        Me.TXTDOCSHARE.Location = New System.Drawing.Point(1042, 50)
        Me.TXTDOCSHARE.Name = "TXTDOCSHARE"
        Me.TXTDOCSHARE.Size = New System.Drawing.Size(69, 29)
        Me.TXTDOCSHARE.TabIndex = 1358
        Me.TXTDOCSHARE.UseSelectable = True
        Me.TXTDOCSHARE.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(994, 50)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(47, 29)
        Me.Panel9.TabIndex = 1357
        Me.Panel9.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Share"
        '
        'TxtDateNow
        '
        Me.TxtDateNow.CustomFormat = "dd/MM/yyyy"
        Me.TxtDateNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtDateNow.Location = New System.Drawing.Point(956, 148)
        Me.TxtDateNow.MinimumSize = New System.Drawing.Size(4, 29)
        Me.TxtDateNow.Name = "TxtDateNow"
        Me.TxtDateNow.Size = New System.Drawing.Size(10, 29)
        Me.TxtDateNow.TabIndex = 1361
        '
        'TxtREASON
        '
        Me.TxtREASON.BackColor = System.Drawing.Color.White
        Me.TxtREASON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtREASON.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtREASON.Location = New System.Drawing.Point(125, 148)
        Me.TxtREASON.Multiline = True
        Me.TxtREASON.Name = "TxtREASON"
        Me.TxtREASON.Size = New System.Drawing.Size(863, 164)
        Me.TxtREASON.TabIndex = 7
        '
        'bntLinkPdf
        '
        Me.bntLinkPdf.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntLinkPdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntLinkPdf.Image = Global.DocumentSystem.My.Resources.Resources.press__Custom_
        Me.bntLinkPdf.Location = New System.Drawing.Point(1076, 318)
        Me.bntLinkPdf.Name = "bntLinkPdf"
        Me.bntLinkPdf.Size = New System.Drawing.Size(30, 30)
        Me.bntLinkPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntLinkPdf.TabIndex = 1349
        Me.bntLinkPdf.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.PictureBox1.Location = New System.Drawing.Point(1073, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1342
        Me.PictureBox1.TabStop = False
        '
        'FrmCourseMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 681)
        Me.Controls.Add(Me.chkSelectALL)
        Me.Controls.Add(Me.dgvDataDept)
        Me.Controls.Add(Me.TXTDOCSHARE)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.txtSELECTSYSTEM)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.TxtFindData)
        Me.Controls.Add(Me.bntLinkPdf)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtFind)
        Me.Controls.Add(Me.TxtDOCTYPEFind)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.TxtLinkPdf)
        Me.Controls.Add(Me.TxtDOCDEPT)
        Me.Controls.Add(Me.TxtREVNO)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TxtDOCTYPE)
        Me.Controls.Add(Me.Panel52)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.TxtREASON)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.TxtEFFDATE)
        Me.Controls.Add(Me.Panel51)
        Me.Controls.Add(Me.Panel53)
        Me.Controls.Add(Me.TxtDOCNO)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TxtDOCNAME)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.TxtDateNow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCourseMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCourseMaster"
        Me.Panel1.ResumeLayout(False)
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel53.ResumeLayout(False)
        Me.Panel53.PerformLayout()
        Me.Panel51.ResumeLayout(False)
        Me.Panel51.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel52.ResumeLayout(False)
        Me.Panel52.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvDataDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.bntLinkPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bntClose As PictureBox
    Friend WithEvents grdData As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEFFDATE As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel53 As Panel
    Friend WithEvents Label60 As Label
    Friend WithEvents Panel51 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDOCNAME As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDOCNO As TextBox
    Friend WithEvents Panel52 As Panel
    Friend WithEvents Label55 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDOCTYPE As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TxtREVNO As TextBox
    Friend WithEvents TxtDOCDEPT As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TxtLinkPdf As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntAddItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents TxtFind As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtDOCTYPEFind As MetroFramework.Controls.MetroComboBox
    Friend WithEvents bntLinkPdf As PictureBox
    Friend WithEvents TxtFindData As TextBox
    Friend WithEvents TxtStatus As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSELECTSYSTEM As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents chkSelectALL As CheckBox
    Friend WithEvents dgvDataDept As MetroFramework.Controls.MetroGrid
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents DeptCod As DataGridViewTextBoxColumn
    Friend WithEvents TXTDOCSHARE As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDateNow As MetroFramework.Controls.MetroDateTime
    Friend WithEvents TxtREASON As TextBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents DOCNAME As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents DOCDEPT As DataGridViewTextBoxColumn
    Friend WithEvents REVNO As DataGridViewTextBoxColumn
    Friend WithEvents EFFDATE As DataGridViewTextBoxColumn
    Friend WithEvents DOCTYPE As DataGridViewTextBoxColumn
    Friend WithEvents AttachFile As DataGridViewTextBoxColumn
    Friend WithEvents REASON As DataGridViewTextBoxColumn
    Friend WithEvents SELECTSYSTEM As DataGridViewTextBoxColumn
End Class
