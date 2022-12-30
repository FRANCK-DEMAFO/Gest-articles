Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Inscription

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("veuillez remplir tout les champs")
        Else
            Dim nom As String
            nom = TextBox1.Text
            Dim prenom As String
            prenom = TextBox2.Text
            Dim pwd As String
            pwd = TextBox3.Text

            'creation de la connection'
            Dim con As New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;database=ventes_vb;password="
            Try
                con.Open()
                If (con.State = ConnectionState.Open) Then

                    'creation de l'objet commande pour l'utilisateur'

                    Dim cmdUser As MySqlCommand = New MySqlCommand()
                    cmdUser.Connection = con
                    cmdUser.CommandText = "INSERT INTO employe(NOM, PRENOM, DATENAISSANCE) " + "VALUES (@nom, @prenom, @date)"
                    cmdUser.Parameters.AddWithValue("@nom", nom)
                    cmdUser.Parameters.AddWithValue("@prenom", prenom)
                    cmdUser.Parameters.AddWithValue("@date", pwd)
                    Dim resultat As MySqlDataReader
                    resultat = cmdUser.ExecuteReader
                    If (resultat.HasRows) Then

                        MsgBox("cet utilisateur existe deja")

                    Else

                        MsgBox("Incription reussit")
                        Connexion.Show()
                        Me.Hide()
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox3.Text = ""

                    End If
                End If
            Catch ex As Exception
                MsgBox("Echec de la connection" & ex.Message)
            End Try

        End If



    End Sub

    Private Sub Inscription_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub Inscription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
