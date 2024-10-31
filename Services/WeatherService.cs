
using Newtonsoft.Json;
using WeatherNow.Models;

namespace WeatherNow.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public WeatherService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {
            var apiKey = _configuration["WeatherApi:ApiKey"];
            var baseUrl = _configuration["WeatherApi:BaseUrl"];
            var url = $"{baseUrl}?q={city}&appid={apiKey}&units=metric";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(content);
                if (weatherResponse == null)
                {
                    throw new Exception("Failed to deserialize weather data.");
                }
                return weatherResponse;
            }

            return null;
        }
    }
}
