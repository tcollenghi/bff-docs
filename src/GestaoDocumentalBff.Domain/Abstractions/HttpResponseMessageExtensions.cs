using GestaoDocumentalBff.Domain.Abstractions.Exceptions;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    internal static class HttpResponseMessageExtensions
    {
        internal static async Task<HttpResponseMessage> EnsureFailOnKnowStatusCodeAsync(this HttpResponseMessage source)
        {
            if (source.StatusCode == HttpStatusCode.BadRequest)
                throw new BadRequestException(await source.Content.ReadAsStringAsync());

            if (source.StatusCode == HttpStatusCode.MethodNotAllowed)
                throw new MethodNotAllowedException();

            if (source.StatusCode == HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException();

            if (source.StatusCode == HttpStatusCode.Forbidden)
                throw new ForbiddenException();

            if (source.StatusCode == HttpStatusCode.InternalServerError)
                throw new InternalServerErrorException(await source.Content.ReadAsStringAsync());

            return source;
        }

        internal static async Task<TContentResult> DeserializeContentAsync<TContentResult>(this HttpResponseMessage source, CancellationToken cancellationToken)
        {
            if (source.StatusCode == HttpStatusCode.NoContent || source.Content.Headers.ContentLength == 0)
                return default;

            return await source.Content.ReadFromJsonAsync<TContentResult>(
                new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                },
                cancellationToken);
        }

        internal static IAsyncEnumerable<TContentResult> StreamDeserializeContentAsync<TContentResult>(
            this HttpResponseMessage source,
            CancellationToken cancellationToken
        )
        {
            if (source.StatusCode == HttpStatusCode.NoContent)
                return default;

            return source
                .Content
                .StreamDeserializeAsync<TContentResult>(cancellationToken);
        }
    }
}
