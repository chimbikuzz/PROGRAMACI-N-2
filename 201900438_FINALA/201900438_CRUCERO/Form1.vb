Public Class Form1
    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        If (chimbi <= 5) Then
            If (TxtCliente.Text <> "") Then
                NIT(chimbi) = TxtCliente.Text
            Else
                MsgBox("ERROR, NO SE INGRESO EL NOMBRE")
                TxtNombre.Focus()
                Exit Sub
            End If

            If (TxtPersonas.Text <> "") Then
                PERSONAS(chimbi) = TxtPersonas.Text
            Else
                MsgBox("ERROR, NO SE INGRESO NINGUN VALOR")
                TxtPersonas.Focus()
                Exit Sub
            End If

            PRECIOI(chimbi) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : PRIMERACLASE()
                Case 1 : SEGUNDACLASE()
            End Select

            TOTAL(chimbi) = Val(PRECIOI(chimbi)) * Val(PERSONAS(chimbi))

            chimbi = chimbi + 1
            Limpiar_Entradas()
        End If

        If (chimbi = 6) Then
            MsgBox("Vectores llenos")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Mostrar()
    End Sub



    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub DatosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeEntradaToolStripMenuItem.Click
        Limpiar_Entradas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub ConsularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsularToolStripMenuItem.Click
        Dim existe As Boolean = False
        chimbi = 0
        While (chimbi <= 5) And Not (existe)
            If (NIT(chimbi) = Val(TxtConsulta.Text)) Then
                existe = True
            Else
                chimbi = chimbi + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            TxtCliente.Text = Str(NIT(chimbi))
            If (RbCompar.Checked) Or (RbDoble.Checked) Or (RbSencilla.Checked) Then
                RbCompar.Text = Str(TCABINA(chimbi))
                RbDoble.Text = Str(TCABINA(chimbi))
                RbSencilla.Text = Str(TCABINA(chimbi))
            End If
            TxtPersonas.Text = Str(PERSONAS(chimbi))
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(NIT(chimbi)), TCABINA(chimbi), Str(PERSONAS(chimbi)), PRECIOI(chimbi), Str(TOTAL(chimbi)))
            numero = chimbi
        Else
            MsgBox("Etapa no encontrada")
            TxtConsulta.Focus()
        End If
    End Sub
End Class
