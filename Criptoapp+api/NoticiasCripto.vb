Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class NoticiasCripto
    Private Async Sub ButtonCargarNoticias_Click(sender As Object, e As EventArgs) Handles ButtonCargarNoticias.Click
        ' Llamar a la función para cargar noticias
        Await CargarNoticiasAsync()
    End Sub

    Private Async Function CargarNoticiasAsync() As Task
        ' URL de la API de CryptoCompare News
        Dim apiUrl As String = "https://min-api.cryptocompare.com/data/v2/news/?lang=ES"

        ' Crear un cliente HTTP
        Using httpClient As New HttpClient()
            Try
                ' Realizar la solicitud GET
                Dim response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)

                ' Verificar si la solicitud fue exitosa
                If response.IsSuccessStatusCode Then
                    ' Leer el contenido de la respuesta como cadena JSON
                    Dim jsonString As String = Await response.Content.ReadAsStringAsync()

                    ' Deserializar el JSON a un objeto
                    Dim jsonObject As JObject = JObject.Parse(jsonString)

                    ' Obtener el array de noticias
                    Dim jsonArray As JArray = jsonObject("Data")

                    ' Limpiar el RichTextBox
                    RichTextBoxNoticias.Clear()

                    ' Recorrer las noticias y mostrarlas en el RichTextBox
                    For Each item As JObject In jsonArray
                        RichTextBoxNoticias.AppendText("Título: " & item("title").ToString() & vbCrLf)
                        RichTextBoxNoticias.AppendText("Fuente: " & item("source").ToString() & vbCrLf)
                        RichTextBoxNoticias.AppendText("Descripción: " & item("body").ToString() & vbCrLf)
                        RichTextBoxNoticias.AppendText("Enlace: " & item("url").ToString() & vbCrLf)
                        RichTextBoxNoticias.AppendText(vbCrLf & "----------------------------------------" & vbCrLf & vbCrLf)
                    Next
                Else
                    MessageBox.Show("Error al obtener las noticias: " & response.StatusCode.ToString())
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub NoticiasCripto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class