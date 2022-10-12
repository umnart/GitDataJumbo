Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Reflection

Public Class FrmTraining_History
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
    Dim maxProcess As Integer
    Dim percentOfProcess, checkPercent As Double
    Dim strLoading As String
    Dim strSuccess As String
    Dim count As Integer
    Private Sub FrmTraining_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Call GetHostName()
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

    Private Sub bntClose_Click(sender As Object, e As EventArgs)
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub TxtMD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtMD.SelectedIndexChanged
        Select Case TxtMD.Text
            Case "รายเดือน"
                strMD = "M"
            Case "รายวัน"
                strMD = "D"

        End Select

        TxtEmployeeNo.DataSource = Nothing
        ' dgvDetail.Rows.Clear()
        Call GetPersonName()
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

    Private Sub bntDelete_Click(sender As Object, e As EventArgs)
        'If CheckData() = False Then
        '    MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
        '    Exit Sub
        'Else

        '    Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtEmployeeNo.SelectedValue.ToString & "    ออก จากรายการ หรือไม่?"
        '    If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        '    CmdExcute("DELETE FROM QEa_Training_Assign  WHERE EmployeeNo='" & TxtEmployeeNo.SelectedValue.ToString & "' ", DB_CMD.ObjConn)
        '    StrFunction.AssignSel = 1
        '    Call LoadData()
        '    '  Call LoadDataDetail()
        '    ' Call ShowCourseSet()
        'End If

        'FrmMainMenu.PictureBox2.Enabled = True
    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Me.Cursor = Cursors.WaitCursor


        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No , DOCNO,REVNO,EFFDATE,RetrainFreq,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,EmployeeNo,MD,Dept,ComName "
        Sql = Sql + "From QEa_Training_History_tmp  "
        Sql = Sql + "WHERE EmployeeNo = 'XXX' "
        Sql = Sql + "AND Dept = '" & strDeptData & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt


        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible = False

        'Call LoadDataHistory()
        Call LoadDataHistory15092022()  '15092022
        Call LoadDataRetraingFreq()

        Call LoadDataGrid()
    End Sub
    Sub LoadDataRetraingFreqNew19092022() '19092022


        Dim Sql As String = "SELECT  DOCNO, RetrainFreq, EmployeeNo, Dept, MD,Approve "
        Sql = Sql + "From QEa_Training_Assign  "
        Sql = Sql + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql = Sql + "AND Dept = '" & strDeptData & "'"
        Sql = Sql + "AND MD = '" & strMD & "' "
        Sql = Sql + "AND RetrainFreq <> ''"
        Sql = Sql + "ORDER BY DOCNO"

        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr As DataRow In Dt.Rows
            'LoadingForm.Show()
            'LoadingForm.SetData(Dt.Rows.Count, "ขั้นตอนสุดท้าย...(ตรวจสอบ Retaining Frequency)")
            'LoadingForm.Show()
            TextBox1.Visible = True
            Call SetData(Dt.Rows.Count, "ขั้นตอนสุดท้าย...(ตรวจสอบ Retaining Frequency)")

            Dim intFreqNo As Integer = 0

            Select Case Dtr.Item("RetrainFreq").ToString
                Case "6 เดือน"
                    intFreqNo = 6
                Case "1 ปี"
                    intFreqNo = 1
                Case "2 ปี"
                    intFreqNo = 2
                Case "3 ปี"
                    intFreqNo = 3
            End Select



            Dim Sql1 As String = "SELECT  MAX(REVNO) As MaxREVNO, MAX(TrnnDate) As MaxTrnnDate, MAX(RetrainFreq) As MaxRetrainFreq "
            Sql1 = Sql1 + "From QEa_Training_History  "
            Sql1 = Sql1 + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql1 = Sql1 + "AND Dept = '" & strDeptData & "'"
            Sql1 = Sql1 + "AND MD = '" & strMD & "' "
            Sql1 = Sql1 + "AND DOCNO = '" & Dtr.Item("DOCNO").ToString & "' "
            Dim Dt1 As New DataTable
            Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

            Dim intFreq As Integer = 0
            For Each Dtr1 As DataRow In Dt1.Rows

                'If Dtr.Item("DOCNO").ToString = "Att.6-2" Then
                '    MsgBox("XXXXX")
                'End If

                If IsDBNull(Dtr1.Item("MaxTrnnDate").ToString) Or Dtr1.Item("MaxTrnnDate").ToString = "" Then
                    GoTo NEXT_STEP1
                End If

                dtpCheck.Value = Dtr1.Item("MaxTrnnDate").ToString


                Select Case Dtr.Item("RetrainFreq").ToString
                    Case "6 เดือน"
                        dtpCheck.Value = dtpCheck.Value.AddMonths(+(CInt(intFreqNo)))
                    Case "1 ปี"
                        dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))
                    Case "2 ปี"
                        dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))
                    Case "3 ปี"
                        dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))

                End Select

                If dtpCheck.Value < dtpToday.Value Then


                    If IsDBNull(Dtr1.Item("MaxRetrainFreq").ToString) Or Dtr1.Item("MaxRetrainFreq").ToString = "" Then
                        intFreq = 1
                    Else
                        intFreq = Dtr1.Item("MaxRetrainFreq").ToString + 1

                    End If



                    Dim Sql99 As String = "SELECT  * "
                    Sql99 = Sql99 + "From QEa_Training_History  "
                    Sql99 = Sql99 + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
                    Sql99 = Sql99 + "AND Dept = '" & strDeptData & "'"
                    Sql99 = Sql99 + "AND DOCNO = '" & Dtr.Item("DOCNO").ToString & "' "
                    Sql99 = Sql99 + "AND REVNO = " & Dtr1.Item("MaxREVNO").ToString & " "
                    Sql99 = Sql99 + "AND RetrainFreq = " & Dtr1.Item("MaxRetrainFreq").ToString & " "
                    Sql99 = Sql99 + "ORDER BY DOCNO,REVNO"
                    Dim Dt99 As New DataTable
                    Dt99 = DB_CMD.GetData_Table(Sql99, DB_CMD.ObjConn)



                    Dim sqlinsert As String = ""
                    For Each Dtr99 As DataRow In Dt99.Rows

                        If IsDBNull(Dtr99.Item("MthdCode").ToString) Or Dtr99.Item("MthdCode").ToString = "" Then
                            MsgBox(" พนักงาน : '" & TxtEmployeeNo.Text & "' ยังไม่ได้ระบุ (Method Training ) ที่เมนู Training Assign  ", MsgBoxStyle.Information, "เเจ้งเดือนให้ทราบ")
                            Exit Sub
                        End If


                        sqlinsert = "INSERT INTO QEa_Training_History_tmp(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Result,Approve,Remark,MthdCode,MD,Dept,RetrainFreq,ComName) " &
                                            "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@RetrainFreq,@ComName)"

                        With comSave
                            .Parameters.Clear()
                            .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = TxtEmployeeNo.SelectedValue.ToString
                            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr99.Item("DOCNO").ToString
                            .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr99.Item("REVNO").ToString
                            .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)



                            Dim strCheckDocName As String = ""

                            Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr99.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                            Dim Dt21 As New DataTable
                            Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                            For Each Dtr21 As DataRow In Dt21.Rows
                                strCheckDocName = Dtr21.Item("DOCNAME").ToString
                                GoTo NEXT_STEP_DOCNAME

                            Next


NEXT_STEP_DOCNAME:

                            If strCheckDocName <> "" Then
                                .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = strCheckDocName
                            Else
                                .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = ""
                            End If

                            Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr99.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                            Dim Dt2 As New DataTable
                            Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                            For Each Dtr2 As DataRow In Dt2.Rows


                                .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString


                            Next

                            .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr99.Item("DOCDEPT").ToString
                            '.Parameters.Add("@TrnnDate", SqlDbType.Date).Value = ""
                            .Parameters.Add("@Result", SqlDbType.Int).Value = 0

                            If IsDBNull(Dtr.Item("Approve").ToString) Or Dtr.Item("Approve").ToString = "" Then
                                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr99.Item("Approve").ToString
                            Else
                                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                            End If



                            .Parameters.Add("@Remark", SqlDbType.VarChar).Value = ""
                            .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr99.Item("MthdCode").ToString
                            .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                            .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr99.Item("Dept").ToString


                            .Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = intFreq
                            .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                            .CommandText = sqlinsert
                            .Connection = DB_CMD.ObjConn
                            .ExecuteNonQuery()



                        End With


                    Next

                End If


            Next
