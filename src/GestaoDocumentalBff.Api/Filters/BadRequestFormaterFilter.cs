using GestaoDocumentalBff.Domain.Abstractions.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace GestaoDocumentalBff.Api.Filters
{
    public class BadRequestFormatterFilter : IActionFilter
    {
        public BadRequestFormatterFilter()
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
                context.Result = new BadRequestObjectResult(context.ModelState)
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                };
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is BadRequestException exception)
            {
                //Logger.Error(context.Exception, $"ActionFilter capturou um {nameof(BadRequestException)} em {nameof(OnActionExecuted)} às {DateTime.Now.ToString("o")}.");
                context.Result = new BadRequestObjectResult(exception.Message)
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
                context.ExceptionHandled = true;
                return;
            }
        }
    }
}