using MediatR;
using System;
using System.Linq;
using Xunit;

public class RequestHandlerTest
{
    [Theory]
    [InlineData("GestaoDocumentalBff.Api")]
    [InlineData("GestaoDocumentalBff.Application")]
    [InlineData("GestaoDocumentalBff.CrossCutting")]
    [InlineData("GestaoDocumentalBff.Domain")]
    public void RestrictionsTest(string name)
    {
        var handlers = AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(w => w.FullName.Contains(name))
            .Single()
            .GetTypes()
            .Where(type => type
                .GetInterfaces()
                .Any(@interface =>
                {
                    if (!@interface.IsGenericType)
                        return false;

                    var type = @interface.GetGenericTypeDefinition();
                    if (!new[]
                        {
                            typeof(IRequestHandler<,>),
                            typeof(IRequestHandler<>)
                        }
                        .Contains(type)
                    )
                        return false;

                    return true;
                })
            )
            .ToArray();

        Assert
            .True(
                handlers.All(h => !h.IsPublic),
                $"types ({string.Join(", ", handlers.Where(w => w.IsPublic).Select(s => s.FullName))}) is public"
             );

        Assert
            .True(
                handlers.All(h => h.IsSealed),
                $"types ({string.Join(", ", handlers.Where(w => !w.IsSealed).Select(s => s.FullName))}) is not sealed"
             );

        Assert
            .True(
                handlers.All(h => h.Name.EndsWith("RequestHandler")),
                $"types ({string.Join(", ", handlers.Where(w => !w.Name.EndsWith("RequestHandler")).Select(s => s.FullName))}) is not endsWith (RequestHandler)"
             );

        Assert
            .True(
                handlers.All(h => !h.GetConstructors().Skip(1).Any()),
                $"types ({string.Join(", ", handlers.Where(w => w.GetConstructors().Skip(1).Any()).Select(s => s.FullName))}) is not a single public constructor"
            );
    }
}