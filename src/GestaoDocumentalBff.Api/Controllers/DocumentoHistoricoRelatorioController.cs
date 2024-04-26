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
    [Route("documento/historico-relatorio")]
    public class DocumentoHistoricoRelatorioController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoHistoricoRelatorioController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("emprestimo-devolucao/consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/emprestimo-devolucao/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }
        
        [HttpGet("emprestimo-devolucao/consulta-exportar")]
        public IAsyncEnumerable<object> ConsultaExportar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/emprestimo-devolucao/consulta-exportar{Request.QueryString}",
            },
                       cancellationToken);
        }

        [HttpGet("entrega-registrada/consulta-exportar")]
        public IAsyncEnumerable<object> EntregaRegistradaConsultaExportar(CancellationToken cancellationToken)
        {
            return Mediator.CreateStream(new Application.QueryStreamRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint =
                    $"{Config.ApiHost}/documento/historico-relatorio/entrega-registrada/consulta-exportar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("entrega-registrada/consulta-listar")]
        public async Task<object> EntregaRegistradaConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint =
                    $"{Config.ApiHost}/documento/historico-relatorio/entrega-registrada/consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-codigo-barras-carregar")]
        public async Task<object> ConsultaCodigoBarrasCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint =
                    $"{Config.ApiHost}/documento/historico-relatorio/consulta-codigo-barras-carregar{Request.QueryString}",
            },
                       cancellationToken);
        }

        [HttpGet("consulta-centro-custo-carregar")]
        public async Task<object> ConsultaCentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        

        [HttpGet("consulta-tipo-documento-carregar")]
        public async Task<object> ConsultaTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-codigo-documento-carregar")]
        public async Task<object> ConsultaCodigoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-codigo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-tipo-relatorio-carregar")]
        public async Task<object> ConsultaTipoRelatorioCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-tipo-relatorio-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-forma-entrega-carregar")]
        public async Task<object> ConsultaFormaEntregaCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-forma-entrega-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-solicitante-carregar")]
        public async Task<object> ConsultaSolicitanteCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-solicitante-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-situacao-carregar")]
        public async Task<object> ConsultaSituacaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-situacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-atendente-carregar")]
        public async Task<object> ConsultaAtendenteCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-atendente-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("consulta-autorizador-carregar")]
        public async Task<object> ConsultaAutorizadorCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/historico-relatorio/consulta-autorizador-carregar{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}