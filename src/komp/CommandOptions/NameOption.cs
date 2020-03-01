using System.CommandLine;

namespace komp.CommandOptions
{
    public class NameOption : Option
    {
        public NameOption(bool required = false)
            : base(new[] { "-n", "--name" }, "Name of the component")
        {
            Required = required;
        }

        public NameOption(string description, bool required = false)
            : base(new[] { "-n", "--name" }, description)
        {
            Required = required;
        }
    }
}