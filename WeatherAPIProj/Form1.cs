using Newtonsoft.Json;
using System.Net;

namespace WeatherAPIProj
{
    public partial class Form1 : Form
    {
        private const string _openWeatherApiKey = "8cb819ad90c6174a17ed320d707d3dcf";
        private readonly HttpClient _httpClient = new();


        public Form1() => InitializeComponent();

        private async void GetWeatherButton_Click(object sender, EventArgs e)
        {
            string city = weatherInputField.Text;
            if (!CheckEmptyCityName(city))
            {
                MessageBox.Show("Введите город");
                return;
            }

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_openWeatherApiKey}&units=metric&lang=ru";
            string json = await SendHttpRequest(url);

            if (json != null)
                weatherLabel.Text = ParseJson(json);
        }

        private async Task<string> SendHttpRequest(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();

            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                MessageBox.Show("Город не найден. Проверьте название и попробуйте снова.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            return null;
        }

        private bool CheckEmptyCityName(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return false;

            return true;
        }
        private string ParseJson(string json)
        {
            dynamic weatherData = JsonConvert.DeserializeObject(json);

            string city = weatherData.name;
            string weatherDesc = weatherData.weather[0].description;
            double temp = weatherData.main.temp;

            return ($"Погода в городе {city}: {weatherDesc}, Температура: {temp}°C");
        }
    }
}
