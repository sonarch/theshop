using Core.Entities;
using System.Security.Principal;

namespace Authentication.Entities
{
    public class User : GuidEntity, IIdentity
    {
        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string Name { get; set; }
    }
}
