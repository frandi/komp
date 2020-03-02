using komp.Modules.AddOn;
using System.CommandLine;

namespace komp.Commands.AddOn
{
    public class UpdateCommand : Command
    {
        private readonly AddOnService _addOnService;

        public UpdateCommand(AddOnService addOnService) 
            : base("update", "Update a Komp add-on to the newest version")
        {
            _addOnService = addOnService;
        }
    }
}