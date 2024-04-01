using Newtonsoft.Json;

namespace WebApplication9.Models
{
    public class OpenWeatherMapResponse
    {
        public string Name { get; set; } = string.Empty;
        public MainData Main { get; set; }
        public Weather[] Weather { get; set; }
        public Sys Sys { get; set; }
        public Wind Wind { get; set; } 
        public Coord Coord { get; set; }
    }
}
