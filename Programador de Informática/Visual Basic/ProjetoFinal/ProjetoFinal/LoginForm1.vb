Public Class LoginForm1

    ' TODO: Inserir c�digo para realizar autentica��o personalizada utilizando o nome de usu�rio e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de seguran�a personalizada pode ser anexada � entidade de seguran�a da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal � a implementa��o de IPrincipal usada para realizar a autentica��o. 
    ' Subsequentemente, My.User ir� retornar informa��es de identifica��o encapsuladas num objeto CustomPrincipal
    ' como nome de usu�rio, nome de exibi��o etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Form1 As New Form1
        Dim R As Integer
        If (UsernameTextBox.Text = "Username" And PasswordTextBox.Text = "Password") Then
            Me.Hide()
            Form1.Show()
        Else
            R = MessageBox.Show("Utilizador ou Senha Errados", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
