using System.CommandLine;

namespace komp.Commands
{
    public class RemoveCommand : Command
    {
        public RemoveCommand() 
            : base("remove", "Remove component from your app")
        {
        }
    }
}