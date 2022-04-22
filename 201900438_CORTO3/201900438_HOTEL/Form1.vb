Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (chimbi <= 6) Then
            If (TxtNombre.Text <> "") Then
                Nombre(chimbi) = TxtNombre.Text
            Else
                MsgBox("ERROR, NO SE INGRESO EL NOMBRE")
                TxtNombre.Focus()
                Exit Sub
            End If

            If (TxtNIT.Text <> "") Then
                NIT(chimbi) = TxtNIT.Text
            Else
                MsgBox("ERROR, NO SE INGRESO NIT")
                TxtNIT.Focus()
                Exit Sub
            End If

            If (TxtDías.Text <> "") Then
                Días(chimbi) = TxtDías.Text
            Else
                MsgBox("ERROR, NO SE INGRESO NINGUN VALOR")
                TxtDías.Focus()
                Exit Sub
            End If

            If (ComboBox1.SelectedIndex > -1) Then
                TipoHab(chimbi) = ComboBox1.Text
            Else
                MsgBox("ERROR, NO SELECCIONÓ TIPO DE HABITACIÓN")
                ComboBox1.Focus()
                Exit Sub
            End If

            Parcial(chimbi) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : SENC()
                Case 1 : DOB()
                Case 2 : CAB()

            End Select

            Impuesto(chimbi) = CalculoImpuesto()

            Total(chimbi) = Val(Parcial(chimbi)) + Val(Impuesto(chimbi))

            chimbi = chimbi + 1
            'Limpiar_Entradas()

        End If
        If (chimbi = 17) Then
            MsgBox("Vectores llenos")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Limpiar_Vectores()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False

        I = 0


        While (I <= 7) And Not (existe)

            If (NIT(I) = Val(TxtNIT.Text)) Then
                existe = True '
            Else
                I = I + 1  '
            End If
        End While


        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TxtNombre.Text = Str(Nombre(I))
            TxtNIT.Text = NIT(I)
            TxtDías.Text = Str(Días(I))
            RbEfectivo.Text = (TipoDePa(I))
            RbDep.Text = (TipoDePa(I))
            RbTarjeta.Text = (TipoDePa(I))
            RbTrans.Text = (TipoDePa(I))
            ComboBox1.Text = TipoHab(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Nombre(I)), NIT(I), (Días(I)), (TipoHab(I)), (TipoDePa(I)), Parcial(I), (Impuesto(I)), Total(I))

            chimbi = I
        Else
            MsgBox("NIT no encontrado")
            TxtConsultar.Focus()
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Nombre(chimbi) = Nothing
        NIT(chimbi) = Nothing
        Días(chimbi) = Nothing
        TipoHab(chimbi) = Nothing
        TipoDePa(chimbi) = Nothing
        Parcial(chimbi) = Nothing
        Impuesto(chimbi) = Nothing
        Total(chimbi) = Nothing

        For I = chimbi To 5

            Nombre(chimbi) = Nombre(I + 1)
            NIT(chimbi) = NIT(I + 1)
            Días(chimbi) = Días(I + 1)
            TipoHab(chimbi) = TipoHab(I + 1)
            TipoDePa(chimbi) = TipoDePa(I + 1)
            Parcial(chimbi) = Parcial(I + 1)
            Impuesto(chimbi) = Impuesto(I + 1)
            Total(chimbi) = Total(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        Nombre(chimbi) = Nothing
        NIT(chimbi) = Nothing
        Días(chimbi) = Nothing
        TipoHab(chimbi) = Nothing
        TipoDePa(chimbi) = Nothing
        Parcial(chimbi) = Nothing
        Impuesto(chimbi) = Nothing
        Total(chimbi) = Nothing

        chimbi = I
        DataGridView1.Rows.Clear()
    End Sub

End Class
