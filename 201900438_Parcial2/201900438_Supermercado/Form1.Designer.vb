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
        Me.RbLargo = New System.Windows.Forms.RadioButton()
        Me.RbCorto = New System.Windows.Forms.RadioButton()
        Me.Plazos = New System.Windows.Forms.GroupBox()
        Me.CbTv = New System.Windows.Forms.CheckBox()
        Me.CbTel = New System.Windows.Forms.CheckBox()
        Me.CbLaptop = New System.Windows.Forms.CheckBox()
        Me.CbRefri = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCui = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCostos = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Plazos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RbLargo
        '
        Me.RbLargo.AutoSize = True
        Me.RbLargo.Location = New System.Drawing.Point(17, 37)
        Me.RbLargo.Name = "RbLargo"
        Me.RbLargo.Size = New System.Drawing.Size(68, 24)
        Me.RbLargo.TabIndex = 0
        Me.RbLargo.TabStop = True
        Me.RbLargo.Text = "Largo"
        Me.RbLargo.UseVisualStyleBackColor = True
        '
        'RbCorto
        '
        Me.RbCorto.AutoSize = True
        Me.RbCorto.Location = New System.Drawing.Point(108, 37)
        Me.RbCorto.Name = "RbCorto"
        Me.RbCorto.Size = New System.Drawing.Size(67, 24)
        Me.RbCorto.TabIndex = 1
        Me.RbCorto.TabStop = True
        Me.RbCorto.Text = "Corto"
        Me.RbCorto.UseVisualStyleBackColor = True
        '
        'Plazos
        '
        Me.Plazos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Plazos.Controls.Add(Me.RbLargo)
        Me.Plazos.Controls.Add(Me.RbCorto)
        Me.Plazos.Location = New System.Drawing.Point(828, 75)
        Me.Plazos.Name = "Plazos"
        Me.Plazos.Size = New System.Drawing.Size(199, 95)
        Me.Plazos.TabIndex = 2
        Me.Plazos.TabStop = False
        Me.Plazos.Text = "Tipos de Plazo"
        '
        'CbTv
        '
        Me.CbTv.AutoSize = True
        Me.CbTv.Location = New System.Drawing.Point(52, 38)
        Me.CbTv.Name = "CbTv"
        Me.CbTv.Size = New System.Drawing.Size(48, 24)
        Me.CbTv.TabIndex = 3
        Me.CbTv.Text = "TV"
        Me.CbTv.UseVisualStyleBackColor = True
        '
        'CbTel
        '
        Me.CbTel.AutoSize = True
        Me.CbTel.Location = New System.Drawing.Point(168, 38)
        Me.CbTel.Name = "CbTel"
        Me.CbTel.Size = New System.Drawing.Size(89, 24)
        Me.CbTel.TabIndex = 4
        Me.CbTel.Text = "Teléfono"
        Me.CbTel.UseVisualStyleBackColor = True
        '
        'CbLaptop
        '
        Me.CbLaptop.AutoSize = True
        Me.CbLaptop.Location = New System.Drawing.Point(314, 38)
        Me.CbLaptop.Name = "CbLaptop"
        Me.CbLaptop.Size = New System.Drawing.Size(78, 24)
        Me.CbLaptop.TabIndex = 5
        Me.CbLaptop.Text = "Laptop"
        Me.CbLaptop.UseVisualStyleBackColor = True
        '
        'CbRefri
        '
        Me.CbRefri.AutoSize = True
        Me.CbRefri.Location = New System.Drawing.Point(422, 38)
        Me.CbRefri.Name = "CbRefri"
        Me.CbRefri.Size = New System.Drawing.Size(127, 24)
        Me.CbRefri.TabIndex = 6
        Me.CbRefri.Text = "Regrigeradora"
        Me.CbRefri.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.CbTv)
        Me.GroupBox1.Controls.Add(Me.CbRefri)
        Me.GroupBox1.Controls.Add(Me.CbTel)
        Me.GroupBox1.Controls.Add(Me.CbLaptop)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 97)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de Aparatos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(53, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Costos Totales Aparatos"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtNombre.Location = New System.Drawing.Point(672, 225)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(157, 27)
        Me.TxtNombre.TabIndex = 13
        '
        'TxtCui
        '
        Me.TxtCui.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtCui.Location = New System.Drawing.Point(858, 225)
        Me.TxtCui.Name = "TxtCui"
        Me.TxtCui.Size = New System.Drawing.Size(157, 27)
        Me.TxtCui.TabIndex = 14
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtDireccion.Location = New System.Drawing.Point(1041, 225)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(188, 27)
        Me.TxtDireccion.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(717, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(911, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CUI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Chartreuse
        Me.Label4.Location = New System.Drawing.Point(1064, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Dirección"
        '
        'TxtCostos
        '
        Me.TxtCostos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtCostos.Location = New System.Drawing.Point(269, 225)
        Me.TxtCostos.Name = "TxtCostos"
        Me.TxtCostos.Size = New System.Drawing.Size(286, 27)
        Me.TxtCostos.TabIndex = 19
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Khaki
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(103, 304)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(150, 104)
        Me.ListBox1.TabIndex = 20
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Khaki
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(276, 304)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(150, 104)
        Me.ListBox2.TabIndex = 21
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.Khaki
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(451, 304)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(150, 104)
        Me.ListBox3.TabIndex = 22
        '
        'ListBox4
        '
        Me.ListBox4.BackColor = System.Drawing.Color.Khaki
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(631, 304)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(150, 104)
        Me.ListBox4.TabIndex = 23
        '
        'ListBox5
        '
        Me.ListBox5.BackColor = System.Drawing.Color.Khaki
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(811, 304)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(150, 104)
        Me.ListBox5.TabIndex = 24
        '
        'ListBox6
        '
        Me.ListBox6.BackColor = System.Drawing.Color.Khaki
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 20
        Me.ListBox6.Location = New System.Drawing.Point(985, 304)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(150, 104)
        Me.ListBox6.TabIndex = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1265, 28)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Crimson
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListBox7
        '
        Me.ListBox7.BackColor = System.Drawing.Color.Khaki
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 20
        Me.ListBox7.Location = New System.Drawing.Point(369, 479)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(150, 104)
        Me.ListBox7.TabIndex = 27
        '
        'ListBox8
        '
        Me.ListBox8.BackColor = System.Drawing.Color.Khaki
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 20
        Me.ListBox8.Location = New System.Drawing.Point(545, 479)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(150, 104)
        Me.ListBox8.TabIndex = 28
        '
        'ListBox9
        '
        Me.ListBox9.BackColor = System.Drawing.Color.Khaki
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 20
        Me.ListBox9.Location = New System.Drawing.Point(717, 479)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(150, 104)
        Me.ListBox9.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Chartreuse
        Me.Label5.Location = New System.Drawing.Point(140, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Chartreuse
        Me.Label6.Location = New System.Drawing.Point(337, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "CUI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(483, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Chartreuse
        Me.Label8.Location = New System.Drawing.Point(672, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Aparatos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Chartreuse
        Me.Label9.Location = New System.Drawing.Point(858, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Plazos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Chartreuse
        Me.Label10.Location = New System.Drawing.Point(968, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Costos Totales Aparatos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Chartreuse
        Me.Label11.Location = New System.Drawing.Point(399, 456)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Descuento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Chartreuse
        Me.Label12.Location = New System.Drawing.Point(590, 456)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 20)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Parcial"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Chartreuse
        Me.Label13.Location = New System.Drawing.Point(764, 456)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 20)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1265, 612)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TxtCostos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtCui)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Plazos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Plazos.ResumeLayout(False)
        Me.Plazos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RbLargo As RadioButton
    Friend WithEvents RbCorto As RadioButton
    Friend WithEvents Plazos As GroupBox
    Friend WithEvents CbTv As CheckBox
    Friend WithEvents CbTel As CheckBox
    Friend WithEvents CbLaptop As CheckBox
    Friend WithEvents CbRefri As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCui As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCostos As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
End Class
