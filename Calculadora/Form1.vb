Public Class Form1

    Private Sub Clicar_Botao(sender As Object, e As EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click
        Formula.Text = Formula.Text + sender.Text
    End Sub

    Private Sub Calcular_Formula(sender As Object, e As EventArgs) Handles Button16.Click
        Resultado.Text = New DataTable().Compute(Formula.Text, Nothing)
    End Sub

    Private Sub Limpar_Valores(sender As Object, e As EventArgs) Handles Button17.Click
        Formula.Text, Resultado.Text = ""
    End Sub
End Class
