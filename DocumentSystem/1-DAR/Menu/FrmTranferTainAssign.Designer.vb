<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTranferTainAssign
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvData_1 = New MetroFramework.Controls.MetroGrid()
        Me.PersonCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Assign = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trainer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEFFDATE = New MetroFramework.Controls.MetroDateTime()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bntChangeStartDate = New System.Windows.Forms.Button()
        CType(Me.dgvData_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData_1
        '
        Me.dgvData_1.AllowUserToDeleteRows = False
        Me.dgvData_1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvData_1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData_1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvData_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvData_1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvData_1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData_1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonCode, Me.CrseCode, Me.DeptCod, Me.EmpTypeID, Me.cDept, Me.Assign, Me.Trainer, Me.MthdCode, Me.Approve})
        Me.dgvData_1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData_1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvData_1.EnableHeadersVisualStyles = False
        Me.dgvData_1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvData_1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvData_1.Location = New System.Drawing.Point(1086, 224)
        Me.dgvData_1.MultiSelect = False
        Me.dgvData_1.Name = "dgvData_1"
        Me.dgvData_1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData_1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvData_1.RowHeadersVisible = False
        Me.dgvData_1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvData_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData_1.Size = New System.Drawing.Size(48, 72)
        Me.dgvData_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvData_1.TabIndex = 1388
        Me.dgvData_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgvData_1.Visible = False
        '
        'PersonCode
        '
        Me.PersonCode.HeaderText = "PersonCode"
        Me.PersonCode.Name = "PersonCode"
        Me.PersonCode.ReadOnly = True
        '
        'CrseCode
        '
        Me.CrseCode.HeaderText = "CrseCode"
        Me.CrseCode.Name = "CrseCode"
        Me.CrseCode.ReadOnly = True
        '
        'DeptCod
        '
        Me.DeptCod.HeaderText = "DeptCod"
        Me.DeptCod.Name = "DeptCod"
        Me.DeptCod.ReadOnly = True
        '
        'EmpTypeID
        '
        Me.EmpTypeID.HeaderText = "EmpTypeID"
        Me.EmpTypeID.Name = "EmpTypeID"
        Me.EmpTypeID.ReadOnly = True
        '
        'cDept
        '
        Me.cDept.HeaderText = "cDept"
        Me.cDept.Name = "cDept"
        Me.cDept.ReadOnly = True
        '
        'Assign
        '
        Me.Assign.HeaderText = "Assign"
        Me.Assign.Name = "Assign"
        Me.Assign.ReadOnly = True
        '
        'Trainer
        '
        Me.Trainer.HeaderText = "Trainer"
        Me.Trainer.Name = "Trainer"
        Me.Trainer.ReadOnly = True
        '
        'MthdCode
        '
        Me.MthdCode.HeaderText = "MthdCode"
        Me.MthdCode.Name = "MthdCode"
        Me.MthdCode.ReadOnly = True
        '
        'Approve
        '
        Me.Approve.HeaderText = "Approve"
        Me.Approve.Name = "Approve"
        Me.Approve.ReadOnly = True
        '
        'TxtEFFDATE
        '
        Me.TxtEFFDATE.CustomFormat = "dd/MM/yyyy"
        Me.TxtEFFDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtEFFDATE.Location = New System.Drawing.Point(1044, 118)
        Me.TxtEFFDATE.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtEFFDATE.Name = "TxtEFFDATE"
        Me.TxtEFFDATE.Size = New System.Drawing.Size(107, 29)
        Me.TxtEFFDATE.TabIndex = 1389
        '
        'grdData
        '
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.EmployeeNo, Me.EmployeeName, Me.Dept, Me.Section, Me.Branch, Me.Lavel, Me.StartDate, Me.MD})
        Me.grdData.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdData.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdData.Location = New System.Drawing.Point(25, 12)
        Me.grdData.MultiSelect = False
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdData.RowHeadersVisible = False
        Me.grdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(1007, 532)
        Me.grdData.Style = MetroFramework.MetroColorStyle.Teal
        Me.grdData.TabIndex = 1392
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.DocumentSystem.My.Resources.Resources.Save_icon15
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1038, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 39)
        Me.Button1.TabIndex = 1391
        Me.Button1.Text = "            SAVEDATA"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.bntChangeStartDate.Image = Global.DocumentSystem.My.Resources.Resources.search_icon__Custom_2
        Me.bntChangeStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntChangeStartDate.Location = New System.Drawing.Point(1039, 12)
        Me.bntChangeStartDate.Name = "bntChangeStartDate"
        Me.bntChangeStartDate.Size = New System.Drawing.Size(111, 39)
        Me.bntChangeStartDate.TabIndex = 1390
        Me.bntChangeStartDate.Text = "            ShowDATA"
        Me.bntChangeStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntChangeStartDate.UseVisualStyleBackColor = False
        '
        'FrmTranferTainAssign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 556)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.dgvData_1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bntChangeStartDate)
        Me.Controls.Add(Me.TxtEFFDATE)
        Me.Name = "FrmTranferTainAssign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTranferTainAssign"
        CType(Me.dgvData_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvData_1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button1 As Button
    Friend WithEvents bntChangeStartDate As Button
    Friend WithEvents TxtEFFDATE As MetroFramework.Controls.MetroDateTime
    Friend WithEvents PersonCode As DataGridViewTextBoxColumn
    Friend WithEvents CrseCode As DataGridViewTextBoxColumn
    Friend WithEvents DeptCod As DataGridViewTextBoxColumn
    Friend WithEvents EmpTypeID As DataGridViewTextBoxColumn
    Friend WithEvents cDept As DataGridViewTextBoxColumn
    Friend WithEvents Assign As DataGridViewTextBoxColumn
    Friend WithEvents Trainer As DataGridViewTextBoxColumn
    Friend WithEvents MthdCode As DataGridViewTextBoxColumn
    Friend WithEvents Approve As DataGridViewTextBoxColumn
    Friend WithEvents grdData As MetroFramework.Controls.MetroGrid
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNo As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents Dept As DataGridViewTextBoxColumn
    Friend WithEvents Section As DataGridViewTextBoxColumn
    Friend WithEvents Branch As DataGridViewTextBoxColumn
    Friend WithEvents Lavel As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents MD As DataGridViewTextBoxColumn
End Class
