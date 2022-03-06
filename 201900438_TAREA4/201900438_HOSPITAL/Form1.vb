Public Class Form1
    Private Sub BtCalcular_Click(sender As Object, e As EventArgs) Handles BtCalcular.Click
        Dim temp1 As Double = 0

        If (Posicion <= 5) Then
            If (TxtNombrePaciente.Text <> "") Then
                Paciente(Posicion) = TxtNombrePaciente.Text
            Else
                MsgBox("ERROR, NO SE INGRESO EL NOMBRE")
                TxtNombrePaciente.Focus()
                Exit Sub
            End If
            If (TxtNIT.Text <> "") Then
                NIT(Posicion) = TxtNIT.Text
            Else
                MsgBox("ERROR, NO SE INGRESO NIT")
                TxtNIT.Focus()
                Exit Sub
            End If
            If (TxtHM.Text <> "") Then
                HMedicos(Posicion) = TxtHM.Text
            Else
                MsgBox("ERROR, NO SE INGRESO NINGUN DATO")
                TxtDíasH.Focus()
                Exit Sub
            End If
            If (ComboBox1.SelectedIndex > -1) Then
                FormaPago(Posicion) = ComboBox1.Text
            Else
                MsgBox("ERROR, NO SELECCIONÓ TIPO DE HABITACIÓN")
                ComboBox1.Focus()
                Exit Sub
            End If

            SubTotal(Posicion) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : SPRIVADA()
                Case 1 : SSEMI()
                Case 2 : NOTP()
            End Select

            Descuento(Posicion) = CalculoDescuentoRecargo()
            Total(Posicion) = TotalFinal()
            MUESTRETOTALES()
            Posicion = Posicion + 1
        End If


        If Posicion = 6 Then
            MsgBox("VECTORES LLENOS")
            limpiar_entradas()
        End If


    End Sub

    Private Sub BtLimpiarE_Click(sender As Object, e As EventArgs) Handles BtLimpiarE.Click
        Call limpiar_entradas()
    End Sub

    Private Sub BtListB_Click(sender As Object, e As EventArgs) Handles BtListB.Click
        Call LIMPIAR_VECTORES()
    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles BtCerrar.Click
        Call salir()
    End Sub






End Class
