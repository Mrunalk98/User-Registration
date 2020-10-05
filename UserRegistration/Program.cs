using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string nameRegex = "^([A-Z][a-z]*).{3,}$";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
            ValidateFirstName();
        }

        public static void ValidateFirstName()
        {
            bool valid = false;
            while(!valid)
            {
                Console.Write("1. Enter First Name : ");
                var firstName = Console.ReadLine();
                Regex regex = new Regex(nameRegex);

                if (regex.IsMatch(firstName))
                {
                    valid = true;
                    ValidateLastName();
                }
                else
                    Console.WriteLine("First Name is not valid ! \n");
            }
        }

        public static void ValidateLastName()
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("2. Enter Last Name : ");
                var firstName = Console.ReadLine();
                Regex regex = new Regex(nameRegex);

                if (regex.IsMatch(firstName))
                {
                    valid = true;
                }
                else
                    Console.WriteLine("Last Name is not valid ! \n");
            }
        }
    }
}
