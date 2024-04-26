using GestaoDocumentalBff.Domain.Entidades;
using MediatR;

namespace GestaoDocumentalBff.Application
{
    public class QueryStreamRequest : IStreamRequest<object>
    {
        public RequestMeta Meta { get; set; }
        public string Endpoint { get; set; }
    }
}