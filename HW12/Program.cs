using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Program
    {
        static void Resize<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            
                newArray[i] = array[i];
            

            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 9, 12 };
            string[] strArray = { "test", "hello", "world" };

            Resize(ref strArray, 10);

            
        }
    }
}