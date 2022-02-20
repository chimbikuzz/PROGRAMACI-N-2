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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RbSmall = New System.Windows.Forms.RadioButton()
        Me.RbMedium = New System.Windows.Forms.RadioButton()
        Me.RbLarge = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbAlgodon = New System.Windows.Forms.RadioButton()
        Me.RbLona = New System.Windows.Forms.RadioButton()
        Me.RbSeda = New System.Windows.Forms.RadioButton()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(219, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FABRICA DE CHUMBAS"
        '
        'RbSmall
        '
        Me.RbSmall.AutoSize = True
        Me.RbSmall.Location = New System.Drawing.Point(34, 55)
        Me.RbSmall.Name = "RbSmall"
        Me.RbSmall.Size = New System.Drawing.Size(67, 24)
        Me.RbSmall.TabIndex = 1
        Me.RbSmall.TabStop = True
        Me.RbSmall.Text = "Small"
        Me.RbSmall.UseVisualStyleBackColor = True
        '
        'RbMedium
        '
        Me.RbMedium.AutoSize = True
        Me.RbMedium.Location = New System.Drawing.Point(187, 55)
        Me.RbMedium.Name = "RbMedium"
        Me.RbMedium.Size = New System.Drawing.Size(85, 24)
        Me.RbMedium.TabIndex = 2
        Me.RbMedium.TabStop = True
        Me.RbMedium.Text = "Medium"
        Me.RbMedium.UseVisualStyleBackColor = True
        '
        'RbLarge
        '
        Me.RbLarge.AutoSize = True
        Me.RbLarge.Location = New System.Drawing.Point(356, 55)
        Me.RbLarge.Name = "RbLarge"
        Me.RbLarge.Size = New System.Drawing.Size(67, 24)
        Me.RbLarge.TabIndex = 3
        Me.RbLarge.TabStop = True
        Me.RbLarge.Text = "Large"
        Me.RbLarge.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.RbSmall)
        Me.GroupBox1.Controls.Add(Me.RbLarge)
        Me.GroupBox1.Controls.Add(Me.RbMedium)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 125)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño de Chumpa"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.RbAlgodon)
        Me.GroupBox2.Controls.Add(Me.RbLona)
        Me.GroupBox2.Controls.Add(Me.RbSeda)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(467, 125)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Material"
        '
        'RbAlgodon
        '
        Me.RbAlgodon.AutoSize = True
        Me.RbAlgodon.Location = New System.Drawing.Point(34, 55)
        Me.RbAlgodon.Name = "RbAlgodon"
        Me.RbAlgodon.Size = New System.Drawing.Size(88, 24)
        Me.RbAlgodon.TabIndex = 1
        Me.RbAlgodon.TabStop = True
        Me.RbAlgodon.Text = "Algodón"
        Me.RbAlgodon.UseVisualStyleBackColor = True
        '
        'RbLona
        '
        Me.RbLona.AutoSize = True
        Me.RbLona.Location = New System.Drawing.Point(356, 55)
        Me.RbLona.Name = "RbLona"
        Me.RbLona.Size = New System.Drawing.Size(62, 24)
        Me.RbLona.TabIndex = 3
        Me.RbLona.TabStop = True
        Me.RbLona.Text = "Lona"
        Me.RbLona.UseVisualStyleBackColor = True
        '
        'RbSeda
        '
        Me.RbSeda.AutoSize = True
        Me.RbSeda.Location = New System.Drawing.Point(187, 55)
        Me.RbSeda.Name = "RbSeda"
        Me.RbSeda.Size = New System.Drawing.Size(63, 24)
        Me.RbSeda.TabIndex = 2
        Me.RbSeda.TabStop = True
        Me.RbSeda.Text = "Seda"
        Me.RbSeda.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtCantidad.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtCantidad.Location = New System.Drawing.Point(177, 420)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(205, 27)
        Me.TxtCantidad.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(107, 500)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Location = New System.Drawing.Point(238, 500)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Location = New System.Drawing.Point(362, 500)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(587, 559)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RbSmall As RadioButton
    Friend WithEvents RbMedium As RadioButton
    Friend WithEvents RbLarge As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RbAlgodon As RadioButton
    Friend WithEvents RbLona As RadioButton
    Friend WithEvents RbSeda As RadioButton
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
