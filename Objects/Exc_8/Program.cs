using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_8
{
    class StaticField
    {
        private static int x = 0;

        public static void ShowField()
        {
            Console.WriteLine("x = {0}", x);
            x++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           // StaticField ob = new StaticField();
            for (int i = 0; i < 10; i++)
            {
                StaticField.ShowField();
            }
        }
    }
}
