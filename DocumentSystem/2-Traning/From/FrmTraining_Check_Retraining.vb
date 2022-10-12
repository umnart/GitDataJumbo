Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Net.Mail
Public Class FrmTraining_Check_Retraining
    Private Sub FrmTraining_Check_Retraining_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        Call Grid()

        Call GetHostName()
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick

    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Call LoadData
    End Sub
    Sub LoadData()
        Try

            If TxtMD.Text = "" Then
                MsgBox("ใส่ข้อมูลให้ครบด้วยค่ะ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                TxtMD.Focus()
                Exit Sub
            End If

            If TxtDOCNO.Text = "" Then
                MsgBox("ใส่ข้อมูลให้ครบด้วยค่ะ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                TxtDOCNO.Focus()
                Exit Sub
            End If

            Me.dgvDetail.AllowUserToAddRows = True

            dgvDetail.Rows.Clear()
            Dim cri As String

            Dim Sql As String = "SELECT A.Dept, B.EmployeeNo, B.EmployeeName, A.DOCNO, A.RetrainFreq, A.StartDate, A.MD "
            Sql = Sql + " FROM QEa_Training_Assign AS A LEFT OUTER JOIN  QEa_Training_Person AS B ON A.EmployeeNo = B.EmployeeNo "
            Sql = Sql + " WHERE A.Dept = '" & strDeptData & "' "
            Sql = Sql + " AND A.DOCNO = '" & TxtDOCNO.Text & "'"
            Sql = Sql + " AND A.MD ='" & strMD & "'"
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
                    .Item(4, .Rows.Count - 2).Value = Mid(Dtr.Item("StartDate").ToString, 1, 10)
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                    .Item(6, .Rows.Count - 2).Value = Dtr.Item("RetrainFreq").ToString

                End With

                intNo = intNo + 1

            Next

            Me.dgvDetail.AllowUserToAddRows = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือน")
            Exit Sub
        End Try
    End Sub
    Private Sub TxtMD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtMD.SelectedIndexChanged
        Select Case TxtMD.Text
            Case "รายเดือน"
                strMD = "M"
            Case "รายวัน"
                strMD = "D"

        End Select
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

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            For Each row As DataGridViewRow In dgvDetail.Rows

                If CBool(row.Cells("Sel").Value) = True Then


                    Dim myCommand As New SqlCommand("Update QEa_Training_Assign Set RetrainFreq = @RetrainFreq " &
                                         "WHERE EmployeeNo = '" & (row.Cells("EmployeeNo").Value) & "' " &
                                         "And DOCNO ='" & (row.Cells("DOCNO").Value) & "' " &
                                         "And Dept ='" & strDeptData & "'", DB_CMD.ObjConn)
                    myCommand.Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = TxtRetrainFreq.Text
                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


                End If

            Next

            Call LoadData()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือน")
            Exit Sub
        End Try
    End Sub
End Class