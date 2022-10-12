Public Class FrmSubMenu

    Private Sub FrmSubMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtBranch.Focus()
        '  txtUser.Focus()
        '   GetUserName()
        ' CreateContextMenu()

        '   StrFunction.connectStr = My.Settings.sunifdb2ConnectionString

        'strFunction.connectStr = "Data Source=ITSUNIF\ITSUNIF;Initial Catalog=DCSUFDTA;Persist Security Info=True;User ID=itkbs;Password=Zaq122wsxc;"



        Dim myBuildInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
        '' MsgBox("Product build part number: " & myBuildInfo.ProductBuildPart)

        Me.SplitContainer1.SplitterDistance = 62
        Me.WindowState = FormWindowState.Normal
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        Me.Bounds = Screen.GetWorkingArea(Me)

        Me.LabelVersion.Text = "Shipment Info " & myBuildInfo.ProductBuildPart




    End Sub



    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        '  MsgBox(Me.SplitContainer1.SplitterDistance)

        If Me.SplitContainer1.SplitterDistance < 300 Then

            Do While Me.SplitContainer1.SplitterDistance < 300
                Me.SplitContainer1.SplitterDistance = SplitContainer1.SplitterDistance + 50
            Loop
            Label1.Visible = True
            Panel2.Visible = True
            Panel7.Visible = True
        ElseIf Me.SplitContainer1.SplitterDistance >= 300 Then

            Label1.Visible = False
            Panel2.Visible = False
            Panel7.Visible = False

            Do While Me.SplitContainer1.SplitterDistance > 62

                Me.SplitContainer1.SplitterDistance = SplitContainer1.SplitterDistance - 31

            Loop

        End If

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim result As Integer = MessageBox.Show("Do you want to close application?: ", "Exit Confirm", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()

        ElseIf result = DialogResult.No Then

        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            'Me.Bounds = Screen.GetWorkingArea(Me)
        Else
            Me.WindowState = FormWindowState.Maximized
            '  Me.Bounds = Screen.GetWorkingArea(Me)
            ' Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        End If

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
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


        Dim Sql As String = "SELECT * FROM QEm_UserLogOn WHERE EmployeeNo ='" & TxtUserName.Text & "' AND Branch='" & TxtBranch.Text & "' "
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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        FrmUserLogOn.Close()
        FrmUserLogOn.ShowDialog()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        If TxtBranch.Text = "" Then
            MsgBox("กรูณาเลือกสาขาที่ต้องการ ", MsgBoxStyle.Critical, "Error")
            TxtBranch.Focus()
            Exit Sub
        End If
        strBranchConn = TxtBranch.Text

        DB_CMD.ObjConn.Close()
        If DB_CMD.ObjConn.State = ConnectionState.Closed Then ConnectSQL()



        Dim Sql As String = "Select * from QEm_UserLogOn where EmployeeNo ='" & TxtUserName.Text & "' AND EmployeePass='" & TxtPassword.Text & "' AND Branch='" & TxtBranch.Text & "' "
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

            lblUsername.Text = StrUserName

            If strBranchConn = "TP" Then
                FrmMainMenu.Label1.Text = "Document System and Training Record ( Theparak )"
            Else
                FrmMainMenu.Label1.Text = "Document System and Training Record ( Kabinburi )"
            End If

            ' FrmMainMenu.TxtSiteID.Text = SiteID
            'FrmShowAll.MdiParent = FrmMainMenu
            'FrmShowAll.Show()

            Try

                Do While Me.Panel4.Width > 10
                    Me.Panel4.Width = Panel4.Width - 2
                Loop
                Panel4.Visible = False
            Catch ex As Exception
            Finally
                Do While Me.SplitContainer1.SplitterDistance < 300
                    Me.SplitContainer1.SplitterDistance = SplitContainer1.SplitterDistance + 10
                Loop
                Label1.Visible = True
                Panel2.Visible = True
                Panel7.Visible = True
                PictureBox1.Visible = True
            End Try




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

    Private Sub bntReceive_Click(sender As Object, e As EventArgs) Handles bntReceive.Click
        '  frmPreShipment.Close()
        '  frmPrintShipment_Info.Close()
        '  frmTrailerBooking.Close()
        '  frmPrintTLBookingSheet.Close()

        If Application.OpenForms().OfType(Of FrmDocumentSystem_Find).Any Then

            MessageBox.Show("This from already to open", "SUNIF Application",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        Else

            Do While Me.SplitContainer1.SplitterDistance > 62
                Me.SplitContainer1.SplitterDistance = SplitContainer1.SplitterDistance - 12
            Loop


            Label1.Visible = False
            Panel2.Visible = False
            FrmMTC_Document.TopLevel = False
            FrmMTC_Document.TopMost = True
            Panel7.Visible = False
            Me.SplitContainer1.Panel2.Controls.Add(FrmMTC_Document)
            FrmMTC_Document.Show()



        End If
    End Sub

    Private Sub TxtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtBranch.SelectedIndexChanged
        TxtUserName.Focus()
    End Sub
End Class