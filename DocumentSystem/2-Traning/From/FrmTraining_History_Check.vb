Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Reflection
Imports System.ComponentModel
Imports System.Threading
Public Class FrmTraining_History_Check
    Public CommandType As String
    Public EditNo As String
    Dim strCri As String

    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim comSave As New SqlCommand
    Dim comDelete As New SqlCommand
    Dim comUpdate As New SqlCommand
    Private WithEvents bgWorker As BackgroundWorker
    Dim strEmployeeNODataChk As String = ""
    Dim strDOCNOHistoryChk As String = ""
    Dim intREVNOHistoryChk As Integer
    Dim intRetrainFreqHistoryChk As Integer
    Dim maxProcess As Integer
    Dim percentOfProcess, checkPercent As Double
    Dim strLoading As String
    Dim strSuccess As String
    Dim count As Integer




    Private Sub bntClose_Click(sender As Object, e As EventArgs)

    End Sub

    Sub LoadData()


        ' dgvDetail.Rows.Clear()
        Dim sqlinsert As String
        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)

        CmdExcute("DELETE FROM QEa_Training_History_ChkRev  WHERE Dept='" & strDeptData & "' ", DB_CMD.ObjConn)


        Me.dgvDetail.AllowUserToAddRows = True
        '  dgvDetail.Rows.Clear()

        ' Select Case hISToRy

        Dim Sql As String = " SELECT QEa_Training_History.EmployeeNo, QEa_Training_History.DOCNO, QEa_Training_History.REVNO, QEa_Training_History.DOCDEPT, QEa_Training_History.MD, "
        Sql = Sql + " QEa_Training_History.EFFDATE, QEa_Training_History.MthdCode, QEa_Training_History.TrnnDate, QEa_Training_History.Result, QEa_Training_History.Approve, QEa_Training_History.Remark, "
        Sql = Sql + " QEa_Training_History.Dept, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName "
        Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_History ON QEa_Training_Assign.EmployeeNo = QEa_Training_History.EmployeeNo AND QEa_Training_Assign.DOCNO = QEa_Training_History.DOCNO AND "
        Sql = Sql + " QEa_Training_Assign.Dept = dbo.QEa_Training_History.Dept LEFT OUTER JOIN QEa_Training_Person On QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        Sql = Sql + " WHERE(QEa_Training_History.EFFDATE >= Convert(DateTime, '" & TxtEFFDate.Text & "', 102)) "
        Sql = Sql + "AND (QEa_Training_History.Result = 0) "
        Sql = Sql + "AND (QEa_Training_History.Dept = '" & strDeptData & "') "
        'Sql = Sql + "AND  (QEa_Training_Assign.StartDate >= Convert(DateTime, '2006-01-01 00:00:00', 102)) "
        Sql = Sql + "ORDER BY QEa_Training_History.DOCNO, QEa_Training_History.REVNO"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr As DataRow In Dt.Rows


            sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,ComName,EmployeeName) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@TrnnDate,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@ComName,@EmployeeName)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr.Item("EmployeeNo").ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr.Item("REVNO").ToString
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)


                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                Dim Dt21 As New DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                For Each Dtr21 As DataRow In Dt21.Rows
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
                Next

                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                For Each Dtr2 As DataRow In Dt2.Rows
                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                Next

                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr.Item("DOCDEPT").ToString
                .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr.Item("Result").ToString = 1
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr.Item("Remark").ToString
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr.Item("MthdCode").ToString
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = Dtr.Item("MD").ToString
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr.Item("Dept").ToString
                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr.Item("EmployeeName").ToString


                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With

        Next


        'Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate,QEa_Training_Assign.DOCNO, QEa_Training_Person.EmployeeName "
        'Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        'Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "' "
        'Sql9 = Sql9 + "AND QEa_Training_Assign.Dept ='" & strDeptData & "' "
        'Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo,QEa_Training_Assign.DOCNO, QEa_Training_Person.EmployeeName "
        'Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "

        Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName, QEa_Training_Assign.DOCNO "
        Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "' "
        Sql9 = Sql9 + "AND QEa_Training_Assign.Dept ='" & strDeptData & "' "
        Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName, QEa_Training_Assign.DOCNO "
        Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate,QEa_Training_Assign.DOCNO "
        Dim Dt9 As DataTable
        Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        For Each Dtr9 As DataRow In Dt9.Rows

            TxtStartDate.Text = Dtr9.Item("StartDate").ToString





            'Dim Sql1 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO As MAXREVNO , QEa_CourseMaster.EFFDATE  As MAXEFFDATE , dbo.QEa_Training_Assign.StartDate "
            'Sql1 = Sql1 + " From QEa_Training_Assign LEFT OUTER Join QEa_CourseMaster On QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO And QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            'Sql1 = Sql1 + " Where CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtEFFDate.Text & "' "
            'Sql1 = Sql1 + " And (QEa_Training_Assign.DEPT = '" & strDeptData & "') "
            'Sql1 = Sql1 + " And (QEa_CourseMaster.STATUS = 'A') "
            'Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
            'Sql1 = Sql1 + " And CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            'Sql1 = Sql1 + " AND QEa_Training_Assign.DOCNO = '" & Dtr9.Item("DOCNO").ToString & "' "
            'Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


            Dim Sql1 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO As MAXREVNO , QEa_CourseMaster.EFFDATE  As MAXEFFDATE , dbo.QEa_Training_Assign.StartDate "
            Sql1 = Sql1 + " From QEa_Training_Assign LEFT OUTER Join QEa_CourseMaster On QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO And QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            Sql1 = Sql1 + " Where CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtEFFDate.Text & "' "
            Sql1 = Sql1 + " And (QEa_Training_Assign.DEPT = '" & strDeptData & "') "
            Sql1 = Sql1 + " And (QEa_CourseMaster.STATUS = 'A') "
            Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
            Sql1 = Sql1 + " And CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            Sql1 = Sql1 + " AND QEa_Training_Assign.DOCNO = '" & Dtr9.Item("DOCNO").ToString & "' "
            Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "
            Dim Dt1 As DataTable
            Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)


            For Each Dtr1 As DataRow In Dt1.Rows

                'If Dtr1.Item("MAXEFFDATE").ToString < strStartDate Then
                '    GoTo NEXTSTEPDATA
                'End If

                Dim strDocxx As String = ""
                Dim strEFF As String = ""
                Dim strRevvv As Integer

                '  If Dtr1.Item("DOCNO").ToString = "Att.1-A" Then


                '  MsgBox("cxxxx")


                TxtChkStartDate.Text = Dtr1.Item("MAXEFFDATE").ToString


                    If TxtChkStartDate.Text < TxtStartDate.Text Then
                        GoTo NEXTSTEPDATA
                    End If

                'strRevvv = Dtr1.Item("MAXREVNO").ToString

                '  End If

                Dim Sql91 As String = "Select  * "
                Sql91 = Sql91 + "FROM QEa_Training_History_ChkRev "
                Sql91 = Sql91 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                Sql91 = Sql91 + "AND Dept ='" & strDeptData & "' "
                Sql91 = Sql91 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                Sql91 = Sql91 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                Sql91 = Sql91 + "ORDER BY DOCNO, REVNO "
                Dim Dt91 As DataTable
                Dt91 = DB_CMD.GetData_Table(Sql91, DB_CMD.ObjConn)
                For Each Dtr91 As DataRow In Dt91.Rows
                    GoTo NEXTSTEPDATA
                Next


                sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr1.Item("EmployeeNo").ToString
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr1.Item("DOCNO").ToString
                    .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr1.Item("MAXREVNO").ToString
                    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr1.Item("MAXEFFDATE")
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr1.Item("DOCNAME").ToString
                    Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr1.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                    Dim Dt2 As New DataTable
                    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                    For Each Dtr2 As DataRow In Dt2.Rows
                        .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                    Next

                    ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr1.Item("DOCDEPT").ToString
                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr1.Item("Approve").ToString
                    .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr1.Item("MthdCode").ToString
                    .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                    .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                    .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                    .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                    .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeName").ToString
                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With








