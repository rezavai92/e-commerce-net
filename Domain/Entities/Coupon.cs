namespace Domain.Entities
{
    public class Coupon : EntityBase
    {
        public DateTime ExpireDate { get; set; }
        public string Title { get; set; }
    }
}
