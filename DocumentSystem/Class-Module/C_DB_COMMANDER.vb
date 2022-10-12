Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class C_DB_COMMANDER
    Dim ValCnn As New SqlClient.SqlConnection
    Property ObjConn() As SqlConnection
        Get
            Return ValCnn
        End Get
        Set(ByVal value As SqlConnection)
            ValCnn = value
        End Set
    End Property
    '****************************************************************
    Public Function SQlServerConnect(ByVal Server As String, ByVal Userid As String, ByVal Password As String, ByVal Database As String) As Boolean
        Try
            With ValCnn
                If .State Then .Close()
                ValCnn.ConnectionString = "server=" & Server & ";uid=" & Userid & ";pwd=" & Password & ";database=" & Database & ""
                .Open()
                SQlServerConnect = True
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        Return Nothing
    End Function
    '****************************************************************
    Public Function GetData_Table(ByVal SqlCommand As String, ByVal Cnn As SqlClient.SqlConnection) As DataTable

        Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SqlCommand, Cnn)
        Dim Dr As SqlClient.SqlDataReader = Cmd.ExecuteReader
        Dim Dt As New DataTable
        Dt.Load(Dr)
        Dr.Close()
        Dr.Dispose()
        Dr = Nothing
        Return Dt



    End Function
    Public Function GetData_TableDAR(ByVal SqlCommand As String, ByVal Cnn As SqlClient.SqlConnection) As DataTable

        Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SqlCommand, Cnn)
        Dim Dr As SqlClient.SqlDataReader = Cmd.ExecuteReader
        Dim Dt As New DataTable
        Dt.Load(Dr)
        Dr.Close()
        Dr.Dispose()
        Dr = Nothing
        Return Dt




    End Function


    Public Function GetData_TableNew(ByVal SqlCommand As String, ByVal Cnn As SqlClient.SqlConnection) As DataTable

        Dim CmdNew As SqlClient.SqlCommand = New SqlClient.SqlCommand(SqlCommand, Cnn)
        Dim Dr As SqlClient.SqlDataReader = CmdNew.ExecuteReader
        Dim Dt As New DataTable
        Dt.Load(Dr)
        Dr.Close()
        Dr.Dispose()
        Dr = Nothing
        Return Dt
    End Function
End Class