NEXTSTEPDATA:

            Next

        Next






        Call LoadDataCheck()
        '' Call LoadDataGrid()


    End Sub

    Sub LoadDataCheck()

        'If strDeptData <> "SD" Then



        '    Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "
        '    Sql = Sql + "From QEa_Training_History_ChkRev  "
        '    Sql = Sql + "WHERE ComName = '" & strHostName & "' "
        '    Sql = Sql + "AND Dept = '" & strDeptData & "'"
        '    Sql = Sql + "AND MD = '" & strMD & "'"
        '    Sql = Sql + "ORDER BY DOCNO,REVNO"
        '    Dim Dt As New DataTable
        '    Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        '    Dim Da = New SqlDataAdapter(Cmd)
        '    Da.Fill(Dt)
        '    Da.Dispose()
        '    dgvDetail.DataSource = Dt

        'Else

        '    Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "
        '    Sql = Sql + "From QEa_Training_History_ChkRev  "
        '    Sql = Sql + "WHERE ComName = '" & strHostName & "' "
        '    Sql = Sql + "AND Dept = '" & strDeptData & "'"
        '    Sql = Sql + "AND MD = '" & strMD & "'"
        '    Sql = Sql + "AND Section = '" & TxtSection.Text & "'"
        '    Sql = Sql + "ORDER BY DOCNO,REVNO"
        '    Dim Dt As New DataTable
        '    Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        '    Dim Da = New SqlDataAdapter(Cmd)
        '    Da.Fill(Dt)
        '    Da.Dispose()
        '    dgvDetail.DataSource = Dt

        'End If


        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "
        Sql = Sql + "From QEa_Training_History_ChkRev  "
        Sql = Sql + "WHERE ComName = '" & strHostName & "' "
        Sql = Sql + "AND Dept = '" & strDeptData & "'"
        Sql = Sql + "AND MD = '" & strMD & "'"
        Sql = Sql + "AND Section = '" & TxtSection.Text & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt

        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible = False
        dgvDetail.Columns(17).Visible = False


        'Dim command As New SqlCommand("SELECT  EmployeeNo, EmployeeNo + ' : ' + EmployeeName AS EmployeeData FROM  QEa_Training_Person WHERE Dept = '" & strDeptData & "' AND MD = '" & strMD & "' and NOT (EmployeeNo IS NULL) ORDER BY EmployeeNo  ", DB_CMD.ObjConn)
        'Dim table As New DataTable
        'Dim adapter As New SqlDataAdapter(command)
        'Dim ds As New DataSet
        'adapter.Fill(table)

        ''adapter.Fill(ds)

        ''For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
        ''    TxtEmployeeNo.Items.Add(ds.Tables(0).Rows(i)(0) & "   :   " & ds.Tables(0).Rows(i)(1))
        ''    ' i = i + 1
        ''Next



        'adapter.Fill(ds, "QEa_Training_Person")
        'If table.Rows.Count > 0 Then
        '    TxtEmployeeNo.DisplayMember = "EmployeeData"
        '    TxtEmployeeNo.ValueMember = "EmployeeNo"
        '    TxtEmployeeNo.DataSource = ds.Tables("QEa_Training_Person")

        'End If

        'Exit Sub


    End Sub
    Sub LoadDataGrid()

        Dim Sql99 As String = "Select  * "
        Sql99 = Sql99 + "From QEa_Training_History_ChkRev  "
        Sql99 = Sql99 + "WHERE ComName = '" & strHostName & "' "
        Sql99 = Sql99 + "AND Dept = '" & strDeptData & "'"
        Sql99 = Sql99 + "AND MD = '" & strMD & "'"
        Sql99 = Sql99 + "ORDER BY DOCNO,REVNO"
        Dim Dt99 As New DataTable
        Dt99 = DB_CMD.GetData_Table(Sql99, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr99 As DataRow In Dt99.Rows


            With dgvDetail
                ' intM = 1
                'intW = 1


                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr99.Item("DOCNO").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr99.Item("REVNO").ToString
                .Item(3, .Rows.Count - 2).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)
                .Item(4, .Rows.Count - 2).Value = Dtr99.Item("DOCNAME").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr99.Item("EmployeeNo").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr99.Item("EmployeeName").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr99.Item("MthdNam").ToString

                .Item(8, .Rows.Count - 2).Value = Dtr99.Item("DOCDEPT").ToString
                .Item(9, .Rows.Count - 2).Value = Mid(Dtr99.Item("TrnnDate").ToString, 1, 10)

                If Dtr99.Item("Result").ToString = 1 Then
                    .Item(10, .Rows.Count - 2).Value = 1
                End If

                '.Item(8, .Rows.Count - 2).Value = Dtr99.Item("Result")
                .Item(11, .Rows.Count - 2).Value = Dtr99.Item("Approve").ToString
                .Item(12, .Rows.Count - 2).Value = Dtr99.Item("Remark").ToString
                .Item(13, .Rows.Count - 2).Value = Dtr99.Item("MthdCode").ToString

            End With

            intNo = intNo + 1
        Next


    End Sub
    Private Sub GetHostName()
        Try

            strHostName = System.Net.Dns.GetHostName()

            'strBranch = Mid(strHostName, 1, 1)
            ''strBranch = "N"
            ''= strDept


        Catch ex As Exception
            MsgBox("เกิดข้อผิดพลาดแก้ไขข้อมูล GetHostName  ", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub FrmTraining_History_Check_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If strDeptData = "SD" Then
        '    TxtSection.Visible = True
        '    bntSDFind.Visible = True
        '    bntFind.Visible = False
        '    Panel8.Visible = True
        'Else
        '    Panel8.Visible = False
        '    TxtSection.Visible = False
        '    bntSDFind.Visible = False
        '    bntFind.Visible = True
        'End If

        TxtSection.Visible = True
        bntSDFind.Visible = True
        bntFind.Visible = False
        Panel8.Visible = True

        pnApprove.Visible = False

        Call Grid()

        Call GetHostName()





    End Sub
    Sub GetSectionDept()

        Dim command As New SqlCommand("SELECT  Section FROM  QEa_Training_Person WHERE Dept = '" & strDeptData & "' AND MD = '" & strMD & "' and NOT (EmployeeNo IS NULL)  GROUP BY Section ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)

        'adapter.Fill(ds)

        'For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
        '    TxtEmployeeNo.Items.Add(ds.Tables(0).Rows(i)(0) & "   :   " & ds.Tables(0).Rows(i)(1))
        '    ' i = i + 1
        'Next



        adapter.Fill(ds, "QEa_Training_Person")
        If table.Rows.Count > 0 Then
            TxtSection.DisplayMember = "Section"
            TxtSection.ValueMember = "Section"
            TxtSection.DataSource = ds.Tables("QEa_Training_Person")

        End If

        Exit Sub

    End Sub
    Sub Grid()
        Me.dgvDetail.AllowUserToAddRows = False
        With Me.dgvDetail
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.LightGray
        End With
    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Me.Cursor = Cursors.WaitCursor
        Me.dgvDetail.AllowUserToAddRows = True

        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "

        Sql = Sql + "From QEa_Training_History_ChkRev  "
        Sql = Sql + "WHERE ComName = 'xxxx' "
        Sql = Sql + "AND Dept = 'xxx' "
        Sql = Sql + "AND MD = '" & strMD & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt

        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible = False
        dgvDetail.Columns(17).Visible = False

        Call LoadGridData()

        Me.dgvDetail.AllowUserToAddRows = False
    End Sub

    Sub LoadGridData()


        ' dgvDetail.Rows.Clear()
        Dim sqlinsert As String
        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)

        CmdExcute("DELETE FROM QEa_Training_History_ChkRev  WHERE Dept='" & strDeptData & "' ", DB_CMD.ObjConn)

        Me.dgvDetail.AllowUserToAddRows = True
        '  dgvDetail.Rows.Clear()

        ' Select Case hISToRy
        'Sql = Sql + "AND (QEa_Training_History.Dept = '" & strDeptData & "') "
        Dim Sql As String = " SELECT QEa_Training_History.EmployeeNo, QEa_Training_History.DOCNO, QEa_Training_History.REVNO, QEa_Training_History.DOCDEPT, QEa_Training_History.MD, "
        Sql = Sql + " QEa_Training_History.EFFDATE, QEa_Training_History.MthdCode, QEa_Training_History.TrnnDate, QEa_Training_History.Result, QEa_Training_History.Approve, QEa_Training_History.Remark, "
        Sql = Sql + " QEa_Training_History.Dept, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_History.RetrainFreq "
        Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_History ON QEa_Training_Assign.EmployeeNo = QEa_Training_History.EmployeeNo AND QEa_Training_Assign.DOCNO = QEa_Training_History.DOCNO AND "
        Sql = Sql + " QEa_Training_Assign.Dept = dbo.QEa_Training_History.Dept LEFT OUTER JOIN QEa_Training_Person On QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        Sql = Sql + "WHERE (QEa_Training_History.Result = 0) "
        Sql = Sql + "AND (QEa_Training_History.Dept = '" & strDeptData & "') "
        Sql = Sql + "AND QEa_Training_History.MD = '" & strMD & "' "
        Sql = Sql + "ORDER BY QEa_Training_History.DOCNO, QEa_Training_History.REVNO"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr As DataRow In Dt.Rows


            If IsDBNull(Dtr.Item("MthdCode").ToString) Or Dtr.Item("MthdCode").ToString = "" Then
                GoTo Next_STEP1
                MsgBox(" พนักงาน : '" & Dtr.Item("EmployeeName").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")

                Exit Sub


            End If


            sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,ComName,EmployeeName,RetrainFreq) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@TrnnDate,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@ComName,@EmployeeName,@RetrainFreq)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr.Item("EmployeeNo").ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr.Item("REVNO").ToString
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)


                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                Dim Dt21 As New DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                For Each Dtr21 As DataRow In Dt21.Rows

                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
                    GoTo NEXTDATA
                Next
NEXTDATA:
                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                For Each Dtr2 As DataRow In Dt2.Rows
                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                Next

                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr.Item("DOCDEPT").ToString


                If IsDBNull(Dtr.Item("TrnnDate").ToString) Or (Dtr.Item("TrnnDate").ToString) = "" Then
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = DBNull.Value
                Else
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                End If



                ' .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr.Item("Result").ToString = 1
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr.Item("Remark").ToString
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr.Item("MthdCode").ToString
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = Dtr.Item("MD").ToString
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr.Item("Dept").ToString
                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr.Item("EmployeeName").ToString

                If IsDBNull(Dtr.Item("RetrainFreq").ToString) Then
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0
                Else
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = Dtr.Item("RetrainFreq").ToString

                End If

                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With
Next_STEP1:
        Next


        'Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate,QEa_Training_Assign.DOCNO, QEa_Training_Person.EmployeeName "
        'Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        'Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "' "
        'Sql9 = Sql9 + "AND QEa_Training_Assign.Dept ='" & strDeptData & "' "
        'Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo,QEa_Training_Assign.DOCNO, QEa_Training_Person.EmployeeName "
        'Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "

        Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName "
        Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "' "
        Sql9 = Sql9 + "AND QEa_Training_Assign.Dept ='" & strDeptData & "' "
        Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName "
        Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "
        Dim Dt9 As DataTable
        Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        For Each Dtr9 As DataRow In Dt9.Rows

            TxtStartDate.Text = Dtr9.Item("StartDate").ToString



            'Dim Sql1 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO As MAXREVNO , QEa_CourseMaster.EFFDATE  As MAXEFFDATE , dbo.QEa_Training_Assign.StartDate "
            'Sql1 = Sql1 + " From QEa_Training_Assign LEFT OUTER Join QEa_CourseMaster On QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO And QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            'Sql1 = Sql1 + " Where CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtEFFDate.Text & "' "
            'Sql1 = Sql1 + " And (QEa_Training_Assign.DEPT = '" & strDeptData & "') "
            'Sql1 = Sql1 + " And (QEa_CourseMaster.STATUS = 'A') "
            'Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
            'Sql1 = Sql1 + " And CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            'Sql1 = Sql1 + " AND QEa_Training_Assign.DOCNO = '" & Dtr9.Item("DOCNO").ToString & "' "
            'Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "
            'Dim Dt1 As DataTable
            'Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)





            Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
            Sql1 = Sql1 + " UNION "
            Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') "
            Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "

            Dim Dt1 As DataTable
            Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)


            For Each Dtr1 As DataRow In Dt1.Rows
                'If Dtr1.Item("EmployeeNo").ToString = "A499365" Then
                '    MsgBox("xxxx")
                'End If


                If IsDBNull(Dtr1.Item("MthdCode").ToString) Or Dtr1.Item("MthdCode").ToString = "" Then
                    GoTo NEXTSTEPDATA
                    MsgBox(" พนักงาน : '" & Dtr1.Item("EmployeeNo").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                    Exit Sub

                End If




                Dim Sql91 As String = "Select  * "
                Sql91 = Sql91 + "FROM QEa_Training_History_ChkRev "
                Sql91 = Sql91 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                Sql91 = Sql91 + "AND Dept ='" & strDeptData & "' "
                Sql91 = Sql91 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                Sql91 = Sql91 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                Sql91 = Sql91 + "ORDER BY DOCNO, REVNO "
                Dim Dt91 As DataTable
                Dt91 = DB_CMD.GetData_Table(Sql91, DB_CMD.ObjConn)
                For Each Dtr91 As DataRow In Dt91.Rows
                    GoTo NEXTSTEPDATA
                Next



                Dim Sql92 As String = "Select  * "
                Sql92 = Sql92 + "FROM QEa_Training_History "
                Sql92 = Sql92 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                Sql92 = Sql92 + "AND Dept ='" & strDeptData & "' "
                Sql92 = Sql92 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                Sql92 = Sql92 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                Sql92 = Sql92 + "ORDER BY DOCNO, REVNO "
                Dim Dt92 As DataTable
                Dt92 = DB_CMD.GetData_Table(Sql92, DB_CMD.ObjConn)
                For Each Dtr92 As DataRow In Dt92.Rows
                    GoTo NEXTSTEPDATA
                Next




                sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr1.Item("EmployeeNo").ToString
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr1.Item("DOCNO").ToString
                    .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr1.Item("MAXREVNO").ToString
                    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr1.Item("MAXEFFDATE")
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr1.Item("DOCNAME").ToString

                    Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr1.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                    Dim Dt2 As New DataTable
                    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

                    For Each Dtr2 As DataRow In Dt2.Rows
                        .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                    Next

                    ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr1.Item("DOCDEPT").ToString
                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr1.Item("Approve").ToString
                    .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr1.Item("MthdCode").ToString
                    .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                    .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                    .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                    .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                    .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeName").ToString
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With








NEXTSTEPDATA:

            Next

        Next





        Call LoadDataRetraingFreq()
        Call LoadDataCheck()
        '' Call LoadDataGrid()




    End Sub



    Sub LoadGridDataSD()



        CmdExcute("DELETE FROM QEa_Training_History_ChkRev  WHERE ComName='" & strHostName & "' ", DB_CMD.ObjConn)


        ' dgvDetail.Rows.Clear()
        Dim sqlinsert As String

        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)



        '  dgvDetail.Rows.Clear()

        ' Select Case hISToRy
        'Sql = Sql + "AND (QEa_Training_History.Dept = '" & strDeptData & "') "

        '*****  29-08-2022 
        Dim strCri As String = ""
        If TxtDOCNO.Text = "" Then
            strCri = "WHERE (QEa_Training_History.Result = 0)  AND QEa_Training_History.Dept = '" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "' AND QEa_Training_History.MD = '" & strMD & "' "
        Else
            strCri = "WHERE (QEa_Training_History.Result = 0)  AND QEa_Training_History.Dept = '" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "' AND QEa_Training_History.MD = '" & strMD & "' AND QEa_Training_History.DOCNO = '" & TxtDOCNO.Text & "' "
        End If

        Dim Sql As String = " SELECT QEa_Training_History.EmployeeNo, QEa_Training_History.DOCNO, QEa_Training_History.REVNO, QEa_Training_History.DOCDEPT, QEa_Training_History.MD, "
        Sql = Sql + " QEa_Training_History.EFFDATE, QEa_Training_History.MthdCode, QEa_Training_History.TrnnDate, QEa_Training_History.Result, QEa_Training_History.Approve, QEa_Training_History.Remark, "
        Sql = Sql + " QEa_Training_History.Dept, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_History.RetrainFreq,QEa_Training_Person.Section "
        Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_History ON QEa_Training_Assign.EmployeeNo = QEa_Training_History.EmployeeNo AND QEa_Training_Assign.DOCNO = QEa_Training_History.DOCNO AND "
        Sql = Sql + " QEa_Training_Assign.Dept = dbo.QEa_Training_History.Dept LEFT OUTER JOIN QEa_Training_Person On QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        Sql = Sql + strCri
        Sql = Sql + "ORDER BY QEa_Training_History.DOCNO, QEa_Training_History.REVNO"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr As DataRow In Dt.Rows
            LoadingForm.Show()
            LoadingForm.SetData(Dt.Rows.Count, "Loading...Check Hoistory ")


            If IsDBNull(Dtr.Item("MthdCode").ToString) Or Dtr.Item("MthdCode").ToString = "" Then
                GoTo Next_STEP1
                MsgBox(" พนักงาน : '" & Dtr.Item("EmployeeName").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")

                Exit Sub


            End If


            sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,ComName,EmployeeName,RetrainFreq,Section) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@TrnnDate,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@ComName,@EmployeeName,@RetrainFreq,@Section)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr.Item("EmployeeNo").ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr.Item("REVNO").ToString
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)


                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                Dim Dt21 As New DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                For Each Dtr21 As DataRow In Dt21.Rows

                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
                    GoTo NEXTDATA
                Next
