Public Class Form1
    Private Sub BtCalcular_Click(sender As Object, e As EventArgs) Handles BtCalcular.Click
        If (VALOR <= 7) Then
            If (TxtCarnet.Text <> "") Then
                ACADEMIA(VALOR, 0) = TxtCarnet.Text
            Else
                MsgBox("ERROR, NO SE INGRESO CARNET")
                TxtCarnet.Focus()
                Exit Sub
            End If
            If (TxtNombre.Text <> "") Then
                ACADEMIA(VALOR, 1) = TxtNombre.Text
            Else
                MsgBox("ERROR, NO SE INGRESO EL NOMBRE")
                TxtNombre.Focus()
                Exit Sub
            End If
            If (TxtFecha.Text <> "") Then
                ACADEMIA(VALOR, 2) = TxtFecha.Text
            Else
                MsgBox("ERROR, NO SE INGRESO FECHA DE INSCRIPCIÓN")
                TxtFecha.Focus()
                Exit Sub
            End If
            If (TxtHoras.Text <> "") Then
                ACADEMIA(VALOR, 3) = TxtHoras.Text
            Else
                MsgBox("ERROR, NO SE INGRESARON HORAS A CURSAR")
                TxtHoras.Focus()
                Exit Sub
            End If
            If (ComboBox1.SelectedIndex > -1) Then
                ACADEMIA(VALOR, 4) = ComboBox1.Text
            Else
                MsgBox("ERROR, NO SELECCIONÓ IDIOMA")
                ComboBox1.Focus()
                Exit Sub
            End If



            If CbViernes.Checked Or CbSabado.Checked Then
                If CbViernes.Checked Then
                    ACADEMIA(VALOR, 6) = CbViernes.Text
                    ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Ingles))
                Else
                    MsgBox("ERROR, NO SELECCIONÓ DÍA")
                    Exit Sub
                End If
                If CbViernes.Checked Then
                    ACADEMIA(VALOR, 6) = CbViernes.Text
                    ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Portugues))
                Else
                    MsgBox("ERROR, NO SELECCIONÓ DÍA")
                    Exit Sub
                End If
                If CbViernes.Checked Then
                    ACADEMIA(VALOR, 6) = CbViernes.Text
                    ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Frances))
                Else
                    MsgBox("ERROR, NO SELECCIONÓ DÍA")
                    Exit Sub
                End If
            End If





            If CbViernes.Checked Or CbSabado.Checked Then
                    If CbSabado.Checked Then
                        ACADEMIA(VALOR, 6) = CbSabado.Text
                        ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Ingles))
                    ElseIf CbSabado.Checked Then
                        ACADEMIA(VALOR, 6) = CbSabado.Text
                        ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Portugues))
                    ElseIf CbSabado.Checked Then
                        ACADEMIA(VALOR, 6) = CbSabado.Text
                        ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Frances))
                    Else
                        MsgBox("ERROR, NO SELECCIONÓ DÍA")
                        Exit Sub
                    End If
                End If



                If (CbViernes.Checked) And (CbSabado.Checked) Then
                    ACADEMIA(VALOR, 6) = CbSabado.Text + CbViernes.Text
                    ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Ingles) + Val((ACADEMIA(VALOR, 3) * Ingles)))
                ElseIf (CbViernes.Checked) And (CbSabado.Checked) Then
                    ACADEMIA(VALOR, 6) = CbSabado.Text + CbViernes.Text
                    ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Portugues) + Val((ACADEMIA(VALOR, 3) * Portugues)))
                ElseIf (CbViernes.Checked) And (CbSabado.Checked) Then
                    ACADEMIA(VALOR, 6) = CbSabado.Text + CbViernes.Text
                    ACADEMIA(VALOR, 7) = Str(Val(ACADEMIA(VALOR, 3) * Frances) + Val((ACADEMIA(VALOR, 3) * Frances)))
                Else
                    MsgBox("ERROR, NO SELECCIONÓ DÍA")
                    Exit Sub
                End If


                If RbEfectivo.Checked Then
                    ACADEMIA(VALOR, 5) = RbEfectivo.Text
                    ACADEMIA(VALOR, 8) = Str(Val(ACADEMIA(VALOR, 7)) * DescuentoEfec)
                ElseIf RbCheque.Checked Then
                    ACADEMIA(VALOR, 5) = RbCheque.Text
                    ACADEMIA(VALOR, 8) = Str(Val(ACADEMIA(VALOR, 7)) * DescuentoCheque)
                ElseIf RbEfectivo.Checked And (CbViernes.Checked) And (CbSabado.Checked) Then
                    ACADEMIA(VALOR, 5) = RbEfectivo.Text
                    ACADEMIA(VALOR, 8) = Str(Val(ACADEMIA(VALOR, 7)) * DescuentoEfec + Val(ACADEMIA(VALOR, 7)) * Descuento2)
                ElseIf RbCheque.Checked And (CbViernes.Checked) And (CbSabado.Checked) Then
                    ACADEMIA(VALOR, 5) = RbCheque.Text
                    ACADEMIA(VALOR, 8) = Str(Val(ACADEMIA(VALOR, 7)) * DescuentoCheque + Val(ACADEMIA(VALOR, 7)) * Descuento2)
                Else
                    MsgBox("ERROR, NO SELECCIONÓ FORMA DE PAGO")
                    Exit Sub
                End If
                ACADEMIA(VALOR, 9) = Str(Val(ACADEMIA(VALOR, 7)) - Val(ACADEMIA(VALOR, 8)))
                MOSTRAR_DATOS()
                VALOR = VALOR + 1

            End If



            If (VALOR = 8) Then
            MsgBox("MATRIZ LLENA")
        End If
    End Sub

    Private Sub BtLimpiarE_Click(sender As Object, e As EventArgs) Handles BtLimpiarE.Click
        ComboBox1.Text = ""
        TxtCarnet.Clear()
        TxtFecha.Clear()
        TxtHoras.Clear()
        TxtNombre.Clear()
        RbCheque.Checked = False
        RbEfectivo.Checked = False
        CbSabado.Checked = False
        CbViernes.Checked = False


    End Sub

    Private Sub BtLimpiarM_Click(sender As Object, e As EventArgs) Handles BtLimpiarM.Click
        VALOR = 0
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles BtCerrar.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        End If
    End Sub
End Class
