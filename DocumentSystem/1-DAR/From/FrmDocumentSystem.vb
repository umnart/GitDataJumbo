Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Net.Mail

Public Class FrmDocumentSystem
    Public EditNo As String
    Private intSelectedRow As Integer
    Private rowIndex As Integer
    Dim strChekGrid As String

    Dim strStatus As String = ""
    Dim strTxtAppMgrEmail As String = ""
    Dim strTxtAppMREmail As String = ""
    Dim strDOCTYPE As String = ""
    Dim comSave As New SqlCommand
    Dim Exts As String
    Dim strDOCTYPEDATA As String
    Dim strAttfile As String = ""
    Dim comUpdate As SqlCommand
    Dim ConnKB As New SqlConnection
    Dim intYearNow As Integer = 0
    Sub Grid()

        With Me.dgvDATA
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AutoResizeColumns()
        End With


        With Me.dgvQE
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        End With

        With Me.dgvApprove3
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        End With



        With Me.dgvDataDept
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        End With


    End Sub

    Private Sub FrmDocumentSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadDataDept()

        If CommandTypeNew = "Addnew" Then
            TxtPETITIONNAME.Text = StrUserName
            TxtPETITIONDEPT.Text = strDeptData
            TxtPETITIONDATE.Text = TxtDateNow.Text
            TxtPETITIONBRANCH.Text = strBranchData


            TxtREFNO.Text = strRefNo
        ElseIf CommandTypeNew = "Edit" Then
            TxtREFNO.Text = strRefNo
            Call LoadGridData()

        End If



        '  Call LoadData

        Call DisabledText()


        bntAddItem.Enabled = True


        Call LockFormData()

        Call Grid()

        Call DeptDATASel()

        TabPage2.Visible = False
        TabPage2.Enabled = False
        TabControl1.Controls.Remove(TabPage2)



    End Sub

    Sub DeptDATASel()

        Dim command As New SqlCommand("SELECT  DeptCod FROM  QEm_Dept  ORDER BY DeptCod  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEm_Dept")
        If table.Rows.Count > 0 Then
            TxtDOCDEPT.DisplayMember = "DeptCod"
            TxtDOCDEPT.ValueMember = "DeptCod"
            TxtDOCDEPT.DataSource = ds.Tables("QEm_Dept")
        End If


        Exit Sub
    End Sub




    Sub LockFormData()

        TxtMANUAL.Enabled = False
        TxtPROCEDURED.Enabled = False
        TxtWORKIN.Enabled = False
        TxtSTANDARD.Enabled = False
        TxtRECORD.Enabled = False
        TxtKM.Enabled = False
        TxtORGJD.Enabled = False
        TxtJobD.Enabled = False

        Select Case strSELECTSYSTEMForm


            Case "DS"

                TxtMANUAL.Enabled = True
                TxtPROCEDURED.Enabled = True
                TxtWORKIN.Enabled = True
                TxtSTANDARD.Enabled = True
                TxtRECORD.Enabled = True


            Case "KM"

                TxtKM.Enabled = True

            Case "DP"
                ' TxtMANUAL.Enabled = True
                ' TxtPROCEDURED.Enabled = True
                ' TxtWORKIN.Enabled = True
                TxtSTANDARD.Enabled = True
                TxtORGJD.Enabled = True
                TxtJobD.Enabled = True
        End Select





    End Sub


    Sub LoadDataDept()

        Me.dgvDataDept.AllowUserToAddRows = True

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

        Me.dgvDataDept.AllowUserToAddRows = False
    End Sub

    Sub LoadData()

        Try
            With QEa_DocSysItem

                .GetData("Select * FROM QEa_DocSysItem WHERE REFNO = '" & strRefNo & "' AND REFNODATA ='" & strRefNoData & "'", DB_CMD.ObjConn)

                TxtREFNO.Text = .REFNO
                TxtREFNODATA.Text = .REFNODATA
                TxtDarNo.Text = .DARNO
                ' TxtSTATUS.Text = .STATUS =
                'TxtDOCTYPE.Text = .DOCTYPE
                strSELECTSYSTEM = .SELECTSYSTEM

                If .DOCTYPE = "MNL" Then
                    TxtMANUAL.Checked = True
                ElseIf .DOCTYPE = "PRC" Then
                    TxtPROCEDURED.Checked = True
                ElseIf .DOCTYPE = "WIN" Then
                    TxtWORKIN.Checked = True
                ElseIf .DOCTYPE = "STD" Then
                    TxtSTANDARD.Checked = True
                ElseIf .DOCTYPE = "RCF" Then
                    TxtRECORD.Checked = True
                ElseIf .DOCTYPE = "KMM" Then
                    TxtKM.Checked = True
                ElseIf .DOCTYPE = "OGN" Then
                    TxtORGJD.Checked = True
                ElseIf .DOCTYPE = "JOB" Then
                    TxtJobD.Checked = True
                End If


                If .MANAGE = "N" Then
                    TxtACTNEW.Checked = True
                ElseIf .MANAGE = "E" Then
                    TxtACTAMD.Checked = True
                ElseIf .MANAGE = "O" Then
                    TxtACTOBS.Checked = True
                ElseIf .MANAGE = "C" Then
                    TxtACTCPY.Checked = True
                ElseIf .MANAGE = "R" Then
                    TxtACTCPY.Checked = True
                ElseIf .MANAGE = "U" Then
                    TxtUndoDoc.Checked = True
                End If


                'If .MANAGE = "N" Then
                '    TxtACTNEW.Checked = True
                'ElseIf .MANAGE = "E" Then
                '    TxtACTAMD.Checked = True
                'ElseIf .MANAGE = "O" Then
                '    TxtACTOBS.Checked = True
                'ElseIf .MANAGE = "C" Then
                '    TxtACTCPY.Checked = True
                'ElseIf .MANAGE = "R" Then
                '    TxtCTRPL.Checked = True
                'ElseIf .MANAGE = "U" Then
                '    TxtUndoDoc.Checked = True
                'End If




                'TxtMANUAL.Text = .MANUAL
                'TxtPROCEDURED.Text = .PROCEDURED
                'TxtWORKIN.Text = .WORKIN
                'TxtSTANDARD.Text = .STANDARD
                'TxtRECORD.Text = .RECORD
                'TxtKM.Text = .KM
                'TxtORGJD.Text = .ORGJD
                '  TxtMANAGE.Text = .MANAGE
                'TxtACTNEW.Text = .ACTNEW
                TxtACTCPYSel.Text = .ACTCPYSel   ' การจัดทำสำเนา
                TxtCheckDelete.Text = .ACTOBS
                TxtUndoDocSelect.Text = .UndoDocSelect
                TxtDocCtrl.Text = .CTRPL
                TxtDOCNO.Text = .DOCNO
                TxtDOCNAME.Text = .DOCNAME
                TxtDOCDEPT.Text = .DOCDEPT
                TxtREVNO.Text = .REVNO
                TxtEFFDATE.Text = .EFFDATE
                TXTDOCSHARE.Text = .DOCSHARE
                TxtREASON.Text = .REASON
                TxtTYPEATTFILE.Text = .TYPEATTFILE
                TxtMGRAPP.Text = .MGRAPP
                TxtMGRNAME.Text = .MGRNAME
                TxtMGRDATE.Text = .MGRDATE
                TxtMGRREASON.Text = .MGRREASON
                TxtPETITIONNAME.Text = .PETITIONNAME
                TxtPETITIONDATE.Text = .PETITIONDATE
                TxtPETITIONDEPT.Text = .PETITIONDEPT
                TxtPETITIONBRANCH.Text = .PETITIONBRANCH


                ' TxtDocCtrl.Text = .DocCtrl

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)

    End Sub

    Private Sub bntUnlock_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtBranch_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        StrFunction.process = 1
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntQEApprove_Click(sender As Object, e As EventArgs) Handles bntQEApprove.Click
        CommandTypeApprove = "Addnew"

        If TxtMGRAPP.Text = "" Or TxtMGRAPP.Text = "ไม่อนุมัติ" Then
            MsgBox("ไม่สามารถจัดการได้ !!! เนื่องจาก ผู้จัดการฝ่ายยังไมได้อนุมัติ", MsgBoxStyle.Critical, "เเจ้งเตือน")
            Exit Sub
        End If


        Call CheckMaxLineData()


        strRefNo = TxtREFNO.Text
        strRefNoData = TxtREFNODATA.Text
        StrDARNO = TxtDarNo.Text

        strShowFoam = "DOC_APPROVE"
        StrFunction.DOC_APPROVE = 2
        Try
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception

        End Try



        FrmApproveDAR.Close()
        FrmApproveDAR.ShowDialog()
    End Sub
    Sub CheckMaxLineData()
        '    Try


        Dim cri As String = ""


        Dim Sql As String = "Select MAX(LINEDATA) As MaxLineData FROM QEa_DocSysItem_Approve "
        Sql = Sql + " GROUP BY REFNODATA, REFNO "
        Sql = Sql + " HAVING  MAX(LineData) <> '' "
        Sql = Sql + " AND  REFNODATA = '" & TxtREFNODATA.Text & "' "
        Sql = Sql + " AND  REFNO =  '" & TxtREFNO.Text & "' "
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

    End Sub

    Private Sub bntCopyKM_Click(sender As Object, e As EventArgs) Handles bntCopyKM.Click
        Try



            If TxtREFNODATA.Text <> "" Then



                CommandTypeCopyNo = "Addnew"



                If TxtACTNEW.Checked = True Then
                    strCaseManage = "New"
                ElseIf TxtACTAMD.Checked = True Then
                    strCaseManage = "Edit"
                ElseIf TxtACTOBS.Checked = True Then
                    strCaseManage = "Cancel"
                ElseIf TxtUndoDoc.Checked = True Then
                    strCaseManage = "Undo"
                End If



                'If TxtACTNEW.Checked = True Then
                '    strCaseManage = "New"
                'ElseIf TxtACTAMD.Checked = True Then
                '    strCaseManage = "Edit"
                'ElseIf TxtACTOBS.Checked = True Then
                '    strCaseManage = "Cancel"
                'ElseIf TxtACTCPY.Checked = True Then
                '    strCaseManage = "Copy"
                'ElseIf TxtCTRPL.Checked = True Then
                '    strCaseManage = "Replace"
                'ElseIf TxtUndoDoc.Checked = True Then
                '    strCaseManage = "Undo"
                'End If


                If TxtACTCPY.Checked = True Then

                    Select Case TxtACTCPYSel.Text

                        Case "สำเนาเพิ่ม"

                            strCaseManage = "Copy"

                        Case "สำเนาทดแทนชุดเดิม"

                            strCaseManage = "Replace"

                    End Select

                End If



                ' Call CheckMaxLineReply()


                'strRefNo = TxtRefNo.Text
                'strRefNoData = TxtRefNoData.Text
                'strShowFoam = "Reply"

                'StrFunction.Car_Reply = 2
                'Try
                '    BackgroundWorker2.RunWorkerAsync()
                'Catch ex As Exception

                'End Try

                If TxtKM.Checked = True Then

                    FrmKMEdit.Close()
                    FrmKMEdit.ShowDialog()
                Else

                    FrmDocSysiTem_Copy.Close()
                    FrmDocSysiTem_Copy.MdiParent = FrmMainMenu
                    FrmDocSysiTem_Copy.Show()

                End If


            End If

        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือน")

            '  Exit Sub
        End Try

    End Sub

    Private Sub bntAttFile_Click(sender As Object, e As EventArgs) Handles bntAttFile.Click
        CommandTypeNew = "Addnew"

        ' Call CheckMaxLineReply()


        'strRefNo = TxtRefNo.Text
        'strRefNoData = TxtRefNoData.Text
        'strShowFoam = "Reply"

        'StrFunction.Car_Reply = 2
        'Try
        '    BackgroundWorker2.RunWorkerAsync()
        'Catch ex As Exception

        'End Try
        strShowFoam = "DOC_APPROVE"

        StrFunction.DOC_APPROVE = 2
        Try
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmAttFile.Close()
        FrmAttFile.ShowDialog()

    End Sub

    Private Sub TxtTypeAttFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtTYPEATTFILE.SelectedIndexChanged

        'If TxtTYPEATTFILE.Text = "File" Then
        '    If CommandTypeNew = "Addnew" Then
        '        FrmAttFile.Close()
        '        FrmAttFile.ShowDialog()
        '        ' Call CheckMaxLineReply()


        '        'strRefNo = TxtRefNo.Text
        '        'strRefNoData = TxtRefNoData.Text
        '        'strShowFoam = "Reply"

        '        'StrFunction.Car_Reply = 2
        '        'Try
        '        '    BackgroundWorker2.RunWorkerAsync()
        '        'Catch ex As Exception

        '        'End Try


        '    End If
        'End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub



    Private Sub Panel20_Paint(sender As Object, e As PaintEventArgs) Handles Panel20.Paint

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

            Dim Sql2 As String = "SELECT * FROM QEm_KM_Dept_SEL WHERE REFNO= '" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "'  "
            Dim Dt2 As New DataTable
            Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            strEmailSend = ""
            For Each Dtr2 As DataRow In Dt2.Rows





                Dim Sql1 As String = "SELECT * "
                Sql1 = Sql1 + " FROM  QEm_UserLogOn "
                Sql1 = Sql1 + " WHERE Dept ='" & Dtr2.Item("DeptDATA").ToString & "' "
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

            Dim Sql21 As String = "SELECT* FROM QEm_KM_UserView WHERE REFNO= '" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "'  "
            Dim Dt21 As New DataTable
            Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)

            For Each Dtr21 As DataRow In Dt21.Rows

                Dim Sql1 As String = "SELECT * "
                Sql1 = Sql1 + " FROM  QEm_UserLogOn "
                Sql1 = Sql1 + " WHERE Dept ='" & Dtr21.Item("DeptDATA").ToString & "' "
                Sql1 = Sql1 + " AND EmployeeNo ='" & Dtr21.Item("EmployeeNo").ToString & "' "
                Sql1 = Sql1 + " Order by Dept asc"
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                Dim strE1 As String = ""

                For Each Dtr1 As DataRow In Dt1.Rows

                    Dim strEmail As String = Dtr1.Item("Email").ToString.ToUpper

                    'Application.DoEvents()
                    If strE1 = strEmail Then
                        GoTo NEXTSTEP_EMAIL_2
                    Else
                        strEmailSendAll = strEmail
                        strE1 = strEmail

                    End If

                    strEmailSend = strEmailSend & "," & strEmailSendAll

