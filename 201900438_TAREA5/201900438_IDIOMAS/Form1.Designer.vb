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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbViernes = New System.Windows.Forms.CheckBox()
        Me.CbSabado = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtHoras = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RbEfectivo = New System.Windows.Forms.RadioButton()
        Me.RbCheque = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtCalcular = New System.Windows.Forms.Button()
        Me.BtLimpiarE = New System.Windows.Forms.Button()
        Me.BtLimpiarM = New System.Windows.Forms.Button()
        Me.BtCerrar = New System.Windows.Forms.Button()
        Me.TxtCarnet = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Carné Del Estudiante"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.DarkKhaki
        Me.TxtNombre.Location = New System.Drawing.Point(372, 67)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(176, 27)
        Me.TxtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(372, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre Del Estudiante"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Inglés", "Portugués", "Francés "})
        Me.ComboBox1.Location = New System.Drawing.Point(570, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 28)
        Me.ComboBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(570, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Idioma a Seleccionar"
        '
        'TxtFecha
        '
        Me.TxtFecha.BackColor = System.Drawing.Color.DarkKhaki
        Me.TxtFecha.Location = New System.Drawing.Point(278, 162)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(176, 27)
        Me.TxtFecha.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha de Inscripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, -5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 9
        '
        'CbViernes
        '
        Me.CbViernes.AutoSize = True
        Me.CbViernes.Location = New System.Drawing.Point(45, 36)
        Me.CbViernes.Name = "CbViernes"
        Me.CbViernes.Size = New System.Drawing.Size(79, 24)
        Me.CbViernes.TabIndex = 10
        Me.CbViernes.Text = "Viernes"
        Me.CbViernes.UseVisualStyleBackColor = True
        '
        'CbSabado
        '
        Me.CbSabado.AutoSize = True
        Me.CbSabado.Location = New System.Drawing.Point(45, 78)
        Me.CbSabado.Name = "CbSabado"
        Me.CbSabado.Size = New System.Drawing.Size(82, 24)
        Me.CbSabado.TabIndex = 11
        Me.CbSabado.Text = "Sábado"
        Me.CbSabado.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbViernes)
        Me.GroupBox1.Controls.Add(Me.CbSabado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(548, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 125)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Días a Recibir Curso"
        '
        'TxtHoras
        '
        Me.TxtHoras.BackColor = System.Drawing.Color.DarkKhaki
        Me.TxtHoras.Location = New System.Drawing.Point(521, 162)
        Me.TxtHoras.Name = "TxtHoras"
        Me.TxtHoras.Size = New System.Drawing.Size(151, 27)
        Me.TxtHoras.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(548, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Horas a Cursar"
        '
        'RbEfectivo
        '
        Me.RbEfectivo.AutoSize = True
        Me.RbEfectivo.Location = New System.Drawing.Point(6, 48)
        Me.RbEfectivo.Name = "RbEfectivo"
        Me.RbEfectivo.Size = New System.Drawing.Size(83, 24)
        Me.RbEfectivo.TabIndex = 15
        Me.RbEfectivo.TabStop = True
        Me.RbEfectivo.Text = "Efectivo"
        Me.RbEfectivo.UseVisualStyleBackColor = True
        '
        'RbCheque
        '
        Me.RbCheque.AutoSize = True
        Me.RbCheque.Location = New System.Drawing.Point(148, 48)
        Me.RbCheque.Name = "RbCheque"
        Me.RbCheque.Size = New System.Drawing.Size(80, 24)
        Me.RbCheque.TabIndex = 16
        Me.RbCheque.TabStop = True
        Me.RbCheque.Text = "Cheque"
        Me.RbCheque.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbEfectivo)
        Me.GroupBox2.Controls.Add(Me.RbCheque)
        Me.GroupBox2.Location = New System.Drawing.Point(203, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 99)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column9, Me.Column10, Me.Column8, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 424)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(956, 143)
        Me.DataGridView1.TabIndex = 18
        '
        'Column6
        '
        Me.Column6.HeaderText = "CARNET"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "NOMBRE"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "FECHA"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "HORAS"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "IDIOMA"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column11
        '
        Me.Column11.HeaderText = "FORMA DE PAGO"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "DÍAS"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 125
        '
        'Column13
        '
        Me.Column13.HeaderText = "SUBTOTAL"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 125
        '
        'Column14
        '
        Me.Column14.HeaderText = "DESCUENTO"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 125
        '
        'Column15
        '
        Me.Column15.HeaderText = "TOTAL"
        Me.Column15.MinimumWidth = 6
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 125
        '
        'BtCalcular
        '
        Me.BtCalcular.BackColor = System.Drawing.Color.Salmon
        Me.BtCalcular.Location = New System.Drawing.Point(190, 372)
        Me.BtCalcular.Name = "BtCalcular"
        Me.BtCalcular.Size = New System.Drawing.Size(94, 29)
        Me.BtCalcular.TabIndex = 19
        Me.BtCalcular.Text = "Calcular"
        Me.BtCalcular.UseVisualStyleBackColor = False
        '
        'BtLimpiarE
        '
        Me.BtLimpiarE.BackColor = System.Drawing.Color.Salmon
        Me.BtLimpiarE.Location = New System.Drawing.Point(320, 372)
        Me.BtLimpiarE.Name = "BtLimpiarE"
        Me.BtLimpiarE.Size = New System.Drawing.Size(134, 29)
        Me.BtLimpiarE.TabIndex = 20
        Me.BtLimpiarE.Text = "Limpiar Entradas"
        Me.BtLimpiarE.UseVisualStyleBackColor = False
        '
        'BtLimpiarM
        '
        Me.BtLimpiarM.BackColor = System.Drawing.Color.Salmon
        Me.BtLimpiarM.Location = New System.Drawing.Point(484, 372)
        Me.BtLimpiarM.Name = "BtLimpiarM"
        Me.BtLimpiarM.Size = New System.Drawing.Size(137, 29)
        Me.BtLimpiarM.TabIndex = 21
        Me.BtLimpiarM.Text = "Limpiar Matriz"
        Me.BtLimpiarM.UseVisualStyleBackColor = False
        '
        'BtCerrar
        '
        Me.BtCerrar.BackColor = System.Drawing.Color.Salmon
        Me.BtCerrar.Location = New System.Drawing.Point(644, 372)
        Me.BtCerrar.Name = "BtCerrar"
        Me.BtCerrar.Size = New System.Drawing.Size(94, 29)
        Me.BtCerrar.TabIndex = 22
        Me.BtCerrar.Text = "Cerrar"
        Me.BtCerrar.UseVisualStyleBackColor = False
        '
        'TxtCarnet
        '
        Me.TxtCarnet.BackColor = System.Drawing.Color.DarkKhaki
        Me.TxtCarnet.Location = New System.Drawing.Point(180, 69)
        Me.TxtCarnet.Name = "TxtCarnet"
        Me.TxtCarnet.Size = New System.Drawing.Size(176, 27)
        Me.TxtCarnet.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "Carnet"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Idioma"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Horas"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900438_IDIOMAS.My.Resources.Resources._1
        Me.ClientSize = New System.Drawing.Size(987, 609)
        Me.Controls.Add(Me.TxtCarnet)
        Me.Controls.Add(Me.BtCerrar)
        Me.Controls.Add(Me.BtLimpiarM)
        Me.Controls.Add(Me.BtLimpiarE)
        Me.Controls.Add(Me.BtCalcular)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtHoras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbViernes As CheckBox
    Friend WithEvents CbSabado As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtHoras As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RbEfectivo As RadioButton
    Friend WithEvents RbCheque As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtCalcular As Button
    Friend WithEvents BtLimpiarE As Button
    Friend WithEvents BtLimpiarM As Button
    Friend WithEvents BtCerrar As Button
    Friend WithEvents TxtCarnet As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
End Class
