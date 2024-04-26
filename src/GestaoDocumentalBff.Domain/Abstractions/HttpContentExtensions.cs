using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;

namespace System.Net.Http
{
    internal static class HttpContentExtensions
    {
        public static async IAsyncEnumerable<TContentResult> StreamDeserializeAsync<TContentResult>(this HttpContent source, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            await foreach (var item in JsonSerializer.DeserializeAsyncEnumerable<TContentResult>(await source.ReadAsStreamAsync(), new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }, cancellationToken))
                yield return item;
        }
    }
}