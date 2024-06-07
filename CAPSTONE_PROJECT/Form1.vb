Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class loginform
    Dim countdown As Integer
    Dim mycon As SqlConnection
    Private loginAttempts As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username = txtusername.Text
        Dim password = txtpassword.Text

        mycon = New SqlConnection(My.Settings.connection)
        mycon.Open()
        Try


            Dim command As New SqlCommand("SELECT Position FROM users WHERE Username = @username AND Password = @password", mycon)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@date", lblDate.Text)
        command.Parameters.AddWithValue("@time", lblTime.Text)

            Dim reader = Command.ExecuteReader


            If reader.Read Then
                Dim role = reader("Position").ToString



                If role = "Admin" Then
                    ' Redirect to admin dashboard
                    mainform.lblUserLogin.Text = username
                    MessageBox.Show("Welcome, Admin!")
                    ' Open admin form
                    mainform.Show()
                    Hide()
                    reader.Close()

                    Dim command2 As New SqlCommand("INSERT INTO userlogin ([Username],[Date],[Time]) VALUES (@username,@date,@time)", mycon)
                    command2.Parameters.AddWithValue("@username", username)
                    command2.Parameters.AddWithValue("@date", lblDate.Text)
                    command2.Parameters.AddWithValue("@time", lblTime.Text)
                    command2.ExecuteNonQuery()

                ElseIf role = "Staff" Then

                    ' Redirect to staff dashboard
                    mainform.lblUserLogin.Text = username
                    MessageBox.Show("Welcome, Staff!")
                    ' Open staff form
                    mainform.Show()

                    mainform.TabControl1.TabPages(6).Visible = False
                    mainform.UsersDataView.Visible = False
                    mainform.txtUserSearch.Visible = False
                    mainform.btnUsersSearch.Visible = False
                    mainform.btnUsersViewAll.Visible = False
                    mainform.lbluserID.Visible = False
                    mainform.comboboxuserpos.Visible = False
                    mainform.txtUsersUsername.Visible = False
                    mainform.txtUsersPass.Visible = False
                    mainform.txtUsersNum.Visible = False
                    mainform.txtUsersAddress.Visible = False
                    mainform.btnUsersAdd.Visible = False
                    mainform.btnUsersUpdate.Visible = False
                    mainform.btnUsersDelete.Visible = False
                    mainform.Label5.Visible = False
                    mainform.Label9.Visible = False
                    mainform.Label10.Visible = False
                    mainform.Label11.Visible = False
                    mainform.Label13.Visible = False
                    mainform.btnUpdatePriceInventory.Visible = False
                    mainform.btnloginhistory.Visible = False
                    Hide()
                    reader.Close()

                    Dim command2 As New SqlCommand("INSERT INTO userlogin ([Username],[Date],[Time]) VALUES (@username,@date,@time)", mycon)
                    command2.Parameters.AddWithValue("@username", username)
                    command2.Parameters.AddWithValue("@date", lblDate.Text)
                    command2.Parameters.AddWithValue("@time", lblTime.Text)
                    command2.ExecuteNonQuery()
                End If
            Else


                loginAttempts += 1
            If loginAttempts = 3 Then
                ' attempts failed, close application
                MessageBox.Show("Too many invalid attempts.")

                Dim countdown As Integer = 30 ' set the countdown time in seconds
                TimerInvalidLogin.Interval = 1000 ' 1 second interval
                TimerInvalidLogin.Start()
                lblCountdown.Text = countdown.ToString
                txtusername.Enabled = False
                txtpassword.Enabled = False
                txtusername.Clear()
                txtpassword.Clear()
                Button1.Enabled = False
                Button2.Enabled = False
                Label1.Visible = True
                Label2.Visible = True
                lblCountdown.Visible = True
                If loginAttempts = 6 Then
                    countdown = 60 ' set the countdown time in seconds
                    TimerInvalidLogin.Interval = 1000 ' 1 second interval
                    TimerInvalidLogin.Start()
                    lblCountdown.Text = countdown.ToString
                    txtusername.Enabled = False
                    txtpassword.Enabled = False
                    txtusername.Clear()
                    txtpassword.Clear()
                    Button1.Enabled = False
                    Button2.Enabled = False
                End If


            Else
                'how error message and allow retry
                MessageBox.Show("Invalid username or password. Please try again.")
                txtusername.Clear()
                txtpassword.Clear()

            End If
        End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
        DateAndTimeTimer.Start()



    End Sub

    Private Sub DateAndTimeTimer_Tick(sender As Object, e As EventArgs) Handles DateAndTimeTimer.Tick
        Dim dt As DateTime = DateTime.Now
        Dim formattedDate As String = dt.ToString("MM/dd/yyyy")
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
        mainform.mainformTime.Text = TimeOfDay.ToString("h:mm:ss tt")
        ManageItems.lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
        lblDate.Text = formattedDate
        mainform.mainformdate.Text = formattedDate
        ManageItems.lblDate.Text = formattedDate

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub loginform_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        config.ShowDialog()
    End Sub

    Private Sub TimerInvalidLogin_Tick(sender As Object, e As EventArgs) Handles TimerInvalidLogin.Tick
        Dim countdown As Integer = Integer.Parse(lblCountdown.Text)
        countdown -= 1
        lblCountdown.Text = countdown.ToString

        If countdown = 0 Then
            TimerInvalidLogin.Stop()
            txtusername.Enabled = True
            txtpassword.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Label1.Visible = False
            Label2.Visible = False
            lblCountdown.Visible = False

        End If
    End Sub
End Class
