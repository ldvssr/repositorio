Public Class Form1
    Dim n1 As Double
    Dim n2 As Double
    Sub leitura()
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        If n1 <> 0 Then
        Else
            MessageBox.Show("Introduziu um texto, caracter ou '0' na caixa N1" & vbLf & "Introduza um número por favor", "ATENÇÃO")
            TextBox1.Focus()
        End If
        If n2 <> 0 Then
        Else
            MessageBox.Show("Introduziu um texto, caracter ou '0' na caixa N2" & vbLf & "Introduza um número por favor", "ATENÇÃO")
            TextBox2.Focus()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        leitura()
        Label5.Text = n1 + n2
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        leitura()
        Label5.Text = n1 - n2
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        leitura()
        Label5.Text = n1 * n2
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        leitura()
        If n2 = 0 Then
            Label5.Text = "Impossível dividir por 0"
        Else
            Label5.Text = n1 / n2
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        leitura()
        If n1 > n2 Then
            Label8.Text = n1
            Label9.Text = n2
        ElseIf n2 > n1 Then
            Label8.Text = n2
            Label9.Text = n1
        ElseIf n1 = n2 Then
            Label8.Text = "Números"
            Label9.Text = "Iguais"
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label5.Text = ""
        Label8.Text = ""
        Label9.Text = ""
    End Sub
End Class