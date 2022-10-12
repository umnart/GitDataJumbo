Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEn_RefNo

Dim Cnn as New SqlClient.SqlConnection 
Dim ValREFNO  as  integer
'****************************************************************
    Property REFNO() as  integer
    Get 
         Return  ValREFNO
    End Get 
    Set(ByVal value As  integer) 
         ValREFNO= Value
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
    Dim ValSELECTSYSTEM As String
    '****************************************************************
    Property SELECTSYSTEM() As String
        Get
            Return ValSELECTSYSTEM
        End Get
        Set(ByVal value As String)
            ValSELECTSYSTEM = value
        End Set
    End Property

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
             Sql="Insert Into QEn_RefNo ("
             Sql=Sql +" REFNO,"
            Sql = Sql + " YEAR,"
            Sql = Sql + " SELECTSYSTEM"
            Sql =Sql +" ) Values ("
         Sql=Sql +"  "&  REFNO & " ,"
            Sql = Sql + " " & YEAR & ","
            Sql = Sql + " '" & SELECTSYSTEM & "'"
            Sql =Sql +")"
             Return Sql
   Catch ex As Exception 

   End Try

End Function 
'****************************************************************
Public Function SqlCommandUpdate() as  String 
     SqlCommandUpdate=nothing 
   Try 
             Dim Sql As String = ""
             Sql="Update QEn_RefNo Set "
             Sql=Sql+" REFNO ="& REFNO &","
            Sql = Sql + " YEAR =" & YEAR & ","
            Sql = Sql + " SELECTSYSTEM ='" & SELECTSYSTEM & "'"
            Sql = Sql + "Where REFNO= " & REFNO & ""
            Sql = Sql + " AND SELECTSYSTEM ='" & SELECTSYSTEM & "'"
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
            REFNO = Dr.Item("REFNO")
            YEAR = Dr.Item("YEAR")
            SELECTSYSTEM = Dr.Item("SELECTSYSTEM")
        End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        REFNO=Nothing
        YEAR=Nothing
        SELECTSYSTEM = Nothing

    End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEn_RefNo
    '               .REFNO=TxtREFNO.Text
    '               .YEAR=TxtYEAR.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class