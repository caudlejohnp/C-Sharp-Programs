using System;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            //work in progress answer 1 only working choice
            Console.WriteLine("Press 1 to access our Drivers information.");
            Console.WriteLine("Press 2 to access our book inventory.");
            Console.WriteLine("Press 3 to access our airplane directory.");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                DriverData();
            }
            if (answer == "2")
            {
                Library();
            }
            if (answer == "3")
            {
                Hanger();
            }
            Console.ReadKey();
        }

        public static void DriverData()
        {
            Driver driver1 = new Driver();
            driver1.firstName = "Harry";
            driver1.lastName = "Dresden";
            driver1.gender = "Male";
            driver1.licenseNumber = 123456;

            Driver driver2 = new Driver();
            driver2.firstName = "Thomas";
            driver2.lastName = "Raith";
            driver2.gender = "Male";
            driver2.licenseNumber = 234567;

            Driver driver3 = new Driver();
            driver3.firstName = "Molly";
            driver3.lastName = "Carpenter";
            driver3.gender = "Female";
            driver3.licenseNumber = 345678;

            Driver driver4 = new Driver();
            driver4.firstName = "Karren";
            driver4.lastName = "Murphy";
            driver4.gender = "Female";
            driver4.licenseNumber = 456789;

            Console.WriteLine($"{driver1.FullName} \n{driver1.gender} \n{driver1.licenseNumber}");
            Console.WriteLine("");
            Console.WriteLine($"{driver2.FullName} \n{driver2.gender} \n{driver2.licenseNumber}");
            Console.WriteLine("");
            Console.WriteLine($"{driver3.FullName} \n{driver3.gender} \n{driver3.licenseNumber}");
            Console.WriteLine("");
            Console.WriteLine($"{driver4.FullName} \n{driver4.gender} \n{driver4.licenseNumber}");
        }

        public static void Library()
        {
            Book book1 = new Book();
            book1.title = "The Blood Mirror";
            book1.author = "Brent Weeks";
            book1.pages = 598;
            book1.sku = 123456789;
            book1.publisher = "Orbit Books";
            book1.price = 16.99;

            Book book2 = new Book();
            book2.title = "Nightlife";
            book2.author = "Rob Thurman";
            book2.pages = 339;
            book2.sku = 234567891;
            book2.publisher = "ROC";
            book2.price = 9.99;

            Book book3 = new Book();
            book3.title = "The Prometheus Deception";
            book3.author = "Robert Ludlum";
            book3.pages = 562;
            book3.sku = 345678912;
            book3.publisher = "St. Martin's Paperbacks";
            book3.price = 9.99;

            Book book4 = new Book();
            book2.title = "The Aeronaut's Windlass";
            book2.author = "Jim Butcher";
            book2.pages = 751;
            book2.sku = 456789123;
            book2.publisher = "ROC";
            book2.price = 9.99;
        }

        public static void Hanger()
        {
            Airplane plane1 = new Airplane();
            plane1.manfacture = "Airbus";
            plane1.model = "A130";
            plane1.variant = "Passenger";
            plane1.seats = 187;
            plane1.numberOfEngines = 2;

            Airplane plane2 = new Airplane();
            plane2.manfacture = "Boeing";
            plane2.model = "737 MAX 10 ";
            plane2.variant = "Passenger";
            plane2.seats = 230;
            plane2.numberOfEngines = 4;

            Airplane plane3 = new Airplane();
            plane3.manfacture = "Dassault Falcon";
            plane3.model = "Falcon 8x";
            plane3.variant = "Private/Corperate";
            plane3.seats = 20;
            plane3.numberOfEngines = 3;

            Airplane plane4 = new Airplane();
            plane4.manfacture = "Gulfstream";
            plane4.model = "G650";
            plane4.variant = "G650ER";
            plane4.seats = 18;
            plane4.numberOfEngines = 2;
        }
    }

    class Driver
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int licenseNumber;
        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
    }

    class Book
    {
        public string title;
        public string author { get; set; }
        public int pages;
        public int sku;
        public string publisher;
        public double price;
    }

    class Airplane
    {
        public string manfacture;
        public string model;
        public string variant;
        public int seats;
        public int numberOfEngines;
    }
}
