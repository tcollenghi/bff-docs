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
    [Route("documento/documento-cadastro-relatorio")]
    public class DocumentoCadastroRelatorioController : ControllerBase
    {
        Config Config { get; }
        IMediator Mediator { get; }

        public DocumentoCadastroRelatorioController(IMediator mediator,IOptions<Config> optionsConfig)
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
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/funcionalidade-validar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("relatorio-tipo-carregar")]
        public async Task<object> TipoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/relatorio-tipo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("centro-custo-carregar")]
        public async Task<object> CentroCustoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/centro-custo-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("tipo-documento-carregar")]
        public async Task<object> TipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/tipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("subtipo-documento-carregar")]
        public async Task<object> SubTipoDocumentoCarregar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/subtipo-documento-carregar{Request.QueryString}",
            },
            cancellationToken);
        }
        
        [HttpGet("relatorio-cadastro-consulta-listar")]
        public async Task<object> RelatorioCadastroConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/relatorio-cadastro-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("relatorio-cadastro-arquivo-obter")]
        public async Task<object> RelatorioCadastroArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/relatorio-cadastro-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("arquivo-interno-consulta-listar")]
        public async Task<object> RelatorioArquivoInternoCadastroConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/arquivo-interno-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("arquivo-interno-arquivo-obter")]
        public async Task<object> RelatorioArquivoInternoCadastroArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/arquivo-interno-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("arquivo-externo-consulta-listar")]
        public async Task<object> RelatorioArquivoExternoCadastroConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/arquivo-externo-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("arquivo-externo-arquivo-obter")]
        public async Task<object> RelatorioArquivoExternoCadastroArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/arquivo-externo-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        
        [HttpGet("excecao-espaco-consulta-listar")]
        public async Task<object> RelatorioExcecaoEspacoCadastroConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/excecao-espaco-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("excecao-espaco-arquivo-obter")]
        public async Task<object> RelatorioExcecaoEspacoCadastroArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/excecao-espaco-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }
        
        [HttpGet("permanencia-consulta-listar")]
        public async Task<object> RelatorioPermanenciaCadastroConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/permanencia-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("permanencia-arquivo-obter")]
        public async Task<object> RelatorioPermanenciaCadastroArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/permanencia-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("pendente-envio-consulta-listar")]
        public async Task<object> RelatorioPendenteEnvioCadastroConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/pendente-envio-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("pendente-envio-arquivo-obter")]
        public async Task<object> RelatorioPendenteEnvioCadastroArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/pendente-envio-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("pendente-expurgo-consulta-listar")]
        public async Task<object> RelatorioPendenteExpurgoCadastroConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/pendente-expurgo-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("pendente-expurgo-arquivo-obter")]
        public async Task<object> RelatorioPendenteExpurgoCadastroArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/pendente-expurgo-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("expurgado-consulta-listar")]
        public async Task<object> RelatorioExpurgadoCadastroConsultaListar(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/expurgado-consulta-listar{Request.QueryString}",
            },
            cancellationToken);
        }

        [HttpGet("expurgado-arquivo-obter")]
        public async Task<object> RelatorioExpurgadoCadastroArquivoObter(CancellationToken cancellationToken)
        {
            return await Mediator.Send(new Application.QueryRequest
            {
                Meta = Request.Headers.ToRequestMeta(),
                Endpoint = $"{Config.ApiHost}/documento/documento-cadastro-relatorio/expurgado-arquivo-obter{Request.QueryString}",
            },
            cancellationToken);
        }
    }
}