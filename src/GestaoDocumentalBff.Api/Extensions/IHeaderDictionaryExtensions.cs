using GestaoDocumentalBff.Domain.Entidades;
using Microsoft.Extensions.Primitives;
using System.Net.Http.Headers;

namespace Microsoft.AspNetCore.Http
{
    public static class IHeaderDictionaryExtensions
    {
        public static AuthenticationHeaderValue Authentication(this IHeaderDictionary source)
        {
            var target = source["Authorization"];
            if (target == StringValues.Empty)
                return default;

            return AuthenticationHeaderValue.Parse(target);
        }
        public static StringValues LoginProxy(this IHeaderDictionary source) =>
            source["login-proxy"];
        public static MediaTypeHeaderValue ContentType(this IHeaderDictionary source)
        {
            var target = source["Content-Type"];
            if (target == StringValues.Empty)
                return default;

            return new MediaTypeHeaderValue(target);
        }
        public static StringValues EventTraceId(this IHeaderDictionary source) =>
            source["event-trace-id"];
        public static StringValues CorrelationId(this IHeaderDictionary source) =>
            source["x-correlation-id"];
        public static StringValues IdempotencyId(this IHeaderDictionary source) =>
            source["x-idempotency-id"];
        public static RequestMeta ToRequestMeta(this IHeaderDictionary source) =>
            new RequestMeta
            {
                Authentication = source.Authentication(),
                LoginProxy = source.LoginProxy(),
                ContentType = source.ContentType(),
                EventTraceId = source.EventTraceId(),
            };
    }
}