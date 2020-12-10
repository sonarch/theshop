using SHOP.Infrastructure.Enums;

namespace SHOP.Infrastructure.Entities
{
    public class Shipper : GuidEntity
    {
        public string ShipperId { get; set; }
        public string ShipperName { get; set; }
        public string ShipperPhone { get; set; }
        public Company Company { get; set; }
    }
}