NEXTDATA:
                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                For Each Dtr2 As DataRow In Dt2.Rows
                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                Next

                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr.Item("DOCDEPT").ToString


                If IsDBNull(Dtr.Item("TrnnDate").ToString) Or (Dtr.Item("TrnnDate").ToString) = "" Then
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = DBNull.Value
                Else
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                End If



                ' .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr.Item("Result").ToString = 1
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr.Item("Remark").ToString
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr.Item("MthdCode").ToString
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = Dtr.Item("MD").ToString
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr.Item("Dept").ToString
                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr.Item("EmployeeName").ToString

                If IsDBNull(Dtr.Item("RetrainFreq").ToString) Then
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0
                Else
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = Dtr.Item("RetrainFreq").ToString

                End If
                If IsDBNull(Dtr.Item("Section").ToString) Or Dtr.Item("Section").ToString = "" Then
                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                Else
                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr.Item("Section").ToString

                End If
                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With
Next_STEP1:


            LoadingForm.nextProcess()
            Application.DoEvents()
        Next




        Dim Dt9 As DataTable
        If TxtDOCNO.Text = "" Then
            Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section "
            Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
            Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "' "
            Sql9 = Sql9 + "AND QEa_Training_Assign.Dept ='" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "'  "
            Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section "
            Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "

            ' Dim Dt9 As DataTable
            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        Else
            Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section,QEa_Training_Assign.DOCNO "
            Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
            Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "'  AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            Sql9 = Sql9 + " And QEa_Training_Assign.Dept ='" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "'  "
            Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section,QEa_Training_Assign.DOCNO "
            Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "
            ' Dim Dt9 As DataTable
            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        End If


        For Each Dtr9 As DataRow In Dt9.Rows


            '  Dim strStartDatehk As Date = Dtr9.Item("StartDate").ToString
            TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            '  strStartDatehk = (Dtr9.Item("StartDate").ToString("yyyy-MM-dd"))


            'If (TxtStartDate.InvokeRequired) Then

            '    TxtStartDate.Invoke(Sub() Text = Dtr9.Item("StartDate").ToString)


            '    ' Invoke(New Action(RunButtonClicked));
            '    TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            'Else
            '    TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            'End If

            '    strStartDatehk = strStartDatehk.Date.ToString("yyyy-MM-dd")

            'Dim Sql1 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO As MAXREVNO , QEa_CourseMaster.EFFDATE  As MAXEFFDATE , dbo.QEa_Training_Assign.StartDate "
            'Sql1 = Sql1 + " From QEa_Training_Assign LEFT OUTER Join QEa_CourseMaster On QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO And QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            'Sql1 = Sql1 + " Where CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtEFFDate.Text & "' "
            'Sql1 = Sql1 + " And (QEa_Training_Assign.DEPT = '" & strDeptData & "') "
            'Sql1 = Sql1 + " And (QEa_CourseMaster.STATUS = 'A') "
            'Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
            'Sql1 = Sql1 + " And CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            'Sql1 = Sql1 + " AND QEa_Training_Assign.DOCNO = '" & Dtr9.Item("DOCNO").ToString & "' "
            'Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "
            'Dim Dt1 As DataTable
            'Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)




            Dim Dt1 As DataTable

            'If TxtDOCNO.Text = "" Then
            '    Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            '    Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            '    Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
            '    Sql1 = Sql1 + " UNION "
            '    Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') "
            '    Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


            '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'Else
            '    Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            '    Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            '    Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            '    Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
            '    Sql1 = Sql1 + " UNION "
            '    Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            '    Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


            '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'End If
            If TxtDOCNO.Text = "" Then
                Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
                Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
                Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
                Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
                Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
                Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
                Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
                Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "

                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            Else
                Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
                Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
                Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
                Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
                Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
                Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
                Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
                Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "

                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

            End If

            For Each Dtr1 As DataRow In Dt1.Rows
                LoadingForm.Show()
                LoadingForm.SetData(Dt1.Rows.Count, "Check Effect Date(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr1.Item("DOCNO").ToString & ")")


                If IsDBNull(Dtr1.Item("MthdCode").ToString) Or Dtr1.Item("MthdCode").ToString = "" Then
                    GoTo NEXTSTEPDATA
                    MsgBox(" พนักงาน  '" & Dtr1.Item("EmployeeNo").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                    Exit Sub

                End If

                Dim Sql91 As String = "Select  * "
                Sql91 = Sql91 + "FROM QEa_Training_History_ChkRev "
                Sql91 = Sql91 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                Sql91 = Sql91 + "AND Dept ='" & strDeptData & "' "
                Sql91 = Sql91 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                Sql91 = Sql91 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                Sql91 = Sql91 + "ORDER BY DOCNO, REVNO "
                Dim Dt91 As DataTable
                Dt91 = DB_CMD.GetData_Table(Sql91, DB_CMD.ObjConn)
                For Each Dtr91 As DataRow In Dt91.Rows
                    GoTo NEXTSTEPDATA
                Next

                Dim Sql92 As String = "Select  * "
                Sql92 = Sql92 + "FROM QEa_Training_History "
                Sql92 = Sql92 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                Sql92 = Sql92 + "AND Dept ='" & strDeptData & "' "
                Sql92 = Sql92 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                Sql92 = Sql92 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                Sql92 = Sql92 + "ORDER BY DOCNO, REVNO "
                Dim Dt92 As DataTable
                Dt92 = DB_CMD.GetData_Table(Sql92, DB_CMD.ObjConn)
                For Each Dtr92 As DataRow In Dt92.Rows
                    GoTo NEXTSTEPDATA
                Next

                sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq,Section) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq,@Section)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr1.Item("EmployeeNo").ToString
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr1.Item("DOCNO").ToString
                    .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr1.Item("MAXREVNO").ToString
                    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr1.Item("MAXEFFDATE")
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr1.Item("DOCNAME").ToString

                    Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr1.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                    Dim Dt2 As New DataTable
                    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

                    For Each Dtr2 As DataRow In Dt2.Rows
                        .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                    Next

                    ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr1.Item("DOCDEPT").ToString
                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr1.Item("Approve").ToString
                    .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr1.Item("MthdCode").ToString
                    .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                    .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                    .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                    .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                    .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeName").ToString
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0

                    If IsDBNull(Dtr9.Item("Section").ToString) Or Dtr9.Item("Section").ToString = "" Then
                        .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                    Else
                        .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr9.Item("Section").ToString

                    End If


                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With








NEXTSTEPDATA:

                LoadingForm.nextProcess()
                Application.DoEvents()

            Next



        Next



        Call LoadDataRetraingFreq()

        Call LoadDataCheck()

        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Or strApprove = "Supervisor" Then
            pnApprove.Visible = True
        Else
            pnApprove.Visible = False
        End If
        '' Call LoadDataGrid()




    End Sub

    Sub LoadGridDataNEW()  '15-09-2022



        CmdExcute("DELETE FROM QEa_Training_History_ChkRev  WHERE ComName='" & strHostName & "' ", DB_CMD.ObjConn)


        ' dgvDetail.Rows.Clear()
        Dim sqlinsert As String

        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)



        '  dgvDetail.Rows.Clear()

        ' Select Case hISToRy
        'Sql = Sql + "AND (QEa_Training_History.Dept = '" & strDeptData & "') "

        '*****  29-08-2022 
        Dim strCri As String = ""
        If TxtDOCNO.Text = "" Then
            strCri = "WHERE (QEa_Training_History.Result = 0)  AND QEa_Training_History.Dept = '" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "' AND QEa_Training_History.MD = '" & strMD & "' "
        Else
            strCri = "WHERE (QEa_Training_History.Result = 0)  AND QEa_Training_History.Dept = '" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "' AND QEa_Training_History.MD = '" & strMD & "' AND QEa_Training_History.DOCNO = '" & TxtDOCNO.Text & "' "
        End If

        Dim Sql As String = " SELECT QEa_Training_History.EmployeeNo, QEa_Training_History.DOCNO, QEa_Training_History.REVNO, QEa_Training_History.DOCDEPT, QEa_Training_History.MD, "
        Sql = Sql + " QEa_Training_History.EFFDATE, QEa_Training_History.MthdCode, QEa_Training_History.TrnnDate, QEa_Training_History.Result, QEa_Training_History.Approve, QEa_Training_History.Remark, "
        Sql = Sql + " QEa_Training_History.Dept, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_History.RetrainFreq,QEa_Training_Person.Section "
        Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_History ON QEa_Training_Assign.EmployeeNo = QEa_Training_History.EmployeeNo AND QEa_Training_Assign.DOCNO = QEa_Training_History.DOCNO AND "
        Sql = Sql + " QEa_Training_Assign.Dept = dbo.QEa_Training_History.Dept LEFT OUTER JOIN QEa_Training_Person On QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        Sql = Sql + strCri
        Sql = Sql + "ORDER BY QEa_Training_History.DOCNO, QEa_Training_History.REVNO"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr As DataRow In Dt.Rows
            LoadingForm.Show()
            LoadingForm.SetData(Dt.Rows.Count, "Loading...Check Hoistory ")


            If IsDBNull(Dtr.Item("MthdCode").ToString) Or Dtr.Item("MthdCode").ToString = "" Then
                GoTo Next_STEP1
                MsgBox(" พนักงาน : '" & Dtr.Item("EmployeeName").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")

                Exit Sub


            End If


            sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,ComName,EmployeeName,RetrainFreq,Section) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@TrnnDate,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@ComName,@EmployeeName,@RetrainFreq,@Section)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr.Item("EmployeeNo").ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr.Item("REVNO").ToString
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)


                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                Dim Dt21 As New DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                For Each Dtr21 As DataRow In Dt21.Rows

                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
                    GoTo NEXTDATA
                Next
NEXTDATA:
                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                For Each Dtr2 As DataRow In Dt2.Rows
                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                Next

                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr.Item("DOCDEPT").ToString


                If IsDBNull(Dtr.Item("TrnnDate").ToString) Or (Dtr.Item("TrnnDate").ToString) = "" Then
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = DBNull.Value
                Else
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                End If



                ' .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr.Item("Result").ToString = 1
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr.Item("Remark").ToString
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr.Item("MthdCode").ToString
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = Dtr.Item("MD").ToString
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr.Item("Dept").ToString
                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr.Item("EmployeeName").ToString

                If IsDBNull(Dtr.Item("RetrainFreq").ToString) Then
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0
                Else
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = Dtr.Item("RetrainFreq").ToString

                End If
                If IsDBNull(Dtr.Item("Section").ToString) Or Dtr.Item("Section").ToString = "" Then
                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                Else
                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr.Item("Section").ToString

                End If
                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With
