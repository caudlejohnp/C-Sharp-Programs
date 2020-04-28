using System;
using System.Collections.Generic;

namespace SupHeroesVillians
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Alfred Pennywise", "Alfred"));
            people.Add(new SuperHero("Bruce Wayne", "Batman", string.Empty, "Intelligence"));
            people.Add(new Villian("Harvy Dent", string.Empty, "Batman"));
            people.Add(new Person("Mary-Jane Watson", "MJ"));
            people.Add(new SuperHero("Peter Parker", "Spider-Man", string.Empty, "Spider-Sense"));
            people.Add(new Villian("Harry Osborn", string.Empty, "Spider-Man"));
            people.Add(new Person("Beatrice Ross", "Betty"));
            people.Add(new SuperHero("Bruce Banner", "The Hulk", string.Empty, "anger issues"));
            people.Add(new Villian("Thaddeus E. Ross", string.Empty, "The Hulk"));


            foreach ( var person in people)
            {
                Console.WriteLine(person.PrintGreeting());
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string NickName { get; set; }

        public Person(string name, string nickname)
        {
            Name = name;
            NickName = nickname;
        }

        public override string ToString()
        {
            return Name;
        }

        public virtual string PrintGreeting()
        {
            return $"Hello, my name is {Name} but you can call me {NickName}.";
        }
    }

    public class SuperHero : Person
    {
        public string RealName { get; set; }
        public string Superpower { get; set; }

        public SuperHero(string name, string realname, string nickname, string superpower) : base(name, nickname )
        {
            RealName = realname;
            Superpower = superpower;
        }

        public override string PrintGreeting()
        {
            return $"Hello, my name is {Name}. When I am {RealName} my superpower is {Superpower}.";
        }

    }

    public class Villian : Person
    {
        public string Nemesis { get; set; }

        public Villian(string name, string nickname, string nemesis) : base(name, nickname)
        {
            Nemesis = nemesis;
        }

        public override string PrintGreeting()
        {
            return $"I am {Name}. Have you seen {Nemesis}";
        }
    }
}
