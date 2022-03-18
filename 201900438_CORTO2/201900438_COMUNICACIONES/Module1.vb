Module Module1
    Public Posicion As Byte = 0
    Public Nombre(7) As String
    Public Sueldo(7) As Double
    Public Comision(7) As Double
    Public Bono(7) As Double
    Public SueldoFinal(7) As Double

    Public Const Tablet = 375
    Public Const Drone = 560
    Public Const Celular = 1450
    Public Const Televisor = 3250

    Public Const Bono1 = 0.03
    Public Const Bono2 = 0.04
    Public Const Bono3 = 0.05
    Public Const Comis = 0.055


    Function Comi() As Double
        Dim desc As Double
        If (Form1.RbTablet.Checked) Then
            desc = Tablet * Comis
            Return desc
        ElseIf (Form1.RbDrone.Checked) Then
            desc = Drone * Comis
            Return desc
        ElseIf (Form1.RbCelular.Checked) Then
            desc = Celular * Comis
            Return desc
        ElseIf (Form1.RbTele.Checked) Then
            desc = Televisor * Comis
            Return desc
        End If


    End Function


    Function TotalFinal() As Double
        TotalFinal = (Sueldo(Posicion)) + (Comision(Posicion)) + (Bono(Posicion))
        Return TotalFinal
    End Function

    Sub MUESTRETOTALES()
        Form1.ListBox1.Items.Add(Nombre(Posicion))
        Form1.ListBox2.Items.Add(Str(Sueldo(Posicion)))
        Form1.ListBox3.Items.Add(Str(Comision(Posicion)))
        Form1.ListBox4.Items.Add(Bono(Posicion))
        Form1.ListBox5.Items.Add(Str(SueldoFinal(Posicion)))
    End Sub

    Sub Limpiar_Vectores()

        Posicion = 0

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
    End Sub

    Sub Limpiar_Entradas()
        Form1.TxtNombreE.Clear()
        Form1.TxtSueldo.Clear()
        Form1.RbCelular.Checked = 0
        Form1.RbDrone.Checked = 0
        Form1.RbTablet.Checked = 0
        Form1.RbTele.Checked = 0

        Form1.TxtNombreE.Focus()
    End Sub

    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            Limpiar_Entradas()
            Limpiar_Vectores()
        End If
    End Sub





End Module

