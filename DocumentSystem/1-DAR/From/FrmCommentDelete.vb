Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Net.Mail
Public Class FrmCommentDelete

    Public EditNo As String
    Private intSelectedRow As Integer
    Private rowIndex As Integer
    Dim strChekGrid As String

    Dim strStatus As String = ""
    Dim strTxtAppMgrEmail As String = ""
    Dim strTxtAppMREmail As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim Sms As String = "คุณต้องการลบข้อมูล :" & strLineData & "    ออก จากรายการ หรือไม่?"
        '     If MsgBox(Sms, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.No Then Exit Sub

        'CmdExcute("DELETE FROM QEa_DocSysItem  WHERE RefNo='" & strLineRefNoData & "' " &
        '          "AND REFNODATA='" & strLineData & "' ", DB_CMD.ObjConn)


        ' Update Running Number
        Dim myCommand As New SqlCommand("Update QEa_DocSysItem Set STATUS = @STATUS WHERE RefNo='" & strLineRefNoData & "'  AND REFNODATA='" & strLineData & "'  ", DB_CMD.ObjConn)
        myCommand.Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "Delete"
        Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


        Dim myCommand1 As New SqlCommand("Update QEa_DocSys_Dar Set RetReaSon1 = @RetReaSon1 WHERE RefNo='" & strLineRefNoData & "'  AND REFNODATA='" & strLineData & "'  ", DB_CMD.ObjConn)
        myCommand1.Parameters.Add("@RetReaSon1", SqlDbType.VarChar).Value = TxtRetReaSon1.Text
        Dim rowsAffected1 As Integer = myCommand1.ExecuteNonQuery


        StrFunction.DeleteDAR = 1

        Me.Close()

    End Sub

    Private Sub FrmCommentDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class