using System.CommandLine;
using komp.Commands.AddOn;
using komp.Modules.AddOn;

namespace komp.Commands
{
    public class AddOnCommand : Command
    {
        private readonly AddOnService _addOnService;

        public AddOnCommand(AddOnService addOnService) 
            : base("addon", "View installed Komp add-ons")
        {
            _addOnService = addOnService;

            AddCommand(new NewCommand(_addOnService));
            AddCommand(new PublishCommand(_addOnService));
            AddCommand(new InstallCommand(_addOnService));
            AddCommand(new UpdateCommand(_addOnService));
        }
    }
}