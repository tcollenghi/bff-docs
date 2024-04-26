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
    [Route("documento/admitido-demitido-formalizacao/matricula-checagem")]
    public class DocumentoAdmitidoDemitidoFormalizacaoMatriculaChecagemController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoAdmitidoDemitidoFormalizacaoMatriculaChecagemController(IMediator mediator, IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/matricula-checagem/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("tipo-carregar")]
        public async Task<object> OpcaoCarregar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/matricula-checagem/tipo-carregar{Request.QueryString}"
        },
        cancellationToken);

        [HttpGet("consulta-listar")]
        public async Task<object> ConsultarListar(CancellationToken cancellationToken) =>
        await Mediator.Send(new Application.QueryRequest
        {
            Meta = Request.Headers.ToRequestMeta(),
            Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/matricula-checagem/consulta-listar{Request.QueryString}"
        },
        cancellationToken);

        [HttpPost("admissao-demissao-documento-gerar")]
        public async Task<object> DocumentoGerar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/admitido-demitido-formalizacao/matricula-checagem/admissao-demissao-documento-gerar{Request.QueryString}",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}