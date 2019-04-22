<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsuma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.btnend = New System.Windows.Forms.Button()
        Me.btnminimizated = New System.Windows.Forms.Button()
        Me.btnminmax = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtres = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnend
        '
        Me.btnend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnend.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnend.FlatAppearance.BorderSize = 0
        Me.btnend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnend.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnend.Location = New System.Drawing.Point(261, 0)
        Me.btnend.Margin = New System.Windows.Forms.Padding(0)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(40, 29)
        Me.btnend.TabIndex = 1
        Me.btnend.Text = "X"
        Me.btnend.UseVisualStyleBackColor = False
        '
        'btnminimizated
        '
        Me.btnminimizated.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizated.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnminimizated.FlatAppearance.BorderSize = 0
        Me.btnminimizated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimizated.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnminimizated.Location = New System.Drawing.Point(181, 0)
        Me.btnminimizated.Margin = New System.Windows.Forms.Padding(0)
        Me.btnminimizated.Name = "btnminimizated"
        Me.btnminimizated.Size = New System.Drawing.Size(40, 29)
        Me.btnminimizated.TabIndex = 2
        Me.btnminimizated.Text = "_"
        Me.btnminimizated.UseVisualStyleBackColor = False
        '
        'btnminmax
        '
        Me.btnminmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminmax.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnminmax.FlatAppearance.BorderSize = 0
        Me.btnminmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminmax.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnminmax.Location = New System.Drawing.Point(221, 0)
        Me.btnminmax.Margin = New System.Windows.Forms.Padding(0)
        Me.btnminmax.Name = "btnminmax"
        Me.btnminmax.Size = New System.Drawing.Size(40, 29)
        Me.btnminmax.TabIndex = 3
        Me.btnminmax.Text = "□"
        Me.btnminmax.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbltitulo.Enabled = False
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.Black
        Me.lbltitulo.Location = New System.Drawing.Point(35, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(127, 16)
        Me.lbltitulo.TabIndex = 4
        Me.lbltitulo.Text = "Suma de 2 numeros"
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.White
        Me.btncalcular.FlatAppearance.BorderSize = 0
        Me.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(12, 91)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(277, 30)
        Me.btncalcular.TabIndex = 5
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'txtnum1
        '
        Me.txtnum1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum1.Location = New System.Drawing.Point(122, 35)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(167, 22)
        Me.txtnum1.TabIndex = 6
        '
        'txtnum2
        '
        Me.txtnum2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum2.Location = New System.Drawing.Point(122, 63)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(167, 22)
        Me.txtnum2.TabIndex = 7
        '
        'txtres
        '
        Me.txtres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtres.Enabled = False
        Me.txtres.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtres.Location = New System.Drawing.Point(121, 127)
        Me.txtres.Name = "txtres"
        Me.txtres.Size = New System.Drawing.Size(168, 22)
        Me.txtres.TabIndex = 8
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.White
        Me.btnlimpiar.FlatAppearance.BorderSize = 0
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(12, 155)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(91, 34)
        Me.btnlimpiar.TabIndex = 9
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresultado.Location = New System.Drawing.Point(12, 124)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(104, 24)
        Me.lblresultado.TabIndex = 10
        Me.lblresultado.Text = "Resultado: "
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum1.Location = New System.Drawing.Point(12, 35)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(99, 24)
        Me.lblnum1.TabIndex = 11
        Me.lblnum1.Text = "Numero 1:"
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum2.Location = New System.Drawing.Point(12, 63)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(99, 24)
        Me.lblnum2.TabIndex = 12
        Me.lblnum2.Text = "Numero 2:"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.White
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(198, 155)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(91, 34)
        Me.btnsalir.TabIndex = 13
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox2.BackgroundImage = Global.Minimizar.My.Resources.Resources.meter_calculator_114402
        Me.PictureBox2.Image = Global.Minimizar.My.Resources.Resources.meter_calculator_114403
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 29)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmsuma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(301, 201)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.txtres)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnminmax)
        Me.Controls.Add(Me.btnminimizated)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmsuma"
        Me.Text = "Suma de 2 numeros"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnend As Button
    Friend WithEvents btnminimizated As Button
    Friend WithEvents btnminmax As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtres As TextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents lblresultado As Label
    Friend WithEvents lblnum1 As Label
    Friend WithEvents lblnum2 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Dim MOVIENDO As Boolean = False
    Dim MIX, MIY, st As Integer
    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        End
    End Sub
    Private Sub btnminimizated_Click(sender As Object, e As EventArgs) Handles btnminimizated.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        'MEMORIZA LA POSICION DE LA ETIQUETA
        MIX = MousePosition.X - Me.Location.X
        MIY = MousePosition.Y - Me.Location.Y
        MOVIENDO = True 'INICIA EL MOVIMIENTO
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If MOVIENDO = True Then
            Me.Location = New Point(MousePosition.X - MIX, MousePosition.Y - MIY) 'MUEVE EL FORM SEGUN EL CAMBIO DE POSICION DE LA ETIQUETA
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        MOVIENDO = False
    End Sub
    Private Sub btnminmax_Click(sender As Object, e As EventArgs) Handles btnminmax.Click
        If st = 0 Then
            Location = New Point(0, 0)
            Size = My.Computer.Screen.WorkingArea.Size
            st = 1

        ElseIf st = 1 Then
            StartPosition = FormStartPosition.CenterScreen
            Me.ClientSize = New System.Drawing.Size(301, 201) ' pon el mismo valor de la ventana de default del frmsuma
            Location = DefaultSize
            st = 0
        End If
    End Sub
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If st = 0 Then
            Location = New Point(0, 0)
            Size = My.Computer.Screen.WorkingArea.Size
            st = 1
        ElseIf st = 1 Then
            StartPosition = FormStartPosition.CenterScreen
            ClientSize = New Size(301, 201)
            Location = DefaultSize
            st = 0
        End If
    End Sub
End Class
