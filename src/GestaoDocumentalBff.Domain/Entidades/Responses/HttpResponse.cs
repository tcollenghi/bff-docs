using System.Text.Json.Serialization;

namespace GestaoDocumentalBff.Domain.Entidades.Responses
{
    public class HttpResponse<T>
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}