using Newtonsoft.Json;

namespace WeatherAPIProj
{
    public partial class Form1 : Form
    {
        private const string OpenWeatherApiKey = "8cb819ad90c6174a17ed320d707d3dcf"; // Получите на openweathermap.org
        private readonly HttpClient _httpClient = new();

        public Form1()
        {
            InitializeComponent();
        }

        private async void GetWeatherButton_Click(object sender, EventArgs e)
        {
            try
            {
                string city = weatherInputField.Text;
                if (string.IsNullOrWhiteSpace(city))
                {
                    MessageBox.Show("Введите город");
                    return;
                }

                // Запрос погоды по названию города
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={OpenWeatherApiKey}&units=metric&lang=ru";
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();

                dynamic weatherData = JsonConvert.DeserializeObject(json);
                string weatherDesc = weatherData.weather[0].description;
                double temp = weatherData.main.temp;


                weatherLabel.Text = ($"Погода в {city}: {weatherDesc}, Температура: {temp}°C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
