using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02_07
{
    internal class Program
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

            public Car(string make, string year, string type, double price, string model, string palletNo, string color)
            {
                this.Make = make;
                this.Year = year;
                this.Type = type;
                this.Price = price;
                this.Model = model;
                this.PalletNo = palletNo;
                this.Color = color;
                // Console.WriteLine($"Car Make is: {Make}, Year is: {Year}, Type is: {Type}, Price is: {Price}, Model is: {Model}, PalletNo is: {PalletNo}, Color is: {Color}.");
            }
            public void DisplayInfo(string make, string year) { Console.WriteLine($"Car make is: {make}, Year is: {year}"); }
            public void DisplayInfo(string make) { Console.WriteLine($"Car make is: {make}."); }
            public virtual void Display() { Console.WriteLine("Welcome Car"); }

        }
        class BMW : Car
        {
            public BMW(string Make, string Year, string Type, double Price, string Model, string PalletNo, string Color)
            : base(Make, Year, Type, Price, Model, PalletNo, Color) { }

            public override void Display() { Console.WriteLine("Welcome BMW"); }
        }
        static void Main(string[] args)
        {
            Car bmw = new BMW("BMW", "2021", "Convertible", 45000.0, "Z4", "PAL127", "Silver");
            bmw.Display();

        }
    }
}

