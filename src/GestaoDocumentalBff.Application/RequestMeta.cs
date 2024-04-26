using Microsoft.Extensions.Primitives;
using System.Net.Http.Headers;

namespace GestaoDocumentalBff.Domain.Entidades
{
    public class RequestMeta
    {
        public StringValues LoginProxy { get; set; }
        public AuthenticationHeaderValue Authentication { get; set; }
        public MediaTypeHeaderValue ContentType { get; set; }
        public StringValues EventTraceId { get; set; }
        public StringValues CorrelationId { get; set; }
        public StringValues IdempotencyId { get; set; }
    }
}