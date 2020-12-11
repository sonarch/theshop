using Microsoft.AspNetCore.Identity;

namespace SHOP.Infrastructure.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Username { get; set; }
    }
}
