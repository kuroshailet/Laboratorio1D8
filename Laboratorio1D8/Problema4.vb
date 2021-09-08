Public Class Problema4
    Dim tmayor, tmenor, tingresada As Integer
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        tingresada = nupTemp.Value

        If (tingresada = 0) Then
            Label1.Hide()
            Label2.Hide()
            btnEnviar.Hide()
            nupTemp.Hide()
            lblTmayor.Text = tmayor
            lblTmenor.Text = tmenor
            lbl33.Show()
            lbl37.Show()
            lblTmayor.Show()
            lblTmenor.Show()



        ElseIf (tingresada > 37) Then
            tmayor += 1

        ElseIf (tmenor < 33) Then
            tmenor += 1

        End If
    End Sub
End Class