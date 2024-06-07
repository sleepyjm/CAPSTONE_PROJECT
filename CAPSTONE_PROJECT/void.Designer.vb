<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class void
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
        txtvoidnum = New TextBox()
        voiddatagridview = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        lblvoidno = New Label()
        CType(voiddatagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtvoidnum
        ' 
        txtvoidnum.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        txtvoidnum.Location = New Point(12, 8)
        txtvoidnum.Name = "txtvoidnum"
        txtvoidnum.PlaceholderText = "OR Number"
        txtvoidnum.Size = New Size(209, 50)
        txtvoidnum.TabIndex = 0
        ' 
        ' voiddatagridview
        ' 
        voiddatagridview.AllowUserToAddRows = False
        voiddatagridview.AllowUserToDeleteRows = False
        voiddatagridview.AllowUserToResizeColumns = False
        voiddatagridview.AllowUserToResizeRows = False
        voiddatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        voiddatagridview.BackgroundColor = Color.LightGray
        voiddatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        voiddatagridview.Location = New Point(12, 64)
        voiddatagridview.Name = "voiddatagridview"
        voiddatagridview.RowTemplate.Height = 25
        voiddatagridview.Size = New Size(526, 225)
        voiddatagridview.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(227, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 49)
        Button1.TabIndex = 2
        Button1.Text = "Void"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(373, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 49)
        Button2.TabIndex = 3
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblvoidno
        ' 
        lblvoidno.AutoSize = True
        lblvoidno.Location = New Point(12, 305)
        lblvoidno.Name = "lblvoidno"
        lblvoidno.Size = New Size(41, 15)
        lblvoidno.TabIndex = 4
        lblvoidno.Text = "Label1"
        ' 
        ' void
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(565, 329)
        Controls.Add(lblvoidno)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(voiddatagridview)
        Controls.Add(txtvoidnum)
        FormBorderStyle = FormBorderStyle.None
        Name = "void"
        StartPosition = FormStartPosition.CenterScreen
        Text = "void"
        CType(voiddatagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtvoidnum As TextBox
    Friend WithEvents voiddatagridview As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblvoidno As Label
End Class
