using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
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
                Regex regex = new Regex("^([A-Z][a-z]*).{3,}$");

                if (regex.IsMatch(firstName))
                {
                    Console.WriteLine("First Name is valid !");
                    valid = true;
                }
                else
                    Console.WriteLine("First Name is not valid !");
            }
        }
    }
}
