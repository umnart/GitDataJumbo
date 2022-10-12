Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows
Public Class FrmCourseMaster
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

    Dim Exts As String


    Private Sub FrmCourseMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clearText()
        Call CourseType()
        Call CourseTypeFind()
        Call DeptDATASel()

        TxtDOCDEPT.Text = ""
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
    Sub CourseType()

        Dim command As New SqlCommand("SELECT  DOCTYPE, CrseTypNam, ID FROM  QEa_Training_CourseType  ORDER BY ID  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)



        adapter.Fill(ds, "QEa_Training_CourseType")
        If table.Rows.Count > 0 Then
            TxtDOCTYPE.DisplayMember = "CrseTypNam"
            TxtDOCTYPE.ValueMember = "DOCTYPE"
            TxtDOCTYPE.DataSource = ds.Tables("QEa_Training_CourseType")

        End If


        Exit Sub
    End Sub

    Sub CourseTypeFind()

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
    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click

        FrmMainMenu.PictureBox2.Enabled = True
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FrmUpdateDataFromSA.ShowDialog()
        '' Try
        'Dim Sql As String = "Select *  from CourseMAster "
        '    Sql = Sql + " Order by CrseCode , RevNo asc"
        '    Dim Dt As New DataTable
        '    Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        '    'grdData.Rows.Clear()
        '    CmdExcute("DELETE FROM QEa_CourseMaster  ", DB_CMD.ObjConn)

        '    Dim intNo As Integer = 1
        '    For Each Dtr As DataRow In Dt.Rows
        '        '  With grdData


        '        Dim sqlinsert As String
        '        Dim Result As Boolean
        '    '    Dim strRevDate As String = ""

        '    '    strRevDate = Mid(Dtr.Item("RevDate").ToString(), 1, 10)

        '    '    sqlinsert = " Insert Into QEa_CourseMaster (DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCTYPE)Values ('" & Dtr.Item("CrseCode").ToString() & "','" & Dtr.Item("CrseNam").ToString() & "','" & Dtr.Item("CrseSts").ToString() & "','" & Dtr.Item("DeptCod").ToString() & "'," & Dtr.Item("RevNo").ToString() & ",'" & strRevDate & "','" & Dtr.Item("DescThai").ToString() & "','" & Dtr.Item("AttachFile").ToString() & "','" & Dtr.Item("CrseTypCode").ToString() & "')"

        '    '    Result = CmdExcute(sqlinsert, DB_CMD.ObjConn)

        '    '    ',EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE
        '    '    ','" & Dtr.Item("DescThai").ToString() & "','" & Dtr.Item("AttachFile").ToString() & "','" & Dtr.Item("CrseTypCode").ToString() & "'

        '    'End With



        '    sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCTYPE) " &
        '                            "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCTYPE)"


        '    With comSave
        '        .Parameters.Clear()
        '        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = Dtr.Item("CrseCode").ToString()
        '        .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr.Item("CrseNam").ToString()
        '        .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = Dtr.Item("CrseSts").ToString()
        '        .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = Dtr.Item("DeptCod").ToString()
        '        .Parameters.Add("@REVNO", SqlDbType.Float).Value = Dtr.Item("RevNo").ToString()
        '        .Parameters.Add("@EFFDATE", SqlDbType.VarChar).Value = Dtr.Item("RevDate").ToString()
        '        .Parameters.Add("@REASON", SqlDbType.VarChar).Value = Dtr.Item("DescThai").ToString()
        '        .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = Dtr.Item("AttachFile").ToString()
        '        .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = Dtr.Item("CrseTypCode").ToString()



        '        .CommandText = sqlinsert
        '        .Connection = DB_CMD.ObjConn
        '        .ExecuteNonQuery()
        '    End With

        '    'End With



        '    'Dim myCommand1 As New SqlCommand("INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME)VALUES(@DOCNO,@DOCNAME)", DB_CMD.ObjConn)
        '    'myCommand1.Parameters.Add("@DARNO", SqlDbType.VarChar).Value = Dtr.Item("CrseCode").ToString()
        '    '    myCommand1.Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = Dtr.Item("CrseNam").ToString()
        '    '    Dim rowsAffected1 As Integer = myCommand1.ExecuteNonQuery



        'Next

        '    MsgBox("OK")
        '    Exit Sub

        ''Catch ex As Exception
        ''    MsgBox("เกิดข้อผิดพลาดแก้ไขข้อมูล GetHostName  ", MsgBoxStyle.Critical, "Error")
        ''End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtREVNO.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtREVNO.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub



    Function CheckData() As Boolean
        CheckData = True
        Try


            If Me.TxtDOCTYPE.Text = Nothing Then
                CheckData = False
                Me.TxtDOCTYPE.Focus()
                Exit Function
            End If

            If Me.TxtDOCNO.Text = Nothing Then
                CheckData = False
                Me.TxtDOCNO.Focus()
                Exit Function
            End If
            If Me.TxtDOCNAME.Text = Nothing Then
                CheckData = False
                Me.TxtDOCNAME.Focus()
                Exit Function
            End If
            If Me.TxtDOCDEPT.Text = Nothing Then
                CheckData = False
                Me.TxtDOCDEPT.Focus()
                Exit Function
            End If

            If Me.TxtREVNO.Text = Nothing Then
                CheckData = False
                Me.TxtREVNO.Focus()
                Exit Function
            End If

            If Me.TxtEFFDATE.Text = Nothing Then
                CheckData = False
                Me.TxtEFFDATE.Focus()
                Exit Function
            End If

            If Me.txtSELECTSYSTEM.Text = Nothing Then
                CheckData = False
                Me.txtSELECTSYSTEM.Focus()
                Exit Function
            End If

            'If Me.TxtREASON.Text = Nothing Then
            '    CheckData = False
            '    Me.TxtREASON.Focus()
            '    Exit Function
            'End If

            'If Me.TxtLinkPdf.Text = Nothing Then
            '    CheckData = False
            '    Me.TxtLinkPdf.Focus()
            '    Exit Function
            'End If


        Catch ex As Exception

        End Try
    End Function

    Sub clearText()
        TxtDOCTYPE.Text = ""
        TxtDOCNO.Text = ""
        TxtDOCNAME.Text = ""
        TxtDOCDEPT.Text = ""
        TxtREVNO.Text = ""
        TxtEFFDATE.Text = ""
        TxtREASON.Text = ""
        TxtLinkPdf.Text = ""
        TxtFind.Text = ""
        TxtStatus.Text = ""
        ' TxtFindData.Text = ""
        'TxtDOCTYPEFind.Text = ""

        TxtStatus.Text = ""
        txtSELECTSYSTEM.Text = ""
        TXTDOCSHARE.Text = ""
        TXTDOCSHARE.Enabled = False

        txtSELECTSYSTEM.Enabled = False
        TxtDOCTYPE.Enabled = False
        TxtDOCNO.Enabled = False
        TxtDOCNAME.Enabled = False
        TxtDOCDEPT.Enabled = False
        TxtREVNO.Enabled = False
        TxtEFFDATE.Enabled = False
        TxtREASON.Enabled = False
        TxtLinkPdf.Enabled = False

        dgvDataDept.Enabled = False
        dgvDataDept.Rows.Clear()
        grdData.Rows.Clear()
        ' grdData.Enabled = False
        '
    End Sub

    Sub EnabledTextbox()
        TxtDOCTYPE.Enabled = True
        TxtDOCNO.Enabled = True
        TxtDOCNAME.Enabled = True
        TxtDOCDEPT.Enabled = True
        TxtREVNO.Enabled = True
        TxtEFFDATE.Enabled = True
        TxtREASON.Enabled = True
        TxtLinkPdf.Enabled = True

        TxtStatus.Text = ""
        txtSELECTSYSTEM.Text = ""
        TXTDOCSHARE.Text = ""
        TXTDOCSHARE.Enabled = True

        txtSELECTSYSTEM.Enabled = True

        TxtDOCTYPE.Text = ""
        TxtDOCNO.Text = ""
        TxtDOCNAME.Text = ""
        TxtDOCDEPT.Text = ""
        TxtREVNO.Text = ""
        TxtEFFDATE.Text = ""
        TxtREASON.Text = ""
        TxtLinkPdf.Text = ""
        grdData.Enabled = True
        dgvDataDept.Enabled = True

    End Sub

    Sub DisabledTextbox()
        TxtDOCTYPE.Enabled = False
        TxtDOCNO.Enabled = False
        TxtDOCNAME.Enabled = False
        TxtDOCDEPT.Enabled = False
        TxtREVNO.Enabled = False
        TxtEFFDATE.Enabled = False
        TxtREASON.Enabled = False
        TxtLinkPdf.Enabled = False

        'TxtDOCTYPE.Text = ""
        'TxtDOCNO.Text = ""
        'TxtDOCNAME.Text = ""
        'TxtDOCDEPT.Text = ""
        'TxtREVNO.Text = ""
        'TxtEFFDATE.Text = ""
        'TxtREASON.Text = ""
        'TxtLinkPdf.Text = ""
        grdData.Enabled = True
    End Sub

    Private Sub TxtDOCNO_TextChanged(sender As Object, e As EventArgs) Handles TxtDOCNO.TextChanged

    End Sub

    Private Sub FrmCourseMaster_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress


    End Sub

    Private Sub TxtDOCNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDOCNO.KeyPress
        If e.KeyChar = Chr(13) Then









            Call LoadData()












        End If
    End Sub

    Sub LoadData()
        Dim strStatus As String = ""
        Dim strFindData As String = ""

        If TxtFindData.Text <> "" Then

            strFindData = TxtFindData.Text
        Else

            strFindData = TxtDOCNO.Text
        End If

        Dim Sql As String = "Select *  from QEa_CourseMaster "
        Sql = Sql + "WHERE DOCNO LIKE '" & strFindData & "%'"
        Sql = Sql + "AND  DOCTYPE ='" & strDOCTYPE & "'"
        Sql = Sql + " Order by DOCTYPE,DOCNO,REVNO asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        grdData.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With grdData
                ' intM = 1
                'intW = 1
                If Dtr.Item("STATUS").ToString = "I" Then
                    If MsgBox("รายการนี้ถูกยกเลิกเเล้ว คุณต้องการเรียกคืนกลับมาใช่หรือไม่", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
                    strStatus = "A"
                End If

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("Status").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                .Item(5, .Rows.Count - 2).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("REASON").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("AttachFile").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("DOCTYPE").ToString
                .Item(9, .Rows.Count - 2).Value = Dtr.Item("SELECTSYSTEM").ToString
            End With

            TxtDOCNAME.Text = Dtr.Item("DOCNAME").ToString

        Next


    End Sub

    Private Sub TxtDOCTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCTYPE.SelectedIndexChanged
        strDOCTYPE = ""
        grdData.Rows.Clear()
        Call clearText()
        Call EnabledTextbox()
        strDOCTYPE = TxtDOCTYPE.SelectedValue.ToString

        If strDOCTYPE = "DEP" Then

            txtSELECTSYSTEM.Text = "Department"
            strSELECTSYSTEM = strDeptData

        ElseIf strDOCTYPE = "KMM" Then
            strSELECTSYSTEM = "KM"
            txtSELECTSYSTEM.Text = ""
        Else

            txtSELECTSYSTEM.Text = "Document System"
            strSELECTSYSTEM = "DS"
        End If
        'Select Case TxtDOCTYPE.Text
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

        '    Case "HAC"
        '        TxtDOCTYPE.Text = "HACCP"

        'End Select


        Call LoadDataDeptDATA(dgvDataDept)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim Sms As String = ""


        If TxtStatus.Text = "เอกสารยกเลิก" Then

            Sms = "เอกสารนี้ยกเเล้ว คุณต้องการนำเอกสาร   " & TxtDOCNO.Text & "    กลับมาใช้ ใช่หรือไม่?"

        Else

            Sms = "คุณต้องการบันทึกข้อมูล    " & TxtDOCNO.Text & "    ใช่หรือไม่?"

        End If

        If MsgBox(Sms, MsgBoxStyle.YesNo, "Update") = MsgBoxResult.No Then Exit Sub

        Try

            Dim sqlinsert As String

            If CheckData() = False Then
                MsgBox("กรุณาตรวจสอบข้อมูลก่อนทำการบันทึก")
                Exit Sub
            Else
                If TxtStatus.Text = "เอกสารยกเลิก" Then

                    Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @STATUS " &
                                    "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)

                    myCommand.Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"

                    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

                Else

                    CmdExcute("DELETE FROM QEa_CourseMaster WHERE DOCNO ='" & TxtDOCNO.Text & "' AND  DOCTYPE ='" & strDOCTYPE & "' AND  REVNO =" & TxtREVNO.Text & "", DB_CMD.ObjConn)


                    'sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,DOCTYPE,AttachFile,REASON) " &
                    '        "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@DOCTYPE,@AttachFile,@REASON)"

                    'With comSave
                    '    .Parameters.Clear()
                    '    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                    '    .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                    '    .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
                    '    .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                    '    .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                    '    .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                    '    .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
                    '    .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = TxtLinkPdf.Text
                    '    .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text



                    '    .CommandText = sqlinsert
                    '    .Connection = DB_CMD.ObjConn
                    '    .ExecuteNonQuery()

                    'End With

                    If strBranchConn = "TP" Then
                        TXTDOCSHARE.Text = "TP"
                    Else
                        TXTDOCSHARE.Text = "KB"
                    End If

                    'Dim sqlinsert As String
                    sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,REASON,AttachFile,DOCSHARE,DOCTYPE,CRTID,CRTDT,BRANCHDATA,SELECTSYSTEM) " &
                                        "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@REASON,@AttachFile,@DOCSHARE,@DOCTYPE,@CRTID,@CRTDT,@BRANCHDATA,@SELECTSYSTEM)"
                    With comSave
                        .Parameters.Clear()
                        .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
                        .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                        .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"
                        .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                        .Parameters.Add("@REVNO", SqlDbType.Int).Value = TxtREVNO.Text
                        .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
                        .Parameters.Add("@REASON", SqlDbType.VarChar).Value = TxtREASON.Text
                        .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = TxtLinkPdf.Text
                        .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                        .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = strDOCTYPE
                        .Parameters.Add("@CRTID", SqlDbType.VarChar).Value = StrEmployeeNo
                        .Parameters.Add("@CRTDT", SqlDbType.VarChar).Value = TxtDateNow.Text
                        .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = strBranchConn
                        '.Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = strDEPTJOIN
                        .Parameters.Add("@SELECTSYSTEM", SqlDbType.VarChar).Value = strSELECTSYSTEM

                        .CommandText = sqlinsert
                        .Connection = DB_CMD.ObjConn
                        .ExecuteNonQuery()

                    End With





                End If




                Dim myCommand1 As New SqlCommand("Update QEa_CourseMaster Set DOCDEPT = @DOCDEPT ,DOCNAME=@DOCNAME,SELECTSYSTEM=@SELECTSYSTEM,AttachFile =@AttachFile,DOCSHARE=@DOCSHARE " &
                                                "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
                myCommand1.Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = TxtDOCDEPT.Text
                myCommand1.Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = TxtDOCNAME.Text
                myCommand1.Parameters.Add("@SELECTSYSTEM", SqlDbType.VarChar).Value = strSELECTSYSTEM
                myCommand1.Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = TxtLinkPdf.Text
                myCommand1.Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = TXTDOCSHARE.Text
                Dim rowsAffected1 As Integer = myCommand1.ExecuteNonQuery


            End If



            Call clearText()
            Call LoadData()





        Catch ex As Exception

        End Try




    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdData.CellMouseClick
        Try


            Call EnabledTextbox()

            TxtDOCNO.Text = Me.grdData.Item(0, Me.grdData.CurrentRow.Index).Value.ToString
            TxtDOCNAME.Text = Me.grdData.Item(1, Me.grdData.CurrentRow.Index).Value.ToString
            TxtDOCDEPT.Text = Me.grdData.Item(3, Me.grdData.CurrentRow.Index).Value.ToString
            TxtREVNO.Text = Me.grdData.Item(4, Me.grdData.CurrentRow.Index).Value.ToString
            TxtEFFDATE.Text = Me.grdData.Item(5, Me.grdData.CurrentRow.Index).Value.ToString
            TxtLinkPdf.Text = Me.grdData.Item(7, Me.grdData.CurrentRow.Index).Value.ToString
            'TxtDOCTYPE.Text = Me.grdData.Item(8, Me.grdData.CurrentRow.Index).Value.ToString
            TxtREASON.Text = Me.grdData.Item(8, Me.grdData.CurrentRow.Index).Value.ToString

            If Me.grdData.Item(2, Me.grdData.CurrentRow.Index).Value.ToString = "I" Then

                TxtStatus.Text = "เอกสารยกเลิก"
                Call DisabledTextbox()
            Else

                ' TxtStatus.Text = "ปกติ"

            End If




            Select Case Me.grdData.Item(6, Me.grdData.CurrentRow.Index).Value.ToString
                Case "MNL"
                    TxtDOCTYPE.Text = "Manual"
                Case "PRC"
                    TxtDOCTYPE.Text = "Procedure"
                Case "WIN"
                    TxtDOCTYPE.Text = "Work Instruction"
                Case "STD"
                    TxtDOCTYPE.Text = "Standard Document"
                Case "RCF"
                    TxtDOCTYPE.Text = "Record Form"
                Case "KMM"
                    TxtDOCTYPE.Text = "Knowledge Management"

                Case "OGN"
                    TxtDOCTYPE.Text = "Organization Chart"

                Case "JOB"
                    TxtDOCTYPE.Text = "Job Description"

                Case "HAC"
                    TxtDOCTYPE.Text = "HACCP"
                Case "DEP"
                    TxtDOCTYPE.Text = "Standard Document by Dept."

            End Select

            If Me.grdData.Item(9, Me.grdData.CurrentRow.Index).Value.ToString = "DS" Then
                txtSELECTSYSTEM.Text = "Document System"
            Else
                txtSELECTSYSTEM.Text = "Department"
            End If
            ' Me.grdData.Item(0, Me.grdData.CurrentRow.Index).Value.ToString()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub bntAddItem_Click(sender As Object, e As EventArgs) Handles bntAddItem.Click
        Call EnabledTextbox()
        Call LoadDataDeptDATA(dgvDataDept)
        '  Call clearText()
    End Sub

    Private Sub TxtFindData_Click(sender As Object, e As EventArgs) Handles TxtFindData.Click

    End Sub



    Private Sub TxtDOCTYPEFind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDOCTYPEFind.SelectedIndexChanged
        grdData.Rows.Clear()
        strDOCTYPE = ""
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

        strDOCTYPE = TxtDOCTYPEFind.SelectedValue.ToString

        Call clearText()

    End Sub

    Private Sub bntLinkPdf_Click(sender As Object, e As EventArgs) Handles bntLinkPdf.Click
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            ' Me.TxtFilename.Text = Dl.SafeFileName
            Me.TxtLinkPdf.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub
    Private Function ReadWordDoc(ByVal filename As String) As Byte()
        Dim fs As New System.IO.FileStream(filename, IO.FileMode.Open)
        Dim br As New System.IO.BinaryReader(fs)
        Dim data() As Byte = br.ReadBytes(CInt(fs.Length))
        br.Close()
        fs.Close()
        Return data
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim strCri As String = ""


        strCri = "WHERE DOCTYPE ='" & strDOCTYPE & "' "

            If TxtFindData.Text <> "" Then
            strCri = strCri & "AND DOCNO  Like '" & TxtFindData.Text & "%' "
        End If


            Dim Sql As String = "Select *  from QEa_CourseMaster "
            Sql = Sql + strCri
            Sql = Sql + " Order by DOCTYPE,DOCNO,REVNO asc"
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
                .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                .Item(2, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString
                .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString
                .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                .Item(5, .Rows.Count - 2).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
                .Item(8, .Rows.Count - 2).Value = Dtr.Item("REASON").ToString
                .Item(7, .Rows.Count - 2).Value = Dtr.Item("AttachFile").ToString
                .Item(6, .Rows.Count - 2).Value = Dtr.Item("DOCTYPE").ToString
                .Item(9, .Rows.Count - 2).Value = Dtr.Item("SELECTSYSTEM").ToString
            End With

            Next


    End Sub

    Private Sub TxtFindData_TextChanged(sender As Object, e As EventArgs) Handles TxtFindData.TextChanged

    End Sub

    Private Sub TxtFindData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFindData.KeyPress
        Dim strCri As String = ""
        ' Call clearText()

        If e.KeyChar = Chr(13) Then
            strCri = "WHERE DOCTYPE ='" & strDOCTYPE & "' "

            If TxtFindData.Text <> "" Then
                strCri = strCri & "AND DOCNO  Like '" & TxtFindData.Text & "%' "
            End If


            Dim Sql As String = "Select *  from QEa_CourseMaster "
            Sql = Sql + strCri
            Sql = Sql + " Order by DOCTYPE,DOCNO,REVNO asc"
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
                    .Item(0, .Rows.Count - 2).Value = Dtr.Item("DOCNO").ToString
                    .Item(1, .Rows.Count - 2).Value = Dtr.Item("DOCNAME").ToString
                    .Item(2, .Rows.Count - 2).Value = Dtr.Item("STATUS").ToString
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("DOCDEPT").ToString
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("REVNO").ToString
                    .Item(5, .Rows.Count - 2).Value = Mid(Dtr.Item("EFFDATE").ToString, 1, 10)
                    .Item(8, .Rows.Count - 2).Value = Dtr.Item("REASON").ToString
                    .Item(7, .Rows.Count - 2).Value = Dtr.Item("AttachFile").ToString
                    .Item(6, .Rows.Count - 2).Value = Dtr.Item("DOCTYPE").ToString
                    .Item(9, .Rows.Count - 2).Value = Dtr.Item("SELECTSYSTEM").ToString
                End With

            Next

        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim Sms As String = "คุณต้องการลบข้อมูล    " & TxtDOCNO.Text & "    ออก จากรายการ หรือไม่?"
        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub


        Dim myCommand As New SqlCommand("Update QEa_CourseMaster Set STATUS = @STATUS " &
                                    "WHERE DOCNO = '" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)

        myCommand.Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "I"


        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        grdData.Rows.Clear()
        'Call LoadData()
        Call clearText()

    End Sub

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip3.ItemClicked

    End Sub

    Private Sub txtSELECTSYSTEM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSELECTSYSTEM.SelectedIndexChanged
        Select Case txtSELECTSYSTEM.Text
            Case "Document System"
                strSELECTSYSTEM = "DS"
            Case "Department"
                strSELECTSYSTEM = strDeptData
                'Case "KM"
                '    strSELECTSYSTEM = "KM"
        End Select

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ' chkSelectALL.Checked = False
        Dim Sms As String = "คุณต้องการลบข้อมูล" & " : " & TxtDOCNO.Text & " ( REVNO : " & TxtREVNO.Text & " )   ออก จากรายการ หรือไม่?"
        If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub
        CmdExcute("DELETE FROM QEa_CourseMaster  WHERE DOCNO='" & TxtDOCNO.Text & "' AND REVNO=" & TxtREVNO.Text & " ", DB_CMD.ObjConn)
        Call clearText()
        Call LoadData()
    End Sub

    Private Sub TxtStatus_TextChanged(sender As Object, e As EventArgs) Handles TxtStatus.TextChanged

    End Sub
End Class