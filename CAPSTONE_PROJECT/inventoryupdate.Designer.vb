<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventoryupdate
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
        txtpriceupdate = New TextBox()
        invupdatedatagridview = New DataGridView()
        btninvupdate = New Button()
        txtsearchinvupdate = New TextBox()
        btninvupdatewindow = New Button()
        btngoback = New Button()
        lblitemid = New Label()
        CType(invupdatedatagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtpriceupdate
        ' 
        txtpriceupdate.BackColor = Color.WhiteSmoke
        txtpriceupdate.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txtpriceupdate.Location = New Point(348, 268)
        txtpriceupdate.Name = "txtpriceupdate"
        txtpriceupdate.Size = New Size(91, 39)
        txtpriceupdate.TabIndex = 0
        ' 
        ' invupdatedatagridview
        ' 
        invupdatedatagridview.BackgroundColor = Color.WhiteSmoke
        invupdatedatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        invupdatedatagridview.GridColor = Color.WhiteSmoke
        invupdatedatagridview.Location = New Point(21, 55)
        invupdatedatagridview.Name = "invupdatedatagridview"
        invupdatedatagridview.RowTemplate.Height = 25
        invupdatedatagridview.Size = New Size(502, 197)
        invupdatedatagridview.TabIndex = 1
        ' 
        ' btninvupdate
        ' 
        btninvupdate.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btninvupdate.Location = New Point(445, 279)
        btninvupdate.Name = "btninvupdate"
        btninvupdate.Size = New Size(78, 26)
        btninvupdate.TabIndex = 2
        btninvupdate.Text = "Update"
        btninvupdate.UseVisualStyleBackColor = True
        ' 
        ' txtsearchinvupdate
        ' 
        txtsearchinvupdate.BackColor = Color.WhiteSmoke
        txtsearchinvupdate.Location = New Point(21, 16)
        txtsearchinvupdate.Name = "txtsearchinvupdate"
        txtsearchinvupdate.Size = New Size(182, 23)
        txtsearchinvupdate.TabIndex = 3
        ' 
        ' btninvupdatewindow
        ' 
        btninvupdatewindow.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btninvupdatewindow.Location = New Point(225, 16)
        btninvupdatewindow.Name = "btninvupdatewindow"
        btninvupdatewindow.Size = New Size(75, 23)
        btninvupdatewindow.TabIndex = 4
        btninvupdatewindow.Text = "Search"
        btninvupdatewindow.UseVisualStyleBackColor = True
        ' 
        ' btngoback
        ' 
        btngoback.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btngoback.Location = New Point(448, 16)
        btngoback.Name = "btngoback"
        btngoback.Size = New Size(75, 23)
        btngoback.TabIndex = 5
        btngoback.Text = "Back"
        btngoback.UseVisualStyleBackColor = True
        ' 
        ' lblitemid
        ' 
        lblitemid.AutoSize = True
        lblitemid.Location = New Point(21, 290)
        lblitemid.Name = "lblitemid"
        lblitemid.Size = New Size(41, 15)
        lblitemid.TabIndex = 6
        lblitemid.Text = "Label1"
        lblitemid.Visible = False
        ' 
        ' inventoryupdate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(545, 319)
        Controls.Add(lblitemid)
        Controls.Add(btngoback)
        Controls.Add(btninvupdatewindow)
        Controls.Add(txtsearchinvupdate)
        Controls.Add(btninvupdate)
        Controls.Add(invupdatedatagridview)
        Controls.Add(txtpriceupdate)
        FormBorderStyle = FormBorderStyle.None
        Name = "inventoryupdate"
        StartPosition = FormStartPosition.CenterScreen
        Text = "inventoryupdate"
        CType(invupdatedatagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtpriceupdate As TextBox
    Friend WithEvents invupdatedatagridview As DataGridView
    Friend WithEvents btninvupdate As Button
    Friend WithEvents txtsearchinvupdate As TextBox
    Friend WithEvents btninvupdatewindow As Button
    Friend WithEvents btngoback As Button
    Friend WithEvents lblitemid As Label
End Class
