Imports SystemstrApprove
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_History_Edit
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

    Private Sub FrmTraining_History_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        TxtDOCNO.Text = strDocNo
        TxtDOCNAME.Text = strDocName
        TxtDOCDEPT.Text = strDocDept
        TxtApprove.Text = strApproveName
        TxtEFFDATE.Text = StrEFFDATE
        TxtRemark.Text = strRemarkTraining
        TxtREVNO.Text = strREVNO
        TxtTrnnDate.Text = strTrainingDate
        TxtResult.CheckState = strResult

        TxtRetrainFreq.Text = intRetrainFreq

        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Or strApprove = "Supervisor" Then
            TxtResult.Enabled = True

        Else
            TxtResult.Enabled = False

        End If


        Try

        Catch ex As Exception

        End Try

    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs)






        Dim Sql As String = "SELECT  * "
        Sql = Sql + "From QEa_Training_History  "
        Sql = Sql + "WHERE EmployeeNo = '" & FrmTraining_History.TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql = Sql + "AND Dept = '" & strDeptData & "'"
        Sql = Sql + "AND DOCNO = '" & TxtDOCNO.Text & "'"
        Sql = Sql + "AND REVNO = " & TxtREVNO.Text & ""
        Sql = Sql + "AND DOCDEPT = '" & TxtDOCDEPT.Text & "'"
        Sql = Sql + "ORDER BY DOCNO"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr As DataRow In Dt.Rows
            strstatus = "DATA"

            Dim myCommand As New SqlCommand("Update QEa_Training_History Set TrnnDate = @TrnnDate,Result = @Result,Approve = @Approve,Remark = @Remark " &
                                        "WHERE EmployeeNo = '" & Dtr.Item("EmployeeNo").ToString & "' " &
                                        "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "' AND  REVNO = " & TxtREVNO.Text & "", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@TrnnDate", SqlDbType.Date).Value = TxtTrnnDate.Text

            If TxtResult.CheckState = 1 Then
                myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = 1
            Else
                myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = 0
            End If

            'myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = TxtResult.CheckState
            myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text
            myCommand.Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            'FrmTraining_History.dgvDetail.Item(7, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtTrnnDate.Text
            'If TxtResult.CheckState = 1 Then
            '    FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 1
            'Else
            '    FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 0
            'End If
            'FrmTraining_History.dgvDetail.Item(9, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtApprove.Text
            '    FrmTraining_History.dgvDetail.Item(10, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtRemark.Text


        Next


        Dim sqlinsert As String
        If strstatus = "" Then

            sqlinsert = "INSERT INTO QEa_Training_History(EmployeeNo,DOCNO,REVNO,DOCDEPT,MD,EFFDATE,MthdCode,TrnnDate,Result,Approve,Remark,Dept) " &
                            "VALUES(@EmployeeNo,@DOCNO,@REVNO,@DOCDEPT,@MD,@EFFDATE,@MthdCode,@TrnnDate,@Result,@Approve,@Remark,@Dept)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = FrmTraining_History.TxtEmployeeNo.SelectedValue.ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = strMthdCode
                .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = TxtTrnnDate.Text

                If TxtResult.CheckState = 1 Then
                    .Parameters.Add("@Result", SqlDbType.VarChar).Value = 1
                Else
                    .Parameters.Add("@Result", SqlDbType.VarChar).Value = 0
                End If
                '.Parameters.Add("@Result", SqlDbType.VarChar).Value = TxtResult.CheckState
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData


                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With
        End If



        FrmTraining_History.dgvDetail.Item(7, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtTrnnDate.Text
        If TxtResult.CheckState = 1 Then
            FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 1
        Else
            FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 0
        End If
        FrmTraining_History.dgvDetail.Item(9, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtApprove.Text
        FrmTraining_History.dgvDetail.Item(10, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtRemark.Text


        StrFunction.TrainingSel = 1
        Me.Close()

    End Sub

    Private Sub bntChangeStartDate_Click(sender As Object, e As EventArgs) Handles bntChangeStartDate.Click
        TxtTrnnDate.Text = TxtEFFDATE.Text
    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub bntSave_Click_1(sender As Object, e As EventArgs) Handles bntSave.Click



        Dim Sql As String = "SELECT  * "
        Sql = Sql + "From QEa_Training_History  "
        Sql = Sql + "WHERE EmployeeNo = '" & FrmTraining_History.TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql = Sql + "AND Dept = '" & strDeptData & "'"
        Sql = Sql + "AND DOCNO = '" & TxtDOCNO.Text & "'"
        Sql = Sql + "AND REVNO = " & TxtREVNO.Text & ""
        Sql = Sql + "AND DOCDEPT = '" & TxtDOCDEPT.Text & "'"
        Sql = Sql + "AND RetrainFreq = " & TxtRetrainFreq.Text & ""
        Sql = Sql + "ORDER BY DOCNO"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr As DataRow In Dt.Rows
            strstatus = "DATA"

            Dim myCommand As New SqlCommand("Update QEa_Training_History Set TrnnDate = @TrnnDate,Result = @Result,Approve = @Approve,Remark = @Remark " &
                                        "WHERE EmployeeNo = '" & Dtr.Item("EmployeeNo").ToString & "' " &
                                        "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "' AND  REVNO = " & TxtREVNO.Text & "AND  RetrainFreq = " & TxtRetrainFreq.Text & "", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@TrnnDate", SqlDbType.Date).Value = TxtTrnnDate.Text

            If TxtResult.CheckState = 1 Then
                myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = 1
            Else
                myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = 0
            End If

            'myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = TxtResult.CheckState
            myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text
            myCommand.Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
            'FrmTraining_History.dgvDetail.Item(7, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtTrnnDate.Text
            'If TxtResult.CheckState = 1 Then
            '    FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 1
            'Else
            '    FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 0
            'End If
            'FrmTraining_History.dgvDetail.Item(9, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtApprove.Text
            '    FrmTraining_History.dgvDetail.Item(10, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtRemark.Text


        Next


        Dim sqlinsert As String
        If strstatus = "" Then

            sqlinsert = "INSERT INTO QEa_Training_History(EmployeeNo,DOCNO,REVNO,DOCDEPT,MD,EFFDATE,MthdCode,TrnnDate,Result,Approve,Remark,Dept,RetrainFreq) " &
                            "VALUES(@EmployeeNo,@DOCNO,@REVNO,@DOCDEPT,@MD,@EFFDATE,@MthdCode,@TrnnDate,@Result,@Approve,@Remark,@Dept,@RetrainFreq)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = FrmTraining_History.TxtEmployeeNo.SelectedValue.ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = strMthdCode
                .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = TxtTrnnDate.Text

                If TxtResult.CheckState = 1 Then
                    .Parameters.Add("@Result", SqlDbType.VarChar).Value = 1
                Else
                    .Parameters.Add("@Result", SqlDbType.VarChar).Value = 0
                End If
                '.Parameters.Add("@Result", SqlDbType.VarChar).Value = TxtResult.CheckState
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = TxtRetrainFreq.Text


                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With
        End If



        FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtTrnnDate.Text
        If TxtResult.CheckState = 1 Then
            FrmTraining_History.dgvDetail.Item(9, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 1
        Else
            FrmTraining_History.dgvDetail.Item(9, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 0
        End If
        FrmTraining_History.dgvDetail.Item(10, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtApprove.Text
        FrmTraining_History.dgvDetail.Item(11, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtRemark.Text


        StrFunction.TrainingSel = 1
        Me.Close()

    End Sub

    Private Sub bntDelete_Click_1(sender As Object, e As EventArgs) Handles bntDelete.Click
        Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"

        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        CmdExcute("DELETE FROM QEa_Training_History  WHERE EmployeeNo = '" & FrmTraining_History.TxtEmployeeNo.SelectedValue.ToString & "' " &
                                           "AND Dept = '" & strDeptData & "' " &
                                           "AND REVNO = " & TxtREVNO.Text & " " &
                                           "AND DOCDEPT = '" & TxtDOCDEPT.Text & "' " &
                                           "AND RetrainFreq = " & TxtRetrainFreq.Text & " " &
                                           "AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)
        ' FrmTraining_History.dgvDetail.Rows.Clear()
        StrFunction.TrainingDel = 1

        Me.Close()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sql9 As String = "Select    StartDate "
        Sql9 = Sql9 + "FROM QEa_Training_Assign "
        Sql9 = Sql9 + "WHERE EmployeeNo ='" & FrmTraining_History.TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql9 = Sql9 + "AND Dept ='" & strDeptData & "' "
        Sql9 = Sql9 + "AND DOCNO ='" & TxtDOCNO.Text & "'"
        Sql9 = Sql9 + "GROUP BY StartDate "
        Sql9 = Sql9 + "ORDER BY StartDate "
        Dim Dt9 As DataTable
        Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        For Each Dtr9 As DataRow In Dt9.Rows

            TxtTrnnDate.Text = Dtr9.Item("StartDate").ToString

        Next
    End Sub
End Class