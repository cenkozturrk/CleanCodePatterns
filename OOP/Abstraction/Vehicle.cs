using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public abstract class Vehicle
    {
        public string Brand
        {
            get; set;
        }
        public string Model
        {
            get; set;
        }

        protected Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public abstract void Start();
        public abstract void Stop();

        public void DisplayInfo()
        {
            string result = $"Vehicle Brand : {Brand}, Model : {Model}";
        }
    }

    public class Car : Vehicle
    {
        public string FuelType
        {
            get; set;
        }

        public Car(string brand, string model, string fuelType) : base(brand, model)
        {
            {
                FuelType = fuelType;
            }
        }
        public override void Start()
        {
            string result = $"The car {Brand} {Model} starts with a key.";
            Console.WriteLine(result);
        }

        public override void Stop()
        {
            string result = $"The car {Brand} {Model} stops by pressing the brake pedal.";
            Console.WriteLine(result);
        }
    }

    public class Truck : Vehicle
    {
        public double LoadCapacity
        {
            get; set;
        }
        public Truck(string brand, string model, double loadCapacity)
         : base(brand, model)
        {
            LoadCapacity = loadCapacity;
        }

        public override void Start()
        {
            string result = $"The truck {Brand} {Model} starts by turning the ignition key.";
            Console.WriteLine(result);
        }

        public override void Stop()
        {
            string result = $"The truck {Brand} {Model} stops by using air brakes.";
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}