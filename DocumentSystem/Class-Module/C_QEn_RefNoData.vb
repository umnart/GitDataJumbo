Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEn_RefNoData

Dim Cnn as New SqlClient.SqlConnection 
Dim ValREFNODATA  as  integer
'****************************************************************
    Property REFNODATA() as  integer
    Get 
         Return  ValREFNODATA
    End Get 
    Set(ByVal value As  integer) 
         ValREFNODATA= Value
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
             Sql="Insert Into QEn_RefNoData ("
             Sql=Sql +" REFNODATA,"
             Sql=Sql +" YEAR"
             Sql=Sql +" ) Values ("
         Sql=Sql +"  "&  REFNODATA & " ,"
             Sql=Sql +" "&  YEAR & ""
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
             Sql="Update QEn_RefNoData Set "
             Sql=Sql+" REFNODATA ="& REFNODATA &","
             Sql=Sql+" YEAR ="& YEAR &""
            Sql = Sql + "Where REFNODATA= " & REFNODATA & ""
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
         REFNODATA=Dr.Item("REFNODATA") 
         YEAR=Dr.Item("YEAR") 
    End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        REFNODATA=Nothing
        YEAR=Nothing

End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEn_RefNoData
    '               .REFNODATA=TxtREFNODATA.Text
    '               .YEAR=TxtYEAR.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class