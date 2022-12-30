
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Connection
    Private server As String = "localhost"
    Private userid As String = "root"
    Private database As String = "ventes"
    Private pwd As String = ""

    'constructeur'
    Public Sub New(ByVal serv As String, ByVal Uid As String, ByVal data As String, ByVal pswd As String)
        Me.server = serv
        Me.userid = Uid
        Me.database = data
        Me.pwd = pswd
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    'getters'
    Public Function getServer() As String
        Return server
    End Function
    Public Function getUserid() As String
        Return userid
    End Function
    Public Function getDatabase() As String
        Return database
    End Function
    Public Function getpwd() As String
        Return pwd
    End Function

    'setters'
    Public Sub setServer(ByVal s As String)
        Me.server = s
    End Sub
    Public Sub setUserid(ByVal id As String)
        Me.userid = id
    End Sub
    Public Sub setDatabase(ByVal db As String)
        Me.database = db
    End Sub
    Public Sub setPwd(ByVal pw As String)
        Me.pwd = pw
    End Sub

    Public Function connexion() As MySqlConnection

        Dim con As New MySqlConnection
        con.ConnectionString = "server=localhost;userid=root;database=BD_utilisateurs;password="

        Try
            con.Open()
            If (con.State = ConnectionState.Open) Then
                MsgBox(" connexion reussit")
            Else
                MsgBox("")
            End If
        Catch ex As Exception

            MsgBox("Echec de la connection" & ex.Message)

        End Try


    End Function

    Public Function getConnection()
        Return Me.connexion()
    End Function



End Class

