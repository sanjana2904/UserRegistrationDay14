using System;
using System.Text.RegularExpressions;
using UserRegistrationDay14;

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

        public bool validateEmail(string name)
        {
            string pattern = @"^[\w]+@[a-zA-Z0-9]+.[a-zA-Z0-9]+";
            bool result = Regex.IsMatch(name, pattern);
            if (!result)
            {
                throw new UserException("Email Name Validation Failed");
            }
            return result;
        }

        public bool validatePhoneNumber(string number)
        {
            string pattern = @"^\d{2}\s\d{10}$";
            bool result = Regex.IsMatch(number, pattern);
            if (!result)
            {
                throw new UserException("Phone Number Name Validation Failed");
            }
            return result;
        }

        public bool validatePassword(string password)
        {
            string pattern = @"^.{8,}$";
            bool result = Regex.IsMatch(password, pattern);
            if (!result)
            {
                throw new UserException("Password Name Validation Failed");
            }
            return result;
        }


        public bool validateUppercase(string uppercase)
        {
            string pattern = @"^(?=.*[A-Z]).{8,}$";
            bool result = Regex.IsMatch(uppercase, pattern);
            if (!result)
            {
                throw new UserException("Uppercase Name Validation Failed");
            }
            return result;
        }

        public bool validateNumericcase(string name)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
            bool result = Regex.IsMatch(name, pattern);
            if (!result)
            {
                throw new UserException("Numeric case Name Validation Failed");
            }
            return result;
        }

        public bool validateSpecialCharactercase(string name)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
            bool result = Regex.IsMatch(name, pattern);
            if (!result)
            {
                throw new UserException("Special Character Validation Failed");
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

            try
            {
                result = program.validateName("sanju@gmail.com");
            }
            catch (UserException)
            {
                Console.WriteLine("Exception caught in Email");
            }

            try
            {
                result = program.validatePhoneNumber("7708796223");
            }
            catch (UserException)
            {
                Console.WriteLine("Exception caught in Phone Number");
            }

            try
            {
                result = program.validatePassword("sanjanaks");
            }
            catch (UserException)
            {
                Console.WriteLine("Exception caught in Password");
            }

            try
            {
                result = program.validateUppercase("sanJanaks");
            }
            catch (UserException)
            {
                Console.WriteLine("Exception caught in Uppercase");
            }


            try
            {
                result = program.validateNumericcase("sanJ5anaks");
            }
            catch (UserException)
            {
                Console.WriteLine("Exception caught in Numeric case");
            }

            try
            {
                result = program.validateSpecialCharactercase("sanJ5*anaks");
            }
            catch (UserException)
            {
                Console.WriteLine("Exception caught in Special character case");
            }



            Console.WriteLine("First name validation result: " + result);
            Console.WriteLine("Email name validation result: " + result);
            Console.WriteLine("Phone Number validation result: " + result);
            Console.WriteLine("Password validation result: " + result);
            Console.WriteLine("Uppercase validation result: " + result);
            Console.WriteLine("Numeric case validation result: " + result);
            Console.WriteLine("Special Character case validation result: " + result);
        }
    }
}
