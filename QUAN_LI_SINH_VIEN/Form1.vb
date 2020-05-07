Public Class Form1
    Private _DBAccess As New DataBaseAccess
    Private _isLoading As Boolean = False



    Private Sub LoadDataOnCombobox()
        Dim sqlQueryBENHAN As String = "SELECT MA_BENH,TEN_BENH,MA_KHOA FROM dbo.benhan"
        Dim sqlQueryKHOA As String = "SELECT MA_KHOA, TEN_KHOA FROM dbo.khoa"
        Dim dataTableBENHAN As DataTable = _DBAccess.GetDataTable(sqlQueryBENHAN)
        Dim dataTableKHOA As DataTable = _DBAccess.GetDataTable(sqlQueryKHOA)
        Me.ComboBoxBENHAN.DataSource = dataTableBENHAN
        Me.ComboBoxBENHAN.DisplayMember = "TEN_BENH"
        Me.ComboBoxBENHAN.ValueMember = "MA_BENH"
        Me.ComboBoxKHOA.DataSource = dataTableKHOA
        Me.ComboBoxKHOA.DisplayMember = "TEN_KHOA"
        Me.ComboBoxKHOA.ValueMember = "MA_KHOA"
    End Sub
    Private Sub LoadDataOnGridView(MA_BENH As String)
        Dim sqlQueryBENHNHAN As String = String.Format("Select ID, TEN_BN, QUE_QUAN, SDT from dbo.thongtin_bn WHERE MA_BENH ='{0}'", MA_BENH)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQueryBENHNHAN)
        Me.dataviewBENHNHAN.DataSource = dTable

        With Me.dataviewBENHNHAN

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Họ Tên"
            .Columns(2).HeaderText = "Quê Quán"
            .Columns(3).HeaderText = "Số ĐT"
            .Columns(0).Width = 120
            .Columns(1).Width = 200
            .Columns(2).Width = 200
            .Columns(3).Width = 200
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True
        LoadDataOnCombobox()
        LoadDataOnGridView(Me.ComboBoxBENHAN.SelectedValue)
        LoadDataOnGridView(Me.ComboBoxKHOA.SelectedValue)
        _isLoading = False

    End Sub
    Private Sub ComboBoxLOP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBENHAN.SelectedIndexChanged
        If Not _isLoading Then
            LoadDataOnGridView(Me.ComboBoxBENHAN.SelectedValue)
        End If
    End Sub
    Private Sub ComboBoxKHOA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKHOA.SelectedIndexChanged
        If Not _isLoading Then
            LoadDataOnGridView(Me.ComboBoxKHOA.SelectedValue)
        End If
    End Sub
    Private Sub Search(MA_BENH As String, value As String)
        Dim sqlQuery As String = String.Format("SELECT ID, TEN_BN, QUE_QUAN,SDT  FROM dbo.thongtin_bn WHERE MA_BENH ='{0}'", MA_BENH)
        If Me.ComboBoxSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format(" AND ID LIKE '{0}%'", value)
        ElseIf Me.ComboBoxSearch.SelectedIndex = 1 Then
            sqlQuery += String.Format(" AND TEN_BN LIKE '{0}%'", value)
        ElseIf Me.ComboBoxSearch.SelectedIndex = 2 Then
            sqlQuery += String.Format(" AND QUE_QUAN LIKE '{0}%'", value)
        ElseIf Me.ComboBoxSearch.SelectedIndex = 3 Then
            sqlQuery += String.Format(" AND SDT LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataviewBENHNHAN.DataSource = dTable
        With Me.dataviewBENHNHAN
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Họ Tên"
            .Columns(2).HeaderText = "Quê Quán"
            .Columns(3).HeaderText = "Số ĐT"
            .Columns(0).Width = 120
            .Columns(1).Width = 200
            .Columns(2).Width = 200
            .Columns(3).Width = 200
        End With
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Search(Me.ComboBoxBENHAN.SelectedValue, Me.TextBoxSearch.Text)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Form2(False)

        frm.TEN_BENH.Text = Me.ComboBoxBENHAN.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.ComboBoxBENHAN.SelectedValue)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Form2(True)
        frm.TEN_BENH.Text = Me.ComboBoxBENHAN.SelectedValue
        frm.ID.ReadOnly = True
        With Me.dataviewBENHNHAN
            frm.ID.Text = .Rows(.CurrentCell.RowIndex).Cells("ID").Value
            frm.HOTEN.Text = .Rows(.CurrentCell.RowIndex).Cells("TEN_BN").Value
            frm.QUE_QUAN.Text = .Rows(.CurrentCell.RowIndex).Cells("QUE_QUAN").Value
            frm.SDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.ComboBoxBENHAN.SelectedValue)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ID As String = Me.dataviewBENHNHAN.Rows(Me.dataviewBENHNHAN.CurrentCell.RowIndex).Cells("ID").Value
        Dim sqlQuery As String = String.Format("DELETE thongtin_bn WHERE ID='{0}'", ID)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa thành công", "Successfully", MessageBoxButtons.OK)
            LoadDataOnGridView(Me.ComboBoxBENHAN.SelectedValue)
        Else
            MessageBox.Show("Lỗi khi xóa dữ liệu", "Lỗi", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub


End Class
