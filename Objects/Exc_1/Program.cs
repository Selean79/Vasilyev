using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_1
{
    class MyClass
    {
        private char ch;

        public void Method_1(char t)
        {
            ch = t;
            Console.WriteLine("Method_1: " + ch);
        }

        public int Method_2(char t)
        {
            ch = t;
            return (int)ch;
        }

        public void Method_3(char t)
        {
            ch = t;
            Console.WriteLine("Method_3: " +  ch + " and " + (int)ch);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            MyClass ob = new MyClass();

            ob.Method_1('k');
            ob.Method_3('K');
            Console.WriteLine("Method_3: " + (int)ob.Method_2('h'));
        }
    }
}
