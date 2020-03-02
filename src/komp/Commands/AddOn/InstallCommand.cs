using komp.Modules.AddOn;
using System.CommandLine;

namespace komp.Commands.AddOn
{
    public class InstallCommand : Command
    {
        private readonly AddOnService _addOnService;

        public InstallCommand(AddOnService addOnService) 
            : base("install", "Install an add-on to Komp")
        {
            _addOnService = addOnService;
        }
    }
}