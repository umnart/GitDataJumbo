Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEm_UserLogOn

    Dim Cnn As New SqlClient.SqlConnection
    Dim ValEmployeeNo As String
    '****************************************************************
    Property EmployeeNo() As String
        Get
            Return ValEmployeeNo
        End Get
        Set(ByVal value As String)
            ValEmployeeNo = value
        End Set
    End Property
    '****************************************************************
    Dim ValEmployeeName As String
    '****************************************************************
    Property EmployeeName() As String
        Get
            Return ValEmployeeName
        End Get
        Set(ByVal value As String)
            ValEmployeeName = value
        End Set
    End Property
    '****************************************************************
    Dim ValEmployeePass As String
    '****************************************************************
    Property EmployeePass() As String
        Get
            Return ValEmployeePass
        End Get
        Set(ByVal value As String)
            ValEmployeePass = value
        End Set
    End Property
    '****************************************************************
    Dim ValDept As String
    '****************************************************************
    Property Dept() As String
        Get
            Return ValDept
        End Get
        Set(ByVal value As String)
            ValDept = value
        End Set
    End Property
    '****************************************************************
    Dim ValBranch As String
    '****************************************************************
    Property Branch() As String
        Get
            Return ValBranch
        End Get
        Set(ByVal value As String)
            ValBranch = value
        End Set
    End Property
    '****************************************************************
    Dim ValLavel As String
    '****************************************************************
    Property Lavel() As String
        Get
            Return ValLavel
        End Get
        Set(ByVal value As String)
            ValLavel = value
        End Set
    End Property
    '****************************************************************
    Dim ValApprove As String
    '****************************************************************
    Property Approve() As String
        Get
            Return ValApprove
        End Get
        Set(ByVal value As String)
            ValApprove = value
        End Set
    End Property
    '****************************************************************
    Dim ValEmail As String
    '****************************************************************
    Property Email() As String
        Get
            Return ValEmail
        End Get
        Set(ByVal value As String)
            ValEmail = value
        End Set
    End Property
    '****************************************************************
    '****************************************************************
    Public Function SQlServerConnect(ByVal Server As String, ByVal Userid As String, ByVal Password As String, Database As String) As Boolean
        Try
            With Cnn
                If .State Then .Close()
                Cnn.ConnectionString = "server=" & Server & ";uid=" & Userid & ";pwd=" & Password & ";database=" & Database & ""
                .Open()
                SQlServerConnect = True
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function

    Public Function CmdExcute(ByVal sql As String) As Boolean
        Try
            If Cnn.State = ConnectionState.Closed Then Cnn.Open()
            Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, Cnn)
            Cmd.ExecuteNonQuery()
            CmdExcute = True
        Catch ex As Exception
            CmdExcute = False
            MsgBox(Err.Description)
        End Try
    End Function


    '****************************************************************
    Public Function SqlCommandInsert() As String
        SqlCommandInsert = Nothing
        Try
            Dim Sql As String = ""
            Sql = "Insert Into QEm_UserLogOn ("
            Sql = Sql + " EmployeeNo,"
            Sql = Sql + " EmployeeName,"
            Sql = Sql + " EmployeePass,"
            Sql = Sql + " Dept,"
            Sql = Sql + " Branch,"
            Sql = Sql + " Lavel,"
            Sql = Sql + " Email,"
            Sql = Sql + " Approve"
            Sql = Sql + " ) Values ("
            Sql = Sql + " '" & EmployeeNo & "',"
            Sql = Sql + " '" & EmployeeName & "',"
            Sql = Sql + " '" & EmployeePass & "',"
            Sql = Sql + " '" & Dept & "',"
            Sql = Sql + " '" & Branch & "',"
            Sql = Sql + " '" & Lavel & "',"
            Sql = Sql + " '" & Email & "',"
            Sql = Sql + " '" & Approve & "'"
            Sql = Sql + ")"
            Return Sql
        Catch ex As Exception

        End Try

    End Function
    '****************************************************************
    Public Function SqlCommandUpdate() As String
        SqlCommandUpdate = Nothing
        Try
            Dim Sql As String = ""
            Sql = "Update QEm_UserLogOn Set "
            Sql = Sql + " EmployeeNo ='" & EmployeeNo & "',"
            Sql = Sql + " EmployeeName ='" & EmployeeName & "',"
            Sql = Sql + " EmployeePass ='" & EmployeePass & "',"
            Sql = Sql + " Dept ='" & Dept & "',"
            Sql = Sql + " Branch ='" & Branch & "',"
            Sql = Sql + " Lavel ='" & Lavel & "',"
            Sql = Sql + " Email ='" & Email & "',"
            Sql = Sql + " Approve ='" & Approve & "'"
            Sql = Sql + "Where EmployeeNo= '" & EmployeeNo & "'"
            Return Sql
        Catch ex As Exception

        End Try

    End Function

    '****************************************************************
    Public Function GetData(SqlCommand As String, Cnn As SqlClient.SqlConnection) As Boolean
        Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SqlCommand, Cnn)
        Dim Dr As SqlClient.SqlDataReader = Cmd.ExecuteReader
        CleareData()

        While Dr.Read
            EmployeeNo = Dr.Item("EmployeeNo")
            EmployeeName = Dr.Item("EmployeeName")
            EmployeePass = Dr.Item("EmployeePass")
            Dept = Dr.Item("Dept")
            Branch = Dr.Item("Branch")
            Lavel = Dr.Item("Lavel")
            Approve = Dr.Item("Approve")
            Email = Dr.Item("Email")
        End While
        Dr.Close()
        Dr = Nothing

    End Function
    '****************************************************************
    Public Function CleareData() As Boolean
        EmployeeNo = Nothing
        EmployeeName = Nothing
        EmployeePass = Nothing
        Dept = Nothing
        Branch = Nothing
        Lavel = Nothing
        Approve = Nothing
        Email = Nothing

    End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEm_UserLogOn
    '               .EmployeeNo=TxtEmployeeNo.Text
    '               .EmployeeName=TxtEmployeeName.Text
    '               .EmployeePass=TxtEmployeePass.Text
    '               .Dept=TxtDept.Text
    '               .Branch=TxtBranch.Text
    '               .Lavel=TxtLavel.Text
    '               .Approve=TxtApprove.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class