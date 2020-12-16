using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_2
{
    class OutASCII
    {
        char ch1 = 'A';
        char ch2 = 'Q';

        public void CharsOut()
        {
            for (int i = (int)ch1; i <= (int)ch2; i++)
            {
                if (i == (int)ch2)
                {
                    Console.Write("{0}", ch1);
                    break;
                }
                Console.Write("{0}, ", ch1);
                ch1 = (char)(ch1 + 1); 
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OutASCII ob = new OutASCII();
            ob.CharsOut();
            Console.WriteLine();
        }
    }
}
