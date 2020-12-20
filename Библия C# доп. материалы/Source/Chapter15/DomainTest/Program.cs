using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это внешняя сборка");
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            Console.ReadLine();
            Console.WriteLine("Завершаем работу");
        }
    }
}
