<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraining_CrseSet_Select
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntOK = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtDOCTYPEFind = New MetroFramework.Controls.MetroComboBox()
        Me.bntClose = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvMain = New MetroFramework.Controls.MetroGrid()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetrainFreq = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.xxx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.bntOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bntOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(985, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(44, 614)
        Me.Panel1.TabIndex = 1201
        '
        'bntOK
        '
        Me.bntOK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntOK.Image = Global.DocumentSystem.My.Resources.Resources.new_database_5125
        Me.bntOK.Location = New System.Drawing.Point(5, 580)
        Me.bntOK.Name = "bntOK"
        Me.bntOK.Size = New System.Drawing.Size(34, 29)
        Me.bntOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntOK.TabIndex = 1348
        Me.bntOK.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.TxtDOCTYPEFind)
        Me.Panel2.Controls.Add(Me.bntClose)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 36)
        Me.Panel2.TabIndex = 1202
        '
        'TxtDOCTYPEFind
        '
        Me.TxtDOCTYPEFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCTYPEFind.FormattingEnabled = True
        Me.TxtDOCTYPEFind.ItemHeight = 23
        Me.TxtDOCTYPEFind.Items.AddRange(New Object() {"Manual", "Procedure", "Standard Document", "Standard Document by Dept.", "Work Instruction", "Record Form", "Knowledge Management", "Organization Chart", "Job Description"})
        Me.TxtDOCTYPEFind.Location = New System.Drawing.Point(124, 4)
        Me.TxtDOCTYPEFind.Name = "TxtDOCTYPEFind"
        Me.TxtDOCTYPEFind.Size = New System.Drawing.Size(265, 29)
        Me.TxtDOCTYPEFind.TabIndex = 1347
        Me.TxtDOCTYPEFind.UseSelectable = True
        '
        'bntClose
        '
        Me.bntClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntClose.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg_hi
        Me.bntClose.Location = New System.Drawing.Point(991, 4)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(34, 29)
        Me.bntClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntClose.TabIndex = 385
        Me.bntClose.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel9.Controls.Add(Me.PictureBox4)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(7, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(116, 29)
        Me.Panel9.TabIndex = 1271
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DocumentSystem.My.Resources.Resources._374_512__Custom___2_1
        Me.PictureBox4.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 21)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1348
        Me.PictureBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Course Type"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.No, Me.Status, Me.DOCNO, Me.DOCNAME, Me.DOCDEPT, Me.RetrainFreq, Me.xxx})
        Me.dgvMain.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.EnableHeadersVisualStyles = False
        Me.dgvMain.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvMain.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMain.Location = New System.Drawing.Point(0, 36)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(985, 614)
        Me.dgvMain.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvMain.TabIndex = 1251
        Me.dgvMain.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel"
        Me.Sel.Name = "Sel"
        Me.Sel.Width = 20
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 50
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 150
        '
        'DOCNO
        '
        Me.DOCNO.HeaderText = "Course No."
        Me.DOCNO.Name = "DOCNO"
        Me.DOCNO.ReadOnly = True
        '
        'DOCNAME
        '
        Me.DOCNAME.HeaderText = "Description"
        Me.DOCNAME.Name = "DOCNAME"
        Me.DOCNAME.ReadOnly = True
        Me.DOCNAME.Width = 500
        '
        'DOCDEPT
        '
        Me.DOCDEPT.HeaderText = "DOCDEPT"
        Me.DOCDEPT.Name = "DOCDEPT"
        Me.DOCDEPT.ReadOnly = True
        Me.DOCDEPT.Visible = False
        '
        'RetrainFreq
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.RetrainFreq.DefaultCellStyle = DataGridViewCellStyle3
        Me.RetrainFreq.DisplayStyleForCurrentCellOnly = True
        Me.RetrainFreq.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RetrainFreq.HeaderText = "Retraing Frequency"
        Me.RetrainFreq.Items.AddRange(New Object() {"", "6 เดือน", "1 ปี", "2 ปี", "3 ปี"})
        Me.RetrainFreq.Name = "RetrainFreq"
        Me.RetrainFreq.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RetrainFreq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RetrainFreq.Width = 140
        '
        'xxx
        '
        Me.xxx.HeaderText = "xx"
        Me.xxx.Name = "xxx"
        Me.xxx.ReadOnly = True
        Me.xxx.Visible = False
        '
        'FrmTraining_CrseSet_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 650)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_CrseSet_Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTraining_CrseSet_Select"
        Me.Panel1.ResumeLayout(False)
        CType(Me.bntOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.bntClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bntClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TxtDOCTYPEFind As MetroFramework.Controls.MetroComboBox
    Friend WithEvents bntOK As PictureBox
    Friend WithEvents dgvMain As MetroFramework.Controls.MetroGrid
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents DOCNAME As DataGridViewTextBoxColumn
    Friend WithEvents DOCDEPT As DataGridViewTextBoxColumn
    Friend WithEvents RetrainFreq As DataGridViewComboBoxColumn
    Friend WithEvents xxx As DataGridViewTextBoxColumn
End Class
