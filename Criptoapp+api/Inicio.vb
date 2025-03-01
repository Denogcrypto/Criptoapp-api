Public Class Inicio
    Private Sub Cargarprecios_Click(sender As Object, e As EventArgs) Handles cargarprecios.Click
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NoticiasCripto As New NoticiasCripto()
        NoticiasCripto.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim portafolio As New Portafolio()
        portafolio.Show()
    End Sub
End Class