Imports System
Imports System.Data
Imports System.Data.Sqlclient
Imports System.Data.Sql
'****************************************************************
Public Class C_QEa_DocSys_Dar

Dim Cnn as New SqlClient.SqlConnection 
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
Dim ValMonth  as  integer
'****************************************************************
    Property Month() as  integer
    Get 
         Return  ValMonth
    End Get 
    Set(ByVal value As  integer) 
         ValMonth= Value
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
Dim ValQEoff1  as  String
'****************************************************************
    Property QEoff1() as  String
    Get 
         Return  ValQEoff1
    End Get 
    Set(ByVal value As  String) 
         ValQEoff1= Value
    End Set 
    End Property 
'****************************************************************
Dim ValAttDoc1  as  String
'****************************************************************
    Property AttDoc1() as  String
    Get 
         Return  ValAttDoc1
    End Get 
    Set(ByVal value As  String) 
         ValAttDoc1= Value
    End Set 
    End Property 
'****************************************************************
Dim ValSendDocSrv1  as  String
'****************************************************************
    Property SendDocSrv1() as  String
    Get 
         Return  ValSendDocSrv1
    End Get 
    Set(ByVal value As  String) 
         ValSendDocSrv1= Value
    End Set 
    End Property 
'****************************************************************
Dim ValSendDocDate1  as  String
'****************************************************************
    Property SendDocDate1() as  String
    Get 
         Return  ValSendDocDate1
    End Get 
    Set(ByVal value As  String) 
         ValSendDocDate1= Value
    End Set 
    End Property 
'****************************************************************
Dim ValRecDocDate1  as  String
'****************************************************************
    Property RecDocDate1() as  String
    Get 
         Return  ValRecDocDate1
    End Get 
    Set(ByVal value As  String) 
         ValRecDocDate1= Value
    End Set 
    End Property 
'****************************************************************
Dim ValRetReaSon1  as  String
'****************************************************************
    Property RetReaSon1() as  String
    Get 
         Return  ValRetReaSon1
    End Get 
    Set(ByVal value As  String) 
         ValRetReaSon1= Value
    End Set 
    End Property 
'****************************************************************
Dim ValPrintCheck2  as  String
'****************************************************************
    Property PrintCheck2() as  String
    Get 
         Return  ValPrintCheck2
    End Get 
    Set(ByVal value As  String) 
         ValPrintCheck2= Value
    End Set 
    End Property 
'****************************************************************
Dim ValPrintDate2  as  String
'****************************************************************
    Property PrintDate2() as  String
    Get 
         Return  ValPrintDate2
    End Get 
    Set(ByVal value As  String) 
         ValPrintDate2= Value
    End Set 
    End Property 
'****************************************************************
Dim ValChkStartApprove3  as  String
'****************************************************************
    Property ChkStartApprove3() as  String
    Get 
         Return  ValChkStartApprove3
    End Get 
    Set(ByVal value As  String) 
         ValChkStartApprove3= Value
    End Set 
    End Property 
'****************************************************************
Dim ValChkStartDate3  as  String
'****************************************************************
    Property ChkStartDate3() as  String
    Get 
         Return  ValChkStartDate3
    End Get 
    Set(ByVal value As  String) 
         ValChkStartDate3= Value
    End Set 
    End Property 
'****************************************************************
Dim ValChkEndApprove3  as  String
'****************************************************************
    Property ChkEndApprove3() as  String
    Get 
         Return  ValChkEndApprove3
    End Get 
    Set(ByVal value As  String) 
         ValChkEndApprove3= Value
    End Set 
    End Property 
'****************************************************************
Dim ValChkEndDate3  as  String
'****************************************************************
    Property ChkEndDate3() as  String
    Get 
         Return  ValChkEndDate3
    End Get 
    Set(ByVal value As  String) 
         ValChkEndDate3= Value
    End Set 
    End Property 
'****************************************************************
Dim ValCopy4  as  String
'****************************************************************
    Property Copy4() as  String
    Get 
         Return  ValCopy4
    End Get 
    Set(ByVal value As  String) 
         ValCopy4= Value
    End Set 
    End Property 
'****************************************************************
Dim ValServer4  as  String
'****************************************************************
    Property Server4() as  String
    Get 
         Return  ValServer4
    End Get 
    Set(ByVal value As  String) 
         ValServer4= Value
    End Set 
    End Property 
'****************************************************************
Dim ValLink4  as  String
'****************************************************************
    Property Link4() as  String
    Get 
         Return  ValLink4
    End Get 
    Set(ByVal value As  String) 
         ValLink4= Value
    End Set 
    End Property 
