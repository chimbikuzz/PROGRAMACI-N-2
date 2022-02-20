<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPrecioC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrecioV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCostoTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(280, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESULTADOS OBTENIDOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(76, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio De Costo"
        '
        'TxtPrecioC
        '
        Me.TxtPrecioC.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPrecioC.Enabled = False
        Me.TxtPrecioC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPrecioC.Location = New System.Drawing.Point(268, 121)
        Me.TxtPrecioC.Name = "TxtPrecioC"
        Me.TxtPrecioC.Size = New System.Drawing.Size(125, 27)
        Me.TxtPrecioC.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(76, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Precio De Venta"
        '
        'TxtPrecioV
        '
        Me.TxtPrecioV.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPrecioV.Enabled = False
        Me.TxtPrecioV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPrecioV.Location = New System.Drawing.Point(268, 193)
        Me.TxtPrecioV.Name = "TxtPrecioV"
        Me.TxtPrecioV.Size = New System.Drawing.Size(125, 27)
        Me.TxtPrecioV.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(526, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Costo TOTAL"
        '
        'TxtCostoTotal
        '
        Me.TxtCostoTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtCostoTotal.Enabled = False
        Me.TxtCostoTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtCostoTotal.Location = New System.Drawing.Point(482, 167)
        Me.TxtCostoTotal.Name = "TxtCostoTotal"
        Me.TxtCostoTotal.Size = New System.Drawing.Size(174, 27)
        Me.TxtCostoTotal.TabIndex = 6
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(737, 274)
        Me.Controls.Add(Me.TxtCostoTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPrecioV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPrecioC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Resultados"
        Me.Text = "Resultados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPrecioC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrecioV As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCostoTotal As TextBox
End Class
