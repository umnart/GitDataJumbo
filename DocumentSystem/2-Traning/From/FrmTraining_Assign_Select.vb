Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmTraining_Assign_Select
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

    Private Sub TxtSelectType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSelectType.SelectedIndexChanged

        TxtCrseSetCode.DataSource = Nothing

        dgvDetail.Rows.Clear()

        Select Case TxtSelectType.Text
            Case "Basic Training"
                Call BasicTraining()
            Case "Course Set"
                Call CourseSet()
            Case "Course Type"
                Call CourseType()
        End Select
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
    Sub BasicTraining()

        Dim command As New SqlCommand("SELECT  DeptCodSet, CrseSetCode, CrseSetNam FROM  QEa_Training_CrseSet GROUP BY DeptCodSet, CrseSetCode, CrseSetNam HAVING DeptCodSet = 'SD'  AND (NOT (CrseSetCode LIKE '%SD%')) ORDER BY CrseSetCode  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEa_Training_CrseSet")
        If table.Rows.Count > 0 Then
            TxtCrseSetCode.DisplayMember = "CrseSetNam"
            TxtCrseSetCode.ValueMember = "CrseSetCode"
            TxtCrseSetCode.DataSource = ds.Tables("QEa_Training_CrseSet")

        End If

        Exit Sub
    End Sub

    Sub CourseSet()

        Dim command As New SqlCommand("SELECT  DeptCodSet, CrseSetCode, CrseSetNam FROM  QEa_Training_CrseSet GROUP BY DeptCodSet, CrseSetCode, CrseSetNam HAVING DeptCodSet = '" & strDeptData & "'  ORDER BY CrseSetCode  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEa_Training_CrseSet")
        If table.Rows.Count > 0 Then
            TxtCrseSetCode.DisplayMember = "CrseSetNam"
            TxtCrseSetCode.ValueMember = "CrseSetCode"
            TxtCrseSetCode.DataSource = ds.Tables("QEa_Training_CrseSet")

        End If

        Exit Sub
    End Sub

    Sub CourseType()

        Dim command As New SqlCommand("SELECT  DOCTYPE, CrseTypNam, ID FROM  QEa_Training_CourseType  ORDER BY ID  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)



        adapter.Fill(ds, "QEa_Training_CourseType")
        If table.Rows.Count > 0 Then
            TxtCrseSetCode.DisplayMember = "CrseTypNam"
            TxtCrseSetCode.ValueMember = "DOCTYPE"
            TxtCrseSetCode.DataSource = ds.Tables("QEa_Training_CourseType")
        End If


        Exit Sub
    End Sub

    Sub DeptDATASel()

        Dim command As New SqlCommand("SELECT  DeptCod FROM  QEm_Dept  ORDER BY DeptCod  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)


        adapter.Fill(ds, "QEm_Dept")
        If table.Rows.Count > 0 Then
            TxtDOCDEPT.DisplayMember = "DeptCod"
            TxtDOCDEPT.ValueMember = "DeptCod"
            TxtDOCDEPT.DataSource = ds.Tables("QEm_Dept")
        End If


        Exit Sub
    End Sub

    Private Sub FrmTraining_Assign_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Grid()
        '  Call LoadDataDeptDATA(strDeptData)
        Call DeptDATASel()

        TxtDOCDEPT.Text = ""
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        '  FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub TxtCrseSetCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtCrseSetCode.SelectedIndexChanged
        dgvDetail.Rows.Clear()
    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Me.dgvDetail.AllowUserToAddRows = True
        Select Case TxtSelectType.Text
            Case "Basic Training"
                Call LoadDataBasic()
            Case "Course Set"
                Call LoadDataCourseSet()
            Case "Course Type"
                Call LoadDataCourseType()

        End Select


        With Me.dgvDetail
            For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot

                If CType((.Rows(i).Cells(2).Value), String) = "เลือกเข้าแบบกำหนดเเล้ว" Then
                    .Item(0, i).ReadOnly = True
                End If

            Next
        End With


        Me.dgvDetail.AllowUserToAddRows = False
    End Sub


    Sub LoadDataBasic()
        Try



            Dim Sql As String = "SELECT  QEa_Training_CrseSet.CrseCode, QEa_Training_CrseSet.DeptCod, QEa_CourseMaster.DOCNAME,QEa_Training_CrseSet.RetrainFreq "
            Sql = Sql + "FROM  QEa_Training_CrseSet LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_CrseSet.CrseCode = QEa_CourseMaster.DOCNO "
            Sql = Sql + "WHERE QEa_Training_CrseSet.CrseSetCode = '" & TxtCrseSetCode.SelectedValue.ToString & "' "
            Sql = Sql + "AND QEa_Training_CrseSet.DeptCodSet = 'SD' "
            Sql = Sql + "GROUP BY QEa_Training_CrseSet.CrseCode, QEa_Training_CrseSet.DeptCod, QEa_CourseMaster.DOCNAME, QEa_Training_CrseSet.CrseSetNam,QEa_Training_CrseSet.RetrainFreq "
            Sql = Sql + "ORDER BY dbo.QEa_Training_CrseSet.CrseCode "
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            dgvDetail.Rows.Clear()

            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                With dgvDetail
                    ' intM = 1
                    'intW = 1
                    Dim criData As String = ""
                    Select Case strFormAssign
                        Case "Assign"
                            criData = "FROM  QEa_Training_Assign "
                        Case "Retraining"
                            criData = "FROM  QEa_Training_ReTaining_Assign "
                    End Select



                    Dim Sql1 As String = "SELECT EmployeeNo, DOCNO "
                    Sql1 = Sql1 + criData
                    Sql1 = Sql1 + "WHERE  EmployeeNo='" & StrEmployeeNoAssign & "' And DOCNO ='" & Dtr.Item("CrseCode").ToString & "' "


                    Dim Dt1 As New DataTable
                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                    Dim strStatus As String = ""
                    For Each Dtr1 As DataRow In Dt1.Rows
                        strStatus = "เลือกเข้าแบบกำหนดเเล้ว"
                    Next

                    Application.DoEvents()
                    .Rows.Add()
                    .Item(1, .Rows.Count - 2).Value = intNo
                    .Item(2, .Rows.Count - 2).Value = strStatus
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("CrseCode").ToString
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("DeptCod").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("DeptCod").ToString

                    If IsDBNull(Dtr.Item("RetrainFreq").ToString) Or Dtr.Item("RetrainFreq").ToString = "" Then
                        .Item(6, .Rows.Count - 2).Value = ""
                    Else
                        .Item(6, .Rows.Count - 2).Value = Dtr.Item("RetrainFreq").ToString

                    End If
                End With

                intNo = intNo + 1

            Next
        Catch ex As Exception

        End Try

    End Sub

    Sub LoadDataCourseSet()
        Try



            Dim Sql As String = "SELECT  QEa_Training_CrseSet.CrseCode, QEa_Training_CrseSet.DeptCod,QEa_Training_CrseSet.RetrainFreq, QEa_CourseMaster.DOCNAME "
            Sql = Sql + "FROM  QEa_Training_CrseSet LEFT OUTER JOIN QEa_CourseMaster ON QEa_Training_CrseSet.CrseCode = QEa_CourseMaster.DOCNO "
            Sql = Sql + "WHERE QEa_Training_CrseSet.CrseSetCode = '" & TxtCrseSetCode.SelectedValue.ToString & "' "
            Sql = Sql + "AND QEa_Training_CrseSet.DeptCodSet = '" & strDeptData & "' "
            Sql = Sql + "GROUP BY QEa_Training_CrseSet.CrseCode, QEa_Training_CrseSet.DeptCod,QEa_Training_CrseSet.RetrainFreq, QEa_CourseMaster.DOCNAME, QEa_Training_CrseSet.CrseSetNam "
            Sql = Sql + "ORDER BY dbo.QEa_Training_CrseSet.CrseCode "
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            dgvDetail.Rows.Clear()

            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                With dgvDetail
                    ' intM = 1
                    'intW = 1

                    Dim criData As String = ""
                    Select Case strFormAssign
                        Case "Assign"
                            criData = "FROM  QEa_Training_Assign "
                        Case "Retraining"
                            criData = "FROM  QEa_Training_ReTaining_Assign "
                    End Select

                    Dim Sql1 As String = "SELECT EmployeeNo, DOCNO "
                    Sql1 = Sql1 + criData
                    Sql1 = Sql1 + "WHERE  EmployeeNo='" & StrEmployeeNoAssign & "' And DOCNO ='" & Dtr.Item("CrseCode").ToString & "' "


                    Dim Dt1 As New DataTable
                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                    Dim strStatus As String = ""
                    For Each Dtr1 As DataRow In Dt1.Rows
                        strStatus = "เลือกเข้าแบบกำหนดเเล้ว"
                    Next



                    Application.DoEvents()
                    .Rows.Add()
                    .Item(1, .Rows.Count - 2).Value = intNo
                    .Item(2, .Rows.Count - 2).Value = strStatus
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("CrseCode").ToString
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("DeptCod").ToString

                    If IsDBNull(Dtr.Item("RetrainFreq").ToString) Or Dtr.Item("RetrainFreq").ToString = "" Then
                        .Item(6, .Rows.Count - 2).Value = ""
                    Else
                        .Item(6, .Rows.Count - 2).Value = Dtr.Item("RetrainFreq").ToString

                    End If


                End With

                intNo = intNo + 1

            Next

        Catch ex As Exception

        End Try
    End Sub


    Sub LoadDataCourseType()

        Try
            Dim cri As String = ""
            'Sql = Sql + " AND SELECTSYSTEM is null "

            strCri = TxtCrseSetCode.SelectedValue.ToString


            cri = "HAVING DOCTYPE = '" & strCri & "'"

            If TxtDOCDEPT.Text <> "" Then
                cri = cri & " AND DOCDEPT = '" & TxtDOCDEPT.Text & "'"
            End If

            'Dim Sql As String = "Select DOCNO, DOCNAME, DOCDEPT, DOCSHARE,SELECTSYSTEM "
            'Sql = Sql + " FROM QEa_CourseMaster"
            'Sql = Sql + " GROUP BY DOCNO, DOCNAME, DOCDEPT, DOCSHARE, DOCTYPE, STATUS,SELECTSYSTEM "
            'Sql = Sql + cri
            'Sql = Sql + " And STATUS = 'A'"
            'Sql = Sql + " Order by DOCNO asc"


            Dim Sql As String = "Select DOCNO, DOCNAME,DOCTYPE, DOCDEPT "
            Sql = Sql + " FROM QEa_CourseMaster"
            Sql = Sql + " GROUP BY DOCNO, DOCNAME, DOCDEPT,DOCTYPE,STATUS "
            Sql = Sql + cri
            Sql = Sql + " And STATUS = 'A'"
            Sql = Sql + " Order by DOCNO asc"
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            dgvDetail.Rows.Clear()
            Dim intNo As Integer = 1



            For Each Dtr As DataRow In Dt.Rows
                With dgvDetail
                    ' intM = 1
                    'intW = 1



                    Dim criData As String = ""
                    Select Case strFormAssign
                        Case "Assign"
                            criData = "FROM  QEa_Training_Assign "
                        Case "Retraining"
                            criData = "FROM  QEa_Training_ReTaining_Assign "
                    End Select


                    Dim Sql1 As String = "SELECT EmployeeNo, DOCNO "
                    Sql1 = Sql1 + criData
                    Sql1 = Sql1 + "WHERE  EmployeeNo='" & StrEmployeeNoAssign & "' And DOCNO ='" & Dtr.Item("DOCNO").ToString & "' "
                    ' Sql1 = Sql1 + "WHERE  EmployeeNo='" & FrmTraining_Assign.TxtEmployeeNo.SelectedValue.ToString & "' And DOCNO ='" & Dtr.Item("DOCNO").ToString & "' "


                    Dim Dt1 As New DataTable
                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                    Dim strStatus As String = ""
                    For Each Dtr1 As DataRow In Dt1.Rows
                        strStatus = "เลือกเข้าแบบกำหนดเเล้ว"
                    Next


                    Application.DoEvents()
                    .Rows.Add()
                    .Item(1, .Rows.Count - 2).Value = intNo
                    .Item(2, .Rows.Count - 2).Value = strStatus
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString

                End With

                intNo = intNo + 1

            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick
        SendKeys.Send("{Tab}")

        'With Me.dgvDetail
        '    For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot

        '        If CType((.Rows(i).Cells(2).Value), String) = "เลือกเข้าแบบกำหนดเเล้ว" Then
        '            .Item(0, i).Value = False
        '        End If

        '    Next
        'End With
    End Sub

    Private Sub bntOK_Click(sender As Object, e As EventArgs) Handles bntOK.Click

        Select Case strFormAssign
            Case "Assign"
                Call SelectData_Assign()
            Case "Retraining"
                Call SelectData_ReTraing()
        End Select

    End Sub

    Sub SelectData_Assign()
        With QEa_Training_Assign
            For Each row As DataGridViewRow In dgvDetail.Rows
                If CBool(row.Cells("Sel").Value) = True Then
                    If CStr(row.Cells("Status").Value) = "เลือกเข้าแบบกำหนดเเล้ว" Then
                        GoTo NEXTSTEP
                    End If
                    ' StrEmployeeNoAssign

                    'FrmTraining_Assign.TxtEmployeeNo.SelectedValue.ToString
                    CmdExcute("DELETE FROM QEa_Training_Assign WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' AND Dept ='" & strDeptData & "' AND DOCNO ='" & CStr(row.Cells("DOCNO").Value) & "' ", DB_CMD.ObjConn)


                    .EmployeeNo = StrEmployeeNoAssign
                    .DOCNO = CStr(row.Cells("DOCNO").Value)
                    .DOCDEPT = CStr(row.Cells("DOCDEPT").Value)
                    .MD = strMD
                    .Dept = strDeptData
                    .StartDate = FrmTraining_Assign.TxtStartDate.Text

                    If IsDBNull(CStr(row.Cells("RetrainFreq").Value)) Or CStr(row.Cells("RetrainFreq").Value) = "" Then
                        .RetrainFreq = "3 ปี"

                    Else
                        .RetrainFreq = CStr(row.Cells("RetrainFreq").Value)
                    End If
                    '.RetrainFreq = "3 ปี"
                    '.AssSeq = CStr(row.Cells("AssSeq").Value)
                    '.Assign = CStr(row.Cells("Assign").Value)
                    '.Trainer = CStr(row.Cells("Trainer").Value)
                    '.MthdCode = CStr(row.Cells("MthdCode").Value)
                    '.Approve = CStr(row.Cells("Approve").Value)

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
                End If
NEXTSTEP:
            Next
        End With

        StrFunction.AssignSel = 1
        Me.Close()

    End Sub


    Sub SelectData_ReTraing()

        With QEa_Training_ReTaining_Assign
            For Each row As DataGridViewRow In dgvDetail.Rows
                If CBool(row.Cells("Sel").Value) = True Then
                    If CStr(row.Cells("Status").Value) = "เลือกเข้าแบบกำหนดเเล้ว" Then
                        GoTo NEXTSTEP
                    End If
                    ' StrEmployeeNoAssign

                    'FrmTraining_Assign.TxtEmployeeNo.SelectedValue.ToString
                    CmdExcute("DELETE FROM QEa_Training_ReTaining_Assign WHERE EmployeeNo = '" & StrEmployeeNoAssign & "' AND Dept ='" & strDeptData & "' AND DOCNO ='" & CStr(row.Cells("DOCNO").Value) & "' ", DB_CMD.ObjConn)


                    .EmployeeNo = StrEmployeeNoAssign
                    .DOCNO = CStr(row.Cells("DOCNO").Value)
                    .DOCDEPT = CStr(row.Cells("DOCDEPT").Value)
                    .MD = strMD
                    .Dept = strDeptData
                    .StartDate = FrmTraining_Assign_ReTraining.TxtStartDate.Text
                    '.AssSeq = CStr(row.Cells("AssSeq").Value)
                    '.Assign = CStr(row.Cells("Assign").Value)
                    '.Trainer = CStr(row.Cells("Trainer").Value)
                    '.MthdCode = CStr(row.Cells("MthdCode").Value)
                    '.Approve = CStr(row.Cells("Approve").Value)

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
                End If
NEXTSTEP:
            Next
        End With

        StrFunction.ReTrainAssignSel = 1
        Me.Close()

    End Sub



    Private Sub chkSelectALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectALL.CheckedChanged
        With Me.dgvDetail
            For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                If chkSelectALL.Checked = True Then

                    If CType((.Rows(i).Cells(2).Value), String) = "เลือกเข้าแบบกำหนดเเล้ว" Then

                        .Item(0, i).Value = False
                    Else
                        .Item(0, i).Value = True
                    End If

                Else
                    .Item(0, i).Value = False
                End If

            Next
        End With
    End Sub

    Private Sub dgvDetail_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetail.CellFormatting
        'With Me.dgvDetail
        '    For i As Integer = 0 To .Rows.Count - 1

        '        If CType((dgvDetail.Rows(i).Cells(2).Value), String) = "เลือกเข้าแบบกำหนดเเล้ว" Then
        '            dgvData.Rows(i).DefaultCellStyle.ForeColor = Color.Red


        '        End If

        '    Next
        'End With
    End Sub

    Private Sub TxtDOCDEPT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCDEPT.SelectedIndexChanged

    End Sub
End Class