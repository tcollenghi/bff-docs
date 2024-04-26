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
    [Route("centro-de-custo")]
    public class CentroDeCustoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public CentroDeCustoController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/centro-de-custo/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/centro-de-custo/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-obter")]
        public async Task<object> ContratoDetalheObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/centro-de-custo/detalhe-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("arquivo-obter")]
        public async Task<object> ArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/centro-de-custo/arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("inclusao-salvar")]
        public async Task<object> InclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/centro-de-custo/inclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("filtro-centro-custo-carregar")]
        public async Task<object> FiltroCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/centro-de-custo/filtro-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }


    }
}