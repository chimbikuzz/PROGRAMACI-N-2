Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (posicion <= 6) Then

            If (TxtNombre.Text <> "") Then
                Super(posicion, 0) = TxtNombre.Text
            Else
                MsgBox("NO SE INGRESO NOMBRE")
                Exit Sub
            End If

            If (TxtCui.Text <> "") Then
                Super(posicion, 1) = Val(TxtCui.Text)
            Else
                MsgBox("NO SE INGRESO CUI")
                Exit Sub
            End If

            If (TxtDireccion.Text <> "") Then
                Super(posicion, 2) = TxtDireccion.Text
            Else
                MsgBox("NO SE INGRESO CUI")
                Exit Sub
            End If

            If (CbLaptop.Checked) Or (CbRefri.Checked) Or (CbTel.Checked) Or (CbTv.Checked) Then
                Super(posicion, 3) = CbLaptop.Text
                Super(posicion, 3) = CbRefri.Text
                Super(posicion, 3) = CbTel.Text
                Super(posicion, 3) = CbTv.Text
            Else
                MsgBox("NO SELECCIONÓ NINGÚN APARATO")
                Exit Sub
            End If

            If (RbCorto.Checked) Or (RbLargo.Checked) Then
                Super(posicion, 4) = RbCorto.Text
                Super(posicion, 4) = RbLargo.Text
            Else
                MsgBox("NO SELECCIONÓ NINGUN PLAZO")
                Exit Sub
            End If

            If (TxtCostos.Text <> "") Then
                Super(posicion, 5) = TxtCostos.Text
            Else
                MsgBox("NO SE INGRESO NINGUN COSTO")
                Exit Sub
            End If

            Descuentos()

            If (CbLaptop.Checked) And (RbCorto.Checked) Then
                Super(posicion, 7) = Val(TxtCostos.Text) + Claptop
            End If
            If (CbLaptop.Checked) Or (CbRefri.Checked) And (RbCorto.Checked) Then
                Super(posicion, 7) = Val(Super(posicion, 5)) + Claptop + Crefri
            End If
            If (CbLaptop.Checked) Or (CbRefri.Checked) Or (CbTel.Checked) And (RbCorto.Checked) Then
                Super(posicion, 7) = Val(Super(posicion, 5)) + Claptop + Crefri + Ctel
            End If
            If (CbLaptop.Checked) Or (CbRefri.Checked) Or (CbTel.Checked) Or (CbTv.Checked) And (RbCorto.Checked) Then
                Super(posicion, 7) = Val(Super(posicion, 5)) + Claptop + Crefri + Ctel + CTv
            End If

            If (CbLaptop.Checked) And (RbLargo.Checked) Then
                Super(posicion, 7) = Val(Super(posicion, 5)) + Llaptop
            End If
            If (CbLaptop.Checked) Or (CbRefri.Checked) And (RbLargo.Checked) Then
                Super(posicion, 7) = Val(Super(posicion, 5)) + Llaptop + Lrefri
            End If
            If (CbLaptop.Checked) Or (CbRefri.Checked) Or (CbTel.Checked) And (RbLargo.Checked) Then
                Super(posicion, 7) = Val(Super(posicion, 5)) + Llaptop + Lrefri + Ltel
                End If
            If (CbLaptop.Checked) Or (CbRefri.Checked) Or (CbTel.Checked) Or (CbTv.Checked) And (RbLargo.Checked) Then
                Super(posicion, 7) = Val(Super(posicion, 5)) + Llaptop + Lrefri + Ltel + LTv
            End If

            Super(posicion, 8) = Val(Super(posicion, 7)) - Val(Super(posicion, 6))

            MuestreTotales()
            posicion = posicion + 1

        End If

        If (posicion = 7) Then
            MsgBox("MATRIZ LLENA")
        End If

    End Sub


    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Call limpiar_entradas()
        TxtNombre.Focus()


    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        Call LIMPIAR_MATRIZ()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Call salir()
    End Sub
End Class
