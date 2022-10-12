Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.OleDb
Imports System.Data.Odbc
Public Class ClassConnect
    Public Shared da As SqlDataAdapter
    Public Shared daWMS As SqlDataAdapter
    Public Shared daDB As OleDb.OleDbDataAdapter
    Public Shared dt As New DataTable
    Public Shared dtWMS As New DataTable
    Public mytrans As SqlTransaction

    Public Shared ConnectionEmail As String = "Server=10.1.1.4;uid=sa;pwd=Sa1234;Database=RESERVE"

    Public Shared ConnectionKB As String = "Server=10.2.1.101\SQLEXPRESSKB;uid=sa;pwd=Sql2000;Database=DocumentSystem"
    Public Shared ConnectionTP As String = "Server=10.1.1.4;uid=sa;pwd=Sa1234;Database=DocumentSystem"

    '  Public Shared ConnectionSrtSA As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DATABASE_SA_EXPORT\KB\SUNIF.mdb"
    Public Shared ConnectionSrtSA As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DATABASE_SA_EXPORT\TP\Sunif.mdb"

    Public Shared ConnectionKBSA As String = "Server=10.2.1.101\SQLEXPRESSKB;uid=sa;pwd=Sql2000;Database=SABASE"
    '    Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;

    'Public Shared ConnectionSrt As String = "Server=Atomi;uid=sa;pwd=Sa1234;Database=EMS"
    Public Shared MyODBCConnection As New OleDbConnection
    'Public conStr As String = "Server=Atomi;uid=sa;pwd=Sa1234;Database=EMS"

    Public command As SqlCommand
    Public Shared ID As String
    Public Shared StrASST As String
    'DESKTOP-7SL8MEC
    'Public conStr As String = "Server=10.1.1.3;uid=sa;pwd=Sql2000;Database=WMS"
    '\---------------------------------------------------------------------------------/

    'นำคำสั่ง sql มา Query แล้วได้ DataSet กลับไป

    Public Shared Function getDataSetSA(ByVal strQuery As String, ByVal mytransDB As OleDbTransaction, Optional ByVal strTableName As String = "") As DataTable
        Try
            connDb.ConnectionString = ClassConnect.ConnectionSrtSA
            If connDb.State = ConnectionState.Closed Then
                connDb.Open()
            End If
            Dim Ds As New DataSet
            daDB = New OleDbDataAdapter(strQuery, connDb)
            If strTableName <> "" Then
                daDB.Fill(Ds, strTableName)
            Else
                daDB.Fill(Ds)
            End If

            Return Ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connDb.Close()
        End Try
        Return dt

    End Function


    Public Shared Function sExecuteSA(ByVal strQuerySA As String, ByVal myTransDB As OleDbTransaction, Optional ByVal ErrInfo As String = "") As Boolean
        Try
            connDb.ConnectionString = ClassConnect.ConnectionSrtSA
            If connDb.State = ConnectionState.Closed Then
                connDb.Open()
                With SqlCommandDB
                    .CommandText = strQuerySA
                    .Connection = connDb
                    .ExecuteNonQuery()
                End With
            End If
            Return True
        Catch ex As Exception
            Return False
        Finally
            connDb.Close()
        End Try

    End Function

    Public Shared Function getDataSetEmail(ByVal strQuery As String, ByVal myTrans As SqlTransaction, Optional ByVal strTableName As String = "") As DataTable
        Try
            ' conn.ConnectionString = ClassConnect.ConnectionSrt
            If connEmail.State = ConnectionState.Closed Then
                connEmail.ConnectionString = ClassConnect.ConnectionEmail
                connEmail.Open()
            End If
            Dim Ds As New DataSet
            da = New SqlDataAdapter(strQuery, connEmail)
            If strTableName <> "" Then
                da.Fill(Ds, strTableName)
            Else
                da.Fill(Ds)
            End If
            Return Ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connEmail.Close()
        End Try
        Return dt
    End Function

    Public Shared Function getDataSetKB(ByVal strQuery As String, ByVal myTrans As SqlTransaction, Optional ByVal strTableName As String = "") As DataTable
        Try
            ' conn.ConnectionString = ClassConnect.ConnectionSrt
            If connKB.State = ConnectionState.Closed Then
                connKB.ConnectionString = ClassConnect.ConnectionKB
                connKB.Open()
            End If
            Dim Ds As New DataSet
            da = New SqlDataAdapter(strQuery, connKB)
            If strTableName <> "" Then
                da.Fill(Ds, strTableName)
            Else
                da.Fill(Ds)
            End If
            Return Ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connKB.Close()
        End Try
        Return dt
    End Function

    Public Shared Function getDataSetKBSA(ByVal strQuery As String, ByVal myTrans As SqlTransaction, Optional ByVal strTableName As String = "") As DataTable
        Try
            ' conn.ConnectionString = ClassConnect.ConnectionSrt
            If connKBSA.State = ConnectionState.Closed Then
                connKBSA.ConnectionString = ClassConnect.ConnectionKBSA
                connKBSA.Open()
            End If
            Dim Ds As New DataSet
            da = New SqlDataAdapter(strQuery, connKBSA)
            If strTableName <> "" Then
                da.Fill(Ds, strTableName)
            Else
                da.Fill(Ds)
            End If
            Return Ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connKBSA.Close()
        End Try
        Return dt
    End Function

    Public Shared Function getDataSetTP(ByVal strQuery As String, ByVal myTrans As SqlTransaction, Optional ByVal strTableName As String = "") As DataTable
        Try
            ' conn.ConnectionString = ClassConnect.ConnectionSrt
            If connTP.State = ConnectionState.Closed Then
                connTP.ConnectionString = ClassConnect.ConnectionTP
                connTP.Open()
            End If
            Dim Ds As New DataSet
            da = New SqlDataAdapter(strQuery, connTP)
            If strTableName <> "" Then
                da.Fill(Ds, strTableName)
            Else
                da.Fill(Ds)
            End If
            Return Ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connTP.Close()
        End Try
        Return dt
    End Function


    Public Shared Function sExecuteKB(ByVal strQuery As String, ByVal myTrans As SqlTransaction, Optional ByVal ErrInfo As String = "") As Boolean
        Try
            ' conn.ConnectionString = ClassConnect.ConnectionSrt
            If connKB.State = ConnectionState.Closed Then
                connKB.ConnectionString = ClassConnect.ConnectionKB
                connKB.Open()
                With SqlCommand
                    .CommandText = strQuery
                    .Connection = connKB
                    .ExecuteNonQuery()
                End With
            End If
            Return True
        Catch ex As Exception
            Return False
        Finally
            connKB.Close()
        End Try
    End Function

    Public Shared Function sExecuteTP(ByVal strQuery As String, ByVal myTrans As SqlTransaction, Optional ByVal ErrInfo As String = "") As Boolean
        Try
            ' conn.ConnectionString = ClassConnect.ConnectionSrt
            If connTP.State = ConnectionState.Closed Then
                connTP.ConnectionString = ClassConnect.ConnectionTP
                connTP.Open()
                With SqlCommand
                    .CommandText = strQuery
                    .Connection = connTP
                    .ExecuteNonQuery()
                End With
            End If
            Return True
        Catch ex As Exception
            Return False
        Finally
            connTP.Close()
        End Try
    End Function
End Class
