Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.ComponentModel

Public Class FrmTraining_Assign
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

    Private Sub FrmTraining_Assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub TxtMD_SelectedIndexChanged(sender As Object, e As EventArgs)
        Call GetPersonName()
    End Sub

    Private Sub TxtMD_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles TxtMD.SelectedIndexChanged

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

    Private Sub bntSelect_Click(sender As Object, e As EventArgs)
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

        StrFunction.AssignSel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmTraining_Assign_Select.Close()
        FrmTraining_Assign_Select.MdiParent = FrmMainMenu
        FrmTraining_Assign_Select.Show()
    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs)
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtEmployeeNo.SelectedValue.ToString & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEa_Training_Assign  WHERE EmployeeNo='" & TxtEmployeeNo.SelectedValue.ToString & "' ", DB_CMD.ObjConn)
            StrFunction.AssignSel = 1
            Call LoadData()
            '  Call LoadDataDetail()
            ' Call ShowCourseSet()
        End If

        FrmMainMenu.PictureBox2.Enabled = True
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs)
        '  Try
        'ตรวจสอบ ข้อมูลก่อนบันทึก
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            CmdExcute("DELETE FROM QEa_Training_Assign  WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' ", DB_CMD.ObjConn)


            With QEa_Training_Assign
                For Each row As DataGridViewRow In dgvDetail.Rows


                    .EmployeeNo = TxtEmployeeNo.SelectedValue.ToString
                    .DOCNO = CStr(row.Cells("DOCNO").Value)
                    .DOCDEPT = CStr(row.Cells("DOCDEPT").Value)
                    .MD = strMD
                    .Dept = strDeptData
                    '.AssSeq = CStr(row.Cells("AssSeq").Value)
                    .Assign = CStr(row.Cells("AssignCode").Value)
                    .Trainer = CStr(row.Cells("TrainerCode").Value)
                    .MthdCode = CStr(row.Cells("MthdCode").Value)
                    .Approve = CStr(row.Cells("Approve").Value)
                    .StartDate = CStr(row.Cells("StartDate").Value)
                    .Remark = CStr(row.Cells("Remark").Value)
                    CommandType = "Addnew"
                    Dim Sql As String = Nothing
                    Select Case CommandType
                        Case "Addnew"
                            Sql = .SqlCommandInsert
                        Case "Edit"
                            Sql = .SqlCommandUpdate
                    End Select
                    If CmdExcute(Sql, DB_CMD.ObjConn) = True Then
                        ' MsgBox("บันทึกข้อมูลสำเร็จ")
                    Else
                        MsgBox("ไม่สามารถบันทึกข้อมูลได้")
                        Exit Sub
                    End If

