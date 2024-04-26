using GestaoDocumentalBff.Domain.Util;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading;
using System.Threading.Tasks;

namespace GestaoDocumentalBff.Api.Controllers
{
    [ApiController]
    [Route("documento/emprestimo-documento-devolucao")]
    public class DocumentoEmprestimoDocumentoDevolucaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoEmprestimoDocumentoDevolucaoController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("situacao-carregar")]
        public async Task<object> SituacaoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/situacao-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultaListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/consulta-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-mensagem-listar")]
        public async Task<object> ConsultaMensagemListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/consulta-mensagem-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-solicitacao-item-listar")]
        public async Task<object> ConsultaSolicitacaoItemListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/consulta-solicitacao-item-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("solicitacao-item-detalhe-obter")]
        public async Task<object> SolicitacaoItemDetalheObter(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/solicitacao-item-detalhe-obter{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("mensagem-detalhe-obter")]
        public async Task<object> MensagemDetalheObter(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/mensagem-detalhe-obter{Request.QueryString}"
        },
        cancellationToken);

        [HttpPost("mensagem-incluir")]
        public async Task<ActionResult> MensagemIncluir(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/mensagem-incluir{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpPost("registro-devolucao-incluir")]
        public async Task<ActionResult> RegistroDevolucaoIncluir(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/registro-devolucao-incluir{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpGet("arquivo-obter")]
        public async Task<object> ArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("anexar")]
        public async Task<object> Anexar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/anexar",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("anexo-obter")]
        public async Task<object> AnexoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/anexo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("anexo-listar")]
        public async Task<object> AnexoListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/anexo-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("opcao-carregar")]
        public async Task<object> FiltroSimNaoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/emprestimo-documento-devolucao/opcao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}