Next_STEP1:


            LoadingForm.nextProcess()
            Application.DoEvents()
        Next




        Dim Dt9 As DataTable
        If TxtDOCNO.Text = "" Then
            Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section "
            Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
            Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "' "
            Sql9 = Sql9 + "AND QEa_Training_Assign.Dept ='" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "'  "
            Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section "
            Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "

            ' Dim Dt9 As DataTable
            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        Else
            Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section,QEa_Training_Assign.DOCNO "
            Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
            Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "'  AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            Sql9 = Sql9 + " And QEa_Training_Assign.Dept ='" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "'  "
            Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section,QEa_Training_Assign.DOCNO "
            Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "
            ' Dim Dt9 As DataTable
            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        End If


        For Each Dtr9 As DataRow In Dt9.Rows


            '  Dim strStartDatehk As Date = Dtr9.Item("StartDate").ToString
            TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            '  strStartDatehk = (Dtr9.Item("StartDate").ToString("yyyy-MM-dd"))


            'If (TxtStartDate.InvokeRequired) Then

            '    TxtStartDate.Invoke(Sub() Text = Dtr9.Item("StartDate").ToString)


            '    ' Invoke(New Action(RunButtonClicked));
            '    TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            'Else
            '    TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            'End If

            '    strStartDatehk = strStartDatehk.Date.ToString("yyyy-MM-dd")

            'Dim Sql1 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO As MAXREVNO , QEa_CourseMaster.EFFDATE  As MAXEFFDATE , dbo.QEa_Training_Assign.StartDate "
            'Sql1 = Sql1 + " From QEa_Training_Assign LEFT OUTER Join QEa_CourseMaster On QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO And QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            'Sql1 = Sql1 + " Where CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtEFFDate.Text & "' "
            'Sql1 = Sql1 + " And (QEa_Training_Assign.DEPT = '" & strDeptData & "') "
            'Sql1 = Sql1 + " And (QEa_CourseMaster.STATUS = 'A') "
            'Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
            'Sql1 = Sql1 + " And CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            'Sql1 = Sql1 + " AND QEa_Training_Assign.DOCNO = '" & Dtr9.Item("DOCNO").ToString & "' "
            'Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "
            'Dim Dt1 As DataTable
            'Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)




            Dim Dt1 As DataTable

            'If TxtDOCNO.Text = "" Then
            '    Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            '    Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            '    Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
            '    Sql1 = Sql1 + " UNION "
            '    Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') "
            '    Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


            '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'Else
            '    Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            '    Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            '    Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            '    Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
            '    Sql1 = Sql1 + " UNION "
            '    Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            '    Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


            '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'End If
            If TxtDOCNO.Text = "" Then
                Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
                Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
                Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
                Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
                Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
                Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
                Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
                Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "

                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            Else
                Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
                Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
                Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
                Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
                Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
                Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
                Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
                Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "

                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

            End If

            For Each Dtr1 As DataRow In Dt1.Rows
                LoadingForm.Show()
                LoadingForm.SetData(Dt1.Rows.Count, "Check Effect Date(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr1.Item("DOCNO").ToString & ")")


                If IsDBNull(Dtr1.Item("MthdCode").ToString) Or Dtr1.Item("MthdCode").ToString = "" Then
                    GoTo NEXTSTEPDATA
                    MsgBox(" พนักงาน  '" & Dtr1.Item("EmployeeNo").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                    Exit Sub

                End If

                Dim Sql91 As String = "Select  * "
                Sql91 = Sql91 + "FROM QEa_Training_History_ChkRev "
                Sql91 = Sql91 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                Sql91 = Sql91 + "AND Dept ='" & strDeptData & "' "
                Sql91 = Sql91 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                Sql91 = Sql91 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                Sql91 = Sql91 + "ORDER BY DOCNO, REVNO "
                Dim Dt91 As DataTable
                Dt91 = DB_CMD.GetData_Table(Sql91, DB_CMD.ObjConn)
                For Each Dtr91 As DataRow In Dt91.Rows
                    GoTo NEXTSTEPDATA
                Next

                Dim Sql92 As String = "Select  * "
                Sql92 = Sql92 + "FROM QEa_Training_History "
                Sql92 = Sql92 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                Sql92 = Sql92 + "AND Dept ='" & strDeptData & "' "
                Sql92 = Sql92 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                Sql92 = Sql92 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                Sql92 = Sql92 + "ORDER BY DOCNO, REVNO "
                Dim Dt92 As DataTable
                Dt92 = DB_CMD.GetData_Table(Sql92, DB_CMD.ObjConn)
                For Each Dtr92 As DataRow In Dt92.Rows
                    GoTo NEXTSTEPDATA
                Next

                sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq,Section) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq,@Section)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr1.Item("EmployeeNo").ToString
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr1.Item("DOCNO").ToString
                    .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr1.Item("MAXREVNO").ToString
                    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr1.Item("MAXEFFDATE")
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr1.Item("DOCNAME").ToString

                    Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr1.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                    Dim Dt2 As New DataTable
                    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

                    For Each Dtr2 As DataRow In Dt2.Rows
                        .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                    Next

                    ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr1.Item("DOCDEPT").ToString
                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr1.Item("Approve").ToString
                    .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr1.Item("MthdCode").ToString
                    .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                    .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                    .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                    .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                    .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeName").ToString
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0

                    If IsDBNull(Dtr9.Item("Section").ToString) Or Dtr9.Item("Section").ToString = "" Then
                        .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                    Else
                        .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr9.Item("Section").ToString

                    End If


                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()


                End With


NEXTSTEPDATA:

                LoadingForm.nextProcess()
                Application.DoEvents()

            Next

            Try
                Dim Dt19 As DataTable
                If TxtDOCNO.Text = "" Then
                    Dim Sql19 As String = "SELECT A.DOCNO, B.REVNO "
                    Sql19 = Sql19 + "FROM  QEa_Training_Assign AS A LEFT OUTER JOIN QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                    Sql19 = Sql19 + "WHERE A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
                    Sql19 = Sql19 + " And CONVERT(DATE,B.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
                    Sql19 = Sql19 + "AND (B.STATUS = 'A')"
                    Sql19 = Sql19 + " And CONVERT(DATE,A.StartDate,105) = '" & TxtStartDate.Text & "' "
                    Sql19 = Sql19 + "GROUP BY A.DOCNO, B.REVNO "
                    Sql19 = Sql19 + "EXCEPT (Select Docno,REVNO "
                    Sql19 = Sql19 + "FROM QEa_Training_History "
                    Sql19 = Sql19 + "WHERE EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "')"
                    Sql19 = Sql19 + "ORDER BY DOCNO "
                    Dt19 = DB_CMD.GetData_Table(Sql19, DB_CMD.ObjConn)
                Else
                    Dim Sql19 As String = "SELECT A.DOCNO, B.REVNO "
                    Sql19 = Sql19 + "FROM  QEa_Training_Assign AS A LEFT OUTER JOIN QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                    Sql19 = Sql19 + "WHERE A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
                    Sql19 = Sql19 + " And CONVERT(DATE,B.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
                    Sql19 = Sql19 + "AND (B.STATUS = 'A')"
                    Sql19 = Sql19 + "AND CONVERT(DATE,A.StartDate,105) = '" & TxtStartDate.Text & "' "
                    Sql19 = Sql19 + "AND A.DOCNO = '" & TxtDOCNO.Text & "' "
                    Sql19 = Sql19 + "GROUP BY A.DOCNO, B.REVNO "
                    Sql19 = Sql19 + "EXCEPT (Select Docno,REVNO "
                    Sql19 = Sql19 + "FROM QEa_Training_History "
                    Sql19 = Sql19 + "WHERE EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
                    Sql19 = Sql19 + "AND DOCNO = '" & TxtDOCNO.Text & "')"
                    Sql19 = Sql19 + "ORDER BY DOCNO "
                    Dt19 = DB_CMD.GetData_Table(Sql19, DB_CMD.ObjConn)
                End If




                For Each Dtr19 As DataRow In Dt19.Rows
                    ' GoTo NEXTSTEPDATA

                    LoadingForm.Show()
                    LoadingForm.SetData(Dt19.Rows.Count, "Check วันบังคับใช้ >= วันเข้างาน(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr19.Item("DOCNO").ToString & ")")

                    Dim Sql20 As String = "SELECT  A.EmployeeNo, A.DOCNO, B.DOCNAME, A.DOCDEPT, A.MthdCode, A.Approve, B.STATUS, B.REVNO, B.EFFDATE, A.StartDate "
                    Sql20 = Sql20 + "From QEa_Training_Assign AS A LEFT OUTER Join QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                    Sql20 = Sql20 + "Where(A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "') "
                    Sql20 = Sql20 + "And (B.STATUS = 'A') "
                    Sql20 = Sql20 + "And (A.DOCNO = '" & Dtr19.Item("DOCNO").ToString & "')"
                    Sql20 = Sql20 + "And (B.REVNO = " & Dtr19.Item("REVNO").ToString & ")"
                    Sql20 = Sql20 + "ORDER BY A.DOCNO, B.REVNO"
                    Dim Dt20 As DataTable
                    Dt20 = DB_CMD.GetData_Table(Sql20, DB_CMD.ObjConn)
                    For Each Dtr20 As DataRow In Dt20.Rows

                        sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq,Section) " &
                               "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq,@Section)"

                        With comSave
                            .Parameters.Clear()
                            .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeNo").ToString
                            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr19.Item("DOCNO").ToString
                            .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr19.Item("REVNO").ToString
                            .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr20.Item("EFFDATE")
                            .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr20.Item("DOCNAME").ToString

                            Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr20.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                            Dim Dt2 As New DataTable
                            Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

                            For Each Dtr2 As DataRow In Dt2.Rows
                                .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                            Next

                            ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                            .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr20.Item("DOCDEPT").ToString
                            .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr20.Item("Approve").ToString
                            .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr20.Item("MthdCode").ToString
                            .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                            .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                            .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                            .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                            .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeName").ToString
                            .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0

                            If IsDBNull(Dtr9.Item("Section").ToString) Or Dtr9.Item("Section").ToString = "" Then
                                .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                            Else
                                .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr9.Item("Section").ToString

                            End If

                            .CommandText = sqlinsert
                            .Connection = DB_CMD.ObjConn
                            .ExecuteNonQuery()


                        End With

                        LoadingForm.nextProcess()
                        Application.DoEvents()

                    Next



                Next

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือน")
                Exit Sub
            End Try









        Next



        Call LoadDataRetraingFreq()

        Call LoadDataCheck()

        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Or strApprove = "Supervisor" Then
            pnApprove.Visible = True
        Else
            pnApprove.Visible = False
        End If
        '' Call LoadDataGrid()




    End Sub

    Sub LoadGridDataNEW150922()  '15-09-2022

        CmdExcute("DELETE FROM QEa_Training_History_ChkRev  WHERE ComName='" & strHostName & "' ", DB_CMD.ObjConn)

        ' dgvDetail.Rows.Clear()
        Dim sqlinsert As String

        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)



        '  dgvDetail.Rows.Clear()

        ' Select Case hISToRy
        'Sql = Sql + "AND (QEa_Training_History.Dept = '" & strDeptData & "') "

        '*****  29-08-2022 
        Dim strCri As String = ""
        If TxtDOCNO.Text = "" Then
            strCri = "WHERE (QEa_Training_History.Result = 0)  AND QEa_Training_History.Dept = '" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "' AND QEa_Training_History.MD = '" & strMD & "' "
        Else
            strCri = "WHERE (QEa_Training_History.Result = 0)  AND QEa_Training_History.Dept = '" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "' AND QEa_Training_History.MD = '" & strMD & "' AND QEa_Training_History.DOCNO = '" & TxtDOCNO.Text & "' "
        End If

        Dim Sql As String = " SELECT QEa_Training_History.EmployeeNo, QEa_Training_History.DOCNO, QEa_Training_History.REVNO, QEa_Training_History.DOCDEPT, QEa_Training_History.MD, "
        Sql = Sql + " QEa_Training_History.EFFDATE, QEa_Training_History.MthdCode, QEa_Training_History.TrnnDate, QEa_Training_History.Result, QEa_Training_History.Approve, QEa_Training_History.Remark, "
        Sql = Sql + " QEa_Training_History.Dept, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_History.RetrainFreq,QEa_Training_Person.Section "
        Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_History ON QEa_Training_Assign.EmployeeNo = QEa_Training_History.EmployeeNo AND QEa_Training_Assign.DOCNO = QEa_Training_History.DOCNO AND "
        Sql = Sql + " QEa_Training_Assign.Dept = dbo.QEa_Training_History.Dept LEFT OUTER JOIN QEa_Training_Person On QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
        Sql = Sql + strCri
        Sql = Sql + "ORDER BY QEa_Training_History.DOCNO, QEa_Training_History.REVNO"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr As DataRow In Dt.Rows
            'LoadingForm.Show()
            'LoadingForm.SetData(Dt.Rows.Count, "Loading...Check Hoistory ")
            TextBox1.Visible = True
            Call SetData(Dt.Rows.Count, "Loading...Check Hoistory :")

            If IsDBNull(Dtr.Item("MthdCode").ToString) Or Dtr.Item("MthdCode").ToString = "" Then
                GoTo Next_STEP1
                MsgBox(" พนักงาน : '" & Dtr.Item("EmployeeName").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")

                TextBox1.Visible = False
                percentOfProcess = 0
                count = 0


                Exit Sub


            End If


            sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,ComName,EmployeeName,RetrainFreq,Section) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@TrnnDate,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@ComName,@EmployeeName,@RetrainFreq,@Section)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr.Item("EmployeeNo").ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr.Item("REVNO").ToString
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)


                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                Dim Dt21 As New DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                For Each Dtr21 As DataRow In Dt21.Rows

                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
                    GoTo NEXTDATA
                Next
