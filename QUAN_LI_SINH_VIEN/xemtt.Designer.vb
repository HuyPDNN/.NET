<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xemtt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xemtt))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxSearch = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxKHOA = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBENHAN = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.dataviewBENHNHAN = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataviewBENHNHAN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(846, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "XEM THÔNG TIN BỆNH NHÂN"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 534)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(846, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'ComboBoxSearch
        '
        Me.ComboBoxSearch.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSearch.FormattingEnabled = True
        Me.ComboBoxSearch.Items.AddRange(New Object() {"ID", "Họ tên", "Địa chỉ"})
        Me.ComboBoxSearch.Location = New System.Drawing.Point(275, 181)
        Me.ComboBoxSearch.Name = "ComboBoxSearch"
        Me.ComboBoxSearch.Size = New System.Drawing.Size(119, 24)
        Me.ComboBoxSearch.TabIndex = 15
        Me.ComboBoxSearch.Text = "Tìm "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxKHOA)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBENHAN)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(400, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 82)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "KHOA"
        '
        'ComboBoxKHOA
        '
        Me.ComboBoxKHOA.DisplayMember = "className"
        Me.ComboBoxKHOA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxKHOA.FormattingEnabled = True
        Me.ComboBoxKHOA.Location = New System.Drawing.Point(16, 39)
        Me.ComboBoxKHOA.Name = "ComboBoxKHOA"
        Me.ComboBoxKHOA.Size = New System.Drawing.Size(202, 27)
        Me.ComboBoxKHOA.TabIndex = 13
        Me.ComboBoxKHOA.ValueMember = "className"
        '
        'ComboBoxBENHAN
        '
        Me.ComboBoxBENHAN.DisplayMember = "className"
        Me.ComboBoxBENHAN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBENHAN.FormattingEnabled = True
        Me.ComboBoxBENHAN.Location = New System.Drawing.Point(224, 39)
        Me.ComboBoxBENHAN.Name = "ComboBoxBENHAN"
        Me.ComboBoxBENHAN.Size = New System.Drawing.Size(202, 27)
        Me.ComboBoxBENHAN.TabIndex = 0
        Me.ComboBoxBENHAN.ValueMember = "className"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BỆNH ÁN"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(43, 180)
        Me.TextBoxSearch.Multiline = True
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(226, 28)
        Me.TextBoxSearch.TabIndex = 13
        '
        'dataviewBENHNHAN
        '
        Me.dataviewBENHNHAN.AllowUserToAddRows = False
        Me.dataviewBENHNHAN.AllowUserToDeleteRows = False
        Me.dataviewBENHNHAN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dataviewBENHNHAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataviewBENHNHAN.Location = New System.Drawing.Point(64, 227)
        Me.dataviewBENHNHAN.MultiSelect = False
        Me.dataviewBENHNHAN.Name = "dataviewBENHNHAN"
        Me.dataviewBENHNHAN.ReadOnly = True
        Me.dataviewBENHNHAN.RowTemplate.Height = 24
        Me.dataviewBENHNHAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataviewBENHNHAN.Size = New System.Drawing.Size(739, 301)
        Me.dataviewBENHNHAN.TabIndex = 12
        '
        'xemtt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 641)
        Me.Controls.Add(Me.ComboBoxSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.dataviewBENHNHAN)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "xemtt"
        Me.Text = "xemtt"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataviewBENHNHAN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ComboBoxSearch As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxKHOA As ComboBox
    Friend WithEvents ComboBoxBENHAN As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents dataviewBENHNHAN As DataGridView
End Class
