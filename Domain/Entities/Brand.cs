using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Brand : EntityBase
    {
        public required string Name { get; set; }
        public required string Country { get; set; }
        [JsonIgnore]
        public ICollection<Product>? Products { get; set; } = new List<Product>();
        
    }
}
