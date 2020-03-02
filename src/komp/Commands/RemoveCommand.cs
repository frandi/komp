using komp.Modules.Component;
using System.CommandLine;

namespace komp.Commands
{
    public class RemoveCommand : Command
    {
        private readonly ComponentService _componentService;

        public RemoveCommand(ComponentService componentService) 
            : base("remove", "Remove component from your app")
        {
            _componentService = componentService;
        }
    }
}