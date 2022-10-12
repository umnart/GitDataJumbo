Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows

Public Class FrmTraining_CrseSet_Select
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

    Private Sub FrmTraining_CrseSet_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvMain.AllowUserToAddRows = False

        Call CourseType()
        Call Grid
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


    Sub Grid()

        With Me.dgvMain
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

    Private Sub TxtDOCTYPEFind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCTYPEFind.SelectedIndexChanged
        Me.dgvMain.AllowUserToAddRows = True
        dgvMain.Rows.Clear()


        ' Cursor = Cursors.WaitCursor
        strDOCTYPE = ""
        'Select Case TxtDOCTYPEFind.Text
        '    Case "Manual"
        '        strDOCTYPE = "MNL"
        '    Case "Procedure"
        '        strDOCTYPE = "PRC"

        '    Case "Work Instruction"
        '        strDOCTYPE = "WIN"

        '    Case "Standard Document"
        '        strDOCTYPE = "STD"

        '    Case "Record Form"
        '        strDOCTYPE = "RCF"

        '    Case "Knowledge Management"
        '        strDOCTYPE = "KMM"

        '    Case "Organization Chart"
        '        strDOCTYPE = "OGN"

        '    Case "Job Description"
        '        strDOCTYPE = "JOB"

        '    Case "HACCP"
        '        strDOCTYPE = "HAC"
        'End Select

        Dim strCri As String = ""

        strDOCTYPE = TxtDOCTYPEFind.SelectedValue.ToString

        ' strCri = "WHERE DOCTYPE ='" & strDOCTYPE & "' "

        Dim Sql As String = "SELECT DOCNO, DOCNAME, DOCDEPT, DOCSHARE "
        Sql = Sql + " FROM QEa_CourseMaster"
        Sql = Sql + " GROUP BY DOCNO, DOCNAME, DOCDEPT, DOCSHARE, DOCTYPE, STATUS "
        Sql = Sql + " HAVING DOCTYPE = '" & strDOCTYPE & "' "
        Sql = Sql + " AND STATUS = 'A'"
        Sql = Sql + " Order by DOCNO asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvMain
                ' intM = 1
                'intW = 1


                Dim Sql1 As String = "SELECT * "
                Sql1 = Sql1 + " FROM QEa_Training_CrseSet WHERE CrseSetCode = '" & FrmTraining_CrseSet.TxtCrseSetCode.Text & "' AND DeptCodSet ='" & strDeptData & "' AND CrseCode ='" & Dtr.Item("DOCNO").ToString & "' "

                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                Dim strStatus As String = ""
                For Each Dtr1 As DataRow In Dt1.Rows
                    strStatus = "เลือกเข้าแบบกำหนดเเล้ว"
                Next


                Application.DoEvents()
                .Rows.Add()
                '.Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = intNo
                .Item(2, .Rows.Count - 2).Value = strStatus
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString

            End With

            intNo = intNo + 1

        Next

        Me.dgvMain.AllowUserToAddRows = False
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close()
    End Sub

    Private Sub bntOK_Click(sender As Object, e As EventArgs) Handles bntOK.Click

        'End Select
        Dim sqlinsert As String
        Dim strCopyNo As String = ""
        Dim strCopyNo_1 As String = ""

        For Each row As DataGridViewRow In dgvMain.Rows

            If CBool(row.Cells("Sel").Value) = True Then

                If CStr(row.Cells("Status").Value) = "เลือกเข้าแบบกำหนดเเล้ว" Then
                    GoTo NEXTSTEP
                End If

                CmdExcute("DELETE FROM QEa_Training_CrseSet WHERE CrseSetCode = '" & FrmTraining_CrseSet.TxtCrseSetCode.Text & "' AND DeptCodSet ='" & strDeptData & "' AND CrseCode ='" & CStr(row.Cells("DOCNO").Value) & "' ", DB_CMD.ObjConn)


                sqlinsert = "INSERT INTO QEa_Training_CrseSet(CrseSetCode,CrseSetNam,DeptCodSet,CrseCode,DeptCod,RetrainFreq) " &
                                    "VALUES(@CrseSetCode,@CrseSetNam,@DeptCodSet,@CrseCode,@DeptCod,@RetrainFreq)"


                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@CrseSetCode", SqlDbType.VarChar).Value = FrmTraining_CrseSet.TxtCrseSetCode.Text
                    .Parameters.Add("@CrseSetNam", SqlDbType.VarChar).Value = FrmTraining_CrseSet.TxtCrseSetNam1.Text
                    .Parameters.Add("@DeptCodSet", SqlDbType.VarChar).Value = strDeptData
                    .Parameters.Add("@CrseCode", SqlDbType.VarChar).Value = CStr(row.Cells("DOCNO").Value)
                    .Parameters.Add("@DeptCod", SqlDbType.VarChar).Value = CStr(row.Cells("DOCDEPT").Value)

                    If IsDBNull(CStr(row.Cells("RetrainFreq").Value)) Or CStr(row.Cells("RetrainFreq").Value) = "" Then
                        .Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = ""
                    Else
                        .Parameters.Add("@RetrainFreq", SqlDbType.VarChar).Value = CStr(row.Cells("RetrainFreq").Value)
                    End If




                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With

            End If
NEXTSTEP:
        Next
        StrFunction.CourseSet = 1
        Me.Close()

    End Sub

    Private Sub dgvMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellContentClick
        SendKeys.Send("{Tab}")
        With Me.dgvMain
            For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot

                If CType((.Rows(i).Cells(2).Value), String) = "เลือกเข้าแบบกำหนดเเล้ว" Then
                    .Item(0, i).Value = False
                End If

            Next
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

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
End Class