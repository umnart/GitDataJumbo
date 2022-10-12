<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMasterLIst
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterLIst))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.Vrifdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextVerifiDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QeChief = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QeChiefName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QeChiefDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QeMgr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QeMgrName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QeMgrDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qmr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrifName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QmrName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MgrSign = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MgrSignName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MgrSigndate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.menuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.QmrDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Vrif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Line = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Advise = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpSys = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReqNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegNameT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegNameE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReplyNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QEReceiveCAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppQEReceiveCARName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppQEReceiveCARDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QEVerifyDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Verifica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.bntFind = New System.Windows.Forms.PictureBox()
        Me.TxtDOCTYPEFind = New MetroFramework.Controls.MetroComboBox()
        Me.TxtFind = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDOCDEPT = New MetroFramework.Controls.MetroComboBox()
        Me.Panel51 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBRANCHDATA = New MetroFramework.Controls.MetroComboBox()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvData = New MetroFramework.Controls.MetroGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        IDLabel = New System.Windows.Forms.Label()
        Me.MetroContextMenu1.SuspendLayout()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel51.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        'Vrifdate
        '
        Me.Vrifdate.HeaderText = "วันที่ทวนสอบ"
        Me.Vrifdate.Name = "Vrifdate"
        Me.Vrifdate.ReadOnly = True
        '
        'VerStatus
        '
        Me.VerStatus.HeaderText = "เหตุผล"
        Me.VerStatus.Name = "VerStatus"
        Me.VerStatus.ReadOnly = True
        '
        'NextVerifiDate
        '
        Me.NextVerifiDate.HeaderText = "วันที่ทวนสอบครั้งต่อไป"
        Me.NextVerifiDate.Name = "NextVerifiDate"
        Me.NextVerifiDate.ReadOnly = True
        '
        'QeChief
        '
        Me.QeChief.HeaderText = "ผลจาก QE chief"
        Me.QeChief.Name = "QeChief"
        Me.QeChief.ReadOnly = True
        '
        'QeChiefName
        '
        Me.QeChiefName.HeaderText = "ชื่อผู้ลงผล"
        Me.QeChiefName.Name = "QeChiefName"
        Me.QeChiefName.ReadOnly = True
        '
        'QeChiefDate
        '
        Me.QeChiefDate.HeaderText = "วันที่"
        Me.QeChiefDate.Name = "QeChiefDate"
        Me.QeChiefDate.ReadOnly = True
        '
        'QeMgr
        '
        Me.QeMgr.HeaderText = "ผลจาก QE Manager"
        Me.QeMgr.Name = "QeMgr"
        Me.QeMgr.ReadOnly = True
        '
        'QeMgrName
        '
        Me.QeMgrName.HeaderText = "ชื่อผู้ลงผล"
        Me.QeMgrName.Name = "QeMgrName"
        Me.QeMgrName.ReadOnly = True
        '
        'QeMgrDate
        '
        Me.QeMgrDate.HeaderText = "วันที่"
        Me.QeMgrDate.Name = "QeMgrDate"
        Me.QeMgrDate.ReadOnly = True
        '
        'Qmr
        '
        Me.Qmr.HeaderText = "ผลจาก MR"
        Me.Qmr.Name = "Qmr"
        Me.Qmr.ReadOnly = True
        '
        'VrifName
        '
        Me.VrifName.HeaderText = "ชื่อผู้ทวนสอบ"
        Me.VrifName.Name = "VrifName"
        Me.VrifName.ReadOnly = True
        '
        'QmrName
        '
        Me.QmrName.HeaderText = "ชื่อผู้ลงผล"
        Me.QmrName.Name = "QmrName"
        Me.QmrName.ReadOnly = True
        '
        'MgrSign
        '
        Me.MgrSign.HeaderText = "ผู้จัดการรับทราบ"
        Me.MgrSign.Name = "MgrSign"
        Me.MgrSign.ReadOnly = True
        '
        'MgrSignName
        '
        Me.MgrSignName.HeaderText = "ชื่อผู้ลงผล"
        Me.MgrSignName.Name = "MgrSignName"
        Me.MgrSignName.ReadOnly = True
        '
        'MgrSigndate
        '
        Me.MgrSigndate.HeaderText = "วันที่"
        Me.MgrSigndate.Name = "MgrSigndate"
        Me.MgrSigndate.ReadOnly = True
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDelete, Me.CopyItemToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(203, 76)
        '
        'menuDelete
        '
        Me.menuDelete.Image = CType(resources.GetObject("menuDelete.Image"), System.Drawing.Image)
        Me.menuDelete.Name = "menuDelete"
        Me.menuDelete.Size = New System.Drawing.Size(202, 36)
        Me.menuDelete.Text = "&Remove Data"
        '
        'CopyItemToolStripMenuItem
        '
        Me.CopyItemToolStripMenuItem.Image = CType(resources.GetObject("CopyItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyItemToolStripMenuItem.Name = "CopyItemToolStripMenuItem"
        Me.CopyItemToolStripMenuItem.Size = New System.Drawing.Size(202, 36)
        Me.CopyItemToolStripMenuItem.Text = "Update CourseMaster"
        '
        'QmrDate
        '
        Me.QmrDate.HeaderText = "วันที่"
        Me.QmrDate.Name = "QmrDate"
        Me.QmrDate.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Vrif
        '
        Me.Vrif.HeaderText = "ผลจาก ผู้ทวนสอบ"
        Me.Vrif.Name = "Vrif"
        Me.Vrif.ReadOnly = True
        Me.Vrif.Width = 120
        '
        'Line
        '
        Me.Line.HeaderText = "Line"
        Me.Line.Name = "Line"
        Me.Line.ReadOnly = True
        Me.Line.Visible = False
        Me.Line.Width = 40
        '
        'Advise
        '
        Me.Advise.HeaderText = "ข้อเสนอแนะ"
        Me.Advise.Name = "Advise"
        Me.Advise.ReadOnly = True
        Me.Advise.Width = 300
        '
        'GrpSys
        '
        Me.GrpSys.HeaderText = "System"
        Me.GrpSys.Name = "GrpSys"
        Me.GrpSys.ReadOnly = True
        Me.GrpSys.Width = 50
        '
        'ReqNo
        '
        Me.ReqNo.HeaderText = "ReqNo"
        Me.ReqNo.Name = "ReqNo"
        Me.ReqNo.ReadOnly = True
        '
        'RegNameT
        '
        Me.RegNameT.HeaderText = "RegNameT"
        Me.RegNameT.Name = "RegNameT"
        Me.RegNameT.ReadOnly = True
        Me.RegNameT.Width = 370
        '
        'RegNameE
        '
        Me.RegNameE.HeaderText = "RegNameE"
        Me.RegNameE.Name = "RegNameE"
        Me.RegNameE.ReadOnly = True
        Me.RegNameE.Width = 370
        '
        'ReplyNo
        '
        Me.ReplyNo.HeaderText = "No."
        Me.ReplyNo.Name = "ReplyNo"
        Me.ReplyNo.ReadOnly = True
        Me.ReplyNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ReplyNo.Width = 25
        '
        'QEReceiveCAR
        '
        Me.QEReceiveCAR.HeaderText = "Status2"
        Me.QEReceiveCAR.Name = "QEReceiveCAR"
        Me.QEReceiveCAR.ReadOnly = True
        Me.QEReceiveCAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.QEReceiveCAR.Width = 70
        '
        'AppQEReceiveCARName
        '
        Me.AppQEReceiveCARName.HeaderText = "ผู้รับ CAR"
        Me.AppQEReceiveCARName.Name = "AppQEReceiveCARName"
        Me.AppQEReceiveCARName.ReadOnly = True
        Me.AppQEReceiveCARName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'AppQEReceiveCARDate
        '
        Me.AppQEReceiveCARDate.HeaderText = "วันที่รับ CAR"
        Me.AppQEReceiveCARDate.Name = "AppQEReceiveCARDate"
        Me.AppQEReceiveCARDate.ReadOnly = True
        Me.AppQEReceiveCARDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'QEVerifyDate
        '
        Me.QEVerifyDate.HeaderText = "ทวนสอบครั้งที่1"
        Me.QEVerifyDate.Name = "QEVerifyDate"
        Me.QEVerifyDate.ReadOnly = True
        Me.QEVerifyDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.QEVerifyDate.Width = 110
        '
        'DetailData
        '
        Me.DetailData.HeaderText = "Detail"
        Me.DetailData.Name = "DetailData"
        Me.DetailData.ReadOnly = True
        Me.DetailData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DetailData.Width = 200
        '
        'LineData
        '
        Me.LineData.HeaderText = "No."
        Me.LineData.Name = "LineData"
        Me.LineData.ReadOnly = True
        Me.LineData.Width = 30
        '
        'Version
        '
        Me.Version.HeaderText = "Version"
        Me.Version.Name = "Version"
        Me.Version.ReadOnly = True
        Me.Version.Visible = False
        Me.Version.Width = 50
        '
        'Verifica
        '
        Me.Verifica.HeaderText = "ผลการทวนสอบ"
        Me.Verifica.Name = "Verifica"
        Me.Verifica.ReadOnly = True
        Me.Verifica.Width = 300
        '
        'bntFind
        '
        Me.bntFind.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntFind.Location = New System.Drawing.Point(1013, 8)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(34, 29)
        Me.bntFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntFind.TabIndex = 1344
        Me.bntFind.TabStop = False
        '
        'TxtDOCTYPEFind
        '
        Me.TxtDOCTYPEFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCTYPEFind.FormattingEnabled = True
        Me.TxtDOCTYPEFind.ItemHeight = 23
        Me.TxtDOCTYPEFind.Items.AddRange(New Object() {"MANUAL", "PROCEDURE", "WORK INSTRUCTION", "STANDARD DOCUMENT", "RECORD", "KM", "Organization Chart", "Job Description", "HACCP"})
        Me.TxtDOCTYPEFind.Location = New System.Drawing.Point(500, 8)
        Me.TxtDOCTYPEFind.Name = "TxtDOCTYPEFind"
        Me.TxtDOCTYPEFind.Size = New System.Drawing.Size(232, 29)
        Me.TxtDOCTYPEFind.TabIndex = 1343
        Me.TxtDOCTYPEFind.UseSelectable = True
        '
        'TxtFind
        '
        Me.TxtFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtFind.Location = New System.Drawing.Point(834, 8)
        Me.TxtFind.Name = "TxtFind"
        Me.TxtFind.Size = New System.Drawing.Size(173, 29)
        Me.TxtFind.TabIndex = 1347
        Me.TxtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.TxtDOCDEPT)
        Me.Panel2.Controls.Add(Me.Panel51)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.TxtBRANCHDATA)
        Me.Panel2.Controls.Add(Me.TxtDOCTYPEFind)
        Me.Panel2.Controls.Add(Me.bntFind)
        Me.Panel2.Controls.Add(Me.TxtFind)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1151, 45)
        Me.Panel2.TabIndex = 1402
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(738, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(95, 28)
        Me.Panel3.TabIndex = 1378
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Doc.NO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(402, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 28)
        Me.Panel1.TabIndex = 1377
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ประเภทเอกสาร"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDOCDEPT
        '
        Me.TxtDOCDEPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCDEPT.FormattingEnabled = True
        Me.TxtDOCDEPT.ItemHeight = 23
        Me.TxtDOCDEPT.Items.AddRange(New Object() {"", "AC", "BU", "DC", "EN", "GA", "HR", "IT", "IV", "LB", "MK", "MR", "PD", "PR", "QA", "RD", "SD", "SF", "WS"})
        Me.TxtDOCDEPT.Location = New System.Drawing.Point(338, 9)
        Me.TxtDOCDEPT.Name = "TxtDOCDEPT"
        Me.TxtDOCDEPT.Size = New System.Drawing.Size(57, 29)
        Me.TxtDOCDEPT.TabIndex = 1376
        Me.TxtDOCDEPT.UseSelectable = True
        '
        'Panel51
        '
        Me.Panel51.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel51.Controls.Add(Me.Label14)
        Me.Panel51.Location = New System.Drawing.Point(292, 9)
        Me.Panel51.Name = "Panel51"
        Me.Panel51.Size = New System.Drawing.Size(45, 29)
        Me.Panel51.TabIndex = 1375
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ฝ่าย"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(125, 9)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(95, 28)
        Me.Panel5.TabIndex = 1374
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เอกสาร สาขา"
        '
        'TxtBRANCHDATA
        '
        Me.TxtBRANCHDATA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtBRANCHDATA.FormattingEnabled = True
        Me.TxtBRANCHDATA.ItemHeight = 23
        Me.TxtBRANCHDATA.Items.AddRange(New Object() {"", "TP", "KB", "TP-KB"})
        Me.TxtBRANCHDATA.Location = New System.Drawing.Point(221, 9)
        Me.TxtBRANCHDATA.Name = "TxtBRANCHDATA"
        Me.TxtBRANCHDATA.Size = New System.Drawing.Size(64, 29)
        Me.TxtBRANCHDATA.TabIndex = 1348
        Me.TxtBRANCHDATA.UseSelectable = True
        '
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(Me.PictureBox1)
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(Me.Label5)
        Me.Panel_Head.Controls.Add(Me.PictureBox3)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(1151, 43)
        Me.Panel_Head.TabIndex = 1401
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.DocumentSystem.My.Resources.Resources._13014619901547782854minimizebutton_hi__Custom_
        Me.PictureBox1.Location = New System.Drawing.Point(1068, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
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
        Me.Label5.Size = New System.Drawing.Size(172, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Master List For Document"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg_hi
        Me.PictureBox3.Location = New System.Drawing.Point(1108, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1151, 36)
        Me.Panel8.TabIndex = 1403
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(521, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Status Update"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(375, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Related parties"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(531, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "สถานะปัจจุบัน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(807, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "การแก้ไขครั้งที่ / วันที่บังคับใช้"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(392, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ผู้ที่เกี่ยวข้อง "
        '
        'dgvData
        '
        Me.dgvData.AllowUserToResizeRows = False
        Me.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.EnableHeadersVisualStyles = False
        Me.dgvData.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvData.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvData.Location = New System.Drawing.Point(0, 0)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(1151, 526)
        Me.dgvData.TabIndex = 1231
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 88)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1151, 36)
        Me.Panel4.TabIndex = 1404
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvData)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 124)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1151, 526)
        Me.Panel6.TabIndex = 1405
        '
        'FrmMasterLIst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 650)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMasterLIst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master List For Document"
        Me.MetroContextMenu1.ResumeLayout(False)
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel51.ResumeLayout(False)
        Me.Panel51.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Vrifdate As DataGridViewTextBoxColumn
    Friend WithEvents VerStatus As DataGridViewTextBoxColumn
    Friend WithEvents NextVerifiDate As DataGridViewTextBoxColumn
    Friend WithEvents QeChief As DataGridViewTextBoxColumn
    Friend WithEvents QeChiefName As DataGridViewTextBoxColumn
    Friend WithEvents QeChiefDate As DataGridViewTextBoxColumn
    Friend WithEvents QeMgr As DataGridViewTextBoxColumn
    Friend WithEvents QeMgrName As DataGridViewTextBoxColumn
    Friend WithEvents QeMgrDate As DataGridViewTextBoxColumn
    Friend WithEvents Qmr As DataGridViewTextBoxColumn
    Friend WithEvents VrifName As DataGridViewTextBoxColumn
    Friend WithEvents QmrName As DataGridViewTextBoxColumn
    Friend WithEvents MgrSign As DataGridViewTextBoxColumn
    Friend WithEvents MgrSignName As DataGridViewTextBoxColumn
    Friend WithEvents MgrSigndate As DataGridViewTextBoxColumn
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents menuDelete As ToolStripMenuItem
    Friend WithEvents CopyItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents QmrDate As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Vrif As DataGridViewTextBoxColumn
    Friend WithEvents Line As DataGridViewTextBoxColumn
    Friend WithEvents Advise As DataGridViewTextBoxColumn
    Friend WithEvents GrpSys As DataGridViewTextBoxColumn
    Friend WithEvents ReqNo As DataGridViewTextBoxColumn
    Friend WithEvents RegNameT As DataGridViewTextBoxColumn
    Friend WithEvents RegNameE As DataGridViewTextBoxColumn
    Friend WithEvents ReplyNo As DataGridViewTextBoxColumn
    Friend WithEvents QEReceiveCAR As DataGridViewTextBoxColumn
    Friend WithEvents AppQEReceiveCARName As DataGridViewTextBoxColumn
    Friend WithEvents AppQEReceiveCARDate As DataGridViewTextBoxColumn
    Friend WithEvents QEVerifyDate As DataGridViewTextBoxColumn
    Friend WithEvents DetailData As DataGridViewTextBoxColumn
    Friend WithEvents LineData As DataGridViewTextBoxColumn
    Friend WithEvents Version As DataGridViewTextBoxColumn
    Friend WithEvents Verifica As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bntFind As PictureBox
    Friend WithEvents TxtDOCTYPEFind As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TxtFind As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TxtBRANCHDATA As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDOCDEPT As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel51 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvData As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
