Public Class Form1

    Private Sub AddFormInPanel(formHijo)
        If (Me.splitContainer1.Panel2.Controls.Count > 0) Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
        Dim fh = formHijo
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(fh)
        Me.splitContainer1.Panel2.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnProblema1_Click(sender As Object, e As EventArgs) Handles btnProblema1.Click

        AddFormInPanel(New Problema1())

    End Sub

    Private Sub btnProblema2_Click(sender As Object, e As EventArgs) Handles btnProblema2.Click

        AddFormInPanel(New Problema2())

    End Sub

    Private Sub btnProblema3_Click(sender As Object, e As EventArgs) Handles btnProblema3.Click

        AddFormInPanel(New Problema3())

    End Sub

    Private Sub btnProblema4_Click(sender As Object, e As EventArgs) Handles btnProblema4.Click

        AddFormInPanel(New Problema4())

    End Sub

    Private Sub btnProblema5_Click(sender As Object, e As EventArgs) Handles btnProblema5.Click

        AddFormInPanel(New Problema5())

    End Sub
End Class
