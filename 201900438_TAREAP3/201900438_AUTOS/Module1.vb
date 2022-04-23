Module Module1
    Public Placa(7) As String
    Public TAuto(7) As String
    Public CBase(7) As String
    Public Kinicial(7) As String
    Public Kfinal(7) As String
    Public Total(7) As String

    Public chimbi As Byte = 0
    Public I As Byte

    Public Const tipo1 = 500
    Public Const tipo2 = 400
    Public Const tipo3 = 300
    Public Const tipo4 = 200

    Function CalculoImpuesto() As Double
        Dim imp As Double
        If (Kinicial(chimbi) > 0 And Kfinal(chimbi) <= 50) Then
            imp = (Val(Kfinal(chimbi)) - Val(Kinicial(chimbi))) * 3
            Return imp
        ElseIf (Kinicial(chimbi) >= 0 And Kfinal(chimbi) <= 70) Then
            imp = (Val(Kfinal(chimbi)) - Val(Kinicial(chimbi))) * 4
            Return imp
        ElseIf (Kinicial(chimbi) >= 0 And Kfinal(chimbi) >= 71) Then
            imp = (Val(Kfinal(chimbi)) - Val(Kinicial(chimbi))) * 5
            Return imp
        Else
            MsgBox("No ingresó algún dato")
        End If
    End Function


    Sub Limpiar_Entradas()
        Form1.TxtPlaca.Clear()
        Form1.TxtKinicial.Clear()
        Form1.TxtKfinal.Clear()
        Form1.TxtPlacaC.Clear()
        Form1.RbT1.Checked = False
        Form1.RbT2.Checked = False
        Form1.RbT3.Checked = False
        Form1.RbT4.Checked = False


        Form1.TxtPlaca.Focus()
    End Sub

    Sub Mostrar()

        Dim i As Byte

        Form1.DataGridView1.Rows.Clear()
        '
        For i = 0 To 6

            If Total(i) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Placa(i), TAuto(i), CBase(i), Kinicial(i), Kfinal(i), Total(i))
            Else

                Exit For
            End If
        Next i

    End Sub

    Sub Limpiar_Vectores()
        For i = 0 To 6
            Placa(i) = Nothing
            TAuto(i) = Nothing
            CBase(i) = Nothing
            Kinicial(i) = Nothing
            Kfinal(i) = Nothing
            Total(i) = Nothing

        Next i
        Form1.DataGridView1.Rows.Clear()

        chimbi = 0
    End Sub

    Sub Salir()
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else

            Limpiar_Entradas()
            Limpiar_Vectores()
        End If
    End Sub







End Module
