Imports System.Math
Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextVenta_TextChanged(sender As Object, e As EventArgs) Handles TextVenta.TextChanged

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim TotalCompra, CDolar, CPeso, CEuro, CColón, CCompra, CVenta, TotalVentas As Double
        Dim Contador, Contador2 As Integer
        Dim Aux, Aux2 As Boolean
        CDolar = 7.69
        CPeso = 0.38
        CEuro = 8.79
        CColón = 0.012
        CCompra = 0.025
        CVenta = 0.03
        Contador = 0
        Contador2 = 0


        If (CompraDolar.Checked = True) Then
            Contador += 1

        End If
        If (CompraPesoM.Checked = True) Then
            Contador += 1

        End If
        If (CompraEuro.Checked = True) Then
            Contador += 1

        End If
        If (CompraColón.Checked = True) Then
            Contador += 1

        End If
        'Este es Contador Para ventas
        If (VentaDolar.Checked = True) Then
            Contador2 += 1

        End If
        If (VentaPesoM.Checked = True) Then
            Contador2 += 1

        End If
        If (VentaEuro.Checked = True) Then
            Contador2 += 1

        End If
        If (VentaColón.Checked = True) Then
            Contador2 += 1

        End If

        'If (Contador <> 1 Or Contador2 <> 1) Then
        'MsgBox("Seleccionó más de una opción en Compra o Venta")
        'End If


        If (TextCompra.Text <> "") Then
            If (CompraDolar.Checked = True) Then
                TotalCompra = (Val(TextCompra.Text) / CDolar) - (Val(TextCompra.Text) / CDolar) * CCompra

            ElseIf (CompraPesoM.Checked) Then
                TotalCompra = (Val(TextCompra.Text) / CPeso) - (Val(TextCompra.Text) / CPeso) * CCompra

            ElseIf (CompraEuro.Checked) Then
                TotalCompra = (Val(TextCompra.Text) / CEuro) - (Val(TextCompra.Text) / CEuro) * CCompra

            ElseIf (CompraColón.Checked) Then
                TotalCompra = (Val(TextCompra.Text) / CColón) - (Val(TextCompra.Text) / CColón) * CCompra


            End If
        End If
        If (TextVenta.Text <> "") Then
            If (VentaDolar.Checked = True) Then
                TotalVentas = (Val(TextVenta.Text) / CDolar) - (Val(TextVenta.Text) / CDolar) * CVenta

            ElseIf (VentaPesoM.Checked) Then
                TotalVentas = (Val(TextVenta.Text) / CPeso) - (Val(TextVenta.Text) / CPeso) * CVenta

            ElseIf (VentaEuro.Checked) Then
                TotalVentas = (Val(TextVenta.Text) / CEuro) - (Val(TextVenta.Text) / CEuro) * CVenta

            ElseIf (VentaColón.Checked) Then
                TotalVentas = (Val(TextVenta.Text) * CColón) - (Val(TextVenta.Text) / CColón) * CVenta

            End If
        End If

        If (TextCompra.Text = "" Or Contador <> 1) Then
            Aux = False
        Else
            Aux = True
        End If

        If (TextVenta.Text = "" Or Contador2 <> 1) Then
            Aux2 = False
        Else
            Aux2 = True

        End If

        If (TextCompra.Text = "" And Contador <> 1) Then
            Aux = True

        End If

        If (TextVenta.Text = "" And Contador2 <> 1) Then
            Aux2 = True

        End If


        TotalCompra = Round(TotalCompra, 2)
        TotalVentas = Round(TotalVentas, 2)


        If (Aux = True And Aux2 = True) Then
            MsgBox("Compra   " + TotalCompra.ToString + "     Venta   " + TotalVentas.ToString, , "TOTAL")
        Else
            MsgBox("-No se han ingresado valores" + vbNewLine + "-Se seleccionó más de una casilla o No se seleccionó ninguna", vbCritical, "ERROR")
        End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        If (MsgBox("¿DESEA CERRAR EL FORMULARIO?", vbQuestion + vbYesNo, "201900438") = vbYes) Then
            Me.Close()
            'End
        End If

    End Sub

End Class
