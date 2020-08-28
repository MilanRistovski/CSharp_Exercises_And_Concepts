using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharp_Exercises_And_Concepts_Part_1
{
    public partial class Person
    {
        public string Name;
        public DateTime DateOfBirth;
        public FavouriteTeams Teams;
        public List<Person> Children = new List<Person>();
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public (string, DateTime) GetInfo()
        {
            return (Name, DateOfBirth);
        }

        public string SayHello()
        {
            return $"{Name} says Hello";
        }

        public string SayHelloTo(string name)
        {
            return $"{Name} says Hello {name}!";
        }
        public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            return String.Format(format: "command is {0}, number is {1}, active is {2}",
                arg0: command, arg1: number, arg2: active);
        }
        public void PassingParameters(int x, ref int y, out int z)
        {
            z = 99;

            x++;
            y++;
            z++;
        }
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("Impossible to travel back before your birth");
            }
            else
            {
                Console.WriteLine($"Welcome to {when:yyyy}!");
            }
        }
    }

    [Flags]
    public enum FavouriteTeams
    {
        Milan,
        Internazionale,
        Juventus,
        Genoa,
        ManUTD,
        Arsenal,
        Chelsea
    }
    public class BankAccount
    {
        public string AccountName;
        public decimal Balance;
        public static decimal InterestRate;
    }
}
