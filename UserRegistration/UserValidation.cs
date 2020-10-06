using System;
using System.Collections.Generic;
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
                    Console.WriteLine("Enter a valid " + displayText + " ! \n");
            }
        } 
    }
}
