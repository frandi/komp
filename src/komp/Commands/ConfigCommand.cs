using komp.Commands.Config;
using komp.Modules.Config;
using System.CommandLine;

namespace komp.Commands
{
    public class ConfigCommand : Command
    {
        private readonly ConfigService _configService;

        public ConfigCommand(ConfigService configService) 
            : base("config", "View Komp configurations")
        {
            _configService = configService;

            AddCommand(new GetCommand(_configService));
            AddCommand(new SetCommand(_configService));
        }
    }
}