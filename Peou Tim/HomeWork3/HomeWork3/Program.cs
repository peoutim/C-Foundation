#region Using Directive
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

/// <summary>
/// Programmer: Peou Tim
/// Homework3 Requirement: Write a Program that takes seconds and converts it into days,
/// hours, minutes, and seconds. 
/// </summary>

namespace HomeWork3
{
    class HomeWork3
    {
        /// <summary>
        /// This Program take seconds and convert to Days, Hours, Minutes.
        /// </summary>
        /// <param name="args">Command-Line Args</param>

        static void Main(string[] args)
        {
            /* Variables Define and initialize */

            long totalSecondInput = 0;
            long secPerDay = 0;
            long secPerHour = 0;
            long secPerMinute = 0;
                   
            // While Loop use to allow user to input value while they are still true

            while (true)
            {
                Console.WriteLine("C# Program convert seconds to Days, Hours, Minutes, Seconds");
                Console.WriteLine("-----------------------------------------------------------");

                // Input from User

                Console.Write("Enter the number of seconds: ");

                //Convert input from user and parse it to long

                totalSecondInput = long.Parse(Console.ReadLine());

                Console.WriteLine("---------------------------------");

                // Calcualtion: Conversion to Days, Hours, Minutes.

                secPerDay = (totalSecondInput / 86400);

                secPerHour = (totalSecondInput / 3600);

                secPerMinute = (totalSecondInput / 60);


                //Print out the Calculation to display days, hours, and minutes.

                Console.WriteLine("{0} days " + ": " + "{1} hours" + ": " +
                                  "{2} minutes", secPerDay, secPerHour, secPerMinute);
               
                Console.WriteLine();
                Console.WriteLine("Press Enter for another input.... ");

                Console.ReadLine();
            }

        }
    }
}
