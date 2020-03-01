using System.CommandLine;

namespace komp.Commands
{
    public class InitCommand : Command
    {
        public InitCommand() 
            : base("init", "Initiate config file in your app")
        {
        }
    }
}