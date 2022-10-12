<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMTC_Document
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMTC_Document))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile8 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile7 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
        Me.TxtDOCDEPT = New MetroFramework.Controls.MetroComboBox()
        Me.Panel51 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bntQEApprove = New MetroFramework.Controls.MetroButton()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel51.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(52, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Master Maintain Screen"
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
        Me.Panel_Head.Size = New System.Drawing.Size(923, 43)
        Me.Panel_Head.TabIndex = 24
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
        Me.PictureBox2.Location = New System.Drawing.Point(871, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.BackColor = System.Drawing.Color.Salmon
        Me.MetroTile5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile5.Location = New System.Drawing.Point(55, 396)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(219, 141)
        Me.MetroTile5.TabIndex = 36
        Me.MetroTile5.TabStop = False
        Me.MetroTile5.Text = "แก้ไขเลข DAR NO"
        Me.MetroTile5.TileImage = Global.DocumentSystem.My.Resources.Resources._374_512__Custom___3_1
        Me.MetroTile5.UseCustomBackColor = True
        Me.MetroTile5.UseCustomForeColor = True
        Me.MetroTile5.UseSelectable = True
        Me.MetroTile5.UseTileImage = True
        '
        'MetroTile8
        '
        Me.MetroTile8.ActiveControl = Nothing
        Me.MetroTile8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroTile8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile8.Location = New System.Drawing.Point(505, 249)
        Me.MetroTile8.Name = "MetroTile8"
        Me.MetroTile8.Size = New System.Drawing.Size(219, 141)
        Me.MetroTile8.TabIndex = 35
        Me.MetroTile8.TabStop = False
        Me.MetroTile8.Text = "ตารางเเจกจ่ายเอกสาร"
        Me.MetroTile8.TileImage = Global.DocumentSystem.My.Resources.Resources.imagesEHZ7Y6RZ__Custom___2_
        Me.MetroTile8.UseCustomBackColor = True
        Me.MetroTile8.UseCustomForeColor = True
        Me.MetroTile8.UseSelectable = True
        Me.MetroTile8.UseTileImage = True
        '
        'MetroTile7
        '
        Me.MetroTile7.ActiveControl = Nothing
        Me.MetroTile7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroTile7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile7.Location = New System.Drawing.Point(505, 102)
        Me.MetroTile7.Name = "MetroTile7"
        Me.MetroTile7.Size = New System.Drawing.Size(219, 141)
        Me.MetroTile7.TabIndex = 34
        Me.MetroTile7.TabStop = False
        Me.MetroTile7.Text = "รับ / คืนเอกสาร"
        Me.MetroTile7.TileImage = Global.DocumentSystem.My.Resources.Resources._374_512__Custom___3_
        Me.MetroTile7.UseCustomBackColor = True
        Me.MetroTile7.UseCustomForeColor = True
        Me.MetroTile7.UseSelectable = True
        Me.MetroTile7.UseTileImage = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroTile4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile4.Location = New System.Drawing.Point(280, 249)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(219, 141)
        Me.MetroTile4.TabIndex = 31
        Me.MetroTile4.TabStop = False
        Me.MetroTile4.Text = "Training History"
        Me.MetroTile4.TileImage = Global.DocumentSystem.My.Resources.Resources._1902270__Custom___4_1
        Me.MetroTile4.UseCustomBackColor = True
        Me.MetroTile4.UseCustomForeColor = True
        Me.MetroTile4.UseSelectable = True
        Me.MetroTile4.UseTileImage = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroTile3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile3.Location = New System.Drawing.Point(55, 249)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(219, 141)
        Me.MetroTile3.TabIndex = 30
        Me.MetroTile3.TabStop = False
        Me.MetroTile3.Text = "Training Assign"
        Me.MetroTile3.TileImage = Global.DocumentSystem.My.Resources.Resources.contackEmail3__Custom_
        Me.MetroTile3.UseCustomBackColor = True
        Me.MetroTile3.UseCustomForeColor = True
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroTile1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile1.Location = New System.Drawing.Point(280, 102)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(219, 141)
        Me.MetroTile1.TabIndex = 28
        Me.MetroTile1.TabStop = False
        Me.MetroTile1.Text = "ตารางเเจกจ่าย"
        Me.MetroTile1.TileImage = CType(resources.GetObject("MetroTile1.TileImage"), System.Drawing.Image)
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseCustomForeColor = True
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile2.Location = New System.Drawing.Point(55, 102)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(219, 141)
        Me.MetroTile2.TabIndex = 29
        Me.MetroTile2.TabStop = False
        Me.MetroTile2.Text = "Course Master ( SA )"
        Me.MetroTile2.TileImage = Global.DocumentSystem.My.Resources.Resources.document__Custom___2_
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseCustomForeColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTile6
        '
        Me.MetroTile6.ActiveControl = Nothing
        Me.MetroTile6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroTile6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile6.Location = New System.Drawing.Point(280, 396)
        Me.MetroTile6.Name = "MetroTile6"
        Me.MetroTile6.Size = New System.Drawing.Size(219, 141)
        Me.MetroTile6.TabIndex = 37
        Me.MetroTile6.TabStop = False
        Me.MetroTile6.Text = "Course Master ( EXCEL )"
        Me.MetroTile6.TileImage = Global.DocumentSystem.My.Resources.Resources.document__Custom___2_
        Me.MetroTile6.UseCustomBackColor = True
        Me.MetroTile6.UseCustomForeColor = True
        Me.MetroTile6.UseSelectable = True
        Me.MetroTile6.UseTileImage = True
        '
        'TxtDOCDEPT
        '
        Me.TxtDOCDEPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCDEPT.FormattingEnabled = True
        Me.TxtDOCDEPT.ItemHeight = 23
        Me.TxtDOCDEPT.Items.AddRange(New Object() {"", "AC", "BU", "EN", "HRGA", "GA", "HR", "IT", "IV", "LB", "MK", "MR", "PD", "PR", "QA", "RD", "SD", "SF", "WS"})
        Me.TxtDOCDEPT.Location = New System.Drawing.Point(174, 546)
        Me.TxtDOCDEPT.Name = "TxtDOCDEPT"
        Me.TxtDOCDEPT.Size = New System.Drawing.Size(130, 29)
        Me.TxtDOCDEPT.TabIndex = 1225
        Me.TxtDOCDEPT.UseSelectable = True
        '
        'Panel51
        '
        Me.Panel51.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel51.Controls.Add(Me.Label14)
        Me.Panel51.Location = New System.Drawing.Point(57, 546)
        Me.Panel51.Name = "Panel51"
        Me.Panel51.Size = New System.Drawing.Size(116, 29)
        Me.Panel51.TabIndex = 1224
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "เอกสารของฝ่าย Dept"
        '
        'bntQEApprove
        '
        Me.bntQEApprove.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.new_database_512
        Me.bntQEApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntQEApprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntQEApprove.Location = New System.Drawing.Point(308, 543)
        Me.bntQEApprove.Name = "bntQEApprove"
        Me.bntQEApprove.Size = New System.Drawing.Size(38, 36)
        Me.bntQEApprove.TabIndex = 1226
        Me.bntQEApprove.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntQEApprove.UseSelectable = True
        '
        'FrmMTC_Document
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 691)
        Me.Controls.Add(Me.bntQEApprove)
        Me.Controls.Add(Me.TxtDOCDEPT)
        Me.Controls.Add(Me.Panel51)
        Me.Controls.Add(Me.MetroTile6)
        Me.Controls.Add(Me.MetroTile5)
        Me.Controls.Add(Me.MetroTile8)
        Me.Controls.Add(Me.MetroTile7)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMTC_Document"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMTC_Document"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel51.ResumeLayout(False)
        Me.Panel51.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTile8 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile7 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
    Friend WithEvents TxtDOCDEPT As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel51 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents bntQEApprove As MetroFramework.Controls.MetroButton
End Class
