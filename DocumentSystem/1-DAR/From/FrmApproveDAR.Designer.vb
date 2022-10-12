<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmApproveDAR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApproveDAR))
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TxtQEMGRREASON = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.TxtQEMRREASON = New System.Windows.Forms.TextBox()
        Me.TxtQEMRDATE = New System.Windows.Forms.TextBox()
        Me.TxtQEMRNAME = New System.Windows.Forms.TextBox()
        Me.TxtQEMRAPPROVE = New MetroFramework.Controls.MetroComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblStep_3 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.TxtQEMGRDATE = New System.Windows.Forms.TextBox()
        Me.TxtQEMGRNAME = New System.Windows.Forms.TextBox()
        Me.TxtQEMGRAPPROVE = New MetroFramework.Controls.MetroComboBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lblStep_2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtQEOFFICERREASON = New System.Windows.Forms.TextBox()
        Me.TxtQEOFFICERDATE = New System.Windows.Forms.TextBox()
        Me.TxtQEOFFICERNAME = New System.Windows.Forms.TextBox()
        Me.TxtQEOFFICERAPPROVE = New MetroFramework.Controls.MetroComboBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblStep_1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TxtDarNo = New System.Windows.Forms.TextBox()
        Me.TxtREFNO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtLINEDATA = New System.Windows.Forms.TextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.TxtDateNow = New MetroFramework.Controls.MetroDateTime()
        Me.TxtREFNODATA = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvEmailKM = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KM_DOCNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KM_DOCNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KM_REVNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KM_Mange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KM_EFFDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.bntDelete = New MetroFramework.Controls.MetroButton()
        Me.bntSave = New MetroFramework.Controls.MetroButton()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEmailKM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.TxtQEMGRREASON)
        Me.Panel7.Controls.Add(Me.Label61)
        Me.Panel7.Controls.Add(Me.TxtQEMRREASON)
        Me.Panel7.Controls.Add(Me.TxtQEMRDATE)
        Me.Panel7.Controls.Add(Me.TxtQEMRNAME)
        Me.Panel7.Controls.Add(Me.TxtDateNow)
        Me.Panel7.Controls.Add(Me.TxtQEMRAPPROVE)
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Controls.Add(Me.Label64)
        Me.Panel7.Controls.Add(Me.TxtQEMGRDATE)
        Me.Panel7.Controls.Add(Me.TxtQEMGRNAME)
        Me.Panel7.Controls.Add(Me.TxtQEMGRAPPROVE)
        Me.Panel7.Controls.Add(Me.Panel12)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Controls.Add(Me.TxtQEOFFICERREASON)
        Me.Panel7.Controls.Add(Me.TxtQEOFFICERDATE)
        Me.Panel7.Controls.Add(Me.TxtQEOFFICERNAME)
        Me.Panel7.Controls.Add(Me.TxtQEOFFICERAPPROVE)
        Me.Panel7.Controls.Add(Me.Panel13)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 51)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(602, 490)
        Me.Panel7.TabIndex = 1143
        '
        'TxtQEMGRREASON
        '
        Me.TxtQEMGRREASON.BackColor = System.Drawing.Color.White
        Me.TxtQEMGRREASON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQEMGRREASON.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQEMGRREASON.Location = New System.Drawing.Point(12, 256)
        Me.TxtQEMGRREASON.Multiline = True
        Me.TxtQEMGRREASON.Name = "TxtQEMGRREASON"
        Me.TxtQEMGRREASON.Size = New System.Drawing.Size(585, 78)
        Me.TxtQEMGRREASON.TabIndex = 1235
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label61.Location = New System.Drawing.Point(12, 374)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(267, 15)
        Me.Label61.TabIndex = 1234
        Me.Label61.Text = "ความเห็นที่ไม่อนุมัติ ( Reason when not approved )"
        '
        'TxtQEMRREASON
        '
        Me.TxtQEMRREASON.BackColor = System.Drawing.Color.White
        Me.TxtQEMRREASON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQEMRREASON.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQEMRREASON.Location = New System.Drawing.Point(13, 394)
        Me.TxtQEMRREASON.Multiline = True
        Me.TxtQEMRREASON.Name = "TxtQEMRREASON"
        Me.TxtQEMRREASON.Size = New System.Drawing.Size(584, 78)
        Me.TxtQEMRREASON.TabIndex = 1233
        '
        'TxtQEMRDATE
        '
        Me.TxtQEMRDATE.BackColor = System.Drawing.SystemColors.Control
        Me.TxtQEMRDATE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtQEMRDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtQEMRDATE.Location = New System.Drawing.Point(519, 345)
        Me.TxtQEMRDATE.Multiline = True
        Me.TxtQEMRDATE.Name = "TxtQEMRDATE"
        Me.TxtQEMRDATE.ReadOnly = True
        Me.TxtQEMRDATE.Size = New System.Drawing.Size(73, 29)
        Me.TxtQEMRDATE.TabIndex = 1232
        '
        'TxtQEMRNAME
        '
        Me.TxtQEMRNAME.BackColor = System.Drawing.SystemColors.Control
        Me.TxtQEMRNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtQEMRNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtQEMRNAME.Location = New System.Drawing.Point(270, 345)
        Me.TxtQEMRNAME.Multiline = True
        Me.TxtQEMRNAME.Name = "TxtQEMRNAME"
        Me.TxtQEMRNAME.ReadOnly = True
        Me.TxtQEMRNAME.Size = New System.Drawing.Size(247, 29)
        Me.TxtQEMRNAME.TabIndex = 1231
        '
        'TxtQEMRAPPROVE
        '
        Me.TxtQEMRAPPROVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtQEMRAPPROVE.FormattingEnabled = True
        Me.TxtQEMRAPPROVE.ItemHeight = 23
        Me.TxtQEMRAPPROVE.Items.AddRange(New Object() {"", "Pass", "Not Pass"})
        Me.TxtQEMRAPPROVE.Location = New System.Drawing.Point(178, 344)
        Me.TxtQEMRAPPROVE.Name = "TxtQEMRAPPROVE"
        Me.TxtQEMRAPPROVE.Size = New System.Drawing.Size(91, 29)
        Me.TxtQEMRAPPROVE.TabIndex = 1230
        Me.TxtQEMRAPPROVE.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.lblStep_3)
        Me.Panel3.Location = New System.Drawing.Point(13, 344)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(164, 29)
        Me.Panel3.TabIndex = 1229
        '
        'lblStep_3
        '
        Me.lblStep_3.AutoSize = True
        Me.lblStep_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStep_3.ForeColor = System.Drawing.Color.White
        Me.lblStep_3.Location = New System.Drawing.Point(3, 7)
        Me.lblStep_3.Name = "lblStep_3"
        Me.lblStep_3.Size = New System.Drawing.Size(93, 15)
        Me.lblStep_3.TabIndex = 0
        Me.lblStep_3.Text = "ตัวแทนฝ่ายบริหาร"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label64.Location = New System.Drawing.Point(10, 238)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(267, 15)
        Me.Label64.TabIndex = 1228
        Me.Label64.Text = "ความเห็นที่ไม่อนุมัติ ( Reason when not approved )"
        '
        'TxtQEMGRDATE
        '
        Me.TxtQEMGRDATE.BackColor = System.Drawing.SystemColors.Control
        Me.TxtQEMGRDATE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtQEMGRDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtQEMGRDATE.Location = New System.Drawing.Point(518, 206)
        Me.TxtQEMGRDATE.Multiline = True
        Me.TxtQEMGRDATE.Name = "TxtQEMGRDATE"
        Me.TxtQEMGRDATE.ReadOnly = True
        Me.TxtQEMGRDATE.Size = New System.Drawing.Size(73, 29)
        Me.TxtQEMGRDATE.TabIndex = 1227
        '
        'TxtQEMGRNAME
        '
        Me.TxtQEMGRNAME.BackColor = System.Drawing.SystemColors.Control
        Me.TxtQEMGRNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtQEMGRNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtQEMGRNAME.Location = New System.Drawing.Point(269, 206)
        Me.TxtQEMGRNAME.Multiline = True
        Me.TxtQEMGRNAME.Name = "TxtQEMGRNAME"
        Me.TxtQEMGRNAME.ReadOnly = True
        Me.TxtQEMGRNAME.Size = New System.Drawing.Size(247, 29)
        Me.TxtQEMGRNAME.TabIndex = 1226
        '
        'TxtQEMGRAPPROVE
        '
        Me.TxtQEMGRAPPROVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtQEMGRAPPROVE.FormattingEnabled = True
        Me.TxtQEMGRAPPROVE.ItemHeight = 23
        Me.TxtQEMGRAPPROVE.Items.AddRange(New Object() {"", "Pass", "Not Pass"})
        Me.TxtQEMGRAPPROVE.Location = New System.Drawing.Point(177, 205)
        Me.TxtQEMGRAPPROVE.Name = "TxtQEMGRAPPROVE"
        Me.TxtQEMGRAPPROVE.Size = New System.Drawing.Size(91, 29)
        Me.TxtQEMGRAPPROVE.TabIndex = 1225
        Me.TxtQEMGRAPPROVE.UseSelectable = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel12.Controls.Add(Me.lblStep_2)
        Me.Panel12.Location = New System.Drawing.Point(12, 205)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(164, 29)
        Me.Panel12.TabIndex = 1224
        '
        'lblStep_2
        '
        Me.lblStep_2.AutoSize = True
        Me.lblStep_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStep_2.ForeColor = System.Drawing.Color.White
        Me.lblStep_2.Location = New System.Drawing.Point(2, 7)
        Me.lblStep_2.Name = "lblStep_2"
        Me.lblStep_2.Size = New System.Drawing.Size(55, 15)
        Me.lblStep_2.TabIndex = 0
        Me.lblStep_2.Text = "SD Chief"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(267, 15)
        Me.Label12.TabIndex = 1223
        Me.Label12.Text = "ความเห็นที่ไม่อนุมัติ ( Reason when not approved )"
        '
        'TxtQEOFFICERREASON
        '
        Me.TxtQEOFFICERREASON.BackColor = System.Drawing.Color.White
        Me.TxtQEOFFICERREASON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQEOFFICERREASON.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQEOFFICERREASON.Location = New System.Drawing.Point(12, 117)
        Me.TxtQEOFFICERREASON.Multiline = True
        Me.TxtQEOFFICERREASON.Name = "TxtQEOFFICERREASON"
        Me.TxtQEOFFICERREASON.Size = New System.Drawing.Size(585, 78)
        Me.TxtQEOFFICERREASON.TabIndex = 1222
        '
        'TxtQEOFFICERDATE
        '
        Me.TxtQEOFFICERDATE.BackColor = System.Drawing.SystemColors.Control
        Me.TxtQEOFFICERDATE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtQEOFFICERDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtQEOFFICERDATE.Location = New System.Drawing.Point(521, 68)
        Me.TxtQEOFFICERDATE.Multiline = True
        Me.TxtQEOFFICERDATE.Name = "TxtQEOFFICERDATE"
        Me.TxtQEOFFICERDATE.ReadOnly = True
        Me.TxtQEOFFICERDATE.Size = New System.Drawing.Size(73, 29)
        Me.TxtQEOFFICERDATE.TabIndex = 1221
        '
        'TxtQEOFFICERNAME
        '
        Me.TxtQEOFFICERNAME.BackColor = System.Drawing.SystemColors.Control
        Me.TxtQEOFFICERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtQEOFFICERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtQEOFFICERNAME.Location = New System.Drawing.Point(272, 68)
        Me.TxtQEOFFICERNAME.Multiline = True
        Me.TxtQEOFFICERNAME.Name = "TxtQEOFFICERNAME"
        Me.TxtQEOFFICERNAME.ReadOnly = True
        Me.TxtQEOFFICERNAME.Size = New System.Drawing.Size(247, 29)
        Me.TxtQEOFFICERNAME.TabIndex = 1220
        '
        'TxtQEOFFICERAPPROVE
        '
        Me.TxtQEOFFICERAPPROVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtQEOFFICERAPPROVE.FormattingEnabled = True
        Me.TxtQEOFFICERAPPROVE.ItemHeight = 23
        Me.TxtQEOFFICERAPPROVE.Items.AddRange(New Object() {"", "Pass", "Not Pass"})
        Me.TxtQEOFFICERAPPROVE.Location = New System.Drawing.Point(180, 67)
        Me.TxtQEOFFICERAPPROVE.Name = "TxtQEOFFICERAPPROVE"
        Me.TxtQEOFFICERAPPROVE.Size = New System.Drawing.Size(91, 29)
        Me.TxtQEOFFICERAPPROVE.TabIndex = 1219
        Me.TxtQEOFFICERAPPROVE.UseSelectable = True
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel13.Controls.Add(Me.lblStep_1)
        Me.Panel13.Location = New System.Drawing.Point(15, 67)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(164, 29)
        Me.Panel13.TabIndex = 1218
        '
        'lblStep_1
        '
        Me.lblStep_1.AutoSize = True
        Me.lblStep_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStep_1.ForeColor = System.Drawing.Color.White
        Me.lblStep_1.Location = New System.Drawing.Point(3, 7)
        Me.lblStep_1.Name = "lblStep_1"
        Me.lblStep_1.Size = New System.Drawing.Size(112, 15)
        Me.lblStep_1.TabIndex = 0
        Me.lblStep_1.Text = "Document Control  "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.TxtDarNo)
        Me.Panel2.Controls.Add(Me.TxtREFNO)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtLINEDATA)
        Me.Panel2.Controls.Add(Me.MetroButton2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 51)
        Me.Panel2.TabIndex = 1132
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg7
        Me.PictureBox3.Location = New System.Drawing.Point(559, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1212
        Me.PictureBox3.TabStop = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label42.Location = New System.Drawing.Point(300, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(52, 15)
        Me.Label42.TabIndex = 1211
        Me.Label42.Text = "DarNo."
        '
        'TxtDarNo
        '
        Me.TxtDarNo.BackColor = System.Drawing.Color.Black
        Me.TxtDarNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDarNo.Font = New System.Drawing.Font("BrowalliaUPC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDarNo.ForeColor = System.Drawing.Color.Yellow
        Me.TxtDarNo.Location = New System.Drawing.Point(352, 14)
        Me.TxtDarNo.Multiline = True
        Me.TxtDarNo.Name = "TxtDarNo"
        Me.TxtDarNo.ReadOnly = True
        Me.TxtDarNo.Size = New System.Drawing.Size(98, 21)
        Me.TxtDarNo.TabIndex = 1210
        '
        'TxtREFNO
        '
        Me.TxtREFNO.BackColor = System.Drawing.Color.Black
        Me.TxtREFNO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtREFNO.Font = New System.Drawing.Font("BrowalliaUPC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtREFNO.ForeColor = System.Drawing.Color.Yellow
        Me.TxtREFNO.Location = New System.Drawing.Point(187, 14)
        Me.TxtREFNO.Multiline = True
        Me.TxtREFNO.Name = "TxtREFNO"
        Me.TxtREFNO.ReadOnly = True
        Me.TxtREFNO.Size = New System.Drawing.Size(115, 21)
        Me.TxtREFNO.TabIndex = 1209
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(136, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 1208
        Me.Label1.Text = "RefNo."
        '
        'TxtLINEDATA
        '
        Me.TxtLINEDATA.BackColor = System.Drawing.Color.Black
        Me.TxtLINEDATA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtLINEDATA.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLINEDATA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtLINEDATA.Location = New System.Drawing.Point(55, 15)
        Me.TxtLINEDATA.Multiline = True
        Me.TxtLINEDATA.Name = "TxtLINEDATA"
        Me.TxtLINEDATA.ReadOnly = True
        Me.TxtLINEDATA.Size = New System.Drawing.Size(26, 21)
        Me.TxtLINEDATA.TabIndex = 1207
        Me.TxtLINEDATA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.BackgroundImage = Global.DocumentSystem.My.Resources.Resources._374_512__Custom___2_2
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(8, 6)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(37, 38)
        Me.MetroButton2.TabIndex = 792
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        '
        'TxtDateNow
        '
        Me.TxtDateNow.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtDateNow.CustomFormat = "yyyy-MM-dd"
        Me.TxtDateNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtDateNow.Location = New System.Drawing.Point(468, 345)
        Me.TxtDateNow.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtDateNow.Name = "TxtDateNow"
        Me.TxtDateNow.Size = New System.Drawing.Size(33, 29)
        Me.TxtDateNow.TabIndex = 1201
        '
        'TxtREFNODATA
        '
        Me.TxtREFNODATA.BackColor = System.Drawing.Color.DimGray
        Me.TxtREFNODATA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtREFNODATA.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtREFNODATA.ForeColor = System.Drawing.Color.White
        Me.TxtREFNODATA.Location = New System.Drawing.Point(563, 6)
        Me.TxtREFNODATA.Multiline = True
        Me.TxtREFNODATA.Name = "TxtREFNODATA"
        Me.TxtREFNODATA.ReadOnly = True
        Me.TxtREFNODATA.Size = New System.Drawing.Size(18, 21)
        Me.TxtREFNODATA.TabIndex = 1206
        Me.TxtREFNODATA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.dgvEmailKM)
        Me.Panel1.Controls.Add(Me.MetroButton1)
        Me.Panel1.Controls.Add(Me.bntDelete)
        Me.Panel1.Controls.Add(Me.bntSave)
        Me.Panel1.Controls.Add(Me.TxtREFNODATA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 51)
        Me.Panel1.TabIndex = 1144
        '
        'dgvEmailKM
        '
        Me.dgvEmailKM.AllowUserToDeleteRows = False
        Me.dgvEmailKM.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvEmailKM.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmailKM.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmailKM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmailKM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmailKM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmailKM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmailKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmailKM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.KM_DOCNO, Me.KM_DOCNAME, Me.KM_REVNO, Me.KM_Mange, Me.KM_EFFDATE})
        Me.dgvEmailKM.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmailKM.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmailKM.EnableHeadersVisualStyles = False
        Me.dgvEmailKM.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvEmailKM.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmailKM.Location = New System.Drawing.Point(421, 9)
        Me.dgvEmailKM.MultiSelect = False
        Me.dgvEmailKM.Name = "dgvEmailKM"
        Me.dgvEmailKM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmailKM.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmailKM.RowHeadersVisible = False
        Me.dgvEmailKM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEmailKM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmailKM.Size = New System.Drawing.Size(69, 33)
        Me.dgvEmailKM.Style = MetroFramework.MetroColorStyle.Blue
        Me.dgvEmailKM.TabIndex = 1307
        Me.dgvEmailKM.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgvEmailKM.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'KM_DOCNO
        '
        Me.KM_DOCNO.HeaderText = "KM No."
        Me.KM_DOCNO.Name = "KM_DOCNO"
        Me.KM_DOCNO.ReadOnly = True
        '
        'KM_DOCNAME
        '
        Me.KM_DOCNAME.HeaderText = "KM Name"
        Me.KM_DOCNAME.Name = "KM_DOCNAME"
        Me.KM_DOCNAME.ReadOnly = True
        '
        'KM_REVNO
        '
        Me.KM_REVNO.HeaderText = "Rev.No"
        Me.KM_REVNO.Name = "KM_REVNO"
        Me.KM_REVNO.ReadOnly = True
        '
        'KM_Mange
        '
        Me.KM_Mange.HeaderText = "การจัดการเอกสาร"
        Me.KM_Mange.Name = "KM_Mange"
        Me.KM_Mange.ReadOnly = True
        '
        'KM_EFFDATE
        '
        Me.KM_EFFDATE.HeaderText = "วันที่บังคับใช้"
        Me.KM_EFFDATE.Name = "KM_EFFDATE"
        Me.KM_EFFDATE.ReadOnly = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.maintenance_icon__Custom___2_1
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(8, 6)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(37, 38)
        Me.MetroButton1.TabIndex = 1213
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        '
        'bntDelete
        '
        Me.bntDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntDelete.BackgroundImage = Global.DocumentSystem.My.Resources.Resources.delete_icon_image_152
        Me.bntDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntDelete.Enabled = False
        Me.bntDelete.Location = New System.Drawing.Point(553, 4)
        Me.bntDelete.Name = "bntDelete"
        Me.bntDelete.Size = New System.Drawing.Size(37, 38)
        Me.bntDelete.TabIndex = 1212
        Me.bntDelete.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntDelete.UseSelectable = True
        '
        'bntSave
        '
        Me.bntSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntSave.BackgroundImage = CType(resources.GetObject("bntSave.BackgroundImage"), System.Drawing.Image)
        Me.bntSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSave.Enabled = False
        Me.bntSave.Location = New System.Drawing.Point(510, 3)
        Me.bntSave.Name = "bntSave"
        Me.bntSave.Size = New System.Drawing.Size(37, 38)
        Me.bntSave.TabIndex = 3
        Me.bntSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntSave.UseSelectable = True
        '
        'FrmApproveDAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 541)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmApproveDAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmApproveDAR"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvEmailKM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents bntSave As MetroFramework.Controls.MetroButton
    Friend WithEvents TxtQEMGRREASON As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents TxtQEMRREASON As TextBox
    Friend WithEvents TxtQEMRDATE As TextBox
    Friend WithEvents TxtQEMRNAME As TextBox
    Friend WithEvents TxtQEMRAPPROVE As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblStep_3 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents TxtQEMGRDATE As TextBox
    Friend WithEvents TxtQEMGRNAME As TextBox
    Friend WithEvents TxtQEMGRAPPROVE As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lblStep_2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtQEOFFICERREASON As TextBox
    Friend WithEvents TxtQEOFFICERDATE As TextBox
    Friend WithEvents TxtQEOFFICERNAME As TextBox
    Friend WithEvents TxtQEOFFICERAPPROVE As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lblStep_1 As Label
    Friend WithEvents TxtDateNow As MetroFramework.Controls.MetroDateTime
    Friend WithEvents TxtREFNODATA As TextBox
    Friend WithEvents TxtLINEDATA As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents TxtDarNo As TextBox
    Friend WithEvents TxtREFNO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bntDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dgvEmailKM As MetroFramework.Controls.MetroGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents KM_DOCNO As DataGridViewTextBoxColumn
    Friend WithEvents KM_DOCNAME As DataGridViewTextBoxColumn
    Friend WithEvents KM_REVNO As DataGridViewTextBoxColumn
    Friend WithEvents KM_Mange As DataGridViewTextBoxColumn
    Friend WithEvents KM_EFFDATE As DataGridViewTextBoxColumn
End Class
