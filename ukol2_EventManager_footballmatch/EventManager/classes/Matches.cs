using System;
using EventApp.Models;
using EventApp.Exceptions;

namespace EventApp
{
    internal class Matches
    {
        public string place;
        public string description;

        List <Organisor> organisorList = new List <Organisor>();
        List <Spectator> spectatorList = new List <Spectator>();

        public Matches(string place, string description)
        {
            this.place = place;
            this.description = description;
        }

        public void AddParticipant<T>(Participant<T> participant)
        {
            switch (participant)
            {
                case Spectator spectator:
                    spectatorList.Add(spectator);
                    spectator.ticketStatus = Spectator.TicketStatus.Pending;
                    break;
                case Organisor organisor:
                    organisorList.Add(organisor);
                    break;
                default:
                    throw new IncorrectParticipantObjectException();
            }
        }
        public void RemoveParticipant(string name, string surname)
        {
            if (name == null || surname == null)
            {
                throw new IncorrectNameException();
            }
            try
            {
                Organisor person = organisorList.Find(person => person.name == name && person.surname == surname)!;
                if (person != null)
                {
                    organisorList.Remove(person);
                }
            }
            catch (ArgumentNullException)
            {
                try
                {
                    Spectator person = spectatorList.Find(person => person.name == name && person.surname == surname)!;
                    if (person != null)
                    {
                        spectatorList.Remove(person);
                    }
                }
                catch (ArgumentNullException)
                {
                    throw new ParticipantExcusedException();
                }
            }
        }
        public void ShowSpectators()
        {
            foreach (var spectator in spectatorList)
            {
                spectator.ShowInfo();
            }
        }
        public void ShowOrganisors()
        {
            foreach (var organisor in organisorList)
            {
                organisor.ShowInfo();
            }
        }
    }
}