using GestaoDocumentalBff.Domain.Entidades;
using MediatR;
using System.IO;

namespace GestaoDocumentalBff.Application
{
    public class PostCommandRequest : IRequest<object>
    {
        public RequestMeta Meta { get; set; }
        public string Endpoint { get; set; }
        public Stream Stream { get; set; }
    }
}