using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    /// <summary>
    /// Programmer: Peou Tim
    /// HomeWork4 Requirement: This Program Calculate Factorial from User's Input.
    /// </summary>
    
    class Program
    {
        /// <summary>
        /// Factorial Mathematical Definition:
        /// 0! = 1
        /// N! = N! x N (N-1)! if N > 0
        /// Analysis: Solving task one piece at a time and combine the result. Iteration such as For Loop
        /// keep repeating until a calculation is solved.
        /// Input:  Data type ulong tend to work better than data type integer and long.
        /// Processing: Use For Loop for Factorial Iteration.
        /// Output: Display Factorial.
        /// </summary>
        /// <param name="args">Command-Line Args</param>

        static void Main(string[] args)
        {
            //Declare and initialize variables 

            ulong number;
            ulong i;
            ulong factorial = 1;

            //Console Header Interface

            Console.WriteLine("C# Program to Compute N! Factorial:");
            Console.WriteLine("------------------------------------");

            //Prompt User to enter a Non Negative number. While Loop is use to Validate User's Input.

            while (true)
            {
                Console.Write("\nEnter a Non-Negative Number: ");
                string numberText = Console.ReadLine();

                bool success = ulong.TryParse(numberText, out number);
             
                if (!success)
                   
                    Console.WriteLine("\nPlease Try Again...........");
                else if (number < 0)
                    Console.WriteLine("Enter a Non Negative Number");
                else
                    break;
            }
            
            //Optional Formating

            Console.WriteLine();
            Console.WriteLine("The Factorial of 1! to {0}!", number);
            Console.WriteLine("---------------------------");

            //For Loop is use for interation although a While Loop can also work.

            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;

                Console.WriteLine("{0}!    =       {1}", i, factorial);
            }

            Console.ReadLine();

        }


    }
}

