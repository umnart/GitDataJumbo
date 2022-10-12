<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentSystem_Find
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentSystem_Find))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRefNoFM = New System.Windows.Forms.ComboBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.bntExcharte = New MetroFramework.Controls.MetroButton()
        Me.grdDataRows = New MetroFramework.Controls.MetroGrid()
        Me.NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DARNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REVNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCTYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PETITIONBRANCH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PETITIONDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QEOFFICERDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MGRAPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QEOFFICERAPPROVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QEMGRAPPROVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QEMRAPPROVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RRSNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFNODATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELECTSYSTEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtStatus = New MetroFramework.Controls.MetroComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDOCDEPT = New MetroFramework.Controls.MetroComboBox()
        Me.TxtYearData = New System.Windows.Forms.TextBox()
        Me.txtSELECTSYSTEM = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDOCNO = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRefNoTO = New System.Windows.Forms.ComboBox()
        Me.bntFind = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TxtBranch = New MetroFramework.Controls.MetroComboBox()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroContextMenu2 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.bntDS = New System.Windows.Forms.ToolStripMenuItem()
        Me.bntDP = New System.Windows.Forms.ToolStripMenuItem()
        Me.bntKM = New System.Windows.Forms.ToolStripMenuItem()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDataRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu2.SuspendLayout()
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
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Location = New System.Drawing.Point(684, 39)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(111, 28)
        Me.Panel7.TabIndex = 1115
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "เลที่เอกสาร"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Location = New System.Drawing.Point(410, 39)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(85, 28)
        Me.Panel8.TabIndex = 1117
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ฝ่ายที่รับผิดชอบ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRefNoFM
        '
        Me.TxtRefNoFM.BackColor = System.Drawing.Color.White
        Me.TxtRefNoFM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtRefNoFM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtRefNoFM.ForeColor = System.Drawing.Color.Black
        Me.TxtRefNoFM.FormattingEnabled = True
        Me.TxtRefNoFM.Location = New System.Drawing.Point(381, 5)
        Me.TxtRefNoFM.Name = "TxtRefNoFM"
        Me.TxtRefNoFM.Size = New System.Drawing.Size(184, 28)
        Me.TxtRefNoFM.TabIndex = 1126
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel11.Controls.Add(Me.Label12)
        Me.Panel11.Location = New System.Drawing.Point(297, 5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(84, 28)
        Me.Panel11.TabIndex = 1127
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "REF No. FM"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Desktop
        Me.ProgressBar1.Location = New System.Drawing.Point(924, 5)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Minimum = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(129, 23)
        Me.ProgressBar1.Step = 50
        Me.ProgressBar1.TabIndex = 848
        Me.ProgressBar1.Value = 10
        Me.ProgressBar1.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(797, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(80, 28)
        Me.Panel6.TabIndex = 1113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Year (YY)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackgroundWorker1
        '
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel19.Controls.Add(Me.ToolStrip1)
        Me.Panel19.Controls.Add(Me.MetroButton2)
        Me.Panel19.Controls.Add(Me.bntExcharte)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel19.Location = New System.Drawing.Point(0, 559)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1091, 63)
        Me.Panel19.TabIndex = 851
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1091, 47)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip_menu2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(100, 44)
        Me.ToolStripButton2.Text = "Add Item"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.DocumentSystem.My.Resources.Resources.email
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(109, 44)
        Me.ToolStripButton1.Text = "Send Email"
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(3, 84)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(37, 38)
        Me.MetroButton2.TabIndex = 10
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        '
        'bntExcharte
        '
        Me.bntExcharte.BackgroundImage = CType(resources.GetObject("bntExcharte.BackgroundImage"), System.Drawing.Image)
        Me.bntExcharte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntExcharte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntExcharte.Location = New System.Drawing.Point(46, 84)
        Me.bntExcharte.Name = "bntExcharte"
        Me.bntExcharte.Size = New System.Drawing.Size(37, 38)
        Me.bntExcharte.TabIndex = 8
        Me.bntExcharte.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntExcharte.UseSelectable = True
        '
        'grdDataRows
        '
        Me.grdDataRows.AllowUserToDeleteRows = False
        Me.grdDataRows.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdDataRows.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDataRows.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdDataRows.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDataRows.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdDataRows.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDataRows.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdDataRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataRows.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NO, Me.REFNO, Me.DARNO, Me.DOCNO, Me.REVNO, Me.DOCTYPE, Me.STATUS, Me.DOCDEPT, Me.PETITIONBRANCH, Me.PETITIONDATE, Me.QEOFFICERDATE, Me.EFFDATE, Me.MGRAPP, Me.QEOFFICERAPPROVE, Me.QEMGRAPPROVE, Me.QEMRAPPROVE, Me.RRSNO, Me.REFNODATA, Me.SELECTSYSTEM})
        Me.grdDataRows.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDataRows.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdDataRows.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdDataRows.EnableHeadersVisualStyles = False
        Me.grdDataRows.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdDataRows.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdDataRows.Location = New System.Drawing.Point(0, 106)
        Me.grdDataRows.Name = "grdDataRows"
        Me.grdDataRows.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDataRows.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdDataRows.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdDataRows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDataRows.Size = New System.Drawing.Size(1091, 450)
        Me.grdDataRows.TabIndex = 850
        Me.grdDataRows.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'NO
        '
        Me.NO.HeaderText = "No"
        Me.NO.Name = "NO"
        Me.NO.ReadOnly = True
        Me.NO.Width = 30
        '
        'REFNO
        '
        Me.REFNO.HeaderText = "เลขที่อ้างอิง"
        Me.REFNO.Name = "REFNO"
        Me.REFNO.ReadOnly = True
        '
        'DARNO
        '
        Me.DARNO.HeaderText = "DAR No."
        Me.DARNO.Name = "DARNO"
        Me.DARNO.ReadOnly = True
        Me.DARNO.Width = 80
        '
        'DOCNO
        '
        Me.DOCNO.HeaderText = "เลขที่เอกสาร"
        Me.DOCNO.Name = "DOCNO"
        Me.DOCNO.ReadOnly = True
        '
        'REVNO
        '
        Me.REVNO.HeaderText = "Rev.No"
        Me.REVNO.Name = "REVNO"
        Me.REVNO.ReadOnly = True
        Me.REVNO.Width = 60
        '
        'DOCTYPE
        '
        Me.DOCTYPE.HeaderText = "ประเภทการจัดการเอกสาร"
        Me.DOCTYPE.Name = "DOCTYPE"
        Me.DOCTYPE.ReadOnly = True
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "สถานะการจัดการเอกสาร"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        '
        'DOCDEPT
        '
        Me.DOCDEPT.HeaderText = "ฝ่ายที่ขอ"
        Me.DOCDEPT.Name = "DOCDEPT"
        Me.DOCDEPT.ReadOnly = True
        Me.DOCDEPT.Width = 70
        '
        'PETITIONBRANCH
        '
        Me.PETITIONBRANCH.HeaderText = "สาขา"
        Me.PETITIONBRANCH.Name = "PETITIONBRANCH"
        Me.PETITIONBRANCH.ReadOnly = True
        Me.PETITIONBRANCH.Width = 50
        '
        'PETITIONDATE
        '
        Me.PETITIONDATE.HeaderText = "วันที่ยื่นคำขอ"
        Me.PETITIONDATE.Name = "PETITIONDATE"
        Me.PETITIONDATE.ReadOnly = True
        Me.PETITIONDATE.Width = 90
        '
        'QEOFFICERDATE
        '
        Me.QEOFFICERDATE.HeaderText = "วันที่รับคำขอ"
        Me.QEOFFICERDATE.Name = "QEOFFICERDATE"
        Me.QEOFFICERDATE.ReadOnly = True
        Me.QEOFFICERDATE.Width = 90
        '
        'EFFDATE
        '
        Me.EFFDATE.HeaderText = "วันที่บังคับใช้"
        Me.EFFDATE.Name = "EFFDATE"
        Me.EFFDATE.ReadOnly = True
        '
        'MGRAPP
        '
        Me.MGRAPP.HeaderText = "Manager"
        Me.MGRAPP.Name = "MGRAPP"
        Me.MGRAPP.ReadOnly = True
        '
        'QEOFFICERAPPROVE
        '
        Me.QEOFFICERAPPROVE.HeaderText = "OE Office"
        Me.QEOFFICERAPPROVE.Name = "QEOFFICERAPPROVE"
        Me.QEOFFICERAPPROVE.ReadOnly = True
        '
        'QEMGRAPPROVE
        '
        Me.QEMGRAPPROVE.HeaderText = "QE Manager/QE Section Head"
        Me.QEMGRAPPROVE.Name = "QEMGRAPPROVE"
        Me.QEMGRAPPROVE.ReadOnly = True
        '
        'QEMRAPPROVE
        '
        Me.QEMRAPPROVE.HeaderText = "MR"
        Me.QEMRAPPROVE.Name = "QEMRAPPROVE"
        Me.QEMRAPPROVE.ReadOnly = True
        '
        'RRSNO
        '
        Me.RRSNO.HeaderText = "เลขที่รับ-คืนเอกสาร"
        Me.RRSNO.Name = "RRSNO"
        Me.RRSNO.ReadOnly = True
        '
        'REFNODATA
        '
        Me.REFNODATA.HeaderText = "RefNoData"
        Me.REFNODATA.Name = "REFNODATA"
        Me.REFNODATA.ReadOnly = True
        '
        'SELECTSYSTEM
        '
        Me.SELECTSYSTEM.HeaderText = "SELECTSYSTEM"
        Me.SELECTSYSTEM.Name = "SELECTSYSTEM"
        Me.SELECTSYSTEM.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.TxtStatus)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxtDOCDEPT)
        Me.Panel2.Controls.Add(Me.TxtYearData)
        Me.Panel2.Controls.Add(Me.txtSELECTSYSTEM)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.TxtDOCNO)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.TxtRefNoTO)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.TxtRefNoFM)
        Me.Panel2.Controls.Add(Me.bntFind)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.TxtBranch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 75)
        Me.Panel2.TabIndex = 849
        '
        'TxtStatus
        '
        Me.TxtStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtStatus.FormattingEnabled = True
        Me.TxtStatus.ItemHeight = 23
        Me.TxtStatus.Location = New System.Drawing.Point(87, 37)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(320, 29)
        Me.TxtStatus.TabIndex = 1420
        Me.TxtStatus.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(3, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(83, 29)
        Me.Panel3.TabIndex = 1419
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Status"
        '
        'TxtDOCDEPT
        '
        Me.TxtDOCDEPT.FormattingEnabled = True
        Me.TxtDOCDEPT.ItemHeight = 23
        Me.TxtDOCDEPT.Items.AddRange(New Object() {"", "AC", "BU", "EN", "HRGA", "GA", "HR", "IT", "IV", "LB", "MK", "PD", "PR", "QA", "RD", "SD", "SF", "WS"})
        Me.TxtDOCDEPT.Location = New System.Drawing.Point(495, 38)
        Me.TxtDOCDEPT.Name = "TxtDOCDEPT"
        Me.TxtDOCDEPT.Size = New System.Drawing.Size(183, 29)
        Me.TxtDOCDEPT.TabIndex = 1211
        Me.TxtDOCDEPT.UseSelectable = True
        '
        'TxtYearData
        '
        Me.TxtYearData.BackColor = System.Drawing.Color.White
        Me.TxtYearData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtYearData.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtYearData.Location = New System.Drawing.Point(877, 6)
        Me.TxtYearData.Multiline = True
        Me.TxtYearData.Name = "TxtYearData"
        Me.TxtYearData.Size = New System.Drawing.Size(83, 28)
        Me.TxtYearData.TabIndex = 1210
        Me.TxtYearData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSELECTSYSTEM
        '
        Me.txtSELECTSYSTEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSELECTSYSTEM.FormattingEnabled = True
        Me.txtSELECTSYSTEM.ItemHeight = 23
        Me.txtSELECTSYSTEM.Items.AddRange(New Object() {"Document System", "Department", "KM"})
        Me.txtSELECTSYSTEM.Location = New System.Drawing.Point(87, 5)
        Me.txtSELECTSYSTEM.Name = "txtSELECTSYSTEM"
        Me.txtSELECTSYSTEM.Size = New System.Drawing.Size(207, 29)
        Me.txtSELECTSYSTEM.TabIndex = 1209
        Me.txtSELECTSYSTEM.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 28)
        Me.Panel1.TabIndex = 1208
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เลือกระบบ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDOCNO
        '
        Me.TxtDOCNO.BackColor = System.Drawing.Color.White
        Me.TxtDOCNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDOCNO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOCNO.Location = New System.Drawing.Point(797, 38)
        Me.TxtDOCNO.Name = "TxtDOCNO"
        Me.TxtDOCNO.Size = New System.Drawing.Size(164, 29)
        Me.TxtDOCNO.TabIndex = 1206
        Me.TxtDOCNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(570, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(33, 28)
        Me.Panel4.TabIndex = 1130
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRefNoTO
        '
        Me.TxtRefNoTO.BackColor = System.Drawing.Color.White
        Me.TxtRefNoTO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtRefNoTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtRefNoTO.ForeColor = System.Drawing.Color.Black
        Me.TxtRefNoTO.FormattingEnabled = True
        Me.TxtRefNoTO.Location = New System.Drawing.Point(603, 5)
        Me.TxtRefNoTO.Name = "TxtRefNoTO"
        Me.TxtRefNoTO.Size = New System.Drawing.Size(188, 28)
        Me.TxtRefNoTO.TabIndex = 1129
        '
        'bntFind
        '
        Me.bntFind.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntFind.Location = New System.Drawing.Point(1019, 5)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(68, 63)
        Me.bntFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntFind.TabIndex = 1123
        Me.bntFind.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(966, 40)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 1102
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'TxtBranch
        '
        Me.TxtBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtBranch.FormattingEnabled = True
        Me.TxtBranch.ItemHeight = 23
        Me.TxtBranch.Items.AddRange(New Object() {"", "TP", "KB"})
        Me.TxtBranch.Location = New System.Drawing.Point(966, 6)
        Me.TxtBranch.Name = "TxtBranch"
        Me.TxtBranch.PromptText = "Branch"
        Me.TxtBranch.Size = New System.Drawing.Size(47, 29)
        Me.TxtBranch.TabIndex = 1101
        Me.TxtBranch.UseSelectable = True
        Me.TxtBranch.Visible = False
        '
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(Me.ProgressBar1)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox1)
        Me.Panel_Head.Controls.Add(Me.Label1)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(1091, 31)
        Me.Panel_Head.TabIndex = 848
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg_hi
        Me.PictureBox2.Location = New System.Drawing.Point(1059, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 842
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DocumentSystem.My.Resources.Resources._374_512__Custom___2_
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(33, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "การจัดการใบคำขอ"
        '
        'MetroContextMenu2
        '
        Me.MetroContextMenu2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MetroContextMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntDS, Me.bntDP, Me.bntKM})
        Me.MetroContextMenu2.Name = "MetroContextMenu1"
        Me.MetroContextMenu2.Size = New System.Drawing.Size(189, 112)
        '
        'bntDS
        '
        Me.bntDS.Image = Global.DocumentSystem.My.Resources.Resources.M_17
        Me.bntDS.Name = "bntDS"
        Me.bntDS.Size = New System.Drawing.Size(188, 36)
        Me.bntDS.Text = "&Document System "
        '
        'bntDP
        '
        Me.bntDP.Image = Global.DocumentSystem.My.Resources.Resources.M_k18
        Me.bntDP.Name = "bntDP"
        Me.bntDP.Size = New System.Drawing.Size(188, 36)
        Me.bntDP.Text = "&Department"
        '
        'bntKM
        '
        Me.bntKM.Image = Global.DocumentSystem.My.Resources.Resources.M_1
        Me.bntKM.Name = "bntKM"
        Me.bntKM.Size = New System.Drawing.Size(188, 36)
        Me.bntKM.Text = "&KM"
        '
        'FrmDocumentSystem_Find
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 622)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.grdDataRows)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDocumentSystem_Find"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDocumentSystem_Find"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDataRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtRefNoFM As ComboBox
    Friend WithEvents bntFind As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel19 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents bntExcharte As MetroFramework.Controls.MetroButton
    Friend WithEvents grdDataRows As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TxtBranch As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRefNoTO As ComboBox
    Friend WithEvents TxtDOCNO As TextBox
    Friend WithEvents MetroContextMenu2 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents bntDS As ToolStripMenuItem
    Friend WithEvents bntKM As ToolStripMenuItem
    Friend WithEvents bntDP As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSELECTSYSTEM As MetroFramework.Controls.MetroComboBox
    Friend WithEvents NO As DataGridViewTextBoxColumn
    Friend WithEvents REFNO As DataGridViewTextBoxColumn
    Friend WithEvents DARNO As DataGridViewTextBoxColumn
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents REVNO As DataGridViewTextBoxColumn
    Friend WithEvents DOCTYPE As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents DOCDEPT As DataGridViewTextBoxColumn
    Friend WithEvents PETITIONBRANCH As DataGridViewTextBoxColumn
    Friend WithEvents PETITIONDATE As DataGridViewTextBoxColumn
    Friend WithEvents QEOFFICERDATE As DataGridViewTextBoxColumn
    Friend WithEvents EFFDATE As DataGridViewTextBoxColumn
    Friend WithEvents MGRAPP As DataGridViewTextBoxColumn
    Friend WithEvents QEOFFICERAPPROVE As DataGridViewTextBoxColumn
    Friend WithEvents QEMGRAPPROVE As DataGridViewTextBoxColumn
    Friend WithEvents QEMRAPPROVE As DataGridViewTextBoxColumn
    Friend WithEvents RRSNO As DataGridViewTextBoxColumn
    Friend WithEvents REFNODATA As DataGridViewTextBoxColumn
    Friend WithEvents SELECTSYSTEM As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents TxtYearData As TextBox
    Friend WithEvents TxtDOCDEPT As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TxtStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
End Class
