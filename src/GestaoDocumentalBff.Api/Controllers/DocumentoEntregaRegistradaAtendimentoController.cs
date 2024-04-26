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
    [Route("documento/entrega-registrada/atendimento")]
    public class DocumentoEntregaRegistradaAtendimentoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoEntregaRegistradaAtendimentoController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("filtro-situacao-carregar")]
        public async Task<object> FiltroSituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/filtro-situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        
        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("retornar-totais")]
        public async Task<object> RetornarTotais(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/retornar-totais{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("assumir-solicitacao")]
        public async Task<object> AssumirSolicitacao(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/assumir-solicitacao",
                Stream = Request.Body,
            },
            cancellationToken);
        }

        [HttpGet("opcao-carregar")]
        public async Task<object> OpcaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/opcao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        
        [HttpGet("imprimir-documento")]
        public async Task<object> ImprimirDocumento(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/imprimir-documento{Request.QueryString}",
            },
            cancellationToken);
        }

        
        [HttpGet("planilha-obter")]
        public async Task<object> PlanilhaObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/planilha-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        
        [HttpGet("detalhe-obter")]
        public async Task<object> DetalheObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/detalhe-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("mensagem-obter")]
        public async Task<object> MensagemObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/mensagem-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        //solicitacao-cancelar
        [HttpPost("solicitacao-cancelar")]
        public async Task<object> SolicitacaoCancelar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/solicitacao-cancelar",
                Stream = Request.Body,
            },
            cancellationToken);
        }

        //solicitacao-concluir
        [HttpPost("solicitacao-concluir")]
        public async Task<object> SolicitacaoConcluir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/solicitacao-concluir",
                Stream = Request.Body,
            },
                       cancellationToken);
        }

        //solicitacao-assumir
        [HttpPost("solicitacao-assumir")]
        public async Task<object> SolicitacaoAssumir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/solicitacao-assumir",
                Stream = Request.Body,
            },
            cancellationToken);
        }

        //mensagem-incluir
        [HttpPost("mensagem-incluir")]
        public async Task<object> MensagemIncluir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/mensagem-incluir",
                Stream = Request.Body,
            },
            cancellationToken);
        }

        //solicitacaoImprimir
        [HttpGet("solicitacao-imprimir")]
        public async Task<object> SolicitacaoImprimir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/solicitacao-imprimir{Request.QueryString}",
            }
            , cancellationToken);
        }

        //confirmar-avulso
        [HttpPost("confirmar-avulso")]
        public async Task<object> ConfirmarAvulso(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/confirmar-avulso",
                Stream = Request.Body,
            },
            cancellationToken);
        }

        //conferencia-lote
        [HttpPost("conferencia-lote")]
        public async Task<object> ConferenciaLote(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/conferencia-lote",
                Stream = Request.Body,
            },
            cancellationToken);
        }

        [HttpGet("centro-custo-carregar")]
        public async Task<object> CentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        //documento-obter
        [HttpGet("documento-obter")]
        public async Task<object> DocumentoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/documento-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        //alteracao-salvar
        [HttpPost("alteracao-salvar")]
        public async Task<object> AlteracaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/alteracao-salvar",
                Stream = Request.Body,
            },
            cancellationToken);
        }

        //lote-finalizar
        [HttpPost("lote-finalizar")]
        public async Task<object> LoteFinalizar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/entrega-registrada/atendimento/lote-finalizar",
                Stream = Request.Body,
            },
            cancellationToken);
        }
    }
}