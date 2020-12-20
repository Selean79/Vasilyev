using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        enum MyColors
        {
            Red = 100,
            Green,
            Blue
        }
        
        static void Main(string[] args)
        {
            MyColors r = MyColors.Red;
            MyColors g = MyColors.Green;
            MyColors b = MyColors.Blue;

            Console.WriteLine((int)r);
            Console.WriteLine((int)g);
            Console.WriteLine((int)b);
            Console.ReadLine();
        }
    }
}
