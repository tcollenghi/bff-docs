using GestaoDocumentalBff.CrossCutting.InjecaoDependencia;
using GestaoDocumentalBff.Domain.Abstractions.Exceptions;
using GestaoDocumentalBff.Domain.Util;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GestaoDocumentalBff.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static string SWAGGER_TITLE = "SAG Documental BFF";
        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddHttpClient()
                .AddHealthChecksInjection()
                .AddHttpContextAccessor()
                .AddCustomFilters()
                .AddCustomJsonOptions()
                .AddMediator(
                    typeof(Application.Context).Assembly,
                    typeof(Program).Assembly
                )
                .AddCustomConfigs(Configuration)
                .AddCustomSwagger()
            ;
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsEnvironment("Localhost"))
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", SWAGGER_TITLE);
                });
            }
            app.UseCors(q =>
                q.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader()
            );

            app.UseExceptionHandler(
                options =>
                {
                    options.Run(
                    async context =>
                    {
                        var handler = context.Features.Get<IExceptionHandlerFeature>();

                        if (handler.Error is UnauthorizedAccessException)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                            await context.Response.WriteAsync("Não autorizado");
                            return;
                        }

                        if (handler.Error is MethodNotAllowedException methodNotAllowedException)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.MethodNotAllowed;
                            await context.Response.WriteAsync(methodNotAllowedException.Message);
                            return;
                        }

                        if (handler.Error is BadRequestException exception)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                            await context.Response.WriteAsync(handler.Error.Message);
                            return;
                        }

                        if (handler.Error is HttpRequestException httpException)
                        {
                            if (httpException.Message.EndsWith("404 (Not Found)."))
                            {
                                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                                return;
                            }
                        }

                        if (handler.Error is ForbiddenException forbiddenException)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                            await context.Response.WriteAsync("Não permitido");
                            return;
                        }

                        if (handler.Error is InternalServerErrorException internalServerErrorException)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            if (env.IsEnvironment("Homolog"))
                                await context.Response.WriteAsync(internalServerErrorException.Message);
                            return;
                        }

                        //context.RequestServices.GetRequiredService<ILogger>().Error(handler.Error, "Falha não tratada");
                        if (env.IsEnvironment("Homolog"))
                            await context.Response.WriteAsync(handler.Error.ToString());
                    });
                });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealths();
            });
        }
    }

    internal static class Custom
    {
        internal static void MapHealths(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapHealthChecks("/health", new HealthCheckOptions()
            {
                ResponseWriter = (context, health) =>
                {
                    context.Response.ContentType = "application/json";
                    var options = new JsonWriterOptions { Indented = true };
                    using var memoryStream = new MemoryStream();
                    using (var jsonWriter = new Utf8JsonWriter(memoryStream, options))
                    {
                        jsonWriter.WriteStartObject();
                        foreach (var healthEntry in health.Entries)
                        {
                            jsonWriter.WriteString("status", healthEntry.Value.Description);
                        }
                        jsonWriter.WriteEndObject();
                    }

                    return context.Response.WriteAsync(Encoding.UTF8.GetString(memoryStream.ToArray()));
                }
            });

        }
        internal static IMvcBuilder AddCustomFilters(this IServiceCollection services)
        {
            return services.AddControllers(options =>
            {
                /*A ORDEM AQUI É RELEVANTE!*/
                options.Filters.Add(new AuthorizeFilter());
                // options.Filters.Add<UnauthorizedAccessExceptionFilter>();
                // options.Filters.Add<MethodNotAllowedFilter>();
                // options.Filters.Add<BadRequestFormatterFilter>();
                // options.Filters.Add<HttpRequestExceptionFilter>();
                // options.Filters.Add<ForbiddenExceptionFilter>();
                // options.Filters.Add<InternalServerErrorExceptionFilter>();
            });
        }

        internal static IServiceCollection AddCustomJsonOptions(this IMvcBuilder services)
        {
            return services
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                })
                .Services
                .Configure<ApiBehaviorOptions>(options =>
                {
                    options.SuppressModelStateInvalidFilter = true;
                });
        }

        internal static IServiceCollection AddCustomConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .Configure<Config>(configuration.GetSection(nameof(Config)));
        }

        internal static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(c =>
            {
                // configure SwaggerDoc and others
                c.SwaggerDoc("v1", new OpenApiInfo { Title = Startup.SWAGGER_TITLE, Version = "v1" });
                c.CustomSchemaIds(type => type.ToString());
                // add JWT Authentication
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "JWT Authentication",
                    Description = "Enter JWT Bearer token **_only_**",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer", // must be lower case
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        //Id = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                //c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {{securityScheme, new string[] { }}}
                );
            });
        }

    }
}
