Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class FrmLogonChangePass
    Private Sub FrmLogonChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        Dim Sql As String = "SELECT * FROM QEm_UserLogOn WHERE EmployeeNo ='" & StrEmployeeNo & "' AND EmployeePass = '" & TxtOldPassword.Text & "' "
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Dim strBranchID As String = ""
        For Each Dtr As DataRow In Dt.Rows


            If TxtNewPassword.Text = TxtConfirmPassword.Text Then

                Dim myCommand As New SqlCommand("Update QEm_UserLogOn Set EmployeePass = @EmployeePass WHERE EmployeeNo ='" & StrEmployeeNo & "' ", DB_CMD.ObjConn)
                myCommand.Parameters.Add("@EmployeePass", SqlDbType.VarChar).Value = TxtNewPassword.Text

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery


                Me.Close()

            Else
                MsgBox("The password does not match", MsgBoxStyle.Exclamation, "Error Messages")
                TxtNewPassword.Focus()
                Exit Sub
            End If

        Next

        Exit Sub
        Close()
        MsgBox("The old Password is incorrect", MsgBoxStyle.Exclamation, "Error Messages")
        TxtOldPassword.Focus()
        Exit Sub
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub
End Class