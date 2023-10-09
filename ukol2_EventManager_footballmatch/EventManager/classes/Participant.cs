
using System;

namespace EventApp.Models

{
    internal abstract class Participant<T>
    {
       
        public string name;
        public string surname;  
        
        public Participant(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public abstract void ShowInfo();
    }
}