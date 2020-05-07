Public Class Form2
    Private _DBAccess As New DataBaseAccess
    Private _isEdit As Boolean = False
    Public Sub New(IsEdit As Boolean)
        InitializeComponent()
        _isEdit = IsEdit
    End Sub
    Private Function InsertBN()
        Dim sqlQuery As String = "INSERT INTO thongtin_bn (ID,TEN_BN,QUE_QUAN,SDT,MA_BENH)"
        sqlQuery += String.Format("values ('{0}','{1}','{2}','{3}','{4}')", ID.Text, HOTEN.Text, QUE_QUAN.Text, SDT.Text, TEN_BENH.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function UpdateBN() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE thongtin_bn SET TEN_BN='{0}', QUE_QUAN='{1}',SDT ='{2}' WHERE ID='{3}'",
        Me.HOTEN.Text, Me.QUE_QUAN.Text, Me.SDT.Text, Me.ID.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(ID.Text) OrElse String.IsNullOrEmpty(HOTEN.Text) OrElse
            String.IsNullOrEmpty(QUE_QUAN.Text) OrElse String.IsNullOrEmpty(SDT.Text) OrElse String.IsNullOrEmpty(TEN_BENH.Text)
    End Function
    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        If IsEmpty() Then
            MessageBox.Show("Hãy nhập tất cả các giá trị", "Thông báo", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateBN() Then
                    MessageBox.Show("Sửa dữ liệu thành công", "Successfully", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Lỗi sửa dữ liệu", "Lỗi", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertBN() Then
                    MessageBox.Show("Thêm dữ liệu thành công", "Successfully", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Lỗi thêm dữ liệu", "Lỗi", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class