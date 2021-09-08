<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema2
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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtIngreseEdad = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblIngreseEdad = New System.Windows.Forms.Label()
        Me.lblEdadMama = New System.Windows.Forms.Label()
        Me.txtEdadMama = New System.Windows.Forms.TextBox()
        Me.lblEdadAna = New System.Windows.Forms.Label()
        Me.txtEdadAna = New System.Windows.Forms.TextBox()
        Me.lblEdadAlberto = New System.Windows.Forms.Label()
        Me.txtEdadAlberto = New System.Windows.Forms.TextBox()
        Me.lblEdadJuan = New System.Windows.Forms.Label()
        Me.txtEdadJuan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(249, 246)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtIngreseEdad
        '
        Me.txtIngreseEdad.Location = New System.Drawing.Point(72, 95)
        Me.txtIngreseEdad.Name = "txtIngreseEdad"
        Me.txtIngreseEdad.Size = New System.Drawing.Size(118, 20)
        Me.txtIngreseEdad.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(221, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(131, 13)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Edad de la Mamá de Juan"
        '
        'lblIngreseEdad
        '
        Me.lblIngreseEdad.AutoSize = True
        Me.lblIngreseEdad.Location = New System.Drawing.Point(69, 79)
        Me.lblIngreseEdad.Name = "lblIngreseEdad"
        Me.lblIngreseEdad.Size = New System.Drawing.Size(121, 13)
        Me.lblIngreseEdad.TabIndex = 3
        Me.lblIngreseEdad.Text = "Ingrese la edad de Juan"
        '
        'lblEdadMama
        '
        Me.lblEdadMama.AutoSize = True
        Me.lblEdadMama.Location = New System.Drawing.Point(400, 79)
        Me.lblEdadMama.Name = "lblEdadMama"
        Me.lblEdadMama.Size = New System.Drawing.Size(36, 13)
        Me.lblEdadMama.TabIndex = 5
        Me.lblEdadMama.Text = "Mamá"
        '
        'txtEdadMama
        '
        Me.txtEdadMama.Location = New System.Drawing.Point(403, 95)
        Me.txtEdadMama.Name = "txtEdadMama"
        Me.txtEdadMama.ReadOnly = True
        Me.txtEdadMama.Size = New System.Drawing.Size(100, 20)
        Me.txtEdadMama.TabIndex = 4
        '
        'lblEdadAna
        '
        Me.lblEdadAna.AutoSize = True
        Me.lblEdadAna.Location = New System.Drawing.Point(400, 118)
        Me.lblEdadAna.Name = "lblEdadAna"
        Me.lblEdadAna.Size = New System.Drawing.Size(26, 13)
        Me.lblEdadAna.TabIndex = 7
        Me.lblEdadAna.Text = "Ana"
        '
        'txtEdadAna
        '
        Me.txtEdadAna.Location = New System.Drawing.Point(403, 134)
        Me.txtEdadAna.Name = "txtEdadAna"
        Me.txtEdadAna.ReadOnly = True
        Me.txtEdadAna.Size = New System.Drawing.Size(100, 20)
        Me.txtEdadAna.TabIndex = 6
        '
        'lblEdadAlberto
        '
        Me.lblEdadAlberto.AutoSize = True
        Me.lblEdadAlberto.Location = New System.Drawing.Point(400, 157)
        Me.lblEdadAlberto.Name = "lblEdadAlberto"
        Me.lblEdadAlberto.Size = New System.Drawing.Size(40, 13)
        Me.lblEdadAlberto.TabIndex = 9
        Me.lblEdadAlberto.Text = "Alberto"
        '
        'txtEdadAlberto
        '
        Me.txtEdadAlberto.Location = New System.Drawing.Point(403, 173)
        Me.txtEdadAlberto.Name = "txtEdadAlberto"
        Me.txtEdadAlberto.ReadOnly = True
        Me.txtEdadAlberto.Size = New System.Drawing.Size(100, 20)
        Me.txtEdadAlberto.TabIndex = 8
        '
        'lblEdadJuan
        '
        Me.lblEdadJuan.AutoSize = True
        Me.lblEdadJuan.Location = New System.Drawing.Point(400, 196)
        Me.lblEdadJuan.Name = "lblEdadJuan"
        Me.lblEdadJuan.Size = New System.Drawing.Size(30, 13)
        Me.lblEdadJuan.TabIndex = 11
        Me.lblEdadJuan.Text = "Juan"
        '
        'txtEdadJuan
        '
        Me.txtEdadJuan.Location = New System.Drawing.Point(403, 212)
        Me.txtEdadJuan.Name = "txtEdadJuan"
        Me.txtEdadJuan.ReadOnly = True
        Me.txtEdadJuan.Size = New System.Drawing.Size(100, 20)
        Me.txtEdadJuan.TabIndex = 10
        '
        'Problema2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblEdadJuan)
        Me.Controls.Add(Me.txtEdadJuan)
        Me.Controls.Add(Me.lblEdadAlberto)
        Me.Controls.Add(Me.txtEdadAlberto)
        Me.Controls.Add(Me.lblEdadAna)
        Me.Controls.Add(Me.txtEdadAna)
        Me.Controls.Add(Me.lblEdadMama)
        Me.Controls.Add(Me.txtEdadMama)
        Me.Controls.Add(Me.lblIngreseEdad)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtIngreseEdad)
        Me.Controls.Add(Me.btnCalcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Problema2"
        Me.Text = "Problema2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtIngreseEdad As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblIngreseEdad As Label
    Friend WithEvents lblEdadMama As Label
    Friend WithEvents txtEdadMama As TextBox
    Friend WithEvents lblEdadAna As Label
    Friend WithEvents txtEdadAna As TextBox
    Friend WithEvents lblEdadAlberto As Label
    Friend WithEvents txtEdadAlberto As TextBox
    Friend WithEvents lblEdadJuan As Label
    Friend WithEvents txtEdadJuan As TextBox
End Class
