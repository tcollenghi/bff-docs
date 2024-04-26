using GestaoDocumentalBff.Domain.Entidades;
using MediatR;

namespace GestaoDocumentalBff.Application
{
    public class HeadQueryRequest : IRequest
    {
        public RequestMeta Meta { get; set; }
        public string Endpoint { get; set; }
    }
}