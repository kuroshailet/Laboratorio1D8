<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema1
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHorasTra = New System.Windows.Forms.TextBox()
        Me.lblhoras = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTarifaHor = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalarioNeto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSalarioBruto = New System.Windows.Forms.TextBox()
        Me.btnCalcularSalario = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalcularSalario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTarifaHor)
        Me.GroupBox1.Controls.Add(Me.lblhoras)
        Me.GroupBox1.Controls.Add(Me.txtHorasTra)
        Me.GroupBox1.Location = New System.Drawing.Point(83, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Captura de Datos"
        '
        'txtHorasTra
        '
        Me.txtHorasTra.Location = New System.Drawing.Point(147, 64)
        Me.txtHorasTra.Name = "txtHorasTra"
        Me.txtHorasTra.Size = New System.Drawing.Size(100, 22)
        Me.txtHorasTra.TabIndex = 0
        '
        'lblhoras
        '
        Me.lblhoras.AutoSize = True
        Me.lblhoras.Location = New System.Drawing.Point(19, 67)
        Me.lblhoras.Name = "lblhoras"
        Me.lblhoras.Size = New System.Drawing.Size(122, 17)
        Me.lblhoras.TabIndex = 1
        Me.lblhoras.Text = "Horas Trabajadas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tarifa Horaria"
        '
        'txtTarifaHor
        '
        Me.txtTarifaHor.Location = New System.Drawing.Point(147, 92)
        Me.txtTarifaHor.Name = "txtTarifaHor"
        Me.txtTarifaHor.Size = New System.Drawing.Size(100, 22)
        Me.txtTarifaHor.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSalarioNeto)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSalarioBruto)
        Me.GroupBox2.Location = New System.Drawing.Point(434, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 192)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Salario Neto"
        '
        'txtSalarioNeto
        '
        Me.txtSalarioNeto.Location = New System.Drawing.Point(147, 92)
        Me.txtSalarioNeto.Name = "txtSalarioNeto"
        Me.txtSalarioNeto.ReadOnly = True
        Me.txtSalarioNeto.Size = New System.Drawing.Size(100, 22)
        Me.txtSalarioNeto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Salario Bruto"
        '
        'txtSalarioBruto
        '
        Me.txtSalarioBruto.Location = New System.Drawing.Point(147, 64)
        Me.txtSalarioBruto.Name = "txtSalarioBruto"
        Me.txtSalarioBruto.ReadOnly = True
        Me.txtSalarioBruto.Size = New System.Drawing.Size(100, 22)
        Me.txtSalarioBruto.TabIndex = 0
        '
        'btnCalcularSalario
        '
        Me.btnCalcularSalario.Location = New System.Drawing.Point(73, 144)
        Me.btnCalcularSalario.Name = "btnCalcularSalario"
        Me.btnCalcularSalario.Size = New System.Drawing.Size(118, 26)
        Me.btnCalcularSalario.TabIndex = 5
        Me.btnCalcularSalario.Text = "Calcular Sueldo"
        Me.btnCalcularSalario.UseVisualStyleBackColor = True
        '
        'Problema1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Problema1"
        Me.Text = "Problema1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalcularSalario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTarifaHor As TextBox
    Friend WithEvents lblhoras As Label
    Friend WithEvents txtHorasTra As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalarioNeto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSalarioBruto As TextBox
End Class
