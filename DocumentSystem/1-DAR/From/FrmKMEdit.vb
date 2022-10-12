Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows
Public Class FrmKMEdit
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
    Dim Exts As String
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub FrmKMEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Grid()
        '  Call LoadDataDept()



        Call GROUPNAME()


        TxtREFNO.Text = FrmDocumentSystem.TxtREFNO.Text
        TxtREFNODATA.Text = FrmDocumentSystem.TxtREFNODATA.Text
        TxtDOCNO.Text = FrmDocumentSystem.TxtDOCNO.Text
        TxtDOCNAME.Text = FrmDocumentSystem.TxtDOCNAME.Text
        Call LoadDataGridSelect()

        Call LoadData()
        Me.dgvUser.AllowUserToAddRows = True
        Call LoadDataUSER()
        Me.dgvUser.AllowUserToAddRows = False

        Call LoadDataAttFileKM()

    End Sub


    Sub LoadDataGridSelect()
        Try

            strDEPTJOIN = ","
            ' CmdExcute("DELETE FROM QEa_DocSysItem_SelectDept  WHERE REFNO='" & TxtREFNO.Text & "' AND  REFNODATA ='" & TxtREFNODATA.Text & "'  AND  DOCNO ='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)
            'dgvDataDept.DataSource = Nothing
            dgvDept.Rows.Clear()
            Call LoadDataDept()

            Dim Sql2 As String = "SELECT MAX(REFNODATA) AS MAXREFNODATA, DeptDATA, Branch, Lavel FROM QEm_KM_Dept_SEL "
            Sql2 = Sql2 + " WHERE  DOCNO ='" & TxtDOCNO.Text & "' GROUP BY DeptDATA, Branch, Lavel "

            Dim Dt2 As New DataTable
            Dt2 = DB_CMD.GetData_Table(Sql2, DB_CMD.ObjConn)
            'dgvCopyNo.Rows.Clear()
            Dim intNo As Integer = 1
            For Each Dtr2 As DataRow In Dt2.Rows

                With Me.dgvDept
                    For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                        If .Item(1, i).Value.ToString = Dtr2.Item("DeptDATA").ToString Then

                            .Item(0, i).Value = True

                            ' strDEPTJOIN = strDEPTJOIN & Dtr2.Item("DeptCod").ToString & ","

                        End If
                    Next

                End With


                TxtBranch.Text = Dtr2.Item("Branch").ToString
                TxtLavel.Text = Dtr2.Item("Lavel").ToString
                '  Exit Sub
            Next

            'strDEPTJOIN = strDEPTJOIN.Trim().Remove(strDEPTJOIN.Length - 1)
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือน")

            Exit Sub

        End Try
    End Sub


    Sub GROUPNAME()

        Dim command As New SqlCommand("SELECT  GROUPNAME, ID FROM  QEm_KM_GROUP  ORDER BY ID  ", DB_CMD.ObjConn)
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet
        adapter.Fill(table)



        adapter.Fill(ds, "QEm_KM_GROUP")
        If table.Rows.Count > 0 Then
            TxtGROUPNAME.DisplayMember = "GROUPNAME"
            TxtGROUPNAME.ValueMember = "ID"
            TxtGROUPNAME.DataSource = ds.Tables("QEm_KM_GROUP")
        End If


        Exit Sub
    End Sub




    Sub LoadDataAttFileKM()

        Dim cri As String = ""
        Dim strBranch As String = ""

        Dim Sql As String = "SELECT * FROM QEa_AttFile WHERE  REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'  "
        Sql = Sql + "Order by REFNO,REFNODATA asc"


        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


        Dim intNo1 As Integer = 1
        For Each Dtr As DataRow In Dt.Rows

            TxtAttFile_1.Text = Dtr.Item("AttFile1").ToString
            TxtFilename1.Text = Dtr.Item("Filename1").ToString

            ' intNo1 = intNo1 + 1
        Next
    End Sub

    Sub Grid()

        With Me.dgvDept
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With

        With Me.dgvUser
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With


    End Sub

    Sub LoadDataDept()

        Me.dgvDept.AllowUserToAddRows = True

        Dim Sql As String = "Select * from QEm_KM_Dept "
        Sql = Sql + " Order by ID,DeptDATA asc"
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        dgvDept.Rows.Clear()

        Dim intNo As Integer = 1
        For Each Dtr As DataRow In Dt.Rows
            With dgvDept
                ' intM = 1
                'intW = 1

                Application.DoEvents()
                .Rows.Add()
                ' .Item(0, .Rows.Count - 2).Value = intNo
                .Item(1, .Rows.Count - 2).Value = Dtr.Item("DeptDATA").ToString


            End With

        Next

        Me.dgvDept.AllowUserToAddRows = False
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        'Me.dgvDept.AllowUserToAddRows = True
        '  dgvDept.Rows.Clear()

        If TxtAttFile_1.Text = "" Then

            MsgBox("กรุณาเลือกไฟล์แนบด้วยค่ะ", MsgBoxStyle.Exclamation, "เเจ้งเตือน")
            TxtAttFile_1.Focus()
            Exit Sub
        End If

        CmdExcute("DELETE FROM QEm_KM_Dept_SEL WHERE REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

        For Each row As DataGridViewRow In dgvDept.Rows


            If CBool(row.Cells("Sel").Value) = True Then

                Dim sqlinsert As String
                sqlinsert = "INSERT INTO QEm_KM_Dept_SEL(REFNO,REFNODATA,DeptDATA,Branch,GROUPNAME,Lavel,DOCNO) " &
                                      "VALUES(@REFNO,@REFNODATA,@DeptDATA,@Branch,@GROUPNAME,@Lavel,@DOCNO)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DeptDATA", SqlDbType.VarChar).Value = (row.Cells("DeptData").Value.ToString)
                    .Parameters.Add("@Branch", SqlDbType.VarChar).Value = TxtBranch.Text
                    .Parameters.Add("@GROUPNAME", SqlDbType.VarChar).Value = TxtGROUPNAME.Text
                    .Parameters.Add("@Lavel", SqlDbType.VarChar).Value = TxtLavel.Text
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With

            End If

        Next


        Call AttfilesKM()

        Call SAVEUSERVIEW()

        Me.Close()

    End Sub

    Sub SAVEUSERVIEW()
        Try



            CmdExcute("DELETE FROM QEm_KM_UserView WHERE REFNO ='" & TxtREFNO.Text & "' AND DOCNO ='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)

            For Each row As DataGridViewRow In dgvUser.Rows



                Dim sqlinsert As String
                sqlinsert = "INSERT INTO QEm_KM_UserView(REFNO,REFNODATA,DeptDATA,Branch,Lavel,EmployeeNo,EmployeeName,DOCNO) " &
                                          "VALUES(@REFNO,@REFNODATA,@DeptDATA,@Branch,@Lavel,@EmployeeNo,@EmployeeName,@DOCNO)"

                With comSave
                    .Parameters.Clear()
                    .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
                    .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
                    .Parameters.Add("@DeptDATA", SqlDbType.VarChar).Value = (row.Cells("Dept").Value.ToString)
                    .Parameters.Add("@Branch", SqlDbType.VarChar).Value = TxtBranch.Text
                    .Parameters.Add("@Lavel", SqlDbType.VarChar).Value = (row.Cells("Level").Value.ToString)
                    .Parameters.Add("@EmployeeNo", SqlDbType.VarChar).Value = (row.Cells("UserID").Value.ToString)
                    .Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = (row.Cells("UserName").Value.ToString)
                    .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text

                    .CommandText = sqlinsert
                    .Connection = DB_CMD.ObjConn
                    .ExecuteNonQuery()

                End With

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub AttfilesKM()




        CmdExcute("DELETE FROM QEa_AttFile WHERE REFNO ='" & TxtREFNO.Text & "' AND DOCNO ='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)


        Dim sqlinsert As String
        sqlinsert = "INSERT INTO QEa_AttFile(REFNO,REFNODATA,DOCNO,AttFile1,Filename1) " &
                                  "VALUES(@REFNO,@REFNODATA,@DOCNO,@AttFile1,@Filename1)"

        With comSave
            .Parameters.Clear()
            .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
            .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
            .Parameters.Add("@AttFile1", SqlDbType.VarChar).Value = TxtAttFile_1.Text
            .Parameters.Add("@Filename1", SqlDbType.VarChar).Value = TxtFilename1.Text

            .CommandText = sqlinsert
            .Connection = DB_CMD.ObjConn
            .ExecuteNonQuery()

        End With



        'If TxtApprove.CheckState = CheckState.Checked Then
        '    Dim myCommand As New SqlCommand("Update QEa_AttFile Set LinkFilePDF = @LinkFilePDF,Approve = @Approve ,ApproveName = @ApproveName,ApproveDate = @ApproveDate " &
        '                                  "WHERE REFNO = '" & TxtREFNO.Text & "' " &
        '                                  "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
        '    myCommand.Parameters.Add("@LinkFilePDF", SqlDbType.VarChar).Value = TxtLinkFilePDF.Text
        '    myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.CheckState
        '    myCommand.Parameters.Add("@ApproveName", SqlDbType.VarChar).Value = TxtApproveName.Text
        '    myCommand.Parameters.Add("@ApproveDate", SqlDbType.Date).Value = TxtApproveDate.Text

        '    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        'Else

        '    Dim purDT As Object
        '    purDT = DBNull.Value
        '    Dim myCommand As New SqlCommand("Update QEa_AttFile Set Approve = @Approve ,ApproveName = @ApproveName,ApproveDate = @ApproveDate " &
        '                                "WHERE REFNO = '" & TxtREFNO.Text & "' " &
        '                                "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
        '    myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.CheckState
        '    myCommand.Parameters.Add("@ApproveName", SqlDbType.VarChar).Value = TxtApproveName.Text
        '    myCommand.Parameters.Add("@ApproveDate", SqlDbType.Date).Value = purDT


        '    Dim rowsAffected As Integer = myCommand.ExecuteNonQuery



        'End If


        '  Call UpdateStatusDAR()


        '  Catch ex As Exception

        ' End Try


    End Sub

    Sub LoadData()

        Dim cri As String = ""
        Dim strBranch As String = ""

        Dim Sql As String = "SELECT * FROM QEm_KM_Dept_SEL WHERE  REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'  "
        Sql = Sql + "Order by REFNO,REFNODATA asc"


        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


        Dim intNo1 As Integer = 1
        For Each Dtr As DataRow In Dt.Rows



            TxtBranch.Text = Dtr.Item("Branch").ToString
            TxtGROUPNAME.Text = Dtr.Item("GROUPNAME").ToString
            TxtLavel.Text = Dtr.Item("Lavel").ToString

            ' intNo1 = intNo1 + 1
            ' Me.dgvDept.AllowUserToAddRows = True

            With Me.dgvDept
                For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot

                    If Dtr.Item("DeptData").ToString = .Item(1, i).Value.ToString Then

                        .Item(0, i).Value = True
                        GoTo NEXTSTEP
                    End If
                Next

            End With

            ' Me.dgvDept.AllowUserToAddRows = False
NEXTSTEP:
        Next


    End Sub



    Sub LoadDataUSER()
        Try



            Me.dgvUser.AllowUserToAddRows = True
            Dim cri As String = ""
            Dim strBranch As String = ""

            Dim Sql As String = "SELECT * FROM QEm_KM_UserView WHERE  REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "'  "
            Sql = Sql + "Order by REFNO,REFNODATA asc"

            dgvUser.Rows.Clear()
            Dim Dt As New DataTable
            Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)


            Dim intNo1 As Integer = 1
            Dim strChkDataUserView As String = ""


            For Each Dtr As DataRow In Dt.Rows

                strChkDataUserView = "OK"
                With dgvUser
                    Application.DoEvents()
                    .Rows.Add()
                    .Item(0, .Rows.Count - 2).Value = intNo1
                    .Item(1, .Rows.Count - 2).Value = Dtr.Item("Branch").ToString
                    .Item(2, .Rows.Count - 2).Value = Dtr.Item("DeptDATA").ToString
                    .Item(3, .Rows.Count - 2).Value = Dtr.Item("EmployeeNo").ToString
                    .Item(4, .Rows.Count - 2).Value = Dtr.Item("EmployeeName").ToString
                    .Item(5, .Rows.Count - 2).Value = Dtr.Item("Lavel").ToString


                End With

                intNo1 = intNo1 + 1
            Next


            If strChkDataUserView = "" Then


                Dim Sql1 As String = "SELECT  MAX(REFNODATA) AS Expr2, DeptDATA, Branch, GROUPNAME, Lavel, EmployeeNo, EmployeeName FROM QEm_KM_UserView WHERE  DOCNO  ='" & TxtDOCNO.Text & "' GROUP BY DeptDATA, Branch, GROUPNAME, Lavel, EmployeeNo, EmployeeName "
                Sql1 = Sql1 + "Order by DeptDATA,EmployeeNo asc"

                dgvUser.Rows.Clear()
                Dim Dt1 As New DataTable
                Dt1 = DB_CMD.GetData_Table(Sql1, DB_CMD.ObjConn)


                For Each Dtr1 As DataRow In Dt1.Rows

                    ' strChkDataUserView = "OK"
                    With dgvUser
                        Application.DoEvents()
                        .Rows.Add()
                        .Item(0, .Rows.Count - 2).Value = intNo1
                        .Item(1, .Rows.Count - 2).Value = Dtr1.Item("Branch").ToString
                        .Item(2, .Rows.Count - 2).Value = Dtr1.Item("DeptDATA").ToString
                        .Item(3, .Rows.Count - 2).Value = Dtr1.Item("EmployeeNo").ToString
                        .Item(4, .Rows.Count - 2).Value = Dtr1.Item("EmployeeName").ToString
                        .Item(5, .Rows.Count - 2).Value = Dtr1.Item("Lavel").ToString


                    End With

                    intNo1 = intNo1 + 1
                Next


            End If


            Me.dgvUser.AllowUserToAddRows = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "เเจ้งเตือน")

            Exit Sub
        End Try
    End Sub

    Private Sub bntSelectEm_Click(sender As Object, e As EventArgs) Handles bntSelectEm.Click
        StrFunction.KMEM = 2
        strShowFoam = "KMM"
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try
        FrmUserLogOn.Close()
        FrmUserLogOn.ShowDialog()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until 1 = StrFunction.KMEM

            Console.WriteLine("Start.")

        Loop
        Console.WriteLine("stop.")

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Call LoadDataUSER()
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellContentClick

    End Sub

    Private Sub dgvUser_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUser.CellMouseUp
        Try


            If e.Button = MouseButtons.Right Then
                Me.dgvUser.Rows(e.RowIndex).Selected = True
                dgvUser.FirstDisplayedScrollingRowIndex = e.RowIndex


                strLineRefNoData = TxtREFNO.Text
                strLineData = TxtREFNODATA.Text
                strUserSEL = dgvUser.Rows(e.RowIndex).Cells(3).Value().ToString.Trim()

                Me.MetroContextMenu1.Show(Me.dgvUser, e.Location)
                MetroContextMenu1.Show(Cursor.Position)


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuDelete_Click(sender As Object, e As EventArgs) Handles menuDelete.Click
        Try


            If strLineDataDAR = "" Then

                Dim Sms As String = "คุณต้องการลบข้อมูล :" & strLineData & "    ออก จากรายการ หรือไม่?"
                If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub

                CmdExcute("DELETE FROM QEm_KM_UserView  WHERE RefNo='" & TxtREFNO.Text & "' " &
                           "AND REFNODATA='" & TxtREFNODATA.Text & "' AND EmployeeNo ='" & strUserSEL & "' ", DB_CMD.ObjConn)

                Call LoadDataUSER()


            Else

                For Each dr As DataGridViewRow In dgvUser.Rows

                    If dr.Selected = True Then
                        intSelectedRow = dr.Index
                        StrFunction.RowSelected = intSelectedRow
                    End If

                Next


                StrFunction.DeleteDAR = 2
                Try
                    BackgroundWorker1.RunWorkerAsync()
                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkSelectALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectALL.CheckedChanged
        With Me.dgvDept
            For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                If chkSelectALL.Checked = True Then
                    .Item(0, i).Value = True
                Else
                    .Item(0, i).Value = False
                End If

            Next
        End With
    End Sub
    Private Function ReadWordDoc(ByVal filename As String) As Byte()
        Dim fs As New System.IO.FileStream(filename, IO.FileMode.Open)
        Dim br As New System.IO.BinaryReader(fs)
        Dim data() As Byte = br.ReadBytes(CInt(fs.Length))
        br.Close()
        fs.Close()
        Return data
    End Function
    Private Sub bntLinkFilePDF_Click(sender As Object, e As EventArgs) Handles bntLinkFilePDF.Click
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            Me.TxtFilename1.Text = Dl.SafeFileName
            Me.TxtAttFile_1.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub

    Private Sub bntTxtLinkFilePDF_Del_Click(sender As Object, e As EventArgs) Handles bntTxtLinkFilePDF_Del.Click

    End Sub

    Private Sub bntTxtLinkFilePDF_Del_DoubleClick(sender As Object, e As EventArgs) Handles bntTxtLinkFilePDF_Del.DoubleClick
        TxtAttFile_1.Text = ""
    End Sub

    Private Sub bntTxtLinkFilePDF_Open_Click(sender As Object, e As EventArgs) Handles bntTxtLinkFilePDF_Open.Click
        Try


            Process.Start(TxtAttFile_1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtFilename1_TextChanged(sender As Object, e As EventArgs) Handles TxtFilename1.TextChanged

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtBranch.SelectedIndexChanged
        FrmDocumentSystem.TXTDOCSHARE.Text = TxtBranch.Text
    End Sub
End Class