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
    [Route("aprovacao/excecao")]
    public class AprovacaoExcecaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public AprovacaoExcecaoController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/aprovacao/excecao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultarListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/aprovacao/excecao/consulta-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpPost("alterar")]
        public async Task<ActionResult> SolicitacaoIndividualAlterar(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/aprovacao/excecao/alterar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpGet("arquivo-obter")]
        public async Task<object> ArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/aprovacao/excecao/arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("autorizacao-carregar")]
        public async Task<object> AutorizacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/aprovacao/excecao/autorizacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("tipo-solicitacao-carregar")]
        public async Task<object> TipoSolicitacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/aprovacao/excecao/tipo-solicitacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("tipo-documento-carregar")]
        public async Task<object> TipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/aprovacao/excecao/tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("centro-custo-carregar")]
        public async Task<object> CentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/aprovacao/excecao/centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-obter")]
        public async Task<object> DetalheObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/aprovacao/excecao/detalhe-obter{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}