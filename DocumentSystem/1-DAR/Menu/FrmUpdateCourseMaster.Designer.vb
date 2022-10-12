<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateCourseMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateCourseMaster))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntAddItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.grdData = New MetroFramework.Controls.MetroGrid()
        Me.CrseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrseNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrseSts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescThai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrseTypCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntAddItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(996, 47)
        Me.ToolStrip3.TabIndex = 1340
        Me.ToolStrip3.Text = "ToolStrip_menu2"
        '
        'bntAddItem
        '
        Me.bntAddItem.ForeColor = System.Drawing.Color.White
        Me.bntAddItem.Image = CType(resources.GetObject("bntAddItem.Image"), System.Drawing.Image)
        Me.bntAddItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntAddItem.Name = "bntAddItem"
        Me.bntAddItem.Size = New System.Drawing.Size(100, 44)
        Me.bntAddItem.Text = "Add Item"
        Me.bntAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.DocumentSystem.My.Resources.Resources.Save_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(99, 44)
        Me.ToolStripButton1.Text = "SaveData"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.DocumentSystem.My.Resources.Resources.delete_icon_image_15_jpg
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(84, 44)
        Me.ToolStripButton2.Text = "Delete"
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
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CrseCode, Me.CrseNam, Me.CrseSts, Me.DeptCod, Me.RevNo, Me.RevDate, Me.DescThai, Me.AttachFile, Me.CrseTypCode})
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
        Me.grdData.Location = New System.Drawing.Point(12, 83)
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
        Me.grdData.Size = New System.Drawing.Size(972, 548)
        Me.grdData.Style = MetroFramework.MetroColorStyle.Teal
        Me.grdData.TabIndex = 1341
        Me.grdData.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'CrseCode
        '
        Me.CrseCode.HeaderText = "CrseCode"
        Me.CrseCode.Name = "CrseCode"
        Me.CrseCode.ReadOnly = True
        '
        'CrseNam
        '
        Me.CrseNam.HeaderText = "CrseNam"
        Me.CrseNam.Name = "CrseNam"
        Me.CrseNam.ReadOnly = True
        '
        'CrseSts
        '
        Me.CrseSts.HeaderText = "CrseSts"
        Me.CrseSts.Name = "CrseSts"
        Me.CrseSts.ReadOnly = True
        '
        'DeptCod
        '
        Me.DeptCod.HeaderText = "DeptCod"
        Me.DeptCod.Name = "DeptCod"
        '
        'RevNo
        '
        Me.RevNo.HeaderText = "RevNo"
        Me.RevNo.Name = "RevNo"
        '
        'RevDate
        '
        Me.RevDate.HeaderText = "RevDate"
        Me.RevDate.Name = "RevDate"
        '
        'DescThai
        '
        Me.DescThai.HeaderText = "DescThai"
        Me.DescThai.Name = "DescThai"
        '
        'AttachFile
        '
        Me.AttachFile.HeaderText = "AttachFile"
        Me.AttachFile.Name = "AttachFile"
        '
        'CrseTypCode
        '
        Me.CrseTypCode.HeaderText = "CrseTypCode"
        Me.CrseTypCode.Name = "CrseTypCode"
        '
        'FrmUpdateCourseMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 652)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Name = "FrmUpdateCourseMaster"
        Me.Text = "FrmUpdateCourseMaster"
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntAddItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents grdData As MetroFramework.Controls.MetroGrid
    Friend WithEvents CrseCode As DataGridViewTextBoxColumn
    Friend WithEvents CrseNam As DataGridViewTextBoxColumn
    Friend WithEvents CrseSts As DataGridViewTextBoxColumn
    Friend WithEvents DeptCod As DataGridViewTextBoxColumn
    Friend WithEvents RevNo As DataGridViewTextBoxColumn
    Friend WithEvents RevDate As DataGridViewTextBoxColumn
    Friend WithEvents DescThai As DataGridViewTextBoxColumn
    Friend WithEvents AttachFile As DataGridViewTextBoxColumn
    Friend WithEvents CrseTypCode As DataGridViewTextBoxColumn
End Class
