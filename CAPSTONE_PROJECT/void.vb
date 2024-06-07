Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class void

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub void_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        voidviewdata()
    End Sub

    Private Sub txtvoidnum_TextChanged(sender As Object, e As EventArgs) Handles txtvoidnum.TextChanged
        Dim connectionString As String = "Server=DESKTOP-PT9RB1P\SQLEXPRESS;Database=capstoneproject;Trusted_Connection=True;"
        Dim sql As String = "SELECT [No],[OR_NO],[TotalPrice],[Date] FROM stockout WHERE OR_NO LIKE @searchTerm OR Date LIKE @searchTerm"

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@searchTerm", "%" & txtvoidnum.Text & "%")
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    voiddatagridview.DataSource = dt
                    con.Close()
                End Using
            End Using
        End Using
    End Sub

    Private Sub voiddatagridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles voiddatagridview.CellClick
        Dim i As Integer
        i = voiddatagridview.CurrentRow.Index
        lblvoidno.Text = voiddatagridview.Item(0, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class