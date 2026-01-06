
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public sealed record Firstname
    {
        public string? _value { get; }

        public Firstname(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("First name cannot be empty");

            value = value.Trim();

            if (!isFirstnameValid(value))
            {
                throw new ArgumentException("Invalid first name insertion");
            }

            _value = value;
        }

        private static bool isFirstnameValid(string value)
        {
            string regEx = "^[A - Za - z]+([ '-][A-Za-z]+)*$";

            return Regex.IsMatch(value, regEx);
        }

        public override string ToString()
        {
            #pragma warning disable
            return _value;
        }
    }
}
