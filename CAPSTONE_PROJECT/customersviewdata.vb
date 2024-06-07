Imports System.Data.SqlClient
Module customersviewdata
    Dim mycon As SqlConnection




    Sub cuswindowviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM customers"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("customers")
            dr.Fill(data)
            customerwindow.cuswindowdatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM customers"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cusviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM customers"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("customers")
            dr.Fill(data)
            mainform.CustomersDataView.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM customers"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub suppviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM suppliers"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("suppliers")
            dr.Fill(data)
            mainform.supplierdataview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM suppliers"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub selectsuppviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM suppliers"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("suppliers")
            dr.Fill(data)
            supplierwindow.suppwindowdatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM suppliers"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub usersviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM users"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("users")
            dr.Fill(data)
            mainform.UsersDataView.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM users"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub stockinviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM stockin"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("stockin")
            dr.Fill(data)
            ManageItems.InventoryDatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM stockin"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub inventoryviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM inventory"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("inventory")
            dr.Fill(data)
            ManageItems.InventoryDatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub mainforminventoryviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM inventory"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("inventory")
            dr.Fill(data)
            mainform.inventoryview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub salesmanagementinventoryviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM inventory"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("inventory")
            dr.Fill(data)
            mainform.salesmanagementInventorydatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Sub salescalculate()
    '    Dim item1, item2, item3, total As Integer
    '    item1 = Val(mainform.Itemprice1.Text)
    '    item2 = Val(mainform.Itemprice1.Text)
    '    'item3 = Val(mainform.Itemprice3.Text)
    '    total = item1 + item2 + item3
    '    mainform.Itemtotalprice.Text = total
    'End Sub
    Sub salesinventoryviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM inventory"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("inventory")
            dr.Fill(data)
            mainform.salesmanagementInventorydatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub stockoutviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT No, ItemName, Category, TotalPrice, Date, UserLogin FROM stockout"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("stockout")
            dr.Fill(data)
            mainform.Stockoutdatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT No, ItemName, Category, TotalPrice, Date, UserLogin FROM stockout"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub updateinventoryviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM inventory"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("inventory")
            dr.Fill(data)
            inventoryupdate.invupdatedatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub searchdate()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try


            Dim query As String
            query = "SELECT * FROM stockout WHERE Date BETWEEN @StartDate= '" + mainform.DateTimePicker1.Value + "' AND @EndDate= '" + mainform.DateTimePicker2.Value + "' ORDDER BY Date DESC"
            Dim cmd As New SqlCommand(query, mycon)
            cmd.Parameters.Add("StartDate", SqlDbType.DateTime).Value = mainform.DateTimePicker1.Value
            cmd.Parameters.Add("EndDate", SqlDbType.DateTime).Value = mainform.DateTimePicker2.Value
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("stockout")
            dr.Fill(data)
            mainform.Stockoutdatagridview.DataSource = data
            Dim myreader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub dashboardtotalitems()
        mycon = New SqlConnection(My.Settings.connection)
        Dim query As String = "SELECT COUNT(*) FROM inventory"

        mycon.Open()

        Using cmd As New SqlCommand(query, mycon)

            ' Execute the query
            Dim count As Integer = CInt(cmd.ExecuteScalar())

            ' Now count contains the result of the COUNT query
            mainform.lbltotalitems.Text = count

        End Using

    End Sub

    Sub dashboardlowstocks()
        mycon = New SqlConnection(My.Settings.connection)
        Dim query As String = "SELECT COUNT(*) FROM inventory WHERE Qty <= 10"

        mycon.Open()

        Using cmd As New SqlCommand(query, mycon)

            ' Execute the query
            Dim count As Integer = CInt(cmd.ExecuteScalar())

            ' Now count contains the result of the COUNT query
            mainform.Label12.Text = count

        End Using
    End Sub
    Sub loginhistoryviewall()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM userlogin"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("userlogin")
            dr.Fill(data)
            loginhistory.loginhistorydatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM userlogin"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub dailysales()
        ' Create a connection to the database
        Dim connectionString As String = My.Settings.connection
        Dim connection As New SqlConnection(connectionString)

        ' Define the date for which you want to get the sum of TotalPrice
        Dim dateParameter As New SqlParameter("@date", SqlDbType.Date)
        dateParameter.Value = DateTime.Today ' Set the date to today's date

        ' Create a command to retrieve the sales data for the specified date
        Dim command As New SqlCommand("SELECT SUM(TotalPrice) AS DailySaleIncome FROM stockout WHERE Date = @date", connection)
        command.Parameters.Add(dateParameter)

        ' Execute the command and get the result
        connection.Open()
        Dim result As Object = command.ExecuteScalar()
        Dim dailySaleIncome As Decimal = If(result IsNot DBNull.Value, CType(result, Decimal), 0)
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        ' Display the daily sale income in the label
        mainform.lbldailysales.Text = dailySaleIncome.ToString("#,##0.00")

        '' Get the current date
        'Dim currentDate As Date = Date.Today

        '' Create a connection to the database
        'Dim connectionString As String = My.Settings.connection
        'Dim connection As New SqlConnection(connectionString)

        '' Create a command to retrieve the sales data for the current date
        'Dim command As New SqlCommand("SELECT SUM(TotalPrice) AS DailySaleIncome FROM stockout WHERE Date = @SaleDate", connection)
        'command.Parameters.AddWithValue("@SaleDate", currentDate)

        '' Execute the command and get the result
        'connection.Open()
        'Dim result As Object = command.ExecuteScalar()
        'Dim dailySaleIncome As Decimal = If(result IsNot DBNull.Value, CType(result, Decimal), 0)
        'If connection.State = ConnectionState.Open Then
        '    connection.Close()
        'End If

        '' Display the daily sale income in the label
        'mainform.lbldailysales.Text = dailySaleIncome.ToString("#,##0.00")
    End Sub
    Sub voidviewdata()
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT [No],[OR_NO],[TotalPrice],[Date] FROM stockout"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("stockout")
            dr.Fill(data)
            void.voiddatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT [No],[OR_NO],[TotalPrice],[Date] FROM stockout"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)

            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub allrefresh()
        mainforminventoryviewdata()
        dailysales()
        loginhistoryviewall()
        dashboardtotalitems()
        searchdate()
        updateinventoryviewdata()
        stockoutviewdata()
        salesinventoryviewdata()
        salesmanagementinventoryviewdata()
        mainforminventoryviewdata()
        inventoryviewdata()
        stockinviewdata()
        usersviewdata()
        selectsuppviewdata()
        suppviewdata()
        cusviewdata()
        cuswindowviewdata()
        dashboardlowstocks()
    End Sub
End Module
