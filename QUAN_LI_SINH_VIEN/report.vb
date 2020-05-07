Public Class report
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.thongtin_bn' table. You can move, or remove it, as needed.
        Me.thongtin_bnTableAdapter.Fill(Me.DataSet1.thongtin_bn)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class