using komp.Modules.AddOn;
using System.CommandLine;

namespace komp.Commands.AddOn
{
    public class PublishCommand : Command
    {
        private readonly AddOnService _addOnService;

        public PublishCommand(AddOnService addOnService) 
            : base("publish", "Publish Komp add-on to NuGet server")
        {
            _addOnService = addOnService;
        }
    }
}