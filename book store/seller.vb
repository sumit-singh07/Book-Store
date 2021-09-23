Imports System.Data.SqlClient

Public Class seller
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

    Private Sub Reset()
        txtName.Clear()
        txtAddress.Clear()
        txtContact.Clear()

        txtName.Focus()
        Me.SellerTableAdapter.Fill(Me.Book_StoreDataSet3.seller)

        Button2.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Open()
        cmd = New SqlCommand("insert into seller (s_name,s_address,s_contact) values ('" + txtName.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "')", cn)
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

    Private Sub SellerDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SellerDataGridView.CellClick
        txtName.Text = SellerDataGridView.CurrentRow.Cells(1).Value.ToString
        txtAddress.Text = SellerDataGridView.CurrentRow.Cells(2).Value.ToString
        txtContact.Text = SellerDataGridView.CurrentRow.Cells(3).Value.ToString

        Button2.Enabled = True
        Button3.Enabled = True

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn.Open()
        cmd = New SqlCommand("update seller set s_name = '" + txtName.Text + "', s_address = '" + txtAddress.Text + "', s_contact = '" + txtContact.Text + "' where s_id = " + SellerDataGridView.CurrentRow.Cells(0).Value.ToString + " ", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Update Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            update_combo_name()
            Reset()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cn.Open()
        cmd = New SqlCommand("delete from seller where s_id = " + SellerDataGridView.CurrentRow.Cells(0).Value.ToString + " ", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Delete Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            update_combo_name()
            Reset()
        End If
    End Sub

    Private Sub seller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_combo_name()
        Reset()
    End Sub
End Class