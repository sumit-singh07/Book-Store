Public Class Login
    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If MessageBox.Show("Are you sure wnat to cancle?", "Book Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUserID.Text = "sumit" And TxtPassword.Text = "123" Then
            Me.Hide()
            MainForm.ShowDialog()
        Else
            MsgBox("Invalid User ID and Password")
        End If
    End Sub

    Private Sub BtnLogin_MouseHover(sender As Object, e As EventArgs) Handles BtnLogin.MouseHover
        BtnLogin.BackColor = Color.FromArgb(0, 182, 0)
    End Sub

    Private Sub BtnLogin_MouseLeave(sender As Object, e As EventArgs) Handles BtnLogin.MouseLeave
        BtnLogin.BackColor = Color.FromArgb(153, 180, 209)
    End Sub

    Private Sub BtnCancel_MouseHover(sender As Object, e As EventArgs) Handles BtnCancel.MouseHover
        BtnCancel.BackColor = Color.Red
    End Sub

    Private Sub BtnCancel_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancel.MouseLeave
        BtnCancel.BackColor = Color.FromArgb(153, 180, 209)
    End Sub

    Private Sub BtnCancel_GotFocus(sender As Object, e As EventArgs) Handles BtnCancel.GotFocus
        BtnCancel.BackColor = Color.Red
    End Sub

    Private Sub BtnCancel_LostFocus(sender As Object, e As EventArgs) Handles BtnCancel.LostFocus
        BtnCancel.BackColor = Color.FromArgb(153, 180, 209)
    End Sub

    Private Sub BtnLogin_GotFocus(sender As Object, e As EventArgs) Handles BtnLogin.GotFocus
        BtnLogin.BackColor = Color.FromArgb(0, 182, 0)
    End Sub

    Private Sub BtnLogin_LostFocus(sender As Object, e As EventArgs) Handles BtnLogin.LostFocus
        BtnLogin.BackColor = Color.FromArgb(153, 180, 209)
    End Sub
End Class