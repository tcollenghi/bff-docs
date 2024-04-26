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
    [Route("documento/admitido-demitido-formalizacao/documento-cadastro")]
    public class DocumentoAdmitidoDemitidoFormalizacaoDocumentoCadastroController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoAdmitidoDemitidoFormalizacaoDocumentoCadastroController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("empresa-carregar")]
        public async Task<object> EmpresaCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/empresa-carregar{Request.QueryString}"
        },
        cancellationToken);


        [HttpGet("tipo-opcao-carregar")]
        public async Task<object> TipoOpcaoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/tipo-opcao-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("tipo-opcao-consulta-carregar")]
        public async Task<object> TipoOpcaoConsultaCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/tipo-opcao-consulta-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultarListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/consulta-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpPost("vinculo-alterar")]
        public async Task<object> VinculoAlterar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/vinculo-alterar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("documento-manutencao-consulta-listar")]
        public async Task<object> DocumentoConsultarListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/documento-manutencao-consulta-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("documento-manutencao-detalhe-obter")]
        public async Task<object> DocumentoDetalheObter(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/documento-manutencao-detalhe-obter{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("documento-manutencao-status-carregar")]
        public async Task<object> DocumentoStatusCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/documento-manutencao-status-carregar{Request.QueryString}"
        },
        cancellationToken);


        [HttpPost("documento-manutencao-alterar")]
        public async Task<object> DocumentoAlterar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/documento-manutencao-alterar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("documento-manutencao-incluir")]
        public async Task<object> DocumentoIncluir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/documento-manutencao-incluir{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpPost("documento-manutencao-excluir")]
        public async Task<object> DocumentoExcluir(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/documento-manutencao-excluir{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken);
        }

        [HttpGet("empresa-consulta-listar")]
        public async Task<object> EmpresaConsultarListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/empresa-consulta-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("empresa-detalhe-obter")]
        public async Task<object> EmpresaDetalheObter(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/empresa-detalhe-obter{Request.QueryString}"
        },
        cancellationToken);


        [HttpPost("empresa-alterar")]
        public async Task<ActionResult> EmpresaAlterar(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/empresa-alterar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpPost("empresa-incluir")]
        public async Task<ActionResult> EmpresaIncluir(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/empresa-incluir{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpPost("empresa-excluir")]
        public async Task<ActionResult> EmpresaExcluir(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/documento-cadastro/empresa-excluir{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }
    }
}