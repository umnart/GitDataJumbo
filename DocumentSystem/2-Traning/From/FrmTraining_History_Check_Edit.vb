Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_History_Check_Edit
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
    Dim strEmployeeNOData As String
    Private Sub FrmTraining_History_Check_Edit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()
        TxtREVNO.Text = strREVNO
        TxtDOCNO.Text = strDocNo
        TxtDOCNAME.Text = strDocName
        TxtDOCDEPT.Text = strDocDept
        TxtApprove.Text = strApproveName
        TxtEFFDATE.Text = StrEFFDATE
        TxtRemark.Text = strRemarkAssign
        TxtRetrainFreq.Text = intRetrainFreq
        TxtTrnnDate.Text = strTrainingDate


        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Or strApprove = "Supervisor" Then
            TxtResult.Enabled = True

        Else
            TxtResult.Enabled = False

        End If


        Call LoadEmployeeName()
        Call Grid()
        Call GetHostName()
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
            .CellBorderStyle = DataGridViewCellBorderStyle.Raised
        End With

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

    Sub LoadEmployeeName()

        Me.dgvDetail.AllowUserToAddRows = True

        Dim Sql99 As String = "SELECT  A.EmployeeNo, A.DOCNO, A.EmployeeName, A.REVNO, A.Dept, A.MD, A.ComName, A.RetrainFreq, A.Section, B.StartDate "
        Sql99 = Sql99 + "From QEa_Training_History_ChkRev AS A LEFT OUTER JOIN QEa_Training_Assign AS B ON A.EmployeeNo = B.EmployeeNo AND A.DOCNO = B.DOCNO "
        Sql99 = Sql99 + "WHERE A.Dept = '" & strDeptData & "' "
        Sql99 = Sql99 + "AND A.MD = '" & strMD & "' "
        Sql99 = Sql99 + "AND A.DOCNO = '" & strDocNo & "' "
        Sql99 = Sql99 + "AND A.REVNO = '" & strREVNO & "' "
        Sql99 = Sql99 + "AND A.ComName = '" & strHostName & "' "
        Sql99 = Sql99 + "AND A.RetrainFreq = " & intRetrainFreq & " "
        Sql99 = Sql99 + "AND A.Section = '" & StrSectionChk & "' "
        Sql99 = Sql99 + "ORDER BY A.EmployeeNo, A.DOCNO "

        'Dim Sql99 As String = "SELECT  EmployeeNo, DOCNO, EmployeeName, REVNO, Dept, MD, ComName,RetrainFreq,Section, "
        'Sql99 = Sql99 + "From QEa_Training_History_ChkRev  "
        'Sql99 = Sql99 + "WHERE Dept = '" & strDeptData & "' "
        'Sql99 = Sql99 + "AND MD = '" & strMD & "' "
        'Sql99 = Sql99 + "AND DOCNO = '" & strDocNo & "' "
        'Sql99 = Sql99 + "AND REVNO = '" & strREVNO & "' "
        'Sql99 = Sql99 + "AND ComName = '" & strHostName & "' "
        'Sql99 = Sql99 + "AND RetrainFreq = " & intRetrainFreq & " "
        'Sql99 = Sql99 + "AND Section = '" & StrSectionChk & "' "
        'Sql99 = Sql99 + "ORDER BY EmployeeNo, DOCNO "


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
                '.Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr99.Item("EmployeeNo").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr99.Item("EmployeeName").ToString
                .Item(3, .Rows.Count - 2).Value = Mid(Dtr99.Item("StartDate").ToString, 1, 10)

            End With
        Next

        Me.dgvDetail.AllowUserToAddRows = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub TxtEFFDATE_Click(sender As Object, e As EventArgs) Handles TxtEFFDATE.Click

    End Sub

    Private Sub bntChangeStartDate_Click(sender As Object, e As EventArgs) Handles bntChangeStartDate.Click
        TxtTrnnDate.Text = TxtEFFDATE.Text
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

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        For Each row As DataGridViewRow In dgvDetail.Rows

            If CBool(row.Cells("Sel").Value) = True Then
                strEmployeeNOData = (row.Cells("EmployeeNo").Value.ToString)

                Dim Sql As String = "SELECT  * "
                Sql = Sql + "From QEa_Training_History  "
                Sql = Sql + "WHERE EmployeeNo = '" & (row.Cells("EmployeeNo").Value.ToString) & "' "
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
                                            "WHERE EmployeeNo = '" & (row.Cells("EmployeeNo").Value.ToString) & "' " &
                                            "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "' AND  REVNO = " & TxtREVNO.Text & " AND  RetrainFreq = " & TxtRetrainFreq.Text & " ", DB_CMD.ObjConn)

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


                    Call ChkData(strEmployeeNOData)

                Next


                Dim sqlinsert As String
                If strstatus = "" Then

                    sqlinsert = "INSERT INTO QEa_Training_History(EmployeeNo,DOCNO,REVNO,DOCDEPT,MD,EFFDATE,MthdCode,TrnnDate,Result,Approve,Remark,Dept,RetrainFreq) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@DOCDEPT,@MD,@EFFDATE,@MthdCode,@TrnnDate,@Result,@Approve,@Remark,@Dept,@RetrainFreq)"

                    With comSave
                        .Parameters.Clear()
                        .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = (row.Cells("EmployeeNo").Value.ToString)
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


                        Call ChkData(strEmployeeNOData)
                    End With
                End If



            End If


        Next











        'For Each row As DataGridViewRow In FrmTraining_History_Check.dgvDetail.Rows
        '    FrmTraining_History_Check.dgvDetail.Item(8, FrmTraining_History_Check.dgvDetail.CurrentRow.Index).Value = TxtTrnnDate.Text
        '    If TxtResult.CheckState = 1 Then
        '        FrmTraining_History_Check.dgvDetail.Item(9, FrmTraining_History_Check.dgvDetail.CurrentRow.Index).Value = 1
        '    Else
        '        FrmTraining_History_Check.dgvDetail.Item(9, FrmTraining_History_Check.dgvDetail.CurrentRow.Index).Value = 0
        '    End If
        '    FrmTraining_History_Check.dgvDetail.Item(10, FrmTraining_History_Check.dgvDetail.CurrentRow.Index).Value = TxtApprove.Text
        '    FrmTraining_History_Check.dgvDetail.Item(11, FrmTraining_History_Check.dgvDetail.CurrentRow.Index).Value = TxtRemark.Text
        'Next


        ' StrFunction.TraingCheck = 1
        Me.Close()


    End Sub

    Sub ChkData(strEmployeeNOData)

        For Each row As DataGridViewRow In FrmTraining_History_Check.dgvDetail.Rows

            If row.Cells("DOCNO").Value = TxtDOCNO.Text And row.Cells("REVNO").Value = TxtREVNO.Text And row.Cells("EmployeeNo").Value = strEmployeeNOData And row.Cells("RetrainFreq").Value = intRetrainFreq Then

                row.Cells("TrnnDate").Value = TxtTrnnDate.Text

                If TxtResult.CheckState = 1 Then
                    row.Cells("Result").Value = 1
                Else
                    row.Cells("Result").Value = 0
                End If

                row.Cells("Approve").Value = TxtApprove.Text
                row.Cells("Remark").Value = TxtRemark.Text

                Exit Sub

            End If
        Next

    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick
        SendKeys.Send("{Tab}")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class