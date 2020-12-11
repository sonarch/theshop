using Core.Entities;
using System.Security.Principal;

namespace SHOP.Infrastructure.AuthEntities
{
    public class User : GuidEntity, IIdentity
    {
        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string Name { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
