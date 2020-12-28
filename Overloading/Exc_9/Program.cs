using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_9
{
    class MyClass
    {
        private int n;

        public MyClass(int x)
        {
            n = x;
        }

        
        public static MyClass operator +(MyClass ob1, MyClass ob2)
        {
            return new MyClass(ob1.n + ob2.n);
        }

        public static MyClass operator -(MyClass ob1, MyClass ob2)
        {
            return new MyClass(ob1.n - ob2.n);
        }

        public static MyClass operator *(MyClass ob1, MyClass ob2)
        {
            return new MyClass(ob1.n * ob2.n);
        }

        public override string ToString()
        {
            string str = "";
            return (str + n);
        }


        /* 
        public static int operator +(MyClass ob1, MyClass ob2)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += (ob1.n + ob2.n);
            }
            return sum;
        }
        */

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(10);
            MyClass ob2 = new MyClass(20);

            //int r = ob1 + ob2;
            // ob1 += ob2;
            // ob1 -= ob2;
            ob1 *= ob2;
            Console.WriteLine(ob1);
        }
    }
}
