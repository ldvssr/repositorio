Public Class Form3
    Dim escolha As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        escolha = Val(TextBox1.Text)
        Select Case escolha
            Case 1
                Dim Form1 As New Form1
                Me.Hide()
                Form1.Show()
            Case 2
                Dim Form2 As New Form2
                Me.Hide()
                Form2.Show()
            Case Else
                MessageBox.Show("Introduza 1 ou 2", "Erro!")
                TextBox1.Clear()
                TextBox1.Focus()
        End Select
    End Sub
End Class