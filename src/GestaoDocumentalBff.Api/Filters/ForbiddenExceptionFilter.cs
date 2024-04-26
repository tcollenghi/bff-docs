using GestaoDocumentalBff.Domain.Abstractions.Exceptions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace GestaoDocumentalBff.Api.Filters
{
    public class ForbiddenExceptionFilter : IExceptionFilter
    {
        IWebHostEnvironment Env { get; }

        public ForbiddenExceptionFilter(
            IWebHostEnvironment env
         )
        {
            Env = env;
        }

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ForbiddenException)
            {
               // Logger.Error(context.Exception, $"ActionFilter capturou uma {nameof(Exception)} em {nameof(OnException)} às {DateTime.Now.ToString("o")}.");

                context.Result = new ObjectResult
                (
                    "Não permitido"
                )
                {
                    StatusCode = (int)HttpStatusCode.Forbidden
                };

                context.ExceptionHandled = true;

                return;
            }
        }
    }
}