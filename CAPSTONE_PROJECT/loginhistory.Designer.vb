<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginhistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginhistory))
        loginhistorydatagridview = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Button4 = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        CType(loginhistorydatagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' loginhistorydatagridview
        ' 
        loginhistorydatagridview.AllowUserToAddRows = False
        loginhistorydatagridview.AllowUserToDeleteRows = False
        loginhistorydatagridview.AllowUserToResizeColumns = False
        loginhistorydatagridview.AllowUserToResizeRows = False
        loginhistorydatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        loginhistorydatagridview.BackgroundColor = Color.WhiteSmoke
        loginhistorydatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.LightCyan
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        loginhistorydatagridview.DefaultCellStyle = DataGridViewCellStyle1
        loginhistorydatagridview.Location = New Point(21, 54)
        loginhistorydatagridview.Name = "loginhistorydatagridview"
        loginhistorydatagridview.RowTemplate.Height = 25
        loginhistorydatagridview.Size = New Size(641, 287)
        loginhistorydatagridview.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(169, 25)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(96, 23)
        DateTimePicker1.TabIndex = 1
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(294, 25)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(96, 23)
        DateTimePicker2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(396, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(22, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search..."
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 5
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(477, 23)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 6
        Button3.Text = "View All"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(128, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 7
        Label1.Text = "From"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(271, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 15)
        Label2.TabIndex = 8
        Label2.Text = "To"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(587, 23)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlText
        Button4.ImageAlign = ContentAlignment.MiddleRight
        Button4.Location = New Point(587, 347)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 10
        Button4.Text = "Print"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' loginhistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(674, 386)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(loginhistorydatagridview)
        FormBorderStyle = FormBorderStyle.None
        Name = "loginhistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "loginhistory"
        CType(loginhistorydatagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents loginhistorydatagridview As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
