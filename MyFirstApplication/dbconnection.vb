Imports MySql.Data.MySqlClient
Imports System.IO
Module dbconnection
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public i As Integer
    Public results As Boolean

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "Data Source=DESKTOP-LH64PJC\SQLEXPRESS;Initial Catalog=ExamBooking;Integrated Security=True;Trust Server Certificate=True"
                results = True
            End If
        Catch ex As Exception
            results = False
            MsgBox("server not connected !", vbExclamation)

        End Try
        Return results
    End Function

End Module
