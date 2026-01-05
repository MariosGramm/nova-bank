
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public sealed record Email 
    {
        public string? _value { get; }

        public Email (string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Email cannot be empty");

            value = value.Trim();

            if (!isEmailValid(value))
            {
                throw new ArgumentException("Invalid email insertion");
            }

            _value = value;
        }

        private static bool isEmailValid(string value)
        {
            string regEx = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$\r\n";

            return Regex.IsMatch(value, regEx);
        }

        public override string ToString()
        {
            #pragma warning disable
            return _value;
        }
    }
}
