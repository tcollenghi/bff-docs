using GestaoDocumentalBff.Domain.Abstractions.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace GestaoDocumentalBff.Api.Filters
{
    public class InternalServerErrorExceptionFilter : IExceptionFilter
    {
       // ILogger Logger { get; }
        public InternalServerErrorExceptionFilter(
          
        )
        {
            //Logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is InternalServerErrorException)
            {
                //Logger.Error(context.Exception, $"ActionFilter capturou uma {nameof(InternalServerErrorException)} em {nameof(OnException)} às {DateTime.Now.ToString("o")}.");

                context.Result = new ObjectResult(context.Exception.Message)
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };
                context.ExceptionHandled = true;

                return;
            }
        }
    }
}
