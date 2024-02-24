using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class ProductCategory : EntityBase
    {
        public required string Title { get; set; } 
        public string? Alias { get; set; }
        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}
