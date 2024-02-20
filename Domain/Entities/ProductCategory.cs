namespace Domain.Entities
{
    public class ProductCategory : EntityBase
    {
        public required string Title { get; set; } 
        public string? Alias { get; set; } 
        public ICollection<Product>? Products { get; set; }
    }
}
