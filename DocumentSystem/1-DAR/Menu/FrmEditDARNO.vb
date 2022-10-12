Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Reflection
Public Class FrmEditDARNO

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

    Private Sub FrmEditDARNO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()
        Call LoadData()
    End Sub
    Sub LoadData()
        Me.Cursor = Cursors.WaitCursor


        'Dim command As New SqlCommand("SELECT  * FROM QEn_DarNo ORDER By YEAR ", DB_CMD.ObjConn)
        'Dim adapter As New SqlDataAdapter(command)
        'Dim ds As New DataSet
        'Dim table As New DataTable
        'adapter.Fill(table)

        'If table.Rows.Count > 0 Then

        '    TxtYear.Text = table.Rows(0).Item("YEAR").ToString
        '    TxtDarNo.Text = table.Rows(0).Item("DARNO").ToString

        'End If


        Dim Sql As String = "SELECT YEAR,DARNO "
        Sql = Sql + "From QEn_DarNo  "
        Sql = Sql + "ORDER BY YEAR DESC "
        Dim Dt As New DataTable
        Dim Cmd = New SqlCommand(Sql, DB_CMD.ObjConn)
        Dim Da = New SqlDataAdapter(Cmd)
        Da.Fill(Dt)
        Da.Dispose()
        dgvDetail.DataSource = Dt
        dgvDetail.Columns(0).ReadOnly = True
        dgvDetail.Columns(0).Width = 80
        dgvDetail.Columns(0).Width = 100

        Call Grid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each row As DataGridViewRow In dgvDetail.Rows

            Dim myCommand As New SqlCommand("Update QEn_DarNo Set DARNO = @DARNO  " &
                                                   "WHERE YEAR = '" & CStr(row.Cells("YEAR").Value) & "' ", DB_CMD.ObjConn)

            myCommand.Parameters.Add("@DARNO", SqlDbType.VarChar).Value = CStr(row.Cells("DARNO").Value)
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery

        Next


        With dgvDetail

        End With

        Call LoadData()


    End Sub
    Sub Grid()
        Me.dgvDetail.AllowUserToAddRows = False
        With Me.dgvDetail
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 12)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 12)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .GridColor = Color.LightGray
        End With

    End Sub
End Class