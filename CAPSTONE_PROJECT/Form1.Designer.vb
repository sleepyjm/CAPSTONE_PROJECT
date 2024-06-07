<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Button1 = New Button()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        CheckBox1 = New CheckBox()
        lblTime = New Label()
        lblDate = New Label()
        DateAndTimeTimer = New Timer(components)
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        lblCountdown = New Label()
        Button2 = New Button()
        Button3 = New Button()
        TimerInvalidLogin = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(104, 338)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 47)
        Button1.TabIndex = 0
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = Color.LightGray
        txtpassword.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtpassword.ForeColor = Color.Black
        txtpassword.Location = New Point(139, 272)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(198, 35)
        txtpassword.TabIndex = 2
        txtpassword.TextAlign = HorizontalAlignment.Center
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.LightGray
        txtusername.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtusername.Location = New Point(139, 189)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(198, 35)
        txtusername.TabIndex = 1
        txtusername.TextAlign = HorizontalAlignment.Center
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.LightGray
        CheckBox1.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.Black
        CheckBox1.Location = New Point(352, 282)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(72, 22)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTime.ForeColor = Color.Black
        lblTime.Location = New Point(12, 10)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(315, 42)
        lblTime.TabIndex = 10
        lblTime.Text = "CURRENT TIME" & vbCrLf
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.ForeColor = Color.Black
        lblDate.Location = New Point(171, 72)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(159, 23)
        lblDate.TabIndex = 11
        lblDate.Text = "CURRENT DATE"
        ' 
        ' DateAndTimeTimer
        ' 
        DateAndTimeTimer.Enabled = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(34, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(388, 45)
        Label4.TabIndex = 14
        Label4.Text = "CORNERGLOVALG"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(330, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 25)
        Label5.TabIndex = 15
        Label5.Text = "Enterprises"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(75, 179)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(75, 262)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(46, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Navy
        PictureBox3.BackgroundImage = My.Resources.Resources.LOGO_removebg_preview
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(12, 9)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(214, 196)
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SkyBlue
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lblCountdown)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(txtusername)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(txtpassword)
        Panel2.Controls.Add(lblTime)
        Panel2.Controls.Add(lblDate)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(CheckBox1)
        Panel2.Location = New Point(476, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(498, 514)
        Panel2.TabIndex = 20
        ' 
        ' lblCountdown
        ' 
        lblCountdown.AutoSize = True
        lblCountdown.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCountdown.ForeColor = Color.Black
        lblCountdown.Location = New Point(260, 137)
        lblCountdown.Name = "lblCountdown"
        lblCountdown.Size = New Size(20, 23)
        lblCountdown.TabIndex = 19
        lblCountdown.Text = "0"
        lblCountdown.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightGray
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(245, 338)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 47)
        Button2.TabIndex = 18
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightGray
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(12, 474)
        Button3.Name = "Button3"
        Button3.Size = New Size(30, 27)
        Button3.TabIndex = 19
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TimerInvalidLogin
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(131, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 23)
        Label1.TabIndex = 20
        Label1.Text = "Try again in: "
        Label1.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(286, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 23)
        Label2.TabIndex = 21
        Label2.Text = "'s"
        Label2.Visible = False
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(960, 513)
        Controls.Add(Button3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        ForeColor = Color.PaleTurquoise
        FormBorderStyle = FormBorderStyle.None
        Name = "loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents DateAndTimeTimer As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblCountdown As Label
    Friend WithEvents TimerInvalidLogin As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
