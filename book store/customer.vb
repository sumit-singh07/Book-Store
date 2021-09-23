Imports System.Data.SqlClient

Public Class customer

    Dim cn As New SqlConnection("Data Source=DESKTOP-TD2OJPK;Initial Catalog=Book Store;User ID=sa;Password=sumit123")
    Dim cmd As SqlCommand

    Private Sub update_combo_name()

        cmd = New SqlCommand("select distinct c_name from customer", cn)
        Dim da1 As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        Dim col1 As New AutoCompleteStringCollection
        da1.Fill(ds1)
        For i = 0 To ds1.Tables(0).Rows.Count - 1
            col1.Add(ds1.Tables(0).Rows(i)("c_name").ToString)
        Next
        txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtName.AutoCompleteCustomSource = col1
        txtName.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        'cmd = New SqlCommand("select distinct c_address from customer", cn)
        'Dim da2 As New SqlDataAdapter(cmd)
        'Dim ds2 As New DataSet
        'Dim col2 As New AutoCompleteStringCollection
        'da2.Fill(ds2)
        'For i = 0 To ds2.Tables(0).Rows.Count - 1
        '    col2.Add(ds2.Tables(0).Rows(i)("c_address").ToString)
        'Next
        'txtAddress.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtAddress.AutoCompleteCustomSource = col2
        'txtAddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        cmd = New SqlCommand("select distinct c_contact from customer", cn)
        Dim da3 As New SqlDataAdapter(cmd)
        Dim ds3 As New DataSet
        Dim col3 As New AutoCompleteStringCollection
        da3.Fill(ds3)
        For i = 0 To ds3.Tables(0).Rows.Count - 1
            col3.Add(ds3.Tables(0).Rows(i)("c_contact").ToString)
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
        Me.CustomerTableAdapter.Fill(Me.Book_StoreDataSet3.customer)

        Button2.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Open()
        cmd = New SqlCommand("insert into customer (c_name,c_address,c_contact) values ('" + txtName.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "')", cn)
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

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_combo_name()
        Reset()
    End Sub

    Private Sub CustomerDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellClick
        txtName.Text = CustomerDataGridView.CurrentRow.Cells(1).Value.ToString
        txtAddress.Text = CustomerDataGridView.CurrentRow.Cells(2).Value.ToString
        txtContact.Text = CustomerDataGridView.CurrentRow.Cells(3).Value.ToString

        Button2.Enabled = True
        Button3.Enabled = True

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn.Open()
        cmd = New SqlCommand("update customer set c_name = '" + txtName.Text + "', c_address = '" + txtAddress.Text + "', c_contact = '" + txtContact.Text + "' where c_id = " + CustomerDataGridView.CurrentRow.Cells(0).Value.ToString + " ", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Update Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            update_combo_name()
            Reset()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cn.Open()
        cmd = New SqlCommand("delete from customer where c_id = " + CustomerDataGridView.CurrentRow.Cells(0).Value.ToString + " ", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Delete Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            update_combo_name()
            Reset()
        End If
    End Sub
End Class