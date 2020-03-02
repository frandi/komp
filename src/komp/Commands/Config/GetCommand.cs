using komp.CommandOptions;
using komp.Modules.Config;
using System.CommandLine;

namespace komp.Commands.Config
{
    public class GetCommand : Command
    {
        private readonly ConfigService _configService;

        public GetCommand(ConfigService configService) 
            : base("get", "Get a Komp configuration")
        {
            _configService = configService;

            AddOption(new KeyOption(true));
        }
    }
}