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
    [Route("documento/tipo-cadastro")]
    public class DocumentoTipoCadastroController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoTipoCadastroController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("juridico-carregar")]
        public async Task<object> JuridicoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/juridico-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("planilha-obter")]
        public async Task<object> PlanilhaObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/planilha-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-obter")]
        public async Task<object> DetalheObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/detalhe-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-centro-custo-carregar")]
        public async Task<object> DetalheCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/detalhe-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-juridico-carregar")]
        public async Task<object> DetalheJuridicoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/detalhe-juridico-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-entrega-registrada-ativo-carregar")]
        public async Task<object> DetalheEntregaRegistradaCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/detalhe-entrega-registrada-ativo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-centro-custo-carregar")]
        public async Task<object> InclusaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/inclusao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-juridico-carregar")]
        public async Task<object> InclusaoJuridicoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/inclusao-juridico-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-entrega-registrada-ativo-carregar")]
        public async Task<object> InclusaoEntregaRegistradaCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/inclusao-entrega-registrada-ativo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("inclusao-salvar")]
        public async Task<object> InclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/inclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("alteracao-salvar")]
        public async Task<object> AlteracaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/alteracao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("exclusao-obter")]
        public async Task<object> ExclusaoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/exclusao-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-centro-custo-carregar")]
        public async Task<object> ExclusaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/exclusao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("exclusao-salvar")]
        public async Task<object> ExclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/tipo-cadastro/exclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}