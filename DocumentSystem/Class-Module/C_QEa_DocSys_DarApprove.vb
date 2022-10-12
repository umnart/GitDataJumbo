Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEa_DocSys_DarApprove

Dim Cnn as New SqlClient.SqlConnection 
Dim ValREFNO  as  String
'****************************************************************
    Property REFNO() as  String
    Get 
         Return  ValREFNO
    End Get 
    Set(ByVal value As  String) 
         ValREFNO= Value
    End Set 
    End Property 
'****************************************************************
Dim ValREFNODATA  as  String
'****************************************************************
    Property REFNODATA() as  String
    Get 
         Return  ValREFNODATA
    End Get 
    Set(ByVal value As  String) 
         ValREFNODATA= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDARNO  as  String
'****************************************************************
    Property DARNO() as  String
    Get 
         Return  ValDARNO
    End Get 
    Set(ByVal value As  String) 
         ValDARNO= Value
    End Set 
    End Property 
'****************************************************************
Dim ValNameApprove  as  String
'****************************************************************
    Property NameApprove() as  String
    Get 
         Return  ValNameApprove
    End Get 
    Set(ByVal value As  String) 
         ValNameApprove= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDeptApprove  as  String
'****************************************************************
    Property DeptApprove() as  String
    Get 
         Return  ValDeptApprove
    End Get 
    Set(ByVal value As  String) 
         ValDeptApprove= Value
    End Set 
    End Property 
'****************************************************************
Dim ValEmailApprove  as  String
'****************************************************************
    Property EmailApprove() as  String
    Get 
         Return  ValEmailApprove
    End Get 
    Set(ByVal value As  String) 
         ValEmailApprove= Value
    End Set 
    End Property 
'****************************************************************
Dim ValFlag  as  String
'****************************************************************
    Property Flag() as  String
    Get 
         Return  ValFlag
    End Get 
    Set(ByVal value As  String) 
         ValFlag= Value
    End Set 
    End Property 
'****************************************************************
Dim ValIDApprove  as  String
'****************************************************************
    Property IDApprove() as  String
    Get 
         Return  ValIDApprove
    End Get 
    Set(ByVal value As  String) 
         ValIDApprove= Value
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
             Sql="Insert Into QEa_DocSys_DarApprove ("
             Sql=Sql +" REFNO,"
             Sql=Sql +" REFNODATA,"
             Sql=Sql +" DARNO,"
             Sql=Sql +" NameApprove,"
             Sql=Sql +" DeptApprove,"
             Sql=Sql +" EmailApprove,"
             Sql=Sql +" Flag,"
             Sql=Sql +" IDApprove"
             Sql=Sql +" ) Values ("
             Sql=Sql +" '"&  REFNO & "',"
             Sql=Sql +" '"&  REFNODATA & "',"
             Sql=Sql +" '"&  DARNO & "',"
             Sql=Sql +" '"&  NameApprove & "',"
             Sql=Sql +" '"&  DeptApprove & "',"
             Sql=Sql +" '"&  EmailApprove & "',"
             Sql=Sql +" '"&  Flag & "',"
             Sql=Sql +" '"&  IDApprove & "'"
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
             Sql="Update QEa_DocSys_DarApprove Set "
             Sql=Sql+" REFNO ='"& REFNO &"',"
             Sql=Sql+" REFNODATA ='"& REFNODATA &"',"
             Sql=Sql+" DARNO ='"& DARNO &"',"
             Sql=Sql+" NameApprove ='"& NameApprove &"',"
             Sql=Sql+" DeptApprove ='"& DeptApprove &"',"
             Sql=Sql+" EmailApprove ='"& EmailApprove &"',"
             Sql=Sql+" Flag ='"& Flag &"',"
             Sql=Sql+" IDApprove ='"& IDApprove &"'"
            Sql = Sql + "Where REFNO= '" & REFNO & "' AND REFNODATA = '" & REFNODATA & "' "
            Return Sql
   Catch ex As Exception 

   End Try

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        REFNO=Nothing
        REFNODATA=Nothing
        DARNO=Nothing
        NameApprove=Nothing
        DeptApprove=Nothing
        EmailApprove=Nothing
        Flag=Nothing
        IDApprove=Nothing

End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEa_DocSys_DarApprove
    '               .REFNO=TxtREFNO.Text
    '               .REFNODATA=TxtREFNODATA.Text
    '               .DARNO=TxtDARNO.Text
    '               .NameApprove=TxtNameApprove.Text
    '               .DeptApprove=TxtDeptApprove.Text
    '               .EmailApprove=TxtEmailApprove.Text
    '               .Flag=TxtFlag.Text
    '               .IDApprove=TxtIDApprove.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class