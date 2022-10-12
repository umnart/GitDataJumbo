Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEn_RrsNo

Dim Cnn as New SqlClient.SqlConnection 
Dim ValRRSNO  as  integer
'****************************************************************
    Property RRSNO() as  integer
    Get 
         Return  ValRRSNO
    End Get 
    Set(ByVal value As  integer) 
         ValRRSNO= Value
    End Set 
    End Property 
'****************************************************************
Dim ValYEAR  as  integer
'****************************************************************
    Property YEAR() as  integer
    Get 
         Return  ValYEAR
    End Get 
    Set(ByVal value As  integer) 
         ValYEAR= Value
    End Set 
    End Property
    '****************************************************************

    Dim ValTypeData As String
    '****************************************************************
    Property TypeData() As String
        Get
            Return ValTypeData
        End Get
        Set(ByVal value As String)
            ValTypeData = value
        End Set
    End Property
    '****************************************************************
    Dim ValDeptData As String
    '****************************************************************
    Property DeptData() As String
        Get
            Return ValDeptData
        End Get
        Set(ByVal value As String)
            ValDeptData = value
        End Set
    End Property
    '****************************************************************
    Public Function SQlServerConnect(ByVal Server As String, ByVal Userid As String, ByVal Password As String,Database as String) As Boolean
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
          Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(Sql, Cnn)
          Cmd.ExecuteNonQuery()
          CmdExcute = True
          Catch ex As Exception
          CmdExcute = False
          MsgBox(Err.Description)
    End Try
End Function


'****************************************************************
Public Function SqlCommandInsert() as  String 
     SqlCommandInsert=nothing 
   Try 
             Dim Sql As String = ""
             Sql="Insert Into QEn_RrsNo ("
            Sql = Sql + " RRSNO,"
            Sql = Sql + " TypeData,"
            Sql = Sql + " DeptData,"
            Sql =Sql +" YEAR"
             Sql=Sql +" ) Values ("
            Sql = Sql + "  " & RRSNO & " ,"
            Sql = Sql + "  '" & TypeData & "' ,"
            Sql = Sql + "  '" & DeptData & "' ,"
            Sql =Sql +" "&  YEAR & ""
             Sql=Sql +")"
             Return Sql
   Catch ex As Exception 

   End Try

End Function 
'****************************************************************
Public Function SqlCommandUpdate() as  String 
     SqlCommandUpdate=nothing 
   Try 
             Dim Sql As String = ""
             Sql="Update QEn_RrsNo Set "
            Sql = Sql + " RRSNO =" & RRSNO & ","
            Sql = Sql + " TypeData ='" & TypeData & "',"
            Sql = Sql + " DeptData ='" & DeptData & "',"
            Sql =Sql+" YEAR ="& YEAR &""
            Sql = Sql + "Where RRSNO= " & RRSNO & ""
            Return Sql
   Catch ex As Exception 

   End Try

End Function 

'****************************************************************
Public Function GetData(SqlCommand as String ,Cnn as SqlClient.SqlConnection)as Boolean 
Dim Cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(Sqlcommand, Cnn)
Dim Dr As SqlClient.SqlDataReader = Cmd.ExecuteReader
    CleareData
    While Dr.Read
         RRSNO=Dr.Item("RRSNO")
            YEAR = Dr.Item("YEAR")
            TypeData = Dr.Item("TypeData")
            DeptData = Dr.Item("DeptData")
        End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        RRSNO=Nothing
        YEAR = Nothing
        TypeData = Nothing
        DeptData = Nothing

    End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEn_RrsNo
    '               .RRSNO=TxtRRSNO.Text
    '               .YEAR=TxtYEAR.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class