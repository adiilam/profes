Imports System
Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Globalization

Public Module module1
    Public frm As New Windows.Forms.Form
    Public SQLComm As New SqlCommand
    Public Baca As SqlClient.SqlDataReader
    Public sDesc As String, sStat As String, sTitle As String, iAsk As Integer
    Public fordel1 As String, fordel2 As String, fordel3 As String
    Public dfordel As Date

    'sql server local Adi Ilham
    Public SQLConn As New SqlConnection("Server='local';Database='Profes'; " &
                                                     " User ID='sa';Password='Belden99'")

    Public Sub UsingSql(ByVal S As String)
        SQLComm = New SqlCommand(S, SQLConn)
        SQLComm.CommandType = CommandType.Text
        SQLComm.ExecuteNonQuery()
    End Sub


End Module
