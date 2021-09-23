Public Class setting

    Public flag As String

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        If MessageBox.Show("are you sure want to clear books data?", "Book Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            flag = "books"
            Security.ShowDialog()
        End If
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        If MessageBox.Show("are you sure want to clear sales data?", "Book Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            flag = "sales"
            Security.ShowDialog()
        End If
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        If MessageBox.Show("are you sure want to clear purchase data?", "Book Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            flag = "purchase"
            Security.ShowDialog()
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        If MessageBox.Show("are you sure want to clear customer data?", "Book Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            flag = "customer"
            Security.ShowDialog()
        End If
    End Sub

    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        If MessageBox.Show("are you sure want to clear seller data?", "Book Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            flag = "seller"
            Security.ShowDialog()
        End If
    End Sub

    Private Sub btnALL_Click(sender As Object, e As EventArgs) Handles btnALL.Click
        If MessageBox.Show("are you sure want to clear all data?", "Book Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            flag = "all"
            Security.ShowDialog()
        End If
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        If MessageBox.Show("are you sure want to clear stock data?", "Book Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            flag = "stock"
            Security.ShowDialog()
        End If
    End Sub
End Class