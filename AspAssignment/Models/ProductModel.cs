namespace AspAssignment.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string SKU { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Price { get; set; } = null!;
    }
}
