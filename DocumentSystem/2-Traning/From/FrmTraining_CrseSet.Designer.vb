<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTraining_CrseSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraining_CrseSet))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bntFind = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.bntClose = New System.Windows.Forms.PictureBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.bntNew = New MetroFramework.Controls.MetroButton()
        Me.bntDelete = New MetroFramework.Controls.MetroButton()
        Me.bntSave = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCrseSetNam = New MetroFramework.Controls.MetroTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMain = New MetroFramework.Controls.MetroGrid()
        Me.TxtCrseSetNam1 = New System.Windows.Forms.TextBox()
        Me.TxtCrseSetCode = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntAddNew = New System.Windows.Forms.ToolStripButton()
        Me.bntSaveData = New System.Windows.Forms.ToolStripButton()
        Me.bntSelectData = New System.Windows.Forms.ToolStripButton()
        Me.bntDeleteData = New System.Windows.Forms.ToolStripButton()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrseNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetrainFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.MetroButton1)
        Me.Panel2.Controls.Add(Me.bntNew)
        Me.Panel2.Controls.Add(Me.bntDelete)
        Me.Panel2.Controls.Add(Me.bntSave)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(857, 51)
        Me.Panel2.TabIndex = 886
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.bntFind)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.MetroButton2)
        Me.Panel3.Controls.Add(Me.bntClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(857, 51)
        Me.Panel3.TabIndex = 887
        '
        'bntFind
        '
        Me.bntFind.BackColor = System.Drawing.Color.Orange
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon__Custom_4
        Me.bntFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntFind.Location = New System.Drawing.Point(622, 11)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(180, 31)
        Me.bntFind.TabIndex = 797
        Me.bntFind.Text = "คลิกปุ่มเพื่อค้นหา Course Set"
        Me.bntFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntFind.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(41, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 796
        Me.Label2.Text = "Course Set"
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.Report__Custom_1
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(9, 9)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(27, 30)
        Me.MetroButton2.TabIndex = 795
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        '
        'bntClose
        '
        Me.bntClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntClose.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg_hi
        Me.bntClose.Location = New System.Drawing.Point(817, 12)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(34, 29)
        Me.bntClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntClose.TabIndex = 385
        Me.bntClose.TabStop = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.Report__Custom_1
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(-63, 6)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(37, 38)
        Me.MetroButton1.TabIndex = 793
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        '
        'bntNew
        '
        Me.bntNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntNew.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.Plus_Folder_icon__Custom_
        Me.bntNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntNew.Location = New System.Drawing.Point(726, 6)
        Me.bntNew.Name = "bntNew"
        Me.bntNew.Size = New System.Drawing.Size(37, 38)
        Me.bntNew.TabIndex = 7
        Me.bntNew.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntNew.UseSelectable = True
        '
        'bntDelete
        '
        Me.bntDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntDelete.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.delete_button_pngrepo_com
        Me.bntDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntDelete.Location = New System.Drawing.Point(812, 6)
        Me.bntDelete.Name = "bntDelete"
        Me.bntDelete.Size = New System.Drawing.Size(37, 38)
        Me.bntDelete.TabIndex = 6
        Me.bntDelete.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntDelete.UseSelectable = True
        '
        'bntSave
        '
        Me.bntSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntSave.BackgroundImage = CType(resources.GetObject("bntSave.BackgroundImage"), System.Drawing.Image)
        Me.bntSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSave.Location = New System.Drawing.Point(769, 6)
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(37, 38)
        Me.bntSave.TabIndex = 5
        Me.bntSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntSave.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 511
        Me.Label5.Text = "Course Set"
        '
        'BackgroundWorker1
        '
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(269, 11)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(95, 29)
        Me.Panel4.TabIndex = 894
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Description"
        '
        'TxtCrseSetNam
        '
        '
        '
        '
        Me.TxtCrseSetNam.CustomButton.Image = Nothing
        Me.TxtCrseSetNam.CustomButton.Location = New System.Drawing.Point(-20, 2)
        Me.TxtCrseSetNam.CustomButton.Name = ""
        Me.TxtCrseSetNam.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtCrseSetNam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtCrseSetNam.CustomButton.TabIndex = 1
        Me.TxtCrseSetNam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtCrseSetNam.CustomButton.UseSelectable = True
        Me.TxtCrseSetNam.CustomButton.Visible = False
        Me.TxtCrseSetNam.Lines = New String(-1) {}
        Me.TxtCrseSetNam.Location = New System.Drawing.Point(0, 0)
        Me.TxtCrseSetNam.MaxLength = 32767
        Me.TxtCrseSetNam.Name = "TxtCrseSetNam"
        Me.TxtCrseSetNam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCrseSetNam.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCrseSetNam.SelectedText = ""
        Me.TxtCrseSetNam.SelectionLength = 0
        Me.TxtCrseSetNam.SelectionStart = 0
        Me.TxtCrseSetNam.ShortcutsEnabled = True
        Me.TxtCrseSetNam.Size = New System.Drawing.Size(0, 22)
        Me.TxtCrseSetNam.TabIndex = 1375
        Me.TxtCrseSetNam.UseSelectable = True
        Me.TxtCrseSetNam.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtCrseSetNam.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(8, 11)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(95, 29)
        Me.Panel5.TabIndex = 893
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Set"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.CrseCode, Me.CrseNam, Me.DeptCod, Me.RetrainFreq})
        Me.dgvMain.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.EnableHeadersVisualStyles = False
        Me.dgvMain.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvMain.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(857, 483)
        Me.dgvMain.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvMain.TabIndex = 876
        Me.dgvMain.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'TxtCrseSetNam1
        '
        Me.TxtCrseSetNam1.BackColor = System.Drawing.Color.White
        Me.TxtCrseSetNam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCrseSetNam1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCrseSetNam1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCrseSetNam1.Location = New System.Drawing.Point(365, 11)
        Me.TxtCrseSetNam1.Name = "TxtCrseSetNam1"
        Me.TxtCrseSetNam1.Size = New System.Drawing.Size(480, 29)
        Me.TxtCrseSetNam1.TabIndex = 1351
        '
        'TxtCrseSetCode
        '
        Me.TxtCrseSetCode.BackColor = System.Drawing.Color.White
        Me.TxtCrseSetCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCrseSetCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCrseSetCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCrseSetCode.Location = New System.Drawing.Point(104, 11)
        Me.TxtCrseSetCode.Name = "TxtCrseSetCode"
        Me.TxtCrseSetCode.ReadOnly = True
        Me.TxtCrseSetCode.Size = New System.Drawing.Size(161, 29)
        Me.TxtCrseSetCode.TabIndex = 1353
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.TxtCrseSetNam1)
        Me.Panel6.Controls.Add(Me.TxtCrseSetCode)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 51)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(857, 51)
        Me.Panel6.TabIndex = 1372
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.dgvMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 483)
        Me.Panel1.TabIndex = 1373
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntAddNew, Me.bntSaveData, Me.bntSelectData, Me.bntDeleteData})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 585)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(857, 47)
        Me.ToolStrip3.TabIndex = 1374
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'bntAddNew
        '
        Me.bntAddNew.ForeColor = System.Drawing.Color.White
        Me.bntAddNew.Image = CType(resources.GetObject("bntAddNew.Image"), System.Drawing.Image)
        Me.bntAddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntAddNew.Name = "bntAddNew"
        Me.bntAddNew.Size = New System.Drawing.Size(135, 44)
        Me.bntAddNew.Text = "Add Course Set "
        Me.bntAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bntSaveData
        '
        Me.bntSaveData.ForeColor = System.Drawing.Color.White
        Me.bntSaveData.Image = Global.DocumentSystem.My.Resources.Resources.Save_icon3
        Me.bntSaveData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntSaveData.Name = "bntSaveData"
        Me.bntSaveData.Size = New System.Drawing.Size(134, 44)
        Me.bntSaveData.Text = "Save Course Set"
        '
        'bntSelectData
        '
        Me.bntSelectData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bntSelectData.ForeColor = System.Drawing.Color.White
        Me.bntSelectData.Image = Global.DocumentSystem.My.Resources.Resources.new_database_5123
        Me.bntSelectData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntSelectData.Name = "bntSelectData"
        Me.bntSelectData.Size = New System.Drawing.Size(122, 44)
        Me.bntSelectData.Text = "Select Course"
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
        'BackgroundWorker2
        '
        '
        'No
        '
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 30
        '
        'CrseCode
        '
        Me.CrseCode.HeaderText = "Course No."
        Me.CrseCode.Name = "CrseCode"
        Me.CrseCode.ReadOnly = True
        Me.CrseCode.Width = 150
        '
        'CrseNam
        '
        Me.CrseNam.HeaderText = "Description"
        Me.CrseNam.Name = "CrseNam"
        Me.CrseNam.ReadOnly = True
        Me.CrseNam.Width = 500
        '
        'DeptCod
        '
        Me.DeptCod.HeaderText = "DeptCod"
        Me.DeptCod.Name = "DeptCod"
        Me.DeptCod.ReadOnly = True
        Me.DeptCod.Visible = False
        '
        'RetrainFreq
        '
        Me.RetrainFreq.HeaderText = "Retraing Frequency"
        Me.RetrainFreq.Name = "RetrainFreq"
        Me.RetrainFreq.ReadOnly = True
        Me.RetrainFreq.Width = 140
        '
        'FrmTraining_CrseSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 632)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtCrseSetNam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_CrseSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTraining_CrseSet"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents bntNew As MetroFramework.Controls.MetroButton
    Friend WithEvents bntDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents bntSave As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents bntClose As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCrseSetNam As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvMain As MetroFramework.Controls.MetroGrid
    Friend WithEvents TxtCrseSetNam1 As TextBox
    Friend WithEvents TxtCrseSetCode As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntAddNew As ToolStripButton
    Friend WithEvents bntSaveData As ToolStripButton
    Friend WithEvents bntDeleteData As ToolStripButton
    Friend WithEvents bntSelectData As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents bntFind As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents CrseCode As DataGridViewTextBoxColumn
    Friend WithEvents CrseNam As DataGridViewTextBoxColumn
    Friend WithEvents DeptCod As DataGridViewTextBoxColumn
    Friend WithEvents RetrainFreq As DataGridViewTextBoxColumn
End Class
