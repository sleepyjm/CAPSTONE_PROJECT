Imports System.Data.SqlClient

Public Class customerwindow
    Dim mycon As SqlConnection
    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles cuswindowdatagridview.CellClick
        'Dim i As Integer
        'i = cuswindowdatagridview.CurrentRow.Index
        'mainform.lblcusname.Text = cuswindowdatagridview.Item(1, i).Value
        'mainform.lblcusadd.Text = cuswindowdatagridview.Item(2, i).Value
        'mainform.lblcuscontact.Text = cuswindowdatagridview.Item(3, i).Value
    End Sub

    Private Sub customerwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cuswindowviewdata()

    End Sub

    Private Sub btnSearchcuswindow_Click(sender As Object, e As EventArgs) Handles btnSearchcuswindow.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()


        Try
            Dim query As String
            query = "SELECT * FROM customers WHERE Name = '" + txtcuswindowSearch.Text + "' OR CustomersID = '" + txtcuswindowSearch.Text + "'"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("customers")
            dr.Fill(data)
            cuswindowdatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM customers WHERE Name = '" + txtcuswindowSearch.Text + "' OR CustomersID = '" + txtcuswindowSearch.Text + "'"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class