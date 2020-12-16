using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayDemo
{
    class SortArray
    {
        static void Main(string[] args)
        {
            char s;

            char[] symbs = { 'Q', 'W', 'R', 'T' };

            Console.WriteLine("Array before sorting");

            for (int i = 0; i < symbs.Length; i++)
            {
                Console.Write("| " + symbs[i] + " ");
            }
            Console.WriteLine("|");
            Console.WriteLine();

            for (int k = 0; k < symbs.Length; k++)
            {
                for (int j = 0; j < symbs.Length - 1; j++)
                {
                    if (symbs[j] > symbs[j + 1])
                    {
                        s = symbs[j + 1];
                        symbs[j + 1] = symbs[j];
                        symbs[j] = s;
                    }
                }
            }

            Console.WriteLine("Array after sorting");

            for (int i = 0; i < symbs.Length; i++)
            {
                Console.Write("| " + symbs[i] + " ");
            }
            Console.WriteLine("|");
            Console.WriteLine();

            Console.Read();
        }
    }
}
