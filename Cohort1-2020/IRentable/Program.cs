using System;
using System.Collections.Generic;

namespace IRentable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rent = new List<IRentable>();
            rent.Add(new Boat("$100 per hour", "Speed Boat"));
            rent.Add(new Boat("$300 per hour", "50 ft. Yacht"));
            rent.Add(new House("3 Bed, 2 Bath", "$350 per week"));
            rent.Add(new House("2 Bed, 1 Bath", "$200 per week"));
            rent.Add(new Car("Volkswagen Jetta", "$75 per day"));
            rent.Add(new Car("Ford F150", "$125 per day"));

            foreach (var item in rent)
            {
                Console.WriteLine($"{item.GetDescription()} and costs {item.GetRate()}");
            }
        }
    }

    interface IRentable
    {
        string GetRate();
        string GetDescription();
    }

    class Boat : IRentable
    {
        private string rate;
        private string desc;

        public Boat(string rate, string desc)
        {
            this.rate = rate;
            this.desc = desc;
        }

        public string GetDescription()
        {
            return desc;
        }

        public string GetRate()
        {
            return rate;
        }

    }

    class House : IRentable
    {
        private string rate;
        private string desc;

        public House(string desc, string rate)
        {
            this.rate = rate;
            this.desc = desc;
        }

        public string GetDescription()
        {
            return desc;
        }

        public string GetRate()
        {
            return rate;
        }
    }

    class Car : IRentable
    {
        private string rate;
        private string desc;

        public Car(string desc, string rate)
        {
            this.rate = rate;
            this.desc = desc;
        }

        public string GetDescription()
        {
            return desc;
        }

        public string GetRate()
        {
            return rate;
        }
    }

}
