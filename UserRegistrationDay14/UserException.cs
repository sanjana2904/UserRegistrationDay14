using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationDay14
{
   public class UserException : Exception
    {
        public UserException()
        {

        }
        public UserException(string message)
        : base(message)
        {
        }
    }
}