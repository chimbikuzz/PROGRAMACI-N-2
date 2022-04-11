Module Module1
    Public Nombre(10) As String
    Public Precio(10) As String
    Public Peso(10) As String
    Public TipoDeEn(10) As String
    Public TipoDePa(10) As String
    Public Parcial(10) As String
    Public Impuesto(10) As String
    Public Total(10) As String

    Public chimbi As Byte = 0


    Public Const EnvioCA = 50
    Public Const EnvioMO = 15


    Sub CAMI()
        If (Form1.RbAnp.Checked) Or (Form1.RbAplast.Checked) Or (Form1.RbDocumentos.Checked) Or (Form1.RbLociones.Checked) Or (Form1.RbRopa.Checked) Then
            If (Form1.RbAnp.Checked) Then
                TipoDePa(chimbi) = Form1.RbAnp.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
            If (Form1.RbAplast.Checked) Then
                TipoDePa(chimbi) = Form1.RbAplast.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
            If (Form1.RbDocumentos.Checked) Then
                TipoDePa(chimbi) = Form1.RbDocumentos.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
            If (Form1.RbLociones.Checked) Then
                TipoDePa(chimbi) = Form1.RbLociones.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
            If (Form1.RbRopa.Checked) Then
                TipoDePa(chimbi) = Form1.RbRopa.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
        Else
            MsgBox("No se seleccionó tipo de envío")
            Exit Sub
        End If
    End Sub

    Sub MOTO()
        If (Form1.RbAnp.Checked) Or (Form1.RbAplast.Checked) Or (Form1.RbDocumentos.Checked) Or (Form1.RbLociones.Checked) Or (Form1.RbRopa.Checked) Then
            If (Form1.RbAnp.Checked) Then
                TipoDePa(chimbi) = Form1.RbAnp.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
            If (Form1.RbAplast.Checked) Then
                TipoDePa(chimbi) = Form1.RbAplast.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
            If (Form1.RbDocumentos.Checked) Then
                TipoDePa(chimbi) = Form1.RbDocumentos.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
            If (Form1.RbLociones.Checked) Then
                TipoDePa(chimbi) = Form1.RbLociones.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
            If (Form1.RbRopa.Checked) Then
                TipoDePa(chimbi) = Form1.RbRopa.Text
                Parcial(chimbi) = Val(Precio(chimbi)) + Val(Impuesto(chimbi))
            End If
        Else
            MsgBox("No se seleccionó tipo de envío")
            Exit Sub
        End If
    End Sub


    Function CalculoImpuesto() As Double
        Dim imp As Double
        If (Form1.RbAnp.Checked) And (Peso(chimbi) > 0 And Peso(chimbi) <= 5) Then
            imp = Val(Peso(chimbi)) * 0.055 * Val(Precio(chimbi))
            Return imp
        ElseIf (Form1.RbAplast.Checked) And (Peso(chimbi) > 0 And Peso(chimbi) <= 5) Then
            imp = Val(Peso(chimbi)) * 0.045 * Val(Precio(chimbi))
            Return imp
        ElseIf (Form1.RbDocumentos.Checked) And (Peso(chimbi) > 0 And Peso(chimbi) <= 5) Then
            imp = Val(Peso(chimbi)) * 0.015 * Val(Precio(chimbi))
            Return imp
        ElseIf (Form1.RbLociones.Checked) And (Peso(chimbi) > 0 And Peso(chimbi) <= 5) Then
            imp = Val(Peso(chimbi)) * 0.02 * Val(Precio(chimbi))
            Return imp
        ElseIf (Form1.RbRopa.Checked) And (Peso(chimbi) > 0 And Peso(chimbi) <= 5) Then
            imp = Val(Peso(chimbi)) * 0.06 * Val(Precio(chimbi))
            Return imp
        Else
            MsgBox("Excedió las libras límite")
        End If

    End Function

    Sub Tot1()
        If (Parcial(chimbi) <> "") Then
            Total(chimbi) = Val(Parcial(chimbi)) + EnvioCA
        End If
    End Sub

    Sub Tot2()
        If (Parcial(chimbi) <> "") Then
            Total(chimbi) = Val(Parcial(chimbi)) + EnvioMO
        End If
    End Sub



    'Function TOTALFINAL() As Double
    'Dim totf As Double
    '(Form1.ComboBox2.SelectedIndex) Then
    'totf = Val(Parcial(chimbi)) + EnvioCA
    'Return totf
    'ElseIf (Form1.ComboBox2.SelectedIndex) Then
    'totf = Val(Parcial(chimbi)) + EnvioMO
    ' Return totf
    'End If
    'End Function



    Sub Mostrar()
        'Procedimiento que se utiliza para mostrar el contenido de los vectores
        Dim i As Byte
        'se limpia primero el datagrid para poder mostrar el contenido de los vectores
        Form1.DataGridView1.Rows.Clear()
        'se utiliza ciclo for para recorrer cada fila de los vectores y mostrarlos en el datagridview
        'dicho proceso muestra una fila completa en cada iteración del ciclo.
        For i = 0 To 9
            'la condición del siguiente If es para verificar que el vector total 
            'no esta vacío que muestre su contenido, de lo contrario que se salga del ciclo for
            If Total(i) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Nombre(i), Precio(i), Peso(i), TipoDeEn(i), TipoDePa(i), Parcial(i), Impuesto(i), Total(i))
            Else
                'instrucción que hace que se haga una salida forzada del ciclo for en dado caso la condición 
                'del if es falsa, al igual existe una salida forzada del ciclo while: Exit While
                Exit For
            End If
        Next i

    End Sub

    Sub Limpiar_Entradas()
        Form1.TxtNombre.Clear()
        Form1.TxtPeso.Clear()
        Form1.TxtValor.Clear()
        Form1.RbAnp.Checked = False
        Form1.RbAplast.Checked = False
        Form1.RbDocumentos.Checked = False
        Form1.RbLociones.Checked = False
        Form1.RbRopa.Checked = False
        Form1.ComboBox2.SelectedIndex = -1

        Form1.TxtNombre.Focus()
    End Sub

    Sub Limpiar_Vectores()
        For i = 0 To 9
            Nombre(i) = Nothing
            Precio(i) = Nothing
            Peso(i) = Nothing
            TipoDeEn(i) = Nothing
            TipoDePa(i) = Nothing
            Parcial(i) = Nothing
            Impuesto(i) = Nothing
            Total(i) = Nothing
        Next i
        Form1.DataGridView1.Rows.Clear()

        chimbi = 0
    End Sub

    Sub Limpiar_Estadisticas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
    End Sub

    Sub Salir()
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            ' se hace la llamada el procedimiento que limpia objetos y vectores
            Limpiar_Entradas()
            Limpiar_Estadisticas()
            Limpiar_Vectores()
        End If
    End Sub

End Module
