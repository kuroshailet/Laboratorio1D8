Public Class Problema3
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Call CalcularGananciaSocio.CalcularGananciaSocio(Val(txtCapital1.Text), Val(txtCapital2.Text), Val(txtCapital3.Text), Val(txtGanancias.Text))

    End Sub
End Class