Module Module1
    Public ACADEMIA(8, 10) As String
    Public VALOR As Byte = 0

    Public Const Ingles = 150
    Public Const Portugues = 80
    Public Const Frances = 125
    Public Const DescuentoEfec = 0.02
    Public Const DescuentoCheque = 0.015
    Public Const Descuento2 = 0.05

    Sub MOSTRAR_DATOS()
        Form1.DataGridView1.Rows.Add(ACADEMIA(VALOR, 0), ACADEMIA(VALOR, 1), ACADEMIA(VALOR, 2), ACADEMIA(VALOR, 3), ACADEMIA(VALOR, 4), ACADEMIA(VALOR, 5), ACADEMIA(VALOR, 6), ACADEMIA(VALOR, 7), ACADEMIA(VALOR, 8), ACADEMIA(VALOR, 9))
    End Sub



End Module
