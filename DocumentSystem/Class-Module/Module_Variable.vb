Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Module Module_Variable
    'ตัวแปรชุดจัดการ Member   ****************************
    Public DB_CMD As New C_DB_COMMANDER
    Public QEn_RefNo As New C_QEn_RefNo
    Public QEa_DocSysItem As New C_QEa_DocSysItem
    Public QEn_RefNoData As New C_QEn_RefNoData
    Public QEn_RrsNo As New C_QEn_RrsNo
    Public QEa_DocSysItem_Approve As New C_QEa_DocSysItem_Approve
    Public QEm_UserLogOn As New C_QEm_UserLogOn
    Public QEa_DocSys_DarApprove As New C_QEa_DocSys_DarApprove
    Public QEn_DarNo As New C_QEn_DarNo
    Public QEa_DocSys_Dar As New C_QEa_DocSys_Dar
    Public QEm_ToDept As New C_QEm_ToDept
    Public QEa_SendDocToDept As New C_QEa_SendDocToDept
    Public mytrans As SqlTransaction
    Public connDb As New OleDbConnection
    Public SqlCommandDB As New OleDbCommand
    Public mytransDB As OleDbTransaction
    Public SqlCommand As New SqlCommand
    'Training Record

    Public QEa_Training_Person As New C_QEa_Training_Person
    Public QEa_Training_CrseSet As New C_QEa_Training_CrseSet
    Public QEa_Training_Assign As New C_QEa_Training_Assign
    Public QEa_Training_ReTaining_Assign As New C_QEa_Training_ReTaining_Assign


    Public strMD As String
    Public strTTCCEmail As String
    Public StrSectionChk As String
    Public strEmployeeNoRpt, strDeptRpt, strDEPTJOIN, StrEmployeeNoAssign, strFormAssign, strAttFile_1, strFilename1, strCheckBntMgr, strDeptDataRRSNO As String


    Public strMaxLineDataAttfile As String
    'Public QEm_UserLogOn As New C_QEm_UserLogOn
    'Public QEa_Car_Reply As New C_QEa_Car_Reply
    'Public QEa_Car As New C_QEa_Car
    'Public QEn_Car_RefNoData As New C_QEn_Car_RefNoData
    'Public QEa_CarH As New C_QEa_CarH
    'Public QEn_Car_Reference As New C_QEn_Car_Reference
    'Public QEn_Car_CarNumber As New C_QEn_Car_CarNumber
    'Public QEa_LogSendEmail As New C_QEa_LogSendEmail
    'Public QEa_Car_DepSec As New C_QEa_Car_DepSec
    'Public QEt_RepliedCarStatus As New C_QEt_RepliedCarStatus
    'Public QEm_Car_Require As New C_QEm_Car_Require

    'Public QEt_VerificationCARStatus As New C_QEt_VerificationCARStatus

    'Public QEa_Car_RequireNo As New C_QEa_Car_RequireNo
    'Public QEa_Car_AttFile As New C_QEa_Car_AttFile

    'Public QEa_Car_Verification As New C_QEa_Car_Verification
    'Public History_Personnel As New C_History_Personnel

    Public SiteID As String
    Public SiteName As String
    Public strModeOpen As String
    Public strModeLabel As String
    Public strTypeEQ As String
    Public intAge As String
    Public strTypeDSPM As String
    Public strEmailTo As String
    Public strEmailSend As String
    Public strEmailSendCC As String
    Public strGrpSys As String
    Public strIDApproveDar, strLabelCopy, strCHKREFNOOPENFORM As String

    'Public strCARNO As String

    Public strAttfileAction As String



    Public strMaxLineReply As String
    Public strMaxLineData As String

    Public StrUserName As String
    Public StrEmployeeNo As String

    Public StrModeProgram As String
    Public strDocNo, strDocName, strDocDept, strApprove, strApproveName, strRRSNO, strTrainingDate, strRemarkTraining, StrEFFDATE, strREVNO, strResult, strMRApproveData, intRetrainFreq As String
    Public strForm As String
    Public strDeptData As String
    Public strBranchData As String
    Public strBranchConn As String

    Public strBranch As String
    Public intRefNoData, intRRSNo As Integer
    Public intRefNo As Integer
    Public intCarNoRunning As Integer
    Public strRefNoData, StrDARNO, strStatusDelete As String
    Public strRefNo As String
    Public strCarNo As String
    Public strStatusCAR As String
    Public intLINEDATA As Integer


    Public intSelectedRow As Integer

    Public strBranchRecieve, strDRrsNoRecieve As String

    Public strFormShowGrid As String
    Public strShowFoam As String
    Public strReqNo As String
    Public strLineData, strLineRefNoData, strLineRefNo, strLineDataDAR, strUserSEL, strToDept As String
    Public strLavelLogon As String
    Public strStepSendEmail As String
    Public strCARCASEDATA As String
    Public strSELECTSYSTEMFind As String
    Public strSELECTSYSTEMRecive As String
    Public strSELECTSYSTEMEmail As String
    ' Public intReplyNo As String



    ' Public mytrans As SqlTransaction
    '************************************************
    Public strEdit As String

    Public UserName As String
    Public CommandTypeData As String
    Public strSpecDesc As String
    Public CommandTypeVer As String
    Public CommandTypeReply As String
    Public CommandTypeNew As String
    Public CommandTypeApprove As String
    Public CommandApproveDAR As String
    Public strHostName As String
    Public CommandTypeCopyNo As String


    Public strCaseManage As String
    Public strSELECTSYSTEM As String
    Public strSELECTSYSTEMForm As String
    Public connEmail As New SqlConnection
    Public connKB As New SqlConnection
    Public connKBSA As New SqlConnection
    Public connTP As New SqlConnection

    Public strAssignCode, strTrainerCode, strMthdCode, strStartDate, strRemarkAssign, strRetrainFreqAssign As String


    Public strDOCNOSendTodept, strLanguageSendTodept, strCtypeDataSendTodept, strDocCtrlSendTodept, strCopyNoSendTodept, strToDeptSendTodept As String

    Public strYearDateFm, strYearDateTo As String



    Public Function ConnectSQL() As Boolean
        Try

            With DB_CMD

                ' strBranchConn = "TP"
                If strBranchConn = "TP" Then

                    If .SQlServerConnect("10.1.1.4", "Sa", "Sa1234", "DocumentSystem") = False Then
                        'If .SQlServerConnect("DESKTOP-SC23JPJ\SQLEXPRESS", "Sa", "Sa1234", "DocumentSystem") = False Then
                        '    'MsgBox("Can not connect database ")
                    End If

                        'If .SQlServerConnect("10.1.1.4", "Sa", "Sa1234", "DocumentSystem") = False Then
                        '    'If .SQlServerConnect("DESKTOP-SC23JPJ\SQLEXPRESS", "Sa", "Sa1234", "CARONLINE") = False Then
                        '    ' MsgBox("Can not connect database ")
                        'End If


                    ElseIf strBranchConn = "KB" Then

                        If .SQlServerConnect("10.2.1.101\SQLEXPRESSKB", "Sa", "Sql2000", "DocumentSystem") = False Then
                        ' MsgBox("Can not connect database ")
                    End If

                End If
            End With

        Catch ex As Exception

        End Try

        Return Nothing
    End Function
    Public Function CmdExcute(ByVal sql As String, ByVal SQlConn As SqlClient.SqlConnection) As Boolean
        Try
            If SQlConn.State = ConnectionState.Closed Then SQlConn.Open()
            Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, SQlConn)
            Cmd.ExecuteNonQuery()
            CmdExcute = True
        Catch ex As Exception
            CmdExcute = False
            MsgBox(Err.Description)
        End Try
    End Function
    Public Function LoadGridData(ByVal Grd As DataGridView) As Boolean
        Dim cri As String = ""


        Dim Sql As String = "Select * from QEa_DocSysItem "
        Sql = Sql + " Order by ToDept asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Grd.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With Grd
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("ToDeptName").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                .Item(5, .Rows.Count - 2).Value = Mid(Dtr.Item("ToDept").ToString, 2, 2)
                .Item(6, .Rows.Count - 2).Value = Mid(Dtr.Item("ToDept").ToString, 2, 2)
                .Item(4, .Rows.Count - 2).Value = False

            End With

        Next

        '   Return = Nothing
    End Function

    Public Function LoadGridDataPerson(ByVal Grd As DataGridView) As Boolean
        Dim cri As String = ""


        Dim Sql As String = "Select * from RDa_ToDept "
        Sql = Sql + " Order by ToDept asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Grd.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With Grd
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("ToDeptName").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString

            End With

        Next



        '   Return = Nothing
    End Function

    Public Function LoadGridSendDocument(ByVal Grd As DataGridView, DocNo As String) As Boolean
        Dim cri As String = ""
        Dim Sql As String

        Sql = "Select * from RDa_SendDocument "
        Sql = Sql + " WHERE DocNo ='" & DocNo & "' "
        Sql = Sql + " Order by SpecNo,ToDept asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)







        Grd.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With Grd
                ' intM = 1
                'intW = 1
                Sql = "Select * from RDm_SpecDetail  "
                Sql = Sql + " WHERE SpecNo='" & Dtr.Item("SpecNo").ToString & "' "
                Sql = Sql + " Order by SpecNo asc"
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

                For Each Dtr1 As DataRow In Dt1.Rows

                    strSpecDesc = Dtr1.Item("SpecDesc").ToString

                Next

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("DocNo").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("SpecNo").ToString
                .Item(3, .Rows.Count - 2).Value = strSpecDesc
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("ToDeptName").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("CopyNo").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("Amt").ToString
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("Branch_C").ToString

            End With

        Next



        '   Return = Nothing
    End Function


    Public Function loadGridReciveData(ByVal Grd As DataGridView) As Boolean
        Dim cri As String = ""




        Dim Sql As String = "Select * from RDm_SpecDetail "
        Sql = Sql + " Order by SpecNo asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Grd.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With Grd
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("SpecNo").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("SpecDesc").ToString

            End With

        Next



        '   Return = Nothing
    End Function

    Public Function loadGridStatus(ByVal Grd As DataGridView) As Boolean
        Dim cri As String = ""




        Dim Sql As String = "Select * from RDm_SpecDetail "
        Sql = Sql + " Order by SpecNo asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Grd.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With Grd
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("SpecNo").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("SpecDesc").ToString

            End With

        Next

        '  Return= Nothing
    End Function


    Public Function LoadGridReceive(ByVal RrsNoData As String, ByVal BranchData As String, ByVal Grd As DataGridView) As Boolean

        Dim strCri As String = ""



        Dim Sql As String = "SELECT * FROM RDa_ReceiveFrom  WHERE RrsNo ='" & RrsNoData & "'AND Branch ='" & BranchData & "' "
        Sql = Sql + " Order by DocNo,SpecNo,ReCopyNo asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Grd.Rows.Clear()

        Dim intNo1 As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With Grd


                .Rows.Add(1)
                .Rows(.Rows.Count - 1).Cells("Branch").Value = Dtr.Item("Branch").ToString
                .Rows(.Rows.Count - 1).Cells("DocNo").Value = Dtr.Item("DocNo").ToString
                .Rows(.Rows.Count - 1).Cells("SpecNo").Value = Dtr.Item("SpecNo").ToString
                .Rows(.Rows.Count - 1).Cells("SpecDesc").Value = Dtr.Item("SpecDesc").ToString
                .Rows(.Rows.Count - 1).Cells("Type").Value = Dtr.Item("Type").ToString
                .Rows(.Rows.Count - 1).Cells("RevNoN").Value = Dtr.Item("RevNoN").ToString
                .Rows(.Rows.Count - 1).Cells("ReRev").Value = Dtr.Item("ReRev").ToString
                .Rows(.Rows.Count - 1).Cells("ReCopyNo").Value = Dtr.Item("ReCopyNo").ToString
                .Rows(.Rows.Count - 1).Cells("RtRev").Value = Dtr.Item("RtRev").ToString
                .Rows(.Rows.Count - 1).Cells("RtCopyNo").Value = Dtr.Item("RtCopyNo").ToString
                .Rows(.Rows.Count - 1).Cells("TotalNo").Value = Dtr.Item("TotalNo").ToString
                .Rows(.Rows.Count - 1).Cells("RevDate").Value = Dtr.Item("RevDate").ToString
                .Rows(.Rows.Count - 1).Cells("ToDept").Value = Dtr.Item("ToDept").ToString
                .Rows(.Rows.Count - 1).Cells("ToDeptName").Value = Dtr.Item("ToDeptName").ToString
                .Rows(.Rows.Count - 1).Cells("TypeNew").Value = Dtr.Item("TypeNew").ToString
                .Rows(.Rows.Count - 1).Cells("Branch_C").Value = Dtr.Item("Branch_c").ToString
                .Rows(.Rows.Count - 1).Cells("YearData").Value = Dtr.Item("YearData").ToString

                If strFormShowGrid = "Receive" Then

                    'If Dtr.Item("Sign").ToString = 1 Then
                    '    .Rows(.Rows.Count - 2).Cells("Sign").Value = 1
                    'End If
                    '  .Rows(.Rows.Count - 1).Cells("Sign").Value = Dtr.Item("Sign").ToString
                    .Rows(.Rows.Count - 1).Cells("ResName").Value = Dtr.Item("ResName").ToString
                    .Rows(.Rows.Count - 1).Cells("ResDate").Value = Dtr.Item("ResDate").ToString

                    'If Dtr.Item("RDSign").ToString = 1 Then
                    '    .Rows(.Rows.Count - 2).Cells("RDSign").Value = 1
                    'End If

                    '.Rows(.Rows.Count - 1).Cells("RDSign").Value = Dtr.Item("RDSign").ToString
                    .Rows(.Rows.Count - 1).Cells("RDResName").Value = Dtr.Item("RDResName").ToString
                    .Rows(.Rows.Count - 1).Cells("RDResDate").Value = Dtr.Item("RDResDate").ToString



                End If

            End With

            intNo1 = intNo1 + 1
        Next
    End Function


    Public Function LoadGridSpec(ByVal Grd As DataGridView) As Boolean
        Dim cri As String = ""


        Dim Sql As String = "Select * from RDm_SpecDetail "
        Sql = Sql + " Order by SpecNo asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Grd.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With Grd
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("SpecNo").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("SpecDesc").ToString

            End With

        Next



        '   Return = Nothing
    End Function


    Public Function CheckMaxLineDataApprove(StrREFNOChkMax, StrREFNODATAChkMAX)
        '    Try


        Dim cri As String = ""


        Dim Sql As String = "Select MAX(LINEDATA) As MaxLineData FROM QEa_DocSysItem_Approve "
        Sql = Sql + " GROUP BY REFNODATA, REFNO "
        Sql = Sql + " HAVING  MAX(LineData) <> '' "
        Sql = Sql + " AND  REFNODATA = '" & StrREFNODATAChkMAX & "' "
        Sql = Sql + " AND  REFNO =  '" & StrREFNOChkMax & "' "
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        'Grd.Rows.Clear()

        Dim intNo As Integer = 1

        strMaxLineData = 1

        For Each Dtr As DataRow In Dt.Rows
            '  With Grd
            ' intM = 1
            'intW = 1

            Application.DoEvents()


            strMaxLineData = ""
            strMaxLineData = Dtr.Item("MaxLineData").ToString + 1




            '  End With

        Next

        '   Catch ex As Exception

        '  End Try

    End Function


    Public Function CheckMaxLineDataApproveAttfile(StrREFNOChkMaxAttfile, StrREFNODATAChkMAXAttfile)
        '    Try


        Dim cri As String = ""


        Dim Sql As String = "Select MAX(LINEDATA) As MaxLineData FROM QEa_DocSysItem_Approve "
        Sql = Sql + " GROUP BY REFNODATA, REFNO "
        Sql = Sql + " HAVING  MAX(LineData) <> '' "
        Sql = Sql + " AND  REFNODATA = '" & StrREFNODATAChkMAXAttfile & "' "
        Sql = Sql + " AND  REFNO =  '" & StrREFNOChkMaxAttfile & "' "
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        'Grd.Rows.Clear()

        Dim intNo As Integer = 1

        strMaxLineDataAttfile = 1

        For Each Dtr As DataRow In Dt.Rows
            '  With Grd
            ' intM = 1
            'intW = 1

            Application.DoEvents()


            strMaxLineDataAttfile = ""
            strMaxLineDataAttfile = Dtr.Item("MaxLineData").ToString




            '  End With

        Next

        '   Catch ex As Exception

        '  End Try

    End Function


    Function LoadDataDeptDATA(dgvDataDept)

        dgvDataDept.AllowUserToAddRows = True

        Dim Sql As String = "Select * from QEm_Dept "
        Sql = Sql + " Order by DeptCod asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvDataDept.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvDataDept
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("DeptCod").ToString



            End With

        Next
        dgvDataDept.AllowUserToAddRows = False

    End Function

    'Public Function SaveLogSendEmail()

    '    Dim CommandEmail As String = "Addnew"
    '    Call GetHostName()

    '    With QEa_LogSendEmail

    '        .FromEmail = strEmailTo
    '        .ToEmail = strEmailSend
    '        .ComName = strHostName

    '        .SendDateEmail = Date.Today
    '        .TimeDateEmail = TimeOfDay
    '        .RefNo = strRefNo
    '        .CARNO = strCarNo
    '        .EmployeeNo = StrEmployeeNo
    '        .EmployeeName = StrUserName
    '        .EmployeePass = ""
    '        .Dept = strDeptData
    '        .Branch = strBranchData
    '        .StepSendEmail = strStepSendEmail


    '        Dim Sql As String = Nothing
    '        Select Case CommandEmail
    '            Case "Addnew"
    '                Sql = .SqlCommandInsert
    '                'Case "Edit"
    '                '    Sql = .SqlCommandUpdate
    '        End Select
    '        If CmdExcute(Sql, DB_CMD.ObjConn) = True Then

    '        Else
    '            MsgBox("ไม่สามารถบันทึกข้อมูลได้")
    '        End If
    '    End With



    'End Function


    Public Sub GetHostName()
        Try

            strHostName = System.Net.Dns.GetHostName()

            'strBranch = Mid(strHostName, 1, 1)
            ''strBranch = "N"
            ''= strDept


        Catch ex As Exception
            MsgBox("เกิดข้อผิดพลาดแก้ไขข้อมูล GetHostName  ", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    '    Private Sub SendEmailToUser()

    '        Dim smtp As New SmtpClient("mail.sunif.co.th")
    '        Dim mail As New MailMessage()
    '        Call GetHostName()
    '        Call GetEmailSend()


    '        Call SaveLogSendEmail()

    '        mail.From = New MailAddress(strEmailTo)

    '        mail.To.Add(strEmailSend)
    '        'mail.CC.Add("ekarat@sunif.co.th")

    '        mail.Subject = "แจ้งสถานะการขออนุมัติออก CAR  REF No. : " & strRefNo & ""
    '        ' Dim parts() As String = Split(My.User.Name, " \")
    '        ' Dim username As String = parts(1)
    '        mail.Body = "CAR online. 
    'แจ้งสถานะการขออนุมัติออก CAR  REF No. : " & strRefNo & "
    'ที่มา : " & strCARCASEDATA & " 
    'รายงานโดย : " & StrUserName & "
    'ฝ่ายงาน/หน่วยงาน : " & strDeptData & "
    'Sent from computer name : " & strHostName & "
    'This email is auto-generated."

    '        mail.SubjectEncoding = System.Text.Encoding.GetEncoding(65001)
    '        mail.BodyEncoding = System.Text.Encoding.GetEncoding(65001)

    '        Try
    '            smtp.Send(mail)
    '            Application.DoEvents()

    '            MsgBox("Send Mail Complete  ", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        Finally
    '            smtp.Dispose()
    '        End Try

    '    End Sub

    'Private Sub GetEmailSendToUser()

    '    strEmailSend = ""

    '    Dim Sql As String = "SELECT * "
    '    Sql = Sql + " FROM  QEm_UserLogOn "
    '    Sql = Sql + " WHERE  Dept ='QE' "
    '    Sql = Sql + " Order by Dept asc"
    '    Dim Dt As New DataTable
    '    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

    '    grdDataRows.Rows.Clear()

    '    Dim intNo As Integer = 1

    '    Dim strEmailSendAll As String = ""

    '    For Each Dtr As DataRow In Dt.Rows

    '        Application.DoEvents()

    '        strEmailSendAll = Dtr.Item("Email").ToString


    '        strEmailSend = strEmailSend & "," & strEmailSendAll

    '    Next

    '    strEmailSend = Mid(strEmailSend, 2, 500) & "," & strEmailTo

    'End Sub

End Module
