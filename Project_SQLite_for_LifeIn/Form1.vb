
Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmPrincipale
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtID.Text = "" Or txtTitle.Text = "" Or txtISBN.Text = "" Or txtPublication.Text = "" Or txtGenre.Text = "" Or txtAuthor.Text = "" Then
            MessageBox.Show("Fill the Data", "Info")
        Else
            Dim Cn As New SQLiteConnection()
            Cn.ConnectionString = "Data Source=C:\App Visual Basic\Project_SQLite_for_LifeIn\Project_SQLite_for_LifeIn\Dati\Database.db;Version=3;"
            Dim s As String = "insert into Books (bookID,Title,ISBN,Genre, Publication, Author) Values (@bookID,@Title,@ISBN,@Genre, @Publication, @Author)"


            Cn.Open()
            Dim cmd As New SQLiteCommand(s, Cn)
            cmd.Parameters.AddWithValue("@bookID", txtID.Text)
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text)
            cmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
            cmd.Parameters.AddWithValue("@Publication", txtPublication.Text)
            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully Saved ", "Info")
            Cn.Close()
            txtID.Text = ""
            txtTitle.Text = ""
            txtISBN.Text = ""
            txtGenre.Text = ""
            txtPublication.Text = ""
            txtAuthor.Text = ""

        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim con As New SQLiteConnection()
        con.ConnectionString = "Data Source=C:\App Visual Basic\Project_SQLite_for_LifeIn\Project_SQLite_for_LifeIn\Dati\Database.db;Version=3;"
        Dim s As String = "select * from Books"
        con.Open()
        Dim cmd As New SQLiteCommand(s, con)
        Dim adapter As New SQLiteDataAdapter(s, con)
        Dim table As New DataTable()
        table.Clear()
        adapter.Fill(table)
        DG1.DataSource = table
        con.Close()


    End Sub


End Class
