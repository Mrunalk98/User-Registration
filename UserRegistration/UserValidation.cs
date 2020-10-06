using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {

        public void ValidateField(string displayText, string pattern)
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter " + displayText + " : ");
                var value = Console.ReadLine();
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(value))   
                    valid = true;
                else
                {                    
                    if (displayText == "Password")
                        ValidatePassword(value);
                    else
                        Console.WriteLine("Enter a valid " + displayText + " ! \n");
                }

            }
        } 

        private void ValidatePassword(string value)
        {
            string characters = "^(?=.*[!@#$%^&*(){}<>:;_+=,./?|])";
            Regex regex = new Regex(characters);
            if (value.Length < 8)
                Console.WriteLine("Password must have atleast 8 characters");
            if (!value.Any(char.IsUpper))
                Console.WriteLine("Password must have atleast one uppercase letter");
            if (!value.Any(char.IsLower))
                Console.WriteLine("Password must have atleast one lowercase letter");
            if (!value.Any(char.IsDigit))
                Console.WriteLine("Password must have atleast one digit");
            if (!regex.IsMatch(value))
                Console.WriteLine("Password must have atleast one special character");
        }
    }
}
