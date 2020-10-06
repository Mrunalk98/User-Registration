using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static UserValidation validate = new UserValidation();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
            validate.ValidateName("First Name");
            validate.ValidateName("Last Name");

        }


        //public static void ValidateLastName()
        //{
        //    bool valid = false;
        //    while (!valid)
        //    {
        //        Console.Write("2. Enter Last Name : ");
        //        var firstName = Console.ReadLine();
        //        Regex regex = new Regex(nameRegex);

        //        if (regex.IsMatch(firstName))
        //        {
        //            valid = true;
        //        }
        //        else
        //            Console.WriteLine("Last Name is not valid ! \n");
        //    }
        //}
    }
}
