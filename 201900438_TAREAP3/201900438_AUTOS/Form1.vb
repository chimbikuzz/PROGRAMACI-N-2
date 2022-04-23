Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim temp1 As Double = 0

        If (chimbi <= 9) Then
            If (TxtPlaca.Text <> "") Then
                Placa(chimbi) = TxtPlaca.Text
            Else
                MsgBox("ERROR, NO SE INGRESO NO. PLACA")
                TxtPlaca.Focus()
                Exit Sub
            End If

            If (RbT1.Checked) Or (RbT2.Checked) Or (RbT3.Checked) Or (RbT4.Checked) Then
                If (RbT1.Checked) Then
                    TAuto(chimbi) = RbT1.Text
                    CBase(chimbi) = tipo1
                End If
                If (RbT2.Checked) Then
                    TAuto(chimbi) = RbT2.Text
                    CBase(chimbi) = tipo2
                End If
                If (RbT3.Checked) Then
                    TAuto(chimbi) = RbT3.Text
                    CBase(chimbi) = tipo3
                End If
                If (RbT4.Checked) Then
                    TAuto(chimbi) = RbT4.Text
                    CBase(chimbi) = tipo4
                End If
            Else
                MsgBox("No se seleccionó tipo de auto")
                Exit Sub
            End If

            If (TxtKinicial.Text <> "") Then
                Kinicial(chimbi) = TxtKinicial.Text
            Else
                MsgBox("ERROR, NO SE INGRESO KM INICIAL")
                TxtKinicial.Focus()
                Exit Sub
            End If

            If (TxtKfinal.Text <> "") Then
                Kfinal(chimbi) = TxtKfinal.Text
            Else
                MsgBox("ERROR, NO SE INGRESO KM FINAL")
                TxtKfinal.Focus()
                Exit Sub
            End If

            Total(chimbi) = Val(CBase(chimbi)) + CalculoImpuesto()

            chimbi = chimbi + 1
            Limpiar_Entradas()

        End If
        If (chimbi = 7) Then
            MsgBox("Vectores llenos")
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_Vectores()
        Limpiar_Entradas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 6) And Not (existe)
            If (Placa(I) = Val(TxtPlacaC.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            TxtPlaca.Text = Str(Placa(I))
            If (RbT1.Checked) Then
                RbT1.Text = TAuto(I)
            End If
            If (RbT2.Checked) Then
                RbT2.Text = TAuto(I)
            End If
            If (RbT3.Checked) Then
                RbT3.Text = TAuto(I)
            End If
            If (RbT4.Checked) Then
                RbT4.Text = TAuto(I)
            End If
            TxtKinicial.Text = Str(Kinicial(I))
                TxtKfinal.Text = Str(Kfinal(I))

                DataGridView1.Rows.Clear()
                DataGridView1.Rows.Add(Placa(I), TAuto(I), CBase(I), Kinicial(I), Kfinal(I), Total(I))
                chimbi = I
            Else
                MsgBox("Carnet no encontrado")
            TxtPlacaC.Focus()
        End If


    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        If (TxtPlaca.Text <> "") Then
            Placa(chimbi) = TxtPlaca.Text
        Else
            MsgBox("ERROR, NO SE INGRESO NO. PLACA")
            TxtPlaca.Focus()
            Exit Sub
        End If

        If (RbT1.Checked) Or (RbT2.Checked) Or (RbT3.Checked) Or (RbT4.Checked) Then
            If (RbT1.Checked) Then
                TAuto(chimbi) = RbT1.Text
                CBase(chimbi) = tipo1
            End If
            If (RbT2.Checked) Then
                TAuto(chimbi) = RbT2.Text
                CBase(chimbi) = tipo2
            End If
            If (RbT3.Checked) Then
                TAuto(chimbi) = RbT3.Text
                CBase(chimbi) = tipo3
            End If
            If (RbT4.Checked) Then
                TAuto(chimbi) = RbT4.Text
                CBase(chimbi) = tipo4
            End If
        Else
            MsgBox("No se seleccionó tipo de auto")
            Exit Sub
        End If

        If (TxtKinicial.Text <> "") Then
            Kinicial(chimbi) = TxtKinicial.Text
        Else
            MsgBox("ERROR, NO SE INGRESO KM INICIAL")
            TxtKinicial.Focus()
            Exit Sub
        End If

        If (TxtKfinal.Text <> "") Then
            Kfinal(chimbi) = TxtKfinal.Text
        Else
            MsgBox("ERROR, NO SE INGRESO KM FINAL")
            TxtKfinal.Focus()
            Exit Sub
        End If

        Total(chimbi) = Val(CBase(chimbi)) + CalculoImpuesto()
        MsgBox("Registro actualizado correctamente en los vectores")
        TxtPlacaC.Clear()
        chimbi = 7

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Placa(chimbi) = Nothing
        TAuto(chimbi) = Nothing
        CBase(chimbi) = Nothing
        Kinicial(chimbi) = Nothing
        Kfinal(chimbi) = Nothing
        Total(chimbi) = Nothing

        For I = chimbi To 5
            Placa(I) = Placa(I + 1)
            TAuto(I) = TAuto(I + 1)
            CBase(I) = CBase(I + 1)
            Kinicial(I) = Kinicial(I + 1)
            Kfinal(I) = Kfinal(I + 1)
            Total(I) = Total(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")
        Placa(I) = Nothing
        TAuto(I) = Nothing
        CBase(I) = Nothing
        Kinicial(I) = Nothing
        Kfinal(I) = Nothing
        Total(I) = Nothing
        chimbi = I
        Limpiar_Entradas()
        DataGridView1.Rows.Clear()
    End Sub
End Class
