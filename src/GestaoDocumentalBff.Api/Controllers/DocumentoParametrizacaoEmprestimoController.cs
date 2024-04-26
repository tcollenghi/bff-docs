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
    [Route("documento/parametrizacao-emprestimo")]
    public class DocumentoParametrizacaoEmprestimoController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoParametrizacaoEmprestimoController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/parametrizacao-emprestimo/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("parametrizacao-carregar")]
        public async Task<object> ExclusaoPublicacaoTipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/parametrizacao-emprestimo/parametrizacao-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpPost("alteracao-salvar")]
        public async Task<object> AlteracaoSalvar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.PostCommandRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/parametrizacao-emprestimo/alteracao-salvar",
                Stream = Request.Body
            },
            cancellationToken);
        }
    }
}