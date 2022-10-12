Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Public Class FrmTranferTraining_History
    Dim ConnSA As New OleDbConnection
    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlDataAdapter
    Dim ds2 As New DataSet
    Dim da3 As SqlDataAdapter
    Dim ds3 As New DataSet
    Dim strSQL As String
    Dim cri As String = ""
    Dim strDateDueStartFM, strDateDueStartTO As String
    Dim IsFindItemcode As Boolean


    Dim Check As Boolean
    Dim Action As String
    Dim IsFind As Boolean
    Dim IsParentSite As Boolean
    Dim IsParentLocation As Boolean
    Dim IsParentComp As Boolean
    Dim strShowBrand As Boolean
    Dim strShowMoBrand As Boolean
    Dim strShowWindows As Boolean
    Dim strShowOffice As Boolean
    Dim comSave As New SqlCommand
    Dim comDelete As New SqlCommand
    Dim comUpdate As New SqlCommand
    Dim SQL As String
    Dim strDOCTYPE As String

    Dim Exts As String

    Public CommandType As String
    Public EditNo As String
    Dim strCri As String

    Private Sub bntChangeStartDate_Click(sender As Object, e As EventArgs) Handles bntChangeStartDate.Click


        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        CommandType = "Addnew"

        '   Call ShowDept()
        Call LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case strBranchConn

            Case "TP"
                Call TPData()
            Case "KB"
                Call KBDATA()
        End Select

    End Sub

    Sub KBDATA()
        With Me.grdData


            For i As Integer = 0 To .Rows.Count - 1


                Dim sqlinsert As String


                CmdExcute("DELETE FROM QEa_Training_History WHERE EmployeeNo ='" & CType((grdData.Rows(i).Cells(1).Value), String) & "' ", DB_CMD.ObjConn)



                Dim dt_SelectDataSA = ClassConnect.getDataSetKBSA("SELECT * FROM QEa_TrnnHist WHERE PersonCode ='" & CType((grdData.Rows(i).Cells(1).Value), String) & "'   ORDER BY PersonCode ,CrseCode   ", mytrans, "")

                If dt_SelectDataSA.Rows.Count > 0 Then
                    Dim intNo As Integer = 1
                    For ii As Integer = 0 To dt_SelectDataSA.Rows.Count - 1


                        Dim strAssign As String = ""
                        Dim strTrainer As String = ""
                        Dim strMthdCode As String = ""



                        If IsDBNull(dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString) Or (dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString) = "" Then
                            GoTo Next_LINEData
                        End If



                        If IsDBNull(dt_SelectDataSA.Rows(ii).Item("MthdCode").ToString) Or dt_SelectDataSA.Rows(ii).Item("MthdCode").ToString = "" Then

                            GoTo Next_STEP

                        End If


                        Dim command1 As New SqlCommand("SELECT  * FROM T_Mthd " &
                                     "WHERE MthdCodedata ='" & dt_SelectDataSA.Rows(ii).Item("MthdCode").ToString & "'", DB_CMD.ObjConn)
                        Dim table1 As New DataTable
                        Dim adapter1 As New SqlDataAdapter(command1)
                        Dim ds1 As New DataSet
                        adapter1.Fill(table1)

                        If table1.Rows.Count > 0 Then

                            strMthdCode = table1.Rows(0).Item("EditData").ToString

                        End If





