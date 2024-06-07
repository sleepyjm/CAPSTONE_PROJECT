Imports System.Data.SqlClient

Public Class loginhistory
    Dim mycon As New SqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try

            Dim startDate As Date = DateTimePicker1.Value.Date
            Dim endDate As Date = DateTimePicker2.Value.Date

            Dim query As String = "SELECT * FROM userlogin WHERE Date BETWEEN @StartDate AND @EndDate ORDER BY Date ASC" &
                " SELECT * FROM userlogin WHERE Username LIKE '%" + TextBox1.Text + "%' OR 
                Position LIKE '%" + TextBox1.Text + "%' OR Date LIKE '%" + TextBox1.Text + "%' OR
                Time LIKE '%" + TextBox1.Text + "%'"

            Dim cmd As New SqlCommand(query, mycon)
            cmd.Parameters.AddWithValue("@StartDate", startDate)
            cmd.Parameters.AddWithValue("@EndDate", endDate)


            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            loginhistorydatagridview.DataSource = dataTable
            mycon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        loginhistoryviewall()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        loginhistoryviewall()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As New Rectangle(loginhistorydatagridview.Location.X, loginhistorydatagridview.Location.Y, loginhistorydatagridview.Width, loginhistorydatagridview.Height)

        ' Print the content of the DataGridView
        loginhistorydatagridview.DrawToBitmap(New Bitmap(loginhistorydatagridview.Width, loginhistorydatagridview.Height), rect)
        Dim g As Graphics = e.Graphics

        ' Get the size of the panel.
        Dim Stockout As Size = loginhistorydatagridview.Size

        ' Create a bitmap to hold the panel's contents.
        Using bmp As New Bitmap(Stockout.Width, Stockout.Height)
            ' Draw the panel onto the bitmap.
            loginhistorydatagridview.DrawToBitmap(bmp, New Rectangle(0, 0, Stockout.Width, Stockout.Height))

            ' Draw the bitmap onto the print page.
            g.DrawImage(bmp, e.PageBounds.Location)
        End Using
    End Sub

    Private Sub loginhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginhistoryviewall()
    End Sub
End Class