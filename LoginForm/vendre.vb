Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class vendre

    Private Sub vendre_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Acceuil.Show()
        Me.Hide()
    End Sub

    Private Sub vendre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Ventes_vbDataSet2.article'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticleTableAdapter2.Fill(Me.Ventes_vbDataSet2.article)
        'TODO: cette ligne de code charge les données dans la table 'Ventes_vbDataSet1.article'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticleTableAdapter1.Fill(Me.Ventes_vbDataSet1.article)
        'TODO: cette ligne de code charge les données dans la table 'Ventes_vbDataSet.article'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticleTableAdapter.Fill(Me.Ventes_vbDataSet.article)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim libelle As String = ComboBox1.Text
        Dim quantite As String = TextBox1.Text
        If (libelle <> "") And (quantite <> "") Then
            'creation de la connection'
            Dim con As New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;database=gestion_ventes;password="
            Try
                con.Open()
                If (con.State = ConnectionState.Open) Then

                    'creation de l'objet commande pour l'utilisateur'


                    Dim selectSql As New MySqlCommand("select * from article where LIBELLE=@libelle", con)

                    selectSql.Parameters.AddWithValue("@libelle", libelle)

                    Dim listeArticles As MySqlDataReader
                    listeArticles = selectSql.ExecuteReader

                    'recuperation des donnees a partir de la requete'

                End If
            Catch ex As Exception

                MsgBox("Echec de la connection" & ex.Message)
            End Try
        Else
            MsgBox("remplir tout les champs")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
        Me.Hide()

    End Sub

End Class