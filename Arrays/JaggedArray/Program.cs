using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] symbs = new char[5][];
            int[][] nums = { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 } };
            char s = 'A';

            for (int i = 0; i < symbs.Length; i++)
            {
                symbs[i] = new char[i + 3];

                for (int k = 0; k < symbs[i].Length; k++)
                {
                    symbs[i][k] = s;
                    s++;
                }
            }

            foreach (char[] item in symbs)
            {
                foreach (char item2 in item)
                {
                    Console.Write("{0,3}", item2);
                }
                Console.WriteLine();
            }
        }
    }
}
