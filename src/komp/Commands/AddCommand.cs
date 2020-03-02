using komp.Modules.Component;
using System.CommandLine;

namespace komp.Commands
{
    public class AddCommand : Command
    {
        private readonly ComponentService _componentService;

        public AddCommand(ComponentService componentService) 
            : base("add", "Add component to your app")
        {
            _componentService = componentService;
        }
    }
}