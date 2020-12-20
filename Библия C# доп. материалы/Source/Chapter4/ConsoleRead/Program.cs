using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleRead
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Введите строку, чтобы разбить ее на символы:");
            do
            {
                int x = Console.Read();
                ch = Convert.ToChar(x);
                if (x != 13 && x != 10)
                    Console.WriteLine(ch);
            } while (ch != 'q');

            string str;
            Console.WriteLine("Введите строку, я прочитаю ее полностью:");
            do
            {
                str = Console.ReadLine();
                Console.WriteLine(str);
            } while (str != "q");
        }
    }
}
