Public Class Form1

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        Dim temp1 As Double = 0

        If (chimbi <= 9) Then
            If (TxtNombre.Text <> "") Then
                Nombre(chimbi) = TxtNombre.Text
            Else
                MsgBox("ERROR, NO SE INGRESO EL NOMBRE")
                TxtNombre.Focus()
                Exit Sub
            End If


            If (TxtValor.Text <> "") Then
                Precio(chimbi) = TxtValor.Text
            Else
                MsgBox("ERROR, NO SE INGRESO NINGUN VALOR")
                TxtValor.Focus()
                Exit Sub
            End If

            If (TxtPeso.Text <> "") Then
                Peso(chimbi) = TxtPeso.Text
            Else
                MsgBox("ERROR, NO SE INGRESO EL PESO DEL PAQUETE")
                TxtPeso.Focus()
                Exit Sub
            End If

            If (ComboBox2.SelectedIndex > -1) Then
                TipoDeEn(chimbi) = ComboBox2.Text
            Else
                MsgBox("ERROR, NO SELECCIONÓ TIPO DE HABITACIÓN")
                ComboBox2.Focus()
                Exit Sub
            End If

            Impuesto(chimbi) = CalculoImpuesto()

            Parcial(chimbi) = 0
            Select Case (ComboBox2.SelectedIndex)
                Case 0 : CAMI()
                Case 1 : MOTO()
            End Select

            Total(chimbi) = 0
            Select Case (ComboBox2.SelectedIndex)
                Case 0 : Tot1()
                Case 1 : Tot2()
            End Select






            'DataGridView1.Rows.Add(Nombre(chimbi), Precio(chimbi), Peso(chimbi), TipoDeEn(chimbi), TipoDePa(chimbi), Parcial(chimbi), Impuesto(chimbi), Total(chimbi))
            chimbi = chimbi + 1
            Limpiar_Entradas()
        End If
        If (chimbi = 10) Then
            MsgBox("Vectores llenos")
        End If
    End Sub

    Private Sub MostrarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarVectoresToolStripMenuItem.Click
        Mostrar()
    End Sub

    Private Sub CalcularEstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularEstadísticasToolStripMenuItem.Click
        Dim i As Byte
        Dim TotLocio As Double
        Dim PaquetesPlas As Double
        Dim TotDocum As Double
        Dim PaquetesRopa As Double

        TotLocio = 0
        PaquetesPlas = 0
        TotDocum = 0
        PaquetesRopa = 0

        If (DataGridView1.Rows.Count <> 1) Then
            For i = 0 To DataGridView1.Rows.Count - 1

                If (TipoDePa(i) = "Lociones") Then
                    TotLocio = TotLocio + Total(i)
                End If

                If (TipoDePa(i) = "Articulos de Plástico") Then
                    PaquetesPlas = PaquetesPlas + 1
                End If

                If (TipoDePa(i) = "Documentos") Then
                    TotDocum = TotDocum + Total(i)
                End If

                If (TipoDePa(i) = "Ropa") Then
                    PaquetesRopa = PaquetesRopa + 1
                End If

            Next i
        End If

        TextBox1.Text = Str(TotLocio)
        TextBox2.Text = Str(PaquetesPlas)
        TextBox3.Text = Str(TotDocum)
        TextBox4.Text = Str(PaquetesRopa)

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Limpiar_Entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub LimpiarEstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadísticasToolStripMenuItem.Click
        Limpiar_Estadisticas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub
End Class
