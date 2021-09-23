Imports System.Data.SqlClient

Public Class Books

    Dim cn As New SqlConnection("Data Source=DESKTOP-TD2OJPK;Initial Catalog=Book Store;User ID=sa;Password=sumit123")
    Dim cmd As SqlCommand

    Private Sub update_combo_name()

        cmd = New SqlCommand("select distinct b_title from books", cn)
        Dim da1 As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        Dim col1 As New AutoCompleteStringCollection
        da1.Fill(ds1)
        For i = 0 To ds1.Tables(0).Rows.Count - 1
            col1.Add(ds1.Tables(0).Rows(i)("b_title").ToString)
        Next
        txtTitle.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtTitle.AutoCompleteCustomSource = col1
        txtTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        cmd = New SqlCommand("select distinct author from books", cn)
        Dim da2 As New SqlDataAdapter(cmd)
        Dim ds2 As New DataSet
        Dim col2 As New AutoCompleteStringCollection
        da2.Fill(ds2)
        For i = 0 To ds2.Tables(0).Rows.Count - 1
            col2.Add(ds2.Tables(0).Rows(i)("author").ToString)
        Next
        txtAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtAuthor.AutoCompleteCustomSource = col2
        txtAuthor.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        cmd = New SqlCommand("select distinct publisher from books", cn)
        Dim da3 As New SqlDataAdapter(cmd)
        Dim ds3 As New DataSet
        Dim col3 As New AutoCompleteStringCollection
        da3.Fill(ds3)
        For i = 0 To ds3.Tables(0).Rows.Count - 1
            col3.Add(ds3.Tables(0).Rows(i)("publisher").ToString)
        Next
        txtPublisher.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtPublisher.AutoCompleteCustomSource = col3
        txtPublisher.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub Reset()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtPublisher.Clear()
        txtPrice.Clear()

        txtTitle.Focus()
        Me.BooksTableAdapter.Fill(Me.Book_StoreDataSet2.books)

        Button2.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Open()
        cmd = New SqlCommand("insert into books (b_title,author,publisher,price) values ('" + txtTitle.Text + "','" + txtAuthor.Text + "','" + txtPublisher.Text + "'," + txtPrice.Text + ")", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Insert Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            update_combo_name()
            Reset()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Reset()
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_combo_name()
        Reset()
    End Sub

    Private Sub booksDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BooksDataGridView.CellClick
        txtTitle.Text = BooksDataGridView.CurrentRow.Cells(1).Value.ToString
        txtAuthor.Text = BooksDataGridView.CurrentRow.Cells(2).Value.ToString
        txtPublisher.Text = BooksDataGridView.CurrentRow.Cells(3).Value.ToString
        txtPrice.Text = BooksDataGridView.CurrentRow.Cells(4).Value.ToString

        Button2.Enabled = True
        Button3.Enabled = True

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn.Open()
        cmd = New SqlCommand("update books set b_title = '" + txtTitle.Text + "', author = '" + txtAuthor.Text + "', publisher = '" + txtPublisher.Text + "', price = " + txtPrice.Text + " where b_id = " + BooksDataGridView.CurrentRow.Cells(0).Value.ToString + " ", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Update Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            update_combo_name()
            Reset()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cn.Open()
        cmd = New SqlCommand("delete from books where b_id = " + BooksDataGridView.CurrentRow.Cells(0).Value.ToString + " ", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Delete Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            update_combo_name()
            Reset()
        End If
    End Sub
End Class