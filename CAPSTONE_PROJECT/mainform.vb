Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class mainform
    Dim mycon As SqlConnection




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then

            TabControl1.SelectedIndex += 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then

            TabControl1.SelectedIndex += 2
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnmanageitems.Click
        ManageItems.Show()

    End Sub

    Private Sub btnCusAdd_Click(sender As Object, e As EventArgs) Handles btnCusAdd.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = " INSERT INTO customers ([Name],[Address],[ContactNum]) VALUES (@Name,@Address,@ContactNum)"
            Dim cmd = New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@Name", txtcusname.Text)
            cmd.Parameters.AddWithValue("@Address", txtcusadd.Text)
            cmd.Parameters.AddWithValue("@ContactNum", txtcusnum.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Customers info has been Added", MsgBoxStyle.Information, "SUCCESS!")
            txtcusname.Clear()
            txtcusadd.Clear()
            txtcusnum.Clear()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCusUpdate_Click(sender As Object, e As EventArgs) Handles btnCusUpdate.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = " UPDATE customers SET Name=@Name,Address=@Address,ContactNum=@ContactNum WHERE CustomersID=@ID"
            Dim cmd = New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@ID", lblcusID.Text)
            cmd.Parameters.AddWithValue("@Name", txtcusname.Text)
            cmd.Parameters.AddWithValue("@Address", txtcusadd.Text)
            cmd.Parameters.AddWithValue("@ContactNum", txtcusnum.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Customers info has been Updated", MsgBoxStyle.Information, "SUCCESS!")
            txtcusname.Clear()
            txtcusadd.Clear()
            txtcusnum.Clear()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CustomersCLicked(sender As Object, e As DataGridViewCellEventArgs) Handles CustomersDataView.CellClick
        Dim i As Integer
        i = CustomersDataView.CurrentRow.Index
        lblcusID.Text = CustomersDataView.Item(0, i).Value
        txtcusname.Text = CustomersDataView.Item(1, i).Value
        txtcusadd.Text = CustomersDataView.Item(2, i).Value
        txtcusnum.Text = CustomersDataView.Item(3, i).Value
        txtCusSearch.Clear()

    End Sub

    Private Sub BtnCusDel_Click(sender As Object, e As EventArgs) Handles btnCusDel.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' Code to execute if the user clicks Yes
            Try
                Dim query As String
                query = "DELETE FROM customers WHERE CustomersID='" + txtCusSearch.Text + "'"
                Dim cmd = New SqlCommand(query, mycon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Customer has been Deleted", MsgBoxStyle.Information, "Success")

                txtCusSearch.Clear()
                txtcusname.Clear()
                txtcusadd.Clear()
                txtcusnum.Clear()
                cusviewdata()
                mycon.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CusSearch_Click(sender As Object, e As EventArgs) Handles CusSearch.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        txtcusname.Clear()
        txtcusadd.Clear()
        txtcusnum.Clear()
        Try
            Dim query As String
            query = "SELECT * FROM customers WHERE Name LIKE '%" + txtCusSearch.Text + "%' OR CustomersID = '" + txtCusSearch.Text + "'"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("customers")
            dr.Fill(data)
            CustomersDataView.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM customers WHERE Name LIKE '%" + txtCusSearch.Text + "%' OR CustomersID = '" + txtCusSearch.Text + "'"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        cusviewdata()
        txtCusSearch.Clear()
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainforminventoryviewdata()
        cusviewdata()
        suppviewdata()
        usersviewdata()
        salesmanagementinventoryviewdata()
        'salescalculate()
        stockoutviewdata()
        dashboardtotalitems()
        dailysales()
        dashboardlowstocks()



        txtCusSearch.Clear()
        txtcusname.Clear()
        txtcusadd.Clear()
        txtcusnum.Clear()



    End Sub

    Private Sub btnsuppsearch_Click(sender As Object, e As EventArgs) Handles btnsuppsearch.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        txtsuppname.Clear()
        txtsuppnum.Clear()

        Try
            Dim query As String
            query = "SELECT * FROM suppliers WHERE SupplierName LIKE '%" + txtsuppsearch.Text + "%' OR SupplierID = '" + txtsuppsearch.Text + "'"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("suppliers")
            dr.Fill(data)
            supplierdataview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM suppliers WHERE SupplierName LIKE '%" + txtsuppsearch.Text + "%' OR SupplierID = '" + txtsuppsearch.Text + "'"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnsuppviewall_Click(sender As Object, e As EventArgs) Handles btnsuppviewall.Click
        suppviewdata()
        txtsuppsearch.Clear()
    End Sub

    Private Sub btnsuppAdd_Click(sender As Object, e As EventArgs) Handles btnsuppAdd.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = " INSERT INTO suppliers ([SupplierName],[ContactNum]) VALUES (@SupplierName,@ContactNum)"
            Dim cmd = New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@SupplierName", txtsuppname.Text)
            cmd.Parameters.AddWithValue("@ContactNum", txtsuppnum.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Supplier info has been Added", MsgBoxStyle.Information, "SUCCESS!")
            txtsuppname.Clear()
            txtsuppnum.Clear()
            suppviewdata()

            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsuppUpdate_Click(sender As Object, e As EventArgs) Handles btnsuppUpdate.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = " UPDATE suppliers SET SupplierName=@SupplierName,ContactNum=@ContactNum WHERE SupplierID=@ID"
            Dim cmd = New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@ID", lblsuppID.Text)
            cmd.Parameters.AddWithValue("@SupplierName", txtsuppname.Text)
            cmd.Parameters.AddWithValue("@ContactNum", txtsuppnum.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Supplier has been Updated", MsgBoxStyle.Information, "SUCCESS!")
            txtsuppname.Clear()
            txtsuppnum.Clear()
            lblsuppID.Text = ""
            suppviewdata()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsuppDel_Click(sender As Object, e As EventArgs) Handles btnsuppDel.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Dim query As String
                query = "DELETE FROM suppliers WHERE SupplierID='" + lblsuppID.Text + "'"
                Dim cmd = New SqlCommand(query, mycon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Supplier information has been Deleted", MsgBoxStyle.Information, "Success")

                txtsuppname.Clear()
                txtsuppnum.Clear()
                lblsuppID.Text = ""

                suppviewdata()
                mycon.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub supplierclicked(sender As Object, e As DataGridViewCellEventArgs) Handles supplierdataview.CellContentClick
        Dim i As Integer
        i = supplierdataview.CurrentRow.Index
        lblsuppID.Text = supplierdataview.Item(0, i).Value
        txtsuppname.Text = supplierdataview.Item(1, i).Value
        txtsuppnum.Text = supplierdataview.Item(2, i).Value
        txtsuppsearch.Clear()
    End Sub

    Private Sub btnUsersAdd_Click(sender As Object, e As EventArgs) Handles btnUsersAdd.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = " INSERT INTO users ([Position],[Username],[Password],[ContactNum],[Address]) VALUES (@Position,@Username,@Password,@ContactNum,@Address)"
            Dim cmd = New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@Position", comboboxuserpos.Text)
            cmd.Parameters.AddWithValue("@Username", txtUsersUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtUsersPass.Text)
            cmd.Parameters.AddWithValue("@ContactNum", txtUsersNum.Text)
            cmd.Parameters.AddWithValue("@Address", txtUsersAddress.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("User has been Added", MsgBoxStyle.Information, "SUCCESS!")
            comboboxuserpos.Text = ""
            txtUsersUsername.Clear()
            txtUsersPass.Clear()
            txtUsersNum.Clear()
            txtUsersAddress.Clear()

            usersviewdata()

            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUsersUpdate_Click(sender As Object, e As EventArgs) Handles btnUsersUpdate.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = " UPDATE users SET Position=@Position,Username=@Username,Password=@Password,ContactNum=@ContactNum,Address=@Address WHERE UserID=@ID"
            Dim cmd = New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@ID", lbluserID.Text)
            cmd.Parameters.AddWithValue("@Position", comboboxuserpos.Text)
            cmd.Parameters.AddWithValue("@Username", txtUsersUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtUsersPass.Text)
            cmd.Parameters.AddWithValue("@ContactNum", txtUsersNum.Text)
            cmd.Parameters.AddWithValue("@Address", txtUsersAddress.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("User has been Updated", MsgBoxStyle.Information, "SUCCESS!")
            txtUsersUsername.Clear()
            txtUsersPass.Clear()
            lbluserID.Text = ""
            txtUsersNum.Clear()
            txtUsersAddress.Clear()
            comboboxuserpos.Text = ""
            usersviewdata()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUsersDelete_Click(sender As Object, e As EventArgs) Handles btnUsersDelete.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Dim query As String
                query = "DELETE FROM users WHERE UserID='" + lbluserID.Text + "'"
                Dim cmd = New SqlCommand(query, mycon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("User has been Deleted", MsgBoxStyle.Information, "Success")
                txtUsersUsername.Clear()
                txtUsersPass.Clear()
                lbluserID.Text = ""
                txtUsersNum.Clear()
                txtUsersAddress.Clear()
                comboboxuserpos.Text = ""
                usersviewdata()
                mycon.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUsersSearch_Click(sender As Object, e As EventArgs) Handles btnUsersSearch.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        txtUsersUsername.Clear()
        txtUsersPass.Clear()
        txtUsersNum.Clear()
        txtUsersAddress.Clear()


        Try
            Dim query As String
            query = "SELECT * FROM users WHERE Username LIKE '%" + txtUserSearch.Text + "%' OR UserID = '" + txtUserSearch.Text + "'"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("users")
            dr.Fill(data)
            UsersDataView.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM users WHERE Username LIKE '%" + txtUserSearch.Text + "%' OR UserID = '" + txtUserSearch.Text + "'"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUsersViewAll_Click(sender As Object, e As EventArgs) Handles btnUsersViewAll.Click
        usersviewdata()
        txtUsersUsername.Clear()
        txtUsersPass.Clear()
        lbluserID.Text = ""
        txtUsersNum.Clear()
        txtUsersAddress.Clear()
        comboboxuserpos.Text = ""
        txtUserSearch.Clear()

    End Sub

    Private Sub UsersDataView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataView.CellClick
        Dim i As Integer
        i = UsersDataView.CurrentRow.Index
        lbluserID.Text = UsersDataView.Item(0, i).Value
        comboboxuserpos.Text = UsersDataView.Item(1, i).Value
        txtUsersUsername.Text = UsersDataView.Item(2, i).Value
        txtUsersPass.Text = UsersDataView.Item(3, i).Value
        txtUsersNum.Text = UsersDataView.Item(4, i).Value
        txtUsersAddress.Text = UsersDataView.Item(5, i).Value
        txtUserSearch.Clear()
    End Sub

    Private Sub btnlowstocks_Click(sender As Object, e As EventArgs) Handles btnlowstocks.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()


        Try
            Dim query As String
            query = "SELECT * FROM inventory WHERE Qty <= 10 "
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("inventory")
            dr.Fill(data)
            inventoryview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory WHERE Qty <= 10"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btninventoryViewAll_Click(sender As Object, e As EventArgs) Handles btninventoryViewAll.Click
        mainforminventoryviewdata()

    End Sub

    Private Sub btnShowCusWindow_Click(sender As Object, e As EventArgs) Handles btnShowCusWindow.Click
        customerwindow.ShowDialog()

    End Sub



    Private Sub sales(sender As Object, e As DataGridViewCellEventArgs) Handles salesmanagementInventorydatagridview.CellClick

        Dim i As Integer
        i = salesmanagementInventorydatagridview.CurrentRow.Index
        ITEMID.Text = salesmanagementInventorydatagridview.Item(0, i).Value
        pangalan.Text = salesmanagementInventorydatagridview.Item(1, i).Value
        categ.Text = salesmanagementInventorydatagridview.Item(2, i).Value
        InputQty.Item1currentqty.Text = salesmanagementInventorydatagridview.Item(3, i).Value
        InputQty.Price.Text = salesmanagementInventorydatagridview.Item(4, i).Value

        InputQty.ShowDialog()

        'Item1.Text = salesmanagementInventorydatagridview.Item(1, i).Value
        'Itemcat1.Text = salesmanagementInventorydatagridview.Item(2, i).Value
        'Itemqty1.Text = txtsalesQty.Text


        'Dim total, finalprice, itemqty, price As Integer
        'itemqty = Val(Itemqty1.Text)
        'price = Val(Itemprice1.Text)

        'finalprice = itemqty * price
        'Item1finalprice.Text = finalprice
        'total = finalprice
        'Itemtotalprice.Text = total
        'Dim a, b, c As Integer
        'a = Val(Item1currentqty.Text)
        'b = Val(Itemqty1.Text)
        'c = a - b

        'Item1finalqty.Text = c




    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        txtcusname.Clear()
        txtcusadd.Clear()
        txtcusnum.Clear()
        Try
            Dim query As String
            query = "SELECT * FROM inventory WHERE ItemName LIKE '%" + txtsalessearch.Text + "%' OR Category LIKE '%" + txtsalessearch.Text + "%'"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("customers")
            dr.Fill(data)
            salesmanagementInventorydatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory WHERE ItemName LIKE '%" + txtsalessearch.Text + "%' OR Category LIKE '%" + txtsalessearch.Text + "%'"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        salesinventoryviewdata()
    End Sub

    Private Sub btnconfirmsale_Click(sender As Object, e As EventArgs) Handles btnconfirmsale.Click

        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = " INSERT INTO stockout ([ItemName],[Category],[TotalPrice],[Date],[UserLogin]) VALUES (@item,@cat,@tp,@d,@u)" &
             "UPDATE inventory SET Qty=@finalqty WHERE ItemID=@ID"
            Dim cmd = New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@ID", ITEMID.Text)
            cmd.Parameters.AddWithValue("@cat", categ.Text)
            cmd.Parameters.AddWithValue("@item", pangalan.Text)
            cmd.Parameters.AddWithValue("@tp", InputQty.tprice.Text)
            cmd.Parameters.AddWithValue("@d", mainformdate.Text)
            cmd.Parameters.AddWithValue("@u", lblUserLogin.Text)
            cmd.Parameters.AddWithValue("@finalqty", Itemfinalqty.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            '    PrintPreviewDialog1.Document = PrintDocument1
            '    PrintPreviewDialog1.ShowDialog()
            '    PrintDocument1.Print()
            mainforminventoryviewdata()
            dailysales()
            stockoutviewdata()
            salesinventoryviewdata()
            salesmanagementinventoryviewdata()
            updateinventoryviewdata()
            MsgBox("Item has been Updated", MsgBoxStyle.Information, "Success")

            mycon.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim paperSize As New PaperSize("A4", 215, 1889) '4 paper size in pixels
        'PrintDocument1.DefaultPageSettings.PaperSize = paperSize

        'Dim panelSize As New Size(Panel1.Width, Panel1.Height)
        'Dim scale As Single = Math.Min(paperSize.Width / panelSize.Width, paperSize.Height / panelSize.Height)

        'Using bmp As New Bitmap(panelSize.Width, panelSize.Height)
        '    Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, panelSize.Width, panelSize.Height))

        '    Dim g As Graphics = e.Graphics
        '    g.ScaleTransform(scale, scale)
        '    g.DrawImage(bmp, e.PageBounds.Location)
        'End Using

    End Sub

    Private Sub btnstockoutsearch_Click(sender As Object, e As EventArgs) Handles btnstockoutsearch.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try


            Dim query As String
            query = "SELECT * FROM stockout WHERE Itemname = '" + txtstockoutsearch.Text + "' OR
                 Category = '" + txtstockoutsearch.Text + "' OR
                 Date LIKE '%" + txtstockoutsearch.Text + "%' OR
                 UserLogin LIKE '%" + txtstockoutsearch.Text + "%'" &
                 "SELECT SUM(TotalPrice) AS Total FROM stockout"

            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("stockout")
            dr.Fill(data)
            Stockoutdatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM stockout WHERE Itemname = '" + txtstockoutsearch.Text + "' OR
                 Category = '" + txtstockoutsearch.Text + "' OR
                 Date LIKE '%" + txtstockoutsearch.Text + "%' OR
                 UserLogin LIKE '%" + txtstockoutsearch.Text + "%'" &
                 "SELECT SUM(TotalPrice) AS Total FROM stockout"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnstockoutprint_Click(sender As Object, e As EventArgs) Handles btnstockoutprint.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try


            Dim query As String
            query = "SELECT * FROM stockout WHERE Itemname = '" + txtstockoutsearch.Text + "' OR
                 Category = '" + txtstockoutsearch.Text + "' OR
                 Date LIKE '%" + txtstockoutsearch.Text + "%' OR
                 UserLogin = '" + txtstockoutsearch.Text + "'" &
                 "SELECT SUM(TotalPrice) FROM stockout WHERE Date Like '%" + txtstockoutsearch.Text + "%'"


            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("stockout")
            dr.Fill(data)
            Stockoutdatagridview.DataSource = data
            SalesReportPrintPreviewDialog.Document = SalesReportDocument
            SalesReportPrintPreviewDialog.ShowDialog()
            Dim sql1 As String
            sql1 = "SELECT * FROM stockout WHERE Itemname = '" + txtstockoutsearch.Text + "' OR
                 Category = '" + txtstockoutsearch.Text + "' OR
                 Date LIKE '%" + txtstockoutsearch.Text + "%' OR
                 UserLogin = '" + txtstockoutsearch.Text + "'" &
                 "SELECT SUM(TotalPrice) AS Total FROM stockout"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader = cmd.ExecuteReader
            myreader.Read()

            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SalesReportDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles SalesReportDocument.PrintPage
        Dim rect As New Rectangle(Stockoutdatagridview.Location.X, Stockoutdatagridview.Location.Y, Stockoutdatagridview.Width, Stockoutdatagridview.Height)

        ' Print the content of the DataGridView
        Stockoutdatagridview.DrawToBitmap(New Bitmap(Stockoutdatagridview.Width, Stockoutdatagridview.Height), rect)
        Dim g As Graphics = e.Graphics

        ' Get the size of the panel.
        Dim Stockout As Size = Stockoutdatagridview.Size

        ' Create a bitmap to hold the panel's contents.
        Using bmp As New Bitmap(Stockout.Width, Stockout.Height)
            ' Draw the panel onto the bitmap.
            Stockoutdatagridview.DrawToBitmap(bmp, New Rectangle(0, 0, Stockout.Width, Stockout.Height))

            ' Draw the bitmap onto the print page.
            g.DrawImage(bmp, e.PageBounds.Location)
        End Using

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        loginform.Show()

        loginform.txtusername.Text = ""
        loginform.txtpassword.Text = ""
        Me.Close()

    End Sub

    Private Sub btnUpdatePriceInventory_Click(sender As Object, e As EventArgs) Handles btnUpdatePriceInventory.Click
        inventoryupdate.ShowDialog()

    End Sub

    Private Sub Suppliers_Click(sender As Object, e As EventArgs) Handles Suppliers.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try

            Dim startDate As Date = DateTimePicker1.Value.Date
            Dim endDate As Date = DateTimePicker2.Value.Date

            Dim query As String = "SELECT * FROM stockout WHERE Date BETWEEN @StartDate AND @EndDate ORDER BY Date ASC"

            Dim cmd As New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@StartDate", startDate)
            cmd.Parameters.AddWithValue("@EndDate", endDate)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Stockoutdatagridview.DataSource = dataTable
            mycon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnloginhistory_Click(sender As Object, e As EventArgs) Handles btnloginhistory.Click
        loginhistory.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        void.ShowDialog()
        'voidviewdata()
    End Sub

    Private Sub txtsalesQty_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcusadd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcusadd.KeyPress

    End Sub

    Private Sub txtcusname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcusname.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUsersNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsersNum.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
            If txtUsersNum.Text.Length >= 11 Then 'et the limit to 10 characters
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        txtcusname.Text = ""
        txtcusnum.Text = ""
        txtcusadd.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtsuppname.Text = ""
        txtsuppnum.Text = ""

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        comboboxuserpos.Text = ""
        txtUsersUsername.Clear()
        txtUsersPass.Clear()
        txtUsersNum.Clear()
        txtUsersAddress.Clear()

    End Sub

    Private Sub supplierdataview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles supplierdataview.CellClick
        Dim i As Integer
        i = supplierdataview.CurrentRow.Index
        lblsuppID.Text = supplierdataview.Item(0, i).Value
        txtsuppname.Text = supplierdataview.Item(1, i).Value
        txtsuppnum.Text = supplierdataview.Item(2, i).Value
        txtsuppsearch.Clear()
    End Sub

    Private Sub txtcusnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcusnum.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
            If txtcusnum.Text.Length >= 11 Then 'et the limit to 10 characters
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtsuppnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsuppnum.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
            If txtsuppnum.Text.Length >= 11 Then 'et the limit to 10 characters
                e.Handled = True
            End If
        End If
    End Sub
End Class