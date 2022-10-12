Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows
Public Class FrmDocSys_RcRt_Receive
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
    Dim strRecComment As String = ""
    Dim strQEComment As String = ""


    Private Sub FrmDocSys_RcRt_Receive_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtSELECTSYSTEM.Text = "Document System"
        strSELECTSYSTEMRecive = "DS"

        If strBranchConn = "TP" Then
            TxtBranch.Text = "T"
        ElseIf strBranchConn = "KB" Then
            TxtBranch.Text = "K"
        End If

        Grid()

        TxtSelect.Text = "คืนเอกสาร"

        If strRRSNO <> "" Then

            Me.dgvDetail.AllowUserToAddRows = True
            Call LoadData()
            Me.dgvDetail.AllowUserToAddRows = False

        End If

        Select Case txtSELECTSYSTEM.Text

            Case "Document System"

                If strDeptData = "SD" Then

                    LblSelect.Visible = True
                    TxtSelect.Visible = True
                    chkSelectALL.Visible = True

                Else

                    LblSelect.Visible = False
                    TxtSelect.Visible = False
                    chkSelectALL.Visible = False

                End If

            Case "Department"
                LblSelect.Visible = True
                TxtSelect.Visible = True
        End Select


    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntFinds_Click(sender As Object, e As EventArgs) Handles bntFinds.Click

        If txtSELECTSYSTEM.Text = "" Then
            MsgBox("กรุณาเลือก System ด้วยค่ะ", MsgBoxStyle.Exclamation, "เเจ้งเตือน")
            txtSELECTSYSTEM.Focus()
            Exit Sub
        End If

        Me.dgvDetail.AllowUserToAddRows = True
        Call LoadData()
        Me.dgvDetail.AllowUserToAddRows = False



    End Sub

    Sub LoadData()

        Select Case txtSELECTSYSTEM.Text
            Case "Document System"
                strSELECTSYSTEMRecive = "DS"

            Case "Department"
                strSELECTSYSTEMRecive = "DP"
        End Select


        Dim cri As String = ""
        Dim strBranch As String = ""

        If strRRSNO <> "" Then
            TxtRRSNOFM.Text = strRRSNO
            TxtRRSNOTO.Text = strRRSNO
        End If



        cri = "WHERE B.SELECTSYSTEM   ='" & strSELECTSYSTEMRecive & "'"

        cri = cri & " And (SUBSTRING(A.RRSNO, 1, 1) ='" & TxtBranch.Text & "') "



        If TxtRRSNOFM.Text <> "" And TxtRRSNOTO.Text <> "" Then
            cri = cri & "AND (A.RRSNO BETWEEN   '" & TxtRRSNOFM.Text & "' AND  '" & TxtRRSNOTO.Text & "')"
        End If

        If TxtYearData.Text <> "" Then

            cri = cri & "AND (SUBSTRING(A.RRSNO, 5, 2)  =   '" & TxtYearData.Text & "') "

        End If

        If TxtDOCNO.Text <> "" Then

            cri = cri & "AND (A.DOCNO  =   '" & TxtDOCNO.Text & "') "

        End If



        If strDeptData = "SD" Then
            'cri = cri & "AND (DOCNO  =   '" & TxtDOCNO.Text & "') "
        Else
            If strDeptData = "HRGA" And strSELECTSYSTEMRecive = "DP" Then
            Else
                If strDeptData = "QA" Then
                    cri = cri & "AND (A.Dept  = '" & strDeptData & "' OR A.Dept  ='QC') "
                ElseIf strDeptData = "EN" Then
                    cri = cri & "AND (A.Dept  = '" & strDeptData & "' OR A.Dept  ='WS') "
                Else

                    cri = cri & "AND (A.Dept  =   '" & strDeptData & "') "
                End If

            End If

        End If


        'Dim Sql As String = "SELECT * FROM QEa_DocSys_ReceiveDoc "
        'Sql = Sql + cri
        'Sql = Sql + "Order by RRSNO,ReCopyNo asc"


        Dim Sql As String = "SELECT  A.ID, A.RRSDATE, A.STATUS, A.REFNO, A.REFNODATA, A.DARNO, A.DOCNO, A.DOCNAME, A.ToDept, A.ToDeptName, A.Dept, A.Branch, A.DOCTYPE, A.ReREVNO, A.ReCopyNo, A.RtREVNO, A.RtCopyNo, A.RecLogonID, "
        Sql = Sql + "A.RecName, A.RecDate, A.RecComment, A.QELogonID, A.QEName, A.QEDate, A.QEComment, B.SELECTSYSTEM, A.RRSNO "
        Sql = Sql + "FROM QEa_DocSys_ReceiveDoc AS A LEFT OUTER JOIN QEa_DocSysItem AS B ON A.REFNO = B.REFNO AND A.REFNODATA = B.REFNODATA "
        Sql = Sql + cri
        Sql = Sql + "Order by A.RRSNO,A.ReCopyNo asc"


        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvDetail.Rows.Clear()

        Dim intNo1 As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvDetail


                ' Dim strToDeptName As String



                Dim Sql1 As String = "SELECT * FROM QEa_CourseMaster "
                Sql1 = Sql1 + "WHERE DOCNO ='" & Dtr.Item("DocNo").ToString & "' "
                Sql1 = Sql1 + "Order by DOCNO,DOCNAME asc"


                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)
                Dim strDOCNAMEData As String = ""

                For Each Dtr1 As DataRow In Dt1.Rows

                    strDOCNAMEData = Dtr1.Item("DOCNAME").ToString

                Next


                Application.DoEvents()
                .Rows.Add()
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("REFNO").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("RRSNO").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("DocNo").ToString
                .Item(3, .Rows.Count - 2).Value = strDOCNAMEData
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("ReREVNO").ToString
                .Item(5, .Rows.Count - 2).Value = Dtr.Item("ReCopyNo").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("RtREVNO").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("RtCopyNo").ToString
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("ToDept").ToString
                .Item(9, .Rows.Count - 2).Value = Dtr.Item("ToDeptName").ToString
                .Item(10, .Rows.Count - 2).Value = Dtr.Item("RecLogonID").ToString
                .Item(11, .Rows.Count - 2).Value = Dtr.Item("RecName").ToString
                .Item(12, .Rows.Count - 2).Value = Dtr.Item("RecDate").ToString

                If IsDBNull(Dtr.Item("RecComment").ToString) Or Dtr.Item("RecComment").ToString = "" Then
                    .Item(13, .Rows.Count - 2).Value = ""
                Else
                    .Item(13, .Rows.Count - 2).Value = Dtr.Item("RecComment").ToString
                End If

                .Item(14, .Rows.Count - 2).Value = Dtr.Item("QELogonID").ToString
                .Item(15, .Rows.Count - 2).Value = Dtr.Item("QEName").ToString
                .Item(16, .Rows.Count - 2).Value = Dtr.Item("QEDate").ToString

                If IsDBNull(Dtr.Item("QEComment").ToString) Or Dtr.Item("QEComment").ToString = "" Then
                    .Item(17, .Rows.Count - 2).Value = ""
                Else
                    .Item(17, .Rows.Count - 2).Value = Dtr.Item("QEComment").ToString
                End If

                '.Item(17, .Rows.Count - 2).Value = Dtr.Item("QEComment").ToString
                .Item(18, .Rows.Count - 2).Value = Dtr.Item("REFNODATA").ToString
                .Item(19, .Rows.Count - 2).Value = Dtr.Item("DARNO").ToString
                .Item(20, .Rows.Count - 2).Value = Dtr.Item("DEPT").ToString
                .Item(21, .Rows.Count - 2).Value = Dtr.Item("DOCTYPE").ToString



                ' End If
            End With

            ' intNo1 = intNo1 + 1
        Next
    End Sub


    Sub Grid()



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
        End With
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellContentClick
        Try


            strRecComment = ""
            strQEComment = ""

            strRecComment = Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).Value.ToString
            strQEComment = Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).Value.ToString

            Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).ReadOnly = False
            Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = False
            ''Dim strDept As String = Mid(Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).Value, 1, 2)
            ''Dim strBranch As String = Mid(Me.dgvDetail.Item(21, Me.dgvDetail.CurrentRow.Index).Value, 1, 2)

            ''Dim strData As String = Me.dgvDetail.Item(16, Me.dgvDetail.CurrentRow.Index).Value

            'Me.dgvDetail.Item(8, Me.dgvDetail.CurrentRow.Index).ReadOnly = True

            ''  strBranchData = Mid(strBranchData, 1, 2)

            ''If strBranchData = strBranch And strDeptData = strDept Then
            ''    '  Me.grdDetail.Item(15, Me.grdDetail.CurrentRow.Index).ReadOnly = False
            ''    Me.grdDetail.Item(16, Me.grdDetail.CurrentRow.Index).Value = StrUserName
            ''    Me.grdDetail.Item(17, Me.grdDetail.CurrentRow.Index).Value = Year()
            ''    'Me.grdDetail.Item(15, Me.grdDetail.CurrentRow.Index).Value = True
            ''    'Me.grdDetail.Item(15, Me.grdDetail.CurrentRow.Index).ReadOnly = True
            ''End If

            'If strLavelLogon = "QE" Or strLavelLogon = "GA" Then
            '    ' Me.grdDetail.Item(15, Me.grdDetail.CurrentRow.Index).ReadOnly = False
            '    'Me.grdDetail.Item(16, Me.grdDetail.CurrentRow.Index).Value = StrUserName
            '    'Me.grdDetail.Item(17, Me.grdDetail.CurrentRow.Index).Value = Year


            '    If Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value.ToString = "" Then
            '        Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value = StrEmployeeNo
            '        Me.dgvDetail.Item(12, Me.dgvDetail.CurrentRow.Index).Value = StrUserName
            '        Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).Value = TxtDateNow.Text

            '    End If




            '    'Me.grdDetail.Item(15, Me.grdDetail.CurrentRow.Index).Value = True

            '    'Me.grdDetail.Item(15, Me.grdDetail.CurrentRow.Index).ReadOnly = True
            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDetail_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetail.CellMouseDoubleClick
        Dim strDept As String = Me.dgvDetail.Item(20, Me.dgvDetail.CurrentRow.Index).Value.ToString
        Dim strDOCTYPECHK As String = Me.dgvDetail.Item(21, Me.dgvDetail.CurrentRow.Index).Value.ToString
        'Dim strBranch As String = Mid(Me.dgvDetail.Item(21, Me.dgvDetail.CurrentRow.Index).Value, 1, 2)

        strRecComment = ""
        strQEComment = ""

        strRecComment = Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).Value.ToString
        strQEComment = Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).Value.ToString

        Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).ReadOnly = False
        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = False


        If Me.dgvDetail.Item(7, Me.dgvDetail.CurrentRow.Index).Value.ToString = "" Then
            If strDeptData <> "SD" Then
                TxtSelect.Text = "คืนเอกสาร"
            End If

        End If



        'Dim strData As String = Me.dgvDetail.Item(16, Me.dgvDetail.CurrentRow.Index).Value

        Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
        Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
        '  strBranchData = Mid(strBranchData, 1, 2)




        Select Case TxtSelect.Text
            Case "รับเอกสาร"
                GoTo NextSTEP1_2
            Case "คืนเอกสาร"
                GoTo NextSTEP_1
            Case "รับ-คืนเอกสาร"
                GoTo NextSTEP_1
        End Select


