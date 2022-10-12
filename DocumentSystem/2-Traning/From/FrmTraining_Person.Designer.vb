<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTraining_Person
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraining_Person))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBranch = New MetroFramework.Controls.MetroComboBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLavel = New MetroFramework.Controls.MetroComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New MetroFramework.Controls.MetroTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFind = New MetroFramework.Controls.MetroTextBox()
        Me.cboBranch = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdData = New MetroFramework.Controls.MetroGrid()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Branch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lavel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEmployeeNo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtFindData = New System.Windows.Forms.TextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.bntNew = New MetroFramework.Controls.MetroButton()
        Me.bntDelete = New MetroFramework.Controls.MetroButton()
        Me.bntSave = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntSelectEm = New System.Windows.Forms.PictureBox()
        Me.bntClose = New System.Windows.Forms.PictureBox()
        Me.TxtStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMD = New MetroFramework.Controls.MetroComboBox()
        Me.TxtDept = New MetroFramework.Controls.MetroComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSection = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeName1 = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bntSelectEm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(210, 62)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(95, 29)
        Me.Panel4.TabIndex = 874
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
        Me.TxtBranch.Location = New System.Drawing.Point(102, 124)
        Me.TxtBranch.Name = "TxtBranch"
        Me.TxtBranch.Size = New System.Drawing.Size(96, 29)
        Me.TxtBranch.TabIndex = 868
        Me.TxtBranch.UseSelectable = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel18.Controls.Add(Me.Label2)
        Me.Panel18.Location = New System.Drawing.Point(7, 124)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(95, 29)
        Me.Panel18.TabIndex = 871
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Branch"
        '
        'TxtLavel
        '
        Me.TxtLavel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtLavel.FormattingEnabled = True
        Me.TxtLavel.ItemHeight = 23
        Me.TxtLavel.Items.AddRange(New Object() {"", "C 1", "C 2", "C 3", "C 4", "C 5", "C 6", "C 7", "C 8", "C 9", "C 10", "C 11", "C 12"})
        Me.TxtLavel.Location = New System.Drawing.Point(305, 93)
        Me.TxtLavel.Name = "TxtLavel"
        Me.TxtLavel.Size = New System.Drawing.Size(197, 29)
        Me.TxtLavel.TabIndex = 879
        Me.TxtLavel.UseSelectable = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(210, 93)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(95, 29)
        Me.Panel9.TabIndex = 880
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
        Me.txtEmployeeName.TabIndex = 889
        Me.txtEmployeeName.UseSelectable = True
        Me.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmployeeName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(7, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(95, 29)
        Me.Panel3.TabIndex = 872
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dept"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(505, 93)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(71, 29)
        Me.Panel7.TabIndex = 877
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
        Me.TxtFind.TabIndex = 873
        Me.TxtFind.UseSelectable = True
        Me.TxtFind.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtFind.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboBranch
        '
        Me.cboBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboBranch.FormattingEnabled = True
        Me.cboBranch.ItemHeight = 23
        Me.cboBranch.Items.AddRange(New Object() {"", "Employee No", "Employee Name", "Branch", "Dept", "Level"})
        Me.cboBranch.Location = New System.Drawing.Point(158, 11)
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(147, 29)
        Me.cboBranch.TabIndex = 847
        Me.cboBranch.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 511
        Me.Label5.Text = "รายชื่อพนักงาน"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(7, 62)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(95, 29)
        Me.Panel5.TabIndex = 873
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
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.EmployeeNo, Me.EmployeeName, Me.Dept, Me.Section, Me.Branch, Me.Lavel, Me.StartDate, Me.MD})
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
        Me.grdData.Location = New System.Drawing.Point(7, 159)
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
        Me.grdData.Size = New System.Drawing.Size(688, 351)
        Me.grdData.Style = MetroFramework.MetroColorStyle.Teal
        Me.grdData.TabIndex = 875
        Me.grdData.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'No
        '
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 30
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
        'Dept
        '
        Me.Dept.HeaderText = "Dept"
        Me.Dept.Name = "Dept"
        Me.Dept.ReadOnly = True
        Me.Dept.Width = 50
        '
        'Section
        '
        Me.Section.HeaderText = "แผนก"
        Me.Section.Name = "Section"
        Me.Section.ReadOnly = True
        Me.Section.Width = 60
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
        'StartDate
        '
        Me.StartDate.HeaderText = "StartDate"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ReadOnly = True
        '
        'MD
        '
        Me.MD.HeaderText = "MD"
        Me.MD.Name = "MD"
        Me.MD.ReadOnly = True
        Me.MD.Width = 50
        '
        'TxtEmployeeNo
        '
        Me.TxtEmployeeNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmployeeNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmployeeNo.Location = New System.Drawing.Point(102, 62)
        Me.TxtEmployeeNo.Name = "TxtEmployeeNo"
        Me.TxtEmployeeNo.Size = New System.Drawing.Size(96, 29)
        Me.TxtEmployeeNo.TabIndex = 864
        Me.TxtEmployeeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
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
        Me.Panel2.Size = New System.Drawing.Size(703, 51)
        Me.Panel2.TabIndex = 863
        '
        'TxtFindData
        '
        Me.TxtFindData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFindData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindData.Location = New System.Drawing.Point(306, 11)
        Me.TxtFindData.Name = "TxtFindData"
        Me.TxtFindData.Size = New System.Drawing.Size(260, 29)
        Me.TxtFindData.TabIndex = 872
        Me.TxtFindData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.canva_man_laptop_computer_technology_education_icon_vector_graphic_MAB7lHHOi10
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(-133, 6)
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
        Me.bntNew.Location = New System.Drawing.Point(572, 6)
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
        Me.bntDelete.Location = New System.Drawing.Point(658, 6)
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
        Me.bntSave.Location = New System.Drawing.Point(615, 6)
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(37, 38)
        Me.bntSave.TabIndex = 5
        Me.bntSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntSave.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bntSelectEm)
        Me.Panel1.Controls.Add(Me.bntClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(703, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(44, 517)
        Me.Panel1.TabIndex = 862
        '
        'bntSelectEm
        '
        Me.bntSelectEm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSelectEm.Image = Global.DocumentSystem.My.Resources.Resources._2000px_Microsoft_Excel_2013_logo_svg__Custom_
        Me.bntSelectEm.Location = New System.Drawing.Point(7, 481)
        Me.bntSelectEm.Name = "bntSelectEm"
        Me.bntSelectEm.Size = New System.Drawing.Size(32, 29)
        Me.bntSelectEm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntSelectEm.TabIndex = 1225
        Me.bntSelectEm.TabStop = False
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
        'TxtStartDate
        '
        Me.TxtStartDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtStartDate.Location = New System.Drawing.Point(576, 93)
        Me.TxtStartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(125, 29)
        Me.TxtStartDate.TabIndex = 7
        '
        'BackgroundWorker1
        '
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(505, 124)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(140, 29)
        Me.Panel6.TabIndex = 882
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "รายวัน (D) / รายเดือน (M)"
        '
        'TxtMD
        '
        Me.TxtMD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtMD.FormattingEnabled = True
        Me.TxtMD.ItemHeight = 23
        Me.TxtMD.Items.AddRange(New Object() {"", "M", "D"})
        Me.TxtMD.Location = New System.Drawing.Point(645, 124)
        Me.TxtMD.Name = "TxtMD"
        Me.TxtMD.Size = New System.Drawing.Size(55, 29)
        Me.TxtMD.TabIndex = 883
        Me.TxtMD.UseSelectable = True
        '
        'TxtDept
        '
        Me.TxtDept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDept.FormattingEnabled = True
        Me.TxtDept.ItemHeight = 23
        Me.TxtDept.Items.AddRange(New Object() {"", "AC", "AD", "BU", "EN", "HRGA", "IT", "IV", "LB", "MK", "PD", "PR", "QA", "RD", "SD", "SF", "WS"})
        Me.TxtDept.Location = New System.Drawing.Point(102, 93)
        Me.TxtDept.Name = "TxtDept"
        Me.TxtDept.Size = New System.Drawing.Size(96, 29)
        Me.TxtDept.TabIndex = 869
        Me.TxtDept.UseSelectable = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Location = New System.Drawing.Point(210, 124)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(95, 28)
        Me.Panel8.TabIndex = 885
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
        'TxtSection
        '
        Me.TxtSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtSection.FormattingEnabled = True
        Me.TxtSection.Location = New System.Drawing.Point(305, 124)
        Me.TxtSection.Name = "TxtSection"
        Me.TxtSection.Size = New System.Drawing.Size(197, 28)
        Me.TxtSection.TabIndex = 886
        '
        'txtEmployeeName1
        '
        Me.txtEmployeeName1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeName1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName1.Location = New System.Drawing.Point(305, 62)
        Me.txtEmployeeName1.Name = "txtEmployeeName1"
        Me.txtEmployeeName1.Size = New System.Drawing.Size(396, 29)
        Me.txtEmployeeName1.TabIndex = 888
        Me.txtEmployeeName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmTraining_Person
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 517)
        Me.Controls.Add(Me.txtEmployeeName1)
        Me.Controls.Add(Me.TxtSection)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.TxtMD)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TxtBranch)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.TxtLavel)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TxtDept)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.TxtEmployeeNo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_Person"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTraining_Person"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bntSelectEm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBranch As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLavel As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmployeeName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents bntNew As MetroFramework.Controls.MetroButton
    Friend WithEvents bntDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents bntSave As MetroFramework.Controls.MetroButton
    Friend WithEvents bntSelectEm As PictureBox
    Friend WithEvents bntClose As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtFind As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboBranch As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents grdData As MetroFramework.Controls.MetroGrid
    Friend WithEvents TxtEmployeeNo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMD As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TxtDept As MetroFramework.Controls.MetroComboBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNo As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents Dept As DataGridViewTextBoxColumn
    Friend WithEvents Section As DataGridViewTextBoxColumn
    Friend WithEvents Branch As DataGridViewTextBoxColumn
    Friend WithEvents Lavel As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents MD As DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSection As ComboBox
    Friend WithEvents txtEmployeeName1 As TextBox
    Friend WithEvents TxtFindData As TextBox
End Class
