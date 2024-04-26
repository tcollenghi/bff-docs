using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace GestaoDocumentalBff.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((config) =>
            {
                config.AddJsonFile($"/opt/app-root/app/settings/appsettings.json",
                optional: true,
                reloadOnChange: false);
            })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile($"/opt/app-root/app/settings/appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json",
                optional: true,
                reloadOnChange: false);
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
