<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentSystem_SelectDept
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim CNRBGNBRLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentSystem_SelectDept))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bntDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntSave = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.dgvToDept = New MetroFramework.Controls.MetroGrid()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToDept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDeptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDOCNO = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        IDLabel = New System.Windows.Forms.Label()
        CNRBGNBRLabel = New System.Windows.Forms.Label()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Head.SuspendLayout()
        CType(Me.dgvToDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        'CNRBGNBRLabel
        '
        CNRBGNBRLabel.AutoSize = True
        CNRBGNBRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        CNRBGNBRLabel.Location = New System.Drawing.Point(12, 15)
        CNRBGNBRLabel.Name = "CNRBGNBRLabel"
        CNRBGNBRLabel.Size = New System.Drawing.Size(120, 16)
        CNRBGNBRLabel.TabIndex = 1399
        CNRBGNBRLabel.Text = "เอกสารเลขที่ Doc.No :"
        '
        'bntDelete
        '
        Me.bntDelete.ForeColor = System.Drawing.Color.White
        Me.bntDelete.Image = Global.DocumentSystem.My.Resources.Resources.delete_icon_image_15_jpg
        Me.bntDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntDelete.Name = "bntDelete"
        Me.bntDelete.Size = New System.Drawing.Size(84, 44)
        Me.bntDelete.Text = "Delete"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntSave, Me.bntDelete})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 549)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(278, 47)
        Me.ToolStrip3.TabIndex = 1409
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'bntSave
        '
        Me.bntSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bntSave.ForeColor = System.Drawing.Color.White
        Me.bntSave.Image = Global.DocumentSystem.My.Resources.Resources.Save_icon
        Me.bntSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(99, 44)
        Me.bntSave.Text = "SaveData"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(226, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(52, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Master Maintain Screen"
        '
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(Me.Label11)
        Me.Panel_Head.Controls.Add(Me.PictureBox3)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(278, 43)
        Me.Panel_Head.TabIndex = 1407
        '
        'dgvToDept
        '
        Me.dgvToDept.AllowUserToAddRows = False
        Me.dgvToDept.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvToDept.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvToDept.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvToDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvToDept.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvToDept.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvToDept.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvToDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvToDept.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.ToDept, Me.ToDeptName, Me.Quantity})
        Me.dgvToDept.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvToDept.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvToDept.EnableHeadersVisualStyles = False
        Me.dgvToDept.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvToDept.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvToDept.Location = New System.Drawing.Point(12, 119)
        Me.dgvToDept.MultiSelect = False
        Me.dgvToDept.Name = "dgvToDept"
        Me.dgvToDept.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvToDept.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvToDept.RowHeadersVisible = False
        Me.dgvToDept.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvToDept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvToDept.Size = New System.Drawing.Size(233, 399)
        Me.dgvToDept.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvToDept.TabIndex = 1410
        Me.dgvToDept.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Sel
        '
        Me.Sel.HeaderText = "Sel"
        Me.Sel.Name = "Sel"
        Me.Sel.Width = 20
        '
        'ToDept
        '
        Me.ToDept.HeaderText = "ToDept"
        Me.ToDept.Name = "ToDept"
        Me.ToDept.ReadOnly = True
        Me.ToDept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ToDept.Width = 45
        '
        'ToDeptName
        '
        Me.ToDeptName.HeaderText = "ToDeptName"
        Me.ToDeptName.Name = "ToDeptName"
        Me.ToDeptName.ReadOnly = True
        Me.ToDeptName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ToDeptName.Width = 80
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "จำนวนชุด"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Quantity.Width = 78
        '
        'TxtDOCNO
        '
        Me.TxtDOCNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtDOCNO.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtDOCNO.Location = New System.Drawing.Point(138, 15)
        Me.TxtDOCNO.Name = "TxtDOCNO"
        Me.TxtDOCNO.Size = New System.Drawing.Size(135, 23)
        Me.TxtDOCNO.TabIndex = 1400
        Me.TxtDOCNO.Text = "--"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(CNRBGNBRLabel)
        Me.Panel2.Controls.Add(Me.TxtDOCNO)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 51)
        Me.Panel2.TabIndex = 1408
        '
        'FrmDocumentSystem_SelectDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 596)
        Me.Controls.Add(Me.dgvToDept)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDocumentSystem_SelectDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDocumentSystem_SelectDept"
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.dgvToDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bntDelete As ToolStripButton
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntSave As ToolStripButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents dgvToDept As MetroFramework.Controls.MetroGrid
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents ToDept As DataGridViewTextBoxColumn
    Friend WithEvents ToDeptName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents TxtDOCNO As Label
    Friend WithEvents Panel2 As Panel
End Class
