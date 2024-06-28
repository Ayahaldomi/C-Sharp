

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace task26_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# program that accept two integers and display the smaller.
            //

            Console.WriteLine("task 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("the smaller number is : "); Console.WriteLine(Math.Min(num1, num2));




            //2.Write a C# conditional statement to find the sign  of input  number. Display sign. Go 
            //•	Sample numbers: -7
            //•	Output: The sign is -

            Console.WriteLine("task 2");
            int number = Convert.ToInt32(Console.ReadLine());
            string sign = number.ToString("+#;-#;0");

            Console.WriteLine(sign[0]);




            //3.Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            //•	Sample numbers: 0, -1, 4
            //•	Output: 4, 0, -1

            Console.WriteLine("task 3");
            int[] ints = { 0, -1, 4 };
            Array.Sort(ints);
            Array.Reverse(ints);
            Console.Write(ints[0]); Console.Write(" "); Console.Write(ints[1]); Console.Write(" "); Console.WriteLine(ints[2]);




            //4.Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            //•	Sample numbers: -5, -2, -6, 0, -1
            //•	Output: 0

            Console.WriteLine("task 4");
            int[] ints1 = { -5, -2, -6, 0, -1 };
            Array.Sort(ints1);
            Array.Reverse(ints1);
            Console.WriteLine(ints1[0]);



            //5.Write a C# program that converts kilometers per hour to miles per hour.  
            //Expected Output:
            //•	Input kilometers per hour: 15.
            //•	9.320568 miles per hour
            Console.WriteLine("task 5");
            Console.Write("Input kilometers per hour: "); int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(kilo * 0.621371 + " miles per hour");




            //6.Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
            //•	Input hours: 5
            //•	Input minutes: 37
            //•	Total: 337 minutes.

            Console.WriteLine("task 6");
            Console.Write("Input hours: "); int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: "); int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total: {hours * 60 + minutes}");



            //7.Write a program in C# that takes minutes as input and display the total number of hours and minutes. 
            //•	Input minutes: 546
            //•	9 Hours, 6 Minutes
            Console.WriteLine("task 7");
            Console.Write("Input minutes: "); int minutes1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{minutes1 / 60} Hours, {minutes1 % 60} Minutes");




            //8.Create string of array that contains 5 element of different sentence with different length.
            //Print all elements with fixed length for each sentence.
            Console.WriteLine("task 8");
            string[] strings = { "my name is ayah", "orange coding ", "irbid is the best", "i love mansef", "i need to sleep" };
            Console.WriteLine(strings[0] + $" >>>The length of this sentence is : {strings[0].Length}");
            Console.WriteLine(strings[1] + $" >>>The length of this sentence is : {strings[1].Length}");
            Console.WriteLine(strings[2] + $" >>>The length of this sentence is : {strings[2].Length}");
            Console.WriteLine(strings[3] + $" >>>The length of this sentence is : {strings[3].Length}");
            Console.WriteLine(strings[4] + $" >>>The length of this sentence is : {strings[4].Length}");

            Console.WriteLine(strings[0].Substring(0, 7));
            Console.WriteLine(strings[1].Substring(0, 7));
            Console.WriteLine(strings[2].Substring(0, 7));
            Console.WriteLine(strings[3].Substring(0, 7));
            Console.WriteLine(strings[4].Substring(0, 7));










        }
    }
}
