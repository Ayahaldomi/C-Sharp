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
        public static void SumAndAverage(double[] Nums)
        {
            double sum = 0;
            foreach (double i in Nums)
            {
                sum += i;
            }
            double average = sum / 10;
            Console.WriteLine($"The sum of 10 numbers is : {sum}");
            Console.WriteLine($"The  of Average of 10 numbers is : {average}");
        }

        public static void CubeOfNumbers(int numCube)
        {
            for (int i = 1; i <= numCube; i++)
            {
                int theCube = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{theCube}");
            }


        }

        public static void YearNewer(int[] years)
        {
            Console.Write("Years greater than 1950 : ");
            for (int i = 1; i < years.Length; i++)
            {

                if (years[i] >= 1950)
                {
                    Console.Write($" {years[i]} ");
                }
            }
        }
        public static void Age(int ageinyears)
        {

            int AgeInDays = ageinyears * 365;
            Console.WriteLine($"Your Age in Days is : {AgeInDays} days. ");
        }
        static void Main(string[] args)
        {
            //1 - Write a function in C# that accept 10 numbers and return sum and average.

            double[] numbers = new double[10];
            Console.Write("Number-1 : "); numbers[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-2 : "); numbers[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-3 : "); numbers[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-4 : "); numbers[3] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-5 : "); numbers[4] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-6 : "); numbers[5] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-7 : "); numbers[6] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-8 : "); numbers[7] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-9 : "); numbers[8] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number-10 : "); numbers[9] = Convert.ToDouble(Console.ReadLine());

            SumAndAverage(numbers);


            ////2 - Write a program in C to display the cube of the number up to given an integer.



            Console.Write("Input number of terms : "); int cube = Convert.ToInt32(Console.ReadLine());

            CubeOfNumbers(cube);

            //3 - Write a program in C# return only numbers in the years array greater than 1950.
            //int[] years = new Year();
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            YearNewer(years);
            Console.WriteLine("");

            //4 - Create a function that takes the age in years and returns the age in days.

            Console.Write("Please enter your Age in YEARS : ");
            int age = (Convert.ToInt32(Console.ReadLine()));

            Age(age);


            //5 - Create class that contain the following field:

            Info person1 = new Info();
            Console.Write("Please enter your Age: ");
            int testAge = Convert.ToInt32(Console.ReadLine());
            while (testAge > 60 || testAge < 18)
            {
                Console.WriteLine("please enter a valid age (18 - 60)");
                testAge = Convert.ToInt32(Console.ReadLine());
            }
            if (testAge <= 60 || testAge >= 18) { person1.Age = testAge; }

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
            }
            if (testPhone.StartsWith("077") || testPhone.StartsWith("078") || testPhone.StartsWith("079"))
            {
                person1.Phone = testPhone;
            }

            person1.InfoView();







        }
    }
}
