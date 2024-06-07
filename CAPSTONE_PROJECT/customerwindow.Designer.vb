<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerwindow
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnSelectCustomer = New Button()
        cuswindowdatagridview = New DataGridView()
        txtcuswindowSearch = New TextBox()
        btnSearchcuswindow = New Button()
        CType(cuswindowdatagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSelectCustomer
        ' 
        btnSelectCustomer.BackColor = Color.LightGray
        btnSelectCustomer.FlatStyle = FlatStyle.Flat
        btnSelectCustomer.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectCustomer.ForeColor = Color.Black
        btnSelectCustomer.Location = New Point(597, 283)
        btnSelectCustomer.Name = "btnSelectCustomer"
        btnSelectCustomer.Size = New Size(80, 32)
        btnSelectCustomer.TabIndex = 0
        btnSelectCustomer.Text = "Select"
        btnSelectCustomer.UseVisualStyleBackColor = False
        ' 
        ' cuswindowdatagridview
        ' 
        cuswindowdatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        cuswindowdatagridview.BackgroundColor = Color.LightGray
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.LightGray
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        cuswindowdatagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        cuswindowdatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.LightCyan
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        cuswindowdatagridview.DefaultCellStyle = DataGridViewCellStyle2
        cuswindowdatagridview.Location = New Point(12, 53)
        cuswindowdatagridview.Name = "cuswindowdatagridview"
        cuswindowdatagridview.RowTemplate.Height = 25
        cuswindowdatagridview.Size = New Size(676, 216)
        cuswindowdatagridview.TabIndex = 1
        ' 
        ' txtcuswindowSearch
        ' 
        txtcuswindowSearch.BackColor = Color.WhiteSmoke
        txtcuswindowSearch.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtcuswindowSearch.Location = New Point(41, 12)
        txtcuswindowSearch.Name = "txtcuswindowSearch"
        txtcuswindowSearch.Size = New Size(189, 22)
        txtcuswindowSearch.TabIndex = 2
        ' 
        ' btnSearchcuswindow
        ' 
        btnSearchcuswindow.BackColor = Color.LightGray
        btnSearchcuswindow.FlatStyle = FlatStyle.Flat
        btnSearchcuswindow.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSearchcuswindow.ForeColor = Color.Black
        btnSearchcuswindow.Location = New Point(236, 9)
        btnSearchcuswindow.Name = "btnSearchcuswindow"
        btnSearchcuswindow.Size = New Size(84, 27)
        btnSearchcuswindow.TabIndex = 3
        btnSearchcuswindow.Text = "Search"
        btnSearchcuswindow.UseVisualStyleBackColor = False
        ' 
        ' customerwindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(702, 327)
        Controls.Add(btnSearchcuswindow)
        Controls.Add(txtcuswindowSearch)
        Controls.Add(cuswindowdatagridview)
        Controls.Add(btnSelectCustomer)
        FormBorderStyle = FormBorderStyle.None
        Name = "customerwindow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "customerwindow"
        CType(cuswindowdatagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSelectCustomer As Button
    Friend WithEvents cuswindowdatagridview As DataGridView
    Friend WithEvents txtcuswindowSearch As TextBox
    Friend WithEvents btnSearchcuswindow As Button
End Class
