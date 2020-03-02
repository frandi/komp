using System.CommandLine;

namespace komp.CommandOptions
{
    public class KeyOption : Option
    {
        public KeyOption(bool required = false)
            : base(new[] { "-k", "--key" }, "Name of the config key")
        {
            Required = required;
        }

        public KeyOption(string description, bool required = false)
            : base(new[] { "-k", "--key" }, description)
        {
            Required = required;
        }
    }
}