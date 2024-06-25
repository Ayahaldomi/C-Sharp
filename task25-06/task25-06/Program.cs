

using System;

namespace task25_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////task 1 ////////
            //string name = Console.ReadLine();
            //Console.WriteLine(name);

            ///////task2///////////
            //string x = "hi";
            //Console.WriteLine(x);
            //int y = 0;
            //Console.WriteLine(y);
            //Double z = 1.2;
            //Console.WriteLine(z);
            //char c = 'a';
            //Console.WriteLine(c);
            //bool b = true;
            //Console.WriteLine(b);
            //const int a = 1;   
            //Console.WriteLine(a);

            ////////task 3 ////////
            //string[] cars = { "kia", "honda", "volvo" };
            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);
            //Console.WriteLine("cars array Length is : " + cars.Length);

            //////task4//////
            //Console.Write("Input your firstname: "); string firstName =  Console.ReadLine();
            //Console.Write("Input your Lastname: "); string lastName = Console.ReadLine();
            //Console.Write("Input your year of birth: "); string birthYear = Console.ReadLine();
            //Console.WriteLine(firstName + " " + lastName + " " + birthYear);

            //////task 5 ///////
            //Console.WriteLine("Test Data:");
            //Console.WriteLine("input 10 element in the array");

            //var nums = new string[10];
            //Console.Write("element - 0"); nums[0] = Console.ReadLine();
            //Console.Write("element - 1"); nums[1] = Console.ReadLine();
            //Console.Write("element - 2"); nums[2] = Console.ReadLine();
            //Console.Write("element - 3"); nums[3] = Console.ReadLine();
            //Console.Write("element - 4"); nums[4] = Console.ReadLine();
            //Console.Write("element - 5"); nums[5] = Console.ReadLine();
            //Console.Write("element - 6"); nums[6] = Console.ReadLine();
            //Console.Write("element - 7"); nums[7] = Console.ReadLine();
            //Console.Write("element - 8"); nums[8] = Console.ReadLine();
            //Console.Write("element - 9"); nums[9] = Console.ReadLine();
            //Console.Write(nums[0] + nums[1] + nums[2] + nums[3] + nums[4] + nums[5] + nums[6] + nums[7] + nums[8] + nums[9]);

            /////task 6 ////
            var sum = new int[3];
            Console.Write("index-0  "); sum[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("index-1  "); sum[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("index-2  "); sum[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("the sum of numbers is : ");  Console.WriteLine(sum[0] + sum[1] + sum[2]);
                
        }
    }
}
