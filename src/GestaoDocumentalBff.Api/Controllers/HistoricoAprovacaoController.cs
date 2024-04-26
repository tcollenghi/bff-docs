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
    [Route("historico-aprovacao")]

    public class HistoricoAprovacaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public HistoricoAprovacaoController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/historico-aprovacao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-situacao-carregar")]
        public async Task<object> ConsultaSituacaoCarregar(CancellationToken cancellationToken)
        {

            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/historico-aprovacao/consulta-situacao-carregar{Request.QueryString}",
            },
                       cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {

            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/historico-aprovacao/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-exportar")]
        public IAsyncEnumerable<object> ConsultaExportar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/historico-aprovacao/consulta-exportar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-imprimir")]
        public async Task<object> ConsultaImprimir(CancellationToken cancellationToken)
        {

            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/historico-aprovacao/consulta-imprimir{Request.QueryString}",
            },
            cancellationToken);
        }


    }
}
