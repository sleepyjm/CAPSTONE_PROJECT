Imports System.Data.SqlClient

Public Class ManageItems
    Dim mycon As SqlConnection
    Private Sub btnselectsupplier_Click(sender As Object, e As EventArgs) Handles btnselectsupplier.Click
        supplierwindow.Show
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = "IF EXISTS ( SELECT * FROM inventory WHERE ItemID = @itemid )" &
    " BEGIN" &
        " UPDATE inventory SET Qty = @totalqty WHERE ItemID = @itemid" &
        " INSERT INTO stockin ([SupplierName], [ItemName], [Category], [Qty], [Price], [Date], [Time], [UserLogin])" &
        " VALUES (@Sn, @In, @cat, @qty, @p, @d, @t, @u);" &
    " END" &
    " ELSE" &
    " BEGIN" &
        " INSERT INTO stockin ([SupplierName], [ItemName], [Category], [Qty], [Price], [Date], [Time], [UserLogin])" &
        " VALUES (@Sn, @In, @cat, @qty, @p, @d, @t, @u);" &
        " INSERT INTO inventory ([ItemName], [Category], [Qty], [Price])" &
        " VALUES (@In, @cat, @qty, @p)" &
    " END"

            Dim transaction As SqlTransaction = mycon.BeginTransaction()
            Try
                Dim cmd = New SqlCommand(query, mycon, transaction)
                cmd.Parameters.AddWithValue("@itemid", lblItemNum.Text)
                cmd.Parameters.AddWithValue("@Sn", txtManageItemSupplier.Text)
                cmd.Parameters.AddWithValue("@In", txtItemName.Text)
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
                cmd.Parameters.AddWithValue("@qty", txtQty.Text)
                cmd.Parameters.AddWithValue("@p", txtPrice.Text)
                cmd.Parameters.AddWithValue("@d", lblDate.Text)
                cmd.Parameters.AddWithValue("@t", lblTime.Text)
                cmd.Parameters.AddWithValue("@u", lblUserLogin.Text)
                cmd.Parameters.AddWithValue("@totalqty", lbltotalqty.Text)
                cmd.ExecuteNonQuery()

                transaction.Commit()

                MsgBox("Item has been Added", MsgBoxStyle.Information, "SUCCESS!")

                txtManageItemSupplier.Clear()
                txtItemName.Clear()
                txtCategory.Clear()
                txtQty.Clear()
                txtPrice.Clear()
                inventoryviewdata()
                dashboardtotalitems()
                salesmanagementinventoryviewdata()
                salesinventoryviewdata()
                mainforminventoryviewdata()
                allrefresh()

            Catch ex As Exception
                transaction.Rollback()
                MsgBox(ex.Message)
            End Try
        Finally
            mycon.Close()
        End Try

    End Sub
    Sub calculate()
        Dim qty, prevqty, totalqty As Integer
        qty = Val(txtQty.Text)
        prevqty = Val(lblpreviousqty.Text)
        totalqty = qty + prevqty
        lbltotalqty.Text = totalqty
    End Sub
    Private Sub ManageItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inventoryviewdata()
        qtycalculate.Start()

    End Sub

    Private Sub StockInDatagridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InventoryDatagridview.CellClick
        Dim i As Integer
        i = InventoryDatagridview.CurrentRow.Index
        lblItemNum.Text = InventoryDatagridview.Item(0, i).Value
        txtItemName.Text = InventoryDatagridview.Item(1, i).Value
        txtCategory.Text = InventoryDatagridview.Item(2, i).Value
        txtQty.Text = InventoryDatagridview.Item(3, i).Value
        lblpreviousqty.Text = InventoryDatagridview.Item(3, i).Value
        txtPrice.Text = InventoryDatagridview.Item(4, i).Value
        txtPrice.Enabled = False
    End Sub

    Private Sub qtycalculate_Tick(sender As Object, e As EventArgs) Handles qtycalculate.Tick
        calculate()

    End Sub

    Private Sub btnStockInSearch_Click(sender As Object, e As EventArgs) Handles btnInventorySearch.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()


        Try
            Dim query As String
            query = "SELECT * FROM inventory WHERE ItemName Like '%" + txtInventorySearch.Text + "%' OR Category Like '%" + txtInventorySearch.Text + "%'"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("inventory")
            dr.Fill(data)
            InventoryDatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory WHERE ItemName Like '%" + txtInventorySearch.Text + "%' OR Category Like '%" + txtInventorySearch.Text + "%'"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnInventoryViewAll_Click(sender As Object, e As EventArgs) Handles btnInventoryViewAll.Click
        inventoryviewdata()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            AdminLoginToDelete.ShowDialog()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtPrice.Enabled = True
        txtManageItemSupplier.Clear()
        txtItemName.Clear()
        txtCategory.Clear()
        txtQty.Clear()
        txtPrice.Clear()

    End Sub
End Class