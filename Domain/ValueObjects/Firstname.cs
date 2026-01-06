
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public sealed record FirstName
    {
        private const int DefaultLength = 12;
        private FirstName(string value) => _value = value;
        public string _value { get; }

        public static FirstName Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("First name cannot be empty");

            value = value.Trim();

            if (!isFirstNameValid(value))
            {
                throw new ArgumentException("Invalid first name insertion");
            }

            if (value.Length > DefaultLength)
            {
                throw new ArgumentException("First name cannot exceed 12 characters");
            }

            return new FirstName(value);
        }

        private static bool isFirstNameValid(string value)
        {
            string regEx = "^[A-Za-z]+([ '-][A-Za-z]+)*$";

            return Regex.IsMatch(value, regEx);
        }

        public override string ToString()
        {
            #pragma warning disable
            return _value;
        }
    }
}
