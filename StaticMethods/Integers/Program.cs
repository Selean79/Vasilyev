using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers
{
    class IntegersNums
    {
  /*      static int IntNums(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n ; i++)
            {
                sum += (i * i);
            }
            return sum;
        }
  */
        static int IntNumsRecurs(int n)
        {
            int i = n;
            int sum = 0;
            
            if(n >= 1)
            {
                sum += (i * i);
                IntNumsRecurs(n - 1);
            }
            
           return sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(IntNumsRecurs(3));
        }
    }
}
