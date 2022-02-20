Imports System.Math
Public Class Form1
    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RbSmall.Checked = False AndAlso RbMedium.Checked = False AndAlso RbLarge.Checked = False Then
            MsgBox("-No se seleccióno un tamaño", vbCritical, "ERROR")
            Exit Sub

        End If

        If RbAlgodon.Checked = False AndAlso RbSeda.Checked = False AndAlso RbLona.Checked = False Then
            MsgBox("No se seleccióno ningún material", vbCritical, "ERROR")
            Exit Sub

        End If



        If (RbSmall.Checked) And (RbAlgodon.Checked) Then
            PRECIOCOSTO = MOsmall + PMalgodon * CYsmall
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub

        End If

        If (RbMedium.Checked) And (RbAlgodon.Checked) Then
            PRECIOCOSTO = MOmedium + PMalgodon * CYmedium
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub

        End If


        If (RbLarge.Checked) And (RbAlgodon.Checked) Then
            PRECIOCOSTO = MOlarge + PMalgodon * CYlarge
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub

        End If








        If (RbSmall.Checked) And (RbSeda.Checked) Then
            PRECIOCOSTO = MOsmall + PMseda * CYsmall
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub
        End If


        If (RbMedium.Checked) And (RbSeda.Checked) Then
            PRECIOCOSTO = MOmedium + PMseda * CYmedium
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub

        End If
        If (RbLarge.Checked) And (RbSeda.Checked) Then
            PRECIOCOSTO = MOlarge + PMseda * CYlarge
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub

        End If






        If (RbSmall.Checked) And (RbLona.Checked) Then
            PRECIOCOSTO = MOsmall + PMlona * CYsmall
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub
        End If


        If (RbMedium.Checked) And (RbLona.Checked) Then
            PRECIOCOSTO = MOmedium + PMlona * CYmedium
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub

        End If
        If (RbLarge.Checked) And (RbLona.Checked) Then
            PRECIOCOSTO = MOlarge + PMlona * CYlarge
        ElseIf TxtCantidad.Text = "" Then
            MsgBox("Ingrese Cantidad", vbCritical, "ERROR")
            Exit Sub

        End If

        PrecioVenta = PRECIOCOSTO + 0.65 * PRECIOCOSTO
        COSTOTOTAL = PRECIOCOSTO * Val(TxtCantidad.Text)




        'Calcular(material, tamaño, )

        Me.Hide()
        Resultados.Show()


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LIMPIAR()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("¿DESEA CERRAR EL FORMULARIO?", vbQuestion + vbYesNo, "201900438") = vbYes) Then
            Me.Close()
            'End
        End If

    End Sub
End Class
