Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmLogon
    Public CommandType As String
    Public EditNo As String
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        If TxtBranch.Text = "" Then
            MsgBox("กรูณาเลือกสาขาที่ต้องการ ", MsgBoxStyle.Critical, "Error")
            TxtBranch.Focus()
            Exit Sub
        End If
        strBranchConn = TxtBranch.Text

        DB_CMD.ObjConn.Close()
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()
        '
        ' Dim Sql As String = "Select * from QEm_UserLogOn where EmployeeNo ='" & TxtUserName.Text & "' AND EmployeePass='" & TxtPassword.Text & "' AND Branch='" & TxtBranch.Text & "' "

        Dim Sql As String = "Select * from QEm_UserLogOn where EmployeeNo ='" & TxtUserName.Text & "' AND EmployeePass='" & TxtPassword.Text & "' "


        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Dim strBranchID As String = ""
        For Each Dtr As DataRow In Dt.Rows

            StrEmployeeNo = Dtr.Item("EmployeeNo").ToString
            StrUserName = Dtr.Item("EmployeeName").ToString
            strDeptData = Dtr.Item("Dept").ToString
            strBranchData = Dtr.Item("Branch").ToString
            strLavelLogon = Dtr.Item("Lavel").ToString
            strEmailTo = Dtr.Item("Email").ToString
            strApprove = Dtr.Item("Approve").ToString
            ' FrmMainMenu.TxtSitename.Text = SiteName
            FrmMainMenu.TxtUserName.Text = StrUserName & " " & "(" & strDeptData & ")"

            If strBranchConn = "TP" Then
                FrmMainMenu.Label1.Text = "Document System and Training Record ( Theparak )"
            Else
                FrmMainMenu.Label1.Text = "Document System and Training Record ( Kabinburi )"
            End If

            ' FrmMainMenu.TxtSiteID.Text = SiteID
            'FrmShowAll.MdiParent = FrmMainMenu
            'FrmShowAll.Show()
            Me.Hide()

            Exit Sub


        Next

        If strBranchID = "" Then

            MsgBox("The user name or Password is incorrect", MsgBoxStyle.Exclamation, "Error Messages")
            '  TxtUserName.Text = ""
            TxtPassword.Text = ""
            TxtBranch.Text = ""
            TxtUserName.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        FrmUserLogOn.Close()
        FrmUserLogOn.ShowDialog()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
        FrmMainMenu.Close()
    End Sub

    Private Sub FrmLogon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()



        TxtBranch.Focus()

    End Sub

    Private Sub TxtUserName_TextChanged(sender As Object, e As EventArgs) Handles TxtUserName.TextChanged

    End Sub

    Private Sub TxtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUserName.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdLogin.Focus()
        End If
    End Sub

    Private Sub TxtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtBranch.SelectedIndexChanged
        TxtUserName.Focus()
        strBranchConn = TxtBranch.Text

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If TxtBranch.Text = "" Then
            MsgBox("กรูณาเลือกสาขาที่ต้องการ ", MsgBoxStyle.Critical, "Error")
            TxtBranch.Focus()
            Exit Sub
        End If

        If TxtUserName.Text = "" Then
            MsgBox("Invalid Data ", MsgBoxStyle.Critical, "Error")
            TxtUserName.Focus()
            Exit Sub
        End If

        strBranchConn = TxtBranch.Text

        DB_CMD.ObjConn.Close()

        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()


        '   Dim dt As DataTable

        ' strBranch2 = ""
        'dt = ClassConnect.getDataSet("Select * From KPI_Person Where PersonCode = '" & TxtUserName.Text & "'", mytrans, "")
        'If dt.Rows.Count > 0 Then

        '    StrUserName = dt.Rows(0).Item("BFnameE").ToString & " " & dt.Rows(0).Item("FnameE").ToString & " " & dt.Rows(0).Item("LnameE").ToString

        '    StrEmployeeNo = dt.Rows(0).Item("PersonCode").ToString

        '    TxtPassword.Text = ""

        'AND Branch='" & TxtBranch.Text & "'
        Dim Sql As String = "SELECT * FROM QEm_UserLogOn WHERE EmployeeNo ='" & TxtUserName.Text & "' "
        Dim Dt As New DataTable
        Dt = DB_CMD.GetData_Table(Sql, DB_CMD.ObjConn)
        Dim strBranchID As String = ""
        For Each Dtr As DataRow In Dt.Rows

            StrUserName = Dtr.Item("EmployeeName").ToString
            StrEmployeeNo = Dtr.Item("EmployeeNo").ToString


            FrmLogonChangePass.Close()
            FrmLogonChangePass.ShowDialog()
            'If strLavel = "Admin" Then

            '    FrmMainMenu.Button1.Enabled = True
            '    FrmMainMenu.CmdSele.Enabled = True
            'Else
            '    FrmMainMenu.Button1.Enabled = False
            '    FrmMainMenu.CmdSele.Enabled = False


            'End If

            'Me.Hide()

        Next
        '   MsgBox("The user name is incorrect", MsgBoxStyle.Exclamation, "Error Messages")
        '  TxtUserName.Focus()
        'Call DiabledData()

        Exit Sub

    End Sub


End Class