using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication9.Models;
using Newtonsoft.Json;

namespace WebApplication9.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.openweathermap.org");
        }

        public async Task<WeatherViewModel> GetWeatherAsync(string cityName)
        {
            try
            {
                string apiKey = "6b3efb5d97bb06f50c79469aab48bf92";
                string requestUrl = $"/data/2.5/weather?q={cityName}&appid={apiKey}";

                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonString); 

                var weatherData = JsonConvert.DeserializeObject<OpenWeatherMapResponse>(jsonString);

                var weatherViewModel = new WeatherViewModel
                {
                    City = weatherData.Name,
                    Country = weatherData.Sys != null ? weatherData.Sys.Country : null,
                    Temperature = weatherData.Main.Temperature,
                    Description = weatherData.Weather[0].Description,
                    Sunset = weatherData.Sys != null ? weatherData.Sys.Sunset : 0,
                    Sunrise = weatherData.Sys != null ? weatherData.Sys.Sunrise : 0,
                    Humidity = weatherData.Main.Humidity, 
                    WindSpeed = weatherData.Wind.Speed, 
                    
                    Pressure = weatherData.Main.Pressure, 
                    Coordinates = new Coord 
                    {
                        lon = weatherData.Coord.lon,
                        lat = weatherData.Coord.lat
                    }

                };

                return weatherViewModel;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get weather data: " + ex.Message); 
                throw new Exception("Failed to get weather data.", ex);
            }

        }
    }
}
