Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_Assign_Edit
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
    Private Sub FrmTraining_Assign_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        TxtDOCNO.Text = strDocNo
        TxtDOCNAME.Text = strDocName
        TxtDOCDEPT.Text = strDocDept
        TxtApprove.Text = strApproveName
        TxtStartDate.Text = strStartDate
        TxtRemark.Text = strRemarkAssign
        TxtRetrainFreq.Text = strRetrainFreqAssign

        Try


            Call QEa_Training_Method()
            Call QEa_Training_Method_Assign()
            Call QEa_Training_Method_Trainer()


            TxtAssignCode.Text = ""
            TxtMthdCode.Text = ""
            TxtTrainerCode.Text = ""


            Call LoaddataAssignCode()
            Call LoaddataMthdCode()
            Call LoaddataTrainerCode()

        Catch ex As Exception

        End Try

    End Sub

    Sub LoaddataMthdCode()

        Dim Sql As String = "SELECT  * "
        Sql = Sql + "From QEa_Training_Method  "
        Sql = Sql + "WHERE MthdCode = '" & strMthdCode & "' "
        Sql = Sql + "ORDER BY MthdCode"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            TxtMthdCode.Text = Dtr.Item("MthdNam").ToString()
        Next

    End Sub

    Sub LoaddataAssignCode()

        Dim Sql As String = "SELECT  * "
        Sql = Sql + "From QEa_Training_Method_Assign  "
        Sql = Sql + "WHERE AssignCode = '" & strAssignCode & "' "
        Sql = Sql + "ORDER BY AssignCode"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            TxtAssignCode.Text = Dtr.Item("AssignName").ToString()
        Next

    End Sub

    Sub LoaddataTrainerCode()

        Dim Sql As String = "SELECT  * "
        Sql = Sql + "From QEa_Training_Method_Trainer  "
        Sql = Sql + "WHERE TrainerCode = '" & strTrainerCode & "' "
        Sql = Sql + "ORDER BY TrainerCode"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            TxtTrainerCode.Text = Dtr.Item("TrainerName").ToString()
        Next

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Sub QEa_Training_Method()

        Dim command As New SqlCommand("SELECT MthdCode,MthdNam  FROM  QEa_Training_Method  ORDER BY MthdCode  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)

        'adapter.Fill(ds)

        'For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
        '    TxtEmployeeNo.Items.Add(ds.Tables(0).Rows(i)(0) & "   :   " & ds.Tables(0).Rows(i)(1))
        '    ' i = i + 1
        'Next

        adapter.Fill(ds, "QEa_Training_Method")
        If table.Rows.Count > 0 Then
            TxtMthdCode.DisplayMember = "MthdNam"
            TxtMthdCode.ValueMember = "MthdCode"
            TxtMthdCode.DataSource = ds.Tables("QEa_Training_Method")

        End If

        Exit Sub
    End Sub
    Sub QEa_Training_Method_Assign()

        Dim command As New SqlCommand("SELECT AssignCode,AssignName  FROM  QEa_Training_Method_Assign  ORDER BY AssignCode  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)

        'adapter.Fill(ds)

        'For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
        '    TxtEmployeeNo.Items.Add(ds.Tables(0).Rows(i)(0) & "   :   " & ds.Tables(0).Rows(i)(1))
        '    ' i = i + 1
        'Next

        adapter.Fill(ds, "QEa_Training_Method_Assign")
        If table.Rows.Count > 0 Then
            TxtAssignCode.DisplayMember = "AssignName"
            TxtAssignCode.ValueMember = "AssignCode"
            TxtAssignCode.DataSource = ds.Tables("QEa_Training_Method_Assign")

        End If

        Exit Sub
    End Sub

    Sub QEa_Training_Method_Trainer()

        Dim command As New SqlCommand("SELECT TrainerCode,TrainerName  FROM  QEa_Training_Method_Trainer  ORDER BY TrainerCode  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)

        'adapter.Fill(ds)

        'For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
        '    TxtEmployeeNo.Items.Add(ds.Tables(0).Rows(i)(0) & "   :   " & ds.Tables(0).Rows(i)(1))
        '    ' i = i + 1
        'Next

        adapter.Fill(ds, "QEa_Training_Method_Trainer")
        If table.Rows.Count > 0 Then
            TxtTrainerCode.DisplayMember = "TrainerName"
            TxtTrainerCode.ValueMember = "TrainerCode"
            TxtTrainerCode.DataSource = ds.Tables("QEa_Training_Method_Trainer")

        End If
        Exit Sub
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click


        If chkSelectALL.Checked = True Then

            Dim criData As String = ""
            Select Case strFormAssign
                Case "Assign"
                    criData = "FROM  QEa_Training_Assign "
                Case "Retraining"
                    criData = "FROM  QEa_Training_ReTaining_Assign "
            End Select


            Dim Sql As String = "SELECT  * "
            Sql = Sql + criData
            Sql = Sql + "WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' "
            Sql = Sql + "AND Dept = '" & strDeptData & "'"
            Sql = Sql + "ORDER BY DOCNO"
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows

                Select Case strFormAssign
                    Case "Assign"
                        Dim myCommand As New SqlCommand("Update QEa_Training_Assign Set Assign = @Assign,Trainer = @Trainer,MthdCode = @MthdCode,Approve = @Approve " &
                                    "WHERE EmployeeNo = '" & Dtr.Item("EmployeeNo").ToString & "' " &
                                    "AND Dept ='" & Dtr.Item("Dept").ToString & "' AND DOCNO ='" & Dtr.Item("DOCNO").ToString & "'", DB_CMD.ObjConn)

                        myCommand.Parameters.Add("@Assign", SqlDbType.VarChar).Value = TxtAssignCode.SelectedValue.ToString
                        myCommand.Parameters.Add("@Trainer", SqlDbType.VarChar).Value = TxtTrainerCode.SelectedValue.ToString
                        myCommand.Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = TxtMthdCode.SelectedValue.ToString
                        myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text


                        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                        StrFunction.AssignSel = 1
                        Me.Close()


                    Case "Retraining"

                        Dim myCommand As New SqlCommand("Update QEa_Training_ReTaining_Assign Set Assign = @Assign,Trainer = @Trainer,MthdCode = @MthdCode,Approve = @Approve " &
                                    "WHERE EmployeeNo = '" & Dtr.Item("EmployeeNo").ToString & "' " &
                                    "AND Dept ='" & Dtr.Item("Dept").ToString & "' AND DOCNO ='" & Dtr.Item("DOCNO").ToString & "'", DB_CMD.ObjConn)

                        myCommand.Parameters.Add("@Assign", SqlDbType.VarChar).Value = TxtAssignCode.SelectedValue.ToString
                        myCommand.Parameters.Add("@Trainer", SqlDbType.VarChar).Value = TxtTrainerCode.SelectedValue.ToString
                        myCommand.Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = TxtMthdCode.SelectedValue.ToString
                        myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text

                        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
                        StrFunction.ReTrainAssignSel = 1
                        Me.Close()
                End Select





            Next

        Else

            Select Case strFormAssign
                Case "Assign"

                    Dim myCommand As New SqlCommand("Update QEa_Training_Assign Set Assign = @Assign,Trainer = @Trainer,MthdCode = @MthdCode,Approve = @Approve,RetrainFreq = @RetrainFreq  " &
                                                   "WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' " &
                                                   "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)

                    myCommand.Parameters.Add("@Assign", SqlDbType.VarChar).Value = TxtAssignCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@Trainer", SqlDbType.VarChar).Value = TxtTrainerCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = TxtMthdCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text
                    myCommand.Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = TxtRetrainFreq.Text

                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                    StrFunction.AssignSel = 1
                    Me.Close()

                Case "Retraining"

                    Dim myCommand As New SqlCommand("Update QEa_Training_ReTaining_Assign Set Assign = @Assign,Trainer = @Trainer,MthdCode = @MthdCode,Approve = @Approve " &
                                                   "WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' " &
                                                   "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)

                    myCommand.Parameters.Add("@Assign", SqlDbType.VarChar).Value = TxtAssignCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@Trainer", SqlDbType.VarChar).Value = TxtTrainerCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = TxtMthdCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text

                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                    StrFunction.ReTrainAssignSel = 1
                    Me.Close()

            End Select




        End If





    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs) Handles bntDelete.Click
        Select Case strFormAssign
            Case "Assign"
                Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"
                If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
                CmdExcute("DELETE FROM QEa_Training_Assign  WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' " &
                                               "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)
                StrFunction.AssignDelete = 1
                Me.Close()
            Case "Retraining"
                Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"
                If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
                CmdExcute("DELETE FROM QEa_Training_ReTaining_Assign  WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' " &
                                               "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)
                StrFunction.ReTrainAssignSel = 1
                Me.Close()
        End Select



    End Sub

    Private Sub bntChangeStartDate_Click(sender As Object, e As EventArgs) Handles bntChangeStartDate.Click


        If TxtRemark.Text = "" Then
            MsgBox("กรุณาระบุเหตุผลที่เปลี่ยนแปลงวันที่เริ่มอบรมด้วย")
            TxtRemark.Focus()
            Exit Sub
        End If

        Dim criData As String = ""
        Select Case strFormAssign
            Case "Assign"
                criData = "FROM  QEa_Training_Assign "
            Case "Retraining"
                criData = "FROM  QEa_Training_ReTaining_Assign "
        End Select

        Dim Sql As String = "SELECT  * "
        Sql = Sql + criData
        Sql = Sql + "WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' "
        Sql = Sql + "AND Dept = '" & strDeptData & "'"
        Sql = Sql + "AND DOCNO = '" & TxtDOCNO.Text & "'"
        Sql = Sql + "ORDER BY DOCNO"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows


            Select Case strFormAssign
                Case "Assign"

                    'Dim myCommand As New SqlCommand("Update QEa_Training_Assign Set StartDate = @StartDate,Remark = @Remark " &
                    '                    "WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' " &
                    '                    "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)

                    'myCommand.Parameters.Add("@StartDate", SqlDbType.Date).Value = TxtStartDate.Text
                    'myCommand.Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text

                    'Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                    Dim myCommand As New SqlCommand("Update QEa_Training_Assign Set Assign = @Assign,Trainer = @Trainer,MthdCode = @MthdCode,Approve = @Approve,StartDate = @StartDate,Remark = @Remark " &
                                    "WHERE EmployeeNo = '" & Dtr.Item("EmployeeNo").ToString & "' " &
                                    "AND Dept ='" & Dtr.Item("Dept").ToString & "' AND DOCNO ='" & Dtr.Item("DOCNO").ToString & "'", DB_CMD.ObjConn)

                    myCommand.Parameters.Add("@Assign", SqlDbType.VarChar).Value = TxtAssignCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@Trainer", SqlDbType.VarChar).Value = TxtTrainerCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = TxtMthdCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text
                    myCommand.Parameters.Add("@StartDate", SqlDbType.Date).Value = TxtStartDate.Text
                    myCommand.Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text

                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


                    StrFunction.AssignSel = 1
                    Me.Close()


                Case "Retraining"

                    'Dim myCommand As New SqlCommand("Update QEa_Training_ReTaining_Assign Set StartDate = @StartDate,Remark = @Remark " &
                    '                  "WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' " &
                    '                  "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "'", DB_CMD.ObjConn)

                    'myCommand.Parameters.Add("@StartDate", SqlDbType.Date).Value = TxtStartDate.Text
                    'myCommand.Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text

                    'Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                    Dim myCommand As New SqlCommand("Update QEa_Training_ReTaining_Assign Set Assign = @Assign,Trainer = @Trainer,MthdCode = @MthdCode,Approve = @Approve, StartDate = @StartDate,Remark = @Remark " &
                                    "WHERE EmployeeNo = '" & Dtr.Item("EmployeeNo").ToString & "' " &
                                    "AND Dept ='" & Dtr.Item("Dept").ToString & "' AND DOCNO ='" & Dtr.Item("DOCNO").ToString & "'", DB_CMD.ObjConn)

                    myCommand.Parameters.Add("@Assign", SqlDbType.VarChar).Value = TxtAssignCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@Trainer", SqlDbType.VarChar).Value = TxtTrainerCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = TxtMthdCode.SelectedValue.ToString
                    myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text
                    myCommand.Parameters.Add("@StartDate", SqlDbType.Date).Value = TxtStartDate.Text
                    myCommand.Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text
                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


                    StrFunction.ReTrainAssignSel = 1
                    Me.Close()
            End Select

        Next



    End Sub
End Class