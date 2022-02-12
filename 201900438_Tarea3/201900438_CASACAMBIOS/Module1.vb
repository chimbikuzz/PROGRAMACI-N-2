Module Module1
    Sub Limpiar()
        Form1.TextCompra.Clear()
        Form1.TextVenta.Clear()
        Form1.CompraDolar.Checked = False
        Form1.CompraPesoM.Checked = False
        Form1.CompraEuro.Checked = False
        Form1.CompraColón.Checked = False
        Form1.VentaDolar.Checked = False
        Form1.VentaPesoM.Checked = False
        Form1.VentaEuro.Checked = False
        Form1.VentaColón.Checked = False

        Form1.TextCompra.Focus()
    End Sub

End Module
