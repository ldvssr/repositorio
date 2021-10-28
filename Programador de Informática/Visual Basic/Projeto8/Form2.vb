Public Class Form2
    Dim valorLido As Integer = 0
    Dim somatorio As Integer = 0
    Dim resultado As Integer = 0
    Dim contador As Integer = 0
    Dim max As Integer = 0
    Dim n As Integer
    Dim txt As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles _lbl.Click
        valorLido = txb_input.Text
        resultado = somatorio + valorLido
        lbl_somatorio.Text = resultado
        somatorio = resultado
        contador = contador + 1
        lbl_contador.Text = contador
        If valorLido > max Then
            max = valorLido
            lbl_maximo.Text = max
        End If
        txb_input.Clear()
        txb_input.Focus()
    End Sub
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        valorLido = 0
        somatorio = 0
        resultado = 0
        contador = 0
        max = 0
        lbl_contador.Text = ""
        lbl_maximo.Text = ""
        lbl_somatorio.Text = ""
        txb_input.Clear()
        txb_input.Focus()
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Dim Form3 As New Form3
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btn_calcular_msb_Click(sender As Object, e As EventArgs) Handles btn_calcular_msb.Click
        n = Val(txb_input.Text)
        If n > max Then
            max = n
        End If
        contador = contador + 1
        somatorio = somatorio + n
        txb_input.Text = ""
        If n = 0 Then
            contador = contador - 1
            txt = "Máximo = " & Str(max) & vbLf
            txt = txt & " " & "Contador = " & contador & vbLf & "Somatório = " & somatorio
            MessageBox.Show(txt, "Total")
        End If
    End Sub
End Class