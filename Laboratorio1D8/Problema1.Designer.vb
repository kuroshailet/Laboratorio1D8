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
        Me.btnCalcularSalario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTarifaHor = New System.Windows.Forms.TextBox()
        Me.lblhoras = New System.Windows.Forms.Label()
        Me.txtHorasTra = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalarioNeto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSalarioBruto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Location = New System.Drawing.Point(62, 93)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(195, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Captura de Datos"
        '
        'btnCalcularSalario
        '
        Me.btnCalcularSalario.Location = New System.Drawing.Point(27, 117)
        Me.btnCalcularSalario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcularSalario.Name = "btnCalcularSalario"
        Me.btnCalcularSalario.Size = New System.Drawing.Size(134, 21)
        Me.btnCalcularSalario.TabIndex = 5
        Me.btnCalcularSalario.Text = "Calcular Sueldo"
        Me.btnCalcularSalario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tarifa Horaria"
        '
        'txtTarifaHor
        '
        Me.txtTarifaHor.Location = New System.Drawing.Point(110, 75)
        Me.txtTarifaHor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTarifaHor.Name = "txtTarifaHor"
        Me.txtTarifaHor.Size = New System.Drawing.Size(76, 20)
        Me.txtTarifaHor.TabIndex = 2
        '
        'lblhoras
        '
        Me.lblhoras.AutoSize = True
        Me.lblhoras.Location = New System.Drawing.Point(14, 54)
        Me.lblhoras.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhoras.Name = "lblhoras"
        Me.lblhoras.Size = New System.Drawing.Size(91, 13)
        Me.lblhoras.TabIndex = 1
        Me.lblhoras.Text = "Horas Trabajadas"
        '
        'txtHorasTra
        '
        Me.txtHorasTra.Location = New System.Drawing.Point(110, 52)
        Me.txtHorasTra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHorasTra.Name = "txtHorasTra"
        Me.txtHorasTra.Size = New System.Drawing.Size(76, 20)
        Me.txtHorasTra.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSalarioNeto)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSalarioBruto)
        Me.GroupBox2.Location = New System.Drawing.Point(326, 93)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(195, 156)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Salario Neto"
        '
        'txtSalarioNeto
        '
        Me.txtSalarioNeto.Location = New System.Drawing.Point(110, 75)
        Me.txtSalarioNeto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalarioNeto.Name = "txtSalarioNeto"
        Me.txtSalarioNeto.ReadOnly = True
        Me.txtSalarioNeto.Size = New System.Drawing.Size(76, 20)
        Me.txtSalarioNeto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Salario Bruto"
        '
        'txtSalarioBruto
        '
        Me.txtSalarioBruto.Location = New System.Drawing.Point(110, 52)
        Me.txtSalarioBruto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalarioBruto.Name = "txtSalarioBruto"
        Me.txtSalarioBruto.ReadOnly = True
        Me.txtSalarioBruto.Size = New System.Drawing.Size(76, 20)
        Me.txtSalarioBruto.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pago mensual de un empleado"
        '
        'Problema1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Problema1"
        Me.Text = "Problema1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label4 As Label
End Class