NextSTEP_1:
        If strDeptData = strDept Or (strDeptData = "SD" And strDept = "QE") Or (strDeptData = "QA" And strDept = "QC") Or (strDeptData = "EN" And strDept = "WS") Then

            If Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).Value.ToString = "" Then
                Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).Value = StrEmployeeNo
                Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value = StrUserName
                Me.dgvDetail.Item(12, Me.dgvDetail.CurrentRow.Index).Value = TxtDateNow.Text
                Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).Value = strRecComment
                Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).ReadOnly = False
            Else
                Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"
                If MsgBox("ฝ่ายที่เกี่ยวข้อง ได้คืนเอกสารเเล้ว ต้องการยกเลิกใช่หรือไม่", MsgBoxStyle.YesNo, "ยกเลิกรับ - คืน เอกสาร") = MsgBoxResult.No Then Exit Sub
                Me.dgvDetail.Item(10, Me.dgvDetail.CurrentRow.Index).Value = ""
                Me.dgvDetail.Item(11, Me.dgvDetail.CurrentRow.Index).Value = ""
                Me.dgvDetail.Item(12, Me.dgvDetail.CurrentRow.Index).Value = ""
                Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).Value = ""
                Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
            End If
        End If



        If TxtSelect.Text = "คืนเอกสาร" Then Exit Sub

