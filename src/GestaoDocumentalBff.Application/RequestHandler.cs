using GestaoDocumentalBff.Domain.Util;
using MediatR;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GestaoDocumentalBff.Application
{
    internal sealed class RequestHandler : IRequestHandler<QueryRequest, object>
    {
        IHttpClientFactory HttpClientFactory { get; }

        public RequestHandler(
            IHttpClientFactory httpClientFactory
        )
        {
            HttpClientFactory = httpClientFactory;
        }

        public async Task<object> Handle(QueryRequest request, CancellationToken cancellationToken) =>
             await HttpClientFactory
                .CreateClient()
                .SendGetEnsureStatusCodeAndDeserializeAsync<object>(
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