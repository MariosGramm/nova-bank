
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public sealed record LastName
    {
        public string? _value { get; }

        public LastName(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("Last name cannot be empty");

            value = value.Trim();

            if (!isLastNameValid(value))
            {
                throw new ArgumentException("Invalid last name insertion");
            }

            _value = value;
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
