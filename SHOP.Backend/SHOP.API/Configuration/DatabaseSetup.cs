using Microsoft.Extensions.DependencyInjection;
using SHOP.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace SHOP.API.Configuration
{
    public static class DatabaseSetup
    {
        public static void AddAppDatabase(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
    }
}
