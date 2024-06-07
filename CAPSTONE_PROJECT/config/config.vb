Public Class config
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.connection = txtarea.Text.Trim()
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtarea.Text = My.Settings.connection
    End Sub
End Class