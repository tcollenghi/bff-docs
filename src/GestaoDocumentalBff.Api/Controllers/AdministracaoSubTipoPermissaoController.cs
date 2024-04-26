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
    [Route("administracao/sub-tipo-permissao")]
    public class AdministracaoSubTipoPermissaoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public AdministracaoSubTipoPermissaoController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("usuario-carregar")]
        public async Task<object> UsuarioCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/usuario-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("usuario-departamento-carregar")]
        public async Task<object> UsuarioDepartamentoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/usuario-departamento-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("departamento-carregar")]
        public async Task<object> DepartamentoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/departamento-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("tipo-documento-carregar")]
        public async Task<object> TipoDocumentoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/tipo-documento-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("sub-tipo-documento-carregar")]
        public async Task<object> SubTipoDocumentoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/sub-tipo-documento-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-vinculado-listar")]
        public async Task<object> ConsultaVinculadoListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/consulta-vinculado-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-sem-vinculo-listar")]
        public async Task<object> ConsultaSemVinculoListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/consulta-sem-vinculo-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpPost("inclusao-individual-salvar")]
        public async Task<ActionResult> InclusaoSubTipoPermissao(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/inclusao-individual-salvar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpPost("remocao-individual-salvar")]
        public async Task<ActionResult> RemocaoSubTipoPermissao(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/remocao-individual-salvar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpPost("inclusao-lote-salvar")]
        public async Task<ActionResult> InclusaoLoteSubTipoPermissao(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/inclusao-lote-salvar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpPost("remocao-lote-salvar")]
        public async Task<ActionResult> RemocaoLoteSubTipoPermissao(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/remocao-lote-salvar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken));
        }

        [HttpGet("tipo-acesso-obter")]
        public async Task<object> TipoAcessoObter(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/administracao/sub-tipo-permissao/tipo-acesso-obter{Request.QueryString}"
        },
        cancellationToken);
    }
}