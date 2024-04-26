using GestaoDocumentalBff.Domain.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace GestaoDocumentalBff.Api.Controllers
{
    [ApiController]
    [Route("contrato/imagem-associacao")]
    public class ContratoImagemAssociacaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public ContratoImagemAssociacaoController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/contrato/imagem-associacao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("contrato-encontrar")]
        public async Task<object> ContratoEncontrar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/contrato/imagem-associacao/contrato-encontrar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("contrato-detalhe-obter")]
        public async Task<object> ContratoDetalheObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/contrato/imagem-associacao/contrato-detalhe-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("arquivo-anexar")]
        public async Task<object> ArquivoAnexar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/contrato/imagem-associacao/arquivo-anexar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("arquivo-obter")]
        public async Task<object> ArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/contrato/imagem-associacao/arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("arquivo-lote-anexar")]
        public async Task<object> ArquivoLoteAnexar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/contrato/imagem-associacao/arquivo-lote-anexar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}