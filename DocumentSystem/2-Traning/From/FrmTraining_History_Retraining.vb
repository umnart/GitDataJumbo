Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Reflection
Public Class FrmTraining_History_Retraining
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
    Private rowIndex As Integer

    Dim strDOCNODel As String
    Dim strEmployeeNoDel As String
    Dim strREVNODel As String
    Dim strNoReTrainingDel As String
    Dim strTrnnDateDel As String
    Private Sub FrmTraining_History_Retraining_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.LightGray
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



    Private Sub bntSelect_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtMD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtMD.SelectedIndexChanged
        Select Case TxtMD.Text
            Case "รายเดือน"
                strMD = "M"
            Case "รายวัน"
                strMD = "D"

        End Select

        Call LoadClearDataGrid()
    End Sub
    Sub GetPersonName()
        Dim strYearDateFm As String = TxtYearData.Text & "-01-01"
        Dim strYearDateTo As String = TxtYearData.Text & "-12-31"
        Dim command As New SqlCommand("SELECT  A.EmployeeNo, A.EmployeeNo + ' : ' + B.EmployeeName AS EmployeeData " &
                                       " FROM QEa_Training_History_ReTraining AS A LEFT OUTER JOIN QEa_Training_Person AS B ON A.EmployeeNo = B.EmployeeNo " &
                                       " WHERE A.Dept = '" & strDeptData & "' AND A.MD = '" & strMD & "' " &
                                       " AND CONVERT(DATE,TrnnDate  ,105) BETWEEN '" & strYearDateFm & "'  AND  '" & strYearDateTo & "' " &
                                       " GROUP BY A.EmployeeNo, A.EmployeeNo + ' : ' + B.EmployeeName " &
                                       " ORDER BY A.EmployeeNo  ", DB_CMD.ObjConn)

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
            TxtEmployeeNo.DisplayMember = "EmployeeData"
            TxtEmployeeNo.ValueMember = "EmployeeNo"
            TxtEmployeeNo.DataSource = ds.Tables("QEa_Training_Person")

        End If

        Exit Sub
    End Sub

    Sub GetPersonNameClear()
        TxtEmployeeNo.DataSource = Nothing
        'Dim strYearDateFm As String = TxtYearData.Text & "-01-01"
        'Dim strYearDateTo As String = TxtYearData.Text & "-12-31"
        'Dim command As New SqlCommand("SELECT  A.EmployeeNo, A.EmployeeNo + ' : ' + B.EmployeeName AS EmployeeData " &
        '                               " FROM QEa_Training_History_ReTraining AS A LEFT OUTER JOIN QEa_Training_Person AS B ON A.EmployeeNo = B.EmployeeNo " &
        '                               " WHERE A.Dept = 'XXXXX' " &
        '                              " GROUP BY A.EmployeeNo, A.EmployeeNo + ' : ' + B.EmployeeName " &
        '                               " ORDER BY A.EmployeeNo  ", DB_CMD.ObjConn)

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

        Exit Sub
    End Sub

    Sub LoadClearDataGrid()
        Dim Sql As String = "Select ROW_NUMBER() OVER(ORDER BY A.DOCNO) AS No , A.DOCNO, A.REVNO, A.EFFDATE, B.DOCNAME, A.EmployeeNo, C.EmployeeName, D.MthdNam, A.DOCDEPT, A.NoReTraining, A.TrnnDate, A.Result, A.Approve, A.Remark, A.MthdCode, A.MD, A.Dept "
        Sql = Sql + " FROM QEa_Training_History_ReTraining AS A LEFT OUTER JOIN   QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO LEFT OUTER JOIN QEa_Training_Person AS C ON A.EmployeeNo = C.EmployeeNo LEFT OUTER JOIN QEa_Training_Method AS D ON A.MthdCode = D.MthdCode "
        Sql = Sql + " GROUP BY A.DOCNO, A.REVNO, A.EFFDATE, B.DOCNAME, A.EmployeeNo, C.EmployeeName, D.MthdNam, A.DOCDEPT, A.NoReTraining, A.TrnnDate, A.Result, A.Approve, A.Remark, A.MthdCode, A.MD, A.Dept "
        Sql = Sql + " HAVING  A.MD  ='XXX' "
        Sql = Sql + " ORDER BY A.DOCNO, A.REVNO, A.TrnnDate, A.NoReTraining "

        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt
        ' dgvDetail.Columns(11).Visible = False
        'dgvDetail.Columns(5).Visible = False
        'dgvDetail.Columns(7).Visible = False
        ' dgvDetail.Columns(14).Visible = False
        ' dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(17).Visible = False
        dgvDetail.Columns(18).Visible = False
    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Call LoadClearDataGrid()
        Call LoadData()

    End Sub

    Sub LoadData()

        Dim strYearDateFm As String = TxtYearData.Text & "-01-01"
        Dim strYearDateTo As String = TxtYearData.Text & "-12-31"

        Try

            Dim cri As String = ""

            Select Case TxtSelectData.Text
                Case "ดูข้อมูลทั้งหมด"
                    cri = " HAVING  A.MD  ='" & strMD & "' AND A.Dept  ='" & strDeptData & "' AND CONVERT(DATE,TrnnDate  ,105) BETWEEN '" & strYearDateFm & "'  AND  '" & strYearDateTo & "' "
                Case "ดูข้อมูลเฉพาะพนักงาน"
                    cri = " HAVING  A.MD  ='" & strMD & "' AND A.Dept  ='" & strDeptData & "' AND CONVERT(DATE,TrnnDate  ,105) BETWEEN '" & strYearDateFm & "'  AND  '" & strYearDateTo & "' AND A.EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "

            End Select




            Dim Sql As String = "Select ROW_NUMBER() OVER(ORDER BY A.DOCNO) AS No , A.DOCNO, A.REVNO, A.EFFDATE, B.DOCNAME, A.EmployeeNo, C.EmployeeName, D.MthdNam, A.DOCDEPT, A.NoReTraining, A.TrnnDate, A.Result, A.Approve, A.Remark, A.MthdCode, A.MD, A.Dept "
            Sql = Sql + " FROM QEa_Training_History_ReTraining AS A LEFT OUTER JOIN   QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO LEFT OUTER JOIN QEa_Training_Person AS C ON A.EmployeeNo = C.EmployeeNo LEFT OUTER JOIN QEa_Training_Method AS D ON A.MthdCode = D.MthdCode "
            Sql = Sql + " GROUP BY A.DOCNO, A.REVNO, A.EFFDATE, B.DOCNAME, A.EmployeeNo, C.EmployeeName, D.MthdNam, A.DOCDEPT, A.NoReTraining, A.TrnnDate, A.Result, A.Approve, A.Remark, A.MthdCode, A.MD, A.Dept "
            Sql = Sql + cri
            Sql = Sql + " ORDER BY A.DOCNO, A.REVNO, A.TrnnDate, A.NoReTraining "

            Dim Dt As New DataTable
            Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
            Dim Da = New SqlDataAdapter(Cmd)
            Da.Fill(Dt)
            Da.Dispose()
            dgvDetail.DataSource = Dt
            ' dgvDetail.Columns(11).Visible = False
            'dgvDetail.Columns(5).Visible = False
            'dgvDetail.Columns(7).Visible = False
            ' dgvDetail.Columns(14).Visible = False
            ' dgvDetail.Columns(15).Visible = False
            dgvDetail.Columns(17).Visible = False
            dgvDetail.Columns(18).Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until 1 = StrFunction.ReTraining

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted_1(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Call LoadClearDataGrid()
        Call LoadData()
        '  Call LoadDataDetail()
        ' Call ShowCourseSet()
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick

    End Sub

    Private Sub dgvDetail_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetail.CellMouseUp
        Try


            If e.Button = MouseButtons.Right Then


                Me.dgvDetail.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex

                strDOCNODel = ""
                strEmployeeNoDel = ""
                strREVNODel = ""
                strNoReTrainingDel = ""
                strTrnnDateDel = ""
                strDOCNODel = dgvDetail.Rows(e.RowIndex).Cells(3).Value().ToString.Trim()
                strEmployeeNoDel = dgvDetail.Rows(e.RowIndex).Cells(7).Value().ToString.Trim()
                ' = Me.dgvDATA.Item(9, Me.dgvDATA.CurrentRow.Index).Value
                strREVNODel = dgvDetail.Rows(e.RowIndex).Cells(4).Value().ToString.Trim()
                strNoReTrainingDel = dgvDetail.Rows(e.RowIndex).Cells(11).Value().ToString.Trim()
                strTrnnDateDel = Mid(dgvDetail.Rows(e.RowIndex).Cells(12).Value().ToString.Trim(), 1, 10)

                TxtTrnnDate.Text = Mid(dgvDetail.Rows(e.RowIndex).Cells(12).Value().ToString.Trim(), 1, 10)

                Me.MetroContextMenu1.Show(Me.dgvDetail, e.Location)
                MetroContextMenu1.Show(Cursor.Position)


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuDelete_Click(sender As Object, e As EventArgs) Handles menuDelete.Click
        Dim Sms As String = "คุณต้องการลบข้อมูล    " & strEmployeeNoDel & "    ออก จากรายการ หรือไม่?"
        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        CmdExcute("DELETE FROM QEa_Training_History_ReTraining  WHERE EmployeeNo='" & strEmployeeNoDel & "' AND DOCNO ='" & strDOCNODel & "' AND REVNO ='" & strREVNODel & "' AND NoReTraining ='" & strNoReTrainingDel & "' AND DEPT ='" & strDeptData & "' ", DB_CMD.ObjConn)
        ' StrFunction.AssignSel = 1
        Call LoadClearDataGrid()
        Call LoadData()
    End Sub

    Private Sub bntDeleteAll_Click(sender As Object, e As EventArgs) Handles bntDeleteAll.Click
        Dim Sms As String = "คุณต้องการลบข้อมูล    " & strDOCNODel & "    ออก จากรายการ หรือไม่?"
        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        CmdExcute("DELETE FROM QEa_Training_History_ReTraining  WHERE DOCNO ='" & strDOCNODel & "' AND REVNO ='" & strREVNODel & "' AND TrnnDate ='" & TxtTrnnDate.Text & "' AND DEPT ='" & strDeptData & "' ", DB_CMD.ObjConn)
        ' StrFunction.AssignSel = 1
        Call LoadClearDataGrid()
        Call LoadData()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub bntSaveData_Click(sender As Object, e As EventArgs) Handles bntSaveData.Click

        If Me.TxtMD.Text = Nothing Then
            MsgBox("กรุณาใส่ชื่อข้อมูลให้ครบด้วย")
            Me.TxtMD.Focus()
            Exit Sub
        End If

        StrFunction.ReTraining = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmTraining_History_Retraining_Select.Close()
        ' FrmTraining_History_Retraining_Select.MdiParent = FrmMainMenu
        FrmTraining_History_Retraining_Select.ShowDialog()
    End Sub

    Private Sub TxtSelectData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSelectData.SelectedIndexChanged

        Select Case TxtSelectData.Text
            Case "ดูข้อมูลทั้งหมด"
                Call GetPersonNameClear()
                Call LoadClearDataGrid()

            Case "ดูข้อมูลเฉพาะพนักงาน"
                Call GetPersonName()

        End Select
    End Sub

    Private Sub TxtEmployeeNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtEmployeeNo.SelectedIndexChanged
        Call LoadClearDataGrid()
    End Sub

    Private Sub TxtYearData_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntPrinting_Click(sender As Object, e As EventArgs) Handles bntPrinting.Click
        Try

            If TxtEmployeeNo.Text = "" Then
                MsgBox("ต้องเลือกรายชื่อพนักงานก่อน")
                Exit Sub
            End If

            strEmployeeNoRpt = TxtEmployeeNo.SelectedValue.ToString
            strDeptRpt = strDeptData

            strYearDateFm = TxtYearData.Text & "-01-01"
            strYearDateTo = TxtYearData.Text & "-12-31"



            FrmTraining_History_Retraining_Report.Close()
            FrmTraining_History_Retraining_Report.MdiParent = FrmMainMenu
            FrmTraining_History_Retraining_Report.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtCrseSetCode_TextChanged(sender As Object, e As EventArgs) Handles TxtYearData.TextChanged

    End Sub
End Class