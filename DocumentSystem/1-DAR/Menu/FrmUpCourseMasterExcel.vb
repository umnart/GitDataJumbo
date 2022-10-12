Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Threading
Imports System.Data.SqlTypes
'Imports Microsoft.OFFICE.INTERRAP
Imports System.Data
'Imports System.ID
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class FrmUpCourseMasterExcel
    Public dr As OleDbDataReader
    Dim Exts As String
    Dim strDESTI As String
    Dim strDESTIData As String
    Dim ConnSA As New OleDbConnection
    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim da2 As SqlDataAdapter
    Dim ds2 As New DataSet
    Dim da3 As SqlDataAdapter
    Dim ds3 As New DataSet
    Dim strSQL As String
    Dim cri As String = ""
    Dim strDateDueStartFM, strDateDueStartTO As String
    Dim IsFindItemcode As Boolean


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


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Call Grid()
    End Sub

    Private Function ReadWordDoc(ByVal filename As String) As Byte()
        Dim fs As New System.IO.FileStream(filename, IO.FileMode.Open)
        Dim br As New System.IO.BinaryReader(fs)
        Dim data() As Byte = br.ReadBytes(CInt(fs.Length))
        br.Close()
        fs.Close()
        Return data
    End Function
    Private Sub SelectFile()
        Dim Dl As New OpenFileDialog
        If Dl.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Exts = IO.Path.GetExtension(Dl.FileName)
            ' Me.TxtFilename.Text = Dl.SafeFileName
            Me.TxtSourceFile.Text = Dl.FileName
            ' Me.TxtDescription.Focus()
        Else
            Exts = Nothing
        End If


    End Sub

    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmd.Click
        'If combLOADPLC.Text = "" Then
        '    MsgBox("เลือกสาขาก่อนจ๊ะ")
        '    Exit Sub
        'End If

        Call SelectFile()
        ListView1.Items.Clear()
        GetExcelSheetNames(Me.TxtSourceFile.Text)
    End Sub
    Private Sub GetExcelSheetNames(ByVal fileName As String)
        Try


            Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
              fileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
            Dim conn As New OleDbConnection(strconn)
            conn.Open()
            Dim dtSheets As DataTable =
                      conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim listSheet As New List(Of String)
            Dim drSheet As DataRow
            For Each drSheet In dtSheets.Rows
                listSheet.Add(drSheet("TABLE_NAME").ToString())
            Next
            'show sheetname in textbox where multiline Is true
            For Each sheet As String In listSheet
                '  ListView1.Items.Add(sheet & vbNewLine)
                ListView1.Items.Add(sheet)

                'ComboBox1.Items.Add(sheet)
                ' TextBox1.Text = TextBox1.Text & sheet & vbNewLine
            Next

            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Sub Grid()

        Me.grdFind.AllowUserToAddRows = False
        With Me.grdFind
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
    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        'Try
        'Dim strSheet As String
        Dim strSheet2 As String

        strSheet2 = ListView1.Text
        strSheet2 = "Select * from [" & strSheet2 & "] "


        Dim MyConnection As OleDb.OleDbConnection
        Dim Ds As System.Data.DataSet
        Dim MyAdapter As System.Data.OleDb.OleDbDataAdapter

        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & Me.TxtSourceFile.Text & "';Extended Properties='Excel 12.0 Xml;HDR=YES;'")
        MyAdapter = New System.Data.OleDb.OleDbDataAdapter(strSheet2, MyConnection)
        Ds = New System.Data.DataSet
        MyAdapter.Fill(Ds)
        Me.grdFind.DataSource = Ds.Tables(0)

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click


    End Sub

    Sub SAVESA()
        'With Me.dgvData

        '    For i As Integer = 0 To .Rows.Count - 1


        '        Dim sqlinsert As String


        '        CmdExcute("DELETE FROM QEa_CourseMaster WHERE DOCNO ='" & CType((dgvData.Rows(i).Cells(0).Value), String) & "' AND  DOCTYPE ='" & CType((dgvData.Rows(i).Cells(8).Value), String) & "' AND  REVNO =" & CType((dgvData.Rows(i).Cells(4).Value), String) & " AND DOCDEPT ='" & CType((dgvData.Rows(i).Cells(3).Value), String) & "'", DB_CMD.ObjConn)


        '        sqlinsert = "INSERT INTO QEa_CourseMaster(DOCNO,DOCNAME,STATUS,DOCDEPT,REVNO,EFFDATE,DOCTYPE,AttachFile,REASON,DOCSHARE,BRANCHDATA,SELECTSYSTEM) " &
        '                    "VALUES(@DOCNO,@DOCNAME,@STATUS,@DOCDEPT,@REVNO,@EFFDATE,@DOCTYPE,@AttachFile,@REASON,@DOCSHARE,@BRANCHDATA,@SELECTSYSTEM)"

        '        With comSave
        '            .Parameters.Clear()
        '            .Parameters.Add("@DOCNO", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(0).Value), String)
        '            .Parameters.Add("@DOCNAME", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(1).Value), String)
        '            .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(2).Value), String)
        '            .Parameters.Add("@DOCDEPT", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(3).Value), String)
        '            .Parameters.Add("@REVNO", SqlDbType.Int).Value = CType((dgvData.Rows(i).Cells(4).Value), String)
        '            TxtEFFDATE.Text = Mid(CType((dgvData.Rows(i).Cells(5).Value), String), 1, 10)
        '            If IsDBNull(CType((dgvData.Rows(i).Cells(5).Value), String)) Or CType((dgvData.Rows(i).Cells(5).Value), String) = "" Then
        '                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = TxtEFFDATE.Text
        '            Else
        '                .Parameters.Add("@EFFDATE", SqlDbType.Date).Value = CType((dgvData.Rows(i).Cells(5).Value), String)
        '            End If

        '            If IsDBNull(dgvData.Rows(i).Cells(8).Value) Then

        '                .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = "MNL"
        '            Else
        '                .Parameters.Add("@DOCTYPE", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(8).Value), String)

        '            End If


        '            If IsDBNull(dgvData.Rows(i).Cells(7).Value) Then
        '                .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = ""
        '            Else

        '                .Parameters.Add("@AttachFile", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(7).Value), String)

        '            End If
        '            If IsDBNull(dgvData.Rows(i).Cells(6).Value) Then

        '                .Parameters.Add("@REASON", SqlDbType.VarChar).Value = " "
        '            Else
        '                .Parameters.Add("@REASON", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(6).Value), String)
        '            End If


        '            .Parameters.Add("@DOCSHARE", SqlDbType.VarChar).Value = strBranchConn
        '            .Parameters.Add("@BRANCHDATA", SqlDbType.VarChar).Value = strBranchConn

        '            If CType((dgvData.Rows(i).Cells(3).Value), String) = "DC" Then

        '                .Parameters.Add("@SELECTSYSTEM", SqlDbType.VarChar).Value = "DS"
        '            Else
        '                .Parameters.Add("@SELECTSYSTEM", SqlDbType.VarChar).Value = CType((dgvData.Rows(i).Cells(3).Value), String)
        '            End If



        '            .CommandText = sqlinsert
        '            .Connection = DB_CMD.ObjConn
        '            .ExecuteNonQuery()

        '        End With


        '    Next


        'End With

        'MsgBox("OK")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class