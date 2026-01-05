
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public sealed record Lastname
    {
        public string? _value { get; }

        public Lastname(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Last name cannot be empty");

            value = value.Trim();

            if (!isLastnameValid(value))
            {
                throw new ArgumentException("Invalid last name insertion");
            }

            _value = value;
        }

        private static bool isLastnameValid(string value)
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
