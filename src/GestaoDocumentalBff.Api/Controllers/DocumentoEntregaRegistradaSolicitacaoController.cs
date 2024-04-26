using GestaoDocumentalBff.Domain.Util;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GestaoDocumentalBff.Api.Controllers
{
    [ApiController]
    [Route("documento/entrega-registrada/solicitacao")]
    public class DocumentoEntregaRegistradaSolicitacaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoEntregaRegistradaSolicitacaoController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("tipo-carregar")]
        public async Task<object> TipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("empresa-carregar")]
        public async Task<object> EmpresaCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/empresa-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("centro-custo-carregar")]
        public async Task<object> CentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("documento-tipo-carregar")]
        public async Task<object> DocumentoTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/documento-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("documento-subtipo-carregar")]
        public async Task<object> DocumentoSubTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/documento-subtipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("formato-obter")]
        public async Task<object> FormatoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/formato-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("juridico-processo-consulta-listar")]
        public IAsyncEnumerable<object> JuridicoProcessoConsultaListar(
            CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/juridico-processo-consulta-listar{Request.QueryString}",
            }, cancellationToken);
        }

        [HttpPost("validar")]
        public async Task<object> Validar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/validar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("registrar")]
        public async Task<object> Registrar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/solicitacao/registrar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}