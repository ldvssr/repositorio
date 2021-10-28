Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = True
        Button4.Enabled = True
        CheckBox1.Visible = True
        Button1.Enabled = False
        CheckedListBox1.Visible = True
        ComboBox1.Visible = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Visible = True
        Label1.Visible = True
        PictureBox2.Visible = False
        Label2.Visible = False
        Button3.Enabled = True
        Button2.Enabled = False
        CheckBox1.Checked = True
        CheckBox2.Checked = False
        CheckBox2.Visible = True
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
            Me.CheckedListBox1.SetItemChecked(0, True)
            Me.CheckedListBox1.SetItemChecked(1, False)
            ComboBox1.SelectedIndex = 0
        Else
            PictureBox2.Visible = True
            Label2.Visible = True
            PictureBox1.Visible = False
            Label1.Visible = False
            Button3.Enabled = False
            Button2.Enabled = True
            CheckBox2.Checked = True
            Me.CheckedListBox1.SetItemChecked(0, False)
            Me.CheckedListBox1.SetItemChecked(1, True)
            ComboBox1.SelectedIndex = 1
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
            Me.CheckedListBox1.SetItemChecked(0, False)
            Me.CheckedListBox1.SetItemChecked(1, True)
            ComboBox1.SelectedIndex = 1
        Else
            PictureBox1.Visible = True
            Label1.Visible = True
            CheckBox2.Visible = True
            PictureBox2.Visible = False
            Label2.Visible = False
            Button3.Enabled = True
            Button2.Enabled = False
            CheckBox1.Checked = True
            Me.CheckedListBox1.SetItemChecked(0, True)
            Me.CheckedListBox1.SetItemChecked(1, False)
            ComboBox1.SelectedIndex = 0
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.SelectedIndex = 0 Then
            Me.CheckedListBox1.SetItemChecked(0, True)
            Me.CheckedListBox1.SetItemChecked(1, False)
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            ComboBox1.SelectedIndex = 0
        End If
        If CheckedListBox1.SelectedIndex = 1 Then
            Me.CheckedListBox1.SetItemChecked(0, False)
            Me.CheckedListBox1.SetItemChecked(1, True)
            CheckBox2.Checked = True
            CheckBox1.Checked = False
            ComboBox1.SelectedIndex = 1
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Me.CheckedListBox1.SetItemChecked(0, True)
            Me.CheckedListBox1.SetItemChecked(1, False)
            CheckBox1.Checked = True
            CheckBox2.Checked = False
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Me.CheckedListBox1.SetItemChecked(0, False)
            Me.CheckedListBox1.SetItemChecked(1, True)
            CheckBox2.Checked = True
            CheckBox1.Checked = False
        End If
    End Sub
End Class
