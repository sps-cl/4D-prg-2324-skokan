
using System;

namespace EventApp.Exceptions 
{

    public class MatchNotFoundException : Exception 
    {
        public MatchNotFoundException(string message = "Event not found") : base(message) 
        {

        }
    }

}