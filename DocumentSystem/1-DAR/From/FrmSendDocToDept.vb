Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmSendDocToDept

    Public CommandType As String
    Public EditNo As String
    Dim strCri As String
    Private intSelectedRow As Integer
    Private rowIndex As Integer

    Private Sub FrmSendDocToDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        CommandType = "Addnew"
        TxtToDept.DataSource = Nothing
        Call ShowDept()
        ' Call LoadData()


        TxtDOCNO.Enabled = False
        Txtlanguage.Enabled = False
        TxtToDept.Enabled = False
        TxtCtypeData.Enabled = False
        TxtCopyNo.Enabled = False
        TxtDocCtrl.Enabled = False

        TxtToDeptName.Text = ""
        Call Grid()




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

    Sub ShowDept()




        Dim command As New SqlCommand("Select * FROM QEm_ToDept ORDER BY ToDept ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEm_ToDept")
        If table.Rows.Count > 0 Then
            TxtToDept.DisplayMember = "ToDept"
            TxtToDept.ValueMember = "ToDept"
            TxtToDept.DataSource = ds.Tables("QEm_ToDept")
        End If


        Exit Sub


    End Sub

    Private Sub bntNew_Click(sender As Object, e As EventArgs) Handles bntNew.Click
        CommandType = "Addnew"

        Call Clear()

        TxtDOCNO.Enabled = True
        Txtlanguage.Enabled = True
        TxtToDept.Enabled = True
        TxtCtypeData.Enabled = True
        TxtCopyNo.Enabled = True
        TxtDocCtrl.Enabled = True

        TxtDOCNO.Focus()
    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs) Handles bntDelete.Click
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEm_ToDept  Where DOCNO ='" & TxtDOCNO.Text & "' AND language ='" & Txtlanguage.Text & "' AND CtypeData ='" & TxtCtypeData.Text & "'AND CopyNo ='" & TxtCopyNo.Text & "' AND ToDept ='" & TxtToDept.Text & "'AND DocCtrl ='" & TxtDocCtrl.Text & "' ", DB_CMD.ObjConn)
            StrFunction.process = 1
            Call LoadData()
        End If

        FrmMainMenu.PictureBox2.Enabled = True
    End Sub


    Sub Clear()

        grdData.Rows.Clear()
        TxtDOCNO.Text = ""
        Txtlanguage.Text = ""
        TxtToDept.Text = ""
        TxtCtypeData.Text = ""
        TxtCopyNo.Text = ""
        TxtDocCtrl.Text = ""
        TxtFind.Text = ""

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        Try
            'ตรวจสอบ ข้อมูลก่อนบันทึก
            If CheckData() = False Then
                MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
                Exit Sub
            Else

                With QEa_SendDocToDept

                    .DOCNO = TxtDOCNO.Text
                    .language = Txtlanguage.Text
                    .CtypeData = TxtCtypeData.Text
                    .CopyNo = TxtCopyNo.Text
                    .ToDept = TxtToDept.Text
                    .DocCtrl = TxtDocCtrl.Text
                    .STATUS = "A"

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
            TxtDOCNO.Enabled = False
            Txtlanguage.Enabled = False
            TxtToDept.Enabled = False
            TxtCtypeData.Enabled = False
            TxtCopyNo.Enabled = False
            TxtDocCtrl.Enabled = False


            FrmMainMenu.PictureBox2.Enabled = True
            'Me.Close()

        Catch ex As Exception
        End Try
    End Sub

    Sub LoadData()
        Try
            Dim strFindData As String = ""
            Me.grdData.AllowUserToAddRows = True

            If TxtFindData.Text <> "" Then
                strFindData = TxtFindData.Text
            Else
                strFindData = TxtDOCNO.Text
            End If

            Dim Sql As String = "Select * from QEa_SendDocToDept FROM DOCNO ='" & strFindData & "' AND STATUS = 'A' "
            Sql = Sql + " Order by DOCNO,ToDept asc"
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            grdData.Rows.Clear()

            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                With grdData
                    ' intM = 1
                    'intW = 1

                    Dim Sql1 As String = "Select * from QEm_ToDept "
                    Sql1 = Sql1 + " WHERE  ToDept ='" & Dtr.Item("ToDept").ToString & "'"
                    Sql1 = Sql1 + " Order by ToDept asc"
                    Dim Dt1 As New DataTable
                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                    Dim strToDeptName As String = ""
                    For Each Dtr1 As DataRow In Dt1.Rows
                        strToDeptName = Dtr1.Item("ToDeptName").ToString()

                    Next

                    Application.DoEvents()
                    .Rows.Add()
                    ' .Item(0, .Rows.Count - 2).Value = intNo
                    .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                    .Item(1, .Rows.Count - 2).Value = Dtr.Item("language").ToString
                    .Item(2, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                    .Item(3, .Rows.Count - 2).Value = strToDeptName
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("CtypeData").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("CopyNo").ToString
                    .Item(6, .Rows.Count - 2).Value = Dtr.Item("DocCtrl").ToString



                End With

            Next

            Me.grdData.AllowUserToAddRows = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdData.CellMouseClick
        CommandType = "Edit"

        TxtDOCNO.Enabled = True
        Txtlanguage.Enabled = True
        TxtToDept.Enabled = True
        TxtCtypeData.Enabled = True
        TxtCopyNo.Enabled = True
        TxtDocCtrl.Enabled = True



        TxtDOCNO.Text = Me.grdData.Item(0, Me.grdData.CurrentRow.Index).Value
        Txtlanguage.Text = Me.grdData.Item(1, Me.grdData.CurrentRow.Index).Value
        TxtToDept.Text = Me.grdData.Item(2, Me.grdData.CurrentRow.Index).Value
        TxtCtypeData.Text = Me.grdData.Item(4, Me.grdData.CurrentRow.Index).Value
        TxtCopyNo.Text = Me.grdData.Item(5, Me.grdData.CurrentRow.Index).Value

        'If Me.grdData.Item(6, Me.grdData.CurrentRow.Index).Value = "Y" Then
        '    TxtDocCtrl.Text = "เอกสารควมคุม"
        'ElseIf Me.grdData.Item(6, Me.grdData.CurrentRow.Index).Value = "N" Then
        '    TxtDocCtrl.Text = "เอกสารไม่ควมคุม"
        'End If
        TxtDocCtrl.Text = Me.grdData.Item(6, Me.grdData.CurrentRow.Index).Value


    End Sub
    Function CheckData() As Boolean
        CheckData = True
        Try


            If Me.TxtDOCNO.Text = Nothing Then
                CheckData = False
                Me.TxtDOCNO.Focus()
                Exit Function
            End If

            If Me.Txtlanguage.Text = Nothing Then
                CheckData = False
                Me.Txtlanguage.Focus()
                Exit Function
            End If
            If Me.TxtToDept.Text = Nothing Then
                CheckData = False
                Me.TxtToDept.Focus()
                Exit Function
            End If
            If Me.TxtCtypeData.Text = Nothing Then
                CheckData = False
                Me.TxtCtypeData.Focus()
                Exit Function
            End If

            If Me.TxtDocCtrl.Text = Nothing Then
                CheckData = False
                Me.TxtDocCtrl.Focus()
                Exit Function
            End If
            If Me.TxtCopyNo.Text = Nothing Then
                CheckData = False
                Me.TxtCopyNo.Focus()
                Exit Function
            End If


        Catch ex As Exception

        End Try
    End Function

    Private Sub TxtToDept_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtToDept_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles TxtToDept.SelectedIndexChanged
        Dim Sql1 As String = "Select * from QEm_ToDept "
        Sql1 = Sql1 + " WHERE  ToDept ='" & TxtToDept.Text & "'"
        Sql1 = Sql1 + " Order by ToDept asc"
        Dim Dt1 As New DataTable
        Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

        Dim strToDeptName As String = ""
        For Each Dtr1 As DataRow In Dt1.Rows
            TxtToDeptName.Text = Dtr1.Item("ToDeptName").ToString()

        Next
    End Sub





    Private Sub TxtFindData_TextChanged(sender As Object, e As EventArgs) Handles TxtFindData.TextChanged

    End Sub

    Private Sub TxtFindData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFindData.KeyPress
        If e.KeyChar = Chr(13) Then
            ' strCri = "WHERE Branch <> "" "
            '

            Call LoadDataFind()


        End If
    End Sub

    Sub LoadDataFind()

        If cboBranch.Text = "เอกสารเลขที่" Then
            strCri = "WHERE DOCNO  = '" & TxtFindData.Text & "' AND STATUS = 'A' "
        End If

        If cboBranch.Text = "ผู้รับเอกสาร" Then
            strCri = "WHERE ToDept  = '" & TxtFindData.Text & "' AND STATUS = 'A' "
        End If


        Dim Sql As String = "Select * from QEa_SendDocToDept "
        Sql = Sql + strCri
        Sql = Sql + " Order by DOCNO,ToDept asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        grdData.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With grdData
                ' intM = 1
                'intW = 1

                Dim Sql1 As String = "Select * from QEm_ToDept "
                Sql1 = Sql1 + " WHERE  ToDept ='" & Dtr.Item("ToDept").ToString & "'"
                Sql1 = Sql1 + " Order by ToDept asc"
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                Dim strToDeptName As String = ""
                For Each Dtr1 As DataRow In Dt1.Rows
                    strToDeptName = Dtr1.Item("ToDeptName").ToString()

                Next

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("language").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                .Item(3, .Rows.Count - 2).Value = strToDeptName
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("CtypeData").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("CopyNo").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("DocCtrl").ToString


            End With

        Next
    End Sub

    Private Sub bntAddNew_Click(sender As Object, e As EventArgs) Handles bntAddNew.Click
        CommandType = "Addnew"

        Call Clear()

        TxtDOCNO.Enabled = True
        Txtlanguage.Enabled = True
        TxtToDept.Enabled = True
        TxtCtypeData.Enabled = True
        TxtCopyNo.Enabled = True
        TxtDocCtrl.Enabled = True


        TxtDOCNO.Focus()
    End Sub

    Private Sub bntSaveData_Click(sender As Object, e As EventArgs) Handles bntSaveData.Click
        Try
            'ตรวจสอบ ข้อมูลก่อนบันทึก
            If CheckData() = False Then
                MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
                Exit Sub
            Else

                With QEa_SendDocToDept

                    .DOCNO = TxtDOCNO.Text
                    .language = Txtlanguage.Text
                    .CtypeData = TxtCtypeData.Text
                    .CopyNo = TxtCopyNo.Text
                    .ToDept = TxtToDept.Text
                    .DocCtrl = TxtDocCtrl.Text
                    .STATUS = "A"

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
            TxtDOCNO.Enabled = False
            Txtlanguage.Enabled = False
            TxtToDept.Enabled = False
            TxtCtypeData.Enabled = False
            TxtCopyNo.Enabled = False
            TxtDocCtrl.Enabled = False


            FrmMainMenu.PictureBox2.Enabled = True
            'Me.Close()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub bntDeleteData_Click(sender As Object, e As EventArgs) Handles bntDeleteData.Click

        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEa_SendDocToDept WHERE DOCNO =  '" & TxtDOCNO.Text & "'     ", DB_CMD.ObjConn)
            StrFunction.process = 1
            Call LoadData()
        End If


        'If CheckData() = False Then
        '    MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
        '    Exit Sub
        'Else

        '    Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"
        '    If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        '    CmdExcute("DELETE FROM QEa_SendDocToDept  Where DOCNO ='" & TxtDOCNO.Text & "' AND language ='" & Txtlanguage.Text & "' AND CtypeData ='" & TxtCtypeData.Text & "'AND CopyNo ='" & TxtCopyNo.Text & "' AND ToDept ='" & TxtToDept.Text & "'AND DocCtrl ='" & TxtDocCtrl.Text & "' ", DB_CMD.ObjConn)
        '    StrFunction.process = 1
        '    Call LoadData()
        'End If


        FrmMainMenu.PictureBox2.Enabled = True
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try

            Call LoadDataFind()
            '    'strCri = "WHERE Branch <> "" "

            '    If cboBranch.Text = "เอกสารเลขที่" Then
            '        strCri = "WHERE DOCNO  = '" & TxtFindData.Text & "' "
            '    End If

            '    If cboBranch.Text = "ผู้รับเอกสาร" Then
            '        strCri = "WHERE ToDept = '" & TxtFindData.Text & "' "
            '    End If

            '    Dim Sql As String = "Select * from QEa_SendDocToDept "
            '    Sql = Sql + strCri
            '    Sql = Sql + " Order by DOCNO,ToDept asc"
            '    Dim Dt As New DataTable
            '    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            '    grdData.Rows.Clear()

            '    Dim intNo As Integer = 1
            '    For Each Dtr As DataRow In Dt.Rows
            '        With grdData
            '            ' intM = 1
            '            'intW = 1

            '            Dim Sql1 As String = "Select * from QEm_ToDept "
            '            Sql1 = Sql1 + " WHERE  ToDept ='" & Dtr.Item("ToDept").ToString & "'"
            '            Sql1 = Sql1 + " Order by ToDept asc"
            '            Dim Dt1 As New DataTable
            '            Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

            '            Dim strToDeptName As String = ""
            '            For Each Dtr1 As DataRow In Dt1.Rows
            '                strToDeptName = Dtr1.Item("ToDeptName").ToString()

            '            Next

            '            Application.DoEvents()
            '            .Rows.Add()
            '            ' .Item(0, .Rows.Count - 2).Value = intNo
            '            .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
            '            .Item(1, .Rows.Count - 2).Value = Dtr.Item("language").ToString
            '            .Item(2, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
            '            .Item(3, .Rows.Count - 2).Value = strToDeptName
            '            .Item(4, .Rows.Count - 2).Value = Dtr.Item("CtypeData").ToString
            '            .Item(5, .Rows.Count - 2).Value = Dtr.Item("CopyNo").ToString
            '            .Item(6, .Rows.Count - 2).Value = Dtr.Item("DocCtrl").ToString


            '        End With

            '    Next



        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdData_MouseUp(sender As Object, e As MouseEventArgs) Handles grdData.MouseUp

    End Sub

    Private Sub grdData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdData.CellMouseUp
        Try


            If e.Button = MouseButtons.Right Then
                Me.grdData.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex

                strDOCNOSendTodept = ""
                strLanguageSendTodept = ""
                strCtypeDataSendTodept = ""
                strDocCtrlSendTodept = ""
                strCopyNoSendTodept = ""
                strToDeptSendTodept = ""
                'strLineData = dgvDATA.Rows(e.RowIndex).Cells(14).Value().ToString.Trim()
                strDOCNOSendTodept = grdData.Rows(e.RowIndex).Cells(0).Value().ToString.Trim()
                strLanguageSendTodept = grdData.Rows(e.RowIndex).Cells(1).Value().ToString.Trim()
                strToDeptSendTodept = grdData.Rows(e.RowIndex).Cells(2).Value().ToString.Trim()
                strCtypeDataSendTodept = grdData.Rows(e.RowIndex).Cells(4).Value().ToString.Trim()

                strCopyNoSendTodept = grdData.Rows(e.RowIndex).Cells(5).Value().ToString.Trim()
                strDocCtrlSendTodept = grdData.Rows(e.RowIndex).Cells(6).Value().ToString.Trim()



                ' strRRSNO = Me.dgvDATA.Item(9, Me.dgvDATA.CurrentRow.Index).Value

                Me.MetroContextMenu1.Show(Me.grdData, e.Location)
                MetroContextMenu1.Show(Cursor.Position)


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuDelete_Click(sender As Object, e As EventArgs) Handles menuDelete.Click

        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & strCopyNoSendTodept & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEa_SendDocToDept  Where DOCNO ='" & TxtDOCNO.Text & "' AND language ='" & Txtlanguage.Text & "' AND CtypeData ='" & TxtCtypeData.Text & "'AND CopyNo ='" & TxtCopyNo.Text & "' AND ToDept ='" & TxtToDept.Text & "'AND DocCtrl ='" & TxtDocCtrl.Text & "' ", DB_CMD.ObjConn)
            StrFunction.process = 1
            Call LoadData()
        End If
    End Sub

    Private Sub MetroContextMenu1_Opening(sender As Object, e As ComponentModel.CancelEventArgs) Handles MetroContextMenu1.Opening

    End Sub
End Class