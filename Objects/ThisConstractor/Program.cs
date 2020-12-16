using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisConstractor
{
    class MyClass
    {
        public int alpha;
        public int bravo;

        public MyClass(int a)
        {
            Console.WriteLine("Constructor with one argument");
            alpha = a;
            bravo = a;

            Console.WriteLine("Two fields are equle " + alpha);
        }

        public MyClass(int a, int b) : this(a)
        {
            Console.WriteLine("Constructor with two arguments");
            bravo = b;
            Console.WriteLine("Fields " + alpha + " and " + bravo);
        }

        public MyClass():this(400, 500)
        {
            Console.WriteLine("Constructor without arguments");
            Console.WriteLine("Values " + alpha + " and " + bravo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            Console.WriteLine();

            MyClass B = new MyClass(200, 300);
            Console.WriteLine();

            MyClass C = new MyClass();
        }
    }
}
