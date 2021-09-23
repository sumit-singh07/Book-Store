Imports System.Data.SqlClient

Public Class SalesView

    Dim cn As New SqlConnection("Data Source=DESKTOP-TD2OJPK;Initial Catalog=Book Store;User ID=sa;Password=sumit123")
    Dim cmd As SqlCommand


    Private Sub update_combo_name()
        cmd = New SqlCommand("select distinct cust_name from sales", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim col As New AutoCompleteStringCollection
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("cust_name").ToString)
        Next
        txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtName.AutoCompleteCustomSource = col
        txtName.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        cmd = New SqlCommand("select distinct book_title from sales", cn)
        Dim da1 As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        Dim col1 As New AutoCompleteStringCollection
        da1.Fill(ds1)
        For i = 0 To ds1.Tables(0).Rows.Count - 1
            col1.Add(ds1.Tables(0).Rows(i)("book_title").ToString)
        Next
        txtTitle.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtTitle.AutoCompleteCustomSource = col1
        txtTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        cmd = New SqlCommand("select distinct author from sales", cn)
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


        cmd = New SqlCommand("select distinct publisher from sales", cn)
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

    Private Sub SalesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Book_StoreDataSet.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.Book_StoreDataSet.sales)
        update_combo_name()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        cmd = New SqlCommand("select * from sales where sales_date = '" + DateTimePicker1.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        SalesDataGridView.DataSource = ds.Tables(0)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        cmd = New SqlCommand("select * from sales where cust_name = '" + txtName.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        SalesDataGridView.DataSource = ds.Tables(0)
        If txtName.Text = "" Then
            cmd = New SqlCommand("select * from sales", cn)
            Dim da1 As New SqlDataAdapter(cmd)
            Dim ds1 As New DataSet
            da1.Fill(ds1)
            SalesDataGridView.DataSource = ds1.Tables(0)
        End If
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        cmd = New SqlCommand("select * from sales where book_title = '" + txtTitle.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        SalesDataGridView.DataSource = ds.Tables(0)
        If txtTitle.Text = "" Then
            cmd = New SqlCommand("select * from sales", cn)
            Dim da1 As New SqlDataAdapter(cmd)
            Dim ds1 As New DataSet
            da1.Fill(ds1)
            SalesDataGridView.DataSource = ds1.Tables(0)
        End If
    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        cmd = New SqlCommand("select * from sales where author = '" + txtAuthor.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        SalesDataGridView.DataSource = ds.Tables(0)
        If txtAuthor.Text = "" Then
            cmd = New SqlCommand("select * from sales", cn)
            Dim da1 As New SqlDataAdapter(cmd)
            Dim ds1 As New DataSet
            da1.Fill(ds1)
            SalesDataGridView.DataSource = ds1.Tables(0)
        End If
    End Sub

    Private Sub txtPublisher_TextChanged(sender As Object, e As EventArgs) Handles txtPublisher.TextChanged
        cmd = New SqlCommand("select * from sales where publisher = '" + txtPublisher.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        SalesDataGridView.DataSource = ds.Tables(0)
        If txtPublisher.Text = "" Then
            cmd = New SqlCommand("select * from sales", cn)
            Dim da1 As New SqlDataAdapter(cmd)
            Dim ds1 As New DataSet
            da1.Fill(ds1)
            SalesDataGridView.DataSource = ds1.Tables(0)
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        cmd = New SqlCommand("select * from sales where sales_date between '" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        SalesDataGridView.DataSource = ds.Tables(0)
    End Sub
End Class