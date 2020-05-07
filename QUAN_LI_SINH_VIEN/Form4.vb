Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'quanlisinhvien_vbnetDataSet.KHOA' table. You can move, or remove it, as needed.
        Me.KHOATableAdapter.Fill(Me.quanlisinhvien_vbnetDataSet.KHOA)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class