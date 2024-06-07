Imports System.Data.SqlClient
Public Class supplierwindow
    Dim mycon As New SqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        Me.Close()
    End Sub

    Private Sub supplierwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectsuppviewdata()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles suppwindowdatagridview.CellClick
        Dim i As Integer
        i = suppwindowdatagridview.CurrentRow.Index
        ManageItems.txtManageItemSupplier.Text = suppwindowdatagridview.Item(1, i).Value
    End Sub

    Private Sub btnsuppwindowsearch_Click(sender As Object, e As EventArgs) Handles btnsuppwindowsearch.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()

        Try
            Dim query As String
            query = "SELECT * FROM suppliers WHERE Name LIKE '%" + txtsuppwindowsearch.Text + "%' OR CustomersID = '" + txtsuppwindowsearch.Text + "'"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("suppliers")
            dr.Fill(data)
            suppwindowdatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM suppliers WHERE Name LIKE '%" + txtsuppwindowsearch.Text + "%' OR CustomersID = '" + txtsuppwindowsearch.Text + "'"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtsuppwindowsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsuppwindowsearch.TextChanged

    End Sub

    Private Sub suppwindowdatagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles suppwindowdatagridview.CellContentClick

    End Sub
End Class