using Microsoft.AspNet.Identity.EntityFramework;

namespace MC.WebApiServices.Infrastructure.Data
{
    public class AuthDbContext : IdentityDbContext<IdentityUser>
    {
        public AuthDbContext()
            : base("AuthDbContext")
        {

        }
    }
}