NEXTDATA:
                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                For Each Dtr2 As DataRow In Dt2.Rows
                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                Next

                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr.Item("DOCDEPT").ToString


                If IsDBNull(Dtr.Item("TrnnDate").ToString) Or (Dtr.Item("TrnnDate").ToString) = "" Then
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = DBNull.Value
                Else
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                End If



                ' .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr.Item("TrnnDate").ToString, 1, 10)
                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr.Item("Result").ToString = 1
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr.Item("Remark").ToString
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr.Item("MthdCode").ToString
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = Dtr.Item("MD").ToString
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr.Item("Dept").ToString
                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr.Item("EmployeeName").ToString

                If IsDBNull(Dtr.Item("RetrainFreq").ToString) Then
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0
                Else
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = Dtr.Item("RetrainFreq").ToString

                End If
                If IsDBNull(Dtr.Item("Section").ToString) Or Dtr.Item("Section").ToString = "" Then
                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                Else
                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr.Item("Section").ToString

                End If
                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With
Next_STEP1:


            'LoadingForm.nextProcess()
            'Application.DoEvents()


            Call nextProcess()
            Application.DoEvents()
        Next
        TextBox1.Visible = False

        Dim Dt9 As DataTable
        If TxtDOCNO.Text = "" Then
            Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section "
            Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
            Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "' "
            Sql9 = Sql9 + "AND QEa_Training_Assign.Dept ='" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "'  "
            Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section "
            Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "

            ' Dim Dt9 As DataTable
            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        Else
            Dim Sql9 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section,QEa_Training_Assign.DOCNO "
            Sql9 = Sql9 + "FROM QEa_Training_Assign LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo "
            Sql9 = Sql9 + "WHERE QEa_Training_Assign.MD ='" & strMD & "'  AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            Sql9 = Sql9 + " And QEa_Training_Assign.Dept ='" & strDeptData & "' AND QEa_Training_Person.Section = '" & StrSectionChk & "'  "
            Sql9 = Sql9 + "GROUP BY QEa_Training_Assign.StartDate, QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_Person.Section,QEa_Training_Assign.DOCNO "
            Sql9 = Sql9 + "ORDER BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.StartDate "
            ' Dim Dt9 As DataTable
            Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        End If


        For Each Dtr9 As DataRow In Dt9.Rows


            '  Dim strStartDatehk As Date = Dtr9.Item("StartDate").ToString
            TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            '  strStartDatehk = (Dtr9.Item("StartDate").ToString("yyyy-MM-dd"))


            'If (TxtStartDate.InvokeRequired) Then

            '    TxtStartDate.Invoke(Sub() Text = Dtr9.Item("StartDate").ToString)


            '    ' Invoke(New Action(RunButtonClicked));
            '    TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            'Else
            '    TxtStartDate.Text = Dtr9.Item("StartDate").ToString
            'End If

            '    strStartDatehk = strStartDatehk.Date.ToString("yyyy-MM-dd")

            'Dim Sql1 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO As MAXREVNO , QEa_CourseMaster.EFFDATE  As MAXEFFDATE , dbo.QEa_Training_Assign.StartDate "
            'Sql1 = Sql1 + " From QEa_Training_Assign LEFT OUTER Join QEa_CourseMaster On QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO And QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            'Sql1 = Sql1 + " Where CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtEFFDate.Text & "' "
            'Sql1 = Sql1 + " And (QEa_Training_Assign.DEPT = '" & strDeptData & "') "
            'Sql1 = Sql1 + " And (QEa_CourseMaster.STATUS = 'A') "
            'Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
            'Sql1 = Sql1 + " And CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            'Sql1 = Sql1 + " AND QEa_Training_Assign.DOCNO = '" & Dtr9.Item("DOCNO").ToString & "' "
            'Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "
            'Dim Dt1 As DataTable
            'Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)




            Dim Dt1 As DataTable

            'If TxtDOCNO.Text = "" Then
            '    Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            '    Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            '    Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
            '    Sql1 = Sql1 + " UNION "
            '    Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') "
            '    Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


            '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'Else
            '    Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            '    Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            '    Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            '    Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "
            '    Sql1 = Sql1 + " UNION "
            '    Sql1 = Sql1 + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            '    Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


            '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'End If
            ' If TxtDOCNO.Text = "" Then
            '    Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            '    Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            '    Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
            '    Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "





            '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'Else
            '    Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            '    Sql1 = Sql1 + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            '    Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            '    Sql1 = Sql1 + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            '    Sql1 = Sql1 + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            '    Sql1 = Sql1 + " HAVING EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' AND QEa_Training_Assign.DOCNO = '" & TxtDOCNO.Text & "' "
            '    Sql1 = Sql1 + " AND QEa_CourseMaster.STATUS ='A' "

            '    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

            'End If


            If TxtDOCNO.Text = "" Then

                Dim Sql1 As String = "SELECT A.DOCNO, MAX(B.REVNO) AS MAXREVNO "
                Sql1 = Sql1 + "FROM  QEa_Training_Assign AS A LEFT OUTER JOIN QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                Sql1 = Sql1 + "WHERE A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
                Sql1 = Sql1 + " And CONVERT(DATE,B.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
                Sql1 = Sql1 + "AND (B.STATUS = 'A')"
                Sql1 = Sql1 + " And CONVERT(DATE,A.StartDate,105) = '" & TxtStartDate.Text & "' "
                Sql1 = Sql1 + "GROUP BY A.DOCNO "
                Sql1 = Sql1 + "EXCEPT (Select Docno,REVNO "
                Sql1 = Sql1 + "FROM QEa_Training_History "
                Sql1 = Sql1 + "WHERE EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "')"
                Sql1 = Sql1 + "ORDER BY DOCNO "
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

            Else
                Dim Sql1 As String = "SELECT A.DOCNO, MAX(B.REVNO) AS MAXREVNO "
                Sql1 = Sql1 + "FROM  QEa_Training_Assign AS A LEFT OUTER JOIN QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                Sql1 = Sql1 + "WHERE A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
                Sql1 = Sql1 + " And CONVERT(DATE,B.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
                Sql1 = Sql1 + "AND (B.STATUS = 'A')"
                Sql1 = Sql1 + "AND CONVERT(DATE,A.StartDate,105) = '" & TxtStartDate.Text & "' "
                Sql1 = Sql1 + "AND A.DOCNO = '" & TxtDOCNO.Text & "' "
                Sql1 = Sql1 + "GROUP BY A.DOCNO "
                Sql1 = Sql1 + "EXCEPT (Select Docno,REVNO "
                Sql1 = Sql1 + "FROM QEa_Training_History "
                Sql1 = Sql1 + "WHERE EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
                Sql1 = Sql1 + "AND DOCNO = '" & TxtDOCNO.Text & "')"
                Sql1 = Sql1 + "ORDER BY DOCNO "
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

            End If

            For Each Dtr1 As DataRow In Dt1.Rows
                'LoadingForm.Show()
                'LoadingForm.SetData(Dt1.Rows.Count, "Check Effect Date(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr1.Item("DOCNO").ToString & ")")
                TextBox1.Visible = True
                Call SetData(Dt1.Rows.Count, "Check Effect Date(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr1.Item("DOCNO").ToString & ")")

                'Dim Sql91 As String = "Select  * "
                'Sql91 = Sql91 + "FROM QEa_Training_History_ChkRev "
                'Sql91 = Sql91 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                'Sql91 = Sql91 + "AND Dept ='" & strDeptData & "' "
                'Sql91 = Sql91 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                'Sql91 = Sql91 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                'Sql91 = Sql91 + "ORDER BY DOCNO, REVNO "
                'Dim Dt91 As DataTable
                'Dt91 = DB_CMD.GetData_Table(Sql91, DB_CMD.ObjConn)
                'For Each Dtr91 As DataRow In Dt91.Rows
                '    GoTo NEXTSTEPDATA
                'Next

                'Dim Sql92 As String = "Select  * "
                'Sql92 = Sql92 + "FROM QEa_Training_History "
                'Sql92 = Sql92 + "WHERE EmployeeNo ='" & Dtr1.Item("EmployeeNo").ToString & "' "
                'Sql92 = Sql92 + "AND Dept ='" & strDeptData & "' "
                'Sql92 = Sql92 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                'Sql92 = Sql92 + "AND REVNO ='" & Dtr1.Item("MAXREVNO").ToString & "' "
                'Sql92 = Sql92 + "ORDER BY DOCNO, REVNO "
                'Dim Dt92 As DataTable
                'Dt92 = DB_CMD.GetData_Table(Sql92, DB_CMD.ObjConn)
                'For Each Dtr92 As DataRow In Dt92.Rows
                '    GoTo NEXTSTEPDATA
                'Next

                Dim Sql21 As String = "SELECT  A.EmployeeNo, A.DOCNO, B.DOCNAME, A.DOCDEPT, A.MthdCode, A.Approve, B.STATUS, B.REVNO, B.EFFDATE, A.StartDate "
                    Sql21 = Sql21 + "From QEa_Training_Assign AS A LEFT OUTER Join QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                    Sql21 = Sql21 + "Where(A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "') "
                    Sql21 = Sql21 + "And (B.STATUS = 'A') "
                    Sql21 = Sql21 + "And (A.DOCNO = '" & Dtr1.Item("DOCNO").ToString & "')"
                Sql21 = Sql21 + "And (B.REVNO = " & Dtr1.Item("MAXREVNO").ToString & ")"
                Sql21 = Sql21 + "ORDER BY A.DOCNO, B.REVNO"
                    Dim Dt21 As DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                For Each Dtr21 As DataRow In Dt21.Rows

                    If IsDBNull(Dtr21.Item("MthdCode").ToString) Or Dtr21.Item("MthdCode").ToString = "" Then
                        'GoTo NEXTSTEPDATA
                        TextBox1.Visible = False
                        percentOfProcess = 0
                        count = 0
                        MsgBox(" พนักงาน  '" & Dtr21.Item("EmployeeNo").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")


                        Exit Sub
                    End If

                    sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq,Section) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq,@Section)"

                    With comSave
                        .Parameters.Clear()
                        .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr21.Item("EmployeeNo").ToString
                        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr1.Item("DOCNO").ToString
                        .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr1.Item("MAXREVNO").ToString
                        .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr21.Item("EFFDATE")
                        .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString

                        Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr21.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                        Dim Dt2 As New DataTable
                        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

                        For Each Dtr2 As DataRow In Dt2.Rows
                            .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                        Next

                        ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                        .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr21.Item("DOCDEPT").ToString
                        .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr21.Item("Approve").ToString
                        .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr21.Item("MthdCode").ToString
                        .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                        .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                        .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                        .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                        .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeName").ToString
                        .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0

                        If IsDBNull(Dtr9.Item("Section").ToString) Or Dtr9.Item("Section").ToString = "" Then
                            .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                        Else
                            .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr9.Item("Section").ToString

                        End If


                        .CommandText = sqlinsert
                        .Connection = DB_CMD.ObjConn
                        .ExecuteNonQuery()


                    End With




                    'LoadingForm.nextProcess()
                    'Application.DoEvents()
                    Call nextProcess()
                    Application.DoEvents()
                Next
