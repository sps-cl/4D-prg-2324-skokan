using System;

namespace EventApp.Exceptions {

    public class IncorrectParticipantObjectException : Exception {
        public IncorrectParticipantObjectException(string message = "Something go wrong") : base(message) {
        }
    }

}