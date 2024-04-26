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
    [Route("entrega-registrada")]
    public class EntregaRegistradaDocumentosController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public EntregaRegistradaDocumentosController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/entrega-registrada/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("mensagem-incluir")]
        public async Task<ActionResult> IncluirComentario( CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/entrega-registrada/mensagem-incluir{Request.QueryString}",
                Stream = Request.Body,
            },
           cancellationToken));
        }

        [HttpGet("mensagem-obter")]
        public async Task<object> MensagemObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/entrega-registrada/mensagem-obter{Request.QueryString}",
            },
                       cancellationToken);
        }

        [HttpGet("detalhe-obter")]
        public async Task<object> DetalheObter(CancellationToken cancellationToken)
        {
                return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/entrega-registrada/detalhe-obter{Request.QueryString}",
            },
                       cancellationToken);
        }

        [HttpGet("consulta-situacao-carregar")]
        public async Task<object> ConsultaSituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/entrega-registrada/consulta-situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/entrega-registrada/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("anexo-obter")]
        public async Task<object> AnexoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/entrega-registrada/anexo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("anexo-listar")]
        public async Task<object> AnexoListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/entrega-registrada/anexo-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("situacao-item-carregar")]
        public async Task<object> SituacaoItemCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/entrega-registrada/situacao-item-carregar{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}