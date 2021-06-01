Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tbmaxmin3num1.Text = ("")
        tbmaxmin3num2.Text = ("")
        tbmaxmin3num3.Text = ("")
        lbmax3.Text = ("")
        lbmax4.Text = ("")
        tbmaxmin4num1.Text = ("")
        tbmaxmin4num2.Text = ("")
        tbmaxmin4num3.Text = ("")
        tbmaxmin4num4.Text = ("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(tbmaxmin3num1.Text) Or (tbmaxmin3num2.Text) Or (tbmaxmin3num3.Text) = False Then
            lbmax3.Text = ("não é")
            lbmin3.Text = ("número")
        Else
            lbmax3.Text = ("é")
            lbmin3.Text = ("número")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(tbmaxmin4num1.Text) Or (tbmaxmin4num2.Text) Or (tbmaxmin4num3.Text) Or (tbmaxmin4num4.Text) = False Then
            lbmax4.Text = ("não é")
            lbmin4.Text = ("número")
        Else
            lbmax4.Text = ("é")
            lbmin4.Text = ("número")
        End If
    End Sub
End Class