'****************************************************************
Dim ValHardCopy5  as  String
'****************************************************************
    Property HardCopy5() as  String
    Get 
         Return  ValHardCopy5
    End Get 
    Set(ByVal value As  String) 
         ValHardCopy5= Value
    End Set 
    End Property 
'****************************************************************
Dim ValEmail5  as  String
'****************************************************************
    Property Email5() as  String
    Get 
         Return  ValEmail5
    End Get 
    Set(ByVal value As  String) 
         ValEmail5= Value
    End Set 
    End Property 
'****************************************************************
Dim ValHardCopy6  as  String
'****************************************************************
    Property HardCopy6() as  String
    Get 
         Return  ValHardCopy6
    End Get 
    Set(ByVal value As  String) 
         ValHardCopy6= Value
    End Set 
    End Property 
'****************************************************************
Dim ValServer6  as  String
'****************************************************************
    Property Server6() as  String
    Get 
         Return  ValServer6
    End Get 
    Set(ByVal value As  String) 
         ValServer6= Value
    End Set 
    End Property 
'****************************************************************
Dim ValLinkPdf7  as  String
'****************************************************************
    Property LinkPdf7() as  String
    Get 
         Return  ValLinkPdf7
    End Get 
    Set(ByVal value As  String) 
         ValLinkPdf7= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEoff8  as  String
'****************************************************************
    Property QEoff8() as  String
    Get 
         Return  ValQEoff8
    End Get 
    Set(ByVal value As  String) 
         ValQEoff8= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEoffName8  as  String
'****************************************************************
    Property QEoffName8() as  String
    Get 
         Return  ValQEoffName8
    End Get 
    Set(ByVal value As  String) 
         ValQEoffName8= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEoffDate8  as  String
'****************************************************************
    Property QEoffDate8() as  String
    Get 
         Return  ValQEoffDate8
    End Get 
    Set(ByVal value As  String) 
         ValQEoffDate8= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQE8  as  String
'****************************************************************
    Property QE8() as  String
    Get 
         Return  ValQE8
    End Get 
    Set(ByVal value As  String) 
         ValQE8= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEName8  as  String
'****************************************************************
    Property QEName8() as  String
    Get 
         Return  ValQEName8
    End Get 
    Set(ByVal value As  String) 
         ValQEName8= Value
    End Set 
    End Property 
'****************************************************************
Dim ValQEDate8  as  String
'****************************************************************
    Property QEDate8() as  String
    Get 
         Return  ValQEDate8
    End Get 
    Set(ByVal value As  String) 
         ValQEDate8= Value
    End Set 
    End Property 
'****************************************************************
Dim ValUserRunDar  as  String
'****************************************************************
    Property UserRunDar() as  String
    Get 
         Return  ValUserRunDar
    End Get 
    Set(ByVal value As  String) 
         ValUserRunDar= Value
    End Set 
    End Property 
