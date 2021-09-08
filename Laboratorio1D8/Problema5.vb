Public Class Problema5
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numList(10), temp, men, may, vali As Integer
        vali = 0
        temp = 0
        lstOfertas.Items.Clear()
        'Para cuando esten los valores
        For Each c As Control In Controls
            Dim t As TextBox = TryCast(c, TextBox)
            If t IsNot Nothing Then
                numList(temp) = Val(t.Text)
                temp += 1
            End If
        Next

        'here you can use any numbers in any order
        Dim Count As Integer = 0
        Dim Swapvalue As Integer
        For ii = 0 To numList.Length - 2
            For i = 0 To numList.Length - 2
                Count += 1
                If numList(i) < numList(i + 1) Then
                    Swapvalue = numList(i)
                    numList(i) = numList(i + 1)
                    numList(i + 1) = Swapvalue
                End If
            Next
        Next
        For i = 0 To 10
            If (numList(i) > 0) Then
                lstOfertas.Items.Add(numList(i))
                If vali = 0 Then
                    may = i
                    men = i
                    vali = 1
                Else
                    If numList(may) > numList(i) Then
                        may = i
                    End If
                    If numList(men) < numList(i) Then
                        men = i
                    End If
                End If
            End If
        Next

        txtMayor.Text = numList(may)
        txtMenor.Text = numList(men)

    End Sub
End Class