using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {
        string nameRegex = "^([A-Z][a-z]*).{2,}$";
        
        public void ValidateName(string text)
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter " + text + " : ");
                var name = Console.ReadLine();
                Regex regex = new Regex(nameRegex);
                if (regex.IsMatch(name))
                {
                    valid = true;
                }
                else
                    Console.WriteLine("Enter a valid " + text + " ! \n");
            }
        } 

    }
}
