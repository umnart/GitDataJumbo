Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEa_DocSysItem_Approve

Dim Cnn as New SqlClient.SqlConnection 
Dim ValLINEDATA  as  integer
'****************************************************************
    Property LINEDATA() as  integer
    Get 
         Return  ValLINEDATA
    End Get 
    Set(ByVal value As  integer) 
         ValLINEDATA= Value
    End Set 
    End Property 
'****************************************************************
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
Dim ValQEOFFICERAPPROVE  as  String
'****************************************************************
    Property QEOFFICERAPPROVE() as  String
    Get 
         Return  ValQEOFFICERAPPROVE
    End Get 
    Set(ByVal value As  String) 
         ValQEOFFICERAPPROVE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEOFFICERNAME  as  String
'****************************************************************
    Property QEOFFICERNAME() as  String
    Get 
         Return  ValQEOFFICERNAME
    End Get 
    Set(ByVal value As  String) 
         ValQEOFFICERNAME= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEOFFICERDATE  as  String
'****************************************************************
    Property QEOFFICERDATE() as  String
    Get 
         Return  ValQEOFFICERDATE
    End Get 
    Set(ByVal value As  String) 
         ValQEOFFICERDATE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEOFFICERREASON  as  String
'****************************************************************
    Property QEOFFICERREASON() as  String
    Get 
         Return  ValQEOFFICERREASON
    End Get 
    Set(ByVal value As  String) 
         ValQEOFFICERREASON= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEMGRAPPROVE  as  String
'****************************************************************
    Property QEMGRAPPROVE() as  String
    Get 
         Return  ValQEMGRAPPROVE
    End Get 
    Set(ByVal value As  String) 
         ValQEMGRAPPROVE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEMGRNAME  as  String
'****************************************************************
    Property QEMGRNAME() as  String
    Get 
         Return  ValQEMGRNAME
    End Get 
    Set(ByVal value As  String) 
         ValQEMGRNAME= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEMGRDATE  as  String
'****************************************************************
    Property QEMGRDATE() as  String
    Get 
         Return  ValQEMGRDATE
    End Get 
    Set(ByVal value As  String) 
         ValQEMGRDATE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEMGRREASON  as  String
'****************************************************************
    Property QEMGRREASON() as  String
    Get 
         Return  ValQEMGRREASON
    End Get 
    Set(ByVal value As  String) 
         ValQEMGRREASON= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEMRAPPROVE  as  String
'****************************************************************
    Property QEMRAPPROVE() as  String
    Get 
         Return  ValQEMRAPPROVE
    End Get 
    Set(ByVal value As  String) 
         ValQEMRAPPROVE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEMRNAME  as  String
'****************************************************************
    Property QEMRNAME() as  String
    Get 
         Return  ValQEMRNAME
    End Get 
    Set(ByVal value As  String) 
         ValQEMRNAME= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEMRDATE  as  String
'****************************************************************
    Property QEMRDATE() as  String
    Get 
         Return  ValQEMRDATE
    End Get 
    Set(ByVal value As  String) 
         ValQEMRDATE= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEMRREASON  as  String
