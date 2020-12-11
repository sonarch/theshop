using SHOP.Infrastructure.AuthEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Infrastructure.Entities
{
    public class Customer
    {
        [Key]
        [ForeignKey("Id")]
        public User User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
