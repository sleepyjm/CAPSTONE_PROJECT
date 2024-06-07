<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config
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
        Button1 = New Button()
        Button2 = New Button()
        txtarea = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(12, 241)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 37)
        Button1.TabIndex = 1
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightGray
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(115, 241)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 37)
        Button2.TabIndex = 2
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtarea
        ' 
        txtarea.BackColor = Color.LightGray
        txtarea.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtarea.ForeColor = Color.Black
        txtarea.Location = New Point(-1, 3)
        txtarea.Multiline = True
        txtarea.Name = "txtarea"
        txtarea.Size = New Size(213, 192)
        txtarea.TabIndex = 3
        txtarea.TextAlign = HorizontalAlignment.Center
        txtarea.UseSystemPasswordChar = True
        ' 
        ' config
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(212, 290)
        ControlBox = False
        Controls.Add(txtarea)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "config"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtarea As TextBox
End Class
