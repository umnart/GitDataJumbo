Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_History_Copy
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
    Private Sub FrmTraining_History_Copy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()
        Call Grid()

        Try


            Call LoadDataDept()

            TxtDept.Text = strDeptData


            TxtDept.Text = ""
            TxtSection.Text = ""

        Catch ex As Exception

        End Try
    End Sub
    Sub Grid()

        With Me.dgvDetail
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With
    End Sub
    Sub LoadDataDept()

        Dim command As New SqlCommand("SELECT Dept   FROM  QEa_Training_Person  GROUP BY Dept ORDER BY Dept  ", DB_CMD.ObjConn)
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
            TxtDept.DisplayMember = "Dept"
            TxtDept.ValueMember = "Dept"
            TxtDept.DataSource = ds.Tables("QEa_Training_Person")

        End If

        Exit Sub


    End Sub

    Sub LoadDataSection()

        TxtSection.DataSource = Nothing

        Dim command As New SqlCommand("SELECT Section FROM  QEa_Training_Person   WHERE Dept = '" & TxtDept.Text & "'AND (NOT (Section IS NULL)) AND (MD = '" & strMD & "') GROUP BY  Section  ORDER BY Section  ", DB_CMD.ObjConn)
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

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close()
    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Me.dgvDetail.AllowUserToAddRows = True

        dgvDetail.Rows.Clear()
        Dim cri As String

        cri = "WHERE Dept ='" & TxtDept.Text & "' AND MD  ='" & strMD & "'"

        If TxtSection.Text <> "" Then
            cri = cri & "And (Section   =  '" & TxtSection.Text & "')"
        End If




        'Dim Sql As String = "SELECT * "
        'Sql = Sql + " FROM  QEa_DocSysItem "
        'Sql = Sql + cri
        'Sql = Sql + " Order by REFNO,REFNODATA asc "

        Dim Sql As String = "SELECT * "
        Sql = Sql + " FROM QEa_Training_Person "
        Sql = Sql + cri
        Sql = Sql + " Order by EmployeeNo asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvDetail.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvDetail
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                .Item(1, .Rows.Count - 2).Value = intNo
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("StartDate").ToString

            End With

            intNo = intNo + 1

        Next
        Me.dgvDetail.AllowUserToAddRows = False
    End Sub

    Private Sub TxtDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDept.SelectedIndexChanged
        dgvDetail.Rows.Clear()
        Call LoadDataSection()
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick
        SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSection.SelectedIndexChanged
        dgvDetail.Rows.Clear()
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        With QEa_Training_Assign
            For Each row As DataGridViewRow In dgvDetail.Rows
                If CBool(row.Cells("Sel").Value) = True Then

                    CmdExcute("DELETE FROM QEa_Training_History WHERE EmployeeNo = '" & CStr(row.Cells("EmployeeNo").Value) & "' AND Dept ='" & strDeptData & "' ", DB_CMD.ObjConn)


                    Dim Sql1 As String = "SELECT * "
                    Sql1 = Sql1 + " FROM QEa_Training_History "
                    Sql1 = Sql1 + " WHERE EmployeeNo = '" & FrmTraining_History.TxtEmployeeNo.SelectedValue.ToString & "' AND Dept ='" & strDeptData & "'"
                    Sql1 = Sql1 + " Order by EmployeeNo asc"
                    Dim Dt1 As New DataTable
                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                    Dim sqlinsert As String = ""
                    For Each Dtr1 As DataRow In Dt1.Rows



                        Dim command As New SqlCommand("SELECT  * FROM QEa_Training_Assign " &
                                                      "WHERE DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' AND EmployeeNo  = '" & CStr(row.Cells("EmployeeNo").Value) & "'", DB_CMD.ObjConn)
                        Dim table As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        Dim ds As New DataSet
                        adapter.Fill(table)

                        If table.Rows.Count = 0 Then

                            GoTo Next_STEP1

                        End If



                        sqlinsert = "INSERT INTO QEa_Training_History(EmployeeNo,DOCNO,REVNO,DOCDEPT,MD,EFFDATE,MthdCode,TrnnDate,Result,Approve,Remark,Dept,RetrainFreq) " &
                            "VALUES(@EmployeeNo,@DOCNO,@REVNO,@DOCDEPT,@MD,@EFFDATE,@MthdCode,@TrnnDate,@Result,@Approve,@Remark,@Dept,@RetrainFreq)"

                        With comSave
                            .Parameters.Clear()
                            .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = CStr(row.Cells("EmployeeNo").Value)
                            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr1.Item("DOCNO").ToString
                            .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr1.Item("REVNO").ToString
                            .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr1.Item("DOCDEPT").ToString
                            .Parameters.Add("@MD", SqlDbType.VarChar).Value = Dtr1.Item("MD").ToString
                            .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr1.Item("EFFDATE").ToString
                            .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr1.Item("MthdCode").ToString
                            .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Dtr1.Item("TrnnDate").ToString


                            .Parameters.Add("@Result", SqlDbType.VarChar).Value = Dtr1.Item("Result").ToString


                            .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr1.Item("Approve").ToString
                            .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr1.Item("Remark").ToString
                            .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr1.Item("Dept").ToString
                            .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = Dtr1.Item("RetrainFreq").ToString


                            .CommandText = sqlinsert
                            .Connection = DB_CMD.ObjConn
                            .ExecuteNonQuery()

                        End With

                        '.EmployeeNo = CStr(row.Cells("EmployeeNo").Value)
                        '.DOCNO = Dtr1.Item("DOCNO").ToString
                        '.DOCDEPT = Dtr1.Item("DOCDEPT").ToString
                        '.MD = Dtr1.Item("MD").ToString
                        '.Dept = Dtr1.Item("Dept").ToString
                        '' .AssSeq = CStr(row.Cells("AssSeq").Value)
                        '.Assign = Dtr1.Item("Assign").ToString
                        '.Trainer = Dtr1.Item("Trainer").ToString
                        '.MthdCode = Dtr1.Item("MthdCode").ToString
                        '.Approve = Dtr1.Item("Approve").ToString
                        'If IsDBNull(Dtr1.Item("Remark").ToString) Or Dtr1.Item("Remark").ToString = "" Then
                        '    .StartDate = Dtr1.Item("StartDate").ToString
                        'Else
                        '    .StartDate = CStr(row.Cells("StartDate").Value)
                        'End If


                        '.Remark = Dtr1.Item("Remark").ToString

                        'CommandType = "Addnew"
                        'Dim Sql As String = Nothing
                        'Select Case CommandType
                        '    Case "Addnew"
                        '        Sql = .SqlCommandInsert
                        '    Case "Edit"
                        '        Sql = .SqlCommandUpdate
                        'End Select
                        'If CmdExcute(Sql, DB_CMD.ObjConn) = True Then
                        '    ' MsgBox("บันทึกข้อมูลสำเร็จ")
                        'Else
                        '    MsgBox("ไม่สามารถบันทึกข้อมูลได้")
                        '    Exit Sub
                        'End If
Next_STEP1:

                    Next

                End If
NEXTSTEP:
            Next
        End With




        '   StrFunction.AssignSel = 1
        MsgBox("Copy Training History เรียบร้อย", MsgBoxStyle.Information, "เเจ้งเตือน")
        Me.Close()



    End Sub

    Private Sub chkSelectALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectALL.CheckedChanged
        With Me.dgvDetail
            For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                If chkSelectALL.Checked = True Then
                    .Item(0, i).Value = True
                Else
                    .Item(0, i).Value = False
                End If

            Next
        End With
    End Sub
End Class