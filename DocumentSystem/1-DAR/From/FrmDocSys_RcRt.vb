Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows
Public Class FrmDocSys_RcRt
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

    Dim strCopyNo As String
    Dim intNUmber As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub FrmDocSys_RcRt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Grid()
        Me.dgvCopy.AllowUserToAddRows = False
        Me.dgvDetail.AllowUserToAddRows = False

        TxtBranch.Text = strBranchConn
        If strDeptData <> "SD" Then
            txtSELECTSYSTEM.Enabled = False
            txtSELECTSYSTEM.Text = "Department"
        Else
            txtSELECTSYSTEM.Enabled = True
        End If

    End Sub


    Sub Grid()

        With Me.dgvCopy
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With


        With Me.dgvDetail
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With
    End Sub

    Sub LoadData()
        Try
            dgvCopy.Rows.Clear()
            Dim cri As String = ""
            ' cri = "WHERE A.PETITIONBRANCH ='" & TxtBranch.Text & "' "
            'A.SELECTSYSTEM

            If txtSELECTSYSTEM.Text = "" Then
                MsgBox("กรุณาเลือก System ด้วยค่ะ", MsgBoxStyle.Exclamation, "เเจ้งเตือน")
                txtSELECTSYSTEM.Focus()
                Exit Sub
            End If


            Select Case txtSELECTSYSTEM.Text
                Case "Document System"
                    strSELECTSYSTEMRecive = "DS"

                Case "Department"
                    strSELECTSYSTEMRecive = "DP"
            End Select

            cri = "WHERE A.SELECTSYSTEM ='" & strSELECTSYSTEMRecive & "' "

            If TxtDARNOFM.Text <> "" And TxtDARNOTO.Text <> "" Then
                cri = cri & "AND (A.DARNO  BETWEEN   '" & TxtDARNOFM.Text & "' AND  '" & TxtDARNOTO.Text & "')"
            End If

            If TxtYearData.Text <> "" Then

                cri = cri & "AND (SUBSTRING(A.REFNO, 5, 2)  =   '" & TxtYearData.Text & "') "

            End If



          '  cri = cri & "AND (Not (B.QEOFFICERDATE Is NULL)) AND B.QEOFFICERAPPROVE = 'PASS' "





            If strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
                cri = cri & " AND  (A.DOCTYPE  = 'JOB' OR A.DOCTYPE  = 'OGN' )"
            Else
                cri = cri & " AND  A.DOCTYPE  <> 'JOB' AND  A.DOCTYPE  <> 'OGN'"
            End If





            If strSELECTSYSTEMRecive = "DP" Then

                cri = cri & " AND  A.STATUS = 'รอประกาศใช้'"

                If strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Or strDeptData = "SD" Then
                Else

                    cri = cri & " AND  A.PETITIONDEPT = '" & strDeptData & "'"

                End If
            End If

            If strSELECTSYSTEMRecive = "DS" Then
                cri = cri & " AND  B.QEMRAPPROVE = 'Pass' "
            ElseIf strSELECTSYSTEMRecive = "DP" Then
                'cri = cri & " AND  B.QEMGRAPPROVE = 'Pass' "

            End If




            'If strDeptData = "SD" Then
            '    cri = cri & " AND  A.DOCTYPE  <> 'JOB' AND  A.DOCTYPE  <> 'OGN'"
            'End If



            Me.dgvCopy.AllowUserToAddRows = True

            Dim Sql As String = "Select A.DARNO, B.QEOFFICERDATE, A.DOCTYPE, A.MANAGE, A.REFNO, A.REFNODATA, A.PETITIONBRANCH,A.DOCNO,A.REVNO,MAX(B.LINEDATA) AS MAXLINEDATA, A.SELECTSYSTEM, A.PETITIONDEPT,A.STATUS, B.QEMRAPPROVE,B.QEMGRAPPROVE  "
            Sql = Sql + "FROM QEa_DocSysItem AS A LEFT OUTER Join dbo.QEa_DocSysItem_Approve AS B ON A.REFNO = B.REFNO And A.REFNODATA = B.REFNODATA "
            Sql = Sql + cri
            Sql = Sql + "GROUP BY A.DARNO, B.QEOFFICERDATE, A.DOCTYPE, A.MANAGE, A.REFNO, A.REFNODATA, A.PETITIONBRANCH, A.DOCNO, A.REVNO, A.SELECTSYSTEM,A.PETITIONDEPT ,A.STATUS, B.QEMRAPPROVE,B.QEMGRAPPROVE  "
            Sql = Sql + " Order by A.DARNO  asc"
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
            dgvCopy.Rows.Clear()

            Dim intNo As Integer = 1
            For Each Dtr As DataRow In Dt.Rows
                With dgvCopy
                    ' intM = 1
                    'intW = 1

                    '(DARNO = '" & Dtr.Item("DARNO").ToString & "') AND 

                    Dim Sql1 As String = "Select RRSNO, REFNO, DARNO, REFNODATA "
                    Sql1 = Sql1 + " FROM QEa_DocSys_ReceiveDoc "
                    Sql1 = Sql1 + " GROUP BY RRSNO, REFNO, DARNO, REFNODATA "
                    Sql1 = Sql1 + " HAVING  (REFNODATA = '" & Dtr.Item("REFNODATA").ToString & "') AND (REFNO = '" & Dtr.Item("REFNO").ToString & "')"
                    Dim Dt1 As New DataTable
                    Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)

                    Dim strRRSNODATA As String = ""
                    For Each Dtr1 As DataRow In Dt1.Rows
                        strRRSNODATA = Dtr1.Item("RRSNO").ToString
                    Next
                    If strSELECTSYSTEMRecive = "DP" Then
                        If strDeptData <> "SD" Then
                            If Mid(Dtr.Item("DOCNO").ToString, 2, 3) = "JSA" Then
                                GoTo NEXT_STEP_DOCNO
                            End If
                        Else
                            If strDeptData = "SD" And Mid(Dtr.Item("DOCNO").ToString, 2, 3) = "JSA" Then

                            Else
                                If strDeptData = "SD" And strDeptData = Dtr.Item("PETITIONDEPT").ToString Then
                                Else
                                    GoTo NEXT_STEP_DOCNO
                                End If
                            End If
                        End If
                    End If



                    Application.DoEvents()
                    .Rows.Add()
                    ' .Item(0, .Rows.Count - 2).Value = intNo
                    .Item(1, .Rows.Count - 2).Value = Dtr.Item("DARNO").ToString
                    .Item(2, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("DOCTYPE").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("MANAGE").ToString
                    .Item(6, .Rows.Count - 2).Value = Dtr.Item("QEOFFICERDATE").ToString
                    .Item(7, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                    .Item(8, .Rows.Count - 2).Value = Dtr.Item("REFNODATA").ToString
                    .Item(9, .Rows.Count - 2).Value = strRRSNODATA
                    .Item(10, .Rows.Count - 2).Value = Dtr.Item("PETITIONDEPT").ToString


                End With
NEXT_STEP_DOCNO:
            Next

            Me.dgvCopy.AllowUserToAddRows = False

            dgvDetail.Rows.Clear()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Call LoadData()
    End Sub

    Private Sub TxtCopyNo_TextChanged(sender As Object, e As EventArgs) Handles TxtYearData.TextChanged
        dgvCopy.Rows.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtDARNOFM.TextChanged
        dgvCopy.Rows.Clear()
    End Sub

    Private Sub dgvCopy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCopy.CellContentClick
        SendKeys.Send("{Tab}")
        dgvDetail.Rows.Clear()
    End Sub


    Sub LoadDataDAR()
        Try
            Dim Dt As New DataTable
            Me.dgvDetail.AllowUserToAddRows = True

            dgvDetail.Rows.Clear()
            For Each row As DataGridViewRow In dgvCopy.Rows

                If CBool(row.Cells("Sel").Value) = True Then

                    If (row.Cells("Status").Value.ToString) <> "" Then
                        GoTo NextRecordData
                    End If


                    If (row.Cells("MANAGE").Value.ToString) = "N" Then

                        'Check Course Master 
                        '                '***************************************************************************

                        Dim command As New SqlCommand("SELECT * FROM QEa_CourseMaster " &
                                              "WHERE DOCNO ='" & row.Cells("DOCNO").Value.ToString & "' " &
                                              "AND REVNO IN (Select REVNO " &
                                              "FROM QEa_DocSysItem " &
                                              "WHERE REFNODATA ='" & row.Cells("REFNODATA").Value.ToString & "'" &
                                              "AND DOCNO ='" & row.Cells("DOCNO").Value.ToString & "' " &
                                              "AND REFNO ='" & row.Cells("REFNO").Value.ToString & "')", DB_CMD.ObjConn)

                        Dim table As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        Dim ds As New DataSet
                        adapter.Fill(table)

                        If table.Rows.Count = 0 Then

                            MsgBox("เลขที่เอกสาร :  " & row.Cells("DOCNO").Value.ToString & " ยังไม่ได้ Update Course Master ", MsgBoxStyle.Critical, "เเจ้งเตือนให้รับทราบ")

                            'TxtApprove.Checked = False

                            Exit Sub

                        End If

                    End If

                    '*****************************************************************************


                    'If strDeptData = "SD" Then

                    '        Dim Sql As String = "Select A.REFNO, A.REFNO As Expr1, A.REFNODATA, A.DOCNO, A.language, A.CtypeData, A.DocCtrl, A.ToDept, A.CopyNo, B.DOCNAME, B.DOCTYPE, C.ToDeptName, C.Dept, C.Branch, D.REVNO "
                    '        Sql = Sql + "FROM QEa_DocSysItem_CopyNo As A LEFT OUTER JOIN  dbo.QEa_DocSysItem As D On A.REFNODATA = D.REFNODATA And A.REFNO = D.REFNO LEFT OUTER JOIN   QEm_ToDept As C On A.ToDept = C.ToDept LEFT OUTER JOIN   dbo.QEa_CourseMaster As B On A.DOCNO = B.DOCNO "
                    '        Sql = Sql + "GROUP BY A.REFNO, A.REFNODATA, A.DOCNO, A.language, A.CtypeData, A.DocCtrl, A.ToDept, A.CopyNo, B.DOCNAME, B.DOCTYPE, C.ToDeptName, C.Dept, C.Branch, D.REVNO "
                    '        Sql = Sql + "HAVING A.CtypeData <> 'SERVER' "
                    '        ' Sql = Sql + "AND A.DOCNO = '" & row.Cells("DOCNO").Value.ToString & "' "
                    '        Sql = Sql + "AND A.REFNODATA = '" & row.Cells("REFNODATA").Value.ToString & "' "
                    '        Sql = Sql + "AND A.REFNO = '" & row.Cells("REFNO").Value.ToString & "' "
                    '        Sql = Sql + "Order by A.CopyNo, A.ToDept, A.DOCNO, A.DocCtrl asc"

                    '        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)

                    '    ElseIf strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then

                    '        Dim Sql As String = "Select A.REFNO, A.REFNO As Expr1, A.REFNODATA, A.DOCNO,A.language, A.CtypeData, A.DocCtrl, A.ToDept, A.CopyNo, B.DOCNAME, B.DOCTYPE, C.ToDeptName,C.Dept,C.Branch,D.REVNO "
                    '        Sql = Sql + "FROM QEa_DocSysItem_CopyNo As A LEFT OUTER JOIN  dbo.QEa_DocSysItem As D On A.REFNODATA = D.REFNODATA And A.REFNO = D.REFNO LEFT OUTER JOIN   QEm_ToDeptGA As C On A.ToDept = C.ToDept LEFT OUTER JOIN   dbo.QEa_CourseMaster As B On A.DOCNO = B.DOCNO "
                    '        Sql = Sql + "GROUP BY A.REFNO, A.REFNODATA, A.DOCNO, A.language, A.CtypeData, A.DocCtrl, A.ToDept, A.CopyNo, B.DOCNAME, B.DOCTYPE,C.ToDeptName,C.Dept,C.Branch,D.REVNO "
                    '        Sql = Sql + "HAVING A.CtypeData <> 'SERVER' "
                    '        ' Sql = Sql + "AND A.DOCNO = '" & row.Cells("DOCNO").Value.ToString & "' "
                    '        Sql = Sql + "AND A.REFNODATA = '" & row.Cells("REFNODATA").Value.ToString & "' "
                    '        Sql = Sql + "AND A.REFNO = '" & row.Cells("REFNO").Value.ToString & "' "
                    '        Sql = Sql + "Order by A.CopyNo, A.ToDept, A.DOCNO, A.DocCtrl asc"


                    '        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
                    '    End If


                    '*****************  07/08/22  ********************
                    ' เพิ่มเงื่อนไข Case  07/08/2022
                    Select Case txtSELECTSYSTEM.Text



                        Case "Department"
                            If (row.Cells("DOCTYPE").Value.ToString) = "STD" Then
                                GoTo Next_SETP_DATA
                            End If
                            strSELECTSYSTEMRecive = "DP"
                            Dim Sql As String = "Select A.REFNO, A.REFNO As Expr1, A.REFNODATA, A.DOCNO, A.language, A.CtypeData, A.DocCtrl, A.ToDept, A.CopyNo, B.DOCNAME, B.DOCTYPE, C.ToDeptName, C.Dept, C.Branch, D.REVNO "
                            Sql = Sql + "FROM QEa_DocSysItem_CopyNo As A LEFT OUTER JOIN  dbo.QEa_DocSysItem As D On A.REFNODATA = D.REFNODATA And A.REFNO = D.REFNO LEFT OUTER JOIN   QEm_ToDeptGA As C On A.ToDept = C.ToDept LEFT OUTER JOIN   dbo.QEa_CourseMaster As B On A.DOCNO = B.DOCNO "
                            Sql = Sql + "GROUP BY A.REFNO, A.REFNODATA, A.DOCNO, A.language, A.CtypeData, A.DocCtrl, A.ToDept, A.CopyNo, B.DOCNAME, B.DOCTYPE, C.ToDeptName, C.Dept, C.Branch, D.REVNO "
                            Sql = Sql + "HAVING A.CtypeData <> 'SERVER' "
                            ' Sql = Sql + "AND A.DOCNO = '" & row.Cells("DOCNO").Value.ToString & "' "
                            Sql = Sql + "AND A.REFNODATA = '" & row.Cells("REFNODATA").Value.ToString & "' "
                            Sql = Sql + "AND A.REFNO = '" & row.Cells("REFNO").Value.ToString & "' "
                            Sql = Sql + "Order by A.CopyNo, A.ToDept, A.DOCNO, A.DocCtrl asc"
                            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)



                        Case "Document System"

Next_SETP_DATA:
                            strSELECTSYSTEMRecive = "DS"
                            Dim Sql As String = "Select A.REFNO, A.REFNO As Expr1, A.REFNODATA, A.DOCNO, A.language, A.CtypeData, A.DocCtrl, A.ToDept, A.CopyNo, B.DOCNAME, B.DOCTYPE, C.ToDeptName, C.Dept, C.Branch, D.REVNO "
                            Sql = Sql + "FROM QEa_DocSysItem_CopyNo As A LEFT OUTER JOIN  dbo.QEa_DocSysItem As D On A.REFNODATA = D.REFNODATA And A.REFNO = D.REFNO LEFT OUTER JOIN   QEm_ToDept As C On A.ToDept = C.ToDept LEFT OUTER JOIN   dbo.QEa_CourseMaster As B On A.DOCNO = B.DOCNO "
                            Sql = Sql + "GROUP BY A.REFNO, A.REFNODATA, A.DOCNO, A.language, A.CtypeData, A.DocCtrl, A.ToDept, A.CopyNo, B.DOCNAME, B.DOCTYPE, C.ToDeptName, C.Dept, C.Branch, D.REVNO "
                            Sql = Sql + "HAVING A.CtypeData <> 'SERVER' "
                            ' Sql = Sql + "AND A.DOCNO = '" & row.Cells("DOCNO").Value.ToString & "' "
                            Sql = Sql + "AND A.REFNODATA = '" & row.Cells("REFNODATA").Value.ToString & "' "
                            Sql = Sql + "AND A.REFNO = '" & row.Cells("REFNO").Value.ToString & "' "
                            Sql = Sql + "Order by A.CopyNo, A.ToDept, A.DOCNO, A.DocCtrl asc"
                            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


                    End Select





                    '*************************************************

                    Dim intNo As Integer = 1
                    For Each Dtr As DataRow In Dt.Rows

                        '********* 27/06/2022 ******
                        If Dtr.Item("CtypeData").ToString = "ORIGINAL" And Dtr.Item("DOCTYPE").ToString <> "STD" Then
                            GoTo NextRecord
                        End If



                        '********* 27/06/2022 ******

                        'Dim sqlinsert As String
                        'sqlinsert = "INSERT INTO Qet_DocSys_RcRt(REFNO,REFNODATA,DOCNO,DOCNAME,DOCTYPE,ToDept,ToDeptName,ReREVNO,ReCopyNo,RtREVNO,RtCopyNo) " &
                        '                      "VALUES(@REFNO,@REFNODATA,@DOCNO,@DOCNAME,@DOCTYPE,@ToDept,@ToDeptName,@ReREVNO,@ReCopyNo,@RtREVNO,@RtCopyNo)"

                        'With comSave
                        '    .Parameters.Clear()
                        '    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = strRefNo
                        '    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = strRefNoData
                        '    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("DOCNO").ToString()
                        '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr.Item("DOCNAME").ToString()
                        '    .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = Dtr.Item("DocCtrl").ToString()
                        '    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = Dtr.Item("ToDept").ToString()
                        '    .Parameters.Add("@ToDeptName", SqlDbType.VarChar).Value = Dtr.Item("ToDeptName").ToString()
                        '    .Parameters.Add("@ReREVNO", SqlDbType.Int).Value = Dtr.Item("REVNO").ToString()
                        '    .Parameters.Add("@ReCopyNo", SqlDbType.Int).Value = Dtr.Item("CopyNo").ToString()
                        '    .Parameters.Add("@RtREVNO", SqlDbType.Int).Value = Dtr.Item("REVNO").ToString()
                        '    .Parameters.Add("@RtCopyNo", SqlDbType.Int).Value = Dtr.Item("CopyNo").ToString()


                        '    .CommandText = sqlinsert
                        '    .Connection = DB_CMD.ObjConn
                        '    .ExecuteNonQuery()

                        'End With


                        Dim strReREVNO As String = ""
                        Dim strReCopyNo As String = ""

                        Dim strRtREVNO As String = ""
                        Dim strRtCopyNo As String = ""
                        Dim strCopyNoData As String = ""

                        If Dtr.Item("CtypeData").ToString = "ORIGINAL" Then
                            strCopyNoData = "ต้นฉบับ"
                        Else
                            strCopyNoData = Dtr.Item("CopyNo").ToString

                        End If

                        Select Case (row.Cells("MANAGE").Value.ToString)

                            Case "N"
                                strReREVNO = Dtr.Item("REVNO").ToString
                                strReCopyNo = strCopyNoData
                                strRtREVNO = ""
                                strRtCopyNo = ""
                            Case "E"
                                If (row.Cells("DOCTYPE").Value.ToString) = "JOB" Or (row.Cells("DOCTYPE").Value.ToString) = "OGN" Then
                                    If CInt(Dtr.Item("REVNO").ToString) = 1 Then
                                        strReREVNO = Dtr.Item("REVNO").ToString
                                        strReCopyNo = strCopyNoData
                                        strRtREVNO = ""
                                        strRtCopyNo = ""
                                    Else
                                        strReREVNO = Dtr.Item("REVNO").ToString
                                        strReCopyNo = strCopyNoData
                                        strRtREVNO = CType(CInt(Dtr.Item("REVNO").ToString) - 1, String)
                                        strRtCopyNo = strCopyNoData
                                    End If

                                Else
                                    strReREVNO = Dtr.Item("REVNO").ToString
                                    strReCopyNo = strCopyNoData
                                    strRtREVNO = CType(CInt(Dtr.Item("REVNO").ToString) - 1, String)
                                    strRtCopyNo = strCopyNoData

                                End If


                            Case "O"
                                strReREVNO = ""
                                strReCopyNo = ""
                                strRtREVNO = Dtr.Item("REVNO").ToString
                                strRtCopyNo = strCopyNoData

                            Case "C"
                                strReREVNO = Dtr.Item("REVNO").ToString
                                strReCopyNo = strCopyNoData
                                strRtREVNO = ""
                                strRtCopyNo = ""

                            Case "R"
                                strReREVNO = Dtr.Item("REVNO").ToString
                                strReCopyNo = strCopyNoData
                                strRtREVNO = ""
                                strRtCopyNo = ""

                            Case "U"
                                strReREVNO = Dtr.Item("REVNO").ToString
                                strReCopyNo = strCopyNoData
                                strRtREVNO = ""
                                strRtCopyNo = ""

                        End Select

                        '***************************  31/05/2022  ************************
                        'Select Case (row.Cells("MANAGE").Value.ToString)

                        '        Case "N"
                        '            strReREVNO = Dtr.Item("REVNO").ToString
                        '            strReCopyNo = Dtr.Item("CopyNo").ToString
                        '            strRtREVNO = ""
                        '            strRtCopyNo = ""
                        '        Case "E"
                        '            strReREVNO = Dtr.Item("REVNO").ToString
                        '            strReCopyNo = Dtr.Item("CopyNo").ToString
                        '            strRtREVNO = CType(CInt(Dtr.Item("REVNO").ToString) - 1, String)
                        '            strRtCopyNo = Dtr.Item("CopyNo").ToString

                        '        Case "O"
                        '            strReREVNO = ""
                        '            strReCopyNo = ""
                        '            strRtREVNO = Dtr.Item("REVNO").ToString
                        '            strRtCopyNo = Dtr.Item("CopyNo").ToString

                        '        Case "C"
                        '            strReREVNO = Dtr.Item("REVNO").ToString
                        '            strReCopyNo = Dtr.Item("CopyNo").ToString
                        '            strRtREVNO = ""
                        '            strRtCopyNo = ""

                        '        Case "R"
                        '            strReREVNO = Dtr.Item("REVNO").ToString
                        '            strReCopyNo = Dtr.Item("CopyNo").ToString
                        '            strRtREVNO = ""
                        '            strRtCopyNo = ""

                        '        Case "U"
                        '            strReREVNO = Dtr.Item("REVNO").ToString
                        '            strReCopyNo = Dtr.Item("CopyNo").ToString
                        '            strRtREVNO = ""
                        '            strRtCopyNo = ""

                        '    End Select


                        'If Dtr.Item("CtypeData").ToString = "ORIGINAL" Then
                        '    GoTo NextRecord
                        'End If

                        '***************************  31/05/2022  ************************

                        With dgvDetail
                            ' intM = 1
                            'intW = 1



                            Application.DoEvents()

                            .Rows.Add()

                            .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                            .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                            .Item(2, .Rows.Count - 2).Value = Dtr.Item("DocCtrl").ToString
                            .Item(3, .Rows.Count - 2).Value = strReREVNO
                            .Item(4, .Rows.Count - 2).Value = strReCopyNo
                            .Item(5, .Rows.Count - 2).Value = strRtREVNO
                            .Item(6, .Rows.Count - 2).Value = strRtCopyNo
                            .Item(7, .Rows.Count - 2).Value = Dtr.Item("ToDeptName").ToString
                            .Item(8, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                            .Item(9, .Rows.Count - 2).Value = (row.Cells("REFNO").Value.ToString)
                            .Item(10, .Rows.Count - 2).Value = (row.Cells("REFNODATA").Value.ToString)
                            .Item(11, .Rows.Count - 2).Value = Dtr.Item("Dept").ToString
                            .Item(12, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                            .Item(13, .Rows.Count - 2).Value = (row.Cells("DARNO").Value.ToString)
                            .Item(14, .Rows.Count - 2).Value = (row.Cells("DOCTYPE").Value.ToString)


                        End With

NextRecord:

                    Next


                End If

NextRecordData:
            Next


            Me.dgvDetail.AllowUserToAddRows = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งให้ทราบ")
        Exit Sub
        End Try


    End Sub

    Private Sub dgvCopy_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCopy.CellMouseUp

        'If CBool(Me.dgvCopy.Item(0, Me.dgvCopy.CurrentRow.Index).Value) = True Then

        'Else

        '    MsgBox(Me.dgvCopy.Item(1, Me.dgvCopy.CurrentRow.Index).Value)

        'End If
    End Sub

    Private Sub dgvCopy_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvCopy.MouseClick
        'With Me.dgvCopy

        '    dgvCopy.Item(0, Me.dgvCopy.CurrentRow.Index).Value = True

        'End With


        'If CBool(Me.dgvCopy.Item(0, Me.dgvCopy.CurrentRow.Index).Value) = True Then

        '    MsgBox(Me.dgvCopy.Item(1, Me.dgvCopy.CurrentRow.Index).Value)
        'Else

        '    MsgBox("ไม่โอเค")

        'End If




    End Sub

    Private Sub dgvCopy_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvCopy.CurrentCellChanged
        ''For Each row As DataGridViewRow In Me.dgvCopy.Rows
        ''    Dim checked As Boolean = CType(row.Cells("Sel").Value, Boolean)
        ''    If checked Then
        ''        row.DefaultCellStyle.BackColor = Color.Wheat

        ''    Else
        ''        row.DefaultCellStyle.BackColor = Color.White

        ''    End If

        ''Next



        'strDocNo = CType(dgvCopy.Item(2, dgvCopy.CurrentRow.Index).Value, String)
        'strRefNo = CType(dgvCopy.Item(7, dgvCopy.CurrentRow.Index).Value, String)
        'strRefNoData = CType(dgvCopy.Item(8, dgvCopy.CurrentRow.Index).Value, String)
        '' strDocNo = CType(dgvCopy.Item(8, dgvCopy.CurrentRow.Index).Value, String)



        'With Me.dgvCopy

        '    For Each row As DataGridViewRow In dgvCopy.Rows

        '        If CBool(row.Cells("Sel").Value) = True Then


        '            CmdExcute("DELETE FROM Qet_DocSys_RcRt WHERE DOCNO = '" & strDocNo & "' AND REFNO ='" & strRefNo & "' AND REFNODATA ='" & strRefNoData & "' ", DB_CMD.ObjConn)

        '            LoadDataDAR()



        '        End If
        '    Next

        '    'If CBool(dgvCopy.Item(0, Me.dgvCopy.CurrentRow.Index).Value) = False Then
        '    '    MsgBox("Ccccxxx")
        '    'End If
        '    '' Call LoadDataDAR()
        'End With
        ''  dgvCopy.Item(0, Me.dgvCopy.CurrentRow.Index).Value = True
    End Sub

    Private Sub bntUpdate_Click(sender As Object, e As EventArgs) Handles bntSelect.Click

        Call LoadDataDAR()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click

        Try
            Dim REFNODATARRS2 As String = ""
            Dim REFNODATARRS1 As String = ""
            Dim strDOCNO1RRSNO As String = ""

            Select Case txtSELECTSYSTEM.Text
                Case "Document System"
                    strSELECTSYSTEMRecive = "DS"
                Case "Department"
                    strSELECTSYSTEMRecive = "DP"
                    For Each row As DataGridViewRow In Me.dgvDetail.Rows
                        strDOCNO1RRSNO = (row.Cells("DOCNO1").Value.ToString)
                        If Mid(strDOCNO1RRSNO, 2, 3) = "JSA" Then
                            strDeptDataRRSNO = "JS"
                        ElseIf (row.Cells("DOCTYPE_2").Value.ToString) = "JOB" Then
                            strDeptDataRRSNO = "JP"
                        ElseIf (row.Cells("DOCTYPE_2").Value.ToString) = "OGN" Then
                            strDeptDataRRSNO = "OC"
                        ElseIf (row.Cells("DOCTYPE_2").Value.ToString) = "STD" Then
                            strDeptDataRRSNO = strDeptData
                        End If
                        ' strDeptDataRRSNO = (row.Cells("DOCTYPE_2").Value.ToString)
                    Next
            End Select

            Call RunningRefNo()

            For Each row As DataGridViewRow In Me.dgvDetail.Rows
                Dim sqlinsert As String
                sqlinsert = "INSERT INTO QEa_DocSys_ReceiveDoc(RRSNO, RRSDATE, Status, REFNO, REFNODATA, DARNO, DOCNO, DOCNAME, Todept, ToDeptName, Dept, Branch, DOCTYPE, ReREVNO, ReCopyNo, RtREVNO, RtCopyNo) " &
                                      "VALUES(@RRSNO, @RRSDATE, @Status, @REFNO, @REFNODATA, @DARNO, @DOCNO, @DOCNAME, @Todept, @ToDeptName, @Dept, @Branch, @DOCTYPE, @ReREVNO, @ReCopyNo, @RtREVNO, @RtCopyNo)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@RRSNO", SqlDbType.VarChar).Value = strRefNoData
                    .Parameters.Add("@RRSDATE", SqlDbType.VarChar).Value = TxtDateNow.Text
                    .Parameters.Add("@Status", SqlDbType.VarChar).Value = "A"
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = (row.Cells("REFNO1").Value.ToString)
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = (row.Cells("REFNODATA1").Value.ToString)
                    .Parameters.Add("@DARNO", SqlDbType.VarChar).Value = (row.Cells("DARNO1").Value.ToString)
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = (row.Cells("DOCNO1").Value.ToString)
                    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = (row.Cells("DOCNAME").Value.ToString)
                    .Parameters.Add("@ToDept", SqlDbType.VarChar).Value = (row.Cells("Todept").Value.ToString)
                    .Parameters.Add("@ToDeptName", SqlDbType.VarChar).Value = (row.Cells("ToDeptName").Value.ToString)
                    .Parameters.Add("@Dept", SqlDbType.VarChar).Value = (row.Cells("Dept").Value.ToString)
                    .Parameters.Add("@Branch", SqlDbType.VarChar).Value = (row.Cells("Branch").Value.ToString)
                    .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = (row.Cells("DOCTYPE1").Value.ToString)
                    .Parameters.Add("@ReREVNO", SqlDbType.VarChar).Value = (row.Cells("ReREVNO").Value.ToString)
                    .Parameters.Add("@ReCopyNo", SqlDbType.VarChar).Value = (row.Cells("ReCopyNo").Value.ToString)
                    .Parameters.Add("@RtREVNO", SqlDbType.VarChar).Value = (row.Cells("RtREVNO").Value.ToString)
                    .Parameters.Add("@RtCopyNo", SqlDbType.VarChar).Value = (row.Cells("RtCopyNo").Value.ToString)

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With




                REFNODATARRS1 = (row.Cells("REFNO1").Value.ToString)


                If REFNODATARRS1 = REFNODATARRS2 Then
                    GoTo NEXT_STEP_1
                Else
                    REFNODATARRS2 = (row.Cells("REFNO1").Value.ToString)
                End If

                'Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                '                             "WHERE REFNO = '" & (row.Cells("REFNO1").Value.ToString) & "' " &
                '                             "And REFNODATA ='" & (row.Cells("REFNODATA1").Value.ToString) & "' ", DB_CMD.ObjConn)

                'myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "รอ รับ-คืนเอกสาร"

                '' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                'Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
NEXT_STEP_1:
            Next

            MsgBox("บันทึกข้อมูลเรียบร้อย เลขที่รับ-คืนเอกสาร : " & strRefNoData & "")

            dgvCopy.Rows.Clear()
            dgvDetail.Rows.Clear()
            Exit Sub

        Catch ex As Exception
            MsgBox("ไม่สามารถบันทึกได้ กรุณาตรวจสอบความถูกต้องของข้อมูล")
        End Try

    End Sub

    'Sub UpdateStatus()


    '    Try


    '        Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
    '                                           "WHERE REFNO = '" & TxtREFNO.Text & "' " &
    '                                           "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

    '        myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = strStatus
    '        ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

    '        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

    '    Catch ex As Exception

    '    End Try


    'End Sub
    Sub RunningRefNo()

        Dim Sql As String = Nothing
        Dim Year As Integer = CInt(Format(Now, "yyyy"))
        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))

        CommandTypeData = "Addnew"

        Select Case txtSELECTSYSTEM.Text
            Case "Document System"
                strSELECTSYSTEMRecive = "DS"

                Dim command As New SqlCommand("Select *  FROM QEn_RrsNo WHERE Year=" & Year & " AND TypeData ='" & strSELECTSYSTEMRecive & "' ", DB_CMD.ObjConn)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)

                adapter.Fill(table)


                If table.Rows.Count = 0 Then

                    Dim intRefNoNew As Integer = 1

                    With QEn_RrsNo

                        .RRSNO = intRefNoNew
                        .YEAR = Year
                        .TypeData = strSELECTSYSTEMRecive
                        .DeptData = "SD"

                        Select Case CommandTypeData
                            Case "Addnew"
                                Sql = .SqlCommandInsert
                        End Select
                        If CmdExcute(Sql, DB_CMD.ObjConn) = True Then

                        End If
                    End With
                End If

