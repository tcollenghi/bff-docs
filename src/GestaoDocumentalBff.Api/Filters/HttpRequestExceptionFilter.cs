using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Net.Http;

namespace GestaoDocumentalBff.Api.Filters
{
    public class HttpRequestExceptionFilter : IExceptionFilter
    {
        //ILogger Logger { get; }
        public HttpRequestExceptionFilter()
        {
        }

        public void OnException(ExceptionContext context)
        {
            var httpException = context.Exception as HttpRequestException;
            if (httpException == default)
                return;
            if (httpException.Message.EndsWith("404 (Not Found)."))
            {
                //Logger.Error(context.Exception, $"{nameof(HttpRequestExceptionFilter)} capturou um ${nameof(HttpRequestException)} em ${nameof(OnException)}");
                context.Result = new NotFoundResult();
                context.ExceptionHandled = true;
                return;
            }

            if (httpException.Message.Contains("Error while copying content to a stream"))
            {
                if (!(httpException.InnerException?.Message?.Contains("Request body too large") == true))
                    return;

                //Logger.Error(httpException, $"{nameof(HttpRequestExceptionFilter)} capturou um ${nameof(HttpRequestException)} em ${nameof(OnException)}");
                context.Result = new BadRequestObjectResult("Corpo da requisição muito grande")
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
                context.ExceptionHandled = true;
                return;
            }
        }
    }
}