
using System;

namespace EventApp.Exceptions 
{

    public class IncorrectNameException : Exception 
    {
        public IncorrectNameException(string message = "Incorrect given name") : base(message) 
        {

        }
    }

}