using System.Collections.Generic;

namespace SHOP.Infrastructure.Entities
{
    public class Customer : User
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
