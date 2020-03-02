using System.CommandLine;

namespace komp.CommandOptions
{
    public class ValueOption : Option
    {
        public ValueOption(bool required = false)
            : base(new[] { "-v", "--value" }, "Value of the config")
        {
            Required = required;
        }

        public ValueOption(string description, bool required = false)
            : base(new[] { "-v", "--value" }, description)
        {
            Required = required;
        }
    }
}