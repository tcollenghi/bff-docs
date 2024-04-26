using GestaoDocumentalBff.Domain.Util;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading;
using System.Threading.Tasks;

namespace GestaoDocumentalBff.Api.Controllers
{
    [ApiController]
    [Route("administracao/permissao-consulta")]
    public class AdministracaoPermissaoConsultaController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public AdministracaoPermissaoConsultaController(IMediator mediator, IOptions<Config> optionsConfig)
        {
            Mediator = mediator;
            Config = optionsConfig.Value;
        }

        [HttpGet("funcionalidade-validar")]
        public async Task<object> FuncionalidadeValidar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/permissao-consulta/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("usuario-carregar")]
        public async Task<object> UsuarioCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/permissao-consulta/usuario-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("departamento-carregar")]
        public async Task<object> DepartamentoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/permissao-consulta/departamento-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultarListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/permissao-consulta/consulta-listar{Request.QueryString}"
        },
        cancellationToken);


        [HttpGet("arquivo-obter")]
        public async Task<object> ArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/permissao-consulta/arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}