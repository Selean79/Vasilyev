using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_10
{
    class MyClass
    {
        private char ch;

        public MyClass(char ch)
        {
            this.ch = ch;
        }

        public static string operator +(MyClass ob1, MyClass ob2)
        {
            char[] charr = { ob1.ch, ob2.ch };
            return new string(charr); 

        }

        public static int operator -(MyClass ob1, MyClass ob2)
        {

            return (int)ob1.ch - (int)ob2.ch;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass('A');
            MyClass ob2 = new MyClass('B');
            Console.WriteLine(ob1 + ob2);
            Console.WriteLine(ob1 - ob2);
        }
    }
}
