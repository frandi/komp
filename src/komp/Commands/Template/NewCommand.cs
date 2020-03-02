using System.CommandLine;
using komp.CommandOptions;
using komp.Modules.Template;

namespace komp.Commands.Template
{
    public class NewCommand : Command
    {
        private readonly TemplateService _templateService;

        public NewCommand(TemplateService templateService) 
            : base("new", "Create new Komp template folder")
        {
            _templateService = templateService;

            AddOption(new NameOption(true));
            AddOption(new OutputOption());
        }
    }
}