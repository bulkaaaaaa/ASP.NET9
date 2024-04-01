namespace WebApplication9.Models
{
    public class Product
    {
        public int ID { get; set; } = int.MaxValue;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.MaxValue;
    }
}