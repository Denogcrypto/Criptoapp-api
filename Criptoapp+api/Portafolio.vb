Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Globalization
Imports System.Configuration
Public Class Portafolio
    Private portafolio As New List(Of Criptomoneda)()

    Private Sub Portafolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar criptomonedas al ComboBox
        ComboBoxCriptomonedas.Items.Add("BTC")
        ComboBoxCriptomonedas.Items.Add("ETH")
        ComboBoxCriptomonedas.Items.Add("BNB")
        ComboBoxCriptomonedas.Items.Add("ADA")
        ComboBoxCriptomonedas.Items.Add("DOGE")
        ComboBoxCriptomonedas.SelectedIndex = 0 ' Seleccionar la primera opción por defecto
    End Sub

    Private Async Function ObtenerPrecioCriptomoneda(criptomoneda As String) As Task(Of Decimal)
        Dim apiUrl As String = $"https://pro-api.coinmarketcap.com/v1/cryptocurrency/quotes/latest?symbol={criptomoneda}&convert=USD"
        Using httpClient As New HttpClient()
            Dim apiKey As String = ConfigurationManager.AppSettings("ApiKey")
            If String.IsNullOrEmpty(apiKey) Then
                MessageBox.Show("No se encontró la API Key en el archivo de configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End If

            httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", apiKey)
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json")
            httpClient.Timeout = TimeSpan.FromSeconds(10) ' Establece un tiempo de espera

            Try
                Dim response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)
                If response.IsSuccessStatusCode Then
                    Dim jsonString As String = Await response.Content.ReadAsStringAsync()
                    ' Comentamos o eliminamos la siguiente línea para evitar el mensaje de depuración
                    ' MessageBox.Show($"Respuesta de la API: {jsonString}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim jsonObject As JObject = JObject.Parse(jsonString)

                    ' Verificar si la criptomoneda existe en la respuesta
                    If jsonObject("data")(criptomoneda) IsNot Nothing Then
                        Dim precioUSD As Decimal = jsonObject("data")(criptomoneda)("quote")("USD")("price").ToObject(Of Decimal)()
                        Return precioUSD
                    Else
                        Throw New Exception($"No se encontraron datos para la criptomoneda: {criptomoneda}")
                    End If
                Else
                    Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show($"Error en la respuesta de la API: {response.StatusCode} - {errorContent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Throw New Exception("Error al obtener el precio: " & response.StatusCode.ToString())
                End If
            Catch ex As Exception
                MessageBox.Show($"Error al obtener el precio de {criptomoneda}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End Try
        End Using
    End Function

    Private Async Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        ' Limpiar el texto ingresado
        Dim cantidadTexto As String = TextBoxCantidad.Text.Trim()

        ' Validar que la cantidad ingresada sea un número válido
        Dim cantidad As Decimal
        If Not Decimal.TryParse(cantidadTexto, NumberStyles.Any, CultureInfo.InvariantCulture, cantidad) Then
            MessageBox.Show("Por favor, ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validar que la cantidad sea positiva
        If cantidad <= 0 Then
            MessageBox.Show("Por favor, ingresa una cantidad mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Obtener la criptomoneda seleccionada
        Dim criptomoneda As String = ComboBoxCriptomonedas.SelectedItem.ToString()

        ' Obtener el precio actual de la criptomoneda
        Dim precioUSD As Decimal = Await ObtenerPrecioCriptomoneda(criptomoneda)

        ' Calcular el valor total
        Dim valorTotal As Decimal = cantidad * precioUSD

        ' Agregar la criptomoneda al portafolio
        portafolio.Add(New Criptomoneda With {
            .Nombre = criptomoneda,
            .Cantidad = cantidad,
            .PrecioUSD = precioUSD,
            .ValorTotal = valorTotal
        })

        ' Actualizar el DataGridView
        ActualizarDataGridView()

        ' Calcular y mostrar el valor total del portafolio
        CalcularValorTotalPortafolio()
    End Sub

    Private Sub ActualizarDataGridView()
        DataGridViewPortafolio.DataSource = Nothing
        DataGridViewPortafolio.DataSource = portafolio
        DataGridViewPortafolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CalcularValorTotalPortafolio()
        Dim valorTotalPortafolio As Decimal = portafolio.Sum(Function(c) c.ValorTotal)
        LabelValorTotal.Text = $"Valor total del portafolio: {valorTotalPortafolio:C2}"
    End Sub
End Class