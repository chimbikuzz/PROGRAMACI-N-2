Imports System.Math
Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextFrijol.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextArroz.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextArroz.Clear()
        TextAzucar.Clear()
        TextFrijol.Clear()
        TextNombre.Clear()

        TextArroz.Focus()

    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        End

    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        'If (TextArroz.Text = 1) Then
        'MsgBox("Verdadero")
        'End If
        Dim Arroz, azucar, frijol, Pago_Normal, Valor_IVA, Pago_Parcial, Descuento, Pago_Total, N, Descuento1 As Double
        N = 0.12
        Descuento1 = 0.025
        Arroz = Val(TextArroz.Text) * 2
        frijol = Val(TextFrijol.Text) * 1.75
        azucar = Val(TextAzucar.Text) * 2.5


        Pago_Normal = Round(Val(Arroz + frijol + azucar), 2)
        'MsgBox("Pago Normal: " + Pago_Normal.ToString)

        Valor_IVA = Round(Val(Pago_Normal * N), 2)
        'MsgBox(Valor_IVA)
        Pago_Parcial = Round(Val(Pago_Normal + Valor_IVA), 2)

        Descuento = Round(Val(Pago_Parcial * Descuento1), 2)
        Pago_Total = Round(Val(Pago_Parcial - Descuento), 2)
        MsgBox(TextNombre.Text + vbNewLine + vbNewLine + "1. Pago Normal: " + Pago_Normal.ToString + vbNewLine + "2. Valor IVA: " + Valor_IVA.ToString + vbNewLine +
               "3. Pago Parcial: " + Pago_Parcial.ToString + vbNewLine + "4. Descuento: " + Descuento.ToString + vbNewLine + vbNewLine + "           TOTAL: " + Pago_Total.ToString, , "DATOS DE LA VENTA")



    End Sub
End Class
