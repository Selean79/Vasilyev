using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobleFactorial
{
    class FindDoubleFactorial
    {
        static int DFactorial(int k)
        {
            /*           int f = 1;

                       for (int i = 2; (k - i) >= 2; i = 2 + i)
                       {
                           f *= (k - i);
                       }

                       return k * f;

            */

            int f = 1;

            f = DFactorial(k - 1);

            return f;
        }
        static void Main(string[] args)
        {
            int fac = DFactorial(3);
            Console.WriteLine(fac);
        }
    }
}
