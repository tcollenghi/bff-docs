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
    [Route("empresa")]
    public class EmpresaController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public EmpresaController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/empresa/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/empresa/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-obter")]
        public async Task<object> ContratoDetalheObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/empresa/detalhe-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("situacao-carregar")]
        public async Task<object> SituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/empresa/situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-situacao-carregar")]
        public async Task<object> InclusaoSituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/empresa/inclusao-situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("inclusao-salvar")]
        public async Task<object> InclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/empresa/inclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("detalhe-situacao-carregar")]
        public async Task<object> DetalheSituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/empresa/detalhe-situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("alteracao-salvar")]
        public async Task<object> AlteracaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/empresa/alteracao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}