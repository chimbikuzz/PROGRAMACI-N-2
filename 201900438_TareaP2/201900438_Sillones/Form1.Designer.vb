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
        Me.RbSofa = New System.Windows.Forms.RadioButton()
        Me.RbIndi = New System.Windows.Forms.RadioButton()
        Me.RbDoble = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbCuerina = New System.Windows.Forms.RadioButton()
        Me.RbCuero = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNVenta = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RbSofa
        '
        Me.RbSofa.AutoSize = True
        Me.RbSofa.Location = New System.Drawing.Point(18, 39)
        Me.RbSofa.Name = "RbSofa"
        Me.RbSofa.Size = New System.Drawing.Size(60, 24)
        Me.RbSofa.TabIndex = 0
        Me.RbSofa.TabStop = True
        Me.RbSofa.Text = "Sofá"
        Me.RbSofa.UseVisualStyleBackColor = True
        '
        'RbIndi
        '
        Me.RbIndi.AutoSize = True
        Me.RbIndi.Location = New System.Drawing.Point(94, 39)
        Me.RbIndi.Name = "RbIndi"
        Me.RbIndi.Size = New System.Drawing.Size(95, 24)
        Me.RbIndi.TabIndex = 1
        Me.RbIndi.TabStop = True
        Me.RbIndi.Text = "Individual"
        Me.RbIndi.UseVisualStyleBackColor = True
        '
        'RbDoble
        '
        Me.RbDoble.AutoSize = True
        Me.RbDoble.Location = New System.Drawing.Point(216, 39)
        Me.RbDoble.Name = "RbDoble"
        Me.RbDoble.Size = New System.Drawing.Size(71, 24)
        Me.RbDoble.TabIndex = 2
        Me.RbDoble.TabStop = True
        Me.RbDoble.Text = "Doble"
        Me.RbDoble.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.RbSofa)
        Me.GroupBox1.Controls.Add(Me.RbDoble)
        Me.GroupBox1.Controls.Add(Me.RbIndi)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 90)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Sillones"
        '
        'RbCuerina
        '
        Me.RbCuerina.AutoSize = True
        Me.RbCuerina.Location = New System.Drawing.Point(102, 39)
        Me.RbCuerina.Name = "RbCuerina"
        Me.RbCuerina.Size = New System.Drawing.Size(80, 24)
        Me.RbCuerina.TabIndex = 1
        Me.RbCuerina.TabStop = True
        Me.RbCuerina.Text = "Cuerina"
        Me.RbCuerina.UseVisualStyleBackColor = True
        '
        'RbCuero
        '
        Me.RbCuero.AutoSize = True
        Me.RbCuero.Location = New System.Drawing.Point(18, 39)
        Me.RbCuero.Name = "RbCuero"
        Me.RbCuero.Size = New System.Drawing.Size(69, 24)
        Me.RbCuero.TabIndex = 0
        Me.RbCuero.TabStop = True
        Me.RbCuero.Text = "Cuero"
        Me.RbCuero.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.RbCuero)
        Me.GroupBox2.Controls.Add(Me.RbCuerina)
        Me.GroupBox2.Location = New System.Drawing.Point(491, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 90)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Material"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtCantidad.Location = New System.Drawing.Point(164, 192)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(228, 27)
        Me.TxtCantidad.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(89, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cantidad"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarGridToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(811, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.BackColor = System.Drawing.Color.Gold
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarGridToolStripMenuItem
        '
        Me.LimpiarGridToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue
        Me.LimpiarGridToolStripMenuItem.Name = "LimpiarGridToolStripMenuItem"
        Me.LimpiarGridToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.LimpiarGridToolStripMenuItem.Text = "Limpiar Grid"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(428, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Numero de Venta"
        '
        'TxtNVenta
        '
        Me.TxtNVenta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtNVenta.Location = New System.Drawing.Point(559, 196)
        Me.TxtNVenta.Name = "TxtNVenta"
        Me.TxtNVenta.Size = New System.Drawing.Size(150, 27)
        Me.TxtNVenta.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.DataGridViewTextBoxColumn1, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(49, 254)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(728, 245)
        Me.DataGridView1.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Número De Venta"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 170
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sillones"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Precio Costo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio Venta"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(811, 526)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtNVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RbSofa As RadioButton
    Friend WithEvents RbIndi As RadioButton
    Friend WithEvents RbDoble As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbCuerina As RadioButton
    Friend WithEvents RbCuero As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNVenta As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents LimpiarGridToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
End Class
