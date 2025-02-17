namespace BlazorSportStoreAuth.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        public string Category { get; set; } = null!;
        public string image { get; set; } = null!;
        public bool isAvailable { get; set; } = true;
    }
}
