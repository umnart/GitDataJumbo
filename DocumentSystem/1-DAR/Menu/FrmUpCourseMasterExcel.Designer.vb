<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpCourseMasterExcel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpCourseMasterExcel))
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_fillter = New System.Windows.Forms.Panel()
        Me.TxtSourceFile = New MetroFramework.Controls.MetroTextBox()
        Me.grdFind = New MetroFramework.Controls.MetroGrid()
        Me.ListView1 = New System.Windows.Forms.ListBox()
        Me.bntPrinting = New MetroFramework.Controls.MetroButton()
        Me.bntSave = New MetroFramework.Controls.MetroButton()
        Me.cmd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel_Head.SuspendLayout()
        Me.Panel_fillter.SuspendLayout()
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox1)
        Me.Panel_Head.Controls.Add(Me.Label1)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(964, 43)
        Me.Panel_Head.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(52, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Update Course Master From Excel"
        '
        'Panel_fillter
        '
        Me.Panel_fillter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel_fillter.Controls.Add(Me.bntPrinting)
        Me.Panel_fillter.Controls.Add(Me.bntSave)
        Me.Panel_fillter.Controls.Add(Me.TxtSourceFile)
        Me.Panel_fillter.Controls.Add(Me.cmd)
        Me.Panel_fillter.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_fillter.Location = New System.Drawing.Point(0, 43)
        Me.Panel_fillter.Name = "Panel_fillter"
        Me.Panel_fillter.Size = New System.Drawing.Size(964, 52)
        Me.Panel_fillter.TabIndex = 12
        '
        'TxtSourceFile
        '
        '
        '
        '
        Me.TxtSourceFile.CustomButton.Image = Nothing
        Me.TxtSourceFile.CustomButton.Location = New System.Drawing.Point(651, 2)
        Me.TxtSourceFile.CustomButton.Name = ""
        Me.TxtSourceFile.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtSourceFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtSourceFile.CustomButton.TabIndex = 1
        Me.TxtSourceFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtSourceFile.CustomButton.UseSelectable = True
        Me.TxtSourceFile.CustomButton.Visible = False
        Me.TxtSourceFile.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TxtSourceFile.Lines = New String(-1) {}
        Me.TxtSourceFile.Location = New System.Drawing.Point(161, 11)
        Me.TxtSourceFile.MaxLength = 32767
        Me.TxtSourceFile.Name = "TxtSourceFile"
        Me.TxtSourceFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSourceFile.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtSourceFile.SelectedText = ""
        Me.TxtSourceFile.SelectionLength = 0
        Me.TxtSourceFile.SelectionStart = 0
        Me.TxtSourceFile.ShortcutsEnabled = True
        Me.TxtSourceFile.Size = New System.Drawing.Size(679, 30)
        Me.TxtSourceFile.TabIndex = 532
        Me.TxtSourceFile.UseSelectable = True
        Me.TxtSourceFile.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtSourceFile.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'grdFind
        '
        Me.grdFind.AllowUserToAddRows = False
        Me.grdFind.AllowUserToResizeRows = False
        Me.grdFind.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdFind.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdFind.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdFind.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdFind.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdFind.ColumnHeadersHeight = 30
        Me.grdFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdFind.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFind.EnableHeadersVisualStyles = False
        Me.grdFind.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdFind.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdFind.Location = New System.Drawing.Point(161, 95)
        Me.grdFind.Name = "grdFind"
        Me.grdFind.ReadOnly = True
        Me.grdFind.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdFind.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdFind.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdFind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdFind.Size = New System.Drawing.Size(803, 639)
        Me.grdFind.TabIndex = 393
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FormattingEnabled = True
        Me.ListView1.ItemHeight = 16
        Me.ListView1.Location = New System.Drawing.Point(0, 95)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(161, 639)
        Me.ListView1.TabIndex = 394
        '
        'bntPrinting
        '
        Me.bntPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntPrinting.BackgroundImage = CType(resources.GetObject("bntPrinting.BackgroundImage"), System.Drawing.Image)
        Me.bntPrinting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntPrinting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntPrinting.Location = New System.Drawing.Point(869, 6)
        Me.bntPrinting.Name = "bntPrinting"
        Me.bntPrinting.Size = New System.Drawing.Size(37, 38)
        Me.bntPrinting.TabIndex = 534
        Me.bntPrinting.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntPrinting.UseSelectable = True
        Me.bntPrinting.Visible = False
        '
        'bntSave
        '
        Me.bntSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntSave.BackgroundImage = CType(resources.GetObject("bntSave.BackgroundImage"), System.Drawing.Image)
        Me.bntSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSave.Location = New System.Drawing.Point(915, 6)
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(37, 38)
        Me.bntSave.TabIndex = 533
        Me.bntSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntSave.UseSelectable = True
        '
        'cmd
        '
        Me.cmd.BackColor = System.Drawing.Color.Silver
        Me.cmd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd.Image = Global.DocumentSystem.My.Resources.Resources._2000px_Microsoft_Excel_2013_logo2
        Me.cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd.Location = New System.Drawing.Point(37, 9)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(123, 34)
        Me.cmd.TabIndex = 374
        Me.cmd.Text = "        SelectExcel"
        Me.cmd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(912, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'FrmUpCourseMasterExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 734)
        Me.Controls.Add(Me.grdFind)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel_fillter)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUpCourseMasterExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUpCourseMasterExcel"
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        Me.Panel_fillter.ResumeLayout(False)
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Head As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel_fillter As Panel
    Friend WithEvents bntPrinting As MetroFramework.Controls.MetroButton
    Friend WithEvents bntSave As MetroFramework.Controls.MetroButton
    Friend WithEvents TxtSourceFile As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmd As Button
    Friend WithEvents grdFind As MetroFramework.Controls.MetroGrid
    Friend WithEvents ListView1 As ListBox
End Class
