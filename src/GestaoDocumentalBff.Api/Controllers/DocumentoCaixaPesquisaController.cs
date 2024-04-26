using GestaoDocumentalBff.Domain.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System;

namespace GestaoDocumentalBff.Api.Controllers
{
    [ApiController]
    [Route("documento/caixa-pesquisa")]
    public class DocumentoCaixaPesquisaController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoCaixaPesquisaController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/caixa-pesquisa/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public IAsyncEnumerable<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/caixa-pesquisa/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-exportar")]
        public IAsyncEnumerable<object> ConsultaExportar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/caixa-pesquisa/consulta-exportar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-caixa-numero-imprimir")]
        public async Task<object> ConsultaCaixaNumeroImprimir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/caixa-pesquisa/consulta-caixa-numero-imprimir{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}