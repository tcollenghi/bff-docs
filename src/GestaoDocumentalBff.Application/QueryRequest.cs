using GestaoDocumentalBff.Domain.Entidades;
using MediatR;

namespace GestaoDocumentalBff.Application
{
    public class QueryRequest : IRequest<object>
    {
        public RequestMeta Meta { get; set; }
        public string Endpoint { get; set; }
    }
}