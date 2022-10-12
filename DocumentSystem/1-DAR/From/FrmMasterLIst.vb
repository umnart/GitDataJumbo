Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows
Public Class FrmMasterLIst

    Dim strConn As String
    Dim Conn As New SqlConnection
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
    Dim strDOCTYPE As String
    Dim strDOCNO As String = ""
    Dim strAttfile As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'Dim intNo As Integer = 4
        'Dim xxx As Integer = 1
        'For i As Integer = 1 To CInt(MetroComboBox1.Text)

        '    'MetroGrid1.Columns.Add(intNo)
        '    'MetroGrid1.ColumnCount = MetroComboBox1.Text + 4
        '    'MetroGrid1.Columns(intNo).Name = xxx

        '    intNo = intNo + 1
        '    xxx = xxx + 1
        'Next
    End Sub

    Private Sub FrmMasterLIst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Grid()
        Call CourseType()
    End Sub
    Sub CourseType()

        Dim command As New SqlCommand("SELECT  DOCTYPE, CrseTypNam, ID FROM  QEa_Training_CourseType  ORDER BY ID  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)



        adapter.Fill(ds, "QEa_Training_CourseType")
        If table.Rows.Count > 0 Then
            TxtDOCTYPEFind.DisplayMember = "CrseTypNam"
            TxtDOCTYPEFind.ValueMember = "DOCTYPE"
            TxtDOCTYPEFind.DataSource = ds.Tables("QEa_Training_CourseType")

        End If


        Exit Sub
    End Sub

    Private Sub TxtDOCTYPEFind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCTYPEFind.SelectedIndexChanged
        dgvData.Rows.Clear()
        dgvData.Columns.Clear()
        TxtFind.Text = ""
    End Sub
    Sub Grid()

        With Me.dgvData
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

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub dgvData_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseDoubleClick
        Try
            strDOCNO = ""
            strDOCNO = ""

            strDOCNO = CType(dgvData.Item(0, dgvData.CurrentRow.Index).Value, String)
            strAttfile = CType(dgvData.Item(6, dgvData.CurrentRow.Index).Value, String)
            If strAttfile <> "" Then
                Process.Start(strAttfile)
            End If
        Catch ex As Exception
            MsgBox("path ที่เก็บไฟล์ไม่ถูกต้อง  : " & strAttfile)
        End Try
    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click

        Try
            '
            Me.dgvData.AllowUserToAddRows = True
            ' Cursor = Cursors.WaitCursor
            strDOCTYPE = ""
            strDOCTYPE = TxtDOCTYPEFind.SelectedValue.ToString
            'Select Case TxtDOCTYPEFind.Text
            '    Case "MANUAL"
            '        strDOCTYPE = "MNL"
            '    Case "PROCEDURE"
            '        strDOCTYPE = "PRC"

            '    Case "WORK INSTRUCTION"
            '        strDOCTYPE = "WIN"

            '    Case "STANDARD DOCUMENT"
            '        strDOCTYPE = "STD"

            '    Case "RECORD"
            '        strDOCTYPE = "RCF"

            '    Case "KM"
            '        strDOCTYPE = "KMM"

            '    Case "Organization Chart"
            '        strDOCTYPE = "OGN"

            '    Case "Job Description"
            '        strDOCTYPE = "JOB"

            '    Case "HACCP"
            '        strDOCTYPE = "HAC"
            'End Select

            Dim strCri As String = ""

            strCri = "WHERE DOCTYPE ='" & strDOCTYPE & "' "

            If TxtFind.Text <> "" Then
                strCri = strCri & "AND DOCNO  Like '" & TxtFind.Text & "%' "
            End If

            'If TxtBRANCHDATA.Text <> "" Then
            '    strCri = strCri & "AND BRANCHDATA = '" & TxtBRANCHDATA.Text & "' "s
            'End If


            If TxtBRANCHDATA.Text <> "" Then
                strCri = strCri & "AND DOCSHARE = '" & TxtBRANCHDATA.Text & "' "
            End If

            If TxtDOCDEPT.Text <> "" Then
                strCri = strCri & "AND DOCDEPT  = '" & TxtDOCDEPT.Text & "' "
            End If


            Dim Sql As String = "Select MAX(REVNO) As MAXREVNO  from QEa_CourseMaster "
            Sql = Sql + strCri
            Sql = Sql + "HAVING (NOT (MAX(REVNO) IS NULL)) "

            Dim Dt As New DataTable
            If TxtBRANCHDATA.Text = "TP" Then

                If connTP.State = ConnectionState.Closed Then
                    connTP.ConnectionString = ClassConnect.ConnectionTP
                    connTP.Open()
                End If


                Dt = DB_CMD.GetData_Table(Sql, connTP)


            ElseIf TxtBRANCHDATA.Text = "KB" Then

                If connKB.State = ConnectionState.Closed Then
                    connKB.ConnectionString = ClassConnect.ConnectionKB
                    connKB.Open()
                End If

                Dt = DB_CMD.GetData_Table(Sql, connKB)
            Else
                Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            End If



            ' Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            dgvData.Rows.Clear()
            dgvData.Columns.Clear()

            For Each Dtr As DataRow In Dt.Rows
                dgvData.ColumnCount = 9
                dgvData.Columns(0).Name = "เอกสารเลขที่ Doc.NO."
                dgvData.Columns(1).Name = "ชื่อเรื่อง Title"
                dgvData.Columns(2).Name = "ผู้จัดทำ Issue By"
                dgvData.Columns(3).Name = "ผู้ใช้งาน Share to"
                dgvData.Columns(4).Name = "แก้ไขครั้งที่ Revision"
                dgvData.Columns(5).Name = "วันที่บังคับใช้ Effective date"
                dgvData.Columns(6).Name = "Attfile"
                dgvData.Columns(7).Name = "Status"
                dgvData.Columns(8).Name = "0"



                dgvData.Columns(0).Width = 100
                dgvData.Columns(1).Width = 200
                dgvData.Columns(2).Width = 60
                dgvData.Columns(3).Width = 80
                dgvData.Columns(4).Width = 90
                dgvData.Columns(5).Width = 115
                dgvData.Columns(6).Width = 0
                dgvData.Columns(7).Width = 0
                dgvData.Columns(8).Width = 80

                dgvData.Columns(6).Visible = False
                dgvData.Columns(7).Visible = False
                dgvData.Columns(8).Visible = True
                dgvData.Columns(5).Frozen = True

                dgvData.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                'dgvData.ColumnCount = 5
                'dgvData.ColumnCount = 5
                'dgvData.Columns(0).Name = "Doc.NO"
                'dgvData.Columns(1).Name = "ชื่อเอกสาร"
                'dgvData.Columns(2).Name = "Dept.Use"
                'dgvData.Columns(3).Name = "Attfile"
                'dgvData.Columns(4).Name = "0"

                'dgvData.Columns(0).Width = 100
                'dgvData.Columns(1).Width = 200
                'dgvData.Columns(2).Width = 60
                'dgvData.Columns(3).Width = 0
                'dgvData.Columns(4).Width = 80

                'dgvData.Columns(3).Visible = False
                ''dgvData.Columns(1).Frozen = True
                'With dgvData
                '    Dim intNo As Integer = 5
                '    Dim xxx As Integer = 1
                '    For i As Integer = 1 To CInt(Dtr.Item("MAXREVNO").ToString)


                '        dgvData.ColumnCount = CInt(Dtr.Item("MAXREVNO").ToString) + 5
                '        ' dgvData.Columns.Add(intNo)
                '        dgvData.Columns(intNo).Name = CType(xxx, String)
                '        dgvData.Columns(intNo).Width = 80

                '        intNo = intNo + 1
                '        xxx = xxx + 1
                '    Next

                'End With

                With dgvData
                    Dim intNo As Integer = 9
                    Dim xxx As Integer = 1
                    Dim intMAXREVNODATA As Integer = CInt(Dtr.Item("MAXREVNO").ToString) + 1
                    For i As Integer = 1 To intMAXREVNODATA

                        ' dgvData.ColumnCount = CInt(Dtr.Item("MAXREVNO").ToString) + 8
                        dgvData.ColumnCount = intMAXREVNODATA + 9
                        ' dgvData.Columns.Add(intNo)
                        dgvData.Columns(intNo).Name = CType(xxx, String)
                        dgvData.Columns(intNo).Width = 80
                        dgvData.Columns(intNo).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                        intNo = intNo + 1
                        xxx = xxx + 1
                    Next

                End With
            Next




            Dim Sql1 As String = "SELECT *  FROM QEa_CourseMaster "
            Sql1 = Sql1 + strCri
            Sql1 = Sql1 + "ORDER BY DOCNO, REVNO "

            Dim Dt1 As New DataTable

            '  Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)


            If TxtBRANCHDATA.Text = "TP" Then

                'If connTP.State = ConnectionState.Closed Then
                '    connTP.ConnectionString = ClassConnect.ConnectionTP
                '    connTP.Open()
                'End If


                Dt1 = DB_CMD.GetData_Table(Sql1, connTP)


            ElseIf TxtBRANCHDATA.Text = "KB" Then

                'If connKB.State = ConnectionState.Closed Then
                '    connKB.ConnectionString = ClassConnect.ConnectionKB
                '    connKB.Open()
                'End If

                Dt1 = DB_CMD.GetData_Table(Sql1, connKB)
            Else
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            End If

            Dim intNextREVNO As Integer = 1
            Dim intColumns As Integer = 9
            Dim strDOCNO As String = ""
            Dim strUPDDT As String = ""
            Dim strDonNOCheck As String = ""
            Dim strStatusChk As String = ""
            For Each Dtr1 As DataRow In Dt1.Rows
                With dgvData

                    '        ' intM = 1
                    '        'intW = 1

                    strDOCNO = Dtr1.Item("DOCNO").ToString.ToUpper
                    ' strDOCNO = strDOCNO.ToUpper

                    If strDonNOCheck <> strDOCNO Then

                        If strStatusChk = "ยกเลิก" Then
                            If strUPDDT <> "" Then
                                .Item(intColumns, .Rows.Count - 2).Value = "ยกเลิก" & "( " & strUPDDT & " )"
                            Else
                                .Item(intColumns, .Rows.Count - 2).Value = "ยกเลิก"
                            End If
                        Else
                                strStatusChk = ""
                        End If


                        strDonNOCheck = strDOCNO
                        intNextREVNO = 1
                        intColumns = 9
                    Else
                        intNextREVNO = intNextREVNO + 1
                    End If

                    If IsDBNull(Dtr1.Item("UPDDT").ToString) Or Dtr1.Item("UPDDT").ToString = "" Then
                        strUPDDT = ""
                    Else
                        strUPDDT = Dtr1.Item("UPDDT").ToString
                    End If


                    Application.DoEvents()
                    If intNextREVNO = 1 Then
                        .Rows.Add()
                        ' .Item(0, .Rows.Count - 2).Value = intNo


                        Dim intDEPTJOIN As Integer = 0
                        Dim strDEPTJOIN As String = ""

                        'dgvData.Columns(0).Name = "Doc.NO"
                        'dgvData.Columns(1).Name = "ชื่อเอกสาร"
                        'dgvData.Columns(2).Name = "ผู้จัดทำ Issue By"
                        'dgvData.Columns(3).Name = "ผู้ใช้งาน Share to"
                        'dgvData.Columns(4).Name = "แก้ไขครั้งที่ Revision"
                        'dgvData.Columns(5).Name = "วันที่บังคับใช้ Effective date"
                        'dgvData.Columns(6).Name = "Attfile"
                        'dgvData.Columns(7).Name = "0"

                        .Item(0, .Rows.Count - 2).Value = Dtr1.Item("DOCNO").ToString
                        .Item(1, .Rows.Count - 2).Value = Dtr1.Item("DOCNAME").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr1.Item("DOCDEPT").ToString


                        If IsDBNull(Dtr1.Item("DEPTJOIN").ToString) Or Dtr1.Item("DEPTJOIN").ToString = "" Then

                        Else

                            strDEPTJOIN = (Mid(Dtr1.Item("DEPTJOIN").ToString, 1, 15))
                            intDEPTJOIN = Len(strDEPTJOIN)

                        End If

                        If intDEPTJOIN > 14 Then
                            .Item(3, .Rows.Count - 2).Value = "ALL"
                        Else

                            If IsDBNull(Dtr1.Item("DEPTJOIN").ToString) Or Dtr1.Item("DEPTJOIN").ToString = "" Then
                                .Item(3, .Rows.Count - 2).Value = ""
                            Else
                                .Item(3, .Rows.Count - 2).Value = Dtr1.Item("DEPTJOIN").ToString
                            End If

                        End If

                        .Item(6, .Rows.Count - 2).Value = Dtr1.Item("AttachFile").ToString
                        .Item(Dtr1.Item("REVNO").ToString, .Rows.Count - 2).Value = Mid(Dtr1.Item("EFFDATE").ToString, 1, 10)

                        If Dtr1.Item("Status").ToString = "I" Then
                            .Item(7, .Rows.Count - 2).Value = "ยกเลิก"
                            strStatusChk = "ยกเลิก"
                        Else
                            .Item(7, .Rows.Count - 2).Value = ""
                            strStatusChk = ""
                        End If



                        Dim Sql11 As String = "Select MAX(REVNO) AS MAXREVNO, MAX(EFFDATE) AS MAXEFFDATE FROM  QEa_CourseMaster WHERE  DOCNO = '" & Dtr1.Item("DOCNO").ToString & "' "
                        Dim Dt11 As New DataTable
                        '  Dt11 = DB_CMD.GetData_Table(Sql11, DB_CMD.ObjConn)


                        If TxtBRANCHDATA.Text = "TP" Then

                            'If connTP.State = ConnectionState.Closed Then
                            '    connTP.ConnectionString = ClassConnect.ConnectionTP
                            '    connTP.Open()
                            'End If


                            Dt11 = DB_CMD.GetData_Table(Sql11, connTP)


                        ElseIf TxtBRANCHDATA.Text = "KB" Then

                            'If connKB.State = ConnectionState.Closed Then
                            '    connKB.ConnectionString = ClassConnect.ConnectionKB
                            '    connKB.Open()
                            'End If

                            Dt11 = DB_CMD.GetData_Table(Sql11, connKB)
                        Else
                            Dt11 = DB_CMD.GetData_Table(Sql11, DB_CMD.ObjConn)
                        End If


                        For Each Dtr11 As DataRow In Dt11.Rows

                            .Item(4, .Rows.Count - 2).Value = Dtr11.Item("MAXREVNO").ToString
                            .Item(5, .Rows.Count - 2).Value = Mid(Dtr11.Item("MAXEFFDATE").ToString, 1, 10)

                        Next

                    Else




                        .Item(intColumns, .Rows.Count - 2).Value = Mid(Dtr1.Item("EFFDATE").ToString, 1, 10)

                        intColumns = intColumns + 1

                    End If



                End With

            Next

            Me.dgvData.AllowUserToAddRows = False


            '  dgvData.AutoResizeColumns()
            Exit Sub
        Catch ex As Exception

        End Try
        '  Cursor = Cursors.Hand
        'End If
    End Sub

    Private Sub TxtFind_Click(sender As Object, e As EventArgs)
        dgvData.Rows.Clear()
        dgvData.Columns.Clear()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub dgvData_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvData.CellFormatting


        With Me.dgvData
            For i As Integer = 0 To .Rows.Count - 1

                If CType((dgvData.Rows(i).Cells(7).Value), String) = "ยกเลิก" Then
                    dgvData.Rows(i).DefaultCellStyle.ForeColor = Color.Red

                    ' dgvData.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                End If

            Next
        End With



        'For Each Row As DataGridViewRow In dgvData.Rows


        '    If dgvData.Item(0, .Rows.Count - 2).Value = "เปิดใบเเจ้งซ่อม" Then
        '        Row.DefaultCellStyle.ForeColor = Color.White

        '        Row.DefaultCellStyle.BackColor = Color.Orange

        '    End If


        '    If CStr(Row.Cells("JobStatus").Value) = "รอดำเนินการจากฝ่าย iT" Then
        '        Row.DefaultCellStyle.ForeColor = Color.White

        '        Row.DefaultCellStyle.BackColor = Color.Green

        '    End If





    End Sub

    Private Sub TxtDOCDEPT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCDEPT.SelectedIndexChanged
        dgvData.Rows.Clear()
        dgvData.Columns.Clear()
        TxtFind.Text = ""
    End Sub

    Private Sub TxtBRANCHDATA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtBRANCHDATA.SelectedIndexChanged
        dgvData.Rows.Clear()
        dgvData.Columns.Clear()
        TxtFind.Text = ""
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs) Handles TxtFind.TextChanged
        dgvData.Rows.Clear()
        dgvData.Columns.Clear()
        ' TxtFind.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class