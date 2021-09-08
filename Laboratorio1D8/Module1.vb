Module Module1

    Public Sub CalcularEdad(ByVal edad As Integer)

        Dim edadJuan As Integer
        Dim edadAna As Integer
        Dim edadAlberto As Integer
        Dim edadMama As Integer

        edadJuan = edad

        edadAna = 4 * edadJuan / 3
        edadAlberto = 2 * edadJuan / 3
        edadMama = edadJuan + edadAna + edadAlberto

        Problema2.txtEdadJuan.Text = edadJuan
        Problema2.txtEdadAna.Text = edadAna
        Problema2.txtEdadAlberto.Text = edadAlberto
        Problema2.txtEdadMama.Text = edadMama


    End Sub

End Module
