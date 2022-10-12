Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Net.Mail
Public Class FrmDocumentSystem_Find

    Public EditNo As String
    Private intSelectedRow As Integer
    Dim ds As New DataSet
    Dim da As SqlDataAdapter
    Dim IsFindType, IsFindRepair, IsFindName, IsEquName, IsFindJobDesc, IsFindService As Boolean



    Private Sub grdDataRows_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdDataRows.CellContentClick

    End Sub
    Private Sub grdDataRows_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdDataRows.CellMouseDoubleClick
        Try


            strRefNo = ""
            strRefNoData = ""
            strRefNo = Me.grdDataRows.Item(1, Me.grdDataRows.CurrentRow.Index).Value
            If Me.grdDataRows.Item(18, Me.grdDataRows.CurrentRow.Index).Value = "KM" Then

                strSELECTSYSTEMForm = "KM"


            ElseIf Me.grdDataRows.Item(18, Me.grdDataRows.CurrentRow.Index).Value = "DS" Then

                strSELECTSYSTEMForm = "DS"

            ElseIf Me.grdDataRows.Item(18, Me.grdDataRows.CurrentRow.Index).Value = "DP" Then

                strSELECTSYSTEMForm = "DP"

            End If


            Select Case txtSELECTSYSTEM.Text
                Case "Document System"
                    strSELECTSYSTEMFind = "DS"
                Case "Department"
                    strSELECTSYSTEMFind = "DP"

                Case "KM"
                    strSELECTSYSTEMFind = "KM"
            End Select




            'If IsDBNull(Me.grdDataRows.Item(0, Me.grdDataRows.CurrentRow.Index).Value) Then
            'Else
            '    strRefNoData = Me.grdDataRows.Item(0, Me.grdDataRows.CurrentRow.Index).Value
            'End If
            ''strDRrsNoRecieve = Me.grdDetail.Item(0, Me.grdDetail.CurrentRow.Index).Value


            For Each dr As DataGridViewRow In grdDataRows.Rows

                If dr.Selected = True Then
                    intSelectedRow = dr.Index
                    StrFunction.RowSelectedFind = intSelectedRow
                End If

            Next

            StrFunction.process = 2
            Try
                BackgroundWorker1.RunWorkerAsync()
            Catch ex As Exception

            End Try

            CommandTypeNew = "Edit"
            FrmDocumentSystem.Close()
            strFormShowGrid = "DocSystem"
            FrmDocumentSystem.MdiParent = FrmMainMenu
            FrmDocumentSystem.Show()

            'FrmDocumentSystem.TopLevel = False
            'FrmDocumentSystem.TopMost = True
            'FrmSubMenu.SplitContainer1.Panel2.Controls.Add(FrmDocumentSystem)
            'FrmDocumentSystem.Show()


        Catch ex As Exception

        End Try

    End Sub
    Sub Grid()

        With Me.grdDataRows
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
    Sub RunningRefNo()

        Dim Sql As String = Nothing
        Dim Year As Integer = CInt(Format(Now, "yyyy"))
        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))

        CommandTypeData = "Addnew"

        Dim command As New SqlCommand("Select *  FROM QEn_RefNo WHERE Year=" & Year & " AND SELECTSYSTEM = '" & strSELECTSYSTEM & "'  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)

        adapter.Fill(table)


        If table.Rows.Count = 0 Then

            Dim intRefNoNew As Integer = 1

            With QEn_RefNo
                .SELECTSYSTEM = strSELECTSYSTEM
                .REFNO = intRefNoNew
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
        With QEn_RefNo

            .GetData("Select * FROM QEn_RefNo WHERE YEAR =" & Year & " AND SELECTSYSTEM = '" & strSELECTSYSTEM & "'  ", DB_CMD.ObjConn)

            ' TxtRefNo.Text = .RefNoData
            Dim strRefBranch As String = ""

            strRefBranch = Mid(strBranchConn, 1, 1)

            strRefNo = strRefBranch & strSELECTSYSTEM & "-" & yy & "-" & Format(CSng(.REFNO), "0000")

            intRefNo = CInt(.REFNO).ToString

        End With


        ' Update Running Number
        Dim myCommand As New SqlCommand("Update QEn_RefNo Set REFNO = @RefNo WHERE YEAR = " & Year & " AND SELECTSYSTEM = '" & strSELECTSYSTEM & "' ", DB_CMD.ObjConn)
        myCommand.Parameters.Add("@RefNo", SqlDbType.Int).Value = intRefNo + 1


        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        Call AddQEa_DocSysItem_H()
    End Sub

    Sub AddQEa_DocSysItem_H()



        Dim sqlinsert As String
        Dim Result As Boolean


        sqlinsert = " Insert Into QEa_DocSysItem_H (REFNO,SELECTSYSTEM,DOCDEPT)Values ('" & strRefNo & "','" & strSELECTSYSTEM & "','" & strDeptData & "') "

        Result = CmdExcute(sqlinsert, DB_CMD.ObjConn)



    End Sub





    Sub SaveData()

        Dim Sql As String = Nothing
        Dim Year As Integer = CInt(Format(Now, "yyyy"))
        Dim StrCreateDate As String = CStr(Format(Now, "yyyy-MM-dd"))
        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))



        '  Try
        ''ตรวจสอบ ข้อมูลก่อนบันทึก
        'If CheckData() = False Then
        '    MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
        '    Exit Sub
        'Else


        'If CommandType = "Addnew" Then

        'End If


        'With QEa_CarH

        '    .RefNo = strRefNo
        '    .Status = "Data"
        '    .Branch = strBranchData
        '    '.LeadApp = TxtLeadApp.Text
        '    '.LeadAppName = TxtLeadAppName.Text
        '    '.LeadAppDate = TxtLeadAppDate.Text
        '    .CreateDate = StrCreateDate
        '    .DeptData = strDeptData
        '    .UserName = StrUserName
        '    .EmployeeNo = StrEmployeeNo


        '    ' Dim Sql As String = Nothing
        '    Select Case CommandType
        '        Case "Addnew"
        '            Sql = .SqlCommandInsert
        '        Case "Edit"
        '            Sql = .SqlCommandUpdate
        '    End Select
        '    If CmdExcute(Sql, DB_CMD.ObjConn) = True Then
        '        StrFunction.Car_Reply = 1
        '        'MsgBox("บันทึกข้อมูลสำเร็จ")
        '        'Me.Close()


        '    Else
        '        MsgBox("ไม่สามารถบันทึกข้อมูลได้")
        '    End If
        'End With
        ''End If



    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmDocumentSystem_SendMail.Close()
        FrmDocumentSystem_SendMail.ShowDialog()



    End Sub

    'Sub SendEmail()

    '    Dim strStatusRepair As String = ""
    '    Dim strSubjectEmail As String = ""

    '    'If CommandTypeData = "Addnew" Then
    '    '    strStatusRepair = "เปิดใบเเจ้งซ่อม"
    '    '    strSubjectEmail = TxtOther.Text & "( ใบเเจ้งซ่อมระบบคอมพิวเตอร์ เลขที่ : " & TxtJobNo.Text & ") "
    '    'Else
    '    '    strStatusRepair = "รอดำเนินการ"
    '    '    strSubjectEmail = "กำหนดผู้รับผิดชอบงาน โดยฝ่าย iT เลขที่ใบเเจ้งซ่อม : " & TxtJobNo.Text & ""
    '    'End If

    '    Dim smtp As New SmtpClient("10.1.1.5")
    '    Dim mail As New MailMessage()
    '    'Call GetHostName()

    '    strStepSendEmail = "ส่งอนุมัติออก CAR ให้ QE Manager "

    '    mail.From = New MailAddress(TxtEmailFM.Text)


    '    StrUserEmail = ""
    '    Dim Sql As String = "Select * from ITm_User where UserNam ='" & TxtServPersn.Text & "' "
    '    Dim Dt As New DataTable
    '    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
    '    Dim strBranchID As String = ""
    '    For Each Dtr As DataRow In Dt.Rows

    '        StrUserEmail = Dtr.Item("UserEmail").ToString

    '    Next





    '    'If TxtBranch.Text = "TP" Then

    '    '    mail.To.Add("isdiv@sunif.co.th")
    '    'Else
    '    '    mail.To.Add("itkb@sunif.co.th")
    '    'End If

    '    If txtToEmail.Text <> "" Then
    '        StrUserEmail = txtToEmail.Text & StrUserEmail
    '    Else
    '        StrUserEmail = StrUserEmail
    '    End If


    '    mail.To.Add(StrUserEmail)
    '    mail.CC.Add(TxtEmailCC.Text)

    '    mail.Subject = strSubjectEmail

    '    mail.IsBodyHtml = True


    '    '************************************************************************

    '    'mail.Body = "<center><table><tr><td><h2><font color=Blue>ระบบเเจ้งซ่อมคอมพิวเตอร์</font></h3><br/><br/></td></tr></table></center>"
    '    mail.Body = " <html>
    '    <head>
    '    <style>
    '    table, th, td {
    '      border: 1px solid black;
    '      border-collapse: collapse;
    '    }
    '    </style>
    '    </head>
    '    <body>
    '          <table>
    '                <tr style=background-color:#005D44 >
    '                    <th><b><font color=White><h6>เลขที่ใบเเจ้งซ่อม</h6></b></Font></th>
    '                    <th><b><font color=White><h6>สถานะใบเเจ้งซ่อม</h6></b></Font></th>
    '                    <th><b><font color=White><h6>วันที่เเจ้งซ่อม</h6></b></Font></th>
    '                    <th><b><font color=White><h6>รายละเอียดการแจ้งซ่อม</h6></b></Font></th>
    '                    <th><b><font color=White><h6>ผู้เเจ้งซ่อม</h6></b></Font></th>
    '                    <th><b><font color=White><h6>ฝ่ายงาน/หน่วยงาน</h6></b></Font></th>
    '                    <th><b><font color=White><h6>สาขา</h6></b></Font></th>
    '                    <th><b><font color=White><h6>เจ้าหน้าที่ฝ่าย IT </h6></b></Font></th>  
    '                    <th><b><font color=White><h6>วันที่รับเรื่อง</h6></b></Font></th>        

    '                </tr>
    '                <tr>
    '                    <td><h6>" & TxtJobNo.Text & "</h6></td>
    '                    <td><h6>" & strStatusRepair & "</h6></td>
    '                    <td><h6>" & TxtJobDate.Text & "</h6></td>
    '                    <td><h6>" & txtJobDesc.Text & "</h6></td>
    '                    <td><h6>" & TxtInformant.Text & "</h6></td>
    '                    <td><h6>" & TxtDept.Text & "</h6></td>
    '                    <td><h6>" & TxtBranch.Text & "</h6></td>
    '                    <td><h6>" & TxtServPersn.Text & "</h6></td>
    '                    <td><h6>" & TxtJobDate.Text & "</h6></td>


    '                </tr>
    '            </table> </body>
    '    </html>"


    '    mail.Body = mail.Body + "Sent from computer name : " & strHostName & "<br/>"
    '    mail.Body = mail.Body + "This email is auto-generated."

    '    '*****************************************************************************

    '    ''mail.Body = "<table><tr><td><h3><font color=Blue>ระบบเเจ้งซ่อมคอมพิวเตอร์</font></h3><br/><br/></td></tr></table>"
    '    'mail.Body = mail.Body + "<table><tr><td><b><font color=Blue>เลขที่ใบเเจ้งซ่อม : </b></Font> " & TxtJobNo.Text & "<br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><b><font color=Blue>สถานะใบเเจ้งซ่อม : </b></Font> " & strStatusRepair & "<br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><b><font color=Blue>วันที่เเจ้งซ่อม : </b></Font>" & TxtJobDate.Text & "<br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><b><font color=Blue>รายละเอียดการแจ้งซ่อม : </b></Font>" & txtJobDesc.Text & "<br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><b><font color=Blue>ผู้เเจ้งซ่อม : </b></Font>" & TxtInformant.Text & "<br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><b><font color=Blue>ฝ่ายงาน/หน่วยงาน : </b></Font>" & TxtDept.Text & "<br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><b><font color=Blue>สาขา : </b></Font>" & TxtBranch.Text & "<br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><b><font color=Blue>วันที่รับเรื่อง : </b></Font>" & TxtJobDate.Text & "<br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><br/></td></tr>"
    '    'mail.Body = mail.Body + "<tr><td><br/>Sent from computer name : " & strHostName & "</td></tr>"
    '    'mail.Body = mail.Body + "<tr><td>This email is auto-generated. </td></tr></table>"





    '    mail.SubjectEncoding = System.Text.Encoding.GetEncoding(65001)
    '    mail.BodyEncoding = System.Text.Encoding.GetEncoding(65001)

    '    '  mail.Attachments.Add(New Attachment("D:\DaTA\Config -.xlsx"))

    '    For Each row As DataGridViewRow In grdAttFile.Rows

    '        If (CStr(row.Cells("RequestAttFile").Value)) <> "" Then
    '            mail.Attachments.Add(New Attachment(CStr(row.Cells("RequestAttFile").Value)))
    '        End If


    '    Next

    '    Try
    '        smtp.Send(mail)
    '        Application.DoEvents()

    '        MsgBox("Send Mail Complete  ", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle))
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        smtp.Dispose()
    '    End Try



    'End Sub
    Sub Openform()
        Dim Sms As String = "คุณต้องการเปิดใบคำขอจัดการเอกสารใช่หรือไม่ ?"
        If MsgBox(Sms, MsgBoxStyle.YesNo, "DAR") = MsgBoxResult.No Then Exit Sub

        Call RunningRefNo()
        ' Call SaveData()


        For Each dr As DataGridViewRow In grdDataRows.Rows

            If dr.Selected = True Then
                intSelectedRow = dr.Index
                StrFunction.RowSelected = intSelectedRow
            End If

        Next





        StrFunction.DocSystem = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try

        CommandTypeNew = "Addnew"
        FrmDocumentSystem.Close()
        FrmDocumentSystem.MdiParent = FrmMainMenu
        FrmDocumentSystem.Show()
    End Sub

    Private rowIndex As Integer
    Dim strColumn As String = ""

    Private Sub FrmDocumentSystem_Find_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Grid()



        If strBranchData = "TP" Then
            TxtBranch.Text = "TP"
        Else
            TxtBranch.Text = "KB"
        End If

        Call DeptDATASel()

        If strDeptData = "SD" Or strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
            If strSELECTSYSTEMFind = "DP" And strDeptData = "SD" Then
                TxtDOCDEPT.Text = strDeptData
                TxtDOCDEPT.Enabled = False

            Else
                TxtDOCDEPT.Enabled = True
            End If

        Else

                TxtDOCDEPT.Text = strDeptData
            TxtDOCDEPT.Enabled = False


        End If
    End Sub

    Sub ShowReFNOFM()
        Dim strsql As String = ""
        If strDeptData = "SD" Then
            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMFind & "' GROUP BY REFNO ORDER BY REFNO DESC "
        Else
            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMFind & "'  AND PETITIONDEPT = '" & strDeptData & "' GROUP BY REFNO ORDER BY REFNO DESC "
        End If

        Dim command As New SqlCommand(strsql, DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEa_DocSysItem")
        If table.Rows.Count > 0 Then
            TxtRefNoFM.DisplayMember = "REFNO"
            TxtRefNoFM.ValueMember = "REFNO"
            TxtRefNoFM.DataSource = ds.Tables("QEa_DocSysItem")

        End If

        Exit Sub


    End Sub

    Sub ShowReFNOTO()

        '  Dim command As New SqlCommand("Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMFind & "' GROUP BY REFNO ORDER BY REFNO DESC ", DB_CMD.ObjConn)

        Dim strsql As String = ""
        If strDeptData = "SD" Then
            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMFind & "' GROUP BY REFNO ORDER BY REFNO DESC "
        Else
            strsql = "Select REFNO FROM QEa_DocSysItem WHERE SELECTSYSTEM = '" & strSELECTSYSTEMFind & "'  AND PETITIONDEPT =  '" & strDeptData & "' GROUP BY REFNO ORDER BY REFNO DESC "
        End If
        Dim command As New SqlCommand(strsql, DB_CMD.ObjConn)


        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEa_DocSysItem")
        If table.Rows.Count > 0 Then
            TxtRefNoTO.DisplayMember = "REFNO"
            TxtRefNoTO.ValueMember = "REFNO"
            TxtRefNoTO.DataSource = ds.Tables("QEa_DocSysItem")

        End If

        Exit Sub


    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click

        strCHKREFNOOPENFORM = ""
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Call LoadData()
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Visible = False
        '  FrmProgressBAr.ShowDialog()
        grdDataRows.AutoResizeColumns()

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

    Private Sub MetroContextMenu2_Opening(sender As Object, e As ComponentModel.CancelEventArgs) Handles MetroContextMenu2.Opening

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub bntKM_Click(sender As Object, e As EventArgs) Handles bntKM.Click

        strSELECTSYSTEMForm = ""
        strSELECTSYSTEM = ""
        strSELECTSYSTEM = "KM"
        strSELECTSYSTEMForm = "KM"
        strSELECTSYSTEMFind = "KM"
        Call CheckREFNO()
        'Call Openform()

    End Sub
    Sub CheckREFNO()
        Try

            Dim strREFNOCHECK As String = ""
            strCHKREFNOOPENFORM = ""

            Dim command As New SqlCommand("SELECT  A.REFNO, A.SELECTSYSTEM, B.REFNO AS ChkREFNO, A.DOCDEPT " &
                                          "FROM QEa_DocSysItem_H AS A LEFT OUTER JOIN QEa_DocSysItem AS B ON A.REFNO = B.REFNO AND A.SELECTSYSTEM = B.SELECTSYSTEM " &
                                          "WHERE B.REFNO IS NULL " &
                                          "AND A.SELECTSYSTEM = '" & strSELECTSYSTEM & "' " &
                                          "AND A.DOCDEPT = '" & strDeptData & "' ", DB_CMD.ObjConn)

            Dim table As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            Dim ds As New DataSet
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                For i As Integer = 0 To table.Rows.Count - 1


                    strREFNOCHECK = strREFNOCHECK & "," & table.Rows(i).Item("REFNO").ToString



                Next
                strCHKREFNOOPENFORM = "Active"
                strREFNOCHECK = Trim(Mid(strREFNOCHECK, 2, 500))
                MsgBox("มีรายการ REFNO ที่ฝ่ายเปิดไว้เเต่ไม่ได้ใช้งาน  รบกวนใช้งาน REFNO ตามนี้ด้วยค่ะ : " & strREFNOCHECK, MsgBoxStyle.Exclamation, "เเจ้งให้ทราบ")

                Call LoadData()
                Exit Sub
            Else
                strCHKREFNOOPENFORM = ""
                Call Openform()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub bntDS_Click(sender As Object, e As EventArgs) Handles bntDS.Click

        strSELECTSYSTEMForm = ""
        strSELECTSYSTEM = ""
        strSELECTSYSTEM = "DS"
        strSELECTSYSTEMForm = "DS"
        strSELECTSYSTEMFind = "DS"

        Call CheckREFNO()





    End Sub

    Private Sub bntDP_Click(sender As Object, e As EventArgs) Handles bntDP.Click
        strSELECTSYSTEM = ""
        strSELECTSYSTEMForm = ""
        strSELECTSYSTEM = "DP"
        strSELECTSYSTEMForm = "DP"
         strSELECTSYSTEMFind = "DP"
        'Call Openform()
        Call CheckREFNO()
    End Sub

    Sub CHECKSELECTSYSTEM()
        Select Case txtSELECTSYSTEM.Text
            Case "Document System"
                strSELECTSYSTEMFind = "DS"
                strSELECTSYSTEMForm = "DS"
            Case "Department"
                'strSELECTSYSTEMFind = strDeptData

                strSELECTSYSTEMFind = "DP"
                If strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
                    TxtDOCDEPT.Enabled = True
                Else
                    TxtDOCDEPT.Enabled = False
                End If
                strSELECTSYSTEMForm = "DP"
            Case "KM"
                strSELECTSYSTEMFind = "KM"
                strSELECTSYSTEMForm = "KM"
        End Select

    End Sub
    Private Sub txtSELECTSYSTEM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSELECTSYSTEM.SelectedIndexChanged
        grdDataRows.Rows.Clear()

        Call CHECKSELECTSYSTEM()



        Call ShowReFNOFM()
        Call ShowReFNOTO()





        TxtRefNoFM.Text = ""
        TxtRefNoTO.Text = ""



        TxtStatus.Items.Clear()

        Select Case txtSELECTSYSTEM.Text
            Case "Document System"


                If strDeptData = "SD" Then

                    TxtDOCDEPT.Enabled = True
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอ SD จัดทำเอกสาร")
                    TxtStatus.Items.Add("SD ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD Section Head อนุมัติ")
                    TxtStatus.Items.Add("SD Section Head ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ MR อนุมัติ")
                    TxtStatus.Items.Add("MR ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอจัดทำเอกสาร")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                    TxtStatus.Items.Add("รอ SD Chief ทวนสอบ")


                ElseIf strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอจัดทำเอกสาร")
                    TxtStatus.Items.Add("รอ SD รับ DAR")
                Else

                    TxtDOCDEPT.Enabled = False
                    TxtDOCDEPT.Text = strDeptData

                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")

                End If


            Case "Department"


                If strDeptData = "SD" Then
                    TxtDOCDEPT.Enabled = True
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอ SD จัดทำเอกสาร")
                    TxtStatus.Items.Add("SD ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ จป.วิชาชีพ จัดการ")
                    TxtStatus.Items.Add("จป.วิชาชีพ ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD Section Head อนุมัติ")
                    TxtStatus.Items.Add("SD Section Head ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ ผู้บริหารหน่วยงานความปลอดภัย อนุมัติ")
                    TxtStatus.Items.Add("ผู้บริหารหน่วยงานความปลอดภัย ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ MR อนุมัติ")
                    TxtStatus.Items.Add("MR ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอจัดทำเอกสาร")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                    TxtStatus.Items.Add("รอ SD Chief ทวนสอบ")


                ElseIf strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอ Asst.Mgr/Manager อนุมัติ")
                    TxtStatus.Items.Add("Asst.Mgr/Manager ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                Else

                    TxtDOCDEPT.Enabled = False
                    TxtDOCDEPT.Text = strDeptData

                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                End If

            Case "KM"

                If strDeptData = "SD" Then
                    TxtDOCDEPT.Enabled = True
                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")
                    TxtStatus.Items.Add("รอ Document Control จัดการ")
                    TxtStatus.Items.Add("รอ SD จัดทำเอกสาร")
                    TxtStatus.Items.Add("SD ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD Section Head อนุมัติ")
                    TxtStatus.Items.Add("SD Section Head ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ MR อนุมัติ")
                    TxtStatus.Items.Add("MR ไม่อนุมัติ")
                    TxtStatus.Items.Add("รอจัดทำเอกสาร")
                    TxtStatus.Items.Add("รอเอกสารลงนาม")
                    TxtStatus.Items.Add("รอประกาศใช้")
                    TxtStatus.Items.Add("รอ SD Chief ทวนสอบ")


                ElseIf strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then

                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")

                Else

                    TxtDOCDEPT.Enabled = False
                    TxtDOCDEPT.Text = strDeptData

                    TxtStatus.Items.Add("")
                    TxtStatus.Items.Add("รอ ผู้จัดการฝ่ายอนุมัติ")
                    TxtStatus.Items.Add("ผู้จัดการฝ่ายไม่อนุมัติ")
                    TxtStatus.Items.Add("รอ SD รับ DAR")

                End If

        End Select

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


        Do Until 1 = StrFunction.process

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("Stop.")


    End Sub

    Private Sub TxtDOCNO_TextChanged(sender As Object, e As EventArgs) Handles TxtDOCNO.TextChanged

    End Sub

    Private Sub TxtRefNoTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtRefNoTO.SelectedIndexChanged

    End Sub

    Private Sub TxtStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtStatus.SelectedIndexChanged
        grdDataRows.Rows.Clear()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try


            Call LoadData()
            '  Call ShowReFNOFM()
            '  Call ShowReFNOTO()
            '  TxtRefNoFM.Text = ""
            ' TxtRefNoTO.Text = ""

            '   Call ShowCARFM()
            '  Call ShowCARTO()

            TxtRefNoFM.Text = ""
            TxtRefNoTO.Text = ""


            'If TxtRefNoFM.Text <> "" Then
            '    TxtRefNoFM.Text = strRefNo
            'Else
            ' TxtRefNoFM.Text = ""
            '  TxtRefNoTO.Text = ""
            '  End If



            Me.grdDataRows.ClearSelection()

            Me.grdDataRows.Rows(StrFunction.RowSelectedFind).Selected = True
            grdDataRows.FirstDisplayedScrollingRowIndex = StrFunction.RowSelectedFind


        Catch ex As Exception

        End Try
    End Sub

    Sub LoadData()


        'If txtSELECTSYSTEM.Text <> "" Then

        '    MsgBox("ก")

        'End If

        '
        '  Try

        Me.grdDataRows.AllowUserToAddRows = True

        Dim cri As String = ""

        Select Case txtSELECTSYSTEM.Text

            Case "Document System"
                strSELECTSYSTEMFind = "DS"
            Case "Department"

                'If strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
                '    strSELECTSYSTEMFind = TxtDOCDEPT.Text
                'Else
                '    strSELECTSYSTEMFind = strDeptData
                'End If
                strSELECTSYSTEMFind = "DP"

            Case "KM"
                strSELECTSYSTEMFind = "KM"
        End Select




        cri = "WHERE QEa_DocSysItem_H.SELECTSYSTEM ='" & strSELECTSYSTEMFind & "'"

        If TxtRefNoFM.Text <> "" And TxtRefNoTO.Text <> "" Then

            cri = cri & "And (QEa_DocSysItem.REFNO  BETWEEN   '" & TxtRefNoFM.Text & "' AND  '" & TxtRefNoTO.Text & "')"
        End If


        If TxtDOCNO.Text <> "" Then



            cri = cri & "And ( QEa_DocSysItem.DOCNO =  '" & TxtDOCNO.Text & "')"


        End If



        If TxtDOCDEPT.Text <> "" Then


            If TxtDOCDEPT.Text = "GA" Or TxtDOCDEPT.Text = "HR" Or TxtDOCDEPT.Text = "HRGA" Then
                cri = cri & "And (QEa_DocSysItem_H.DOCDEPT ='GA' OR QEa_DocSysItem_H.DOCDEPT ='HR' OR QEa_DocSysItem_H.DOCDEPT ='HRGA' )"

            Else

                cri = cri & "And (QEa_DocSysItem_H.DOCDEPT ='" & TxtDOCDEPT.Text & "')"

            End If

        End If



        'If TxtDOCDEPT.Text <> "" Then
        '    cri = cri & "And (QEa_DocSysItem.PETITIONDEPT ='" & TxtDOCDEPT.Text & "')"
        'End If




        If TxtYearData.Text <> "" Then
            cri = cri & "And (Substring(QEa_DocSysItem.PETITIONDATE,1,24) =  '" & TxtYearData.Text & "')"
        End If



        If TxtStatus.Text <> "" Then
            cri = cri & "And (QEa_DocSysItem.STATUS ='" & TxtStatus.Text & "')"
        End If




        If strCHKREFNOOPENFORM = "Active" Then

            TxtDOCDEPT.Text = strDeptData

            Select Case strSELECTSYSTEMFind
                Case "DS"
                    txtSELECTSYSTEM.Text = "Document System"
                Case "DP"
                    txtSELECTSYSTEM.Text = "Department"
                Case "KM"
                    txtSELECTSYSTEM.Text = "KM"
            End Select


            Call CHECKSELECTSYSTEM



            cri = cri & "And (QEa_DocSysItem_H.DOCDEPT ='" & TxtDOCDEPT.Text & "')"

            cri = cri & "And QEa_DocSysItem.REFNO IS NUll  "

        End If


        'If TxtYearData.Text <> "" Then
        '    cri = cri & "And (Substring(QEa_DocSysItem.PETITIONDATE,1,24) =  '" & TxtYearData.Text & "')"
        'End If




        '*********  18/05/2021 ****************
        'Dim Sql As String = "SELECT  QEa_Car.RefNoData,QEa_Car.CarNo, QEa_Car.Status,SUBSTRING(QEa_CarH.CreateDate,6,2), QEa_Car.SystemCase, QEa_Car.GroupSystem,"
        'Sql = Sql + " QEa_Car.CarCase, QEa_Car.DescData, QEa_Car.DeptRespon, QEa_CarH.RefNo  "
        'Sql = Sql + " FROM  QEa_CarH LEFT OUTER JOIN   QEa_Car ON QEa_CarH.RefNo = QEa_Car.RefNo "
        'Sql = Sql + cri
        'Sql = Sql + " Order by QEa_CarH.RefNo asc "
        '*********  18/05/2021 ****************

        'da = New SqlDataAdapter(Sql, DB_CMD.ObjConn)


        'If IsFindRepair = True Then
        '    ds.Tables("QEa_CarH").Clear()
        'End If
        'da.Fill(ds, "QEa_CarH")
        'If ds.Tables("QEa_CarH").Rows.Count <> 0 Then
        '    grdDataRows.DataSource = ds.Tables(0)
        '    Call FormatGrdSale()
        '    IsFindRepair = True
        'End If


        'Dim Sql As String = "SELECT * "
        'Sql = Sql + " FROM  QEa_DocSysItem "
        'Sql = Sql + cri
        'Sql = Sql + " Order by REFNO,REFNODATA asc "



        Dim Sql As String = "SELECT QEa_DocSysItem_H.REFNO, dbo.QEa_DocSysItem_H.DOCDEPT, dbo.QEa_DocSysItem.* "
        Sql = Sql + " FROM  QEa_DocSysItem_H LEFT OUTER Join QEa_DocSysItem ON dbo.QEa_DocSysItem_H.REFNO = QEa_DocSysItem.REFNO "
        Sql = Sql + cri
        Sql = Sql + " Order by QEa_DocSysItem_H.REFNO,QEa_DocSysItem.REFNODATA asc "




        ' Select Case dbo.QEa_DocSysItem_H.REFNO, dbo.QEa_DocSysItem.DOCDEPT, dbo.QEa_DocSysItem.*
        'From dbo.QEa_DocSysItem_H LEFT OUTER Join dbo.QEa_DocSysItem ON dbo.QEa_DocSysItem_H.REFNO = dbo.QEa_DocSysItem.REFNO

        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        grdDataRows.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows

            'Dim Sql1 As String = "Select RefNoData,LineData,VerStatus "
            'Sql1 = Sql1 + " From QEa_Car_Verification WHERE RefNoData ='" & Dtr.Item("RefNoData").ToString & "' "
            'Sql1 = Sql1 + " And LineData In ( Select MAX(LineData) From QEa_Car_Verification"
            'Sql1 = Sql1 + " WHERE RefNoData ='" & Dtr.Item("RefNoData").ToString & "' )"
            'Dim Dt1 As New DataTable
            'Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'Dim strVerStatus As String = ""
            'For Each Dtr1 As DataRow In Dt1.Rows
            '    strVerStatus = Dtr1.Item("VerStatus").ToString


            'Next

            Dim strMANAGEFind As String = ""
            Select Case Dtr.Item("MANAGE").ToString
                Case "N"
                    strMANAGEFind = "จัดทำใหม่"
                Case "E"
                    strMANAGEFind = "แก้ไข"
                Case "O"
                    If Dtr.Item("ACTOBS").ToString = "สำเนา" Then
                        strMANAGEFind = "ยกเลิกสำเนา"
                    ElseIf Dtr.Item("ACTOBS").ToString = "ต้นฉบับ" Then
                        strMANAGEFind = "ยกเลิกต้นฉบับ"
                    End If

                Case "C"
                    strMANAGEFind = "ขอสำเนาเพิ่ม"
                Case "R"
                    strMANAGEFind = "ขอสำเนาทดแทน"
                Case "U"
                    strMANAGEFind = "ขอนำเอกสารยกเลิกกลับมาใช้"
            End Select








            With grdDataRows
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()


                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("DARNO").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                .Item(5, .Rows.Count - 2).Value = strMANAGEFind
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("PETITIONDEPT").ToString
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("PETITIONBRANCH").ToString
                .Item(9, .Rows.Count - 2).Value = Dtr.Item("PETITIONDATE").ToString
                ' .Item(10, .Rows.Count - 2).Value = Dtr.Item("").ToString
                .Item(11, .Rows.Count - 2).Value = Dtr.Item("EFFDATE").ToString
                '.Item(12, .Rows.Count - 2).Value = Dtr.Item("").ToString
                '.Item(13, .Rows.Count - 2).Value = Dtr.Item("").ToString
                '.Item(14, .Rows.Count - 2).Value = Dtr.Item("").ToString
                '.Item(15, .Rows.Count - 2).Value = Dtr.Item("").ToString
                '.Item(16, .Rows.Count - 2).Value = Dtr.Item("").ToString
                .Item(17, .Rows.Count - 2).Value = Dtr.Item("REFNODATA").ToString
                .Item(18, .Rows.Count - 2).Value = Dtr.Item("SELECTSYSTEM").ToString


            End With

            intNo = intNo + 1
            '
        Next




        Me.grdDataRows.AllowUserToAddRows = False

        ' Return = Nothing

        '     Catch ex As Exception

        '  End Try
    End Sub

    Private Sub ToolStripButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripButton1.MouseUp
        'Try


        '    If e.Button = MouseButtons.Left Then

        '        'strLineData = ""
        '        'strChekGrid = ""
        '        'strChekGrid = "Additem"
        '        'strLineRefNoData = ""
        '        'strLineRefNoData = TxtREFNO.Text
        '        'strLineData = dgvDATA.Rows(e.RowIndex).Cells(14).Value().ToString.Trim()
        '        'strLineDataDAR = dgvDATA.Rows(e.RowIndex).Cells(4).Value().ToString.Trim()

        '        Me.MetroContextMenu2.Show(grdDataRows, e.Location)
        '        MetroContextMenu2.Show(Cursor.Position)


        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ToolStripButton2_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripButton2.MouseUp
        Try


            If e.Button = MouseButtons.Left Then

                'strLineData = ""
                'strChekGrid = ""
                'strChekGrid = "Additem"
                'strLineRefNoData = ""
                'strLineRefNoData = TxtREFNO.Text
                'strLineData = dgvDATA.Rows(e.RowIndex).Cells(14).Value().ToString.Trim()
                'strLineDataDAR = dgvDATA.Rows(e.RowIndex).Cells(4).Value().ToString.Trim()

                Me.MetroContextMenu2.Show(grdDataRows, e.Location)
                MetroContextMenu2.Show(Cursor.Position)


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmDocumentSystem_Find_ImeModeChanged(sender As Object, e As EventArgs) Handles Me.ImeModeChanged

    End Sub
End Class