Next_STEP:




                        Dim ObTrnnDate As Object

                        sqlinsert = "INSERT INTO QEa_Training_History(EmployeeNo,DOCNO,REVNO,DOCDEPT,MD,EFFDATE,MthdCode,TrnnDate,Result,Approve,Remark,Dept) " &
                            "VALUES(@EmployeeNo,@DOCNO,@REVNO,@DOCDEPT,@MD,@EFFDATE,@MthdCode,@TrnnDate,@Result,@Approve,@Remark,@Dept)"

                        With comSave
                            .Parameters.Clear()

                            .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = CType((grdData.Rows(i).Cells(1).Value), String)
                            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = dt_SelectDataSA.Rows(ii).Item("CrseCode").ToString
                            .Parameters.Add("@REVNO", SqlDbType.Int).Value = dt_SelectDataSA.Rows(ii).Item("RevNo").ToString
                            .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = dt_SelectDataSA.Rows(ii).Item("DeptCod").ToString
                            If CInt(dt_SelectDataSA.Rows(ii).Item("EmpTypeID").ToString) = 1 Then
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = "M"
                            Else
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = "D"
                            End If
                            .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = dt_SelectDataSA.Rows(ii).Item("RevDate").ToString
                            .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = strMthdCode

                            If IsDBNull(dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString) Or (dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString) = "" Then
                                ObTrnnDate = DBNull.Value

                                .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = ObTrnnDate

                            Else
                                .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString


                            End If

                            If dt_SelectDataSA.Rows(ii).Item("Result").ToString = "True" Then
                                .Parameters.Add("@Result", SqlDbType.Int).Value = 1
                            Else
                                .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                            End If


                            .Parameters.Add("@Approve", SqlDbType.VarChar).Value = dt_SelectDataSA.Rows(ii).Item("Approve").ToString
                            .Parameters.Add("@Remark", SqlDbType.VarChar).Value = dt_SelectDataSA.Rows(ii).Item("Remark").ToString
                            .Parameters.Add("@Dept", SqlDbType.VarChar).Value = CType((grdData.Rows(i).Cells(3).Value), String)



                            .CommandText = sqlinsert
                            .Connection = DB_CMD.ObjConn
                            .ExecuteNonQuery()

                        End With


Next_LINEData:

                    Next

                End If

                ' .Item(8, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("Approve").ToString

                'CmdExcute("DELETE FROM QEa_CourseMaster WHERE DOCNO ='" & CType((dgvData.Rows(i).Cells(0).Value), String) & "' AND  DOCTYPE ='" & CType((dgvData.Rows(i).Cells(8).Value), String) & "' AND  REVNO =" & CType((dgvData.Rows(i).Cells(4).Value), String) & " AND DOCDEPT ='" & CType((dgvData.Rows(i).Cells(3).Value), String) & "'", DB_CMD.ObjConn)




            Next


        End With

        MsgBox("OK")
    End Sub

    Sub TPData()
        With Me.grdData


            For i As Integer = 0 To .Rows.Count - 1


                Dim sqlinsert As String


                CmdExcute("DELETE FROM QEa_Training_History WHERE EmployeeNo ='" & CType((grdData.Rows(i).Cells(1).Value), String) & "' ", DB_CMD.ObjConn)



                Dim dt_SelectDataSA = ClassConnect.getDataSetSA("SELECT * FROM QEa_TrnnHist WHERE PersonCode ='" & CType((grdData.Rows(i).Cells(1).Value), String) & "'   ORDER BY PersonCode ,CrseCode   ", mytransDB, "")

                If dt_SelectDataSA.Rows.Count > 0 Then
                    Dim intNo As Integer = 1
                    For ii As Integer = 0 To dt_SelectDataSA.Rows.Count - 1


                        Dim strAssign As String = ""
                        Dim strTrainer As String = ""
                        Dim strMthdCode As String = ""



                        If IsDBNull(dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString) Or (dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString) = "" And dt_SelectDataSA.Rows(ii).Item("Result").ToString = "FALSE" Then
                            GoTo Next_LINEData
                        End If



                        If IsDBNull(dt_SelectDataSA.Rows(ii).Item("MthdCode").ToString) Or dt_SelectDataSA.Rows(ii).Item("MthdCode").ToString = "" Then

                            GoTo Next_STEP

                        End If


                        Dim command1 As New SqlCommand("SELECT  * FROM T_Mthd " &
                                     "WHERE MthdCodedata ='" & dt_SelectDataSA.Rows(ii).Item("MthdCode").ToString & "'", DB_CMD.ObjConn)
                        Dim table1 As New DataTable
                        Dim adapter1 As New SqlDataAdapter(command1)
                        Dim ds1 As New DataSet
                        adapter1.Fill(table1)

                        If table1.Rows.Count > 0 Then

                            strMthdCode = table1.Rows(0).Item("EditData").ToString

                        End If





