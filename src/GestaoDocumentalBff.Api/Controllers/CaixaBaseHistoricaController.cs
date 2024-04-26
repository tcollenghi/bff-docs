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
    [Route("caixa/base-historica")]
    public class CaixaBaseHistoricaController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public CaixaBaseHistoricaController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/caixa/base-historica/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("tipo-carregar")]
        public async Task<object> TipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/caixa/base-historica/tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("situacao-carregar")]
        public async Task<object> SituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/caixa/base-historica/situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("centro-custo-carregar")]
        public async Task<object> CentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/caixa/base-historica/centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/caixa/base-historica/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("planilha-obter")]
        public IAsyncEnumerable<object> PlanilhaObter(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/caixa/base-historica/planilha-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-obter")]
        public async Task<object> DetalheObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/caixa/base-historica/detalhe-obter{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}