'****************************************************************
Dim ValDateRunDar  as  String
'****************************************************************
    Property DateRunDar() as  String
    Get 
         Return  ValDateRunDar
    End Get 
    Set(ByVal value As  String) 
         ValDateRunDar= Value
    End Set 
    End Property
    '****************************************************************

    Dim ValLinkFilePDF As String
    '****************************************************************
    Property LinkFilePDF() As String
        Get
            Return ValLinkFilePDF
        End Get
        Set(ByVal value As String)
            ValLinkFilePDF = value
        End Set
    End Property

    '****************************************************************
    Dim ValQEoff1Date As String
    '****************************************************************
    Property QEoff1Date() As String
        Get
            Return ValQEoff1Date
        End Get
        Set(ByVal value As String)
            ValQEoff1Date = value
        End Set
    End Property
    '****************************************************************
    Dim ValAttDoc1Date As String
    '****************************************************************
    Property AttDoc1Date() As String
        Get
            Return ValAttDoc1Date
        End Get
        Set(ByVal value As String)
            ValAttDoc1Date = value
        End Set
    End Property
    '****************************************************************
    Dim ValSendDocSrv1Date As String
    '****************************************************************
    Property SendDocSrv1Date() As String
        Get
            Return ValSendDocSrv1Date
        End Get
        Set(ByVal value As String)
            ValSendDocSrv1Date = value
        End Set
    End Property
    '****************************************************************
    '****************************************************************
    '****************************************************************
    '****************************************************************
    '****************************************************************

    '****************************************************************
    '****************************************************************
    '****************************************************************
    '****************************************************************
    '****************************************************************
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
             Sql="Insert Into QEa_DocSys_Dar ("
             Sql=Sql +" Branch,"
             Sql=Sql +" STATUS,"
             Sql=Sql +" Flag,"
             Sql=Sql +" Month,"
             Sql=Sql +" REFNO,"
             Sql=Sql +" REFNODATA,"
             Sql=Sql +" DARNO,"
             Sql=Sql +" QEoff1,"
             Sql=Sql +" AttDoc1,"
             Sql=Sql +" SendDocSrv1,"
             Sql=Sql +" SendDocDate1,"
             Sql=Sql +" RecDocDate1,"
             Sql=Sql +" RetReaSon1,"
             Sql=Sql +" PrintCheck2,"
             Sql=Sql +" PrintDate2,"
             Sql=Sql +" ChkStartApprove3,"
             Sql=Sql +" ChkStartDate3,"
             Sql=Sql +" ChkEndApprove3,"
             Sql=Sql +" ChkEndDate3,"
             Sql=Sql +" Copy4,"
             Sql=Sql +" Server4,"
             Sql=Sql +" Link4,"
             Sql=Sql +" HardCopy5,"
             Sql=Sql +" Email5,"
             Sql=Sql +" HardCopy6,"
             Sql=Sql +" Server6,"
             Sql=Sql +" LinkPdf7,"
             Sql=Sql +" QEoff8,"
             Sql=Sql +" QEoffName8,"
             Sql=Sql +" QEoffDate8,"
             Sql=Sql +" QE8,"
             Sql=Sql +" QEName8,"
             Sql=Sql +" QEDate8,"
             Sql=Sql +" UserRunDar,"
            Sql = Sql + " DateRunDar,"
            Sql = Sql + " LinkFilePDF,"
            Sql = Sql + " QEoff1Date,"
            Sql = Sql + " AttDoc1Date,"
            Sql = Sql + " SendDocSrv1Date"
            Sql =Sql +" ) Values ("
             Sql=Sql +" '"&  Branch & "',"
             Sql=Sql +" '"&  STATUS & "',"
             Sql=Sql +" '"&  Flag & "',"
         Sql=Sql +"  "&  Month & " ,"
             Sql=Sql +" '"&  REFNO & "',"
             Sql=Sql +" '"&  REFNODATA & "',"
             Sql=Sql +" '"&  DARNO & "',"
             Sql=Sql +" '"&  QEoff1 & "',"
             Sql=Sql +" '"&  AttDoc1 & "',"
             Sql=Sql +" '"&  SendDocSrv1 & "',"
             Sql=Sql +" '"&  SendDocDate1 & "',"
             Sql=Sql +" '"&  RecDocDate1 & "',"
             Sql=Sql +" '"&  RetReaSon1 & "',"
             Sql=Sql +" '"&  PrintCheck2 & "',"
             Sql=Sql +" '"&  PrintDate2 & "',"
             Sql=Sql +" '"&  ChkStartApprove3 & "',"
             Sql=Sql +" '"&  ChkStartDate3 & "',"
             Sql=Sql +" '"&  ChkEndApprove3 & "',"
             Sql=Sql +" '"&  ChkEndDate3 & "',"
             Sql=Sql +" '"&  Copy4 & "',"
             Sql=Sql +" '"&  Server4 & "',"
             Sql=Sql +" '"&  Link4 & "',"
             Sql=Sql +" '"&  HardCopy5 & "',"
             Sql=Sql +" '"&  Email5 & "',"
             Sql=Sql +" '"&  HardCopy6 & "',"
             Sql=Sql +" '"&  Server6 & "',"
             Sql=Sql +" '"&  LinkPdf7 & "',"
             Sql=Sql +" '"&  QEoff8 & "',"
             Sql=Sql +" '"&  QEoffName8 & "',"
             Sql=Sql +" '"&  QEoffDate8 & "',"
             Sql=Sql +" '"&  QE8 & "',"
             Sql=Sql +" '"&  QEName8 & "',"
             Sql=Sql +" '"&  QEDate8 & "',"
             Sql=Sql +" '"&  UserRunDar & "',"
            Sql = Sql + " '" & DateRunDar & "',"
            Sql = Sql + " '" & LinkFilePDF & "',"
            Sql = Sql + " '" & QEoff1Date & "',"
            Sql = Sql + " '" & AttDoc1Date & "',"
            Sql = Sql + " '" & SendDocSrv1Date & "'"

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
             Sql="Update QEa_DocSys_Dar Set "
             Sql=Sql+" Branch ='"& Branch &"',"
             Sql=Sql+" STATUS ='"& STATUS &"',"
             Sql=Sql+" Flag ='"& Flag &"',"
            'Sql=Sql+" Month ="& Month &","
            Sql =Sql+" REFNO ='"& REFNO &"',"
             Sql=Sql+" REFNODATA ='"& REFNODATA &"',"
             Sql=Sql+" DARNO ='"& DARNO &"',"
             Sql=Sql+" QEoff1 ='"& QEoff1 &"',"
             Sql=Sql+" AttDoc1 ='"& AttDoc1 &"',"
             Sql=Sql+" SendDocSrv1 ='"& SendDocSrv1 &"',"
             Sql=Sql+" SendDocDate1 ='"& SendDocDate1 &"',"
             Sql=Sql+" RecDocDate1 ='"& RecDocDate1 &"',"
             Sql=Sql+" RetReaSon1 ='"& RetReaSon1 &"',"
             Sql=Sql+" PrintCheck2 ='"& PrintCheck2 &"',"
             Sql=Sql+" PrintDate2 ='"& PrintDate2 &"',"
             Sql=Sql+" ChkStartApprove3 ='"& ChkStartApprove3 &"',"
             Sql=Sql+" ChkStartDate3 ='"& ChkStartDate3 &"',"
             Sql=Sql+" ChkEndApprove3 ='"& ChkEndApprove3 &"',"
             Sql=Sql+" ChkEndDate3 ='"& ChkEndDate3 &"',"
             Sql=Sql+" Copy4 ='"& Copy4 &"',"
             Sql=Sql+" Server4 ='"& Server4 &"',"
             Sql=Sql+" Link4 ='"& Link4 &"',"
             Sql=Sql+" HardCopy5 ='"& HardCopy5 &"',"
             Sql=Sql+" Email5 ='"& Email5 &"',"
             Sql=Sql+" HardCopy6 ='"& HardCopy6 &"',"
             Sql=Sql+" Server6 ='"& Server6 &"',"
             Sql=Sql+" LinkPdf7 ='"& LinkPdf7 &"',"
             Sql=Sql+" QEoff8 ='"& QEoff8 &"',"
             Sql=Sql+" QEoffName8 ='"& QEoffName8 &"',"
             Sql=Sql+" QEoffDate8 ='"& QEoffDate8 &"',"
             Sql=Sql+" QE8 ='"& QE8 &"',"
             Sql=Sql+" QEName8 ='"& QEName8 &"',"
            Sql = Sql + " QEDate8 ='" & QEDate8 & "',"
            Sql = Sql + " LinkFilePDF ='" & LinkFilePDF & "',"
            Sql = Sql + " QEoff1Date ='" & QEoff1Date & "',"
            Sql = Sql + " AttDoc1Date ='" & AttDoc1Date & "',"
            Sql = Sql + " SendDocSrv1Date ='" & SendDocSrv1Date & "'"
            ' Sql =Sql+" DateRunDar ='"& DateRunDar &"'"
            Sql = Sql + "Where REFNO= '" & REFNO & "' AND REFNODATA = '" & REFNODATA & "' AND DARNO ='" & DARNO & "'"
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
         Branch=Dr.Item("Branch") 
         STATUS=Dr.Item("STATUS") 
         Flag=Dr.Item("Flag") 
         Month=Dr.Item("Month") 
         REFNO=Dr.Item("REFNO") 
         REFNODATA=Dr.Item("REFNODATA") 
         DARNO=Dr.Item("DARNO") 
         QEoff1=Dr.Item("QEoff1") 
         AttDoc1=Dr.Item("AttDoc1") 
         SendDocSrv1=Dr.Item("SendDocSrv1") 
         SendDocDate1=Dr.Item("SendDocDate1") 
         RecDocDate1=Dr.Item("RecDocDate1") 
         RetReaSon1=Dr.Item("RetReaSon1") 
         PrintCheck2=Dr.Item("PrintCheck2") 
         PrintDate2=Dr.Item("PrintDate2") 
         ChkStartApprove3=Dr.Item("ChkStartApprove3") 
         ChkStartDate3=Dr.Item("ChkStartDate3") 
         ChkEndApprove3=Dr.Item("ChkEndApprove3") 
         ChkEndDate3=Dr.Item("ChkEndDate3") 
         Copy4=Dr.Item("Copy4") 
         Server4=Dr.Item("Server4") 
         Link4=Dr.Item("Link4") 
         HardCopy5=Dr.Item("HardCopy5") 
         Email5=Dr.Item("Email5") 
         HardCopy6=Dr.Item("HardCopy6") 
         Server6=Dr.Item("Server6") 
         LinkPdf7=Dr.Item("LinkPdf7") 
         QEoff8=Dr.Item("QEoff8") 
         QEoffName8=Dr.Item("QEoffName8") 
         QEoffDate8=Dr.Item("QEoffDate8") 
         QE8=Dr.Item("QE8") 
         QEName8=Dr.Item("QEName8") 
         QEDate8=Dr.Item("QEDate8") 
         UserRunDar=Dr.Item("UserRunDar")
            DateRunDar = Dr.Item("DateRunDar")
            LinkFilePDF = Dr.Item("LinkFilePDF")
            QEoff1Date = Dr.Item("QEoff1Date")
            AttDoc1Date = Dr.Item("AttDoc1Date")
            SendDocSrv1Date = Dr.Item("SendDocSrv1Date")


        End While
    Dr.Close 
    Dr=Nothing 

