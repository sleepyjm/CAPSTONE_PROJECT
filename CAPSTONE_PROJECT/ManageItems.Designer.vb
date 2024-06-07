<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageItems
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        InventoryDatagridview = New DataGridView()
        txtInventorySearch = New TextBox()
        btnInventorySearch = New Button()
        btnInventoryViewAll = New Button()
        txtQty = New TextBox()
        btnStockIn = New Button()
        txtManageItemSupplier = New TextBox()
        Label1 = New Label()
        btnselectsupplier = New Button()
        txtPrice = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtItemName = New TextBox()
        txtCategory = New TextBox()
        lblUserLogin = New Label()
        lblDate = New Label()
        lblTime = New Label()
        lblItemNum = New Label()
        lbltotalqty = New Label()
        qtycalculate = New Timer(components)
        lblpreviousqty = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1 = New GroupBox()
        CType(InventoryDatagridview, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' InventoryDatagridview
        ' 
        InventoryDatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        InventoryDatagridview.BackgroundColor = Color.LightGray
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.LightGray
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        InventoryDatagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        InventoryDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.LightCyan
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        InventoryDatagridview.DefaultCellStyle = DataGridViewCellStyle2
        InventoryDatagridview.Location = New Point(12, 259)
        InventoryDatagridview.Name = "InventoryDatagridview"
        InventoryDatagridview.RowTemplate.Height = 25
        InventoryDatagridview.Size = New Size(776, 164)
        InventoryDatagridview.TabIndex = 1
        ' 
        ' txtInventorySearch
        ' 
        txtInventorySearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtInventorySearch.Location = New Point(465, 226)
        txtInventorySearch.Name = "txtInventorySearch"
        txtInventorySearch.Size = New Size(142, 25)
        txtInventorySearch.TabIndex = 2
        ' 
        ' btnInventorySearch
        ' 
        btnInventorySearch.BackColor = Color.LightGray
        btnInventorySearch.FlatStyle = FlatStyle.Flat
        btnInventorySearch.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnInventorySearch.ForeColor = Color.Black
        btnInventorySearch.Location = New Point(628, 222)
        btnInventorySearch.Name = "btnInventorySearch"
        btnInventorySearch.Size = New Size(78, 31)
        btnInventorySearch.TabIndex = 3
        btnInventorySearch.Text = "Search"
        btnInventorySearch.UseVisualStyleBackColor = False
        ' 
        ' btnInventoryViewAll
        ' 
        btnInventoryViewAll.BackColor = Color.LightGray
        btnInventoryViewAll.FlatStyle = FlatStyle.Flat
        btnInventoryViewAll.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnInventoryViewAll.ForeColor = Color.Black
        btnInventoryViewAll.Location = New Point(712, 222)
        btnInventoryViewAll.Name = "btnInventoryViewAll"
        btnInventoryViewAll.Size = New Size(78, 31)
        btnInventoryViewAll.TabIndex = 4
        btnInventoryViewAll.Text = "View All"
        btnInventoryViewAll.UseVisualStyleBackColor = False
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(521, 37)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(171, 29)
        txtQty.TabIndex = 9
        txtQty.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnStockIn
        ' 
        btnStockIn.BackColor = Color.LightGray
        btnStockIn.FlatStyle = FlatStyle.Flat
        btnStockIn.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnStockIn.ForeColor = Color.Black
        btnStockIn.Location = New Point(614, 122)
        btnStockIn.Name = "btnStockIn"
        btnStockIn.Size = New Size(93, 27)
        btnStockIn.TabIndex = 13
        btnStockIn.Text = "Stock-In"
        btnStockIn.UseVisualStyleBackColor = False
        ' 
        ' txtManageItemSupplier
        ' 
        txtManageItemSupplier.Location = New Point(166, 38)
        txtManageItemSupplier.Name = "txtManageItemSupplier"
        txtManageItemSupplier.Size = New Size(171, 29)
        txtManageItemSupplier.TabIndex = 7
        txtManageItemSupplier.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(47, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 18)
        Label1.TabIndex = 11
        Label1.Text = "Supplier :"
        ' 
        ' btnselectsupplier
        ' 
        btnselectsupplier.BackColor = Color.LightGray
        btnselectsupplier.FlatStyle = FlatStyle.Flat
        btnselectsupplier.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnselectsupplier.ForeColor = Color.Black
        btnselectsupplier.Location = New Point(343, 32)
        btnselectsupplier.Name = "btnselectsupplier"
        btnselectsupplier.Size = New Size(84, 30)
        btnselectsupplier.TabIndex = 12
        btnselectsupplier.Text = "Select"
        btnselectsupplier.UseVisualStyleBackColor = False
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(521, 74)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(171, 29)
        txtPrice.TabIndex = 14
        txtPrice.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(47, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 18)
        Label2.TabIndex = 15
        Label2.Text = "Item Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(47, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 18)
        Label3.TabIndex = 16
        Label3.Text = "Category :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(441, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 18)
        Label4.TabIndex = 17
        Label4.Text = "Qty :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(441, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 18)
        Label5.TabIndex = 18
        Label5.Text = "Price :"
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(166, 78)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(171, 29)
        txtItemName.TabIndex = 19
        txtItemName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(166, 117)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(171, 29)
        txtCategory.TabIndex = 20
        txtCategory.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblUserLogin
        ' 
        lblUserLogin.AutoSize = True
        lblUserLogin.ForeColor = Color.White
        lblUserLogin.Location = New Point(513, 426)
        lblUserLogin.Name = "lblUserLogin"
        lblUserLogin.Size = New Size(41, 15)
        lblUserLogin.TabIndex = 21
        lblUserLogin.Text = "Label6"
        lblUserLogin.Visible = False
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.ForeColor = Color.White
        lblDate.Location = New Point(712, 426)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(41, 15)
        lblDate.TabIndex = 22
        lblDate.Text = "Label7"
        lblDate.Visible = False
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(618, 426)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(41, 15)
        lblTime.TabIndex = 23
        lblTime.Text = "Label8"
        lblTime.Visible = False
        ' 
        ' lblItemNum
        ' 
        lblItemNum.AutoSize = True
        lblItemNum.Location = New Point(301, 25)
        lblItemNum.Name = "lblItemNum"
        lblItemNum.Size = New Size(13, 15)
        lblItemNum.TabIndex = 24
        lblItemNum.Text = "0"
        lblItemNum.Visible = False
        ' 
        ' lbltotalqty
        ' 
        lbltotalqty.AutoSize = True
        lbltotalqty.Location = New Point(12, 19)
        lbltotalqty.Name = "lbltotalqty"
        lbltotalqty.Size = New Size(60, 15)
        lbltotalqty.TabIndex = 25
        lbltotalqty.Text = "TOTALQTY"
        lbltotalqty.Visible = False
        ' 
        ' qtycalculate
        ' 
        ' 
        ' lblpreviousqty
        ' 
        lblpreviousqty.AutoSize = True
        lblpreviousqty.Location = New Point(155, 21)
        lblpreviousqty.Name = "lblpreviousqty"
        lblpreviousqty.Size = New Size(81, 15)
        lblpreviousqty.TabIndex = 26
        lblpreviousqty.Text = "PREVIOUSQTY"
        lblpreviousqty.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(704, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(84, 30)
        Button2.TabIndex = 27
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightGray
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(416, 122)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 27)
        Button3.TabIndex = 28
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightGray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(515, 122)
        Button4.Name = "Button4"
        Button4.Size = New Size(93, 27)
        Button4.TabIndex = 29
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(txtManageItemSupplier)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnselectsupplier)
        GroupBox1.Controls.Add(txtItemName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtCategory)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtQty)
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(btnStockIn)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 39)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(774, 177)
        GroupBox1.TabIndex = 30
        GroupBox1.TabStop = False
        GroupBox1.Text = "Manage Items"
        ' 
        ' ManageItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(lblpreviousqty)
        Controls.Add(lbltotalqty)
        Controls.Add(lblItemNum)
        Controls.Add(lblTime)
        Controls.Add(lblDate)
        Controls.Add(lblUserLogin)
        Controls.Add(btnInventoryViewAll)
        Controls.Add(btnInventorySearch)
        Controls.Add(txtInventorySearch)
        Controls.Add(InventoryDatagridview)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ManageItems"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageItems"
        CType(InventoryDatagridview, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents InventoryDatagridview As DataGridView
    Friend WithEvents txtInventorySearch As TextBox
    Friend WithEvents btnInventorySearch As Button
    Friend WithEvents btnInventoryViewAll As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnStockIn As Button
    Friend WithEvents txtManageItemSupplier As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnselectsupplier As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblUserLogin As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblItemNum As Label
    Friend WithEvents lbltotalqty As Label
    Friend WithEvents qtycalculate As Timer
    Friend WithEvents lblpreviousqty As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
