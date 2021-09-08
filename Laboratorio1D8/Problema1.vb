Public Class Problema1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcularSalario.Click
        Dim salarioB As Double

        If (Val(txtHorasTra.Text) > 0 And Val(txtTarifaHor.Text) > 0) Then
            salarioB = Val(txtHorasTra.Text) * Val(txtTarifaHor.Text)
            txtSalarioBruto.Text = salarioB
            txtSalarioNeto.Text = salarioB - ((salarioB * 12) / 100)
        Else
            MsgBox("Valores invalidos.")
        End If

    End Sub
End Class