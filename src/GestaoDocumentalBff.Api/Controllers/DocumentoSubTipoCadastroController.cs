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
    [Route("documento/sub-tipo-cadastro")]
    public class DocumentoSubTipoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoSubTipoController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }
        
        [HttpGet("inclusao-centro-custo-carregar")]
        public async Task<object> InclusaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/inclusao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-tipo-documento-carregar")]
        public async Task<object> InclusaoTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/inclusao-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-publicacao-tipo-carregar")]
        public async Task<object> InclusaoPublicacaoTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/inclusao-publicacao-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("inclusao-salvar")]
        public async Task<object> InclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/inclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("alteracao-sub-tipo-obter")]
        public async Task<object> AlteracaoSubTipoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/alteracao-sub-tipo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-centro-custo-carregar")]
        public async Task<object> AlteracaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/alteracao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-tipo-documento-carregar")]
        public async Task<object> AlteracaoTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/alteracao-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-publicacao-tipo-carregar")]
        public async Task<object> AlteracaoPublicacaoTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/alteracao-publicacao-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("alteracao-salvar")]
        public async Task<object> AlteracaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/alteracao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("exclusao-sub-tipo-obter")]
        public async Task<object> ExclusaoSubTipoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/exclusao-sub-tipo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-centro-custo-carregar")]
        public async Task<object> ExclusaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/exclusao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-tipo-documento-carregar")]
        public async Task<object> ExclusaoTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/exclusao-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-publicacao-tipo-carregar")]
        public async Task<object> ExclusaoPublicacaoTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/exclusao-publicacao-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("exclusao-salvar")]
        public async Task<object> ExclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/exclusao-salvar",
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
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-centro-custo-carregar")]
        public async Task<object> FiltroCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/filtro-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-tipo-documento-carregar")]
        public async Task<object> FiltroTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/sub-tipo-cadastro/filtro-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

    }
}