NEXTSTEPDATA:

                Next

            TextBox1.Visible = False

            Try
                Dim Dt19 As DataTable
                If TxtDOCNO.Text = "" Then
                    Dim Sql19 As String = "SELECT A.DOCNO, B.REVNO "
                    Sql19 = Sql19 + "FROM  QEa_Training_Assign AS A LEFT OUTER JOIN QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                    Sql19 = Sql19 + "WHERE A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
                    Sql19 = Sql19 + " And CONVERT(DATE,B.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
                    Sql19 = Sql19 + "AND (B.STATUS = 'A')"
                    Sql19 = Sql19 + " And CONVERT(DATE,A.StartDate,105) = '" & TxtStartDate.Text & "' "
                    Sql19 = Sql19 + "GROUP BY A.DOCNO, B.REVNO "
                    Sql19 = Sql19 + "EXCEPT (Select Docno,REVNO "
                    Sql19 = Sql19 + "FROM QEa_Training_History "
                    Sql19 = Sql19 + "WHERE EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "')"
                    Sql19 = Sql19 + "ORDER BY DOCNO "
                    Dt19 = DB_CMD.GetData_Table(Sql19, DB_CMD.ObjConn)
                Else
                    Dim Sql19 As String = "SELECT A.DOCNO, B.REVNO "
                    Sql19 = Sql19 + "FROM  QEa_Training_Assign AS A LEFT OUTER JOIN QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                    Sql19 = Sql19 + "WHERE A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "' "
                    Sql19 = Sql19 + " And CONVERT(DATE,B.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
                    Sql19 = Sql19 + "AND (B.STATUS = 'A')"
                    Sql19 = Sql19 + "AND CONVERT(DATE,A.StartDate,105) = '" & TxtStartDate.Text & "' "
                    Sql19 = Sql19 + "AND A.DOCNO = '" & TxtDOCNO.Text & "' "
                    Sql19 = Sql19 + "GROUP BY A.DOCNO, B.REVNO "
                    Sql19 = Sql19 + "EXCEPT (Select Docno,REVNO "
                    Sql19 = Sql19 + "FROM QEa_Training_History "
                    Sql19 = Sql19 + "WHERE EmployeeNo ='" & Dtr9.Item("EmployeeNo").ToString & "' "
                    Sql19 = Sql19 + "AND DOCNO = '" & TxtDOCNO.Text & "')"
                    Sql19 = Sql19 + "ORDER BY DOCNO "
                    Dt19 = DB_CMD.GetData_Table(Sql19, DB_CMD.ObjConn)
                End If




                For Each Dtr19 As DataRow In Dt19.Rows
                    ' GoTo NEXTSTEPDATA

                    ' LoadingForm.Show()
                    'LoadingForm.SetData(Dt19.Rows.Count, "Check วันบังคับใช้ >= วันเข้างาน(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr19.Item("DOCNO").ToString & ")")
                    TextBox1.Visible = True
                    Call SetData(Dt19.Rows.Count, "Check วันบังคับใช้ >= วันเข้างาน(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr19.Item("DOCNO").ToString & ")")


                    Dim Sql20 As String = "SELECT  A.EmployeeNo, A.DOCNO, B.DOCNAME, A.DOCDEPT, A.MthdCode, A.Approve, B.STATUS, B.REVNO, B.EFFDATE, A.StartDate "
                    Sql20 = Sql20 + "From QEa_Training_Assign AS A LEFT OUTER Join QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                    Sql20 = Sql20 + "Where(A.EmployeeNo = '" & Dtr9.Item("EmployeeNo").ToString & "') "
                    Sql20 = Sql20 + "And (B.STATUS = 'A') "
                    Sql20 = Sql20 + "And (A.DOCNO = '" & Dtr19.Item("DOCNO").ToString & "')"
                    Sql20 = Sql20 + "And (B.REVNO = " & Dtr19.Item("REVNO").ToString & ")"
                    Sql20 = Sql20 + "ORDER BY A.DOCNO, B.REVNO"
                    Dim Dt20 As DataTable
                    Dt20 = DB_CMD.GetData_Table(Sql20, DB_CMD.ObjConn)
                    For Each Dtr20 As DataRow In Dt20.Rows


                        If IsDBNull(Dtr20.Item("MthdCode").ToString) Or Dtr20.Item("MthdCode").ToString = "" Then
                            'GoTo NEXTSTEPDATA
                            TextBox1.Visible = False
                            percentOfProcess = 0
                            count = 0
                            MsgBox(" พนักงาน  '" & Dtr20.Item("EmployeeNo").ToString & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                            Exit Sub
                        End If


                        sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq,Section) " &
                               "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq,@Section)"

                        With comSave
                            .Parameters.Clear()
                            .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeNo").ToString
                            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr19.Item("DOCNO").ToString
                            .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr19.Item("REVNO").ToString
                            .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr20.Item("EFFDATE")
                            .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr20.Item("DOCNAME").ToString

                            Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr20.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                            Dim Dt2 As New DataTable
                            Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

                            For Each Dtr2 As DataRow In Dt2.Rows
                                .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                            Next

                            ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                            .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr20.Item("DOCDEPT").ToString
                            .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr20.Item("Approve").ToString
                            .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr20.Item("MthdCode").ToString
                            .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                            .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                            .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                            .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                            .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr9.Item("EmployeeName").ToString
                            .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0

                            If IsDBNull(Dtr9.Item("Section").ToString) Or Dtr9.Item("Section").ToString = "" Then
                                .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                            Else
                                .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr9.Item("Section").ToString

                            End If

                            .CommandText = sqlinsert
                            .Connection = DB_CMD.ObjConn
                            .ExecuteNonQuery()


                        End With

                        'LoadingForm.nextProcess()
                        'Application.DoEvents()

                        Call nextProcess()
                        Application.DoEvents()
                    Next



                Next
                TextBox1.Visible = False

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Dtr9.Item("EmployeeNo").ToString)
                LoadingForm.Close()
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try




        Next



        Call LoadDataRetraingFreq()

        Call LoadDataCheck()

        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Or strApprove = "Supervisor" Then
            pnApprove.Visible = True
        Else
            pnApprove.Visible = False
        End If
        '' Call LoadDataGrid()




    End Sub

    Sub LoadDataRetraingFreq()

        'Dim command As New SqlCommand("Select  EmployeeNo FROM  QEa_Training_Person WHERE Dept = '" & strDeptData & "' AND MD = '" & strMD & "' and NOT (EmployeeNo IS NULL) ORDER BY EmployeeNo  ", DB_CMD.ObjConn)
        'Dim table As New DataTable
        'Dim adapter As New SqlDataAdapter(command)
        'Dim ds As New DataSet
        'adapter.Fill(table)
        'If table.Rows.Count > 0 Then


        'End If
        Dim cri As String = ""
        ' If strDeptData = "SD" Then
        cri = "AND MD = '" & strMD & "'AND Section = '" & StrSectionChk & "' "
        ' Else
        ' cri = "AND MD = '" & strMD & "' "
        '  End If

        Dim Sql11 As String = "SELECT  * "
        Sql11 = Sql11 + "From QEa_Training_Person  "
        Sql11 = Sql11 + "WHERE Dept = '" & strDeptData & "'"
        Sql11 = Sql11 + cri
        Sql11 = Sql11 + "AND Not (EmployeeNo Is NULL) "
        Dim Dt11 As New DataTable
        Dt11 = DB_CMD.GetData_Table(Sql11, DB_CMD.ObjConn)
        For Each Dtr11 As DataRow In Dt11.Rows

            '  LoadingForm.Show()
            '  LoadingForm.SetData(Dt11.Rows.Count, "ขั้นตอนสุดท้าย...(ตรวจสอบ Retaining Frequency)")
            TextBox1.Visible = True
            Call SetData(Dt11.Rows.Count, "ขั้นตอนสุดท้าย...(ตรวจสอบ Retaining Frequency)")


            Dim Dt As New DataTable

            If TxtDOCNO.Text = "" Then
                Dim Sql As String = "SELECT  DOCNO, RetrainFreq, EmployeeNo, Dept, MD,Approve "
                Sql = Sql + "From QEa_Training_Assign  "
                Sql = Sql + "WHERE EmployeeNo = '" & Dtr11.Item("EmployeeNo").ToString & "' "
                Sql = Sql + "AND Dept = '" & strDeptData & "'"
                Sql = Sql + "AND MD = '" & strMD & "' "
                Sql = Sql + "AND RetrainFreq <> ''"
                Sql = Sql + "ORDER BY DOCNO"
                Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            Else
                Dim Sql As String = "SELECT  DOCNO, RetrainFreq, EmployeeNo, Dept, MD,Approve "
                Sql = Sql + "From QEa_Training_Assign  "
                Sql = Sql + "WHERE EmployeeNo = '" & Dtr11.Item("EmployeeNo").ToString & "' "
                Sql = Sql + "AND Dept = '" & strDeptData & "'"
                Sql = Sql + "AND MD = '" & strMD & "' "
                Sql = Sql + "AND DOCNO = '" & TxtDOCNO.Text & "' "
                Sql = Sql + "AND RetrainFreq <> ''"
                Sql = Sql + "ORDER BY DOCNO"
                Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            End If



            Dim intNo As Integer = 1
            Dim strstatus As String = ""
            For Each Dtr As DataRow In Dt.Rows

                Dim intFreqNo As Integer = 0

                Select Case Dtr.Item("RetrainFreq").ToString
                    Case "6 เดือน"
                        intFreqNo = 6
                    Case "1 ปี"
                        intFreqNo = 1
                    Case "2 ปี"
                        intFreqNo = 2
                    Case "3 ปี"
                        intFreqNo = 3
                    Case "ทันที"
                        intFreqNo = 1

                End Select


                Dim Sql1 As String = "SELECT  MAX(REVNO) As MaxREVNO, MAX(TrnnDate) As MaxTrnnDate, MAX(RetrainFreq) As MaxRetrainFreq "
                Sql1 = Sql1 + "From QEa_Training_History  "
                Sql1 = Sql1 + "WHERE EmployeeNo = '" & Dtr11.Item("EmployeeNo").ToString & "' "
                Sql1 = Sql1 + "AND Dept = '" & strDeptData & "'"
                Sql1 = Sql1 + "AND MD = '" & strMD & "' "
                Sql1 = Sql1 + "AND DOCNO = '" & Dtr.Item("DOCNO").ToString & "' "
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                Dim intFreq As Integer = 0
                For Each Dtr1 As DataRow In Dt1.Rows



                    If IsDBNull(Dtr1.Item("MaxTrnnDate").ToString) Or Dtr1.Item("MaxTrnnDate").ToString = "" Then
                        GoTo NEXT_STEP1
                    End If

                    dtpCheck.Value = Dtr1.Item("MaxTrnnDate").ToString


                    Select Case Dtr.Item("RetrainFreq").ToString
                        Case "6 เดือน"
                            dtpCheck.Value = dtpCheck.Value.AddMonths(+(CInt(intFreqNo)))
                        Case "1 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))
                        Case "2 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))
                        Case "3 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))

                        Case "ทันที"
                            dtpCheck.Value = dtpCheck.Value.AddDays(+(CInt(intFreqNo)))
                    End Select

                    If dtpCheck.Value < dtpToday.Value Then


                        If IsDBNull(Dtr1.Item("MaxRetrainFreq").ToString) Or Dtr1.Item("MaxRetrainFreq").ToString = "" Then
                            intFreq = 1
                        Else
                            intFreq = Dtr1.Item("MaxRetrainFreq").ToString + 1

                        End If



                        Dim Sql99 As String = "SELECT  * "
                        Sql99 = Sql99 + "From QEa_Training_History  "
                        Sql99 = Sql99 + "WHERE EmployeeNo = '" & Dtr11.Item("EmployeeNo").ToString & "' "
                        Sql99 = Sql99 + "AND Dept = '" & strDeptData & "'"
                        Sql99 = Sql99 + "AND DOCNO = '" & Dtr.Item("DOCNO").ToString & "' "
                        Sql99 = Sql99 + "AND REVNO = " & Dtr1.Item("MaxREVNO").ToString & " "
                        Sql99 = Sql99 + "AND RetrainFreq = " & Dtr1.Item("MaxRetrainFreq").ToString & " "
                        Sql99 = Sql99 + "ORDER BY DOCNO,REVNO"
                        Dim Dt99 As New DataTable
                        Dt99 = DB_CMD.GetData_Table(Sql99, DB_CMD.ObjConn)



                        Dim sqlinsert As String = ""
                        For Each Dtr99 As DataRow In Dt99.Rows

                            If IsDBNull(Dtr99.Item("MthdCode").ToString) Or Dtr99.Item("MthdCode").ToString = "" Then
                                MsgBox(" พนักงาน : '" & Dtr11.Item("EmployeeNo").ToString & "' ยังไม่ได้ระบุ (Method Training ) ที่เมนู Training Assign  ", MsgBoxStyle.Information, "เเจ้งเดือนให้ทราบ")
                                Exit Sub
                            End If


                            sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Result,Approve,Remark,MthdCode,MD,Dept,RetrainFreq,ComName,EmployeeName,Section) " &
                                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@RetrainFreq,@ComName,@EmployeeName,@Section)"

                            '       sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq) " &
                            '    "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq)"

                            With comSave
                                .Parameters.Clear()
                                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr11.Item("EmployeeNo").ToString
                                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr99.Item("DOCNO").ToString
                                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr99.Item("REVNO").ToString
                                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)



                                Dim strCheckDocName As String = ""

                                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr99.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                                Dim Dt21 As New DataTable
                                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                                For Each Dtr21 As DataRow In Dt21.Rows
                                    strCheckDocName = Dtr21.Item("DOCNAME").ToString
                                    GoTo NEXT_STEP_DOCNAME

                                Next


