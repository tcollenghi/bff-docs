using GestaoDocumentalBff.Application.HeathChecks;
using GestaoDocumentalBff.Domain.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GestaoDocumentalBff.Api.Controllers
{
    [ApiController]
    [Route("/hc")]
    public class HealthController : ControllerBase
    {
        Config Config { get; }


        public HealthController( IConfiguration configuration)
        {
            Config = configuration.GetSection(nameof(Config)).Get<Config>();
        }

        [HttpGet, AllowAnonymous]
        public string Get()
        {
            return "OK";
        }

        [HttpGet, AllowAnonymous]
        [Route("ready")]
        public ICheckService GetReady()
        {
            return ((ICheckService)new CheckService());
        }

        [HttpGet]
        [Route("deep")]
        public ICheckService GetDeep()
        {
            return GetReady()
                .Add(
                    new CheckServiceDeep(
                        nameof(Config.ApiHost),
                        Config.ApiHost,
                        Request.Headers["Authorization"]
                        
                    )
                );
        }
    }
}