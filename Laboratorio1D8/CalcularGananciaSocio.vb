Module CalcularGananciaSocio

    Public Sub CalcularGananciaSocio(ByVal capital1 As Double, capital2 As Double, capital3 As Double, ganancias As Double)

        Dim capitalTotal As Double

        'Porcentaje correspondiente a cada socio
        Dim porcentaje1 As Double
        Dim porcentaje2 As Double
        Dim porcentaje3 As Double

        'Ganancia correspondiente a cada socio
        Dim ganancia1 As Double
        Dim ganancia2 As Double
        Dim ganancia3 As Double

        capitalTotal = capital1 + capital2 + capital3
        porcentaje1 = (capital1 / capitalTotal)
        porcentaje2 = (capital2 / capitalTotal)
        porcentaje3 = (capital3 / capitalTotal)
        ganancia1 = (ganancias * porcentaje1)
        ganancia2 = (ganancias * porcentaje2)
        ganancia3 = (ganancias * porcentaje3)

        Problema3.txtGanancia1.Text = ganancia1
        Problema3.txtGanancia2.Text = ganancia2
        Problema3.txtGanancia3.Text = ganancia3



    End Sub

End Module
