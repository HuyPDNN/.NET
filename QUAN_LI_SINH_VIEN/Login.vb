Imports System.Data.SqlClient
Public Class Login
    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Dim conn As New SqlConnection("Data Source=DESKTOP-PIKNVLI;Initial Catalog=quanlibenan;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM dbo.USER WHERE USERNAME = '" & TextBoxUsername.Text & "' and  PASS = '" & TextBoxPassword.Text & "'", conn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Đăng Nhập Thành Công")
            xemtt.Show()
        Else
            MessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu")
        End If
    End Sub
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click

        Me.Close()

    End Sub
End Class
