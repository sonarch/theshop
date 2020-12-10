namespace SHOP.Infrastructure.Entities
{
    public class Product : GuidEntity
    {
        public string ProductId { get; set; }
        public string SupplierId { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
    }
}
