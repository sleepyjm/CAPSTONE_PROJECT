Imports System.Data.SqlClient

Public Class AdminLoginToDelete
    Dim mycon As SqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verify the password


        ' Open the connection
        Using mycon = New SqlConnection(My.Settings.connection)
            mycon.Open()

            ' Check if the users table exists and the user is an admin
            Dim checkAdminQuery As String = "SELECT COUNT(*) FROM users WHERE Position='Admin'"
            Using cmd = New SqlCommand(checkAdminQuery, mycon)
                If CInt(cmd.ExecuteScalar()) = 0 Then
                    MsgBox("Invalid password", MsgBoxStyle.Critical, "Error")
                    mycon.Close()
                    Return
                End If
            End Using

            Try
                ' Prepare the deletion query
                Dim query As String
                query = "DELETE FROM inventory WHERE ItemID='" + ManageItems.lblItemNum.Text + "'"

                ' Execute the deletion
                Using cmd = New SqlCommand(query, mycon)
                    cmd.ExecuteNonQuery()
                End Using

                ' Clear the textboxes and refresh the data
                ManageItems.txtManageItemSupplier.Clear()
                ManageItems.txtItemName.Clear()
                ManageItems.txtCategory.Clear()
                ManageItems.txtQty.Clear()
                ManageItems.txtPrice.Clear()
                inventoryviewdata()


                MsgBox("Item has been Deleted", MsgBoxStyle.Information, "Success")
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        ManageItems.txtManageItemSupplier.Clear()
        ManageItems.txtItemName.Clear()
        ManageItems.txtCategory.Clear()
        ManageItems.txtQty.Clear()
        ManageItems.txtPrice.Clear()
    End Sub
End Class