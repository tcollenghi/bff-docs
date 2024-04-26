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
    [Route("etiqueta-impressao")]
    public class EtiquetaImpressaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public EtiquetaImpressaoController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/etiqueta-impressao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("etiqueta-tipo-carregar")]
        public IAsyncEnumerable<object> EtiquetaTipoCarregar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/etiqueta-impressao/etiqueta-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("impressao-pendencia-carregar")]
        public IAsyncEnumerable<object> PendenciaImpressaoCarregar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/etiqueta-impressao/impressao-pendencia-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("barras-codigo-consulta-listar")]
        public IAsyncEnumerable<object> BarrasCodigoConsultaListar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/etiqueta-impressao/barras-codigo-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("impressao-confirmar")]
        public async Task<object> ImpressaoConfirmar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/etiqueta-impressao/impressao-confirmar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}