using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace _27_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1 - Correct the syntax error:

            //•	int[] ARR = {1, 7, 9,  45};
            //•	string[] arr2 = {"Str", "alex","moh"};
            //•	string[] arr3= {"the","fox", "over", "lazy", "dog"};



            //2 - What the index of "Banana","Tomato" ?

            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            Console.WriteLine(Array.IndexOf(fruits, "Tomato"));



            //3 - Create an multiple arrays that represents your:
            //•	Favorite Food(5 item)
            //•	Favorite Sport(3 item)
            //•	Favorite Movie(4 item)
            //Then, print each array using foreach, and Loop Through an Array


            Console.WriteLine("MY FAVORITE !!");
            string[] favFood = { "apple", "mango", "banana", "water", "coco" };
            foreach (var food in favFood) { Console.WriteLine(food); }
            string[] favSport = { "soccer", "basketball", "football" };
            foreach (var sport in favSport) { Console.WriteLine(sport); };
            string[] favMovies = { "The First Omen", "Unlocked", "Trigger Warning", "The Hunger Games" };
            foreach (var movies in favMovies) { Console.WriteLine(movies); };


            //4 - Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            //•	Expected Output:
            //•	Input three numbers separated by comma: 5,10,15
            //•	The sum of three numbers: 30.

            Console.Write("Input three numbers separated by comma: ");
            string nums = Console.ReadLine();
            string[] num = nums.Split(',');

            int sum = 0;
            foreach (var i in num)
            {
                int number = int.Parse(i);
                sum += number;
            }
            Console.WriteLine("The sum of three numbers: " + sum);


            //5 - Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            //•	Test Data
            //•	The odd numbers are1 3 5 7 9 11 13 15 17 19……
            //•	The Sum of odd Numbers is: …...


            Console.Write("The odd numbers are1 ");
            for (int i = 1; i <= 100; i += 2)
            {
                if (i == 99)
                {
                    Console.WriteLine(" " + i);
                    continue;
                }
                Console.Write(" " + i);
            }
            int sum1 = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                sum1 += i;
            }
            Console.Write("The Sum of odd Numbers is:");
            Console.WriteLine(sum1);


            //6 - Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
            //The pattern like:
            //   *
            //  **
            // ***
            //****

            int k = 1;
            while (k <= 5)
            {
                int j = 1;
                while (j < k)
                {

                    Console.Write("*");
                    j++;
                }
                k++;
                Console.WriteLine();
            }
            //7 - Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            //The pattern like :

            //     1
            //   2 3
            //  4 5 6
            //7 8 9 10

            int counter = 1;
            for (int i = 1; i < 5; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter++);
                }

                Console.WriteLine(" ");
            }

        }
    }
}
