using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_06task
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a function in C# that accept 10 numbers and return sum and average.
            //numbers numbers = new numbers();
            //Console.Write("Number-1 : "); numbers.Nums[0] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-2 : "); numbers.Nums[1] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-3 : "); numbers.Nums[2] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-4 : "); numbers.Nums[3] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-5 : "); numbers.Nums[4] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-6 : "); numbers.Nums[5] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-7 : "); numbers.Nums[6] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-8 : "); numbers.Nums[7] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-9 : "); numbers.Nums[8] = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Number-10 : "); numbers.Nums[9] = Convert.ToDouble(Console.ReadLine());

            //numbers.sumAndAverage();


            //2 - Write a program in C to display the cube of the number up to given an integer.
            
            //Cube cube = new Cube();
            //Console.Write("Input number of terms : ");cube.numCube = Convert.ToInt32(Console.ReadLine());

            //cube.CubeOfNumbers();

            //3 - Write a program in C# return only numbers in the years array greater than 1950.
            //Year years = new Year();
            //int[] allYears = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //for (int i = 0; i < allYears.Length; i++) 
            //{
            //    years.years[i] = allYears[i]  ;
            //}
            //years.YearNewer();
            //Console.WriteLine("");

            //4 - Create a function that takes the age in years and returns the age in days.
            
            //Console.Write("Please enter your Age in YEARS : ");
            //Age age = new Age(Convert.ToInt32(Console.ReadLine()));

            //5 - Create class that contain the following field:

            Info person1 = new Info();
            Console.Write("Please enter your Age: ");
            int testAge = Convert.ToInt32(Console.ReadLine());
            while (testAge > 60 || testAge< 18)
            {
                Console.WriteLine("please enter a valid age (18 - 60)");
                testAge = Convert.ToInt32(Console.ReadLine());
            } if (testAge <= 60 || testAge >= 18) { person1.Age = testAge; }
            
            Console.Write("Please enter your Gender: "); person1.Gender = Console.ReadLine();
            Console.Write("Please enter your Name: "); person1.Name = Console.ReadLine();
            Console.Write("Please enter your E-Mail: "); person1.Email = Console.ReadLine();
            Console.Write("Please enter your ID: "); person1.ID = Console.ReadLine();
            
            Console.Write("Please enter your Phone: ");
            string testPhone = Console.ReadLine();
            while (!(testPhone.StartsWith("077") || testPhone.StartsWith("078") || testPhone.StartsWith("079")))
            {
                Console.WriteLine("Please enter a valid Phone number start with (077 / 078 / 079)");
                testPhone = Console.ReadLine();
            }if (testPhone.StartsWith("077") || testPhone.StartsWith("078") || testPhone.StartsWith("079")) 
            {
                person1.Phone = testPhone;
            }

            person1.InfoView();







        }
    }
}
