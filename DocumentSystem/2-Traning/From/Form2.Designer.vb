<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.dgvDetail = New MetroFramework.Controls.MetroGrid()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REVNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EFFDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MthdNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrnnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetail
        '
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
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.DOCNO, Me.REVNO, Me.EFFDATE, Me.DOCNAME, Me.MthdNam, Me.DOCDEPT, Me.TrnnDate, Me.Result, Me.Approve, Me.Remark})
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
        Me.dgvDetail.Location = New System.Drawing.Point(3, 12)
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
        Me.dgvDetail.Size = New System.Drawing.Size(1028, 547)
        Me.dgvDetail.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvDetail.TabIndex = 1376
        Me.dgvDetail.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'No
        '
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.No.Visible = False
        Me.No.Width = 30
        '
        'DOCNO
        '
        Me.DOCNO.HeaderText = "DOC NO"
        Me.DOCNO.Name = "DOCNO"
        Me.DOCNO.ReadOnly = True
        Me.DOCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'REVNO
        '
        Me.REVNO.HeaderText = "REV"
        Me.REVNO.Name = "REVNO"
        Me.REVNO.ReadOnly = True
        Me.REVNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.REVNO.Width = 30
        '
        'EFFDATE
        '
        Me.EFFDATE.HeaderText = "Rev Date"
        Me.EFFDATE.Name = "EFFDATE"
        Me.EFFDATE.ReadOnly = True
        Me.EFFDATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EFFDATE.Width = 80
        '
        'DOCNAME
        '
        Me.DOCNAME.HeaderText = "DOCNAME"
        Me.DOCNAME.Name = "DOCNAME"
        Me.DOCNAME.ReadOnly = True
        Me.DOCNAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DOCNAME.Width = 300
        '
        'MthdNam
        '
        Me.MthdNam.HeaderText = "Method Training"
        Me.MthdNam.Name = "MthdNam"
        Me.MthdNam.ReadOnly = True
        Me.MthdNam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MthdNam.Width = 140
        '
        'DOCDEPT
        '
        Me.DOCDEPT.HeaderText = "DOCDEPT"
        Me.DOCDEPT.Name = "DOCDEPT"
        Me.DOCDEPT.ReadOnly = True
        Me.DOCDEPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DOCDEPT.Visible = False
        '
        'TrnnDate
        '
        Me.TrnnDate.HeaderText = "TrainingDate"
        Me.TrnnDate.Name = "TrnnDate"
        Me.TrnnDate.ReadOnly = True
        Me.TrnnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TrnnDate.Width = 105
        '
        'Result
        '
        Me.Result.HeaderText = "Pass"
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        Me.Result.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Result.Width = 50
        '
        'Approve
        '
        Me.Approve.HeaderText = "Approve By"
        Me.Approve.Name = "Approve"
        Me.Approve.ReadOnly = True
        Me.Approve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Remark
        '
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        Me.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Remark.Width = 110
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 489)
        Me.Controls.Add(Me.dgvDetail)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDetail As MetroFramework.Controls.MetroGrid
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents REVNO As DataGridViewTextBoxColumn
    Friend WithEvents EFFDATE As DataGridViewTextBoxColumn
    Friend WithEvents DOCNAME As DataGridViewTextBoxColumn
    Friend WithEvents MthdNam As DataGridViewTextBoxColumn
    Friend WithEvents DOCDEPT As DataGridViewTextBoxColumn
    Friend WithEvents TrnnDate As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewCheckBoxColumn
    Friend WithEvents Approve As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
End Class
