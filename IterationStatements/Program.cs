using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            int num = 0;

            Console.WriteLine($"Increase: ");
            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                num++;
                // Then add your variable to "numbers"
                numbers.Add(num);
                Console.WriteLine($"{num}");
            } while (num < 100);
            // While your variable is less than 100


            
            // Create a while loop
            while (num < 200)// While your variable is less than 200
            {
                num++; // Increment your variable by 1
                numbers.Add(num);// Then add your variable to "numbers"
                Console.WriteLine($"{num}");
            }

            Console.WriteLine($"increase:");
            foreach (var number in numbers)// Create a foreach loop
            // Write your variable to the console
            { 
            Console.WriteLine($"{number} ");
            }
            Console.WriteLine($"Decrease:");
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                Console.WriteLine(i); // Write to the console "numbers" at index i
            }
        }
    }
}
