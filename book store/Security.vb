Imports System.Data.SqlClient

Public Class Security

    Dim cn As New SqlConnection("Data Source=DESKTOP-TD2OJPK;Initial Catalog=Book Store;User ID=sa;Password=sumit123")
    Dim cmd As SqlCommand

    Public flag As String

    Private Sub get_flag()
        flag = setting.flag
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        get_flag()
        If TxtUserID.Text = "sumit" And TxtPassword.Text = "123" Then
            cn.Open()
            If flag = "books" Then
                cmd = New SqlCommand("truncate table books", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Books Data Deleted")
            ElseIf flag = "sales" Then
                cmd = New SqlCommand("truncate table sales", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Sales Data Deleted")
            ElseIf flag = "purchase" Then
                cmd = New SqlCommand("truncate table purchase", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Purchase Data Deleted")
            ElseIf flag = "cutomer" Then
                cmd = New SqlCommand("truncate table customer", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Cutomer Data Deleted")
            ElseIf flag = "seller" Then
                cmd = New SqlCommand("truncate table seller", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Seller Data Deleted")
            ElseIf flag = "stock" Then
                cmd = New SqlCommand("truncate table stock", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Stock Data Deleted")
            End If


            cn.Close()
            If flag = "all" Then
                cn.Open()
                Dim cmd1 As New SqlCommand("truncate table books", cn)
                Dim cmd2 As New SqlCommand("truncate table sales", cn)
                Dim cmd3 As New SqlCommand("truncate table purchase", cn)
                Dim cmd4 As New SqlCommand("truncate table customer", cn)
                Dim cmd5 As New SqlCommand("truncate table seller", cn)
                Dim cmd6 As New SqlCommand("truncate table stock", cn)

                cmd1.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                cmd3.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                cmd5.ExecuteNonQuery()
                cmd6.ExecuteNonQuery()

                MsgBox("All Data Deleted")
                cn.Close()
            End If
            TxtUserID.Clear()
            TxtPassword.Clear()
            TxtUserID.Focus()
            Me.Close()
        Else
            MsgBox("Invalid UserID and Passsword")
        End If
    End Sub
End Class