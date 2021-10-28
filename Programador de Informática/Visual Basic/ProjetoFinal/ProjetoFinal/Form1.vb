Public Class Form1
    Dim escolha As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        escolha = Val(TextBox1.Text)
        Select Case escolha
            Case 1
                Dim Form2 As New Form2
                Me.Hide()
                Form2.Show()
            Case 2
                Dim Form3 As New Form3
                Me.Hide()
                Form3.Show()
            Case Else
                MessageBox.Show("Introduza 1 ou 2", "Erro!")
                TextBox1.Clear()
                TextBox1.Focus()
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LoginForm1 As New LoginForm1
        Me.Hide()
        LoginForm1.Show()
    End Sub
End Class
