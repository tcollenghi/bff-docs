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
    [Route("documento/admitido-demitido-formalizacao/check-list")]
    public class DocumentoAdmitidoDemitidoFormalizacaoCheckListController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoAdmitidoDemitidoFormalizacaoCheckListController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("tipo-documento-carregar")]
        public async Task<object> OpcaoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/tipo-documento-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("empresa-carregar")]
        public async Task<object> EmpresaCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/empresa-carregar{Request.QueryString}"
        },
        cancellationToken);


        [HttpGet("tipo-opcao-carregar")]
        public async Task<object> TipoOpcaoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/tipo-opcao-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("status-carregar")]
        public async Task<object> StatusCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/status-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultarListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/consulta-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("check-list-listar")]
        public async Task<object> CheckListlistar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/check-list-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("arquivo-obter")]
        public async Task<object> ArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("gravar")]
        public async Task<object> Gravar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/check-list/gravar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}