NextSTEP1_2:



        Select Case txtSELECTSYSTEM.Text
            Case "Document System"
                If strDeptData = "SD" Then
                    If Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value.ToString = "" Then
                        Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value = StrEmployeeNo
                        Me.dgvDetail.Item(15, Me.dgvDetail.CurrentRow.Index).Value = StrUserName
                        Me.dgvDetail.Item(16, Me.dgvDetail.CurrentRow.Index).Value = TxtDateNow.Text
                        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).Value = strQEComment
                        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = False

                    Else
                        If MsgBox("Document Control ได้เซ็นรับ เอกสารเเล้ว ต้องการยกเลิกใช่หรือไม่", MsgBoxStyle.YesNo, "ยกเลิกรับ - คืน เอกสาร") = MsgBoxResult.No Then Exit Sub
                        Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value = ""
                        Me.dgvDetail.Item(15, Me.dgvDetail.CurrentRow.Index).Value = ""
                        Me.dgvDetail.Item(16, Me.dgvDetail.CurrentRow.Index).Value = ""
                        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).Value = ""
                        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
                    End If
                End If

            Case "Department"

                If strDOCTYPECHK = "JOB" Or strDOCTYPECHK = "OGN" Then
                    If strDeptData = "GA" Or strDeptData = "HRGA" Then

                        If Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value.ToString = "" Then
                            Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value = StrEmployeeNo
                            Me.dgvDetail.Item(15, Me.dgvDetail.CurrentRow.Index).Value = StrUserName
                            Me.dgvDetail.Item(16, Me.dgvDetail.CurrentRow.Index).Value = TxtDateNow.Text
                            Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).Value = strQEComment
                            Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = False

                        Else
                            If MsgBox("Document Control ได้เซ็นรับ เอกสารเเล้ว ต้องการยกเลิกใช่หรือไม่", MsgBoxStyle.YesNo, "ยกเลิกรับ - คืน เอกสาร") = MsgBoxResult.No Then Exit Sub
                            Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value = ""
                            Me.dgvDetail.Item(15, Me.dgvDetail.CurrentRow.Index).Value = ""
                            Me.dgvDetail.Item(16, Me.dgvDetail.CurrentRow.Index).Value = ""
                            Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).Value = ""
                            Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
                        End If

                    End If

                Else


                    If Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value.ToString = "" Then
                        Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value = StrEmployeeNo
                        Me.dgvDetail.Item(15, Me.dgvDetail.CurrentRow.Index).Value = StrUserName
                        Me.dgvDetail.Item(16, Me.dgvDetail.CurrentRow.Index).Value = TxtDateNow.Text
                        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).Value = strQEComment
                        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = False

                    Else
                        If MsgBox("Document Control ได้เซ็นรับ เอกสารเเล้ว ต้องการยกเลิกใช่หรือไม่", MsgBoxStyle.YesNo, "ยกเลิกรับ - คืน เอกสาร") = MsgBoxResult.No Then Exit Sub
                        Me.dgvDetail.Item(14, Me.dgvDetail.CurrentRow.Index).Value = ""
                        Me.dgvDetail.Item(15, Me.dgvDetail.CurrentRow.Index).Value = ""
                        Me.dgvDetail.Item(16, Me.dgvDetail.CurrentRow.Index).Value = ""
                        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).Value = ""
                        Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
                    End If



                End If








        End Select




    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click

        For Each row As DataGridViewRow In Me.dgvDetail.Rows




            ' Update Running Number
            Dim myCommand As New SqlCommand("Update QEa_DocSys_ReceiveDoc Set RecLogonID = @RecLogonID ,RecName = @RecName ,RecDate = @RecDate ,QELogonID = @QELogonID ,QEName = @QEName ,QEDate = @QEDate ,RecComment=@RecComment ,QEComment =@QEComment  WHERE RRSNO = '" & (row.Cells("RRSNO").Value.ToString) & "' AND REFNO = '" & (row.Cells("REFNO").Value.ToString) & "' AND REFNODATA = '" & (row.Cells("REFNODATA").Value.ToString) & "' AND ReCopyNo = '" & (row.Cells("ReCopyNo").Value.ToString) & "'AND ToDept = '" & (row.Cells("ToDept").Value.ToString) & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@RecLogonID", SqlDbType.VarChar).Value = (row.Cells("RecLogonID").Value.ToString)
            myCommand.Parameters.Add("@RecName", SqlDbType.VarChar).Value = (row.Cells("RecName").Value.ToString)
            myCommand.Parameters.Add("@RecDate", SqlDbType.VarChar).Value = (row.Cells("RecDate").Value.ToString)
            myCommand.Parameters.Add("@QELogonID", SqlDbType.VarChar).Value = (row.Cells("QELogonID").Value.ToString)
            myCommand.Parameters.Add("@QEName", SqlDbType.VarChar).Value = (row.Cells("QEName").Value.ToString)
            myCommand.Parameters.Add("@QEDate", SqlDbType.VarChar).Value = (row.Cells("QEDate").Value.ToString)


            If IsDBNull(row.Cells("RecComment").Value) Or (row.Cells("RecComment").Value.ToString) = "" Then
                myCommand.Parameters.Add("@RecComment", SqlDbType.VarChar).Value = ""
            Else
                myCommand.Parameters.Add("@RecComment", SqlDbType.VarChar).Value = (row.Cells("RecComment").Value)
            End If


            'If IsDBNull(row.Cells("RecComment").Value.ToString) Or (row.Cells("RecComment").Value.ToString) = "" Then



            '    myCommand.Parameters.Add("@RecComment", SqlDbType.VarChar).Value = ""
            'Else
            '    '
            '    myCommand.Parameters.Add("@RecComment", SqlDbType.VarChar).Value = (row.Cells("RecComment").Value.ToString)
            'End If


            'myCommand.Parameters.Add("@RecComment", SqlDbType.VarChar).Value = (row.Cells("RecComment").Value.ToString)
            myCommand.Parameters.Add("@QEComment", SqlDbType.VarChar).Value = (row.Cells("QEComment").Value.ToString)

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery






        Next
        Select Case txtSELECTSYSTEM.Text

            Case "Department"
                Call UpdateStatus()
        End Select

        MsgBox("บันทึกข้อมูลเรียบร้อย")

        Call clearText()

    End Sub
    Sub UpdateStatus()




        Try
            For Each row As DataGridViewRow In Me.dgvDetail.Rows

                Select Case txtSELECTSYSTEM.Text

                    Case "Department"
                        If Mid((row.Cells("DOCNO").Value.ToString), 2, 3) = "JSA" Then
                            GoTo NEXT_STEP_REFNO
                        End If

                End Select
                Dim strChkRecName As String = ""
                Dim strChkRecNameStatus As String = "รอประกาศใช้"
                If CInt((row.Cells("ReREVNO").Value.ToString)) = CInt(0) Then



                    Dim Sql As String = "SELECT REFNO, DOCNO, RecName "
                    Sql = Sql + "FROM QEa_DocSys_ReceiveDoc "
                    Sql = Sql + "GROUP BY REFNO, DOCNO, RecName "
                    Sql = Sql + "HAVING REFNO = '" & (row.Cells("REFNO").Value.ToString) & "' And DOCNO ='" & (row.Cells("DOCNO").Value.ToString) & "' "
                    Sql = Sql + "Order by REFNO asc"

                    Dim Dt As New DataTable
                    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
                    'dgvDetail.Rows.Clear()


                    For Each Dtr As DataRow In Dt.Rows
                        If IsDBNull(Dtr.Item("RecName").ToString) Or Dtr.Item("RecName").ToString = "" Then


                            GoTo NEXT_STEP_REFNO
                        Else
                            strChkRecName = "OK"
                        End If

                    Next

                Else

                    Dim Sql As String = "SELECT REFNO, DOCNO, RecName,QEName "
                    Sql = Sql + "FROM QEa_DocSys_ReceiveDoc "
                    Sql = Sql + "GROUP BY REFNO, DOCNO, RecName, QEName "
                    Sql = Sql + "HAVING REFNO = '" & (row.Cells("REFNO").Value.ToString) & "' And DOCNO ='" & (row.Cells("DOCNO").Value.ToString) & "' "
                    Sql = Sql + "Order by REFNO asc"

                    Dim Dt As New DataTable
                    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
                    'dgvDetail.Rows.Clear()


                    For Each Dtr As DataRow In Dt.Rows
                        If IsDBNull(Dtr.Item("QEName").ToString) Or Dtr.Item("QEName").ToString = "" Then
                            If IsDBNull((row.Cells("RtCopyNo").Value.ToString)) Or (row.Cells("RtCopyNo").Value.ToString) = "" Then
                                strChkRecName = "OK"
                            Else
                                GoTo NEXT_STEP_REFNO
                            End If


                        Else
                                strChkRecName = "OK"
                        End If

                    Next


                End If


                If strChkRecName = "OK" Then
                    Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                                         "WHERE REFNO = '" & (row.Cells("REFNO").Value.ToString) & "' " &
                                         "And DOCNO ='" & (row.Cells("DOCNO").Value.ToString) & "' ", DB_CMD.ObjConn)

                    myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Close"
                    ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery
                Else

                    Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                                        "WHERE REFNO = '" & (row.Cells("REFNO").Value.ToString) & "' " &
                                        "And DOCNO ='" & (row.Cells("DOCNO").Value.ToString) & "' ", DB_CMD.ObjConn)

                    myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "รอประกาศใช้"
                    ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                End If

