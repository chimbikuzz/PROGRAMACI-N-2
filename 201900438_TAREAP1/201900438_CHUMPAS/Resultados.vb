Imports System.Math
Public Class Resultados
    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPrecioC.Text = Val(Round(PRECIOCOSTO, 2))
        TxtPrecioV.Text = Val(Round(PrecioVenta, 2))
        TxtCostoTotal.Text = Val(Round(COSTOTOTAL, 2))

    End Sub

    Private Sub Resultados_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()


    End Sub
End Class