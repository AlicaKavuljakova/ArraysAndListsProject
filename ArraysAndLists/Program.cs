using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Create an int Array and populate numbers 1-10

            // Create two Lists of type int.
            List<int> evens = new List<int> (); //* Name one List "evens"
            List<int> odds = new List<int>(); ;// * Name the other List "odds"
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }
            }
            Console.WriteLine("Even numbers are :");
            foreach (int num in evens)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Odd numbers are: ");
            foreach (int oddNum in odds)
            {
                Console.WriteLine(oddNum);
            }
        }
    }
}

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
   
