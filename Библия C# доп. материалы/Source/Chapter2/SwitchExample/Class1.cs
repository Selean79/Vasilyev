using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchExample
{
    public class Class1
    {
        public static void Main()
        {
            int i = 3;

            switch (i)
            {
                case 1:
                    Console.WriteLine("i = 1");
                    break;
                case 2:
                    Console.WriteLine("i = 2");
                    break;
                case 3:
                    Console.WriteLine("i = 3");
                    break;
                default:
                    Console.WriteLine("Что-то непонятное");
                    break;
            }

            Console.ReadLine();
        }
    }
}
