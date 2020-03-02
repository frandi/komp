using komp.Modules.AddOn;
using komp.Modules.Component;
using komp.Modules.Config;
using komp.Modules.Template;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace komp
{
    class Program
    {
        static int Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddOptions()
                .Configure<KompOptions>(Configuration.GetSection("Options"))
                .AddLogging()
                .AddSingleton<KompService>()
                .AddSingleton<AddOnService>()
                .AddSingleton<ComponentService>()
                .AddSingleton<ConfigService>()
                .AddSingleton<TemplateService>();

            var kompService = services.BuildServiceProvider().GetService<KompService>();

            return kompService.Run(args);
        }

        static IConfiguration Configuration => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true)
            .AddEnvironmentVariables()
            .Build();
    }
}
