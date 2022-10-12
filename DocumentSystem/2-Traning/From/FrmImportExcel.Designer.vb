<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportExcel))
        Me.grdFind = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMD = New MetroFramework.Controls.MetroComboBox()
        Me.TxtSourceFile = New System.Windows.Forms.TextBox()
        Me.cmdAddWorkOrder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdAddSave = New System.Windows.Forms.Button()
        Me.cmdEx = New System.Windows.Forms.Button()
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdFind
        '
        Me.grdFind.AllowUserToAddRows = False
        Me.grdFind.AllowUserToDeleteRows = False
        Me.grdFind.AllowUserToResizeColumns = False
        Me.grdFind.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdFind.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdFind.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFind.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdFind.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdFind.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdFind.Location = New System.Drawing.Point(6, 62)
        Me.grdFind.Name = "grdFind"
        Me.grdFind.ReadOnly = True
        Me.grdFind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdFind.Size = New System.Drawing.Size(916, 513)
        Me.grdFind.TabIndex = 400
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxtMD)
        Me.Panel2.Controls.Add(Me.TxtSourceFile)
        Me.Panel2.Controls.Add(Me.cmdAddWorkOrder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(932, 49)
        Me.Panel2.TabIndex = 402
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(383, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(101, 28)
        Me.Panel4.TabIndex = 1363
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "แหล่งไฟล์"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 28)
        Me.Panel3.TabIndex = 1361
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รายเดือน / รายวัน"
        '
        'TxtMD
        '
        Me.TxtMD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtMD.FormattingEnabled = True
        Me.TxtMD.ItemHeight = 23
        Me.TxtMD.Items.AddRange(New Object() {"รายเดือน", "รายวัน"})
        Me.TxtMD.Location = New System.Drawing.Point(114, 12)
        Me.TxtMD.Name = "TxtMD"
        Me.TxtMD.Size = New System.Drawing.Size(130, 29)
        Me.TxtMD.TabIndex = 1362
        Me.TxtMD.UseSelectable = True
        '
        'TxtSourceFile
        '
        Me.TxtSourceFile.Location = New System.Drawing.Point(485, 13)
        Me.TxtSourceFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSourceFile.Multiline = True
        Me.TxtSourceFile.Name = "TxtSourceFile"
        Me.TxtSourceFile.ReadOnly = True
        Me.TxtSourceFile.Size = New System.Drawing.Size(442, 27)
        Me.TxtSourceFile.TabIndex = 374
        '
        'cmdAddWorkOrder
        '
        Me.cmdAddWorkOrder.BackColor = System.Drawing.Color.Silver
        Me.cmdAddWorkOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAddWorkOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdAddWorkOrder.Image = Global.DocumentSystem.My.Resources.Resources._2000px_Microsoft_Excel_2013_logo1
        Me.cmdAddWorkOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAddWorkOrder.Location = New System.Drawing.Point(257, 9)
        Me.cmdAddWorkOrder.Name = "cmdAddWorkOrder"
        Me.cmdAddWorkOrder.Size = New System.Drawing.Size(123, 36)
        Me.cmdAddWorkOrder.TabIndex = 373
        Me.cmdAddWorkOrder.Text = "        SelectExcel"
        Me.cmdAddWorkOrder.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdAddSave)
        Me.Panel1.Controls.Add(Me.cmdEx)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(932, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(69, 587)
        Me.Panel1.TabIndex = 401
        '
        'cmdAddSave
        '
        Me.cmdAddSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAddSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdAddSave.Image = Global.DocumentSystem.My.Resources.Resources._2000px_Microsoft_Excel_2013_logo1
        Me.cmdAddSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAddSave.Location = New System.Drawing.Point(5, 459)
        Me.cmdAddSave.Name = "cmdAddSave"
        Me.cmdAddSave.Size = New System.Drawing.Size(61, 56)
        Me.cmdAddSave.TabIndex = 389
        Me.cmdAddSave.Text = "Import"
        Me.cmdAddSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAddSave.UseVisualStyleBackColor = True
        '
        'cmdEx
        '
        Me.cmdEx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdEx.Image = CType(resources.GetObject("cmdEx.Image"), System.Drawing.Image)
        Me.cmdEx.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEx.Location = New System.Drawing.Point(3, 521)
        Me.cmdEx.Name = "cmdEx"
        Me.cmdEx.Size = New System.Drawing.Size(61, 54)
        Me.cmdEx.TabIndex = 390
        Me.cmdEx.Text = "ออก"
        Me.cmdEx.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEx.UseVisualStyleBackColor = True
        '
        'FrmImportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 587)
        Me.Controls.Add(Me.grdFind)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmImportExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmImportExcel"
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdFind As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtSourceFile As TextBox
    Friend WithEvents cmdAddWorkOrder As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdAddSave As Button
    Friend WithEvents cmdEx As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMD As MetroFramework.Controls.MetroComboBox
End Class
