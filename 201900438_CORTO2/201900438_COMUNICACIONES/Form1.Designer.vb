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
        Me.TxtNombreE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSueldo = New System.Windows.Forms.TextBox()
        Me.RbTablet = New System.Windows.Forms.RadioButton()
        Me.RbDrone = New System.Windows.Forms.RadioButton()
        Me.RbCelular = New System.Windows.Forms.RadioButton()
        Me.RbTele = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.BtCalcular = New System.Windows.Forms.Button()
        Me.BtLimpiar = New System.Windows.Forms.Button()
        Me.BtCerrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombreE
        '
        Me.TxtNombreE.BackColor = System.Drawing.Color.LightSalmon
        Me.TxtNombreE.Location = New System.Drawing.Point(265, 88)
        Me.TxtNombreE.Name = "TxtNombreE"
        Me.TxtNombreE.Size = New System.Drawing.Size(213, 27)
        Me.TxtNombreE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(305, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(602, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sueldo Bruto"
        '
        'TxtSueldo
        '
        Me.TxtSueldo.BackColor = System.Drawing.Color.LightSalmon
        Me.TxtSueldo.Location = New System.Drawing.Point(556, 88)
        Me.TxtSueldo.Name = "TxtSueldo"
        Me.TxtSueldo.Size = New System.Drawing.Size(213, 27)
        Me.TxtSueldo.TabIndex = 3
        '
        'RbTablet
        '
        Me.RbTablet.AutoSize = True
        Me.RbTablet.Location = New System.Drawing.Point(15, 39)
        Me.RbTablet.Name = "RbTablet"
        Me.RbTablet.Size = New System.Drawing.Size(70, 24)
        Me.RbTablet.TabIndex = 4
        Me.RbTablet.TabStop = True
        Me.RbTablet.Text = "Tablet"
        Me.RbTablet.UseVisualStyleBackColor = True
        '
        'RbDrone
        '
        Me.RbDrone.AutoSize = True
        Me.RbDrone.Location = New System.Drawing.Point(112, 39)
        Me.RbDrone.Name = "RbDrone"
        Me.RbDrone.Size = New System.Drawing.Size(71, 24)
        Me.RbDrone.TabIndex = 5
        Me.RbDrone.TabStop = True
        Me.RbDrone.Text = "Drone"
        Me.RbDrone.UseVisualStyleBackColor = True
        '
        'RbCelular
        '
        Me.RbCelular.AutoSize = True
        Me.RbCelular.Location = New System.Drawing.Point(200, 39)
        Me.RbCelular.Name = "RbCelular"
        Me.RbCelular.Size = New System.Drawing.Size(76, 24)
        Me.RbCelular.TabIndex = 6
        Me.RbCelular.TabStop = True
        Me.RbCelular.Text = "Celular"
        Me.RbCelular.UseVisualStyleBackColor = True
        '
        'RbTele
        '
        Me.RbTele.AutoSize = True
        Me.RbTele.Location = New System.Drawing.Point(298, 39)
        Me.RbTele.Name = "RbTele"
        Me.RbTele.Size = New System.Drawing.Size(88, 24)
        Me.RbTele.TabIndex = 7
        Me.RbTele.TabStop = True
        Me.RbTele.Text = "Televisor"
        Me.RbTele.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSalmon
        Me.GroupBox1.Controls.Add(Me.RbTablet)
        Me.GroupBox1.Controls.Add(Me.RbTele)
        Me.GroupBox1.Controls.Add(Me.RbDrone)
        Me.GroupBox1.Controls.Add(Me.RbCelular)
        Me.GroupBox1.Location = New System.Drawing.Point(308, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 84)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Artículos"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(36, 357)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(150, 204)
        Me.ListBox1.TabIndex = 9
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(240, 357)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(150, 204)
        Me.ListBox2.TabIndex = 10
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(450, 357)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(150, 204)
        Me.ListBox3.TabIndex = 11
        '
        'ListBox4
        '
        Me.ListBox4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(649, 357)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(150, 204)
        Me.ListBox4.TabIndex = 12
        '
        'ListBox5
        '
        Me.ListBox5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 20
        Me.ListBox5.Location = New System.Drawing.Point(844, 357)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(150, 204)
        Me.ListBox5.TabIndex = 13
        '
        'BtCalcular
        '
        Me.BtCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtCalcular.Location = New System.Drawing.Point(284, 247)
        Me.BtCalcular.Name = "BtCalcular"
        Me.BtCalcular.Size = New System.Drawing.Size(94, 29)
        Me.BtCalcular.TabIndex = 14
        Me.BtCalcular.Text = "Calcular"
        Me.BtCalcular.UseVisualStyleBackColor = False
        '
        'BtLimpiar
        '
        Me.BtLimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtLimpiar.Location = New System.Drawing.Point(469, 247)
        Me.BtLimpiar.Name = "BtLimpiar"
        Me.BtLimpiar.Size = New System.Drawing.Size(94, 29)
        Me.BtLimpiar.TabIndex = 15
        Me.BtLimpiar.Text = "Limpiar Vectores"
        Me.BtLimpiar.UseVisualStyleBackColor = False
        '
        'BtCerrar
        '
        Me.BtCerrar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtCerrar.Location = New System.Drawing.Point(635, 247)
        Me.BtCerrar.Name = "BtCerrar"
        Me.BtCerrar.Size = New System.Drawing.Size(94, 29)
        Me.BtCerrar.TabIndex = 16
        Me.BtCerrar.Text = "Cerrar"
        Me.BtCerrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSalmon
        Me.Label3.Location = New System.Drawing.Point(50, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSalmon
        Me.Label4.Location = New System.Drawing.Point(265, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Sueldo Bruto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSalmon
        Me.Label5.Location = New System.Drawing.Point(469, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Comisión"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightSalmon
        Me.Label6.Location = New System.Drawing.Point(674, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Bono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightSalmon
        Me.Label7.Location = New System.Drawing.Point(875, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Sueldo Final"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1035, 573)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtCerrar)
        Me.Controls.Add(Me.BtLimpiar)
        Me.Controls.Add(Me.BtCalcular)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtSueldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombreE)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombreE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSueldo As TextBox
    Friend WithEvents RbTablet As RadioButton
    Friend WithEvents RbDrone As RadioButton
    Friend WithEvents RbCelular As RadioButton
    Friend WithEvents RbTele As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents BtCalcular As Button
    Friend WithEvents BtLimpiar As Button
    Friend WithEvents BtCerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
