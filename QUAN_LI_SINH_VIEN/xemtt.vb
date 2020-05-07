Public Class xemtt
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
End Class