NEXTSTEP_EMAIL_2:
                Next


            Next



            strEmailSend = Mid(strEmailSend, 1, 999999)
            'MsgBox(strEmailSend)



            Dim strStatusRepair As String = ""
            Dim strSubjectEmail As String = ""



            Dim smtp As New SmtpClient("10.1.1.5")
            Dim mail As New MailMessage()

            '  strStepSendEmail = "ส่งอนุมัติออก CAR ให้ SD Manager "

            mail.From = New MailAddress(strEmailTo)


            mail.To.Add(strEmailSend)
            'If TxtEmailCC1.Text <> "" Then
            '    mail.CC.Add(TxtEmailCC1.Text)
            ' End If
            mail.IsBodyHtml = True

            ' mail.Subject = "ฝ่าย " & strDeptData & "  ได้ดำเนินการจัดการเอกสาร KM ไว้ใน Master list Document System "
            mail.Subject = "Inform the effective date  of KM No. ( " & strKMNO & " ) "
            mail.Body = mail.Body + "<tr><td><b><font-size: 7pt color=BLACK>เรียน ทุกท่าน </b></b></Font><br/><br/></td></tr>"
            mail.Body = mail.Body + "<tr><td><b><font-size: 6pt color=BLACK> &nbsp;  &nbsp; &nbsp;&nbsp;  ระบบได้ดำเนินการจัดการเอกสาร KM  ไว้ใน  </Font></Font><font-size: 6pt><font color=RED> KM Master List </Font></b></b></Font></Font><br/></td></tr>"
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

    Private Sub bntSave_Click_1(sender As Object, e As EventArgs) Handles bntSave.Click
        Try


            If TxtTYPEATTFILE.Text = "Electronic File" Then

                If TxtKM.Checked = False Then
                    Dim command As New SqlCommand("Select * FROM QEa_AttFile WHERE REFNO = '" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'AND AttFile1 <> '' ORDER BY REFNO DESC ", DB_CMD.ObjConn)
                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)
                    adapter.Fill(ds, "QEa_AttFile")
                    If table.Rows.Count = 0 Then

                        MsgBox("กรุณาเลือก แนบไฟล์เอกสาร ด้วยค่ะ ")
                        bntCopyKM.Focus()
                        Exit Sub

                    End If
                End If
            End If


            If TxtKM.Checked = True Then

                Dim command As New SqlCommand("Select * FROM QEm_KM_Dept_SEL WHERE REFNO = '" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "' ORDER BY REFNO DESC ", DB_CMD.ObjConn)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                Dim ds As New DataSet
                adapter.Fill(table)
                adapter.Fill(ds, "QEm_KM_Dept_SEL")
                If table.Rows.Count = 0 Then

                    MsgBox("กรุณาเลือก การจัดการ Lavel ระบบ KM  ด้วยค่ะ ")
                    bntCopyKM.Focus()
                    Exit Sub

                End If


            End If





            If TxtSTANDARD.Checked = True And strSELECTSYSTEM = "DP" And Mid(TxtDOCNO.Text, 2, 3) <> "JSA" Then

                If TxtMGRAPP.Text = "อนุมัติ" Then

                    Call UpdateCourseMaster()

                End If
            End If

            Call SAVEDATA()


            If TxtKM.Checked = True Then
                'Call AttFileKM()

                Try


                    If TxtMGRAPP.Text = "อนุมัติ" Then

                        If TxtKM.Checked = True Then

                            Dim cri As String = ""
                            Dim strBranch As String = ""

                            Dim Sql As String = "SELECT * FROM QEa_AttFile WHERE  REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'  "
                            Sql = Sql + "Order by REFNO,REFNODATA asc"


                            Dim Dt As New DataTable
                            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

                            strAttFile_1 = ""
                            strFilename1 = ""
                            Dim intNo1 As Integer = 1
                            For Each Dtr As DataRow In Dt.Rows

                                strAttFile_1 = Dtr.Item("AttFile1").ToString
                                strFilename1 = Dtr.Item("Filename1").ToString

                                ' intNo1 = intNo1 + 1
                            Next


                            Dim command As New SqlCommand("SELECT  Lavel FROM QEm_KM_Dept_SEL " &
                                             "WHERE REFNODATA ='" & TxtREFNODATA.Text & "'" &
                                             "AND DOCNO ='" & TxtDOCNO.Text & "'" &
                                             "And REFNO ='" & TxtREFNO.Text & "' GROUP BY Lavel ", DB_CMD.ObjConn)
                            Dim table As New DataTable
                            Dim adapter As New SqlDataAdapter(command)
                            Dim ds As New DataSet
                            adapter.Fill(table)

                            Dim strLavelKM As String = ""

                            If table.Rows.Count > 0 Then

                                strLavelKM = table.Rows(0).Item("Lavel").ToString

                            End If


                            Dim sSource As String = ""
                            Dim sTarget As String = ""


                            sSource = strAttFile_1

                            If strBranchConn = "TP" Then
                                sTarget = "\\10.1.1.4\km$\" & TxtDOCDEPT.Text & "\" & strLavelKM & "\" & strFilename1

                            Else
                                sTarget = "\\10.2.1.101\km$\" & TxtDOCDEPT.Text & "\" & strLavelKM & "\" & strFilename1

                            End If
                            ' System.IO.File.Copy(sSource, sTarget, True)

                            ' My.Computer.FileSystem.CopyFile(sSource, sTarget, True)
                            'My.Computer.FileSystem.RenameFile("c:\test\test.txt", "c:\test\NewName.txt")

                            Dim strGetP As String = ""

                            strGetP = Mid(sSource, 1, 33)

                            'If strGetP = "\\10.1.1.4\km$\" & strGroupName & "\" Then

                            'Else

                            My.Computer.FileSystem.CopyFile(sSource, sTarget, True)


                            'End If



                            Dim myCommand As New SqlCommand("Update QEa_AttFile Set AttFile3 = @AttFile3,Filename3 = @Filename3 " &
                                             "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                              "AND DOCNO ='" & TxtDOCNO.Text & "'" &
                                             "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
                            myCommand.Parameters.Add("@AttFile3", SqlDbType.VarChar).Value = sTarget
                            myCommand.Parameters.Add("@Filename3", SqlDbType.VarChar).Value = strFilename1
                            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                            Call UpdateCourseMasterKM()
                            Call SendEmailKM()

                        End If
                    End If

                    ' Exit Sub

                Catch ex As Exception

                    MsgBox(ex.Message)
                    Exit Sub

                End Try

            End If


            StrFunction.process = 1
            StrFunction.ClickDATA = 1
            chkSelectALL.Checked = False


            Me.dgvDATA.ClearSelection()

            Me.dgvDATA.Rows(StrFunction.RowSelected).Selected = True
            dgvDATA.FirstDisplayedScrollingRowIndex = StrFunction.RowSelected

        Catch ex As Exception

        End Try

    End Sub

    Sub AttFileKM()
        Try


            If TxtMGRAPP.Text = "อนุมัติ" Then

                If TxtKM.Checked = True Then

                    Dim cri As String = ""
                    Dim strBranch As String = ""

                    Dim Sql As String = "SELECT * FROM QEa_AttFile WHERE  REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'  "
                    Sql = Sql + "Order by REFNO,REFNODATA asc"


                    Dim Dt As New DataTable
                    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

                    strAttFile_1 = ""
                    strFilename1 = ""
                    Dim intNo1 As Integer = 1
                    For Each Dtr As DataRow In Dt.Rows

                        strAttFile_1 = Dtr.Item("AttFile1").ToString
                        strFilename1 = Dtr.Item("Filename1").ToString

                        ' intNo1 = intNo1 + 1
                    Next


                    Dim command As New SqlCommand("SELECT  Lavel FROM QEm_KM_Dept_SEL " &
                                         "WHERE REFNODATA ='" & TxtREFNODATA.Text & "'" &
                                         "AND DOCNO ='" & TxtDOCNO.Text & "'" &
                                         "And REFNO ='" & TxtREFNO.Text & "' GROUP BY Lavel ", DB_CMD.ObjConn)
                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)

                    Dim strLavelKM As String = ""

                    If table.Rows.Count > 0 Then

                        strLavelKM = table.Rows(0).Item("Lavel").ToString

                    End If


                    Dim sSource As String = ""
                    Dim sTarget As String = ""


                    sSource = strAttFile_1


                    sTarget = "\\10.1.1.4\km$\" & TxtDOCDEPT.Text & "\" & strLavelKM & "\" & strFilename1


                    ' System.IO.File.Copy(sSource, sTarget, True)

                    ' My.Computer.FileSystem.CopyFile(sSource, sTarget, True)
                    'My.Computer.FileSystem.RenameFile("c:\test\test.txt", "c:\test\NewName.txt")

                    Dim strGetP As String = ""

                    strGetP = Mid(sSource, 1, 33)

                    'If strGetP = "\\10.1.1.4\km$\" & strGroupName & "\" Then

                    'Else

                    My.Computer.FileSystem.CopyFile(sSource, sTarget, True)


                    'End If



                    Dim myCommand As New SqlCommand("Update QEa_AttFile Set AttFile3 = @AttFile3,Filename3 = @Filename3 " &
                                         "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                          "AND DOCNO ='" & TxtDOCNO.Text & "'" &
                                         "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
                    myCommand.Parameters.Add("@AttFile3", SqlDbType.VarChar).Value = sTarget
                    myCommand.Parameters.Add("@Filename3", SqlDbType.VarChar).Value = strFilename1
                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                    Call UpdateCourseMasterKM()

                End If
            End If

            Exit Sub

        Catch ex As Exception

            MsgBox(ex.Message)
            Exit Sub

        End Try

    End Sub
    Sub CheckDeptSel()
        Dim strDeptCheck As String = ""
        For Each row As DataGridViewRow In dgvDataDept.Rows




            With dgvDataDept

                If CBool(row.Cells("Sel").Value) = True Then

                    strDeptCheck = "OK"
                End If

            End With
        Next

        If strDeptCheck = "" Then
            MsgBox("กรุณาเลือกฝ่ายที่รับผิดชอบด้วยค่ะ", MsgBoxStyle.Information)
            Exit Sub
        End If

    End Sub
    Sub SaveSelectDept()

        'Dim strDOCTYPE As String = ""
        'If TxtMANUAL.Checked = True Then
        '    strDOCTYPE = "MNL"
        'ElseIf TxtPROCEDURED.Checked = True Then
        '    strDOCTYPE = "PRC"
        'ElseIf TxtWORKIN.Checked = True Then
        '    strDOCTYPE = "WIN"
        'ElseIf TxtSTANDARD.Checked = True Then
        '    strDOCTYPE = "STD"
        'ElseIf TxtRECORD.Checked = True Then
        '    strDOCTYPE = "RCF"
        'ElseIf TxtKM.Checked = True Then
        '    strDOCTYPE = "KMM"
        'ElseIf TxtORGJD.Checked = True Then
        '    strDOCTYPE = "OGN"
        'ElseIf TxtJobD.Checked = True Then
        '    strDOCTYPE = "JOB"
        'End If


        CmdExcute("DELETE FROM QEa_DocSysItem_SelectDept  WHERE REFNO='" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "'  AND  DOCNO ='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)

        Dim sqlinsert As String = ""
        For Each row As DataGridViewRow In dgvDataDept.Rows
            With dgvDataDept

                If CBool(row.Cells("Sel").Value) = True Then


                    sqlinsert = "INSERT INTO QEa_DocSysItem_SelectDept(REFNO,REFNODATA,DOCNO,DOCTYPE,DeptCod) " &
                        "VALUES(@REFNO,@REFNODATA,@DOCNO,@DOCTYPE,@DeptCod)"


                    With comSave
                        .Parameters.Clear()
                        .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                        .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                        .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPEDATA
                        .Parameters.Add("@DeptCod", SqlDbType.VarChar).Value = CStr(row.Cells("DeptCod").Value)

                        .CommandText = sqlinsert
                        .Connection = DB_CMD.ObjConn
                        .ExecuteNonQuery()

                    End With

                End If

            End With

        Next

        Call LoadDataDept()

    End Sub

    Sub SAVEDATA()

        Dim Sql As String = Nothing
        Dim Year As Integer = CInt(Format(Now, "yyyy"))
        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))



        '  Try
        ''ตรวจสอบ ข้อมูลก่อนบันทึก
        'If CheckData() = False Then
        '    MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
        '    Exit Sub
        'Else




        'If CommandType = "Addnew" Then

        'End If

        If TxtMANUAL.Checked = False And TxtPROCEDURED.Checked = False And TxtWORKIN.Checked = False And TxtSTANDARD.Checked = False And TxtRECORD.Checked = False And TxtKM.Checked = False And TxtORGJD.Checked = False And TxtJobD.Checked = False Then
            MsgBox("กรุณาเลือก : ประเภทเอกสาร ")
            Exit Sub
        End If

        If TxtACTNEW.Checked = False And TxtACTAMD.Checked = False And TxtACTOBS.Checked = False And TxtACTCPY.Checked = False And TxtCTRPL.Checked = False And TxtUndoDoc.Checked = False Then
            MsgBox("กรุณาเลือก : ประเภทข้อบกพร่อง")
            Exit Sub
        End If



        If TxtDOCNO.Text = "" Then
            MsgBox("กรุณา : กำหนด เอกสารเลขที่ Doc.No ")
            TxtDOCNO.Focus()
            Exit Sub
        End If

        If TxtDOCNAME.Text = "" Then
            MsgBox("กรุณา : กำหนด ชื่อเรื่อง ( TH )")
            TxtDOCNAME.Focus()
            Exit Sub
        End If

        If TxtDOCDEPT.Text = "" Then
            MsgBox("กรุณา : กำหนด เอกสารของฝ่าย Dept")
            TxtDOCDEPT.Focus()
            Exit Sub
        End If

        If TxtREVNO.Text = "" Then
            MsgBox("กรุณา : กำหนด แก้ไขครั้งที่ Rev.")
            TxtREVNO.Focus()
            Exit Sub
        End If


        If TxtKM.Checked = False Then

            If TXTDOCSHARE.Text = "" Then
                MsgBox("กรุณา : กำหนด Share , Dept ")
                TXTDOCSHARE.Focus()
                Exit Sub
            End If

            Call CheckDeptSel()

        End If



        If TxtTYPEATTFILE.Text = "" Then
            MsgBox("กรุณา : กำหนด ประเภทเอกสารแนบ")
            TxtTYPEATTFILE.Focus()
            Exit Sub

        End If

        'If TxtDocCtrl.Text = "" Then
        '    MsgBox("กรุณา : เลือกเอกสารควบคุม /  เอกสารไม่ควบคุม")
        '    TxtTYPEATTFILE.Focus()
        '    Exit Sub

        'End If


        'If CommandType = "Edit" Then

        '    If TxtMGRAPP.Text = "" Then
        '        MsgBox("กรุณา : กำหนด ผู้จัดการฝ่าย ")
        '        TxtMGRAPP.Focus()
        '        Exit Sub
        '    End If

        'End If




        With QEa_DocSysItem




            If TxtMANUAL.Checked = True Then
                .DOCTYPE = "MNL"
                strDOCTYPEDATA = "MNL"
            ElseIf TxtPROCEDURED.Checked = True Then
                .DOCTYPE = "PRC"
                strDOCTYPEDATA = "PRC"
            ElseIf TxtWORKIN.Checked = True Then
                .DOCTYPE = "WIN"
                strDOCTYPEDATA = "WIN"
            ElseIf TxtSTANDARD.Checked = True Then
                .DOCTYPE = "STD"
                strDOCTYPEDATA = "STD"
            ElseIf TxtRECORD.Checked = True Then
                .DOCTYPE = "RCF"
                strDOCTYPEDATA = "RCF"
            ElseIf TxtKM.Checked = True Then
                .DOCTYPE = "KMM"
                strDOCTYPEDATA = "KMM"
            ElseIf TxtORGJD.Checked = True Then
                .DOCTYPE = "OGN"
                strDOCTYPEDATA = "OGN"
            ElseIf TxtJobD.Checked = True Then
                .DOCTYPE = "JOB"
                strDOCTYPEDATA = "JOB"
            End If



            If TxtACTNEW.Checked = True Then
                .MANAGE = "N"
            ElseIf TxtACTAMD.Checked = True Then
                .MANAGE = "E"
            ElseIf TxtACTOBS.Checked = True Then
                .MANAGE = "O"
            ElseIf TxtUndoDoc.Checked = True Then
                .MANAGE = "U"
            End If

            If TxtACTCPY.Checked = True Then

                Select Case TxtACTCPYSel.Text

                    Case "สำเนาเพิ่ม"

                        .MANAGE = "C"

                    Case "สำเนาทดแทนชุดเดิม"

                        .MANAGE = "R"

                End Select

            End If



            'If TxtACTNEW.Checked = True Then
            '    .MANAGE = "N"
            'ElseIf TxtACTAMD.Checked = True Then
            '    .MANAGE = "E"
            'ElseIf TxtACTOBS.Checked = True Then
            '    .MANAGE = "O"
            'ElseIf TxtACTCPY.Checked = True Then
            '    .MANAGE = "C"
            'ElseIf TxtCTRPL.Checked = True Then
            '    .MANAGE = "R"
            'ElseIf TxtUndoDoc.Checked = True Then
            '    .MANAGE = "U"
            'End If



            '.CheckDelete = TxtCheckDelete.Text
            .REFNO = TxtREFNO.Text
            .REFNODATA = TxtREFNODATA.Text
            .DARNO = TxtDarNo.Text
            '.STATUS = TxtSTATUS.Text
            '.DOCTYPE = TxtDOCTYPE.Text
            '.MANUAL = TxtMANUAL.Text
            '.PROCEDURED = TxtPROCEDURED.Text
            '.WORKIN = TxtWORKIN.Text
            '.STANDARD = TxtSTANDARD.Text
            '.RECORD = TxtRECORD.Text
            '.KM = TxtKM.Text
            '.ORGJD = TxtORGJD.Text
            '.MANAGE = TxtMANAGE.Text

            If strSELECTSYSTEM = "" Then

                strSELECTSYSTEM = strSELECTSYSTEMFind

            Else

                If strSELECTSYSTEM <> strSELECTSYSTEMFind Then

                    strSELECTSYSTEM = strSELECTSYSTEMFind

                Else

                    strSELECTSYSTEM = strSELECTSYSTEMFind

                End If

            End If

            .SELECTSYSTEM = strSELECTSYSTEM

            .ACTCPYSel = TxtACTCPYSel.Text
            .ACTOBS = TxtCheckDelete.Text
            ' รายละเอียดการเรียกคืนเอกสารกลับมาใช้งาน
            .UndoDocSelect = TxtUndoDocSelect.Text
            .CTRPL = TxtDocCtrl.Text
            .DOCNO = TxtDOCNO.Text
            .DOCNAME = TxtDOCNAME.Text
            .DOCDEPT = TxtDOCDEPT.Text
            .REVNO = TxtREVNO.Text
            .EFFDATE = TxtEFFDATE.Text
            .DOCSHARE = TXTDOCSHARE.Text
            .REASON = TxtREASON.Text
            .TYPEATTFILE = TxtTYPEATTFILE.Text
            .MGRAPP = TxtMGRAPP.Text
            .MGRNAME = TxtMGRNAME.Text
            .MGRDATE = TxtMGRDATE.Text
            .MGRREASON = TxtMGRREASON.Text
            .PETITIONNAME = TxtPETITIONNAME.Text
            .PETITIONDATE = TxtPETITIONDATE.Text
            .PETITIONDEPT = TxtPETITIONDEPT.Text
            .PETITIONBRANCH = TxtPETITIONBRANCH.Text
            '.DocCtrl = TxtDocCtrl.Text

            '   End With


            Dim command As New SqlCommand("Select * FROM QEa_DocSysItem WHERE REFNO = '" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "' ORDER BY REFNO DESC ", DB_CMD.ObjConn)
            Dim table As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            Dim ds As New DataSet
            adapter.Fill(table)
            adapter.Fill(ds, "QEa_DocSysItem")

            If table.Rows.Count > 0 Then


                CommandTypeNew = "Edit"


            End If

            Select Case CommandTypeNew
                Case "Addnew"
                    Sql = .SqlCommandInsert
                Case "Edit"
                    Sql = .SqlCommandUpdate
            End Select
            If CmdExcute(Sql, DB_CMD.ObjConn) = True Then
                StrFunction.DocSystem = 1
                'MsgBox("บันทึกข้อมูลสำเร็จ")


                If TxtQEoff8.Checked <> True Then
                    If strCheckBntMgr = "Data" Then

                    ElseIf strStatusDelete = "รอประกาศใช้" Or strStatusDelete = "รอเอกสารลงนาม" Or strStatusDelete = "รอ จป.วิชาชีพ จัดการ" Or strStatusDelete = "รอ Document control จัดการ" Or strStatusDelete = "รอ ผู้บริหารหน่วยงานความปลอดภัย อนุมัติ" Then

                    Else
                        Call UpdateStatus()

                    End If
                End If

                'If strTxtAppMgrEmail = "Email" Then
                '    Call SendEmailToUser()
                'End If


                'If strTxtAppMREmail = "Email" Then
                '    Call SendEmailToUser()
                'End If

                Call LoadGridData()

            Else

                MsgBox("ไม่สามารถบันทึกข้อมูลได้")

                Exit Sub

            End If

        End With

        Call SaveSelectDept()

        'End If

        Call DisabledText()
        Call ClearText()
        StrFunction.ClickDATA = 1
        bntAddItem.Enabled = True

    End Sub
    Sub LoadGridData()
        Dim cri As String = ""



        Me.dgvDATA.AllowUserToAddRows = True

        Dim Sql As String = "Select * from QEa_DocSysItem "
        Sql = Sql + " WHERE REFNO= '" & TxtREFNO.Text & "' "
        Sql = Sql + " Order by REFNO, REFNODATA asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvDATA.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvDATA

                Dim Sql11 As String = "Select * From QEa_DocSysItem_Approve "
                Sql11 = Sql11 + " Where REFNODATA ='" & Dtr.Item("REFNODATA").ToString & "' "
                Sql11 = Sql11 + " AND REFNO ='" & Dtr.Item("REFNO").ToString & "' "
                Sql11 = Sql11 + " And LINEDATA In ( Select MAX(LINEDATA) From QEa_DocSysItem_Approve "
                Sql11 = Sql11 + " WHERE REFNODATA ='" & Dtr.Item("REFNODATA").ToString & "' "
                Sql11 = Sql11 + " AND REFNO ='" & Dtr.Item("REFNO").ToString & "')"

                Dim Dt11 As New Data.DataTable
                Dt11 = DB_CMD.GetData_Table(Sql11, DB_CMD.ObjConn)
                Dim strAppQEReceiveCARDate, strQEVerifyDate As String

                strAppQEReceiveCARDate = ""
                strQEVerifyDate = ""






                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(14, .Rows.Count - 2).Value = Dtr.Item("DOCTYPE").ToString


                Select Case Dtr.Item("MANAGE").ToString
                    Case "N"
                        .Item(2, .Rows.Count - 2).Value = "จัดทำ"
                    Case "E"
                        .Item(2, .Rows.Count - 2).Value = "แก้ไข"
                    Case "O"
                        .Item(2, .Rows.Count - 2).Value = "ยกเลิก"
                    Case "C"
                        .Item(2, .Rows.Count - 2).Value = "สำเนาเพิ่ม"
                    Case "R"
                        .Item(2, .Rows.Count - 2).Value = "สำเนาเเทนชุดเดิม"
                    Case "U"
                        .Item(2, .Rows.Count - 2).Value = "นำเอกสารยกเลิกกลับมาใช้ใหม่"
                End Select
                ' .Item(2, .Rows.Count - 2).Value = Dtr.Item("MANAGE").ToString






                .Item(4, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("DARNO").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString



                Dim Sql12 As String = "Select RRSNO, DOCNO from QEa_DocSys_ReceiveDoc "
                Sql12 = Sql12 + " WHERE REFNO= '" & Dtr.Item("REFNO").ToString & "' "
                Sql12 = Sql12 + " AND REFNODATA = '" & Dtr.Item("REFNODATA").ToString & "' "
                Sql12 = Sql12 + " AND DARNO = '" & Dtr.Item("DARNO").ToString & "' "
                Sql12 = Sql12 + " Order by RRSNO, DOCNO asc"
                Dim Dt12 As New DataTable
                Dt12 = DB_CMD.GetData_Table(Sql12, DB_CMD.ObjConn)

                'Dim intNo As Integer = 1
                For Each Dtr12 As DataRow In Dt12.Rows

                    .Item(9, .Rows.Count - 2).Value = Dtr12.Item("RRSNO").ToString

                Next



                For Each Dtr11 As DataRow In Dt11.Rows
                    .Item(10, .Rows.Count - 2).Value = Dtr11.Item("QEOFFICERAPPROVE").ToString
                    .Item(11, .Rows.Count - 2).Value = Dtr11.Item("QEMGRAPPROVE").ToString
                    .Item(12, .Rows.Count - 2).Value = Dtr11.Item("QEMRAPPROVE").ToString
                Next

                .Item(14, .Rows.Count - 2).Value = Dtr.Item("REFNODATA").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString

            End With

            intNo = intNo + 1
        Next

        dgvDATA.AutoResizeColumns()

        Me.dgvDATA.AllowUserToAddRows = False
        '   Return = Nothing
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


            If TxtMGRAPP.Text = "" Then

                strStatus = "รอ ผู้จัดการฝ่ายอนุมัติ"

            End If

            If TxtMGRAPP.Text = "ไม่อนุมัติ" Then

                strStatus = "ผู้จัดการฝ่ายไม่อนุมัติ"

            End If

            If TxtMGRAPP.Text = "อนุมัติ" Then


                If TxtKM.Checked = True Then
                    strStatus = "Close"
                End If

                If TxtORGJD.Checked = True Or TxtJobD.Checked = True Then
                    strStatus = "รอ Document Control จัดการ"
                ElseIf Mid(TxtDOCNO.Text, 2, 3) = "JSA" Then
                    strStatus = "รอ จป.วิชาชีพ จัดการ"
                ElseIf strSELECTSYSTEM = "DS" Then
                    strStatus = "รอ SD รับ DAR"
                ElseIf strSELECTSYSTEM = "DP" And TxtSTANDARD.Checked = True Then
                    strStatus = "รอประกาศใช้"
                End If
            End If



            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                                               "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                               "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = strStatus
            ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        Catch ex As Exception

        End Try


    End Sub

    Private Sub bntAddItem_Click(sender As Object, e As EventArgs) Handles bntAddItem.Click
        chkSelectALL.Checked = False
        CommandTypeNew = "Addnew"
        strStatusDelete = ""

        Call ClearText()

        Call EnabledText()



        Call LockFormData()

        Call RunningRefNo()

        ' Call SaveData()




        StrFunction.DocSystem = 2




        bntAddItem.Enabled = False
        If strSELECTSYSTEMForm = "KM" Then

            TxtKM.Checked = True

        Else

            TxtKM.Checked = False

        End If

        TxtPETITIONNAME.Text = StrUserName
        TxtPETITIONDEPT.Text = strDeptData
        TxtPETITIONDATE.Text = TxtDateNow.Text
        TxtPETITIONBRANCH.Text = strBranchData
        intYearNow = 0
        intYearNow = Mid(TxtPETITIONDATE.Text, 7, 4)


        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Then

            TxtMGRAPP.Enabled = True

        Else

            TxtMGRAPP.Enabled = False

        End If


    End Sub

    Sub RunningRefNo()

        Dim Sql As String = Nothing
        Dim Year As Integer = CInt(Format(Now, "yyyy"))
        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))

        CommandTypeData = "Addnew"

        Dim command As New SqlCommand("Select *  FROM QEn_RefNoData WHERE Year=" & Year & "  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)

        adapter.Fill(table)


        If table.Rows.Count = 0 Then

            Dim intRefNoNew As Integer = 1

            With QEn_RefNoData

                .REFNODATA = intRefNoNew
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

        With QEn_RefNoData

            .GetData("Select * FROM QEn_RefNoData WHERE YEAR =" & Year & " ", DB_CMD.ObjConn)

            ' TxtRefNo.Text = .RefNoData
            Dim strRefBranch As String = ""

            strRefBranch = Mid(strBranchConn, 1, 1)

            strRefNoData = strRefBranch & "DD" & "-" & yy & "-" & Format(CSng(.REFNODATA), "00000")

            intRefNoData = CInt(.REFNODATA).ToString

            TxtREFNODATA.Text = strRefNoData





        End With


        ' Update Running Number
        Dim myCommand As New SqlCommand("Update QEn_RefNoData Set REFNODATA = @REFNODATA WHERE YEAR = " & Year & " ", DB_CMD.ObjConn)
        myCommand.Parameters.Add("@REFNODATA", SqlDbType.Int).Value = intRefNoData + 1



        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


    End Sub


    Sub EnabledText()

        TxtDOCTYPE.Enabled = True
        TxtMANAGE.Enabled = True
        TxtDOCNO.Enabled = True
        TxtDOCNAME.Enabled = True
        TxtDOCDEPT.Enabled = True
        TxtREVNO.Enabled = True
        TxtEFFDATE.Enabled = True
        TXTDOCSHARE.Enabled = True
        TxtREASON.Enabled = True
        TxtTYPEATTFILE.Enabled = True
        TxtMGRAPP.Enabled = True
        TxtMGRREASON.Enabled = True
        TxtDocCtrl.Enabled = True

        bntAttFile.Enabled = True


        bntSave.Enabled = True
        bntDelete.Enabled = True
        If strDeptData = "SD" Or strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
            bntQEApprove.Enabled = True
            dgvQE.Enabled = True
            bntUpdate.Enabled = True
        Else
            bntQEApprove.Enabled = False
            dgvQE.Enabled = False
        End If
        bntAddItem.Enabled = True

        If strSELECTSYSTEM = "KM" Then
            TXTDOCSHARE.Visible = False
            dgvDataDept.Visible = False
            chkSelectALL.Visible = False
            Panel9.Visible = False
            bntAttFile.Visible = False
        Else

            TXTDOCSHARE.Visible = True
            dgvDataDept.Visible = True

            chkSelectALL.Visible = True
            Panel9.Visible = True

            bntAttFile.Visible = True

        End If




    End Sub

    Sub DisabledText()

        TxtDOCTYPE.Enabled = False
        TxtMANAGE.Enabled = False
        TxtDOCNO.Enabled = False
        TxtDOCNAME.Enabled = False
        TxtDOCDEPT.Enabled = False
        TxtREVNO.Enabled = False
        TxtEFFDATE.Enabled = False
        TXTDOCSHARE.Enabled = False
        TxtREASON.Enabled = False
        TxtTYPEATTFILE.Enabled = False
        TxtMGRAPP.Enabled = False
        TxtMGRREASON.Enabled = False
        bntSave.Enabled = False
        bntDelete.Enabled = False
        bntQEApprove.Enabled = False
        TxtDocCtrl.Enabled = False
        'bntAddItem.Enabled = False

        ' bntAttFile.Enabled = False

    End Sub

    Sub ClearText()


        TxtMANUAL.Checked = False
        TxtPROCEDURED.Checked = False
        TxtWORKIN.Checked = False
        TxtSTANDARD.Checked = False
        TxtRECORD.Checked = False
        TxtKM.Checked = False
        TxtORGJD.Checked = False
        TxtJobD.Checked = False


        TxtDOCTYPE.Text = ""
        TxtMANAGE.Text = ""
        TxtDOCNO.Text = ""
        TxtDOCNAME.Text = ""
        TxtDOCDEPT.Text = ""
        TxtREVNO.Text = ""
        TxtEFFDATE.Text = ""
        TXTDOCSHARE.Text = ""
        TxtREASON.Text = ""
        TxtTYPEATTFILE.Text = ""
        TxtMGRAPP.Text = ""
        TxtMGRREASON.Text = ""
        TxtCheckDelete.Text = ""
        TxtDocCtrl.Text = ""

        TxtACTNEW.Checked = False
        TxtACTAMD.Checked = False
        TxtACTOBS.Checked = False
        TxtACTCPY.Checked = False
        TxtCTRPL.Checked = False
        dgvDataDept.Rows.Clear()

        Call LoadDataDept()


        TxtDarNo.Text = ""
        TxtREFNODATA.Text = ""

        dgvQE.Rows.Clear()


    End Sub



    Private Sub dgvDATA_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDATA.CellMouseDoubleClick


    End Sub

    Private Sub TxtMGRAPP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtMGRAPP.SelectedIndexChanged



        If TxtMGRAPP.Text = "" Then
            TxtMGRNAME.Text = ""
            TxtMGRDATE.Text = ""
        Else
            TxtMGRNAME.Text = StrUserName
            TxtMGRDATE.Text = TxtDateNow.Text
        End If



    End Sub
    Private Sub dgvDATA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDATA.CellContentClick
        chkSelectALL.Checked = False
        CommandTypeNew = "Edit"
    End Sub
    Private Sub dgvDATA_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDATA.CellMouseClick
        strRefNoData = ""
        StrDARNO = ""
        strRefNoData = Me.dgvDATA.Item(14, Me.dgvDATA.CurrentRow.Index).Value
        StrDARNO = Me.dgvDATA.Item(5, Me.dgvDATA.CurrentRow.Index).Value
        strStatusDelete = Me.dgvDATA.Item(7, Me.dgvDATA.CurrentRow.Index).Value
        strDocNo = Me.dgvDATA.Item(1, Me.dgvDATA.CurrentRow.Index).Value
        strRRSNO = Me.dgvDATA.Item(9, Me.dgvDATA.CurrentRow.Index).Value

        strMRApproveData = Me.dgvDATA.Item(12, Me.dgvDATA.CurrentRow.Index).Value


        dgvEmailKM.Rows.Clear()

        Call ClearTextDAR()
        Call LoadData()
        Call LoadDataGridSelect()

        Call LoadDOCAPPROVE()
        Call EnabledText()


        If StrDARNO <> "" Then
            Call DisabledText()
            If strDeptData = "SD" Then
                TabControl1.Controls.Remove(TabPage2)
                TabControl1.Controls.Add(TabPage2)
                Call ClearTextDAR()
                Call LoadDOCAPPROVEDAR()
                Call LoadDataDAR()
                Call DisabledText()



            End If
        Else

                TabControl1.Controls.Remove(TabPage2)

        End If

        CommandTypeNew = "Edit"

        If TxtACTAMD.Checked = True Or TxtACTOBS.Checked = True Or TxtACTCPY.Checked = True Or TxtCTRPL.Checked = True Then

            TxtDOCNO.Enabled = False
            TxtDOCNAME.Enabled = False
            TxtREVNO.Enabled = False

        End If


        If StrDARNO <> "" Then
            TabPage2.Visible = True
            TabPage2.Enabled = True
        Else
            TabPage2.Visible = False
            TabPage2.Enabled = False
        End If



        If strStatusDelete = "Delete" Then

            TabPage2.Enabled = False

        End If



        If strMRApproveData = "Pass" Then
            bntQEApprove.Enabled = True

        ElseIf strMRApproveData = "Not Pass" Then
            If strDeptData = "SD" Then
                bntQEApprove.Enabled = True
            Else
                bntQEApprove.Enabled = False
            End If
        End If


        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Then

            If strDeptData = TxtPETITIONDEPT.Text Then
                TxtMGRAPP.Enabled = True
                TxtMGRREASON.Enabled = True
            Else
                If strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
                    TxtMGRAPP.Enabled = True
                    TxtMGRREASON.Enabled = True
                Else
                    TxtMGRAPP.Enabled = False
                    TxtMGRREASON.Enabled = False
                End If

            End If

        Else
            TxtMGRAPP.Enabled = False
            TxtMGRREASON.Enabled = False

        End If


        TxtDOCNAME.Enabled = True

        If strDeptData = "SD" Then
            TxtEFFDATE.Enabled = True
            bntSave.Enabled = True
            TxtMGRREASON.Enabled = True
            TxtREASON.Enabled = True
        End If









        Call CheckCourseMaster()

        Call CheckRRSNO()


        Call LockFormData()


        If strStatusDelete = "Close" Then

            Call DisabledText()

            TabPage2.Enabled = False
            bntAddItem.Enabled = False
        Else

            TabPage2.Enabled = True
            bntAddItem.Enabled = True

        End If
        If strSELECTSYSTEM = "DP" Then

            If strStatusDelete = "รอประกาศใช้" Then 'And Mid(TxtDOCNO.Text, 2, 3) = "JSA" Then
                Call DisabledText()

                TabPage2.Enabled = False
                bntAddItem.Enabled = False

            End If
        End If



        TxtDOCTYPE.Enabled = False

        For Each dr As DataGridViewRow In dgvDATA.Rows

            If dr.Selected = True Then
                intSelectedRow = dr.Index
                StrFunction.RowSelected = intSelectedRow


            End If
        Next

        ' StrFunction.process = 2
        StrFunction.DOC_APPROVE = 2
        StrFunction.ClickDATA = 2

        Try
            BackgroundWorker4.RunWorkerAsync()
        Catch ex As Exception


        End Try


        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
        End Try

        Try
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception
        End Try

        Try
            BackgroundWorker3.RunWorkerAsync()
        Catch ex As Exception
        End Try
    End Sub
    Sub CheckRRSNO()


        Dim Sql As String = "SELECT RRSNO, RecLogonID "
        Sql = Sql + " FROM  QEa_DocSys_ReceiveDoc "
        Sql = Sql + " WHERE RRSNO = '" & strRRSNO & "' "
        Sql = Sql + " Order by RRSNO, RecLogonID asc "

        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        lblStatusRRSNO.Text = "."
        For Each Dtr As DataRow In Dt.Rows

            If Dtr.Item("RecLogonID").ToString <> "" Then

                lblStatusRRSNO.Text = strRRSNO & " " & ": " & "รับ-คืน เอกสารเรียบร้อยแล้ว"
            Else
                lblStatusRRSNO.Text = "."
            End If

        Next

    End Sub
    Sub LoadDataGridSelect()
        Try


            strDEPTJOIN = ","
            ' CmdExcute("DELETE FROM QEa_DocSysItem_SelectDept  WHERE REFNO='" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "'  AND  DOCNO ='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
            'dgvDataDept.DataSource = Nothing
            dgvDataDept.Rows.Clear()
            Call LoadDataDept()

            Dim Sql2 As String = "SELECT * from QEa_DocSysItem_SelectDept "
            Sql2 = Sql2 + " WHERE REFNO='" & TxtREFNO.Text & "'  "
            Sql2 = Sql2 + " AND  REFNODATA ='" & TxtREFNODATA.Text & "' "
            Sql2 = Sql2 + " AND  DOCNO ='" & TxtDOCNO.Text & "'  "

            Dim Dt2 As New DataTable
            Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            'dgvCopyNo.Rows.Clear()
            Dim intNo As Integer = 1
            For Each Dtr2 As DataRow In Dt2.Rows


                With Me.dgvDataDept
                    For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                        If .Item(1, i).Value.ToString = Dtr2.Item("DeptCod").ToString Then

                            .Item(0, i).Value = True

                            strDEPTJOIN = strDEPTJOIN & Dtr2.Item("DeptCod").ToString & ","


                        End If
                    Next

                End With

                '  Exit Sub
            Next

            strDEPTJOIN = strDEPTJOIN.Trim().Remove(strDEPTJOIN.Length - 1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub menuDelete_Click_1(sender As Object, e As EventArgs) Handles menuDelete.Click
        Try

            Select Case strChekGrid
                Case "Additem"

                    If strLineDataDAR = "" Then

                        Dim Sms As String = "คุณต้องการลบข้อมูล :" & strLineData & "    ออก จากรายการ หรือไม่?"
                        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub

                        CmdExcute("DELETE FROM QEa_DocSysItem  WHERE RefNo='" & TxtREFNO.Text & "' " &
                                   "AND REFNODATA='" & strLineData & "' ", DB_CMD.ObjConn)
                        Call LoadGridData()


                    Else

                        For Each dr As DataGridViewRow In dgvQE.Rows

                            If dr.Selected = True Then
                                intSelectedRow = dr.Index
                                StrFunction.RowSelected = intSelectedRow
                            End If

                        Next


                        StrFunction.DeleteDAR = 2
                        Try
                            BackgroundWorker1.RunWorkerAsync()
                        Catch ex As Exception

                        End Try


                        FrmCommentDelete.ShowDialog()

                        'Dim Sms As String = "คุณต้องการลบข้อมูล :" & strLineData & "    ออก จากรายการ หรือไม่?"
                        'If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub

                        'CmdExcute("DELETE FROM QEa_DocSysItem  WHERE RefNo='" & TxtREFNO.Text & "' " &
                        '           "AND REFNODATA='" & strLineData & "' ", DB_CMD.ObjConn)
                        'Call LoadGridData()



                    End If


                Case "ApproveDar"

                    Dim Sms As String = "คุณต้องการลบข้อมูล :" & strIDApproveDar & "    ออก จากรายการ หรือไม่?"
                    If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub

                    CmdExcute("DELETE FROM QEa_DocSys_DarApprove  WHERE RefNo='" & TxtREFNO.Text & "' " &
                               "AND REFNODATA='" & strLineRefNoData & "' " &
                               "AND IDApprove ='" & strIDApproveDar & "' ", DB_CMD.ObjConn)

                    Call LoadDOCAPPROVEDAR()

            End Select



        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDATA_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDATA.CellMouseUp
        Try


            If e.Button = MouseButtons.Right Then
                Me.dgvDATA.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex

                strLineData = ""
                strChekGrid = ""
                strChekGrid = "Additem"
                strLineRefNoData = ""
                strLineRefNoData = TxtREFNO.Text
                strLineData = dgvDATA.Rows(e.RowIndex).Cells(14).Value().ToString.Trim()
                strLineDataDAR = dgvDATA.Rows(e.RowIndex).Cells(5).Value().ToString.Trim()
                strRRSNO = Me.dgvDATA.Item(9, Me.dgvDATA.CurrentRow.Index).Value

                Me.MetroContextMenu1.Show(Me.dgvDATA, e.Location)
                MetroContextMenu1.Show(Cursor.Position)

                If strSELECTSYSTEM = "KM" Or TxtORGJD.Checked = True Or TxtJobD.Checked = True Then

                    bntLinkReciveForm.Visible = False
                    CheckMaxLineDataApproveAttfile(TxtREFNO.Text, TxtREFNODATA.Text)
                    Dim command As New SqlCommand("SELECT  * FROM QEa_DocSysItem_Approve " &
                                     "WHERE REFNODATA ='" & TxtREFNODATA.Text & "'" &
                                     "AND LINEDATA ='" & strMaxLineDataAttfile & "'" &
                                     "AND QEMRAPPROVE ='Pass' " &
                                     "And REFNO ='" & TxtREFNO.Text & "'", DB_CMD.ObjConn)
                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        CopyItemToolStripMenuItem.Visible = True
                    Else
                        CopyItemToolStripMenuItem.Visible = False

                    End If
                Else
                    bntLinkReciveForm.Visible = True
                    CopyItemToolStripMenuItem.Visible = False
                End If


            End If



            If (TxtSTANDARD.Checked = True And strSELECTSYSTEM = "DP") Then
                CopyItemToolStripMenuItem.Visible = True
            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvQE_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQE.CellContentClick

    End Sub

    Private Sub dgvQE_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvQE.CellMouseDoubleClick
        strRefNo = TxtREFNO.Text
        strRefNoData = TxtREFNODATA.Text
        intLINEDATA = Me.dgvQE.Item(0, Me.dgvQE.CurrentRow.Index).Value
        StrDARNO = TxtDarNo.Text
        'strDRrsNoRecieve = Me.grdDetail.Item(0, Me.grdDetail.CurrentRow.Index).Value


        For Each dr As DataGridViewRow In dgvQE.Rows

            If dr.Selected = True Then
                intSelectedRow = dr.Index
                StrFunction.RowSelected = intSelectedRow
            End If

        Next


        For Each dr As DataGridViewRow In dgvDATA.Rows

            If dr.Selected = True Then
                intSelectedRow = dr.Index
                StrFunction.RowSelected = intSelectedRow


            End If
        Next


        StrFunction.DOC_APPROVE = 2
        Try
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception

        End Try


        strShowFoam = "DOC_APPROVE"
        ' FrmCARReply.Close()
        ' strFormShowGrid = "CarNo"
        CommandTypeApprove = "Edit"
        FrmApproveDAR.Close()
        FrmApproveDAR.ShowDialog()
    End Sub



    Private Sub BackgroundWorker2_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Do Until 1 = StrFunction.DOC_APPROVE

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")


        '  Me.dgvDATA.Rows(StrFunction.RowSelected).Selected = True
        '  dgvDATA.FirstDisplayedScrollingRowIndex = StrFunction.RowSelected


    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Try


            Select Case strShowFoam
                Case "DOC_APPROVE"

                    Call LoadDOCAPPROVE()
                    Call LoadGridData()

            End Select


            Me.dgvDATA.ClearSelection()

            Me.dgvDATA.Rows(StrFunction.RowSelected).Selected = True
            dgvDATA.FirstDisplayedScrollingRowIndex = StrFunction.RowSelected
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadDOCAPPROVE()
        Me.dgvQE.AllowUserToAddRows = True
        Dim cri As String = ""
        Dim strSystem As String = ""

        Dim Sql As String = "Select * "
        Sql = Sql + "FROM QEa_DocSysItem_Approve "
        Sql = Sql + "WHERE RefNo='" & TxtREFNO.Text & "' AND RefNoData='" & TxtREFNODATA.Text & "' "
        Sql = Sql + "Order by RefNo,RefNoData asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvQE.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvQE
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                '.Item(0, .Rows.Count - 2).Value = intNo
                '.Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("LINEDATA").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("QEOFFICERAPPROVE").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("QEOFFICERNAME").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("QEOFFICERDATE").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("QEOFFICERREASON").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("QEMGRAPPROVE").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("QEMGRNAME").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("QEMGRDATE").ToString
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("QEMGRREASON").ToString
                .Item(9, .Rows.Count - 2).Value = Dtr.Item("QEMRAPPROVE").ToString
                .Item(10, .Rows.Count - 2).Value = Dtr.Item("QEMRNAME").ToString
                .Item(11, .Rows.Count - 2).Value = Dtr.Item("QEMRDATE").ToString
                .Item(12, .Rows.Count - 2).Value = Dtr.Item("QEMRREASON").ToString
                .Item(13, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                .Item(14, .Rows.Count - 2).Value = Dtr.Item("REFNODATA").ToString


            End With
            ' intNo = intNo + 1
        Next
        Me.dgvQE.AllowUserToAddRows = False

    End Sub

    Sub LoadDOCAPPROVEDAR()
        Me.dgvApprove3.AllowUserToAddRows = True
        Dim cri As String = ""
        Dim strSystem As String = ""

        Dim Sql As String = "Select * "
        Sql = Sql + "FROM QEa_DocSys_DarApprove "
        Sql = Sql + "WHERE RefNo='" & TxtREFNO.Text & "' AND RefNoData='" & TxtREFNODATA.Text & "' "
        Sql = Sql + "Order by RefNo,RefNoData asc"
        Dim Dt As New DataTable

        Dt = DB_CMD.GetData_TableNew(Sql, DB_CMD.ObjConn)
        dgvApprove3.Rows.Clear()

        Dim intNo As Integer = 1
        strCheckBntMgr = ""
        For Each Dtr As DataRow In Dt.Rows
            With dgvApprove3
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                '.Item(0, .Rows.Count - 2).Value = intNo
                '.Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("NameApprove").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("DeptApprove").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("EmailApprove").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("IDApprove").ToString


            End With
            intNo = intNo + 1
            strCheckBntMgr = "Data"
        Next

        Me.dgvApprove3.AllowUserToAddRows = False

    End Sub

    Private Sub TxtQEoff8_SelectedIndexChanged(sender As Object, e As EventArgs)
        If TxtQEoff8.Text = "" Then
            TxtQEoffName8.Text = ""
            TxtQEoffDate8.Text = ""
        Else
            TxtQEoffName8.Text = StrUserName
            TxtQEoffDate8.Text = TxtDateNow.Text
        End If

    End Sub

    Private Sub TxtQE8_SelectedIndexChanged(sender As Object, e As EventArgs)
        If TxtQE8.Text = "" Then
            TxtQEName8.Text = ""
            TxtQEDate8.Text = ""
        Else
            TxtQEName8.Text = StrUserName
            TxtQEDate8.Text = TxtDateNow.Text
        End If
    End Sub

    Private Sub bntApprove3_Click(sender As Object, e As EventArgs) Handles bntApprove3.Click
        CommandApproveDAR = "Addnew"

        'Call CheckMaxLineData()


        strRefNo = TxtREFNO.Text
        strRefNoData = TxtREFNODATA.Text


        strShowFoam = "DOC_APPROVEDAR"
        StrFunction.DOC_APPROVEDAR = 2
        Try

            BackgroundWorker3.RunWorkerAsync()

        Catch ex As Exception

        End Try



        FrmUserLogOn.Close()
        FrmUserLogOn.ShowDialog()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Do Until 1 = StrFunction.DOC_APPROVEDAR

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")

    End Sub

    Private Sub BackgroundWorker3_ProgressChanged(sender As Object, e As ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker3.ProgressChanged

    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        Select Case strShowFoam
            Case "DOC_APPROVEDAR"
                Call LoadDOCAPPROVEDAR()



        End Select
    End Sub

    Private Sub dgvApprove3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApprove3.CellContentClick

    End Sub

    Private Sub dgvApprove3_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvApprove3.CellMouseUp
        Try


            If e.Button = MouseButtons.Right Then
                Me.dgvApprove3.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex

                strLineData = ""
                strChekGrid = ""
                strChekGrid = "ApproveDar"
                strLineRefNoData = ""
                strLineRefNoData = TxtREFNODATA.Text
                strLineRefNo = TxtREFNO.Text
                ' strLineData = dgvDATA.Rows(e.RowIndex).Cells(12).Value().ToString.Trim()
                strIDApproveDar = dgvApprove3.Rows(e.RowIndex).Cells(4).Value().ToString.Trim()

                Me.MetroContextMenu1.Show(Me.dgvApprove3, e.Location)
                MetroContextMenu1.Show(Cursor.Position)


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub miniToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles miniToolStrip.ItemClicked

    End Sub

    Private Sub dgvApprove3_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvApprove3.MouseUp

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Call SAVEDATADAR()
    End Sub

    Sub SAVEDATADAR()


        Dim Sql As String = Nothing
        Dim Year As Integer = CInt(Format(Now, "yyyy"))
        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))



        '  Try
        ''ตรวจสอบ ข้อมูลก่อนบันทึก
        'If CheckData() = False Then
        '    MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
        '    Exit Sub
        'Else




        'If CommandType = "Addnew" Then

        'End If

        'If TxtMANUAL.Checked = False And TxtPROCEDURED.Checked = False And TxtWORKIN.Checked = False And TxtSTANDARD.Checked = False And TxtRECORD.Checked = False And TxtKM.Checked = False And TxtORGJD.Checked = False And TxtJobD.Checked = False Then
        '    MsgBox("กรุณาเลือก : ระบบ ")
        '    Exit Sub
        'End If

        'If TxtACTNEW.Checked = False And TxtACTAMD.Checked = False And TxtACTOBS.Checked = False And TxtACTCPY.Checked = False And TxtCTRPL.Checked = False Then
        '    MsgBox("กรุณาเลือก : ประเภทข้อบกพร่อง")
        '    Exit Sub
        'End If



        'If TxtDOCNO.Text = "" Then
        '    MsgBox("กรุณา : กำหนด เอกสารเลขที่ Doc.No ")
        '    TxtDOCNO.Focus()
        '    Exit Sub
        'End If

        'If TxtDOCNAME.Text = "" Then
        '    MsgBox("กรุณา : กำหนด ชื่อเรื่อง ( TH )")
        '    TxtDOCNAME.Focus()
        '    Exit Sub
        'End If

        'If TxtDOCDEPT.Text = "" Then
        '    MsgBox("กรุณา : กำหนด เอกสารของฝ่าย Dept")
        '    TxtDOCDEPT.Focus()
        '    Exit Sub
        'End If

        'If TxtREVNO.Text = "" Then
        '    MsgBox("กรุณา : กำหนด แก้ไขครั้งที่ Rev.")
        '    TxtREVNO.Focus()
        '    Exit Sub
        'End If

        'If TXTDOCSHARE.Text = "" Then
        '    MsgBox("กรุณา : กำหนด Share , Dept ")
        '    TXTDOCSHARE.Focus()
        '    Exit Sub
        'End If

        'If TxtTYPEATTFILE.Text = "" Then
        '    MsgBox("กรุณา : กำหนด ประเภทเอกสารแนบ")
        '    TxtTYPEATTFILE.Focus()
        '    Exit Sub

        'End If


        ''If CommandType = "Edit" Then

        ''    If TxtMGRAPP.Text = "" Then
        ''        MsgBox("กรุณา : กำหนด ผู้จัดการฝ่าย ")
        ''        TxtMGRAPP.Focus()
        ''        Exit Sub
        ''    End If

        ''End If




        With QEa_DocSys_Dar




            .Branch = strBranchConn
            '.STATUS = TxtSTATUS.Text
            '.Flag = TxtFlag.Text
            '.Month = TxtMonth.Text
            .REFNO = TxtREFNO.Text
            .REFNODATA = TxtREFNODATA.Text
            .DARNO = TxtDarNo.Text
            .QEoff1 = TxtQEoff1.Text
            .QEoff1Date = TxtQEoff1Date.Text
            .AttDoc1 = TxtAttDoc1.Text
            .AttDoc1Date = TxtAttDoc1Date.Text
            .SendDocSrv1 = TxtSendDocSrv1.Text
            .SendDocSrv1Date = TxtSendDocSrv1Date.Text
            ' If TxtSendDocSrv1.Text <> "" Then
            .SendDocDate1 = TxtSendDocDate11.Text
            'Else
            '.SendDocDate1 = ""

            '  End If


            .RecDocDate1 = TxtRecDocDate11.Text
            .RetReaSon1 = TxtRetReaSon1.Text
            .PrintCheck2 = TxtPrintCheck2.Text

            ' If TxtPrintCheck2.Text = "จัดการ" Then
            .PrintDate2 = TxtPrintDate2.Text
            'End If

            .ChkStartApprove3 = TxtChkStartApprove3.Text

            'If TxtChkStartApprove3.Text = "จัดการ" Then
            .ChkStartDate3 = TxtChkStartDate3.Text
            ' End If

            .ChkEndApprove3 = TxtChkEndApprove3.Text

            'If TxtChkEndApprove3.Text = "จัดการ" Then
            .ChkEndDate3 = TxtChkEndDate3.Text
            'End If





            .Copy4 = TxtCopy4.Text
            .Server4 = TxtServer4.Text
            .Link4 = TxtLink4.Text
            .HardCopy5 = TxtHardCopy5.Text
            .Email5 = TxtEmail5.Text
            .HardCopy6 = TxtHardCopy6.Text
            .Server6 = TxtServer6.Text
            .LinkPdf7 = TxtLinkPdf7.Text
            .QEoff8 = TxtQEoff8.CheckState
            .QEoffName8 = TxtQEoffName8.Text
            .QEoffDate8 = TxtQEoffDate8.Text
            .QE8 = TxtQE8.CheckState
            .QEName8 = TxtQEName8.Text
            .QEDate8 = TxtQEDate8.Text
            .LinkFilePDF = TxtLinkFilePDF.Text



            ' .UserRunDar = TxtUserRunDar.Text
            ' .DateRunDar = TxtDateRunDar.Text



            'Select Case CommandTypeNew
            '    'Case "Addnew"
            '    '    Sql = .SqlCommandInsert
            'Case "Edit"
            Sql = .SqlCommandUpdate
            'End Select
            If CmdExcute(Sql, DB_CMD.ObjConn) = True Then
                StrFunction.DocSystem = 1
                MsgBox("บันทึกข้อมูล รายละเอียด DAR สำเร็จ")
                Call UpdateStatusDAR()

                'If strTxtAppMgrEmail = "Email" Then
                '    Call SendEmailToUser()
                'End If


                'If strTxtAppMREmail = "Email" Then
                '    Call SendEmailToUser()
                'End If

                Call LoadGridData()

            Else
                MsgBox("ไม่สามารถบันทึกข้อมูลได้")
            End If
        End With



        Me.dgvDATA.ClearSelection()

        Me.dgvDATA.Rows(StrFunction.RowSelected).Selected = True
        dgvDATA.FirstDisplayedScrollingRowIndex = StrFunction.RowSelected


        'End If

        ' Call DisabledText()
        ' Call ClearTextDAR()

        ' bntAddItem.Enabled = True

    End Sub

    Sub UpdateStatusDAR()


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


            'If TxtLinkFilePDF.Text = "" Then

            '    strStatus = "รอเอกสารลงนาม"

            'End If

            strStatus = ""

            If TxtQEoff8.Checked = True Then

                strStatus = "รอ SD Chief ทวนสอบ"

            End If


            If TxtQE8.Checked = True Then

                strStatus = "Close"

            End If


            If strStatus <> "" Then

                Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                                              "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                              "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

                myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = strStatus
                ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

            End If




        Catch ex As Exception

        End Try


    End Sub


    Sub ClearTextDAR()

        ' TabPage_2

        TxtQEoff1.Text = ""
        TxtAttDoc1.Text = ""
        TxtSendDocSrv1.Text = ""
        TxtSendDocDate11.Text = ""
        TxtRecDocDate11.Text = ""
        TxtRetReaSon1.Text = ""
        TxtPrintCheck2.Text = ""
        TxtPrintDate2.Text = ""
        TxtChkStartApprove3.Text = ""
        TxtChkStartDate3.Text = ""
        TxtChkEndApprove3.Text = ""
        TxtChkEndDate3.Text = ""
        TxtCopy4.Text = ""
        TxtServer4.Text = ""
        TxtLink4.Text = ""
        TxtHardCopy5.Text = ""
        TxtEmail5.Text = ""
        TxtHardCopy6.Text = ""
        TxtServer6.Text = ""
        TxtLinkPdf7.Text = ""
        TxtQEoff8.Text = ""
        TxtQEoffName8.Text = ""
        TxtQEoffDate8.Text = ""
        TxtQE8.Text = ""
        TxtQEName8.Text = ""
        TxtQEDate8.Text = ""


        dgvApprove3.Rows.Clear()


    End Sub

    Sub LoadDataDAR()

        Try



            Dim cri As String = ""
            Dim strSystem As String = ""

            Dim Sql As String = "Select * "
            Sql = Sql + "FROM QEa_DocSys_Dar "
            Sql = Sql + "WHERE RefNo='" & TxtREFNO.Text & "' AND RefNoData='" & TxtREFNODATA.Text & "' AND DARNO = '" & TxtDarNo.Text & "' "
            Sql = Sql + "Order by RefNo,RefNoData asc"
            Dim Dt As New DataTable

            Dt = DB_CMD.GetData_TableNew(Sql, DB_CMD.ObjConn)


            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows


                TxtQEoff1.Text = Dtr.Item("QEoff1").ToString()
                TxtQEoff1Date.Text = Dtr.Item("QEoff1Date").ToString()
                TxtAttDoc1.Text = Dtr.Item("AttDoc1").ToString()
                TxtAttDoc1Date.Text = Dtr.Item("AttDoc1Date").ToString()
                TxtSendDocSrv1.Text = Dtr.Item("SendDocSrv1").ToString()
                TxtSendDocSrv1Date.Text = Dtr.Item("SendDocSrv1Date").ToString()

                TxtSendDocDate11.Text = Dtr.Item("SendDocDate1").ToString()
                TxtRecDocDate11.Text = Dtr.Item("RecDocDate1").ToString()
                TxtRetReaSon1.Text = Dtr.Item("RetReaSon1").ToString()
                TxtPrintCheck2.Text = Dtr.Item("PrintCheck2").ToString()
                TxtPrintDate2.Text = Dtr.Item("PrintDate2").ToString()
                TxtChkStartApprove3.Text = Dtr.Item("ChkStartApprove3").ToString()
                TxtChkStartDate3.Text = Dtr.Item("ChkStartDate3").ToString()
                TxtChkEndApprove3.Text = Dtr.Item("ChkEndApprove3").ToString()
                TxtChkEndDate3.Text = Dtr.Item("ChkEndDate3").ToString()
                TxtCopy4.Text = Dtr.Item("Copy4").ToString()
                TxtServer4.Text = Dtr.Item("Server4").ToString()
                TxtLink4.Text = Dtr.Item("Link4").ToString()
                TxtHardCopy5.Text = Dtr.Item("HardCopy5").ToString()
                TxtEmail5.Text = Dtr.Item("Email5").ToString()
                TxtHardCopy6.Text = Dtr.Item("HardCopy6").ToString()
                TxtServer6.Text = Dtr.Item("Server6").ToString()
                TxtLinkPdf7.Text = Dtr.Item("LinkPdf7").ToString()

                TxtQEoff8.CheckState = Dtr.Item("QEoff8").ToString()
                TxtQEoffName8.Text = Dtr.Item("QEoffName8").ToString()
                TxtQEoffDate8.Text = Dtr.Item("QEoffDate8").ToString()
                TxtQE8.CheckState = Dtr.Item("QE8").ToString()
                TxtQEName8.Text = Dtr.Item("QEName8").ToString()
                TxtQEDate8.Text = Dtr.Item("QEDate8").ToString()
                TxtLinkFilePDF.Text = Dtr.Item("LinkFilePDF").ToString()


            Next









            'With QEa_DocSys_Dar



            '    .GetData("Select * FROM QEa_DocSys_Dar WHERE REFNO = '" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'", DB_CMD.ObjConn)

            '    '.Branch = TxtBranch.Text
            '    '.STATUS = TxtSTATUS.Text
            '    '.Flag = TxtFlag.Text
            '    '.Month = TxtMonth.Text

            '    'TxtREFNO.Text = .REFNO =
            '    '.REFNODATA = TxtREFNODATA.Text =
            '    '.DARNO = TxtDarNo.Text =
            '    TxtQEoff1.Text = .QEoff1
            '    TxtAttDoc1.Text = .AttDoc1
            '    TxtSendDocSrv1.Text = .SendDocSrv1
            '    TxtSendDocDate11.Text = .SendDocDate1
            '    TxtRecDocDate11.Text = .RecDocDate1
            '    TxtRetReaSon1.Text = .RetReaSon1
            '    TxtPrintCheck2.Text = .PrintCheck2
            '    TxtPrintDate2.Text = .PrintDate2
            '    TxtChkStartApprove3.Text = .ChkStartApprove3
            '    TxtChkStartDate3.Text = .ChkStartDate3
            '    TxtChkEndApprove3.Text = .ChkEndApprove3
            '    TxtChkEndDate3.Text = .ChkEndDate3
            '    TxtCopy4.Text = .Copy4
            '    TxtServer4.Text = .Server4
            '    TxtLink4.Text = .Link4
            '    TxtHardCopy5.Text = .HardCopy5
            '    TxtEmail5.Text = .Email5
            '    TxtHardCopy6.Text = .HardCopy6
            '    TxtServer6.Text = .Server6
            '    TxtLinkPdf7.Text = .LinkPdf7
            '    TxtQEoff8.Text = .QEoff8
            '    TxtQEoffName8.Text = .QEoffName8
            '    TxtQEoffDate8.Text = .QEoffDate8
            '    TxtQE8.Text = .QE8
            '    TxtQEName8.Text = .QEName8
            '    TxtQEDate8.Text = .QEDate8
            '    '.UserRunDar = TxtUserRunDar.Text
            '    '.DateRunDar = TxtDateRunDar.Text

            'End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtREVNO_TextChanged(sender As Object, e As EventArgs) Handles TxtREVNO.TextChanged

    End Sub

    Private Sub TxtREVNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtREVNO.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip3.ItemClicked

    End Sub

    Private Sub TxtDOCDEPT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCDEPT.SelectedIndexChanged

    End Sub

    Private Sub TxtDOCNO_TextChanged(sender As Object, e As EventArgs) Handles TxtDOCNO.TextChanged
        'Call KeyEnterCourse()
    End Sub

    Sub KeyEnterCourse()


        If CommandTypeNew = "Addnew" Then
            Call CheckDocType()


            If TxtACTOBS.Checked = True And TxtCheckDelete.Text = "" Then
                MsgBox("กรุณาเลือกเหตุผล ( ต้องการยกเลิกต้นฉบับ / ยกเลิกสำเนา ) ")

                TxtCheckDelete.Focus()
                Exit Sub
            End If

            If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "" Then

                MsgBox("กรุณาเลือกเหตุผล การนำเอกสารยกเลิกกลับมาใช้งาน  ( ข้อมูลฉบับเดิม  / ข้อมูลมีการแก้ไข ) ")

                TxtUndoDocSelect.Focus()
                Exit Sub

            End If



            If TxtACTCPY.Checked = True And TxtACTCPYSel.Text = "" Then

                MsgBox("กรุณาเลือกการจัดทำสำเนา   ( สำเนาเพิ่ม  / สำเนาทดแทนชุดเดิม ) ")

                TxtACTCPYSel.Focus()

                Exit Sub

            End If




            If TxtMANUAL.Checked = False And TxtPROCEDURED.Checked = False And TxtWORKIN.Checked = False And TxtSTANDARD.Checked = False And TxtRECORD.Checked = False And TxtKM.Checked = False And TxtORGJD.Checked = False And TxtJobD.Checked = False Then
                '   MsgBox("กรุณาเลือก : ระบบ ")
                Exit Sub
            End If

            'If TxtACTNEW.Checked = False And TxtACTAMD.Checked = False And TxtACTOBS.Checked = False And TxtACTCPY.Checked = False And TxtCTRPL.Checked = False And TxtUndoDoc.Checked = False Then
            '    MsgBox("กรุณาเลือก : ประเภทการจัดการ")
            '    Exit Sub
            'End If


            If TxtACTNEW.Checked = False And TxtACTAMD.Checked = False And TxtACTOBS.Checked = False And TxtACTCPY.Checked = False And TxtUndoDoc.Checked = False Then
                MsgBox("กรุณาเลือก : ประเภทการจัดการ")
                Exit Sub
            End If


            '     If TxtACTNEW.Checked = True Or TxtACTAMD.Checked = True Or TxtACTOBS.Checked = True Or TxtACTCPY.Checked = True Or TxtCTRPL.Checked = True Or TxtUndoDoc.Checked = True Then

            If TxtACTNEW.Checked = True Or TxtACTAMD.Checked = True Or TxtACTOBS.Checked = True Or TxtACTCPY.Checked = True Or TxtUndoDoc.Checked = True Then



                'Dim Sql As String = "Select *  from QEa_CourseMaster "
                'Sql = Sql + "WHERE DOCNO ='" & TxtDOCNO.Text & "'"
                'Sql = Sql + "AND  DOCTYPE ='" & strDOCTYPE & "'"
                'Sql = Sql + " Order by DOCTYPE,DOCNO,REVNO asc"
                If TxtUndoDoc.Checked = False Then

                    Dim command As New SqlCommand("SELECT  * FROM QEa_CourseMaster " &
                                     "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                                     "AND STATUS ='I' " &
                                     " And DocType ='" & strDOCTYPE & "'", DB_CMD.ObjConn)

                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then

                        MsgBox("This Course No., Status is Deleted. ")
                        TxtDOCNO.Text = ""
                        TxtDOCNAME.Text = ""
                        TxtREVNO.Text = ""
                        Exit Sub
                    End If

                End If



                Dim Sql As String = "Select * From QEa_CourseMaster "
                Sql = Sql + " WHERE DOCNO ='" & TxtDOCNO.Text & "' "
                Sql = Sql + " AND DOCTYPE ='" & strDOCTYPE & "' "
                Sql = Sql + " AND REVNO In ( Select MAX(REVNO) From QEa_CourseMaster "
                Sql = Sql + " WHERE DOCNO ='" & TxtDOCNO.Text & "' "
                Sql = Sql + " AND DOCTYPE ='" & strDOCTYPE & "' )"





                Dim Dt As New DataTable
                Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

                Dim intNo As Integer = 1
                For Each Dtr As DataRow In Dt.Rows

                    If TxtACTNEW.Checked = True Then

                        MsgBox("เลขที่เอกสารนี้มีในระบบเเล้ว กรุณาเปลี่ยนใหม่ด้วย")
                        TxtDOCNO.Focus()
                        TxtDOCNO.Clear()
                        Exit Sub

                    End If

                    '   TxtDOCNAME.Text = Dtr.Item("DOCNO").ToString
                    TxtDOCNAME.Text = Dtr.Item("DOCNAME").ToString
                    '.Item(2, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString


                    'TxtDOCDEPT.Text = Dtr.Item("DOCDEPT").ToString

                    'If Dtr.Item("DOCDEPT").ToString = "DC" Then
                    '    TXTDOCSHARE.Text = "Share Document"
                    'Else
                    '    TXTDOCSHARE.Text = "Dept"
                    'End If
                    TxtREVNO.Text = ""
                    TxtDOCDEPT.Text = Dtr.Item("DOCDEPT").ToString

                    If TxtACTAMD.Checked = True Or (TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลมีการแก้ไข") Then


                        If TxtJobD.Checked = True Or TxtORGJD.Checked = True Then


                            Dim command As New SqlCommand("SELECT   MAX(REVNO) AS MaxREVNO  FROM QEa_CourseMaster " &
                                    "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                                    "And (YEAR(EFFDATE) = " & intYearNow & ") " &
                                    "HAVING (NOT (MAX(REVNO) IS NULL))", DB_CMD.ObjConn)
                            Dim table As New DataTable
                            Dim adapter As New SqlDataAdapter(command)
                            Dim ds As New DataSet
                            adapter.Fill(table)

                            If table.Rows.Count > 0 Then

                                TxtREVNO.Text = table.Rows(0).Item("MaxREVNO") + 1

                            Else

                                TxtREVNO.Text = 1
                            End If

                        Else
                            TxtREVNO.Text = Dtr.Item("REVNO").ToString + 1
                        End If

                    Else
                        TxtREVNO.Text = Dtr.Item("REVNO").ToString
                    End If


                    TxtEFFDATE.Text = Dtr.Item("EFFDATE").ToString
                    ' TxtDocCtrl.Text = Dtr.Item("EFFDATE").ToString

                    ' TxtDOCNO.Enabled = False
                    TxtDOCNAME.Enabled = True
                    TxtREVNO.Enabled = False

                Next

                Call LoadDataGridSelectMaster()

            Else


                Dim command As New SqlCommand("SELECT  * FROM QEa_CourseMaster " &
                                 "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                                 "AND DOCTYPE ='" & strDOCTYPE & "'", DB_CMD.ObjConn)

                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                Dim ds As New DataSet
                adapter.Fill(table)

                If table.Rows.Count > 0 Then

                    MsgBox("มีเลขที่เอกสารนี้ในระบบเเล้ว ถ้าต้องการใข้งานเลขเอกสารนี้ให้เลือกแก้ไข")
                    TxtDOCNO.Text = ""

                End If
            End If
        End If

        ' TxtDOCNAME.Focus()

    End Sub


    Sub LoadDataGridSelectMaster()

        strDEPTJOIN = ","
        ' CmdExcute("DELETE FROM QEa_DocSysItem_SelectDept  WHERE REFNO='" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "'  AND  DOCNO ='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
        'dgvDataDept.DataSource = Nothing
        dgvDataDept.Rows.Clear()
        Call LoadDataDept()

        Dim Sql2 As String = "SELECT DeptCod "
        Sql2 = Sql2 + " FROM QEa_DocSysItem_SelectDept  "
        Sql2 = Sql2 + " WHERE DOCNO ='" & TxtDOCNO.Text & "' "
        Sql2 = Sql2 + " GROUP BY DeptCod "


        Dim Dt2 As New DataTable
        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
        'dgvCopyNo.Rows.Clear()
        Dim intNo As Integer = 1
        For Each Dtr2 As DataRow In Dt2.Rows


            With Me.dgvDataDept
                For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                    If .Item(1, i).Value.ToString = Dtr2.Item("DeptCod").ToString Then

                        .Item(0, i).Value = True

                        strDEPTJOIN = strDEPTJOIN & Dtr2.Item("DeptCod").ToString & ","


                    End If
                Next

            End With

            '  Exit Sub
        Next

        strDEPTJOIN = strDEPTJOIN.Trim().Remove(strDEPTJOIN.Length - 1)

    End Sub
    Private Sub TxtDOCNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDOCNO.KeyPress
        Call CheckDocType()



        If e.KeyChar = Chr(13) Then


            If TxtACTOBS.Checked = True And TxtCheckDelete.Text = "" Then
                MsgBox("กรุณาเลือกเหตุผล ( ต้องการยกเลิกต้นฉบับ / ยกเลิกสำเนา ) ")

                TxtCheckDelete.Focus()
                Exit Sub
            End If

            If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "" Then

                MsgBox("กรุณาเลือกเหตุผล การนำเอกสารยกเลิกกลับมาใช้งาน  ( ข้อมูลฉบับเดิม  / ข้อมูลมีการแก้ไข ) ")

                TxtUndoDocSelect.Focus()
                Exit Sub

            End If



            If TxtACTCPY.Checked = True And TxtACTCPYSel.Text = "" Then

                MsgBox("กรุณาเลือกการจัดทำสำเนา   ( สำเนาเพิ่ม  / สำเนาทดแทนชุดเดิม ) ")

                TxtACTCPYSel.Focus()

                Exit Sub

            End If




            If TxtMANUAL.Checked = False And TxtPROCEDURED.Checked = False And TxtWORKIN.Checked = False And TxtSTANDARD.Checked = False And TxtRECORD.Checked = False And TxtKM.Checked = False And TxtORGJD.Checked = False And TxtJobD.Checked = False Then
                MsgBox("กรุณาเลือก : ระบบ ")
                Exit Sub
            End If

            'If TxtACTNEW.Checked = False And TxtACTAMD.Checked = False And TxtACTOBS.Checked = False And TxtACTCPY.Checked = False And TxtCTRPL.Checked = False And TxtUndoDoc.Checked = False Then
            '    MsgBox("กรุณาเลือก : ประเภทการจัดการ")
            '    Exit Sub
            'End If


            If TxtACTNEW.Checked = False And TxtACTAMD.Checked = False And TxtACTOBS.Checked = False And TxtACTCPY.Checked = False And TxtUndoDoc.Checked = False Then
                MsgBox("กรุณาเลือก : ประเภทการจัดการ")
                Exit Sub
            End If


            '     If TxtACTNEW.Checked = True Or TxtACTAMD.Checked = True Or TxtACTOBS.Checked = True Or TxtACTCPY.Checked = True Or TxtCTRPL.Checked = True Or TxtUndoDoc.Checked = True Then

            If TxtACTNEW.Checked = True Or TxtACTAMD.Checked = True Or TxtACTOBS.Checked = True Or TxtUndoDoc.Checked = True Then

                Dim command1 As New SqlCommand("SELECT  * FROM QEa_DocSysItem " &
                                     "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                                     " And DocType ='" & strDOCTYPE & "' " &
                                     " And STATUS <> 'Close' AND  STATUS <> 'Delete' ", DB_CMD.ObjConn)

                Dim table1 As New DataTable
                Dim adapter1 As New SqlDataAdapter(command1)
                Dim ds1 As New DataSet
                adapter1.Fill(table1)

                If table1.Rows.Count > 0 Then

                    MsgBox("เลขที่เอกสารนี้อยู่ระหว่างการจัดการเอกสาร" & " (REFNO :" & table1.Rows(0).Item("REFNO").ToString & ")  ,      (Status : " & table1.Rows(0).Item("STATUS").ToString & ")", MsgBoxStyle.Information, "เเจ้งเตือน!!!!")
                    TxtDOCNO.Focus()
                    TxtDOCNO.Text = ""
                    TxtDOCNAME.Text = ""
                    TxtREVNO.Text = ""
                    Exit Sub
                End If

                'Dim Sql As String = "Select *  from QEa_CourseMaster "
                'Sql = Sql + "WHERE DOCNO ='" & TxtDOCNO.Text & "'"
                'Sql = Sql + "AND  DOCTYPE ='" & strDOCTYPE & "'"
                'Sql = Sql + " Order by DOCTYPE,DOCNO,REVNO asc"
                If TxtUndoDoc.Checked = False Then

                    Dim command As New SqlCommand("SELECT  * FROM QEa_CourseMaster " &
                                     "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                                     "AND STATUS ='I' " &
                                     " And DocType ='" & strDOCTYPE & "'", DB_CMD.ObjConn)

                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then

                        MsgBox("This Course No., Status is Deleted. ", MsgBoxStyle.Information, "เเจ้งเตือน!!!!")
                        TxtDOCNO.Text = ""
                        TxtDOCNAME.Text = ""
                        TxtREVNO.Text = ""
                        Exit Sub
                    End If

                End If


                If TxtACTAMD.Checked = True Or TxtACTOBS.Checked = True Or TxtACTCPY.Checked = True Or TxtUndoDoc.Checked = True Then

                    Dim command As New SqlCommand("SELECT  * FROM QEa_CourseMaster " &
                                     "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                                     " And DocType ='" & strDOCTYPE & "'", DB_CMD.ObjConn)

                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then

                        MsgBox("เลขที่เอกสารนี้ไม่มีในระบบ กรุณาติดต่อฝ่าย SD", MsgBoxStyle.Information, "เเจ้งเตือน!!!!")
                        TxtDOCNO.Focus()
                        TxtDOCNO.Text = ""
                        TxtDOCNAME.Text = ""
                        TxtREVNO.Text = ""
                        Exit Sub
                    End If



                End If




                Dim Sql As String = "Select * From QEa_CourseMaster "
                Sql = Sql + " WHERE DOCNO ='" & TxtDOCNO.Text & "' "
                Sql = Sql + " AND DOCTYPE ='" & strDOCTYPE & "' "
                Sql = Sql + " AND REVNO In ( Select MAX(REVNO) From QEa_CourseMaster "
                Sql = Sql + " WHERE DOCNO ='" & TxtDOCNO.Text & "' "
                Sql = Sql + " AND DOCTYPE ='" & strDOCTYPE & "' )"





                Dim Dt As New DataTable
                Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

                Dim intNo As Integer = 1
                For Each Dtr As DataRow In Dt.Rows

                    If TxtACTNEW.Checked = True Then

                        MsgBox("เลขที่เอกสารนี้มีในระบบเเล้ว กรุณาเปลี่ยนใหม่ด้วย", MsgBoxStyle.Information, "เเจ้งเตือน!!!!")
                        TxtDOCNO.Focus()
                        TxtDOCNO.Clear()
                        Exit Sub

                    End If

                    '   TxtDOCNAME.Text = Dtr.Item("DOCNO").ToString
                    TxtDOCNAME.Text = Dtr.Item("DOCNAME").ToString
                    '.Item(2, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString


                    'TxtDOCDEPT.Text = Dtr.Item("DOCDEPT").ToString

                    'If Dtr.Item("DOCDEPT").ToString = "DC" Then
                    '    TXTDOCSHARE.Text = "Share Document"
                    'Else
                    '    TXTDOCSHARE.Text = "Dept"
                    'End If



                    TxtDOCDEPT.Text = Dtr.Item("DOCDEPT").ToString

                    If TxtACTAMD.Checked = True Or (TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลมีการแก้ไข") Then
                        'TxtREVNO.Text = Dtr.Item("REVNO").ToString + 1

                        If TxtJobD.Checked = True Or TxtORGJD.Checked = True Then


                            Dim command As New SqlCommand("SELECT   MAX(REVNO) AS MaxREVNO  FROM QEa_CourseMaster " &
                                    "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                                    "And (YEAR(EFFDATE) = " & intYearNow & ") " &
                                    "HAVING (NOT (MAX(REVNO) IS NULL))", DB_CMD.ObjConn)
                            Dim table As New DataTable
                            Dim adapter As New SqlDataAdapter(command)
                            Dim ds As New DataSet
                            adapter.Fill(table)

                            If table.Rows.Count > 0 Then

                                TxtREVNO.Text = table.Rows(0).Item("MaxREVNO") + 1
                                'TxtEFFDATE.Text = Dtr.Item("EFFDATE").ToString
                            Else

                                TxtREVNO.Text = 1
                                ' TxtEFFDATE.Text = TxtDateNow.Text
                            End If

                        Else
                            TxtREVNO.Text = Dtr.Item("REVNO").ToString + 1
                            '  TxtEFFDATE.Text = Dtr.Item("EFFDATE").ToString
                        End If



                    Else
                        TxtREVNO.Text = Dtr.Item("REVNO").ToString
                        ' TxtEFFDATE.Text = TxtDateNow.Text
                    End If

                    TxtEFFDATE.Text = TxtDateNow.Text

                    ' TxtDocCtrl.Text = Dtr.Item("EFFDATE").ToString

                    TxtDOCNO.Enabled = False
                    TxtDOCNAME.Enabled = True
                    TxtREVNO.Enabled = False

                Next

                Call LoadDataGridSelectMaster()



            Else


                Dim command As New SqlCommand("SELECT  * FROM QEa_CourseMaster " &
                                 "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                                 "AND DOCTYPE ='" & strDOCTYPE & "'", DB_CMD.ObjConn)

                    Dim table As New DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then

                    MsgBox("มีเลขที่เอกสารนี้ในระบบเเล้ว ถ้าต้องการใข้งานเลขเอกสารนี้ให้เลือกแก้ไข", MsgBoxStyle.Information, "เเจ้งเตือน!!!!")
                    TxtDOCNO.Text = ""

                    End If
                End If
            End If

        ' TxtDOCNAME.Focus()

    End Sub

    Sub CheckDocType()

        If TxtMANUAL.Checked = True Then
            strDOCTYPE = "MNL"
        ElseIf TxtPROCEDURED.Checked = True Then
            strDOCTYPE = "PRC"
        ElseIf TxtWORKIN.Checked = True Then
            strDOCTYPE = "WIN"
        ElseIf TxtSTANDARD.Checked = True Then
            strDOCTYPE = "STD"
        ElseIf TxtRECORD.Checked = True Then
            strDOCTYPE = "RCF"
        ElseIf TxtKM.Checked = True Then
            strDOCTYPE = "KMM"
        ElseIf TxtORGJD.Checked = True Then
            strDOCTYPE = "OGN"
        ElseIf TxtJobD.Checked = True Then
            strDOCTYPE = "JOB"
        End If


    End Sub

    Private Sub TxtACTAMD_CheckedChanged(sender As Object, e As EventArgs) Handles TxtACTAMD.CheckedChanged

        Call ClearTextChange()
        TxtDOCNO.Focus()
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtACTNEW_CheckedChanged(sender As Object, e As EventArgs) Handles TxtACTNEW.CheckedChanged
        ' strLabelCopy = ""
        Call ClearTextChange()
        TxtDOCNO.Focus()
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtACTOBS_CheckedChanged(sender As Object, e As EventArgs) Handles TxtACTOBS.CheckedChanged
        Call ClearTextChange()
        TxtCheckDelete.Text = ""
        TxtCheckDelete.Enabled = True
        TxtDOCNO.Focus()
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtACTCPY_CheckedChanged(sender As Object, e As EventArgs) Handles TxtACTCPY.CheckedChanged

        Call ClearTextChange()
        TxtACTCPYSel.Enabled = True
        TxtACTCPYSel.Text = ""
        TxtDOCNO.Focus()
        TxtDOCNO.Enabled = True

    End Sub

    Private Sub TxtCTRPL_CheckedChanged(sender As Object, e As EventArgs) Handles TxtCTRPL.CheckedChanged
        Call ClearTextChange()
        TxtDOCNO.Focus()
        TxtDOCNO.Enabled = True
    End Sub

    Sub ClearTextChange()
        TxtDOCNO.Text = ""
        TxtDOCNAME.Text = ""
        TxtREVNO.Text = ""
        TxtREASON.Text = ""
        TxtDOCDEPT.Text = ""
        TxtEFFDATE.Text = ""
        TxtCheckDelete.Text = ""
        TxtCheckDelete.Enabled = False
        TxtACTCPYSel.Enabled = False
        TxtUndoDocSelect.Enabled = False
    End Sub

    Private Sub BackgroundWorker1_DoWork_1(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until 1 = StrFunction.DeleteDAR

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")
    End Sub

    Private Sub MetroContextMenu1_Opening(sender As Object, e As ComponentModel.CancelEventArgs) Handles MetroContextMenu1.Opening

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted_1(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Call LoadGridData()


        Me.dgvDATA.ClearSelection()

        Me.dgvDATA.Rows(StrFunction.RowSelected).Selected = True
        dgvDATA.FirstDisplayedScrollingRowIndex = StrFunction.RowSelected

        ' Me.dgvDATA.Rows(StrFunction.RowSelected).Selected = True
        ' dgvDATA.FirstDisplayedScrollingRowIndex = StrFunction.RowSelected
    End Sub


    Private Sub dgvDATA_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDATA.CellFormatting

        For Each Row As DataGridViewRow In dgvDATA.Rows


            If CStr(Row.Cells("STATUS").Value) = "Delete" Then
                Row.DefaultCellStyle.ForeColor = Color.White

                Row.DefaultCellStyle.BackColor = Color.Orange

            End If


            'If CStr(Row.Cells("JobStatus").Value) = "รอดำเนินการจากฝ่าย iT" Then
            '    Row.DefaultCellStyle.ForeColor = Color.White

            '    Row.DefaultCellStyle.BackColor = Color.Green

            'End If




        Next
    End Sub

    Private Sub TxtDOCTYPE_Enter(sender As Object, e As EventArgs) Handles TxtDOCTYPE.Enter

    End Sub

    Private Sub TxtCheckDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtCheckDelete.SelectedIndexChanged
        TxtDOCNO.Focus()
    End Sub
    Private Sub CopyItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyItemToolStripMenuItem.Click

        'If TxtMGRAPP.Text = "" Or TxtMGRAPP.Text = "ไม่อนุมัติ" Then
        '    MsgBox("ไม่สามารถ Click Update ได้ เนื่องจากผู้จัดการไม่ อนุมัติ", MsgBoxStyle.Exclamation, "เเจ้งเตือนจากระบบ")
        '    Exit Sub
        'End If

        'Dim Sms As String = "คุณต้องการ Update Course Master  :" & TxtDOCNO.Text & "    หรือไม่?"
        'If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub

        'CmdExcute("DELETE FROM QEa_CourseMaster  WHERE DOCNO='" & TxtDOCNO.Text & "' " &
        '                           "AND REVNO='" & TxtREVNO.Text & "' ", DB_CMD.ObjConn)


        'Dim strDOCTYPE As String = ""
        'If TxtMANUAL.Checked = True Then
        '    strDOCTYPE = "MNL"
        'ElseIf TxtPROCEDURED.Checked = True Then
        '    strDOCTYPE = "PRC"
        'ElseIf TxtWORKIN.Checked = True Then
        '    strDOCTYPE = "WIN"
        'ElseIf TxtSTANDARD.Checked = True Then
        '    strDOCTYPE = "STD"
        'ElseIf TxtRECORD.Checked = True Then
        '    strDOCTYPE = "RCF"
        'ElseIf TxtKM.Checked = True Then
        '    strDOCTYPE = "KMM"
        'ElseIf TxtORGJD.Checked = True Then
        '    strDOCTYPE = "OGN"
        'ElseIf TxtJobD.Checked = True Then
        '    strDOCTYPE = "JOB"
        'End If

        'Dim strDOCSHARE As String = ""
        'Select Case TXTDOCSHARE.Text
        '    Case "Share Document"
        '        strDOCSHARE = "DC"
        '    Case "Dept"
        '        strDOCSHARE = TxtDOCDEPT.Text
        'End Select




        'Dim Sql As String = "Select * From QEa_AttFile "
        'Sql = Sql + " WHERE REFNO ='" & TxtREFNO.Text & "' "
        'Sql = Sql + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "

        'Dim Dt As New DataTable
        'Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        'Dim strAttfile As String = ""
        'For Each Dtr As DataRow In Dt.Rows
        '    strAttfile = Dtr.Item("AttFile1").ToString()
        'Next


        'Dim sqlinsert As String

        'sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT,BRANCHDATA,DEPTJOIN) " &
        '                        "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT,@BRANCHDATA,@DEPTJOIN)"
        'With comSave
        '    .Parameters.Clear()
        '    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
        '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
        '    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
        '    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
        '    .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
        '    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
        '    .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
        '    .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
        '    .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
        '    .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
        '    .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
        '    .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
        '    .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
        '    .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = Mid(strDEPTJOIN, 2, 100)

        '    .CommandText = sqlinsert
        '    .Connection = DB_CMD.ObjConn
        '    .ExecuteNonQuery()

        'End With




        'MsgBox("Update Course Master เรียบร้อยครับ")


        'If strStatusDelete = "รอประกาศใช้" Then

        '    Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
        '                                      "WHERE REFNO = '" & TxtREFNO.Text & "' " &
        '                                      "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

        '    myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Close KM"
        '    ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

        '    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        'End If



        'Call UpdateCourseMaster()


        Call UpdateCourseMasterKM()

    End Sub

    Sub UpdateCourseMasterKM()

        If strStatusDelete = "รอประกาศใช้" Then

            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                                              "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                              "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Close KM"
            ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        End If



        Call UpdateCourseMaster()

    End Sub
    Private Sub bntUpdate_Click(sender As Object, e As EventArgs) Handles bntUpdate.Click
        Call UpdateCourseMaster()
    End Sub

    Public Sub UpdateCourseMaster()
        ' Try

        'Dim Sms As String = "คุณต้องการ Update รายการ Course Master  " & TxtDOCNO.Text & "   ใช่หรือไม่?"
        'If MsgBox(Sms, MsgBoxStyle.YesNo, "Update") = MsgBoxResult.No Then Exit Sub

        Dim strDOCTYPE As String = ""
        If TxtMANUAL.Checked = True Then
            strDOCTYPE = "MNL"
        ElseIf TxtPROCEDURED.Checked = True Then
            strDOCTYPE = "PRC"
        ElseIf TxtWORKIN.Checked = True Then
            strDOCTYPE = "WIN"
        ElseIf TxtSTANDARD.Checked = True Then
            strDOCTYPE = "STD"
        ElseIf TxtRECORD.Checked = True Then
            strDOCTYPE = "RCF"
        ElseIf TxtKM.Checked = True Then
            strDOCTYPE = "KMM"
        ElseIf TxtORGJD.Checked = True Then
            strDOCTYPE = "OGN"
        ElseIf TxtJobD.Checked = True Then
            strDOCTYPE = "JOB"
        End If


        ' เอกสารใหม่...

        Dim Sql1 As String = "Select * From QEa_AttFile "
        Sql1 = Sql1 + " WHERE REFNO ='" & TxtREFNO.Text & "' "
        Sql1 = Sql1 + " AND REFNODATA ='" & TxtREFNODATA.Text & "' "

        Dim Dt1 As New DataTable
        Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)


        For Each Dtr1 As DataRow In Dt1.Rows

            If TxtSTANDARD.Checked = True And strSELECTSYSTEM = "DP" And Mid(TxtDOCNO.Text, 2, 3) <> "JSA" Then
                strAttfile = Dtr1.Item("AttFile1").ToString()
            Else
                strAttfile = Dtr1.Item("AttFile3").ToString()
            End If


        Next





        If TxtACTNEW.Checked = True Or TxtACTAMD.Checked = True Then



            If TxtJobD.Checked = True Or TxtORGJD.Checked = True Then

                intYearNow = 0
                intYearNow = Mid(TxtEFFDATE.Text, 7, 4)

                Dim command As New SqlCommand("SELECT   MAX(REVNO) AS MaxREVNO  FROM QEa_CourseMaster " &
                        "WHERE DOCNO ='" & TxtDOCNO.Text & "'" &
                        "And (YEAR(EFFDATE) = " & intYearNow & ") " &
                        "HAVING (NOT (MAX(REVNO) IS NULL))", DB_CMD.ObjConn)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                Dim ds As New DataSet
                adapter.Fill(table)

                If table.Rows.Count > 0 Then

                    CmdExcute("DELETE FROM QEa_CourseMaster  WHERE DOCNO='" & TxtDOCNO.Text & "' AND DOCTYPE = '" & strDOCTYPE & "' AND REVNO = " & TxtREVNO.Text & " ", DB_CMD.ObjConn)

                Else
                    CmdExcute("DELETE FROM QEa_CourseMaster  WHERE DOCNO='" & TxtDOCNO.Text & "' AND DOCTYPE = '" & strDOCTYPE & "' ", DB_CMD.ObjConn)


                End If
            Else

                CmdExcute("DELETE FROM QEa_CourseMaster  WHERE DOCNO='" & TxtDOCNO.Text & "' AND DOCTYPE = '" & strDOCTYPE & "' AND REVNO = " & TxtREVNO.Text & " ", DB_CMD.ObjConn)

            End If










            Dim sqlinsert As String
                    sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT,BRANCHDATA,DEPTJOIN,SELECTSYSTEM) " &
                                        "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT,@BRANCHDATA,@DEPTJOIN,@SELECTSYSTEM)"
                    With comSave
                        .Parameters.Clear()
                        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                        .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                        .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
                        .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                        .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                        .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                        .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
                        .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
                        .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                        .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
                        .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
                        .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
                        .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = strBranchConn
                        .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = Mid(strDEPTJOIN, 2, 100)
                        .Parameters.Add("@SELECTSYSTEM", SqlDbType.VarChar).Value = strSELECTSYSTEM

                        .CommandText = sqlinsert
                        .Connection = DB_CMD.ObjConn
                        .ExecuteNonQuery()

                    End With

                    If TxtACTAMD.Checked = True Then

                        Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set DOCDEPT = @DOCDEPT ,DOCNAME=@DOCNAME,DOCSHARE=@DOCSHARE,AttachFile=@AttachFile ,DEPTJOIN=@DEPTJOIN " &
                                                       "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
                        myCommand.Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                        myCommand.Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                        myCommand.Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                        myCommand.Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
                        myCommand.Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

                        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                    End If

                End If



                'เอกสารยกเลิก...
                If TxtACTOBS.Checked = True And TxtCheckDelete.Text = "ต้นฉบับ" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "I"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        End If


        ' นำเอกสารยกเลิกกลับมาใช้งาน...
        'If TxtUndoDoc.Checked = True Then

        '    Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
        '                                        "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)

        '    myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
        '    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        'End If


        ' นำข้อมูลเดิมกลับมา ตามเงื่อนไข
        If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลฉบับเดิม" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        End If


        ' นำข้อมูลเดิมกลับมา ตามเงื่อนไข
        If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลมีการแก้ไข" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "'  ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


            '*** START ***   26/07/2022 ****************
            CmdExcute("DELETE FROM QEa_CourseMaster  WHERE DOCNO='" & TxtDOCNO.Text & "' AND DOCTYPE = '" & strDOCTYPE & "' AND REVNO = " & TxtREVNO.Text & " ", DB_CMD.ObjConn)




            Dim sqlinsert As String
            sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT,BRANCHDATA,DEPTJOIN,SELECTSYSTEM) " &
                                "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT,@BRANCHDATA,@DEPTJOIN,@SELECTSYSTEM)"
            With comSave
                .Parameters.Clear()
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
                .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
                .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
                .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
                .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
                .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = strBranchConn
                .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = Mid(strDEPTJOIN, 2, 100)
                .Parameters.Add("@SELECTSYSTEM", SqlDbType.VarChar).Value = strSELECTSYSTEM

                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With

            '*** END ***   26/07/2022 ****************

            'Dim sqlinsert As String
            'sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT) " &
            '                "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT)"
            'With comSave
            '    .Parameters.Clear()
            '    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
            '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
            '    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
            '    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
            '    .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
            '    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
            '    .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
            '.Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
            '.Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
            '    .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
            '    .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
            '    .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
            '    .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
            '    .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

            '    .CommandText = sqlinsert
            '    .Connection = DB_CMD.ObjConn
            '    .ExecuteNonQuery()

            'End With


        End If

        ''เอกสารยกเลิก...
        'If TxtACTOBS.Checked = True And TxtCheckDelete.Text = "ต้นฉบับ" Then

        '        Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
        '                                        "WHERE DOCNO = '" & TxtDOCNO.Text & "' " &
        '                                        "AND BRANCHDATA ='" & TXTDOCSHARE.Text & "' ", DB_CMD.ObjConn)
        '        myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "I"
        '        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        '    End If


        '    ' นำเอกสารยกเลิกกลับมาใช้งาน...
        '    If TxtUndoDoc.Checked = True Then

        '        Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
        '                                        "WHERE DOCNO = '" & TxtDOCNO.Text & "' " &
        '                                        "AND BRANCHDATA ='" & TXTDOCSHARE.Text & "' ", DB_CMD.ObjConn)

        '        myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
        '        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        '    End If


        '    ' นำข้อมูลเดิมกลับมา ตามเงื่อนไข
        '    If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลฉบับเดิม" Then

        '        Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
        '                                        "WHERE DOCNO = '" & TxtDOCNO.Text & "' " &
        '                                        "AND BRANCHDATA ='" & TXTDOCSHARE.Text & "' ", DB_CMD.ObjConn)
        '        myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
        '        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        '    End If


        '    ' นำข้อมูลเดิมกลับมา ตามเงื่อนไข
        '    If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลมีการแก้ไข" Then

        '        Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
        '                                        "WHERE DOCNO = '" & TxtDOCNO.Text & "' " &
        '                                        "AND BRANCHDATA ='" & TXTDOCSHARE.Text & "' ", DB_CMD.ObjConn)
        '        myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
        '        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        '    'Dim sqlinsert As String
        '    'sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT) " &
        '    '                "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT)"
        '    'With comSave
        '    '    .Parameters.Clear()
        '    '    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
        '    '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
        '    '    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
        '    '    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
        '    '    .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
        '    '    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
        '    '    .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
        '    '.Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
        '    '.Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
        '    '    .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
        '    '    .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
        '    '    .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
        '    '    .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
        '    '    .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

        '    '    .CommandText = sqlinsert
        '    '    .Connection = DB_CMD.ObjConn
        '    '    .ExecuteNonQuery()

        '    'End With




        'End If
NEXTKB:

        'Dim Sql As String = "Select * FROM QEa_CourseMaster "
        'Sql = Sql + " WHERE  DOCNO = '" & TxtDOCNO.Text & "' "
        'Sql = Sql + " AND  REVNO =  " & TxtREVNO.Text & " "
        'Dim Dt As New DataTable
        'Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        ''Grd.Rows.Clear()

        'For Each Dtr As DataRow In Dt.Rows
        '    If TXTDOCSHARE.Text = "TP-KB" Then
        '        GoTo NEXTKB
        '    Else
        '        Exit Sub
        '    End If



        'Next



        If TXTDOCSHARE.Text = "TP-KB" Then

            If strBranchConn = "KB" Then
                Call UpdateTP()
            ElseIf strBranchConn = "TP" Then
                Call UpdateKB()
            End If
        End If



        MsgBox("Update Course Master เรียบร้อยครับ")

        Call UpdateStatusCourseMaster()

        Call CheckCourseMaster()


        FrmSub_CourseMaster.Close()
        FrmSub_CourseMaster.ShowDialog(Me)


        ' Catch ex As Exception

        ' End Try

    End Sub

    Sub UpdateKB()

        If connKB.State = ConnectionState.Closed Then
            connKB.ConnectionString = ClassConnect.ConnectionKB
            connKB.Open()
        End If


        Dim Sql As String = ""

        Dim strDOCTYPE As String = ""
        If TxtMANUAL.Checked = True Then
            strDOCTYPE = "MNL"
        ElseIf TxtPROCEDURED.Checked = True Then
            strDOCTYPE = "PRC"
        ElseIf TxtWORKIN.Checked = True Then
            strDOCTYPE = "WIN"
        ElseIf TxtSTANDARD.Checked = True Then
            strDOCTYPE = "STD"
        ElseIf TxtRECORD.Checked = True Then
            strDOCTYPE = "RCF"
        ElseIf TxtKM.Checked = True Then
            strDOCTYPE = "KMM"
        ElseIf TxtORGJD.Checked = True Then
            strDOCTYPE = "OGN"
        ElseIf TxtJobD.Checked = True Then
            strDOCTYPE = "JOB"
        End If



        ' เอกสารใหม่...
        If TxtACTNEW.Checked = True Or TxtACTAMD.Checked = True Then




            Dim dt_Select = ClassConnect.getDataSetKB("Select * FROM QEa_CourseMaster " &
                                                          "WHERE  DOCNO = '" & TxtDOCNO.Text & "' AND  DOCTYPE =  '" & strDOCTYPE & "' AND  REVNO =  " & TxtREVNO.Text & "  ", mytrans, "")

            If dt_Select.Rows.Count > 0 Then
                Exit Sub
            End If

            If ConnKB.State = ConnectionState.Closed Then
                ConnKB.ConnectionString = ClassConnect.ConnectionKB
                ConnKB.Open()
            End If

            Dim sqlinsert As String
            sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT) " &
                                "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT)"
            With comSave
                .Parameters.Clear()
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
                .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
                .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
                .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
                .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
                .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = "KB"
                .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

                .CommandType = CommandType.Text
                .CommandText = sqlinsert
                .Connection = ConnKB
                .ExecuteNonQuery()

            End With

            If TxtACTAMD.Checked = True Then

                Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set DOCDEPT = @DOCDEPT ,DOCNAME=@DOCNAME,DOCSHARE=@DOCSHARE,AttachFile=@AttachFile ,DEPTJOIN=@DEPTJOIN " &
                                               "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
                myCommand.Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                myCommand.Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                myCommand.Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                myCommand.Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
                myCommand.Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

            End If

        End If

        'เอกสารยกเลิก...
        If TxtACTOBS.Checked = True And TxtCheckDelete.Text = "ต้นฉบับ" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", ConnKB)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "I"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


            'Sql = "UPDATE QEa_CourseMaster  Set STATUS ='I' " &
            '        "WHERE DOCNO = '" & TxtDOCNO.Text & "' "

            'With comUpdate

            '    .CommandType = CommandType.Text
            '    .CommandText = Sql
            '    .Connection = ConnKB
            '    .ExecuteNonQuery()
            'End With



        End If


        '' นำเอกสารยกเลิกกลับมาใช้งาน...
        'If TxtUndoDoc.Checked = True Then

        '    Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
        '                                        "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", ConnKB)

        '    myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
        '    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


        'End If


        ' นำข้อมูลเดิมกลับมา ตามเงื่อนไข
        If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลฉบับเดิม" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", ConnKB)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery




        End If


        ' นำข้อมูลเดิมกลับมา ตามเงื่อนไข
        If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลมีการแก้ไข" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", ConnKB)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


            'Dim sqlinsert As String
            'sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT) " &
            '                    "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT)"
            'With comSave
            '    .Parameters.Clear()
            '    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
            '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
            '    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
            '    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
            '    .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
            '    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
            '    .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
            '    .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = ""
            '    .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
            '    .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
            '    .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
            '    .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
            '    .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
            '    .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

            '    .CommandText = sqlinsert
            '    .Connection = DB_CMD.ObjConn
            '    .ExecuteNonQuery()

            'End With




        End If








        connKB.Close()


    End Sub

    Sub UpdateTP()

        If connTP.State = ConnectionState.Closed Then
            connTP.ConnectionString = ClassConnect.ConnectionTP
            connTP.Open()
        End If


        Dim Sql As String = ""

        Dim strDOCTYPE As String = ""
        If TxtMANUAL.Checked = True Then
            strDOCTYPE = "MNL"
        ElseIf TxtPROCEDURED.Checked = True Then
            strDOCTYPE = "PRC"
        ElseIf TxtWORKIN.Checked = True Then
            strDOCTYPE = "WIN"
        ElseIf TxtSTANDARD.Checked = True Then
            strDOCTYPE = "STD"
        ElseIf TxtRECORD.Checked = True Then
            strDOCTYPE = "RCF"
        ElseIf TxtKM.Checked = True Then
            strDOCTYPE = "KMM"
        ElseIf TxtORGJD.Checked = True Then
            strDOCTYPE = "OGN"
        ElseIf TxtJobD.Checked = True Then
            strDOCTYPE = "JOB"
        End If



        ' เอกสารใหม่...
        If TxtACTNEW.Checked = True Or TxtACTAMD.Checked = True Then




            Dim dt_Select = ClassConnect.getDataSetTP("Select * FROM QEa_CourseMaster " &
                                                          "WHERE  DOCNO = '" & TxtDOCNO.Text & "' AND  DOCTYPE =  '" & strDOCTYPE & "' AND  REVNO =  " & TxtREVNO.Text & "  ", mytrans, "")

            If dt_Select.Rows.Count > 0 Then
                Exit Sub
            End If

            If connTP.State = ConnectionState.Closed Then
                connTP.ConnectionString = ClassConnect.ConnectionTP
                connTP.Open()
            End If

            Dim sqlinsert As String
            sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT) " &
                                "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT)"
            With comSave
                .Parameters.Clear()
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
                .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
                .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
                .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
                .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
                .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = "TP"
                .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

                .CommandType = CommandType.Text
                .CommandText = sqlinsert
                .Connection = connTP
                .ExecuteNonQuery()

            End With


            If TxtACTAMD.Checked = True Then

                Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set DOCDEPT = @DOCDEPT ,DOCNAME=@DOCNAME,DOCSHARE=@DOCSHARE,AttachFile=@AttachFile ,DEPTJOIN=@DEPTJOIN " &
                                               "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
                myCommand.Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                myCommand.Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                myCommand.Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                myCommand.Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = strAttfile
                myCommand.Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

            End If

        End If

        'เอกสารยกเลิก...
        If TxtACTOBS.Checked = True And TxtCheckDelete.Text = "ต้นฉบับ" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", connTP)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "I"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


            'Sql = "UPDATE QEa_CourseMaster  Set STATUS ='I' " &
            '        "WHERE DOCNO = '" & TxtDOCNO.Text & "' "

            'With comUpdate

            '    .CommandType = CommandType.Text
            '    .CommandText = Sql
            '    .Connection = ConnKB
            '    .ExecuteNonQuery()
            'End With



        End If


        '' นำเอกสารยกเลิกกลับมาใช้งาน...
        'If TxtUndoDoc.Checked = True Then

        '    Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
        '                                        "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", ConnKB)

        '    myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
        '    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


        'End If


        ' นำข้อมูลเดิมกลับมา ตามเงื่อนไข
        If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลฉบับเดิม" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", connTP)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery




        End If


        ' นำข้อมูลเดิมกลับมา ตามเงื่อนไข
        If TxtUndoDoc.Checked = True And TxtUndoDocSelect.Text = "ข้อมูลมีการแก้ไข" Then

            Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @Status " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", connTP)
            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


            'Dim sqlinsert As String
            'sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT) " &
            '                    "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT)"
            'With comSave
            '    .Parameters.Clear()
            '    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
            '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
            '    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
            '    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
            '    .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
            '    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
            '    .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
            '    .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = ""
            '    .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
            '    .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
            '    .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
            '    .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
            '    .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
            '    .Parameters.Add("@DEPTJOIN", SqlDbType.VarChar).Value = strDEPTJOIN

            '    .CommandText = sqlinsert
            '    .Connection = DB_CMD.ObjConn
            '    .ExecuteNonQuery()

            'End With




        End If








        connTP.Close()


    End Sub




    Sub UpdateStatusCourseMaster()

        Try


            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set StatusUpCourseMaster = @StatusUpCourseMaster " &
                                       "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                       "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@StatusUpCourseMaster", SqlDbType.VarChar).Value = "OK"
            ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        Catch ex As Exception

        End Try

    End Sub


    Sub CheckCourseMaster()

        Dim command1 As New SqlCommand("Select * FROM  QEa_DocSysItem " &
                                    " WHERE REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'AND StatusUpCourseMaster = 'OK'", DB_CMD.ObjConn)
        Dim table1 As New DataTable
        Dim adapter1 As New SqlDataAdapter(command1)
        Dim ds1 As New DataSet
        adapter1.Fill(table1)
        LblStatusUpCourseMaster.Text = ""
        If table1.Rows.Count > 0 Then
            LblStatusUpCourseMaster.Text = "Update Course Master เรียบร้อยแล้ว"
        End If

    End Sub




    Private Sub TxtPrintDate2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtMANUAL_CheckedChanged(sender As Object, e As EventArgs) Handles TxtMANUAL.CheckedChanged
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtPROCEDURED_CheckedChanged(sender As Object, e As EventArgs) Handles TxtPROCEDURED.CheckedChanged
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtWORKIN_CheckedChanged(sender As Object, e As EventArgs) Handles TxtWORKIN.CheckedChanged
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtSTANDARD_CheckedChanged(sender As Object, e As EventArgs) Handles TxtSTANDARD.CheckedChanged
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtRECORD_CheckedChanged(sender As Object, e As EventArgs) Handles TxtRECORD.CheckedChanged
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtKM_CheckedChanged(sender As Object, e As EventArgs) Handles TxtKM.CheckedChanged
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtORGJD_CheckedChanged(sender As Object, e As EventArgs) Handles TxtORGJD.CheckedChanged
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtJobD_CheckedChanged(sender As Object, e As EventArgs) Handles TxtJobD.CheckedChanged
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtUndoDoc_CheckedChanged(sender As Object, e As EventArgs) Handles TxtUndoDoc.CheckedChanged
        Call ClearTextChange()
        TxtUndoDocSelect.Text = ""
        TxtUndoDocSelect.Enabled = True
        TxtDOCNO.Focus()
        TxtDOCNO.Enabled = True
    End Sub

    Private Sub TxtMGRREASON_TextChanged(sender As Object, e As EventArgs) Handles TxtMGRREASON.TextChanged

    End Sub

    Private Sub bntLinkPdf_Click(sender As Object, e As EventArgs)
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            ' Me.TxtFilename.Text = Dl.SafeFileName
            Me.TxtLinkPdf7.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub

    Private Function ReadWordDoc(ByVal filename As String) As Byte()
        Dim fs As New System.IO.FileStream(filename, IO.FileMode.Open)
        Dim br As New System.IO.BinaryReader(fs)
        Dim data() As Byte = br.ReadBytes(CInt(fs.Length))
        br.Close()
        fs.Close()
        Return data
    End Function

    Private Sub TxtLinkPdf7_TextChanged(sender As Object, e As EventArgs) Handles TxtLinkPdf7.TextChanged

    End Sub

    Private Sub TxtLinkPdf7_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtLinkPdf7.MouseDoubleClick
        Process.Start(TxtLinkPdf7.Text)
    End Sub

    Private Sub bntLinkPdf_Click_1(sender As Object, e As EventArgs) Handles bntLinkPdf.Click
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            ' Me.TxtFilename.Text = Dl.SafeFileName
            Me.TxtLinkPdf7.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles bntLinkFilePDF.Click
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            ' Me.TxtFilename.Text = Dl.SafeFileName
            Me.TxtLinkFilePDF.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub

    Private Sub TxtLinkFilePDF_TextChanged(sender As Object, e As EventArgs) Handles TxtLinkFilePDF.TextChanged

    End Sub

    Private Sub TxtLinkFilePDF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLinkFilePDF.KeyPress

    End Sub

    Private Sub TxtLinkFilePDF_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtLinkFilePDF.MouseDoubleClick
        Process.Start(TxtLinkFilePDF.Text)
    End Sub



    Private Sub TxtPrintCheck2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtPrintCheck2.SelectedIndexChanged
        If TxtPrintCheck2.Text = "" Then
            TxtPrintDate2.Text = ""
        ElseIf TxtPrintCheck2.Text = "จัดการ" Then
            TxtPrintDate2.Text = TxtDateNow.Text
        Else
            TxtPrintDate2.Text = ""
        End If
    End Sub

    Private Sub TxtChkStartApprove3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtChkStartApprove3.SelectedIndexChanged
        If TxtChkStartApprove3.Text = "" Then
            TxtChkStartDate3.Text = ""
        ElseIf TxtChkStartApprove3.Text = "จัดการ" Then
            TxtChkStartDate3.Text = TxtDateNow.Text
        Else
            TxtChkStartDate3.Text = ""
        End If
    End Sub

    Private Sub TxtChkEndApprove3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtChkEndApprove3.SelectedIndexChanged
        If TxtChkEndApprove3.Text = "" Then
            TxtChkEndDate3.Text = ""
        ElseIf TxtChkEndApprove3.Text = "จัดการ" Then
            TxtChkEndDate3.Text = TxtDateNow.Text
        Else
            TxtChkEndDate3.Text = ""
        End If
    End Sub

    Private Sub bntLinkReciveForm_Click(sender As Object, e As EventArgs) Handles bntLinkReciveForm.Click
        If strRRSNO <> "" Then
            FrmDocSys_RcRt_Receive.Close()
            FrmDocSys_RcRt_Receive.MdiParent = FrmMainMenu
            FrmDocSys_RcRt_Receive.Show()

        End If
    End Sub

    Private Sub TxtDocCtrl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDocCtrl.SelectedIndexChanged

    End Sub

    Private Sub dgvDataDept_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataDept.CellContentClick
        SendKeys.Send("{Tab}")
    End Sub

    Private Sub bntDelete_Click_1(sender As Object, e As EventArgs) Handles bntDelete.Click
        strStatusDelete = ""
        chkSelectALL.Checked = False
        Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtREFNO.Text & "    ออก จากรายการ หรือไม่?"
        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        CmdExcute("DELETE FROM QEa_DocSysItem  WHERE REFNO='" & TxtREFNO.Text & "' ", DB_CMD.ObjConn)

        CmdExcute("DELETE FROM QEa_DocSysItem_H  WHERE REFNO='" & TxtREFNO.Text & "' ", DB_CMD.ObjConn)

        StrFunction.CAR_Reference = 1
        Me.Close()

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Process.Start(TxtLinkFilePDF.Text)


        If strRRSNO <> "" Then
            FrmDocSys_RcRt_Receive.Close()
            FrmDocSys_RcRt_Receive.MdiParent = FrmMainMenu
            FrmDocSys_RcRt_Receive.Show()

        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start(TxtLinkPdf7.Text)
    End Sub

    Private Sub TxtQEoff8_CheckedChanged(sender As Object, e As EventArgs) Handles TxtQEoff8.CheckedChanged
        If TxtQEoff8.Checked = True Then
            TxtQEoffName8.Text = StrUserName
            TxtQEoffDate8.Text = TxtDateNow.Text
        Else
            TxtQEoffName8.Text = ""
            TxtQEoffDate8.Text = ""

        End If
    End Sub

    Private Sub TxtQE8_CheckedChanged(sender As Object, e As EventArgs) Handles TxtQE8.CheckedChanged
        If TxtQE8.Checked = True Then
            TxtQEName8.Text = StrUserName
            TxtQEDate8.Text = TxtDateNow.Text
        Else
            TxtQEName8.Text = ""
            TxtQEDate8.Text = ""

        End If
    End Sub

    Private Sub chkSelectALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectALL.CheckedChanged
        With Me.dgvDataDept
            For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                If chkSelectALL.Checked = True Then
                    .Item(0, i).Value = True
                Else
                    .Item(0, i).Value = False
                End If

            Next
        End With
    End Sub

    Private Sub TxtQEoff1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtQEoff1.SelectedIndexChanged
        If TxtQEoff1.Text = "" Then
            TxtQEoff1Date.Text = ""
        ElseIf TxtQEoff1.Text = "จัดการ" Then
            TxtQEoff1Date.Text = TxtDateNow.Text
        Else
            TxtQEoff1Date.Text = ""
        End If
    End Sub

    Private Sub TxtAttDoc1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtAttDoc1.SelectedIndexChanged
        If TxtAttDoc1.Text = "" Then
            TxtAttDoc1Date.Text = ""
        ElseIf TxtAttDoc1.Text = "จัดการ" Then
            TxtAttDoc1Date.Text = TxtDateNow.Text
        Else
            TxtAttDoc1Date.Text = ""
        End If
    End Sub

    Private Sub TxtSendDocSrv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSendDocSrv1.SelectedIndexChanged
        If TxtSendDocSrv1.Text = "" Then
            TxtSendDocSrv1Date.Text = ""
        ElseIf TxtSendDocSrv1.Text = "จัดการ" Then
            TxtSendDocSrv1Date.Text = TxtDateNow.Text
        Else
            TxtSendDocSrv1Date.Text = ""
        End If
    End Sub

    Private Sub TxtACTCPYSel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtACTCPYSel.SelectedIndexChanged
        TxtDOCNO.Focus()
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork

        Do Until 1 = StrFunction.ClickDATA

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")

    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Me.dgvDATA.ClearSelection()

        Me.dgvDATA.Rows(StrFunction.RowSelected).Selected = True
        dgvDATA.FirstDisplayedScrollingRowIndex = StrFunction.RowSelected

    End Sub

    Private Sub dgvDATA_CellValuePushed(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvDATA.CellValuePushed

    End Sub

    Private Sub bntKM_Click(sender As Object, e As EventArgs)

        'If TxtKM.Checked = True Then

        '    FrmKMEdit.Close()
        '    FrmKMEdit.ShowDialog()
        'Else

        '    'FrmDocSysiTem_Copy.Close()
        '    'FrmDocSysiTem_Copy.MdiParent = FrmMainMenu
        '    'FrmDocSysiTem_Copy.Show()

        'End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If strDeptData = "SD" Or strDeptData = "IT" Then


            TabPage2.Enabled = True
            Call DisabledText()
            Call EnabledText()


        End If
    End Sub
End Class