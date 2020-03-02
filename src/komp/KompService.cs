using System.CommandLine;
using komp.Commands;
using komp.Modules.AddOn;
using komp.Modules.Component;
using komp.Modules.Config;
using komp.Modules.Template;

namespace komp
{
    public class KompService
    {
        private readonly ComponentService _componentService;
        private readonly ConfigService _configService;
        private readonly TemplateService _templateService;
        private readonly AddOnService _addOnService;

        public KompService(
            ComponentService componentService,
            ConfigService configService,
            TemplateService templateService,
            AddOnService addOnService)
        {
            _componentService = componentService;
            _configService = configService;
            _templateService = templateService;
            _addOnService = addOnService;
        }

        public int Run(string[] args)
        {
            var rootCommand = new RootCommand("A simple tooling for your app components");

            rootCommand.AddCommand(new InitCommand(_componentService));
            rootCommand.AddCommand(new AddCommand(_componentService));
            rootCommand.AddCommand(new RemoveCommand(_componentService));
            rootCommand.AddCommand(new ConfigCommand(_configService));
            rootCommand.AddCommand(new TemplateCommand(_templateService));
            rootCommand.AddCommand(new AddOnCommand(_addOnService));

            return rootCommand.Invoke(args);
        }
    }
}