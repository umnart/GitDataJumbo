<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserLogOn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserLogOn))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtFindData = New System.Windows.Forms.TextBox()
        Me.TxtFind = New MetroFramework.Controls.MetroTextBox()
        Me.cboBranch = New MetroFramework.Controls.MetroComboBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.bntNew = New MetroFramework.Controls.MetroButton()
        Me.bntDelete = New MetroFramework.Controls.MetroButton()
        Me.bntSave = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntSelectEm = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bntClose = New System.Windows.Forms.PictureBox()
        Me.TxtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEmployeeNo = New System.Windows.Forms.TextBox()
        Me.TxtApprove = New MetroFramework.Controls.MetroComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEmployeePass = New MetroFramework.Controls.MetroTextBox()
        Me.TxtDept = New MetroFramework.Controls.MetroComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdData = New MetroFramework.Controls.MetroGrid()
        Me.EmployeeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Branch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lavel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.z = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBranch = New MetroFramework.Controls.MetroComboBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New MetroFramework.Controls.MetroTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLevel = New MetroFramework.Controls.MetroComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmployeeName1 = New System.Windows.Forms.TextBox()
        Me.TxtEmployeePass1 = New System.Windows.Forms.TextBox()
        Me.TxtEmail1 = New System.Windows.Forms.TextBox()
        Me.bntTxtLinkFilePDF_Open = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bntSelectEm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.bntTxtLinkFilePDF_Open, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.bntTxtLinkFilePDF_Open)
        Me.Panel2.Controls.Add(Me.TxtFindData)
        Me.Panel2.Controls.Add(Me.TxtFind)
        Me.Panel2.Controls.Add(Me.cboBranch)
        Me.Panel2.Controls.Add(Me.MetroButton1)
        Me.Panel2.Controls.Add(Me.bntNew)
        Me.Panel2.Controls.Add(Me.bntDelete)
        Me.Panel2.Controls.Add(Me.bntSave)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(843, 51)
        Me.Panel2.TabIndex = 842
        '
        'TxtFindData
        '
        Me.TxtFindData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFindData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindData.Location = New System.Drawing.Point(306, 11)
        Me.TxtFindData.Name = "TxtFindData"
        Me.TxtFindData.Size = New System.Drawing.Size(260, 29)
        Me.TxtFindData.TabIndex = 871
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
        Me.TxtFind.TabIndex = 872
        Me.TxtFind.UseSelectable = True
        Me.TxtFind.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtFind.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboBranch
        '
        Me.cboBranch.FormattingEnabled = True
        Me.cboBranch.ItemHeight = 23
        Me.cboBranch.Items.AddRange(New Object() {"", "Employee No", "Employee Name", "Branch", "Dept", "Level"})
        Me.cboBranch.Location = New System.Drawing.Point(158, 11)
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(147, 29)
        Me.cboBranch.TabIndex = 847
        Me.cboBranch.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.canva_man_laptop_computer_technology_education_icon_vector_graphic_MAB7lHHOi10
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(7, 6)
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
        Me.bntNew.Location = New System.Drawing.Point(712, 6)
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
        Me.bntDelete.Location = New System.Drawing.Point(798, 6)
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
        Me.bntSave.Location = New System.Drawing.Point(755, 6)
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
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 511
        Me.Label5.Text = "User Logon"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bntSelectEm)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.bntClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(843, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(44, 517)
        Me.Panel1.TabIndex = 841
        '
        'bntSelectEm
        '
        Me.bntSelectEm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSelectEm.Image = Global.DocumentSystem.My.Resources.Resources.Login_Icon__Custom_1
        Me.bntSelectEm.Location = New System.Drawing.Point(7, 481)
        Me.bntSelectEm.Name = "bntSelectEm"
        Me.bntSelectEm.Size = New System.Drawing.Size(32, 29)
        Me.bntSelectEm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntSelectEm.TabIndex = 1225
        Me.bntSelectEm.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(5, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 841
        Me.PictureBox2.TabStop = False
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
        'TxtEmail
        '
        '
        '
        '
        Me.TxtEmail.CustomButton.Image = Nothing
        Me.TxtEmail.CustomButton.Location = New System.Drawing.Point(-20, 2)
        Me.TxtEmail.CustomButton.Name = ""
        Me.TxtEmail.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtEmail.CustomButton.TabIndex = 1
        Me.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtEmail.CustomButton.UseSelectable = True
        Me.TxtEmail.CustomButton.Visible = False
        Me.TxtEmail.Lines = New String(-1) {}
        Me.TxtEmail.Location = New System.Drawing.Point(0, 0)
        Me.TxtEmail.MaxLength = 32767
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.SelectionLength = 0
        Me.TxtEmail.SelectionStart = 0
        Me.TxtEmail.ShortcutsEnabled = True
        Me.TxtEmail.Size = New System.Drawing.Size(0, 22)
        Me.TxtEmail.TabIndex = 868
        Me.TxtEmail.UseSelectable = True
        Me.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Location = New System.Drawing.Point(7, 156)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(95, 29)
        Me.Panel8.TabIndex = 859
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Emp.Email"
        '
        'TxtEmployeeNo
        '
        Me.TxtEmployeeNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmployeeNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmployeeNo.Location = New System.Drawing.Point(102, 62)
        Me.TxtEmployeeNo.Name = "TxtEmployeeNo"
        Me.TxtEmployeeNo.Size = New System.Drawing.Size(86, 29)
        Me.TxtEmployeeNo.TabIndex = 845
        Me.TxtEmployeeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtApprove
        '
        Me.TxtApprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtApprove.FormattingEnabled = True
        Me.TxtApprove.ItemHeight = 23
        Me.TxtApprove.Items.AddRange(New Object() {"", "Assistant manager", "Manager", "SD Staff", "SD Chief", "Lead", "MR", "Supervisor", "SF Chief"})
        Me.TxtApprove.Location = New System.Drawing.Point(460, 155)
        Me.TxtApprove.Name = "TxtApprove"
        Me.TxtApprove.Size = New System.Drawing.Size(188, 29)
        Me.TxtApprove.TabIndex = 851
        Me.TxtApprove.UseSelectable = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(365, 155)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(95, 29)
        Me.Panel7.TabIndex = 858
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Approve"
        '
        'TxtEmployeePass
        '
        '
        '
        '
        Me.TxtEmployeePass.CustomButton.Image = Nothing
        Me.TxtEmployeePass.CustomButton.Location = New System.Drawing.Point(-20, 2)
        Me.TxtEmployeePass.CustomButton.Name = ""
        Me.TxtEmployeePass.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtEmployeePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtEmployeePass.CustomButton.TabIndex = 1
        Me.TxtEmployeePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtEmployeePass.CustomButton.UseSelectable = True
        Me.TxtEmployeePass.CustomButton.Visible = False
        Me.TxtEmployeePass.Lines = New String(-1) {}
        Me.TxtEmployeePass.Location = New System.Drawing.Point(0, 0)
        Me.TxtEmployeePass.MaxLength = 32767
        Me.TxtEmployeePass.Name = "TxtEmployeePass"
        Me.TxtEmployeePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmployeePass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtEmployeePass.SelectedText = ""
        Me.TxtEmployeePass.SelectionLength = 0
        Me.TxtEmployeePass.SelectionStart = 0
        Me.TxtEmployeePass.ShortcutsEnabled = True
        Me.TxtEmployeePass.Size = New System.Drawing.Size(0, 22)
        Me.TxtEmployeePass.TabIndex = 869
        Me.TxtEmployeePass.UseSelectable = True
        Me.TxtEmployeePass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtEmployeePass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtDept
        '
        Me.TxtDept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDept.FormattingEnabled = True
        Me.TxtDept.ItemHeight = 23
        Me.TxtDept.Items.AddRange(New Object() {"", "AC", "AD", "BU", "EN", "HRGA", "HR", "GA", "IT", "IV", "LB", "MK", "PD", "PR", "QA", "RD", "SD", "SF", "WS"})
        Me.TxtDept.Location = New System.Drawing.Point(460, 124)
        Me.TxtDept.Name = "TxtDept"
        Me.TxtDept.Size = New System.Drawing.Size(85, 29)
        Me.TxtDept.TabIndex = 850
        Me.TxtDept.UseSelectable = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(7, 62)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(95, 29)
        Me.Panel5.TabIndex = 854
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Emp.No"
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
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeNo, Me.EmployeeName, Me.EmployeePass, Me.Dept, Me.Branch, Me.Lavel, Me.Approve, Me.Email, Me.Sel, Me.z})
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
        Me.grdData.Location = New System.Drawing.Point(7, 191)
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
        Me.grdData.Size = New System.Drawing.Size(830, 319)
        Me.grdData.Style = MetroFramework.MetroColorStyle.Teal
        Me.grdData.TabIndex = 856
        Me.grdData.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'EmployeeNo
        '
        Me.EmployeeNo.HeaderText = "EmployeeNo"
        Me.EmployeeNo.Name = "EmployeeNo"
        Me.EmployeeNo.Width = 90
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "EmployeeName"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Width = 150
        '
        'EmployeePass
        '
        Me.EmployeePass.HeaderText = "Pass"
        Me.EmployeePass.Name = "EmployeePass"
        Me.EmployeePass.ReadOnly = True
        Me.EmployeePass.Visible = False
        Me.EmployeePass.Width = 80
        '
        'Dept
        '
        Me.Dept.HeaderText = "Dept"
        Me.Dept.Name = "Dept"
        Me.Dept.ReadOnly = True
        Me.Dept.Width = 50
        '
        'Branch
        '
        Me.Branch.HeaderText = "Branch"
        Me.Branch.Name = "Branch"
        Me.Branch.ReadOnly = True
        Me.Branch.Width = 50
        '
        'Lavel
        '
        Me.Lavel.HeaderText = "Level"
        Me.Lavel.Name = "Lavel"
        Me.Lavel.ReadOnly = True
        Me.Lavel.Width = 90
        '
        'Approve
        '
        Me.Approve.HeaderText = "Approve"
        Me.Approve.Name = "Approve"
        Me.Approve.ReadOnly = True
        Me.Approve.Width = 120
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 220
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel"
        Me.Sel.Name = "Sel"
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sel.Width = 50
        '
        'z
        '
        Me.z.HeaderText = "Column1"
        Me.z.Name = "z"
        Me.z.ReadOnly = True
        Me.z.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(7, 93)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(95, 29)
        Me.Panel4.TabIndex = 855
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Emp.Name"
        '
        'TxtBranch
        '
        Me.TxtBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtBranch.FormattingEnabled = True
        Me.TxtBranch.ItemHeight = 23
        Me.TxtBranch.Items.AddRange(New Object() {"", "TP", "KB", "TP-KB"})
        Me.TxtBranch.Location = New System.Drawing.Point(460, 93)
        Me.TxtBranch.Name = "TxtBranch"
        Me.TxtBranch.Size = New System.Drawing.Size(85, 29)
        Me.TxtBranch.TabIndex = 849
        Me.TxtBranch.UseSelectable = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel18.Controls.Add(Me.Label2)
        Me.Panel18.Location = New System.Drawing.Point(365, 93)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(95, 29)
        Me.Panel18.TabIndex = 852
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "สาขา"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(7, 124)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(95, 29)
        Me.Panel6.TabIndex = 857
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Emp.Pass"
        '
        'txtEmployeeName
        '
        '
        '
        '
        Me.txtEmployeeName.CustomButton.Image = Nothing
        Me.txtEmployeeName.CustomButton.Location = New System.Drawing.Point(-20, 2)
        Me.txtEmployeeName.CustomButton.Name = ""
        Me.txtEmployeeName.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmployeeName.CustomButton.TabIndex = 1
        Me.txtEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmployeeName.CustomButton.UseSelectable = True
        Me.txtEmployeeName.CustomButton.Visible = False
        Me.txtEmployeeName.Lines = New String(-1) {}
        Me.txtEmployeeName.Location = New System.Drawing.Point(0, 0)
        Me.txtEmployeeName.MaxLength = 32767
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmployeeName.SelectedText = ""
        Me.txtEmployeeName.SelectionLength = 0
        Me.txtEmployeeName.SelectionStart = 0
        Me.txtEmployeeName.ShortcutsEnabled = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(0, 22)
        Me.txtEmployeeName.TabIndex = 870
        Me.txtEmployeeName.UseSelectable = True
        Me.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmployeeName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(365, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(95, 29)
        Me.Panel3.TabIndex = 853
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ฝ่าย"
        '
        'TxtLevel
        '
        Me.TxtLevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtLevel.FormattingEnabled = True
        Me.TxtLevel.ItemHeight = 23
        Me.TxtLevel.Items.AddRange(New Object() {"", "Low", "Medium", "Hight", "Admin"})
        Me.TxtLevel.Location = New System.Drawing.Point(648, 93)
        Me.TxtLevel.Name = "TxtLevel"
        Me.TxtLevel.Size = New System.Drawing.Size(188, 29)
        Me.TxtLevel.TabIndex = 860
        Me.TxtLevel.UseSelectable = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(553, 93)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(95, 29)
        Me.Panel9.TabIndex = 861
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Level"
        '
        'txtEmployeeName1
        '
        Me.txtEmployeeName1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeName1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName1.Location = New System.Drawing.Point(102, 93)
        Me.txtEmployeeName1.Name = "txtEmployeeName1"
        Me.txtEmployeeName1.Size = New System.Drawing.Size(260, 29)
        Me.txtEmployeeName1.TabIndex = 865
        Me.txtEmployeeName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmployeePass1
        '
        Me.TxtEmployeePass1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmployeePass1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmployeePass1.Location = New System.Drawing.Point(102, 124)
        Me.TxtEmployeePass1.Name = "TxtEmployeePass1"
        Me.TxtEmployeePass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtEmployeePass1.Size = New System.Drawing.Size(260, 29)
        Me.TxtEmployeePass1.TabIndex = 866
        Me.TxtEmployeePass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmail1
        '
        Me.TxtEmail1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmail1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail1.Location = New System.Drawing.Point(102, 156)
        Me.TxtEmail1.Name = "TxtEmail1"
        Me.TxtEmail1.Size = New System.Drawing.Size(260, 29)
        Me.TxtEmail1.TabIndex = 867
        Me.TxtEmail1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bntTxtLinkFilePDF_Open
        '
        Me.bntTxtLinkFilePDF_Open.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntTxtLinkFilePDF_Open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntTxtLinkFilePDF_Open.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntTxtLinkFilePDF_Open.Location = New System.Drawing.Point(568, 11)
        Me.bntTxtLinkFilePDF_Open.Name = "bntTxtLinkFilePDF_Open"
        Me.bntTxtLinkFilePDF_Open.Size = New System.Drawing.Size(33, 29)
        Me.bntTxtLinkFilePDF_Open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntTxtLinkFilePDF_Open.TabIndex = 1413
        Me.bntTxtLinkFilePDF_Open.TabStop = False
        '
        'FrmUserLogOn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 517)
        Me.Controls.Add(Me.TxtEmail1)
        Me.Controls.Add(Me.TxtEmployeePass1)
        Me.Controls.Add(Me.txtEmployeeName1)
        Me.Controls.Add(Me.TxtLevel)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.TxtEmployeeNo)
        Me.Controls.Add(Me.TxtApprove)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TxtEmployeePass)
        Me.Controls.Add(Me.TxtDept)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TxtBranch)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUserLogOn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUserLogOn"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bntSelectEm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.bntTxtLinkFilePDF_Open, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtFind As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboBranch As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents bntNew As MetroFramework.Controls.MetroButton
    Friend WithEvents bntDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents bntSave As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents bntClose As PictureBox
    Friend WithEvents TxtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEmployeeNo As TextBox
    Friend WithEvents TxtApprove As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEmployeePass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtDept As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents grdData As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBranch As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmployeeName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents bntSelectEm As PictureBox
    Friend WithEvents TxtLevel As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents EmployeeNo As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePass As DataGridViewTextBoxColumn
    Friend WithEvents Dept As DataGridViewTextBoxColumn
    Friend WithEvents Branch As DataGridViewTextBoxColumn
    Friend WithEvents Lavel As DataGridViewTextBoxColumn
    Friend WithEvents Approve As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents z As DataGridViewTextBoxColumn
    Friend WithEvents txtEmployeeName1 As TextBox
    Friend WithEvents TxtEmployeePass1 As TextBox
    Friend WithEvents TxtEmail1 As TextBox
    Friend WithEvents TxtFindData As TextBox
    Friend WithEvents bntTxtLinkFilePDF_Open As PictureBox
End Class
