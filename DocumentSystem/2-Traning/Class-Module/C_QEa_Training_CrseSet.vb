Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEa_Training_CrseSet

Dim Cnn as New SqlClient.SqlConnection 
Dim ValCrseSetCode  as  String
'****************************************************************
    Property CrseSetCode() as  String
    Get 
         Return  ValCrseSetCode
    End Get 
    Set(ByVal value As  String) 
         ValCrseSetCode= Value
    End Set 
    End Property 
'****************************************************************
Dim ValCrseSetNam  as  String
'****************************************************************
    Property CrseSetNam() as  String
    Get 
         Return  ValCrseSetNam
    End Get 
    Set(ByVal value As  String) 
         ValCrseSetNam= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDeptCodSet  as  String
'****************************************************************
    Property DeptCodSet() as  String
    Get 
         Return  ValDeptCodSet
    End Get 
    Set(ByVal value As  String) 
         ValDeptCodSet= Value
    End Set 
    End Property 
'****************************************************************
Dim ValCrseCode  as  String
'****************************************************************
    Property CrseCode() as  String
    Get 
         Return  ValCrseCode
    End Get 
    Set(ByVal value As  String) 
         ValCrseCode= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDeptCod  as  String
'****************************************************************
    Property DeptCod() as  String
    Get 
         Return  ValDeptCod
    End Get 
    Set(ByVal value As  String) 
         ValDeptCod= Value
    End Set 
    End Property
    '****************************************************************

    Dim ValRetrainFreq As String
    '****************************************************************
    Property RetrainFreq() As String
        Get
            Return ValRetrainFreq
        End Get
        Set(ByVal value As String)
            ValRetrainFreq = value
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
             Sql="Insert Into QEa_Training_CrseSet ("
             Sql=Sql +" CrseSetCode,"
             Sql=Sql +" CrseSetNam,"
             Sql=Sql +" DeptCodSet,"
            Sql = Sql + " CrseCode,"
            Sql = Sql + " RetrainFreq,"
            Sql =Sql +" DeptCod"
             Sql=Sql +" ) Values ("
             Sql=Sql +" '"&  CrseSetCode & "',"
             Sql=Sql +" '"&  CrseSetNam & "',"
             Sql=Sql +" '"&  DeptCodSet & "',"
            Sql = Sql + " '" & CrseCode & "',"
            Sql = Sql + " '" & RetrainFreq & "',"
            Sql =Sql +" '"&  DeptCod & "'"
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
             Sql="Update QEa_Training_CrseSet Set "
             Sql=Sql+" CrseSetCode ='"& CrseSetCode &"',"
             Sql=Sql+" CrseSetNam ='"& CrseSetNam &"',"
             Sql=Sql+" DeptCodSet ='"& DeptCodSet &"',"
            Sql = Sql + " RetrainFreq ='" & RetrainFreq & "',"
            Sql = Sql + " CrseCode ='" & CrseCode & "',"
            Sql =Sql+" DeptCod ='"& DeptCod &"'"
            Sql = Sql + "Where CrseSetCode= " & CrseSetCode & ""
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
         CrseSetCode=Dr.Item("CrseSetCode") 
         CrseSetNam=Dr.Item("CrseSetNam") 
         DeptCodSet=Dr.Item("DeptCodSet")
            CrseCode = Dr.Item("CrseCode")
            RetrainFreq = Dr.Item("RetrainFreq")

            DeptCod =Dr.Item("DeptCod") 
    End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        CrseSetCode=Nothing
        CrseSetNam=Nothing
        DeptCodSet=Nothing
        CrseCode=Nothing
        DeptCod = Nothing
        RetrainFreq = Nothing


    End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEa_Training_CrseSet
    '               .CrseSetCode=TxtCrseSetCode.Text
    '               .CrseSetNam=TxtCrseSetNam.Text
    '               .DeptCodSet=TxtDeptCodSet.Text
    '               .CrseCode=TxtCrseCode.Text
    '               .DeptCod=TxtDeptCod.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class