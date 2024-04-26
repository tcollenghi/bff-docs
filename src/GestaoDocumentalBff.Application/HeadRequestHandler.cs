using GestaoDocumentalBff.Domain.Util;
using MediatR;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GestaoDocumentalBff.Application
{
    internal sealed class HeadRequestHandler : IRequestHandler<HeadQueryRequest>
    {
        Config Config { get; }
        IHttpClientFactory HttpClientFactory { get; }

        public HeadRequestHandler(
            IOptions<Config> GestaoDocumentalBffConfig,
            IHttpClientFactory httpClientFactory
        )
        {
            HttpClientFactory = httpClientFactory;
            Config = GestaoDocumentalBffConfig.Value;
        }

        public async Task Handle(HeadQueryRequest request, CancellationToken cancellationToken)
        {
            await HttpClientFactory
               .CreateClient()
               .SendHeadEnsureStatusCode(
                   request.Meta.Authentication,
                   request.Meta.LoginProxy.ToString(),
                   request.Meta.EventTraceId,
                   request.Meta.CorrelationId,
                   request.Meta.IdempotencyId,
                   request.Endpoint,
                   cancellationToken
               );
        }
    }
}