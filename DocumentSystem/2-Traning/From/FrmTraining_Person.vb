Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_Person
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

    Private Sub FrmTraining_Person_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        CommandType = "Addnew"

        If strDeptData = "SD" Or strDeptData = "HRGA" Then
            TxtFindData.Text = ""
            cboBranch.Enabled = True
            TxtFindData.Enabled = True
        Else
            TxtFindData.Text = strDeptData
            TxtFindData.Enabled = False
            cboBranch.Enabled = False
        End If
        '   Call ShowDept()
        cboBranch.Text = "Dept"

        Call LoadData()
        Call LoadSection()

        TxtSection.Text = ""

        TxtDept.Enabled = False
        TxtBranch.Enabled = False
        TxtEmployeeNo.Enabled = False
        txtEmployeeName1.Enabled = False
        TxtLavel.Enabled = False
        TxtStartDate.Enabled = False

        Call Grid()
    End Sub


    Sub LoadSection()


        Dim command As New SqlCommand("SELECT Section From dbo.QEa_Training_Person  Group By Section Order By Section  ", DB_CMD.ObjConn)
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

    Sub Grid()

        With Me.grdData
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With
    End Sub
    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    'Sub ShowDept()




    '    Dim command As New SqlCommand("Select * FROM QEm_Dept ORDER BY DeptCod ", DB_CMD.ObjConn)
    '    Dim table As New DataTable
    '    Dim adapter As New SqlDataAdapter(command)
    '    Dim ds As New DataSet
    '    adapter.Fill(table)


    '    adapter.Fill(ds, "QEm_Dept")
    '    If table.Rows.Count > 0 Then
    '        MetroComboBox1.DisplayMember = "DeptCod"
    '        MetroComboBox1.ValueMember = "DeptCod"
    '        MetroComboBox1.DataSource = ds.Tables("QEm_Dept")
    '    End If


    '    Exit Sub


    'End Sub

    Private Sub bntNew_Click(sender As Object, e As EventArgs) Handles bntNew.Click
        CommandType = "Addnew"

        Call Clear()

        TxtDept.Enabled = True
        TxtSection.Enabled = True
        TxtBranch.Enabled = True
        TxtEmployeeNo.Enabled = True
        txtEmployeeName1.Enabled = True
        TxtLavel.Enabled = True
        TxtStartDate.Enabled = True

        TxtEmployeeNo.Focus()
    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs) Handles bntDelete.Click
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtEmployeeNo.Text & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEa_Training_Person  WHERE EmployeeNo='" & TxtEmployeeNo.Text & "' ", DB_CMD.ObjConn)
            StrFunction.process = 1
            Call LoadData()
        End If

        FrmMainMenu.PictureBox2.Enabled = True

    End Sub

    Sub Clear()

        TxtEmployeeNo.Text = ""
        txtEmployeeName1.Text = ""
        ' TxtEmployeePass.Text = ""
        TxtDept.Text = ""
        TxtSection.Text = ""
        TxtBranch.Text = ""
        TxtLavel.Text = ""
        TxtStartDate.Text = ""
        TxtFindData.Text = ""

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        '  Try
        'ตรวจสอบ ข้อมูลก่อนบันทึก

        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub

        Else

            CmdExcute("DELETE FROM QEa_Training_Person  WHERE EmployeeNo = '" & TxtEmployeeNo.Text & "' ", DB_CMD.ObjConn)


            With QEa_Training_Person

                .EmployeeNo = TxtEmployeeNo.Text
                .EmployeeName = txtEmployeeName1.Text
                .Dept = TxtDept.Text
                .Section = TxtSection.Text
                .Branch = TxtBranch.Text
                .Lavel = TxtLavel.Text
                .StartDate = TxtStartDate.Text
                .MD = TxtMD.Text
                CommandType = "Addnew"
                Dim Sql As String = Nothing
                Select Case CommandType
                    Case "Addnew"
                        Sql = .SqlCommandInsert
                    Case "Edit"
                        Sql = .SqlCommandUpdate
                End Select
                If CmdExcute(Sql, DB_CMD.ObjConn) = True Then

                    MsgBox("บันทึกข้อมูลสำเร็จ")

                Else
                    MsgBox("ไม่สามารถบันทึกข้อมูลได้")
                    Exit Sub
                End If
            End With
        End If

        '    StrFunction.process = 1

        Call LoadData()
        Call LoadSection()

        TxtSection.Text = ""

        Call Clear()
        TxtDept.Enabled = False
        TxtSection.Enabled = False
        TxtBranch.Enabled = False
        TxtEmployeeNo.Enabled = False
        txtEmployeeName1.Enabled = False

        TxtLavel.Enabled = False
        TxtStartDate.Enabled = False
        TxtMD.Enabled = False
        ' TxtFindData.Text = ""

        FrmMainMenu.PictureBox2.Enabled = True
        'Me.Close()

        ' Catch ex As Exception
        ' End Try

    End Sub

    Sub LoadData()


        Dim Sql As String = "Select * from QEa_Training_Person "
        Sql = Sql + "WHERE Dept  = '" & TxtFindData.Text & "' "
        Sql = Sql + " Order by Branch,Dept,EmployeeNo asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        grdData.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With grdData
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("Section").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
                .Item(7, .Rows.Count - 2).Value = Mid(Dtr.Item("StartDate").ToString, 1, 10)
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("MD").ToString


            End With

            intNo = intNo + 1

        Next

        ' TxtFindData.Text = ""
    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdData.CellMouseDoubleClick

    End Sub

    Function CheckData() As Boolean
        CheckData = True
        Try


            If Me.TxtDept.Text = Nothing Then
                CheckData = False
                Me.TxtDept.Focus()
                Exit Function
            End If


            'If Me.TxtSection.Text = Nothing Then
            '    CheckData = False
            '    Me.TxtSection.Focus()
            '    Exit Function
            'End If

            If Me.TxtBranch.Text = Nothing Then
                CheckData = False
                Me.TxtBranch.Focus()
                Exit Function
            End If
            If Me.TxtEmployeeNo.Text = Nothing Then
                CheckData = False
                Me.TxtEmployeeNo.Focus()
                Exit Function
            End If
            If Me.txtEmployeeName1.Text = Nothing Then
                CheckData = False
                Me.txtEmployeeName1.Focus()
                Exit Function
            End If

            If Me.TxtLavel.Text = Nothing Then
                CheckData = False
                Me.TxtLavel.Focus()
                Exit Function
            End If


        Catch ex As Exception

        End Try
    End Function

    Private Sub bntSelectEm_Click(sender As Object, e As EventArgs) Handles bntSelectEm.Click
        Call Clear()
        StrFunction.ImportExcel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        FrmImportExcel.Close()
        FrmImportExcel.MdiParent = FrmMainMenu
        FrmImportExcel.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until 1 = StrFunction.ImportExcel

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted_1(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Call LoadData()
    End Sub

    Private Sub grdData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdData.CellMouseClick
        CommandType = "Edit"

        TxtDept.Enabled = True
        TxtSection.Enabled = True
        TxtBranch.Enabled = True
        TxtEmployeeNo.Enabled = True
        txtEmployeeName1.Enabled = True

        TxtLavel.Enabled = True
        TxtStartDate.Enabled = True
        TxtMD.Enabled = True
        TxtDept.Text = ""


        TxtEmployeeNo.Text = Me.grdData.Item(1, Me.grdData.CurrentRow.Index).Value
        txtEmployeeName1.Text = Me.grdData.Item(2, Me.grdData.CurrentRow.Index).Value


        TxtDept.Text = Me.grdData.Item(3, Me.grdData.CurrentRow.Index).Value
        TxtSection.Text = Me.grdData.Item(4, Me.grdData.CurrentRow.Index).Value
        TxtBranch.Text = Me.grdData.Item(5, Me.grdData.CurrentRow.Index).Value

        TxtLavel.Text = Me.grdData.Item(6, Me.grdData.CurrentRow.Index).Value
        TxtStartDate.Text = Me.grdData.Item(7, Me.grdData.CurrentRow.Index).Value
        TxtMD.Text = Me.grdData.Item(8, Me.grdData.CurrentRow.Index).Value
    End Sub

    Private Sub TxtFindData_Click(sender As Object, e As EventArgs) Handles TxtFindData.Click

    End Sub

    Private Sub TxtFindData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFindData.KeyPress
        If e.KeyChar = Chr(13) Then
            strCri = "WHERE Branch <> "" "

            If cboBranch.Text = "" Then
                strCri = "WHERE Branch  Like <> "" "
            End If

            If cboBranch.Text = "Employee No" Then
                strCri = "WHERE EmployeeNo  Like '%" & TxtFindData.Text & "%' "
            End If

            If cboBranch.Text = "Employee Name" Then
                strCri = "WHERE EmployeeName  = '" & TxtFindData.Text & "' "
            End If

            If cboBranch.Text = "Branch" Then
                strCri = "WHERE Branch  = '" & TxtFindData.Text & "' "
            End If

            If cboBranch.Text = "Dept" Then
                strCri = "WHERE Dept  = '" & TxtFindData.Text & "' "
            End If

            If cboBranch.Text = "Level" Then
                strCri = "WHERE Lavel  = '" & TxtFindData.Text & "' "
            End If

            Dim Sql As String = "Select * from QEa_Training_Person "
            Sql = Sql + strCri
            Sql = Sql + " Order by Branch,Dept,EmployeeNo asc"
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            grdData.Rows.Clear()

            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                With grdData
                    ' intM = 1
                    'intW = 1

                    Application.DoEvents()
                    .Rows.Add()
                    .Item(0, .Rows.Count - 2).Value = intNo
                    .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
                    .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("Section").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                    .Item(6, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
                    .Item(7, .Rows.Count - 2).Value = Dtr.Item("StartDate").ToString
                    .Item(8, .Rows.Count - 2).Value = Dtr.Item("MD").ToString


                End With

            Next


        End If

    End Sub

    Private Sub TxtFindData_TextChanged(sender As Object, e As EventArgs) Handles TxtFindData.TextChanged
        ''   strCri = "WHERE Branch <> "" "

        ''If cboBranch.Text = "" Then
        ''    strCri = "WHERE Branch  <> "" "
        ''End If

        'If cboBranch.Text = "Employee No" Then
        '    strCri = "WHERE EmployeeNo  = '" & TxtFindData.Text & "' "
        'End If

        'If cboBranch.Text = "Employee Name" Then
        '    strCri = "WHERE EmployeeName  = '" & TxtFindData.Text & "' "
        'End If

        'If cboBranch.Text = "Branch" Then
        '    strCri = "WHERE Branch  = '" & TxtFindData.Text & "' "
        'End If

        'If cboBranch.Text = "Dept" Then
        '    strCri = "WHERE Dept  = '" & TxtFindData.Text & "' "
        'End If

        'If cboBranch.Text = "Level" Then
        '    strCri = "WHERE Lavel  = '" & TxtFindData.Text & "' "
        'End If

        'Dim Sql As String = "Select * from QEa_Training_Person"
        'Sql = Sql + strCri
        'Sql = Sql + "Order by Branch,Dept,EmployeeNo asc"
        'Dim Dt As New DataTable
        'Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        'grdData.Rows.Clear()

        'Dim intNo As Integer = 1
        'For Each Dtr As DataRow In Dt.Rows
        '    With grdData
        '        ' intM = 1
        '        'intW = 1

        '        Application.DoEvents()
        '        .Rows.Add()
        '        .Item(0, .Rows.Count - 2).Value = intNo
        '        .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
        '        .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
        '        .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
        '        .Item(4, .Rows.Count - 2).Value = Dtr.Item("Section").ToString
        '        .Item(5, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
        '        .Item(6, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
        '        .Item(7, .Rows.Count - 2).Value = Mid(Dtr.Item("StartDate").ToString, 1, 10)
        '        .Item(8, .Rows.Count - 2).Value = Dtr.Item("MD").ToString


        '    End With

        'Next

    End Sub

    Private Sub TxtSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSection.SelectedIndexChanged

    End Sub
End Class