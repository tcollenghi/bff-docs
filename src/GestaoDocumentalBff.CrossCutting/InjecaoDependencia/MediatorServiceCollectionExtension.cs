using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GestaoDocumentalBff.CrossCutting.InjecaoDependencia
{
    public static class MediatorServiceCollectionExtension
    {
        public static IServiceCollection AddMediator(this IServiceCollection services, params Assembly[] assemblies) =>
            services
                .AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(assemblies));
    }
}