Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class FrmAttFile
    Dim Exts As String
    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim comSave As New SqlCommand
    Dim comDelete As New SqlCommand
    Dim comUpdate As New SqlCommand
    Dim SQL As String
    Dim strDOCTYPE As String

    Dim strCopyNo As String
    Dim intNUmber As Integer
    Dim strStatus As String

    Private Sub SelectFile()


    End Sub

    Private Function ReadWordDoc(ByVal filename As String) As Byte()
        Dim fs As New System.IO.FileStream(filename, IO.FileMode.Open)
        Dim br As New System.IO.BinaryReader(fs)
        Dim data() As Byte = br.ReadBytes(CInt(fs.Length))
        br.Close()
        fs.Close()
        Return data
    End Function
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmAttFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        TxtTypeAttFile.Text = FrmDocumentSystem.TxtTYPEATTFILE.Text
        TxtREFNO.Text = FrmDocumentSystem.TxtREFNO.Text
        TxtREFNODATA.Text = FrmDocumentSystem.TxtREFNODATA.Text
        TxtDOCNO.Text = FrmDocumentSystem.TxtDOCNO.Text


        If strDeptData = "SD" Or strDeptData = "GA" Or strDeptData = "HR" Or strDeptData = "HRGA" Then
            bntAttFile_2.Enabled = True
            bntDelete_2.Enabled = True

            bntAttFile_3.Enabled = True
            bntDelete_3.Enabled = True

            bntLinkFilePDF.Enabled = True
            bntTxtLinkFilePDF_Del.Enabled = True

        End If

        Call LoadData()


    End Sub

    Private Sub bntAttFile_1_Click(sender As Object, e As EventArgs) Handles bntAttFile_1.Click
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

    Private Sub bntAttFile_2_Click(sender As Object, e As EventArgs) Handles bntAttFile_2.Click
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            Me.TxtFilename2.Text = Dl.SafeFileName
            Me.TxtAttFile_2.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub

    Private Sub bntAttFile_3_Click(sender As Object, e As EventArgs) Handles bntAttFile_3.Click
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            Me.TxtFilename3.Text = Dl.SafeFileName
            Me.TxtAttFile_3.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs)


    End Sub


    Sub LoadData()

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
            TxtAttFile_2.Text = Dtr.Item("AttFile2").ToString
            TxtFilename2.Text = Dtr.Item("Filename2").ToString
            TxtAttFile_3.Text = Dtr.Item("AttFile3").ToString
            TxtFilename3.Text = Dtr.Item("Filename3").ToString
            TxtLinkFilePDF.Text = Dtr.Item("LinkFilePDF").ToString
            TxtFilename4.Text = Dtr.Item("Filename4").ToString
            If Dtr.Item("Approve").ToString = "Unchecked" Or Dtr.Item("Approve").ToString = "" Then
                TxtApprove.Checked = CBool(CheckState.Unchecked)
            ElseIf Dtr.Item("Approve").ToString = "Checked" Then
                TxtApprove.Checked = CBool(CheckState.Checked)
            End If
            TxtApproveDate.Text = Mid(Dtr.Item("ApproveDate").ToString, 1, 10)
            TxtApproveName.Text = Dtr.Item("ApproveName").ToString


            ' intNo1 = intNo1 + 1
        Next
    End Sub

    Private Sub bntDelete_1_Click(sender As Object, e As EventArgs) Handles bntDelete_1.Click

    End Sub

    Private Sub bntDelete_1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles bntDelete_1.MouseDoubleClick
        TxtAttFile_1.Text = ""
    End Sub

    Private Sub bntDelete_2_Click(sender As Object, e As EventArgs) Handles bntDelete_2.Click

    End Sub

    Private Sub bntDelete_2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles bntDelete_2.MouseDoubleClick
        TxtAttFile_2.Text = ""
    End Sub

    Private Sub bntDelete_3_Click(sender As Object, e As EventArgs) Handles bntDelete_3.Click

    End Sub

    Private Sub bntDelete_3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles bntDelete_3.MouseDoubleClick
        TxtAttFile_3.Text = ""
    End Sub

    Private Sub TxtAttFile_1_TextChanged(sender As Object, e As EventArgs) Handles TxtAttFile_1.TextChanged

    End Sub

    Private Sub TxtAttFile_1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtAttFile_1.MouseDoubleClick
        ' Process.Start(TxtAttFile_1.Text)
    End Sub

    Private Sub TxtAttFile_2_TextChanged(sender As Object, e As EventArgs) Handles TxtAttFile_2.TextChanged

    End Sub

    Private Sub TxtAttFile_2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtAttFile_2.MouseDoubleClick
        ' Process.Start(TxtAttFile_2.Text)
    End Sub

    Private Sub TxtAttFile_3_TextChanged(sender As Object, e As EventArgs) Handles TxtAttFile_3.TextChanged

    End Sub

    Private Sub TxtAttFile_3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtAttFile_3.MouseDoubleClick
        ' Process.Start(TxtAttFile_3.Text)
    End Sub

    Private Sub bntSave_Click_1(sender As Object, e As EventArgs) Handles bntSave.Click
        '   Try


        ' CmdExcute("DELETE FROM QEa_AttFile WHERE REFNO ='" & TxtREFNO.Text & "' AND REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
        CmdExcute("DELETE FROM QEa_AttFile WHERE REFNO ='" & TxtREFNO.Text & "' AND DOCNO ='" & TxtDOCNO.Text & "' ", DB_CMD.ObjConn)




        Dim sqlinsert As String
        sqlinsert = "INSERT INTO QEa_AttFile(REFNO,REFNODATA,DOCNO,AttFile1,Filename1,AttFile2,Filename2,AttFile3,Filename3,LinkFilePDF,Filename4) " &
                                  "VALUES(@REFNO,@REFNODATA,@DOCNO,@AttFile1,@Filename1,@AttFile2,@Filename2,@AttFile3,@Filename3,@LinkFilePDF,@Filename4)"

        With comSave
            .Parameters.Clear()
            .Parameters.Add("@REFNO", SqlDbType.VarChar).Value = TxtREFNO.Text
            .Parameters.Add("@REFNODATA", SqlDbType.VarChar).Value = TxtREFNODATA.Text
            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = TxtDOCNO.Text
            .Parameters.Add("@AttFile1", SqlDbType.VarChar).Value = TxtAttFile_1.Text
            .Parameters.Add("@Filename1", SqlDbType.VarChar).Value = TxtFilename1.Text
            .Parameters.Add("@AttFile2", SqlDbType.VarChar).Value = TxtAttFile_2.Text
            .Parameters.Add("@Filename2", SqlDbType.VarChar).Value = TxtFilename2.Text
            .Parameters.Add("@AttFile3", SqlDbType.VarChar).Value = TxtAttFile_3.Text
            .Parameters.Add("@Filename3", SqlDbType.VarChar).Value = TxtFilename3.Text
            .Parameters.Add("@LinkFilePDF", SqlDbType.VarChar).Value = TxtLinkFilePDF.Text
            .Parameters.Add("@Filename4", SqlDbType.VarChar).Value = TxtFilename4.Text
            '.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.CheckState
            '.Parameters.Add("@ApproveName", SqlDbType.VarChar).Value = TxtApproveName.Text
            '.Parameters.Add("@ApproveDate", SqlDbType.Date).Value = TxtApproveDate.Text

            .CommandText = sqlinsert
            .Connection = DB_CMD.ObjConn
            .ExecuteNonQuery()

        End With

        If TxtApprove.CheckState = CheckState.Checked Then
            Dim myCommand As New SqlCommand("Update QEa_AttFile Set LinkFilePDF = @LinkFilePDF,Approve = @Approve ,ApproveName = @ApproveName,ApproveDate = @ApproveDate " &
                                          "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                          "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@LinkFilePDF", SqlDbType.VarChar).Value = TxtLinkFilePDF.Text
            myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.CheckState
            myCommand.Parameters.Add("@ApproveName", SqlDbType.VarChar).Value = TxtApproveName.Text
            myCommand.Parameters.Add("@ApproveDate", SqlDbType.Date).Value = TxtApproveDate.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        Else

            Dim purDT As Object
            purDT = DBNull.Value
            Dim myCommand As New SqlCommand("Update QEa_AttFile Set Approve = @Approve ,ApproveName = @ApproveName,ApproveDate = @ApproveDate " &
                                        "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                        "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)
            myCommand.Parameters.Add("@Approve", SqlDbType.VarChar).Value = TxtApprove.CheckState
            myCommand.Parameters.Add("@ApproveName", SqlDbType.VarChar).Value = TxtApproveName.Text
            myCommand.Parameters.Add("@ApproveDate", SqlDbType.Date).Value = purDT


            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery



        End If


        Call UpdateStatusDAR()

        strShowFoam = "DOC_APPROVE"
        StrFunction.DOC_APPROVE = 1


        Me.Close()
        Exit Sub

        '  Catch ex As Exception

        ' End Try
    End Sub

    Sub UpdateStatusDAR()


        Try


            If TxtLinkFilePDF.Text <> "" And TxtApprove.CheckState = CheckState.Unchecked Then
                strStatus = "รอเอกสารลงนาม"
            End If


            If TxtLinkFilePDF.Text <> "" And TxtApprove.CheckState = CheckState.Checked Then
                strStatus = "รอประกาศใช้"
            End If

            Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set Status = @Status " &
                                               "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                               "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = strStatus
            ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery



            If TxtLinkFilePDF.Text <> "" And TxtApprove.CheckState = CheckState.Checked Then
                Dim myCommand1 As New SqlCommand("Update QEa_DocSys_Dar Set ChkEndApprove3 = @ChkEndApprove3 ,ChkEndDate3 = @ChkEndDate3 " &
                                              "WHERE REFNO = '" & TxtREFNO.Text & "' " &
                                               "And REFNODATA ='" & TxtREFNODATA.Text & "' ", DB_CMD.ObjConn)

                myCommand1.Parameters.Add("@ChkEndApprove3", SqlDbType.VarChar).Value = "จัดการ"
                myCommand1.Parameters.Add("@ChkEndDate3", SqlDbType.VarChar).Value = TxtDateData.Text

                ' myCommand.Parameters.Add("@DateVerify", SqlDbType.VarChar).Value = TxtDateVerify.Text

                Dim rowsAffected1 As Integer = myCommand1.ExecuteNonQuery

            End If






        Catch ex As Exception

        End Try


    End Sub

    Private Sub bntFind_Click(sender As Object, e As EventArgs) Handles bntFind.Click
        Try


            Process.Start(TxtAttFile_1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Try
            Process.Start(TxtAttFile_2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Try
            Process.Start(TxtAttFile_3.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub bntLinkFilePDF_Click(sender As Object, e As EventArgs) Handles bntLinkFilePDF.Click
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            Me.TxtFilename4.Text = Dl.SafeFileName
            Me.TxtLinkFilePDF.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If
    End Sub

    Private Sub bntTxtLinkFilePDF_Del_Click(sender As Object, e As EventArgs) Handles bntTxtLinkFilePDF_Del.Click

    End Sub

    Private Sub bntTxtLinkFilePDF_Del_DoubleClick(sender As Object, e As EventArgs) Handles bntTxtLinkFilePDF_Del.DoubleClick
        TxtLinkFilePDF.Text = ""
    End Sub

    Private Sub bntTxtLinkFilePDF_Open_Click(sender As Object, e As EventArgs) Handles bntTxtLinkFilePDF_Open.Click
        Try
            Process.Start(TxtLinkFilePDF.Text)

        Catch ex As Exception
        End Try

    End Sub

    Private Sub TxtQEoff8_CheckedChanged(sender As Object, e As EventArgs) Handles TxtApprove.CheckedChanged


        Try

            If TxtApprove.Checked = False Then
                TxtApproveName.Text = ""
                TxtApproveDate.Text = ""
                Exit Sub
            End If

            CheckMaxLineDataApproveAttfile(TxtREFNO.Text, TxtREFNODATA.Text)

            Dim command As New SqlCommand("SELECT  * FROM QEa_DocSysItem_Approve " &
                                     "WHERE REFNODATA ='" & TxtREFNODATA.Text & "'" &
                                     "AND LINEDATA ='" & strMaxLineDataAttfile & "'" &
                                     "AND QEMRAPPROVE ='Pass' " &
                                     "And REFNO ='" & TxtREFNO.Text & "'", DB_CMD.ObjConn)
            Dim table As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            Dim ds As New DataSet
            adapter.Fill(table)

            If table.Rows.Count = 0 Then

                MsgBox("ไม่สามารถลงนามเอกสารได้ เนื่องจาก MR ยังไม่ได้อนุมัติ  ", MsgBoxStyle.Critical, "เเจ้งเตือนให้อนุมัติ")

                TxtApprove.Checked = False

                Exit Sub

            End If





            If TxtApprove.Checked = True Then
                TxtApproveName.Text = StrUserName
                TxtApproveDate.Text = TxtDateNow.Text
            Else
                TxtApproveName.Text = ""
                TxtApproveDate.Text = ""

            End If


        Catch ex As Exception

        End Try
    End Sub
End Class

