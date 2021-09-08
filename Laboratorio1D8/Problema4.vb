Public Class Problema4
    Dim tmayor, tmenor, tingresada As Integer
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        tingresada = nupTemp.Value

        If (tingresada = 0) Then

            lblTmayor.Text = "Hay " & tmayor & " Personas con una temperatura mayor a 37°C"
            lblTmenor.Text = "Hay " & tmenor & " Personas con una temperatura menor a 33°C"
            tmayor = 0
            tmenor = 0


        ElseIf (tingresada > 37) Then
            tmayor += 1

        ElseIf (tmenor < 33) Then
            tmenor += 1

        End If
    End Sub
End Class