
Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmPrincipale
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtTitle.Text = "" Or txtISBN.Text = "" Or txtPublication.Text = "" Or txtGenre.Text = "" Or txtAuthor.Text = "" Then
            MessageBox.Show("Fill the Data", "Info")
        Else

            Dim conn As New SQLiteConnection()
            conn.ConnectionString = "Data Source=C:\App Visual Basic\Project_SQLite_for_LifeIn\Project_SQLite_for_LifeIn\Dati\Database.db;Version=3;"
            Dim s As String = "insert into Books (Title,ISBN,Genre, Publication, Author) Values (@Title,@ISBN,@Genre, @Publication, @Author)"

            Try
                conn.Open()
                Dim cmd As New SQLiteCommand(s, conn)

                cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text)
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
                cmd.Parameters.AddWithValue("@Publication", txtPublication.Text)
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Saved ", "Info")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                txtTitle.Text = ""
                txtISBN.Text = ""
                txtGenre.Text = ""
                txtPublication.Text = ""
                txtAuthor.Text = ""
            End Try
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim conn As New SQLiteConnection()
        conn.ConnectionString = "Data Source=C:\App Visual Basic\Project_SQLite_for_LifeIn\Project_SQLite_for_LifeIn\Dati\Database.db;Version=3;"
        Dim s As String = "select * from Books"
        Try
            conn.Open()
            Dim cmd As New SQLiteCommand(s, conn)
            Dim adapter As New SQLiteDataAdapter(s, conn)
            Dim table As New DataTable()
            table.Clear()
            adapter.Fill(table)
            DG1.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try


    End Sub


End Class
