<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_calcular_msb = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.lbl_maximo = New System.Windows.Forms.Label()
        Me.lbl_contador = New System.Windows.Forms.Label()
        Me.lbl_somatorio = New System.Windows.Forms.Label()
        Me._lbl = New System.Windows.Forms.Button()
        Me.txb_input = New System.Windows.Forms.TextBox()
        Me.lbl_maximo2 = New System.Windows.Forms.Label()
        Me.lbl_maximo3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_calcular_msb
        '
        Me.btn_calcular_msb.Location = New System.Drawing.Point(169, 68)
        Me.btn_calcular_msb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_calcular_msb.Name = "btn_calcular_msb"
        Me.btn_calcular_msb.Size = New System.Drawing.Size(143, 38)
        Me.btn_calcular_msb.TabIndex = 23
        Me.btn_calcular_msb.Text = "Calcular MSB"
        Me.btn_calcular_msb.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Location = New System.Drawing.Point(169, 225)
        Me.btn_menu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(107, 38)
        Me.btn_menu.TabIndex = 22
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(17, 155)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(107, 38)
        Me.btn_limpar.TabIndex = 21
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'lbl_maximo
        '
        Me.lbl_maximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_maximo.Location = New System.Drawing.Point(320, 112)
        Me.lbl_maximo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_maximo.Name = "lbl_maximo"
        Me.lbl_maximo.Size = New System.Drawing.Size(142, 37)
        Me.lbl_maximo.TabIndex = 20
        '
        'lbl_contador
        '
        Me.lbl_contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_contador.Location = New System.Drawing.Point(169, 112)
        Me.lbl_contador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_contador.Name = "lbl_contador"
        Me.lbl_contador.Size = New System.Drawing.Size(142, 37)
        Me.lbl_contador.TabIndex = 19
        '
        'lbl_somatorio
        '
        Me.lbl_somatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_somatorio.Location = New System.Drawing.Point(17, 112)
        Me.lbl_somatorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_somatorio.Name = "lbl_somatorio"
        Me.lbl_somatorio.Size = New System.Drawing.Size(142, 37)
        Me.lbl_somatorio.TabIndex = 18
        '
        '_lbl
        '
        Me._lbl.Location = New System.Drawing.Point(17, 68)
        Me._lbl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me._lbl.Name = "_lbl"
        Me._lbl.Size = New System.Drawing.Size(143, 38)
        Me._lbl.TabIndex = 17
        Me._lbl.Text = "Calcular LBL"
        Me._lbl.UseVisualStyleBackColor = True
        '
        'txb_input
        '
        Me.txb_input.Location = New System.Drawing.Point(17, 20)
        Me.txb_input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txb_input.Name = "txb_input"
        Me.txb_input.Size = New System.Drawing.Size(141, 31)
        Me.txb_input.TabIndex = 16
        '
        'lbl_maximo2
        '
        Me.lbl_maximo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_maximo2.Location = New System.Drawing.Point(320, 149)
        Me.lbl_maximo2.Name = "lbl_maximo2"
        Me.lbl_maximo2.Size = New System.Drawing.Size(142, 37)
        Me.lbl_maximo2.TabIndex = 24
        '
        'lbl_maximo3
        '
        Me.lbl_maximo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_maximo3.Location = New System.Drawing.Point(320, 186)
        Me.lbl_maximo3.Name = "lbl_maximo3"
        Me.lbl_maximo3.Size = New System.Drawing.Size(142, 37)
        Me.lbl_maximo3.TabIndex = 25
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 277)
        Me.Controls.Add(Me.lbl_maximo3)
        Me.Controls.Add(Me.lbl_maximo2)
        Me.Controls.Add(Me.btn_calcular_msb)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.lbl_maximo)
        Me.Controls.Add(Me.lbl_contador)
        Me.Controls.Add(Me.lbl_somatorio)
        Me.Controls.Add(Me._lbl)
        Me.Controls.Add(Me.txb_input)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_calcular_msb As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents lbl_maximo As Label
    Friend WithEvents lbl_contador As Label
    Friend WithEvents lbl_somatorio As Label
    Friend WithEvents _lbl As Button
    Friend WithEvents txb_input As TextBox
    Friend WithEvents lbl_maximo2 As Label
    Friend WithEvents lbl_maximo3 As Label
End Class
