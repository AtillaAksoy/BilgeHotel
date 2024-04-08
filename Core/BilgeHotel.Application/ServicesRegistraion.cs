using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BilgeHotel.Application
{
    public static class ServicesRegistraion
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            var serviceProvider = serviceCollection.BuildServiceProvider();

            serviceCollection.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });
        }
    }
}
