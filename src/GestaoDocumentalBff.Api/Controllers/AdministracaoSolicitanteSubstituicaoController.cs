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
    [Route("administracao/solicitante-substituicao")]
    public class AdministracaoSolicitanteSubstituicaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public AdministracaoSolicitanteSubstituicaoController(IMediator mediator, IOptions<Config> optionsConfig)
        {
            Mediator = mediator;
            Config = optionsConfig.Value;
        }

        [HttpGet("funcionalidade-validar")]
        public async Task<ActionResult> FuncionalidadeValidar(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/solicitante-substituicao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken));
        }

        [HttpGet("usuario-carregar")]
        public async Task<object> UsuarioCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/solicitante-substituicao/usuario-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("departamento-carregar")]
        public async Task<object> DepartamentoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/solicitante-substituicao/departamento-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultarListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/solicitante-substituicao/consulta-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpPost("solicitacao-individual-alterar")]
        public async Task<ActionResult> SolicitacaoIndividualAlterar(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/solicitante-substituicao/solicitacao-individual-alterar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpPost("solicitacao-lote-alterar")]
        public async Task<ActionResult> SolicitacaoLoteAlterar(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/solicitante-substituicao/solicitacao-lote-alterar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpGet("solicitacao-individual-detalhe-obter")]
        public async Task<object> SolicitacaoIndividualDetalheObter(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/solicitante-substituicao/solicitacao-individual-detalhe-obter{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-lote-listar")]
        public async Task<object> ConsultarLoteListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/solicitante-substituicao/consulta-lote-listar{Request.QueryString}"
        },
        cancellationToken);


    }
}