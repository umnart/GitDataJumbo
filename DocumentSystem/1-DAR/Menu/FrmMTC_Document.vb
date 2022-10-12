Public Class FrmMTC_Document
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        'FrmDocumentSystem_Find.TopLevel = False
        'FrmDocumentSystem_Find.TopMost = True
        'FrmSubMenu.SplitContainer1.Panel2.Controls.Add(FrmDocumentSystem_Find)
        'FrmDocumentSystem_Find.Show()

        ' FrmDocumentSystem_Find.TopLevel = False
        'FrmDocumentSystem_Find.TopMost = True
        ' FrmSubMenu.SplitContainer1.Panel2.Controls.Add(FrmDocumentSystem_Find)

        FrmUpdateDataFromSA.Close()
        FrmUpdateDataFromSA.ShowDialog()


    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click

        FrmQEa_DocSys_SndDoc.Close()
        FrmQEa_DocSys_SndDoc.ShowDialog()


    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        FrmTranferTainAssign.Close()
        FrmTranferTainAssign.ShowDialog()
    End Sub

    Private Sub MetroTile7_Click(sender As Object, e As EventArgs) Handles MetroTile7.Click

    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        FrmTranferTraining_History.Close()
        FrmTranferTraining_History.ShowDialog()
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        FrmEditDARNO.Close()
        FrmEditDARNO.ShowDialog()
    End Sub

    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click
        FrmUpCourseMasterExcel.Close()
        FrmUpCourseMasterExcel.ShowDialog()
    End Sub

    Private Sub FrmMTC_Document_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bntQEApprove_Click(sender As Object, e As EventArgs) Handles bntQEApprove.Click
        strDeptData = TxtDOCDEPT.Text
    End Sub
End Class