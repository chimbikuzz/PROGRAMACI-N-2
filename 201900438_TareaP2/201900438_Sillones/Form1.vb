Imports System.Math
Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim temp1 As Double = 0

        If (Posicion <= 7) Then
            If (TxtNVenta.Text <> "") Then
                NVenta(Posicion) = TxtNVenta.Text
            Else
                MsgBox("ERROR, NO SE INGRESO NO. DE VENTA")
                TxtNVenta.Focus()
                Exit Sub
            End If

            If (TxtCantidad.Text <> "") Then
                Cantidad(Posicion) = TxtCantidad.Text
            Else
                MsgBox("ERROR, NO SE INGRESO CANTIDAD")
                TxtCantidad.Focus()
                Exit Sub
            End If


            If (RbSofa.Checked) And (RbCuero.Checked) Then
                SillonesDeSala(Posicion) = RbSofa.Text
                PrecioCosto(Posicion) = Round((MOSofa + (Cuero * YSofa)) * Val(Cantidad(Posicion)), 2)
            ElseIf (RbSofa.Checked) And (RbCuerina.Checked) Then
                SillonesDeSala(Posicion) = RbSofa.Text
                PrecioCosto(Posicion) = Round((MOSofa + (Cuerina * YSofa)) * Val(Cantidad(Posicion)), 2)
            End If

            If (RbIndi.Checked) And (RbCuero.Checked) Then
                SillonesDeSala(Posicion) = RbIndi.Text
                PrecioCosto(Posicion) = Round((MOIndividual + (Cuero * YIndividual)) * Val(Cantidad(Posicion)), 2)
            ElseIf (RbIndi.Checked) And (RbCuerina.Checked) Then
                SillonesDeSala(Posicion) = RbIndi.Text
                PrecioCosto(Posicion) = Round((MOIndividual + (Cuerina * YIndividual)) * Val(Cantidad(Posicion)), 2)
            End If

            If (RbDoble.Checked) And (RbCuero.Checked) Then
                SillonesDeSala(Posicion) = RbDoble.Text
                PrecioCosto(Posicion) = Round((MODoble + (Cuero * YDoble)) * Val(Cantidad(Posicion)), 2)
            ElseIf (RbDoble.Checked) And (RbCuerina.Checked) Then
                SillonesDeSala(Posicion) = RbDoble.Text
                PrecioCosto(Posicion) = Round((MODoble + (Cuerina * YDoble)) * Val(Cantidad(Posicion)), 2)
            End If

            PrecioVenta(Posicion) = TotalFinal()
            MUESTRETOTALES()
            Posicion = Posicion + 1
        End If

        If Posicion = 8 Then
            MsgBox("VECTORES LLENOS")
            Limpiar_entradas()
        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Call Limpiar_entradas()
    End Sub

    Private Sub LimpiarGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarGridToolStripMenuItem.Click
        Call LIMPIAR_VECTORES()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Call salir()
    End Sub

    Private Sub TxtNVenta_TextChanged(sender As Object, e As EventArgs) Handles TxtNVenta.TextChanged

    End Sub
End Class
