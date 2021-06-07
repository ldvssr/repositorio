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
        Me.SuspendLayout()
        '
        'btn_calcular_msb
        '
        Me.btn_calcular_msb.Location = New System.Drawing.Point(118, 41)
        Me.btn_calcular_msb.Name = "btn_calcular_msb"
        Me.btn_calcular_msb.Size = New System.Drawing.Size(100, 23)
        Me.btn_calcular_msb.TabIndex = 23
        Me.btn_calcular_msb.Text = "Calcular MSB"
        Me.btn_calcular_msb.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Location = New System.Drawing.Point(249, 93)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(75, 23)
        Me.btn_menu.TabIndex = 22
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(12, 93)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpar.TabIndex = 21
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'lbl_maximo
        '
        Me.lbl_maximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_maximo.Location = New System.Drawing.Point(224, 67)
        Me.lbl_maximo.Name = "lbl_maximo"
        Me.lbl_maximo.Size = New System.Drawing.Size(100, 23)
        Me.lbl_maximo.TabIndex = 20
        '
        'lbl_contador
        '
        Me.lbl_contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_contador.Location = New System.Drawing.Point(118, 67)
        Me.lbl_contador.Name = "lbl_contador"
        Me.lbl_contador.Size = New System.Drawing.Size(100, 23)
        Me.lbl_contador.TabIndex = 19
        '
        'lbl_somatorio
        '
        Me.lbl_somatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_somatorio.Location = New System.Drawing.Point(12, 67)
        Me.lbl_somatorio.Name = "lbl_somatorio"
        Me.lbl_somatorio.Size = New System.Drawing.Size(100, 23)
        Me.lbl_somatorio.TabIndex = 18
        '
        '_lbl
        '
        Me._lbl.Location = New System.Drawing.Point(12, 41)
        Me._lbl.Name = "_lbl"
        Me._lbl.Size = New System.Drawing.Size(100, 23)
        Me._lbl.TabIndex = 17
        Me._lbl.Text = "Calcular LBL"
        Me._lbl.UseVisualStyleBackColor = True
        '
        'txb_input
        '
        Me.txb_input.Location = New System.Drawing.Point(12, 12)
        Me.txb_input.Name = "txb_input"
        Me.txb_input.Size = New System.Drawing.Size(100, 23)
        Me.txb_input.TabIndex = 16
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 166)
        Me.Controls.Add(Me.btn_calcular_msb)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.lbl_maximo)
        Me.Controls.Add(Me.lbl_contador)
        Me.Controls.Add(Me.lbl_somatorio)
        Me.Controls.Add(Me._lbl)
        Me.Controls.Add(Me.txb_input)
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
End Class
