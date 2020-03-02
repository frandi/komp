using System.CommandLine;
using komp.CommandOptions;
using komp.Modules.AddOn;

namespace komp.Commands.AddOn
{
    public class NewCommand : Command
    {
        private readonly AddOnService _addOnService;

        public NewCommand(AddOnService addOnService) 
            : base("new", "Create new Komp add-on")
        {
            _addOnService = addOnService;

            AddOption(new NameOption(true));
            AddOption(new OutputOption());
        }
    }
}