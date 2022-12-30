Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class listes_des_ventes

    Private Sub listes_des_ventes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Acceuil.Show()
        Me.Hide()
    End Sub

    Private Sub listes_des_ventes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Numero vente", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Numero client", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Quantite", 40, HorizontalAlignment.Center)
        ListView1.Columns.Add("Total", 40, HorizontalAlignment.Center)
        ListView1.Columns.Add("Date de vente", 40, HorizontalAlignment.Right)

        'creation de la connection'
        Dim con As New MySqlConnection
        con.ConnectionString = "server=localhost;userid=root;database=ventes_vb;password="
        Try
            con.Open()
            If (con.State = ConnectionState.Open) Then

                'creation de l'objet commande pour l'utilisateur'

                Dim selectSql As New MySqlCommand("select * from ventes", con)

                Dim listeArticles As MySqlDataReader
                listeArticles = selectSql.ExecuteReader

                'recuperation des donnees a partir de la requete'
                'creer la classe connection corriger l'erreur'
                While listeArticles.Read()

                    Dim unItem As New ListViewItem

                    'provide '
                    unItem.SubItems.Add(listeArticles("NUMEROVENTE"))
                    unItem.SubItems.Add(listeArticles("NUMEROIDENT"))
                    unItem.SubItems.Add(listeArticles("QTE"))
                    unItem.SubItems.Add(listeArticles("TOTAL"))
                    unItem.SubItems.Add(listeArticles("DATEVENTE"))


                    'affecter l'item'

                    ListView1.Items.Add(unItem)

                End While


            End If
        Catch ex As Exception

            MsgBox("Echec de la connection" & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Acceuil.Show()
        Me.Hide()

    End Sub
End Class