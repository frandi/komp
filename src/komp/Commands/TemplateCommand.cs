using System.CommandLine;
using komp.Commands.Template;
using komp.Modules.Template;

namespace komp.Commands
{
    public class TemplateCommand : Command
    {
        private readonly TemplateService _templateService;

        public TemplateCommand(TemplateService templateService) 
            : base("template", "View available Komp templates")
        {
            _templateService = templateService;

            AddCommand(new NewCommand(_templateService));
        }
    }
}