Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_Assign_ReTraining

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
    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub FrmTraining_Assign_ReTraining_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        Call Grid()

        CommandType = "Addnew"

        '   Call ShowDept()
        '  Call LoadData()

        ' TxtCrseSetCode.ReadOnly = True
        TxtEmployeeNo.Text = ""
        TxtMD.Text = ""
        ' TxtMD.DropDownStyle = ComboBoxStyle.DropDownList

        '  TxtCrseSetNam.ReadOnly = True
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
            '.CellBorderStyle = DataGridViewCellBorderStyle.Raised

            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

            .GridColor = Color.LightGray
        End With



    End Sub

    Sub GetPersonName()



        Dim command As New SqlCommand("SELECT  EmployeeNo, EmployeeNo + ' : ' + EmployeeName AS EmployeeData FROM  QEa_Training_Person WHERE Dept = '" & strDeptData & "' AND MD = '" & strMD & "' and NOT (EmployeeNo IS NULL) ORDER BY EmployeeNo  ", DB_CMD.ObjConn)
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

    Private Sub TxtMD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtMD.SelectedIndexChanged
        Select Case TxtMD.Text
            Case "รายเดือน"
                strMD = "M"
            Case "รายวัน"
                strMD = "D"

        End Select

        TxtEmployeeNo.DataSource = Nothing
        dgvDetail.Rows.Clear()
        Call GetPersonName()

    End Sub

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub bntAddNew_Click(sender As Object, e As EventArgs) Handles bntAddNew.Click
        ' MsgBox(TxtEmployeeNo.SelectedValue.ToString)


        If Me.TxtEmployeeNo.Text = Nothing Then
            MsgBox("กรุณาใส่ชื่อข้อมูลให้ครบด้วย")
            Me.TxtEmployeeNo.Focus()
            Exit Sub
        End If

        If Me.TxtMD.Text = Nothing Then
            MsgBox("กรุณาใส่ชื่อข้อมูลให้ครบด้วย")
            Me.TxtMD.Focus()
            Exit Sub
        End If

        StrFunction.ReTrainAssignSel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmTraining_Assign_Select.Close()
        FrmTraining_Assign_Select.MdiParent = FrmMainMenu
        FrmTraining_Assign_Select.Show()
    End Sub

    Private Sub bntDeleteData_Click(sender As Object, e As EventArgs) Handles bntDeleteData.Click
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtEmployeeNo.SelectedValue.ToString & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEa_Training_ReTaining_Assign  WHERE EmployeeNo='" & TxtEmployeeNo.SelectedValue.ToString & "' ", DB_CMD.ObjConn)
            StrFunction.ReTrainAssignSel = 1
            Call LoadData()
            '  Call LoadDataDetail()
            ' Call ShowCourseSet()
        End If

        FrmMainMenu.PictureBox2.Enabled = True
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick

    End Sub

    Private Sub dgvDetail_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetail.CellMouseClick


    End Sub

    Private Sub TxtEmployeeNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtEmployeeNo.SelectedIndexChanged
        StrEmployeeNoAssign = TxtEmployeeNo.SelectedValue.ToString
        dgvDetail.Rows.Clear()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until 1 = StrFunction.ReTrainAssignSel

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted_1(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Call LoadData()
        '  Call LoadDataDetail()
        ' Call ShowCourseSet()
    End Sub
    Sub LoadData()
        '   Try

        Dim strYearDateFm As String = TxtYearData.Text & "-01-01"
        Dim strYearDateTo As String = TxtYearData.Text & "-12-31"

        Me.dgvDetail.AllowUserToAddRows = True

        Dim Sql As String = "SELECT A.EmployeeNo, A.DOCNO, B.DOCNAME, B.STATUS, A.DOCDEPT, A.MD, A.Dept, A.AssSeq, A.Assign, A.Trainer, A.MthdCode, A.Approve, A.StartDate, A.Remark, A.YEARDATA "
        Sql = Sql + "FROM QEa_Training_ReTaining_Assign As A LEFT OUTER JOIN QEa_CourseMaster As B On A.DOCNO = B.DOCNO "
        Sql = Sql + "GROUP BY A.EmployeeNo, A.DOCNO, B.DOCNAME, B.STATUS, A.DOCDEPT, A.MD, A.Dept, A.AssSeq, A.Assign, A.Trainer, A.MthdCode, A.Approve, A.StartDate, A.Remark, A.YEARDATA "
        Sql = Sql + "HAVING A.EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql = Sql + "AND A.Dept = '" & strDeptData & "'"
        Sql = Sql + "And CONVERT(DATE,A.StartDate  ,105) BETWEEN '" & strYearDateFm & "'  AND  '" & strYearDateTo & "' "
        Sql = Sql + "AND B.STATUS = 'A'"
        Sql = Sql + "ORDER BY A.DOCNO "
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
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                If Dtr.Item("Status").ToString = "I" Then
                    .Item(2, .Rows.Count - 2).Value = "Course ยกเลิกเเล้ว"
                Else
                    .Item(2, .Rows.Count - 2).Value = ""
                End If

                .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString

                Dim Sql2 As String = "SELECT  * From QEa_Training_Method_Assign WHERE AssignCode = '" & Dtr.Item("Assign").ToString & "' ORDER BY AssignCode"
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)

                For Each Dtr2 As DataRow In Dt2.Rows
                    .Item(4, .Rows.Count - 2).Value = Dtr2.Item("AssignName").ToString
                Next



                Dim Sql3 As String = "SELECT  * From QEa_Training_Method_Trainer WHERE TrainerCode = '" & Dtr.Item("Trainer").ToString & "' ORDER BY TrainerCode "
                Dim Dt3 As New DataTable
                Dt3 = DB_CMD.GetData_Table(Sql3, DB_CMD.ObjConn)
                For Each Dtr3 As DataRow In Dt3.Rows
                    .Item(5, .Rows.Count - 2).Value = Dtr3.Item("TrainerName").ToString
                Next


                Dim Sql1 As String = "SELECT  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                For Each Dtr1 As DataRow In Dt1.Rows
                    .Item(6, .Rows.Count - 2).Value = Dtr1.Item("MthdNam").ToString
                Next



                .Item(7, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString
                .Item(9, .Rows.Count - 2).Value = Dtr.Item("Assign").ToString
                .Item(10, .Rows.Count - 2).Value = Dtr.Item("Trainer").ToString
                .Item(11, .Rows.Count - 2).Value = Dtr.Item("MthdCode").ToString
                .Item(12, .Rows.Count - 2).Value = Mid(Dtr.Item("StartDate"), 1, 10)
                .Item(13, .Rows.Count - 2).Value = Dtr.Item("Remark").ToString

            End With

            intNo = intNo + 1

        Next
        '   dgvDetail.AutoResizeColumns()

        Me.dgvDetail.AllowUserToAddRows = False
        '   Catch ex As Exception

        '  End Try

    End Sub

    Function CheckData() As Boolean
        CheckData = True
        Try


            If Me.TxtEmployeeNo.Text = Nothing Then
                CheckData = False
                Me.TxtEmployeeNo.Focus()
                Exit Function
            End If

            If Me.TxtMD.Text = Nothing Then
                CheckData = False
                Me.TxtMD.Focus()
                Exit Function
            End If


        Catch ex As Exception

        End Try
    End Function

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        dgvDetail.Rows.Clear()
        Call LoadData()
    End Sub

    Private Sub dgvDetail_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetail.CellMouseDoubleClick
        strDocNo = Me.dgvDetail.Item(1, Me.dgvDetail.CurrentRow.Index).Value
        strDocName = Me.dgvDetail.Item(3, Me.dgvDetail.CurrentRow.Index).Value
        strDocDept = Me.dgvDetail.Item(8, Me.dgvDetail.CurrentRow.Index).Value
        strApproveName = Me.dgvDetail.Item(7, Me.dgvDetail.CurrentRow.Index).Value
        strAssignCode = Me.dgvDetail.Item(9, Me.dgvDetail.CurrentRow.Index).Value
        strTrainerCode = Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).Value
        strMthdCode = Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value
        strStartDate = Me.dgvDetail.Item(12, Me.dgvDetail.CurrentRow.Index).Value
        strRemarkAssign = Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).Value
        StrFunction.ReTrainAssignSel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try
        FrmTraining_Assign_Edit.Close()
        FrmTraining_Assign_Edit.ShowDialog()
    End Sub

    Private Sub bntPrinting_Click(sender As Object, e As EventArgs) Handles bntPrinting.Click
        strEmployeeNoRpt = TxtEmployeeNo.SelectedValue.ToString
        strDeptRpt = strDeptData

        strYearDateFm = TxtYearData.Text & "-01-01"
        strYearDateTo = TxtYearData.Text & "-12-31"



        FrmTraining_Assign_Report.Close()
        FrmTraining_Assign_Report.MdiParent = FrmMainMenu
        FrmTraining_Assign_Report.Show()
    End Sub
End Class