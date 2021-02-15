using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    class Program
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;
            int result = Sum(myArray, i + 1);

            return myArray[i] + result;

            
        }
        
        static void Main(string[] args)
        {
            int[] myArray = { 12, 1, 90, 2, 100 };

            int result = Sum(myArray);

            Console.WriteLine(result);
        }
    }
}
