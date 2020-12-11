using Microsoft.Extensions.DependencyInjection;

namespace SHOP.API.Configuration
{
    public static class ServicesDependency
    {
        public static void AddServicesDependency(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromCallingAssembly()
                .AddClasses()
                .AsSelf()
                .WithTransientLifetime()
            );
            //services.AddTransient<ITransientService, TransientService>(); // From previous registrations
        }
    }
}
