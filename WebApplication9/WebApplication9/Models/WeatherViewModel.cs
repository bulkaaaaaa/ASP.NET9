namespace WebApplication9.Models
{
    public class WeatherViewModel
    {
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public double Temperature { get; set; } = double.MinValue;
        public string Description { get; set; } = string.Empty;
        public int Sunrise { get; set; } = int.MinValue;
        public int Sunset { get; set; } = int.MinValue;
        public int Humidity { get; set; } = int.MinValue;
        public double WindSpeed { get; set; } = double.MinValue;
        public double Pressure { get; set; } = double.MinValue;
        public Coord Coordinates { get; set; } 
    }
}
