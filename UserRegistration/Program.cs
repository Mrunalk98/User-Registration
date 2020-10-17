using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static UserValidation validate = new UserValidation();
        static UserAnnotations user = new UserAnnotations();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
            ValidateName();
            ValidateEmail();
            ValidateMobileNumber();
            ValidatePassword();
            Console.WriteLine("\nUser Registration is Successful !");
        }

        public static void ValidateName()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Enter Name : ");
                user.Name = Console.ReadLine();
                isValid = DisplayMessage(isValid);
            }
        }

        public static void ValidateEmail()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Enter Email ID : ");
                user.EmailID = Console.ReadLine();
                isValid = DisplayMessage(isValid);
            }
        }

        public static void ValidateMobileNumber()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Enter Mobile Number : ");
                user.PhoneNumber = Console.ReadLine();
                isValid = DisplayMessage(isValid);
            }
        }

        public static void ValidatePassword()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Enter Password : ");
                user.Password = Console.ReadLine();
                isValid = DisplayMessage(isValid);
            }
        }


        public static bool DisplayMessage(bool valid)
        {
            ValidationContext validation = new ValidationContext(user, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            valid = Validator.TryValidateObject(user, validation, results, true);

            if (!valid)
            {
                    Console.WriteLine("Error Message : " + results[0].ErrorMessage + "\n");
            }
            return valid;

        }
    }
}
