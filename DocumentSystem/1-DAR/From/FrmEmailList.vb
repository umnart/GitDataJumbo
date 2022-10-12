Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmEmailList
    Dim strConn As String
    Dim Conn As New SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim strSQL As String
    Dim Check As Boolean
    Dim Action As String
    Dim IsFindType, IsFindRepair, IsFindName As Boolean
    Dim strHostName As String
    Dim strDept As String
    Dim strBranch As String
    Dim strJobNo As String
    Dim comSave As New SqlCommand
    Dim comUpdate As New SqlCommand
    Dim strJobDateFM As String
    ' Dim strType As String
    ' Dim strJObNo_OK As String
    Dim strJobDateTO As String
    ' Dim strTTCCEmail As String

    Private Sub FrmEmailList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadData()
        Call Grid()

        TxtEmail.Text = ""
        StrSelEmail = ""
        TxtFind.Text = ""

        TxtFind.Focus()

        If strTTCCEmail = "TO" Then
            Button3.Text = "TO :"
        ElseIf strTTCCEmail = "CC" Then
            Button3.Text = "CC :"
        End If



    End Sub
    Sub Grid()

        With Me.DgvFind
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            '.AlternatingRowsDefaultCellStyle.Font.arial, 
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 8)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        End With

    End Sub

    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs) Handles TxtFind.TextChanged
        chkSelectALL.Checked = False
        Call LoadData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each row As DataGridViewRow In DgvFind.Rows
            If CBool(row.Cells("Sel").Value) = True Then

                StrSelEmail = StrSelEmail & CStr(row.Cells("Email").Value) & ","

            End If

        Next
        With Me.DgvFind
            For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                .Item(0, i).Value = False

            Next
        End With

        chkSelectALL.Checked = False
        TxtEmail.Text = StrSelEmail
    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        If TxtEmail.Text <> "" Then
            ' FrmRepairSevice.TxtEmailCC.Text = StrSelEmail.Trim().Remove(StrSelEmail.Length - 1)
            If strTTCCEmail = "TO" Then
                FrmDocumentSystem_SendMail.txtToEmail1.Text = StrSelEmail.Trim().Remove(StrSelEmail.Length - 1)
                Me.Close()
            ElseIf strTTCCEmail = "CC" Then
                FrmDocumentSystem_SendMail.TxtEmailCC1.Text = StrSelEmail & FrmDocumentSystem_SendMail.TxtEmailFM1.Text
                Me.Close()
            End If

        End If
    End Sub

    Dim StrSelEmail As String = ""
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub chkSelectALL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectALL.CheckedChanged
        Try


            With Me.DgvFind
                For i As Integer = 0 To .Rows.Count - 1 'Loop data for check lot
                    If chkSelectALL.Checked = True Then
                        .Item(0, i).Value = True
                    Else
                        .Item(0, i).Value = False
                    End If

                Next

            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Sub LoadData()



        Try

            DgvFind.Rows.Clear()


            Dim dt_SelectData = ClassConnect.getDataSetEmail("Select * FROM EMAIL WHERE DisplayName LIKE '%" & TxtFind.Text & "%'  ORDER BY DisplayName ", mytrans, "")

            If dt_SelectData.Rows.Count > 0 Then

                For i As Integer = 0 To dt_SelectData.Rows.Count - 1

                    DgvFind.Rows.Add(1)
                    DgvFind.Rows(DgvFind.Rows.Count - 1).Cells("DisplayName").Value = dt_SelectData.Rows(i).Item("DisplayName").ToString
                    DgvFind.Rows(DgvFind.Rows.Count - 1).Cells("AliasEmail").Value = dt_SelectData.Rows(i).Item("Alias").ToString
                    DgvFind.Rows(DgvFind.Rows.Count - 1).Cells("Email").Value = dt_SelectData.Rows(i).Item("Email").ToString

                Next
            End If




            Exit Sub


        Catch ex As Exception
            MsgBox("ERROR กรุณาแจ้งฝ่าย iT ด้วยครับ!", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        Call LoadData()
    End Sub
End Class