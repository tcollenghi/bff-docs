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
    [Route("documento/atendimento")]
    public class DocumentoAtendimentoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoAtendimentoController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/atendimento/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-situacao-carregar")]
        public async Task<object> FiltroSituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/filtro-situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }
        
        [HttpGet("filtro-opcao-carregar")]
        public async Task<object> FiltroOpcaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/filtro-opcao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }
        
        [HttpGet("filtro-cartorio-carregar")]
        public async Task<object> FiltroCartorioCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/filtro-cartorio-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-situacao-carregar")]
        public async Task<object> DetalheSituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-listar")]
        public IAsyncEnumerable<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("solicitacoes-assumir")]
        public async Task<object> SolicitacoesAssumir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/solicitacoes-assumir",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("solicitacoes-cancelar")]
        public async Task<object> SolicitacoesCancelar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/solicitacoes-cancelar",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("solicitacoes-cancelar-acao-nao")]
        public async Task<object> SolicitacoesCancelarAcaoNao(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/solicitacoes-cancelar-acao-nao",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("consulta-solicitacao-imprimir")]
        public async Task<object> ConsultaSolicitacaoImprimir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/consulta-solicitacao-imprimir{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-solicitacao-obter")]
        public async Task<object> DetalheSolicitacaoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-solicitacao-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("detalhe-solicitacao-assumir")]
        public async Task<object> DetalheSolicitacaoAssumir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-solicitacao-assumir",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("detalhe-solicitacao-cancelar")]
        public async Task<object> DetalheSolicitacaoCancelar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-solicitacao-cancelar",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("detalhe-solicitacao-concluir")]
        public async Task<object> DetalheSolicitacaoConcluir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-solicitacao-concluir",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("detalhe-itens-listar")]
        public IAsyncEnumerable<object> DetalheItensListar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-itens-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-arquivo-obter")]
        public async Task<object> ArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("detalhe-item-pesquisar")]
        public async Task<object> DetalheItemPesquisar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-item-pesquisar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("detalhe-documento-emprestar")]
        public async Task<object> DetalheDocumentoEmprestar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-documento-emprestar",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("detalhe-item-devolver")]
        public async Task<object> DetalheitemDevolver(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-item-devolver",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("detalhe-item-cancelar")]
        public async Task<object> DetalheItemCancelar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-item-cancelar",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("detalhe-item-copia-disponibilizar")]
        public async Task<object> DetalheItemCopiaDisponibilizar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-item-copia-disponibilizar",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("detalhe-item-kit-disponibilizar")]
        public async Task<object> DetalheItemKitDisponibilizar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-item-kit-disponibilizar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("detalhe-item-servico-baixar")]
        public async Task<object> DetalheItemServicoBaixar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-item-servico-baixar",
                Stream = Request.Body
            },
            cancellationToken);
        }
        
        [HttpPost("detalhe-documento-tipo-alterar")]
        public async Task<object> DetalheIDocumentoTipoAlterar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-documento-tipo-alterar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("detalhe-documento-obter")]
        public async Task<object> DetalheDocumentoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-documento-obter{Request.QueryString}",
            },
            cancellationToken);
        }
        
        [HttpGet("detalhe-documento-classificacao-obter")]
        public async Task<object> DetalheDocumentoClassificacaoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-documento-classificacao-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("detalhe-valida-item-classificar")]
        public async Task<object> DetalheValidaItemClassificar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/atendimento/detalhe-valida-item-classificar{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}