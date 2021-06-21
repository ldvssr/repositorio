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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Expressão 1: 7 x 8 + 5 - 4 x 3 ="
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(252, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Expressão 2: 5.5% de 20 + 30 ="
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 73)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(252, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Expressão 3: 17 (3 + 162) + 2¹⁰ ="
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 103)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(252, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Expressão 4: (1 + 2.9)³ x (0.3 + 4.2)² ="
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(13, 133)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(252, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Expressão 5: 30 ÷ [10 + (2 + 3)] ="
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(13, 163)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(252, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Expressão 6: 25 - {√64 + 5³ x [7 - (4 ÷ 2)]}"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(13, 193)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(252, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Expressão 7: 7² - 3 ÷ 2 + √16"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 222)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(97, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Form1 > Form2"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(373, 221)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "&Sair"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(271, 13)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(177, 203)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 256)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projeto7A"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ListView1 As ListView
End Class
