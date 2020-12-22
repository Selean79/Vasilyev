using System;

namespace Exc_5
{
    class MyClass
    {
        private int num;
        private char ch;

        public MyClass(int n, char c)
        {
            num = n;
            ch = c;
        }

        public static bool operator true(MyClass ob)
        {


            if ((ob.num - (int)ob.ch) <= 10)
            {
                return true;
            }
            else
            {
              return  false;
            }
        }

        public static bool operator false(MyClass ob)
        {

            if ((ob.num - (int)ob.ch) <= 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass(120, 'k');

            if (ob!)
            {
                Console.WriteLine("ob is true") ;
            }
            else
            {
                Console.WriteLine("ob is false");
            }
        }
    }
}
