Public Class Form2
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub btn_mm3_Click(sender As Object, e As EventArgs) Handles btn_mm3.Click
        If IsNumeric(tb_mm3_num1.Text) = False Then
            lbl_mm3_output_max.Text = ("Insira um N-º")
            tb_mm3_num1.Clear()
            tb_mm3_num1.Focus()
        End If
        If IsNumeric(tb_mm3_num2.Text) = False Then
            lbl_mm3_output_max.Text = ("Insira um N-º")
            tb_mm3_num2.Clear()
            tb_mm3_num2.Focus()
        End If
        If IsNumeric(tb_mm3_num3.Text) = False Then
            lbl_mm3_output_max.Text = ("Insira um N-º")
            tb_mm3_num3.Clear()
            tb_mm3_num3.Focus()
        End If
        If IsNumeric(tb_mm3_num1.Text) = True Then
            If tb_mm3_num1.Text > tb_mm3_num2.Text Then
                If tb_mm3_num1.Text > tb_mm3_num3.Text Then
                    lbl_mm3_output_max.Text = tb_mm3_num1.Text
                End If
            End If
        End If
        If IsNumeric(tb_mm3_num2.Text) = True Then
            If tb_mm3_num2.Text > tb_mm3_num3.Text Then
                If tb_mm3_num2.Text > tb_mm3_num1.Text Then
                    lbl_mm3_output_max.Text = tb_mm3_num2.Text
                End If
            End If
        End If
        If IsNumeric(tb_mm3_num3.Text) = True Then
            If tb_mm3_num3.Text > tb_mm3_num1.Text Then
                If tb_mm3_num3.Text > tb_mm3_num2.Text Then
                    lbl_mm3_output_max.Text = tb_mm3_num3.Text
                End If
            End If
        End If
        If IsNumeric(tb_mm3_num1.Text) = True Then
            If tb_mm3_num1.Text < tb_mm3_num2.Text Then
                If tb_mm3_num1.Text < tb_mm3_num3.Text Then
                    lbl_mm3_output_min.Text = tb_mm3_num1.Text
                End If
            End If
        End If
        If IsNumeric(tb_mm3_num2.Text) = True Then
            If tb_mm3_num2.Text < tb_mm3_num3.Text Then
                If tb_mm3_num2.Text < tb_mm3_num1.Text Then
                    lbl_mm3_output_min.Text = tb_mm3_num2.Text
                End If
            End If
        End If
        If IsNumeric(tb_mm3_num3.Text) = True Then
            If tb_mm3_num3.Text < tb_mm3_num1.Text Then
                If tb_mm3_num3.Text < tb_mm3_num2.Text Then
                    lbl_mm3_output_min.Text = tb_mm3_num3.Text
                End If
            End If
        End If
    End Sub

    Private Sub btn_mm4_Click(sender As Object, e As EventArgs) Handles btn_mm4.Click
        If IsNumeric(tb_mm4_num1.Text) = False Then
            lbl_mm4_output_max.Text = ("Insira um N-º")
            tb_mm4_num1.Clear()
            tb_mm4_num1.Focus()
        End If
        If IsNumeric(tb_mm4_num2.Text) = False Then
            lbl_mm4_output_max.Text = ("Insira um N-º")
            tb_mm4_num2.Clear()
            tb_mm4_num2.Focus()
        End If
        If IsNumeric(tb_mm4_num3.Text) = False Then
            lbl_mm4_output_max.Text = ("Insira um N-º")
            tb_mm4_num3.Clear()
            tb_mm4_num3.Focus()
        End If
        If IsNumeric(tb_mm4_num4.Text) = False Then
            lbl_mm4_output_max.Text = ("Insira um N-º")
            tb_mm4_num4.Clear()
            tb_mm4_num4.Focus()
        End If
        If IsNumeric(tb_mm4_num1.Text) = True Then
            If tb_mm4_num1.Text > tb_mm4_num2.Text Then
                If tb_mm4_num1.Text > tb_mm4_num3.Text Then
                    If tb_mm4_num1.Text > tb_mm4_num4.Text Then
                        lbl_mm4_output_max.Text = tb_mm4_num1.Text
                    End If
                End If
            End If
        End If
        If IsNumeric(tb_mm4_num2.Text) = True Then
            If tb_mm4_num2.Text > tb_mm4_num1.Text Then
                If tb_mm4_num2.Text > tb_mm4_num3.Text Then
                    If tb_mm4_num2.Text > tb_mm4_num4.Text Then
                        lbl_mm4_output_max.Text = tb_mm4_num2.Text
                    End If
                End If
            End If
        End If
        If IsNumeric(tb_mm4_num3.Text) = True Then
            If tb_mm4_num3.Text > tb_mm4_num1.Text Then
                If tb_mm4_num3.Text > tb_mm4_num2.Text Then
                    If tb_mm4_num3.Text > tb_mm4_num4.Text Then
                        lbl_mm4_output_max.Text = tb_mm4_num3.Text
                    End If
                End If
            End If
        End If
        If IsNumeric(tb_mm4_num4.Text) = True Then
            If tb_mm4_num4.Text > tb_mm4_num1.Text Then
                If tb_mm4_num4.Text > tb_mm4_num2.Text Then
                    If tb_mm4_num4.Text > tb_mm4_num3.Text Then
                        lbl_mm4_output_max.Text = tb_mm4_num4.Text
                    End If
                End If
            End If
        End If
        If IsNumeric(tb_mm4_num1.Text) = True Then
            If tb_mm4_num1.Text < tb_mm4_num2.Text Then
                If tb_mm4_num1.Text < tb_mm4_num3.Text Then
                    If tb_mm4_num1.Text < tb_mm4_num4.Text Then
                        lbl_mm4_output_min.Text = tb_mm4_num1.Text
                    End If
                End If
            End If
        End If
        If IsNumeric(tb_mm4_num2.Text) = True Then
            If tb_mm4_num2.Text < tb_mm4_num1.Text Then
                If tb_mm4_num2.Text < tb_mm4_num3.Text Then
                    If tb_mm4_num2.Text < tb_mm4_num4.Text Then
                        lbl_mm4_output_min.Text = tb_mm4_num2.Text
                    End If
                End If
            End If
        End If
        If IsNumeric(tb_mm4_num3.Text) = True Then
            If tb_mm4_num3.Text < tb_mm4_num1.Text Then
                If tb_mm4_num3.Text < tb_mm4_num2.Text Then
                    If tb_mm4_num3.Text < tb_mm4_num4.Text Then
                        lbl_mm4_output_min.Text = tb_mm4_num3.Text
                    End If
                End If
            End If
        End If
        If IsNumeric(tb_mm4_num4.Text) = True Then
            If tb_mm4_num4.Text < tb_mm4_num1.Text Then
                If tb_mm4_num4.Text < tb_mm4_num2.Text Then
                    If tb_mm4_num4.Text < tb_mm4_num3.Text Then
                        lbl_mm4_output_min.Text = tb_mm4_num4.Text
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tb_mm3_num1.Clear()
        tb_mm3_num2.Clear()
        tb_mm3_num3.Clear()
        lbl_mm3_output_max.Text = ("")
        lbl_mm3_output_min.Text = ("")
        tb_mm4_num1.Clear()
        tb_mm4_num2.Clear()
        tb_mm4_num3.Clear()
        tb_mm4_num4.Clear()
        lbl_mm4_output_max.Text = ("")
        lbl_mm4_output_min.Text = ("")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form1 As New Form1
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class