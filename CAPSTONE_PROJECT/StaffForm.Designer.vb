<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
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
        TabControl1 = New TabControl()
        Dashboard = New TabPage()
        Button2 = New Button()
        Button1 = New Button()
        Inventory = New TabPage()
        Button5 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        SalesManagement = New TabPage()
        Button9 = New Button()
        Button8 = New Button()
        TextBox3 = New TextBox()
        Button7 = New Button()
        TextBox2 = New TextBox()
        DataGridView2 = New DataGridView()
        Button6 = New Button()
        Label2 = New Label()
        SalesReport = New TabPage()
        Button11 = New Button()
        TextBox4 = New TextBox()
        DataGridView3 = New DataGridView()
        Button10 = New Button()
        Customers = New TabPage()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        TextBox6 = New TextBox()
        Button13 = New Button()
        DataGridView4 = New DataGridView()
        TextBox5 = New TextBox()
        Label3 = New Label()
        Button12 = New Button()
        Suppliers = New TabPage()
        Button17 = New Button()
        Button18 = New Button()
        Button19 = New Button()
        TextBox7 = New TextBox()
        Button20 = New Button()
        DataGridView5 = New DataGridView()
        TextBox8 = New TextBox()
        Label4 = New Label()
        Button21 = New Button()
        Button27 = New Button()
        TabControl1.SuspendLayout()
        Dashboard.SuspendLayout()
        Inventory.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SalesManagement.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SalesReport.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        Customers.SuspendLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        Suppliers.SuspendLayout()
        CType(DataGridView5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Dashboard)
        TabControl1.Controls.Add(Inventory)
        TabControl1.Controls.Add(SalesManagement)
        TabControl1.Controls.Add(SalesReport)
        TabControl1.Controls.Add(Customers)
        TabControl1.Controls.Add(Suppliers)
        TabControl1.Location = New Point(1, 21)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(998, 475)
        TabControl1.TabIndex = 1
        ' 
        ' Dashboard
        ' 
        Dashboard.BackColor = Color.SkyBlue
        Dashboard.Controls.Add(Button2)
        Dashboard.Controls.Add(Button1)
        Dashboard.Location = New Point(4, 23)
        Dashboard.Name = "Dashboard"
        Dashboard.Padding = New Padding(3)
        Dashboard.Size = New Size(990, 448)
        Dashboard.TabIndex = 0
        Dashboard.Text = "Dashboard"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(337, 97)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 21)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(219, 97)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 21)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Inventory
        ' 
        Inventory.BackColor = Color.SkyBlue
        Inventory.Controls.Add(Button5)
        Inventory.Controls.Add(Button4)
        Inventory.Controls.Add(TextBox1)
        Inventory.Controls.Add(Label1)
        Inventory.Controls.Add(DataGridView1)
        Inventory.Location = New Point(4, 23)
        Inventory.Name = "Inventory"
        Inventory.Padding = New Padding(3)
        Inventory.Size = New Size(990, 448)
        Inventory.TabIndex = 2
        Inventory.Text = "Inventory"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(366, 7)
        Button5.Name = "Button5"
        Button5.Size = New Size(86, 21)
        Button5.TabIndex = 5
        Button5.Text = "View All"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(258, 7)
        Button4.Name = "Button4"
        Button4.Size = New Size(86, 21)
        Button4.TabIndex = 4
        Button4.Text = "Search"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(118, 7)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 22)
        TextBox1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 14)
        Label1.TabIndex = 2
        Label1.Text = "Search :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightGray
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(7, 35)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(975, 316)
        DataGridView1.TabIndex = 1
        ' 
        ' SalesManagement
        ' 
        SalesManagement.BackColor = Color.SkyBlue
        SalesManagement.Controls.Add(Button9)
        SalesManagement.Controls.Add(Button8)
        SalesManagement.Controls.Add(TextBox3)
        SalesManagement.Controls.Add(Button7)
        SalesManagement.Controls.Add(TextBox2)
        SalesManagement.Controls.Add(DataGridView2)
        SalesManagement.Controls.Add(Button6)
        SalesManagement.Controls.Add(Label2)
        SalesManagement.Location = New Point(4, 23)
        SalesManagement.Name = "SalesManagement"
        SalesManagement.Padding = New Padding(3)
        SalesManagement.Size = New Size(990, 448)
        SalesManagement.TabIndex = 3
        SalesManagement.Text = "Sales Management"
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button9.Location = New Point(819, 360)
        Button9.Name = "Button9"
        Button9.Size = New Size(86, 35)
        Button9.TabIndex = 7
        Button9.Text = "New"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button8.Location = New Point(819, 307)
        Button8.Name = "Button8"
        Button8.Size = New Size(86, 35)
        Button8.TabIndex = 6
        Button8.Text = "OK"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(87, 357)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(114, 22)
        TextBox3.TabIndex = 5
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(262, 6)
        Button7.Name = "Button7"
        Button7.Size = New Size(86, 21)
        Button7.TabIndex = 4
        Button7.Text = "View All"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(19, 7)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 22)
        TextBox2.TabIndex = 3
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.LightGray
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(19, 48)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(752, 294)
        DataGridView2.TabIndex = 2
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(152, 6)
        Button6.Name = "Button6"
        Button6.Size = New Size(86, 21)
        Button6.TabIndex = 1
        Button6.Text = "Search"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 360)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 14)
        Label2.TabIndex = 0
        Label2.Text = "Label2"
        ' 
        ' SalesReport
        ' 
        SalesReport.BackColor = Color.SkyBlue
        SalesReport.Controls.Add(Button11)
        SalesReport.Controls.Add(TextBox4)
        SalesReport.Controls.Add(DataGridView3)
        SalesReport.Controls.Add(Button10)
        SalesReport.Location = New Point(4, 23)
        SalesReport.Name = "SalesReport"
        SalesReport.Padding = New Padding(3)
        SalesReport.Size = New Size(990, 448)
        SalesReport.TabIndex = 4
        SalesReport.Text = "Sales Report"
        ' 
        ' Button11
        ' 
        Button11.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button11.Location = New Point(848, 368)
        Button11.Name = "Button11"
        Button11.Size = New Size(90, 55)
        Button11.TabIndex = 7
        Button11.Text = "Create PDF"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(21, 22)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(176, 22)
        TextBox4.TabIndex = 6
        ' 
        ' DataGridView3
        ' 
        DataGridView3.BackgroundColor = Color.LightGray
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(21, 55)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowTemplate.Height = 25
        DataGridView3.Size = New Size(949, 295)
        DataGridView3.TabIndex = 5
        ' 
        ' Button10
        ' 
        Button10.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button10.Location = New Point(203, 13)
        Button10.Name = "Button10"
        Button10.Size = New Size(91, 36)
        Button10.TabIndex = 4
        Button10.Text = "Search"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Customers
        ' 
        Customers.BackColor = Color.SkyBlue
        Customers.Controls.Add(Button16)
        Customers.Controls.Add(Button15)
        Customers.Controls.Add(Button14)
        Customers.Controls.Add(TextBox6)
        Customers.Controls.Add(Button13)
        Customers.Controls.Add(DataGridView4)
        Customers.Controls.Add(TextBox5)
        Customers.Controls.Add(Label3)
        Customers.Controls.Add(Button12)
        Customers.Location = New Point(4, 23)
        Customers.Name = "Customers"
        Customers.Padding = New Padding(3)
        Customers.Size = New Size(990, 448)
        Customers.TabIndex = 5
        Customers.Text = "Customers"
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button16.Location = New Point(815, 391)
        Button16.Name = "Button16"
        Button16.Size = New Size(85, 40)
        Button16.TabIndex = 8
        Button16.Text = "Delete"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button15.Location = New Point(723, 391)
        Button15.Name = "Button15"
        Button15.Size = New Size(86, 40)
        Button15.TabIndex = 7
        Button15.Text = "Update"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(321, 14)
        Button14.Name = "Button14"
        Button14.Size = New Size(86, 21)
        Button14.TabIndex = 6
        Button14.Text = "View All"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(48, 14)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(114, 22)
        TextBox6.TabIndex = 5
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(213, 13)
        Button13.Name = "Button13"
        Button13.Size = New Size(86, 21)
        Button13.TabIndex = 4
        Button13.Text = "Search"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' DataGridView4
        ' 
        DataGridView4.BackgroundColor = Color.LightGray
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Location = New Point(19, 41)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.RowTemplate.Height = 25
        DataGridView4.Size = New Size(945, 336)
        DataGridView4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(95, 383)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(114, 22)
        TextBox5.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 391)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 14)
        Label3.TabIndex = 1
        Label3.Text = "Label3"
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button12.Location = New Point(637, 391)
        Button12.Name = "Button12"
        Button12.Size = New Size(80, 40)
        Button12.TabIndex = 0
        Button12.Text = "Add"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Suppliers
        ' 
        Suppliers.BackColor = Color.SkyBlue
        Suppliers.Controls.Add(Button17)
        Suppliers.Controls.Add(Button18)
        Suppliers.Controls.Add(Button19)
        Suppliers.Controls.Add(TextBox7)
        Suppliers.Controls.Add(Button20)
        Suppliers.Controls.Add(DataGridView5)
        Suppliers.Controls.Add(TextBox8)
        Suppliers.Controls.Add(Label4)
        Suppliers.Controls.Add(Button21)
        Suppliers.Location = New Point(4, 23)
        Suppliers.Name = "Suppliers"
        Suppliers.Padding = New Padding(3)
        Suppliers.Size = New Size(990, 448)
        Suppliers.TabIndex = 6
        Suppliers.Text = "Suppliers"
        ' 
        ' Button17
        ' 
        Button17.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button17.Location = New Point(859, 403)
        Button17.Name = "Button17"
        Button17.Size = New Size(80, 38)
        Button17.TabIndex = 17
        Button17.Text = "Delete"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button18
        ' 
        Button18.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button18.Location = New Point(766, 403)
        Button18.Name = "Button18"
        Button18.Size = New Size(87, 39)
        Button18.TabIndex = 16
        Button18.Text = "Update"
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button19
        ' 
        Button19.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button19.Location = New Point(304, 13)
        Button19.Name = "Button19"
        Button19.Size = New Size(80, 31)
        Button19.TabIndex = 15
        Button19.Text = "View All"
        Button19.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(48, 13)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(159, 22)
        TextBox7.TabIndex = 14
        ' 
        ' Button20
        ' 
        Button20.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button20.Location = New Point(213, 11)
        Button20.Name = "Button20"
        Button20.Size = New Size(85, 33)
        Button20.TabIndex = 13
        Button20.Text = "Search"
        Button20.UseVisualStyleBackColor = True
        ' 
        ' DataGridView5
        ' 
        DataGridView5.BackgroundColor = Color.LightGray
        DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView5.Location = New Point(19, 50)
        DataGridView5.Name = "DataGridView5"
        DataGridView5.RowTemplate.Height = 25
        DataGridView5.Size = New Size(945, 334)
        DataGridView5.TabIndex = 12
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(94, 393)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(114, 22)
        TextBox8.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 393)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 14)
        Label4.TabIndex = 10
        Label4.Text = "Label4"
        ' 
        ' Button21
        ' 
        Button21.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button21.Location = New Point(667, 403)
        Button21.Name = "Button21"
        Button21.Size = New Size(93, 39)
        Button21.TabIndex = 9
        Button21.Text = "Add"
        Button21.UseVisualStyleBackColor = True
        ' 
        ' Button27
        ' 
        Button27.Location = New Point(902, 11)
        Button27.Name = "Button27"
        Button27.Size = New Size(86, 21)
        Button27.TabIndex = 28
        Button27.Text = "LOGOUT"
        Button27.UseVisualStyleBackColor = True
        ' 
        ' StaffForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(1013, 497)
        Controls.Add(Button27)
        Controls.Add(TabControl1)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "StaffForm"
        Text = "StaffForm"
        TabControl1.ResumeLayout(False)
        Dashboard.ResumeLayout(False)
        Inventory.ResumeLayout(False)
        Inventory.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        SalesManagement.ResumeLayout(False)
        SalesManagement.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        SalesReport.ResumeLayout(False)
        SalesReport.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        Customers.ResumeLayout(False)
        Customers.PerformLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        Suppliers.ResumeLayout(False)
        Suppliers.PerformLayout()
        CType(DataGridView5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Dashboard As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Inventory As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SalesManagement As TabPage
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SalesReport As TabPage
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button10 As Button
    Friend WithEvents Customers As TabPage
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button13 As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Suppliers As TabPage
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button20 As Button
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button21 As Button
    Friend WithEvents Button27 As Button
End Class
