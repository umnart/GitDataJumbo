<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateDataFromSA
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvData = New MetroFramework.Controls.MetroGrid()
        Me.CrseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrseNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevSts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescThai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrseTypCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEFFDATE = New MetroFramework.Controls.MetroDateTime()
        Me.bntChangeStartDate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CrseCode, Me.CrseNam, Me.RevSts, Me.DeptCod, Me.RevNo, Me.RevDate, Me.DescThai, Me.AttachFile, Me.CrseTypCode, Me.NO})
        Me.dgvData.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvData.EnableHeadersVisualStyles = False
        Me.dgvData.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvData.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvData.Location = New System.Drawing.Point(12, 12)
        Me.dgvData.MultiSelect = False
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(1026, 314)
        Me.dgvData.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvData.TabIndex = 1343
        Me.dgvData.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'CrseCode
        '
        Me.CrseCode.Frozen = True
        Me.CrseCode.HeaderText = "CrseCode"
        Me.CrseCode.Name = "CrseCode"
        Me.CrseCode.ReadOnly = True
        '
        'CrseNam
        '
        Me.CrseNam.Frozen = True
        Me.CrseNam.HeaderText = "CrseNam"
        Me.CrseNam.Name = "CrseNam"
        Me.CrseNam.ReadOnly = True
        '
        'RevSts
        '
        Me.RevSts.HeaderText = "RevSts"
        Me.RevSts.Name = "RevSts"
        Me.RevSts.ReadOnly = True
        '
        'DeptCod
        '
        Me.DeptCod.HeaderText = "DeptCod"
        Me.DeptCod.Name = "DeptCod"
        Me.DeptCod.ReadOnly = True
        '
        'RevNo
        '
        Me.RevNo.HeaderText = "RevNo"
        Me.RevNo.Name = "RevNo"
        Me.RevNo.ReadOnly = True
        '
        'RevDate
        '
        Me.RevDate.HeaderText = "RevDate"
        Me.RevDate.Name = "RevDate"
        Me.RevDate.ReadOnly = True
        '
        'DescThai
        '
        Me.DescThai.HeaderText = "DescThai"
        Me.DescThai.Name = "DescThai"
        Me.DescThai.ReadOnly = True
        '
        'AttachFile
        '
        Me.AttachFile.HeaderText = "AttachFile"
        Me.AttachFile.Name = "AttachFile"
        Me.AttachFile.ReadOnly = True
        '
        'CrseTypCode
        '
        Me.CrseTypCode.HeaderText = "CrseTypCode"
        Me.CrseTypCode.Name = "CrseTypCode"
        Me.CrseTypCode.ReadOnly = True
        '
        'NO
        '
        Me.NO.HeaderText = "No"
        Me.NO.Name = "NO"
        Me.NO.ReadOnly = True
        '
        'TxtEFFDATE
        '
        Me.TxtEFFDATE.CustomFormat = "dd/MM/yyyy"
        Me.TxtEFFDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtEFFDATE.Location = New System.Drawing.Point(1049, 118)
        Me.TxtEFFDATE.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtEFFDATE.Name = "TxtEFFDATE"
        Me.TxtEFFDATE.Size = New System.Drawing.Size(107, 29)
        Me.TxtEFFDATE.TabIndex = 1347
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
        Me.bntChangeStartDate.Location = New System.Drawing.Point(1044, 12)
        Me.bntChangeStartDate.Name = "bntChangeStartDate"
        Me.bntChangeStartDate.Size = New System.Drawing.Size(111, 39)
        Me.bntChangeStartDate.TabIndex = 1386
        Me.bntChangeStartDate.Text = "            ShowDATA"
        Me.bntChangeStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntChangeStartDate.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(1043, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 39)
        Me.Button1.TabIndex = 1387
        Me.Button1.Text = "            SAVEDATA"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(331, 389)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(82, 20)
        Me.T1.TabIndex = 1388
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(419, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 33)
        Me.Button2.TabIndex = 1389
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(551, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 33)
        Me.Button3.TabIndex = 1390
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmUpdateDataFromSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 556)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bntChangeStartDate)
        Me.Controls.Add(Me.TxtEFFDATE)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "FrmUpdateDataFromSA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUpdateDataFromSA"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvData As MetroFramework.Controls.MetroGrid
    Friend WithEvents TxtEFFDATE As MetroFramework.Controls.MetroDateTime
    Friend WithEvents bntChangeStartDate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CrseCode As DataGridViewTextBoxColumn
    Friend WithEvents CrseNam As DataGridViewTextBoxColumn
    Friend WithEvents RevSts As DataGridViewTextBoxColumn
    Friend WithEvents DeptCod As DataGridViewTextBoxColumn
    Friend WithEvents RevNo As DataGridViewTextBoxColumn
    Friend WithEvents RevDate As DataGridViewTextBoxColumn
    Friend WithEvents DescThai As DataGridViewTextBoxColumn
    Friend WithEvents AttachFile As DataGridViewTextBoxColumn
    Friend WithEvents CrseTypCode As DataGridViewTextBoxColumn
    Friend WithEvents NO As DataGridViewTextBoxColumn
    Friend WithEvents T1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
