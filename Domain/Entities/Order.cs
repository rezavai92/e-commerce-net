namespace Domain.Entities
{
    public class Order : EntityBase
    {

        public DateTime OrderedOn { get; set; }
        public DateTime DeliveredOn { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }

        #region Coupon
        public Coupon Coupon { get; set; }
        public string CouponItemId { get; set; }
        #endregion

        #region Customer
        public Customer Customer { get; set; }
        public string CustomerItemId { get; set; }
        #endregion Customer

        #region Product
        public ICollection<Product> Product { get; set; }

        #endregion

        #region Shipping Info
        public ShippingInfo ShippingInfo { get; set; } = new ShippingInfo();
        public string ShippingInfoId { get; set; } = string.Empty;
        #endregion

        #region Payment Info

        public  PaymentInfo PaymentInfo { get; set; }

        #endregion
        //public User ApprovedByUser { get; set; }
        #region Invoice

        public Invoice Invoice { get; set; }

        #endregion
    }
}
