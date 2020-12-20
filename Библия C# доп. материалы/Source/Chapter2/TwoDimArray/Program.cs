using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3];
            myArray[1, 1] = 10;
            Console.WriteLine(myArray[1,1]);
            Console.ReadLine();
        }
    }
}
