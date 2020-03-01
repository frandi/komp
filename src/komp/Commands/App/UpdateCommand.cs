using System.CommandLine;

namespace komp.Commands.App
{
    public class UpdateCommand : Command
    {
        public UpdateCommand() 
            : base("update", "Update a Komp App add-on to the newest version")
        {
        }
    }
}