<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextCompra = New System.Windows.Forms.TextBox()
        Me.TextVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.CompraDolar = New System.Windows.Forms.RadioButton()
        Me.CompraPesoM = New System.Windows.Forms.RadioButton()
        Me.CompraEuro = New System.Windows.Forms.RadioButton()
        Me.CompraColón = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VentaDolar = New System.Windows.Forms.RadioButton()
        Me.VentaPesoM = New System.Windows.Forms.RadioButton()
        Me.VentaEuro = New System.Windows.Forms.RadioButton()
        Me.VentaColón = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextCompra
        '
        Me.TextCompra.BackColor = System.Drawing.Color.Gray
        Me.TextCompra.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextCompra.Location = New System.Drawing.Point(87, 182)
        Me.TextCompra.Name = "TextCompra"
        Me.TextCompra.Size = New System.Drawing.Size(161, 27)
        Me.TextCompra.TabIndex = 0
        '
        'TextVenta
        '
        Me.TextVenta.BackColor = System.Drawing.Color.Gray
        Me.TextVenta.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextVenta.Location = New System.Drawing.Point(315, 182)
        Me.TextVenta.Name = "TextVenta"
        Me.TextVenta.Size = New System.Drawing.Size(165, 27)
        Me.TextVenta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(136, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(379, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Venta"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCalcular.Location = New System.Drawing.Point(562, 198)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(94, 29)
        Me.BtnCalcular.TabIndex = 12
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpiar.Location = New System.Drawing.Point(562, 293)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(94, 29)
        Me.BtnLimpiar.TabIndex = 13
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCerrar.Location = New System.Drawing.Point(562, 393)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(94, 29)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'CompraDolar
        '
        Me.CompraDolar.AutoSize = True
        Me.CompraDolar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CompraDolar.Location = New System.Drawing.Point(19, 42)
        Me.CompraDolar.Name = "CompraDolar"
        Me.CompraDolar.Size = New System.Drawing.Size(78, 24)
        Me.CompraDolar.TabIndex = 31
        Me.CompraDolar.TabStop = True
        Me.CompraDolar.Text = "DOLAR"
        Me.CompraDolar.UseVisualStyleBackColor = True
        '
        'CompraPesoM
        '
        Me.CompraPesoM.AutoSize = True
        Me.CompraPesoM.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CompraPesoM.Location = New System.Drawing.Point(19, 85)
        Me.CompraPesoM.Name = "CompraPesoM"
        Me.CompraPesoM.Size = New System.Drawing.Size(144, 24)
        Me.CompraPesoM.TabIndex = 32
        Me.CompraPesoM.TabStop = True
        Me.CompraPesoM.Text = "PESO MEXICANO"
        Me.CompraPesoM.UseVisualStyleBackColor = True
        '
        'CompraEuro
        '
        Me.CompraEuro.AutoSize = True
        Me.CompraEuro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CompraEuro.Location = New System.Drawing.Point(19, 132)
        Me.CompraEuro.Name = "CompraEuro"
        Me.CompraEuro.Size = New System.Drawing.Size(68, 24)
        Me.CompraEuro.TabIndex = 33
        Me.CompraEuro.TabStop = True
        Me.CompraEuro.Text = "EURO"
        Me.CompraEuro.UseVisualStyleBackColor = True
        '
        'CompraColón
        '
        Me.CompraColón.AutoSize = True
        Me.CompraColón.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CompraColón.Location = New System.Drawing.Point(19, 177)
        Me.CompraColón.Name = "CompraColón"
        Me.CompraColón.Size = New System.Drawing.Size(79, 24)
        Me.CompraColón.TabIndex = 34
        Me.CompraColón.TabStop = True
        Me.CompraColón.Text = "COLÓN"
        Me.CompraColón.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.CompraDolar)
        Me.GroupBox1.Controls.Add(Me.CompraColón)
        Me.GroupBox1.Controls.Add(Me.CompraPesoM)
        Me.GroupBox1.Controls.Add(Me.CompraEuro)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 233)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'VentaDolar
        '
        Me.VentaDolar.AutoSize = True
        Me.VentaDolar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VentaDolar.Location = New System.Drawing.Point(23, 33)
        Me.VentaDolar.Name = "VentaDolar"
        Me.VentaDolar.Size = New System.Drawing.Size(78, 24)
        Me.VentaDolar.TabIndex = 36
        Me.VentaDolar.TabStop = True
        Me.VentaDolar.Text = "DOLAR"
        Me.VentaDolar.UseVisualStyleBackColor = True
        '
        'VentaPesoM
        '
        Me.VentaPesoM.AutoSize = True
        Me.VentaPesoM.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VentaPesoM.Location = New System.Drawing.Point(23, 76)
        Me.VentaPesoM.Name = "VentaPesoM"
        Me.VentaPesoM.Size = New System.Drawing.Size(144, 24)
        Me.VentaPesoM.TabIndex = 37
        Me.VentaPesoM.TabStop = True
        Me.VentaPesoM.Text = "PESO MEXICANO"
        Me.VentaPesoM.UseVisualStyleBackColor = True
        '
        'VentaEuro
        '
        Me.VentaEuro.AutoSize = True
        Me.VentaEuro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VentaEuro.Location = New System.Drawing.Point(23, 123)
        Me.VentaEuro.Name = "VentaEuro"
        Me.VentaEuro.Size = New System.Drawing.Size(68, 24)
        Me.VentaEuro.TabIndex = 38
        Me.VentaEuro.TabStop = True
        Me.VentaEuro.Text = "EURO"
        Me.VentaEuro.UseVisualStyleBackColor = True
        '
        'VentaColón
        '
        Me.VentaColón.AutoSize = True
        Me.VentaColón.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VentaColón.Location = New System.Drawing.Point(23, 168)
        Me.VentaColón.Name = "VentaColón"
        Me.VentaColón.Size = New System.Drawing.Size(79, 24)
        Me.VentaColón.TabIndex = 39
        Me.VentaColón.TabStop = True
        Me.VentaColón.Text = "COLÓN"
        Me.VentaColón.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.VentaDolar)
        Me.GroupBox2.Controls.Add(Me.VentaColón)
        Me.GroupBox2.Controls.Add(Me.VentaPesoM)
        Me.GroupBox2.Controls.Add(Me.VentaEuro)
        Me.GroupBox2.Location = New System.Drawing.Point(315, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 233)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(728, 574)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextVenta)
        Me.Controls.Add(Me.TextCompra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextCompra As TextBox
    Friend WithEvents TextVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents CompraDolar As RadioButton
    Friend WithEvents CompraPesoM As RadioButton
    Friend WithEvents CompraEuro As RadioButton
    Friend WithEvents CompraColón As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VentaDolar As RadioButton
    Friend WithEvents VentaPesoM As RadioButton
    Friend WithEvents VentaEuro As RadioButton
    Friend WithEvents VentaColón As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
End Class
