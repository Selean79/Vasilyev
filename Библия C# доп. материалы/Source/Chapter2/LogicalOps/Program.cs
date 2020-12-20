using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            if (!(i > 0))
                Console.WriteLine("i == 0");
            else
                Console.WriteLine("i > 0");
            Console.ReadLine();
        }
    }
}
