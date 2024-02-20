namespace Domain.Entities
{
    public class Coupon : EntityBase
    {
        public DateTime ExpireDate { get; set; }
        public required string Title { get; set; }    
        public ICollection<Order>? Orders { get; set; }
    }
}
