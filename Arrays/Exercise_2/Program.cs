using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 11;

            int[] intArray = new int[size];
            intArray[0] = 1;

            for (int i = 1,  l = 2; i < intArray.Length; i++, l*=2)
            {

                intArray[i] = l;
            }

            foreach (int k in intArray)
            {
                Console.Write("[{0}] ", k);
            }
            Console.WriteLine('\n');

            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.Write("[{0}] ", intArray[i]);
            }
        }
    }
}
