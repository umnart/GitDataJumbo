<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdvFinder
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
        Me.bntFind = New System.Windows.Forms.PictureBox()
        Me.TxtAttFile_1 = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'bntFind
        '
        Me.bntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntFind.Image = Global.DocumentSystem.My.Resources.Resources.search_icon
        Me.bntFind.Location = New System.Drawing.Point(380, 27)
        Me.bntFind.Name = "bntFind"
        Me.bntFind.Size = New System.Drawing.Size(33, 29)
        Me.bntFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntFind.TabIndex = 1415
        Me.bntFind.TabStop = False
        '
        'TxtAttFile_1
        '
        Me.TxtAttFile_1.BackColor = System.Drawing.Color.White
        Me.TxtAttFile_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAttFile_1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAttFile_1.Location = New System.Drawing.Point(159, 27)
        Me.TxtAttFile_1.Multiline = True
        Me.TxtAttFile_1.Name = "TxtAttFile_1"
        Me.TxtAttFile_1.Size = New System.Drawing.Size(215, 29)
        Me.TxtAttFile_1.TabIndex = 1414
        Me.TxtAttFile_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel14.Controls.Add(Me.Label16)
        Me.Panel14.Location = New System.Drawing.Point(12, 27)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(145, 29)
        Me.Panel14.TabIndex = 1413
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(3, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "เลขที่เอกสารที่ต้องการค้นหา"
        '
        'FrmAdvFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 82)
        Me.Controls.Add(Me.bntFind)
        Me.Controls.Add(Me.TxtAttFile_1)
        Me.Controls.Add(Me.Panel14)
        Me.Name = "FrmAdvFinder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAdvFinder"
        CType(Me.bntFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bntFind As PictureBox
    Friend WithEvents TxtAttFile_1 As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label16 As Label
End Class
