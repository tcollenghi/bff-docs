using GestaoDocumentalBff.Domain.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Options;

namespace GestaoDocumentalBff.Api.Controllers
{
    [ApiController]
    [Route("documento-solicitacao")]
    public class DocumentoSolicitacaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoSolicitacaoController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento-solicitacao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-centro-custo-carregar")]
        public async Task<object> FiltroCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento-solicitacao/filtro-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-tipo-documento-carregar")]
        public async Task<object> FiltroTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento-solicitacao/filtro-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-subtipo-documento-carregar")]
        public async Task<object> FiltroSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento-solicitacao/filtro-subtipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento-solicitacao/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("inclusao-salvar")]
        public async Task<object> InclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento-solicitacao/inclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("solicitacao-tipo-carregar")]
        public async Task<object> SolicitacaoTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento-solicitacao/solicitacao-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

    }
}