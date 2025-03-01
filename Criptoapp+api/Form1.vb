Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Async Sub ButtonCargar_Click(sender As Object, e As EventArgs) Handles ButtonCargar.Click
        ' Llamar a la función para cargar datos
        Await CargarDatosCriptomonedasAsync()
    End Sub

    Private Async Function CargarDatosCriptomonedasAsync() As Task
        ' URL de la API de CoinMarketCap
        Dim apiUrl As String = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest"

        ' Crear un cliente HTTP
        Using httpClient As New HttpClient()
            ' Agregar la API Key como encabezado
            httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", " 1622e0e0-d4d7-4170-976b-cd50aad74d6d ")

            Try
                ' Realizar la solicitud GET
                Dim response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)

                ' Verificar si la solicitud fue exitosa
                If response.IsSuccessStatusCode Then
                    ' Leer el contenido de la respuesta como cadena JSON
                    Dim jsonString As String = Await response.Content.ReadAsStringAsync()

                    ' Deserializar el JSON a un objeto
                    Dim jsonObject As JObject = JObject.Parse(jsonString)

                    ' Obtener el array de datos
                    Dim jsonArray As JArray = jsonObject("data")

                    ' Crear una tabla para almacenar los datos
                    Dim dataTable As New DataTable()

                    ' Agregar columnas al DataTable
                    dataTable.Columns.Add("Nombre", GetType(String))
                    dataTable.Columns.Add("Símbolo", GetType(String))
                    dataTable.Columns.Add("Precio (USD)", GetType(Decimal))
                    dataTable.Columns.Add("Cambio 24h (%)", GetType(Decimal))
                    dataTable.Columns.Add("Capitalización de Mercado", GetType(Decimal))

                    ' Recorrer el JSON y agregar filas al DataTable
                    For Each item As JObject In jsonArray
                        dataTable.Rows.Add(
                            item("name").ToString(), ' Nombre de la criptomoneda
                            item("symbol").ToString(), ' Símbolo de la criptomoneda
                            item("quote")("USD")("price").ToObject(Of Decimal)(), ' Precio actual en USD
                            item("quote")("USD")("percent_change_24h").ToObject(Of Decimal)(), ' Cambio porcentual en 24h
                            item("quote")("USD")("market_cap").ToObject(Of Decimal)() ' Capitalización de mercado
                        )
                    Next

                    ' Asignar el DataTable al DataGridView
                    DataGridView1.DataSource = dataTable
                Else
                    ' Mostrar detalles del error
                    Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show("Error al obtener los datos: " & response.StatusCode.ToString() & vbCrLf & errorContent)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class