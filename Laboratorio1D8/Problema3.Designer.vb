<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCapital1 = New System.Windows.Forms.TextBox()
        Me.txtCapital2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCapital3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtGanancia3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGanancia2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGanancia1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGanancias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(164, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(253, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Ganancias de los socios en base al capital aportado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Capital del Socio 1"
        '
        'txtCapital1
        '
        Me.txtCapital1.Location = New System.Drawing.Point(48, 68)
        Me.txtCapital1.Name = "txtCapital1"
        Me.txtCapital1.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital1.TabIndex = 2
        '
        'txtCapital2
        '
        Me.txtCapital2.Location = New System.Drawing.Point(48, 107)
        Me.txtCapital2.Name = "txtCapital2"
        Me.txtCapital2.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Capital del Socio 2"
        '
        'txtCapital3
        '
        Me.txtCapital3.Location = New System.Drawing.Point(48, 146)
        Me.txtCapital3.Name = "txtCapital3"
        Me.txtCapital3.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Capital Socio 3"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(250, 248)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtGanancia3
        '
        Me.txtGanancia3.Location = New System.Drawing.Point(432, 146)
        Me.txtGanancia3.Name = "txtGanancia3"
        Me.txtGanancia3.ReadOnly = True
        Me.txtGanancia3.Size = New System.Drawing.Size(100, 20)
        Me.txtGanancia3.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(429, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ganancias del Socio 3"
        '
        'txtGanancia2
        '
        Me.txtGanancia2.Location = New System.Drawing.Point(432, 107)
        Me.txtGanancia2.Name = "txtGanancia2"
        Me.txtGanancia2.ReadOnly = True
        Me.txtGanancia2.Size = New System.Drawing.Size(100, 20)
        Me.txtGanancia2.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(429, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ganancias del Socio 2"
        '
        'txtGanancia1
        '
        Me.txtGanancia1.Location = New System.Drawing.Point(432, 68)
        Me.txtGanancia1.Name = "txtGanancia1"
        Me.txtGanancia1.ReadOnly = True
        Me.txtGanancia1.Size = New System.Drawing.Size(100, 20)
        Me.txtGanancia1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(429, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Ganancias del Socio 1"
        '
        'txtGanancias
        '
        Me.txtGanancias.Location = New System.Drawing.Point(48, 185)
        Me.txtGanancias.Name = "txtGanancias"
        Me.txtGanancias.Size = New System.Drawing.Size(100, 20)
        Me.txtGanancias.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ganancias de la empresa"
        '
        'Problema3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 283)
        Me.Controls.Add(Me.txtGanancias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGanancia3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGanancia2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGanancia1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCapital3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCapital2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCapital1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Problema3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCapital1 As TextBox
    Friend WithEvents txtCapital2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCapital3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtGanancia3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGanancia2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGanancia1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtGanancias As TextBox
    Friend WithEvents Label1 As Label
End Class
