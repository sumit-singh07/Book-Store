Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pbLoading.Value >= 100 Then
            Timer1.Enabled = False
            Me.Hide()
            Login.ShowDialog()
        Else
            pbLoading.Value = pbLoading.Value + 5
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
