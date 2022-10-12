Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEm_ToDept

Dim Cnn as New SqlClient.SqlConnection 
Dim ValToDept  as  String
'****************************************************************
    Property ToDept() as  String
    Get 
         Return  ValToDept
    End Get 
    Set(ByVal value As  String) 
         ValToDept= Value
    End Set 
    End Property 
'****************************************************************
Dim ValToDeptName  as  String
'****************************************************************
    Property ToDeptName() as  String
    Get 
         Return  ValToDeptName
    End Get 
    Set(ByVal value As  String) 
         ValToDeptName= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDept  as  String
'****************************************************************
    Property Dept() as  String
    Get 
         Return  ValDept
    End Get 
    Set(ByVal value As  String) 
         ValDept= Value
    End Set 
    End Property 
'****************************************************************
Dim ValBranch  as  String
'****************************************************************
    Property Branch() as  String
    Get 
         Return  ValBranch
    End Get 
    Set(ByVal value As  String) 
         ValBranch= Value
    End Set 
    End Property 
'****************************************************************
'****************************************************************
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
             Sql="Insert Into QEm_ToDept ("
             Sql=Sql +" ToDept,"
             Sql=Sql +" ToDeptName,"
             Sql=Sql +" Dept,"
             Sql=Sql +" Branch"
             Sql=Sql +" ) Values ("
             Sql=Sql +" '"&  ToDept & "',"
             Sql=Sql +" '"&  ToDeptName & "',"
             Sql=Sql +" '"&  Dept & "',"
             Sql=Sql +" '"&  Branch & "'"
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
             Sql="Update QEm_ToDept Set "
             Sql=Sql+" ToDept ='"& ToDept &"',"
             Sql=Sql+" ToDeptName ='"& ToDeptName &"',"
             Sql=Sql+" Dept ='"& Dept &"',"
             Sql=Sql+" Branch ='"& Branch &"'"
            Sql = Sql + "Where ToDept= " & ToDept & ""
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
         ToDept=Dr.Item("ToDept") 
         ToDeptName=Dr.Item("ToDeptName") 
         Dept=Dr.Item("Dept") 
         Branch=Dr.Item("Branch") 
    End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        ToDept=Nothing
        ToDeptName=Nothing
        Dept=Nothing
        Branch=Nothing

End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEm_ToDept
    '               .ToDept=TxtToDept.Text
    '               .ToDeptName=TxtToDeptName.Text
    '               .Dept=TxtDept.Text
    '               .Branch=TxtBranch.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class