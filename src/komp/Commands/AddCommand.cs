using System.CommandLine;

namespace komp.Commands
{
    public class AddCommand : Command
    {
        public AddCommand() 
            : base("add", "Add component to your app")
        {
        }
    }
}