using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            char s = 'A';


            char[] charArray = new char[size];

            for (int i = 0; i < charArray.Length; i++)
            {
                switch (s)
                {
                    case 'A':
                        i--;
                        s++;
                      continue;

                    case 'E':
                        i--;
                        s++;
                        continue;

                    case 'I':
                        i--;
                        s++;
                        continue;
                    default:
                        charArray[i] = s;
                        s++;
                        continue;
                }

                

            }

            

            foreach (char k in charArray)
            {
                Console.Write("[{0}] ", k);
            }
            Console.WriteLine('\n');

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                Console.Write("[{0}] ", charArray[i]);
            }
        }
    }
}
