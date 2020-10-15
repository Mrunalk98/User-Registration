using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string namePattern = "^([A-Z][a-z]*).{2,}$";
        static string emailPattern = @"^([a-z0-9][a-z0-9.+_-]*@([a-z0-9]([a-z0-9-]*)?\.)+[a-z0-9]([a-z0-9-]*)?)$";
        static string mobilePattern = "^[\\+]{1}[91]{2}\\s{1}[0-9]{10}$";
        static string passwordPattern = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*(){}<>:;_+=,./?|]).{7,}$";

        static UserValidation validate = new UserValidation();
        static UserAnnotations user = new UserAnnotations();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
            ValidateName();
            ValidateEmail();
            ValidateMobileNumber();
            ValidatePassword();
        }

        public static void ValidateName()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Enter First Name : ");
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
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine("Error Message : " + result.ErrorMessage + "\n");
                }
            }
            return valid;

        }
    }
}
