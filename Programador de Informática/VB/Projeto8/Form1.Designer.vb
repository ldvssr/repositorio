<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_dia = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_while_do = New System.Windows.Forms.Button()
        Me.btn_for = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Case"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "N"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 2
        '
        'btn_dia
        '
        Me.btn_dia.Location = New System.Drawing.Point(13, 77)
        Me.btn_dia.Name = "btn_dia"
        Me.btn_dia.Size = New System.Drawing.Size(75, 23)
        Me.btn_dia.TabIndex = 3
        Me.btn_dia.Text = "dia"
        Me.btn_dia.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ciclos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Numero inicial"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Numero final"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(164, 91)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 8
        '
        'btn_while_do
        '
        Me.btn_while_do.Location = New System.Drawing.Point(164, 120)
        Me.btn_while_do.Name = "btn_while_do"
        Me.btn_while_do.Size = New System.Drawing.Size(75, 23)
        Me.btn_while_do.TabIndex = 9
        Me.btn_while_do.Text = "while do"
        Me.btn_while_do.UseVisualStyleBackColor = True
        '
        'btn_for
        '
        Me.btn_for.Location = New System.Drawing.Point(164, 149)
        Me.btn_for.Name = "btn_for"
        Me.btn_for.Size = New System.Drawing.Size(75, 23)
        Me.btn_for.TabIndex = 10
        Me.btn_for.Text = "for"
        Me.btn_for.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Location = New System.Drawing.Point(189, 178)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(75, 23)
        Me.btn_menu.TabIndex = 11
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 215)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_for)
        Me.Controls.Add(Me.btn_while_do)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_dia)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Case_While_For"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_dia As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn_while_do As Button
    Friend WithEvents btn_for As Button
    Friend WithEvents btn_menu As Button
End Class
