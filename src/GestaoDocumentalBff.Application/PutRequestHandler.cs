using MediatR;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GestaoDocumentalBff.Application
{
    internal sealed class PutRequestHandler : IRequestHandler<PutCommandRequest, object>
    {
        IHttpClientFactory HttpClientFactory { get; }

        public PutRequestHandler(
            IHttpClientFactory httpClientFactory
        )
        {
            HttpClientFactory = httpClientFactory;
        }

        public async Task<object> Handle(PutCommandRequest request, CancellationToken cancellationToken)
        {
            return await HttpClientFactory
                .CreateClient()
                .SendPutEnsureStatusCodeAndDeserializeAsync<object>(
                request.Meta.Authentication,
                request.Meta.LoginProxy.ToString(),
                request.Meta.EventTraceId,
                request.Meta.CorrelationId,
                request.Meta.IdempotencyId,
                request.Meta.ContentType,
                request.Endpoint,
                request.Stream,
                cancellationToken
            );
        }
    }
}