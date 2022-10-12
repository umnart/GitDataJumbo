Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmToDept
    Public CommandType As String
    Public EditNo As String
    Dim strCri As String
    Private Sub bntClose_Click(sender As Object, e As EventArgs)
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()

    End Sub

    Private Sub bntClose_Click_1(sender As Object, e As EventArgs)
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()

    End Sub

    Private Sub bntClose_Click_2(sender As Object, e As EventArgs) Handles bntClose.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()

    End Sub


    Private Sub FrmToDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()

        CommandType = "Addnew"

        Call ShowDept()
        Call LoadData()


        TxtDept.Enabled = False
        TxtBranch.Enabled = False
        TxtToDept.Enabled = False
        TxtToDeptName1.Enabled = False

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
        TxtToDept.Enabled = True
        TxtToDeptName1.Enabled = True


        TxtDept.Focus()
    End Sub

    Private Sub bntDelete_Click(sender As Object, e As EventArgs) Handles bntDelete.Click
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtToDept.Text & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEm_ToDept  WHERE ToDept='" & TxtToDept.Text & "' ", DB_CMD.ObjConn)
            StrFunction.process = 1
            Call LoadData()
        End If

        FrmMainMenu.PictureBox2.Enabled = True
    End Sub

    Sub Clear()

        TxtToDept.Text = ""
        TxtToDeptName1.Text = ""
        TxtDept.Text = ""
        TxtBranch.Text = ""


    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        '  Try
        'ตรวจสอบ ข้อมูลก่อนบันทึก
        If CheckData() = False Then
            MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
            Exit Sub
        Else

            With QEm_ToDept

                .ToDept = TxtToDept.Text
                .ToDeptName = TxtToDeptName1.Text
                .Dept = TxtDept.Text
                .Branch = TxtBranch.Text

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
        TxtToDept.Enabled = False
        TxtToDeptName1.Enabled = False


        FrmMainMenu.PictureBox2.Enabled = True
        'Me.Close()

        ' Catch ex As Exception
        ' End Try
    End Sub

    Sub LoadData()



        Dim Sql As String = "Select * from QEm_ToDept "
        Sql = Sql + " Order by ToDept asc"
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
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("ToDeptName").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString


            End With

        Next


    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_MouseClick(sender As Object, e As MouseEventArgs) Handles grdData.MouseClick
        CommandType = "Edit"

        TxtDept.Enabled = True
        TxtBranch.Enabled = True
        TxtToDept.Enabled = True
        TxtToDeptName1.Enabled = True



        TxtDept.Text = Me.grdData.Item(2, Me.grdData.CurrentRow.Index).Value
        TxtBranch.Text = Me.grdData.Item(3, Me.grdData.CurrentRow.Index).Value
        TxtToDept.Text = Me.grdData.Item(0, Me.grdData.CurrentRow.Index).Value
        TxtToDeptName1.Text = Me.grdData.Item(1, Me.grdData.CurrentRow.Index).Value

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
            If Me.TxtToDept.Text = Nothing Then
                CheckData = False
                Me.TxtToDept.Focus()
                Exit Function
            End If
            If Me.TxtToDeptName1.Text = Nothing Then
                CheckData = False
                Me.TxtToDeptName1.Focus()
                Exit Function
            End If



        Catch ex As Exception

        End Try
    End Function
End Class