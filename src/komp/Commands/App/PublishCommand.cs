using System.CommandLine;

namespace komp.Commands.App
{
    public class PublishCommand : Command
    {
        public PublishCommand() 
            : base("publish", "Publish Komp App add-on to NuGet server")
        {
        }
    }
}