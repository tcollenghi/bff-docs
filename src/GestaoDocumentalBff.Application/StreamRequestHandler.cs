using MediatR;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace GestaoDocumentalBff.Application
{
    internal sealed class StreamRequestHandler : IStreamRequestHandler<QueryStreamRequest, object>
    {
        IHttpClientFactory HttpClientFactory { get; }
        public StreamRequestHandler(
            IHttpClientFactory httpClientFactory
        )
        {
            HttpClientFactory = httpClientFactory;
        }

        public IAsyncEnumerable<object> Handle(QueryStreamRequest request, CancellationToken cancellationToken)
        {
            return HttpClientFactory
                .CreateClient()
                .StreamGetEnsureStatusCodeAndDeserializeAsync<object>(
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