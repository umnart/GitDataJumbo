<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraningReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraningReport))
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDOCTYPE = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtDOCDEPT = New MetroFramework.Controls.MetroComboBox()
        Me.bntPrinting = New MetroFramework.Controls.MetroButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel51 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtDOCNO = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        'Panel_Head
        '
        Me.Panel_Head.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(Me.Panel3)
        Me.Panel_Head.Controls.Add(Me.TxtDOCTYPE)
        Me.Panel_Head.Controls.Add(Me.Label5)
        Me.Panel_Head.Controls.Add(Me.PictureBox3)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(796, 43)
        Me.Panel_Head.TabIndex = 1400
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DocumentSystem.My.Resources.Resources.Report
        Me.PictureBox2.Location = New System.Drawing.Point(10, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(266, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(116, 29)
        Me.Panel3.TabIndex = 1161
        Me.Panel3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ประเภทเอกสาร"
        '
        'TxtDOCTYPE
        '
        Me.TxtDOCTYPE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCTYPE.FormattingEnabled = True
        Me.TxtDOCTYPE.ItemHeight = 23
        Me.TxtDOCTYPE.Items.AddRange(New Object() {"MANUAL", "PROCEDURE", "WORK INSTRUCTION", "STANDARD DOCUMENT", "RECORD", "KM", "Organization Chart", "Job Description"})
        Me.TxtDOCTYPE.Location = New System.Drawing.Point(383, 8)
        Me.TxtDOCTYPE.Name = "TxtDOCTYPE"
        Me.TxtDOCTYPE.Size = New System.Drawing.Size(248, 29)
        Me.TxtDOCTYPE.TabIndex = 1156
        Me.TxtDOCTYPE.UseSelectable = True
        Me.TxtDOCTYPE.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(49, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Training Course Report"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.DocumentSystem.My.Resources.Resources.Close
        Me.PictureBox3.Location = New System.Drawing.Point(757, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.TxtDOCDEPT)
        Me.Panel2.Controls.Add(Me.bntPrinting)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel51)
        Me.Panel2.Controls.Add(Me.TxtDOCNO)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 47)
        Me.Panel2.TabIndex = 1401
        '
        'TxtDOCDEPT
        '
        Me.TxtDOCDEPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDOCDEPT.FormattingEnabled = True
        Me.TxtDOCDEPT.ItemHeight = 23
        Me.TxtDOCDEPT.Items.AddRange(New Object() {"AC", "BU", "DC", "EN", "GA", "HR", "IT", "IV", "LB", "MK", "MR", "PD", "PR", "QA", "RD", "SD", "SF", "WS"})
        Me.TxtDOCDEPT.Location = New System.Drawing.Point(455, 9)
        Me.TxtDOCDEPT.Name = "TxtDOCDEPT"
        Me.TxtDOCDEPT.Size = New System.Drawing.Size(130, 29)
        Me.TxtDOCDEPT.TabIndex = 1158
        Me.TxtDOCDEPT.UseSelectable = True
        '
        'bntPrinting
        '
        Me.bntPrinting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntPrinting.BackgroundImage = CType(resources.GetObject("bntPrinting.BackgroundImage"), System.Drawing.Image)
        Me.bntPrinting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntPrinting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntPrinting.Location = New System.Drawing.Point(591, 3)
        Me.bntPrinting.Name = "bntPrinting"
        Me.bntPrinting.Size = New System.Drawing.Size(37, 38)
        Me.bntPrinting.TabIndex = 9
        Me.bntPrinting.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bntPrinting.UseSelectable = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(12, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(116, 29)
        Me.Panel4.TabIndex = 1159
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "เอกสารเลขที่ Doc.No"
        '
        'Panel51
        '
        Me.Panel51.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel51.Controls.Add(Me.Label14)
        Me.Panel51.Location = New System.Drawing.Point(338, 9)
        Me.Panel51.Name = "Panel51"
        Me.Panel51.Size = New System.Drawing.Size(116, 29)
        Me.Panel51.TabIndex = 1160
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
        'TxtDOCNO
        '
        Me.TxtDOCNO.BackColor = System.Drawing.Color.White
        Me.TxtDOCNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDOCNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDOCNO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOCNO.Location = New System.Drawing.Point(129, 9)
        Me.TxtDOCNO.Name = "TxtDOCNO"
        Me.TxtDOCNO.Size = New System.Drawing.Size(205, 29)
        Me.TxtDOCNO.TabIndex = 1157
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 90)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(796, 518)
        Me.ReportViewer1.TabIndex = 1402
        '
        'FrmTraningReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 608)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraningReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTraningReport"
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel51.ResumeLayout(False)
        Me.Panel51.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Head As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bntPrinting As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDOCTYPE As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TxtDOCDEPT As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel51 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtDOCNO As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
