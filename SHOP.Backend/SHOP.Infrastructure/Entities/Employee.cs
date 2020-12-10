using System.Collections.Generic;

namespace SHOP.Infrastructure.Entities
{
    public class Employee : User
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
