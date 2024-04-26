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
    [Route("documento/documento-recepcao")]
    public class DocumentoRecepcaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoRecepcaoController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-empresa-carregar")]
        public async Task<object> FiltroEmpresaCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/filtro-empresa-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-centro-custo-carregar")]
        public async Task<object> InclusaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/inclusao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-tipo-documento-carregar")]
        public async Task<object> InclusaoTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/inclusao-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-subtipo-documento-carregar")]
        public async Task<object> InclusaoSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/inclusao-subtipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }
        
        [HttpGet("inclusao-empresa-carregar")]
        public async Task<object> InclusaoEmpresaCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/inclusao-empresa-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-cadastro-tipo-carregar")]
        public async Task<object> InclusaoCadastroTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/inclusao-cadastro-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("inclusao-espaco-excecao-carregar")]
        public async Task<object> InclusaoEspacoExcecaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/inclusao-espaco-excecao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-doc-obter")]
        public async Task<object> ExclusaoSubTipoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-doc-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-cadastro-tipo-carregar")]
        public async Task<object> AlteracaoCadastroTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-cadastro-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-centro-custo-carregar")]
        public async Task<object> AlteracaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-empresa-carregar")]
        public async Task<object> AlteracaoEmpresaCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-empresa-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-espaco-excecao-carregar")]
        public async Task<object> AlteracaoEspacoExcecaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-espaco-excecao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-tipo-documento-carregar")]
        public async Task<object> AlteracaoTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-subtipo-documento-carregar")]
        public async Task<object> AlteracaoSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-subtipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("alteracao-digitalizado-documento-carregar")]
        public async Task<object> AlteracaoDigitalizadoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-digitalizado-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-doc-obter")]
        public async Task<object> ExclusaoDocObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-doc-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-cadastro-tipo-carregar")]
        public async Task<object> ExclusaoCadastroTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-cadastro-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-centro-custo-carregar")]
        public async Task<object> ExclusaoCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-empresa-carregar")]
        public async Task<object> ExclusaoEmpresaCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-empresa-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-espaco-excecao-carregar")]
        public async Task<object> ExclusaoEspacoExcecaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-espaco-excecao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-tipo-documento-carregar")]
        public async Task<object> ExclusaoTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-subtipo-documento-carregar")]
        public async Task<object> ExclusaoSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-subtipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("exclusao-digitalizado-documento-carregar")]
        public async Task<object> ExclusaoDigitalizadoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-digitalizado-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-centro-custo-carregar")]
        public async Task<object> FiltroCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/filtro-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-tipo-documento-carregar")]
        public async Task<object> FiltroTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/filtro-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-subtipo-documento-carregar")]
        public async Task<object> FiltroSubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/filtro-subtipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("arquivo-obter")]
        public IAsyncEnumerable<object> ArquivoObter(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("exclusao-salvar")]
        public async Task<object> ExclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/exclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("cod-barras-obter")]
        public async Task<object> CodBarasObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/cod-barras-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("inclusao-salvar")]
        public async Task<object> InclusaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/inclusao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("responsavel-obter")]
        public async Task<object> ResponsavelObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/responsavel-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("alteracao-salvar")]
        public async Task<object> AlteracaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-recepcao/alteracao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}