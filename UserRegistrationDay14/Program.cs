using System;
using System.Text.RegularExpressions;

namespace UserRegistrationDay14
{
    public class Program
    {
        public bool validateName(string name)
        {
            string pattern = @"^[A-Z]\w{2,}$";
            bool result = Regex.IsMatch(name, pattern);
            if (!result)
            {
                throw new UserException("Name Validation Failed");
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("Welcome to unit testing of user registration");
            bool result = false; ;

            Program program = new Program();
            try
            {
                result = program.validateName("Sanjana");
            }
            catch (UserException)
            {
                Console.WriteLine("Exception caught");
            }

            Console.WriteLine("First name validation result: " + result);
        }
    }
}