Public Class Form2
    Dim x As Double
    Dim a1 As Double
    Dim b1 As Double
    Dim x1 As Double
    Dim x2 As Double
    Dim a2 As Double
    Dim b2 As Double
    Dim c2 As Double
    Dim d As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_f2_to_f1.Click
        Dim Form1 As New Form1
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        End
    End Sub

    Private Sub btn_solucao_Click(sender As Object, e As EventArgs) Handles btn_solucao.Click
        If IsNumeric(TextBox1.Text) = False Then
            MessageBox.Show("Insira valores numéricos para ""a""", "ATENÇÃO!")
            TextBox3.Clear()
            TextBox3.Focus()
        End If
        If IsNumeric(TextBox2.Text) = False Then
            MessageBox.Show("Insira valores numéricos para ""b""", "ATENÇÃO!")
            TextBox4.Clear()
            TextBox4.Focus()
        End If
        If IsNumeric(TextBox1.Text) And (TextBox2.Text) = True Then
            a1 = TextBox1.Text
            b1 = TextBox2.Text
            x = -b1 / a1
            lbl_x.Text = x
        End If
    End Sub

    Private Sub btn_solucoes_Click(sender As Object, e As EventArgs) Handles btn_solucoes.Click

        If IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) And IsNumeric(TextBox5.Text) = True Then
            a2 = Val(TextBox3.Text)
            b2 = Val(TextBox4.Text)
            c2 = Val(TextBox5.Text)
            d = b2 ^ 2 - 4 * a2 * c2
            lbl_x1.Visible = True
            lbl_x2.Visible = True
            If a2 = 0 Then
                x1 = (-c2) / b2
                lbl_x1.Text = x1
                lbl_x2.Visible = False
            Else
                If d < 0 Then
                    MessageBox.Show("Não existem soluções", "ATENÇÃO!")
                    lbl_x1.Visible = False
                    lbl_x2.Visible = False
                Else
                    If d = 0 Then
                        MessageBox.Show("Só existe uma solução", "ATENÇÃO!")
                        x1 = (-b2) / (2 * a2)
                        lbl_x1.Text = x1
                        lbl_x2.Visible = False
                    Else
                        x1 = (-b2 + (d ^ (1 / 2))) / (2 * a2)
                        lbl_x1.Text = x1
                        x2 = (-b2 - (d ^ (1 / 2))) / (2 * a2)
                        lbl_x2.Text = x2
                    End If
                End If
            End If
        Else
            If IsNumeric(TextBox3.Text) = False Then
                MessageBox.Show("Insira valores numéricos para ""a""", "ATENÇÃO!")
                TextBox3.Clear()
                TextBox3.Focus()
                lbl_x1.Visible = False
                lbl_x2.Visible = False
            End If
            If IsNumeric(TextBox4.Text) = False Then
                MessageBox.Show("Insira valores numéricos para ""b""", "ATENÇÃO!")
                TextBox4.Clear()
                TextBox4.Focus()
                lbl_x1.Visible = False
                lbl_x2.Visible = False
            End If
            If IsNumeric(TextBox5.Text) = False Then
                MessageBox.Show("Insira valores numéricos para ""c""", "ATENÇÃO!")
                TextBox5.Clear()
                TextBox5.Focus()
                lbl_x1.Visible = False
                lbl_x2.Visible = False
            End If
        End If
    End Sub
End Class