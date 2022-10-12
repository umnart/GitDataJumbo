Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Net.Mail
Public Class FrmApproveDAR
    Public EditNo As String
    Private intSelectedRow As Integer
    Private rowIndex As Integer
    Dim strChekGrid As String

    Dim strStatus As String = ""
    Dim strTxtAppMgrEmail As String = ""
    Dim strTxtAppMREmail As String = ""
    Private Sub bntDelete_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TxtQEOFFICERAPPROVE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtQEOFFICERAPPROVE.SelectedIndexChanged
        If TxtQEOFFICERAPPROVE.Text = "" Then
            TxtQEOFFICERNAME.Text = ""
            TxtQEOFFICERDATE.Text = ""
        Else
            TxtQEOFFICERNAME.Text = StrUserName
            TxtQEOFFICERDATE.Text = TxtDateNow.Text
        End If



        If TxtQEOFFICERAPPROVE.Text = "Not Pass" Then

            TxtQEMGRAPPROVE.Enabled = False
            TxtQEMGRREASON.Enabled = False

            TxtQEMRAPPROVE.Enabled = False
            TxtQEMRREASON.Enabled = False

        ElseIf TxtQEOFFICERAPPROVE.Text = "Pass" Then
            If strApprove = "Manager" Or strApprove = "MR" Or strApprove = "Assistant manager" Or strApprove = "SF Chief" Or strApprove = "SD Chief" Then
                TxtQEMGRAPPROVE.Enabled = True
                TxtQEMGRREASON.Enabled = True

                TxtQEMRAPPROVE.Enabled = True
                TxtQEMRREASON.Enabled = True
            End If

        End If

            If strSELECTSYSTEMForm = "DS" Then
            ' If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then


            Select Case CommandTypeApprove
                Case = "Addnew"

                    If TxtDarNo.Text <> "" Then
                        Exit Sub
                    End If
                    If TxtQEOFFICERAPPROVE.Text = "Pass" Then

                        Dim Sms As String = "คุณต้องการ RunDAR Number ใช่หรือไม่ ?"
                        If MsgBox(Sms, MsgBoxStyle.YesNo, "DAR") = MsgBoxResult.No Then Exit Sub

                        Call RunningRefNo()
                        If TxtDarNo.Text = "" Then
                            TxtQEOFFICERAPPROVE.Enabled = True
                        Else
                            TxtQEOFFICERAPPROVE.Enabled = False
                        End If


                    End If

                    'If TxtQEOFFICERAPPROVE.Text = "Pass" Then
                    '    TxtQEOFFICERAPPROVE.Enabled = False
                    'Else TxtQEOFFICERAPPROVE.Text = "Not Pass"
                    '    TxtQEOFFICERAPPROVE.Enabled = True
                    '    'TxtQEOFFICERNAME.Text = ""
                    '    'TxtQEOFFICERDATE.Text = ""
                    '    'TxtQEOFFICERAPPROVE.Text = ""

                    'End If
            End Select

        Else

        End If




    End Sub



    Private Sub TxtQEMGRAPPROVE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtQEMGRAPPROVE.SelectedIndexChanged
        If TxtQEOFFICERAPPROVE.Text = "Not Pass" Then
            TxtQEMGRAPPROVE.Enabled = False
            TxtQEMGRREASON.Enabled = False
            Exit Sub
        Else
            TxtQEMGRAPPROVE.Enabled = True
            TxtQEMGRREASON.Enabled = True
        End If

        If TxtQEMGRAPPROVE.Text = "" Then
            TxtQEMGRNAME.Text = ""
            TxtQEMGRDATE.Text = ""

        Else
            TxtQEMGRNAME.Text = StrUserName
            TxtQEMGRDATE.Text = TxtDateNow.Text
        End If
    End Sub

    Private Sub TxtQEMRAPPROVE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtQEMRAPPROVE.SelectedIndexChanged

        If TxtQEMGRAPPROVE.Text = "Not Pass" Then
            TxtQEMRAPPROVE.Enabled = False
            TxtQEMRREASON.Enabled = False

            Exit Sub
        Else
            TxtQEMRAPPROVE.Enabled = True
            TxtQEMRREASON.Enabled = True
        End If



        If TxtQEMRAPPROVE.Text = "" Then
            TxtQEMRNAME.Text = ""
            TxtQEMRDATE.Text = ""
        Else
            TxtQEMRNAME.Text = StrUserName
            TxtQEMRDATE.Text = TxtDateNow.Text
        End If
    End Sub
    Sub CheckAttFile()

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click

        If TxtQEOFFICERAPPROVE.Text = "" Then
            MsgBox("ลงข้อมูลให้ครบด้วย")
            TxtQEOFFICERAPPROVE.Focus()
            Exit Sub
        End If

        If strSELECTSYSTEM = "DP" Then
            Try


                Dim command As New SqlCommand("SELECT  * FROM QEa_AttFile " &
                                   "WHERE DOCNO  ='" & FrmDocumentSystem.TxtDOCNO.Text & "'" &
                                   "And REFNO ='" & TxtREFNO.Text & "'", DB_CMD.ObjConn)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                Dim ds As New DataSet
                adapter.Fill(table)

                If table.Rows.Count > 0 Then


                    If IsDBNull(table.Rows(0).Item("AttFile3").ToString) Or table.Rows(0).Item("AttFile3").ToString = "" Then
                        MsgBox("ไม่สามารถลงผลเนื่องจากยังไม่ได้แนบเอกสารต้นฉบับ  ", MsgBoxStyle.Critical, "เเจ้งเตือนให้แนบเอกสาร")

                        'TxtApprove.Checked = False

                        Exit Sub

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือน")
                Exit Sub
            End Try
        End If


        Dim Sql As String = Nothing
        Dim Year As Integer = CInt(Format(Now, "yyyy"))
        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))




        With QEa_DocSysItem_Approve
            .LINEDATA = TxtLINEDATA.Text
            .REFNO = TxtREFNO.Text
            .REFNODATA = TxtREFNODATA.Text
            '.DARNO = TxtDARNO.Text
            .QEOFFICERAPPROVE = TxtQEOFFICERAPPROVE.Text
            .QEOFFICERNAME = TxtQEOFFICERNAME.Text
            .QEOFFICERDATE = TxtQEOFFICERDATE.Text
            .QEOFFICERREASON = TxtQEOFFICERREASON.Text
            .QEMGRAPPROVE = TxtQEMGRAPPROVE.Text
            .QEMGRNAME = TxtQEMGRNAME.Text
            .QEMGRDATE = TxtQEMGRDATE.Text
            .QEMGRREASON = TxtQEMGRREASON.Text
            .QEMRAPPROVE = TxtQEMRAPPROVE.Text
            .QEMRNAME = TxtQEMRNAME.Text
            .QEMRDATE = TxtQEMRDATE.Text
            .QEMRREASON = TxtQEMRREASON.Text

            ' Dim Sql As String = Nothing
            Select Case CommandTypeApprove
                Case "Addnew"
                    Sql = .SqlCommandInsert
                Case "Edit"
                    Sql = .SqlCommandUpdate
            End Select
            If CmdExcute(Sql, DB_CMD.ObjConn) = True Then
                'StrFunction.DOC_APPROVE = 1
                'MsgBox("บันทึกข้อมูลสำเร็จ")
                '  Me.Close()

                'Call LoadDataVer()
                'Call Tabpage3_Disable()

                Call UpdateStatus()
                Call UpdateRemark()

                StrFunction.DOC_APPROVE = 1
            Else
                MsgBox("ไม่สามารถบันทึกข้อมูลได้")
            End If
        End With
        'End If
        Me.Close()

    End Sub
    Sub UpdateRemark()



        If TxtQEOFFICERAPPROVE.Text = "Not Pass" Then
            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set MGRREASON = @MGRREASON " &
                                          "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                          "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@MGRREASON", SqlDbType.VarChar).Value = "Document Control " & " : " & TxtQEOFFICERREASON.Text
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

            FrmDocumentSystem.TxtMGRREASON.Text = "Document Control  " & " : " & TxtQEOFFICERREASON.Text

        ElseIf TxtQEOFFICERAPPROVE.Text = "Pass" Then

            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set MGRREASON = @MGRREASON " &
                                        "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                        "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@MGRREASON", SqlDbType.VarChar).Value = TxtQEOFFICERREASON.Text
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

            FrmDocumentSystem.TxtMGRREASON.Text = TxtQEOFFICERREASON.Text

        End If


        If TxtQEMGRAPPROVE.Text = "Not Pass" Then
            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set MGRREASON = @MGRREASON " &
                                          "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                          "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@MGRREASON", SqlDbType.VarChar).Value = "QE Mgr. / QE Chief " & " : " & TxtQEMGRREASON.Text
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            FrmDocumentSystem.TxtMGRREASON.Text = "QE Mgr. / QE Chief " & " : " & TxtQEMGRREASON.Text

        ElseIf TxtQEMGRAPPROVE.Text = "Pass" Then
            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set MGRREASON = @MGRREASON " &
                                         "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                         "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@MGRREASON", SqlDbType.VarChar).Value = TxtQEMGRREASON.Text
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            FrmDocumentSystem.TxtMGRREASON.Text = TxtQEMGRREASON.Text
        End If




        If TxtQEMRAPPROVE.Text = "Not Pass" Then

            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set MGRREASON = @MGRREASON " &
                                          "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                          "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@MGRREASON", SqlDbType.VarChar).Value = "ตัวแทนฝ่ายบริหาร" & " : " & TxtQEMRREASON.Text
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            FrmDocumentSystem.TxtMGRREASON.Text = "ตัวแทนฝ่ายบริหาร" & " : " & TxtQEMRREASON.Text

        ElseIf TxtQEMRAPPROVE.Text = "Pass" Then

            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set MGRREASON = @MGRREASON " &
                                          "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                          "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@MGRREASON", SqlDbType.VarChar).Value = TxtQEMRREASON.Text
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            FrmDocumentSystem.TxtMGRREASON.Text = TxtQEMRREASON.Text

        End If






        If TxtQEOFFICERAPPROVE.Text = "Pass" Then
            Dim myCommand As New SqlCommand("Update QEa_DocSys_Dar Set QEoff1 = @QEoff1,AttDoc1 = @AttDoc1,SendDocSrv1 = @SendDocSrv1 " &
                                          "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                          "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@QEoff1", SqlDbType.VarChar).Value = "จัดการ"
            myCommand.Parameters.Add("@AttDoc1", SqlDbType.VarChar).Value = "จัดการ"
            myCommand.Parameters.Add("@SendDocSrv1", SqlDbType.VarChar).Value = "จัดการ"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


            FrmDocumentSystem.TxtQEoff1.Text = "จัดการ"
            FrmDocumentSystem.TxtAttDoc1.Text = "จัดการ"
            FrmDocumentSystem.TxtSendDocSrv1.Text = "จัดการ"

        End If



    End Sub
    Sub UpdateStatus()


        Try



            'If TxtRptBy.Checked = True Then
            '    strStatus = "รอ อนุมัติการออก CAR"
            'End If

            'If TxtAppMrApproveY.Checked = True Then
            '    strStatus = "รอ ตอบกลับ CAR"
            'End If

            'If TxtAppMrApproveN.Checked = True Then

            '    strStatus = "ไม่อนุมัติให้ออก CAR"

            'End If

            'If TxtAppMgr.Checked = True Then
            '    strStatus = "รอ พิจารณาผลตอบกลับ CAR"
            'End If


            If TxtQEOFFICERAPPROVE.Text = "Not Pass" Then
                If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then
                    strStatus = "Document Control ไม่อนุมัติ"
                ElseIf Mid(FrmDocumentSystem.TxtDOCNO.Text, 2, 3) = "JSA" Then
                    strStatus = "จป.วิชาชีพ ไม่อนุมัติ"
                Else
                    strStatus = "SD ไม่อนุมัติ"
                End If

            End If

            If TxtQEOFFICERAPPROVE.Text = "Pass" Then
                If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then
                    strStatus = "รอ Asst.Mgr/Manager อนุมัติ"
                ElseIf Mid(FrmDocumentSystem.TxtDOCNO.Text, 2, 3) = "JSA" Then
                    strStatus = "รอ ผู้บริหารหน่วยงานความปลอดภัย อนุมัติ"
                Else
                    strStatus = "รอ SD Section Head อนุมัติ"
                End If
            End If


            If TxtQEMGRAPPROVE.Text = "Not Pass" Then
                If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then
                    strStatus = "Asst.Mgr/Manager ไม่อนุมัติ"
                ElseIf Mid(FrmDocumentSystem.TxtDOCNO.Text, 2, 3) = "JSA" Then
                    strStatus = "ผู้บริหารหน่วยงานความปลอดภัย ไม่อนุมัติ"
                Else
                    strStatus = "SD Section Head ไม่อนุมัติ"
                End If
            End If

            If TxtQEMGRAPPROVE.Text = "Pass" Then
                If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then
                    strStatus = "รอประกาศใช้"
                    Call FrmDocumentSystem.UpdateCourseMaster()
                ElseIf Mid(FrmDocumentSystem.TxtDOCNO.Text, 2, 3) = "JSA" Then
                    ' strStatus = "รอประกาศใช้"
                    strStatus = "Close"
                    Call FrmDocumentSystem.UpdateCourseMaster()
                    Call SendEmailKM()

                Else
                    strStatus = "รอ MR อนุมัติ"
                End If
            End If

            If strSELECTSYSTEM = "DP" Then
                GoTo NEXTSTEP_STATUS_MR
            End If


            If TxtQEMRAPPROVE.Text = "Not Pass" Then
                If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then
                    strStatus = "Asst.Mgr / Manager ไม่อนุมัติ"
                Else
                    strStatus = "MR ไม่อนุมัติ"
                End If
            End If

            If TxtQEMRAPPROVE.Text = "Pass" Then

                If FrmDocumentSystem.TxtRECORD.Checked = True Or FrmDocumentSystem.TxtKM.Checked = True Then
                    strStatus = "รอประกาศใช้"
                    GoTo NEXTSTEP_STATUS_MR
                Else
                    If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then
                        strStatus = "รอ Document Control จัดทำ รับ/คืน เอกสาร"
                    Else
                        strStatus = "รอ SD จัดทำเอกสาร"
                    End If
                End If


                If FrmDocumentSystem.TxtACTOBS.Checked Or FrmDocumentSystem.TxtACTCPY.Checked Then

                    strStatus = "รอประกาศใช้"
                    GoTo NEXTSTEP_STATUS_MR
                Else

                    If FrmDocumentSystem.TxtTYPEATTFILE.Text = "Paper" Then
                        strStatus = "รอประกาศใช้"
                        GoTo NEXTSTEP_STATUS_MR
                    Else
                        If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then
                            strStatus = "รอ Document Control จัดทำ รับ/คืน เอกสาร"
                        Else
                            If FrmDocumentSystem.TxtRECORD.Checked = True Then
                                strStatus = "รอประกาศใช้"
                            Else

                                strStatus = "รอ SD จัดทำเอกสาร"
                            End If
                        End If
                    End If

                End If


            End If


NEXTSTEP_STATUS_MR:

            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                                               "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                               "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = strStatus
            ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        Catch ex As Exception

        End Try


    End Sub

    Sub SendEmailKM()
        Try
            Dim strKMNO As String = ""


            Dim cri As String = ""

            Me.dgvEmailKM.AllowUserToAddRows = True

            Dim Sql As String = "Select * from QEa_DocSysItem "
            Sql = Sql + " WHERE REFNO= '" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "' "
            Sql = Sql + " Order by REFNO, REFNODATA asc"
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            dgvEmailKM.Rows.Clear()

            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                With dgvEmailKM


                    Application.DoEvents()
                    .Rows.Add()
                    .Item(0, .Rows.Count - 2).Value = intNo
                    .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString

                    strKMNO = Dtr.Item("DOCNO").ToString

                    Select Case Dtr.Item("MANAGE").ToString
                        Case "N"
                            .Item(4, .Rows.Count - 2).Value = "จัดทำ"
                        Case "E"
                            .Item(4, .Rows.Count - 2).Value = "แก้ไข"
                        Case "O"
                            .Item(4, .Rows.Count - 2).Value = "ยกเลิก"
                        Case "C"
                            .Item(4, .Rows.Count - 2).Value = "สำเนาเพิ่ม"
                        Case "R"
                            .Item(4, .Rows.Count - 2).Value = "สำเนาเเทนชุดเดิม"
                        Case "U"
                            .Item(4, .Rows.Count - 2).Value = "นำเอกสารยกเลิกกลับมาใช้ใหม่"
                    End Select

                    .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString


                End With

                intNo = intNo + 1
            Next

            dgvEmailKM.AutoResizeColumns()

            Me.dgvEmailKM.AllowUserToAddRows = False




            '*** 29/07/2022 *** 
            'Send Email

            Call GetHostName()
            Dim strEmailSendAll As String = ""

            Dim Sql2 As String = "SELECT * FROM QEa_DocSysItem_SelectDept WHERE REFNO= '" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "'  "
            Dim Dt2 As New DataTable
            Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            strEmailSend = ""
            For Each Dtr2 As DataRow In Dt2.Rows





                Dim Sql1 As String = "SELECT * "
                Sql1 = Sql1 + " FROM  QEm_UserLogOn "
                Sql1 = Sql1 + " WHERE Dept ='" & Dtr2.Item("DeptCod").ToString & "' "
                Sql1 = Sql1 + " Order by Dept,Email asc"
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                Dim strE1 As String = ""
                For Each Dtr1 As DataRow In Dt1.Rows

                    Dim strEmail As String = Dtr1.Item("Email").ToString.ToUpper

                    'Application.DoEvents()
                    If strE1 = strEmail Then
                        GoTo NEXTSTEP_EMAIL_1
                    Else
                        strEmailSendAll = strEmail
                        strE1 = strEmail

                    End If

                    strEmailSend = strEmailSend & "," & strEmailSendAll

NEXTSTEP_EMAIL_1:
                Next


            Next

            strEmailSend = Mid(strEmailSend, 2, 999999)

            'Dim Sql21 As String = "SELECT B.Section, A.EmployeeNo, A.EmployeeName, A.Email, A.Approve FROM QEm_UserLogOn AS A LEFT OUTER JOIN  QEa_Training_Person AS B ON A.EmployeeNo = B.EmployeeNo " &
            '                      "WHERE REFNO= '" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "'  "
            'Dim Dt21 As New DataTable
            'Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)


            Dim Sql21 As String = "SELECT * FROM QEm_Email_JSA " 
            Dim Dt21 As New DataTable
            Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)

            Dim strEmailSendCC As String = ""
            For Each Dtr21 As DataRow In Dt21.Rows



                strEmailSendCC = Dtr21.Item("Email").ToString.ToUpper


            Next


            Dim strStatusRepair As String = ""
            Dim strSubjectEmail As String = ""



            Dim smtp As New SmtpClient("10.1.1.5")
            Dim mail As New MailMessage()

            '  strStepSendEmail = "ส่งอนุมัติออก CAR ให้ SD Manager "

            mail.From = New MailAddress(strEmailTo)


            mail.To.Add(strEmailSend)
            'If TxtEmailCC1.Text <> "" Then
            mail.CC.Add(strEmailSendCC)
            ' End If
            mail.IsBodyHtml = True

            ' mail.Subject = "ฝ่าย " & strDeptData & "  ได้ดำเนินการจัดการเอกสาร KM ไว้ใน Master list Document System "
            mail.Subject = "Inform the effective date  of JSA No. ( " & strKMNO & " ) "
            mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน ทุกท่าน </b></b></Font><br/><br/></td></tr>"
            mail.Body = mail.Body + "<tr><td><b><font-size: 6pt color=BLACK> &nbsp;  &nbsp; &nbsp;&nbsp;  ระบบได้ดำเนินการจัดการเอกสาร JSA  ไว้ใน  </Font></Font><font-size: 6pt><font color=RED> Document Maser List </Font></b></b></Font></Font><br/></td></tr>"
            mail.Body = mail.Body + "<tr><td><b><font-size: 6pt><font color=BLACK>รายละเอียดของเอกสาร และวันที่บังคับใช้ ระบุตามตารางด้านล่างนี้ </b></b></Font></Font><br/></td></tr>"
            mail.Body = mail.Body + "<tr><td><b><font-size: 6pt><font color=BLUE> ขอให้หน่วยงานที่ได้รับเเจ้งทำการอ่านศึกษาเอกสารดังกล่าว และฝึกอบรมเอกสารก่อนวันบังคับใช้ด้วย  </b></b></Font></Font><br/> <br/><br/></td></tr>"

            'Table start.
            Dim html As String = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>"

            'Adding HeaderRow.
            html &= "<tr>"

            For Each column As DataGridViewColumn In dgvEmailKM.Columns

                html &= "<th style='background-color: #014690;color:white; border: 1px solid #ccc'>" & column.HeaderText & "</th>"

                'color:Tomato;
            Next

            html &= "</tr>"

            'Adding DataRow.
            For Each row As DataGridViewRow In dgvEmailKM.Rows
                html &= "<tr>"

                Dim intno11 As Integer = 0
                For Each cell As DataGridViewCell In row.Cells
                    ' If intNoColumn <> 1 And intNoColumn <> 6 And intNoColumn <> 9 Then

                    Select Case intno11
                        Case 0
                            html &= "<td style='width:30px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                        Case 1
                            html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                        Case 2
                            html &= "<td style='width:400px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                        Case 3
                            html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                        Case 4
                            html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                        Case 5
                            html &= "<td style='width:100px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"

                    End Select

                    intno11 = intno11 + 1

                    'End If

                    'intNoColumn = intNoColumn + 1
                Next


                html &= "</tr>"
            Next

            'Table end.
            html &= "</table>"


            mail.Body = mail.Body + html


            'mail.Body = mail.Body + "<tr><td><br/><br/><font-size: 1pt><font color=Black> รายงานโดย : " & StrUserName & "<br/></b></Font></Font><br/> <br/><br/></td></tr>"

            mail.Body = mail.Body + "<br/><br/> รายงานโดย : " & StrUserName & "<br/>"
            mail.Body = mail.Body + "ฝ่ายงาน / หน่วยงาน : " & strDeptData & "<br/>"
            mail.Body = mail.Body + "Sent from computer name : " & strHostName & "<br/>"
            mail.Body = mail.Body + "This email is auto-generated."

            mail.SubjectEncoding = System.Text.Encoding.GetEncoding(65001)
            mail.BodyEncoding = System.Text.Encoding.GetEncoding(65001)

            '  mail.Attachments.Add(New Attachment("D:\DaTA\Config -.xlsx"))

            Try
                smtp.Send(mail)
                Application.DoEvents()

                MsgBox("Send Mail Complete  ", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                smtp.Dispose()
            End Try


            Exit Sub

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งให้ทราบ")
            Exit Sub

        End Try



    End Sub


    Sub RunningRefNo()


        Dim Sql As String = Nothing
        Dim Year As Integer = CInt(Format(Now, "yyyy"))
        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))

        CommandTypeData = "Addnew"

        Dim command As New SqlCommand("Select *  FROM QEn_DarNo WHERE Year=" & Year & "  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)

        adapter.Fill(table)


        If table.Rows.Count = 0 Then

            Dim intRefNoNew As Integer = 1

            With QEn_DarNo

                .DARNO = intRefNoNew
                .YEAR = Year

                Select Case CommandTypeData
                    Case "Addnew"
                        Sql = .SqlCommandInsert
                End Select
                If CmdExcute(Sql, DB_CMD.ObjConn) = True Then

                End If
            End With
        End If

NexeSetp:
        With QEn_DarNo

            .GetData("Select * FROM QEn_DarNo WHERE YEAR =" & Year & " ", DB_CMD.ObjConn)

            ' TxtRefNo.Text = .RefNoData
            Dim strRefBranch As String = ""

            strRefBranch = Mid(strBranchConn, 1, 1)

            StrDARNO = Format(CSng(.DARNO), "000") & "/" & yy

            intRefNoData = CInt(.DARNO).ToString

            TxtDarNo.Text = StrDARNO

            Dim command1 As New SqlCommand("SELECT  * FROM QEa_DocSys_Dar WHERE DARNO ='" & StrDARNO & "' ORDER By DARNO ", DB_CMD.ObjConn)
            Dim adapter1 As New SqlDataAdapter(command1)
            Dim ds1 As New DataSet
            Dim table1 As New DataTable
            adapter1.Fill(table1)

            If table1.Rows.Count > 0 Then

                MsgBox("DAR NO : " & StrDARNO & "  มีในระบบเเล้ว แก้ไขให้ถูกต้องด้วย  ", MsgBoxStyle.Critical, "เเจ้งเตือน")
                TxtQEOFFICERAPPROVE.Text = ""
                TxtDarNo.Text = ""
                Exit Sub
            End If

        End With


        ' Update Running Number
        Dim myCommand As New SqlCommand("Update QEn_DarNo Set DARNO = @DARNO WHERE YEAR = " & Year & " ", DB_CMD.ObjConn)
        myCommand.Parameters.Add("@DARNO", SqlDbType.Int).Value = intRefNoData + 1
        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery




        ' Update QEa_DocSysItem
        Dim myCommand1 As New SqlCommand("Update QEa_DocSysItem Set DARNO = @DARNO WHERE REFNO = '" & TxtREFNO.Text & "' AND REFNODATA = '" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
        myCommand1.Parameters.Add("@DARNO", SqlDbType.VarChar).Value = TxtDarNo.Text
        Dim rowsAffected1 As Integer = myCommand1.ExecuteNonQuery


        ' Update QEa_DocSys_Dar
        'Dim myCommand2 As New SqlCommand("Update QEa_DocSys_Dar Set DARNO = @DARNO WHERE REFNO = '" & TxtREFNO.Text & "' AND REFNODATA = '" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
        'myCommand2.Parameters.Add("@DARNO", SqlDbType.VarChar).Value = TxtDarNo.Text
        'Dim rowsAffected2 As Integer = myCommand2.ExecuteNonQuery




        Dim sqlinsert As String
        Dim Result As Boolean

        Dim intMonthData As Integer
        intMonthData = Mid(TxtDateNow.Text, 6, 2)

        sqlinsert = " Insert Into QEa_DocSys_Dar (REFNO,REFNODATA,DARNO,UserRunDar,DateRunDar,Month)Values ('" & TxtREFNO.Text & "','" & TxtREFNODATA.Text & "','" & TxtDarNo.Text & "','" & StrUserName & "','" & TxtDateNow.Text & "'," & intMonthData & ") "
        Result = CmdExcute(sqlinsert, DB_CMD.ObjConn)


    End Sub
    Sub CheckDARNO()



    End Sub



    Private Sub FrmApproveDAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        'CommandType = "Addnew"
        TxtLINEDATA.Text = strMaxLineData
        TxtREFNO.Text = strRefNo
        TxtREFNODATA.Text = strRefNoData
        TxtDarNo.Text = StrDARNO

        If CommandTypeApprove = "Addnew" Then
        Else
            Call LoadData()

        End If




        Call DisableControl()


        If Mid(FrmDocumentSystem.TxtDOCNO.Text, 2, 3) = "JSA" Then

            lblStep_1.Text = "จป.วิชาชีพ"
            lblStep_2.Text = "ผบ.หน่วยงานความปลอดภัย"
            ' lblStep_3.Text = ""
            TxtQEMRAPPROVE.Enabled = False
            Call DisabledMR()
        End If

        If FrmDocumentSystem.TxtORGJD.Checked = True Or FrmDocumentSystem.TxtJobD.Checked = True Then

            lblStep_1.Text = "Document Control"
            lblStep_2.Text = "Asst.Mgr / Manager"
            ' lblStep_3.Text = ""
            TxtQEMRAPPROVE.Enabled = False
            Call DisabledMR()
        End If



    End Sub

    Sub DisabledMR()

        Panel3.Visible = False
        TxtQEMRAPPROVE.Visible = False
        TxtQEMRNAME.Visible = False
        TxtQEMRDATE.Visible = False
        Label61.Visible = False
        TxtQEMRREASON.Visible = False

    End Sub


    Sub DisableControl()


        TxtQEOFFICERAPPROVE.Enabled = False
        TxtQEOFFICERREASON.Enabled = False

        TxtQEMGRAPPROVE.Enabled = False
        TxtQEMGRREASON.Enabled = False


        TxtQEMRAPPROVE.Enabled = False
        TxtQEMRREASON.Enabled = False
        bntSave.Enabled = False
        bntDelete.Enabled = False

        If strStatusDelete = "รอประกาศใช้" Then
            Exit Sub
        End If

        If strSELECTSYSTEMForm <> "DS" Then

            TxtQEMGRAPPROVE.Enabled = False
            TxtQEMGRREASON.Enabled = False
            TxtQEMRAPPROVE.Enabled = False
            TxtQEMRREASON.Enabled = False

        End If


        If strDeptData = "SD" Or strDeptData = "GA" Or strDeptData = "HRGA" Then
            TxtQEOFFICERAPPROVE.Enabled = True
            TxtQEOFFICERREASON.Enabled = True

            bntSave.Enabled = True
            bntDelete.Enabled = True

        End If

        If strDeptData = "SD" Or strDeptData = "GA" Or strDeptData = "HRGA" Then
            If strApprove = "Manager" Or strApprove = "MR" Or strApprove = "Assistant manager" Then
                TxtQEMRAPPROVE.Enabled = True
                TxtQEMRREASON.Enabled = True

                TxtQEMGRAPPROVE.Enabled = True
                TxtQEMGRREASON.Enabled = True
                bntSave.Enabled = True
                bntDelete.Enabled = True
            End If

            If strApprove = "SD Chief" Then

                TxtQEMGRAPPROVE.Enabled = True
                TxtQEMGRREASON.Enabled = True
                bntSave.Enabled = True
                bntDelete.Enabled = True
            End If


            If strApprove = "SF Chief" And Mid(FrmDocumentSystem.TxtDOCNO.Text, 2, 3) = "JSA" Then

                TxtQEMGRAPPROVE.Enabled = True
                TxtQEMGRREASON.Enabled = True
                bntSave.Enabled = True
                bntDelete.Enabled = True

            End If

        End If






    End Sub



    Sub LoadData()
        With QEa_DocSysItem_Approve

            .GetData("Select * FROM QEa_DocSysItem_Approve WHERE REFNO='" & strRefNo & "' AND REFNODATA='" & strRefNoData & "' AND LINEDATA =" & intLINEDATA & " ", DB_CMD.ObjConn)

            TxtLINEDATA.Text = .LINEDATA
            TxtREFNO.Text = .REFNO
            TxtREFNODATA.Text = .REFNODATA
            ' TxtDARNO.Text =.DARNO 
            TxtQEOFFICERAPPROVE.Text = .QEOFFICERAPPROVE
            TxtQEOFFICERNAME.Text = .QEOFFICERNAME
            TxtQEOFFICERDATE.Text = .QEOFFICERDATE
            TxtQEOFFICERREASON.Text = .QEOFFICERREASON
            TxtQEMGRAPPROVE.Text = .QEMGRAPPROVE
            TxtQEMGRNAME.Text = .QEMGRNAME
            TxtQEMGRDATE.Text = .QEMGRDATE
            TxtQEMGRREASON.Text = .QEMGRREASON
            TxtQEMRAPPROVE.Text = .QEMRAPPROVE
            TxtQEMRNAME.Text = .QEMRNAME
            TxtQEMRDATE.Text = .QEMRDATE
            TxtQEMRREASON.Text = .QEMRREASON

            'If TxtQEReceiveCAR.Text = "Pass" Then
            '    bntSave.Enabled = False
            '    bntDelete.Enabled = False
            'End If

        End With


        'Call CalcDate("01/01/2520", Now)





    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub bntDelete_Click_1(sender As Object, e As EventArgs) Handles bntDelete.Click
        ' chkSelectALL.Checked = False
        Dim Sms As String = "คุณต้องการลบข้อมูล" & " : " & TxtLINEDATA.Text & "    ออก จากรายการ หรือไม่?"
        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        CmdExcute("DELETE FROM QEa_DocSysItem_Approve  WHERE REFNO='" & TxtREFNO.Text & "' AND REFNODATA='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
        CmdExcute("DELETE FROM QEa_DocSys_Dar  WHERE REFNO='" & TxtREFNO.Text & "' AND REFNODATA='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
        StrFunction.DOC_APPROVE = 1
        Me.Close()


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        FrmEditDARNO.Close()
        FrmEditDARNO.ShowDialog()
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        bntSave.Enabled = True
    End Sub

    Private Sub MetroButton2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MetroButton2.MouseDoubleClick
        bntSave.Enabled = True
    End Sub
End Class