<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraining_History_TP
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
        Me.Panel_Head = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bntFind = New System.Windows.Forms.PictureBox()
        Me.TxtShowData = New MetroFramework.Controls.MetroComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Me.Panel_Head.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        Me.Panel_Head.Controls.Add(Me.PictureBox2)
        Me.Panel_Head.Controls.Add(IDLabel)
        Me.Panel_Head.Controls.Add(Me.Label5)
        Me.Panel_Head.Controls.Add(Me.PictureBox3)
        Me.Panel_Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Head.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Head.Name = "Panel_Head"
        Me.Panel_Head.Size = New System.Drawing.Size(1091, 43)
        Me.Panel_Head.TabIndex = 1401
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DocumentSystem.My.Resources.Resources.imagesEHZ7Y6RZ__Custom_1
        Me.PictureBox2.Location = New System.Drawing.Point(9, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(52, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "แบบบันทึกประวัติการฝึกอบรม"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.DocumentSystem.My.Resources.Resources._11954453151817762013molumen_red_square_error_warning_icon_svg5
        Me.PictureBox3.Location = New System.Drawing.Point(1052, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 84)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1091, 566)
        Me.ReportViewer1.TabIndex = 1403
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.bntFind)
        Me.Panel2.Controls.Add(Me.TxtShowData)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 42)
        Me.Panel2.TabIndex = 1405
        '
        'bntFind
        '
        Me.bntFind.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntFind.Location = New System.Drawing.Point(405, 7)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(33, 29)
        Me.bntFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntFind.TabIndex = 1386
        Me.bntFind.TabStop = False
        '
        'TxtShowData
        '
        Me.TxtShowData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtShowData.FormattingEnabled = True
        Me.TxtShowData.ItemHeight = 23
        Me.TxtShowData.Items.AddRange(New Object() {"Show All RevNo.", "Last RevNo."})
        Me.TxtShowData.Location = New System.Drawing.Point(247, 7)
        Me.TxtShowData.Name = "TxtShowData"
        Me.TxtShowData.Size = New System.Drawing.Size(152, 29)
        Me.TxtShowData.TabIndex = 1385
        Me.TxtShowData.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(55, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(189, 28)
        Me.Panel3.TabIndex = 1384
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sow all Revison / Last Revision"
        '
        'FrmTraining_History_TP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 650)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTraining_History_TP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTraining_History_TP"
        Me.Panel_Head.ResumeLayout(False)
        Me.Panel_Head.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Head As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtShowData As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents bntFind As PictureBox
End Class
