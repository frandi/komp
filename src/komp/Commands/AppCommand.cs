using System.CommandLine;
using komp.Commands.App;

namespace komp.Commands
{
    public class AppCommand : Command
    {
        public AppCommand() 
            : base("app", "View installed Komp App add-on")
        {
            AddCommand(new NewCommand());
            AddCommand(new PublishCommand());
            AddCommand(new InstallCommand());
            AddCommand(new UpdateCommand());
        }
    }
}