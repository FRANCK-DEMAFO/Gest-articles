Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Article

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Acceuil.Show()
        Me.Hide()

    End Sub

    Private Sub Article_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Acceuil.Show()
        Me.Hide()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("Veillez remplir tout les champs")
        Else
            Dim libelle As String
            libelle = TextBox1.Text
            Dim quantite As Integer
            quantite = Integer.Parse(TextBox2.Text)
            Dim prix As Integer
            prix = TextBox3.Text
            Dim con As New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;database=ventes_vb;password="
            Try
                con.Open()
                If (con.State = ConnectionState.Open) Then

                    'creation de l'objet commande pour l'utilisateur' PRIX_UNITAIRE

                    Dim cmdUser As MySqlCommand = New MySqlCommand()
                    cmdUser.Connection = con
                    cmdUser.CommandText = "INSERT INTO article(LIBELLE, QUANTITESTOCK, PRIXDEVENTE) " + "VALUES (@libelle, @quantite, @prix)"
                    cmdUser.Parameters.AddWithValue("@libelle", libelle)
                    cmdUser.Parameters.AddWithValue("@quantite", quantite)
                    cmdUser.Parameters.AddWithValue("@prix", prix)
                    Dim resultat As MySqlDataReader
                    resultat = cmdUser.ExecuteReader
                    If (resultat.HasRows) Then

                        MsgBox("cet article existe deja")

                    Else
                        MsgBox("enregistrement reussit")
                        Acceuil.Show()
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
End Class