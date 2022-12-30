Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Connexion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        Dim login As String
        login = TextBox1.Text
        Dim pwd As String
        pwd = TextBox2.Text
        If (login = "" Or pwd = "") Then
            MessageBox.Show("Veillez remplir tout les champs")
        Else
            'creation de la connection'
            Dim con As New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;database=ventes_vb;password="
            Try
                con.Open()
                If (con.State = ConnectionState.Open) Then

                    'creation de l'objet commande pour l'utilisateur'

                    Dim cmdUser As MySqlCommand = New MySqlCommand()
                    cmdUser.Connection = con
                    cmdUser.CommandText = "select * from compteutilisateur where LOGIN = @login and PASSWORD = @motDePasse"
                    cmdUser.Parameters.AddWithValue("@login", login)
                    cmdUser.Parameters.AddWithValue("@motDePasse", pwd)

                    'recuperation des donnees a partir de la requete'
                    Dim resultat As MySqlDataReader
                    resultat = cmdUser.ExecuteReader()
                    If (resultat.HasRows) Then
                        mail = login
                        MsgBox("utilisateur connecter")
                        Acceuil.Show()
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        Me.Hide()
                    Else
                        MsgBox("Utilisateur inconnu")

                    End If

                End If
            Catch ex As Exception
                MsgBox("Echec de la connection" & ex.Message)
            End Try

        End If
    End Sub

    Private Sub Connexion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
        Me.Hide()
    End Sub


    Private Sub Connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Connexion_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class