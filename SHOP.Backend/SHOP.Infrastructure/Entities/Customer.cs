using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Infrastructure.Entities
{
    public class Customer : User
    {
        public string CustomerId { get; set; }
    }
}
