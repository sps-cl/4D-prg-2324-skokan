
using System;

namespace EventApp.Exceptions 
{

    public class InvalidTicketException : Exception 
    {
        public InvalidTicketException(string message = "Ticket not found") : base(message) 
        {
        }
    }

}