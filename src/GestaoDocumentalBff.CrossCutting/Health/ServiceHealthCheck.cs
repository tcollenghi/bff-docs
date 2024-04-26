using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace GestaoDocumentalBff.CrossCutting.Health
{
    public class ServiceHealthCheck : IHealthCheck
    {

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            var HealthCheckResultHealthy = true;

            if (HealthCheckResultHealthy)
            {
                return Task.FromResult(HealthCheckResult.Healthy("UP"));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("DOWN"));
        }
    }
}