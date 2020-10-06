using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string namePattern = "^([A-Z][a-z]*).{2,}$";
        static string emailPattern = @"^([a-z0-9.+_-]*@(?:[a-z0-9]*?\.)[a-z0-9.]+)$";

        static UserValidation validate = new UserValidation();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
            validate.ValidateField("First Name", namePattern);
            validate.ValidateField("Last Name", namePattern);
            validate.ValidateField("Email ID" , emailPattern);

        }
    }
}