Next_STEP:




                        Dim ObTrnnDate As Object

                        sqlinsert = "INSERT INTO QEa_Training_History(EmployeeNo,DOCNO,REVNO,DOCDEPT,MD,EFFDATE,MthdCode,TrnnDate,Result,Approve,Remark,Dept) " &
                            "VALUES(@EmployeeNo,@DOCNO,@REVNO,@DOCDEPT,@MD,@EFFDATE,@MthdCode,@TrnnDate,@Result,@Approve,@Remark,@Dept)"

                        With comSave
                            .Parameters.Clear()

                            .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = CType((grdData.Rows(i).Cells(1).Value), String)
                            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = dt_SelectDataSA.Rows(ii).Item("CrseCode").ToString
                            .Parameters.Add("@REVNO", SqlDbType.Int).Value = dt_SelectDataSA.Rows(ii).Item("RevNo").ToString
                            .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = dt_SelectDataSA.Rows(ii).Item("DeptCod").ToString
                            If CInt(dt_SelectDataSA.Rows(ii).Item("EmpTypeID").ToString) = 1 Then
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = "M"
                            Else
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = "D"
                            End If
                            .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = dt_SelectDataSA.Rows(ii).Item("RevDate").ToString
                            .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = strMthdCode

                            If IsDBNull(dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString) Or (dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString) = "" Then
                                ObTrnnDate = DBNull.Value

                                .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = ObTrnnDate

                            Else
                                .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = dt_SelectDataSA.Rows(ii).Item("TrnnDate").ToString


                            End If

                            If dt_SelectDataSA.Rows(ii).Item("Result").ToString = "True" Then
                                .Parameters.Add("@Result", SqlDbType.Int).Value = 1
                            Else
                                .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                            End If


                            .Parameters.Add("@Approve", SqlDbType.VarChar).Value = dt_SelectDataSA.Rows(ii).Item("Approve").ToString
                            .Parameters.Add("@Remark", SqlDbType.VarChar).Value = dt_SelectDataSA.Rows(ii).Item("Remark").ToString
                            .Parameters.Add("@Dept", SqlDbType.VarChar).Value = CType((grdData.Rows(i).Cells(3).Value), String)



                            .CommandText = sqlinsert
                            .Connection = DB_CMD.ObjConn
                            .ExecuteNonQuery()

                        End With


Next_LINEData:

                    Next

                End If

                ' .Item(8, .Rows.Count - 2).Value = dt_SelectDataSA.Rows(i).Item("Approve").ToString

                'CmdExcute("DELETE FROM QEa_CourseMaster WHERE DOCNO ='" & CType((dgvData.Rows(i).Cells(0).Value), String) & "' AND  DOCTYPE ='" & CType((dgvData.Rows(i).Cells(8).Value), String) & "' AND  REVNO =" & CType((dgvData.Rows(i).Cells(4).Value), String) & " AND DOCDEPT ='" & CType((dgvData.Rows(i).Cells(3).Value), String) & "'", DB_CMD.ObjConn)




            Next


        End With

        MsgBox("OK")
    End Sub


    Sub LoadData()


        Dim Sql As String = "Select * from QEa_Training_Person  WHERE EmployeeNo LIke 'Z%' "
        Sql = Sql + " Order by Branch,Dept,EmployeeNo asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        grdData.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With grdData
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("Section").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
                .Item(7, .Rows.Count - 2).Value = Mid(Dtr.Item("StartDate").ToString, 1, 10)
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("MD").ToString


            End With

            intNo = intNo + 1

        Next

        'TxtFindData.Text = ""
    End Sub

    Private Sub FrmTranferTraining_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connKBSA.State = ConnectionState.Closed Then
            connKBSA.ConnectionString = ClassConnect.ConnectionKBSA
            connKBSA.Open()
        End If
    End Sub
End Class