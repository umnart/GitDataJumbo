Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEa_SendDocToDept

Dim Cnn as New SqlClient.SqlConnection 
Dim ValDOCNO  as  String
'****************************************************************
    Property DOCNO() as  String
    Get 
         Return  ValDOCNO
    End Get 
    Set(ByVal value As  String) 
         ValDOCNO= Value
    End Set 
    End Property 
'****************************************************************
Dim Vallanguage  as  String
'****************************************************************
    Property language() as  String
    Get 
         Return  Vallanguage
    End Get 
    Set(ByVal value As  String) 
         Vallanguage= Value
    End Set 
    End Property 
'****************************************************************
Dim ValCtypeData  as  String
'****************************************************************
    Property CtypeData() as  String
    Get 
         Return  ValCtypeData
    End Get 
    Set(ByVal value As  String) 
         ValCtypeData= Value
    End Set 
    End Property 
'****************************************************************
Dim ValCopyNo  as  String
'****************************************************************
    Property CopyNo() as  String
    Get 
         Return  ValCopyNo
    End Get 
    Set(ByVal value As  String) 
         ValCopyNo= Value
    End Set 
    End Property 
'****************************************************************
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
Dim ValDocCtrl  as  String
'****************************************************************
    Property DocCtrl() as  String
    Get 
         Return  ValDocCtrl
    End Get 
    Set(ByVal value As  String) 
         ValDocCtrl= Value
    End Set 
    End Property 
'****************************************************************
Dim ValSTATUS  as  String
'****************************************************************
    Property STATUS() as  String
    Get 
         Return  ValSTATUS
    End Get 
    Set(ByVal value As  String) 
         ValSTATUS= Value
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
             Sql="Insert Into QEa_SendDocToDept ("
             Sql=Sql +" DOCNO,"
             Sql=Sql +" language,"
             Sql=Sql +" CtypeData,"
             Sql=Sql +" CopyNo,"
             Sql=Sql +" ToDept,"
             Sql=Sql +" DocCtrl,"
             Sql=Sql +" STATUS"
             Sql=Sql +" ) Values ("
             Sql=Sql +" '"&  DOCNO & "',"
             Sql=Sql +" '"&  language & "',"
             Sql=Sql +" '"&  CtypeData & "',"
             Sql=Sql +" '"&  CopyNo & "',"
             Sql=Sql +" '"&  ToDept & "',"
             Sql=Sql +" '"&  DocCtrl & "',"
             Sql=Sql +" '"&  STATUS & "'"
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
             Sql="Update QEa_SendDocToDept Set "
             Sql=Sql+" DOCNO ='"& DOCNO &"',"
             Sql=Sql+" language ='"& language &"',"
             Sql=Sql+" CtypeData ='"& CtypeData &"',"
             Sql=Sql+" CopyNo ='"& CopyNo &"',"
             Sql=Sql+" ToDept ='"& ToDept &"',"
             Sql=Sql+" DocCtrl ='"& DocCtrl &"',"
             Sql=Sql+" STATUS ='"& STATUS &"'"
            Sql = Sql + "Where DOCNO ='" & DOCNO & "' AND language ='" & language & "' AND CtypeData ='" & CtypeData & "'AND CopyNo ='" & CopyNo & "' AND ToDept ='" & ToDept & "'AND DocCtrl ='" & DocCtrl & "'"
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
         DOCNO=Dr.Item("DOCNO") 
         language=Dr.Item("language") 
         CtypeData=Dr.Item("CtypeData") 
         CopyNo=Dr.Item("CopyNo") 
         ToDept=Dr.Item("ToDept") 
         DocCtrl=Dr.Item("DocCtrl") 
         STATUS=Dr.Item("STATUS") 
    End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        DOCNO=Nothing
        language=Nothing
        CtypeData=Nothing
        CopyNo=Nothing
        ToDept=Nothing
        DocCtrl=Nothing
        STATUS=Nothing

End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEa_SendDocToDept
    '               .DOCNO=TxtDOCNO.Text
    '               .language=Txtlanguage.Text
    '               .CtypeData=TxtCtypeData.Text
    '               .CopyNo=TxtCopyNo.Text
    '               .ToDept=TxtToDept.Text
    '               .DocCtrl=TxtDocCtrl.Text
    '               .STATUS=TxtSTATUS.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class