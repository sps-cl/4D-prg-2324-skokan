using System;
using System.Text.RegularExpressions;
using EventApp;
using EventApp.Models;

public class Program
{

    public static void Main(string[] args)
    {
        Matches match = new Matches("Stadion: epet ARÉNA (Praha, Letná)", "AC Sparta Praha - FC Slovan Liberec"); //vytvoření zápasu
        
        Spectator spectator1 = new Spectator ("Pavel", "Omáčka");
        Spectator spectator2 = new Spectator ("Tomáš", "Jedno");
        Spectator spectator3 = new Spectator ("Jáchym", "Stroj");
        Spectator spectator4 = new Spectator ("Karl", "Heinrich");
        Spectator spectator5 = new Spectator("Petr", "Kout");

        Organisor organisor1 = new Organisor ("Karel", "Potok", "security");
        Organisor organisor2 = new Organisor ("Dan", "Janek", "masseur");
        Organisor organisor3 = new Organisor ("Aleš", "Dimitry", "security");
        Organisor organisor4 = new Organisor("Karel", "Nový", "security");

        match.AddParticipant(spectator1);
        match.AddParticipant(spectator2);
        match.AddParticipant(spectator3);
        match.AddParticipant(spectator4);

        match.AddParticipant(organisor1);
        match.AddParticipant(organisor2);
        match.AddParticipant(organisor3);   
        match.AddParticipant(organisor4);

        spectator1.processTicket(true);
        spectator2.processTicket(false);
        spectator3.processTicket(true);             // přidávání účastníků zatím jen ve skryptu


        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Football Match Managaer menu:");
            Console.WriteLine("0. Show match info");
            Console.WriteLine("1. Show spectators list");
            Console.WriteLine("2. Show oranisors list");
            Console.WriteLine("3. Remove spectator1 Karel Potok");
            Console.WriteLine("4. Add spectator5 Petr Kout");
            Console.WriteLine("5. EXIT");

            Console.Write("Choose option (0/1/2/3/4/5) //type number and enter: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.WriteLine(match.ToString());
                    Console.WriteLine("Volba 0 byla zvolena.");
                    Console.ReadLine();
                    break;

                case "1":
                    match.ShowSpectators();
                    Console.WriteLine("Volba 1 byla zvolena.");
                    Console.ReadLine();
                    break;

                case "2":
                    match.ShowOrganisors();
                    Console.WriteLine("Volba 2 byla zvolena.");
                    Console.ReadLine();
                    break;

                case "3":
                    match.RemoveParticipant("Karel", "Potok");    // vyplnění jmena pro odstranění vybraneho ucastnika
                    Console.WriteLine("Participant removed");
                    Console.ReadLine();
                    break;

                case "4":
                    match.AddParticipant(spectator5);    
                    Console.WriteLine("Participant added");
                    Console.ReadLine();
                    break;

                case "5":
                    exit = true;
                    break;             

                default:
                    Console.WriteLine("Wrong!, choose 0/1/2/3/4/5");
                    Console.ReadLine();
                    break;
            }
        }
        
    }

}