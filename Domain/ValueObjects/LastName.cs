
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public sealed record LastName
    {
        private const int DefaultLength = 20;
        private LastName(string value) => _value = value;
        public string _value { get; }

        public static LastName Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("Last name cannot be empty");

            value = value.Trim();

            if (!isLastNameValid(value))
            {
                throw new ArgumentException("Invalid last name insertion");
            }

            if (value.Length > DefaultLength)
            {
                throw new ArgumentException("Last name cannot exceed 20 characters");
            }

            return new LastName(value);
        }

        private static bool isLastNameValid(string value)
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