NexeSetp_1:
                With QEn_RrsNo

                    .GetData("Select * FROM QEn_RrsNo WHERE YEAR =" & Year & " AND TypeData ='" & strSELECTSYSTEMRecive & "' ", DB_CMD.ObjConn)

                    ' TxtRefNo.Text = .RefNoData
                    Dim strRefBranch As String = ""

                    strRefBranch = Mid(strBranchConn, 1, 1)

                    Select Case txtSELECTSYSTEM.Text
                        Case "Document System"
                            strRefNoData = strRefBranch & "RRS" & yy & Format(CSng(.RRSNO), "000")

                        Case "Department"
                            strRefNoData = strRefBranch & "RDP" & yy & Format(CSng(.RRSNO), "000")
                    End Select


                    intRRSNo = CInt(CInt(.RRSNO).ToString)

                    'TxtREFNODATA.Text = strRefNoData

                End With


                ' Update Running Number
                Dim myCommand As New SqlCommand("Update QEn_RrsNo Set RRSNO = @RRSNO WHERE YEAR = " & Year & " AND TypeData ='" & strSELECTSYSTEMRecive & "' ", DB_CMD.ObjConn)
                myCommand.Parameters.Add("@RRSNO", SqlDbType.Int).Value = intRRSNo + 1


                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


            Case "Department"

                strSELECTSYSTEMRecive = "DP"




                Dim command As New SqlCommand("Select *  FROM QEn_RrsNo WHERE Year=" & Year & " AND TypeData ='" & strSELECTSYSTEMRecive & "' AND DeptData ='" & strDeptDataRRSNO & "'  ", DB_CMD.ObjConn)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)

                adapter.Fill(table)


                If table.Rows.Count = 0 Then

                    Dim intRefNoNew As Integer = 1

                    With QEn_RrsNo

                        .RRSNO = intRefNoNew
                        .YEAR = Year
                        .TypeData = strSELECTSYSTEMRecive

                        '  If 
                        .DeptData = strDeptDataRRSNO

                        Select Case CommandTypeData
                            Case "Addnew"
                                Sql = .SqlCommandInsert
                        End Select
                        If CmdExcute(Sql, DB_CMD.ObjConn) = True Then

                        End If
                    End With
                End If