End Function 
'****************************************************************
Public Function CleareData() as Boolean 
        Branch=Nothing
        STATUS=Nothing
        Flag=Nothing
        Month=Nothing
        REFNO=Nothing
        REFNODATA=Nothing
        DARNO=Nothing
        QEoff1=Nothing
        AttDoc1=Nothing
        SendDocSrv1=Nothing
        SendDocDate1=Nothing
        RecDocDate1=Nothing
        RetReaSon1=Nothing
        PrintCheck2=Nothing
        PrintDate2=Nothing
        ChkStartApprove3=Nothing
        ChkStartDate3=Nothing
        ChkEndApprove3=Nothing
        ChkEndDate3=Nothing
        Copy4=Nothing
        Server4=Nothing
        Link4=Nothing
        HardCopy5=Nothing
        Email5=Nothing
        HardCopy6=Nothing
        Server6=Nothing
        LinkPdf7=Nothing
        QEoff8=Nothing
        QEoffName8=Nothing
        QEoffDate8=Nothing
        QE8=Nothing
        QEName8=Nothing
        QEDate8=Nothing
        UserRunDar=Nothing
        DateRunDar = Nothing
        LinkFilePDF = Nothing
        QEoff1Date = Nothing
        AttDoc1Date = Nothing
        SendDocSrv1Date = Nothing


    End Function

    '****************************************************************
    'Public Function AppendData() as boolean 
    '      Try
    '       With  C_QEa_DocSys_Dar
    '               .Branch=TxtBranch.Text
    '               .STATUS=TxtSTATUS.Text
    '               .Flag=TxtFlag.Text
    '               .Month=TxtMonth.Text
    '               .REFNO=TxtREFNO.Text
    '               .REFNODATA=TxtREFNODATA.Text
    '               .DARNO=TxtDARNO.Text
    '               .QEoff1=TxtQEoff1.Text
    '               .AttDoc1=TxtAttDoc1.Text
    '               .SendDocSrv1=TxtSendDocSrv1.Text
    '               .SendDocDate1=TxtSendDocDate1.Text
    '               .RecDocDate1=TxtRecDocDate1.Text
    '               .RetReaSon1=TxtRetReaSon1.Text
    '               .PrintCheck2=TxtPrintCheck2.Text
    '               .PrintDate2=TxtPrintDate2.Text
    '               .ChkStartApprove3=TxtChkStartApprove3.Text
    '               .ChkStartDate3=TxtChkStartDate3.Text
    '               .ChkEndApprove3=TxtChkEndApprove3.Text
    '               .ChkEndDate3=TxtChkEndDate3.Text
    '               .Copy4=TxtCopy4.Text
    '               .Server4=TxtServer4.Text
    '               .Link4=TxtLink4.Text
    '               .HardCopy5=TxtHardCopy5.Text
    '               .Email5=TxtEmail5.Text
    '               .HardCopy6=TxtHardCopy6.Text
    '               .Server6=TxtServer6.Text
    '               .LinkPdf7=TxtLinkPdf7.Text
    '               .QEoff8=TxtQEoff8.Text
    '               .QEoffName8=TxtQEoffName8.Text
    '               .QEoffDate8=TxtQEoffDate8.Text
    '               .QE8=TxtQE8.Text
    '               .QEName8=TxtQEName8.Text
    '               .QEDate8=TxtQEDate8.Text
    '               .UserRunDar=TxtUserRunDar.Text
    '               .DateRunDar=TxtDateRunDar.Text

    '       End with 
    '      Catch ex As Exception 
    'End Try 
    'End Function 

End Class