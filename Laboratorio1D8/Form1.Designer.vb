<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnProblema1 = New System.Windows.Forms.Button()
        Me.btnProblema2 = New System.Windows.Forms.Button()
        Me.btnProblema3 = New System.Windows.Forms.Button()
        Me.btnProblema4 = New System.Windows.Forms.Button()
        Me.btnProblema5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnProblema5)
        Me.Panel1.Controls.Add(Me.btnProblema4)
        Me.Panel1.Controls.Add(Me.btnProblema3)
        Me.Panel1.Controls.Add(Me.btnProblema2)
        Me.Panel1.Controls.Add(Me.btnProblema1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 326)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(168, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 326)
        Me.Panel2.TabIndex = 1
        '
        'btnProblema1
        '
        Me.btnProblema1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProblema1.Location = New System.Drawing.Point(0, 0)
        Me.btnProblema1.Name = "btnProblema1"
        Me.btnProblema1.Size = New System.Drawing.Size(161, 65)
        Me.btnProblema1.TabIndex = 0
        Me.btnProblema1.Text = "Problema 1"
        Me.btnProblema1.UseVisualStyleBackColor = True
        '
        'btnProblema2
        '
        Me.btnProblema2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProblema2.Location = New System.Drawing.Point(0, 65)
        Me.btnProblema2.Name = "btnProblema2"
        Me.btnProblema2.Size = New System.Drawing.Size(161, 65)
        Me.btnProblema2.TabIndex = 1
        Me.btnProblema2.Text = "Problema 2"
        Me.btnProblema2.UseVisualStyleBackColor = True
        '
        'btnProblema3
        '
        Me.btnProblema3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProblema3.Location = New System.Drawing.Point(0, 130)
        Me.btnProblema3.Name = "btnProblema3"
        Me.btnProblema3.Size = New System.Drawing.Size(161, 65)
        Me.btnProblema3.TabIndex = 2
        Me.btnProblema3.Text = "Problema 3"
        Me.btnProblema3.UseVisualStyleBackColor = True
        '
        'btnProblema4
        '
        Me.btnProblema4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProblema4.Location = New System.Drawing.Point(0, 195)
        Me.btnProblema4.Name = "btnProblema4"
        Me.btnProblema4.Size = New System.Drawing.Size(161, 65)
        Me.btnProblema4.TabIndex = 3
        Me.btnProblema4.Text = "Problema 4"
        Me.btnProblema4.UseVisualStyleBackColor = True
        '
        'btnProblema5
        '
        Me.btnProblema5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProblema5.Location = New System.Drawing.Point(0, 260)
        Me.btnProblema5.Name = "btnProblema5"
        Me.btnProblema5.Size = New System.Drawing.Size(161, 65)
        Me.btnProblema5.TabIndex = 4
        Me.btnProblema5.Text = "Problema 5"
        Me.btnProblema5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 326)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Laboratorio 1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProblema5 As Button
    Friend WithEvents btnProblema4 As Button
    Friend WithEvents btnProblema3 As Button
    Friend WithEvents btnProblema2 As Button
    Friend WithEvents btnProblema1 As Button
    Friend WithEvents Panel2 As Panel
End Class
