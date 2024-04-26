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
    [Route("documento/temporalidade-cadastro")]
    public class DocumentoTemporalidadeController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoTemporalidadeController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-centro-custo-carregar")]
        public async Task<object> ConsultaCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/consulta-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-tipo-documento-carregar")]
        public async Task<object> ConsultaTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/consulta-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-sub-tipo-documento-carregar")]
        public async Task<object> ConsultaSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/consulta-sub-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("planilha-obter")]
        public async Task<object> PlanilhaObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/planilha-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-obter")]
        public async Task<object> DetalheObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-centro-custo-carregar")]
        public async Task<object> DetalheCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-tipo-documento-carregar")]
        public async Task<object> DetalheTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-sub-tipo-documento-carregar")]
        public async Task<object> DetalheSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-sub-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-origem-carregar")]
        public async Task<object> DetalheOrigemCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-origem-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-area-origem-carregar")]
        public async Task<object> DetalheAreaOrigemCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-area-origem-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-apresentacao-carregar")]
        public async Task<object> DetalheApresentacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-apresentacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-suporte-carregar")]
        public async Task<object> DetalheSuporteCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-suporte-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-destino-carregar")]
        public async Task<object> DetalheDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-area-destino-carregar")]
        public async Task<object> DetalheAreaDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-area-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-setorial-guarda-associacao-carregar")]
        public async Task<object> DetalheSetorialGuardaAssociacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-setorial-guarda-associacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-setorial-destino-carregar")]
        public async Task<object> DetalheSetorialDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-setorial-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-setorial-area-destino-carregar")]
        public async Task<object> DetalheSetorialAreaDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-setorial-area-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-interno-guarda-associacao-carregar")]
        public async Task<object> DetalheInternoGuardaAssociacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-interno-guarda-associacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-interno-destino-carregar")]
        public async Task<object> DetalheInternoDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-interno-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-externo-guarda-associacao-carregar")]
        public async Task<object> DetalheExternoGuardaAssociacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-externo-guarda-associacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-externo-destino-carregar")]
        public async Task<object> DetalheExternoDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/detalhe-externo-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-centro-custo-carregar")]
        public async Task<object> InclusaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-tipo-documento-carregar")]
        public async Task<object> InclusaoTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-sub-tipo-documento-carregar")]
        public async Task<object> InclusaoSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-sub-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-origem-carregar")]
        public async Task<object> InclusaoOrigemCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-origem-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-area-origem-carregar")]
        public async Task<object> InclusaoAreaOrigemCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-area-origem-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-apresentacao-carregar")]
        public async Task<object> InclusaoApresentacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-apresentacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-suporte-carregar")]
        public async Task<object> InclusaoSuporteCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-suporte-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-destino-carregar")]
        public async Task<object> InclusaoDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-area-destino-carregar")]
        public async Task<object> InclusaoAreaDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-area-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-setorial-guarda-associacao-carregar")]
        public async Task<object> InclusaoSetorialGuardaAssociacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-setorial-guarda-associacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-setorial-destino-carregar")]
        public async Task<object> InclusaoSetorialDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-setorial-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-setorial-area-destino-carregar")]
        public async Task<object> InclusaoSetorialAreaDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-setorial-area-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-interno-guarda-associacao-carregar")]
        public async Task<object> InclusaoInternoGuardaAssociacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-interno-guarda-associacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-interno-destino-carregar")]
        public async Task<object> InclusaoInternoDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-interno-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-externo-guarda-associacao-carregar")]
        public async Task<object> InclusaoExternoGuardaAssociacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-externo-guarda-associacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-externo-destino-carregar")]
        public async Task<object> InclusaoExternoDestinoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-externo-destino-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-obter")]
        public async Task<object> ExclusaoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/exclusao-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-centro-custo-carregar")]
        public async Task<object> ExclusaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/exclusao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-tipo-documento-carregar")]
        public async Task<object> ExclusaoTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/exclusao-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-sub-tipo-documento-carregar")]
        public async Task<object> ExclusaoSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/exclusao-sub-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-origem-carregar")]
        public async Task<object> ExclusaoOrigemCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/exclusao-origem-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("exclusao-salvar")]
        public async Task<object> ExclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/exclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("inclusao-salvar")]
        public async Task<object> InclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/inclusao-salvar",
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
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/alteracao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("interno-compartilhamento-salvar")]
        public async Task<object> InternoCompartilhamentoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/interno-compartilhamento-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("externo-compartilhamento-salvar")]
        public async Task<object> ExternoCompartilhamentoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/temporalidade-cadastro/externo-compartilhamento-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}