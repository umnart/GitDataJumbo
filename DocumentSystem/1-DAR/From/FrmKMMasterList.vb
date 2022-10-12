Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows
Public Class FrmKMMasterList
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
    Private Sub FrmKMMasterList_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Grid()
        ' Call CourseType()
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
    'Sub CourseType()

    '    Dim command As New SqlCommand("SELECT  DOCTYPE, CrseTypNam, ID FROM  QEa_Training_CourseType  ORDER BY ID  ", DB_CMD.ObjConn)
    '    Dim table As New DataTable
    '    Dim adapter As New SqlDataAdapter(command)
    '    Dim ds As New DataSet
    '    adapter.Fill(table)



    '    adapter.Fill(ds, "QEa_Training_CourseType")
    '    If table.Rows.Count > 0 Then
    '        TxtDOCTYPEFind.DisplayMember = "CrseTypNam"
    '        TxtDOCTYPEFind.ValueMember = "DOCTYPE"
    '        TxtDOCTYPEFind.DataSource = ds.Tables("QEa_Training_CourseType")

    '    End If


    '    Exit Sub
    'End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub dgvData_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseDoubleClick
        Try
            strDOCNO = ""
            strAttfile = ""

            strDOCNO = CType(dgvData.Item(0, dgvData.CurrentRow.Index).Value, String)
            strAttfile = CType(dgvData.Item(8, dgvData.CurrentRow.Index).Value, String)
            If strAttfile <> "" Then
                Process.Start(strAttfile)
                strDOCNO = ""
                strAttfile = ""
            End If
        Catch ex As Exception
            MsgBox("path ที่เก็บไฟล์ไม่ถูกต้อง  : " & strAttfile)
            strDOCNO = ""
            strAttfile = ""
        End Try
    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click

        Try
            '
            Dim intnoRun As Integer = 0
            If TxtBRANCHDATA.Text = "" Then

                MsgBox("เลือกสาขาด้วยนะคะ", MsgBoxStyle.Exclamation, "เเจ้งเตือน")
                TxtBRANCHDATA.Focus()
                Exit Sub

            End If


            Me.dgvData.AllowUserToAddRows = True
            ' Cursor = Cursors.WaitCursor
            strDOCTYPE = ""
            ' strDOCTYPE = TxtDOCTYPEFind.SelectedValue.ToString

            Dim strCri As String = ""

            strCri = "WHERE A.DOCTYPE ='KMM' "

            If TxtFind.Text <> "" Then
                strCri = strCri & "AND DOCNO  ='" & TxtFind.Text & "' "
            End If



            If TxtBRANCHDATA.Text <> "" Then
                strCri = strCri & "AND DOCSHARE = '" & TxtBRANCHDATA.Text & "' "
            End If

            If TxtDOCDEPT.Text <> "" Then
                strCri = strCri & "AND DOCDEPT  = '" & TxtDOCDEPT.Text & "' "
            End If



            If TxtDOCNAME.Text <> "" Then
                strCri = strCri & "AND DOCNAME  LIKE '%" & TxtDOCNAME.Text & "%' "
            End If


            If strLavelLogon = "Medium" Then



                strCri = strCri & "And  B.Lavel <> 'Hight' "
                'strCri = strCri & "And  A.DOCDEPT ='" & strDeptData & "' "
            End If

            If strLavelLogon = "Hight" Then
                ' strCri = strCri & "And  B.Lavel = 'Hight' "
            End If

            If strLavelLogon = "Admin" Then
                ' strcri = strcri & "And Lavel = 'Hight' "
            End If



            Dim Sql As String = "Select MAX(A.REVNO) As MAXREVNO  From dbo.QEa_CourseMaster AS A LEFT OUTER Join  QEm_KM_Dept_SEL AS B ON A.DOCNO = B.DOCNO "
            Sql = Sql + strCri

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
                dgvData.ColumnCount = 11
                dgvData.Columns(0).Name = "NO."
                dgvData.Columns(1).Name = "KM NO."
                dgvData.Columns(2).Name = "KM Name"
                dgvData.Columns(3).Name = "Security Lavel"
                dgvData.Columns(4).Name = "แก้ไขครั้งที่ Revision"
                dgvData.Columns(5).Name = "วันที่บังคับใช้ Effective date"
                dgvData.Columns(6).Name = "Branch"
                dgvData.Columns(7).Name = "Dept"
                dgvData.Columns(8).Name = "Attfile"
                dgvData.Columns(9).Name = "Status"
                dgvData.Columns(10).Name = "0"



                dgvData.Columns(0).Width = 30
                dgvData.Columns(1).Width = 100
                dgvData.Columns(2).Width = 200
                dgvData.Columns(3).Width = 60
                dgvData.Columns(4).Width = 60
                dgvData.Columns(5).Width = 80
                dgvData.Columns(6).Width = 50
                dgvData.Columns(7).Width = 50
                dgvData.Columns(8).Width = 0
                dgvData.Columns(9).Width = 0
                dgvData.Columns(10).Width = 80


                ' dgvData.Columns(6).Visible = False
                dgvData.Columns(8).Visible = False
                dgvData.Columns(9).Visible = False
                dgvData.Columns(6).Frozen = True

                dgvData.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvData.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                With dgvData
                    Dim intNo As Integer = 11
                    Dim xxx As Integer = 1
                    Dim intMAXREVNODATA As Integer = CInt(Dtr.Item("MAXREVNO").ToString) + 1
                    For i As Integer = 1 To intMAXREVNODATA

                        ' dgvData.ColumnCount = CInt(Dtr.Item("MAXREVNO").ToString) + 8
                        dgvData.ColumnCount = intMAXREVNODATA + 11
                        ' dgvData.Columns.Add(intNo)
                        dgvData.Columns(intNo).Name = CType(xxx, String)
                        dgvData.Columns(intNo).Width = 80
                        dgvData.Columns(intNo).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                        intNo = intNo + 1
                        xxx = xxx + 1
                    Next

                End With
            Next


            Dim Sql1 As String = "Select A.DOCNO, MAX(A.EFFDATE) As MAXEFFDATE, A.DOCNAME, A.STATUS, A.DOCDEPT, A.REVNO,B.Lavel, A.EFFDATE, A.AttachFile, A.DEPTJOIN,A.DOCSHARE FROM QEa_CourseMaster AS A LEFT OUTER Join QEm_KM_Dept_SEL AS B ON A.DOCNO = B.DOCNO "
            Sql1 = Sql1 + strCri
            Sql1 = Sql1 + "GROUP BY A.DOCNAME, A.STATUS, A.DOCDEPT, A.REVNO, A.EFFDATE, A.AttachFile, A.DEPTJOIN, A.DOCNO,B.Lavel,A.DOCSHARE "
            Sql1 = Sql1 + "ORDER BY A.DOCNO, A.REVNO "

            Dim Dt1 As New DataTable




            If TxtBRANCHDATA.Text = "TP" Then



                Dt1 = DB_CMD.GetData_Table(Sql1, connTP)


            ElseIf TxtBRANCHDATA.Text = "KB" Then



                Dt1 = DB_CMD.GetData_Table(Sql1, connKB)
            Else
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
            End If

            Dim intNextREVNO As Integer = 1
            Dim intColumns As Integer = 11
            Dim strDOCNO As String = ""
            Dim strUPDDT As String = ""
            Dim strDonNOCheck As String = ""
            Dim strStatusChk As String = ""
            For Each Dtr1 As DataRow In Dt1.Rows
                With dgvData



                    If strLavelLogon = "Admin" Or strLavelLogon = "Hight" Then
                        GoTo NEXTSTEP_1
                    End If

                    Dim strDeptDATASel As String = ""
                    Dim command99 As New SqlCommand("SELECT  * FROM QEm_KM_Dept_SEL " &
                                     "WHERE DOCNO ='" & Dtr1.Item("DOCNO").ToString & "'" &
                                     "AND DeptDATA ='" & strDeptData & "'", DB_CMD.ObjConn)
                    Dim table99 As New DataTable
                    Dim adapter99 As New SqlDataAdapter(command99)
                    Dim ds99 As New DataSet
                    adapter99.Fill(table99)

                    If table99.Rows.Count > 0 Then

                        strDeptDATASel = CType(table99.Rows(0).Item("DeptDATA"), String)

                    End If




                    If strDeptData <> strDeptDATASel Then

                        Dim command As New SqlCommand("Select * FROM QEm_KM_UserView WHERE DOCNO = '" & Dtr1.Item("DOCNO").ToString & "' AND EmployeeNo ='" & StrEmployeeNo & "' ORDER BY DOCNO DESC ", DB_CMD.ObjConn)
                        Dim table As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        Dim ds As New DataSet
                        adapter.Fill(table)
                        adapter.Fill(ds, "QEm_KM_UserView")
                        If table.Rows.Count > 0 Then

                            GoTo NEXTSTEP_1

                        End If


                        If Dtr1.Item("Lavel").ToString <> "Low" Then
                            GoTo NEXTSTEP_2
                        End If
                    End If

