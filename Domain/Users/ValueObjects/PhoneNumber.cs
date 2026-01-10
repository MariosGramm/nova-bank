using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain.Users.ValueObjects
{
    public sealed record PhoneNumber
    {
        public string Value { get; }

        private PhoneNumber(string value) 
        {
            Value = value; 
        }

        public static PhoneNumber Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Phone number cannot be empty");

            if (!IsPhoneNumberValid(value)) throw new ArgumentException("Invalid phone number format");
           
            return new PhoneNumber(value);
        }

        private static bool IsPhoneNumberValid(string value)
        {
            string regEx = "^\\+[1-9]\\d{1,3}\\d{6,14}$";

            return Regex.IsMatch(value, regEx);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
