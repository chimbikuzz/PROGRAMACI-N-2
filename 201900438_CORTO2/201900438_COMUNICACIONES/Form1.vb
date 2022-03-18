Public Class Form1
    Private Sub BtCalcular_Click(sender As Object, e As EventArgs) Handles BtCalcular.Click
        Dim temp1 As Double = 0

        If (Posicion <= 6) Then
            If (TxtNombreE.Text <> "") Then
                Nombre(Posicion) = TxtNombreE.Text
            Else
                MsgBox("ERROR, NO SE INGRESO EL NOMBRE")
                TxtNombreE.Focus()
                Exit Sub
            End If

            If (TxtSueldo.Text <> "") Then
                Sueldo(Posicion) = TxtSueldo.Text
            Else
                MsgBox("ERROR, NO SE INGRESO EL SUELDO")
                TxtNombreE.Focus()
                Exit Sub
            End If

            Comision(Posicion) = Comi()

            If (Val(Sueldo(Posicion)) >= 1) And (Val(Sueldo(Posicion)) <= 2000) Then
                Bono(Posicion) = Val(Sueldo(Posicion)) * Bono1
            ElseIf (Val(Sueldo(Posicion)) >= 2001) And (Val(Sueldo(Posicion)) <= 5000) Then
                Bono(Posicion) = Val(Sueldo(Posicion)) * Bono2
            ElseIf (Val(Sueldo(Posicion)) >= 5001) Then
                Bono(Posicion) = Val(Sueldo(Posicion)) * Bono3
            End If

            SueldoFinal(Posicion) = TotalFinal()
            MUESTRETOTALES()
            Posicion = Posicion + 1
        End If

        If Posicion = 7 Then
            MsgBox("VECTORES LLENOS")
            limpiar_entradas()
        End If


    End Sub

    Private Sub BtLimpiar_Click(sender As Object, e As EventArgs) Handles BtLimpiar.Click
        Call Limpiar_Vectores()
    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles BtCerrar.Click
        Call salir()

    End Sub
End Class
