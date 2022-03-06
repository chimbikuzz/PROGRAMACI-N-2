Module Module1
    Public Posicion As Byte = 0
    Public Paciente(6) As String
    Public NIT(6) As Double
    Public HMedicos(6) As Double
    Public FormaPago(6) As String
    Public SubTotal(6) As Double
    Public Descuento(6) As Double
    Public Total(6) As Double


    Public Const ChequeEfectivo = 0.15
    Public Const Debito = 0.08
    Public Const Credito = 0.05

    Public Const PrivE = 350
    Public Const PrivO = 550
    Public Const PrivM = 450
    Public Const SemiPrivE = 250
    Public Const SemiPrivO = 400
    Public Const SemiPrivM = 350
    Public Const NotPrivE = 150
    Public Const NotPrivO = 300
    Public Const NotPrivM = 250

    Sub SPRIVADA()
        If (Form1.CbEncam.Checked) Or (Form1.CbOpe.Checked) Or (Form1.CbMater.Checked) Then
            If Form1.CbEncam.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * PrivE)
            End If
            If Form1.CbOpe.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * PrivO)
            End If
            If Form1.CbMater.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * PrivM)
            End If
        Else
            MsgBox("No seleccionó Tipo de Servicio o Habitación")
            Exit Sub
        End If
    End Sub


    Sub SSEMI()
        If (Form1.CbEncam.Checked) Or (Form1.CbOpe.Checked) Or (Form1.CbMater.Checked) Then
            If Form1.CbEncam.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * SemiPrivE)
            End If
            If Form1.CbOpe.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * SemiPrivO)
            End If
            If Form1.CbMater.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * SemiPrivM)
            End If
        Else
            MsgBox("No seleccionó Tipo de Servicio o Habitación")
            Exit Sub
        End If
    End Sub



    Sub NOTP()
        If (Form1.CbEncam.Checked) Or (Form1.CbOpe.Checked) Or (Form1.CbMater.Checked) Then
            If Form1.CbEncam.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * NotPrivE)
            End If
            If Form1.CbEncam.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * NotPrivO)
            End If
            If Form1.CbMater.Checked Then
                SubTotal(Posicion) = Val(Form1.TxtDíasH.Text * NotPrivM)
            End If
        Else
            MsgBox("No seleccionó Tipo de Servicio o Habitación")
            Exit Sub
        End If
    End Sub


    Function CalculoDescuentoRecargo() As Double
        Dim desc As Double
        Dim Recargo As Double

        If (Form1.RbEfectivo.Checked) Then
            FormaPago(Posicion) = Form1.RbEfectivo.Text
            desc = SubTotal(Posicion) * ChequeEfectivo
            Return desc * -1
        ElseIf (Form1.RbCheque.Checked) Then
            FormaPago(Posicion) = Form1.RbCheque.Text
            desc = SubTotal(Posicion) * ChequeEfectivo
            Return desc * -1
        ElseIf (Form1.RbTarD.Checked) Then
            FormaPago(Posicion) = Form1.RbTarD.Text
            desc = SubTotal(Posicion) * Debito
            Return desc * -1
        ElseIf (Form1.RbTarC.Checked) Then
            FormaPago(Posicion) = Form1.RbTarC.Text
            Recargo = SubTotal(Posicion) * Credito
            Return Recargo

        End If

    End Function


    Function TotalFinal() As Double
        TotalFinal = SubTotal(Posicion) + Descuento(Posicion)
        Return TotalFinal

    End Function

    Sub MUESTRETOTALES()
        Form1.ListBox1.Items.Add(Paciente(Posicion))
        Form1.ListBox2.Items.Add(Str(NIT(Posicion)))
        Form1.ListBox3.Items.Add(Str(HMedicos(Posicion)))
        Form1.ListBox4.Items.Add(FormaPago(Posicion))
        Form1.ListBox5.Items.Add(Str(SubTotal(Posicion)))
        Form1.ListBox6.Items.Add(Str(Descuento(Posicion)))
        Form1.ListBox7.Items.Add(Str(Total(Posicion)))

    End Sub

    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            LIMPIAR_VECTORES()
        End If
    End Sub

    Sub limpiar_entradas()
        Form1.TxtNombrePaciente.Clear()
        Form1.TxtNIT.Clear()
        Form1.TxtDíasH.Clear()
        Form1.TxtHM.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.CbEncam.Checked = 0
        Form1.CbMater.Checked = 0
        Form1.CbOpe.Checked = 0
        Form1.RbCheque.Checked = 0
        Form1.RbEfectivo.Checked = 0
        Form1.RbTarC.Checked = 0
        Form1.RbTarD.Checked = 0

        Form1.TxtNombrePaciente.Focus()

    End Sub

    Sub LIMPIAR_VECTORES()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()

    End Sub

End Module
