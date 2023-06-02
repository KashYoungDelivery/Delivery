namespace Delivery.Backend.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set;}
        public string? ProductCategory { get; set;}
        public decimal ProductPrice { get; set; }
    }
}
