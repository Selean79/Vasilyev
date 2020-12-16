using System;

namespace Exc_3
{
    class MyClass
    {
        int x, k;

        public MyClass()
        {
            Console.WriteLine("No arguments");
        }

        public MyClass(int x, int k)
        {
            this.x = x;
            this.k = k;

            Console.WriteLine("x = {0} / k = {1}", x, k);
        }

        public MyClass(int x)
        {
            this.x = x;
            Console.WriteLine("x = {0}", x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass(5, 6);
        }
    }
}
