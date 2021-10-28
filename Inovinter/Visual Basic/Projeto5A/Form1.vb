Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) = False Then
            Label2.Text = ("Insira um N-º")
            TextBox1.Focus()
        End If
        If IsNumeric(TextBox1.Text) = True Then
            If TextBox1.Text = 0 Then
                Label2.Text = ("O N-º é 0")
            End If
            If TextBox1.Text < 0 Then
                Label2.Text = ("O N-º é < 0")
            End If
            If TextBox1.Text > 0 Then
                Label2.Text = ("O N-º é > 0")
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(TextBox2.Text) = False Then
            Label7.Text = ("Insira um N-º")
            TextBox2.Clear()
            TextBox2.Focus()
        End If
        If IsNumeric(TextBox3.Text) = False Then
            Label7.Text = ("Insira um N-º")
            TextBox3.Clear()
            TextBox3.Focus()
        End If
        If IsNumeric(TextBox4.Text) = False Then
            Label7.Text = ("Insira um N-º")
            TextBox4.Clear()
            TextBox4.Focus()
        End If
        If IsNumeric(TextBox2.Text) = True Then
            If TextBox2.Text > TextBox3.Text Then
                If TextBox2.Text > TextBox4.Text Then
                    Label7.Text = TextBox2.Text
                End If
            End If
        End If
        If IsNumeric(TextBox3.Text) = True Then
            If TextBox3.Text > TextBox4.Text Then
                If TextBox3.Text > TextBox2.Text Then
                    Label7.Text = TextBox3.Text
                End If
            End If
        End If
        If IsNumeric(TextBox4.Text) = True Then
            If TextBox4.Text > TextBox2.Text Then
                If TextBox4.Text > TextBox3.Text Then
                    Label7.Text = TextBox4.Text
                End If
            End If
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        Label2.Text = ("")
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        Label7.Text = ("")
    End Sub
End Class