NEXT_STEP_REFNO:

                strChkRecName = ""
            Next

NEXT_STEP_REFNO_2:

            Exit Sub
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือนจากระบบ")
            Exit Sub

        End Try


    End Sub
    Sub clearText()

        dgvDetail.Rows.Clear()
        TxtDOCNO.Text = ""
        TxtRRSNOFM.Text = ""
        TxtRRSNOTO.Text = ""

    End Sub

    Private Sub chkRecLogonID_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecLogonID.CheckedChanged

        If chkRecLogonID.Checked = True Then

            For Each row As DataGridViewRow In Me.dgvDetail.Rows
                If strDeptData = (row.Cells("DEPT").Value).ToString Then
                    If CStr(row.Cells("RecLogonID").Value) = "" Then
                        row.Cells("RecLogonID").Value = StrEmployeeNo
                        row.Cells("RecName").Value = StrUserName
                        row.Cells("RecDate").Value = TxtDateNow.Text
                    Else

                    End If
                End If
            Next
        End If

        chkRecLogonID.Checked = False




    End Sub

    Private Sub chkSelectALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectALL.CheckedChanged
        If chkSelectALL.Checked = True Then

            For Each row As DataGridViewRow In Me.dgvDetail.Rows


                If strDeptData = "SD" Or strDeptData = "GA" Or strDeptData = "HRGA" Then
                    'If CStr(row.Cells("ReREVNO").Value) = "" Then

                    'Else
                    '    If CInt(row.Cells("ReREVNO").Value) = 0 Then
                    '        Exit Sub
                    '    End If
                    'End If

                    If CStr(row.Cells("QELogonID").Value) = "" Then
                        row.Cells("QELogonID").Value = StrEmployeeNo
                        row.Cells("QEName").Value = StrUserName
                        row.Cells("QEDate").Value = TxtDateNow.Text
                    End If
                End If

            Next


            For Each row As DataGridViewRow In Me.dgvDetail.Rows
                If strDeptData = (row.Cells("DEPT").Value).ToString Then
                    If CStr(row.Cells("RecLogonID").Value) = "" Then
                        row.Cells("RecLogonID").Value = StrEmployeeNo
                        row.Cells("RecName").Value = StrUserName
                        row.Cells("RecDate").Value = TxtDateNow.Text
                    End If
                End If
            Next
        End If

        chkSelectALL.Checked = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()
    End Sub

    Private Sub dgvDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellClick
        Dim strDept As String = Me.dgvDetail.Item(20, Me.dgvDetail.CurrentRow.Index).Value.ToString
        If strDeptData = strDept Then
            Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).ReadOnly = False
        Else
            Me.dgvDetail.Item(13, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
        End If

        If strDeptData = "SD" Or strDeptData = "GA" Or strDeptData = "HRGA" Then
            Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = False
        Else
            Me.dgvDetail.Item(17, Me.dgvDetail.CurrentRow.Index).ReadOnly = True
        End If

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub TxtRRSNOFM_TextChanged(sender As Object, e As EventArgs) Handles TxtRRSNOFM.TextChanged
        dgvDetail.Rows.Clear()
        '  strRRSNO = ""

        If TxtRRSNOFM.Text = "" Then
            strRRSNO = ""
        End If
    End Sub

    Private Sub TxtRRSNOTO_TextChanged(sender As Object, e As EventArgs) Handles TxtRRSNOTO.TextChanged
        dgvDetail.Rows.Clear()
        'strRRSNO = ""

        If TxtRRSNOTO.Text = "" Then
            strRRSNO = ""
        End If
    End Sub

    Private Sub TxtYearData_TextChanged(sender As Object, e As EventArgs) Handles TxtYearData.TextChanged
        dgvDetail.Rows.Clear()
        ' strRRSNO = ""
    End Sub

    Private Sub TxtDOCNO_TextChanged(sender As Object, e As EventArgs) Handles TxtDOCNO.TextChanged
        dgvDetail.Rows.Clear()
        ' strRRSNO = ""
    End Sub

    Private Sub txtSELECTSYSTEM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSELECTSYSTEM.SelectedIndexChanged
        dgvDetail.Rows.Clear()

        TxtRRSNOFM.Text = ""
        TxtRRSNOTO.Text = ""
        TxtYearData.Text = ""
        TxtDOCNO.Text = ""

        Select Case txtSELECTSYSTEM.Text
            Case "Document System"
                strSELECTSYSTEMRecive = "DS"
                If strDeptData = "SD" Then

                    LblSelect.Visible = True
                    TxtSelect.Visible = True
                Else
                    LblSelect.Visible = False
                    TxtSelect.Visible = False
                End If
            Case "Department"
                strSELECTSYSTEMRecive = "DP"
                LblSelect.Visible = True
                TxtSelect.Visible = True
        End Select


    End Sub
End Class