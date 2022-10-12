<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraining_History_Check_Edit
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim CNRBGNBRLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraining_History_Check_Edit))
        Me.TxtTrnnDate = New MetroFramework.Controls.MetroDateTime()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRemark = New System.Windows.Forms.TextBox()
        Me.TxtResult = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSelectALL = New System.Windows.Forms.CheckBox()
        Me.dgvDetail = New MetroFramework.Controls.MetroGrid()
        Me.bntChangeStartDate = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TxtApprove = New System.Windows.Forms.TextBox()
        Me.TxtDOCDEPT = New System.Windows.Forms.TextBox()
        Me.Panel52 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtEFFDATE = New System.Windows.Forms.Label()
        Me.TxtREVNO = New System.Windows.Forms.Label()
        Me.TxtDOCNAME = New System.Windows.Forms.Label()
        Me.TxtDOCNO = New System.Windows.Forms.Label()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.TxtRetrainFreq = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.bntSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        CNRBGNBRLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel11.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel52.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_Head.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
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
        'CNRBGNBRLabel
        '
        CNRBGNBRLabel.AutoSize = True
        CNRBGNBRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        CNRBGNBRLabel.Location = New System.Drawing.Point(12, 15)
        CNRBGNBRLabel.Name = "CNRBGNBRLabel"
        CNRBGNBRLabel.Size = New System.Drawing.Size(120, 16)
        CNRBGNBRLabel.TabIndex = 1399
        CNRBGNBRLabel.Text = "เอกสารเลขที่ Doc.No :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label3.Location = New System.Drawing.Point(81, 38)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(51, 16)
        Label3.TabIndex = 1401
        Label3.Text = "ชื่อเรื่อง  :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label5.Location = New System.Drawing.Point(307, 15)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(88, 16)
        Label5.TabIndex = 1403
        Label5.Text = "Revision No :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(496, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(99, 16)
        Label1.TabIndex = 1405
        Label1.Text = "Revision Date :"
        '
        'TxtTrnnDate
        '
        Me.TxtTrnnDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtTrnnDate.CustomFormat = "dd/MM/yyyy"
        Me.TxtTrnnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtTrnnDate.Location = New System.Drawing.Point(121, 3)
        Me.TxtTrnnDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtTrnnDate.Name = "TxtTrnnDate"
        Me.TxtTrnnDate.Size = New System.Drawing.Size(115, 29)
        Me.TxtTrnnDate.TabIndex = 1384
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Start Date"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Location = New System.Drawing.Point(264, 62)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(110, 25)
        Me.Panel11.TabIndex = 1387
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Remark"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Approve"
        '
        'TxtRemark
        '
        Me.TxtRemark.BackColor = System.Drawing.Color.White
        Me.TxtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRemark.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemark.Location = New System.Drawing.Point(375, 62)
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(289, 25)
        Me.TxtRemark.TabIndex = 2
        '
        'TxtResult
        '
        Me.TxtResult.AutoSize = True
        Me.TxtResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtResult.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TxtResult.Location = New System.Drawing.Point(122, 39)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(103, 17)
        Me.TxtResult.TabIndex = 1369
        Me.TxtResult.Text = "Pass / Not Pass"
        Me.TxtResult.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.chkSelectALL)
        Me.Panel3.Controls.Add(Me.dgvDetail)
        Me.Panel3.Controls.Add(Me.bntChangeStartDate)
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.TxtRemark)
        Me.Panel3.Controls.Add(Me.TxtTrnnDate)
        Me.Panel3.Controls.Add(Me.TxtResult)
        Me.Panel3.Controls.Add(Me.Panel12)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.TxtApprove)
        Me.Panel3.Location = New System.Drawing.Point(12, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(667, 391)
        Me.Panel3.TabIndex = 1394
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(9, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 24)
        Me.Panel1.TabIndex = 1398
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Result"
        '
        'chkSelectALL
        '
        Me.chkSelectALL.AutoSize = True
        Me.chkSelectALL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSelectALL.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.chkSelectALL.Location = New System.Drawing.Point(17, 92)
        Me.chkSelectALL.Name = "chkSelectALL"
        Me.chkSelectALL.Size = New System.Drawing.Size(70, 17)
        Me.chkSelectALL.TabIndex = 1397
        Me.chkSelectALL.Text = "Select All"
        Me.chkSelectALL.UseVisualStyleBackColor = True
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
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.EmployeeNo, Me.EmployeeName, Me.StartDate})
        Me.dgvDetail.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetail.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetail.EnableHeadersVisualStyles = False
        Me.dgvDetail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.Location = New System.Drawing.Point(9, 114)
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
        Me.dgvDetail.Size = New System.Drawing.Size(655, 274)
        Me.dgvDetail.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvDetail.TabIndex = 1396
        Me.dgvDetail.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'bntChangeStartDate
        '
        Me.bntChangeStartDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bntChangeStartDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntChangeStartDate.FlatAppearance.BorderSize = 0
        Me.bntChangeStartDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.bntChangeStartDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.bntChangeStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntChangeStartDate.ForeColor = System.Drawing.Color.White
        Me.bntChangeStartDate.Image = Global.DocumentSystem.My.Resources.Resources.fsvxlzqocyhmrblzvehl__Custom_
        Me.bntChangeStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntChangeStartDate.Location = New System.Drawing.Point(239, 4)
        Me.bntChangeStartDate.Name = "bntChangeStartDate"
        Me.bntChangeStartDate.Size = New System.Drawing.Size(196, 27)
        Me.bntChangeStartDate.TabIndex = 1388
        Me.bntChangeStartDate.Text = "            เปลี่ยนแปลงวันที่ = วันบังคับใช้"
        Me.bntChangeStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntChangeStartDate.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel12.Controls.Add(Me.Label9)
        Me.Panel12.Location = New System.Drawing.Point(9, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(111, 28)
        Me.Panel12.TabIndex = 1385
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Location = New System.Drawing.Point(9, 61)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(110, 25)
        Me.Panel9.TabIndex = 1368
        '
        'TxtApprove
        '
        Me.TxtApprove.BackColor = System.Drawing.Color.White
        Me.TxtApprove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApprove.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApprove.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApprove.Location = New System.Drawing.Point(120, 61)
        Me.TxtApprove.Name = "TxtApprove"
        Me.TxtApprove.Size = New System.Drawing.Size(141, 25)
        Me.TxtApprove.TabIndex = 1
        '
        'TxtDOCDEPT
        '
        Me.TxtDOCDEPT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDOCDEPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDOCDEPT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOCDEPT.Location = New System.Drawing.Point(475, 7)
        Me.TxtDOCDEPT.Multiline = True
        Me.TxtDOCDEPT.Name = "TxtDOCDEPT"
        Me.TxtDOCDEPT.ReadOnly = True
        Me.TxtDOCDEPT.Size = New System.Drawing.Size(22, 29)
        Me.TxtDOCDEPT.TabIndex = 1376
        Me.TxtDOCDEPT.Visible = False
        '
        'Panel52
        '
        Me.Panel52.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel52.Controls.Add(Me.Label14)
        Me.Panel52.Controls.Add(Me.Label55)
        Me.Panel52.Location = New System.Drawing.Point(463, 7)
        Me.Panel52.Name = "Panel52"
        Me.Panel52.Size = New System.Drawing.Size(11, 29)
        Me.Panel52.TabIndex = 1375
        Me.Panel52.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "เอกสารของฝ่าย Dept"
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
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.TxtEFFDATE)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Me.TxtREVNO)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.TxtDOCNAME)
        Me.Panel2.Controls.Add(CNRBGNBRLabel)
        Me.Panel2.Controls.Add(Me.TxtDOCNO)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 70)
        Me.Panel2.TabIndex = 1402
        '
        'TxtEFFDATE
        '
        Me.TxtEFFDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtEFFDATE.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtEFFDATE.Location = New System.Drawing.Point(592, 15)
        Me.TxtEFFDATE.Name = "TxtEFFDATE"
        Me.TxtEFFDATE.Size = New System.Drawing.Size(93, 23)
        Me.TxtEFFDATE.TabIndex = 1406
        Me.TxtEFFDATE.Text = "--"
        '
        'TxtREVNO
        '
        Me.TxtREVNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtREVNO.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtREVNO.Location = New System.Drawing.Point(403, 15)
        Me.TxtREVNO.Name = "TxtREVNO"
        Me.TxtREVNO.Size = New System.Drawing.Size(58, 23)
        Me.TxtREVNO.TabIndex = 1404
        Me.TxtREVNO.Text = "--"
        '
        'TxtDOCNAME
        '
        Me.TxtDOCNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtDOCNAME.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtDOCNAME.Location = New System.Drawing.Point(138, 38)
        Me.TxtDOCNAME.Name = "TxtDOCNAME"
        Me.TxtDOCNAME.Size = New System.Drawing.Size(528, 23)
        Me.TxtDOCNAME.TabIndex = 1402
        Me.TxtDOCNAME.Text = "--"
        '
        'TxtDOCNO
        '
        Me.TxtDOCNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtDOCNO.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtDOCNO.Location = New System.Drawing.Point(138, 15)
        Me.TxtDOCNO.Name = "TxtDOCNO"
        Me.TxtDOCNO.Size = New System.Drawing.Size(135, 23)
        Me.TxtDOCNO.TabIndex = 1400
        Me.TxtDOCNO.Text = "--"
        '
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(Me.TxtRetrainFreq)
        Me.Panel_Head.Controls.Add(Me.Panel4)
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(Me.TxtDOCDEPT)
        Me.Panel_Head.Controls.Add(Me.Label11)
        Me.Panel_Head.Controls.Add(Me.Panel52)
        Me.Panel_Head.Controls.Add(Me.PictureBox3)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(688, 43)
        Me.Panel_Head.TabIndex = 1401
        '
        'TxtRetrainFreq
        '
        Me.TxtRetrainFreq.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtRetrainFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRetrainFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRetrainFreq.ForeColor = System.Drawing.Color.Red
        Me.TxtRetrainFreq.Location = New System.Drawing.Point(576, 7)
        Me.TxtRetrainFreq.Name = "TxtRetrainFreq"
        Me.TxtRetrainFreq.ReadOnly = True
        Me.TxtRetrainFreq.Size = New System.Drawing.Size(57, 29)
        Me.TxtRetrainFreq.TabIndex = 1391
        Me.TxtRetrainFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(449, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(126, 29)
        Me.Panel4.TabIndex = 1390
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 15)
        Me.Label7.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Retraing Frequency"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(52, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Check Revision Not Update"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(636, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.AutoScroll = True
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 113)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(688, 401)
        Me.Panel7.TabIndex = 1403
        '
        'bntSave
        '
        Me.bntSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bntSave.ForeColor = System.Drawing.Color.White
        Me.bntSave.Image = Global.DocumentSystem.My.Resources.Resources.Save_icon
        Me.bntSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(99, 44)
        Me.bntSave.Text = "SaveData"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntSave})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 514)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(688, 47)
        Me.ToolStrip3.TabIndex = 1404
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel"
        Me.Sel.Name = "Sel"
        Me.Sel.Width = 30
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
        Me.EmployeeName.Width = 500
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "StartDate"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ReadOnly = True
        '
        'FrmTraining_History_Check_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 563)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_History_Check_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTraining_History_Check_Edit"
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel52.ResumeLayout(False)
        Me.Panel52.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTrnnDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label9 As Label
    Friend WithEvents bntChangeStartDate As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRemark As TextBox
    Friend WithEvents TxtResult As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TxtApprove As TextBox
    Friend WithEvents TxtDOCDEPT As TextBox
    Friend WithEvents Panel52 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgvDetail As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel7 As Panel
    Friend WithEvents bntSave As ToolStripButton
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents TxtREVNO As Label
    Friend WithEvents TxtDOCNAME As Label
    Friend WithEvents TxtDOCNO As Label
    Friend WithEvents TxtEFFDATE As Label
    Friend WithEvents chkSelectALL As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRetrainFreq As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents EmployeeNo As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
End Class
