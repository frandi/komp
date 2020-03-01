using System.CommandLine;
using komp.CommandOptions;

namespace komp.Commands.App
{
    public class NewCommand : Command
    {
        public NewCommand() 
            : base("new", "Create new Komp App add-on")
        {
            AddOption(new NameOption(true));
            AddOption(new OutputOption());
        }
    }
}