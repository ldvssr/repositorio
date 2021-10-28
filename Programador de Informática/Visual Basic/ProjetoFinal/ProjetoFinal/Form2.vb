Option Explicit On
Public Class Form2
    Dim n, i, n_inicial, n_final, dia As Integer

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        Dim Form1 As New Form1
        Me.Hide()
        Form1.Show()
    End Sub

    Dim txt As String
    Private Sub btn_for_Click(sender As Object, e As EventArgs) Handles btn_for.Click
        If IsNumeric(TextBox2.Text) = False Then
            MessageBox.Show("Introduza apenas valores numéricos na caixa menor!", "ERRO!")
            TextBox2.Clear()
            TextBox2.Focus()
        End If
        If IsNumeric(TextBox3.Text) = False Then
            MessageBox.Show("Introduza apenas valores numéricos na caixa maior!", "ERRO!")
            TextBox3.Clear()
            TextBox3.Focus()
        End If
        If IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) = True Then
            n_inicial = Val(TextBox2.Text)
            n_final = Val(TextBox3.Text)
            If n_inicial > n_final Then
                MessageBox.Show("Introduza valores menores na caixa menor!", "ERRO!")
                TextBox2.Clear()
                TextBox2.Focus()
            ElseIf n_final < n_inicial Then
                MessageBox.Show("Introduza valores maiores na caixa maior!", "ERRO!")
                TextBox3.Clear()
                TextBox3.Focus()
            Else
                For i = n_inicial To n_final
                    txt = Str(i)
                    MessageBox.Show(txt, "Contagem-II")
                    'messagebox.show(i)
                Next
            End If
        End If
    End Sub
    Private Sub btn_while_do_Click(sender As Object, e As EventArgs) Handles btn_while_do.Click
        If IsNumeric(TextBox2.Text) = False Then
            MessageBox.Show("Introduza apenas valores numéricos na caixa menor!", "ERRO!")
            TextBox2.Clear()
            TextBox2.Focus()
        End If
        If IsNumeric(TextBox3.Text) = False Then
            MessageBox.Show("Introduza apenas valores numéricos na caixa maior!", "ERRO!")
            TextBox3.Clear()
            TextBox3.Focus()
        End If
        If IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) = True Then
            n_inicial = Val(TextBox2.Text)
            n_final = Val(TextBox3.Text)
            n = n_inicial
            If n_inicial > n_final Then
                MessageBox.Show("Introduza valores menores na caixa menor!", "ERRO!")
                TextBox2.Clear()
                TextBox2.Focus()
            ElseIf n_final < n_inicial Then
                MessageBox.Show("Introduza valores maiores na caixa maior!", "ERRO!")
                TextBox3.Clear()
                TextBox3.Focus()
            Else
                Do While n < n_final
                    txt = n 'conversao forcada do numero em string
                    'ou txt = str(n)
                    'funcao str converte texto em string
                    MessageBox.Show(txt, "Contagem-I")
                    'a funcao nao aceita o argumento inteiro
                    n = n + 1
                Loop
            End If
        End If
    End Sub
    Private Sub btn_dia_Click(sender As Object, e As EventArgs) Handles btn_dia.Click
        If IsNumeric(TextBox1.Text) = False Then
            MessageBox.Show("Introduza apenas valores numéricos!", "ERRO!")
            TextBox1.Clear()
            TextBox1.Focus()
        End If
        If IsNumeric(TextBox1.Text) = True Then
            dia = Val(TextBox1.Text)
            Select Case dia
                Case 1 : MessageBox.Show("Domingo", "Dia da semana")
                Case 2 : MessageBox.Show("Segunda", "Dia da semana")
                Case 3 : MessageBox.Show("Terça", "Dia da semana")
                Case 4 : MessageBox.Show("Quarta", "Dia da semana")
                Case 5 : MessageBox.Show("Quinta", "Dia da semana")
                Case 6 : MessageBox.Show("Sexta", "Dia da semana")
                Case 7 : MessageBox.Show("Sábado", "Dia da semana")
                    'ou tambem
                    'case 1 to 6 : Messagebox.Show("Dia de Trabalho")
                Case Else : MessageBox.Show("Dia errado", "Dia da semana")
            End Select
        End If
    End Sub
End Class