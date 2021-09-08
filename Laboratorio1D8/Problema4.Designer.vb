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
        Me.lbl37 = New System.Windows.Forms.Label()
        Me.lbl33 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nupTemp = New System.Windows.Forms.NumericUpDown()
        Me.btnEnviar = New System.Windows.Forms.Button()
        CType(Me.nupTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTmayor
        '
        Me.lblTmayor.AutoSize = True
        Me.lblTmayor.Location = New System.Drawing.Point(397, 288)
        Me.lblTmayor.Name = "lblTmayor"
        Me.lblTmayor.Size = New System.Drawing.Size(134, 13)
        Me.lblTmayor.TabIndex = 16
        Me.lblTmayor.Text = "Temperatura menor a 33ºC"
        Me.lblTmayor.Visible = False
        '
        'lblTmenor
        '
        Me.lblTmenor.AutoSize = True
        Me.lblTmenor.Location = New System.Drawing.Point(397, 234)
        Me.lblTmenor.Name = "lblTmenor"
        Me.lblTmenor.Size = New System.Drawing.Size(134, 13)
        Me.lblTmenor.TabIndex = 15
        Me.lblTmenor.Text = "Temperatura menor a 33ºC"
        Me.lblTmenor.Visible = False
        '
        'lbl37
        '
        Me.lbl37.AutoSize = True
        Me.lbl37.Location = New System.Drawing.Point(241, 288)
        Me.lbl37.Name = "lbl37"
        Me.lbl37.Size = New System.Drawing.Size(133, 13)
        Me.lbl37.TabIndex = 14
        Me.lbl37.Text = "Temperatura mayor a 37ºC"
        Me.lbl37.Visible = False
        '
        'lbl33
        '
        Me.lbl33.AutoSize = True
        Me.lbl33.Location = New System.Drawing.Point(241, 234)
        Me.lbl33.Name = "lbl33"
        Me.lbl33.Size = New System.Drawing.Size(134, 13)
        Me.lbl33.TabIndex = 13
        Me.lbl33.Text = "Temperatura menor a 33ºC"
        Me.lbl33.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ingrese 0 para terminar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ingrese su temperatura"
        '
        'nupTemp
        '
        Me.nupTemp.Location = New System.Drawing.Point(390, 149)
        Me.nupTemp.Name = "nupTemp"
        Me.nupTemp.Size = New System.Drawing.Size(61, 20)
        Me.nupTemp.TabIndex = 10
        Me.nupTemp.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(485, 149)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 9
        Me.btnEnviar.Text = "Button1"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Problema4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTmayor)
        Me.Controls.Add(Me.lblTmenor)
        Me.Controls.Add(Me.lbl37)
        Me.Controls.Add(Me.lbl33)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nupTemp)
        Me.Controls.Add(Me.btnEnviar)
        Me.Name = "Problema4"
        Me.Text = "Problema4"
        CType(Me.nupTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTmayor As Label
    Friend WithEvents lblTmenor As Label
    Friend WithEvents lbl37 As Label
    Friend WithEvents lbl33 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nupTemp As NumericUpDown
    Friend WithEvents btnEnviar As Button
End Class
