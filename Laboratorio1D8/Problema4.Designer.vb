<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema4
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
        Me.lblTmayor = New System.Windows.Forms.Label()
        Me.lblTmenor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nupTemp = New System.Windows.Forms.NumericUpDown()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.lblhoras = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.nupTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTmayor
        '
        Me.lblTmayor.AutoSize = True
        Me.lblTmayor.Location = New System.Drawing.Point(169, 268)
        Me.lblTmayor.Name = "lblTmayor"
        Me.lblTmayor.Size = New System.Drawing.Size(10, 13)
        Me.lblTmayor.TabIndex = 16
        Me.lblTmayor.Text = "-"
        '
        'lblTmenor
        '
        Me.lblTmenor.AutoSize = True
        Me.lblTmenor.Location = New System.Drawing.Point(169, 224)
        Me.lblTmenor.Name = "lblTmenor"
        Me.lblTmenor.Size = New System.Drawing.Size(10, 13)
        Me.lblTmenor.TabIndex = 15
        Me.lblTmenor.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ingrese 0 para terminar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ingrese su temperatura"
        '
        'nupTemp
        '
        Me.nupTemp.Location = New System.Drawing.Point(20, 55)
        Me.nupTemp.Name = "nupTemp"
        Me.nupTemp.Size = New System.Drawing.Size(112, 20)
        Me.nupTemp.TabIndex = 10
        Me.nupTemp.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(195, 52)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 9
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'lblhoras
        '
        Me.lblhoras.AutoSize = True
        Me.lblhoras.Location = New System.Drawing.Point(231, 9)
        Me.lblhoras.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhoras.Name = "lblhoras"
        Me.lblhoras.Size = New System.Drawing.Size(120, 13)
        Me.lblhoras.TabIndex = 17
        Me.lblhoras.Text = "Registro de temperatura"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEnviar)
        Me.GroupBox1.Controls.Add(Me.nupTemp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 143)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Problema4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblhoras)
        Me.Controls.Add(Me.lblTmayor)
        Me.Controls.Add(Me.lblTmenor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Problema4"
        Me.Text = "Problema4"
        CType(Me.nupTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTmayor As Label
    Friend WithEvents lblTmenor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nupTemp As NumericUpDown
    Friend WithEvents btnEnviar As Button
    Friend WithEvents lblhoras As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
