namespace SHOP.Infrastructure.Entities
{
    public class OrderDetail
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
    }
}
