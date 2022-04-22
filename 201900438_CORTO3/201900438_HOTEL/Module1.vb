Module Module1
    Public Nombre(7) As String
    Public NIT(7) As String
    Public Días(7) As String
    Public TipoHab(7) As String
    Public TipoDePa(7) As String
    Public Parcial(7) As String
    Public Impuesto(7) As String
    Public Total(7) As String

    Public chimbi As Byte = 0
    Public I As Byte

    Public Const Sencilla = 250
    Public Const Doble = 400
    Public Const Cabaña = 650

    Sub SENC()
        If (Form1.RbEfectivo.Checked) Or (Form1.RbTarjeta.Checked) Or (Form1.RbTrans.Checked) Or (Form1.RbDep.Checked) Then
            If (Form1.RbEfectivo.Checked) Then
                TipoDePa(chimbi) = Form1.RbEfectivo.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Sencilla
            End If
            If (Form1.RbTarjeta.Checked) Then
                TipoDePa(chimbi) = Form1.RbTarjeta.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Sencilla
            End If
            If (Form1.RbTrans.Checked) Then
                TipoDePa(chimbi) = Form1.RbTrans.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Sencilla
            End If
            If (Form1.RbDep.Checked) Then
                TipoDePa(chimbi) = Form1.RbDep.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Sencilla
            End If
        Else
            MsgBox("No se seleccionó tipo de pago")
            Exit Sub
        End If
    End Sub

    Sub DOB()
        If (Form1.RbEfectivo.Checked) Or (Form1.RbTarjeta.Checked) Or (Form1.RbTrans.Checked) Or (Form1.RbDep.Checked) Then
            If (Form1.RbEfectivo.Checked) Then
                TipoDePa(chimbi) = Form1.RbEfectivo.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Doble
            End If
            If (Form1.RbTarjeta.Checked) Then
                TipoDePa(chimbi) = Form1.RbTarjeta.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Doble
            End If
            If (Form1.RbTrans.Checked) Then
                TipoDePa(chimbi) = Form1.RbTrans.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Doble
            End If
            If (Form1.RbDep.Checked) Then
                TipoDePa(chimbi) = Form1.RbDep.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Doble
            End If
        Else
            MsgBox("No se seleccionó tipo de pago")
            Exit Sub
        End If
    End Sub

    Sub CAB()
        If (Form1.RbEfectivo.Checked) Or (Form1.RbTarjeta.Checked) Or (Form1.RbTrans.Checked) Or (Form1.RbDep.Checked) Then
            If (Form1.RbEfectivo.Checked) Then
                TipoDePa(chimbi) = Form1.RbEfectivo.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Cabaña
            End If
            If (Form1.RbTarjeta.Checked) Then
                TipoDePa(chimbi) = Form1.RbTarjeta.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Cabaña
            End If
            If (Form1.RbTrans.Checked) Then
                TipoDePa(chimbi) = Form1.RbTrans.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Cabaña
            End If
            If (Form1.RbDep.Checked) Then
                TipoDePa(chimbi) = Form1.RbDep.Text
                Parcial(chimbi) = Val(Días(chimbi)) * Cabaña
            End If
        Else
            MsgBox("No se seleccionó tipo de pago")
            Exit Sub
        End If
    End Sub

    Function CalculoImpuesto() As Double
        Dim imp As Double
        If (Form1.RbEfectivo.Checked) Then
            imp = Val(Parcial(chimbi)) * 0.15
            Return imp * -1
        ElseIf (Form1.RbTarjeta.Checked) Then
            imp = Val(Parcial(chimbi)) * 0.03
            Return imp
        ElseIf (Form1.RbTrans.Checked) Then
            imp = Val(Parcial(chimbi)) * 0
            Return imp
        ElseIf (Form1.RbDep.Checked) Then
            imp = Val(Parcial(chimbi)) * 0
            Return imp
        Else
            MsgBox("No seleccionó tipo de pago")
        End If
    End Function


    Sub Mostrar()

        Dim i As Byte

        Form1.DataGridView1.Rows.Clear()

        For i = 0 To 6

            If Total(i) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Nombre(i), NIT(i), Días(i), TipoHab(i), TipoDePa(i), Parcial(i), Impuesto(i), Total(i))
            Else

                Exit For
            End If
        Next i

    End Sub

    Sub Limpiar_Vectores()
        For i = 0 To 6
            Nombre(i) = Nothing
            NIT(i) = Nothing
            Días(i) = Nothing
            TipoHab(i) = Nothing
            TipoDePa(i) = Nothing
            Parcial(i) = Nothing
            Impuesto(i) = Nothing
            Total(i) = Nothing
        Next i
        Form1.DataGridView1.Rows.Clear()

        chimbi = 0
    End Sub

End Module