NEXTSTEP:
                Next
            End With

        End If



        '    StrFunction.process = 1

        Call LoadData()

        ' Call Clear()
        TxtEmployeeNo.Enabled = False
        TxtMD.Enabled = False

        '  FrmMainMenu.PictureBox2.Enabled = True
        'Me.Close()

        ' Catch ex As Exception
        ' End Try
    End Sub

    Sub LoadData()
        Try
            'Sql = Sql + "AND QEa_CourseMaster.STATUS='A'"
            Me.dgvDetail.AllowUserToAddRows = True

            Dim Sql As String = "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_CourseMaster.STATUS, QEa_Training_Assign.DOCDEPT, "
            Sql = Sql + " QEa_Training_Assign.MD, QEa_Training_Assign.Dept, QEa_Training_Assign.AssSeq, QEa_Training_Assign.Assign, QEa_Training_Assign.Trainer, QEa_Training_Assign.MthdCode, "
            Sql = Sql + "QEa_Training_Assign.Approve,QEa_Training_Assign.StartDate ,QEa_Training_Assign.Remark,QEa_Training_Assign.RetrainFreq "
            Sql = Sql + "From QEa_Training_Assign LEFT OUTER Join QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            Sql = Sql + "Group By QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_CourseMaster.STATUS, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MD, "
            Sql = Sql + "QEa_Training_Assign.Dept, QEa_Training_Assign.AssSeq, QEa_Training_Assign.Assign, QEa_Training_Assign.Trainer, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve,QEa_Training_Assign.StartDate ,QEa_Training_Assign.Remark,QEa_Training_Assign.RetrainFreq  "
            Sql = Sql + "HAVING QEa_Training_Assign.EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql = Sql + "AND QEa_Training_Assign.Dept = '" & strDeptData & "'"
            Sql = Sql + "ORDER BY QEa_Training_Assign.DOCNO"
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
                    .Item(14, .Rows.Count - 2).Value = Dtr.Item("RetrainFreq").ToString

                End With

                intNo = intNo + 1

            Next
            '   dgvDetail.AutoResizeColumns()

            Me.dgvDetail.AllowUserToAddRows = False
        Catch ex As Exception

        End Try

    End Sub

    Sub LoaddataMthdCode()



    End Sub

    Sub LoaddataAssignCode()



    End Sub

    Sub LoaddataTrainerCode()



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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until 1 = StrFunction.AssignSel

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted_1(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Call LoadData()
        '  Call LoadDataDetail()
        ' Call ShowCourseSet()


    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        dgvDetail.Rows.Clear()
        Call LoadData()
    End Sub

    Private Sub TxtEmployeeNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtEmployeeNo.SelectedIndexChanged
        Try


            Call SelectStartDate()
            StrEmployeeNoAssign = TxtEmployeeNo.SelectedValue.ToString

            dgvDetail.Rows.Clear()

        Catch ex As Exception

        End Try
    End Sub
    Sub SelectStartDate()
        TxtStartDate.Text = ""
        Try


            Dim Sql As String = "SELECT  EmployeeNo, StartDate  "
            Sql = Sql + "From QEa_Training_Person  "

            Sql = Sql + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql = Sql + "ORDER BY EmployeeNo"
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                TxtStartDate.Text = Mid(Dtr.Item("StartDate"), 1, 10)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick

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
        strRetrainFreqAssign = Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value
        StrFunction.AssignSel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        StrFunction.AssignDelete = 2
        Try
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception

        End Try




        FrmTraining_Assign_Edit.Close()
        FrmTraining_Assign_Edit.ShowDialog()
    End Sub

    Private Sub bntCopy_Click(sender As Object, e As EventArgs)
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

        StrFunction.AssignSel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmTraining_Assign_Copy.Close()
        FrmTraining_Assign_Copy.ShowDialog()
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

        StrFunction.AssignSel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmTraining_Assign_Select.Close()
        FrmTraining_Assign_Select.MdiParent = FrmMainMenu
        FrmTraining_Assign_Select.Show()
    End Sub

    Private Sub bntSaveData_Click(sender As Object, e As EventArgs) Handles bntSaveData.Click
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

        StrFunction.AssignSel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmTraining_Assign_Copy.Close()
        FrmTraining_Assign_Copy.ShowDialog()
    End Sub

    Private Sub bntDeleteData_Click(sender As Object, e As EventArgs) Handles bntDeleteData.Click
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtEmployeeNo.SelectedValue.ToString & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEa_Training_Assign  WHERE EmployeeNo='" & TxtEmployeeNo.SelectedValue.ToString & "' ", DB_CMD.ObjConn)
            StrFunction.AssignSel = 1
            Call LoadData()
            '  Call LoadDataDetail()
            ' Call ShowCourseSet()
        End If

        FrmMainMenu.PictureBox2.Enabled = True
    End Sub

    Private Sub bntPrinting_Click(sender As Object, e As EventArgs) Handles bntPrinting.Click
        Try


            strEmployeeNoRpt = TxtEmployeeNo.SelectedValue.ToString
            strDeptRpt = strDeptData

            FrmTraining_Assign_Report.Close()
            FrmTraining_Assign_Report.MdiParent = FrmMainMenu
            FrmTraining_Assign_Report.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub bntDeleteCancel_Click(sender As Object, e As EventArgs) Handles bntDeleteCancel.Click
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล Course ยกเลิกเเล้ว  " & TxtEmployeeNo.SelectedValue.ToString & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub


            For Each row As DataGridViewRow In dgvDetail.Rows

                If CStr(row.Cells("Status").Value) = "Course ยกเลิกเเล้ว" Then

                    CmdExcute("DELETE FROM QEa_Training_Assign  WHERE EmployeeNo='" & TxtEmployeeNo.SelectedValue.ToString & "' AND DOCNO= '" & CStr(row.Cells("DOCNO").Value) & "' AND MD= '" & strMD & "' ", DB_CMD.ObjConn)
                    StrFunction.AssignSel = 1

                    '  Call LoadDataDetail()
                    ' Call ShowCourseSet()
                End If




            Next

        End If


        Call LoadData()
        FrmMainMenu.PictureBox2.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Do Until 1 = StrFunction.AssignDelete

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If dgvDetail.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            dgvDetail.Rows.Remove(dgvDetail.SelectedRows(0))
            '.dgvDetail.CurrentRow.Index).Value
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
    End Sub
End Class