using System.Text.RegularExpressions;

namespace Domain.Users.ValueObjects
{
    public sealed record Email 
    {
        public string Value { get; }

        private Email(string value) 
        {
            Value = value;      // validated value 
        }

        public static Email Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Email cannot be empty");

            if (!isEmailValid(value)) throw new ArgumentException("Invalid email format");
            
            return new Email(value);
        }

        private static bool isEmailValid(string value)
        {
            string regEx = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$\r\n";

            return Regex.IsMatch(value, regEx);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
