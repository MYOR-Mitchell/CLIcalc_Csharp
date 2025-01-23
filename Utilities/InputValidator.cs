

namespace CalcCLICSharp.Utilities
{
    public class InputValidator
    {
        public bool IsValidOperator(string input)
        {
            return input == "+" || input == "-" || input == "*" || input == "/";
        }
    }
}
