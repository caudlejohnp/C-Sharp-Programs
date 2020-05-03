using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot goodman = new CarLot("Isaac Goodman's Used Cars");   //Creates a list for the car lots inventory
            goodman.AddVehicle(new Car("ABC 1234", "Chevy", "Camero", 25000, 2, "Coupe"));  //adds a new car to the car lot
            goodman.AddVehicle(new Car("ABC 9876", "Dodge", "Challenger", 30000, 2, "Sport"));
            goodman.AddVehicle(new Car("ABC 0258", "Dodge", "Charger", 32000, 4, "Sport"));
            goodman.AddVehicle(new Truck("ABC 8520", "Ford", "F150", 45000, "10 SQ FT."));

            foreach (var car in goodman.GetVehicles())  //Goes through each item in the car lot and prints out the details
            {
                Console.WriteLine(car.PrintDetails());
            }

            CarLot franklyn = new CarLot("Doug Franklyn's Dealership");
            franklyn.AddVehicle(new Car("ZYX 8765", "Toyota", "Camry", 31000, 4, "Sedan"));
            franklyn.AddVehicle(new Car("ZYX 7844", "Toyota", "Corolla", 28000, 4, "Sedan"));
            franklyn.AddVehicle(new Truck("ZYX 1101", "Dodge", "Ranger", 38000, "8.5 SQ FT"));

            foreach ( var car in franklyn.GetVehicles())    //goes through each item in the car lot and prints out the details
            {
                Console.WriteLine(car.PrintDetails());
            }
        }
    }

    abstract class Vehicle  //creates a base class to s
    {
        public string licenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Vehicle(string license, string make, string model, decimal price)
        {
            licenseNumber = license;
            Make = make;
            Model = model;
            Price = price;
        }

        public virtual string PrintDetails()
        {
            return $"The {Make} {Model} with the license plate of {licenseNumber} and cost's ${Price}";
        }
    }

    class Truck : Vehicle
    {
        public string BedSize { get; set; }
        public  Truck (string liscense, string make, string model, decimal price, string bedSize) : base (liscense, make, model,price)
        {
            BedSize = bedSize;
        }

        public override string PrintDetails()
        {
            return $"The {Make} {Model} with the license plate of {licenseNumber}. It has a bed size of {BedSize} and cost's ${Price}";
        }
    }

    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public string Type { get; set; }

        public Car (string license, string make, string model, decimal price, int numOfDoors, string type) : base(license, make, model, price)
        {
            NumberOfDoors = numOfDoors;
            Type = type;
        }

        public override string PrintDetails()
        {
            return $"The {Make} {Model} with the license plaet of {licenseNumber} has {NumberOfDoors} doors. It is a {Type} and costs ${Price}.";
        }
    }

    class CarLot
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        public string Name { get; set; }

        public CarLot(string name)
        {
            Name = name;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }
    }
   
    

}
