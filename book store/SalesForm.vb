Imports System.Data.SqlClient

Public Class SalesForm

    Dim total As Integer
    Dim dis As Decimal
    Dim f1 As Integer
    Dim f2 As Integer
    Dim f3 As Integer
    Dim q As Integer

    Dim cn As New SqlConnection("Data Source=DESKTOP-TD2OJPK;Initial Catalog=Book Store;User ID=sa;Password=sumit123")
    Dim cmd As SqlCommand

    Private Sub update_combo_name()
        cmd = New SqlCommand("select distinct c_name from customer", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim col As New AutoCompleteStringCollection
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("c_name").ToString)
        Next
        txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtName.AutoCompleteCustomSource = col
        txtName.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        cmd = New SqlCommand("select distinct book_title from purchase", cn)
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


        'cmd = New SqlCommand("select distinct author from sales", cn)
        'Dim da2 As New SqlDataAdapter(cmd)
        'Dim ds2 As New DataSet
        'Dim col2 As New AutoCompleteStringCollection
        'da2.Fill(ds2)
        'For i = 0 To ds2.Tables(0).Rows.Count - 1
        '    col2.Add(ds2.Tables(0).Rows(i)("author").ToString)
        'Next
        'txtAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtAuthor.AutoCompleteCustomSource = col2
        'txtAuthor.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        'cmd = New SqlCommand("select distinct publisher from sales", cn)
        'Dim da3 As New SqlDataAdapter(cmd)
        'Dim ds3 As New DataSet
        'Dim col3 As New AutoCompleteStringCollection
        'da3.Fill(ds3)
        'For i = 0 To ds3.Tables(0).Rows.Count - 1
        '    col3.Add(ds3.Tables(0).Rows(i)("publisher").ToString)
        'Next
        'txtPublisher.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtPublisher.AutoCompleteCustomSource = col3
        'txtPublisher.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub Reset()
        DateTimePicker1.Value = DateAndTime.Now()
        txtName.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtPublisher.Clear()
        txtPrice.Clear()
        txtQty.Clear()
        txtDis.Clear()
        txtTotal.Clear()

        DateTimePicker1.Focus()
        Me.SalesTableAdapter.Fill(Me.Book_StoreDataSet.sales)

        Button2.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cal_total()
        check_customer()
        check_books()
        check_qty()
        If f1 = 1 And f2 = 1 And f3 = 1 Then
            cn.Open()
            cmd = New SqlCommand("sales_insert", cn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@sales_date", DateTimePicker1.Value).DbType = DbType.Date
            cmd.Parameters.AddWithValue("@cust_name", txtName.Text).DbType = DbType.String
            cmd.Parameters.AddWithValue("@book_title", txtTitle.Text).DbType = DbType.String
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text).DbType = DbType.String
            cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text).DbType = DbType.String
            cmd.Parameters.AddWithValue("@price", Val(txtPrice.Text)).DbType = DbType.Int16
            cmd.Parameters.AddWithValue("@qty", Val(txtQty.Text)).DbType = DbType.Int16
            cmd.Parameters.AddWithValue("@discount", Val(txtDis.Text)).DbType = DbType.Int16
            cmd.Parameters.AddWithValue("@total", Val(txtTotal.Text)).DbType = DbType.Decimal

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cn.Close()

            cn.Open()
            cmd = New SqlCommand("update stock set qty = qty - " + txtQty.Text + " where b_title = '" + txtTitle.Text + "'", cn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cn.Close()

            If MessageBox.Show("Record Insert Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then

                update_combo_name()
                Reset()
            End If
        End If

    End Sub

    Private Sub cal_total()
        total = Val(txtPrice.Text) * Val(txtQty.Text)
        dis = total * Val(txtDis.Text) / 100
        total = total - dis
        txtTotal.Text = total
    End Sub
    Private Sub txtDis_TextChanged(sender As Object, e As EventArgs) Handles txtDis.TextChanged
        cal_total()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Reset()
    End Sub

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_combo_name()
        Reset()

    End Sub

    Private Sub SalesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SalesDataGridView.CellClick
        DateTimePicker1.Text = SalesDataGridView.CurrentRow.Cells(1).Value.ToString
        txtName.Text = SalesDataGridView.CurrentRow.Cells(2).Value.ToString
        txtTitle.Text = SalesDataGridView.CurrentRow.Cells(3).Value.ToString
        txtAuthor.Text = SalesDataGridView.CurrentRow.Cells(4).Value.ToString
        txtPublisher.Text = SalesDataGridView.CurrentRow.Cells(5).Value.ToString
        txtPrice.Text = SalesDataGridView.CurrentRow.Cells(6).Value.ToString
        txtQty.Text = SalesDataGridView.CurrentRow.Cells(7).Value.ToString
        txtDis.Text = SalesDataGridView.CurrentRow.Cells(8).Value.ToString
        txtTotal.Text = SalesDataGridView.CurrentRow.Cells(9).Value.ToString

        Button2.Enabled = True
        Button3.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn.Open()
        cmd = New SqlCommand("update sales set sales_date = '" + DateTimePicker1.Text + "',cust_name = '" + txtName.Text + "',book_title = '" + txtTitle.Text + "', author = '" + txtAuthor.Text + "', publisher = '" + txtPublisher.Text + "', price = " + txtPrice.Text + ", qty = " + txtQty.Text + ", discount =" + txtDis.Text + ",total = " + txtTotal.Text + " where sales_id = " + SalesDataGridView.CurrentRow.Cells(0).Value.ToString + " ", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Update Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            update_combo_name()
            Reset()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cn.Open()
        cmd = New SqlCommand("delete from sales where sales_id = " + SalesDataGridView.CurrentRow.Cells(0).Value.ToString + " ", cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        If MessageBox.Show("Record Delete Successfully", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information) Then

            update_combo_name()
            Reset()
        End If
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        cmd = New SqlCommand("select * from books where b_title = '" + txtTitle.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            txtAuthor.Text = ds.Tables(0).Rows(0)("author").ToString
            txtPublisher.Text = ds.Tables(0).Rows(0)("publisher").ToString
            txtPrice.Text = ds.Tables(0).Rows(0)("price").ToString
            txtPrice.Text = Val(txtPrice.Text) + Val(txtPrice.Text) * 0.3
        Next

        If txtTitle.Text = "" Then
            txtAuthor.Clear()
            txtPublisher.Clear()
            txtPrice.Clear()
        End If
    End Sub

    Private Sub check_customer()
        cmd = New SqlCommand("select distinct c_name from customer", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        f1 = 0
        For i = 0 To ds.Tables(0).Rows.Count - 1
            If txtName.Text = ds.Tables(0).Rows(i)("c_name").ToString Then
                f1 = 1
                Exit For
            End If
        Next
        If f1 = 0 Then
            txtName.Clear()
            MsgBox("Invalid Customer")
            txtName.Focus()
        End If
    End Sub

    Private Sub check_qty()
        cmd = New SqlCommand("select qty from stock where b_title = '" + txtTitle.Text + "'", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        q = ds.Tables(0).Rows(0)("qty").ToString
        f3 = 1
        If txtQty.Text > q Then
            MsgBox("This Qty is not avilable")
            txtQty.Focus()
            f3 = 0
        End If
    End Sub

    Private Sub check_books()
        cmd = New SqlCommand("select distinct book_title from purchase", cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        f2 = 0
        For i = 0 To ds.Tables(0).Rows.Count - 1
            If txtTitle.Text = ds.Tables(0).Rows(i)("book_title").ToString Then
                f2 = 1
                Exit For
            End If
        Next
        If f2 = 0 Then
            txtTitle.Clear()
            MsgBox("Invalid Book Title")
            txtTitle.Focus()
        End If
    End Sub
End Class