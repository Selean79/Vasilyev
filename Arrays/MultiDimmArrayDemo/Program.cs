using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimmArrayDemo
{
    class Program   
    {
        static void Main(string[] args)
        {
            char[,,] symbs = new char [4, 3, 5 ];
            char[] s = { 'b', 'D', 'd', 'D' };

            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                Console.WriteLine("Layer {0}", i+1);

                for (int k = 0; k < symbs.GetLength(1); k++)
                {
                   // Console.WriteLine("Layer {0}", k + 1);

                    for (int l = 0; l < symbs.GetLength(2); l++)
                    {
                      //  Console.WriteLine("Layer {0}", l + 1);
                        symbs[i, k, l] = s[i];
                        s[i]++;
                        Console.Write(symbs[i, k,l] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---------");
            }
        }
    }
}