NEXT_STEP_DOCNAME:

                                If strCheckDocName <> "" Then
                                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = strCheckDocName
                                Else
                                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = ""
                                End If

                                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr99.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                                Dim Dt2 As New DataTable
                                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                                For Each Dtr2 As DataRow In Dt2.Rows


                                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString


                                Next

                                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr99.Item("DOCDEPT").ToString
                                '.Parameters.Add("@TrnnDate", SqlDbType.Date).Value = ""
                                .Parameters.Add("@Result", SqlDbType.Int).Value = 0

                                If IsDBNull(Dtr.Item("Approve").ToString) Or Dtr.Item("Approve").ToString = "" Then
                                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr99.Item("Approve").ToString
                                Else
                                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                                End If



                                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = ""
                                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr99.Item("MthdCode").ToString
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr99.Item("Dept").ToString


                                .Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = intFreq
                                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr11.Item("EmployeeName").ToString

                                If IsDBNull(Dtr11.Item("Section").ToString) Or Dtr11.Item("Section").ToString = "" Then
                                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                                Else
                                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr11.Item("Section").ToString

                                End If
                                .CommandText = sqlinsert
                                .Connection = DB_CMD.ObjConn
                                .ExecuteNonQuery()



                            End With


                        Next

                    End If

                Next
NEXT_STEP1:

            Next
            Call nextProcess()
            Application.DoEvents()
            'LoadingForm.nextProcess()
            ' Application.DoEvents()
        Next
        TextBox1.Visible = False

    End Sub
    Sub LoadDataRetraingFreq150922() '150922

        'Dim command As New SqlCommand("Select  EmployeeNo FROM  QEa_Training_Person WHERE Dept = '" & strDeptData & "' AND MD = '" & strMD & "' and NOT (EmployeeNo IS NULL) ORDER BY EmployeeNo  ", DB_CMD.ObjConn)
        'Dim table As New DataTable
        'Dim adapter As New SqlDataAdapter(command)
        'Dim ds As New DataSet
        'adapter.Fill(table)
        'If table.Rows.Count > 0 Then


        'End If
        Dim cri As String = ""
        ' If strDeptData = "SD" Then
        cri = "AND MD = '" & strMD & "'AND Section = '" & StrSectionChk & "' "
        ' Else
        ' cri = "AND MD = '" & strMD & "' "
        '  End If

        Dim Sql11 As String = "SELECT  * "
        Sql11 = Sql11 + "From QEa_Training_Person  "
        Sql11 = Sql11 + "WHERE Dept = '" & strDeptData & "'"
        Sql11 = Sql11 + cri
        Sql11 = Sql11 + "AND Not (EmployeeNo Is NULL) "
        Dim Dt11 As New DataTable
        Dt11 = DB_CMD.GetData_Table(Sql11, DB_CMD.ObjConn)
        For Each Dtr11 As DataRow In Dt11.Rows

            LoadingForm.Show()
            LoadingForm.SetData(Dt11.Rows.Count, "ขั้นตอนสุดท้าย...(ตรวจสอบ Retaining Frequency)")

            Dim Dt As New DataTable

            If TxtDOCNO.Text = "" Then
                Dim Sql As String = "SELECT  DOCNO, RetrainFreq, EmployeeNo, Dept, MD,Approve "
                Sql = Sql + "From QEa_Training_Assign  "
                Sql = Sql + "WHERE EmployeeNo = '" & Dtr11.Item("EmployeeNo").ToString & "' "
                Sql = Sql + "AND Dept = '" & strDeptData & "'"
                Sql = Sql + "AND MD = '" & strMD & "' "
                Sql = Sql + "AND RetrainFreq <> ''"
                Sql = Sql + "ORDER BY DOCNO"
                Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            Else
                Dim Sql As String = "SELECT  DOCNO, RetrainFreq, EmployeeNo, Dept, MD,Approve "
                Sql = Sql + "From QEa_Training_Assign  "
                Sql = Sql + "WHERE EmployeeNo = '" & Dtr11.Item("EmployeeNo").ToString & "' "
                Sql = Sql + "AND Dept = '" & strDeptData & "'"
                Sql = Sql + "AND MD = '" & strMD & "' "
                Sql = Sql + "AND DOCNO = '" & TxtDOCNO.Text & "' "
                Sql = Sql + "AND RetrainFreq <> ''"
                Sql = Sql + "ORDER BY DOCNO"
                Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            End If




            Dim intNo As Integer = 1
            Dim strstatus As String = ""
            For Each Dtr As DataRow In Dt.Rows

                Dim intFreqNo As Integer = 0

                Select Case Dtr.Item("RetrainFreq").ToString
                    Case "6 เดือน"
                        intFreqNo = 6
                    Case "1 ปี"
                        intFreqNo = 1
                    Case "2 ปี"
                        intFreqNo = 2
                    Case "3 ปี"
                        intFreqNo = 3
                    Case "ทันที"
                        intFreqNo = 1

                End Select


                Dim Sql1 As String = "SELECT  MAX(REVNO) As MaxREVNO, MAX(TrnnDate) As MaxTrnnDate, MAX(RetrainFreq) As MaxRetrainFreq "
                Sql1 = Sql1 + "From QEa_Training_History  "
                Sql1 = Sql1 + "WHERE EmployeeNo = '" & Dtr11.Item("EmployeeNo").ToString & "' "
                Sql1 = Sql1 + "AND Dept = '" & strDeptData & "'"
                Sql1 = Sql1 + "AND MD = '" & strMD & "' "
                Sql1 = Sql1 + "AND DOCNO = '" & Dtr.Item("DOCNO").ToString & "' "
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                Dim intFreq As Integer = 0
                For Each Dtr1 As DataRow In Dt1.Rows



                    If IsDBNull(Dtr1.Item("MaxTrnnDate").ToString) Or Dtr1.Item("MaxTrnnDate").ToString = "" Then
                        GoTo NEXT_STEP1
                    End If

                    dtpCheck.Value = Dtr1.Item("MaxTrnnDate").ToString


                    Select Case Dtr.Item("RetrainFreq").ToString
                        Case "6 เดือน"
                            dtpCheck.Value = dtpCheck.Value.AddMonths(+(CInt(intFreqNo)))
                        Case "1 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))
                        Case "2 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))
                        Case "3 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))

                        Case "ทันที"
                            dtpCheck.Value = dtpCheck.Value.AddDays(+(CInt(intFreqNo)))
                    End Select

                    If dtpCheck.Value < dtpToday.Value Then


                        If IsDBNull(Dtr1.Item("MaxRetrainFreq").ToString) Or Dtr1.Item("MaxRetrainFreq").ToString = "" Then
                            intFreq = 1
                        Else
                            intFreq = Dtr1.Item("MaxRetrainFreq").ToString + 1

                        End If



                        Dim Sql99 As String = "SELECT  * "
                        Sql99 = Sql99 + "From QEa_Training_History  "
                        Sql99 = Sql99 + "WHERE EmployeeNo = '" & Dtr11.Item("EmployeeNo").ToString & "' "
                        Sql99 = Sql99 + "AND Dept = '" & strDeptData & "'"
                        Sql99 = Sql99 + "AND DOCNO = '" & Dtr.Item("DOCNO").ToString & "' "
                        Sql99 = Sql99 + "AND REVNO = " & Dtr1.Item("MaxREVNO").ToString & " "
                        Sql99 = Sql99 + "AND RetrainFreq = " & Dtr1.Item("MaxRetrainFreq").ToString & " "
                        Sql99 = Sql99 + "ORDER BY DOCNO,REVNO"
                        Dim Dt99 As New DataTable
                        Dt99 = DB_CMD.GetData_Table(Sql99, DB_CMD.ObjConn)



                        Dim sqlinsert As String = ""
                        For Each Dtr99 As DataRow In Dt99.Rows

                            If IsDBNull(Dtr99.Item("MthdCode").ToString) Or Dtr99.Item("MthdCode").ToString = "" Then
                                MsgBox(" พนักงาน : '" & Dtr11.Item("EmployeeNo").ToString & "' ยังไม่ได้ระบุ (Method Training ) ที่เมนู Training Assign  ", MsgBoxStyle.Information, "เเจ้งเดือนให้ทราบ")
                                Exit Sub
                            End If


                            sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Result,Approve,Remark,MthdCode,MD,Dept,RetrainFreq,ComName,EmployeeName,Section) " &
                                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@RetrainFreq,@ComName,@EmployeeName,@Section)"

                            '       sqlinsert = "INSERT INTO QEa_Training_History_ChkRev(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,ComName,EmployeeName,RetrainFreq) " &
                            '    "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@ComName,@EmployeeName,@RetrainFreq)"

                            With comSave
                                .Parameters.Clear()
                                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = Dtr11.Item("EmployeeNo").ToString
                                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr99.Item("DOCNO").ToString
                                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr99.Item("REVNO").ToString
                                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)



                                Dim strCheckDocName As String = ""

                                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr99.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                                Dim Dt21 As New DataTable
                                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                                For Each Dtr21 As DataRow In Dt21.Rows
                                    strCheckDocName = Dtr21.Item("DOCNAME").ToString
                                    GoTo NEXT_STEP_DOCNAME

                                Next


NEXT_STEP_DOCNAME:

                                If strCheckDocName <> "" Then
                                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = strCheckDocName
                                Else
                                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = ""
                                End If

                                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr99.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                                Dim Dt2 As New DataTable
                                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                                For Each Dtr2 As DataRow In Dt2.Rows


                                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString


                                Next

                                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr99.Item("DOCDEPT").ToString
                                '.Parameters.Add("@TrnnDate", SqlDbType.Date).Value = ""
                                .Parameters.Add("@Result", SqlDbType.Int).Value = 0

                                If IsDBNull(Dtr.Item("Approve").ToString) Or Dtr.Item("Approve").ToString = "" Then
                                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr99.Item("Approve").ToString
                                Else
                                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                                End If



                                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = ""
                                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr99.Item("MthdCode").ToString
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr99.Item("Dept").ToString


                                .Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = intFreq
                                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                                .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = Dtr11.Item("EmployeeName").ToString

                                If IsDBNull(Dtr11.Item("Section").ToString) Or Dtr11.Item("Section").ToString = "" Then
                                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                                Else
                                    .Parameters.Add("@Section", SqlDbType.VarChar).Value = Dtr11.Item("Section").ToString

                                End If
                                .CommandText = sqlinsert
                                .Connection = DB_CMD.ObjConn
                                .ExecuteNonQuery()



                            End With


                        Next

                    End If

                Next
