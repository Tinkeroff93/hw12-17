using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    class Program
    {
        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = value;

            for (int i = 0; i < index; i++)
            
                newArray[i] = array[i];
            

            for (int i = index; i < array.Length; i++)
            
                newArray[i + 1] = array[i];
                
            array = newArray;
            
        }

        static void AddFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0);
        }
        
        static void AddLast(ref int[] array, int value)
        {
            Insert(ref array, value, array.Length);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 12, 1, 90, 2 };

            AddLast(ref myArray, -5) ;
        }
    }
}