NEXT_STEP1:
            Call nextProcess()
            Application.DoEvents()

        Next
        'Label3.Visible = False
        TextBox1.Visible = False

    End Sub
    Sub LoadDataRetraingFreq()
        Try



            Dim Sql As String = "SELECT  DOCNO, RetrainFreq, EmployeeNo, Dept, MD,Approve "
            Sql = Sql + "From QEa_Training_Assign  "
            Sql = Sql + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql = Sql + "AND Dept = '" & strDeptData & "'"
            Sql = Sql + "AND MD = '" & strMD & "' "
            Sql = Sql + "AND RetrainFreq <> ''"
            Sql = Sql + "ORDER BY DOCNO"
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

            Dim intNo As Integer = 1
            Dim strstatus As String = ""
            For Each Dtr As DataRow In Dt.Rows
                'LoadingForm.Show()
                'LoadingForm.SetData(Dt.Rows.Count, "ขั้นตอนสุดท้าย...(ตรวจสอบ Retaining Frequency)")
                'LoadingForm.Show()
                TextBox1.Visible = True
                Call SetData(Dt.Rows.Count, "ขั้นตอนสุดท้าย...(ตรวจสอบ Retaining Frequency)")

                Dim intFreqNo As Integer = 0

                Select Case Dtr.Item("RetrainFreq").ToString
                    Case "6 เดือน"
                        intFreqNo = 6
                    Case "1 ปี"
                        intFreqNo = 1
                    Case "2 ปี"
                        intFreqNo = 2
                    Case "3 ปี"
                        intFreqNo = 3

                End Select


                Dim Sql1 As String = "SELECT  MAX(REVNO) As MaxREVNO, MAX(TrnnDate) As MaxTrnnDate, MAX(RetrainFreq) As MaxRetrainFreq "
                Sql1 = Sql1 + "From QEa_Training_History  "
                Sql1 = Sql1 + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
                Sql1 = Sql1 + "AND Dept = '" & strDeptData & "'"
                Sql1 = Sql1 + "AND MD = '" & strMD & "' "
                Sql1 = Sql1 + "AND DOCNO = '" & Dtr.Item("DOCNO").ToString & "' "
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                Dim intFreq As Integer = 0
                For Each Dtr1 As DataRow In Dt1.Rows

                    'If Dtr.Item("DOCNO").ToString = "Att.6-2" Then
                    '    MsgBox("XXXXX")
                    'End If

                    If IsDBNull(Dtr1.Item("MaxTrnnDate").ToString) Or Dtr1.Item("MaxTrnnDate").ToString = "" Then
                        GoTo NEXT_STEP1
                    End If

                    dtpCheck.Value = Dtr1.Item("MaxTrnnDate").ToString


                    Select Case Dtr.Item("RetrainFreq").ToString
                        Case "6 เดือน"
                            dtpCheck.Value = dtpCheck.Value.AddMonths(+(CInt(intFreqNo)))
                        Case "1 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))
                        Case "2 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))
                        Case "3 ปี"
                            dtpCheck.Value = dtpCheck.Value.AddYears(+(CInt(intFreqNo)))

                    End Select

                    If dtpCheck.Value < dtpToday.Value Then


                        If IsDBNull(Dtr1.Item("MaxRetrainFreq").ToString) Or Dtr1.Item("MaxRetrainFreq").ToString = "" Then
                            intFreq = 1
                        Else
                            intFreq = Dtr1.Item("MaxRetrainFreq").ToString + 1

                        End If



                        Dim Sql99 As String = "SELECT  * "
                        Sql99 = Sql99 + "From QEa_Training_History  "
                        Sql99 = Sql99 + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
                        Sql99 = Sql99 + "AND Dept = '" & strDeptData & "'"
                        Sql99 = Sql99 + "AND DOCNO = '" & Dtr.Item("DOCNO").ToString & "' "
                        Sql99 = Sql99 + "AND REVNO = " & Dtr1.Item("MaxREVNO").ToString & " "
                        Sql99 = Sql99 + "AND RetrainFreq = " & Dtr1.Item("MaxRetrainFreq").ToString & " "
                        Sql99 = Sql99 + "ORDER BY DOCNO,REVNO"
                        Dim Dt99 As New DataTable
                        Dt99 = DB_CMD.GetData_Table(Sql99, DB_CMD.ObjConn)



                        Dim sqlinsert As String = ""
                        For Each Dtr99 As DataRow In Dt99.Rows

                            If IsDBNull(Dtr99.Item("MthdCode").ToString) Or Dtr99.Item("MthdCode").ToString = "" Then
                                MsgBox(" พนักงาน : '" & TxtEmployeeNo.Text & "' ยังไม่ได้ระบุ (Method Training ) ที่เมนู Training Assign  ", MsgBoxStyle.Information, "เเจ้งเดือนให้ทราบ")
                                Exit Sub
                            End If


                            sqlinsert = "INSERT INTO QEa_Training_History_tmp(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Result,Approve,Remark,MthdCode,MD,Dept,RetrainFreq,ComName) " &
                                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@RetrainFreq,@ComName)"

                            With comSave
                                .Parameters.Clear()
                                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = TxtEmployeeNo.SelectedValue.ToString
                                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr99.Item("DOCNO").ToString
                                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr99.Item("REVNO").ToString
                                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)



                                Dim strCheckDocName As String = ""

                                Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr99.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                                Dim Dt21 As New DataTable
                                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                                For Each Dtr21 As DataRow In Dt21.Rows
                                    strCheckDocName = Dtr21.Item("DOCNAME").ToString
                                    GoTo NEXT_STEP_DOCNAME

                                Next


NEXT_STEP_DOCNAME:

                                If strCheckDocName <> "" Then
                                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = strCheckDocName
                                Else
                                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = ""
                                End If

                                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr99.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                                Dim Dt2 As New DataTable
                                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                                For Each Dtr2 As DataRow In Dt2.Rows


                                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString


                                Next

                                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr99.Item("DOCDEPT").ToString
                                '.Parameters.Add("@TrnnDate", SqlDbType.Date).Value = ""
                                .Parameters.Add("@Result", SqlDbType.Int).Value = 0

                                If IsDBNull(Dtr.Item("Approve").ToString) Or Dtr.Item("Approve").ToString = "" Then
                                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr99.Item("Approve").ToString
                                Else
                                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                                End If



                                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = ""
                                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr99.Item("MthdCode").ToString
                                .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr99.Item("Dept").ToString


                                .Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = intFreq
                                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                                .CommandText = sqlinsert
                                .Connection = DB_CMD.ObjConn
                                .ExecuteNonQuery()



                            End With


                        Next

                    End If


                Next
NEXT_STEP1:
                Call nextProcess()
                Application.DoEvents()

            Next
            'Label3.Visible = False
            TextBox1.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือน")
            ' Exit Sub
        End Try

    End Sub
    Sub LoadDataHistory()



        ' dgvDetail.DataSource = Nothing
        ' dgvDetail.Rows.Clear()
        Dim sqlinsert As String
        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)
        Dim Dt As New DataTable

        CmdExcute("DELETE FROM QEa_Training_History_tmp  WHERE EmployeeNo='" & TxtEmployeeNo.SelectedValue.ToString & "' ", DB_CMD.ObjConn)


        Me.dgvDetail.AllowUserToAddRows = True
        '  dgvDetail.Rows.Clear()

        ' Select Case hISToRy

        Dim Sql99 As String = "SELECT  * "
        Sql99 = Sql99 + "From QEa_Training_History  "
        Sql99 = Sql99 + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql99 = Sql99 + "AND Dept = '" & strDeptData & "'"
        Sql99 = Sql99 + "ORDER BY DOCNO,REVNO"
        Dim Dt99 As New DataTable
        Dt99 = DB_CMD.GetData_Table(Sql99, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr99 As DataRow In Dt99.Rows
            LoadingForm.Show()
            LoadingForm.SetData(Dt99.Rows.Count, "Loadding... ")

            'With dgvDetail
            '    ' intM = 1
            '    'intW = 1


            '    Application.DoEvents()
            '    .Rows.Add()
            '    '.Item(0, .Rows.Count - 2).Value = intNo
            '    .Item(1, .Rows.Count - 2).Value = Dtr99.Item("DOCNO").ToString
            '    .Item(2, .Rows.Count - 2).Value = Dtr99.Item("REVNO").ToString
            '    .Item(3, .Rows.Count - 2).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)

            '    Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr99.Item("DOCNO").ToString & "' ORDER BY DOCNO "
            '    Dim Dt21 As New DataTable
            '    Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
            '    For Each Dtr21 As DataRow In Dt21.Rows
            '        .Item(4, .Rows.Count - 2).Value = Dtr21.Item("DOCNAME").ToString
            '    Next

            '    Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr99.Item("MthdCode").ToString & "' ORDER BY MthdCode "
            '    Dim Dt2 As New DataTable
            '    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            '    For Each Dtr2 As DataRow In Dt2.Rows
            '        .Item(5, .Rows.Count - 2).Value = Dtr2.Item("MthdNam").ToString
            '    Next
            '    .Item(6, .Rows.Count - 2).Value = Dtr99.Item("DOCDEPT").ToString
            '    .Item(7, .Rows.Count - 2).Value = Mid(Dtr99.Item("TrnnDate").ToString, 1, 10)

            '    If Dtr99.Item("Result").ToString = 1 Then
            '        .Item(8, .Rows.Count - 2).Value = 1
            '    End If

            '    '.Item(8, .Rows.Count - 2).Value = Dtr99.Item("Result")
            '    .Item(9, .Rows.Count - 2).Value = Dtr99.Item("Approve").ToString
            '    .Item(10, .Rows.Count - 2).Value = Dtr99.Item("Remark").ToString
            '    .Item(11, .Rows.Count - 2).Value = Dtr99.Item("MthdCode").ToString

            'End With

            ''intNo = intNo + 1



            '  If strstatus = "" Then

            If IsDBNull(Dtr99.Item("MthdCode").ToString) Or Dtr99.Item("MthdCode").ToString = "" Then

                MsgBox(" พนักงาน : '" & TxtEmployeeNo.Text & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign  ( '" & Dtr99.Item("DOCNO").ToString & "' ) ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                Exit Sub

            End If

            sqlinsert = "INSERT INTO QEa_Training_History_tmp(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,RetrainFreq,ComName) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@TrnnDate,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@RetrainFreq,@ComName)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = TxtEmployeeNo.SelectedValue.ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr99.Item("DOCNO").ToString
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr99.Item("REVNO").ToString
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)


                'Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr99.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                'Dim Dt21 As New DataTable
                'Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                'For Each Dtr21 As DataRow In Dt21.Rows
                '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
                'Next

                ' .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = "-"

                Dim Sql21 As String = "Select * From QEa_CourseMaster "
                Sql21 = Sql21 + " Where DOCNO ='" & Dtr99.Item("DOCNO").ToString & "' "
                Sql21 = Sql21 + " And REVNO In ( Select MAX(REVNO) From QEa_CourseMaster "
                Sql21 = Sql21 + " Where DOCNO ='" & Dtr99.Item("DOCNO").ToString & "') "

                Dim Dt21 As New DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)

                Dim strCheckDocName As String = ""

                For Each Dtr21 As DataRow In Dt21.Rows


                    'If Dtr99.Item("DOCNO").ToString = "S-QA-013" Then
                    '    MsgBox("xxxx")
                    'End If
                    strCheckDocName = Dtr21.Item("DOCNAME").ToString


                    GoTo NEXT_STEP99

                Next




