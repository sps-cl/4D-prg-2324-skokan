
using System;

namespace EventApp.Exceptions 
{

    public class ParticipantExcusedException : Exception 
    {
        public ParticipantExcusedException(string message = " Player is excused from the match  ") : base(message) 
        {

        }
    }

}