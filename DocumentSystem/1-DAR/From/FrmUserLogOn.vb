Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmUserLogOn
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub FrmUserLogOn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        CommandType = "Addnew"

        Call ShowDept()
        Call LoadData()


        TxtDept.Enabled = False
        TxtBranch.Enabled = False
        TxtEmployeeNo.Enabled = False
        txtEmployeeName1.Enabled = False
        TxtEmployeePass1.Enabled = False
        TxtApprove.Enabled = False
        TxtEmail1.Enabled = False
        TxtLevel.Enabled = False

    End Sub
    Sub ShowDept()




        Dim command As New SqlCommand("Select * FROM QEm_Dept ORDER BY DeptCod ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEm_Dept")
        If table.Rows.Count > 0 Then
            TxtDept.DisplayMember = "DeptCod"
            TxtDept.ValueMember = "DeptCod"
            TxtDept.DataSource = ds.Tables("QEm_Dept")
        End If


        Exit Sub


    End Sub
    Private Sub bntNew_Click(sender As Object, e As EventArgs) Handles bntNew.Click
        CommandType = "Addnew"

        Call Clear()

        TxtDept.Enabled = True
        TxtBranch.Enabled = True
        TxtEmployeeNo.Enabled = True
        txtEmployeeName1.Enabled = True
        TxtEmployeePass1.Enabled = True
        TxtApprove.Enabled = True
        TxtEmail1.Enabled = True
        TxtLevel.Enabled = True
        TxtLevel.Text = "Medium"
        TxtEmployeeNo.Focus()


        Select Case strBranchConn
            Case "TP"
                TxtBranch.Text = "TP"
            Case "KB"
                TxtBranch.Text = "KB"
        End Select
    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs) Handles bntDelete.Click
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtEmployeeNo.Text & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEm_UserLogOn  WHERE EmployeeNo='" & TxtEmployeeNo.Text & "' ", DB_CMD.ObjConn)
            StrFunction.process = 1
            Call LoadData()
        End If

        FrmMainMenu.PictureBox2.Enabled = True
    End Sub

    Sub Clear()

        TxtEmployeeNo.Text = ""
        txtEmployeeName1.Text = ""
        TxtEmployeePass1.Text = ""
        TxtDept.Text = ""
        TxtBranch.Text = ""
        TxtApprove.Text = ""
        TxtEmail1.Text = ""
        TxtLevel.Text = ""

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        '  Try
        'ตรวจสอบ ข้อมูลก่อนบันทึก
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            With QEm_UserLogOn

                .EmployeeNo = TxtEmployeeNo.Text
                .EmployeeName = txtEmployeeName1.Text
                .EmployeePass = TxtEmployeePass1.Text
                .Dept = TxtDept.Text
                .Branch = TxtBranch.Text
                .Lavel = TxtLevel.Text
                .Email = TxtEmail1.Text
                .Approve = TxtApprove.Text
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

        Call Clear()
        TxtDept.Enabled = False
        TxtBranch.Enabled = False
        TxtEmployeeNo.Enabled = False
        txtEmployeeName1.Enabled = False
        TxtEmployeePass1.Enabled = False
        TxtApprove.Enabled = False
        TxtEmail1.Enabled = False
        TxtLevel.Enabled = False


        FrmMainMenu.PictureBox2.Enabled = True
        'Me.Close()

        ' Catch ex As Exception
        ' End Try


    End Sub

    Sub LoadData()

        'With RDm_UserLogOn
        '    .GetData("SELECT * FROM RDm_UserLogOn ", DB_CMD.ObjConn)
        '    TxtEmployeeNo.Text = .EmployeeNo
        '    txtEmployeeName1.Text = .EmployeeName
        '    TxtEmployeePass1.Text = .EmployeePass
        '    TxtDept.Text = .Dept
        '    TxtBranch.Text = .Branch

        'End With


        'Dim cri As String = ""




        Dim Sql As String = "Select * from QEm_UserLogOn "
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
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeePass").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("Email").ToString

            End With

        Next


    End Sub


    'Private Sub TxtFindData_KeyPress(sender As Object, e As KeyPressEventArgs)

    '    If e.KeyChar = Chr(13) Then
    '        strCri = "WHERE Branch <> "" "

    '        If cboBranch.Text = "" Then
    '            strCri = "WHERE Branch  Like <> "" "
    '        End If

    '        If cboBranch.Text = "Employee No" Then
    '            strCri = "WHERE EmployeeNo  Like '%" & TxtFindData.Text & "%' "
    '        End If

    '        If cboBranch.Text = "Employee Name" Then
    '            strCri = "WHERE EmployeeName  Like '%" & TxtFindData.Text & "%' "
    '        End If

    '        If cboBranch.Text = "Branch" Then
    '            strCri = "WHERE Branch  Like '%" & TxtFindData.Text & "%' "
    '        End If

    '        If cboBranch.Text = "Dept" Then
    '            strCri = "WHERE Dept  Like '%" & TxtFindData.Text & "%' "
    '        End If

    '        If cboBranch.Text = "Level" Then
    '            strCri = "WHERE Lavel  Like '%" & TxtFindData.Text & "%' "
    '        End If



    '        Dim Sql As String = "Select *  from QEm_UserLogOn "
    '        Sql = Sql + strCri
    '        Sql = Sql + " Order by Branch,Dept,EmployeeNo asc"
    '        Dim Dt As New DataTable
    '        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
    '        grdData.Rows.Clear()

    '        Dim intNo As Integer = 1
    '        For Each Dtr As DataRow In Dt.Rows
    '            With grdData
    '                ' intM = 1
    '                'intW = 1

    '                Application.DoEvents()
    '                .Rows.Add()
    '                ' .Item(0, .Rows.Count - 2).Value = intNo
    '                .Item(0, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
    '                .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
    '                .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeePass").ToString
    '                .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
    '                .Item(4, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
    '                .Item(5, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
    '                .Item(6, .Rows.Count - 2).Value = Dtr.Item("Email").ToString

    '            End With

    '        Next

    '    End If
    'End Sub




    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick
        SendKeys.Send("{Tab}")
    End Sub

    Private Sub grdData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdData.CellMouseClick
        CommandType = "Edit"

        TxtDept.Enabled = True
        TxtBranch.Enabled = True
        TxtEmployeeNo.Enabled = True
        txtEmployeeName1.Enabled = True
        TxtEmployeePass1.Enabled = True
        TxtApprove.Enabled = True
        TxtEmail1.Enabled = True
        TxtLevel.Enabled = True


        TxtEmployeeNo.Text = Me.grdData.Item(0, Me.grdData.CurrentRow.Index).Value
        txtEmployeeName1.Text = Me.grdData.Item(1, Me.grdData.CurrentRow.Index).Value
        TxtEmployeePass1.Text = Me.grdData.Item(2, Me.grdData.CurrentRow.Index).Value
        TxtBranch.Text = Me.grdData.Item(4, Me.grdData.CurrentRow.Index).Value
        TxtDept.Text = Me.grdData.Item(3, Me.grdData.CurrentRow.Index).Value
        TxtLevel.Text = Me.grdData.Item(5, Me.grdData.CurrentRow.Index).Value
        TxtApprove.Text = Me.grdData.Item(6, Me.grdData.CurrentRow.Index).Value
        TxtEmail1.Text = Me.grdData.Item(7, Me.grdData.CurrentRow.Index).Value
    End Sub

    Function CheckData() As Boolean
        CheckData = True
        Try


            If Me.TxtDept.Text = Nothing Then
                CheckData = False
                Me.TxtDept.Focus()
                Exit Function
            End If

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

            If Me.TxtEmployeePass1.Text = Nothing Then
                CheckData = False
                Me.TxtEmployeePass1.Focus()
                Exit Function
            End If

            'If Me.TxtLavel.Text = Nothing Then
            '    CheckData = False
            '    Me.TxtLavel.Focus()
            '    Exit Function
            'End If


        Catch ex As Exception

        End Try
    End Function

    Private Sub TxtFindData_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtFindData_Click_1(sender As Object, e As EventArgs) Handles TxtFindData.Click

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
                strCri = "WHERE EmployeeName  Like '%" & TxtFindData.Text & "%' "
            End If

            If cboBranch.Text = "Branch" Then
                strCri = "WHERE Branch  Like '%" & TxtFindData.Text & "%' "
            End If

            If cboBranch.Text = "Dept" Then
                strCri = "WHERE Dept  Like '%" & TxtFindData.Text & "%' "
            End If

            If cboBranch.Text = "Level" Then
                strCri = "WHERE Lavel  Like '%" & TxtFindData.Text & "%' "
            End If



            Dim Sql As String = "Select *  from QEm_UserLogOn "
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
                    ' .Item(0, .Rows.Count - 2).Value = intNo
                    .Item(0, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
                    .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
                    .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeePass").ToString
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
                    .Item(6, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                    .Item(7, .Rows.Count - 2).Value = Dtr.Item("Email").ToString

                End With

            Next

        End If
    End Sub

    Private Sub TxtFindData_TextChanged(sender As Object, e As EventArgs) Handles TxtFindData.TextChanged
        grdData.Rows.Clear()
        'strCri = "WHERE Branch <> "" "

        'If cboBranch.Text = "" Then
        '    strCri = "WHERE Branch  Like <> "" "
        'End If

        'If cboBranch.Text = "Employee No" Then
        '    strCri = "WHERE EmployeeNo  Like '%" & TxtFindData.Text & "%' "
        'End If

        'If cboBranch.Text = "Employee Name" Then
        '    strCri = "WHERE EmployeeName  Like '%" & TxtFindData.Text & "%' "
        'End If

        'If cboBranch.Text = "Branch" Then
        '    strCri = "WHERE Branch  Like '%" & TxtFindData.Text & "%' "
        'End If

        'If cboBranch.Text = "Dept" Then
        '    strCri = "WHERE Dept  Like '%" & TxtFindData.Text & "%' "
        'End If

        'If cboBranch.Text = "Level" Then
        '    strCri = "WHERE Lavel  Like '%" & TxtFindData.Text & "%' "
        'End If



        'Dim Sql As String = "Select *  from QEm_UserLogOn "
        'Sql = Sql + strCri
        'Sql = Sql + " Order by Branch,Dept,EmployeeNo asc"
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
        '        ' .Item(0, .Rows.Count - 2).Value = intNo
        '        .Item(0, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
        '        .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
        '        .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeePass").ToString
        '        .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
        '        .Item(4, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
        '        .Item(5, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
        '        .Item(6, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
        '        .Item(7, .Rows.Count - 2).Value = Dtr.Item("Email").ToString

        '    End With

        'Next
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub grdData_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grdData.MouseDoubleClick

        'Select Case strShowFoam
        '    Case "DOC_APPROVEDAR"
        '        Call SaveData()


        'End Select
    End Sub


    Sub SaveData()




    End Sub

    Private Sub bntSelectEm_Click(sender As Object, e As EventArgs) Handles bntSelectEm.Click


        ' CmdExcute("DELETE FROM QEm_KM_Dept_SEL WHERE REFNO ='" & FrmKMEdit.TxtREFNO.Text & "' AND REFNODATA ='" & FrmKMEdit.TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
        '

        Select Case strShowFoam
            Case "DOC_APPROVEDAR"
                For Each row As DataGridViewRow In grdData.Rows

                    If CBool(row.Cells("Sel").Value) = True Then

                        Dim Sql As String = Nothing
                        Dim Year As Integer = CInt(Format(Now, "yyyy"))
                        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))



                        With QEa_DocSys_DarApprove
                            .REFNO = strRefNo
                            .REFNODATA = strRefNoData
                            .IDApprove = (row.Cells("EmployeeNo").Value.ToString)
                            .NameApprove = (row.Cells("EmployeeName").Value.ToString)
                            .DeptApprove = (row.Cells("Dept").Value.ToString)
                            .EmailApprove = (row.Cells("Email").Value.ToString)
                            ' .Flag = TxtFlag.Text

                            ' Dim Sql As String = Nothing
                            Select Case CommandApproveDAR
                                Case "Addnew"
                                    Sql = .SqlCommandInsert
                                Case "Edit"
                                    Sql = .SqlCommandUpdate
                            End Select
                            If CmdExcute(Sql, DB_CMD.ObjConn) = True Then
                                StrFunction.DOC_APPROVEDAR = 1
                            Else
                                MsgBox("ไม่สามารถบันทึกข้อมูลได้")
                            End If
                        End With
                        'End If

                    End If

                Next

                Me.Close()



            Case "KMM"
                For Each row As DataGridViewRow In grdData.Rows

                    If CBool(row.Cells("Sel").Value) = True Then

                        Dim sqlinsert As String
                        sqlinsert = "INSERT INTO QEm_KM_UserView(REFNO,REFNODATA,DeptDATA,Branch,GROUPNAME,Lavel,EmployeeNo,EmployeeName,DOCNO) " &
                                              "VALUES(@REFNO,@REFNODATA,@DeptDATA,@Branch,@GROUPNAME,@Lavel,@EmployeeNo,@EmployeeName,@DOCNO)"

                        With comSave
                            .Parameters.Clear()
                            .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = FrmKMEdit.TxtREFNO.Text
                            .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = FrmKMEdit.TxtREFNODATA.Text
                            .Parameters.Add("@DeptDATA", SqlDbType.VarChar).Value = (row.Cells("Dept").Value.ToString)
                            .Parameters.Add("@Branch", SqlDbType.VarChar).Value = FrmKMEdit.TxtBranch.Text
                            .Parameters.Add("@GROUPNAME", SqlDbType.VarChar).Value = FrmKMEdit.TxtGROUPNAME.Text
                            .Parameters.Add("@Lavel", SqlDbType.VarChar).Value = (row.Cells("Lavel").Value.ToString)
                            .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = (row.Cells("EmployeeNo").Value.ToString)
                            .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = (row.Cells("EmployeeName").Value.ToString)
                            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = FrmKMEdit.TxtDOCNO.Text

                            .CommandText = sqlinsert
                            .Connection = DB_CMD.ObjConn
                            .ExecuteNonQuery()

                        End With

                    End If

                Next

                StrFunction.KMEM = 1

        End Select






        Me.Close()
    End Sub

    Private Sub bntTxtLinkFilePDF_Open_Click(sender As Object, e As EventArgs) Handles bntTxtLinkFilePDF_Open.Click
        strCri = "WHERE Branch <> "" "

        If cboBranch.Text = "" Then
            strCri = "WHERE Branch  Like <> "" "
        End If

        If cboBranch.Text = "Employee No" Then
            strCri = "WHERE EmployeeNo  Like '%" & TxtFindData.Text & "%' "
        End If

        If cboBranch.Text = "Employee Name" Then
            strCri = "WHERE EmployeeName  Like '%" & TxtFindData.Text & "%' "
        End If

        If cboBranch.Text = "Branch" Then
            strCri = "WHERE Branch  Like '%" & TxtFindData.Text & "%' "
        End If

        If cboBranch.Text = "Dept" Then
            strCri = "WHERE Dept  Like '%" & TxtFindData.Text & "%' "
        End If

        If cboBranch.Text = "Level" Then
            strCri = "WHERE Lavel  Like '%" & TxtFindData.Text & "%' "
        End If



        Dim Sql As String = "Select *  from QEm_UserLogOn "
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
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("EmployeePass").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("Email").ToString

            End With

        Next

    End Sub

    Private Sub cboBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBranch.SelectedIndexChanged
        grdData.Rows.Clear()
    End Sub
End Class