using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    /// <summary>
    /// Programmer: Tim, Peou
    /// Homework7: Modify DynArray to be able to insert and delete array elements. 
    /// </summary>
    class DynamicArray
    {
        /*Dynamic Array - Unlike traditional array, Dynamic Array allow array to grow
        /Dynamic array data structure has following fields:
        /--------------------------------------------------
        /storage: dynamically allocated space to store data;
        /capacity value: size of the storage;
        /size value: size of the real data.*/


        //Fields

        private int[] storage;

        private int size;

        public DynamicArray()
        {

            storage = new int[6];

            size = 0;
        }

        public DynamicArray(int capacity)
        {
            storage = new int[capacity];
            size = 0;
        }

        //Constructor
        public DynamicArray(int[] array)
        {
            storage = array;
        }

        //Ensure the Array have the capacity
        public void ensureCapacity(int minCapacity)
        {

            int capacity = storage.Length;

            if (minCapacity > capacity)
            {
                int newCapacity = (capacity * 3) / 2 + 1;

                if (newCapacity < minCapacity)

                    newCapacity = minCapacity;

                storage.CopyTo(storage, newCapacity);
            }
        }

        //Display Method
        public void Display(int[] array)
        {
            foreach (int x in array)
            {
                Console.Write("{0,2} ", x);
            }
            Console.WriteLine();
        }

        //Insert Method at Index Location
        public void Insert(int index, int val)
        {
            
            ensureCapacity(size + 1);

            int moveCount = size - index;

            if (moveCount > 0)

                Array.Copy(storage, index, storage, index + 1, moveCount);

            storage[index] = val;
        }

        //Method to remove at Index Location
        public void RemoveAt(int index)
        {
           
            int moveCount = size - index - 1;

            if (moveCount > 0)

                Array.Copy(storage, index, storage, index + 1, moveCount);

            storage[index] = -1;
        }
    }//End Class
}