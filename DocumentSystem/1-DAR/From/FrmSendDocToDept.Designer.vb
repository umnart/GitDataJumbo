<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSendDocToDept
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSendDocToDept))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtFindData = New System.Windows.Forms.TextBox()
        Me.TxtFind = New MetroFramework.Controls.MetroTextBox()
        Me.cboBranch = New MetroFramework.Controls.MetroComboBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntClose = New System.Windows.Forms.PictureBox()
        Me.grdData = New MetroFramework.Controls.MetroGrid()
        Me.DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.language = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDeptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtypeData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopyNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocCtrl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDOCNO = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtlanguage = New MetroFramework.Controls.MetroComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCtypeData = New MetroFramework.Controls.MetroComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtToDept = New MetroFramework.Controls.MetroComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDocCtrl = New MetroFramework.Controls.MetroComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCopyNo = New System.Windows.Forms.TextBox()
        Me.TxtToDeptName = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntAddNew = New System.Windows.Forms.ToolStripButton()
        Me.bntSaveData = New System.Windows.Forms.ToolStripButton()
        Me.bntDeleteData = New System.Windows.Forms.ToolStripButton()
        Me.bntDelete = New MetroFramework.Controls.MetroButton()
        Me.bntNew = New MetroFramework.Controls.MetroButton()
        Me.bntSave = New MetroFramework.Controls.MetroButton()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.menuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 20)
        Me.Label5.TabIndex = 511
        Me.Label5.Text = "ตารางการแจกจ่ายเอกสาร"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.MetroButton2)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.TxtFindData)
        Me.Panel2.Controls.Add(Me.TxtFind)
        Me.Panel2.Controls.Add(Me.cboBranch)
        Me.Panel2.Controls.Add(Me.MetroButton1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 51)
        Me.Panel2.TabIndex = 875
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.search_icon1
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(667, 10)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(35, 34)
        Me.MetroButton2.TabIndex = 1354
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel11.Controls.Add(Me.Label10)
        Me.Panel11.Location = New System.Drawing.Point(333, 13)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(46, 29)
        Me.Panel11.TabIndex = 1161
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ค้นหา"
        '
        'TxtFindData
        '
        Me.TxtFindData.BackColor = System.Drawing.Color.White
        Me.TxtFindData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFindData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFindData.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindData.Location = New System.Drawing.Point(515, 11)
        Me.TxtFindData.Name = "TxtFindData"
        Me.TxtFindData.Size = New System.Drawing.Size(150, 33)
        Me.TxtFindData.TabIndex = 1352
        Me.TxtFindData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TxtFind.TabIndex = 1353
        Me.TxtFind.UseSelectable = True
        Me.TxtFind.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtFind.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboBranch
        '
        Me.cboBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboBranch.FormattingEnabled = True
        Me.cboBranch.ItemHeight = 23
        Me.cboBranch.Items.AddRange(New Object() {"", "เอกสารเลขที่", "ผู้รับเอกสาร"})
        Me.cboBranch.Location = New System.Drawing.Point(381, 13)
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(133, 29)
        Me.cboBranch.TabIndex = 1343
        Me.cboBranch.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.modify__report_png_image_14514__Custom_
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(7, 6)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(37, 38)
        Me.MetroButton1.TabIndex = 793
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bntClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(729, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(44, 660)
        Me.Panel1.TabIndex = 874
        '
        'bntClose
        '
        Me.bntClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntClose.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg_hi
        Me.bntClose.Location = New System.Drawing.Point(3, 6)
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DOCNO, Me.language, Me.ToDept, Me.ToDeptName, Me.CtypeData, Me.CopyNo, Me.DocCtrl})
        Me.grdData.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdData.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdData.Location = New System.Drawing.Point(7, 187)
        Me.grdData.MultiSelect = False
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdData.RowHeadersVisible = False
        Me.grdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(712, 408)
        Me.grdData.Style = MetroFramework.MetroColorStyle.Teal
        Me.grdData.TabIndex = 884
        Me.grdData.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'DOCNO
        '
        Me.DOCNO.HeaderText = "เลขที่เอกสาร"
        Me.DOCNO.Name = "DOCNO"
        Me.DOCNO.ReadOnly = True
        '
        'language
        '
        Me.language.HeaderText = "ภาษา"
        Me.language.Name = "language"
        Me.language.ReadOnly = True
        '
        'ToDept
        '
        Me.ToDept.HeaderText = "รหัสผู้รับเอกสาร"
        Me.ToDept.Name = "ToDept"
        Me.ToDept.ReadOnly = True
        '
        'ToDeptName
        '
        Me.ToDeptName.HeaderText = "ผู้รับเอกสาร"
        Me.ToDeptName.Name = "ToDeptName"
        Me.ToDeptName.ReadOnly = True
        '
        'CtypeData
        '
        Me.CtypeData.HeaderText = "ประเภทสำเนา"
        Me.CtypeData.Name = "CtypeData"
        Me.CtypeData.ReadOnly = True
        '
        'CopyNo
        '
        Me.CopyNo.HeaderText = "สำเนาลำดับที่"
        Me.CopyNo.Name = "CopyNo"
        Me.CopyNo.ReadOnly = True
        '
        'DocCtrl
        '
        Me.DocCtrl.HeaderText = "ประเภทเอกสาร"
        Me.DocCtrl.Name = "DocCtrl"
        Me.DocCtrl.ReadOnly = True
        '
        'TxtDOCNO
        '
        Me.TxtDOCNO.BackColor = System.Drawing.Color.White
        Me.TxtDOCNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDOCNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDOCNO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOCNO.Location = New System.Drawing.Point(124, 62)
        Me.TxtDOCNO.Name = "TxtDOCNO"
        Me.TxtDOCNO.Size = New System.Drawing.Size(130, 29)
        Me.TxtDOCNO.TabIndex = 1144
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(7, 62)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(116, 29)
        Me.Panel6.TabIndex = 1145
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
        'Txtlanguage
        '
        Me.Txtlanguage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtlanguage.FormattingEnabled = True
        Me.Txtlanguage.ItemHeight = 23
        Me.Txtlanguage.Items.AddRange(New Object() {"", "Thai", "Eng"})
        Me.Txtlanguage.Location = New System.Drawing.Point(124, 93)
        Me.Txtlanguage.Name = "Txtlanguage"
        Me.Txtlanguage.Size = New System.Drawing.Size(130, 29)
        Me.Txtlanguage.TabIndex = 1146
        Me.Txtlanguage.UseSelectable = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(7, 93)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(116, 29)
        Me.Panel4.TabIndex = 1147
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ภาษา"
        '
        'TxtCtypeData
        '
        Me.TxtCtypeData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtCtypeData.FormattingEnabled = True
        Me.TxtCtypeData.ItemHeight = 23
        Me.TxtCtypeData.Items.AddRange(New Object() {"", "Paper", "SERVER", "DVD", "CD", "ORIGINAL"})
        Me.TxtCtypeData.Location = New System.Drawing.Point(395, 62)
        Me.TxtCtypeData.Name = "TxtCtypeData"
        Me.TxtCtypeData.Size = New System.Drawing.Size(130, 29)
        Me.TxtCtypeData.TabIndex = 1148
        Me.TxtCtypeData.UseSelectable = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(278, 62)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(116, 29)
        Me.Panel5.TabIndex = 1149
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ประเภทสำเนา"
        '
        'TxtToDept
        '
        Me.TxtToDept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtToDept.FormattingEnabled = True
        Me.TxtToDept.ItemHeight = 23
        Me.TxtToDept.Items.AddRange(New Object() {"", "TP", "KB", "TP-KB"})
        Me.TxtToDept.Location = New System.Drawing.Point(124, 124)
        Me.TxtToDept.Name = "TxtToDept"
        Me.TxtToDept.Size = New System.Drawing.Size(130, 29)
        Me.TxtToDept.TabIndex = 1150
        Me.TxtToDept.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(7, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(116, 29)
        Me.Panel3.TabIndex = 1151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รหัสผู้รับเอกสาร"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Location = New System.Drawing.Point(278, 93)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(116, 29)
        Me.Panel7.TabIndex = 1153
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "สำเนาลำดับที่"
        '
        'TxtDocCtrl
        '
        Me.TxtDocCtrl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDocCtrl.FormattingEnabled = True
        Me.TxtDocCtrl.ItemHeight = 23
        Me.TxtDocCtrl.Items.AddRange(New Object() {"", "Y", "N"})
        Me.TxtDocCtrl.Location = New System.Drawing.Point(395, 124)
        Me.TxtDocCtrl.Name = "TxtDocCtrl"
        Me.TxtDocCtrl.Size = New System.Drawing.Size(130, 29)
        Me.TxtDocCtrl.TabIndex = 1154
        Me.TxtDocCtrl.UseSelectable = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Location = New System.Drawing.Point(278, 124)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(116, 29)
        Me.Panel8.TabIndex = 1155
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ประเภทเอกสาร"
        '
        'TxtCopyNo
        '
        Me.TxtCopyNo.BackColor = System.Drawing.Color.White
        Me.TxtCopyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCopyNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCopyNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCopyNo.Location = New System.Drawing.Point(395, 93)
        Me.TxtCopyNo.Name = "TxtCopyNo"
        Me.TxtCopyNo.Size = New System.Drawing.Size(130, 29)
        Me.TxtCopyNo.TabIndex = 1156
        '
        'TxtToDeptName
        '
        Me.TxtToDeptName.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtToDeptName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtToDeptName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtToDeptName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtToDeptName.Location = New System.Drawing.Point(124, 155)
        Me.TxtToDeptName.Name = "TxtToDeptName"
        Me.TxtToDeptName.ReadOnly = True
        Me.TxtToDeptName.Size = New System.Drawing.Size(130, 29)
        Me.TxtToDeptName.TabIndex = 1157
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Location = New System.Drawing.Point(7, 155)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(116, 29)
        Me.Panel9.TabIndex = 1158
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ชื่อผู้รับเอกสาร"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(308, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(217, 15)
        Me.Label9.TabIndex = 1159
        Me.Label9.Text = "( Y = เอกสารควบคุม , N=เอกสารไม่ควบคุม )"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.ToolStrip3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 612)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(729, 48)
        Me.Panel10.TabIndex = 1160
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntAddNew, Me.bntSaveData, Me.bntDeleteData})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(729, 47)
        Me.ToolStrip3.TabIndex = 15
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'bntAddNew
        '
        Me.bntAddNew.ForeColor = System.Drawing.Color.White
        Me.bntAddNew.Image = CType(resources.GetObject("bntAddNew.Image"), System.Drawing.Image)
        Me.bntAddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntAddNew.Name = "bntAddNew"
        Me.bntAddNew.Size = New System.Drawing.Size(73, 44)
        Me.bntAddNew.Text = "Add"
        Me.bntAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bntSaveData
        '
        Me.bntSaveData.ForeColor = System.Drawing.Color.White
        Me.bntSaveData.Image = Global.DocumentSystem.My.Resources.Resources.Save_icon16
        Me.bntSaveData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntSaveData.Name = "bntSaveData"
        Me.bntSaveData.Size = New System.Drawing.Size(77, 44)
        Me.bntSaveData.Text = "SAVE"
        '
        'bntDeleteData
        '
        Me.bntDeleteData.ForeColor = System.Drawing.Color.White
        Me.bntDeleteData.Image = Global.DocumentSystem.My.Resources.Resources.delete_icon_image_15_jpg
        Me.bntDeleteData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntDeleteData.Name = "bntDeleteData"
        Me.bntDeleteData.Size = New System.Drawing.Size(101, 44)
        Me.bntDeleteData.Text = "Delete All"
        Me.bntDeleteData.ToolTipText = "Delete ( ลบข้อมูลทั้งหมด )"
        '
        'bntDelete
        '
        Me.bntDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntDelete.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.delete_button_pngrepo_com
        Me.bntDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntDelete.Location = New System.Drawing.Point(686, 143)
        Me.bntDelete.Name = "bntDelete"
        Me.bntDelete.Size = New System.Drawing.Size(37, 38)
        Me.bntDelete.TabIndex = 6
        Me.bntDelete.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntDelete.UseSelectable = True
        Me.bntDelete.Visible = False
        '
        'bntNew
        '
        Me.bntNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntNew.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.Plus_Folder_icon__Custom_
        Me.bntNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntNew.Location = New System.Drawing.Point(686, 57)
        Me.bntNew.Name = "bntNew"
        Me.bntNew.Size = New System.Drawing.Size(37, 38)
        Me.bntNew.TabIndex = 7
        Me.bntNew.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntNew.UseSelectable = True
        Me.bntNew.Visible = False
        '
        'bntSave
        '
        Me.bntSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntSave.BackgroundImage = CType(resources.GetObject("bntSave.BackgroundImage"), System.Drawing.Image)
        Me.bntSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSave.Location = New System.Drawing.Point(686, 100)
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(37, 38)
        Me.bntSave.TabIndex = 5
        Me.bntSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntSave.UseSelectable = True
        Me.bntSave.Visible = False
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDelete})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(167, 62)
        '
        'menuDelete
        '
        Me.menuDelete.Image = CType(resources.GetObject("menuDelete.Image"), System.Drawing.Image)
        Me.menuDelete.Name = "menuDelete"
        Me.menuDelete.Size = New System.Drawing.Size(166, 36)
        Me.menuDelete.Text = "&Remove Data"
        '
        'FrmSendDocToDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 660)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtToDeptName)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.TxtCopyNo)
        Me.Controls.Add(Me.TxtDocCtrl)
        Me.Controls.Add(Me.bntDelete)
        Me.Controls.Add(Me.bntNew)
        Me.Controls.Add(Me.bntSave)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TxtToDept)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TxtCtypeData)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Txtlanguage)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TxtDOCNO)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSendDocToDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSendDocToDept"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents bntNew As MetroFramework.Controls.MetroButton
    Friend WithEvents bntSave As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents bntDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents bntClose As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grdData As MetroFramework.Controls.MetroGrid
    Friend WithEvents TxtDOCNO As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtlanguage As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCtypeData As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtToDept As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDocCtrl As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCopyNo As TextBox
    Friend WithEvents TxtFind As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboBranch As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents language As DataGridViewTextBoxColumn
    Friend WithEvents ToDept As DataGridViewTextBoxColumn
    Friend WithEvents ToDeptName As DataGridViewTextBoxColumn
    Friend WithEvents CtypeData As DataGridViewTextBoxColumn
    Friend WithEvents CopyNo As DataGridViewTextBoxColumn
    Friend WithEvents DocCtrl As DataGridViewTextBoxColumn
    Friend WithEvents TxtToDeptName As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtFindData As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntAddNew As ToolStripButton
    Friend WithEvents bntSaveData As ToolStripButton
    Friend WithEvents bntDeleteData As ToolStripButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents menuDelete As ToolStripMenuItem
End Class
