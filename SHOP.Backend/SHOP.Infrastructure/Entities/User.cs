using System.Security.Principal;

namespace SHOP.Infrastructure.Entities
{
    public class User : GuidEntity, IIdentity
    {
        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string Name { get; set; }
    }
}
