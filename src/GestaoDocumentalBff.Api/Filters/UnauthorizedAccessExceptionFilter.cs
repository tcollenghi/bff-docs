using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace GestaoDocumentalBff.Api.Filters
{
    public class UnauthorizedAccessExceptionFilter : IExceptionFilter
    {
        IWebHostEnvironment Env { get; }

        public UnauthorizedAccessExceptionFilter(
           // ILogger logger,
            IWebHostEnvironment env
         )
        {
            //Logger = logger;
            Env = env;
        }

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is UnauthorizedAccessException)
            {
                //Logger.Error(context.Exception, $"ActionFilter capturou uma {nameof(Exception)} em {nameof(OnException)} às {DateTime.Now.ToString("o")}.");
                context.Result = new ObjectResult
                (
                    "Não autorizado"
                )
                {
                    StatusCode = (int)HttpStatusCode.Unauthorized
                };

                context.ExceptionHandled = true;
                return;
            }
        }
    }
}