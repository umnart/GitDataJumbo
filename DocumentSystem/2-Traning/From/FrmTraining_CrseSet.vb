Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_CrseSet
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

    Private Sub FrmTraining_CrseSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        CommandType = "Addnew"

        '   Call ShowDept()
        ' Call LoadData()

        ' TxtCrseSetCode.ReadOnly = True
        'TxtCrseSetCode.Text = ""
        'TxtCrseSetCode.DropDownStyle = ComboBoxStyle.DropDownList

        TxtCrseSetNam1.ReadOnly = True

        '  Call ShowCourseSet()
        TxtCrseSetCode.Text = ""
        TxtCrseSetNam1.Text = ""
        dgvMain.Rows.Clear()

        ' Call LoadDataDetail()

        Call Grid()

    End Sub

    'Sub ShowCourseSet()




    '    Dim command As New SqlCommand("SELECT  DeptCodSet, CrseSetCode, CrseSetNam FROM  QEa_Training_CrseSet GROUP BY DeptCodSet, CrseSetCode, CrseSetNam HAVING DeptCodSet = '" & strDeptData & "' ORDER BY CrseSetCode  ", DB_CMD.ObjConn)
    '    Dim table As New DataTable
    '    Dim adapter As New SqlDataAdapter(command)
    '    Dim ds As New DataSet
    '    adapter.Fill(table)


    '    adapter.Fill(ds, "QEa_Training_CrseSet")
    '    If table.Rows.Count > 0 Then
    '        TxtCrseSetCode.DisplayMember = "CrseSetCode"
    '        TxtCrseSetCode.ValueMember = "CrseSetCode"
    '        TxtCrseSetCode.DataSource = ds.Tables("QEa_Training_CrseSet")

    '    End If

    '    Exit Sub


    'End Sub

    Sub Grid()

        With Me.dgvMain
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With
    End Sub

    Private Sub bntNew_Click(sender As Object, e As EventArgs) Handles bntNew.Click

    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs) Handles bntDelete.Click

    End Sub

    Sub Clear()

        TxtCrseSetCode.Text = ""
        TxtCrseSetNam1.Text = ""
        dgvMain.Rows.Clear()


    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click

    End Sub
    Sub LoadData()

        Me.dgvMain.AllowUserToAddRows = True

        Dim Sql As String = "SELECT  QEa_Training_CrseSet.CrseCode, QEa_Training_CrseSet.DeptCod, QEa_CourseMaster.DOCNAME,QEa_Training_CrseSet.CrseSetNam ,QEa_Training_CrseSet.RetrainFreq "
        Sql = Sql + "FROM  QEa_Training_CrseSet LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_CrseSet.CrseCode = QEa_CourseMaster.DOCNO "
        Sql = Sql + "WHERE QEa_Training_CrseSet.CrseSetCode = '" & TxtCrseSetCode.Text & "' "
        Sql = Sql + "AND QEa_Training_CrseSet.DeptCodSet = '" & strDeptData & "' "
        Sql = Sql + "GROUP BY QEa_Training_CrseSet.CrseCode, QEa_Training_CrseSet.DeptCod, QEa_CourseMaster.DOCNAME, QEa_Training_CrseSet.CrseSetNam,QEa_Training_CrseSet.CrseSetNam,QEa_Training_CrseSet.RetrainFreq "
        Sql = Sql + "ORDER BY dbo.QEa_Training_CrseSet.CrseCode "
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvMain.Rows.Clear()


        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows

            TxtCrseSetNam1.Text = Dtr.Item("CrseSetNam").ToString

            With dgvMain
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("CrseCode").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("DeptCod").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("RetrainFreq").ToString

            End With

            intNo = intNo + 1

        Next

        Me.dgvMain.AllowUserToAddRows = False
    End Sub

    'Sub LoadDataDetail()


    '    Dim Sql As String = " SELECT  DeptCodSet, CrseSetCode, CrseSetNam "
    '    Sql = Sql + " FROM  QEa_Training_CrseSet "
    '    Sql = Sql + " GROUP BY DeptCodSet, CrseSetCode, CrseSetNam"
    '    Sql = Sql + " HAVING DeptCodSet = '" & strDeptData & "' "
    '    Sql = Sql + " ORDER BY CrseSetCode "
    '    Dim Dt As New DataTable
    '    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
    '    dgvDetail.Rows.Clear()

    '    Dim intNoDetail As Integer = 1
    '    For Each Dtr As DataRow In Dt.Rows
    '        With dgvDetail
    '            ' intM = 1
    '            'intW = 1

    '            Application.DoEvents()
    '            .Rows.Add()
    '            .Item(0, .Rows.Count - 2).Value = intNoDetail
    '            .Item(1, .Rows.Count - 2).Value = Dtr.Item("CrseSetCode").ToString
    '            .Item(2, .Rows.Count - 2).Value = Dtr.Item("CrseSetNam").ToString
    '            .Item(3, .Rows.Count - 2).Value = Dtr.Item("DeptCodSet").ToString

    '        End With

    '        intNoDetail = intNoDetail + 1

    '    Next



    'End Sub

    Function CheckData() As Boolean
        CheckData = True
        Try


            If Me.TxtCrseSetCode.Text = Nothing Then
                CheckData = False
                Me.TxtCrseSetCode.Focus()
                Exit Function
            End If

            If Me.TxtCrseSetNam1.Text = Nothing Then
                CheckData = False
                Me.TxtCrseSetNam1.Focus()
                Exit Function
            End If


        Catch ex As Exception

        End Try
    End Function

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until 1 = StrFunction.CourseSet

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted_1(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Call LoadData()
        '  Call LoadDataDetail()
        ' Call ShowCourseSet()
    End Sub

    Private Sub TxtCrseSetCode_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs)
        Call LoadData()
    End Sub

    Private Sub bntSelect_Click(sender As Object, e As EventArgs)


    End Sub

    'Private Sub TxtCrseSetCode_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    dgvMain.Rows.Clear()

    '    Dim Sql As String = " SELECT  DeptCodSet, CrseSetCode, CrseSetNam"
    '    Sql = Sql + " FROM  QEa_Training_CrseSet "
    '    Sql = Sql + " GROUP BY DeptCodSet, CrseSetCode, CrseSetNam"
    '    Sql = Sql + " HAVING DeptCodSet = '" & strDeptData & "' "
    '    Sql = Sql + " AND CrseSetCode ='" & TxtCrseSetCode.Text & "'"
    '    Sql = Sql + " ORDER BY CrseSetCode "
    '    Dim Dt As New DataTable
    '    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
    '    dgvDetail.Rows.Clear()

    '    Dim intNoDetail As Integer = 1
    '    For Each Dtr As DataRow In Dt.Rows

    '        TxtCrseSetNam1.Text = Dtr.Item("CrseSetNam").ToString

    '    Next


    '    Call LoadData()

    'End Sub

    Private Sub TxtCrseSetNam1_Click(sender As Object, e As EventArgs) Handles TxtCrseSetNam1.Click

    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        dgvMain.Rows.Clear()
        TxtCrseSetCode.Text = ""
        TxtCrseSetNam1.Text = ""
    End Sub

    Private Sub dgvDetail_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)


        'TxtCrseSetCode.Text = Me.dgvDetail.Item(1, Me.dgvDetail.CurrentRow.Index).Value.ToString()
        'TxtCrseSetNam1.Text = Me.dgvDetail.Item(2, Me.dgvDetail.CurrentRow.Index).Value.ToString()
        'TxtCrseSetCode.Enabled = True
        'TxtCrseSetNam1.Enabled = True

        'TxtCrseSetCode.ReadOnly = False
        'TxtCrseSetNam1.ReadOnly = False

        'Call LoadData()
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntAddNew_Click(sender As Object, e As EventArgs) Handles bntAddNew.Click
        CommandType = "Addnew"



        '  TxtCrseSetCode.DropDownStyle = ComboBoxStyle.DropDown
        TxtCrseSetCode.ReadOnly = False
        TxtCrseSetNam1.ReadOnly = False

        TxtCrseSetCode.Enabled = True
        TxtCrseSetNam1.Enabled = True
        Call Clear()
        TxtCrseSetCode.Focus()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntDeleteData_Click(sender As Object, e As EventArgs) Handles bntDeleteData.Click
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtCrseSetCode.Text & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEa_Training_CrseSet  WHERE CrseSetCode='" & TxtCrseSetCode.Text & "' ", DB_CMD.ObjConn)
            StrFunction.process = 1
            Call LoadData()
            'Call LoadDataDetail()
            ' Call ShowCourseSet()
        End If

        Call Clear()

        FrmMainMenu.PictureBox2.Enabled = True



    End Sub

    Private Sub bntSelectData_Click(sender As Object, e As EventArgs) Handles bntSelectData.Click
        If Me.TxtCrseSetCode.Text = Nothing Then
            MsgBox("กรุณาใส่ชื่อข้อมูลให้ครบด้วย")
            Me.TxtCrseSetCode.Focus()
            Exit Sub
        End If

        If Me.TxtCrseSetNam1.Text = Nothing Then
            MsgBox("กรุณาใส่ชื่อข้อมูลให้ครบด้วย")
            Me.TxtCrseSetNam1.Focus()
            Exit Sub
        End If

        StrFunction.CourseSet = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmTraining_CrseSet_Select.Close()
        FrmTraining_CrseSet_Select.MdiParent = FrmMainMenu
        FrmTraining_CrseSet_Select.Show()
    End Sub

    Private Sub bntSaveData_Click(sender As Object, e As EventArgs) Handles bntSaveData.Click
        '  Try
        'ตรวจสอบ ข้อมูลก่อนบันทึก
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            CmdExcute("DELETE FROM QEa_Training_CrseSet  WHERE CrseSetCode = '" & TxtCrseSetCode.Text & "' AND DeptCodSet ='" & strDeptData & "' ", DB_CMD.ObjConn)


            With QEa_Training_CrseSet
                For Each row As DataGridViewRow In dgvMain.Rows

                    .CrseSetCode = TxtCrseSetCode.Text
                    .CrseSetNam = TxtCrseSetNam1.Text
                    .DeptCodSet = strDeptData
                    .RetrainFreq = CStr(row.Cells("RetrainFreq").Value)



                    If CStr(row.Cells("CrseCode").Value) = Nothing Then
                        GoTo NEXTSTEP
                    End If
                    .CrseCode = CStr(row.Cells("CrseCode").Value)
                    .DeptCod = CStr(row.Cells("DeptCod").Value)


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

        'Call LoadData()
        Call Clear()
        TxtCrseSetCode.ReadOnly = True
        TxtCrseSetNam1.Enabled = False
        FrmMainMenu.PictureBox2.Enabled = True
        'Me.Close()

        ' Catch ex As Exception
        ' End Try
    End Sub

    Private Sub dgvMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Do Until 1 = StrFunction.CourseSetFind

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Call LoadData()
    End Sub

    Private Sub bntFind_Click_1(sender As Object, e As EventArgs) Handles bntFind.Click


        dgvMain.Rows.Clear()

        TxtCrseSetCode.Text = ""
        TxtCrseSetNam1.Text = ""

        StrFunction.CourseSetFind = 2
        Try
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmTraining_CrseSet_Find.Close()
        ' FrmTraining_CrseSet_Find.MdiParent = FrmMainMenu
        FrmTraining_CrseSet_Find.ShowDialog()
    End Sub

    Private Sub TxtCrseSetCode_TextChanged_1(sender As Object, e As EventArgs) Handles TxtCrseSetCode.TextChanged
        TxtCrseSetNam1.Text = ""
        Call LoadData()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class