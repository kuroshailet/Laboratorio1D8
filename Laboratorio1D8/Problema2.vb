Public Class Problema2
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Call CalcularEdad.CalcularEdad(Val(txtIngreseEdad.Text))

    End Sub
End Class