using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01_07
{
    public class Car
    {
        //fields 
        private string make;
        private string year;
        private string type;
        private double price;
        private string model;
        private string palletNo;
        private string color;
        //properties
        public string Make { set { make = value; } get { return make; } }
        public string Year { set { year = value; } get { return year; } }
        public string Type { set { type = value; } get { return type; } }
        public double Price { set { price = value; } get { return price; } }
        public string Model { set { model = value; } get { return model; } }
        public string PalletNo { set { palletNo = value; } get { return palletNo; } }
        public string Color { set { color = value; } get { return color; } }

        public Car(string Make, string Year, string Type, double Price, string Model, string PalletNo, string Color)
        {
            this.Make = Make;
            this.Year = Year;
            this.Type = Type;
            this.Price = Price;
            this.Model = Model;
            this.PalletNo = PalletNo;
            this.Color = Color;
            Console.WriteLine($"Car Make is: {Make}, Year is: {Year}, Type is: {Type}, Price is: {Price}, Model is: {Model}, PalletNo is: {PalletNo}, Color is: {Color}.");
        }
        public void Start()
        {
            Console.WriteLine("Starting the Car !");
        }
        public void Stop()
        {
            Console.WriteLine("Stoping the Car !");
        }
    }
    class BMW : Car
    {
        public BMW(string Make, string Year, string Type, double Price, string Model, string PalletNo, string Color)
        : base(Make, Year, Type, Price, Model, PalletNo, Color)
        {
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Car newCar = new Car("Toyota", "2021", "Sedan", 25000.0, "Camry", "PAL123", "Red");
            newCar.Start();
            newCar.Stop();

            BMW bmw = new BMW("BMW", "2021", "Convertible", 45000.0, "Z4", "PAL127", "Silver");
            
            bmw.Start();
            bmw.Stop();
            
        }
    }
}
