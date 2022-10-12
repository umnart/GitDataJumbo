Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEn_DarNo

Dim Cnn as New SqlClient.SqlConnection 
Dim ValDARNO  as  integer
'****************************************************************
    Property DARNO() as  integer
    Get 
         Return  ValDARNO
    End Get 
    Set(ByVal value As  integer) 
         ValDARNO= Value
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
             Sql="Insert Into QEn_DarNo ("
             Sql=Sql +" DARNO,"
             Sql=Sql +" YEAR"
             Sql=Sql +" ) Values ("
         Sql=Sql +"  "&  DARNO & " ,"
             Sql=Sql +" "&  YEAR & ""
             Sql=Sql +")"
             Return Sql
   Catch ex As Exception 

   End Try

End Function
    '****************************************************************
    Public Function SqlCommandUpdate() As String
        SqlCommandUpdate = Nothing
        Try
            Dim Sql As String = ""
            Sql = "Update QEn_DarNo Set "
            Sql = Sql + " DARNO =" & DARNO & ","
            Sql = Sql + " YEAR =" & YEAR & ""
            Sql = Sql + "Where DARNO= " & DARNO & ""
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
            DARNO = Dr.Item("DARNO")
            YEAR = Dr.Item("YEAR")
        End While
        Dr.Close()
        Dr = Nothing

    End Function
    '****************************************************************


    Public Function CleareData() as Boolean 
        DARNO=Nothing
        YEAR=Nothing

End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEn_DarNo
    '               .DARNO=TxtDARNO.Text
    '               .YEAR=TxtYEAR.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class