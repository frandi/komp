using komp.Modules.Component;
using System.CommandLine;

namespace komp.Commands
{
    public class InitCommand : Command
    {
        private readonly ComponentService _componentService;

        public InitCommand(ComponentService componentService) 
            : base("init", "Initiate config file for your app")
        {
            _componentService = componentService;
        }
    }
}