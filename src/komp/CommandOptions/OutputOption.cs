using System.CommandLine;

namespace komp.CommandOptions
{
    public class OutputOption : Option
    {
        public OutputOption(bool required = false)
            : base(new[] { "-o", "--output" }, "Path where the generated component will be put")
        {
            Required = required;
        }

        public OutputOption(string description, bool required = false)
            : base(new[] { "-o", "--output" }, description)
        {
            Required = required;
        }
    }
}