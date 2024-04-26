using GestaoDocumentalBff.Domain.Abstractions.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace GestaoDocumentalBff.Api.Filters
{
    public class MethodNotAllowedFilter : IActionFilter
    {
        //ILogger Logger { get; }
        public MethodNotAllowedFilter()
        {
            //Logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            {
                if (context.Exception is MethodNotAllowedException exception)
                {
                    //Logger.Error(context.Exception, $"ActionFilter capturou um {nameof(MethodNotAllowedException)} em {nameof(OnActionExecuted)}  às {DateTime.Now.ToString("o")}.");
                    context.Result = new ObjectResult(exception.Message)
                    {
                        StatusCode = (int)HttpStatusCode.MethodNotAllowed
                    };

                    context.ExceptionHandled = true;
                    return;
                }
            }
        }
    }
}