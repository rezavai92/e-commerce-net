using System.Reflection.Metadata.Ecma335;

namespace Domain.Entities
{
    public class Location : EntityBase
    {
        public required string StreetName { get; set; }
        public required string StreetNumber { get; set; }
        public required string City { get; set; }
        public string? State { get; set; }
        public required string PostalCode { get; set; }
        public required string Country { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public ICollection<Customer>? BillingCustomers { get; set; }

        public ShippingInfo? ShippingInfo { get; set; }
    }
}
