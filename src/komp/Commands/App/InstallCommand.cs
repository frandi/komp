using System.CommandLine;

namespace komp.Commands.App
{
    public class InstallCommand : Command
    {
        public InstallCommand() 
            : base("install", "Install an App add-on to Komp")
        {
        }
    }
}