NEXT_STEP99:

                If strCheckDocName <> "" Then
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = strCheckDocName
                Else
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = ""
                End If

                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr99.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                For Each Dtr2 As DataRow In Dt2.Rows
                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                Next

                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr99.Item("DOCDEPT").ToString

                If IsDBNull(Dtr99.Item("TrnnDate").ToString) Or (Dtr99.Item("TrnnDate").ToString) = "" Then
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = DBNull.Value
                Else
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr99.Item("TrnnDate").ToString, 1, 10)
                End If


                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr99.Item("Result").ToString = 1
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr99.Item("Approve").ToString
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr99.Item("Remark").ToString
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr99.Item("MthdCode").ToString
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr99.Item("Dept").ToString
                .Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = Dtr99.Item("RetrainFreq").ToString

                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With
            LoadingForm.nextProcess()
            Application.DoEvents()
        Next



        ' Exit Sub


        'Select Tranning Assign  MAXEFFDATE <= StartDate

        'Select StartDate For TrainingAssign
        Dim Sql9 As String = "Select    StartDate "
        Sql9 = Sql9 + "FROM QEa_Training_Assign "
        Sql9 = Sql9 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql9 = Sql9 + "AND Dept ='" & strDeptData & "' "
        Sql9 = Sql9 + "GROUP BY StartDate "
        Sql9 = Sql9 + "ORDER BY StartDate "
        Dim Dt9 As DataTable
        Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        For Each Dtr9 As DataRow In Dt9.Rows

            TxtStartDate.Text = Dtr9.Item("StartDate").ToString


            Dim Sql As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            Sql = Sql + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            Sql = Sql + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            Sql = Sql + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            Sql = Sql + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            Sql = Sql + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            Sql = Sql + " HAVING EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql = Sql + " AND QEa_CourseMaster.STATUS ='A' "
            Sql = Sql + " UNION "
            Sql = Sql + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            Sql = Sql + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            Sql = Sql + " And QEa_Training_Assign.EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql = Sql + " AND (QEa_CourseMaster.STATUS = 'A') "
            Sql = Sql + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            Sql = Sql + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "

            'Dim Sql As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            'Sql = Sql + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            'Sql = Sql + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            'Sql = Sql + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            'Sql = Sql + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            'Sql = Sql + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            'Sql = Sql + " HAVING EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            'Sql = Sql + " AND QEa_CourseMaster.STATUS ='A' "
            'Sql = Sql + " UNION "
            'Sql = Sql + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            'Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            'Sql = Sql + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            'Sql = Sql + " And QEa_Training_Assign.EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            'Sql = Sql + " AND (QEa_CourseMaster.STATUS = 'A') "
            'Sql = Sql + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            'Sql = Sql + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "


            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


            'Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows

                If IsDBNull(Dtr.Item("MthdCode").ToString) Or Dtr.Item("MthdCode").ToString = "" Then
                    MsgBox(" พนักงาน : '" & TxtEmployeeNo.Text & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                    Exit Sub
                End If

                'Dim XXXX As String = Dtr.Item("DOCNO").ToString

                'If XXXX = "W-GA-005A" Then
                '    MsgBox("xxxx")
                'End If

                Dim Sql91 As String = "Select  * "
                Sql91 = Sql91 + "FROM QEa_Training_History_tmp "
                Sql91 = Sql91 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
                Sql91 = Sql91 + "AND Dept ='" & strDeptData & "' "
                Sql91 = Sql91 + "AND DOCNO ='" & Dtr.Item("DOCNO").ToString & "' "
                Sql91 = Sql91 + "AND REVNO ='" & Dtr.Item("MAXREVNO").ToString & "' "
                Sql91 = Sql91 + "ORDER BY DOCNO, REVNO "
                Dim Dt91 As DataTable
                Dt91 = DB_CMD.GetData_Table(Sql91, DB_CMD.ObjConn)
                For Each Dtr91 As DataRow In Dt91.Rows
                    GoTo NEXTSTEPDATA
                Next


                sqlinsert = "INSERT INTO QEa_Training_History_tmp(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,RetrainFreq,ComName) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@RetrainFreq,@ComName)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = TxtEmployeeNo.SelectedValue.ToString
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString
                    .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr.Item("MAXREVNO").ToString
                    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr.Item("MAXEFFDATE")
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr.Item("DOCNAME").ToString
                    Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                    Dim Dt2 As New DataTable
                    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                    For Each Dtr2 As DataRow In Dt2.Rows
                        .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                    Next

                    ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr.Item("DOCDEPT").ToString
                    .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr.Item("Approve").ToString
                    .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr.Item("MthdCode").ToString
                    .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                    .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                    .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                    .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0
                    .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With


NEXTSTEPDATA:

            Next

            '***************** Update Program 13/10/2021 ***************************

            'With dgvDetail
            '        ' intM = 1
            '        'intW = 1

            '        Application.DoEvents()
            '        .Rows.Add()
            '        '.Item(0, .Rows.Count - 2).Value = intNo
            '        .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
            '        .Item(2, .Rows.Count - 2).Value = Dtr.Item("MAXREVNO").ToString
            '        .Item(3, .Rows.Count - 2).Value = Mid(Dtr.Item("MAXEFFDATE").ToString, 1, 10)
            '        .Item(4, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString

            '        Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
            '        Dim Dt2 As New DataTable
            '        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            '        For Each Dtr2 As DataRow In Dt2.Rows
            '            .Item(5, .Rows.Count - 2).Value = Dtr2.Item("MthdNam").ToString
            '        Next
            '        .Item(6, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString
            '        .Item(9, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
            '        .Item(11, .Rows.Count - 2).Value = Dtr.Item("MthdCode").ToString

            '    End With
            '***************** Update Program 13/10/2021 ***************************



        Next


        '****************************  PROGRAM UPDATE 01/10/2021  ********************************

        '            'Select Tranning Assign MAXEFFDATE > StartDate

        '            Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO , QEa_CourseMaster.EFFDATE,QEa_Training_Assign.StartDate "
        '            Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
        '            Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) > '" & TxtStartDate.Text & "' "
        '            Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
        '            Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') "
        '            Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
        '            Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, QEa_CourseMaster.REVNO "
        '            Dim Dt1 As New DataTable
        '            Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
        '            'dgvDetail.Rows.Clear()

        '            'Dim intNo As Integer = 1
        '            For Each Dtr1 As DataRow In Dt1.Rows
        '                With dgvDetail
        '                    ' intM = 1
        '                    'intW = 1

        '                    If Dtr1.Item("DOCNO").ToString = "F-GA-017" Then
        '                        MsgBox("XXXXXXX")
        '                    End If


        '                    Dim Sql10 As String = "Select  *  "
        '                    Sql10 = Sql10 + "FROM QEa_Training_Assign "
        '                    Sql10 = Sql10 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
        '                    Sql10 = Sql10 + "AND Dept ='" & strDeptData & "' "
        '                    Sql10 = Sql10 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
        '                    Sql10 = Sql10 + "ORDER BY StartDate "
        '                    Dim Dt10 As DataTable
        '                    Dt10 = DB_CMD.GetData_Table(Sql10, DB_CMD.ObjConn)
        '                    For Each Dtr10 As DataRow In Dt10.Rows

        '                        '  GoTo NEXTSTEP_1

        '                        Application.DoEvents()
        '                        .Rows.Add()
        '                        ' .Item(0, .Rows.Count - 2).Value = intNo
        '                        .Item(1, .Rows.Count - 2).Value = Dtr1.Item("DOCNO").ToString
        '                        .Item(2, .Rows.Count - 2).Value = Dtr1.Item("REVNO").ToString
        '                        .Item(3, .Rows.Count - 2).Value = Dtr1.Item("EFFDATE").ToString
        '                        .Item(4, .Rows.Count - 2).Value = Dtr1.Item("DOCNAME").ToString

        '                        Dim Sql4 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr1.Item("MthdCode").ToString & "' ORDER BY MthdCode "
        '                        Dim Dt4 As New DataTable
        '                        Dt4 = DB_CMD.GetData_Table(Sql4, DB_CMD.ObjConn)
        '                        For Each Dtr4 As DataRow In Dt4.Rows
        '                            .Item(5, .Rows.Count - 2).Value = Dtr4.Item("MthdNam").ToString
        '                        Next
        '                        ' .Item(6, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
        '                        ' .Item(7, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
        '                        .Item(9, .Rows.Count - 2).Value = Dtr1.Item("Approve").ToString
        '                        '.Item(9, .Rows.Count - 2).Value = Dtr.Item("Assign").ToString
        '                        '.Item(10, .Rows.Count - 2).Value = Dtr.Item("Trainer").ToString
        '                        '.Item(11, .Rows.Count - 2).Value = Dtr.Item("MthdCode").ToString


        '                    Next



        '                End With

        '                ' intNo = intNo + 1

        'NEXTSTEP_1:

        '            Next

        '****************************  PROGRAM UPDATE 01/10/2021  ********************************


        'Next


        ' dgvDetail.Sort( = "State, ZipCode DESC"




        '  dgvDetail.Sort(dgvDetail.Columns(1), ComponentModel.ListSortDirection.Ascending)
        ' dgvDetail.Sort(dgvDetail.Columns(2), ComponentModel.ListSortDirection.Ascending)
        ' dgvDetail.AutoResizeColumns()

        ' dgvDetail.ShowSortNumbers = True


        ' dgvDetail.Columns(1).DisplayIndex = 0
        'dgvDetail.Columns(2).DisplayIndex = 1




        Call SelectStartDate()

        '   Catch ex As Exception

        '  End Try


        ' Dim command As New SqlCommand("SELECT * FROM  QEa_Training_History_tmp WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' AND Dept = '" & strDeptData & "'  ORDER BY EmployeeNo, DOCNO, REVNO ", DB_CMD.ObjConn)
        'Dim table As New DataTable
        'Dim adapter As New SqlDataAdapter(command)
        'Dim ds As New DataSet
        'adapter.Fill(table)

        'adapter.Fill(ds, "QEa_Training_History_tmp")
        'If table.Rows.Count > 0 Then

        '    dgvDetail.DataSource = ds.Tables("QEa_Training_History_tmp")


        'End If

        ' Call LoadDataGrid()
        'Call LoadData()

        '  MsgBox("OK")



        Me.dgvDetail.AllowUserToAddRows = False
        ' Return Nothing

    End Sub

    Sub LoadDataHistory15092022() '15092022



        ' dgvDetail.DataSource = Nothing
        ' dgvDetail.Rows.Clear()
        Dim sqlinsert As String
        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)
        Dim Dt As New DataTable

        CmdExcute("DELETE FROM QEa_Training_History_tmp  WHERE EmployeeNo='" & TxtEmployeeNo.SelectedValue.ToString & "' ", DB_CMD.ObjConn)


        Me.dgvDetail.AllowUserToAddRows = True
        '  dgvDetail.Rows.Clear()

        ' Select Case hISToRy

        Dim Sql99 As String = "SELECT  * "
        Sql99 = Sql99 + "From QEa_Training_History  "
        Sql99 = Sql99 + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql99 = Sql99 + "AND Dept = '" & strDeptData & "'"
        Sql99 = Sql99 + "ORDER BY DOCNO,REVNO"
        Dim Dt99 As New DataTable
        Dt99 = DB_CMD.GetData_Table(Sql99, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr99 As DataRow In Dt99.Rows
            ' LoadingForm.Show()
            ' LoadingForm.SetData(Dt99.Rows.Count, "Loading...Check Hoistory : ")
            TextBox1.Visible = True
            Call SetData(Dt99.Rows.Count, "Loading...Check Hoistory :")
            'With dgvDetail
            '    ' intM = 1
            '    'intW = 1


            '    Application.DoEvents()
            '    .Rows.Add()
            '    '.Item(0, .Rows.Count - 2).Value = intNo
            '    .Item(1, .Rows.Count - 2).Value = Dtr99.Item("DOCNO").ToString
            '    .Item(2, .Rows.Count - 2).Value = Dtr99.Item("REVNO").ToString
            '    .Item(3, .Rows.Count - 2).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)

            '    Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr99.Item("DOCNO").ToString & "' ORDER BY DOCNO "
            '    Dim Dt21 As New DataTable
            '    Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
            '    For Each Dtr21 As DataRow In Dt21.Rows
            '        .Item(4, .Rows.Count - 2).Value = Dtr21.Item("DOCNAME").ToString
            '    Next

            '    Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr99.Item("MthdCode").ToString & "' ORDER BY MthdCode "
            '    Dim Dt2 As New DataTable
            '    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            '    For Each Dtr2 As DataRow In Dt2.Rows
            '        .Item(5, .Rows.Count - 2).Value = Dtr2.Item("MthdNam").ToString
            '    Next
            '    .Item(6, .Rows.Count - 2).Value = Dtr99.Item("DOCDEPT").ToString
            '    .Item(7, .Rows.Count - 2).Value = Mid(Dtr99.Item("TrnnDate").ToString, 1, 10)

            '    If Dtr99.Item("Result").ToString = 1 Then
            '        .Item(8, .Rows.Count - 2).Value = 1
            '    End If

            '    '.Item(8, .Rows.Count - 2).Value = Dtr99.Item("Result")
            '    .Item(9, .Rows.Count - 2).Value = Dtr99.Item("Approve").ToString
            '    .Item(10, .Rows.Count - 2).Value = Dtr99.Item("Remark").ToString
            '    .Item(11, .Rows.Count - 2).Value = Dtr99.Item("MthdCode").ToString

            'End With

            ''intNo = intNo + 1



            '  If strstatus = "" Then

            If IsDBNull(Dtr99.Item("MthdCode").ToString) Or Dtr99.Item("MthdCode").ToString = "" Then
                TextBox1.Visible = False
                percentOfProcess = 0
                count = 0
                MsgBox(" พนักงาน : '" & TxtEmployeeNo.Text & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign  ( '" & Dtr99.Item("DOCNO").ToString & "' ) ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                Exit Sub

            End If

            sqlinsert = "INSERT INTO QEa_Training_History_tmp(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,MD,Dept,RetrainFreq,ComName) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@TrnnDate,@Result,@Approve,@Remark,@MthdCode,@MD,@Dept,@RetrainFreq,@ComName)"

            With comSave
                .Parameters.Clear()
                .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = TxtEmployeeNo.SelectedValue.ToString
                .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr99.Item("DOCNO").ToString
                .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr99.Item("REVNO").ToString
                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)


                'Dim Sql21 As String = "Select  DOCNAME, DOCNO From QEa_CourseMaster  GROUP BY DOCNAME, DOCNO  HAVING DOCNO = '" & Dtr99.Item("DOCNO").ToString & "' ORDER BY DOCNO "
                'Dim Dt21 As New DataTable
                'Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                'For Each Dtr21 As DataRow In Dt21.Rows
                '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
                'Next

                ' .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = "-"

                Dim Sql21 As String = "Select * From QEa_CourseMaster "
                Sql21 = Sql21 + " Where DOCNO ='" & Dtr99.Item("DOCNO").ToString & "' "
                Sql21 = Sql21 + " And REVNO In ( Select MAX(REVNO) From QEa_CourseMaster "
                Sql21 = Sql21 + " Where DOCNO ='" & Dtr99.Item("DOCNO").ToString & "') "

                Dim Dt21 As New DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)

                Dim strCheckDocName As String = ""

                For Each Dtr21 As DataRow In Dt21.Rows


                    'If Dtr99.Item("DOCNO").ToString = "S-QA-013" Then
                    '    MsgBox("xxxx")
                    'End If
                    strCheckDocName = Dtr21.Item("DOCNAME").ToString


                    GoTo NEXT_STEP99

                Next

NEXT_STEP99:
                If strCheckDocName <> "" Then
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = strCheckDocName
                Else
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = ""
                End If

                Dim Sql2 As String = "Select  * From QEa_Training_Method   WHERE MthdCode = '" & Dtr99.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                Dim Dt2 As New DataTable
                Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                For Each Dtr2 As DataRow In Dt2.Rows
                    .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                Next

                .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr99.Item("DOCDEPT").ToString

                If IsDBNull(Dtr99.Item("TrnnDate").ToString) Or (Dtr99.Item("TrnnDate").ToString) = "" Then
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = DBNull.Value
                Else
                    .Parameters.Add("@TrnnDate", SqlDbType.Date).Value = Mid(Dtr99.Item("TrnnDate").ToString, 1, 10)
                End If


                .Parameters.Add("@Result", SqlDbType.Int).Value = Dtr99.Item("Result").ToString = 1
                .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr99.Item("Approve").ToString
                .Parameters.Add("@Remark", SqlDbType.VarChar).Value = Dtr99.Item("Remark").ToString
                .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr99.Item("MthdCode").ToString
                .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                .Parameters.Add("@Dept", SqlDbType.VarChar).Value = Dtr99.Item("Dept").ToString
                .Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = Dtr99.Item("RetrainFreq").ToString

                .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName

                .CommandText = sqlinsert
                .Connection = DB_CMD.ObjConn
                .ExecuteNonQuery()

            End With
            'LoadingForm.nextProcess()
            Call nextProcess()
            Application.DoEvents()

        Next
        TextBox1.Visible = False


        ' Exit Sub


        'Select Tranning Assign  MAXEFFDATE <= StartDate

        'Select StartDate For TrainingAssign
        Dim Sql9 As String = "Select    StartDate "
        Sql9 = Sql9 + "FROM QEa_Training_Assign "
        Sql9 = Sql9 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql9 = Sql9 + "AND Dept ='" & strDeptData & "' "
        Sql9 = Sql9 + "GROUP BY StartDate "
        Sql9 = Sql9 + "ORDER BY StartDate "
        Dim Dt9 As DataTable
        Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        For Each Dtr9 As DataRow In Dt9.Rows '1-Start Step

            TxtStartDate.Text = Dtr9.Item("StartDate").ToString


            'Dim Sql As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            'Sql = Sql + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            'Sql = Sql + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            'Sql = Sql + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            'Sql = Sql + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            'Sql = Sql + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            'Sql = Sql + " HAVING EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            'Sql = Sql + " AND QEa_CourseMaster.STATUS ='A' "
            'Sql = Sql + " UNION "
            'Sql = Sql + "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO AS MAXREVNO , QEa_CourseMaster.EFFDATE as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            'Sql = Sql + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO "
            'Sql = Sql + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            'Sql = Sql + " And QEa_Training_Assign.EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            'Sql = Sql + " AND (QEa_CourseMaster.STATUS = 'A') "
            'Sql = Sql + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            'Sql = Sql + " ORDER BY QEa_Training_Assign.DOCNO, MAXREVNO "



            'Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


            Dim Sql As String = "SELECT A.DOCNO, MAX(B.REVNO) AS MAXREVNO "
            Sql = Sql + "FROM  QEa_Training_Assign AS A LEFT OUTER JOIN QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
            Sql = Sql + "WHERE A.EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql = Sql + " And CONVERT(DATE,B.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            Sql = Sql + "AND (B.STATUS = 'A')"
            Sql = Sql + " And CONVERT(DATE,A.StartDate,105) = '" & TxtStartDate.Text & "' "
            Sql = Sql + "GROUP BY A.DOCNO "
            Sql = Sql + "EXCEPT (Select Docno,REVNO "
            Sql = Sql + "FROM QEa_Training_History "
            Sql = Sql + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "')"
            Sql = Sql + "ORDER BY DOCNO "
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

            'Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                'LoadingForm.Show()
                ' LoadingForm.SetData(Dt.Rows.Count, "Check Effect Date(ชื่อพนักงาน :" & Dtr9.Item("EmployeeName").ToString & " เอกสาร:" & Dtr.Item("DOCNO").ToString & ")")
                TextBox1.Visible = True
                Call SetData(Dt.Rows.Count, "Check Effect Date(ชื่อพนักงาน :" & TxtEmployeeNo.Text & " เอกสาร:" & Dtr.Item("DOCNO").ToString & ")")





                ''Dim XXXX As String = Dtr.Item("DOCNO").ToString

                ''If XXXX = "W-GA-005A" Then
                ''    MsgBox("xxxx")
                ''End If

                'Dim Sql91 As String = "Select  * "
                'Sql91 = Sql91 + "FROM QEa_Training_History_tmp "
                'Sql91 = Sql91 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
                'Sql91 = Sql91 + "AND Dept ='" & strDeptData & "' "
                'Sql91 = Sql91 + "AND DOCNO ='" & Dtr.Item("DOCNO").ToString & "' "
                'Sql91 = Sql91 + "AND REVNO ='" & Dtr.Item("MAXREVNO").ToString & "' "
                'Sql91 = Sql91 + "ORDER BY DOCNO, REVNO "
                'Dim Dt91 As DataTable
                'Dt91 = DB_CMD.GetData_Table(Sql91, DB_CMD.ObjConn)
                'For Each Dtr91 As DataRow In Dt91.Rows
                '    GoTo NEXTSTEPDATA
                'Next


                Dim Sql21 As String = "SELECT  A.EmployeeNo, A.DOCNO, B.DOCNAME, A.DOCDEPT, A.MthdCode, A.Approve, B.STATUS, B.REVNO, B.EFFDATE, A.StartDate "
                Sql21 = Sql21 + "From QEa_Training_Assign AS A LEFT OUTER Join QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                Sql21 = Sql21 + "Where(A.EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "') "
                Sql21 = Sql21 + "And (B.STATUS = 'A') "
                Sql21 = Sql21 + "And (A.DOCNO = '" & Dtr.Item("DOCNO").ToString & "')"
                Sql21 = Sql21 + "And (B.REVNO = " & Dtr.Item("MAXREVNO").ToString & ")"
                Sql21 = Sql21 + "ORDER BY A.DOCNO, B.REVNO"
                Dim Dt21 As DataTable
                Dt21 = DB_CMD.GetData_Table(Sql21, DB_CMD.ObjConn)
                For Each Dtr21 As DataRow In Dt21.Rows


                    If IsDBNull(Dtr21.Item("MthdCode").ToString) Or Dtr21.Item("MthdCode").ToString = "" Then
                        TextBox1.Visible = False
                        percentOfProcess = 0
                        count = 0
                        MsgBox(" พนักงาน : '" & TxtEmployeeNo.Text & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                        Exit Sub
                    End If


                    sqlinsert = "INSERT INTO QEa_Training_History_tmp(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,RetrainFreq,ComName) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@RetrainFreq,@ComName)"

                    With comSave
                        .Parameters.Clear()
                        .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = TxtEmployeeNo.SelectedValue.ToString
                        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString
                        .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr.Item("MAXREVNO").ToString
                        .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr21.Item("EFFDATE")
                        .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr21.Item("DOCNAME").ToString
                        Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr21.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                        Dim Dt2 As New DataTable
                        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                        For Each Dtr2 As DataRow In Dt2.Rows
                            .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                        Next

                        ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                        .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr21.Item("DOCDEPT").ToString
                        .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr21.Item("Approve").ToString
                        .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr21.Item("MthdCode").ToString
                        .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                        .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                        .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                        .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0
                        .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                        .CommandText = sqlinsert
                        .Connection = DB_CMD.ObjConn
                        .ExecuteNonQuery()

                    End With

                    'LoadingForm.nextProcess()
                    'Application.DoEvents()


                    Call nextProcess()
                    Application.DoEvents()

                Next
NEXTSTEPDATA:

            Next

            TextBox1.Visible = False

            Dim Dt19 As DataTable
            Dim Sql19 As String = "SELECT A.DOCNO, B.REVNO "
            Sql19 = Sql19 + "FROM  QEa_Training_Assign AS A LEFT OUTER JOIN QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
            Sql19 = Sql19 + "WHERE A.EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql19 = Sql19 + " And CONVERT(DATE,B.EFFDATE,105) >= '" & TxtStartDate.Text & "' "
            Sql19 = Sql19 + "AND (B.STATUS = 'A')"
            Sql19 = Sql19 + " And CONVERT(DATE,A.StartDate,105) = '" & TxtStartDate.Text & "' "
            Sql19 = Sql19 + "GROUP BY A.DOCNO, B.REVNO "
            Sql19 = Sql19 + "EXCEPT (Select Docno,REVNO "
            Sql19 = Sql19 + "FROM QEa_Training_History "
            Sql19 = Sql19 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "')"
            Sql19 = Sql19 + "ORDER BY DOCNO "
            Dt19 = DB_CMD.GetData_Table(Sql19, DB_CMD.ObjConn)
            For Each Dtr19 As DataRow In Dt19.Rows
                ' GoTo NEXTSTEPDATA

                'LoadingForm.Show()
                'LoadingForm.SetData(Dt19.Rows.Count, "Check วันบังคับใช้ >= วันเข้างาน(ชื่อพนักงาน :" & TxtEmployeeNo.SelectedValue.ToString & " เอกสาร:" & Dtr19.Item("DOCNO").ToString & ")")

                TextBox1.Visible = True
                Call SetData(Dt19.Rows.Count, "Check วันบังคับใช้ >= วันเข้างาน(ชื่อพนักงาน :" & TxtEmployeeNo.SelectedValue.ToString & " เอกสาร:" & Dtr19.Item("DOCNO").ToString & ")")


                Dim Sql20 As String = "SELECT  A.EmployeeNo, A.DOCNO, B.DOCNAME, A.DOCDEPT, A.MthdCode, A.Approve, B.STATUS, B.REVNO, B.EFFDATE, A.StartDate "
                Sql20 = Sql20 + "From QEa_Training_Assign AS A LEFT OUTER Join QEa_CourseMaster AS B ON A.DOCNO = B.DOCNO "
                Sql20 = Sql20 + "Where(A.EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "') "
                Sql20 = Sql20 + "And (B.STATUS = 'A') "
                Sql20 = Sql20 + "And (A.DOCNO = '" & Dtr19.Item("DOCNO").ToString & "')"
                Sql20 = Sql20 + "And (B.REVNO = " & Dtr19.Item("REVNO").ToString & ")"
                Sql20 = Sql20 + "ORDER BY A.DOCNO, B.REVNO"
                Dim Dt20 As DataTable
                Dt20 = DB_CMD.GetData_Table(Sql20, DB_CMD.ObjConn)
                For Each Dtr20 As DataRow In Dt20.Rows

                    If IsDBNull(Dtr20.Item("MthdCode").ToString) Or Dtr20.Item("MthdCode").ToString = "" Then
                        TextBox1.Visible = False
                        percentOfProcess = 0
                        count = 0
                        MsgBox(" พนักงาน : '" & TxtEmployeeNo.Text & "' ยังไม่ได้ระบุ (Method Training ) :: กรุณาใส่ข้อมูลให้ครบด้วย ที่เมนู Training Assign ", MsgBoxStyle.Information, "เเจ้งเตือนให้ทราบ")
                        Exit Sub
                    End If



                    sqlinsert = "INSERT INTO QEa_Training_History_tmp(EmployeeNo,DOCNO,REVNO,EFFDATE,DOCNAME,MthdNam,DOCDEPT,Approve,MthdCode,MD,Dept,Result,RetrainFreq,ComName) " &
                                "VALUES(@EmployeeNo,@DOCNO,@REVNO,@EFFDATE,@DOCNAME,@MthdNam,@DOCDEPT,@Approve,@MthdCode,@MD,@Dept,@Result,@RetrainFreq,@ComName)"

                    With comSave
                        .Parameters.Clear()
                        .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = TxtEmployeeNo.SelectedValue.ToString
                        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr19.Item("DOCNO").ToString
                        .Parameters.Add("@REVNO", SqlDbType.Int).Value = Dtr19.Item("REVNO").ToString
                        .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = Dtr20.Item("EFFDATE")
                        .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr20.Item("DOCNAME").ToString
                        Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr20.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                        Dim Dt2 As New DataTable
                        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                        For Each Dtr2 As DataRow In Dt2.Rows
                            .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr2.Item("MthdNam").ToString
                        Next

                        ' .Parameters.Add("@MthdNam", SqlDbType.VarChar).Value = Dtr.Item("MthdNam").ToString
                        .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr20.Item("DOCDEPT").ToString
                        .Parameters.Add("@Approve", SqlDbType.VarChar).Value = Dtr20.Item("Approve").ToString
                        .Parameters.Add("@MthdCode", SqlDbType.VarChar).Value = Dtr20.Item("MthdCode").ToString
                        .Parameters.Add("@MD", SqlDbType.VarChar).Value = strMD
                        .Parameters.Add("@Dept", SqlDbType.VarChar).Value = strDeptData
                        .Parameters.Add("@Result", SqlDbType.Int).Value = 0
                        .Parameters.Add("@RetrainFreq", SqlDbType.Int).Value = 0
                        .Parameters.Add("@ComName", SqlDbType.VarChar).Value = strHostName
                        .CommandText = sqlinsert
                        .Connection = DB_CMD.ObjConn
                        .ExecuteNonQuery()

                    End With

                    ' LoadingForm.nextProcess()
                    ' Application.DoEvents()
                    Call nextProcess()
                    Application.DoEvents()

                Next

            Next
            TextBox1.Visible = False
            '***************** Update Program 13/10/2021 ***************************

            'With dgvDetail
            '        ' intM = 1
            '        'intW = 1

            '        Application.DoEvents()
            '        .Rows.Add()
            '        '.Item(0, .Rows.Count - 2).Value = intNo
            '        .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
            '        .Item(2, .Rows.Count - 2).Value = Dtr.Item("MAXREVNO").ToString
            '        .Item(3, .Rows.Count - 2).Value = Mid(Dtr.Item("MAXEFFDATE").ToString, 1, 10)
            '        .Item(4, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString

            '        Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
            '        Dim Dt2 As New DataTable
            '        Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            '        For Each Dtr2 As DataRow In Dt2.Rows
            '            .Item(5, .Rows.Count - 2).Value = Dtr2.Item("MthdNam").ToString
            '        Next
            '        .Item(6, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString
            '        .Item(9, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
            '        .Item(11, .Rows.Count - 2).Value = Dtr.Item("MthdCode").ToString

            '    End With
            '***************** Update Program 13/10/2021 ***************************



        Next '1-End_Step


        '****************************  PROGRAM UPDATE 01/10/2021  ********************************

        '            'Select Tranning Assign MAXEFFDATE > StartDate

        '            Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO , QEa_CourseMaster.EFFDATE,QEa_Training_Assign.StartDate "
        '            Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
        '            Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) > '" & TxtStartDate.Text & "' "
        '            Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
        '            Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') "
        '            Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
        '            Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, QEa_CourseMaster.REVNO "
        '            Dim Dt1 As New DataTable
        '            Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
        '            'dgvDetail.Rows.Clear()

        '            'Dim intNo As Integer = 1
        '            For Each Dtr1 As DataRow In Dt1.Rows
        '                With dgvDetail
        '                    ' intM = 1
        '                    'intW = 1

        '                    If Dtr1.Item("DOCNO").ToString = "F-GA-017" Then
        '                        MsgBox("XXXXXXX")
        '                    End If


        '                    Dim Sql10 As String = "Select  *  "
        '                    Sql10 = Sql10 + "FROM QEa_Training_Assign "
        '                    Sql10 = Sql10 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
        '                    Sql10 = Sql10 + "AND Dept ='" & strDeptData & "' "
        '                    Sql10 = Sql10 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
        '                    Sql10 = Sql10 + "ORDER BY StartDate "
        '                    Dim Dt10 As DataTable
        '                    Dt10 = DB_CMD.GetData_Table(Sql10, DB_CMD.ObjConn)
        '                    For Each Dtr10 As DataRow In Dt10.Rows

        '                        '  GoTo NEXTSTEP_1

        '                        Application.DoEvents()
        '                        .Rows.Add()
        '                        ' .Item(0, .Rows.Count - 2).Value = intNo
        '                        .Item(1, .Rows.Count - 2).Value = Dtr1.Item("DOCNO").ToString
        '                        .Item(2, .Rows.Count - 2).Value = Dtr1.Item("REVNO").ToString
        '                        .Item(3, .Rows.Count - 2).Value = Dtr1.Item("EFFDATE").ToString
        '                        .Item(4, .Rows.Count - 2).Value = Dtr1.Item("DOCNAME").ToString

        '                        Dim Sql4 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr1.Item("MthdCode").ToString & "' ORDER BY MthdCode "
        '                        Dim Dt4 As New DataTable
        '                        Dt4 = DB_CMD.GetData_Table(Sql4, DB_CMD.ObjConn)
        '                        For Each Dtr4 As DataRow In Dt4.Rows
        '                            .Item(5, .Rows.Count - 2).Value = Dtr4.Item("MthdNam").ToString
        '                        Next
        '                        ' .Item(6, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
        '                        ' .Item(7, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
        '                        .Item(9, .Rows.Count - 2).Value = Dtr1.Item("Approve").ToString
        '                        '.Item(9, .Rows.Count - 2).Value = Dtr.Item("Assign").ToString
        '                        '.Item(10, .Rows.Count - 2).Value = Dtr.Item("Trainer").ToString
        '                        '.Item(11, .Rows.Count - 2).Value = Dtr.Item("MthdCode").ToString


        '                    Next



        '                End With

        '                ' intNo = intNo + 1

        'NEXTSTEP_1:

        '            Next

        '****************************  PROGRAM UPDATE 01/10/2021  ********************************


        'Next


        ' dgvDetail.Sort( = "State, ZipCode DESC"




        '  dgvDetail.Sort(dgvDetail.Columns(1), ComponentModel.ListSortDirection.Ascending)
        ' dgvDetail.Sort(dgvDetail.Columns(2), ComponentModel.ListSortDirection.Ascending)
        ' dgvDetail.AutoResizeColumns()

        ' dgvDetail.ShowSortNumbers = True


        ' dgvDetail.Columns(1).DisplayIndex = 0
        'dgvDetail.Columns(2).DisplayIndex = 1




        Call SelectStartDate()

        '   Catch ex As Exception

        '  End Try


        ' Dim command As New SqlCommand("SELECT * FROM  QEa_Training_History_tmp WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' AND Dept = '" & strDeptData & "'  ORDER BY EmployeeNo, DOCNO, REVNO ", DB_CMD.ObjConn)
        'Dim table As New DataTable
        'Dim adapter As New SqlDataAdapter(command)
        'Dim ds As New DataSet
        'adapter.Fill(table)

        'adapter.Fill(ds, "QEa_Training_History_tmp")
        'If table.Rows.Count > 0 Then

        '    dgvDetail.DataSource = ds.Tables("QEa_Training_History_tmp")


        'End If

        ' Call LoadDataGrid()
        'Call LoadData()

        '  MsgBox("OK")



        Me.dgvDetail.AllowUserToAddRows = False
        ' Return Nothing

    End Sub

    Sub LoadDataGrid()

        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No ,DOCNO,REVNO,EFFDATE,RetrainFreq,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,EmployeeNo,MD,Dept,ComName "
        Sql = Sql + "From QEa_Training_History_tmp  "
        Sql = Sql + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql = Sql + "AND Dept = '" & strDeptData & "'"
        Sql = Sql + "ORDER BY DOCNO,REVNO,RetrainFreq"
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt
        'dgvDetail.Columns(12).Visible = False
        dgvDetail.Columns(13).Visible = False
        dgvDetail.Columns(14).Visible = False
        dgvDetail.Columns(15).Visible = False
        dgvDetail.Columns(16).Visible = False
        '  dgvDetail.Columns(16).Visible = False

    End Sub

    Sub LoadData()
        Dim Sql99 As String = "SELECT  * "
        Sql99 = Sql99 + "From QEa_Training_History_tmp  "
        Sql99 = Sql99 + "WHERE EmployeeNo = '" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql99 = Sql99 + "AND Dept = '" & strDeptData & "'"
        Sql99 = Sql99 + "ORDER BY DOCNO,REVNO"
        Dim Dt99 As New DataTable
        Dt99 = DB_CMD.GetData_Table(Sql99, DB_CMD.ObjConn)

        Dim intNo As Integer = 1
        Dim strstatus As String = ""
        For Each Dtr99 As DataRow In Dt99.Rows


            With dgvDetail
                ' intM = 1
                'intW = 1


                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr99.Item("DOCNO").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr99.Item("REVNO").ToString
                .Item(3, .Rows.Count - 2).Value = Mid(Dtr99.Item("EFFDATE").ToString, 1, 10)
                .Item(4, .Rows.Count - 2).Value = Dtr99.Item("RetrainFreq").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr99.Item("DOCNAME").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr99.Item("MthdNam").ToString

                .Item(7, .Rows.Count - 2).Value = Dtr99.Item("DOCDEPT").ToString
                .Item(8, .Rows.Count - 2).Value = Mid(Dtr99.Item("TrnnDate").ToString, 1, 10)

                If Dtr99.Item("Result").ToString = 1 Then
                    .Item(9, .Rows.Count - 2).Value = 1
                End If

                '.Item(8, .Rows.Count - 2).Value = Dtr99.Item("Result")
                .Item(10, .Rows.Count - 2).Value = Dtr99.Item("Approve").ToString
                .Item(11, .Rows.Count - 2).Value = Dtr99.Item("Remark").ToString
                .Item(12, .Rows.Count - 2).Value = Dtr99.Item("MthdCode").ToString

            End With

            intNo = intNo + 1
        Next


    End Sub

    Sub FindData()
        ' Dim strStartDate As String = substring(TxtStartDate.Text, 6, 4) & "-" & substring(TxtStartDate.Text, 3, 2) & "-" & substring(TxtStartDate.Text, 1, 2)

        Me.dgvDetail.AllowUserToAddRows = True
        dgvDetail.Rows.Clear()
        'Select Tranning Assign  MAXEFFDATE <= StartDate

        'Select StartDate For TrainingAssign
        Dim Sql9 As String = "Select    StartDate "
        Sql9 = Sql9 + "FROM QEa_Training_Assign "
        Sql9 = Sql9 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
        Sql9 = Sql9 + "AND Dept ='" & strDeptData & "' "
        Sql9 = Sql9 + "GROUP BY StartDate "
        Sql9 = Sql9 + "ORDER BY StartDate "
        Dim Dt9 As DataTable
        Dt9 = DB_CMD.GetData_Table(Sql9, DB_CMD.ObjConn)
        For Each Dtr9 As DataRow In Dt9.Rows

            TxtStartDate.Text = Dtr9.Item("StartDate").ToString


            Dim Sql As String = "SELECT QEa_Training_Assign.EmployeeNo, qEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, "
            Sql = Sql + "  MAX(QEa_CourseMaster.REVNO) AS MAXREVNO, MAX(QEa_CourseMaster.EFFDATE) as MAXEFFDATE ,QEa_Training_Assign.StartDate "
            Sql = Sql + " FROM  QEa_Training_Assign LEFT OUTER JOIN  QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            Sql = Sql + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) <= '" & TxtStartDate.Text & "' "
            Sql = Sql + " AND (CONVERT(DATE,QEa_Training_Assign.StartDate,105) ='" & TxtStartDate.Text & "') "
            Sql = Sql + " GROUP BY QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT,QEa_Training_Assign.MthdCode,QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_Training_Assign.StartDate "
            Sql = Sql + " HAVING EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql = Sql + " AND QEa_CourseMaster.STATUS ='A' "
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                With dgvDetail
                    ' intM = 1
                    'intW = 1


                    Application.DoEvents()
                    .Rows.Add()
                    '.Item(0, .Rows.Count - 2).Value = intNo
                    .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                    .Item(2, .Rows.Count - 2).Value = Dtr.Item("MAXREVNO").ToString
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("MAXEFFDATE").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString

                    Dim Sql2 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                    Dim Dt2 As New DataTable
                    Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
                    For Each Dtr2 As DataRow In Dt2.Rows

                        .Item(6, .Rows.Count - 2).Value = Dtr2.Item("MthdNam").ToString
                    Next
                    ' .Item(6, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                    ' .Item(7, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                    .Item(10, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                    '.Item(9, .Rows.Count - 2).Value = Dtr.Item("Assign").ToString
                    '.Item(10, .Rows.Count - 2).Value = Dtr.Item("Trainer").ToString
                    '.Item(11, .Rows.Count - 2).Value = Dtr.Item("MthdCode").ToString

                End With

                'intNo = intNo + 1

            Next


            'Select Tranning Assign MAXEFFDATE > StartDate

            Dim Sql1 As String = "SELECT QEa_Training_Assign.EmployeeNo, QEa_Training_Assign.DOCNO, QEa_CourseMaster.DOCNAME, QEa_Training_Assign.DOCDEPT, QEa_Training_Assign.MthdCode, QEa_Training_Assign.Approve, QEa_CourseMaster.STATUS, QEa_CourseMaster.REVNO , QEa_CourseMaster.EFFDATE,QEa_Training_Assign.StartDate "
            Sql1 = Sql1 + " FROM QEa_Training_Assign LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_Assign.DOCNO = QEa_CourseMaster.DOCNO AND QEa_Training_Assign.DOCDEPT = QEa_CourseMaster.DOCDEPT "
            Sql1 = Sql1 + " WHERE	CONVERT(DATE,QEa_CourseMaster.EFFDATE,105) > '" & TxtStartDate.Text & "' "
            Sql1 = Sql1 + " And QEa_Training_Assign.EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
            Sql1 = Sql1 + " AND (QEa_CourseMaster.STATUS = 'A') "
            Sql1 = Sql1 + " AND	CONVERT(DATE,QEa_Training_Assign.StartDate,105) = '" & TxtStartDate.Text & "' "
            Sql1 = Sql1 + " ORDER BY QEa_Training_Assign.DOCNO, QEa_CourseMaster.REVNO "
            Dim Dt1 As New DataTable
            Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            'dgvDetail.Rows.Clear()

            'Dim intNo As Integer = 1
            For Each Dtr1 As DataRow In Dt1.Rows
                With dgvDetail
                    ' intM = 1
                    'intW = 1

                    If Dtr1.Item("DOCNO").ToString = "F-GA-017" Then
                        MsgBox("XXXXXXX")
                    End If


                    Dim Sql10 As String = "Select  *  "
                    Sql10 = Sql10 + "FROM QEa_Training_Assign "
                    Sql10 = Sql10 + "WHERE EmployeeNo ='" & TxtEmployeeNo.SelectedValue.ToString & "' "
                    Sql10 = Sql10 + "AND Dept ='" & strDeptData & "' "
                    Sql10 = Sql10 + "AND DOCNO ='" & Dtr1.Item("DOCNO").ToString & "' "
                    Sql10 = Sql10 + "ORDER BY StartDate "
                    Dim Dt10 As DataTable
                    Dt10 = DB_CMD.GetData_Table(Sql10, DB_CMD.ObjConn)
                    For Each Dtr10 As DataRow In Dt10.Rows

                        '  GoTo NEXTSTEP_1

                        Application.DoEvents()
                        .Rows.Add()
                        ' .Item(0, .Rows.Count - 2).Value = intNo
                        .Item(1, .Rows.Count - 2).Value = Dtr1.Item("DOCNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr1.Item("REVNO").ToString
                        .Item(3, .Rows.Count - 2).Value = Dtr1.Item("EFFDATE").ToString
                        .Item(5, .Rows.Count - 2).Value = Dtr1.Item("DOCNAME").ToString

                        Dim Sql4 As String = "Select  * From QEa_Training_Method  WHERE MthdCode = '" & Dtr1.Item("MthdCode").ToString & "' ORDER BY MthdCode "
                        Dim Dt4 As New DataTable
                        Dt4 = DB_CMD.GetData_Table(Sql4, DB_CMD.ObjConn)
                        For Each Dtr4 As DataRow In Dt4.Rows
                            .Item(6, .Rows.Count - 2).Value = Dtr4.Item("MthdNam").ToString
                        Next
                        ' .Item(6, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                        ' .Item(7, .Rows.Count - 2).Value = Dtr.Item("Approve").ToString
                        .Item(10, .Rows.Count - 2).Value = Dtr1.Item("Approve").ToString
                        '.Item(9, .Rows.Count - 2).Value = Dtr.Item("Assign").ToString
                        '.Item(10, .Rows.Count - 2).Value = Dtr.Item("Trainer").ToString
                        '.Item(11, .Rows.Count - 2).Value = Dtr.Item("MthdCode").ToString


                    Next



                End With

                ' intNo = intNo + 1

NEXTSTEP_1:

            Next




        Next
        ' dgvDetail.Sort( = "State, ZipCode DESC"




        dgvDetail.Sort(dgvDetail.Columns(1), ComponentModel.ListSortDirection.Ascending)
        dgvDetail.Sort(dgvDetail.Columns(2), ComponentModel.ListSortDirection.Ascending)
        ' dgvDetail.AutoResizeColumns()

        ' dgvDetail.ShowSortNumbers = True


        dgvDetail.Columns(1).DisplayIndex = 0
        dgvDetail.Columns(2).DisplayIndex = 1


        Call SelectStartDate()

        '   Catch ex As Exception

        '  End Try

        Me.dgvDetail.AllowUserToAddRows = False

    End Sub

    Sub ConvertDatagridTODataTable()

        'Creating DataTable.
        Dim dt As New DataTable()

        'Adding the Columns.
        For Each column As DataGridViewColumn In dgvDetail.Columns
            dt.Columns.Add(column.HeaderText)
        Next

        'Adding the Rows.
        For Each row As DataGridViewRow In dgvDetail.Rows
            dt.Rows.Add()
            For Each cell As DataGridViewCell In row.Cells
                dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
            Next
        Next

        'Me.DataGridView1.DataSource = dt
        'Me.DataGridView1.AllowUserToAddRows = False

    End Sub
    Private Function substring(text As String, v1 As Integer, v2 As Integer) As String
        ' Throw New NotImplementedException()
    End Function

    Private Function substring(text As String) As String
        Throw New NotImplementedException()
    End Function

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
                TxtStartDate.Text = Dtr.Item("StartDate").ToString()
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtEmployeeNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtEmployeeNo.SelectedIndexChanged

        'Try


        Dim Sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY DOCNO) AS No , DOCNO,REVNO,EFFDATE,RetrainFreq,DOCNAME,MthdNam,DOCDEPT,TrnnDate,Result,Approve,Remark,MthdCode,EmployeeNo,MD,Dept,ComName "
        Sql = Sql + "From QEa_Training_History_tmp  "
            Sql = Sql + "WHERE EmployeeNo = 'XXX' "
            Sql = Sql + "AND Dept = '" & strDeptData & "'"
            Sql = Sql + "ORDER BY DOCNO,REVNO"
            Dim Dt As New DataTable
            Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
            Dim Da = New SqlDataAdapter(Cmd)
            Da.Fill(Dt)
            Da.Dispose()
            dgvDetail.DataSource = Dt


            dgvDetail.Columns(13).Visible = False
            dgvDetail.Columns(14).Visible = False
            dgvDetail.Columns(15).Visible = False
            dgvDetail.Columns(16).Visible = False
            '  dgvDetail.Columns(15).a

            'dgvDetail.DataSource = Nothing
            ' dgvDetail.Rows.Clear()
            ' dgvDetail.Columns.n
            ' dgvDetail.DataSource = Nothing
            ' dgvDetail.Rows.Clear()
            TxtStartDate.Text = ""
            Call SelectStartDate()

        '  Catch ex As Exception

        '  End Try
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtShowData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtShowData.SelectedIndexChanged
        ' dgvDetail.Rows.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'Call ConvertDatagridTODataTable()

        Call xxx()
    End Sub

    Sub xxx()
        Dim dt As New DataTable()
        For Each column As DataGridViewColumn In dgvDetail.Columns
            dt.Columns.Add(column.HeaderText)
        Next




        dt = dgvDetail.DataSource
        '     Me.dataGridView1.DataSource = dt
        'Me.dataGridView1.AllowUserToAddRows = False

        'Dim MyDataTable As New DataTable
        'MyDataTable = CType(dgvDetail.DataSource, DataTable)
        'Me.dataGridView1.DataSource = MyDataTable
        ''  MyDataTable.Clear()


        'Dim dt As DataTable = dgvDetail.GetDataTable()
        'Console.WriteLine($"cols: {dt.Columns.Count} rows: {dt.Rows.Count}")

        'Dim dt As New DataTable
        'dt = (DirectCast(dgvDetail.DataSource, DataTable))

        'Me.dataGridView1.DataSource = dt
    End Sub

    Private Sub dgvDetail_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick
        'strDocNo = Me.dgvDetail.Item(1, Me.dgvDetail.CurrentRow.Index).Value
        'strREVNO = Me.dgvDetail.Item(2, Me.dgvDetail.CurrentRow.Index).Value
        'StrEFFDATE = Me.dgvDetail.Item(3, Me.dgvDetail.CurrentRow.Index).Value
        'strDocName = Me.dgvDetail.Item(4, Me.dgvDetail.CurrentRow.Index).Value

        'strMthdCode = Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value
        'strDocDept = Me.dgvDetail.Item(6, Me.dgvDetail.CurrentRow.Index).Value
        'strTrainingDate = Me.dgvDetail.Item(7, Me.dgvDetail.CurrentRow.Index).Value
        'strResult = Me.dgvDetail.Item(8, Me.dgvDetail.CurrentRow.Index).Value
        'strApprove = Me.dgvDetail.Item(9, Me.dgvDetail.CurrentRow.Index).Value
        'strRemarkTraining = Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).Value


        ''  Dim newDataRow As DataGridViewRow
        ''newDataRow = dgvDetail.Rows()

        ''Me.dgvDetail.Item(9, Me.dgvDetail.CurrentRow.Index).Value = "released"
        'StrFunction.TrainingSel = 2
        'Try
        '    BackgroundWorker1.RunWorkerAsync()
        'Catch ex As Exception

        'End Try

        'FrmTraining_History_Edit.Close()
        'FrmTraining_History_Edit.ShowDialog()
    End Sub

    Private Sub dgvDetail_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetail.CellMouseDoubleClick

        intRetrainFreq = 0

        intRetrainFreq = Me.dgvDetail.Item(4, Me.dgvDetail.CurrentRow.Index).Value
        strDocNo = Me.dgvDetail.Item(1, Me.dgvDetail.CurrentRow.Index).Value
        strREVNO = Me.dgvDetail.Item(2, Me.dgvDetail.CurrentRow.Index).Value
        StrEFFDATE = Me.dgvDetail.Item(3, Me.dgvDetail.CurrentRow.Index).Value
        strDocName = Me.dgvDetail.Item(5, Me.dgvDetail.CurrentRow.Index).Value

        strMthdCode = Me.dgvDetail.Item(12, Me.dgvDetail.CurrentRow.Index).Value
        strDocDept = Me.dgvDetail.Item(7, Me.dgvDetail.CurrentRow.Index).Value
        If IsDBNull(Me.dgvDetail.Item(8, Me.dgvDetail.CurrentRow.Index).Value) Then
            strTrainingDate = ""
        Else
            strTrainingDate = Me.dgvDetail.Item(8, Me.dgvDetail.CurrentRow.Index).Value
        End If

        strResult = Me.dgvDetail.Item(9, Me.dgvDetail.CurrentRow.Index).Value

        strApproveName = Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).Value


        If IsDBNull(Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value) Then
            strRemarkTraining = ""
        Else
            strRemarkTraining = Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value
        End If




        'strDocNo = Me.dgvDetail.Item(1, Me.dgvDetail.CurrentRow.Index).Value
        'strREVNO = Me.dgvDetail.Item(2, Me.dgvDetail.CurrentRow.Index).Value
        'StrEFFDATE = Me.dgvDetail.Item(3, Me.dgvDetail.CurrentRow.Index).Value
        'strDocName = Me.dgvDetail.Item(5, Me.dgvDetail.CurrentRow.Index).Value

        'strMthdCode = Me.dgvDetail.Item(12, Me.dgvDetail.CurrentRow.Index).Value
        'strDocDept = Me.dgvDetail.Item(7, Me.dgvDetail.CurrentRow.Index).Value
        'If IsDBNull(Me.dgvDetail.Item(8, Me.dgvDetail.CurrentRow.Index).Value) Then
        '    strTrainingDate = ""
        'Else
        '    strTrainingDate = Me.dgvDetail.Item(8, Me.dgvDetail.CurrentRow.Index).Value
        'End If
        'strResult = Me.dgvDetail.Item(9, Me.dgvDetail.CurrentRow.Index).Value
        'strApprove = Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).Value
        'If IsDBNull(Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value) Then
        '    strRemarkTraining = ""
        'Else
        '    strRemarkTraining = Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value
        'End If

        '  Dim newDataRow As DataGridViewRow
        'newDataRow = dgvDetail.Rows()

        'Me.dgvDetail.Item(9, Me.dgvDetail.CurrentRow.Index).Value = "released"
        StrFunction.TrainingSel = 2
        StrFunction.TrainingDel = 2
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try


        Try
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception

        End Try

        FrmTraining_History_Edit.Close()
        FrmTraining_History_Edit.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntPrinting_Click(sender As Object, e As EventArgs) Handles bntPrinting.Click
        strEmployeeNoRpt = TxtEmployeeNo.SelectedValue.ToString
        strDeptRpt = strDeptData

        FrmTraining_History_TP.Close()
        FrmTraining_History_TP.MdiParent = FrmMainMenu
        FrmTraining_History_TP.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted


    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Do Until 1 = StrFunction.TrainingDel

            Console.WriteLine("Start.")

        Loop

        Console.WriteLine("stop.")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted

        'Call LoadDataHistory()

        If dgvDetail.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            dgvDetail.Rows.Remove(dgvDetail.SelectedRows(0))
            '.dgvDetail.CurrentRow.Index).Value
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If


    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click

        CmdExcute("DELETE FROM QEa_Training_History_tmp  WHERE ComName='" & strHostName & "' ", DB_CMD.ObjConn)

        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub dgvDetail_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDetail.KeyDown
        If e.Control And e.KeyCode = Keys.F Then

            form_center(frmAdvFinder)
            FrmAdvFinder.ShowDialog()

        End If
    End Sub

    Public Sub form_center(ByVal frm As Form, Optional ByVal parent As Form = Nothing)

        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        If Not parent Is Nothing Then
            r = parent.ClientRectangle
            x = r.Width - frm.Width + parent.Left
            y = r.Height - frm.Height + parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - frm.Width
            y = r.Height - frm.Height
        End If

        x = CInt(x / 2)
        y = CInt(y / 2)

        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(x, y)
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
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

        'StrFunction.AssignSel = 2
        'Try
        '    BackgroundWorker1.RunWorkerAsync()
        'Catch ex As Exception

        'End Try


        FrmTraining_History_Copy.Close()
        FrmTraining_History_Copy.ShowDialog()
    End Sub

    Private Sub bntReport_Click(sender As Object, e As EventArgs) Handles bntReport.Click
        strEmployeeNoRpt = TxtEmployeeNo.SelectedValue.ToString
        strDeptRpt = strDeptData

        FrmTraining_History_TP.Close()
        FrmTraining_History_TP.MdiParent = FrmMainMenu
        FrmTraining_History_TP.Show()
    End Sub

    Private Sub bntDeleteData_Click(sender As Object, e As EventArgs) Handles bntDeleteData.Click
        If CheckData() = False Then
            MsgBox("ใส่รายละเอียดให้ครบก่อนลบข้อมูล")
            Exit Sub
        Else

            Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtEmployeeNo.SelectedValue.ToString & "    ออก จากรายการ หรือไม่?"
            If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
            CmdExcute("DELETE FROM QEa_Training_History  WHERE EmployeeNo='" & TxtEmployeeNo.SelectedValue.ToString & "' AND Dept = '" & strDeptData & "' ", DB_CMD.ObjConn)
            dgvDetail.Rows.Clear()

        End If

        FrmMainMenu.PictureBox2.Enabled = True

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




    Public Sub SetData(ByVal max As Integer, Optional ByVal str As String = "", Optional ByVal success As String = "")
        maxProcess = max
        strLoading = str
        strSuccess = success
        'ProgressBar.Value = 0
        'GroupBox.Text = strLoading
    End Sub
    Public Sub nextProcess()
        count += 1
        percentOfProcess = Convert.ToDouble((count) / maxProcess) * 100
        percentOfProcess = Math.Floor(percentOfProcess)

        ' ProgressBar.Value = percentOfProcess

        If percentOfProcess <> checkPercent Then
            'GroupBox.Text = strLoading & "  " & percentOfProcess & "%"
            Me.TextBox1.Text = strLoading & "  " & percentOfProcess & "%"
            checkPercent = percentOfProcess
        End If

        If percentOfProcess = 100 Then
            '  MainMemuForm.Cursor = Cursors.Default
            Me.Cursor = Cursors.Default
            If strSuccess <> "" Then
                MsgBox(strSuccess, MsgBoxStyle.Information, "Success")
            End If

            percentOfProcess = 0
            count = 0

            Threading.Thread.Sleep(1000)
            'Me.Close()

        End If
    End Sub


End Class