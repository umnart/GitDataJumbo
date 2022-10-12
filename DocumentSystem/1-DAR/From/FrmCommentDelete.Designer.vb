<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCommentDelete
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
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtRetReaSon1 = New System.Windows.Forms.TextBox()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel12.Controls.Add(Me.Label29)
        Me.Panel12.Location = New System.Drawing.Point(12, 12)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(277, 29)
        Me.Panel12.TabIndex = 1155
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 7)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(213, 15)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "เหตุผลส่งคืน / เหตุผลการลบ DAR Number"
        '
        'TxtRetReaSon1
        '
        Me.TxtRetReaSon1.BackColor = System.Drawing.Color.White
        Me.TxtRetReaSon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRetReaSon1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRetReaSon1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRetReaSon1.Location = New System.Drawing.Point(12, 47)
        Me.TxtRetReaSon1.Multiline = True
        Me.TxtRetReaSon1.Name = "TxtRetReaSon1"
        Me.TxtRetReaSon1.Size = New System.Drawing.Size(277, 60)
        Me.TxtRetReaSon1.TabIndex = 1154
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.FlatAppearance.BorderSize = 0
        Me.cmdLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.cmdLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdLogin.ForeColor = System.Drawing.Color.White
        Me.cmdLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogin.Location = New System.Drawing.Point(12, 111)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(120, 41)
        Me.cmdLogin.TabIndex = 1156
        Me.cmdLogin.Text = "ยืนยันการลบ"
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(169, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 41)
        Me.Button1.TabIndex = 1157
        Me.Button1.Text = "ยกเลิกการลบ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmCommentDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 161)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.TxtRetReaSon1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCommentDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCommentDelete"
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents TxtRetReaSon1 As TextBox
    Friend WithEvents cmdLogin As Button
    Friend WithEvents Button1 As Button
End Class
