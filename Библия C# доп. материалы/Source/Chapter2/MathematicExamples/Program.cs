using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = 2 + 2 * 2;
            Console.WriteLine("result = " + result);

            Console.WriteLine("");

            int i = 1;
            int j = i++;
            Console.WriteLine("j = " + j);
            Console.WriteLine("i = " + i);
            Console.WriteLine("");

            j = ++i;
            Console.WriteLine("j = " + j);
            Console.WriteLine("i = " + i);
            Console.WriteLine("");

            Console.WriteLine("i = " + i++);
            Console.WriteLine("i = " + i++);

            Console.WriteLine("Последнее значение i = " + i);
            i = i++;
            i = i++;
            i = i++;
            i = i++;
            i = i++;
            i = i++;
            Console.WriteLine("После множества изменений i = " + i);

            Console.ReadLine();
        }
    }
}
