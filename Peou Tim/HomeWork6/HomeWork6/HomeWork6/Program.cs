using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Programmer: Tim Peou
/// HomeWork6:  Modify the Television class to use properties instead of functions.
/// </summary>
/// 
namespace HomeWork6
{
    /// <summary>
    /// Modify the Television class to use properties instead of functions.
    /// The Main function has already been modified to use the new properties
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and Inititialize Television object

            Television tv = new Television();
                        
            if (!tv.IsOn)
            {
                tv.IsOn = true;
            }

            //new object call Channel and Volume methods.

            tv.Channel = 3;

            tv.Volume++;
            tv.Volume++;
            tv.Volume++;
            tv.Volume++;

            //Tv Off

            tv.IsOn = false;

            //Testing Output

            Console.WriteLine("I am currently watching channel {0}", tv.Channel);
            Console.ReadLine();
        }

    }
}

        
    

