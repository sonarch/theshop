using SHOP.Infrastructure.Enums;
using System;

namespace SHOP.Infrastructure.Entities
{
    public class Order : GuidEntity
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string EmployeeId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipAddress { get; set; }
        public string ShipperId { get; set; }
    }
}
