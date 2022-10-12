Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_History_Retraining_Select

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

    Private Sub FrmTraining_History_Retraining_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Grid()

        If strApprove = "Manager" Or strApprove = "Assistant manager" Or strApprove = "MR" Or strApprove = "SF Chief" Then
            TxtResult.Enabled = True

        Else
            TxtResult.Enabled = False

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub TxtFind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDOCNO.KeyPress
        If e.KeyChar = Chr(13) Then
            Call LoadDataCheck()
        End If
    End Sub
    Sub LoadDataCheck()


        Dim strYearDateFm As String = TxtYearData.Text & "-01-01"
        Dim strYearDateTo As String = TxtYearData.Text & "-12-31"

        Dim Sql As String = "Select * From QEa_CourseMaster "
        Sql = Sql + " WHERE DOCNO ='" & strDocNo & "' "
        Sql = Sql + " AND STATUS ='A' "

        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            TxtDOCNAME.Text = Dtr.Item("DOCNAME").ToString
            TxtREVNO.Text = Dtr.Item("REVNO").ToString
            TxtEFFDATE.Text = Dtr.Item("EFFDATE").ToString
            TxtDOCDEPT.Text = Dtr.Item("DOCDEPT").ToString
        Next

        Dim Sql1 As String = "Select A.EmployeeNo, C.EmployeeName, A.MthdCode, B.MthdNam, A.Approve, A.StartDate "
        Sql1 = Sql1 + " FROM QEa_Training_ReTaining_Assign AS A LEFT OUTER JOIN "
        Sql1 = Sql1 + " QEa_Training_Method As B On A.MthdCode = B.MthdCode LEFT OUTER JOIN "
        Sql1 = Sql1 + " QEa_Training_Person As C On A.EmployeeNo = C.EmployeeNo LEFT OUTER JOIN "
        Sql1 = Sql1 + " QEa_CourseMaster As D On A.DOCNO = D.DOCNO "
        Sql1 = Sql1 + " WHERE A.DOCNO ='" & strDocNo & "' "
        Sql1 = Sql1 + " AND A.Dept ='" & strDeptData & "' "
        Sql1 = Sql1 + " AND A.MD ='" & strMD & "' "
        Sql1 = Sql1 + " AND CONVERT(DATE,A.StartDate ,105) BETWEEN '" & strYearDateFm & "'  AND  '" & strYearDateTo & "' "
        Sql1 = Sql1 + " AND D.STATUS ='A' "
        Sql1 = Sql1 + " GROUP BY A.EmployeeNo, C.EmployeeName, A.MthdCode, B.MthdNam, A.Approve, A.StartDate "
        Sql1 = Sql1 + " Order By A.EmployeeNo "


        'Dim Sql1 As String = "Select QEa_Training_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_ReTaining_Assign.MthdCode, QEa_Training_Method.MthdNam,QEa_Training_ReTaining_Assign.Approve "
        'Sql1 = Sql1 + " FROM QEa_Training_ReTaining_Assign LEFT OUTER JOIN QEa_Training_Method ON QEa_Training_ReTaining_Assign.MthdCode = QEa_Training_Method.MthdCode LEFT OUTER JOIN QEa_Training_Person ON QEa_Training_ReTaining_Assign.EmployeeNo = QEa_Training_Person.EmployeeNo LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_ReTaining_Assign.DOCNO = QEa_CourseMaster.DOCNO "
        'Sql1 = Sql1 + " WHERE QEa_Training_ReTaining_Assign.DOCNO ='" & strDocNo & "' "
        'Sql1 = Sql1 + " AND QEa_Training_ReTaining_Assign.Dept ='" & strDeptData & "' "
        'Sql1 = Sql1 + " AND QEa_Training_ReTaining_Assign.MD ='" & strMD & "' "
        'Sql1 = Sql1 + " AND STATUS ='A' "
        'Sql1 = Sql1 + " GROUP BY QEa_Training_ReTaining_Assign.EmployeeNo, QEa_Training_Person.EmployeeName,QEa_Training_ReTaining_Assign.MthdCode, dbo.QEa_Training_Method.MthdNam,QEa_Training_ReTaining_Assign.Approve "
        'Sql1 = Sql1 + " Order By QEa_Training_ReTaining_Assign.EmployeeNo "

        Dim Dt1 As New DataTable
        Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

        Me.dgvDetail.AllowUserToAddRows = True
        For Each Dtr1 As DataRow In Dt1.Rows


            With dgvDetail
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                '.Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr1.Item("EmployeeNo").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr1.Item("EmployeeName").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr1.Item("MthdCode").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr1.Item("MthdNam").ToString

            End With

            TxtApprove.Text = Dtr1.Item("Approve").ToString

        Next



        Me.dgvDetail.AllowUserToAddRows = False

    End Sub
    Private Sub TxtFind_MouseEnter(sender As Object, e As EventArgs) Handles TxtDOCNO.MouseEnter

    End Sub

    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs) Handles TxtDOCNO.TextChanged
        Call clear()
    End Sub

    Sub clear()
        TxtDOCNAME.Text = ""
        TxtApprove.Text = ""
        TxtRemark.Text = ""
        TxtREVNO.Text = ""
        TxtEFFDATE.Text = ""

        dgvDetail.Rows.Clear()
        chkSelectALL.Checked = False

    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Dim strYearDateFm As String = TxtYearData.Text & "-01-01"
        Dim strYearDateTo As String = TxtYearData.Text & "-12-31"

        Me.dgvDOCNO.AllowUserToAddRows = True
        Dim Sql1 As String = "SELECT DOCNO "
        Sql1 = Sql1 + " FROM QEa_Training_ReTaining_Assign "
        Sql1 = Sql1 + " WHERE CONVERT(DATE,StartDate ,105) BETWEEN '" & strYearDateFm & "'  AND  '" & strYearDateTo & "' "
        Sql1 = Sql1 + " And Dept = '" & strDeptData & "'"
        Sql1 = Sql1 + " GROUP BY DOCNO "
        Sql1 = Sql1 + " ORDER BY DOCNO "

        Dim Dt1 As New DataTable
        Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
        Dim intNo As Integer = 1
        Me.dgvDOCNO.AllowUserToAddRows = True

        dgvDOCNO.Rows.Clear()

        For Each Dtr1 As DataRow In Dt1.Rows


            With dgvDOCNO
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr1.Item("DOCNO").ToString


            End With
            intNo = intNo + 1
        Next



        Me.dgvDOCNO.AllowUserToAddRows = False





        ' Call LoadDataCheck()
        ' Me.dgvDetail.AllowUserToAddRows = False
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


        With Me.dgvDOCNO
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

    Private Sub TxtDOCNAME_Click(sender As Object, e As EventArgs) Handles TxtDOCNAME.Click

    End Sub

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip3.ItemClicked

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

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

        If TxtResult.Checked = False Then
            MsgBox("กรุณาเลือกเหตุ")
        End If


        For Each row As DataGridViewRow In dgvDetail.Rows



            If CBool(row.Cells("Sel").Value) = True Then


                'Dim Sql As String = "SELECT  * "
                'Sql = Sql + "From QEa_Training_History  "
                'Sql = Sql + "WHERE EmployeeNo = '" & (row.Cells("EmployeeNo").Value.ToString) & "' "
                'Sql = Sql + "AND Dept = '" & strDeptData & "'"
                'Sql = Sql + "AND DOCNO = '" & TxtDOCNO.Text & "'"
                'Sql = Sql + "AND REVNO = " & TxtREVNO.Text & ""
                'Sql = Sql + "AND DOCDEPT = '" & TxtDOCDEPT.Text & "'"
                'Sql = Sql + "ORDER BY DOCNO"
                'Dim Dt As New DataTable
                'Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

                'Dim intNo As Integer = 1
                'Dim strstatus As String = ""
                'For Each Dtr As DataRow In Dt.Rows
                '    strstatus = "DATA"

                '    Dim myCommand As New SqlCommand("Update QEa_Training_History Set TrnnDate = @TrnnDate,Result = @Result,Approve = @Approve,Remark = @Remark " &
                '                            "WHERE EmployeeNo = '" & (row.Cells("EmployeeNo").Value.ToString) & "' " &
                '                            "AND Dept ='" & strDeptData & "' AND DOCNO ='" & TxtDOCNO.Text & "' AND  REVNO = " & TxtREVNO.Text & "", DB_CMD.ObjConn)

                '    myCommand.Parameters.Add("@TrnnDate", SqlDbType.Date).Value = TxtTrnnDate.Text

                '    If TxtResult.CheckState = 1 Then
                '        myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = 1
                '    Else
                '        myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = 0
                '    End If

                '    'myCommand.Parameters.Add("@Result", SqlDbType.VarChar).Value = TxtResult.CheckState
                '    myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.Text
                '    myCommand.Parameters.Add("@Remark", SqlDbType.VarChar).Value = TxtRemark.Text

                '    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                'Next


                Dim sqlinsert As String
                '  If strstatus = "" Then

                sqlinsert = "INSERT INTO QEa_Training_History_ReTraining(EmployeeNo,DOCNO,REVNO,DOCDEPT,MD,EFFDATE,MthdCode,TrnnDate,Result,Approve,Remark,Dept,NoReTraining) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@DOCDEPT,@MD,@EFFDATE,@MthdCode,@TrnnDate,@Result,@Approve,@Remark,@Dept,@NoReTraining)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = (row.Cells("EmployeeNo").Value.ToString)
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = strDocNo
                    .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                    .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                    .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = (row.Cells("MthdCode").Value.ToString)
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

                    Dim Sql1 As String = "Select MAX(NOReTraining) AS MAXNOReTraining From QEa_Training_History_ReTraining "
                    Sql1 = Sql1 + " WHERE DOCNO ='" & strDocNo & "' "
                    Sql1 = Sql1 + " AND Dept  ='" & strDeptData & "' "
                    Sql1 = Sql1 + " AND REVNO ='" & TxtREVNO.Text & "' "
                    Sql1 = Sql1 + " AND MD  ='" & strMD & "' "
                    Sql1 = Sql1 + " AND EmployeeNo  ='" & (row.Cells("EmployeeNo").Value.ToString) & "' "
                    Sql1 = Sql1 + " HAVING(Not (MAX(NOReTraining) Is NULL)) "


                    Dim Dt1 As New DataTable
                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                    Dim intNoReTraining As Integer = 0
                    For Each Dtr1 As DataRow In Dt1.Rows

                        intNoReTraining = Dtr1.Item("MAXNOReTraining").ToString

                    Next

                    If intNoReTraining = 0 Then

                        .Parameters.Add("@NoReTraining", SqlDbType.Int).Value = 1

                    Else

                        .Parameters.Add("@NoReTraining", SqlDbType.Int).Value = intNoReTraining + 1

                    End If

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With
            End If
        Next


        'FrmTraining_History.dgvDetail.Item(7, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtTrnnDate.Text
        'If TxtResult.CheckState = 1 Then
        '    FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 1
        'Else
        '    FrmTraining_History.dgvDetail.Item(8, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = 0
        'End If
        'FrmTraining_History.dgvDetail.Item(9, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtApprove.Text
        'FrmTraining_History.dgvDetail.Item(10, FrmTraining_History.dgvDetail.CurrentRow.Index).Value = TxtRemark.Text


        StrFunction.ReTraining = 1

        Me.Close()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick
        SendKeys.Send("{Tab}")
    End Sub

    Private Sub dgvDOCNO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDOCNO.CellContentClick

    End Sub

    Private Sub dgvDOCNO_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDOCNO.CellMouseClick
        dgvDetail.Rows.Clear()
        strDocNo = ""
        strDocNo = Me.dgvDOCNO.Item(1, Me.dgvDOCNO.CurrentRow.Index).Value



        Call LoadDataCheck()
    End Sub
End Class