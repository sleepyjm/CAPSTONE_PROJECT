Public Class InputQty
    Private Sub txtInputQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInputQty.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If


    End Sub



    Private Sub InputQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim finalqty, currentqty, inputqty, itemprice, totalprice As Integer
        currentqty = Val(Item1currentqty.Text)
        inputqty = Val(txtInputQty.Text)
        itemprice = Val(Price.Text)

        finalqty = currentqty - inputqty
        final.Text = finalqty
        totalprice = inputqty * itemprice
        tprice.Text = totalprice
    End Sub

    Private Sub txtInputQty_Enter(sender As Object, e As EventArgs) Handles txtInputQty.Enter
        Timer1.Stop()
        Me.Close()
    End Sub



    Private Sub txtInputQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInputQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If final.Text <= 10 Then
                MessageBox.Show("Insufficient Number of Stocks", "WARNING !!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtInputQty.Clear()
                Timer1.Stop()
                Me.Close()
            Else
                mainform.Itemfinalqty.Text = final.Text
                mainform.Itemprice.Text = tprice.Text
                Timer1.Stop()
                Me.Close()
            End If
        End If
    End Sub


End Class