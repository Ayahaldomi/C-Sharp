using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_06task
{
    internal class numbers
    {
        public double[] Nums = new double[10];

        public void sumAndAverage() 
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
    }
    internal class Cube 
    {
        public int numCube;

        public void CubeOfNumbers() 
        {
            for (int i = 1; i <= numCube; i++)
            {
                int theCube = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{theCube}");
            }

                
        }
    }
    internal class Year
    {
        public int[] years = new int[10];

        public void YearNewer()
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
    }
    internal class Age 
    {
        public int AgeInYears; 

        public Age( int ageinyears)
        {
            AgeInYears= ageinyears;
            int AgeInDays = AgeInYears * 365;
            Console.WriteLine($"Your Age in Days is : {AgeInDays} days. ");
        }

    }

    internal class Info 
    {
        public int Age; 
        public string Gender;
        public string Name;
        public string Email;
        public string ID;
        public string Phone;

        public void InfoView()
        {
            Console.WriteLine($"Age is: {Age}, Gender is: {Gender}, Name is: {Name}, Email is: {Email}, ID is: {ID}, Phone is: {Phone}");
        }
    }
}
