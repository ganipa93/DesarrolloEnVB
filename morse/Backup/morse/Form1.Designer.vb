<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_morse
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmd_calcular = New System.Windows.Forms.Button
        Me.txt_original = New System.Windows.Forms.TextBox
        Me.txt_resultado = New System.Windows.Forms.TextBox
        Me.lbl_convertir = New System.Windows.Forms.Label
        Me.lbl_morse = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmd_calcular
        '
        Me.cmd_calcular.Location = New System.Drawing.Point(188, 68)
        Me.cmd_calcular.Name = "cmd_calcular"
        Me.cmd_calcular.Size = New System.Drawing.Size(77, 22)
        Me.cmd_calcular.TabIndex = 0
        Me.cmd_calcular.Text = "Calcular"
        Me.cmd_calcular.UseVisualStyleBackColor = True
        '
        'txt_original
        '
        Me.txt_original.Location = New System.Drawing.Point(105, 10)
        Me.txt_original.Name = "txt_original"
        Me.txt_original.Size = New System.Drawing.Size(323, 20)
        Me.txt_original.TabIndex = 0
        '
        'txt_resultado
        '
        Me.txt_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_resultado.Location = New System.Drawing.Point(105, 36)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(323, 26)
        Me.txt_resultado.TabIndex = 2
        '
        'lbl_convertir
        '
        Me.lbl_convertir.AutoSize = True
        Me.lbl_convertir.Location = New System.Drawing.Point(12, 15)
        Me.lbl_convertir.Name = "lbl_convertir"
        Me.lbl_convertir.Size = New System.Drawing.Size(87, 13)
        Me.lbl_convertir.TabIndex = 3
        Me.lbl_convertir.Text = "Texto a convertir"
        '
        'lbl_morse
        '
        Me.lbl_morse.AutoSize = True
        Me.lbl_morse.Location = New System.Drawing.Point(12, 39)
        Me.lbl_morse.Name = "lbl_morse"
        Me.lbl_morse.Size = New System.Drawing.Size(80, 13)
        Me.lbl_morse.TabIndex = 4
        Me.lbl_morse.Text = "Texto en morse"
        '
        'frm_morse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 96)
        Me.Controls.Add(Me.lbl_morse)
        Me.Controls.Add(Me.lbl_convertir)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.txt_original)
        Me.Controls.Add(Me.cmd_calcular)
        Me.Name = "frm_morse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor en morse                                       skskynet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_calcular As System.Windows.Forms.Button
    Friend WithEvents txt_original As System.Windows.Forms.TextBox
    Friend WithEvents txt_resultado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_convertir As System.Windows.Forms.Label
    Friend WithEvents lbl_morse As System.Windows.Forms.Label

End Class
