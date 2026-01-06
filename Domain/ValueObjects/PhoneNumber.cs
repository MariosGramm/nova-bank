
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public sealed record PhoneNumber
    {
        public string? _value { get; }

        public PhoneNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("Phone number cannot be empty");

            value = value.Trim();

            if (!isPhoneNumberValid(value))
            {
                throw new ArgumentException("Invalid phone number insertion");
            }

            _value = value;
        }

        private static bool isPhoneNumberValid(string value)
        {
            string regEx = "";

            return Regex.IsMatch(value, regEx);
        }

        public override string ToString()
        {
            #pragma warning disable
            return _value;
        }
    }
}