'****************************************************************
    Property QEMRREASON() as  String
    Get 
         Return  ValQEMRREASON
    End Get 
    Set(ByVal value As  String) 
         ValQEMRREASON= Value
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
             Sql="Insert Into QEa_DocSysItem_Approve ("
             Sql=Sql +" LINEDATA,"
             Sql=Sql +" REFNO,"
             Sql=Sql +" REFNODATA,"
             Sql=Sql +" DARNO,"
             Sql=Sql +" QEOFFICERAPPROVE,"
             Sql=Sql +" QEOFFICERNAME,"
             Sql=Sql +" QEOFFICERDATE,"
             Sql=Sql +" QEOFFICERREASON,"
             Sql=Sql +" QEMGRAPPROVE,"
             Sql=Sql +" QEMGRNAME,"
             Sql=Sql +" QEMGRDATE,"
             Sql=Sql +" QEMGRREASON,"
             Sql=Sql +" QEMRAPPROVE,"
             Sql=Sql +" QEMRNAME,"
             Sql=Sql +" QEMRDATE,"
             Sql=Sql +" QEMRREASON"
             Sql=Sql +" ) Values ("
         Sql=Sql +"  "&  LINEDATA & " ,"
             Sql=Sql +" '"&  REFNO & "',"
             Sql=Sql +" '"&  REFNODATA & "',"
             Sql=Sql +" '"&  DARNO & "',"
             Sql=Sql +" '"&  QEOFFICERAPPROVE & "',"
             Sql=Sql +" '"&  QEOFFICERNAME & "',"
             Sql=Sql +" '"&  QEOFFICERDATE & "',"
             Sql=Sql +" '"&  QEOFFICERREASON & "',"
             Sql=Sql +" '"&  QEMGRAPPROVE & "',"
             Sql=Sql +" '"&  QEMGRNAME & "',"
             Sql=Sql +" '"&  QEMGRDATE & "',"
             Sql=Sql +" '"&  QEMGRREASON & "',"
             Sql=Sql +" '"&  QEMRAPPROVE & "',"
             Sql=Sql +" '"&  QEMRNAME & "',"
             Sql=Sql +" '"&  QEMRDATE & "',"
             Sql=Sql +" '"&  QEMRREASON & "'"
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
             Sql="Update QEa_DocSysItem_Approve Set "
            ' Sql=Sql+" LINEDATA ="& LINEDATA &","
            'Sql =Sql+" REFNO ='"& REFNO &"',"
            'Sql =Sql+" REFNODATA ='"& REFNODATA &"',"
            Sql =Sql+" DARNO ='"& DARNO &"',"
             Sql=Sql+" QEOFFICERAPPROVE ='"& QEOFFICERAPPROVE &"',"
             Sql=Sql+" QEOFFICERNAME ='"& QEOFFICERNAME &"',"
             Sql=Sql+" QEOFFICERDATE ='"& QEOFFICERDATE &"',"
             Sql=Sql+" QEOFFICERREASON ='"& QEOFFICERREASON &"',"
             Sql=Sql+" QEMGRAPPROVE ='"& QEMGRAPPROVE &"',"
             Sql=Sql+" QEMGRNAME ='"& QEMGRNAME &"',"
             Sql=Sql+" QEMGRDATE ='"& QEMGRDATE &"',"
             Sql=Sql+" QEMGRREASON ='"& QEMGRREASON &"',"
             Sql=Sql+" QEMRAPPROVE ='"& QEMRAPPROVE &"',"
             Sql=Sql+" QEMRNAME ='"& QEMRNAME &"',"
             Sql=Sql+" QEMRDATE ='"& QEMRDATE &"',"
             Sql=Sql+" QEMRREASON ='"& QEMRREASON &"'"
            Sql = Sql + "Where LINEDATA= " & LINEDATA & ""
            Sql = Sql + "AND   REFNO ='" & REFNO & "'"
            Sql = Sql + "AND REFNODATA ='" & REFNODATA & "'"
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
         LINEDATA=Dr.Item("LINEDATA") 
         REFNO=Dr.Item("REFNO") 
         REFNODATA=Dr.Item("REFNODATA") 
         DARNO=Dr.Item("DARNO") 
         QEOFFICERAPPROVE=Dr.Item("QEOFFICERAPPROVE") 
         QEOFFICERNAME=Dr.Item("QEOFFICERNAME") 
         QEOFFICERDATE=Dr.Item("QEOFFICERDATE") 
         QEOFFICERREASON=Dr.Item("QEOFFICERREASON") 
         QEMGRAPPROVE=Dr.Item("QEMGRAPPROVE") 
         QEMGRNAME=Dr.Item("QEMGRNAME") 
         QEMGRDATE=Dr.Item("QEMGRDATE") 
         QEMGRREASON=Dr.Item("QEMGRREASON") 
         QEMRAPPROVE=Dr.Item("QEMRAPPROVE") 
         QEMRNAME=Dr.Item("QEMRNAME") 
         QEMRDATE=Dr.Item("QEMRDATE") 
         QEMRREASON=Dr.Item("QEMRREASON") 
    End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        LINEDATA=Nothing
        REFNO=Nothing
        REFNODATA=Nothing
        DARNO=Nothing
        QEOFFICERAPPROVE=Nothing
        QEOFFICERNAME=Nothing
        QEOFFICERDATE=Nothing
        QEOFFICERREASON=Nothing
        QEMGRAPPROVE=Nothing
        QEMGRNAME=Nothing
        QEMGRDATE=Nothing
        QEMGRREASON=Nothing
        QEMRAPPROVE=Nothing
        QEMRNAME=Nothing
        QEMRDATE=Nothing
        QEMRREASON=Nothing

End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEa_DocSysItem_Approve
    '               .LINEDATA=TxtLINEDATA.Text
    '               .REFNO=TxtREFNO.Text
    '               .REFNODATA=TxtREFNODATA.Text
    '               .DARNO=TxtDARNO.Text
    '               .QEOFFICERAPPROVE=TxtQEOFFICERAPPROVE.Text
    '               .QEOFFICERNAME=TxtQEOFFICERNAME.Text
    '               .QEOFFICERDATE=TxtQEOFFICERDATE.Text
    '               .QEOFFICERREASON=TxtQEOFFICERREASON.Text
    '               .QEMGRAPPROVE=TxtQEMGRAPPROVE.Text
    '               .QEMGRNAME=TxtQEMGRNAME.Text
    '               .QEMGRDATE=TxtQEMGRDATE.Text
    '               .QEMGRREASON=TxtQEMGRREASON.Text
    '               .QEMRAPPROVE=TxtQEMRAPPROVE.Text
    '               .QEMRNAME=TxtQEMRNAME.Text
    '               .QEMRDATE=TxtQEMRDATE.Text
    '               .QEMRREASON=TxtQEMRREASON.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class