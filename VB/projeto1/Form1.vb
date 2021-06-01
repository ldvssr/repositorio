Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Bem vindo à programação em vb.net", "Programador de Informática")
        PictureBox1.Visible = True
        Button2.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Button1.Visible = False
        PictureBox1.Visible = False
    End Sub
End Class
