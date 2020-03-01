using System.CommandLine;
using System.CommandLine.Invocation;
using komp.Commands;

namespace komp
{
    public class AppService
    {
        public int Run(string[] args)
        {
            var rootCommand = new RootCommand("A simple tooling for your app components");

            rootCommand.AddCommand(new InitCommand());
            rootCommand.AddCommand(new AddCommand());
            rootCommand.AddCommand(new RemoveCommand());
            rootCommand.AddCommand(new AppCommand());

            return rootCommand.Invoke(args);
        }
    }
}