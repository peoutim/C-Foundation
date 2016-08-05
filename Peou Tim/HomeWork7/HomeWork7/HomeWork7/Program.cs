using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    /// <summary>
    /// Programmer: Tim, Peou
    /// Homework7: Modify DynArray to be able to insert and delete array elements. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 10, 20, 30, 40, 50, -1 };

            //Create an instance of DynamicArray Object

            DynamicArray da = new DynamicArray(array);

            //Displaying, inserting an element, and removing an Element 

            Console.WriteLine("Initial Display:");
            da.Display(array);

            Console.WriteLine("Display - After Insertion:");
            da.Insert(2, 22);
            da.Display(array);

            Console.WriteLine("Display - After Removal:");
            da.RemoveAt(3);
            da.Display(array);

            Console.WriteLine();   
            Console.Write("Press Enter...");
            Console.ReadLine();
        }//End Main
    }
}
