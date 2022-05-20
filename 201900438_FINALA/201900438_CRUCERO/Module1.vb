Module Module1
    Public numero As Byte = 0
    Public NIT(6) As String
    Public TCABINA(6) As String
    Public PERSONAS(6) As String
    Public PRECIOI(6) As String
    Public TOTAL(6) As String

    Public chimbi As Byte = 0

    Public Const Psencilla = 400
    Public Const Pdoble = 700
    Public Const Pcompartida = 350

    Public Const Ssencilla = 375
    Public Const Sdoble = 600
    Public Const Scompartida = 300


    Sub PRIMERACLASE()
        If (Form1.RbCompar.Checked) Or (Form1.RbDoble.Checked) Or (Form1.RbSencilla.Checked) Then
            If (Form1.RbCompar.Checked) Then
                TCABINA(chimbi) = Form1.RbCompar.Text
                PRECIOI(chimbi) = Pcompartida
            End If
            If (Form1.RbDoble.Checked) Then
                TCABINA(chimbi) = Form1.RbDoble.Text
                PRECIOI(chimbi) = Pdoble
            End If
            If (Form1.RbSencilla.Checked) Then
                TCABINA(chimbi) = Form1.RbSencilla.Text
                PRECIOI(chimbi) = Psencilla
            End If
        Else
            MsgBox("No se seleccionó tipo de cabina")
            Exit Sub
        End If
    End Sub

    Sub SEGUNDACLASE()
        If (Form1.RbCompar.Checked) Or (Form1.RbDoble.Checked) Or (Form1.RbSencilla.Checked) Then
            If (Form1.RbCompar.Checked) Then
                TCABINA(chimbi) = Form1.RbCompar.Text
                PRECIOI(chimbi) = Scompartida
            End If
            If (Form1.RbDoble.Checked) Then
                TCABINA(chimbi) = Form1.RbDoble.Text
                PRECIOI(chimbi) = Sdoble
            End If
            If (Form1.RbSencilla.Checked) Then
                TCABINA(chimbi) = Form1.RbSencilla.Text
                PRECIOI(chimbi) = Ssencilla
            End If
        Else
            MsgBox("No se seleccionó tipo de cabina")
            Exit Sub
        End If
    End Sub

    Sub Mostrar()

        Dim i As Byte

        Form1.DataGridView1.Rows.Clear()

        For i = 0 To 5

            If TOTAL(i) <> Nothing Then
                Form1.DataGridView1.Rows.Add(NIT(i), TCABINA(i), PERSONAS(i), PRECIOI(i), TOTAL(i))
            Else
            End If
        Next i

    End Sub

    Sub Limpiar_Entradas()
        Form1.TxtCliente.Clear()
        Form1.TxtNombre.Clear()
        Form1.TxtPersonas.Clear()
        Form1.TxtConsulta.Clear()
        Form1.RbSencilla.Checked = False
        Form1.RbDoble.Checked = False
        Form1.RbCompar.Checked = False
        Form1.ComboBox1.SelectedIndex = -1

        Form1.TxtCliente.Focus()
    End Sub

    Sub Limpiar_Vectores()
        For i = 0 To 5
            NIT(i) = Nothing
            TCABINA(i) = Nothing
            PERSONAS(i) = Nothing
            PRECIOI(i) = Nothing
            TOTAL(i) = Nothing

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
