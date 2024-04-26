using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public static class HttpClientExtensions
    {
        public static async Task<T> SendGetEnsureStatusCodeAndDeserializeAsync<T>(
            this HttpClient source,
            AuthenticationHeaderValue authentication,
            string loginProxy,
            string eventTraceId,
            string correlationId,
            string idempotencyId,
            string url,
            CancellationToken cancellationToken
        )
        {
            return await (
                await source
                    .SendGetEnsureStatusCode(authentication, loginProxy, eventTraceId, correlationId, idempotencyId, url, cancellationToken)
            )
            .EnsureSuccessStatusCode()
            .DeserializeContentAsync<T>(cancellationToken);
        }

        public static async IAsyncEnumerable<T> StreamGetEnsureStatusCodeAndDeserializeAsync<T>(
            this HttpClient source,
            AuthenticationHeaderValue authentication,
            string loginProxy,
            string eventTraceId,
            string correlationId,
            string idempotencyId,
            string url,
            [EnumeratorCancellation] CancellationToken cancellationToken
        )
        {
            var items = (
                await source
                    .SendGetEnsureStatusCode(authentication, loginProxy, eventTraceId, correlationId, idempotencyId, url, cancellationToken)
            )
            .EnsureSuccessStatusCode()
            .StreamDeserializeContentAsync<T>(cancellationToken);

            await foreach (var item in items)
                yield return item;
        }

        private static async Task<HttpResponseMessage> SendGetEnsureStatusCode(
            this HttpClient source,
            AuthenticationHeaderValue authentication,
            string loginProxy,
            string eventTraceId,
            string correlationId,
            string idempotencyId,
            string url,
            CancellationToken cancellationToken
        )
        {
            return (
                await (
                    await source
                        .HeadersDecorate(authentication, loginProxy, eventTraceId, correlationId, idempotencyId)
                        .SendAsync(
                            new HttpRequestMessage(
                                HttpMethod.Get,
                                url
                            ),
                            HttpCompletionOption.ResponseHeadersRead,
                            cancellationToken
                        )
                )
                .EnsureFailOnKnowStatusCodeAsync()
            )
            .EnsureSuccessStatusCode();
        }

        private static async Task<TContentResult> SendPostEnsureStatusCodeAndDeserializeAsync<TContentResult>(
            this HttpClient source,
            string url,
            Stream stream,
            MediaTypeHeaderValue contentType,
            CancellationToken cancelationToken
        )
        {
            return await (
                await source.SendPostEnsureStatusCode(url, stream, contentType, cancelationToken)
            )
            .DeserializeContentAsync<TContentResult>(cancelationToken);
        }

        private static async Task<HttpResponseMessage> SendPostEnsureStatusCode(
                this HttpClient source,
                string url,
                Stream stream,
                MediaTypeHeaderValue contentType,
                CancellationToken cancelationToken
            )
        {
            var content = new StreamContent(stream);

            content.Headers.ContentType = contentType;
            return (
                await (
                    await source
                        .SendAsync(
                            new HttpRequestMessage(
                                HttpMethod.Post,
                                url
                            )
                            {
                                Content = content,
                            },
                            HttpCompletionOption.ResponseHeadersRead,
                            cancelationToken
                        )
                )
                .EnsureFailOnKnowStatusCodeAsync()
            )
            .EnsureSuccessStatusCode();
        }
        private static HttpClient HeadersDecorate(
            this HttpClient source,
            AuthenticationHeaderValue authentication,
            string loginProxy,
            string eventTraceId,
            string correlationId,
            string idempotencyId
        )
        {
            source.DefaultRequestHeaders.Authorization = authentication;

            if (!string.IsNullOrWhiteSpace(loginProxy))
                source.DefaultRequestHeaders.Add("login-proxy", loginProxy);

            if (!string.IsNullOrWhiteSpace(eventTraceId))
                source.DefaultRequestHeaders.Add("event-trace-id", eventTraceId);
         
            if (!string.IsNullOrWhiteSpace(correlationId))
                source.DefaultRequestHeaders.Add("x-correlation-id", correlationId);
         
            if (!string.IsNullOrWhiteSpace(eventTraceId))
                source.DefaultRequestHeaders.Add("x-idempotency-id", idempotencyId);

            return source;
        }

        public static async Task<TContentResult> SendPostEnsureStatusCodeAndDeserializeAsync<TContentResult>(
            this HttpClient source,
            AuthenticationHeaderValue authentication,
            string loginProxy,
            string eventTraceId,
            string correlationId,
            string idempotencyId,
            MediaTypeHeaderValue contentType,
            string url,
            Stream stream,
            CancellationToken cancelationToken
        )
        {
            return await source
                .HeadersDecorate(authentication, loginProxy, eventTraceId, correlationId, idempotencyId)
                .SendPostEnsureStatusCodeAndDeserializeAsync<TContentResult>(
                    url,
                    stream,
                    contentType,
                    cancelationToken
                );
        }
        public static async Task<HttpResponseMessage> SendPostEnsureStatusCode(
           this HttpClient source,
           AuthenticationHeaderValue authentication,
           string loginProxy,
           string eventTraceId,
           string correlationId,
           string idempotencyId,
           MediaTypeHeaderValue contentType,
           string url,
           Stream stream,
           CancellationToken cancelationToken
       )
        {
            return await source
                .HeadersDecorate(authentication, loginProxy, eventTraceId, correlationId, idempotencyId)
                .SendPostEnsureStatusCode(
                    url,
                    stream,
                    contentType,
                    cancelationToken
                );
        }

        private static async Task<HttpResponseMessage> SendPutEnsureStatusCode(
            this HttpClient source,
            string url,
            Stream stream,
            MediaTypeHeaderValue contentType,
            CancellationToken cancelationToken
        )
        {
            var content = new StreamContent(stream);
            content.Headers.ContentType = contentType;
            return (
                await (
                    await source
                        .SendAsync(
                            new HttpRequestMessage(
                                HttpMethod.Put,
                                url
                            )
                            {
                                Content = content,
                            },
                            HttpCompletionOption.ResponseHeadersRead,
                            cancelationToken
                        )
                )
                .EnsureFailOnKnowStatusCodeAsync()
            )
            .EnsureSuccessStatusCode();
        }
        public static async Task<TContentResult> SendPutEnsureStatusCodeAndDeserializeAsync<TContentResult>(
            this HttpClient source,
            AuthenticationHeaderValue authentication,
            string loginProxy,
            string eventTraceId,
            string correlationId,
           string idempotencyId,
            MediaTypeHeaderValue contentType,
            string url,
            Stream stream,
            CancellationToken cancelationToken
        )
        {
            return await (
                await source
                    .HeadersDecorate(authentication, loginProxy, eventTraceId, correlationId, idempotencyId)
                    .SendPutEnsureStatusCode(
                        url,
                        stream,
                        contentType,
                        cancelationToken
                    )
            )
            .DeserializeContentAsync<TContentResult>(cancelationToken);
        }

        public static async Task<HttpResponseMessage> SendHeadEnsureStatusCode(
                this HttpClient source,
                AuthenticationHeaderValue authentication,
                string loginProxy,
                string eventTraceId,
                string correlationId,
                string idempotencyId,
                string url,
                CancellationToken cancelationToken
            )
        {
            return (
                await (
                    await source
                    .HeadersDecorate(authentication, loginProxy, eventTraceId, correlationId, idempotencyId)
                        .SendAsync(
                            new HttpRequestMessage(
                                HttpMethod.Head,
                                url
                            ),
                            HttpCompletionOption.ResponseHeadersRead,
                            cancelationToken
                        )
                )
                .EnsureFailOnKnowStatusCodeAsync()
            )
            .EnsureSuccessStatusCode();
        }
    }
}