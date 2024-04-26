using GestaoDocumentalBff.CrossCutting.Health;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDocumentalBff.CrossCutting.InjecaoDependencia
{
    public static class HealthCheckCollectionExtension
    {
        public static IServiceCollection AddHealthChecksInjection(this IServiceCollection services)
        {
            services.AddHealthChecks()
                .AddCheck<ServiceHealthCheck>("status")
                ;
            return services;
        }
    }
}
