Public Class Form1
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        'lstDisplay.Items.Clear()

        Dim intNumbers() As Integer = {5, 2, 4, 1, 0}
        For xx = intNumbers.GetLowerBound(0) To intNumbers.GetUpperBound(0) - 1
            For i = intNumbers.GetLowerBound(0) To intNumbers.GetUpperBound(0) - 1
                If (intNumbers(i) > intNumbers(i + 1)) Then
                    Dim exc As Integer = intNumbers(i)
                    intNumbers(i) = intNumbers(i + 1)
                    intNumbers(i + 1) = exc
                End If
            Next i
        Next xx

        For i = intNumbers.GetLowerBound(0) To intNumbers.GetUpperBound(0)
            lstDisplay.Items.Add(intNumbers(i))
        Next

'coment
    End Sub
End Class
