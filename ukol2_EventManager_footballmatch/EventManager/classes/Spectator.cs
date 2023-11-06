using System;
using System.Xml.Linq;
using EventApp.Exceptions;

namespace EventApp.Models
{
    internal class Spectator : Participant<Spectator>
    {
        public enum TicketStatus
        {
            Denied, Pending, Accepted, None
        }
        public TicketStatus ticketStatus = TicketStatus.None;
        public Spectator(string name, string surname) : base(name, surname)
        {
        }
        public void processTicket(bool accepted)
        {
            if (ticketStatus != TicketStatus.None)
            {
                if (accepted)
                {
                    ticketStatus = TicketStatus.Accepted;
                }
                else
                {
                    ticketStatus = TicketStatus.Denied;
                }
            }
            else
            {
                throw new InvalidTicketException();
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {name}/ Surname: {surname}/ Ticket: {ticketStatus}");
        }
    }
}