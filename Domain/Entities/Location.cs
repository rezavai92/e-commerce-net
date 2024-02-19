using System.Reflection.Metadata.Ecma335;

namespace Domain.Entities
{
    public class Location : EntityBase
    {
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public ICollection<Customer>? BillingCustomers { get; set; }

        public ShippingInfo? ShippingInfo { get; set; }
    }
}
