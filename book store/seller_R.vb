Imports System.Data.SqlClient

Public Class seller_R

    Dim cn As New SqlConnection("Data Source=DESKTOP-TD2OJPK;Initial Catalog=Book Store;User ID=sa;Password=sumit123")
    Dim cmd As SqlCommand

    Private Sub update_combo_name()

        cmd = New SqlCommand("select distinct s_name from seller", cn)
        Dim da1 As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        Dim col1 As New AutoCompleteStringCollection
        da1.Fill(ds1)
        For i = 0 To ds1.Tables(0).Rows.Count - 1
            col1.Add(ds1.Tables(0).Rows(i)("s_name").ToString)
        Next
        txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtName.AutoCompleteCustomSource = col1
        txtName.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        cmd = New SqlCommand("select distinct s_contact from seller", cn)
        Dim da3 As New SqlDataAdapter(cmd)
        Dim ds3 As New DataSet
        Dim col3 As New AutoCompleteStringCollection
        da3.Fill(ds3)
        For i = 0 To ds3.Tables(0).Rows.Count - 1
            col3.Add(ds3.Tables(0).Rows(i)("s_contact").ToString)
        Next
        txtContact.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtContact.AutoCompleteCustomSource = col3
        txtContact.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub seller_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Book_StoreDataSet3.seller' table. You can move, or remove it, as needed.
        Me.SellerTableAdapter.Fill(Me.Book_StoreDataSet3.seller)
        update_combo_name()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        cmd = New SqlCommand("select * from Seller where s_name = '" + txtName.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        SellerDataGridView.DataSource = ds.Tables(0)
        If txtName.Text = "" Then
            cmd = New SqlCommand("select * from Seller", cn)
            Dim da1 As New SqlDataAdapter(cmd)
            Dim ds1 As New DataSet
            da1.Fill(ds1)
            SellerDataGridView.DataSource = ds1.Tables(0)
        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        cmd = New SqlCommand("select * from Seller where s_contact = '" + txtContact.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        SellerDataGridView.DataSource = ds.Tables(0)
        If txtContact.Text = "" Then
            cmd = New SqlCommand("select * from Seller", cn)
            Dim da1 As New SqlDataAdapter(cmd)
            Dim ds1 As New DataSet
            da1.Fill(ds1)
            SellerDataGridView.DataSource = ds1.Tables(0)
        End If
    End Sub

End Class