NEXT_STEP1:

            Next

            LoadingForm.nextProcess()
            Application.DoEvents()

        Next


    End Sub


    Private Sub TxtMD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtMD.SelectedIndexChanged
        Select Case TxtMD.Text
            Case "รายเดือน"
                strMD = "M"
            Case "รายวัน"
                strMD = "D"

        End Select
        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "

        Sql = Sql + "From QEa_Training_History_ChkRev  "
        Sql = Sql + "WHERE ComName = 'xxxx' "
        Sql = Sql + "AND Dept = 'xxx' "
        Sql = Sql + "AND MD = '" & strMD & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt

        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible =
            False
        dgvDetail.Columns(17).Visible = False

        ' If strDeptData = "SD" Then
        Call GetSectionDept()

        lblResult.Text = ""
        ' End If


        'StrFunction.TraingCheck = 2
        'Try
        '    BackgroundWorker1.RunWorkerAsync()
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        CmdExcute("DELETE FROM QEa_Training_History_ChkRev  WHERE ComName='" & strHostName & "' ", DB_CMD.ObjConn)

        FrmMainMenu.PictureBox2.Enabled = True

        Me.Close()
    End Sub

    Private Sub TxtEFFDate_ValueChanged(sender As Object, e As EventArgs) Handles TxtEFFDate.ValueChanged

        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "

        Sql = Sql + "From QEa_Training_History_ChkRev  "
        Sql = Sql + "WHERE ComName = 'xxxx' "
        Sql = Sql + "AND Dept = 'xxx' "
        Sql = Sql + "AND MD = '" & strMD & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt

        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible = False
        dgvDetail.Columns(17).Visible = False

    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick

    End Sub

    Private Sub dgvDetail_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetail.CellMouseDoubleClick
        Try


            strDocNo = Me.dgvDetail.Item(1, Me.dgvDetail.CurrentRow.Index).Value
            strREVNO = Me.dgvDetail.Item(2, Me.dgvDetail.CurrentRow.Index).Value
            StrEFFDATE = Me.dgvDetail.Item(3, Me.dgvDetail.CurrentRow.Index).Value
            strDocName = Me.dgvDetail.Item(4, Me.dgvDetail.CurrentRow.Index).Value


            strDocDept = Me.dgvDetail.Item(7, Me.dgvDetail.CurrentRow.Index).Value
            intRetrainFreq = Me.dgvDetail.Item(8, Me.dgvDetail.CurrentRow.Index).Value
            If IsDBNull(Me.dgvDetail.Item(9, Me.dgvDetail.CurrentRow.Index).Value) Then
                strTrainingDate = ""
            Else
                strTrainingDate = Me.dgvDetail.Item(9, Me.dgvDetail.CurrentRow.Index).Value
            End If
            strResult = Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).Value
            strApproveName = Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value
            If IsDBNull(Me.dgvDetail.Item(12, Me.dgvDetail.CurrentRow.Index).Value) Then
                strRemarkTraining = ""
            Else
                strRemarkTraining = Me.dgvDetail.Item(12, Me.dgvDetail.CurrentRow.Index).Value
            End If
            strMthdCode = Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).Value

            'StrFunction.TraingCheck = 2
            'Try
            '    BackgroundWorker1.RunWorkerAsync()
            'Catch ex As Exception

            'End Try

            FrmTraining_History_Check_Edit.Close()
            FrmTraining_History_Check_Edit.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtChkStartDate_ValueChanged(sender As Object, e As EventArgs) Handles TxtChkStartDate.ValueChanged

    End Sub


    Public Sub New()
        ' This call is required by the designer.

        InitializeComponent()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True

    End Sub

    Private Sub bntSDFind_Click(sender As Object, e As EventArgs) Handles bntSDFind.Click
        ' StrFunction.TraingCheck = 1
        lblResult.Text = "โปรแกรมประมวลผล..."
        If BackgroundWorker1.IsBusy <> True Then

            ' Start the asynchronous operation.

            BackgroundWorker1.RunWorkerAsync()

            Me.bntSDFind.Enabled = False

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        lblResult.Text = "โปรแกรมประมวลผล..."
        ''Do Until 1 = StrFunction.TraingCheck

        ''    Console.WriteLine("Start.")

        ''Loop
        ''Console.WriteLine("stop.")

        'Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        'Dim i As Integer

        'For i = 1 To 10

        '    If (worker.CancellationPending = True) Then

        '        e.Cancel = True

        '        Exit For

        '    Else

        '        ' Perform a time consuming operation and report progress.

        '        System.Threading.Thread.Sleep(100)

        '        worker.ReportProgress(i * 10)

        '    End If

        'Next
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted_1(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        'ProgressBar1.Visible = True
        'ProgressBar1.Style = ProgressBarStyle.Marquee
        Me.Cursor = Cursors.WaitCursor
        Me.dgvDetail.AllowUserToAddRows = True

        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "

        Sql = Sql + "From QEa_Training_History_ChkRev  "
        Sql = Sql + "WHERE ComName = 'xxxx' "
        Sql = Sql + "AND Dept = 'xxx' "
        Sql = Sql + "AND MD = '" & strMD & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt

        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible = False
        dgvDetail.Columns(17).Visible = False


        'Dim thread_trans As New Thread(AddressOf LoadGridDataSD)
        'thread_trans.Start()

        ' Call LoadGridDataSD()
        'Call LoadGridDataNEW()  '15-09-2022
        Call LoadGridDataNEW150922() '15-09-2022
        Me.dgvDetail.AllowUserToAddRows = False




        Me.bntSDFind.Enabled = True



        'ProgressBar1.Style = ProgressBarStyle.Blocks
        'ProgressBar1.Visible = False

        MessageBox.Show("Working Finished.")
        lblResult.Text = ""
    End Sub

    Sub CheckDataHistory()
        'ProgressBar1.Visible = True
        'ProgressBar1.Style = ProgressBarStyle.Marquee
        Me.Cursor = Cursors.WaitCursor
        Me.dgvDetail.AllowUserToAddRows = True

        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "

        Sql = Sql + "From QEa_Training_History_ChkRev  "
        Sql = Sql + "WHERE ComName = 'xxxx' "
        Sql = Sql + "AND Dept = 'xxx' "
        Sql = Sql + "AND MD = '" & strMD & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt

        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible = False
        dgvDetail.Columns(17).Visible = False


        'Dim thread_trans As New Thread(AddressOf LoadGridDataSD)
        'thread_trans.Start()

        Call LoadGridDataSD()

        Me.dgvDetail.AllowUserToAddRows = False




        Me.bntSDFind.Enabled = True



        'ProgressBar1.Style = ProgressBarStyle.Blocks
        'ProgressBar1.Visible = False

        MessageBox.Show("Working Finished.")
        lblResult.Text = ""
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TxtSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSection.SelectedIndexChanged
        Select Case TxtMD.Text
            Case "รายเดือน"
                strMD = "M"
            Case "รายวัน"
                strMD = "D"

        End Select
        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "

        Sql = Sql + "From QEa_Training_History_ChkRev  "
        Sql = Sql + "WHERE ComName = 'xxxx' "
        Sql = Sql + "AND Dept = 'xxx' "
        Sql = Sql + "AND MD = '" & strMD & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt

        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible =
            False
        dgvDetail.Columns(17).Visible = False
        lblResult.Text = ""

        StrSectionChk = TxtSection.Text

        'StrFunction.TraingCheck = 2
        'Try
        '    BackgroundWorker1.RunWorkerAsync()
        'Catch ex As Exception

        'End Try

        'If strDeptData = "SD" Then
        '    Call GetSectionDept()
        'End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        Me.lblResult.Text = (e.ProgressPercentage.ToString() + "%")
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        For Each row As DataGridViewRow In dgvDetail.Rows

            If Not IsDBNull(row.Cells("TrnnDate").Value) Then
                strEmployeeNODataChk = ""
                strDOCNOHistoryChk = ""
                intREVNOHistoryChk = Nothing
                intRetrainFreqHistoryChk = Nothing
                strEmployeeNODataChk = (row.Cells("EmployeeNo").Value.ToString)

                strDOCNOHistoryChk = (row.Cells("DOCNO").Value.ToString)
                intREVNOHistoryChk = (row.Cells("REVNO").Value.ToString)
                intRetrainFreqHistoryChk = (row.Cells("RetrainFreq").Value.ToString)


                Dim myCommand As New SqlCommand("Update QEa_Training_History Set Result = @Result " &
                                            "WHERE EmployeeNo = '" & (row.Cells("EmployeeNo").Value.ToString) & "' " &
                                            "AND Dept ='" & strDeptData & "' AND DOCNO ='" & (row.Cells("DOCNO").Value.ToString) & "' AND  REVNO = " & (row.Cells("REVNO").Value.ToString) & " AND  RetrainFreq = " & (row.Cells("RetrainFreq").Value.ToString) & " ", DB_CMD.ObjConn)

                If TxtResult.CheckState = 1 Then
                    myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = 1
                Else
                    myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = 0
                End If

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                Call ChkData(strEmployeeNODataChk)

            End If


        Next

        ' Me.Close()
        MsgBox("Approve เรียบร้อย")

    End Sub
    Sub ChkData(strEmployeeNOData)

        For Each row As DataGridViewRow In dgvDetail.Rows

            If row.Cells("DOCNO").Value = strDOCNOHistoryChk And row.Cells("REVNO").Value = intREVNOHistoryChk And row.Cells("EmployeeNo").Value = strEmployeeNOData And row.Cells("RetrainFreq").Value = intRetrainFreqHistoryChk Then

                If TxtResult.CheckState = 1 Then
                    row.Cells("Result").Value = 1
                Else
                    row.Cells("Result").Value = 0
                End If

                Exit Sub

            End If
        Next

    End Sub

    Private Sub TxtDOCNO_TextChanged(sender As Object, e As EventArgs) Handles TxtDOCNO.TextChanged
        Select Case TxtMD.Text
            Case "รายเดือน"
                strMD = "M"
            Case "รายวัน"
                strMD = "D"

        End Select
        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,DOCNAME,EmployeeName,MthdNam,DOCDEPT,RetrainFreq,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,EmployeeNo,ComName "

        Sql = Sql + "From QEa_Training_History_ChkRev  "
        Sql = Sql + "WHERE ComName = 'xxxx' "
        Sql = Sql + "AND Dept = 'xxx' "
        Sql = Sql + "AND MD = '" & strMD & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt

        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible =
            False
        dgvDetail.Columns(17).Visible = False
        lblResult.Text = ""

        StrSectionChk = TxtSection.Text

        'StrFunction.TraingCheck = 2
        'Try
        '    BackgroundWorker1.RunWorkerAsync()
        'Catch ex As Exception

        'End Try

        'If strDeptData = "SD" Then
        '    Call GetSectionDept()
        'End If
    End Sub


    Public Sub SetData(ByVal max As Integer, Optional ByVal str As String = "", Optional ByVal success As String = "")
        maxProcess = max
        strLoading = str
        strSuccess = success
        'ProgressBar.Value = 0
        'GroupBox.Text = strLoading
    End Sub
    Public Sub nextProcess()
        count += 1
        percentOfProcess = Convert.ToDouble((count) / maxProcess) * 100
        percentOfProcess = Math.Floor(percentOfProcess)

        ' ProgressBar.Value = percentOfProcess

        If percentOfProcess <> checkPercent Then
            'GroupBox.Text = strLoading & "  " & percentOfProcess & "%"
            Me.TextBox1.Text = strLoading & "  " & percentOfProcess & "%"
            checkPercent = percentOfProcess
        End If

        If percentOfProcess = 100 Then
            '  MainMemuForm.Cursor = Cursors.Default
            Me.Cursor = Cursors.Default
            If strSuccess <> "" Then
                MsgBox(strSuccess, MsgBoxStyle.Information, "Success")
            End If

            percentOfProcess = 0
            count = 0

            Threading.Thread.Sleep(1000)
            'Me.Close()

        End If
    End Sub

End Class