Imports System.Math
Module Module1
    Public posicion As Byte = 0
    Public Super(6, 9)

    Public Const CTv = 250
    Public Const Ctel = 550
    Public Const Claptop = 770
    Public Const Crefri = 1000
    Public Const LTv = 300
    Public Const Ltel = 600
    Public Const Llaptop = 800
    Public Const Lrefri = 1200

    Public Const Descuento1 = 0.15
    Public Const Descuento2 = 0.05
    Public Const Descuento3 = 0.1
    Public Const Descuento4 = 0.05


    Sub Descuentos()
        If (Form1.CbRefri.Checked) And (Form1.CbTv.Checked) And (Form1.RbCorto.Checked) Then
            Super(posicion, 6) = Val(Super(posicion, 7)) * Descuento1
        ElseIf (Form1.CbRefri.Checked) And (Form1.CbTv.Checked) And (Form1.RbLargo.Checked) Then
            Super(posicion, 6) = Val(Super(posicion, 7)) * Descuento2
        ElseIf (Form1.CbTel.Checked) And (Form1.CbLaptop.Checked) And (Form1.RbLargo.Checked) Then
            Super(posicion, 6) = Val(Super(posicion, 7)) * Descuento3
        ElseIf (Form1.CbTel.Checked) And (Form1.CbLaptop.Checked) And (Form1.RbCorto.Checked) Then
            Super(posicion, 6) = Val(Super(posicion, 7)) * Descuento4
        End If
    End Sub

    Sub MuestreTotales()
        Form1.ListBox1.Items.Add(Super(posicion, 0))
        Form1.ListBox2.Items.Add(Super(posicion, 1))
        Form1.ListBox3.Items.Add(Super(posicion, 2))
        Form1.ListBox4.Items.Add(Super(posicion, 3))
        Form1.ListBox5.Items.Add(Super(posicion, 4))
        Form1.ListBox6.Items.Add(Super(posicion, 5))
        Form1.ListBox7.Items.Add(Val(Super(posicion, 6)))
        Form1.ListBox8.Items.Add(Str(Super(posicion, 7)))
        Form1.ListBox9.Items.Add(Str(Super(posicion, 8)))
    End Sub

    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            LIMPIAR_MATRIZ()
        End If
    End Sub

    Sub limpiar_entradas()
        Form1.TxtNombre.Clear()
        Form1.TxtCui.Clear()
        Form1.TxtDireccion.Clear()
        Form1.TxtCostos.Clear()
        Form1.CbLaptop.Checked = 0
        Form1.CbRefri.Checked = 0
        Form1.CbTel.Checked = 0
        Form1.CbTv.Checked = 0
        Form1.RbCorto.Checked = 0
        Form1.RbLargo.Checked = 0


        Form1.TxtNombre.Focus()
    End Sub

    Sub LIMPIAR_MATRIZ()

        posicion = 0

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
    End Sub



End Module
