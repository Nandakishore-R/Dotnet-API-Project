using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace APIApplication.ValidationAttributes // Make sure the namespace matches your project's namespace
{
    // Custom Validation Attribute for PhoneNumber
    public class PhoneNumberAttribute : ValidationAttribute
    {
        // Constructor that allows you to set a custom error message
        public PhoneNumberAttribute() : base("The phone number is not valid.")
        { }

        // Override the IsValid method to implement custom validation logic
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            var phoneNumber = value.ToString();

            // Check if the phone number is exactly 10 digits long and contains only digits
            if (phoneNumber.Length == 10 && Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                return true;
            }

            return false;
        }
    }
}
