using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputConsolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Title = "Hello...";
            Console.WriteLine("What is your name?");

            name = Console.ReadLine();

            string txt = "Hello " + name + "!";

            Console.Title = "End";
            Console.WriteLine(txt);
        }
    }
}