NEXTSTEP_1:







                    strDOCNO = Dtr1.Item("DOCNO").ToString.ToUpper

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
                        intColumns = 11
                        intnoRun = intnoRun + 1
                    Else
                        intNextREVNO = intNextREVNO + 1
                    End If

                    'If IsDBNull(Dtr1.Item("UPDDT").ToString) Or Dtr1.Item("UPDDT").ToString = "" Then
                    '    strUPDDT = ""
                    'Else
                    '    strUPDDT = Dtr1.Item("UPDDT").ToString
                    'End If


                    Application.DoEvents()
                    If intNextREVNO = 1 Then
                        .Rows.Add()



                        Dim intDEPTJOIN As Integer = 0
                        Dim strDEPTJOIN As String = ""

                        .Item(0, .Rows.Count - 2).Value = intnoRun
                        .Item(1, .Rows.Count - 2).Value = Dtr1.Item("DOCNO").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr1.Item("DOCNAME").ToString
                        .Item(3, .Rows.Count - 2).Value = Dtr1.Item("Lavel").ToString
                        .Item(6, .Rows.Count - 2).Value = Dtr1.Item("DOCSHARE").ToString
                        .Item(7, .Rows.Count - 2).Value = Dtr1.Item("DOCDEPT").ToString




                        'If IsDBNull(Dtr1.Item("DEPTJOIN").ToString) Or Dtr1.Item("DEPTJOIN").ToString = "" Then

                        'Else

                        '    strDEPTJOIN = (Mid(Dtr1.Item("DEPTJOIN").ToString, 1, 15))
                        '    intDEPTJOIN = Len(strDEPTJOIN)

                        'End If

                        'If intDEPTJOIN > 14 Then
                        '    .Item(3, .Rows.Count - 2).Value = "ALL"
                        'Else

                        '    If IsDBNull(Dtr1.Item("DEPTJOIN").ToString) Or Dtr1.Item("DEPTJOIN").ToString = "" Then
                        '        .Item(3, .Rows.Count - 2).Value = ""
                        '    Else
                        '        .Item(3, .Rows.Count - 2).Value = Dtr1.Item("DEPTJOIN").ToString
                        '    End If

                        'End If

                        .Item(8, .Rows.Count - 2).Value = Dtr1.Item("AttachFile").ToString
                        .Item(Dtr1.Item("REVNO").ToString, .Rows.Count - 2).Value = Mid(Dtr1.Item("EFFDATE").ToString, 1, 10)

                        If Dtr1.Item("Status").ToString = "I" Then
                            .Item(9, .Rows.Count - 2).Value = "ยกเลิก"
                            strStatusChk = "ยกเลิก"
                        Else
                            .Item(9, .Rows.Count - 2).Value = ""
                            strStatusChk = ""
                        End If



                        Dim Sql11 As String = "Select MAX(REVNO) As MAXREVNO, MAX(EFFDATE) As MAXEFFDATE FROM  QEa_CourseMaster WHERE  DOCNO = '" & Dtr1.Item("DOCNO").ToString & "' "
                        Dim Dt11 As New DataTable


                        If TxtBRANCHDATA.Text = "TP" Then



                            Dt11 = DB_CMD.GetData_Table(Sql11, connTP)


                        ElseIf TxtBRANCHDATA.Text = "KB" Then



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

NEXTSTEP_2:



            Next

            Me.dgvData.AllowUserToAddRows = False

            Exit Sub
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

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
    End Sub

    Private Sub TxtBRANCHDATA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtBRANCHDATA.SelectedIndexChanged
        Call Clear()
    End Sub

    Sub Clear()

        dgvData.Rows.Clear()
        dgvData.Columns.Clear()
        TxtFind.Text = ""
        'TxtLavel.Text = ""
        'TxtDOCDEPT.Text = ""
        'TxtDOCNAME.Text = ""

    End Sub

    Private Sub TxtDOCDEPT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCDEPT.SelectedIndexChanged
        Call Clear()
    End Sub

    Private Sub TxtLavel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtLavel.SelectedIndexChanged
        Call Clear()
    End Sub

    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs) Handles TxtFind.TextChanged
        Call Clear()
    End Sub

    Private Sub TxtDOCNAME_TextChanged(sender As Object, e As EventArgs) Handles TxtDOCNAME.TextChanged
        Call Clear()
    End Sub
End Class