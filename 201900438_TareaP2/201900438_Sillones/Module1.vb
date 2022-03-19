Imports System.Math
Module Module1
    Public Posicion As Byte = 0

    Public NVenta(8) As Double
    Public SillonesDeSala(8) As String
    Public Cantidad(8) As Double
    Public PrecioCosto(8) As Double
    Public PrecioVenta(8) As Double



    Public Const MOSofa = 250.99
    Public Const MOIndividual = 150.99
    Public Const MODoble = 200.99
    Public Const Cuero = 75
    Public Const Cuerina = 45.99
    Public Const YSofa = 8
    Public Const YIndividual = 3.5
    Public Const YDoble = 6


    Function TotalFinal() As Double
        TotalFinal = Round((Val(PrecioCosto(Posicion)) + (Val(PrecioCosto(Posicion)) * 0.65)), 2)
        Return TotalFinal
    End Function

    Sub MUESTRETOTALES()
        Form1.DataGridView1.Rows.Add(NVenta(Posicion), SillonesDeSala(Posicion), Cantidad(Posicion), PrecioCosto(Posicion), PrecioVenta(Posicion))
    End Sub

    Sub Limpiar_entradas()
        Form1.TxtCantidad.Clear()
        Form1.TxtNVenta.Clear()
        Form1.RbCuerina.Checked = 0
        Form1.RbCuero.Checked = 0
        Form1.RbDoble.Checked = 0
        Form1.RbIndi.Checked = 0
        Form1.RbSofa.Checked = 0
    End Sub

    Sub LIMPIAR_VECTORES()
        Posicion = 0
        Form1.DataGridView1.Rows.Clear()
    End Sub

    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            Limpiar_entradas()
            LIMPIAR_VECTORES()
        End If
    End Sub


End Module