NexeSetp_2:
                With QEn_RrsNo


                    .GetData("Select * FROM QEn_RrsNo WHERE YEAR =" & Year & " AND TypeData ='" & strSELECTSYSTEMRecive & "' AND DeptData ='" & strDeptDataRRSNO & "'  ", DB_CMD.ObjConn)

                    ' TxtRefNo.Text = .RefNoData
                    Dim strRefBranch As String = ""

                    strRefBranch = Mid(strBranchConn, 1, 1) & "R"

                    Select Case txtSELECTSYSTEM.Text
                        Case "Document System"
                            strRefNoData = strRefBranch & "RRS" & yy & Format(CSng(.RRSNO), "000")

                        Case "Department"
                            strRefNoData = strRefBranch & "-" & strDeptDataRRSNO & "-" & yy & Format(CSng(.RRSNO), "000")
                    End Select


                    intRRSNo = CInt(CInt(.RRSNO).ToString)

                    'TxtREFNODATA.Text = strRefNoData

                End With


                ' Update Running Number
                Dim myCommand As New SqlCommand("Update QEn_RrsNo Set RRSNO = @RRSNO WHERE YEAR = " & Year & " AND TypeData ='" & strSELECTSYSTEMRecive & "' AND DeptData ='" & strDeptDataRRSNO & "' ", DB_CMD.ObjConn)
                myCommand.Parameters.Add("@RRSNO", SqlDbType.Int).Value = intRRSNo + 1


                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


        End Select



    End Sub

    '    Sub RunningRefNo()

    '        Dim Sql As String = Nothing
    '        Dim Year As Integer = CInt(Format(Now, "yyyy"))
    '        Dim yy As Integer = CInt(Mid(CType(Year, String), 3, 2))

    '        CommandTypeData = "Addnew"

    '        Dim command As New SqlCommand("Select *  FROM QEn_RrsNo WHERE Year=" & Year & "  ", DB_CMD.ObjConn)
    '        Dim table As New DataTable
    '        Dim adapter As New SqlDataAdapter(command)

    '        adapter.Fill(table)


    '        If table.Rows.Count = 0 Then

    '            Dim intRefNoNew As Integer = 1

    '            With QEn_RrsNo

    '                .RRSNO = intRefNoNew
    '                .YEAR = Year

    '                Select Case CommandTypeData
    '                    Case "Addnew"
    '                        Sql = .SqlCommandInsert
    '                End Select
    '                If CmdExcute(Sql, DB_CMD.ObjConn) = True Then

    '                End If
    '            End With
    '        End If

    'NexeSetp:
    '        With QEn_RrsNo

    '            .GetData("Select * FROM QEn_RrsNo WHERE YEAR =" & Year & " ", DB_CMD.ObjConn)

    '            ' TxtRefNo.Text = .RefNoData
    '            Dim strRefBranch As String = ""

    '            strRefBranch = Mid(strBranchConn, 1, 1)

    '            strRefNoData = strRefBranch & "RRS" & yy & Format(CSng(.RRSNO), "000")

    '            intRRSNo = CInt(CInt(.RRSNO).ToString)

    '            'TxtREFNODATA.Text = strRefNoData

    '        End With


    '        ' Update Running Number
    '        Dim myCommand As New SqlCommand("Update QEn_RrsNo Set RRSNO = @RRSNO WHERE YEAR = " & Year & " ", DB_CMD.ObjConn)
    '        myCommand.Parameters.Add("@RRSNO", SqlDbType.Int).Value = intRRSNo + 1


    '        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


    '    End Sub

    Private Sub chkSelectALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectALL.CheckedChanged
        With Me.dgvCopy
            For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                If chkSelectALL.Checked = True Then
                    .Item(0, i).Value = True
                Else
                    .Item(0, i).Value = False
                End If

            Next
        End With
    End Sub

    Private Sub txtSELECTSYSTEM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSELECTSYSTEM.SelectedIndexChanged
        dgvCopy.Rows.Clear()

        Select Case txtSELECTSYSTEM.Text
            Case "Document System"
                strSELECTSYSTEMRecive = "DS"

            Case "Department"
                strSELECTSYSTEMRecive = "DP"
        End Select
    End Sub

    Private Sub TxtDARNOTO_TextChanged(sender As Object, e As EventArgs) Handles TxtDARNOTO.TextChanged
        dgvCopy.Rows.Clear()
    End Sub
End Class