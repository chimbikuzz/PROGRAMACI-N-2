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
        Me.TxtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.TxtNIT = New System.Windows.Forms.TextBox()
        Me.TxtDíasH = New System.Windows.Forms.TextBox()
        Me.TxtHM = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbEncam = New System.Windows.Forms.CheckBox()
        Me.CbOpe = New System.Windows.Forms.CheckBox()
        Me.CbMater = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbEfectivo = New System.Windows.Forms.RadioButton()
        Me.RbCheque = New System.Windows.Forms.RadioButton()
        Me.RbTarC = New System.Windows.Forms.RadioButton()
        Me.RbTarD = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtCalcular = New System.Windows.Forms.Button()
        Me.BtLimpiarE = New System.Windows.Forms.Button()
        Me.BtListB = New System.Windows.Forms.Button()
        Me.BtCerrar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombrePaciente
        '
        Me.TxtNombrePaciente.Location = New System.Drawing.Point(201, 38)
        Me.TxtNombrePaciente.Name = "TxtNombrePaciente"
        Me.TxtNombrePaciente.Size = New System.Drawing.Size(165, 27)
        Me.TxtNombrePaciente.TabIndex = 0
        '
        'TxtNIT
        '
        Me.TxtNIT.Location = New System.Drawing.Point(201, 96)
        Me.TxtNIT.Name = "TxtNIT"
        Me.TxtNIT.Size = New System.Drawing.Size(165, 27)
        Me.TxtNIT.TabIndex = 1
        '
        'TxtDíasH
        '
        Me.TxtDíasH.Location = New System.Drawing.Point(201, 149)
        Me.TxtDíasH.Name = "TxtDíasH"
        Me.TxtDíasH.Size = New System.Drawing.Size(165, 27)
        Me.TxtDíasH.TabIndex = 2
        '
        'TxtHM
        '
        Me.TxtHM.Location = New System.Drawing.Point(201, 200)
        Me.TxtHM.Name = "TxtHM"
        Me.TxtHM.Size = New System.Drawing.Size(165, 27)
        Me.TxtHM.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombrePaciente)
        Me.GroupBox1.Controls.Add(Me.TxtHM)
        Me.GroupBox1.Controls.Add(Me.TxtNIT)
        Me.GroupBox1.Controls.Add(Me.TxtDíasH)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 240)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Honorarios Médicos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No. Días Hospitalizado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre Paciente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(740, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 8
        '
        'CbEncam
        '
        Me.CbEncam.AutoSize = True
        Me.CbEncam.Location = New System.Drawing.Point(16, 45)
        Me.CbEncam.Name = "CbEncam"
        Me.CbEncam.Size = New System.Drawing.Size(130, 24)
        Me.CbEncam.TabIndex = 9
        Me.CbEncam.Text = "Encamamiento"
        Me.CbEncam.UseVisualStyleBackColor = True
        '
        'CbOpe
        '
        Me.CbOpe.AutoSize = True
        Me.CbOpe.Location = New System.Drawing.Point(154, 45)
        Me.CbOpe.Name = "CbOpe"
        Me.CbOpe.Size = New System.Drawing.Size(100, 24)
        Me.CbOpe.TabIndex = 10
        Me.CbOpe.Text = "Operación"
        Me.CbOpe.UseVisualStyleBackColor = True
        '
        'CbMater
        '
        Me.CbMater.AutoSize = True
        Me.CbMater.Location = New System.Drawing.Point(274, 45)
        Me.CbMater.Name = "CbMater"
        Me.CbMater.Size = New System.Drawing.Size(108, 24)
        Me.CbMater.TabIndex = 11
        Me.CbMater.Text = "Maternidad"
        Me.CbMater.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.CbEncam)
        Me.GroupBox2.Controls.Add(Me.CbMater)
        Me.GroupBox2.Controls.Add(Me.CbOpe)
        Me.GroupBox2.Location = New System.Drawing.Point(643, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 95)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Servicio"
        '
        'RbEfectivo
        '
        Me.RbEfectivo.AutoSize = True
        Me.RbEfectivo.Location = New System.Drawing.Point(29, 39)
        Me.RbEfectivo.Name = "RbEfectivo"
        Me.RbEfectivo.Size = New System.Drawing.Size(83, 24)
        Me.RbEfectivo.TabIndex = 13
        Me.RbEfectivo.TabStop = True
        Me.RbEfectivo.Text = "Efectivo"
        Me.RbEfectivo.UseVisualStyleBackColor = True
        '
        'RbCheque
        '
        Me.RbCheque.AutoSize = True
        Me.RbCheque.Location = New System.Drawing.Point(139, 39)
        Me.RbCheque.Name = "RbCheque"
        Me.RbCheque.Size = New System.Drawing.Size(80, 24)
        Me.RbCheque.TabIndex = 14
        Me.RbCheque.TabStop = True
        Me.RbCheque.Text = "Cheque"
        Me.RbCheque.UseVisualStyleBackColor = True
        '
        'RbTarC
        '
        Me.RbTarC.AutoSize = True
        Me.RbTarC.Location = New System.Drawing.Point(247, 39)
        Me.RbTarC.Name = "RbTarC"
        Me.RbTarC.Size = New System.Drawing.Size(148, 24)
        Me.RbTarC.TabIndex = 15
        Me.RbTarC.TabStop = True
        Me.RbTarC.Text = "Tarjeta de Crédito"
        Me.RbTarC.UseVisualStyleBackColor = True
        '
        'RbTarD
        '
        Me.RbTarD.AutoSize = True
        Me.RbTarD.Location = New System.Drawing.Point(427, 39)
        Me.RbTarD.Name = "RbTarD"
        Me.RbTarD.Size = New System.Drawing.Size(145, 24)
        Me.RbTarD.TabIndex = 16
        Me.RbTarD.TabStop = True
        Me.RbTarD.Text = "Tarjeta de Débito"
        Me.RbTarD.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Controls.Add(Me.RbEfectivo)
        Me.GroupBox3.Controls.Add(Me.RbCheque)
        Me.GroupBox3.Controls.Add(Me.RbTarC)
        Me.GroupBox3.Controls.Add(Me.RbTarD)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 299)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(595, 88)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Método De Pago"
        '
        'BtCalcular
        '
        Me.BtCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtCalcular.Location = New System.Drawing.Point(273, 415)
        Me.BtCalcular.Name = "BtCalcular"
        Me.BtCalcular.Size = New System.Drawing.Size(124, 44)
        Me.BtCalcular.TabIndex = 18
        Me.BtCalcular.Text = "Calcular"
        Me.BtCalcular.UseVisualStyleBackColor = False
        '
        'BtLimpiarE
        '
        Me.BtLimpiarE.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtLimpiarE.Location = New System.Drawing.Point(416, 415)
        Me.BtLimpiarE.Name = "BtLimpiarE"
        Me.BtLimpiarE.Size = New System.Drawing.Size(175, 44)
        Me.BtLimpiarE.TabIndex = 19
        Me.BtLimpiarE.Text = "Limpiar Entradas"
        Me.BtLimpiarE.UseVisualStyleBackColor = False
        '
        'BtListB
        '
        Me.BtListB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtListB.Location = New System.Drawing.Point(628, 415)
        Me.BtListB.Name = "BtListB"
        Me.BtListB.Size = New System.Drawing.Size(144, 44)
        Me.BtListB.TabIndex = 20
        Me.BtListB.Text = "Limpiar Listas"
        Me.BtListB.UseVisualStyleBackColor = False
        '
        'BtCerrar
        '
        Me.BtCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtCerrar.Location = New System.Drawing.Point(800, 415)
        Me.BtCerrar.Name = "BtCerrar"
        Me.BtCerrar.Size = New System.Drawing.Size(97, 44)
        Me.BtCerrar.TabIndex = 21
        Me.BtCerrar.Text = "Cerrar"
        Me.BtCerrar.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(33, 515)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(150, 144)
        Me.ListBox1.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(70, 477)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Paciente"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(216, 515)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(150, 144)
        Me.ListBox2.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(270, 477)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "NIT"
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(393, 515)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(150, 144)
        Me.ListBox3.TabIndex = 26
        '
        'ListBox4
        '
        Me.ListBox4.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBox4.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(579, 515)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(150, 144)
        Me.ListBox4.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(400, 477)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Honorarios Médicos"
        '
        'ListBox5
        '
        Me.ListBox5.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBox5.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(758, 515)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(150, 144)
        Me.ListBox5.TabIndex = 30
        '
        'ListBox6
        '
        Me.ListBox6.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBox6.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 20
        Me.ListBox6.Location = New System.Drawing.Point(930, 515)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(150, 144)
        Me.ListBox6.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(952, 477)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Descuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(1166, 477)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 20)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Total"
        '
        'ListBox7
        '
        Me.ListBox7.BackColor = System.Drawing.Color.Gold
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 20
        Me.ListBox7.Location = New System.Drawing.Point(1108, 515)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(150, 144)
        Me.ListBox7.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(774, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Sub Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(602, 477)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 20)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Tipo De Pago"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Privada", "SemiPrivada", "NoPrivada"})
        Me.ComboBox1.Location = New System.Drawing.Point(722, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 28)
        Me.ComboBox1.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Gold
        Me.Label13.Location = New System.Drawing.Point(765, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 20)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Tipos de Habitación"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1284, 697)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtCerrar)
        Me.Controls.Add(Me.BtListB)
        Me.Controls.Add(Me.BtLimpiarE)
        Me.Controls.Add(Me.BtCalcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombrePaciente As TextBox
    Friend WithEvents TxtNIT As TextBox
    Friend WithEvents TxtDíasH As TextBox
    Friend WithEvents TxtHM As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbEncam As CheckBox
    Friend WithEvents CbOpe As CheckBox
    Friend WithEvents CbMater As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RbEfectivo As RadioButton
    Friend WithEvents RbCheque As RadioButton
    Friend WithEvents RbTarC As RadioButton
    Friend WithEvents RbTarD As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtCalcular As Button
    Friend WithEvents BtLimpiarE As Button
    Friend WithEvents BtListB As Button
    Friend WithEvents BtCerrar As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
End Class
