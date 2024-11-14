namespace MarabitoLab6.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public bool? InStock { get; set; }

        public Product() { }
        public Product(int Id,string Name,decimal Price, bool InStock)
        {
            this.Id=Id;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
    }
    }
}
