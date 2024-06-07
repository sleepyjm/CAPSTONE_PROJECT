Imports System.Data.SqlClient

Public Class inventoryupdate
    Dim mycon As SqlConnection
    Private Sub btngoback_Click(sender As Object, e As EventArgs) Handles btngoback.Click
        Me.Hide()

    End Sub

    Private Sub inventoryupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateinventoryviewdata()

    End Sub

    Private Sub btninvupdatewindow_Click(sender As Object, e As EventArgs) Handles btninvupdatewindow.Click
        mycon = New SqlConnection("Server=DESKTOP-PT9RB1P\SQLEXPRESS;Database=capstoneproject;Trusted_Connection=True;")
        mycon.Open()
        Try
            Dim query As String
            query = "SELECT * FROM inventory WHERE ItemName LIKE '%" + txtsearchinvupdate.Text + "%' OR Category LIKE '%" + txtsearchinvupdate.Text + "%'"
            Dim dr As New SqlDataAdapter(query, mycon)
            Dim data As New DataTable("customers")
            dr.Fill(data)
            invupdatedatagridview.DataSource = data
            Dim sql1 As String
            sql1 = "SELECT * FROM inventory WHERE ItemName LIKE '%" + txtsearchinvupdate.Text + "%' OR Category LIKE '%" + txtsearchinvupdate.Text + "%'"
            Dim adapter1 As New SqlDataAdapter(sql1, mycon)
            Dim cmd As New SqlCommand(sql1, mycon)
            Dim myreader As SqlDataReader = cmd.ExecuteReader
            myreader.Read()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub invupdatedatagridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles invupdatedatagridview.CellClick
        Dim i As Integer
        i = invupdatedatagridview.CurrentRow.Index
        lblitemid.Text = invupdatedatagridview.Item(0, i).Value
        txtpriceupdate.Text = invupdatedatagridview.Item(4, i).Value
    End Sub

    Private Sub btninvupdate_Click(sender As Object, e As EventArgs) Handles btninvupdate.Click
        mycon = New SqlConnection("Server=DESKTOP-PT9RB1P\SQLEXPRESS;Database=capstoneproject;Trusted_Connection=True;")
        mycon.Open()

        Try
            Dim query As String
            query = " UPDATE inventory SET Price=@price WHERE ItemID=@ID"
            Dim cmd = New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@ID", lblitemid.Text)
            cmd.Parameters.AddWithValue("@price", txtpriceupdate.Text)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Item has been Updated", MsgBoxStyle.Information, "SUCCESS!")
            updateinventoryviewdata()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtpriceupdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpriceupdate.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub
End Class