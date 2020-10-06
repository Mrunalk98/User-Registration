using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string namePattern = "^([A-Z][a-z]*).{2,}$";
        static string emailPattern = @"^([a-z0-9.+_-]+@(?:[a-z0-9]+?\.)[a-z0-9.]+)$";
        static string mobilePattern = "^[\\+]{1}[91]{2}\\s{1}[0-9]{10}$";
        static string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{7,}$";

        static UserValidation validate = new UserValidation();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
            validate.ValidateField("First Name", namePattern);
            validate.ValidateField("Last Name", namePattern);
            validate.ValidateField("Email ID", emailPattern);
            validate.ValidateField("Mobile Number", mobilePattern);
            validate.ValidateField("Password", passwordPattern);

        }
    }
}
