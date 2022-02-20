Module Module1

    Public PRECIOCOSTO As Double = 0
    Public PrecioVenta As Double
    Public COSTOTOTAL As Double

    Public Const MOsmall = 65.5
    Public Const MOmedium = 85.99
    Public Const MOlarge = 99.99

    Public Const PMalgodon = 15
    Public Const PMseda = 23.99
    Public Const PMlona = 30.99

    Public Const CYsmall = 2
    Public Const CYmedium = 2.5
    Public Const CYlarge = 3

    Sub LIMPIAR()
        Form1.TxtCantidad.Clear()
        Form1.RbSmall.Checked = False
        Form1.RbSeda.Checked = False
        Form1.RbMedium.Checked = False
        Form1.RbLona.Checked = False
        Form1.RbLarge.Checked = False
        Form1.RbAlgodon.Checked = False


    End Sub






End Module
