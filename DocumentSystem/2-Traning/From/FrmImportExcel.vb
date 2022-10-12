Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Data.SqlTypes
'Imports Microsoft.OFFICE.INTERRAP
Imports System.Data
'Imports System.ID
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class FrmImportExcel
    Public dr As OleDbDataReader
    Dim Exts As String
    'Dim conn As OleDbConnection
    Dim dta As OleDbDataAdapter
    Dim dts As DataSet
    Dim excel As String
    Dim OpenFileDialog As New OpenFileDialog
    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim ConnKB As New SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlDataAdapter
    Dim ds2 As New DataSet
    Dim da3 As SqlDataAdapter
    Dim ds3 As New DataSet
    Dim strSQL As String
    Dim Check As Boolean
    Dim Action As String
    Dim IsFind As Boolean
    Dim IsParentSite As Boolean
    Dim IsParentLocation As Boolean
    Dim IsParentComp As Boolean
    Dim strShowBrand As Boolean
    Dim strShowMoBrand As Boolean
    Dim strShowWindows As Boolean
    Dim strShowOffice As Boolean
    Dim comSave As New SqlCommand
    Dim comDelete As New SqlCommand
    Dim comUpdate As New SqlCommand
    Dim SQL As String
    Private rowIndex As Integer
    Dim result As Boolean
    Dim intJobNo As Integer = 1
    Dim Year As Integer = CInt(Format(Now, "yyyy"))
    Dim strItemType As String = ""
    Dim strJobNo As String = ""
    Dim strBranch As String = ""
    Dim strRunNo As String
    Dim cri As String
    Dim _txt As New TextBox
    Dim intFixed, intStandard, IntHierarchy As Integer
    Dim strdatetime As Date
    Dim strDateStarted As String
    Dim strDateDueStart As String
    Dim strDateDueFinish As String

    Private Sub cmdAddWorkOrder_Click(sender As Object, e As EventArgs) Handles cmdAddWorkOrder.Click
        'If ChkD.Checked = False And ChkM.Checked = False Then
        '    MsgBox("กรุณาเลือกประเภทที่ต้องการ Import ด้วยครับ", MsgBoxStyle.Exclamation)
        '    ChkM.Focus()
        '    Exit Sub
        'End If


        If TxtMD.Text = "" Then
            MsgBox("ต้องเลือกประเภทพนักงานก่อน")
            Exit Sub
        End If


        Call SelectFile()

        'Call Showdata()

        Try
            Dim MyConnection As OleDb.OleDbConnection
            Dim Ds As System.Data.DataSet
            Dim MyAdapter As System.Data.OleDb.OleDbDataAdapter
            ' MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\สถานะงานซ่อมสร้าง ณ 31-8-2017.xls';Extended Properties=Excel 8.0;")

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & Me.TxtSourceFile.Text & "';Extended Properties='Excel 12.0 Xml;HDR=YES;'")
            MyAdapter = New System.Data.OleDb.OleDbDataAdapter("Select * from [Sheet1$]", MyConnection)
            Ds = New System.Data.DataSet
            MyAdapter.Fill(Ds)
            Me.grdFind.DataSource = Ds.Tables(0)
            FormatGrd()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormatGrd()
        With grdFind
            If .RowCount <> 0 Then
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .Columns(2).Width = 150
                .Columns(3).Width = 150
                .Columns(4).Width = 85
                .Columns(5).Width = 85
                .Columns(6).Width = 85
                .Columns(7).Width = 85
                .Columns(8).Width = 85
                .Columns(9).Width = 85
                .Columns(10).Width = 85
                '.Columns(0).HeaderText = "วันที่รับเอกสาร"
                '.Columns(1).HeaderText = "เลขที่ใบเบิก"
                '.Columns(2).HeaderText = "เลขที่ใบงาน"
                '.Columns(3).HeaderText = "รายการ"
                '.Columns(4).HeaderText = "ฝ่ายวิศวกรรม"
                '.Columns(5).HeaderText = "สถานะใบเบิก"
                '.Columns(6).HeaderText = "รออะไหล่/ส่งซ่อมร้านนอก"

            End If
        End With


    End Sub

    Dim strDateFinished As String
    Private Sub FrmImportExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()
    End Sub

    Private Sub cmdEx_Click(sender As Object, e As EventArgs) Handles cmdEx.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub cmdAddSave_Click(sender As Object, e As EventArgs) Handles cmdAddSave.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Dim sqlinsert As String
        Dim comSave As New SqlCommand
        Dim comDelete As New SqlCommand
        '   Try

        ''  Try
        ''ตรวจสอบ ข้อมูลก่อนบันทึก
        If TxtSourceFile.Text = "" Then
                MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
                Exit Sub
            Else
            Dim strMD As String = ""
            If TxtMD.Text = "รายเดือน" Then
                strMD = "M"
            ElseIf TxtMD.Text = "รายวัน" Then
                strMD = "D"
            End If

            CmdExcute("DELETE FROM QEa_Training_Person WHERE MD ='" & strMD & "'  ", DB_CMD.ObjConn)

            With grdFind
                    For i As Integer = 0 To .Rows.Count - 1



                        '   CmdExcute("DELETE FROM QEa_Training_Person  WHERE EmployeeNo='" & CType((grdFind.Rows(i).Cells(1).Value), String) & "' ", DB_CMD.ObjConn)


                        sqlinsert = "INSERT INTO QEa_Training_Person(EmployeeNo,EmployeeName,Dept,Section,Branch,Lavel,StartDate,MD) " &
                            "VALUES(@EmployeeNo,@EmployeeName,@Dept,@Section,@Branch,@Lavel,@StartDate,@MD)"

                        With comSave
                            .Parameters.Clear()
                        .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = CType((grdFind.Rows(i).Cells(1).Value), String)

                        If IsDBNull(grdFind.Rows(i).Cells(4).Value) Then
                            .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = CType((grdFind.Rows(i).Cells(2).Value), String) & CType((grdFind.Rows(i).Cells(3).Value), String) & "  " & ""

                        Else
                            .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = CType((grdFind.Rows(i).Cells(2).Value), String) & CType((grdFind.Rows(i).Cells(3).Value), String) & "  " & CType((grdFind.Rows(i).Cells(4).Value), String)

                        End If


                        .Parameters.Add("@Dept", SqlDbType.VarChar).Value = CType((grdFind.Rows(i).Cells(5).Value), String)
                        If IsDBNull((grdFind.Rows(i).Cells(6).Value)) Then
                                .Parameters.Add("@Section", SqlDbType.VarChar).Value = ""
                            Else
                                .Parameters.Add("@Section", SqlDbType.VarChar).Value = CType((grdFind.Rows(i).Cells(6).Value), String)
                            End If

                            'Select Case CType((grdFind.Rows(i).Cells(9).Value), String)
                            '    Case "สำนักงานเทพารักษ์"
                            '        .Parameters.Add("@Branch", SqlDbType.VarChar).Value = "TP"
                            '    Case "กบินทร์บุรีโรง 2"
                            '        .Parameters.Add("@Branch", SqlDbType.VarChar).Value = "KB2"
                            '    Case "สำนักงานกบินทร์บุรี"
                            '        .Parameters.Add("@Branch", SqlDbType.VarChar).Value = "KB1"
                            'End Select

                            Select Case strBranchConn
                                Case "TP"
                                    .Parameters.Add("@Branch", SqlDbType.VarChar).Value = "TP"
                                Case "KB"
                                    .Parameters.Add("@Branch", SqlDbType.VarChar).Value = "KB"
                            End Select


                            .Parameters.Add("@Lavel", SqlDbType.VarChar).Value = CType((grdFind.Rows(i).Cells(7).Value), String)
                        .Parameters.Add("@StartDate", SqlDbType.Date).Value = Mid(CType((grdFind.Rows(i).Cells(8).Value), String), 1, 10)

                        If TxtMD.Text = "รายเดือน" Then
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = "M"
                            ElseIf TxtMD.Text = "รายวัน" Then
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = "D"
                            End If




                            .CommandText = sqlinsert
                            .Connection = DB_CMD.ObjConn
                            .ExecuteNonQuery()

                        End With





                        ' With QEa_Training_Person



                        '        .EmployeeNo = CType((grdFind.Rows(i).Cells(1).Value), String)
                        '        .EmployeeName = CType((grdFind.Rows(i).Cells(2).Value), String) & CType((grdFind.Rows(i).Cells(3).Value), String) & "  " & CType((grdFind.Rows(i).Cells(4).Value), String)
                        '        If CType((grdFind.Rows(i).Cells(5).Value), String) = "Admin" Then
                        '            .Dept = "AD"
                        '        Else
                        '            .Dept = CType((grdFind.Rows(i).Cells(5).Value), String)
                        '        End If

                        '        If IsDBNull(grdFind.Rows(i).Cells(6).Value) Then
                        '            .Section = ""
                        '        Else
                        '            .Section = CType((grdFind.Rows(i).Cells(6).Value), String)
                        '        End If


                        '        .Lavel = CType((grdFind.Rows(i).Cells(7).Value), String)
                        '        ' .StartDate = CDate(Format((grdFind.Rows(i).Cells(8).Value), "dd/MM/yyyy"))
                        '        ' .StartDate = CDate((grdFind.Rows(i).Cells(8).Value))
                        '        '
                        '        .StartDate = CBool(CType((grdFind.Rows(i).Cells(8).Value), String))
                        '        .MD = CType((grdFind.Rows(i).Cells(10).Value), String)


                        '        ' Format(dr("ActionDate"), "yyyy/MM/dd")
                        '        Select Case CType((grdFind.Rows(i).Cells(9).Value), String)
                        '            Case "สำนักงานเทพารักษ์"
                        '                .Branch = "TP"
                        '            Case "กบินทร์บุรีโรง 2"
                        '                .Branch = "KB2"
                        '            Case "สำนักงานกบินทร์บุรี"
                        '                .Branch = "KB1"
                        '        End Select

                        '        CommandType = "Addnew"

                        '        Dim Sql As String = Nothing
                        '        Select Case CommandType
                        '            Case "Addnew"
                        '                Sql = .SqlCommandInsert
                        '            Case "Edit"
                        '                Sql = .SqlCommandUpdate
                        '        End Select
                        '        If CmdExcute(Sql, DB_CMD.ObjConn) = True Then



                        '        Else
                        '            MsgBox("ไม่สามารถบันทึกข้อมูลได้")
                        '        End If

                        '    End With

                    Next
                    MsgBox("import เรียบร้่อย")
                    StrFunction.ImportExcel = 1

                    Me.Close()
                End With
            End If


            Exit Sub

            'Catch ex As Exception

        '  End Try

    End Sub

    Private Function ReadWordDoc(ByVal filename As String) As Byte()
        Dim fs As New System.IO.FileStream(filename, IO.FileMode.Open)
        Dim br As New System.IO.BinaryReader(fs)
        Dim data() As Byte = br.ReadBytes(CInt(fs.Length))
        br.Close()
        fs.Close()
        Return data
    End Function

    Private Sub SelectFile()
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            ' Me.TxtFilename.Text = Dl.SafeFileName
            Me.TxtSourceFile.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub
End Class