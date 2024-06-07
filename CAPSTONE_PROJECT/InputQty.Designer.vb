<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputQty
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
        components = New ComponentModel.Container()
        txtInputQty = New TextBox()
        Label1 = New Label()
        Item1currentqty = New Label()
        final = New Label()
        Timer1 = New Timer(components)
        Price = New Label()
        tprice = New Label()
        SuspendLayout()
        ' 
        ' txtInputQty
        ' 
        txtInputQty.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        txtInputQty.Location = New Point(79, 53)
        txtInputQty.Name = "txtInputQty"
        txtInputQty.Size = New Size(160, 71)
        txtInputQty.TabIndex = 0
        txtInputQty.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 21)
        Label1.TabIndex = 1
        Label1.Text = "Input Quantity"
        ' 
        ' Item1currentqty
        ' 
        Item1currentqty.AutoSize = True
        Item1currentqty.Location = New Point(217, 9)
        Item1currentqty.Name = "Item1currentqty"
        Item1currentqty.Size = New Size(13, 15)
        Item1currentqty.TabIndex = 2
        Item1currentqty.Text = "0"
        Item1currentqty.Visible = False
        ' 
        ' final
        ' 
        final.AutoSize = True
        final.Location = New Point(264, 9)
        final.Name = "final"
        final.Size = New Size(13, 15)
        final.TabIndex = 3
        final.Text = "0"
        final.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Price
        ' 
        Price.AutoSize = True
        Price.Location = New Point(264, 53)
        Price.Name = "Price"
        Price.Size = New Size(13, 15)
        Price.TabIndex = 4
        Price.Text = "0"
        Price.Visible = False
        ' 
        ' tprice
        ' 
        tprice.AutoSize = True
        tprice.Location = New Point(264, 96)
        tprice.Name = "tprice"
        tprice.Size = New Size(13, 15)
        tprice.TabIndex = 5
        tprice.Text = "0"
        tprice.Visible = False
        ' 
        ' InputQty
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(317, 172)
        Controls.Add(tprice)
        Controls.Add(Price)
        Controls.Add(final)
        Controls.Add(Item1currentqty)
        Controls.Add(Label1)
        Controls.Add(txtInputQty)
        FormBorderStyle = FormBorderStyle.None
        Name = "InputQty"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InputQty"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInputQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Item1currentqty As Label
    Friend WithEvents final As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Price As Label
    Friend WithEvents tprice As Label
End Class
