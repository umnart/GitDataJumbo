Public Class _0FrmBackup_Program
    Private Sub _0FrmBackup_Program_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '    Private Sub _0FrmBackup_Program_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    End Sub

    '    Sub CheckRevNo()
    '          Sub LoadGridDataSD()



    '        CmdExcute("DELETE FROM QEa_Training_History_ChkRev  WHERE ComName='" & strHostName & "' ", DB_CMD.ObjConn)


    '        ' dgvDetail.Rows.Clear()
    '        Dim sqlinsert As String

    '        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)



    '        '  dgvDetail.Rows.Clear()

    '        ' Select Case hISToRy
    '        'Sql = Sql + "AND (QEa_Training_History.Dept = '" & strDeptData & "') "

    '        '*****  29-08-2022 
    '        Dim strCri As String = ""
    '        If TxtDOCNO.Text = "" Then
    '            strCri = "WHERE (QEa_Training_History.Result = 0)  AND QEa_Training_History.Dept = '" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "' AND QEa_Training_History.MD = '" & strMD & "' "
    '        Else
    '            strCri = "WHERE (QEa_Training_History.Result = 0)  AND QEa_Training_History.Dept = '" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "' AND QEa_Training_History.MD = '" & strMD & "' AND QEa_Training_History.DOCNO = '" & TxtDOCNO.Text & "' "
    '        End If

    '        Dim Sql As String = " SELECT QEa_Training_History.EmployeeNo, QEa_Training_History.DOCNO, QEa_Training_History.REVNO, QEa_Training_History.DOCDEPT, QEa_Training_History.MD, "
    '        Sql = Sql + " QEa_Training_History.EFFDATE, QEa_Training_History.MthdCode, QEa_Training_History.TrnnDate, QEa_Training_History.Result, QEa_Training_History.Approve, QEa_Training_History.Remark, "
    '        Sql = Sql + " QEa_Training_History.Dept, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_History.RetrainFreq,QEa_Training_Person.Section "
    '        Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_History ON QEa_Training_Assign.EmployeeNo = QEa_Training_History.EmployeeNo AND QEa_Training_Assign.DOCNO = QEa_Training_History.DOCNO AND "
    '        Sql = Sql + " QEa_Training_Assign.Dept = dbo.QEa_Training_History.Dept LEFT OUTER JOIN QEa_Training_Person On QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
    '        Sql = Sql + strCri
    '        Sql = Sql + "ORDER BY QEa_Training_History.DOCNO, QEa_Training_History.REVNO"
    '        Dim Dt As New DataTable
    '        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

    '        Dim intNo As Integer = 1
    '        Dim strstatus As String = ""
    '        For Each Dtr As DataRow In Dt.Rows
    '            LoadingForm.Show()
    '            LoadingForm.SetData(Dt.Rows.Count, "Loading...Check Hoistory ")


    '            If IsDBNull(Dtr.Item("MthdCode").ToString) Or Dtr.Item("MthdCode").ToString = "" Then
    '                GoTo Next_STEP1
    '                MsgBox(" พนักงาน : '" & Dtr.Item("EmployeeName").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")

    '                Exit Sub


    '            End If


    '            sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,ComName,EmployeeName,RetrainFreq,Section) " &
    '                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@TrnnDate,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@ComName,@EmployeeName,@RetrainFreq,@Section)"

    '            With comSave
    '                .Parameters.Clear()
    '                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr.Item("EmployeeNo").ToString
    '                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString
    '                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr.Item("REVNO").ToString
    '                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)


    '                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr.Item("DOCNO").ToString & "' ORDER BY DOCNO "
    '                Dim Dt21 As New DataTable
    '                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
    '                For Each Dtr21 As DataRow In Dt21.Rows

    '                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
    '                    GoTo NEXTDATA
    '                Next
    'NEXTDATA:
    '                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
    '                Dim Dt2 As New DataTable
    '                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
    '                For Each Dtr2 As DataRow In Dt2.Rows
    '                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
    '                Next

    '                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr.Item("DOCDEPT").ToString


    '                If IsDBNull(Dtr.Item("TrnnDate").ToString) Or (Dtr.Item("TrnnDate").ToString) = "" Then
    '                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = DBNull.Value
    '                Else
    '                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
    '                End If



    '                ' .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
    '                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr.Item("Result").ToString = 1
    '                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
    '                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr.Item("Remark").ToString
    '                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr.Item("MthdCode").ToString
    '                .Parameters.Add("@MD", SqlDbType.VarChar).Value = Dtr.Item("MD").ToString
    '                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr.Item("Dept").ToString
    '                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

    '                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr.Item("EmployeeName").ToString

    '                If IsDBNull(Dtr.Item("RetrainFreq").ToString) Then
    '                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0
    '                Else
    '                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = Dtr.Item("RetrainFreq").ToString

    '                End If
    '                If IsDBNull(Dtr.Item("Section").ToString) Or Dtr.Item("Section").ToString = "" Then
    '                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
    '                Else
    '                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr.Item("Section").ToString

    '                End If
    '                .CommandText = sqlinsert
    '                .Connection = DB_CMD.ObjConn
    '                .ExecuteNonQuery()

    '            End With
    'Next_STEP1:


    '            LoadingForm.nextProcess()
    '            Application.DoEvents()
    '        Next




    '        Dim Dt9 As DataTable
    '        If TxtDOCNO.Text = "" Then
    '            Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section "
    '            Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
    '            Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "' "
    '            Sql9 = Sql9 + "AND QEa_Training_Assign.Dept ='" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "'  "
    '            Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section "
    '            Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "

    '            ' Dim Dt9 As DataTable
    '            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
    '        Else
    '            Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section,QEa_Training_Assign.DOCNO "
    '            Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
    '            Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "'  AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
    '            Sql9 = Sql9 + " And QEa_Training_Assign.Dept ='" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "'  "
    '            Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section,QEa_Training_Assign.DOCNO "
    '            Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "
    '            ' Dim Dt9 As DataTable
    '            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
    '        End If


    '        For Each Dtr9 As DataRow In Dt9.Rows


    '            '  Dim strStartDatehk As Date = Dtr9.Item("StartDate").ToString
    '            TxtStartDate.Text = Dtr9.Item("StartDate").ToString
    '            '  strStartDatehk = (Dtr9.Item("StartDate").ToString("yyyy-MM-dd"))


    '            'If (TxtStartDate.InvokeRequired) Then

    '            '    TxtStartDate.Invoke(Sub() Text = Dtr9.Item("StartDate").ToString)


    '            '    ' Invoke(New Action(RunButtonClicked));
    '            '    TxtStartDate.Text = Dtr9.Item("StartDate").ToString
    '            'Else
    '            '    TxtStartDate.Text = Dtr9.Item("StartDate").ToString
    '            'End If

    '            '    strStartDatehk = strStartDatehk.Date.ToString("yyyy-MM-dd")

    '            'Dim Sql1 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO As MAXREVNO , QEa_CourseMaster.EFFDATE  As MAXEFFDATE , dbo.QEa_Training_Assign.StartDate "
    '            'Sql1 = Sql1 + " From QEa_Training_Assign LEFT OUTER Join QEa_CourseMaster On QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO And QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
    '            'Sql1 = Sql1 + " Where CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtEFFDate.Text & "' "
    '            'Sql1 = Sql1 + " And (QEa_Training_Assign.DEPT = '" & strDeptData & "') "
    '            'Sql1 = Sql1 + " And (QEa_CourseMaster.STATUS = 'A') "
    '            'Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
    '            'Sql1 = Sql1 + " And CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
    '            'Sql1 = Sql1 + " AND QEa_Training_Assign.DOCNO = '" & Dtr9.Item("DOCNO").ToString & "' "
    '            'Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "
    '            'Dim Dt1 As DataTable
    '            'Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)




    '            Dim Dt1 As DataTable

    '            If TxtDOCNO.Text = "" Then
    '                Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
    '                Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
    '                Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
    '                Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
    '                Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
    '                Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
    '                Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
    '                Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
    '                Sql1 = Sql1 + " UNION "
    '                Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
    '                Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
    '                Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
    '                Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
    '                Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') "
    '                Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
    '                Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


    '                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
    '            Else
    '                Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
    '                Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
    '                Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
    '                Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
    '                Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
    '                Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
    '                Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
    '                Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
    '                Sql1 = Sql1 + " UNION "
    '                Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
    '                Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
    '                Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
    '                Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
    '                Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
    '                Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
    '                Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


    '                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
    '            End If



    '            For Each Dtr1 As DataRow In Dt1.Rows
    '                LoadingForm.Show()
    '                LoadingForm.SetData(Dt1.Rows.Count, "Check Effect Date(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr1.Item("DOCNO").ToString & ")")


    '                If IsDBNull(Dtr1.Item("MthdCode").ToString) Or Dtr1.Item("MthdCode").ToString = "" Then
    '                    GoTo NEXTSTEPDATA
    '                    MsgBox(" พนักงาน  '" & Dtr1.Item("EmployeeNo").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
    '                    Exit Sub

    '                End If




    '                Dim Sql91 As String = "Select  * "
    '                Sql91 = Sql91 + "FROM QEa_Training_History_ChkRev "
    '                Sql91 = Sql91 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
    '                Sql91 = Sql91 + "AND Dept ='" & strDeptData & "' "
    '                Sql91 = Sql91 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
    '                Sql91 = Sql91 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
    '                Sql91 = Sql91 + "ORDER BY DOCNO, REVNO "
    '                Dim Dt91 As DataTable
    '                Dt91 = DB_CMD.GetData_Table(Sql91, DB_CMD.ObjConn)
    '                For Each Dtr91 As DataRow In Dt91.Rows
    '                    GoTo NEXTSTEPDATA
    '                Next



    '                Dim Sql92 As String = "Select  * "
    '                Sql92 = Sql92 + "FROM QEa_Training_History "
    '                Sql92 = Sql92 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
    '                Sql92 = Sql92 + "AND Dept ='" & strDeptData & "' "
    '                Sql92 = Sql92 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
    '                Sql92 = Sql92 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
    '                Sql92 = Sql92 + "ORDER BY DOCNO, REVNO "
    '                Dim Dt92 As DataTable
    '                Dt92 = DB_CMD.GetData_Table(Sql92, DB_CMD.ObjConn)
    '                For Each Dtr92 As DataRow In Dt92.Rows
    '                    GoTo NEXTSTEPDATA
    '                Next




    '                sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq,Section) " &
    '                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq,@Section)"

    '                With comSave
    '                    .Parameters.Clear()
    '                    .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr1.Item("EmployeeNo").ToString
    '                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr1.Item("DOCNO").ToString
    '                    .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr1.Item("MAXREVNO").ToString
    '                    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr1.Item("MAXEFFDATE")
    '                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr1.Item("DOCNAME").ToString

    '                    Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr1.Item("MthdCode").ToString & "' ORDER BY MthdCode "
    '                    Dim Dt2 As New DataTable
    '                    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

    '                    For Each Dtr2 As DataRow In Dt2.Rows
    '                        .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
    '                    Next

    '                    ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
    '                    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr1.Item("DOCDEPT").ToString
    '                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr1.Item("Approve").ToString
    '                    .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr1.Item("MthdCode").ToString
    '                    .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
    '                    .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
    '                    .Parameters.Add("@Result", SqlDbType.Int).Value = 0
    '                    .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
    '                    .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeName").ToString
    '                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0

    '                    If IsDBNull(Dtr9.Item("Section").ToString) Or Dtr9.Item("Section").ToString = "" Then
    '                        .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
    '                    Else
    '                        .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr9.Item("Section").ToString

    '                    End If


    '                    .CommandText = sqlinsert
    '                    .Connection = DB_CMD.ObjConn
    '                    .ExecuteNonQuery()


    '                End With








    'NEXTSTEPDATA:

    '                LoadingForm.nextProcess()
    '                Application.DoEvents()

    '            Next



    '        Next


    '        Call LoadDataRetraingFreq()

    '        Call LoadDataCheck()

    '        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Or strApprove = "Supervisor" Then
    '            pnApprove.Visible = True
    '        Else
    '            pnApprove.Visible = False
    '        End If
    '        '' Call LoadDataGrid()




    '    End Sub
    '    End Sub
End Class