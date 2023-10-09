
using System;

namespace EventApp.Models
{

    internal class Organisor : Participant<Organisor>
    {
        public string position;

        public Organisor(string name, string surname, string position) : base(name, surname)
        {
            this.position = position;
        }

        public override void ShowInfo()
        {   Console.WriteLine($"Name: {name}, Surname: {surname}, Position: {position}");   }

    }

}