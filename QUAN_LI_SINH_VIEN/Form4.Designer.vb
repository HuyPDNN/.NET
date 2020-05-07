<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.quanlisinhvien_vbnetDataSet = New QUAN_LI_SINH_VIEN.quanlisinhvien_vbnetDataSet()
        Me.KHOABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KHOATableAdapter = New QUAN_LI_SINH_VIEN.quanlisinhvien_vbnetDataSetTableAdapters.KHOATableAdapter()
        CType(Me.quanlisinhvien_vbnetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KHOABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 37
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.KHOABindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QUAN_LI_SINH_VIEN.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(652, 301)
        Me.ReportViewer1.TabIndex = 0
        '
        'quanlisinhvien_vbnetDataSet
        '
        Me.quanlisinhvien_vbnetDataSet.DataSetName = "quanlisinhvien_vbnetDataSet"
        Me.quanlisinhvien_vbnetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KHOABindingSource
        '
        Me.KHOABindingSource.DataMember = "KHOA"
        Me.KHOABindingSource.DataSource = Me.quanlisinhvien_vbnetDataSet
        '
        'KHOATableAdapter
        '
        Me.KHOATableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 357)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.quanlisinhvien_vbnetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KHOABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents KHOABindingSource As BindingSource
    Friend WithEvents quanlisinhvien_vbnetDataSet As quanlisinhvien_vbnetDataSet
    Friend WithEvents KHOATableAdapter As quanlisinhvien_vbnetDataSetTableAdapters.KHOATableAdapter
End Class
