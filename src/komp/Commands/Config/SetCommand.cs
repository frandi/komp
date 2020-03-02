using komp.CommandOptions;
using komp.Modules.Config;
using System.CommandLine;

namespace komp.Commands.Config
{
    public class SetCommand : Command
    {
        private readonly ConfigService _configService;

        public SetCommand(ConfigService configService) 
            : base("set", "Set the value of a Komp configuration")
        {
            _configService = configService;

            AddOption(new KeyOption(true));
            AddOption(new ValueOption(true));
        }
    }
}