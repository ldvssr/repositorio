Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n_txt As String
        Dim n As Long
        n_txt = Me.TextBox1.Text
        If IsNumeric(n_txt) Then
            MessageBox.Show("Introduziu um número")
            n = Val(n_txt)
        Else
            MessageBox.Show("Introduziu um texto ou caracter" & vbLf & "Introduza um número por favor", "ATENÇÃO")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n_txt As String
        Dim n As Long
        n_txt = TextBox1.Text
        n = Val(n_txt)
        If n <> 0 Then
            MessageBox.Show("Introduziu um número")
        Else
            MessageBox.Show("Introduziu um texto ou caracter" & vbLf & "Introduza um número por favor", "ATENÇÃO")
            TextBox1.Focus()
        End If
    End Sub
End Class
