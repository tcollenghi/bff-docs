using MediatR;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GestaoDocumentalBff.Application
{
    internal sealed class PostRequestHandler : IRequestHandler<PostCommandRequest, object>
    {

        IHttpClientFactory HttpClientFactory { get; }

        public PostRequestHandler(
            IHttpClientFactory httpClientFactory
        )
        {
            HttpClientFactory = httpClientFactory;
        }

        public async Task<object> Handle(PostCommandRequest request, CancellationToken cancellationToken) =>
            await HttpClientFactory
                .CreateClient()
                .SendPostEnsureStatusCodeAndDeserializeAsync<object>(
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