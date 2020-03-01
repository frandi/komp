using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace komp
{
    class Program
    {
        static int Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddOptions()
                .Configure<AppServiceOptions>(Configuration.GetSection("AppService"))
                .AddLogging()
                .AddSingleton<AppService>();

            var appService = services.BuildServiceProvider().GetService<AppService>();

            return appService.Run(args);
        }

        static IConfiguration Configuration => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true)
            .AddEnvironmentVariables()
            .Build();
    }
}
