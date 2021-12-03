Public Class Form1
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click

        limparLista()
        Dim i As Integer

        For i = 1 To 5
            lstLista.Items.Add("O " & i & "º da lista")
        Next

    End Sub

    Private Sub limparLista()
        lstLista.Items.Clear()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limparLista()
    End Sub
End Class
