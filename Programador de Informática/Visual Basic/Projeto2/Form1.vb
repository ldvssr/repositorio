Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = True
        Button4.Enabled = True
        CheckBox1.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Visible = True
        Label1.Visible = True
        PictureBox2.Visible = False
        Label2.Visible = False
        Button3.Enabled = True
        Button2.Enabled = False
        CheckBox1.Checked = True
        CheckBox2.Visible = True
        CheckBox2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox2.Visible = True
        Label2.Visible = True
        PictureBox1.Visible = False
        Label1.Visible = False
        Button3.Enabled = False
        Button2.Enabled = True
        CheckBox2.Checked = True
        CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PictureBox1.Visible = True
            Label1.Visible = True
            CheckBox2.Visible = True
            PictureBox2.Visible = False
            Label2.Visible = False
            Button3.Enabled = True
            Button2.Enabled = False
            CheckBox2.Checked = False
        Else
            PictureBox2.Visible = True
            Label2.Visible = True
            PictureBox1.Visible = False
            Label1.Visible = False
            Button3.Enabled = False
            Button2.Enabled = True
            CheckBox2.Checked = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            PictureBox2.Visible = True
            Label2.Visible = True
            PictureBox1.Visible = False
            Label1.Visible = False
            Button3.Enabled = False
            Button2.Enabled = True
            CheckBox1.Checked = False
        Else
            PictureBox1.Visible = True
            Label1.Visible = True
            CheckBox2.Visible = True
            PictureBox2.Visible = False
            Label2.Visible = False
            Button3.Enabled = True
            Button2.Enabled = False
            CheckBox1.Checked = True
        End If

    End Sub

End Class
