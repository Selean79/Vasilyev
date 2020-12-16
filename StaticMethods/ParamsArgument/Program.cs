using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArgument
{
    class ParamsDemo
    {
        static int Sum(params int[] a)
        {
            int res = 0;
            for (int k = 0; k < a.Length; k++)
            {
                res += a[k];
            }
            return res;
        }

        static string GetText(string t, params int[] a)
        {
            string res = "";
            for (int k = 0; k < a.Length; k++)
            {
                res += t[a[k]];
            }
            return res;
        }

        static void Show(int[] a, params  char[] b)
        {
            Console.Write("Numbers {0}: ", a.Length);
            for (int k = 0; k < a.Length - 1; k++)
            {
                Console.Write(a[k] + " ");
            }
            Console.WriteLine("and " + a[a.Length - 1]);

            Console.Write("Chars {0}: ", b.Length);
            for (int k = 0; k < b.Length - 1; k++)
            {
                Console.Write(b[k] + " ");
            }
            Console.WriteLine("and " + b[b.Length - 1]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of numbers: " + Sum(1,6,9,2,4));
            Console.WriteLine("Sum of numbers: " + Sum(1, 1, 1));

            Console.WriteLine(GetText("One Two Three", 0, 10, 8, 1));
            Show(new int[] {1,2,5}, 'A', 'B','C');
        }
    }
}
