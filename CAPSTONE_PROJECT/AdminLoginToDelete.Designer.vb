<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginToDelete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(66, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 30)
        Label1.TabIndex = 0
        Label1.Text = "INPUT ADMIN PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(78, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 43)
        TextBox1.TabIndex = 1
        TextBox1.TextAlign = HorizontalAlignment.Center
        TextBox1.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(78, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 51)
        Button1.TabIndex = 2
        Button1.Text = "CONFIRM"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(210, 105)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 51)
        Button2.TabIndex = 3
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' AdminLoginToDelete
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(405, 189)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminLoginToDelete"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminLoginToDelete"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
