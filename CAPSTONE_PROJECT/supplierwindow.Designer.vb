<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierwindow
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
        btnsuppwindowsearch = New Button()
        suppwindowdatagridview = New DataGridView()
        txtsuppwindowsearch = New TextBox()
        btnselect = New Button()
        CType(suppwindowdatagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnsuppwindowsearch
        ' 
        btnsuppwindowsearch.BackColor = Color.LightGray
        btnsuppwindowsearch.FlatStyle = FlatStyle.Flat
        btnsuppwindowsearch.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnsuppwindowsearch.ForeColor = Color.Black
        btnsuppwindowsearch.Location = New Point(176, 12)
        btnsuppwindowsearch.Name = "btnsuppwindowsearch"
        btnsuppwindowsearch.Size = New Size(79, 27)
        btnsuppwindowsearch.TabIndex = 0
        btnsuppwindowsearch.Text = "Search"
        btnsuppwindowsearch.UseVisualStyleBackColor = False
        ' 
        ' suppwindowdatagridview
        ' 
        suppwindowdatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        suppwindowdatagridview.BackgroundColor = Color.LightGray
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.LightGray
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        suppwindowdatagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        suppwindowdatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.LightCyan
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        suppwindowdatagridview.DefaultCellStyle = DataGridViewCellStyle2
        suppwindowdatagridview.Location = New Point(12, 52)
        suppwindowdatagridview.Name = "suppwindowdatagridview"
        suppwindowdatagridview.RowTemplate.Height = 25
        suppwindowdatagridview.Size = New Size(505, 222)
        suppwindowdatagridview.TabIndex = 1
        ' 
        ' txtsuppwindowsearch
        ' 
        txtsuppwindowsearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtsuppwindowsearch.Location = New Point(12, 12)
        txtsuppwindowsearch.Name = "txtsuppwindowsearch"
        txtsuppwindowsearch.Size = New Size(147, 27)
        txtsuppwindowsearch.TabIndex = 2
        ' 
        ' btnselect
        ' 
        btnselect.BackColor = Color.LightGray
        btnselect.FlatStyle = FlatStyle.Flat
        btnselect.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnselect.ForeColor = Color.Black
        btnselect.Location = New Point(426, 280)
        btnselect.Name = "btnselect"
        btnselect.Size = New Size(91, 37)
        btnselect.TabIndex = 3
        btnselect.Text = "Select"
        btnselect.UseVisualStyleBackColor = False
        ' 
        ' supplierwindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(529, 329)
        Controls.Add(btnselect)
        Controls.Add(txtsuppwindowsearch)
        Controls.Add(suppwindowdatagridview)
        Controls.Add(btnsuppwindowsearch)
        FormBorderStyle = FormBorderStyle.None
        Name = "supplierwindow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "supplierwindow"
        CType(suppwindowdatagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnsuppwindowsearch As Button
    Friend WithEvents suppwindowdatagridview As DataGridView
    Friend WithEvents txtsuppwindowsearch As TextBox
    Friend WithEvents btnselect As Button
End Class
