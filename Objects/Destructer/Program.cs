using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructer
{
    class MyClass
    {
        private string name;

        public MyClass(string txt)
        {
            name = txt;
            Console.WriteLine("Object has created - {0}", name);
        }

        ~MyClass()
        {
            Console.WriteLine("Object removed - {0}", name);
        }
    }

    class DestructerDemo
    {
        static void Maker(string txt)
        {
            new MyClass(txt);
        }
        static void Main(string[] args)
        {
            MyClass A = new MyClass("First");

            new MyClass("Second");

            A = new MyClass("Therth");

            Maker("Fourth");

            A = new MyClass("Fifth");
        }
    }
}
