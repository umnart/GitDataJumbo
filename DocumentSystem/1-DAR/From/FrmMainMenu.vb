Imports System.Windows.Forms
Imports System.DirectoryServices
Imports System.Net.Mime
Imports System.Deployment.Application
Public Class FrmMainMenu

    Private m_ChildFormNumber As Integer
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()
        Dim C As Control

        PictureBox6.Focus()

        For Each C In Me.Controls
            If TypeOf C Is MdiClient Then
                C.BackColor = Color.White
                Exit For
            End If
        Next

        C = Nothing

        Dim myBuildInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)

        Me.WindowState = FormWindowState.Normal
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        Me.Bounds = Screen.GetWorkingArea(Me)

        grpSetting.Visible = False
        GroupBoxTraining.Visible = False

        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False

        FrmLogon.ShowDialog()



        If strDeptData = "SD" Then

            Button1.Enabled = True
            bntEmail.Enabled = True
            bntCourseMaster.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            bntUserLogOn.Enabled = True
            bntTraningPerson.Enabled = True


            If strDeptData = "HRGA" Or strDeptData = "HR" Then
                bntTraningPerson.Enabled = True
            End If

        Else


                Button1.Enabled = True
            bntEmail.Enabled = False
                bntCourseMaster.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                bntUserLogOn.Enabled = False
            bntTraningPerson.Enabled = True

            If strDeptData = "GA" Or strDeptData = "HRGA" Then
                bntEmail.Enabled = True
                bntTraningPerson.Enabled = True
            End If




        End If




        'Button4.Enabled = False
        'bntRepliedCarStatus.Enabled = False
        'Button5.Enabled = False
        'Button3.Enabled = False
        'bnt.Enabled = False


        If strDeptData = "SD" Or strDeptData = "LB" Then
            'Button4.Enabled = True
            'bntRepliedCarStatus.Enabled = True
            'Button5.Enabled = True
            'Button3.Enabled = True
            'bnt.Enabled = True

            ReTraning.Visible = True
        End If

        If strDeptData = "IT" Or strDeptData = "SD" Then
            Button10.Visible = True
            bntCourseMaster.Enabled = True
            bntTraningPerson.Enabled = True
        Else
            Button10.Visible = False
            bntCourseMaster.Enabled = True
            bntTraningPerson.Enabled = True
        End If


        bntCourseMaster.Enabled = True

        grpSetting.Visible = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False
    End Sub


    Sub chkEnabled()

        If strDeptData = "SD" Then

            Button1.Enabled = True
            bntEmail.Enabled = True
            bntCourseMaster.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            bntUserLogOn.Enabled = True
            bntTraningPerson.Enabled = True
        Else


            Button1.Enabled = True
            bntEmail.Enabled = False
            bntCourseMaster.Enabled = True
            Button3.Enabled = False
            Button4.Enabled = False
            bntUserLogOn.Enabled = False
            bntTraningPerson.Enabled = True
            bntEmail.Enabled = True
            If strDeptData = "GA" Or strDeptData = "HRGA" Then
                bntEmail.Enabled = True
            End If




        End If



        If strDeptData = "IT" Or strDeptData = "SD" Or strDeptData = "PD" Or strDeptData = "QA" Then
            Button10.Visible = True
            bntCourseMaster.Enabled = True
        Else
            Button10.Visible = False

        End If



    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub bntReceive_Click(sender As Object, e As EventArgs) Handles bntReceive.Click
        grpSetting.Visible = True
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False

        'PictureBox2.Enabled = False
        ' strFormShowGrid = "Receive"
        Call chkEnabled()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmDocumentSystem_Find.MdiParent = Me
        FrmDocumentSystem_Find.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub bntUserLogOn_Click(sender As Object, e As EventArgs) Handles bntUserLogOn.Click
        FrmUserLogOn.MdiParent = Me
        FrmUserLogOn.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False

    End Sub

    Private Sub bntCourseMaster_Click(sender As Object, e As EventArgs) Handles bntCourseMaster.Click

        FrmCourseMaster.MdiParent = Me
        FrmCourseMaster.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmToDept.MdiParent = Me
        FrmToDept.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmSendDocToDept.MdiParent = Me
        FrmSendDocToDept.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub bntEmail_Click(sender As Object, e As EventArgs) Handles bntEmail.Click
        FrmDocSys_RcRt.MdiParent = Me
        FrmDocSys_RcRt.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub bntReceiveName_Click(sender As Object, e As EventArgs) Handles bntReceiveName.Click
        FrmDocSys_RcRt_Receive.Close()
        FrmDocSys_RcRt_Receive.MdiParent = Me
        FrmDocSys_RcRt_Receive.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub bntMasterList_Click(sender As Object, e As EventArgs) Handles bntMasterList.Click
        FrmMasterLIst.Close()
        FrmMasterLIst.MdiParent = Me
        FrmMasterLIst.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmKMMasterList.Close()
        FrmKMMasterList.MdiParent = Me
        FrmKMMasterList.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False


    End Sub

    Private Sub GroupBoxTraining_Enter(sender As Object, e As EventArgs) Handles GroupBoxTraining.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        grpSetting.Visible = False
        GroupBoxTraining.Visible = True
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False

    End Sub

    Private Sub bntTraningPerson_Click(sender As Object, e As EventArgs) Handles bntTraningPerson.Click
        FrmTraining_Person.Close()
        FrmTraining_Person.MdiParent = Me
        FrmTraining_Person.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmTraining_CrseSet.Close()
        FrmTraining_CrseSet.MdiParent = Me
        FrmTraining_CrseSet.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub bntTraining_Assign_Click(sender As Object, e As EventArgs) Handles bntTraining_Assign.Click
        strFormAssign = "Assign"
        FrmTraining_Assign.Close()
        FrmTraining_Assign.MdiParent = Me
        FrmTraining_Assign.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False

        GroupBoxTraining.Visible = False
    End Sub

    Private Sub bntHistory_Click(sender As Object, e As EventArgs) Handles bntHistory.Click
        FrmTraining_History.Close()
        FrmTraining_History.MdiParent = Me
        FrmTraining_History.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub bntChkTraining_Click(sender As Object, e As EventArgs) Handles bntChkTraining.Click
        FrmTraining_History_Check.Close()
        FrmTraining_History_Check.MdiParent = Me
        FrmTraining_History_Check.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub ReTraning_Click(sender As Object, e As EventArgs) Handles ReTraning.Click
        grpSetting.Visible = False        'PictureBox2.Enabled = False
        '  GroupBoxTraining.Visible = False
        GrpRetraing.Visible = True

    End Sub

    Private Sub bntTrainingReport_Click(sender As Object, e As EventArgs) Handles bntTrainingReport.Click
        FrmTraningReport.Close()
        FrmTraningReport.MdiParent = Me
        FrmTraningReport.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        '   Panel1.Width = 38

        grpSetting.Visible = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        FrmTraining_History_Retraining.Close()
        FrmTraining_History_Retraining.MdiParent = Me
        FrmTraining_History_Retraining.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        strFormAssign = "Retraining"
        FrmTraining_Assign_ReTraining.Close()
        FrmTraining_Assign_ReTraining.MdiParent = Me
        FrmTraining_Assign_ReTraining.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        grpSettingPerson.Visible = True
        grpSetting.Visible = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        If strDeptData = "IT" Or strDeptData = "SD" Then
            Button10.Visible = True
        Else
            Button10.Visible = True
        End If


    End Sub

    Private Sub bntUpdateMaster_Click(sender As Object, e As EventArgs) 
        FrmUpdateDataFromSA.MdiParent = Me
        FrmUpdateDataFromSA.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'FrmUserLogOn.MdiParent = Me
        'FrmUserLogOn.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False

        FrmMTC_Document.Close()
        FrmMTC_Document.ShowDialog()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        grpSetting.Visible = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        grpSetting.Visible = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub grpSettingPerson_Enter(sender As Object, e As EventArgs) Handles grpSettingPerson.Enter

    End Sub

    Private Sub txtWelcom_Click(sender As Object, e As EventArgs) Handles txtWelcom.Click
        FrmKMViewData.Close()
        FrmKMViewData.MdiParent = Me
        FrmKMViewData.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
        grpSettingPerson.Visible = False
    End Sub

    Private Sub bntChange_Click(sender As Object, e As EventArgs) Handles bntChange.Click
        FrmTraining_Check_Retraining.Close()
        FrmTraining_Check_Retraining.MdiParent = Me
        FrmTraining_Check_Retraining.Show()
        grpSetting.Visible = False
        PictureBox2.Enabled = False
        GroupBoxTraining.Visible = False
        GrpRetraing.Visible = False
    End Sub
End Class
