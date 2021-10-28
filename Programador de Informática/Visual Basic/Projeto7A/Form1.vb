Public Class Form1
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Form2 As New Form2
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3, num4, num5 As Long
        num1 = 7
        num2 = 8
        num3 = 5
        num4 = 4
        num5 = 3
        ListView1.Items.Add(num1 * num2 + num3 - num4 * num5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2, num3 As Long
        num1 = 5.5
        num2 = 20
        num3 = 30
        ListView1.Items.Add(num1 / 100 * num2 + num3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resultado As Long
        resultado = (17 * (3 + 162) + 2 ^ 10)
        ListView1.Items.Add(resultado)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim resultado As Double
        resultado = ((1 + 2.9) ^ 3 * (0.3 + 4.2) ^ 2)
        ListView1.Items.Add(resultado)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim resultado As Double
        resultado = (30 / (10 + (2 + 3)))
        ListView1.Items.Add(resultado)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim resultado As Double
        resultado = (25 - (Math.Sqrt(64) + 5 ^ 3 * (7 - (4 / 2))))
        ListView1.Items.Add(resultado)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim resultado As Double
        resultado = (7 ^ 2 - 3 / 2 + Math.Sqrt(16))
        ListView1.Items.Add(resultado)
    End Sub
End Class
