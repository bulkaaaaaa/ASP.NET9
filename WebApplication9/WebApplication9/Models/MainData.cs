using Newtonsoft.Json;

namespace WebApplication9.Models
{
    public class MainData
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; } = double.MaxValue;
        public int Humidity { get; set; } = int.MaxValue;
        public double Pressure { get; set; } = double.MaxValue;
    }
}
