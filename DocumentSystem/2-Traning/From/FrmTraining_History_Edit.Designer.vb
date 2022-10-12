<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTraining_History_Edit
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim CNRBGNBRLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraining_History_Edit))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bntChangeStartDate = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDOCDEPT = New System.Windows.Forms.TextBox()
        Me.TxtRemark = New System.Windows.Forms.TextBox()
        Me.TxtTrnnDate = New MetroFramework.Controls.MetroDateTime()
        Me.TxtResult = New System.Windows.Forms.CheckBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApprove = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtEFFDATE = New System.Windows.Forms.Label()
        Me.TxtREVNO = New System.Windows.Forms.Label()
        Me.TxtDOCNAME = New System.Windows.Forms.Label()
        Me.TxtDOCNO = New System.Windows.Forms.Label()
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.TxtRetrainFreq = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel52 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.bntSave = New System.Windows.Forms.ToolStripButton()
        Me.bntDelete = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CNRBGNBRLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel52.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label1.Location = New System.Drawing.Point(496, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(99, 16)
        Label1.TabIndex = 1405
        Label1.Text = "Revision Date :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label5.Location = New System.Drawing.Point(307, 15)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(88, 16)
        Label5.TabIndex = 1403
        Label5.Text = "Revision No :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label3.Location = New System.Drawing.Point(81, 38)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(51, 16)
        Label3.TabIndex = 1401
        Label3.Text = "ชื่อเรื่อง  :"
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
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(1021, 9)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 66
        IDLabel.Text = "ID:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.bntChangeStartDate)
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.TxtDOCDEPT)
        Me.Panel3.Controls.Add(Me.TxtRemark)
        Me.Panel3.Controls.Add(Me.TxtTrnnDate)
        Me.Panel3.Controls.Add(Me.TxtResult)
        Me.Panel3.Controls.Add(Me.Panel12)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.TxtApprove)
        Me.Panel3.Location = New System.Drawing.Point(0, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(707, 134)
        Me.Panel3.TabIndex = 1377
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(523, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(116, 29)
        Me.Panel1.TabIndex = 1376
        Me.Panel1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เอกสารของฝ่าย Dept"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "แก้ไขครั้งที่ Rev."
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
        Me.bntChangeStartDate.Image = Global.DocumentSystem.My.Resources.Resources.fsvxlzqocyhmrblzvehl__Custom_
        Me.bntChangeStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntChangeStartDate.Location = New System.Drawing.Point(238, 4)
        Me.bntChangeStartDate.Name = "bntChangeStartDate"
        Me.bntChangeStartDate.Size = New System.Drawing.Size(201, 29)
        Me.bntChangeStartDate.TabIndex = 1388
        Me.bntChangeStartDate.Text = "            เปลี่ยนแปลงวันที่ = วันบังคับใช้"
        Me.bntChangeStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntChangeStartDate.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Location = New System.Drawing.Point(8, 92)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(110, 26)
        Me.Panel11.TabIndex = 1387
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Remark"
        '
        'TxtDOCDEPT
        '
        Me.TxtDOCDEPT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDOCDEPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDOCDEPT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOCDEPT.Location = New System.Drawing.Point(641, 59)
        Me.TxtDOCDEPT.Multiline = True
        Me.TxtDOCDEPT.Name = "TxtDOCDEPT"
        Me.TxtDOCDEPT.ReadOnly = True
        Me.TxtDOCDEPT.Size = New System.Drawing.Size(57, 29)
        Me.TxtDOCDEPT.TabIndex = 1376
        Me.TxtDOCDEPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDOCDEPT.Visible = False
        '
        'TxtRemark
        '
        Me.TxtRemark.BackColor = System.Drawing.Color.White
        Me.TxtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRemark.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemark.Location = New System.Drawing.Point(119, 93)
        Me.TxtRemark.Name = "TxtRemark"
        Me.TxtRemark.Size = New System.Drawing.Size(534, 25)
        Me.TxtRemark.TabIndex = 1386
        '
        'TxtTrnnDate
        '
        Me.TxtTrnnDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtTrnnDate.CustomFormat = "dd/MM/yyyy"
        Me.TxtTrnnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtTrnnDate.Location = New System.Drawing.Point(120, 3)
        Me.TxtTrnnDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TxtTrnnDate.Name = "TxtTrnnDate"
        Me.TxtTrnnDate.Size = New System.Drawing.Size(115, 29)
        Me.TxtTrnnDate.TabIndex = 1384
        '
        'TxtResult
        '
        Me.TxtResult.AutoSize = True
        Me.TxtResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtResult.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.TxtResult.Location = New System.Drawing.Point(115, 38)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(103, 17)
        Me.TxtResult.TabIndex = 1369
        Me.TxtResult.Text = "Pass / Not Pass"
        Me.TxtResult.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel12.Controls.Add(Me.Label9)
        Me.Panel12.Location = New System.Drawing.Point(9, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(110, 29)
        Me.Panel12.TabIndex = 1385
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Training Date"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Location = New System.Drawing.Point(9, 61)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(110, 25)
        Me.Panel9.TabIndex = 1368
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Approve"
        '
        'TxtApprove
        '
        Me.TxtApprove.BackColor = System.Drawing.Color.White
        Me.TxtApprove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApprove.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApprove.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApprove.Location = New System.Drawing.Point(120, 61)
        Me.TxtApprove.Name = "TxtApprove"
        Me.TxtApprove.Size = New System.Drawing.Size(264, 25)
        Me.TxtApprove.TabIndex = 1367
        Me.TxtApprove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.TxtEFFDATE)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Me.TxtREVNO)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.TxtDOCNAME)
        Me.Panel2.Controls.Add(CNRBGNBRLabel)
        Me.Panel2.Controls.Add(Me.TxtDOCNO)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(710, 70)
        Me.Panel2.TabIndex = 1404
        '
        'TxtEFFDATE
        '
        Me.TxtEFFDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtEFFDATE.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtEFFDATE.Location = New System.Drawing.Point(592, 15)
        Me.TxtEFFDATE.Name = "TxtEFFDATE"
        Me.TxtEFFDATE.Size = New System.Drawing.Size(93, 23)
        Me.TxtEFFDATE.TabIndex = 1406
        Me.TxtEFFDATE.Text = "--"
        '
        'TxtREVNO
        '
        Me.TxtREVNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtREVNO.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtREVNO.Location = New System.Drawing.Point(403, 15)
        Me.TxtREVNO.Name = "TxtREVNO"
        Me.TxtREVNO.Size = New System.Drawing.Size(58, 23)
        Me.TxtREVNO.TabIndex = 1404
        Me.TxtREVNO.Text = "--"
        '
        'TxtDOCNAME
        '
        Me.TxtDOCNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtDOCNAME.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtDOCNAME.Location = New System.Drawing.Point(138, 38)
        Me.TxtDOCNAME.Name = "TxtDOCNAME"
        Me.TxtDOCNAME.Size = New System.Drawing.Size(528, 23)
        Me.TxtDOCNAME.TabIndex = 1402
        Me.TxtDOCNAME.Text = "--"
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
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(Me.TxtRetrainFreq)
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(Me.Label11)
        Me.Panel_Head.Controls.Add(Me.Panel52)
        Me.Panel_Head.Controls.Add(Me.PictureBox3)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(710, 43)
        Me.Panel_Head.TabIndex = 1403
        '
        'TxtRetrainFreq
        '
        Me.TxtRetrainFreq.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtRetrainFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRetrainFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRetrainFreq.ForeColor = System.Drawing.Color.Red
        Me.TxtRetrainFreq.Location = New System.Drawing.Point(596, 8)
        Me.TxtRetrainFreq.Name = "TxtRetrainFreq"
        Me.TxtRetrainFreq.ReadOnly = True
        Me.TxtRetrainFreq.Size = New System.Drawing.Size(57, 29)
        Me.TxtRetrainFreq.TabIndex = 1389
        Me.TxtRetrainFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label11.Size = New System.Drawing.Size(137, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Training Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel52
        '
        Me.Panel52.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel52.Controls.Add(Me.Label14)
        Me.Panel52.Controls.Add(Me.Label55)
        Me.Panel52.Location = New System.Drawing.Point(469, 8)
        Me.Panel52.Name = "Panel52"
        Me.Panel52.Size = New System.Drawing.Size(126, 29)
        Me.Panel52.TabIndex = 1375
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 15)
        Me.Label14.TabIndex = 1
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label55.Location = New System.Drawing.Point(3, 7)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(114, 15)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "Retraing Frequency"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg6
        Me.PictureBox3.Location = New System.Drawing.Point(670, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Gray
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bntSave, Me.bntDelete})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 255)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(710, 47)
        Me.ToolStrip3.TabIndex = 1405
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
        'bntDelete
        '
        Me.bntDelete.ForeColor = System.Drawing.Color.White
        Me.bntDelete.Image = Global.DocumentSystem.My.Resources.Resources.delete_icon_image_15_jpg
        Me.bntDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntDelete.Name = "bntDelete"
        Me.bntDelete.Size = New System.Drawing.Size(84, 44)
        Me.bntDelete.Text = "Delete"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.DocumentSystem.My.Resources.Resources.fsvxlzqocyhmrblzvehl__Custom_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(445, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 29)
        Me.Button1.TabIndex = 1389
        Me.Button1.Text = "            เปลี่ยนแปลงวันที่ = วันเริ่มปฏิบัติงาน"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmTraining_History_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 302)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_History_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTraining_History_Edit"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel52.ResumeLayout(False)
        Me.Panel52.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtResult As CheckBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApprove As TextBox
    Friend WithEvents TxtTrnnDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRemark As TextBox
    Friend WithEvents bntChangeStartDate As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtEFFDATE As Label
    Friend WithEvents TxtREVNO As Label
    Friend WithEvents TxtDOCNAME As Label
    Friend WithEvents TxtDOCNO As Label
    Friend WithEvents Panel_Head As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TxtDOCDEPT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel52 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents bntSave As ToolStripButton
    Friend WithEvents bntDelete As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRetrainFreq As TextBox
    Friend WithEvents Button1 As Button
End Class
