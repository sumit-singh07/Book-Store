Public Class MainForm

    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Chart1.Series("Sales").Points.AddXY("Sun", 76)
        Me.Chart1.Series("Sales").Points.AddXY("Mon", 86)
        Me.Chart1.Series("Sales").Points.AddXY("Tues", 26)
        Me.Chart1.Series("Sales").Points.AddXY("Wed", 96)
        Me.Chart1.Series("Sales").Points.AddXY("Thu", 54)
        Me.Chart1.Series("Sales").Points.AddXY("Fri", 76)
        Me.Chart1.Series("Sales").Points.AddXY("Sat", 34)

        Panel1.Width = 210

        Button10.Show()
        Button12.Hide()

        ToolTip1.SetToolTip(btnHome, "Home")
        ToolTip1.SetToolTip(btnSales, "Sales")
        ToolTip1.SetToolTip(btnPurchase, "Purchase")
        ToolTip1.SetToolTip(btnSales_r, "Sales Report")
        ToolTip1.SetToolTip(btnPurchase_r, "Purchase Report")
        ToolTip1.SetToolTip(btnSetting, "Setting")
        ToolTip1.SetToolTip(btnBook, "Books")
        ToolTip1.SetToolTip(btnBook_r, "Books Report")
        ToolTip1.SetToolTip(btnCustomer, "Customer")
        ToolTip1.SetToolTip(btnCustomer_r, "Customer Report")
        ToolTip1.SetToolTip(btnSeller, "Seller")
        ToolTip1.SetToolTip(btnSeller_r, "Seller Report")
        ToolTip1.SetToolTip(btnStock, "Stock")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Chart1.Series("Sales").Points.Clear()
        Me.Chart1.Series("Sales").Points.AddXY("Sun", CInt(Math.Ceiling(Rnd() * 100)) + 1)
        Me.Chart1.Series("Sales").Points.AddXY("Mon", CInt(Math.Ceiling(Rnd() * 100)) + 1)
        Me.Chart1.Series("Sales").Points.AddXY("Tues", CInt(Math.Ceiling(Rnd() * 100)) + 1)
        Me.Chart1.Series("Sales").Points.AddXY("Wed", CInt(Math.Ceiling(Rnd() * 100)) + 1)
        Me.Chart1.Series("Sales").Points.AddXY("Thu", CInt(Math.Ceiling(Rnd() * 100)) + 1)
        Me.Chart1.Series("Sales").Points.AddXY("Fri", CInt(Math.Ceiling(Rnd() * 100)) + 1)
        Me.Chart1.Series("Sales").Points.AddXY("Sat", CInt(Math.Ceiling(Rnd() * 100)) + 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        SalesForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSales_r.Click
        SalesView.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        PurchaseForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPurchase_r.Click
        purchaseview.Show()
    End Sub


    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave, btnHome.LostFocus
        btnHome.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnHome.MouseHover, btnHome.GotFocus
        btnHome.BackColor = Color.DodgerBlue

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnSales.MouseLeave, btnSales.LostFocus
        btnSales.BackColor = Color.FromArgb(41, 57, 85)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles btnSales.MouseHover, btnSales.GotFocus
        btnSales.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles btnPurchase.MouseLeave, btnPurchase.LostFocus
        btnPurchase.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles btnPurchase.MouseHover, btnPurchase.GotFocus
        btnPurchase.BackColor = Color.DodgerBlue

    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles btnSales_r.MouseLeave, btnSales_r.LostFocus
        btnSales_r.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles btnSales_r.MouseHover, btnSales_r.GotFocus
        btnSales_r.BackColor = Color.DodgerBlue

    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles btnPurchase_r.MouseLeave, btnPurchase_r.LostFocus
        btnPurchase_r.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles btnPurchase_r.MouseHover, btnPurchase_r.GotFocus
        btnPurchase_r.BackColor = Color.DodgerBlue

    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles btnSetting.MouseLeave, btnSetting.LostFocus
        btnSetting.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles btnSetting.MouseHover, btnSetting.GotFocus
        btnSetting.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnBook_MouseLeave(sender As Object, e As EventArgs) Handles btnBook.MouseLeave, btnBook.LostFocus
        btnBook.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub btnBook_MouseHover(sender As Object, e As EventArgs) Handles btnBook.MouseHover, btnBook.GotFocus
        btnBook.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnBook_r_MouseLeave(sender As Object, e As EventArgs) Handles btnBook_r.MouseLeave, btnBook_r.LostFocus
        btnBook_r.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub btnBook_r_MouseHover(sender As Object, e As EventArgs) Handles btnBook_r.MouseHover, btnBook_r.GotFocus
        btnBook_r.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnCustomer_MouseLeave(sender As Object, e As EventArgs) Handles btnCustomer.MouseLeave, btnCustomer.LostFocus
        btnCustomer.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub btnCustomer_MouseHover(sender As Object, e As EventArgs) Handles btnCustomer.MouseHover, btnCustomer.GotFocus
        btnCustomer.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnCustomer_r_MouseLeave(sender As Object, e As EventArgs) Handles btnCustomer_r.MouseLeave, btnCustomer_r.LostFocus
        btnCustomer_r.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub btnCustomer_r_MouseHover(sender As Object, e As EventArgs) Handles btnCustomer_r.MouseHover, btnCustomer_r.GotFocus
        btnCustomer_r.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnSeller_MouseLeave(sender As Object, e As EventArgs) Handles btnSeller.MouseLeave, btnSeller.LostFocus
        btnSeller.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub btnSeller_MouseHover(sender As Object, e As EventArgs) Handles btnSeller.MouseHover, btnSeller.GotFocus
        btnSeller.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnSeller_r_MouseLeave(sender As Object, e As EventArgs) Handles btnSeller_r.MouseLeave, btnSeller_r.LostFocus
        btnSeller_r.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub btnSeller_r_MouseHover(sender As Object, e As EventArgs) Handles btnSeller_r.MouseHover, btnSeller_r.GotFocus
        btnSeller_r.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Panel1.Width = 191
        Button12.Hide()
        PictureBox1.Show()
        Timer2.Enabled = True
    End Sub

    Private Sub Button10_MouseLeave(sender As Object, e As EventArgs) Handles Button10.MouseLeave, Button10.LostFocus
        Button10.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub Button10_MouseHover(sender As Object, e As EventArgs) Handles Button10.MouseHover, Button10.GotFocus
        Button10.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button12_MouseLeave(sender As Object, e As EventArgs) Handles Button12.MouseLeave, Button12.LostFocus
        Button12.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub Button12_MouseHover(sender As Object, e As EventArgs) Handles Button12.MouseHover, Button12.GotFocus
        Button12.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave, Button7.LostFocus
        Button7.BackColor = Color.DodgerBlue
    End Sub
    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover, Button7.GotFocus
        Button7.BackColor = Color.FromArgb(41, 57, 85)
    End Sub

    Private Sub btnStock_MouseLeave(sender As Object, e As EventArgs) Handles btnStock.MouseLeave, btnStock.LostFocus
        btnStock.BackColor = Color.FromArgb(41, 57, 85)
    End Sub
    Private Sub btnStock_MouseHover(sender As Object, e As EventArgs) Handles btnStock.MouseHover, btnStock.GotFocus
        btnStock.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel1.Width <= 50 Then
            Timer1.Enabled = False
            Button12.Show()
        Else
            Panel1.Width = Panel1.Width - 20
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Panel1.Width = 45
        Button10.Hide()
        PictureBox1.Hide()
        Timer1.Enabled = True

        btnHome.Text = ""
        btnSales.Text = ""
        btnPurchase.Text = ""
        btnSales_r.Text = ""
        btnPurchase_r.Text = ""
        btnSetting.Text = ""
        btnBook.Text = ""
        btnBook_r.Text = ""
        btnCustomer.Text = ""
        btnCustomer_r.Text = ""
        btnSeller.Text = ""
        btnSeller_r.Text = ""
        btnStock.Text = ""
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel1.Width >= 210 Then
            Timer2.Enabled = False
            Button10.Show()

            btnHome.Text = "        Home"
            btnSales.Text = "        Sale"
            btnPurchase.Text = "        Purchase"
            btnSales_r.Text = "        Sales Report"
            btnPurchase_r.Text = "        Purchase Report"
            btnSetting.Text = "        Setting"
            btnBook.Text = "        Book"
            btnBook_r.Text = "        Books Report"
            btnCustomer.Text = "        Customer"
            btnCustomer_r.Text = "        Customer Report"
            btnSeller.Text = "        Seller"
            btnSeller_r.Text = "        Seller Report"
            btnStock.Text = "        Stock"
        Else
            Panel1.Width = Panel1.Width + 20
        End If
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Books.Show()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        customer.Show()
    End Sub

    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        seller.Show()
    End Sub

    Private Sub btnBook_r_Click(sender As Object, e As EventArgs) Handles btnBook_r.Click
        book_r.Show()
    End Sub

    Private Sub btnCustomer_r_Click(sender As Object, e As EventArgs) Handles btnCustomer_r.Click
        customer_r.Show()
    End Sub

    Private Sub btnSeller_r_Click(sender As Object, e As EventArgs) Handles btnSeller_r.Click
        seller_R.Show()
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        setting.Show()
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        Stock.Show()
    End Sub
End Class